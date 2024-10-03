using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using C1.C1Excel;
using System.Globalization;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc
{
    /// <summary>
    /// Clase que exporta grillas de component one a excel.
    /// </summary>
    public class clsExportarExcel
    {
        /// <summary>
        /// Csontructor de la clase que exporta a excel, este no inicializa ninguna variable
        /// </summary>
        public clsExportarExcel() { }

        /// <summary>
        /// esta funcion la usa el exportar rapido para identificar a que columna de datos esta apuntando
        /// </summary>
        /// <param name="grilla"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        private string verDataField(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla,string caption)
        {

            for (int m = 0; m < grilla.Columns.Count; m++)
            {
                if (grilla.Columns[m].Caption.Trim() == caption)
                {
                    return grilla.Columns[m].DataField.Trim();
                }
            }
            return "";
        }
        
        public void exportXlsWeb(DataTable tb,string nombreLibro,string FilePath,
            string nombreArchivo,string webPath,System.Web.HttpResponse r) 
        {
            if(tb == null || FilePath == null || webPath == null || FilePath.Trim() == string.Empty || webPath.Trim() == string.Empty)
                return;


            C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla=new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            grilla.DataSource= tb.DataSet;
            grilla.DataMember = tb.TableName;
            grilla.Splits[0].DisplayColumns.Clear();
            for (int k = 0; k < tb.Columns.Count; k++)
            {
                
                    grilla.Columns.Add(new C1.Win.C1TrueDBGrid.C1DataColumn(tb.Columns[k].Caption, tb.Columns[k].Caption, typeof(string)));
                
            }

            for (int k = 0; k < grilla.Splits[0].DisplayColumns.Count; k++)
            {
                grilla.Splits[0].DisplayColumns[k].Visible = true;
            }

                exportarRapido(grilla, nombreLibro, false, FilePath + "\\" + nombreArchivo);
            r.Redirect(webPath + nombreArchivo,true);
        }

        public void exportarRapido(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla, string nombreLibro, bool abrirArchivo)
        {
            exportarRapido(grilla, nombreLibro, abrirArchivo,"");
        }

        /// <summary>
        /// esta es muy rapida, esta es muy rapida el problema es que no muestra los codigos 
        /// y que exporta todo lo que esta en memoria no le importa lo que tiene en el filtro, esta deberia solo usarse para listados muy grandes
        /// superior a 20000 filas y a 60 columnas, en las pruebas una grilla con 13844 y 60 columnas se demoro 59 segundos con la otra opcion,
        /// con esta se demora unos 15 segundos.
        /// </summary>
        /// <param name="grilla"></param>
        /// <param name="nombreLibro"></param>
        /// <param name="abrirArchivo"></param>
        public void exportarRapido(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla, string nombreLibro, bool abrirArchivo, string pathArchivo) 
        {

            string archivo = "";
            if (pathArchivo == null || pathArchivo == string.Empty)
            {
                System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
                dlg.DefaultExt = "xls";
                dlg.FileName = "*.xls";
                dlg.Filter = "Archivo de Excel|*.xls";
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                archivo = dlg.FileName;
            }else{
                archivo = pathArchivo;
            }

            if (grilla.DataSource == null) return;
            System.Data.DataTable tabla = null;
            if (grilla.DataMember.Trim() == string.Empty)
            {
                tabla = (System.Data.DataTable)grilla.DataSource;
            }else{
                int pos=((System.Data.DataSet)grilla.DataSource).Tables.IndexOf(grilla.DataMember);
                if (pos < 0) return;
                tabla = ((System.Data.DataSet)grilla.DataSource).Tables[pos];
            }
            if (nombreLibro.Trim().Length > 31) nombreLibro = nombreLibro.Substring(0, 31);
            C1.C1Excel.C1XLBook c1XLBook1 = new C1.C1Excel.C1XLBook();
            c1XLBook1.Sheets.Clear();
            if (nombreLibro.Trim() == string.Empty) nombreLibro = "Libro 1";
            c1XLBook1.Sheets.Add(nombreLibro.Trim());
            int columna=0;

            //Agregamos el encabezado de las columnas
            
            for (int l = 0; l < grilla.Splits[0].DisplayColumns.Count; l++)
            {
                if (grilla.Splits[0].DisplayColumns[l].Visible)
                {
                    c1XLBook1.Sheets[0][0, columna++].Value = grilla.Splits[0].DisplayColumns[l].Name;
                }
            }

            for (int k = 1; (k - 1) < tabla.Rows.Count; k++)
            {
                columna = 0;
                for (int l = 0; l < grilla.Splits[0].DisplayColumns.Count; l++)
                {
                    if (grilla.Splits[0].DisplayColumns[l].Visible)
                    {
                        string campo = verDataField(grilla,grilla.Splits[0].DisplayColumns[l].Name.Trim());
                        c1XLBook1.Sheets[0].Columns[columna].Width = 2500;
                        if(tabla.Columns.Contains(campo))
                        c1XLBook1.Sheets[0][k, columna++].Value = tabla.Rows[k - 1][campo].ToString().Replace("True", "Si").Replace("False", "No");
                    }
                }
            }

            c1XLBook1.Save(archivo);
            //
            if (!abrirArchivo) return;

            try
            {
               SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(archivo);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al abrir el archivo \n" + ex.Message);
            }
            System.Media.SystemSounds.Exclamation.Play();
        }

        /// <summary>
        /// Expande la informacion de la grilla
        /// </summary>
        /// <param name="grilla"></param>
        public void expandirGrilla(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla)
        {
            for (int i = 0; i < grilla.Columns.Count; i++)
                grilla.Columns[i].GroupInfo.OutlineMode = C1.Win.C1TrueDBGrid.OutlineModeEnum.StartExpanded;
        }


        /// <summary>
        /// Contrae la Informacion de la grilla
        /// </summary>
        /// <param name="grilla"></param>
        public void contraerGrilla(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla)
        {
            for (int i = 0; i < grilla.Columns.Count; i++)
                grilla.Columns[i].GroupInfo.OutlineMode = C1.Win.C1TrueDBGrid.OutlineModeEnum.StartCollapsed;
        }


        SPXFrmAnimacion.frmEfectoProgreso frAnimacion = new SPXFrmAnimacion.frmEfectoProgreso();
        /// <summary>
        /// Inicia la animacion al exportar a excel.
        /// </summary>
        public void iniciarAnimacion() 
        {
            frAnimacion = new SPXFrmAnimacion.frmEfectoProgreso();
            frAnimacion.Show();
            frAnimacion.animacion();
        }

        /// <summary>
        /// Exporta un archivo excel teniendo en cuenta si el campo es combobox y teambien teniendo en cuenta los filtros activos.
        /// </summary>
        /// <param name="grilla"></param>
        /// <param name="nombreLibro"></param>
        /// <param name="abrirArchivo"></param>
        public void exportar(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla, string nombreLibro, bool abrirArchivo)
        {
            exportar(grilla, nombreLibro, abrirArchivo, null, "");
        }

        public void exportar(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla, string nombreLibro, bool abrirArchivo, System.Drawing.Image logo, string tituloRpt)
        {
            exportar(grilla, nombreLibro, abrirArchivo, null, "", "");
        }

        /// <summary>
        /// Exporta un archivo excel teniendo en cuenta si el campo es combobox y teambien teniendo en cuenta los filtros activos.
        /// </summary>
        /// <param name="grilla"></param>
        /// <param name="nombreLibro"></param>
        /// <param name="abrirArchivo"></param>
        public void exportar(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla, string nombreLibro, bool abrirArchivo,System.Drawing.Image logo, string tituloRpt,string pathArchivo)
        {
            string archivo="";
            if (pathArchivo == null || pathArchivo == string.Empty)
            {
                System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
                dlg.DefaultExt = "xls";
                dlg.FileName = "*.xls";
                dlg.Filter = "Archivo de Excel|*.xls";
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                archivo = dlg.FileName;
            }else{
                archivo = pathArchivo;
            }
            
            if (grilla.Columns.Count <= 0) return;
            
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(iniciarAnimacion));
            hilo.Start();
            if (nombreLibro == null) nombreLibro = "Libro 1";
            if (nombreLibro.Trim().Length > 31) nombreLibro = nombreLibro.Substring(0, 31);
            C1.C1Excel.C1XLBook c1XLBook1 = new C1.C1Excel.C1XLBook();
            c1XLBook1.Sheets.Clear();
            if (nombreLibro.Trim() == string.Empty) nombreLibro = "Libro 1";
            c1XLBook1.Sheets.Add(nombreLibro.Trim());
            int l = 0;
           
            //Agregamos el encabezado de las columnas
            List<string> listaColumnas = new List<string>();
            frAnimacion.total = grilla.Splits[0].DisplayColumns.Count;
            int columna = 0;
            for ( l = 0; l < grilla.Splits[0].DisplayColumns.Count; l++)
            {
                frAnimacion.progeso = l;
                if (grilla.Splits[0].DisplayColumns[l].Visible)
                {
                    c1XLBook1.Sheets[0].Columns[columna].Width = 2500;
                    c1XLBook1.Sheets[0][0, columna++].Value = grilla.Splits[0].DisplayColumns[l].Name.Replace("Programada Por", "Creada Por");
                    listaColumnas.Add(grilla.Splits[0].DisplayColumns[l].DataColumn.DataField.Replace("programadaPor", "creadaPor"));
                }
            }
           
            bool b=false;
            int limiteR = grilla.RowCount;
            frAnimacion.total = limiteR;
            C1.Win.C1TrueDBGrid.C1DataColumn col;
            
            for (int k = 1; (k - 1) < limiteR && frAnimacion.Activo; k++)
            {
                System.Windows.Forms.Application.DoEvents();
                frAnimacion.texto = "Generando " + k + " de " + limiteR;
                frAnimacion.total = limiteR;
                frAnimacion.progeso = k-1;
                for (l = 0; l < listaColumnas.Count; l++)
                {
                        col = grilla.Columns[listaColumnas[l]]; 
                    if (col.DropDown != null)
                    {
                            c1XLBook1.Sheets[0][k, l].Value = grilla.Columns[listaColumnas[l]].CellText(k - 1).ToString();
                    }else if (col.DataType.Name == "Boolean"){

                            if (bool.TryParse(((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString(), out b))
                            {
                                if (b)
                                    c1XLBook1.Sheets[0][k, l].Value = "Si";
                                else
                                    c1XLBook1.Sheets[0][k, l].Value = "No";
                            }else {
                                c1XLBook1.Sheets[0][k, l].Value = "";
                            }
                    }
                    else
                    {

                        object obj = grilla[k - 1];
                        System.Type tipo = obj.GetType();
                        #region creacion del estilo

                        XLStyle style1 = new XLStyle(c1XLBook1);
                        style1.Format = "mm/dd/yyyy hh:mm:ss.000 ";
                        //style1.ForeColor = Color.RoyalBlue 'effective immediately
                        if (col.DataType.Name == "DateTime")
                        {
                            col.NumberFormat = "mm/dd/yyyy hh:mm:ss.000";
                        }
                        #endregion
                        if (tipo.GetProperty(listaColumnas[l]) != null)
                        {
                            if (tipo.GetProperty(listaColumnas[l]).GetValue(obj, null) != null)
                            {
                                try
                                {
                                    #region asigna dependiendo el tipo

                                    if (col.DataType.Name == "DateTime")
                                    {
                                        c1XLBook1.Sheets[0][k, l].Style = style1;
                                        c1XLBook1.Sheets[0][k, l].Value = Convert.ToDateTime(tipo.GetProperty(listaColumnas[l]).GetValue(obj, null).ToString());
                                    }
                                    else if (col.DataType.Name == "Int32")
                                    {
                                        c1XLBook1.Sheets[0][k, l].Value = Convert.ToInt32(tipo.GetProperty(listaColumnas[l]).GetValue(obj, null).ToString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (col.DataType.Name == "Int64")
                                    {
                                        c1XLBook1.Sheets[0][k, l].Value = Convert.ToInt64(tipo.GetProperty(listaColumnas[l]).GetValue(obj, null).ToString(), CultureInfo.InvariantCulture);
                                    }
                                    else if (col.DataType.Name == "Decimal")
                                    {
                                        c1XLBook1.Sheets[0][k, l].Value = Convert.ToDecimal(tipo.GetProperty(listaColumnas[l]).GetValue(obj, null).ToString().Replace(",", ".").Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
                                    }
                                    else if (col.DataType.Name == "Double")
                                    {
                                        c1XLBook1.Sheets[0][k, l].Value = Convert.ToDouble(tipo.GetProperty(listaColumnas[l]).GetValue(obj, null).ToString().Replace(",", ".").Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
                                    }
                                    else //if (col.DataType.Name == "String")
                                    {
                                        c1XLBook1.Sheets[0][k, l].Value = tipo.GetProperty(listaColumnas[l]).GetValue(obj, null).ToString();
                                    }

                                    #endregion
                                }
                                catch (Exception)
                                {
                                    c1XLBook1.Sheets[0][k, l].Value = tipo.GetProperty(listaColumnas[l]).GetValue(obj, null).ToString();
                                }
                            }
                        }
                        else                        {
                            try
                            {
                                #region asigna dependiendo el tipo

                                if (col.DataType.Name == "DateTime")
                                {
                                    // c1XLBook1.Sheets[0][k, l].Value = ((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString();
                                    c1XLBook1.Sheets[0][k, l].Style = style1;
                                    c1XLBook1.Sheets[0][k, l].Value = Convert.ToDateTime(((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString());
                                }
                                else if (col.DataType.Name == "Int32")
                                {
                                    c1XLBook1.Sheets[0][k, l].Value = Convert.ToInt32(((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString(), CultureInfo.InvariantCulture);
                                }
                                else if (col.DataType.Name == "Int64")
                                {
                                    c1XLBook1.Sheets[0][k, l].Value = Convert.ToInt64(((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString(), CultureInfo.InvariantCulture);
                                }
                                else if (col.DataType.Name == "Decimal")
                                {
                                    c1XLBook1.Sheets[0][k, l].Value = Convert.ToDecimal(((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString().Replace(",", ".").Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
                                }
                                else if (col.DataType.Name == "Double")
                                {
                                    c1XLBook1.Sheets[0][k, l].Value = Convert.ToDouble(((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString().Replace(",", ".").Replace(".", System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
                                }

                                else //(col.DataType.Name == "String")
                                {
                                    c1XLBook1.Sheets[0][k, l].Value = ((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString();
                                }

                                #endregion
                            }
                            catch (Exception)
                            {
                                c1XLBook1.Sheets[0][k, l].Value = ((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString();
                            }
                        }
                    }
                }     
            }
           
            frAnimacion.texto = "Creando Archivo de Excel...";
            //agregamos el logo
            if ( logo != null)
            {
                System.Drawing.Bitmap bitmap= new System.Drawing.Bitmap(logo,new System.Drawing.Size(100,100));
                C1.C1Excel.XLRow nuevaFila= new C1.C1Excel.XLRow();
                nuevaFila.Height = 1500;
                c1XLBook1.Sheets[0].Rows.Insert(0, nuevaFila);
                c1XLBook1.Sheets[0][0, 0].Value = bitmap ;
                c1XLBook1.Sheets[0][0, 2].Value =  tituloRpt;
                C1.C1Excel.XLStyle estilo= new C1.C1Excel.XLStyle(c1XLBook1.Sheets[0].Book);
                estilo.Font =new System.Drawing.Font("Arial", 16);
                estilo.AlignHorz = C1.C1Excel.XLAlignHorzEnum.Center;
                estilo.AlignVert = C1.C1Excel.XLAlignVertEnum.Center;
                c1XLBook1.Sheets[0][0, 2].Style = estilo;
                c1XLBook1.Sheets[0].MergedCells.Insert(0, new C1.C1Excel.XLCellRange(0, 0, 0, 1));
                c1XLBook1.Sheets[0].MergedCells.Insert(0, new C1.C1Excel.XLCellRange(0, 0, 2, 5));
            }

            //tw.WriteLine(" 5");
            c1XLBook1.Save(archivo);
            //tw.Close();
            if (abrirArchivo && frAnimacion.Activo)
            {
                frAnimacion.texto = "Abriendo Archivo de Excel...";
                try
                {
                    SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(archivo);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al abrir el archivo \n" + ex.Message);
                }
            }
            frAnimacion.animacionEnd(); 
            System.Media.SystemSounds.Exclamation.Play();
           
        }

        /// <summary>
        /// Exporta un archivo excel teniendo en cuenta si el campo es combobox y teambien teniendo en cuenta los filtros activos.
        /// </summary>
        /// <param name="grilla"></param>
        /// <param name="nombreLibro"></param>
        /// <param name="abrirArchivo"></param>
        public void exportarTxt(C1.Win.C1TrueDBGrid.C1TrueDBGrid grilla, bool abrirArchivo)
        {
            System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
            dlg.DefaultExt = "txt";
            dlg.FileName = "*.txt";
            dlg.Filter = "Archivo de Texto|*.txt";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            if (grilla.Columns.Count <= 0) return;
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(iniciarAnimacion));
            hilo.Start();
            int l = 0;
            string linea = "";
            //Agregamos el encabezado de las columnas
            List<string> listaColumnas = new List<string>();
            frAnimacion.total = grilla.Splits[0].DisplayColumns.Count;
            
            for (l = 0; l < grilla.Splits[0].DisplayColumns.Count; l++)
            {
                frAnimacion.progeso = l;
                if (grilla.Splits[0].DisplayColumns[l].Visible)
                {
                    linea = linea +grilla.Splits[0].DisplayColumns[l].Name+";";
                    listaColumnas.Add(grilla.Splits[0].DisplayColumns[l].DataColumn.DataField);
                }
            }

            System.IO.TextWriter tw=   System.IO.File.CreateText(dlg.FileName);
            tw.WriteLine(linea);
            bool b = false;
            int limiteR = grilla.RowCount;
            frAnimacion.total = limiteR;
            C1.Win.C1TrueDBGrid.C1DataColumn col;

            for (int k = 1; (k - 1) < limiteR && frAnimacion.Activo; k++)
            {
                System.Windows.Forms.Application.DoEvents();
                frAnimacion.texto = "Generando " + k + " de " + limiteR;
                frAnimacion.total = limiteR;
                frAnimacion.progeso = k - 1;
                linea = "";
                for (l = 0; l < listaColumnas.Count; l++)
                {
                    col = grilla.Columns[listaColumnas[l]];
                    if (col.DropDown != null)
                    {
                        linea = linea + grilla.Columns[listaColumnas[l]].CellText(k - 1).ToString() + ";";
                    }
                    else if (col.DataType.Name == "Boolean")
                    {

                        if (bool.TryParse(((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString(), out b))
                        {
                            if (b)
                                linea = linea +  "Si"+ ";";
                            else
                                linea = linea +  "No"+ ";";
                        }
                        else
                        {
                            linea = linea +  ""+ ";";
                        }
                    }
                    else
                    {

                        object obj = grilla[k - 1];
                        System.Type tipo = obj.GetType();
                        if (tipo.GetProperty(listaColumnas[l]) != null)
                        {
                            if (tipo.GetProperty(listaColumnas[l]).GetValue(obj, null) != null)
                            {
                                linea = linea + tipo.GetProperty(listaColumnas[l]).GetValue(obj, null).ToString() + ";";
                            }
                        }else{
                            linea = linea + ((System.Data.DataRowView)grilla[k - 1]).Row[listaColumnas[l]].ToString() + ";";
                        }
                    }
                }
                tw.WriteLine(linea);
            }
            frAnimacion.texto = "Creando Archivo de Texto...";
            tw.Close();

            if (abrirArchivo && frAnimacion.Activo)
            {
                frAnimacion.texto = "Abriendo Archivo...";
                try
                {
                    SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsArchivos.abrirArchivo(dlg.FileName);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al abrir el archivo \n" + ex.Message);
                }
            }
            frAnimacion.animacionEnd();
            System.Media.SystemSounds.Exclamation.Play();

        }


    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using Microsoft.Office.Interop.Excel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

/// <summary>
/// Summary description for clsUtils
/// </summary>
public class clsUtils
{
    public clsUtils()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DateTime generarFecha(string fecha) 
    {
        int ano = 0, mes = 0, dia = 0;
        int.TryParse(fecha.Substring(0, 4), out ano);
        int.TryParse(fecha.Substring(5, 2), out mes);
        int.TryParse(fecha.Substring(8, 2), out dia);
        DateTime fechaRes = new DateTime(ano, mes, dia);
        return fechaRes;
    }

    public void remplazarCampos(string nombreArchivo, SPControladoraDatos.dsCientifica.revision_equiposDataTable revision,System.Web.UI.Page p)
    {
        if (revision[0].Iscod_template_revison_equipoNull()) return;
        SPControladoraDatos.dsCientifica ds = new SPControladoraDatos.dsCientifica();
        ds.EnforceConstraints = false;
        SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter campos = new SPControladoraDatos.dsCientificaTableAdapters.campos_template_revisionTableAdapter();
        SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter archivo = new SPControladoraDatos.dsCientificaTableAdapters.archivo_template_revision_equipoTableAdapter();
        campos.FillBycod_template_revison_equipo(ds.campos_template_revision, revision[0].cod_template_revison_equipo);

           FileStream file = File.OpenRead(nombreArchivo);
        IWorkbook workbook = new  XSSFWorkbook(file);
        List<int> columnas = new List<int>();
        for (int k = 0; k < 30; k++)
        {
            columnas.Add( workbook.GetSheetAt(0).GetColumnWidth(k));
        }

        file.Close();  
        //C1.C1Excel.C1XLBook libro = new C1.C1Excel.C1XLBook();
        GemBox.Spreadsheet.SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        GemBox.Spreadsheet.ExcelFile l2 =GemBox.Spreadsheet.ExcelFile.Load(nombreArchivo);  
        
   
        
       // file.Close();
        //FileStream sww = File.Create(nombreArchivo);
       // workbook.Write(file);
        //sww.Close();
        //file.Close();
        //return;
       //npo NPOI.SS.
//using NPOI.XSSF.UserModel;
        try{

            l2 = GemBox.Spreadsheet.ExcelFile.Load(nombreArchivo);  
            //    libro.Load(nombreArchivo);
        }catch(Exception){
            CGWebUtils.utils.misc.messageBox(p,"El archivo adjuntado inicialmente no es un archivo valido.");
            archivo.DeleteQuery(revision[0].cod_revision_equipos);
            return;
        }

        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        for (int k = 0; k < ds.campos_template_revision.Count; k++)
        {
        
            string value = "";
            object img = null;
            #region asignamos el objeto
            switch (ds.campos_template_revision[k].campo.Trim().ToLower())
            {
                case "asesor recibe":
                    {
                        if (!revision[0].Isresponsable_revisionNull())
                            value = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario = '" + revision[0].responsable_revision + "'").ToString();
                        break;
                    }
                case "firma asesor recibe":
                    {
                        if (!revision[0].Isresponsable_revisionNull())
                            img = bd.ejecutarProcedimiento("select imagen_firma from informacion_adicional_usuario where cod_usuario = '" + revision[0].responsable_revision + "'");
                        break;
                    }

                case "consecutivo":
                    {
                        value = revision[0].cod_revision_equipos.ToString();
                        break;
                    }
                case "equipo nuevo":
                    {
                        if(!revision[0].Isequipo_nuevoNull())
                            value = (revision[0].equipo_nuevo?"X":"");
                        break;
                    }
                case "equipo usuado":
                    {                        
                        if (!revision[0].Isequipo_nuevoNull())
                        {
                            value = ((!revision[0].equipo_nuevo) ? "X" : "");
                        }else{
                            value =  "X" ;
                        }

                        break;
                    }
                case "adecuado":
                    {
                        if (!ds.campos_template_revision[k].IsesBoleanoNull() && ds.campos_template_revision[k].esBoleano)
                        {
                            if (!ds.campos_template_revision[k].IsesNegadoNull() && ds.campos_template_revision[k].esNegado)
                            {
                                if(revision[0].IsadecuadoNull())
                                {
                                    value="";
                                }else{
                                    value = ((revision[0].adecuado) ? "" : "X");
                                }
                            }else {
                                if(revision[0].IsadecuadoNull())
                                {
                                    value="";
                                }else{
                                    value = ((revision[0].adecuado) ? "X" : "");
                                }
                            }
                        }
                        else
                        {
                            if (revision[0].IsadecuadoNull())
                            {
                                value = "";
                            }
                            else
                            {
                                if (revision[0].adecuado)
                                {
                                    value = "Adecuado"; ;
                                }
                            }
                        }

                        break;
                    }
                case "no adecuado":
                    {
                        if (!ds.campos_template_revision[k].IsesBoleanoNull() && ds.campos_template_revision[k].esBoleano)
                        {
                            if (!ds.campos_template_revision[k].IsesNegadoNull() && ds.campos_template_revision[k].esNegado)
                            {
                                if (revision[0].IsadecuadoNull())
                                {
                                    value = "";
                                }
                                else
                                {
                                    value = ((revision[0].adecuado) ? "X" : "");
                                }
                            }
                            else
                            {
                                if (revision[0].IsadecuadoNull())
                                {
                                    value = "";
                                }
                                else
                                {
                                    value = ((revision[0].adecuado) ? "" : "X");
                                }
                            }
                        }
                        else
                        {
                            if (revision[0].IsadecuadoNull())
                            {
                                value = "";
                            }
                            else
                            {
                                if (!revision[0].adecuado)
                                {
                                    value = "No Adecuado"; ;
                                }
                            }
                        }


                        break;
                    }

                case "fabricante":
                    {
                        if (!revision[0].IsserialNull())
                        value = bd.ejecutarProcedimiento("select nombreFabricante from vistaEquipo where serial = '" + revision[0].serial.Trim() + "'").ToString();
                        break;
                    }
                case "fecha creacion":
                    {
                        if (!revision[0].Isfecha_creacionNull())
                        value = revision[0].fecha_creacion.ToShortDateString();
                        break;
                    }
                case "fecha revision":
                    {
                        if (!revision[0].Isfecha_revisionNull())
                        value = revision[0].fecha_revision.ToShortDateString();
                        break;
                    }
                case "fecha aprobacion":
                    {
                        if (!revision[0].Isfecha_aprobacionNull())
                        value = revision[0].fecha_aprobacion.ToShortDateString();
                        break;
                    }
                case "fecha cierre":
                    {
                        if (!revision[0].Isfecha_cierreNull())
                        value = revision[0].fecha_cierre.ToShortDateString();
                        break;
                    }
                case "ingeniero entrega":
                    {
                        if (!revision[0].Isingeniero_entregaNull())
                            value = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario = '" + revision[0].ingeniero_entrega + "'").ToString();
                        break;
                    }
                case "firma ingeniero entrega":
                    {
                        if (!revision[0].Isingeniero_entregaNull())
                            img = bd.ejecutarProcedimiento("select imagen_firma from informacion_adicional_usuario where cod_usuario = '" + revision[0].ingeniero_entrega + "'");
                        break;
                    }
                case "modelos":
                    {
                        if (!revision[0].IsserialNull())
                        value = bd.ejecutarProcedimiento("select nombreModelo from vistaEquipo where serial = '" + revision[0].serial.Trim() + "'").ToString();

                        break;
                    }
                case "nit cliente":
                    {
                        if (!revision[0].Isnit_clienteNull())
                        value = revision[0].nit_cliente;
                        break;
                    }
                case "nombre cliente":
                    {
                        if (!revision[0].Isnit_cliente_nuevoNull())
                            value = bd.ejecutarProcedimiento("select nombreCliente from clientes where nitCliente ='" + revision[0].nit_cliente_nuevo + "'").ToString();

                        break;
                    }
                case "serial":
                    {
                        value = revision[0].serial;
                        break;
                    }
                case "observaciones": { value = revision[0].observaciones; break; }
                case "observaciones iniciales": { value = revision[0].observaciones_iniciales; break; }
                case "usuario creacion":
                    {
                        if (!revision[0].Isusuario_creacionNull())
                            value = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario = '" + revision[0].usuario_creacion + "'").ToString();

                        break;
                    }

                //case "FIRMA":
                //    {
                        
                //            value = bd.ejecutarProcedimiento("select nombre from usuario where cod_usuario = '" + revision[0].usuario_creacion + "'").ToString();

                //        break;
                //    }

            }
            #endregion

            //IRow fila = workbook.GetSheetAt(0).GetRow(ds.campos_template_revision[k].fila - 1);
            //if (fila == null)
            //{
            //    fila = workbook.GetSheetAt(0).CreateRow(ds.campos_template_revision[k].fila - 1);
            //}
            //ICell celda = fila.GetCell(ds.campos_template_revision[k].columna - 1);
            //if (celda == null)
            //{
            //    celda = fila.CreateCell(ds.campos_template_revision[k].fila - 1);
            //}

            if (img == null)
            {
            //    libro.Sheets[0][ds.campos_template_revision[k].fila - 1, ds.campos_template_revision[k].columna - 1].Value = value;
               l2.Worksheets[0].Cells[ds.campos_template_revision[k].fila - 1, ds.campos_template_revision[k].columna - 1].Value = value;
                //celda.SetCellValue(value);
            }
            else
            {
                try
                {   
                    var im=System.Drawing.Image.FromStream(new System.IO.MemoryStream((byte[])img));
                    int maxWidth = 380;
                    int maxHeight = 80;
                    var ratioX = (double)maxWidth / im.Width;
                    var ratioY = (double)maxHeight / im.Height;
                    var ratio = Math.Min(ratioX, ratioY);

                    var newWidth = (int)(im.Width * ratio);
                    var newHeight = (int)(im.Height * ratio);

 

                    MemoryStream memoryStream = new MemoryStream((byte[])img);


                     l2.Worksheets[0].Pictures.Add(memoryStream, GemBox.Spreadsheet.ExcelPictureFormat.Png,
new GemBox.Spreadsheet.AnchorCell(l2.Worksheets[0].Columns[ds.campos_template_revision[k].columna - 1], l2.Worksheets[0].Rows[ds.campos_template_revision[k].fila], true),
newWidth, newHeight, GemBox.Spreadsheet.LengthUnit.Pixel).Position.Mode = GemBox.Spreadsheet.PositioningMode.MoveAndSize;


                }catch(Exception){}
            }
        }

        //ajustamos el ancho
        for(int k=0;k<30;k++){
            if (columnas[k] != 0)
            {
                l2.Worksheets[0].Columns[k].Width = columnas[k];
            }
        }
        //file.Close();
        //FileStream sw = File.Create(nombreArchivo);
        //workbook.Write(file);
        //file.Close();
        //sw.Close();
        l2.Save(nombreArchivo);
        //libro.Save(nombreArchivo);


    }

    public static int LoadImage(string path, IWorkbook wb)
    {
        FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
        byte[] buffer = new byte[file.Length];
        file.Read(buffer, 0, (int)file.Length);
        return wb.AddPicture(buffer, PictureType.JPEG);

    }

    public bool Convertirmuestraerror(string sourcePath, string targetPath, XlFixedFormatType targetType)
    {
        bool result;
        object missing = Type.Missing;
        ApplicationClass application = null;
        Workbook workBook = null;
        //try
        //{
            application = new ApplicationClass();
            object target = targetPath;
            object type = targetType;
            workBook = application.Workbooks.Open(sourcePath, missing, missing, missing, missing, missing,
                               missing, missing, missing, missing, missing, missing, missing, missing, missing);

            workBook.ExportAsFixedFormat(targetType, target, XlFixedFormatQuality.xlQualityStandard, true, false, missing, missing, missing, missing);
            result = true;
        //}
        //catch
        //{
        //    result = false;
        //}
        //finally
        //{
            if (workBook != null)
            {
                workBook.Close(true, missing, missing);
                workBook = null;
            }
            if (application != null)
            {
                application.Quit();
                application = null;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
       // }
        return result;

    }

    public bool Convertir(string sourcePath, string targetPath, XlFixedFormatType targetType)
    {
        /*
         ABC1-DEF2-GHI3-JKL4
         * 
         */
        //C1.C1Excel.C1XLBook libro = new C1.C1Excel.C1XLBook();
        //libro.Load(sourcePath);
        //libro.CompatibilityMode = C1.C1Excel.CompatibilityMode.Excel2003;
        
        //libro.Save(sourcePath, C1.C1Excel.FileFormat.Biff8);

        
        GemBox.Spreadsheet.SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

        
        try
        {
            var c = GemBox.Spreadsheet.ExcelFile.Load(sourcePath);
            c.Protected = true;
            
                
            c.Save(targetPath, GemBox.Spreadsheet.SaveOptions.PdfDefault);
        }catch(Exception){
            return false;
        }
        return true;
        bool result;
        object missing = Type.Missing;
        ApplicationClass application = null;
        Workbook workBook = null;
        try
        {
            application = new ApplicationClass();
            object target = targetPath;
            object type = targetType;
            workBook = application.Workbooks.Open(sourcePath, missing, missing, missing, missing, missing,
                               missing, missing, missing, missing, missing, missing, missing, missing, missing);
            
            workBook.ExportAsFixedFormat(targetType, target, XlFixedFormatQuality.xlQualityStandard, true, false, missing, missing, missing, missing);
            result = true;
        }
        catch(Exception ex)
        {
            
            result = false;
            throw (ex);
        }
        finally
        {
            if (workBook != null)
            {
                workBook.Close(true, missing, missing);
                workBook = null;
            }
            if (application != null)
            {
                application.Quit();
                application = null;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        return result;

    }
}

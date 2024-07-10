using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.IO;
using SPXdata.BD;
using SPControladoraDatos.artefactos.SPXQuery.data;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes    
{
    public partial class frmSeleccionReporte : Form
    {
        public frmSeleccionReporte()
        {
            InitializeComponent();
        }

        public enum TipoCampoRpt {texto,imagen }

        private static List<string> listaCampos;
        private static List<string> listaValores;
        private static List<TipoCampoRpt> listaTipos;

        private static string filtroObligatorio = "";
        public static string FiltroObligatorio { set { filtroObligatorio = value; } get { return filtroObligatorio; } }

        public static void agregarCampoRpt(string campo,string sentencia,TipoCampoRpt tipocampo) 
        {
            if (listaCampos == null)
            {
                listaCampos = new List<string>();
                listaValores = new List<string>();
                listaTipos = new List<TipoCampoRpt>();
            }
            listaCampos.Add(campo);
            listaValores.Add(sentencia);
            listaTipos.Add(tipocampo);
        }

        public void remplazarCampos() 
        {
            remplazarCampos(c1Report1);
       }

        public static void remplazarCampos(C1.C1Report.C1Report rpt)
        {
            if (listaValores == null || listaValores.Count <= 0) return;

            for (int k = 0; k < listaValores.Count; k++)
            {
                try
                {
                   DataConector obj = new DataConector();
                    System.Data.DataSet ds = obj.ejecutarConsulta(listaValores[k]);

                    if (listaTipos[k] == TipoCampoRpt.texto)
                    {
                        string result = "";
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            result = ds.Tables[0].Rows[0][0].ToString();
                        }
                        if (rpt.Fields.Contains(listaCampos[k].Trim()))
                        {
                            rpt.Fields[listaCampos[k].Trim()].Text = result;
                        }
                    }
                    else if (listaTipos[k] == TipoCampoRpt.imagen)
                    {
                        #region zona de imagen
                        byte[] result = null;
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            result = (ds.Tables[0].Rows[0][0] as byte[]);
                        }
                        MemoryStream ms;
                        if (rpt.Fields.Contains(listaCampos[k].Trim()))
                        {
                            rpt.Fields[listaCampos[k].Trim()].PictureScale = C1.C1Report.PictureScaleEnum.Scale;
                            if (result != null)
                            {
                                ms = new MemoryStream(result, 0, result.Length);
                                Image im = Image.FromStream(ms);
                                rpt.Fields[listaCampos[k].Trim()].Picture = im;
                                rpt.Fields[listaCampos[k].Trim()].PictureScale = C1.C1Report.PictureScaleEnum.Scale;
                            }

                        }
                        #endregion

                    }
                }
                catch (Exception)
                { }
            }

        }

        public static void remplazarCampos(C1.C1Report.C1Report rpt,bool desdeWeb)
        {
            if (listaValores == null || listaValores.Count <= 0) return;

            for (int k = 0; k < listaValores.Count; k++)
            {
                try
                {
                   DataConector obj = new DataConector();
                    System.Data.DataSet ds = obj.ejecutarConsulta(listaValores[k]);

                    if (listaTipos[k] == TipoCampoRpt.texto)
                    {
                        string result = "";
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            result = ds.Tables[0].Rows[0][0].ToString();
                        }
                        if (rpt.Fields.Contains(listaCampos[k].Trim()))
                        {
                            rpt.Fields[listaCampos[k].Trim()].Text = result;
                            rpt.Fields[listaCampos[k].Trim()].Visible = false;
                        }
                    }
                    else if (listaTipos[k] == TipoCampoRpt.imagen)
                    {
                        #region zona de imagen
                        byte[] result = null;
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            result = (ds.Tables[0].Rows[0][0] as byte[]);
                        }
                        MemoryStream ms;
                        if (rpt.Fields.Contains(listaCampos[k].Trim()))
                        {
                            rpt.Fields[listaCampos[k].Trim()].PictureScale = C1.C1Report.PictureScaleEnum.Scale;
                            if (result != null)
                            {
                                ms = new MemoryStream(result, 0, result.Length);
                                Image im = Image.FromStream(ms);
                                rpt.Fields[listaCampos[k].Trim()].Picture = im;
                                rpt.Fields[listaCampos[k].Trim()].PictureScale = C1.C1Report.PictureScaleEnum.Scale;
                                if (desdeWeb)
                                    rpt.Fields[listaCampos[k].Trim()].Visible = false;
                            }

                        }
                        #endregion

                    }
                }
                catch (Exception)
                { }
            }

        }


        private void frmSeleccionReporte_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            rptTableAdapter1.Fill(dsSPXQuery2.rpt);
            tipofiltro_query_rptTableAdapter1.Fill(dsSPXQuery1.tipofiltro_query_rpt);
            resetControles();
        }

        #region zona de ajuste de filtros
        
        private void grdRpt_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            if (grdRpt.Columns["cod_rpt"].Text.Trim() != string.Empty)
            {
                rptTableAdapter1.FillBycod_rpt(dsSPXQuery1.rpt,int.Parse(grdRpt.Columns["cod_rpt"].Text));
                //cargamos los filtros
                
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsFiltro1.rpt_parametros, int.Parse(grdRpt.Columns["cod_rpt"].Text));
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsFiltro2.rpt_parametros, int.Parse(grdRpt.Columns["cod_rpt"].Text));
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsFiltro3.rpt_parametros, int.Parse(grdRpt.Columns["cod_rpt"].Text));
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsFiltro4.rpt_parametros,int.Parse(grdRpt.Columns["cod_rpt"].Text));

                rpt_parametrosTableAdapter1.FillBycod_rpt(dsOrden1.rpt_parametros, int.Parse(grdRpt.Columns["cod_rpt"].Text));
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsOrden2.rpt_parametros, int.Parse(grdRpt.Columns["cod_rpt"].Text));
                rpt_parametrosTableAdapter1.FillBycod_rpt(dsOrden3.rpt_parametros, int.Parse(grdRpt.Columns["cod_rpt"].Text));
            } else {
                dsFiltro1.rpt_parametros.Clear();
                dsFiltro2.rpt_parametros.Clear();
                dsFiltro3.rpt_parametros.Clear();
                dsFiltro4.rpt_parametros.Clear();
                dsOrden1.rpt_parametros.Clear();
                dsOrden2.rpt_parametros.Clear();
                dsOrden3.rpt_parametros.Clear();
                 
            }
            resetControles();
            if (dsFiltro1.rpt_parametros.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsFiltro1.rpt_parametros[cmbCampo1.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 1);
            ajustarControles(tipo, 2);
            ajustarControles(tipo, 3);
            ajustarControles(tipo, 4);
        }

        private void ajustarControles(int tipoDatos,int filtro)
        {
            System.Windows.Forms.ComboBox cm=cmbOperador1;

            if (filtro == 2) cm = cmbOperador2;
            else if (filtro == 3) cm = cmbOperador3;
            else if (filtro == 4) cm = cmbOperador4;
            cm.Items.Clear();
            
            cm.Items.Add("Igual");
            if (tipoDatos != 3)
            {
                cm.Items.Add("Menor");
                cm.Items.Add("Mayor");
                cm.Items.Add("Menor o Igual");
                cm.Items.Add("Mayor o Igual");
                cm.Items.Add("Entre");
            }
            cm.Items.Add("Diferente");
            cm.Items.Add("Like");

        }

        private void grdRpt_BeforeRowColChange(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
        {
           
        }

        private void cmbCampo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsFiltro1.rpt_parametros.Rows.Count <= 0) return;
            int tipo = 0;            
            tipo=dsFiltro1.rpt_parametros[cmbCampo1.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo,1);
        }

        private void cmbFiltro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsFiltro2.rpt_parametros.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsFiltro2.rpt_parametros[cmbFiltro2.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 2);
        }

        private void cmbFiltro3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsFiltro3.rpt_parametros.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsFiltro3.rpt_parametros[cmbFiltro3.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 3);
        }

        private void cmbFiltro4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsFiltro4.rpt_parametros.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsFiltro4.rpt_parametros[cmbFiltro4.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 4);
        }

        private void resetControles() 
        {
                lblCal1.Visible = false;
                lblCal2.Visible = false;
                lblCal3.Visible = false;
                lblCal4.Visible = false;
                #region filtro uno
                cal1F1.Visible = false;
                cal2f1.Visible = false;
                txtEntero1F1.Visible = false;
                txtEntero2F1.Visible = false;
                txtFloat1F1.Visible = false;
                txtFloat2F1.Visible = false;
                lblyf1.Visible = false;
                txtFiltro1.Visible = true;
                txtEntero1F1.Text = "";
                txtEntero2F1.Text = "";
                txtFloat1F1.Text="";
                txtFloat2F1.Text = "";
                txtFiltro1.Text = "";
                cal1F1.ValueObject = null;
                cal2f1.ValueObject = null;
#endregion
                #region filtro dos
                cal1F2.Visible = false;
                cal2f2.Visible = false;
                txtEntero1F2.Visible = false;
                txtEntero2F2.Visible = false;
                txtFloat1F2.Visible = false;
                txtFloat2F2.Visible = false;
                lblyf2.Visible = false;
                txtFiltro2.Visible = true;
                txtEntero1F2.Text = "";
                txtEntero2F2.Text = "";
                txtFloat1F2.Text = "";
                txtFloat2F2.Text = "";
                txtFiltro2.Text = "";
                cal1F2.ValueObject = null;
                cal2f2.ValueObject = null;
                #endregion
                #region filtro tres
                cal1F3.Visible = false;
                cal2F3.Visible = false;
                txtEntero1F3.Visible = false;
                txtEntero2F3.Visible = false;
                txtFloat1F3.Visible = false;
                txtFloat2F3.Visible = false;
                lblyf3.Visible = false;
                txtFiltro3.Visible = true;
                txtEntero1F3.Text = "";
                txtEntero2F3.Text = "";
                txtFloat1F3.Text = "";
                txtFloat2F3.Text = "";
                txtFiltro3.Text = "";
                cal1F3.ValueObject = null;
                cal2F3.ValueObject = null;
                #endregion
                #region filtro cuatro
                cal1F4.Visible = false;
                cal2F4.Visible = false;
                txtEntero1F4.Visible = false;
                txtEntero2F4.Visible = false;
                txtFloat1F4.Visible = false;
                txtFloat2F4.Visible = false;
                lblyf4.Visible = false;
                txtFiltro4.Visible = true;
                txtEntero1F4.Text = "";
                txtEntero2F4.Text = "";
                txtFloat1F4.Text = "";
                txtFloat2F4.Text = "";
                txtFiltro4.Text = "";
                cal1F4.ValueObject = null;
                cal2F4.ValueObject = null;
                #endregion
        }

        private void resetControles(int filtro,int tipo,string operador)
        {      
            #region filtro uno
            bool m = false;
            if (operador.ToUpper().Trim() == "ENTRE")
            {
                m = true;
            }

            if (filtro == 1)
            {
                cal1F1.Visible = false;
                cal2f1.Visible = false;
                txtEntero1F1.Visible = false;
                txtEntero2F1.Visible = false;
                txtFloat1F1.Visible = false;
                txtFloat2F1.Visible = false;
                lblyf1.Visible = false;
                lblCal1.Visible = false;
                txtFiltro1.Visible = false;
                if (tipo == 1)
                {
                    txtEntero1F1.Visible = true;
                    if (m)
                    {
                        lblyf1.Visible = true;
                        txtEntero2F1.Visible = true;
                    }
                }
                else if (tipo == 2)
                {
                    txtFloat1F1.Visible = true;
                    if (m)
                    {
                        lblyf1.Visible = true;
                        txtFloat2F1.Visible = true;
                    }
                }
                else if (tipo == 3)
                {
                    txtFiltro1.Visible = true;
                }
                else if (tipo == 4)
                {
                    cal1F1.Visible = true;
                    if (m)
                    {
                        cal2f1.Visible = true;
                        lblCal1.Visible = true;
                    }
                }
            }
            #endregion
            #region filtro dos
            else if (filtro == 2)
            {
                cal1F2.Visible = false;
                cal2f2.Visible = false;
                txtEntero1F2.Visible = false;
                txtEntero2F2.Visible = false;
                txtFloat1F2.Visible = false;
                txtFloat2F2.Visible = false;
                lblyf2.Visible = false;
                lblCal2.Visible = false;
                txtFiltro2.Visible = false;
                if (tipo == 1)
                {
                    txtEntero1F2.Visible = true;
                    if (m)
                    {
                        lblyf2.Visible = true;
                        txtEntero2F2.Visible = true;
                    }
                }
                else if (tipo == 2)
                {
                    txtFloat1F2.Visible = true;
                    if (m)
                    {
                        lblyf2.Visible = true;
                        txtFloat2F2.Visible = true;
                    }
                }
                else if (tipo == 3)
                {
                    txtFiltro2.Visible = true;
                }
                else if (tipo == 4)
                {
                    cal1F2.Visible = true;
                    if (m)
                    {
                        cal2f2.Visible = true;
                        lblCal1.Visible = true;
                    }
                }
            }
            #endregion
            #region filtro tres
            else if (filtro == 3)
            {
                cal1F3.Visible = false;
                cal2F3.Visible = false;
                txtEntero1F3.Visible = false;
                txtEntero2F3.Visible = false;
                txtFloat1F3.Visible = false;
                txtFloat2F3.Visible = false;
                lblyf3.Visible = false;
                lblCal3.Visible = false;
                txtFiltro3.Visible = false;
                if (tipo == 1)
                {
                    txtEntero1F3.Visible = true;
                    if (m)
                    {
                        lblyf3.Visible = true;
                        txtEntero2F3.Visible = true;
                    }
                }
                else if (tipo == 2)
                {
                    txtFloat1F3.Visible = true;
                    if (m)
                    {
                        lblyf3.Visible = true;
                        txtFloat2F3.Visible = true;
                    }
                }
                else if (tipo == 3)
                {
                    txtFiltro3.Visible = true;
                }
                else if (tipo == 4)
                {
                    cal1F3.Visible = true;
                    if (m)
                    {
                        cal2F3.Visible = true;
                        lblCal3.Visible = true;
                    }
                }
            }
            #endregion
            #region filtro cuatro
            else if (filtro == 4)
            {
                cal1F4.Visible = false;
                cal2F4.Visible = false;
                txtEntero1F4.Visible = false;
                txtEntero2F4.Visible = false;
                txtFloat1F4.Visible = false;
                txtFloat2F4.Visible = false;
                lblyf4.Visible = false;
                lblCal4.Visible = false ;
                txtFiltro4.Visible = false;
                if (tipo == 1)
                {
                    txtEntero1F4.Visible = true;
                    if (m)
                    {
                        lblyf4.Visible = true;
                        txtEntero2F4.Visible = true;
                    }
                }
                else if (tipo == 2)
                {
                    txtFloat1F4.Visible = true;
                    if (m)
                    {
                        lblyf4.Visible = true;
                        txtFloat2F4.Visible = true;
                    }
                }
                else if (tipo == 3)
                {
                    txtFiltro4.Visible = true;
                }
                else if (tipo == 4)
                {
                    cal1F4.Visible = true;
                    if (m)
                    {
                        cal2F4.Visible = true;
                        lblCal4.Visible = true;
                    }
                }
            }
            #endregion
        }

        private void txtEntero1F1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar > 20) e.Handled= true; 
        }

        private void txtFloat1F1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar > 20 && e.KeyChar.ToString() != System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator) e.Handled = true;
        }

        private void ajustar(int filtro)
        {
            dsSPXQuery dr = dsFiltro1;
            System.Windows.Forms.ComboBox cm = cmbOperador1;
            if (filtro == 2) { cm = cmbOperador2; dr = dsFiltro2; }
            else if (filtro == 3) { cm = cmbOperador3; dr = dsFiltro3; }
            else if (filtro == 4) { cm = cmbOperador4; dr = dsFiltro4; }
            string operador = cm.Text;
            //
            cm = cmbCampo1;
            if (filtro == 2) { cm = cmbFiltro2; }
            else if (filtro == 3) { cm = cmbFiltro3; }
            else if (filtro == 4) { cm = cmbFiltro4; }
            

            int tipo = dr.rpt_parametros[cm.SelectedIndex].cod_tipo_filtro;
            resetControles(filtro, tipo, operador);
        }

        private void cmbOperador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ajustar(1);
        }

        private void cmbOperador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ajustar(2);
        }

        private void cmbOperador3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ajustar(3);
        }

        private void cmbOperador4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ajustar(4);
        }
        #endregion

        #region zona donde se arma los filtros y los criterios de ordenacion
        /// <summary>
        /// No olvidar antes de invocar este metodo, invokar validarfiltro
        /// </summary>
        /// <param name="numeroFiltro"></param>
        /// <returns></returns>
        string verFiltro(int numeroFiltro) 
        {
            string filtro = "";
            if (numeroFiltro == 1)
            {
                if (!chkFiltro1.Checked) return "";
               
                filtro = cmbCampo1.SelectedValue.ToString();
                
                string op = retornaOperador(cmbOperador1.Text);
                if (op != "LIKE")
                {
                    filtro = filtro.Trim() + " " + op + " " + retornaValores(1);
                }else {
                    filtro = filtro.Trim() + " " + op + " '" + retornaValores(1).Replace("'","")+"%'";
                }
            }else if (numeroFiltro == 2)
            {
                if (!chkFilltro2.Checked) return "";
                
                filtro = cmbFiltro2.SelectedValue.ToString();
                //ahora vamos con la operacion

                string op = retornaOperador(cmbOperador2.Text); if (op != "LIKE")
                    if (op != "LIKE")
                    {
                    filtro = filtro.Trim() + " " + op + " " + retornaValores(2);
                }
                else
                {
                    filtro = filtro.Trim() + " " + op + " '" + retornaValores(2).Replace("'", "") + "%'";
                }
            }
            else if (numeroFiltro == 3)
            {
                if (!chkFiltro3.Checked) return "";
                
                filtro = cmbFiltro3.SelectedValue.ToString();
                //ahora vamos con la operacion

                string op = retornaOperador(cmbOperador3.Text); if (op != "LIKE")
                if (op != "LIKE")
                {
                    filtro = filtro.Trim() + " " + op + " " + retornaValores(3);
                }
                else
                {
                    filtro = filtro.Trim() + " " + op + " '" + retornaValores(3).Replace("'", "") + "%'";
                }
            }
            else if (numeroFiltro == 4)
            {
                if (!chkFiltro4.Checked) return "";
                
                filtro = cmbFiltro4.SelectedValue.ToString();
                //ahora vamos con la operacion

                string op = retornaOperador(cmbOperador4.Text); if (op != "LIKE")
                
                if (op != "LIKE")
                {
                    filtro = filtro.Trim() + " " + op + " " + retornaValores(4);
                }
                else
                {
                    filtro = filtro.Trim() + " " + op + " '" + retornaValores(4).Replace("'", "") + "%'";
                }
            }
            return filtro;
        }

        string retornaValores(int filtro) 
        {
            string rpta = "";
            if (filtro == 1)
            {
                if (txtFiltro1.Visible) { 
                    if (txtFiltro1.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Uno!"); return ""; } 
                    rpta ="'"+ txtFiltro1.Text+"'"; 
                }
                if (txtEntero1F1.Visible) { rpta = txtEntero1F1.Text; if (txtEntero2F1.Visible)rpta += " AND "+txtEntero2F1.Text; }
                if (txtFloat1F1.Visible) { rpta = txtFloat1F1.Text.Replace(",","."); if (txtFloat2F1.Visible)rpta += " AND " + txtFloat2F1.Text.Replace(",","."); }
                if (cal1F1.Visible) { rpta = "'" + cal1F1.Value.Day + "-" + cal1F1.Value.Month + "-" + cal1F1.Value.Year + "'"; if (cal2f1.Visible)rpta += " AND " + "'" + cal2f1.Value.Day + "-" + cal2f1.Value.Month + "-" + cal2f1.Value.Year + "'"; }
            }
            else if (filtro == 2)
            {
                if (txtFiltro2.Visible)
                {
                    if (txtFiltro2.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Dos!"); return ""; }
                    rpta = "'" + txtFiltro2.Text+"'";
                }
                if (txtEntero1F2.Visible) { rpta = txtEntero1F2.Text; if (txtEntero2F2.Visible)rpta += " AND " + txtEntero2F2.Text; }
                if (txtFloat1F2.Visible) { rpta = txtFloat1F2.Text.Replace(",","."); if (txtFloat2F2.Visible)rpta += " AND " + txtFloat2F2.Text.Replace(",","."); }
                if (cal1F2.Visible) { rpta = "'" + cal1F2.Value.Day + "-" + cal1F2.Value.Month + "-" + cal1F2.Value.Year + "'"; if (cal2f2.Visible)rpta += " AND " + "'" + cal2f2.Value.Day + "-" + cal2f2.Value.Month + "-" + cal2f2.Value.Year + "'"; }
            }
            else if (filtro == 3)
            {
                if (txtFiltro3.Visible)
                {
                    if (txtFiltro3.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Tres!"); return ""; }
                    rpta = "'" + txtFiltro3.Text+"'";
                }
                if (txtEntero1F3.Visible) { rpta = txtEntero1F3.Text; if (txtEntero2F3.Visible)rpta += " AND " + txtEntero2F3.Text; }
                if (txtFloat1F3.Visible) { rpta = txtFloat1F3.Text.Replace(",","."); if (txtFloat2F3.Visible)rpta += " AND " + txtFloat2F3.Text.Replace(",","."); }
                if (cal1F3.Visible) { rpta = "'" + cal1F3.Value.Day + "-" + cal1F3.Value.Month + "-" + cal1F3.Value.Year + "'"; if (cal2F3.Visible)rpta += " AND " + "'" + cal2F3.Value.Day + "-" + cal2F3.Value.Month + "-" + cal2F3.Value.Year + "'"; }
            }
            else if (filtro == 4)
            {
                if (txtFiltro4.Visible)
                {
                    if (txtFiltro4.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Cuatro!"); return ""; }
                    rpta = "'" + txtFiltro1.Text+"'";
                }
                if (txtEntero1F4.Visible) { rpta = txtEntero1F4.Text; if (txtEntero2F4.Visible)rpta += " AND " + txtEntero2F4.Text; }
                if (txtFloat1F4.Visible) { rpta = txtFloat1F4.Text.Replace(",","."); if (txtFloat2F4.Visible)rpta += " AND " + txtFloat2F4.Text.Replace(",","."); }
                if (cal1F4.Visible) { rpta = "'" + cal1F4.Value.Day + "-" + cal1F4.Value.Month + "-" + cal1F4.Value.Year + "'"; if (cal2F4.Visible)rpta += " AND " + "'" + cal2F4.Value.Day + "-" + cal2F4.Value.Month + "-" + cal2F4.Value.Year + "'"; }
            }
            if (rpta.Trim().Replace("'", "") == string.Empty)
            {
                MessageBox.Show("Ingrese los Valores para el Filtro "+filtro);
                return "";
            }
            return rpta;
        }

        string retornaOperador(string texto)
        {
            string rpta="";
            if(texto.Trim().ToUpper() == "IGUAL")rpta="=";
            if(texto.Trim().ToUpper() == "MENOR")rpta="<";
            if(texto.Trim().ToUpper() == "MAYOR")rpta=">";
            if(texto.Trim().ToUpper() == "MENOR O IGUAL")rpta="<=";
            if(texto.Trim().ToUpper() == "MAYOR O IGUAL")rpta=">=";
            if(texto.Trim().ToUpper() == "ENTRE")rpta="between ";
            if(texto.Trim().ToUpper() == "DIFERENTE")rpta="!=";
            if (texto.Trim().ToUpper() == "LIKE") rpta = "LIKE";
            return rpta;
        }
              
        string armarFiltros(bool filtroObl) 
        {

            string a = verFiltro(1);
            if(a!= string.Empty)a +=" AND";
            
            string b = verFiltro(2);
            if(b!= string.Empty)b +=" AND";

            string c = verFiltro(3);
            if(c!= string.Empty)c +=" AND";

            string d = verFiltro(4);
            if(d!= string.Empty)d +=" AND";

            string filtro =a+" "+b+" "+c+" "+d;
            if(filtro.Trim() != string.Empty)
            filtro = filtro.Trim().Substring(0,filtro.Trim().Length-3);
            //miramos si tiene un filtro obligatorio y lo agregamos
            if (filtroObl)
            {
                if (filtroObligatorio != string.Empty)
                {
                    if (filtro.Trim() != string.Empty)
                        filtro = "(" + filtro + ") AND " + filtroObligatorio;
                    else
                        filtro = filtroObligatorio;
                }
            }
            return filtro;
        }

        string armarOrden() 
        {
            string a = "";
            if (chkOrden1.Checked && cmbOrden1Estilos.Text =="Ascendente") a += cmbOrden1.SelectedValue.ToString().Trim()+" asc,";
            if (chkOrden1.Checked && cmbOrden1Estilos.Text == "Descendente") a += cmbOrden1.SelectedValue.ToString().Trim() + " desc,";

            if (chkOrden2.Checked && cmbOrden2Estilos.Text == "Ascendente") a += cmbOrden2.SelectedValue.ToString().Trim() + " asc,";
            if (chkOrden2.Checked && cmbOrden2Estilos.Text == "Descendente") a += cmbOrden2.SelectedValue.ToString().Trim() + " desc,";

            if (chkOrden3.Checked && cmbOrden3Estilos.Text == "Ascendente") a += cmbOrden3.SelectedValue.ToString().Trim() + " asc,";
            if (chkOrden3.Checked && cmbOrden3Estilos.Text == "Descendente") a += cmbOrden3.SelectedValue.ToString().Trim() + " desc,";
            if (a.Length > 0) { a = " ORDER BY " + a.Substring(0, a.Length - 1); }
            return a;
        }

        string armarOrden(int orden)
        {
            string a = "";
            if (orden == 1)
            {
                if (chkOrden1.Checked && cmbOrden1Estilos.Text == "Ascendente") a += cmbOrden1.SelectedValue.ToString().Trim() + " asc,";
                if (chkOrden1.Checked && cmbOrden1Estilos.Text == "Descendente") a += cmbOrden1.SelectedValue.ToString().Trim() + " desc,";
            }
            if (orden == 2)
            {
                if (chkOrden2.Checked && cmbOrden2Estilos.Text == "Ascendente") a += cmbOrden2.SelectedValue.ToString().Trim() + " asc,";
                if (chkOrden2.Checked && cmbOrden2Estilos.Text == "Descendente") a += cmbOrden2.SelectedValue.ToString().Trim() + " desc,";
            }
            if (orden == 3)
            {
                if (chkOrden3.Checked && cmbOrden3Estilos.Text == "Ascendente") a += cmbOrden3.SelectedValue.ToString().Trim() + " asc,";
                if (chkOrden3.Checked && cmbOrden3Estilos.Text == "Descendente") a += cmbOrden3.SelectedValue.ToString().Trim() + " desc,";
            }
                if (a.Length > 0) { a = a.Substring(0, a.Length - 1); }
            return a;
        }
        #endregion
 
        #region zona de validacion
        bool validarFiltros(bool filtroObl)
        {
            bool res= validarFiltro(1);
            if (res) res = validarFiltro(2);
            if (res) res = validarFiltro(3);
            if (res) res = validarFiltro(4);

            if (res) res = validarValores(1);
            if (res) res = validarValores(2);
            if (res) res = validarValores(3);
            if (res) res = validarValores(4);

            return res;
        }

        bool validarValores(int filtro)
        {
            bool rpta = false;
            if (filtro == 1)
            {
                if (txtFiltro1.Visible)
                {
                    if (txtFiltro1.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Uno!"); return false; }
                }
                if (txtEntero1F1.Visible)
                {
                    if (txtEntero1F1.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Uno!"); return false; }
                }
                if (txtEntero2F1.Visible)
                {
                    if (txtEntero2F1.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Segundo Valor para el filtro Uno!"); return false; }
                }
                if (txtFloat1F1.Visible)
                {
                    if (txtFloat1F1.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Uno!"); return false; }
                }
                if (txtFloat2F1.Visible)
                {
                    if (txtFloat2F1.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Segundo Valor para el filtro Dos!"); return false; }
                }
                if (cal1F1.Visible)
                {
                    if (cal1F1.ValueObject == null) { MessageBox.Show("Ingrese Una fecha valida para el filtro Uno!"); return false; }
                }
                if (cal2f1.Visible)
                {
                    if (cal2f1.ValueObject == null) { MessageBox.Show("Ingrese Una fecha valida para el filtro Uno!"); return false; }
                }
                return true;
            }
            else if (filtro == 2)
            {
                if (txtFiltro2.Visible)
                {
                    if (txtFiltro2.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Dos!"); return false; }
                }
                if (txtEntero1F2.Visible)
                {
                    if (txtEntero1F2.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Dos!"); return false; }
                }
                if (txtEntero2F2.Visible)
                {
                    if (txtEntero2F2.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Segundo Valor para el filtro Dos!"); return false; }
                }
                if (txtFloat1F2.Visible)
                {
                    if (txtFloat1F2.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Dos!"); return false; }
                }
                if (txtFloat2F2.Visible)
                {
                    if (txtFloat2F2.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Segundo Valor para el filtro Dos!"); return false; }
                }
                if (cal1F2.Visible)
                {
                    if (cal1F2.ValueObject == null) { MessageBox.Show("Ingrese Una fecha valida para el filtro Dos!"); return false; }
                }
                if (cal2f2.Visible)
                {
                    if (cal2f2.ValueObject == null) { MessageBox.Show("Ingrese Una fecha valida para el filtro Dos!"); return false; }
                }
                return true;
            }
            else if (filtro == 3)
            {
                if (txtFiltro3.Visible)
                {
                    if (txtFiltro3.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Tres!"); return false; }
                }
                if (txtEntero1F3.Visible)
                {
                    if (txtEntero1F3.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Tres!"); return false; }
                }
                if (txtEntero2F3.Visible)
                {
                    if (txtEntero2F3.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Segundo Valor para el filtro Tres!"); return false; }
                }
                if (txtFloat1F3.Visible)
                {
                    if (txtFloat1F3.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Tres!"); return false; }
                }
                if (txtFloat2F3.Visible)
                {
                    if (txtFloat2F3.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Segundo Valor para el filtro Tres!"); return false; }
                }
                if (cal1F3.Visible)
                {
                    if (cal1F3.ValueObject == null) { MessageBox.Show("Ingrese Una fecha valida para el filtro Tres!"); return false; }
                }
                if (cal2F3.Visible)
                {
                    if (cal2F3.ValueObject == null) { MessageBox.Show("Ingrese Una fecha valida para el filtro Tres!"); return false; }
                }
                return true;
            }
            else if (filtro == 4)
            {
                if (txtFiltro4.Visible)
                {
                    if (txtFiltro4.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Cuatro!"); return false; }
                }
                if (txtEntero1F4.Visible)
                {
                    if (txtEntero1F4.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Cuatro!"); return false; }
                }
                if (txtEntero2F4.Visible)
                {
                    if (txtEntero2F4.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Segundo Valor para el filtro Cuatro!"); return false; }
                }
                if (txtFloat1F4.Visible)
                {
                    if (txtFloat1F4.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Cuatro!"); return false; }
                }
                if (txtFloat2F4.Visible)
                {
                    if (txtFloat2F4.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Segundo Valor para el filtro Cuatro!"); return false; }
                }
                if (cal1F4.Visible)
                {
                    if (cal1F4.ValueObject == null) { MessageBox.Show("Ingrese Una fecha valida para el filtro Cuatro!"); return false; }
                }
                if (cal2F4.Visible)
                {
                    if (cal2F4.ValueObject == null) { MessageBox.Show("Ingrese Una fecha valida para el filtro Cuatro!"); return false; }
                }
                return true;
            }
            
            return rpta;
        }

        private bool validarFiltro(int numeroFiltro)
        {
            if (numeroFiltro == 1)
            {
                if (!chkFiltro1.Checked) return true;
                if (cmbCampo1.SelectedValue == null || cmbCampo1.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga el campo para el filtro uno");
                    return false;
                }
                if (cmbOperador1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga el operador para el filtro uno");
                    return false;
                }
              //  if(!validarOperador(cmbOperador1.Text))return false;
            }
            else if (numeroFiltro == 2)
            {
                if (!chkFilltro2.Checked) return true;
                if (cmbFiltro2.SelectedValue == null || cmbFiltro2.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga el campo para el filtro dos");
                    return false;
                }
                //ahora vamos con la operacion
                if (cmbOperador2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga el operador para el filtro dos");
                    return false;
                }
            }
            else if (numeroFiltro == 3)
            {
                if (!chkFiltro3.Checked) return true;
                if (cmbFiltro3.SelectedValue == null || cmbFiltro3.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga el campo para el filtro tres");
                    return false;
                }
                if (cmbOperador3.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga el operador para el filtro tres");
                    return false;
                }
             }
            else if (numeroFiltro == 4)
            {
                if (!chkFiltro4.Checked) return true;
                if (cmbFiltro4.SelectedValue == null || cmbFiltro4.SelectedValue.ToString().Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga el campo para el filtro cuatro");
                    return false;
                }
                if (cmbOperador4.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Escoga el operador para el filtro cuatro");
                    return false;
                }
            }
            return true;
        }

        private bool validar() 
        {
            //validamos que no halla orden repetido
            if (chkOrden1.Checked && chkOrden2.Checked)
            {
                if (cmbOrden1.Text.Trim() == cmbOrden2.Text.Trim())
                {
                    MessageBox.Show("No puede ordenar dos veces por el mismo campo, criterio de orden uno igual al dos");
                    return false;
                }
            }
            if (chkOrden1.Checked && chkOrden3.Checked)
            {
                if (cmbOrden1.Text.Trim() == cmbOrden3.Text.Trim())
                {
                    MessageBox.Show("No puede ordenar dos veces por el mismo campo, criterio de orden uno igual al tres");
                    return false;
                }
            }
            if (chkOrden3.Checked && chkOrden2.Checked)
            {
                if (cmbOrden3.Text.Trim() == cmbOrden2.Text.Trim())
                {
                    MessageBox.Show("No puede ordenar dos veces por el mismo campo, criterio de orden dos igual al tres");
                    return false;
                }
            }
            return true;
        }
        #endregion    
   
        #region zona de agregar y de quitar filtros y criterios de ordenacion
        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            if (!cmbOrden1.Visible)
            {
                chkOrden1.Checked = true;
                cmbOrden1.Visible = true;
                cmbOrden1.SelectedIndex = 0;
                cmbOrden1Estilos.Visible = true;
                cmbOrden1Estilos.SelectedIndex = 0;
                btnQuitarOrden.Visible = true;
                btnAgregarOrden.Location = new Point(cmbOrden1Estilos.Location.X+90, btnAgregarOrden.Location.Y);
                btnQuitarOrden.Location = new Point(btnAgregarOrden.Location.X + 36, btnQuitarOrden.Location.Y);
                
            }
            else if (!cmbOrden2.Visible)
            {
                lblSep1Orden.Visible = true;
                chkOrden2.Checked = true;
                cmbOrden2.Visible = true;
                cmbOrden2Estilos.Visible = true;
                btnAgregarOrden.Location = new Point(cmbOrden2Estilos.Location.X + 90, btnAgregarOrden.Location.Y);
                btnQuitarOrden.Location = new Point(btnAgregarOrden.Location.X + 36, btnQuitarOrden.Location.Y);
                cmbOrden2.SelectedIndex = 0;
                cmbOrden2Estilos.SelectedIndex = 0;

            }
            else if (!cmbOrden3.Visible)
            {
                lblSep2Orden.Visible = true;
                chkOrden3.Checked = true;
                cmbOrden3.Visible = true;
                cmbOrden3Estilos.Visible = true;
                btnQuitarOrden.Location = new Point(cmbOrden3Estilos.Location.X + 90, btnQuitarOrden.Location.Y);
                btnAgregarOrden.Visible = false;
                cmbOrden3.SelectedIndex = 0;
                cmbOrden3Estilos.SelectedIndex = 0;

            }
             
        }

        private void btnQuitarOrden_Click(object sender, EventArgs e)
        {
            //miramos si esta el tres visible ocultamos el tres
            if (cmbOrden3.Visible) 
            {
                chkOrden3.Visible = false;
                chkOrden3.Checked = false;
                cmbOrden3.Visible = false;
                cmbOrden3Estilos.Visible = false;
                btnAgregarOrden.Visible = true;
                btnAgregarOrden.Location = new Point(cmbOrden2Estilos.Location.X+90, btnAgregarOrden.Location.Y);
                btnQuitarOrden.Location = new Point(btnAgregarOrden.Location.X+36, btnQuitarOrden.Location.Y);
                lblSep2Orden.Visible = false;
            }
            else if (cmbOrden2.Visible)
            {
                chkOrden2.Visible = false;
                chkOrden2.Checked = false;
                cmbOrden2.Visible = false;
                cmbOrden2Estilos.Visible = false;
                btnAgregarOrden.Location = new Point(cmbOrden1Estilos.Location.X+90, btnAgregarOrden.Location.Y);
                btnQuitarOrden.Location = new Point(btnAgregarOrden.Location.X + 36, btnQuitarOrden.Location.Y);
                lblSep1Orden.Visible = false;
            }
            else if (cmbOrden1.Visible)
            {
                chkOrden1.Visible = false;
                chkOrden1.Checked = false;
                cmbOrden1.Visible = false;
                cmbOrden1Estilos.Visible = false;
                btnQuitarOrden.Visible = false;
                btnAgregarOrden.Location = new Point(cmbOrden1.Location.X, btnAgregarOrden.Location.Y);
            }
        }

        private void btnAgregarFiltro_Click(object sender, EventArgs e)
        {
             if (!chkFiltro1.Checked)
            {
                chkFiltro1.Checked = true;
                panel1.Visible = true;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel1.Location.Y+28);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel1.Location.Y+28);
                btnQuitarFiltro.Visible = true;
                lblvalor.Visible = true;
                lblCampo.Visible = true;
                lbloperador.Visible = true;
            }else if (!chkFilltro2.Checked)
            {
                chkFilltro2.Checked = true;
                panel2.Visible = true;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel2.Location.Y+28);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel2.Location.Y+28);
            }else if (!chkFiltro3.Checked)
            {
                chkFiltro3.Checked = true;
                panel3.Visible = true;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel3.Location.Y+28);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel3.Location.Y+28);
            }else
            if (!chkFiltro4.Checked)
            {
                chkFiltro4.Checked = true;
                panel4.Visible = true;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel4.Location.Y+28);
                btnQuitarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel4.Location.Y + 28);
                btnAgregarFiltro.Visible = false;
            }
            
 

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //quitar filtro
            if (chkFiltro4.Checked)
            {
                chkFiltro4.Checked = false;
                panel4.Visible = false;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel3.Location.Y + 28);
                btnQuitarFiltro.Location = new Point(btnAgregarFiltro.Location.X+38, panel3.Location.Y + 28);
                btnAgregarFiltro.Visible = true;
            }
            else if (chkFiltro3.Checked)
            {
                chkFiltro3.Checked = false;
                panel3.Visible = false;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel2.Location.Y + 28);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel2.Location.Y + 28);
            }
            else if (chkFilltro2.Checked)
            {
                chkFilltro2.Checked = false;
                panel2.Visible = false;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel1.Location.Y + 28);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel1.Location.Y+28);
            }
            else if (chkFiltro1.Checked)
            {
                chkFiltro1.Checked = false;
                panel1.Visible = false;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel1.Location.Y-15);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel1.Location.Y);
                btnQuitarFiltro.Visible = false;
                lblvalor.Visible = false;
                lblCampo.Visible = false;
                lbloperador.Visible = false;
            }
        }
        #endregion 
    
        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (grdRpt.Columns[0].Text.Trim() == string.Empty) return;
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            ruta += "" + @"\rpt\";
            ruta += grdRpt.Columns["xml"].Text.Trim();
            string nombre = grdRpt.Columns["nombre_rpt"].Text.Trim();
            lblEstado.Text = "validando Proceso...";
            Application.DoEvents();
            if (!validar()) return;
            if (!validarFiltros(dsSPXQuery1.rpt[0].filtra_linea))
            {
                lblEstado.Text = "";
                Application.DoEvents();
                return;
            }
            lblEstado.Text = "Iniciando Proceso...";
            Application.DoEvents();


            #region cargamos la informacion del reporte seleccionado
            c1Report1.Load(ruta, nombre);
            c1Report1.DataSource.ConnectionString =DataConector.CadenaConexionAsignada;
                //BD.DataConector.CadenaConexionReportes;
            string strSql = c1Report1.DataSource.RecordSource;
            #endregion

            //#region configuramos los filtros de la aplicacion
            //c1Report1.DataSource.Filter = "";
            string strParte1 = "";
            string strParte2 = "";
            string filtro = armarFiltros(dsSPXQuery1.rpt[0].filtra_linea);
            string orden = armarOrden();

            if (filtro.Trim() != string.Empty)
            {
                int iniUnion = strSql.IndexOf("union");
                if (iniUnion > 0)
                {
                    #region configura las cadenas si tiene una union
                    strParte1 = strSql.Substring(0, iniUnion - 1);
                    strParte1 = adicionaCondiciones(strParte1, armarFiltros(dsSPXQuery1.rpt[0].filtra_linea), false);

                    strParte2 = strSql.Substring(iniUnion);
                    strParte2 = strParte2.Substring(strParte2.IndexOf("SELECT"));
                    strParte2 = adicionaCondiciones(strParte2, armarFiltros(dsSPXQuery1.rpt[0].filtra_linea), true);
                    strSql = strParte1 + " UNION ALL " + strParte2;
                    #endregion
                }
                else
                {
                    strSql = adicionaCondiciones(strSql, armarFiltros(dsSPXQuery1.rpt[0].filtra_linea), true);
                }
            }
            remplazarCampos();
            lblEstado.Text = "Generando Reporte...";
            Application.DoEvents();
            c1Report1.DataSource.RecordSource = strSql;
            frmReporte frmMon = new frmReporte(c1Report1);
            frmMon.Show();
            lblEstado.Text = "Reporte Generado...";
            Application.DoEvents();
        }

        string adicionaCondiciones(string strSql,string filtros, bool bOrden)
        {
            int Pos_Inicial = 0, Pos_Final_Select = 0, Pos_Inicial_Group = 0;
            int Pos_Final_Group = 0, Pos_Inicial_Order = 0, Pos_Final_Order = 0;
            int Pos_Final = 0;

            string strSqlSelect = "", strSqlGroup = "", strSqlOrder = "";

            Pos_Inicial_Group = strSql.ToUpper().IndexOf("GROUP BY", 0);
            Pos_Inicial_Order = strSql.ToUpper().IndexOf("ORDER BY", 0);
            Pos_Final = strSql.Length;

            #region ajustamos las pociciones de inicio de los agrupamientos dependiendo si los tiene o no
            if (Pos_Inicial_Group == -1)
            {
                Pos_Final_Group = 0;
                if (Pos_Inicial_Order == -1)
                {
                    Pos_Final_Select = Pos_Final;
                    Pos_Inicial_Group = Pos_Final_Select;
                    Pos_Final_Group = Pos_Final - Pos_Inicial_Group;
                    Pos_Inicial_Order = Pos_Inicial_Group + Pos_Final_Group;
                    Pos_Final_Order = Pos_Final - Pos_Inicial_Order;
                }
                else
                {
                    Pos_Final_Select = Pos_Inicial_Order;
                    Pos_Inicial_Group = Pos_Final_Select;
                    Pos_Final_Group = Pos_Inicial_Order - Pos_Inicial_Group;
                    Pos_Final_Order = Pos_Final - Pos_Inicial_Order;
                }
            }else{
                if (Pos_Inicial_Order == -1)
                {
                    Pos_Final_Select = Pos_Inicial_Group;
                    Pos_Inicial_Group = Pos_Final_Select;
                    Pos_Final_Group = Pos_Final - Pos_Inicial_Group;
                    Pos_Inicial_Order = Pos_Final;
                    Pos_Final_Order = Pos_Final - Pos_Inicial_Order;
                }
                else
                {
                    Pos_Final_Select = Pos_Inicial_Group;
                    Pos_Inicial_Group = Pos_Final_Select;
                    Pos_Final_Group = Pos_Inicial_Order - Pos_Inicial_Group;
                    Pos_Final_Order = Pos_Final - Pos_Inicial_Order;
                }
            }

            #endregion

        //elejimos
            strSqlSelect = strSql.Substring(Pos_Inicial, Pos_Final_Select);
            strSqlGroup = strSql.Substring(Pos_Inicial_Group, Pos_Final_Group);
            strSqlOrder = strSql.Substring(Pos_Inicial_Order, Pos_Final_Order);
        //    //Validamos que esten bien selecionados los campos
            #region adicionamos filtros
            if (filtros.Trim() != string.Empty)
            {
                if (strSqlSelect.ToUpper().IndexOf("WHERE") > -1)
                {
                    strSqlSelect = strSqlSelect +" AND "+filtros;
                }else{
                    strSqlSelect = strSqlSelect + " WHERE " +filtros;
                }
            }
#endregion
            if (chkOrden1.Checked && bOrden && (cmbOrden1.SelectedItem != null) && (cmbOrden1.SelectedValue.ToString() != ""))
            {
                if (strSqlOrder.ToUpper().IndexOf(cmbOrden1.SelectedValue.ToString().Trim().ToUpper()) < 0)
                {
                    if (strSqlOrder.ToUpper().IndexOf("ORDER BY") > -1)
                    {
                        strSqlOrder = strSqlOrder + " , " + armarOrden(1);
                    }
                    else
                    {
                        strSqlOrder =" ORDER BY "+ armarOrden(1);
                    }
                }
            }
            if (chkOrden2.Checked && bOrden && (cmbOrden2.SelectedItem != null) && (cmbOrden2.SelectedValue.ToString() != ""))
            {
                if (strSqlOrder.ToUpper().IndexOf(cmbOrden2.SelectedValue.ToString().Trim().ToUpper()) < 0)
                {
                    if (strSqlOrder.ToUpper().IndexOf("ORDER BY") > -1)
                    {
                        strSqlOrder = strSqlOrder + " , " + armarOrden(2);
                    }
                    else
                    {
                        strSqlOrder = " ORDER BY " + armarOrden(2);
                    }
                }
            }
            if (chkOrden3.Checked && bOrden && (cmbOrden3.SelectedItem != null) && (cmbOrden3.SelectedValue.ToString() != ""))
            {
                if (strSqlOrder.ToUpper().IndexOf(cmbOrden3.SelectedValue.ToString().Trim().ToUpper()) < 0)
                {
                    if (strSqlOrder.ToUpper().IndexOf("ORDER BY") > -1)
                    {
                        strSqlOrder = strSqlOrder + " , " + armarOrden(3);
                    }
                    else
                    {
                        strSqlOrder = " ORDER BY " + armarOrden(3);
                    }
                }
            }

            return strSqlSelect + " " + strSqlGroup + " " +strSqlOrder;
        }

        private void btnGenExcel_Click(object sender, EventArgs e)
        {
            if (grdRpt.Columns[0].Text.Trim() == string.Empty) return;
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            ruta += "" + @"\rpt\";
            ruta += grdRpt.Columns["xml"].Text.Trim();
            string nombre = grdRpt.Columns["nombreRpt"].Text.Trim();
            lblEstado.Text = "validando Proceso...";
            Application.DoEvents();
            if (!validar()) return;
            if (!validarFiltros(dsSPXQuery1.rpt[0].filtra_linea))
            {
                lblEstado.Text = "";
                Application.DoEvents();
                return;
            }
            lblEstado.Text = "Iniciando Proceso...";
            Application.DoEvents();


            #region cargamos la informacion del reporte seleccionado
            c1Report1.Load(ruta, nombre);
            c1Report1.DataSource.ConnectionString =DataConector.CadenaConexionAsignada;
            //BD.DataConector.CadenaConexionReportes;
            string strSql = c1Report1.DataSource.RecordSource;
            #endregion

            //#region configuramos los filtros de la aplicacion
            //c1Report1.DataSource.Filter = "";
            string strParte1 = "";
            string strParte2 = "";
            string filtro = armarFiltros(dsSPXQuery1.rpt[0].filtra_linea);
            string orden = armarOrden();

            if (filtro.Trim() != string.Empty)
            {
                int iniUnion = strSql.IndexOf("union");
                if (iniUnion > 0)
                {
                    #region configura las cadenas si tiene una union
                    strParte1 = strSql.Substring(0, iniUnion - 1);
                    strParte1 = adicionaCondiciones(strParte1, armarFiltros(dsSPXQuery1.rpt[0].filtra_linea), false);

                    strParte2 = strSql.Substring(iniUnion);
                    strParte2 = strParte2.Substring(strParte2.IndexOf("SELECT"));
                    strParte2 = adicionaCondiciones(strParte2, armarFiltros(dsSPXQuery1.rpt[0].filtra_linea), true);
                    strSql = strParte1 + " UNION ALL " + strParte2;
                    #endregion
                }else{
                    strSql = adicionaCondiciones(strSql, armarFiltros(dsSPXQuery1.rpt[0].filtra_linea), true);
                }
            }

           DataConector obj = new DataConector();
            grdToolExcel.DataSource = obj.ejecutarConsulta(strSql.Replace("\r\n"," ")).Tables[0];
            
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel objEcel = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            objEcel.exportarRapido(grdToolExcel, grdRpt.Columns[1].Text.Trim(), true);
            lblEstado.Text = "Generando Excel...";
            Application.DoEvents();
            lblEstado.Text = "Excel Generado...";
            Application.DoEvents();
        }

       
    }
}

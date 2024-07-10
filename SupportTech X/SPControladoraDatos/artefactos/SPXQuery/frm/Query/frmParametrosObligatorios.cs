using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    public partial class frmParametrosObligatorios : Form
    {
        public class parametro
        {
            public int codQuery { set; get; }
            public int codParametro { set; get; }
            public string campo { set; get; }
            public string respuesta { set; get; }
            public string valorxDefecto { set; get; }

            //public string valorTexto { set; get; }
            //public int valorInt { set; get; }
            //public decimal valorDecimal { set; get; }
            //public DateTime valorFecha { set; get; }

            public parametro(){ }
        }

        public frmParametrosObligatorios()
        {
            InitializeComponent();
        }

        data.cls.clsTcgq_parametrosquery cgq_parametrosqueryTableAdapter1 = new data.cls.clsTcgq_parametrosquery();
        data.cls.cgq_parametrosquery_ultimo_valor uv = new data.cls.cgq_parametrosquery_ultimo_valor();
        public List<parametro> lista = new List<parametro>();

        private void frmParametrosObligatorios_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            for (int k = 0; k < lista.Count; k++)
            {
                cgq_parametrosqueryTableAdapter1.fillById(dsSPXQuery1.cgq_parametrosquery, lista[k].codParametro);
                uv.FillBycod_parametros_queryCodUsuario(dsSPXQuery1.cgq_parametrosquery_ultimo_valor, lista[k].codParametro,SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
                if (dsSPXQuery1.cgq_parametrosquery.Count <= 0) continue;
                lista[k].campo = dsSPXQuery1.cgq_parametrosquery[0].campo;
                Label l = new Label();
                l.Name = "lbl" + k;
                l.Text = dsSPXQuery1.cgq_parametrosquery[0].caption;
                l.Location = new Point(10, k * 25 + 20);
                pnlContenedor.Controls.Add(l);
                l.Tag = "IGNORE";
                l.Size = new Size(170, l.Height);
                //dependiendo el tipo
                //1 int 2 float 3 string 4 datetime 5 bool
                if (dsSPXQuery1.cgq_parametrosquery[0].cod_tipo_filtro == 1)
                {
                    TextBox txt = new TextBox();
                    txt.Tag = dsSPXQuery1.cgq_parametrosquery[0].caption + "|" + dsSPXQuery1.cgq_parametrosquery[0].cod_parametros_query;
                    txt.Name = "txt" + k;
                    txt.Text = "";
                    if (!dsSPXQuery1.cgq_parametrosquery[0].Isvalor_por_defectoNull())
                    {
                        try {
                            int a = 0;
                            int.TryParse(dsSPXQuery1.cgq_parametrosquery[0].valor_por_defecto, out a);
                            txt.Text = a.ToString();
                        } catch(Exception){}
                    }
                    if (dsSPXQuery1.cgq_parametrosquery_ultimo_valor.Count > 0 && !dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].Isvalor_asignadoNull())
                    {
                        try
                        {
                            int a = 0;
                            int.TryParse(dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].valor_asignado, out a);
                            txt.Text = a.ToString();
                        }catch (Exception) { }
                    }
                    txt.KeyPress += new KeyPressEventHandler(txt_validaInt);
                    txt.Width = 200;
                    txt.Location = new Point(180, k * 25 + 20);
                    pnlContenedor.Controls.Add(txt);
                }else
                if (dsSPXQuery1.cgq_parametrosquery[0].cod_tipo_filtro == 2)
                {
                    TextBox txt = new TextBox();
                    txt.Tag = dsSPXQuery1.cgq_parametrosquery[0].caption + "|" + dsSPXQuery1.cgq_parametrosquery[0].cod_parametros_query;
                    txt.Name = "txt" + k;
                    txt.KeyPress += new KeyPressEventHandler(txt_validaFloat);
                    txt.Text = "";
                    if (!dsSPXQuery1.cgq_parametrosquery[0].Isvalor_por_defectoNull())
                    {
                        try
                        {
                            float a = 0;
                            float.TryParse(dsSPXQuery1.cgq_parametrosquery[0].valor_por_defecto, out a);
                            txt.Text = a.ToString();
                        }
                        catch (Exception) { }
                    }
                    if (dsSPXQuery1.cgq_parametrosquery_ultimo_valor.Count > 0 && !dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].Isvalor_asignadoNull())
                    {
                        try
                        {
                            float a = 0;
                            float.TryParse(dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].valor_asignado, out a);
                            txt.Text = a.ToString();
                        }
                        catch (Exception) { }
                    }
                    txt.Width = 200;
                    txt.Location = new Point(180, k * 25 + 20);
                    pnlContenedor.Controls.Add(txt);
                }else
                if (dsSPXQuery1.cgq_parametrosquery[0].cod_tipo_filtro == 3)
                {
                    TextBox txt = new TextBox();
                    txt.Tag = dsSPXQuery1.cgq_parametrosquery[0].caption + "|" + dsSPXQuery1.cgq_parametrosquery[0].cod_parametros_query;
                    txt.Name = "txt" + k;
                    txt.Text = "";
                    if (!dsSPXQuery1.cgq_parametrosquery[0].Isvalor_por_defectoNull())
                    {
                        txt.Text = dsSPXQuery1.cgq_parametrosquery[0].valor_por_defecto.Trim();
                    }
                    if (dsSPXQuery1.cgq_parametrosquery_ultimo_valor.Count > 0 && !dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].Isvalor_asignadoNull())
                    {
                        txt.Text =dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].valor_asignado.Trim();
                    }
                    txt.Width = 200;
                    txt.Location = new Point(180, k * 25 + 20);
                    pnlContenedor.Controls.Add(txt);
                }else
                if (dsSPXQuery1.cgq_parametrosquery[0].cod_tipo_filtro == 4)
                {
                    DevComponents.Editors.DateTimeAdv.DateTimeInput txt = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
                    txt.ButtonDropDown.Visible = true;
                    txt.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
                    txt.MonthCalendar.ClearButtonVisible = true;
                    txt.MonthCalendar.DisplayMonth = DateTime.Now;
                    txt.Tag = dsSPXQuery1.cgq_parametrosquery[0].caption + "|" + dsSPXQuery1.cgq_parametrosquery[0].cod_parametros_query;
                    txt.Name = "txt" + k;
                    txt.ValueObject = null;
                    txt.Location = new Point(180, k * 25 + 20);
                    pnlContenedor.Controls.Add(txt);
                }
                if (dsSPXQuery1.cgq_parametrosquery[0].cod_tipo_filtro == 5)
                {
                    CheckBox  txt = new CheckBox();
                    txt.Tag = dsSPXQuery1.cgq_parametrosquery[0].caption + "|" + dsSPXQuery1.cgq_parametrosquery[0].cod_parametros_query;
                    txt.Name = "txt" + k;
                    txt.Checked = false;
                    if (!dsSPXQuery1.cgq_parametrosquery[0].Isvalor_por_defectoNull())
                    {
                        txt.Checked = (dsSPXQuery1.cgq_parametrosquery[0].valor_por_defecto.Trim() == "1" || dsSPXQuery1.cgq_parametrosquery[0].valor_por_defecto.Trim().ToUpper() =="TRUE");
                    }

                    if (dsSPXQuery1.cgq_parametrosquery_ultimo_valor.Count > 0 && !dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].Isvalor_asignadoNull())
                    {
                        txt.Checked = (dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].valor_asignado.Trim() == "1" || dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].valor_asignado.Trim().ToUpper() == "TRUE");
                    }
                    txt.Location = new Point(180, k * 25 + 20);
                    pnlContenedor.Controls.Add(txt);
                }
            }

        //    pnlContenedor.Size = new Size(pnlContenedor.Size.Width,lista.Count*20+40 );
            this.Size = new Size(this.Size.Width, (lista.Count * 25) + 140);
        }

        /// <summary>
        /// validacion de entero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txt_validaInt(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar > 20 && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// validacion de entero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txt_validaFloat(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar > 20 && !char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < pnlContenedor.Controls.Count; k++)
            {
                if(pnlContenedor.Controls[k].Tag == null ||  pnlContenedor.Controls[k].Tag.ToString().Trim() == "IGNORE")
                {
                    continue;
                }
//---
                string r = "";
                string[] arr = pnlContenedor.Controls[k].Tag.ToString().Split('|');
                if (pnlContenedor.Controls[k].GetType().Name.IndexOf("TextBox") >= 0)
                {
                    if (pnlContenedor.Controls[k].Text == string.Empty)
                    {
                        MessageBox.Show("Ingrese un valor para " + arr[0] + "!");
                        return;
                    }
                    r = pnlContenedor.Controls[k].Text;
                }
                else if (pnlContenedor.Controls[k].GetType().Name.IndexOf("CheckBox") >= 0)
                {
                    r = ((CheckBox)pnlContenedor.Controls[k]).Checked?"1":"0";
                }
                else
                {
                    DevComponents.Editors.DateTimeAdv.DateTimeInput v = (DevComponents.Editors.DateTimeAdv.DateTimeInput)pnlContenedor.Controls[k];
                    if (v.ValueObject == null)
                    {
                        MessageBox.Show("Ingrese un valor para " + arr[0] + "!");
                        return;
                    }
                    r = "'" + v.Value.Year + "-" + v.Value.Month.ToString().PadLeft(2, '0') + "-" + v.Value.Day.ToString().PadLeft(2, '0')+"'";
                }
                asignar(int.Parse(arr[1]), r);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void asignar(int codParametro,string valor ) 
        {
            for(int k=0; k<lista.Count;k++ )
            {
                if (lista[k].codParametro == codParametro)
                {
                    lista[k].respuesta = valor;
                    uv.FillBycod_parametros_queryCodUsuario(dsSPXQuery1.cgq_parametrosquery_ultimo_valor, codParametro, SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
                    if (dsSPXQuery1.cgq_parametrosquery_ultimo_valor.Count > 0)
                    {
                        uv.UpdateValor_asignado(valor, dsSPXQuery1.cgq_parametrosquery_ultimo_valor[0].cod_cgq_parametrosquery_ultimo_valor);
                    }else {
                        uv.Insert(codParametro, valor, SPXSeguridad.logica.sesion.CodUsuarioAutenticado);
                    }
                }
            }
        }

    }
}

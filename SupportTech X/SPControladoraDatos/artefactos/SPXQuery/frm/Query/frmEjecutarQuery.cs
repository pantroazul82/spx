using SPControladoraDatos.artefactos;
using SPControladoraDatos.artefactos.SPXQuery.data;
using SPXdata.BD;
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
    public partial class frmEjecutarQuery : Form
    {
        public frmEjecutarQuery()
        {
            InitializeComponent();  
            controladorColumnas1.grilla = grdDatos;
        }

        public bool cerrar = false;
        public int codQuery = 0;
        public string sql {set;get;}
       DataConector obj = new DataConector();

        #region parametros
        /// <summary>
        /// Este metodo debe invocase antes de llamar al load
        /// </summary>
        /// <param name="tabla"></param>
        public void cargarParametros(dsSPXQuery.cgq_parametrosqueryDataTable tabla)
        {
            dsPar1.cgq_parametrosquery.Clear();
            dsPar2.cgq_parametrosquery.Clear();
            dsPar3.cgq_parametrosquery.Clear();
            dsPar4.cgq_parametrosquery.Clear();
            dsSPXQuery1.cgq_parametrosquery.Clear();
            //--
            dsPar1.cgq_parametrosquery.Merge( tabla);
            dsPar2.cgq_parametrosquery.Merge(tabla);
            dsPar3.cgq_parametrosquery.Merge(tabla);
            dsPar4.cgq_parametrosquery.Merge(tabla);
            dsSPXQuery1.cgq_parametrosquery.Merge(tabla);
        }

        private void llenarParametros()
        {
            resetControles();
            if (dsPar1.cgq_parametrosquery.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsPar1.cgq_parametrosquery[cmbCampo1.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 1);
            ajustarControles(tipo, 2);
            ajustarControles(tipo, 3);
            ajustarControles(tipo, 4);
        }

        #endregion
        
        private void frmEjecutarQuery_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            ajustar objFormResizer = new ajustar();
            objFormResizer.ResizeForm(this, Height, Width);

           DataConector dc = new DataConector();
            DateTime n = dc.fechaServer;
            calFechaxDefecto.MonthCalendar.DisplayMonth = n;
            cal1F1.MonthCalendar.DisplayMonth = n;
            cal1F2.MonthCalendar.DisplayMonth = n;
            cal1F3.MonthCalendar.DisplayMonth = n;
            cal1F4.MonthCalendar.DisplayMonth =n;
            cal2f1.MonthCalendar.DisplayMonth = n;
            cal2f2.MonthCalendar.DisplayMonth = n;
            cal2F3.MonthCalendar.DisplayMonth = n;
            cal2F4.MonthCalendar.DisplayMonth = n;
            //cargamos la informacion almacenada del query
            // 
            data.cls.clsTtipofiltro_query_rpt clsTtipofiltro_query_rpt1 = new data.cls.clsTtipofiltro_query_rpt();
            data.cls.clsTcgq_query clsTcgq_query1 = new data.cls.clsTcgq_query();
            clsTtipofiltro_query_rpt1.Fill(dsSPXQuery1.tipofiltro_query_rpt);
            if (codQuery == 0) {
                MessageBox.Show("Error de codigo fuente se lanzo la ventana sin ningun query.");
                return;
            }
            //miramos si tiene filtros obligatorios
            llenarParametros();
            //propiedades especiales del query
            clsTcgq_query1.FillByCod_query(dsSPXQuery1.cgq_query, codQuery);
            if((!dsSPXQuery1.cgq_query[0].Isfiltra_fechaNull() && dsSPXQuery1.cgq_query[0].filtra_fecha) )
            {
                lblFechaDefecto.Visible = true;
                calFechaxDefecto.Visible = true;
                calFechaxDefecto.Value = obj.fechaServer.AddDays( dsSPXQuery1.cgq_query[0].periodo_inicial * -1   );
                lblFechaDefecto.Text = dsSPXQuery1.cgq_query[0].campo_fecha.Replace("_"," ").Trim();
                calFechaxDefecto.Location = new Point(lblFechaDefecto.Location.X+10 +(lblFechaDefecto.Text.Length*6 )  , calFechaxDefecto.Location.Y); 
            }
            WindowState = FormWindowState.Maximized;
        }

        #region filtros y parametros
        private void btnAgregarFiltro_Click(object sender, EventArgs e)
        {
            if (dsSPXQuery1.cgq_parametrosquery.Count <= 0)
            {
                MessageBox.Show("No tiene ningun parametro configurado!!!");
                return;
            }
            if (!chkFiltro1.Checked)
            {
                chkFiltro1.Checked = true;
                panel1.Visible = true;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel1.Location.Y + 28);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel1.Location.Y + 28);

                btnQuitarFiltro.Visible = true;
                lblvalor.Visible = true;
                lblCampo.Visible = true;
                lbloperador.Visible = true;
            }
            else if (!chkFilltro2.Checked)
            {
                chkFilltro2.Checked = true;
                panel2.Visible = true;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel2.Location.Y + 28);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel2.Location.Y + 28);
            }
            else if (!chkFiltro3.Checked)
            {
                chkFiltro3.Checked = true;
                panel3.Visible = true;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel3.Location.Y + 28);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel3.Location.Y + 28);
            }
            else
                if (!chkFiltro4.Checked)
                {
                    chkFiltro4.Checked = true;
                    panel4.Visible = true;
                    btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel4.Location.Y + 28);
                    btnQuitarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel4.Location.Y + 28);
                    btnAgregarFiltro.Visible = false;
                }
            actualizarPosicionPanel();
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
    //quitar filtro
            if (chkFiltro4.Checked)
            {
                chkFiltro4.Checked = false;
                panel4.Visible = false;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel3.Location.Y + 28);
                btnQuitarFiltro.Location = new Point(btnAgregarFiltro.Location.X + 38, panel3.Location.Y + 28);
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
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel1.Location.Y + 28);
            }
            else if (chkFiltro1.Checked)
            {
                chkFiltro1.Checked = false;
                panel1.Visible = false;
                btnAgregarFiltro.Location = new Point(btnAgregarFiltro.Location.X, panel1.Location.Y - 15);
                btnQuitarFiltro.Location = new Point(btnQuitarFiltro.Location.X, panel1.Location.Y);
                btnQuitarFiltro.Visible = false;
                lblvalor.Visible = false;
                lblCampo.Visible = false;
                lbloperador.Visible = false;
                
            }
            actualizarPosicionPanel();
        }
   
        private void resetControles()
        {
            chkFiltroResCuatro.Visible = false;
            chkFiltroResDos.Visible = false;
            chkFiltroResTres.Visible = false;
            chkFiltroResUno.Visible = false;
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
            txtFloat1F1.Text = "";
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
   
        private void actualizarPosicionPanel()
        {
            grpFiltros.Height = btnAgregarFiltro.Location.Y + 50;
            btnProbar.Location = new Point(btnProbar.Location.X, grpFiltros.Location.Y + grpFiltros.Size.Height-40);
            controladorColumnas1.Location = new Point(controladorColumnas1.Location.X, grpFiltros.Location.Y + grpFiltros.Size.Height);
            btnExportarTxt.Location = new Point(btnExportarTxt.Location.X, grpFiltros.Location.Y + grpFiltros.Size.Height);
            lblFechaDefecto.Location = new Point(lblFechaDefecto.Location.X,6+ grpFiltros.Location.Y + grpFiltros.Size.Height);
            calFechaxDefecto.Location = new Point(calFechaxDefecto.Location.X,6+ grpFiltros.Location.Y + grpFiltros.Size.Height);

            grdDatos.Location = new Point(grdDatos.Location.X, grpFiltros.Location.Y + grpFiltros.Size.Height+30);
            grdDatos.Size = new Size(grdDatos.Width, this.Height - (grpFiltros.Height+93));

            txtQuery.Location = new Point(grdDatos.Location.X, grpFiltros.Location.Y + grpFiltros.Size.Height + 30);
            txtQuery.Size = new Size(grdDatos.Width, this.Height - (grpFiltros.Height + 93));
        }

        private void resetControles(int filtro, int tipo, string operador)
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
                chkFiltroResUno.Visible = false;
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
                else if (tipo == 5)
                {
                    chkFiltroResUno.Visible = true;
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
                chkFiltroResDos.Visible = false;
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
                } else if (tipo == 5)
                {
                    chkFiltroResDos.Visible = true;
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
                chkFiltroResTres.Visible = false;
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
                else if (tipo == 5)
                {
                    chkFiltroResTres.Visible = true;
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
                lblCal4.Visible = false;
                txtFiltro4.Visible = false;
                chkFiltroResCuatro.Checked = false;
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
                else if (tipo == 5)
                {
                    chkFiltroResCuatro.Visible = true;
                }
            }
            #endregion
        }

        private void ajustarControles(int tipoDatos, int filtro)
        {
            System.Windows.Forms.ComboBox cm = cmbOperador1;

            if (filtro == 2) cm = cmbOperador2;
            else if (filtro == 3) cm = cmbOperador3;
            else if (filtro == 4) cm = cmbOperador4;
            cm.Items.Clear();

            cm.Items.Add("Igual");
            if (tipoDatos != 3 && tipoDatos !=5)
            {
                cm.Items.Add("Menor");
                cm.Items.Add("Mayor");
                cm.Items.Add("Menor o Igual");
                cm.Items.Add("Mayor o Igual");
                cm.Items.Add("Entre");
            }
            cm.Items.Add("Diferente");
            if (tipoDatos != 5)
            {
                cm.Items.Add("Like");
            }
        }

        private void cmbCampo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsPar1.cgq_parametrosquery.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsPar1.cgq_parametrosquery[cmbCampo1.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 1);
        }

        private void cmbFiltro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsPar2.cgq_parametrosquery.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsPar2.cgq_parametrosquery[cmbFiltro2.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 2);
        }

        private void cmbFiltro3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsPar3.cgq_parametrosquery.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsPar3.cgq_parametrosquery[cmbFiltro3.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 3);

        }

        private void cmbFiltro4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dsPar4.cgq_parametrosquery.Rows.Count <= 0) return;
            int tipo = 0;
            tipo = dsPar4.cgq_parametrosquery[cmbFiltro4.SelectedIndex].cod_tipo_filtro;
            ajustarControles(tipo, 4);
        }

        private void ajustar(int filtro)
        {
            dsSPXQuery dr = dsPar1;
            System.Windows.Forms.ComboBox cm = cmbOperador1;
            if (filtro == 2) { cm = cmbOperador2; dr = dsPar2; }
            else if (filtro == 3) { cm = cmbOperador3; dr = dsPar3; }
            else if (filtro == 4) { cm = cmbOperador4; dr = dsPar4; }
            string operador = cm.Text;
            //
            cm = cmbCampo1;
            if (filtro == 2) { cm = cmbFiltro2; }
            else if (filtro == 3) { cm = cmbFiltro3; }
            else if (filtro == 4) { cm = cmbFiltro4; }


            int tipo = dr.cgq_parametrosquery[cm.SelectedIndex].cod_tipo_filtro;
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
        
        private void txtEntero1F1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar > 20) e.Handled = true;
        }

        private void txtFloat1F1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar > 20 && e.KeyChar.ToString() != System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator) e.Handled = true;
        }
#endregion 
        
        private string procesarFiltro(string query, string filtro) 
        {
            string sql = query;
            //buscamos el where
            string consulta  = "";
            string where     = "";
            string groupBy   = "";
            string havingBy  = "";
            string orderBy   = "";
            int tmp=0;
            //order by
            if ( sql.IndexOf("order by", StringComparison.OrdinalIgnoreCase) > 0 )
            {
                tmp = query.IndexOf("order by", StringComparison.OrdinalIgnoreCase);
                orderBy = " ORDER BY "+ sql.Substring((tmp+8), sql.Length - (tmp+8));
                sql = sql.Substring(0, tmp);
            }
            //having
            if (sql.IndexOf("having", StringComparison.OrdinalIgnoreCase) > 0)
            {
                tmp = query.IndexOf("having", StringComparison.OrdinalIgnoreCase);
                havingBy = " HAVING " + sql.Substring((tmp + 6), sql.Length - (tmp + 6));
                sql = sql.Substring(0, tmp);
            }
            //group by
            if (sql.IndexOf("group by", StringComparison.OrdinalIgnoreCase) > 0)
            {
                tmp = query.IndexOf("group by", StringComparison.OrdinalIgnoreCase);
                groupBy = " GROUP BY " + sql.Substring((tmp + 8), sql.Length - (tmp + 8));
                sql = sql.Substring(0, tmp);
            }
            //where
            if (sql.IndexOf("where", StringComparison.OrdinalIgnoreCase) > 0)
            {
                tmp = query.IndexOf("where", StringComparison.OrdinalIgnoreCase);
                where = " WHERE " +"("+filtro+") and " +sql.Substring((tmp + 5), sql.Length - (tmp + 5));
                sql = sql.Substring(0, tmp);
            }else {
                where = " WHERE " + filtro;
            }
            consulta = sql;
            return consulta + where + groupBy + havingBy + orderBy;
        }

        private List<string> desarmarUnion(string query)
        {
            string sql = query;
            List<string> lista = new List<string>();
            while( sql.IndexOf("union",StringComparison.OrdinalIgnoreCase)>0 )
            {
                lista.Add(sql.Substring(0, sql.IndexOf("union", StringComparison.OrdinalIgnoreCase)));
                sql =  sql.Substring(
                    sql.IndexOf("union", StringComparison.OrdinalIgnoreCase)+5,
                sql.Length-(sql.IndexOf("union", StringComparison.OrdinalIgnoreCase)+5)
                );
                
            }
            lista.Add(sql);
            return lista;
        }

        private void ejecutar(bool txt,string archivo)
        {
            string sql = this.sql;
            if (!validarFiltros()) return;
            string filtro = armarFiltros();
            sql = sql.Replace("\n", " "); 
            if (filtro.Trim() != string.Empty)
            {
                 if (sql.IndexOf("UNION") > 0)
                {
                    List<string> lista = desarmarUnion(sql);
                    sql = "";
                    for (int k = 0; k < lista.Count; k++)
                    {
                        sql = procesarFiltro(lista[k], filtro) +((k==lista.Count-1)?"":" UNION "); 
                    }
                }else{
                    sql = procesarFiltro(sql, filtro);   
                }
            }

            try
            {
                
                txtQuery.Text = sql;
               DataConector obj = new DataConector();
                string actual = obj.CadenaConexion;
                if (!dsSPXQuery1.cgq_query[0].Iscod_origen_datosNull())
                {
                    data.origen_datosTableAdapter origen = new data.origen_datosTableAdapter();
                    origen.FillBycod_origen_datos(dsSPXQuery1.origen_datos, dsSPXQuery1.cgq_query[0].cod_origen_datos);
                   DataConector.tipoMotor tipoM=DataConector.tipoMotor.mysql;
                   DataConector.tipoCnnOracle tipoOracle =DataConector.tipoCnnOracle.normal;
                    #region zona de eleccion de tipo de motor
                    if (dsSPXQuery1.origen_datos[0].tipo_cnn == "SQLserver")
                    {
                        tipoM =DataConector.tipoMotor.SQLserver;
                    }
                    else if (dsSPXQuery1.origen_datos[0].tipo_cnn == "mysql")
                    {
                        tipoM =DataConector.tipoMotor.mysql;
                    }
                    else if (dsSPXQuery1.origen_datos[0].tipo_cnn == "oracle")
                    {
                        tipoM =DataConector.tipoMotor.oracle;
                        if (dsSPXQuery1.origen_datos[0].tipo_cnn_oracle == "normal")
                        {
                            tipoOracle =DataConector.tipoCnnOracle.normal;
                        }else if (dsSPXQuery1.origen_datos[0].tipo_cnn_oracle == "sysdba")
                        {
                            tipoOracle =DataConector.tipoCnnOracle.sysdba;
                        }
                        else if (dsSPXQuery1.origen_datos[0].tipo_cnn_oracle == "sysoper")
                        {
                            tipoOracle =DataConector.tipoCnnOracle.sysoper;
                        }
                    }
                    else if (dsSPXQuery1.origen_datos[0].tipo_cnn == "postgress")
                    {
                        tipoM =DataConector.tipoMotor.postgress;
                    }
                    #endregion

                    SPXSeguridad.Cryptografia.CryptoRijndael rin = new SPXSeguridad.Cryptografia.CryptoRijndael();
                    string p = "";
                    if(dsSPXQuery1.origen_datos[0].password.Trim() != string.Empty)
                        p = rin.DesEncriptar(dsSPXQuery1.origen_datos[0].password, "CGSF");

                    string nueva=obj.generarCadenaConexion(true, tipoM,
                        dsSPXQuery1.origen_datos[0].login,
                        p,
                        dsSPXQuery1.origen_datos[0].servidor,
                        dsSPXQuery1.origen_datos[0].base_datos,
                        dsSPXQuery1.origen_datos[0].puerto.ToString(),
                        (dsSPXQuery1.origen_datos[0].IssidNull())?null:dsSPXQuery1.origen_datos[0].sid,
                        dsSPXQuery1.origen_datos[0].conexion_directa,
                        tipoOracle);
                    
                    obj.Obj_CadenaConexionAsignada = nueva;
                }
                System.Data.DataSet ds=obj.ejecutarConsulta( sql);
                
                grdDatos.DataSource = ds.Tables[0];
                if (txt)
                {
                    System.IO.TextWriter tw = System.IO.File.CreateText(archivo);
                    for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                    {
                        string linea = "";
                        for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                        {
                            linea = linea + "," + ds.Tables[0].Rows[k][j].ToString().Trim();
                        }
                        tw.WriteLine(linea);
                    }
                    tw.Close();
                }
                

                string str = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                str += @"\segEjecutaQuery-" +DataConector.Servidor.Trim() + "-" + codQuery.ToString().Trim() + "Layt.xs";
                if (System.IO.File.Exists(str))
                    grdDatos.LoadLayout(str);

                controladorColumnas1.nameEspace = @"\segEjecutaQuery-" +DataConector.Servidor.Trim()+"-"+ codQuery.ToString().Trim() + "Layt.xs";
                controladorColumnas1.cargarDiseno();

                for(int k=0;k<grdDatos.Columns.Count;k++)
                {
                    if(grdDatos.Columns[k].Caption.IndexOf("cantidad")>=0)
                    {
                        grdDatos.Columns[k].Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Sum;
                    }
                }
                lblTotalRegistros.Text = (grdDatos.DataSource as System.Data.DataTable).Rows.Count.ToString();
                System.Media.SystemSounds.Exclamation.Play();
            }catch (Exception ex){
                MessageBox.Show("Error en la consulta \n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportarTxt(grdDatos, false);
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            ejecutar(false,"");
        }

        private void chkDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDebug.Checked)
            {
                txtQuery.Visible = true;
                grdDatos.Visible = false;
            }else{
                txtQuery.Visible = false;
                grdDatos.Visible = true;
            }
        }
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
                }
                else
                {
                    filtro = filtro.Trim() + " " + op + " '" + retornaValores(1).Replace("'", "") + "%'";
                }
            }
            else if (numeroFiltro == 2)
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
                if (txtFiltro1.Visible)
                {
                    if (txtFiltro1.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Uno!"); return ""; }
                    rpta = "'" + txtFiltro1.Text + "'";
                }
                if (txtEntero1F1.Visible) { rpta = txtEntero1F1.Text; if (txtEntero2F1.Visible)rpta += " AND " + txtEntero2F1.Text; }
                if (txtFloat1F1.Visible) { rpta = txtFloat1F1.Text.Replace(",", "."); if (txtFloat2F1.Visible)rpta += " AND " + txtFloat2F1.Text.Replace(",", "."); }
                if (cal1F1.Visible) { rpta = "'" + cal1F1.Value.Year + "/" + cal1F1.Value.Month + "/" + cal1F1.Value.Day + "'"; if (cal2f1.Visible)rpta += " AND " + "'" + cal2f1.Value.Year + "/" + cal2f1.Value.Month + "/" + cal2f1.Value.Day + "'"; }
                if(chkFiltroResUno.Visible)rpta= (chkFiltroResUno.Checked)?"1":"0";
            }
            else if (filtro == 2)
            {
                if (txtFiltro2.Visible)
                {
                    if (txtFiltro2.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Dos!"); return ""; }
                    rpta = "'" + txtFiltro2.Text + "'";
                }
                if (txtEntero1F2.Visible) { rpta = txtEntero1F2.Text; if (txtEntero2F2.Visible)rpta += " AND " + txtEntero2F2.Text; }
                if (txtFloat1F2.Visible) { rpta = txtFloat1F2.Text.Replace(",", "."); if (txtFloat2F2.Visible)rpta += " AND " + txtFloat2F2.Text.Replace(",", "."); }
                if (cal1F2.Visible) { rpta = "'" + cal1F2.Value.Year + "/" + cal1F2.Value.Month + "/" + cal1F2.Value.Day + "'"; if (cal2f2.Visible)rpta += " AND " + "'" + cal2f2.Value.Year + "/" + cal2f2.Value.Month + "/" + cal2f2.Value.Day  + "'"; }
                if (chkFiltroResDos.Visible) rpta = (chkFiltroResDos.Checked) ? "1" : "0";
            }
            else if (filtro == 3)
            {
                if (txtFiltro3.Visible)
                {
                    if (txtFiltro3.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Tres!"); return ""; }
                    rpta = "'" + txtFiltro3.Text + "'";
                }
                if (txtEntero1F3.Visible) { rpta = txtEntero1F3.Text; if (txtEntero2F3.Visible)rpta += " AND " + txtEntero2F3.Text; }
                if (txtFloat1F3.Visible) { rpta = txtFloat1F3.Text.Replace(",", "."); if (txtFloat2F3.Visible)rpta += " AND " + txtFloat2F3.Text.Replace(",", "."); }
                if (cal1F3.Visible) { rpta = "'" + cal1F3.Value.Year + "/" + cal1F3.Value.Month + "/" + cal1F3.Value.Day + "'"; if (cal2F3.Visible)rpta += " AND " + "'" + cal2F3.Value.Year + "/" + cal2F3.Value.Month + "/" + cal2F3.Value.Day + "'"; }
                if (chkFiltroResTres.Visible) rpta = (chkFiltroResTres.Checked) ? "1" : "0";
            }
            else if (filtro == 4)
            {
                if (txtFiltro4.Visible)
                {
                    if (txtFiltro4.Text.Trim() == string.Empty) { MessageBox.Show("Ingrese el Valor para el filtro Cuatro!"); return ""; }
                    rpta = "'" + txtFiltro1.Text + "'";
                }
                if (txtEntero1F4.Visible) { rpta = txtEntero1F4.Text; if (txtEntero2F4.Visible)rpta += " AND " + txtEntero2F4.Text; }
                if (txtFloat1F4.Visible) { rpta = txtFloat1F4.Text.Replace(",", "."); if (txtFloat2F4.Visible)rpta += " AND " + txtFloat2F4.Text.Replace(",", "."); }
                if (cal1F4.Visible) { rpta = "'" + cal1F4.Value.Year + "/" + cal1F4.Value.Month + "/" + cal1F4.Value.Day + "'"; if (cal2F4.Visible)rpta += " AND " + "'" + cal2F4.Value.Year + "/" + cal2F4.Value.Month + "/" + cal2F4.Value.Day + "'"; }
                if (chkFiltroResCuatro.Visible) rpta = (chkFiltroResCuatro.Checked) ? "1" : "0";
            }
            if (rpta.Trim().Replace("'", "") == string.Empty)
            {
                MessageBox.Show("Ingrese los Valores para el Filtro " + filtro);
                return "";
            }
            return rpta;
        }

        string retornaOperador(string texto)
        {
            string rpta = "";
            if (texto.Trim().ToUpper() == "IGUAL") rpta = "=";
            if (texto.Trim().ToUpper() == "MENOR") rpta = "<";
            if (texto.Trim().ToUpper() == "MAYOR") rpta = ">";
            if (texto.Trim().ToUpper() == "MENOR O IGUAL") rpta = "<=";
            if (texto.Trim().ToUpper() == "MAYOR O IGUAL") rpta = ">=";
            if (texto.Trim().ToUpper() == "ENTRE") rpta = "between ";
            if (texto.Trim().ToUpper() == "DIFERENTE") rpta = "!=";
            if (texto.Trim().ToUpper() == "LIKE") rpta = "LIKE";
            return rpta;
        }

        string armarFiltros()
        {

            string a = verFiltro(1);
            if (a != string.Empty) a += " AND";

            string b = verFiltro(2);
            if (b != string.Empty) b += " AND";

            string c = verFiltro(3);
            if (c != string.Empty) c += " AND";

            string d = verFiltro(4);
            if (d != string.Empty) d += " AND";

            string e = "";
            if (calFechaxDefecto.Visible)
            {
                e = " "+dsSPXQuery1.cgq_query[0].campo_fecha.Trim()+" > '"+calFechaxDefecto.Value.Year+"/"+calFechaxDefecto.Value.Month.ToString().PadLeft(2,'0')+"/"+calFechaxDefecto.Value.Day.ToString().PadLeft(2,'0')+"' AND";
            }
            string filtro = a + " " + b + " " + c + " " + d+" "+e;
            if (filtro.Trim() != string.Empty)
                filtro = filtro.Trim().Substring(0, filtro.Trim().Length - 3);
            //miramos si tiene un filtro obligatorio y lo agregamos
            return filtro;
        }


        #endregion

        #region zona de validacion
        bool validarFiltros()
        {
            bool res = validarFiltro(1);
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

        #endregion     
    }
}

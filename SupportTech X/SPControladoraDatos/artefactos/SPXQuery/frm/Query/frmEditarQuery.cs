using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    public partial class frmEditarQuery : Form
    {
        public frmEditarQuery()
        {
            InitializeComponent();
        }

        public int codQuery = 0;
        data.cls.clsTtipofiltro_query_rpt tipofiltro_query_rptTableAdapter1 = new data.cls.clsTtipofiltro_query_rpt();
        data.cls.clsTcgq_query cgq_queryTableAdapter1 = new data.cls.clsTcgq_query();
        data.cls.clsTcgq_parametrosquery cgq_parametrosqueryTableAdapter1 = new data.cls.clsTcgq_parametrosquery();
        data.origen_datosTableAdapter origen_datosTableAdapter1 = new data.origen_datosTableAdapter();
      
        data.cls.cgq_parametrosquery_ultimo_valor cgq_parametrosquery_ultimo_valor1 = new data.cls.cgq_parametrosquery_ultimo_valor();
        SPXSeguridad.data.cls.clsTlinea clsTlinea1 = new SPXSeguridad.data.cls.clsTlinea();
        private void frmEditarQuery_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            //groupBox1.Visible = false;


            origen_datosTableAdapter1.Fill(dsPar1.origen_datos);
            dsPar1.origen_datos.Addorigen_datosRow("", "Ninguno", "", "", "", "", 0, "", false, "", 0);

            
            clsTlinea1.FillSinLogo(dsSPXSeguridad1.linea);
    
   

            if (codQuery != 0)
            {
                cgq_parametrosqueryTableAdapter1.FillByCod_query(dsPar1.cgq_parametrosquery, codQuery);
                cgq_queryTableAdapter1.FillByCod_query(dsPar1.cgq_query, codQuery);
                txtNombre.Text = dsPar1.cgq_query[0].nombre_query.Trim();
                txtSql.Text = dsPar1.cgq_query[0].sentencia_sql.Trim();

                if (!dsPar1.cgq_query[0].Iscampo_fechaNull())
                    txtCampoFecha.Text = dsPar1.cgq_query[0].campo_fecha.Trim();

                if (!dsPar1.cgq_query[0].Isfiltra_fechaNull())
                chkFiltraxPeriodo.Checked = dsPar1.cgq_query[0].filtra_fecha;

                if (!dsPar1.cgq_query[0].Isperiodo_inicialNull())
                nmPeriodoInicial.Value = dsPar1.cgq_query[0].periodo_inicial;

              
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private bool guardar()
        {
            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El nombre es obligatorio","Error de Validacion");
                return false;
            }
            if (txtSql.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La sentencia SQL es obligatoria", "Error de Validacion");
                return false;
            }
           

            if (codQuery == 0)
            {
               codQuery = (int)cgq_queryTableAdapter1.Insert(txtNombre.Text, txtSql.Text, false,
                    true, null, 
                   (int?)null,
                    chkFiltraxPeriodo.Checked,
                    null,
                    txtCampoFecha.Text,(int)nmPeriodoInicial.Value,
                    false,
                    false,"",false,"","");
                
            }
            else
            {
                cgq_queryTableAdapter1.UpdateQuery(txtNombre.Text,txtSql.Text,false,true,DateTime.Now,
                   null,
                    chkFiltraxPeriodo.Checked,null,
                    txtCampoFecha.Text,(int)nmPeriodoInicial.Value,
                   false,false,"",false, "","",codQuery);
                //Close();
            }
            
            System.Media.SystemSounds.Beep.Play();
            return true;
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = txtSql.Text; 
           DataConector obj = new DataConector();
            string actual = obj.CadenaConexion;
            try
            {
               
               

                grddatos.DataSource = obj.ejecutarConsulta(sql).Tables[0];
                
            }
            catch (Exception ex){
                MessageBox.Show("Error en la consulta: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        bool eventosEncendidos = true;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            //prcesamos los select
            procesarTxt(txtSql);
        }

        private void procesarText(string texto, System.Windows.Forms.RichTextBox txt, bool caseSencitive)
        {
            int k = 0;
            string txtOrigen = "";
            if (caseSencitive)
            {
                txtOrigen = txt.Text;
            }
            else
            {
                txtOrigen = txt.Text.ToUpper();
            }

            for (k = 0; k < txtOrigen.Length; k++)
            {
                k = txtOrigen.IndexOf(texto, k);

                if (k < 0) break;
                if (k > 0)
                {
                    if (txtOrigen.ToCharArray()[k - 1] != ' ' && (int)txtOrigen.ToCharArray()[k - 1] != 10)
                        continue;
                }
                if (k + texto.Length < txtOrigen.Length)
                {
                    if (txtOrigen.ToCharArray()[k + texto.Length] != ' ' && (int)txtOrigen.ToCharArray()[k + texto.Length] != 10)
                        continue;
                }
                txt.Select(k, texto.Length);
                txt.SelectionColor = Color.Blue;

            }
        }

        private void procesarTxt(System.Windows.Forms.RichTextBox txtSql)
        {
            ////prcesamos los select
            //int lineaActual = txtSql.SelectionStart;
            //txtSql.SelectAll();
            //txtSql.SuspendLayout();
            //txtSql.SelectionColor = Color.Black;
            //procesarText("SELECT", txtSql, false);
            //procesarText("FROM", txtSql, false);
            //procesarText("JOIN", txtSql, false);
            //procesarText("WHERE", txtSql, false);
            //procesarText("AND", txtSql, false);
            //procesarText("OR", txtSql, false);
            //procesarText("LEFT", txtSql, false);
            //procesarText("INNER", txtSql, false);
            //procesarText("RIGHT", txtSql, false);
            //procesarText("LIKE", txtSql, false);
            //procesarText("ON", txtSql, false);
            //txtSql.Select(lineaActual, 0);
            //txtSql.PerformLayout();
            //txtSql.ResumeLayout(true);
        }

     

        private void btnAgregarParametros_Click(object sender, EventArgs e)
        {
            if (codQuery == 0)
            {
                MessageBox.Show("Debe primero guardar el Query!");
                return;
            }
        
            frmParametro fr = new frmParametro();
            fr.codQuery = codQuery;
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cgq_parametrosqueryTableAdapter1.FillByCod_query(dsPar1.cgq_parametrosquery, codQuery);
            }
        }

        private void btnEditarParametro_Click(object sender, EventArgs e)
        {
            if (grdParametros.Columns["cod_parametros_query"].Text.Trim() == string.Empty)
            {
                return;
            }
        
            frmParametro fr = new frmParametro();
            fr.codQuery = codQuery;
            fr.codparametro = int.Parse(grdParametros.Columns["cod_parametros_query"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cgq_parametrosqueryTableAdapter1.FillByCod_query(dsPar1.cgq_parametrosquery, codQuery);
            }
        }

        private void btnEliminarParametro_Click(object sender, EventArgs e)
        {
            if (grdParametros.Columns["cod_parametros_query"].Text.Trim() == string.Empty)
            {
                return;
            }
            if (MessageBox.Show("Esta seguro de eliminar el registro!","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    cgq_parametrosquery_ultimo_valor1.DeleteBycod_parametros_query(int.Parse(grdParametros.Columns["cod_parametros_query"].Text));
                    cgq_parametrosqueryTableAdapter1.DeleteQuery(int.Parse(grdParametros.Columns["cod_parametros_query"].Text));
                    cgq_parametrosqueryTableAdapter1.FillByCod_query(dsPar1.cgq_parametrosquery, codQuery);
                }catch(Exception ex){
                    MessageBox.Show("Error al eliminar el registro \r\n" + ex.Message);
                }
            }
        }

        private void btnGuardarYcerrar_Click(object sender, EventArgs e)
        {
            if (guardar())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

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
    public partial class frmParametro : Form
    {
        public frmParametro()
        {
            InitializeComponent();
        }

        public int codQuery = 0;
        public int codparametro = 0;


        data.cls.clsTtipofiltro_query_rpt tipofiltro_query_rptTableAdapter1 = new data.cls.clsTtipofiltro_query_rpt();
        data.cls.clsTcgq_parametrosquery cgq_parametrosqueryTableAdapter1 = new data.cls.clsTcgq_parametrosquery();

        private void frmParametro_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            panel1.BackColor = SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.verColor();
            
            tipofiltro_query_rptTableAdapter1.Fill(dsSPXQuery1.tipofiltro_query_rpt);
            if (codparametro != 0)
            {
                cnn a=new cnn();
                
                cgq_parametrosqueryTableAdapter1.fillById(dsSPXQuery1.cgq_parametrosquery, codparametro);
                txtCampo.Text = dsSPXQuery1.cgq_parametrosquery[0].campo.Trim();
                txtEtiqueta.Text = dsSPXQuery1.cgq_parametrosquery[0].caption.Trim();
                if (!dsSPXQuery1.cgq_parametrosquery[0].Isvalor_por_defectoNull())
                txtValorxDefecto.Text = dsSPXQuery1.cgq_parametrosquery[0].valor_por_defecto;    
                cmbTipoDatos.SelectedValue = dsSPXQuery1.cgq_parametrosquery[0].cod_tipo_filtro;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCampo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El campo es obligatorio!!");
                return;
            }
            if (txtEtiqueta.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La etiqueta es obligatoria!!");
                return;
            }
            if (cmbTipoDatos.SelectedValue == null || cmbTipoDatos.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("el tipo de datos!");
                return;
            }

            if (codparametro == 0)
            {
                cgq_parametrosqueryTableAdapter1.Insert(codQuery, txtCampo.Text, txtEtiqueta.Text,
                    int.Parse(cmbTipoDatos.SelectedValue.ToString()), txtValorxDefecto.Text);
            }else{
                cgq_parametrosqueryTableAdapter1.UpdateReducido( txtCampo.Text, txtEtiqueta.Text,
                    int.Parse(cmbTipoDatos.SelectedValue.ToString()), txtValorxDefecto.Text, codparametro);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

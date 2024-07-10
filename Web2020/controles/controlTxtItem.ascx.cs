using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.controles
{
    [Serializable]
    public partial class controlTxtItem : System.Web.UI.UserControl
    {
        private bool visible = true;

        public bool Visibilidad { get { return visible; } }
        public string Tooltip { set { btnCerrar.ToolTip = value; } get { return btnCerrar.ToolTip; } }

        public bool mostrarBoton { set { btnCerrar.Visible = value; } }

        private int anchoTexto = 9;
        public int AnchoTExto { set { anchoTexto = value; } get { return anchoTexto; } }
        public event EventHandler despuesDeQuitar;

        public string Value { set { if (lblCodigo != null) lblCodigo.Text = value; } get { return lblCodigo.Text; } }
        public string Text
        {
            set { if (lblTexto != null) lblTexto.Text = value; }
            get { return lblTexto.Text; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            if (btnCerrar != null)
            {
                btnCerrar.Attributes.Clear();
                btnCerrar.Attributes.Add("onmouseover", "javascript:this.src='../../img/web/cerrar2.png '");
                btnCerrar.Attributes.Add("onmouseout", "javascript:this.src='../../img/web/cerrar.png '");
            }
            //}
        }

        protected void btnCerrar_Click(object sender, ImageClickEventArgs e)
        {
            if (despuesDeQuitar != null) despuesDeQuitar(this, EventArgs.Empty);
            divContainer.Visible = false;
            visible = false;
            lblTexto.Text = "";
            lblCodigo.Text = "";
            btnCerrar.Visible = false;


        }
    }
}
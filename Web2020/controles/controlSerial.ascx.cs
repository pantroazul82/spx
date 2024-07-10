using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.controles
{
    public partial class controlSerial : System.Web.UI.UserControl
    {
        public bool ReadOnly
        {
            set
            {
                btnAgregarRepuesto.Visible = !value;
                textItemPagina.MostrarBoton = !value;

            }
        }


        public string nitCliente
        {
            set { txtNitcliente.Text = value; }
            get { return txtNitcliente.Text; }
        }

        public string fabricante
        {
            set { lblFabricante.Text = value; }
            get { return lblFabricante.Text; }
        }

        public bool esMedicion
        {
            set { chkMedicion.Checked = value; }
            get { return chkMedicion.Checked; }
        }

        public bool esListaVisible
        {
            set { chkListaVisible.Checked = value; }
            get { return chkListaVisible.Checked; }
        }

        public string modelo
        {
            set { lblModelo.Text = value; }
            get { return lblModelo.Text; }
        }


        public void ejecutarBusqueda()
        {
 //           string sql = @"select nombreFabricante,nombreModelo,serial,nitcliente,nombreCliente,nombreCiudad from dbo.vistaEquipo ";
 //           string filtro = "";
 //           int enteroNit;
 //           int.TryParse(txtNitcliente.Text, out enteroNit);
 //           if (txtNitcliente.Text.Trim() != string.Empty)
 //           {
 //               if(enteroNit !=0)
 //               {
 //                   filtro = "( nitcliente = '" + enteroNit + "' )";
 //               }
 //               else
 //               {
 //                   filtro = "(  nombreCliente like '%" + txtNitcliente.Text + "%')";
 //               }
          
 //           }
 //           if (lblFabricante.Text.Trim() != string.Empty)
 //           {
 //               if (filtro != string.Empty)
 //                   filtro = filtro + " and nombreFabricante = '" + lblFabricante.Text + "'";
 //               else
 //                   filtro = " nombreFabricante = '" + lblFabricante.Text + "'";
 //           }

 //           if (lblModelo.Text.Trim() != string.Empty)
 //           {
 //               if (filtro != string.Empty)
 //                   filtro = filtro + " and nombreModelo = '" + lblModelo.Text + "'";
 //               else
 //                   filtro = " nombreModelo = '" + lblModelo.Text + "'";
 //           }

 //           if (SearchText1.Text.Trim() != string.Empty)
 //           {
 //               if (filtro != string.Empty)
 //                   filtro = filtro + " and serial like '" + SearchText1.Text + "%'";
 //               else
 //                   filtro = " serial like '" + SearchText1.Text + "%'";
 //           }

 //           if (cmbFabricante.SelectedValue != "-1")
 //           {
 //               if (filtro != string.Empty)
 //                   filtro = filtro + " and nombreFabricante = '" + cmbFabricante.SelectedItem.Text + "' ";
 //               else
 //                   filtro = " nombreFabricante = '" + cmbFabricante.SelectedItem.Text + "' ";
 //           }
 //           if (cmbModelo.SelectedValue != "-1")
 //           {
 //               if (filtro != string.Empty)
 //                   filtro = filtro + " and nombreModelo = '" + cmbModelo.SelectedItem.Text + "'";
 //               else
 //                   filtro = "  nombreModelo = '" + cmbModelo.SelectedItem.Text + "'";
 //           }
 //           if (chkMedicion.Checked)
 //           {

 //           }
 //           if (chkMedicion.Checked)
 //           {
 //               sql = @"SELECT  vistaEquipo.* from vistaEquipo join equipos on equipos.serial = vistaEquipo.serial join Modelos on equipos.codModelo= modelos.codModelo  and equipos.codFabricante = modelos.codFabricante
 //join tipoEquipo on modelos.codTipoEquipo = tipoEquipo.codTipoEquipo where (tipoEquipo.dispositivo_medicion is not null and tipoEquipo.dispositivo_medicion=1) ";
 //               if (filtro != string.Empty)
 //               {
 //                   sql = sql + " and  " + filtro;
 //               }
 //           }
 //           else
 //           {
 //               if (filtro != string.Empty)
 //               {
 //                   sql = sql + " where " + filtro;
 //               }
 //           }
            //where serial like '123%'";
            // SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            // RadGrid1.DataSource = bd.ejecutarConsulta(sql + " order by nombreCliente asc ").Tables[0];
            // RadGrid1.DataBind();
            //RadGrid1.AllowPaging = true;

        }

        public List<string> verCodigos()
        {
            List<string> lista = new List<string>();
            for (int k = 0; k < textItemPagina.ListaItems.Count; k++)
            {
                lista.Add(textItemPagina.ListaItems[k].Value);
            }
            return lista;
        }

        public List<string> verText()
        {
            List<string> lista = new List<string>();
            for (int k = 0; k < textItemPagina.ListaItems.Count; k++)
            {
                lista.Add(textItemPagina.ListaItems[k].Text);
            }
            return lista;
        }

        public void asignarCodigos(List<string> lista)
        {

            for (int k = 0; k < lista.Count; k++)
            {
                textItemPagina.agregar(new ListItem(lista[k], lista[k]));
            }
        }

        public void limpiarControl()
        {
            textItemPagina.ListaItems.Clear();
            textItemPopPup.ListaItems.Clear();
            updatePanelTexto.Update();
        }

        #region --- Class Methods ---

        protected void Page_Load(object pSender, EventArgs pEventArgs)
        {
            textItemPagina.Visible = chkListaVisible.Checked;
            textItemPopPup.Visible = chkListaVisible.Checked;
            if (lblEventosEnncedidos.Text.Trim() == "") return;
            ListItem l2 = new ListItem("Seleccione", "-1");
            if (!cmbModelo.Items.Contains(l2))
            {
                cmbModelo.DataBind();
                cmbModelo.Items.Add(l2);
                cmbModelo.SelectedValue = "-1";
            }
            // ejecutarBusqueda();
        }

        protected void btnBuscar_Click(object pSender, EventArgs pEventArgs)
        {
            if (lblEventosEnncedidos.Text.Trim() == "") return;
            ejecutarBusqueda();
        }

        #endregion

        protected void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            Panel1_ModalPopupExtender.Show();
            lblEventosEnncedidos.Text = "ok";
            textItemPopPup.ListaItems.Clear();
            //--
            ListItem l = new ListItem("Seleccione", "-1");
            if (!cmbFabricante.Items.Contains(l))
            {
                cmbFabricante.DataBind();
                cmbFabricante.Items.Add(new ListItem("Seleccione", "-1"));
                cmbFabricante.SelectedValue = "-1";
            }
            ListItem l2 = new ListItem("Seleccione", "-1");
            if (!cmbModelo.Items.Contains(l2))
            {
                cmbModelo.DataBind();
                cmbModelo.Items.Add(l2);
                cmbModelo.SelectedValue = "-1";
            }

            ejecutarBusqueda();
            for (int k = 0; k < textItemPagina.ListaItems.Count; k++)
            {

                textItemPopPup.agregar(new ListItem(textItemPagina.ListaItems[k].Text, textItemPagina.ListaItems[k].Value));
            }

            SearchText1.Text = "";
            SearchText1.Focus();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblEventosEnncedidos.Text = "";
            Panel1_ModalPopupExtender.Hide();
        }

        protected void btnOk_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            ImageButton b = (ImageButton)sender;
            textItemPopPup.agregarSingleton(new ListItem(b.ValidationGroup, b.ValidationGroup));
            textItemPagina.agregarSingleton(new ListItem(b.ValidationGroup, b.ValidationGroup));

            lblEventosEnncedidos.Text = "";
            if (this.verCodigos().Count > 0 && OnSerialSelected != null)
            {
                OnSerialSelected(this.verCodigos()[0], new EventArgs());
            }
            updatePanelTexto.Update();

            Panel1_ModalPopupExtender.Hide();

        }

        // public EventHandler 
        public event EventHandler OnSerialSelected;

        protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            ejecutarBusqueda();
        }
        protected void cmbModelo_DataBound(object sender, EventArgs e)
        {
            ListItem l2 = new ListItem("Seleccione", "-1");
            if (!cmbModelo.Items.Contains(l2))
            {
                //cmbModelo.DataBind();
                cmbModelo.Items.Add(l2);
                cmbModelo.SelectedIndex = cmbModelo.Items.Count - 1;
            }
        }
        protected void cmbFabricante_DataBound(object sender, EventArgs e)
        {

        }
        protected void cmbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ejecutarBusqueda();
        }
    }
}
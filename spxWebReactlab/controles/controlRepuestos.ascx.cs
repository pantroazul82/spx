using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate;
using NHibernate.Criterion;
using BOLayer;


public partial class controles_controlRepuestos : System.Web.UI.UserControl
{
    #region --- Class Fields / Objects  ---

    private BOLayer.RepuestoFactory _repuestoFactory = new BOLayer.RepuestoFactory(SessionScope.FactoryScope);
    private BOLayer.Repuesto _repuestosBrowse1;

    #endregion

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
            BOLayer.Repuesto af = _repuestoFactory.Get( lista[k] );
            if (af != null)
            {
                textItemPagina.agregar(new ListItem(af.Descripcion.Trim(), lista[k]));
            }
        }
    }

    #region --- Class Methods ---

    protected void Page_Load(object pSender, EventArgs pEventArgs)
    {
   
        ObjectDataSource1.ObjectCreating += new ObjectDataSourceObjectEventHandler(Browse1_ObjectCreating);
        ObjectDataSource1.Selecting += new ObjectDataSourceSelectingEventHandler(Browse1_Selecting);
     
           if (lblEventosEnncedidos.Text.Trim() =="") return;  
        if (!IsPostBack)
        {
            Browse1.Sort("CodRepuesto", SortDirection.Ascending);
        }
        // Generate Event Handlers
    }

    protected void Browse1_RowDataBound(object pSender, GridViewRowEventArgs pEventArgs)
    {
        if (lblEventosEnncedidos.Text.Trim() == "") return;
        if (pEventArgs.Row.RowType == DataControlRowType.Header)
        {
            // If there is no Sort Expression then exit (nothing to do)
            if (string.IsNullOrEmpty((pSender as GridView).SortExpression)) return;
            int _index = WebUtils.FindColumnIndex((pSender as GridView), (pSender as GridView).SortExpression);
            // If there is Column could not be found also exit.
            if (_index < 0) return;
            Image _sortImage = new Image();
            if ((pSender as GridView).SortDirection == SortDirection.Ascending)
            {
                _sortImage.ImageUrl = @"../img/web/asc.gif";
            }
            else
            {
                _sortImage.ImageUrl = @"../img/web/desc.gif";
            }
            pEventArgs.Row.Cells[_index].Controls.Add(_sortImage);
        }
    }

    protected void Browse1_Sorting(object pSender, GridViewSortEventArgs pEventArgs)
    {
        if (lblEventosEnncedidos.Text.Trim() == "") return;
        // Calls this method to adapt the sort syntax (required for Composite sorting).
        WebUtils.SortExpressionTransformer(pEventArgs);
        // Clears the Search TextBox when Browse Sorts
        SearchText1.Text = string.Empty;

    }

    public ICriteria Browse1_GetCriteria()
    {
        if (lblEventosEnncedidos.Text.Trim() == "") return null;// _accesorioFactory.GetBasicCriteria();
        ICriteria _criteria = _repuestoFactory.GetBasicCriteria();
        
        
        if (SearchText1.Text.Trim() != string.Empty)
        {
            
            _criteria.Add(
                NHibernate.Criterion.Expression.Or(
                    NHibernate.Criterion.Expression.Like("CodRepuesto", SearchText1.Text, NHibernate.Criterion.MatchMode.Start),
                    NHibernate.Criterion.Expression.Like("Descripcion", SearchText1.Text, NHibernate.Criterion.MatchMode.Start)
                    )                
             );
        }
        return _criteria;
    }

    protected void Browse1_ObjectCreating(object pSender, ObjectDataSourceEventArgs pEventArgs)
    {
        if (lblEventosEnncedidos.Text.Trim() == "") return;
        pEventArgs.ObjectInstance = _repuestoFactory;

    }

    protected void Browse1_Selecting(object pSender, ObjectDataSourceSelectingEventArgs pEventArgs)
    {
       // if (lblEventosEnncedidos.Text.Trim() == "") return;
        if (pEventArgs.ExecutingSelectCount)
        {
            pEventArgs.InputParameters.Remove("pSortExpression");
        }

        ICriteria CR = Browse1_GetCriteria();
        if (CR == null)
        {
          pEventArgs.InputParameters["pCriteria"]=  _repuestoFactory.GetBasicCriteria();
            return;
        }
        pEventArgs.InputParameters["pCriteria"] = CR;
       
        CR = Browse1_GetCriteria();
        lblEncontrados.Text = _repuestoFactory.Count(CR).ToString();
        lbldesde.Text = ((Browse1.PageIndex * Browse1.PageSize) + 1).ToString();

        if (((Browse1.PageIndex + 1) * Browse1.PageSize) < _repuestoFactory.Count(CR))
            lblHasta.Text = (((Browse1.PageIndex + 1) * Browse1.PageSize)).ToString();
        else
            lblHasta.Text = (
                    ((Browse1.PageIndex + 1) * Browse1.PageSize) -
                    (
                        ((Browse1.PageIndex + 1) * Browse1.PageSize) -
                         _repuestoFactory.Count(CR)
                    )
                ).ToString();
    }

    /// <summary>
    /// Finds and return the Template Field (BaseProperty Template) related to this Header Text
    /// </summary>
    /// <remarks>
    /// Use this Method to , for example, dynamically hide a Column, etc.
    /// </remarks>
    ///<param name="pHeaderText">Property Header Text to find</param>
    protected DataControlField Browse1_GetProperty(string pHeaderText)
    {
        if (lblEventosEnncedidos.Text.Trim() == "") return null;
        if (string.IsNullOrEmpty(pHeaderText)) throw new ArgumentNullException("pHeaderText");
        foreach (DataControlField _dcf in Browse1.Columns)
        {
            string _headerText = _dcf.HeaderText.Replace(" ", string.Empty);
            if (_headerText == pHeaderText) return _dcf;
        }
        return null;

    }

    protected void Browse1_PreRender(object pSender, EventArgs pEventArgs)
    {
        if (lblEventosEnncedidos.Text.Trim() == "") return;
        if (IsPostBack)
        {
            Browse1.DataBind();
        }
    }

    protected void btnBuscar_Click(object pSender, EventArgs pEventArgs)
    {
        if (lblEventosEnncedidos.Text.Trim() == "") return;
        Browse1.DataBind();
    }


    #endregion

    protected void btnAgregarRepuesto_Click(object sender, EventArgs e)
    {
        Panel1_ModalPopupExtender.Show();
        lblEventosEnncedidos.Text = "ok";
        textItemPopPup.ListaItems.Clear();

        for (int k = 0; k < textItemPagina.ListaItems.Count; k++)
        {

            textItemPopPup.agregar(new ListItem(textItemPagina.ListaItems[k].Text, textItemPagina.ListaItems[k].Value));
        }

        SearchText1.Text = "";
        Browse1.DataBind();
        SearchText1.Focus();
    }

    protected void btnSeleccionarMarcados_Click(object sender, ImageClickEventArgs e)
    {
        seleccionarMarcados();
    }

    private void seleccionarMarcados()
    {
        textItemPagina.ListaItems.Clear();
        for (int k = 0; k < textItemPopPup.ListaItems.Count; k++)
        {
            textItemPagina.agregar(new ListItem(textItemPopPup.ListaItems[k].Text, textItemPopPup.ListaItems[k].Value));
        }
        lblEventosEnncedidos.Text = "";
        updatePanelTexto.Update();
        Panel1_ModalPopupExtender.Hide();

    }

    protected void btnCancelar_Click(object sender, ImageClickEventArgs e)
    {
        lblEventosEnncedidos.Text = "";
        Panel1_ModalPopupExtender.Hide();
    }

    protected void btnOk_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        ImageButton b = (ImageButton)sender;
        int cantidad = 0;

        //buscamos la fila donde esta el control
        for (int k = 0; k < Browse1.Rows.Count; k++)
        {
            if (Browse1.Rows[k].FindControl(b.ID) != null && 
                b.ValidationGroup.Trim() == ((ImageButton)Browse1.Rows[k].FindControl(b.ID)).ValidationGroup.Trim())
            {
                int.TryParse(((DropDownList)Browse1.Rows[k].FindControl("cmbCantidad")).SelectedValue,out cantidad);
            }
        }
        textItemPopPup.agregar(new ListItem(b.CommandName.Trim()+" ("+cantidad+")", b.ValidationGroup));
    }

    public void agregarItem(string codigo,string nombre,int cantidad) 
    {
        textItemPagina.agregar(new ListItem(nombre.Trim() + " (" + cantidad + ")", codigo));
    }
}

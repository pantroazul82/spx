using System; 
using System.Collections.Generic; 
using System.Web; 
using System.Web.UI.WebControls; 
using NHibernate.Criterion; 
using NHibernate; 
using BOLayer; 

public partial class frm_ordenPrestamo_frmListadoOrdenesPrestamo : System.Web.UI.Page
{


#region --- Class Fields / Objects  ---

private BOLayer.OrdenPrestamoFactory _ordenPrestamoFactory = new BOLayer.OrdenPrestamoFactory(SessionScope.FactoryScope);
private BOLayer.OrdenPrestamo _ordenPrestamoBrowse1;

#endregion


#region --- Class Properties ---

public BOLayer.OrdenPrestamo OrdenPrestamoBrowse1 
{
get
{
if ( Browse1.SelectedIndex < 0  ) {   _ordenPrestamoBrowse1 = null; } else if ( _ordenPrestamoBrowse1 == null ) {    _ordenPrestamoBrowse1 = Browse1_GetCurrent("Select",Browse1.SelectedIndex);} 
return _ordenPrestamoBrowse1;
}
}


#endregion


#region --- Class Methods --- 

protected void Page_Load(object pSender , EventArgs pEventArgs)
{
ObjectDataSource1.ObjectCreating += new ObjectDataSourceObjectEventHandler(Browse1_ObjectCreating);
ObjectDataSource1.Selecting += new ObjectDataSourceSelectingEventHandler(Browse1_Selecting);

if (!IsPostBack ) 
{
    clsSeguridad obS = new clsSeguridad();
    obS.comprobarAcceso(Page, Session, Response, 1083);
  Browse1.Sort("CodOrdenPrestamo",SortDirection.Descending);
}
else
{
}


// Generate Event Handlers
}


/// <summary>
/// Method that uses the BO Factory to fetch the object referenced by the values contained in the DataKey Collection. The DataKey Collection contains the Primary Key values.
/// </summary>
protected BOLayer.OrdenPrestamo Browse1_GetCurrent(string pAction, int pIndex)
{
    if (pAction == "Insert") return new BOLayer.OrdenPrestamo();
    // Add extra check to make sure that the index is not greater than the amount of rows
    if (Browse1.DataKeys.Count <= pIndex)
    {
        return null;
    }
    System.Int32 _codOrdenPrestamo = (Int32)Browse1.DataKeys[pIndex][0];
    BOLayer.OrdenPrestamo _ordenPrestamoBrowse1 = _ordenPrestamoFactory.Fetch(_codOrdenPrestamo);
    return _ordenPrestamoBrowse1;
}


protected void Browse1_RowDataBound(object pSender , GridViewRowEventArgs pEventArgs)
{
if ( pEventArgs.Row.RowType == DataControlRowType.Header )
{
// If there is no Sort Expression then exit (nothing to do)
if ( string.IsNullOrEmpty((pSender as GridView).SortExpression)) return;
int _index = WebUtils.FindColumnIndex((pSender as GridView), (pSender as GridView).SortExpression);
// If there is Column could not be found also exit.
if (_index < 0) return;
Image _sortImage = new Image();
if ( (pSender as GridView).SortDirection == SortDirection.Ascending )
{
_sortImage.ImageUrl = @"~/img/web/asc.gif" ;
}else{
_sortImage.ImageUrl = @"~/img/web/desc.gif" ;
}
pEventArgs.Row.Cells[_index].Controls.Add(_sortImage);
}
if ( pEventArgs.Row.RowType == DataControlRowType.DataRow )
{
WebControl _codOrdenPrestamo_DTypeVal1 = pEventArgs.Row.FindControl("codOrdenPrestamo_DTypeVal1") as WebControl;
if (_codOrdenPrestamo_DTypeVal1 != null) _codOrdenPrestamo_DTypeVal1.Enabled = false;
WebControl _loginResponsable_DTypeVal1 = pEventArgs.Row.FindControl("loginResponsable_DTypeVal1") as WebControl;
if (_loginResponsable_DTypeVal1 != null) _loginResponsable_DTypeVal1.Enabled = false;
WebControl _loginSolicito_DTypeVal1 = pEventArgs.Row.FindControl("loginSolicito_DTypeVal1") as WebControl;
if (_loginSolicito_DTypeVal1 != null) _loginSolicito_DTypeVal1.Enabled = false;
WebControl _loginAutorizo_DTypeVal1 = pEventArgs.Row.FindControl("loginAutorizo_DTypeVal1") as WebControl;
if (_loginAutorizo_DTypeVal1 != null) _loginAutorizo_DTypeVal1.Enabled = false;
WebControl _loginAceptado_DTypeVal1 = pEventArgs.Row.FindControl("loginAceptado_DTypeVal1") as WebControl;
if (_loginAceptado_DTypeVal1 != null) _loginAceptado_DTypeVal1.Enabled = false;
WebControl _loginRecibido_DTypeVal1 = pEventArgs.Row.FindControl("loginRecibido_DTypeVal1") as WebControl;
if (_loginRecibido_DTypeVal1 != null) _loginRecibido_DTypeVal1.Enabled = false;
WebControl _loginAnulo_DTypeVal1 = pEventArgs.Row.FindControl("loginAnulo_DTypeVal1") as WebControl;
if (_loginAnulo_DTypeVal1 != null) _loginAnulo_DTypeVal1.Enabled = false;
WebControl _fechaOrden_DTypeVal1 = pEventArgs.Row.FindControl("fechaOrden_DTypeVal1") as WebControl;
if (_fechaOrden_DTypeVal1 != null) _fechaOrden_DTypeVal1.Enabled = false;
WebControl _fechaDevolucion_DTypeVal1 = pEventArgs.Row.FindControl("fechaDevolucion_DTypeVal1") as WebControl;
if (_fechaDevolucion_DTypeVal1 != null) _fechaDevolucion_DTypeVal1.Enabled = false;
WebControl _codPais_DTypeVal1 = pEventArgs.Row.FindControl("codPais_DTypeVal1") as WebControl;
if (_codPais_DTypeVal1 != null) _codPais_DTypeVal1.Enabled = false;
WebControl _codDepartamento_DTypeVal1 = pEventArgs.Row.FindControl("codDepartamento_DTypeVal1") as WebControl;
if (_codDepartamento_DTypeVal1 != null) _codDepartamento_DTypeVal1.Enabled = false;
WebControl _codCiudad_DTypeVal1 = pEventArgs.Row.FindControl("codCiudad_DTypeVal1") as WebControl;
if (_codCiudad_DTypeVal1 != null) _codCiudad_DTypeVal1.Enabled = false;
WebControl _codOrdenServicio_DTypeVal1 = pEventArgs.Row.FindControl("codOrdenServicio_DTypeVal1") as WebControl;
if (_codOrdenServicio_DTypeVal1 != null) _codOrdenServicio_DTypeVal1.Enabled = false;
WebControl _obsIniciales_DTypeVal1 = pEventArgs.Row.FindControl("obsIniciales_DTypeVal1") as WebControl;
if (_obsIniciales_DTypeVal1 != null) _obsIniciales_DTypeVal1.Enabled = false;
WebControl _obsAprobacion_DTypeVal1 = pEventArgs.Row.FindControl("obsAprobacion_DTypeVal1") as WebControl;
if (_obsAprobacion_DTypeVal1 != null) _obsAprobacion_DTypeVal1.Enabled = false;
WebControl _obsEntrega_DTypeVal1 = pEventArgs.Row.FindControl("obsEntrega_DTypeVal1") as WebControl;
if (_obsEntrega_DTypeVal1 != null) _obsEntrega_DTypeVal1.Enabled = false;
WebControl _obsDevolucion_DTypeVal1 = pEventArgs.Row.FindControl("obsDevolucion_DTypeVal1") as WebControl;
if (_obsDevolucion_DTypeVal1 != null) _obsDevolucion_DTypeVal1.Enabled = false;
WebControl _codEstadoOrdenPrestamo_DTypeVal1 = pEventArgs.Row.FindControl("codEstadoOrdenPrestamo_DTypeVal1") as WebControl;
if (_codEstadoOrdenPrestamo_DTypeVal1 != null) _codEstadoOrdenPrestamo_DTypeVal1.Enabled = false;
}
}

protected void Browse1_Sorting(object pSender , GridViewSortEventArgs pEventArgs)
{

// Calls this method to adapt the sort syntax (required for Composite sorting).
WebUtils.SortExpressionTransformer(pEventArgs);


// Clears the Search TextBox when Browse Sorts
txtFiltro.Text = string.Empty;

}


public ICriteria Browse1_GetCriteria()
{
 ICriteria _criteria = _ordenPrestamoFactory.GetBasicCriteria();
_criteria.CreateCriteria("Ciudade","Ciudade",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("EstadosOrdenPrestamo","EstadosOrdenPrestamo",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("OrdenServicio","OrdenServicio",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("Usuario0","Usuario0",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("Usuario01","Usuario01",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("Usuario02","Usuario02",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("Usuario03","Usuario03",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("Usuario04","Usuario04",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
    //miramos los filtros de acuerdo a los permisos

if (chkAnuladas.Checked)
{
    _criteria.Add(Expression.Not(Expression.Eq("CodEstadoOrdenPrestamo", 8)));
}

string msg = "";
if (SPXSeguridad.verificadorPermisos.ejecutarAccion(1002, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg) ||
    SPXSeguridad.verificadorPermisos.ejecutarAccion(1017, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg) ||
    SPXSeguridad.verificadorPermisos.ejecutarAccion(1010, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg) ||
    SPXSeguridad.verificadorPermisos.ejecutarAccion(1104, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
{ }
else { 
  
    _criteria.Add( 
  
                  Expression.Or
                  (
                        Expression.Or(

                            Expression.Or(        Expression.Eq("LoginResponsable",Session["ss_login"].ToString()),
                                              Expression.Eq("LoginSolicito",Session["ss_login"].ToString()))
                            ,
                            Expression.Or(        Expression.Eq("LoginAceptado",Session["ss_login"].ToString()),
                                              Expression.Eq("LoginAnulo",Session["ss_login"].ToString()))
                                    )
                  ,
                        Expression.Or(        
                                      Expression.Eq("LoginAutorizo",Session["ss_login"].ToString()),
                                      Expression.Eq("LoginRecibido",Session["ss_login"].ToString())
                                     )
                  )
               );
                    
}




if (txtFiltro.Text.Trim() != string.Empty)
{
    if (cmbFiltros.SelectedValue.Trim() == "1")
    {
        int a = 0;
        int.TryParse(txtFiltro.Text, out a);
        _criteria.Add(Expression.Eq("CodOrdenPrestamo", a));
    }else
    if (cmbFiltros.SelectedValue.Trim() == "2")
    {
        _criteria.Add(Expression.Like("Usuario04.Nombre", txtFiltro.Text, MatchMode.Start));
    }else if (cmbFiltros.SelectedValue.Trim() == "3")
    {
        _criteria.Add(Expression.Like("EstadosOrdenPrestamo.NombreEstadoOP", txtFiltro.Text, MatchMode.Start));
    }
}
    
    return _criteria;
}

protected void Browse1_ObjectCreating(object pSender , ObjectDataSourceEventArgs pEventArgs)
{
 pEventArgs.ObjectInstance = _ordenPrestamoFactory;

}

protected void Browse1_Selecting(object pSender , ObjectDataSourceSelectingEventArgs pEventArgs)
{
if ( pEventArgs.ExecutingSelectCount )
{
pEventArgs.InputParameters.Remove("pSortExpression");
}

         ICriteria CR = Browse1_GetCriteria();
        pEventArgs.InputParameters["pCriteria"] = CR;
        CR = Browse1_GetCriteria();
        lblEncontrados.Text = _ordenPrestamoFactory.Count(CR).ToString();
        lbldesde.Text = ((Browse1.PageIndex * Browse1.PageSize) + 1).ToString();

        if (((Browse1.PageIndex + 1) * Browse1.PageSize) < _ordenPrestamoFactory.Count(CR))
            lblHasta.Text = (((Browse1.PageIndex + 1) * Browse1.PageSize)).ToString();
        else
            lblHasta.Text = (
                    ((Browse1.PageIndex + 1) * Browse1.PageSize) -
                    (
                        ((Browse1.PageIndex + 1) * Browse1.PageSize) -
                         _ordenPrestamoFactory.Count(CR)
                    )
                ).ToString();


}

/// <summary>
/// Method that updates the BO with the current values (contained in pDictionary)
/// </summary>
///<param name="pDictionary">Dictionary with values that need to applied to the BO instance</param>
private void Browse1_Refresh(System.Collections.Specialized.IOrderedDictionary pDictionary)
{
foreach (string _key in pDictionary.Keys)
{
if (_key == "codOrdenPrestamo" ) continue;

try
{
WebUtils.SetValue( OrdenPrestamoBrowse1 , _key, pDictionary[_key] );
}
catch (Exception ex)
{
}
}
Validate();
Browse1.DataBind();
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
if( string.IsNullOrEmpty(pHeaderText) ) throw new ArgumentNullException("pHeaderText");
foreach (DataControlField _dcf in Browse1.Columns)
{
string _headerText = _dcf.HeaderText.Replace(" ",string.Empty);
if (_headerText == pHeaderText ) return _dcf;
}
return null;

}

protected void Browse1_PreRender(object pSender , EventArgs pEventArgs)
{
if (IsPostBack)
{
Browse1.DataBind();
}
}

protected void SearchBtn1_Click(object pSender, System.Web.UI.ImageClickEventArgs pEventArgs)
{
Browse1.DataBind();

}

public string Browse1_GetOrdenPrestamo_Ciudade_NombreCiudad(BOLayer.OrdenPrestamo pDataItem)
{
if ( pDataItem == null ) return "(NULL)";
if ( pDataItem.Ciudade == null ) return "(NULL)";
if ( pDataItem.Ciudade.NombreCiudad == null ) return "(NULL)";
return pDataItem.Ciudade.NombreCiudad;

}

public string Browse1_GetOrdenPrestamo_EstadosOrdenPrestamo_NombreEstadoOP(BOLayer.OrdenPrestamo pDataItem)
{
if ( pDataItem == null ) return "(NULL)";
if ( pDataItem.EstadosOrdenPrestamo == null ) return "(NULL)";
if ( pDataItem.EstadosOrdenPrestamo.NombreEstadoOP == null ) return "(NULL)";
return pDataItem.EstadosOrdenPrestamo.NombreEstadoOP;

}

public string Browse1_GetOrdenPrestamo_Usuario0_Nombre(BOLayer.OrdenPrestamo pDataItem)
{
if ( pDataItem == null ) return "(NULL)";
if ( pDataItem.Usuario0 == null ) return "(NULL)";
if ( pDataItem.Usuario0.Nombre == null ) return "(NULL)";
return pDataItem.Usuario0.Nombre;

}

public string Browse1_GetOrdenPrestamo_Usuario01_Nombre(BOLayer.OrdenPrestamo pDataItem)
{
if ( pDataItem == null ) return "(NULL)";
if ( pDataItem.Usuario01 == null ) return "(NULL)";
if ( pDataItem.Usuario01.Nombre == null ) return "(NULL)";
return pDataItem.Usuario01.Nombre;

}


public string Browse1_GetOrdenPrestamo_Usuario02_Nombre(BOLayer.OrdenPrestamo pDataItem)
{
if ( pDataItem == null ) return "(NULL)";
if ( pDataItem.Usuario02 == null ) return "(NULL)";
if ( pDataItem.Usuario02.Nombre == null ) return "(NULL)";
return pDataItem.Usuario02.Nombre;

}


public string Browse1_GetOrdenPrestamo_Usuario03_Nombre(BOLayer.OrdenPrestamo pDataItem)
{
if ( pDataItem == null ) return "(NULL)";
if ( pDataItem.Usuario03 == null ) return "(NULL)";
if ( pDataItem.Usuario03.Nombre == null ) return "(NULL)";
return pDataItem.Usuario03.Nombre;

}

public string Browse1_GetOrdenPrestamo_Usuario04_Nombre(BOLayer.OrdenPrestamo pDataItem)
{
if ( pDataItem == null ) return "(NULL)";
if ( pDataItem.Usuario04 == null ) return "(NULL)";
if ( pDataItem.Usuario04.Nombre == null ) return "(NULL)";
return pDataItem.Usuario04.Nombre;

}

public string verREpuestos(BOLayer.OrdenPrestamo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.RepuestosxOrdenPrestamos == null ) return "";
if ( pDataItem.RepuestosxOrdenPrestamos.Count == 0 ) return "";
    string res="";
    for(int k=0;k<pDataItem.RepuestosxOrdenPrestamos.Count;k++)
    {
        string a = "(" + pDataItem.RepuestosxOrdenPrestamos[k].CodRepuesto.Trim() + ")" + pDataItem.RepuestosxOrdenPrestamos[k].Repuesto.Descripcion + "  &nbsp;<strong>" + pDataItem.RepuestosxOrdenPrestamos[k].CantidadSolicitada + "</strong><br><br>";
        res+= a;
    }
return res;

}
 


protected void Browse1_SelectedIndexChanged(object pSender , EventArgs pEventArgs)
{
}   
#endregion
protected void expExcel_Click(object sender, System.Web.UI.ImageClickEventArgs e)
{
    C1.C1Excel.C1XLBook libro = new C1.C1Excel.C1XLBook();
    C1.C1Excel.XLStyle estiloUno = new C1.C1Excel.XLStyle(libro);
    estiloUno.Font = new System.Drawing.Font("Arial", 20, System.Drawing.FontStyle.Bold);

    C1.C1Excel.XLStyle estiloDos = new C1.C1Excel.XLStyle(libro);
    estiloDos.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);


    C1.C1Excel.XLStyle estiloTres = new C1.C1Excel.XLStyle(libro);
    estiloTres.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);

    C1.C1Excel.XLStyle estiloSubarayado = new C1.C1Excel.XLStyle(libro);
    estiloSubarayado.AlignHorz = C1.C1Excel.XLAlignHorzEnum.Center;
    /*estiloSubarayado.BorderColorBottom = System.Drawing.Color.Black;
    estiloSubarayado.BorderBottom= C1.C1Excel.XLLineStyleEnum.Medium;       
    */

    libro.Sheets[0].Name = "Ordenes de Prestamo";
    libro.Sheets[0][0, 0].Value = "Ordenes de Prestamo";
    libro.Sheets[0][0, 0].Style = estiloUno;

    libro.Sheets[0][2, 0].Value = "Cod Orden Prestamo";
    libro.Sheets[0][2, 0].Style = estiloDos;
    libro.Sheets[0].Columns[0].Width = 2100;
    libro.Sheets[0][2, 1].Value = "Estado";
    libro.Sheets[0][2, 1].Style = estiloDos;
    libro.Sheets[0].Columns[1].Width = 2100;
    libro.Sheets[0][2, 2].Value = "Responsable";
    libro.Sheets[0][2, 2].Style = estiloDos;
    libro.Sheets[0].Columns[2].Width = 2400;
    libro.Sheets[0][2, 3].Value = "Solicitada Por";
    libro.Sheets[0][2, 3].Style = estiloDos;
    libro.Sheets[0].Columns[3].Width = 2100;
    libro.Sheets[0][2, 4].Value = "Fecha";
    libro.Sheets[0][2, 4].Style = estiloDos;
    libro.Sheets[0].Columns[4].Width = 2400;
    libro.Sheets[0][2, 5].Value = "Observaciones Iniciales";
    libro.Sheets[0][2, 5].Style = estiloDos;
    libro.Sheets[0].Columns[5].Width = 3100;

    libro.Sheets[0][2, 6].Value = "Autorizada Por";
    libro.Sheets[0][2, 6].Style = estiloDos;
    libro.Sheets[0].Columns[6].Width = 2000;

    libro.Sheets[0][2, 7].Value = "Observaciones Aprobacion";
    libro.Sheets[0][2, 7].Style = estiloDos;
    libro.Sheets[0].Columns[7].Width = 2000;

    libro.Sheets[0][2, 8].Value = "Aceptada Por";
    libro.Sheets[0][2, 8].Style = estiloDos;
    libro.Sheets[0].Columns[8].Width = 2000;

    libro.Sheets[0][2, 9].Value = "Observaciones de Entrega";
    libro.Sheets[0][2, 9].Style = estiloDos;
    libro.Sheets[0].Columns[9].Width = 2000;

    libro.Sheets[0][2, 10].Value = "Recibido Por";
    libro.Sheets[0][2, 10].Style = estiloDos;
    libro.Sheets[0].Columns[10].Width = 2000;

    libro.Sheets[0][2, 11].Value = "Observaciones de Devolucion";
    libro.Sheets[0][2, 11].Style = estiloDos;
    libro.Sheets[0].Columns[11].Width = 2000;

    ICriteria ic = Browse1_GetCriteria();
    ic.AddOrder(Order.Asc("CodOrdenPrestamo"));

    BOLayer.OrdenPrestamoCollection arr = _ordenPrestamoFactory.GetAll(ic);

    for (int k = 0; k < arr.Count; k++)
    {
        string responsable = "";
        string solicitadoPo = "";
        string aprobadaPor = "";
        string aceptadaPor = "";
        string recibidaPor = "";
        if (arr[k].Usuario04 != null && arr[k].Usuario04.Nombre != null)
            responsable = arr[k].Usuario04.Nombre;
        if (arr[k].Usuario03 != null && arr[k].Usuario03.Nombre != null)
            solicitadoPo = arr[k].Usuario03.Nombre;
        if (arr[k].Usuario02 != null && arr[k].Usuario02.Nombre != null)
            aprobadaPor = arr[k].Usuario02.Nombre;
        if (arr[k].Usuario01 != null && arr[k].Usuario01.Nombre != null)
            aceptadaPor = arr[k].Usuario01.Nombre;
        if (arr[k].Usuario0 != null && arr[k].Usuario0.Nombre != null)
            recibidaPor = arr[k].Usuario0.Nombre;

        libro.Sheets[0][3 + k, 0].Value = arr[k].CodOrdenPrestamo;

        if (arr[k].EstadosOrdenPrestamo != null && arr[k].EstadosOrdenPrestamo.NombreEstadoOP != null)
            libro.Sheets[0][3 + k, 1].Value = arr[k].EstadosOrdenPrestamo.NombreEstadoOP;

      
            libro.Sheets[0][3 + k, 2].Value = responsable;

            libro.Sheets[0][3 + k, 3].Value = solicitadoPo;

        if (arr[k].FechaOrden != null )
            libro.Sheets[0][3 + k, 4].Value = arr[k].FechaOrden_Date;

            libro.Sheets[0][3 + k, 5].Value = arr[k].ObsIniciales;

            libro.Sheets[0][3 + k, 6].Value = aprobadaPor;

            if (arr[k].ObsAprobacion != null )
                libro.Sheets[0][3 + k, 7].Value = arr[k].ObsAprobacion;

            libro.Sheets[0][3 + k, 8].Value = aceptadaPor;

            if (arr[k].ObsEntrega != null)
                libro.Sheets[0][3 + k, 9].Value = arr[k].ObsEntrega;

            libro.Sheets[0][3 + k, 10].Value = recibidaPor;

            if (arr[k].ObsDevolucion != null)
                libro.Sheets[0][3 + k, 11].Value = arr[k].ObsDevolucion;
    }



    string ruta = Server.MapPath(@"~\Temp\");
    string archivo = Session["ss_login"].ToString() + "op.xls";
    int contador = 1;
    while (System.IO.File.Exists(ruta + @"\" + archivo))
    {
        archivo = Session["ss_login"].ToString() + "op" + "(" + (contador++) + ")" + ".xls";
    }
    libro.Save(ruta + @"\" + archivo);
    Response.Redirect(@"~\Temp\" + archivo);
}

protected void solicitar_click(object sender, System.Web.UI.ImageClickEventArgs e)
{
    Response.Redirect("frmNuevaOrden.aspx");
}

protected void linkImprimir_Click(object sender, System.Web.UI.ImageClickEventArgs e)
{
    int orden = int.Parse(((ImageButton)sender).ValidationGroup);
    //cargamos los defaults     
    SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter objDef = new SPControladoraDatos.dsSpxTableAdapters.defaultsTableAdapter();
    SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter objOP = new SPControladoraDatos.dsSpxTableAdapters.OrdenPrestamoTableAdapter();
    SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();

    objDef.Fill(dsSpx1.defaults);
    dsSpx1.EnforceConstraints = false;
    objOP.FillBycodOrdenPrestamo(dsSpx1.OrdenPrestamo, orden);


    string ruta = Server.MapPath("../rpt/");
    ruta = ruta + "/rpt.xml";
    C1.C1Report.C1Report rpt = new C1.C1Report.C1Report();
    rpt.Load(ruta, "rptOrdenPrestamo");
    Session["rutaReporte"] = ruta;
    Session["nombreReporte"] = "rptOrdenPrestamo";

    rpt.DataSource.RecordSource = rpt.DataSource.RecordSource.Replace("<<codigo>>", orden.ToString());
    #region aplicamos los defaults
    if (!dsSpx1.defaults[0].IslogotipoNull())
    {
        byte[] arr = (byte[])dsSpx1.defaults[0].logotipo;
        System.IO.Stream stream = new System.IO.MemoryStream(arr);
        System.Drawing.Image im = System.Drawing.Image.FromStream(stream);
        if (rpt.Fields.Contains("picLogo"))
        {
            rpt.Fields["picLogo"].Picture = im;
        }
    }
    if (rpt.Fields.Contains("lblTitulo"))
    {
        rpt.Fields["lblTitulo"].Value = dsSpx1.defaults[0].tituloOrdenPrestamo.Trim();
    }
    if (rpt.Fields.Contains("lblVersion"))
    {
        rpt.Fields["lblVersion"].Value = dsSpx1.defaults[0].versionOrdenPrestamo.Trim();
    }
    if (rpt.Fields.Contains("lblTipoDocumento"))
    {
        if (!dsSpx1.defaults[0].IscodigoOrdenPrestamoNull())
            rpt.Fields["lblTipoDocumento"].Value = dsSpx1.defaults[0].codigoOrdenPrestamo.Trim();
    }
    if (rpt.Fields.Contains("lblVigencia"))
    {
        if (!dsSpx1.defaults[0].IsfechaVigenciaOrdenPrestamoNull())
            rpt.Fields["lblVigencia"].Value = dsSpx1.defaults[0].fechaVigenciaOrdenPrestamo.ToShortDateString();
    }
    #endregion
    SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
    if (rpt.Fields.Contains("subRptObs"))
    {
        rpt.Fields["subRptObs"].Subreport.DataSource.ConnectionString = objData.CadenaConexionReportes;
    }
    if (!dsSpx1.OrdenPrestamo[0].IsanuladaNull() && dsSpx1.OrdenPrestamo[0].anulada)
    {
        if (rpt.Fields.Contains("lblAnulo"))
        {
            rpt.Fields["lblAnulo"].Visible = true;
        }
        if (rpt.Fields.Contains("lblNombreAnulo"))
        {
            rpt.Fields["lblNombreAnulo"].Visible = true;
        }
        if (rpt.Fields.Contains("lblAnulada"))
        {
            rpt.Fields["lblAnulada"].Visible = true;
        }
    }


    if (Session["c1report"] == null)
    {
        Session.Add("c1report", rpt);
    }
    else
    {
        Session["c1report"] = rpt;
    }
    //Session["tituloReporte"] 

    if (Session["tituloReporte"] == null)
    {
        Session.Add("tituloReporte", "Orden de Prestamo");
    }
    else
    {
        Session["tituloReporte"] = "Orden de Prestamo";
    }


    //    Session["showPdf"]
    Response.Redirect("../impresion/frmImprimir.aspx");
}



public bool verVisibleAnular(BOLayer.OrdenPrestamo pDataItem)
{
    if (pDataItem.CodEstadoOrdenPrestamo == 8)
        return false;
    string msg = "";
    return SPXSeguridad.verificadorPermisos.ejecutarAccion(1010
, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
}

    public bool verVisibleAutorizar(BOLayer.OrdenPrestamo pDataItem)
{
    if (pDataItem.CodEstadoOrdenPrestamo != 1)
        return false;
    string msg = "";
    return SPXSeguridad.verificadorPermisos.ejecutarAccion(1017
        , int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
}
       
       

public bool verVisibleRecibir(BOLayer.OrdenPrestamo pDataItem)
{
    if (pDataItem.CodEstadoOrdenPrestamo != 2)
        return false;

    string msg = "";
    return SPXSeguridad.verificadorPermisos.ejecutarAccion(1002
, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
}
       public bool verVisibleREcibirAlmacen(BOLayer.OrdenPrestamo pDataItem)
{
    if (pDataItem.CodEstadoOrdenPrestamo != 5)
        return false;

    string msg = "";
    return SPXSeguridad.verificadorPermisos.ejecutarAccion(1104
, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg);
}

protected void linkAnular_Click(object sender, System.Web.UI.ImageClickEventArgs e)
{
    int orden = int.Parse(((ImageButton)sender).ValidationGroup);

    BOLayer.OrdenPrestamoFactory f = new OrdenPrestamoFactory();
    BOLayer.OrdenPrestamo op= f.Get(orden);
    op.CodEstadoOrdenPrestamo = 8;
    op.Anulada = true;
    op.LoginAnulo = Session["ss_login"].ToString();
    f.Save(op);
    f.Commit();
}

protected void linkRechazar_Click(object sender, System.Web.UI.ImageClickEventArgs e)
{
    int orden = int.Parse(((ImageButton)sender).ValidationGroup);
    Session["op"] = orden;
    Response.Redirect("frmRechazarOp.aspx");
}

protected void linkAprobar_Click(object sender, System.Web.UI.ImageClickEventArgs e)
{
    int orden = int.Parse(((ImageButton)sender).ValidationGroup);
    Session["op"] = orden;
    Response.Redirect("frmAprobarOrdenPrestamo.aspx");
}

    protected void linkRecibir_Click(object sender, System.Web.UI.ImageClickEventArgs e)
{
    int orden = int.Parse(((ImageButton)sender).ValidationGroup);
    Session["op"] = orden;
    Response.Redirect("frmRecibirRepuestos.aspx");
}

    protected void linkDevolver_Click(object sender, System.Web.UI.ImageClickEventArgs e)
{
    int orden = int.Parse(((ImageButton)sender).ValidationGroup);
    Session["op"] = orden;
    Response.Redirect("frmEntregarRepuestos.aspx");
}
    
    
       


}

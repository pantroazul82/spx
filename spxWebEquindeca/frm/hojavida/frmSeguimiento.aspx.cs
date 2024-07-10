using System; 
using System.Collections.Generic; 
using System.Web; 
using System.Web.UI.WebControls; 
using NHibernate.Criterion; 
using NHibernate; 
using BOLayer; 


public partial class frm_hojavida_frmSeguimiento : System.Web.UI.Page
{


#region --- Class Fields / Objects  ---

private BOLayer.EquipoFactory _equipoFactory = new BOLayer.EquipoFactory(SessionScope.FactoryScope);
private BOLayer.Equipo _equiposBrowse1;

#endregion

#region --- Class Methods --- 

protected void Page_Load(object pSender , EventArgs pEventArgs)
{
    clsSeguridad obS = new clsSeguridad();
    obS.comprobarAcceso(Page, Session, Response, 1115);

ObjectDataSource1.ObjectCreating += new ObjectDataSourceObjectEventHandler(Browse1_ObjectCreating);
ObjectDataSource1.Selecting += new ObjectDataSourceSelectingEventHandler(Browse1_Selecting);

if (!IsPostBack ) 
{
    cmbFiltros.SelectedValue = "-1";
    Browse1.Sort("NitClienteUbica", SortDirection.Ascending);
}else{

}


// Generate Event Handlers
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
}
else
{
_sortImage.ImageUrl = @"~/img/web/desc.gif" ;
}
pEventArgs.Row.Cells[_index].Controls.Add(_sortImage);
}
if ( pEventArgs.Row.RowType == DataControlRowType.DataRow )
{
WebControl _codFabricante_DTypeVal1 = pEventArgs.Row.FindControl("codFabricante_DTypeVal1") as WebControl;
if (_codFabricante_DTypeVal1 != null) _codFabricante_DTypeVal1.Enabled = false;
WebControl _codFabricante_ReqVal1 = pEventArgs.Row.FindControl("CodFabricante_ReqVal1") as WebControl;
if (_codFabricante_ReqVal1 != null) _codFabricante_ReqVal1.Enabled = false;
WebControl _codModelo_DTypeVal1 = pEventArgs.Row.FindControl("codModelo_DTypeVal1") as WebControl;
if (_codModelo_DTypeVal1 != null) _codModelo_DTypeVal1.Enabled = false;
WebControl _codModelo_ReqVal1 = pEventArgs.Row.FindControl("CodModelo_ReqVal1") as WebControl;
if (_codModelo_ReqVal1 != null) _codModelo_ReqVal1.Enabled = false;
WebControl _serial_DTypeVal1 = pEventArgs.Row.FindControl("serial_DTypeVal1") as WebControl;
if (_serial_DTypeVal1 != null) _serial_DTypeVal1.Enabled = false;
WebControl _serial_ReqVal1 = pEventArgs.Row.FindControl("Serial_ReqVal1") as WebControl;
if (_serial_ReqVal1 != null) _serial_ReqVal1.Enabled = false;
WebControl _fechaLlegada_DTypeVal1 = pEventArgs.Row.FindControl("fechaLlegada_DTypeVal1") as WebControl;
if (_fechaLlegada_DTypeVal1 != null) _fechaLlegada_DTypeVal1.Enabled = false;
WebControl _fechaSalida_DTypeVal1 = pEventArgs.Row.FindControl("fechaSalida_DTypeVal1") as WebControl;
if (_fechaSalida_DTypeVal1 != null) _fechaSalida_DTypeVal1.Enabled = false;
WebControl _fechaProximoMante_DTypeVal1 = pEventArgs.Row.FindControl("fechaProximoMante_DTypeVal1") as WebControl;
if (_fechaProximoMante_DTypeVal1 != null) _fechaProximoMante_DTypeVal1.Enabled = false;
WebControl _fechaUltimoMante_DTypeVal1 = pEventArgs.Row.FindControl("fechaUltimoMante_DTypeVal1") as WebControl;
if (_fechaUltimoMante_DTypeVal1 != null) _fechaUltimoMante_DTypeVal1.Enabled = false;
WebControl _nitClienteUbica_DTypeVal1 = pEventArgs.Row.FindControl("nitClienteUbica_DTypeVal1") as WebControl;
if (_nitClienteUbica_DTypeVal1 != null) _nitClienteUbica_DTypeVal1.Enabled = false;
WebControl _codSucursalUbica_DTypeVal1 = pEventArgs.Row.FindControl("codSucursalUbica_DTypeVal1") as WebControl;
if (_codSucursalUbica_DTypeVal1 != null) _codSucursalUbica_DTypeVal1.Enabled = false;
WebControl _codTipoServicio_DTypeVal1 = pEventArgs.Row.FindControl("codTipoServicio_DTypeVal1") as WebControl;
if (_codTipoServicio_DTypeVal1 != null) _codTipoServicio_DTypeVal1.Enabled = false;
WebControl _observacionesUltimoMante_DTypeVal1 = pEventArgs.Row.FindControl("observacionesUltimoMante_DTypeVal1") as WebControl;
if (_observacionesUltimoMante_DTypeVal1 != null) _observacionesUltimoMante_DTypeVal1.Enabled = false;
WebControl _codModalidadEquipo_DTypeVal1 = pEventArgs.Row.FindControl("codModalidadEquipo_DTypeVal1") as WebControl;
if (_codModalidadEquipo_DTypeVal1 != null) _codModalidadEquipo_DTypeVal1.Enabled = false;
WebControl _codEstadoLocal_DTypeVal1 = pEventArgs.Row.FindControl("codEstadoLocal_DTypeVal1") as WebControl;
if (_codEstadoLocal_DTypeVal1 != null) _codEstadoLocal_DTypeVal1.Enabled = false;
WebControl _fechaProximaProgramacion_DTypeVal1 = pEventArgs.Row.FindControl("fechaProximaProgramacion_DTypeVal1") as WebControl;
if (_fechaProximaProgramacion_DTypeVal1 != null) _fechaProximaProgramacion_DTypeVal1.Enabled = false;
WebControl _fechaUltimoTraslado_DTypeVal1 = pEventArgs.Row.FindControl("fechaUltimoTraslado_DTypeVal1") as WebControl;
if (_fechaUltimoTraslado_DTypeVal1 != null) _fechaUltimoTraslado_DTypeVal1.Enabled = false;
WebControl _codAdicional_DTypeVal1 = pEventArgs.Row.FindControl("codAdicional_DTypeVal1") as WebControl;
if (_codAdicional_DTypeVal1 != null) _codAdicional_DTypeVal1.Enabled = false;
WebControl _obsEquipo_DTypeVal1 = pEventArgs.Row.FindControl("obsEquipo_DTypeVal1") as WebControl;
if (_obsEquipo_DTypeVal1 != null) _obsEquipo_DTypeVal1.Enabled = false;
WebControl _codTipoPropiedad_DTypeVal1 = pEventArgs.Row.FindControl("codTipoPropiedad_DTypeVal1") as WebControl;
if (_codTipoPropiedad_DTypeVal1 != null) _codTipoPropiedad_DTypeVal1.Enabled = false;
WebControl _fechaCambioTipoPropiedad_DTypeVal1 = pEventArgs.Row.FindControl("fechaCambioTipoPropiedad_DTypeVal1") as WebControl;
if (_fechaCambioTipoPropiedad_DTypeVal1 != null) _fechaCambioTipoPropiedad_DTypeVal1.Enabled = false;
WebControl _usuarioCambio_DTypeVal1 = pEventArgs.Row.FindControl("usuarioCambio_DTypeVal1") as WebControl;
if (_usuarioCambio_DTypeVal1 != null) _usuarioCambio_DTypeVal1.Enabled = false;
}
}

protected void Browse1_Sorting(object pSender , GridViewSortEventArgs pEventArgs)
{

// Calls this method to adapt the sort syntax (required for Composite sorting).
WebUtils.SortExpressionTransformer(pEventArgs);


// Clears the Search TextBox when Browse Sorts
SearchText1.Text = string.Empty;

}



public ICriteria Browse1_GetCriteria()
{
 ICriteria _criteria = _equipoFactory.GetBasicCriteria();
_criteria.CreateCriteria("ModalidadEquipo","ModalidadEquipo",NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("Modelo", "Modelo", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("Modelo.Fabricante", "Fabricante", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("SucursalCliente", "SucursalCliente", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("SucursalCliente.Cliente", "Cliente", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("SucursalCliente.Ciudade", "Ciudade", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
_criteria.CreateCriteria("SucursalCliente.Ciudade.RegionesXusuarios","RegionesXusuarios",NHibernate.SqlCommand.JoinType.InnerJoin);
    
    
#region zona de busquedas
if (SearchText1.Text.Trim() != string.Empty)
{
    switch (cmbFiltros.SelectedValue.Trim())
    {
            //serial;
        case "1": { 
            _criteria.Add(NHibernate.Criterion.Expression.Like("Serial",SearchText1.Text,MatchMode.Start));
            break; 
        }
        //Nit Cliente;
        case "2":
            {
                _criteria.Add(NHibernate.Criterion.Expression.Like("NitClienteUbica", SearchText1.Text, MatchMode.Start));
                break;
            }
        //Nombre de Cliente;
        case "3":
            {
                _criteria.Add(NHibernate.Criterion.Expression.Like("Cliente.NombreCliente", SearchText1.Text, MatchMode.Start));
                break;
            }
        //Socio de Negocio
        case "4":
            {
                _criteria.Add(NHibernate.Criterion.Expression.Like("Cliente.NumeroSocio", SearchText1.Text, MatchMode.Start));
                break;
            }

        case "5":
            {
                _criteria.Add(NHibernate.Criterion.Expression.Like("Modelo.NombreModelo", SearchText1.Text, MatchMode.Start));
                break;
            }
    }
}
#endregion

#region permisos especiales para que el ingeniero vea solo lo de la zona que le toca
//_equiposBrowse1.SucursalCliente.Ciudade.RegionesXusuarios[0].Login
_criteria.Add(NHibernate.Criterion.Expression.Eq("RegionesXusuarios.Login", Session["ss_login"].ToString()));
#endregion

return _criteria;
}


protected void Browse1_ObjectCreating(object pSender , ObjectDataSourceEventArgs pEventArgs)
{
 pEventArgs.ObjectInstance = _equipoFactory;

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
 lblEncontrados.Text = _equipoFactory.Count(CR).ToString();
 lbldesde.Text = ((Browse1.PageIndex * Browse1.PageSize) + 1).ToString();

 if (((Browse1.PageIndex + 1) * Browse1.PageSize) < _equipoFactory.Count(CR))
     lblHasta.Text = (((Browse1.PageIndex + 1) * Browse1.PageSize)).ToString();
 else
     lblHasta.Text = (
             ((Browse1.PageIndex + 1) * Browse1.PageSize) -
             (
                 ((Browse1.PageIndex + 1) * Browse1.PageSize) -
                  _equipoFactory.Count(CR)
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
if (_key == "serial" ) continue;

}
Validate();
Browse1.DataBind();
}

protected virtual bool Browse1_Transaction()
{
// Gets the Current transaction from the Template Factory
NHibernate.ITransaction Transaction = _equipoFactory.GetCurrentTransaction();

// Check the Transaction status
if ( Transaction == null ) throw new Exception("Transaction is null");
if ( !Transaction.IsActive) throw new Exception("Transaction has already been commited. Make sure you do not commit the transaction before this method is called.");

try
{
SessionFactory.CommitTransaction();
return true;
}
catch (Exception ex)
{

return false;
}
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

protected void SearchBtn1_Click(object pSender , EventArgs pEventArgs)
{
Browse1.DataBind();
}

public string Browse1_GetEquipo_EstadoLocalEquipo_NombreEstadoLocal(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.EstadoLocalEquipo == null ) return "";
if ( pDataItem.EstadoLocalEquipo.NombreEstadoLocal == null ) return "";
return pDataItem.EstadoLocalEquipo.NombreEstadoLocal;

}

public string Browse1_GetEquipo_EstadoLocalEquipo_Descripcion(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.EstadoLocalEquipo == null ) return "";
if ( pDataItem.EstadoLocalEquipo.Descripcion == null ) return "";
return pDataItem.EstadoLocalEquipo.Descripcion;

}

public string Browse1_GetEquipo_ModalidadEquipo_NombreModalidadEquipo(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.ModalidadEquipo == null ) return "";
if ( pDataItem.ModalidadEquipo.NombreModalidadEquipo == null ) return "";
return pDataItem.ModalidadEquipo.NombreModalidadEquipo;

}

public string Browse1_GetEquipo_ModalidadEquipo_Descripcion(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.ModalidadEquipo == null ) return "";
if ( pDataItem.ModalidadEquipo.Descripcion == null ) return "";
return pDataItem.ModalidadEquipo.Descripcion;

}

public string Browse1_GetEquipo_Modelo_NombreModelo(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.Modelo == null ) return "";
if ( pDataItem.Modelo.NombreModelo == null ) return "";
return pDataItem.Modelo.NombreModelo;

}

public string Browse1_GetEquipo_Modelo_NombreFabricante(BOLayer.Equipo pDataItem)
{
    if (pDataItem == null) return "";
    if (pDataItem.Modelo == null) return "";
    if (pDataItem.Modelo.NombreModelo == null) return "";
    if (pDataItem.Modelo.Fabricante== null) return "";
    if (pDataItem.Modelo.Fabricante.NombreFabricante == null) return "";
    return pDataItem.Modelo.Fabricante.NombreFabricante;
}

public string Browse1_GetNombreCliente(BOLayer.Equipo pDataItem)
{
    if (pDataItem == null) return "";
    if (pDataItem.SucursalCliente == null) return "";
    if (pDataItem.SucursalCliente.Cliente == null) return "";
    if (pDataItem.SucursalCliente.Cliente.NombreCliente == null) return "";
    return pDataItem.SucursalCliente.Cliente.NombreCliente;
}

public string Browse1_GetNombreCiudad(BOLayer.Equipo pDataItem)
{
    if (pDataItem == null) return "";
    if (pDataItem.SucursalCliente == null) return "";
    if (pDataItem.SucursalCliente.Ciudade == null) return "";
    if (pDataItem.SucursalCliente.Ciudade.NombreCiudad == null) return "";
    return pDataItem.SucursalCliente.Ciudade.NombreCiudad;
}

public string Browse1_GetEquipo_Modelo_Descripcion(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.Modelo == null ) return "";
if ( pDataItem.Modelo.Descripcion == null ) return "";
return pDataItem.Modelo.Descripcion;

}

public string Browse1_GetEquipo_SucursalCliente_NombreSucursal(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.SucursalCliente == null ) return "";
if ( pDataItem.SucursalCliente.NombreSucursal == null ) return "";
return pDataItem.SucursalCliente.NombreSucursal;

}

public string Browse1_GetEquipo_SucursalCliente_CodPais(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.SucursalCliente == null ) return "";
if ( pDataItem.SucursalCliente.CodPais == null ) return "";
return pDataItem.SucursalCliente.CodPais;

}

public string Browse1_GetEquipo_TipoPropiedad_NombreTipoPropiedad(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.TipoPropiedad == null ) return "";
if ( pDataItem.TipoPropiedad.NombreTipoPropiedad == null ) return "";
return pDataItem.TipoPropiedad.NombreTipoPropiedad;

}

public string Browse1_GetEquipo_TipoPropiedad_Descripcion(BOLayer.Equipo pDataItem)
{
if ( pDataItem == null ) return "";
if ( pDataItem.TipoPropiedad == null ) return "";
if ( pDataItem.TipoPropiedad.Descripcion == null ) return "";
return pDataItem.TipoPropiedad.Descripcion;

}

protected void Browse1_SelectedIndexChanged(object pSender , EventArgs pEventArgs)
{

}


#endregion

protected void oprimirBoton(object sender, System.Web.UI.ImageClickEventArgs eventoArgs)
{
    Response.Redirect("frmHojaVida.aspx?sx=" + ((ImageButton)sender).ValidationGroup);
}
}


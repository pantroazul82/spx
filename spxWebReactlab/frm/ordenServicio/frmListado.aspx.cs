using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;
using NHibernate.Criterion;
using NHibernate;
using BOLayer; 

public partial class frm_ordenServicio_frmListado : System.Web.UI.Page
{
    #region --- Class Fields / Objects  ---

    private BOLayer.OrdenServicioFactory _ordenServicioFactory = new BOLayer.OrdenServicioFactory(SessionScope.FactoryScope);
    private BOLayer.OrdenServicio _ordenServicioBrowse1;

    #endregion


    #region --- Class Methods ---

    protected void Page_Load(object pSender, EventArgs pEventArgs)
    {
       
         ObjectDataSource1.Selecting += new ObjectDataSourceSelectingEventHandler(Browse1_Selecting);
        if (!IsPostBack)
        { clsSeguridad obS = new clsSeguridad();
        obS.comprobarAcceso(Page, Session, Response, 1063);
            Browse1.Sort("CodOrdenServicio", SortDirection.Ascending);
        }
        else
        {
        }
      

        // Generate Event Handlers
    }

    protected void Browse1_RowDataBound(object pSender, GridViewRowEventArgs pEventArgs)
    {
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
                _sortImage.ImageUrl = @"~/img/web/asc.gif";
            }
            else
            {
                _sortImage.ImageUrl = @"~/img/web/desc.gif";
            }
            pEventArgs.Row.Cells[_index].Controls.Add(_sortImage);
        }
        if (pEventArgs.Row.RowType == DataControlRowType.DataRow)
        {
            WebControl _codOrdenServicio_DTypeVal1 = pEventArgs.Row.FindControl("codOrdenServicio_DTypeVal1") as WebControl;
            if (_codOrdenServicio_DTypeVal1 != null) _codOrdenServicio_DTypeVal1.Enabled = false;
            WebControl _fechaCreacion_DTypeVal1 = pEventArgs.Row.FindControl("fechaCreacion_DTypeVal1") as WebControl;
            if (_fechaCreacion_DTypeVal1 != null) _fechaCreacion_DTypeVal1.Enabled = false;
            WebControl _fechaProgramacion_DTypeVal1 = pEventArgs.Row.FindControl("fechaProgramacion_DTypeVal1") as WebControl;
            if (_fechaProgramacion_DTypeVal1 != null) _fechaProgramacion_DTypeVal1.Enabled = false;
            WebControl _fechaFinProgramacion_DTypeVal1 = pEventArgs.Row.FindControl("fechaFinProgramacion_DTypeVal1") as WebControl;
            if (_fechaFinProgramacion_DTypeVal1 != null) _fechaFinProgramacion_DTypeVal1.Enabled = false;
            WebControl _fechaCierre_DTypeVal1 = pEventArgs.Row.FindControl("fechaCierre_DTypeVal1") as WebControl;
            if (_fechaCierre_DTypeVal1 != null) _fechaCierre_DTypeVal1.Enabled = false;
            WebControl _fechaAprobacion_DTypeVal1 = pEventArgs.Row.FindControl("fechaAprobacion_DTypeVal1") as WebControl;
            if (_fechaAprobacion_DTypeVal1 != null) _fechaAprobacion_DTypeVal1.Enabled = false;
            WebControl _fechaAnulacion_DTypeVal1 = pEventArgs.Row.FindControl("fechaAnulacion_DTypeVal1") as WebControl;
            if (_fechaAnulacion_DTypeVal1 != null) _fechaAnulacion_DTypeVal1.Enabled = false;
            WebControl _creadaPor_DTypeVal1 = pEventArgs.Row.FindControl("creadaPor_DTypeVal1") as WebControl;
            if (_creadaPor_DTypeVal1 != null) _creadaPor_DTypeVal1.Enabled = false;
            WebControl _aprobadaPor_DTypeVal1 = pEventArgs.Row.FindControl("aprobadaPor_DTypeVal1") as WebControl;
            if (_aprobadaPor_DTypeVal1 != null) _aprobadaPor_DTypeVal1.Enabled = false;
            WebControl _asignadoA_DTypeVal1 = pEventArgs.Row.FindControl("asignadoA_DTypeVal1") as WebControl;
            if (_asignadoA_DTypeVal1 != null) _asignadoA_DTypeVal1.Enabled = false;
            WebControl _cerradaPor_DTypeVal1 = pEventArgs.Row.FindControl("cerradaPor_DTypeVal1") as WebControl;
            if (_cerradaPor_DTypeVal1 != null) _cerradaPor_DTypeVal1.Enabled = false;
            WebControl _anuladaPor_DTypeVal1 = pEventArgs.Row.FindControl("anuladaPor_DTypeVal1") as WebControl;
            if (_anuladaPor_DTypeVal1 != null) _anuladaPor_DTypeVal1.Enabled = false;
            WebControl _serial_DTypeVal1 = pEventArgs.Row.FindControl("serial_DTypeVal1") as WebControl;
            if (_serial_DTypeVal1 != null) _serial_DTypeVal1.Enabled = false;
            WebControl _nitCliente_DTypeVal1 = pEventArgs.Row.FindControl("nitCliente_DTypeVal1") as WebControl;
            if (_nitCliente_DTypeVal1 != null) _nitCliente_DTypeVal1.Enabled = false;
            WebControl _codSucursal_DTypeVal1 = pEventArgs.Row.FindControl("codSucursal_DTypeVal1") as WebControl;
            if (_codSucursal_DTypeVal1 != null) _codSucursal_DTypeVal1.Enabled = false;
            WebControl _codTiposervicio_DTypeVal1 = pEventArgs.Row.FindControl("codTiposervicio_DTypeVal1") as WebControl;
            if (_codTiposervicio_DTypeVal1 != null) _codTiposervicio_DTypeVal1.Enabled = false;
            WebControl _codModalidad_DTypeVal1 = pEventArgs.Row.FindControl("codModalidad_DTypeVal1") as WebControl;
            if (_codModalidad_DTypeVal1 != null) _codModalidad_DTypeVal1.Enabled = false;
            WebControl _codEstadoOrdenServicio_DTypeVal1 = pEventArgs.Row.FindControl("codEstadoOrdenServicio_DTypeVal1") as WebControl;
            if (_codEstadoOrdenServicio_DTypeVal1 != null) _codEstadoOrdenServicio_DTypeVal1.Enabled = false;
            WebControl _codPrioridadOS_DTypeVal1 = pEventArgs.Row.FindControl("codPrioridadOS_DTypeVal1") as WebControl;
            if (_codPrioridadOS_DTypeVal1 != null) _codPrioridadOS_DTypeVal1.Enabled = false;
            WebControl _observaciones_DTypeVal1 = pEventArgs.Row.FindControl("observaciones_DTypeVal1") as WebControl;
            if (_observaciones_DTypeVal1 != null) _observaciones_DTypeVal1.Enabled = false;
            WebControl _observacionesIngeniero_DTypeVal1 = pEventArgs.Row.FindControl("observacionesIngeniero_DTypeVal1") as WebControl;
            if (_observacionesIngeniero_DTypeVal1 != null) _observacionesIngeniero_DTypeVal1.Enabled = false;
            WebControl _fallasReportadas_DTypeVal1 = pEventArgs.Row.FindControl("fallasReportadas_DTypeVal1") as WebControl;
            if (_fallasReportadas_DTypeVal1 != null) _fallasReportadas_DTypeVal1.Enabled = false;
            WebControl _diagnostico_DTypeVal1 = pEventArgs.Row.FindControl("diagnostico_DTypeVal1") as WebControl;
            if (_diagnostico_DTypeVal1 != null) _diagnostico_DTypeVal1.Enabled = false;
            WebControl _numEntrada_DTypeVal1 = pEventArgs.Row.FindControl("numEntrada_DTypeVal1") as WebControl;
            if (_numEntrada_DTypeVal1 != null) _numEntrada_DTypeVal1.Enabled = false;
            WebControl _horaEntradaControl_DTypeVal1 = pEventArgs.Row.FindControl("horaEntradaControl_DTypeVal1") as WebControl;
            if (_horaEntradaControl_DTypeVal1 != null) _horaEntradaControl_DTypeVal1.Enabled = false;
            WebControl _horaSalidaControl_DTypeVal1 = pEventArgs.Row.FindControl("horaSalidaControl_DTypeVal1") as WebControl;
            if (_horaSalidaControl_DTypeVal1 != null) _horaSalidaControl_DTypeVal1.Enabled = false;
            WebControl _nombreUsuarioCliente_DTypeVal1 = pEventArgs.Row.FindControl("nombreUsuarioCliente_DTypeVal1") as WebControl;
            if (_nombreUsuarioCliente_DTypeVal1 != null) _nombreUsuarioCliente_DTypeVal1.Enabled = false;
            WebControl _codAsesor_DTypeVal1 = pEventArgs.Row.FindControl("codAsesor_DTypeVal1") as WebControl;
            if (_codAsesor_DTypeVal1 != null) _codAsesor_DTypeVal1.Enabled = false;
        }
    }

    protected void Browse1_Sorting(object pSender, GridViewSortEventArgs pEventArgs)
    {

        // Calls this method to adapt the sort syntax (required for Composite sorting).
        WebUtils.SortExpressionTransformer(pEventArgs);


        // Clears the Search TextBox when Browse Sorts
        txtFiltro.Text = string.Empty;

    }

   
    public ICriteria Browse1_GetCriteria()
    {
        ICriteria _criteria = _ordenServicioFactory.GetBasicCriteria();
        _criteria.CreateCriteria("AsesoresComerciale", "AsesoresComerciale", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
        _criteria.CreateCriteria("Equipo", "Equipo", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
        _criteria.CreateCriteria("Equipo.Modelo", "Modelo", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
        _criteria.CreateCriteria("Equipo.Modelo.Fabricante", "Fabricante", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
        _criteria.CreateCriteria("EstadosOrdenServicio", "EstadosOrdenServicio", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
        _criteria.CreateCriteria("ModalidadEquipo", "ModalidadEquipo", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
        _criteria.CreateCriteria("SucursalCliente", "SucursalCliente", NHibernate.SqlCommand.JoinType.LeftOuterJoin);
        _criteria.CreateCriteria("TipoServicio", "TipoServicio", NHibernate.SqlCommand.JoinType.LeftOuterJoin);

        #region zona de busquedas
        if (txtFiltro.Text.Trim() != string.Empty)
        {
            switch (cmbFiltros.SelectedValue.Trim())
            {
                //serial;
                case "1":
                    {
                        _criteria.Add(NHibernate.Criterion.Expression.Like("Serial", txtFiltro.Text, MatchMode.Start));
                        break;
                    }
                //Nit Cliente;
                case "2":
                    {
                        _criteria.Add(NHibernate.Criterion.Expression.Like("NitCliente", txtFiltro.Text, MatchMode.Start));
                        break;
                    }
                //Modelo;
                case "3":
                    {
                        _criteria.Add(NHibernate.Criterion.Expression.Like("Modelo.NombreModelo", txtFiltro.Text, MatchMode.Start));
                        break;
                    }
                //FAbricante
                case "4":
                    {
                        _criteria.Add(NHibernate.Criterion.Expression.Like("Fabricante.NombreFabricante", txtFiltro.Text, MatchMode.Start));
                        break;
                    }
                //codigo orden de servicio
                case "5":
                    {
                        int a = 0;
                        int.TryParse(txtFiltro.Text,out a);
                        _criteria.Add(NHibernate.Criterion.Expression.Eq("CodOrdenServicio", a));
                        break;
                    }
                    //asignado a
                case "6":
                    {
                        int a = 0;
                        int.TryParse(txtFiltro.Text, out a);
                        _criteria.Add(NHibernate.Criterion.Expression.Like("AsignadoA", txtFiltro.Text,MatchMode.Start));
                        break;
                    }
            }
            
        }
        #endregion

        #region permisos especiales para que el ingeniero vea solo lo de la zona que le toca
        string msg = "";
        if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(1201
, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
        {
            _criteria.Add(NHibernate.Criterion.Expression.Eq("AsignadoA", Session["ss_login"].ToString()));
            Browse1.Columns[1].Visible = false;
        }else { 
            //ocultamos la columna
            Browse1.Columns[1].Visible = true;
        }
        if (!chkHistorico.Checked)
        {
            _criteria.Add(
         NHibernate.Criterion.Expression.Or(
            NHibernate.Criterion.Expression.Or(
            NHibernate.Criterion.Expression.Eq("CodEstadoOrdenServicio", "EJECU"),
            NHibernate.Criterion.Expression.Eq("CodEstadoOrdenServicio", "ENESP")),

            NHibernate.Criterion.Expression.Or(
            NHibernate.Criterion.Expression.Eq("CodEstadoOrdenServicio", "NUEVA"),
            NHibernate.Criterion.Expression.Eq("CodEstadoOrdenServicio", "PROGR"))
          ));
        }
        #endregion



        return _criteria;
    }

    protected void Browse1_Selecting(object pSender, ObjectDataSourceSelectingEventArgs pEventArgs)
    {
        if (pEventArgs.ExecutingSelectCount)
        {
            pEventArgs.InputParameters.Remove("pSortExpression");
        }
        
        ICriteria CR = Browse1_GetCriteria();
        pEventArgs.InputParameters["pCriteria"] = CR;
        CR = Browse1_GetCriteria();
        lblEncontrados.Text = _ordenServicioFactory.Count(CR).ToString();
        lbldesde.Text = ((Browse1.PageIndex * Browse1.PageSize) + 1).ToString();

        if (((Browse1.PageIndex + 1) * Browse1.PageSize) < _ordenServicioFactory.Count(CR))
            lblHasta.Text = (((Browse1.PageIndex + 1) * Browse1.PageSize)).ToString();
        else
            lblHasta.Text = (
                    ((Browse1.PageIndex + 1) * Browse1.PageSize) -
                    (
                        ((Browse1.PageIndex + 1) * Browse1.PageSize) -
                         _ordenServicioFactory.Count(CR)
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
            if (_key == "codOrdenServicio") continue;

            try
            {
                WebUtils.SetValue(_ordenServicioBrowse1, _key, pDictionary[_key]);
            }
            catch (Exception ex)
            {
          
            }
        }
        Validate();
        Browse1.DataBind();
    }

    List<BOLayer.Error> Browse1_PageValidate(object pSender, EventArgs pEventArgs)
    {
        if (_ordenServicioBrowse1 != null)
        {
            return _ordenServicioBrowse1.Validate();
        }
        else
        {
            return new List<BOLayer.Error>();
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
        if (IsPostBack)
        {
            Browse1.DataBind();
        }
    }

    protected void SearchBtn1_Click(object pSender, EventArgs pEventArgs)
    {
        Browse1.DataBind();

    }

    public string Browse1_GetOrdenServicio_AsesoresComerciale_NombreAsesor(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.AsesoresComerciale == null) return "(NULL)";
        if (pDataItem.AsesoresComerciale.NombreAsesor == null) return "(NULL)";
        return pDataItem.AsesoresComerciale.NombreAsesor;
    }

    public bool verColumnaAsignado() {
        return true;
    }

    public string Browse1_verASignadoA(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.AsignadoA == null) return "(NULL)";
        return pDataItem.AsignadoA;
    }

    public string Browse1_GetOrdenServicio_AsesoresComerciale_Correo(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.AsesoresComerciale == null) return "(NULL)";
        if (pDataItem.AsesoresComerciale.Correo == null) return "(NULL)";
        return pDataItem.AsesoresComerciale.Correo;

    }

    public string Browse1_GetOrdenServicio_Equipo_CodFabricante(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.Equipo == null) return "(NULL)";
        if (pDataItem.Equipo.CodFabricante == null) return "(NULL)";
        return pDataItem.Equipo.CodFabricante;

    }

    public string Browse1_GetOrdenServicio_Equipo_CodModelo(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.Equipo == null) return "(NULL)";
        if (pDataItem.Equipo.CodModelo == null) return "(NULL)";
        return pDataItem.Equipo.Modelo.NombreModelo;

    }

    public string Browse1_GetOrdenServicio_EstadosOrdenServicio_NombreEstado(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.EstadosOrdenServicio == null) return "(NULL)";
        if (pDataItem.EstadosOrdenServicio.NombreEstado == null) return "(NULL)";
        return pDataItem.EstadosOrdenServicio.NombreEstado;

    }

    public string Browse1_GetOrdenServicio_EstadosOrdenServicio_Descripcion(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.EstadosOrdenServicio == null) return "(NULL)";
        if (pDataItem.EstadosOrdenServicio.Descripcion == null) return "(NULL)";
        return pDataItem.EstadosOrdenServicio.Descripcion;

    }

    public string Browse1_verFEchaProgramacion(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.FechaProgramacion == null) return "(NULL)";

        return pDataItem.FechaProgramacion_Date;

    }

    public string nombreCliente(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.SucursalCliente == null) return "(NULL)";
        if (pDataItem.SucursalCliente.Cliente == null) return "(NULL)";
        return pDataItem.SucursalCliente.Cliente.NombreCliente;

    }

    public string Browse1_GetOrdenServicio_ModalidadEquipo_NombreModalidadEquipo(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "";
        if (pDataItem.ModalidadEquipo == null) return "";
        if (pDataItem.ModalidadEquipo.NombreModalidadEquipo == null) return "";
        return pDataItem.ModalidadEquipo.NombreModalidadEquipo;

    }

    public string Browse1_GetOrdenServicio_SucursalCliente_NombreSucursal(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.SucursalCliente == null) return "(NULL)";
        if (pDataItem.SucursalCliente.NombreSucursal == null) return "(NULL)";
        return pDataItem.SucursalCliente.NombreSucursal;

    }

    public bool validarVisibilidadEjecutar(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return false;
        if (pDataItem.CodEstadoOrdenServicio == null) return false;


        if (pDataItem.CodEstadoOrdenServicio == "EJECU" ||
        pDataItem.CodEstadoOrdenServicio == "ENESP"||
            pDataItem.CodEstadoOrdenServicio == "NUEVA" ||
                pDataItem.CodEstadoOrdenServicio == "PROGR" ||
                pDataItem.CodEstadoOrdenServicio == "CERRA"
            )return true;
        else return false;

    }


    public string Browse1_GetOrdenServicio_SucursalCliente_CodPais(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.SucursalCliente == null) return "(NULL)";
        if (pDataItem.SucursalCliente.CodPais == null) return "(NULL)";
        return pDataItem.SucursalCliente.CodPais;

    }

    public string Browse1_GetOrdenServicio_TipoServicio_NombretipoServicio(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.TipoServicio == null) return "(NULL)";
        if (pDataItem.TipoServicio.NombretipoServicio == null) return "(NULL)";
        return pDataItem.TipoServicio.NombretipoServicio;

    }

    public string Browse1_GetOrdenServicio_TipoServicio_Descripcion(BOLayer.OrdenServicio pDataItem)
    {
        if (pDataItem == null) return "(NULL)";
        if (pDataItem.TipoServicio == null) return "(NULL)";
        if (pDataItem.TipoServicio.Descripcion == null) return "(NULL)";
        return pDataItem.TipoServicio.Descripcion;

    }

    protected void Browse1_SelectedIndexChanged(object pSender, EventArgs pEventArgs)
    {
   
    }




    public void ejecutarOrdenServicio(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        string orden = ((ImageButton)sender).ValidationGroup;
        Response.Redirect("frmEjecutarOrden.aspx?osx="+orden);
    }


    public void verOrdenServicio(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        string orden = ((ImageButton)sender).ValidationGroup;
        Response.Redirect("frmPrintOrden.aspx?os=" + orden);
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

        libro.Sheets[0].Name = "Ordenes de Servicio";
        libro.Sheets[0][0, 0].Value = "Ordenes de Servicio";
        libro.Sheets[0][0, 0].Style = estiloUno;

        libro.Sheets[0][2, 0].Value = "Cod Orden Servicio";
        libro.Sheets[0][2, 0].Style = estiloDos;
        libro.Sheets[0].Columns[0].Width = 2100;

        libro.Sheets[0][2, 1].Value = "Estado";
        libro.Sheets[0][2, 1].Style = estiloDos;
        libro.Sheets[0].Columns[1].Width = 2100;
        libro.Sheets[0][2, 2].Value = "Tipo Servicio";
        libro.Sheets[0][2, 2].Style = estiloDos;
        libro.Sheets[0].Columns[2].Width = 2400;
        libro.Sheets[0][2, 3].Value = "Serial";
        libro.Sheets[0][2, 3].Style = estiloDos;
        libro.Sheets[0].Columns[3].Width = 2100;
        //libro.Sheets[0][2, 4].Value = "Fabricante";
        libro.Sheets[0][2, 4].Style = estiloDos;
        libro.Sheets[0].Columns[4].Width = 2400;
        libro.Sheets[0][2, 5].Value = "Modelo";
        libro.Sheets[0][2, 5].Style = estiloDos;
        libro.Sheets[0].Columns[5].Width = 3100;

        libro.Sheets[0][2, 6].Value = "Cliente";
        libro.Sheets[0][2, 6].Style = estiloDos;
        libro.Sheets[0].Columns[6].Width = 2000;

        libro.Sheets[0][2, 7].Value = "Nit Cliente";
        libro.Sheets[0][2, 7].Style = estiloDos;
        libro.Sheets[0].Columns[7].Width = 2000;

        libro.Sheets[0][2, 8].Value = "Modalidad";
        libro.Sheets[0][2, 8].Style = estiloDos;
        libro.Sheets[0].Columns[8].Width = 2000;

        libro.Sheets[0][2, 9].Value = "Sucursal";
        libro.Sheets[0][2, 9].Style = estiloDos;
        libro.Sheets[0].Columns[9].Width = 2000;

        libro.Sheets[0][2, 10].Value = "Direccion";
        libro.Sheets[0][2, 10].Style = estiloDos;
        libro.Sheets[0].Columns[10].Width = 2000;

        libro.Sheets[0][2, 11].Value = "Contaco";
        libro.Sheets[0][2, 11].Style = estiloDos;
        libro.Sheets[0].Columns[11].Width = 2000;

        libro.Sheets[0][2, 12].Value = "Telefono Contacto";
        libro.Sheets[0][2, 12].Style = estiloDos;
        libro.Sheets[0].Columns[12].Width = 2000;

        libro.Sheets[0][2, 13].Value = "Celular Contacto";
        libro.Sheets[0][2, 13].Style = estiloDos;
        libro.Sheets[0].Columns[13].Width = 2000;

        libro.Sheets[0][2, 14].Value = "Fecha";
        libro.Sheets[0][2, 14].Style = estiloDos;
        libro.Sheets[0].Columns[14].Width = 2000;

        libro.Sheets[0][2, 15].Value = "Hora";
        libro.Sheets[0][2, 15].Style = estiloDos;
        libro.Sheets[0].Columns[15].Width = 2000;
        
        ICriteria ic = Browse1_GetCriteria();
        ic.AddOrder(Order.Asc("CodOrdenServicio"));

        BOLayer.OrdenServicioCollection arr = _ordenServicioFactory.GetAll(ic);

        for (int k = 0; k < arr.Count; k++)
        {
            libro.Sheets[0][3 + k, 0].Value = arr[k].CodOrdenServicio;
            
            if (arr[k].EstadosOrdenServicio != null &&  arr[k].EstadosOrdenServicio.NombreEstado != null)
            libro.Sheets[0][3 + k, 1].Value = arr[k].EstadosOrdenServicio.NombreEstado;

            if (arr[k].TipoServicio != null && arr[k].TipoServicio.NombretipoServicio != null)
                libro.Sheets[0][3 + k, 2].Value = arr[k].TipoServicio.NombretipoServicio;

            if (arr[k].Serial != null)
                libro.Sheets[0][3 + k, 3].Value = arr[k].Serial;

            //if (arr[k].Equipo != null && arr[k].Equipo.Modelo != null && arr[k].Equipo.Modelo.Fabricante != null)
            //    libro.Sheets[0][3 + k, 4].Value = arr[k].Equipo.Modelo.cod.NombreFabricante;

            if (arr[k].Equipo != null && arr[k].Equipo.Modelo != null)
                libro.Sheets[0][3 + k, 5].Value = arr[k].Equipo.Modelo.NombreModelo;

            if (arr[k].SucursalCliente != null && arr[k].SucursalCliente.Cliente != null)
                libro.Sheets[0][3 + k, 6].Value = arr[k].SucursalCliente.Cliente.NombreCliente;

            if (arr[k].SucursalCliente != null && arr[k].SucursalCliente.Cliente != null)
                libro.Sheets[0][3 + k, 7].Value = arr[k].SucursalCliente.Cliente.NitCliente;

            if (arr[k].ModalidadEquipo != null && arr[k].ModalidadEquipo.NombreModalidadEquipo != null)
                libro.Sheets[0][3 + k, 8].Value = arr[k].ModalidadEquipo.NombreModalidadEquipo;

            if (arr[k].SucursalCliente != null && arr[k].SucursalCliente.NombreSucursal != null)
                libro.Sheets[0][3 + k, 9].Value = arr[k].SucursalCliente.NombreSucursal;

            if (arr[k].SucursalCliente != null && arr[k].SucursalCliente.Direccion != null)
                libro.Sheets[0][3 + k, 10].Value = arr[k].SucursalCliente.Direccion;

            if (arr[k].SucursalCliente != null && arr[k].SucursalCliente.ContactosCliente != null)
                libro.Sheets[0][3 + k, 11].Value = arr[k].SucursalCliente.ContactosCliente.NombreContacto;

            if (arr[k].SucursalCliente != null && arr[k].SucursalCliente.ContactosCliente != null)
                libro.Sheets[0][3 + k, 12].Value = arr[k].SucursalCliente.ContactosCliente.Telefono1;

            if (arr[k].SucursalCliente != null && arr[k].SucursalCliente.ContactosCliente != null)
                libro.Sheets[0][3 + k, 12].Value += arr[k].SucursalCliente.ContactosCliente.Telefono2;

            if (arr[k].SucursalCliente != null && arr[k].SucursalCliente.ContactosCliente != null)
                libro.Sheets[0][3 + k, 13].Value = arr[k].SucursalCliente.ContactosCliente.Celular;

            if (arr[k].FechaProgramacion_Date != null )
                libro.Sheets[0][3 + k, 14].Value = arr[k].FechaProgramacion_Date;

            if (arr[k].FechaProgramacion_Time != null )
                libro.Sheets[0][3 + k, 15].Value = arr[k].FechaProgramacion_Time;
        }



        string ruta = Server.MapPath(@"~\Temp\");
        string archivo = Session["ss_login"].ToString() + "os.xls";
        int contador = 1;
        while (System.IO.File.Exists(ruta + @"\" + archivo))
        {
            archivo = Session["ss_login"].ToString() + "os" + "(" + (contador++) + ")" + ".xls";
        }
        libro.Save(ruta + @"\" + archivo);
        Response.Redirect(@"~\Temp\" + archivo);
    }

}

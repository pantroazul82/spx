using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.ordenServicio
{
    public partial class frmCrearOrden : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verficamos permiso
            clsSeguridad seg = new clsSeguridad();
            seg.comprobarAcceso(Page, Session, Response, 2014);
            if (!IsPostBack)
            {

                cmbResponsable.DataBind();
                cmbResponsable.SelectedValue = Session["ss_login"].ToString();
                string msg = "";
                if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(2015, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
                {

                    cmbResponsable.Enabled = false;
                }
                //permiso de denegacion si solo puede ver sus ordenes web, del mismo modo solo puede crear para si mismo
                if (SPXSeguridad.verificadorPermisos.ejecutarAccion(2052, int.Parse(Session["ss_cod_usuario"].ToString()), ref msg))
                {

                    cmbResponsable.Enabled = false;
                }
            }
        }


        protected void rdExterna_CheckedChanged(object sender, EventArgs e)
        {
            if (rdExterna.Checked)
            {
                cls.ds2020 dsSpx1 = new cls.ds2020();
                dsSpx1.EnforceConstraints = false;
                cls.ds2020TableAdapters.prioridadesOrdenServicioTableAdapter
                    prioridadesOrdenServicioTableAdapter1 = new cls.ds2020TableAdapters.prioridadesOrdenServicioTableAdapter();

                prioridadesOrdenServicioTableAdapter1.FillByExternas(dsSpx1.prioridadesOrdenServicio);
                cmbPrioridad.DataSource = dsSpx1.prioridadesOrdenServicio;
                cmbPrioridad.DataTextField = "nombre";
                cmbPrioridad.DataValueField = "codPrioridadOS";
                cmbPrioridad.DataBind();
                lblEntrada.Visible = false;
                cmbEntradas.Visible = false;
            }
        }

        protected void rdInterna_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInterna.Checked)
            {
                cls.ds2020 dsSpx1 = new cls.ds2020();
                dsSpx1.EnforceConstraints = false;
                cls.ds2020TableAdapters.prioridadesOrdenServicioTableAdapter
                    prioridadesOrdenServicioTableAdapter1 = new cls.ds2020TableAdapters.prioridadesOrdenServicioTableAdapter();

                prioridadesOrdenServicioTableAdapter1.FillByInternas(dsSpx1.prioridadesOrdenServicio);
                cmbPrioridad.DataSource = dsSpx1.prioridadesOrdenServicio;
                cmbPrioridad.DataTextField = "nombre";
                cmbPrioridad.DataValueField = "codPrioridadOS";
                cmbPrioridad.DataBind();
                //ademas cargamos las entradas que tenga ese serial
                lblEntrada.Visible = true;
                string sql = @"select codEntradaSAlidaEquipos,
'Cod:'+
rtrim(codEntradaSAlidaEquipos) +' Fecha:'+
cast(cast(fechaEntrada as date) as char(20)) 'texto'

 from entradaSalidaEquipos where codOrdenServicio is null
and serial ='" + txtSerial.Text + "'";
                SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();

                DataSet resultadoConsulta = obj.ejecutarConsulta(sql);

                if (resultadoConsulta.Tables[0].Rows.Count > 0)
                {
                    // Si hay filas, enlazar los datos al cmbEntradas
                    cmbEntradas.DataSource = resultadoConsulta.Tables[0];
                    cmbEntradas.DataTextField = "texto";
                    cmbEntradas.DataValueField = "codEntradaSAlidaEquipos";
                    cmbEntradas.DataBind();
                    cmbEntradas.Visible = true;
                }
                else
                {
                    // Si no hay filas, establecer el texto de marcador de posición del cmbEntradas
                    cmbEntradas.Items.Clear(); // Limpiar cualquier elemento existente en cmbEntradas
                    cmbEntradas.Items.Insert(0, new ListItem("No hay entrada", string.Empty)); // Establecer el marcador de posición
                    cmbEntradas.SelectedIndex = 0; // Seleccionar el marcador de posición
                    cmbEntradas.Visible = true;
                }

            }
        }



        protected void btnPaso2_Click(object sender, EventArgs e)
        {
            lblErrorPAsoUno.Text = "";
            if (controlSerial2.verCodigos().Count <= 0)
            {
                lblErrorPAsoUno.Text = "El serial es indispensable para continuar!";
                return;
            }
            PanelUno.Visible = false;
            pnlDos.Visible = true;
            txtSerial.Text = controlSerial2.verCodigos()[0];
            lnkVerHojaVida.NavigateUrl = "~/frm/hojavida/frmHojaVida.aspx?sx=" + txtSerial.Text;
        }

        protected void btnAtrasPaso_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCrearOrden.aspx");
        }
        protected void rdPorContrato_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPorContrato.Checked)
            {
                lblNumeroContrato.Visible = true;
                cmbContrato.Visible = true;

                SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
                DateTime n = obj.fechaServer;
                cls.ds2020TableAdapters.contratosTableAdapter contratosTableAdapter1 = new
                cls.ds2020TableAdapters.contratosTableAdapter();
                cls.ds2020 dsSpx1 = new cls.ds2020();
                //--
                dsSpx1.EnforceConstraints = false;
                contratosTableAdapter1.FillByContratoActivoEquipo(dsSpx1.contratos, txtSerial.Text, n);
                //--
                cmbContrato.DataSource = dsSpx1.contratos;
                cmbContrato.DataTextField = "numeroContrato";
                cmbContrato.DataValueField = "numeroContrato";
                cmbContrato.DataBind();
            }
        }
        protected void rdPorContratoNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPorContratoNo.Checked)
            {
                lblNumeroContrato.Visible = false;
                cmbContrato.Visible = false;
            }
        }

        private bool validar()
        {
            lblError.Text = "";
            if (!rdInterna.Checked && !rdExterna.Checked)
            {
                lblError.Text = "Debe especificar si la orden es interna o externa";
                return false;
            }

            if (rdInterna.Checked)
            {
                if (cmbEntradas.SelectedValue == null || cmbEntradas.SelectedValue.Trim() == string.Empty || cmbEntradas.SelectedValue == "No hay entrada")
                {
                    lblError.Text = "Las ordenes de servicio internas deben estar asociadas a una entrada!";
                    return false;
                }
            }

            if (rdPorContrato.Checked)
            {
                if (cmbContrato.SelectedValue == null || cmbContrato.SelectedValue.Trim() == string.Empty)
                {
                    lblError.Text = "Las ordenes de servicio por contrato deben especificar el numero de contrato!";
                    return false;
                }
            }

            if (!calinicio.SelectedDate.HasValue)
            {
                lblError.Text = "Debe especificar la fecha y hora de inicio de la actividad!";
                return false;
            }

            if (!calFin.SelectedDate.HasValue)
            {
                lblError.Text = "Debe especificar la fecha y hora de fin de la actividad!";
                return false;
            }

            if (calinicio.SelectedDate.Value > calFin.SelectedDate.Value)
            {
                lblError.Text = "La hora de inicio y fin de la actividad no son logicos!";
                return false;
            }
            return true;
        }

        private void crear()
        {


            Nullable<DateTime> fechaProgramacion = new Nullable<DateTime>();
            Nullable<DateTime> fechaFinProgramacion = new Nullable<DateTime>();
            string asignadoA = "";

            asignadoA = cmbResponsable.SelectedValue;
            fechaProgramacion = calinicio.SelectedDate.Value;
            fechaFinProgramacion = calFin.SelectedDate.Value;




            //creamos la orden de servicio con el manejador de ordenes de servicio
            int codAsesor = 0;
            if (cmbAsesoresComerciales.SelectedValue != null && cmbAsesoresComerciales.SelectedValue.ToString().Trim() != string.Empty)
            {
                codAsesor = int.Parse(cmbAsesoresComerciales.SelectedValue.ToString());
            }

            int cod = crearOrdenServicio(txtSerial.Text, ((asignadoA == string.Empty) ? "" : asignadoA),
            fechaProgramacion, fechaFinProgramacion, rdInterna.Checked,
            (rdInterna.Checked) ? int.Parse(cmbEntradas.SelectedValue) : 0, cmbTipoServicio.SelectedValue.ToString()
            , int.Parse(cmbPrioridad.SelectedValue.ToString()), txtObservacionesIniciales.Text, "", "",
            "", codAsesor);
            //si es interna actualizamos la entrada
            if (rdInterna.Checked)
            {

                cls.ds2020TableAdapters.EntradaSalidaEquiposTableAdapter entradaSalidaEquiposTableAdapter1 = new cls.ds2020TableAdapters.EntradaSalidaEquiposTableAdapter ();
               entradaSalidaEquiposTableAdapter1.UpdateCodOrdenServicio(cod, int.Parse(cmbEntradas.SelectedValue));
            }
            //operaciones de contrato

            if (rdPorContrato.Checked && cod != 0)
            {
                vincularOrdenContrato(txtSerial.Text, cod);
            }
        }

        public string vincularOrdenContrato(string serial, int codOrdenServicio)
        {
            cls.ds2020TableAdapters.contratosTableAdapter contratosTableAdapter1 = new cls.ds2020TableAdapters.contratosTableAdapter();

            cls.ds2020 dsSpx1 = new cls.ds2020();
            contratosTableAdapter1.FillByContratoActivoEquipo(dsSpx1.contratos, serial, DateTime.Now);
            if (dsSpx1.contratos.Rows.Count > 0)
            {
                return vincularOrdenContrato2(dsSpx1.contratos[0].numeroContrato, dsSpx1.contratos[0].codOtroSi, serial, codOrdenServicio);
            }
            return "";
        }

        public string vincularOrdenContrato2(string numeroContrato, int codOtroSi, string serial, int codOrdenServicio)
        {
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            cls.ds2020 dsSpx1 = new cls.ds2020();
            cls.ds2020TableAdapters.contratosTableAdapter contratosTableAdapter1 = new cls.ds2020TableAdapters.contratosTableAdapter();
            DateTime n = DateTime.Now;

            cls.ds2020TableAdapters.mantenimientosxContratoTableAdapter mantenimientosxContratoTableAdapter1 = new cls.ds2020TableAdapters.mantenimientosxContratoTableAdapter();
            cls.ds2020TableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new cls.ds2020TableAdapters.ordenServicioTableAdapter();
            cls.ds2020TableAdapters.contratosxEquipoTableAdapter contratosxEquipoTableAdapter1 = new cls.ds2020TableAdapters.contratosxEquipoTableAdapter();
            cls.ds2020TableAdapters.logVinculacionesDesvinculacionesContratoTableAdapter log = new cls.ds2020TableAdapters.logVinculacionesDesvinculacionesContratoTableAdapter();
            cls.ds2020TableAdapters.TipoServicioTableAdapter ts = new cls.ds2020TableAdapters.TipoServicioTableAdapter();



            //carga la informacion del contrato
            contratosTableAdapter1.FillByNumeroContratoCodOtroSI(dsSpx1.contratos, numeroContrato, codOtroSi);
            if (dsSpx1.contratos.Rows.Count == 0) return "";

            mantenimientosxContratoTableAdapter1.FillByContratoOrden(dsSpx1.mantenimientosxContrato,
                codOrdenServicio, numeroContrato, codOtroSi);
            if (dsSpx1.mantenimientosxContrato.Count > 0)
            {
                throw new Exception("El contrato y la orden ya estan vinculados!");
            }
            //validemos que la orden no se encuentra ammarada ya a algun contrato
            ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, codOrdenServicio);
            if (!dsSpx1.ordenServicio[0].IsporContratoNull() && dsSpx1.ordenServicio[0].porContrato)
            {
                throw new Exception("La orden ya esta en el conteo de otro contrato!");
            }
            //cargamos el serial maestro
            contratosxEquipoTableAdapter1.FillBySerialNumContratoOtroSi(dsSpx1.contratosxEquipo, serial, numeroContrato, codOtroSi);
            //calculamos el consecutivo
            int c = mantenimientosxContratoTableAdapter1.verSiguienteConsecutivo(dsSpx1.contratosxEquipo[0].codContratosxEquipo).Value;
            //miramos el tipo de servicio de la orden.
            ts.FillBycodTipoServicio(dsSpx1.TipoServicio, dsSpx1.ordenServicio[0].codTiposervicio);
            //si es preventivo

            mantenimientosxContratoTableAdapter1.Insert(serial, codOrdenServicio,
                dsSpx1.ordenServicio[0].IsfechaProgramacionNull() ? n : dsSpx1.ordenServicio[0].fechaProgramacion,
                c, dsSpx1.contratosxEquipo[0].codContratosxEquipo,
                (dsSpx1.TipoServicio[0].IspreventivoNull()) ? false : dsSpx1.TipoServicio[0].preventivo,
                (dsSpx1.TipoServicio[0].IscorrectivoNull()) ? false : dsSpx1.TipoServicio[0].correctivo);
            //actualizamos la informacion de equipo por contrato
            string sql = @"update contratosxequipo  set mantenimientosRealizados=t,correctivos=c,preventivos=p from contratosxequipo 
    join 
    (
     select contratosxequipo.codContratosxEquipo,count(*) 't', sum( cast(preventivo as int)) 'p',sum( cast(correctivo as int)) 'c'
            from  contratosxequipo 
            join mantenimientosxcontrato on mantenimientosxcontrato.codcontratosxequipo =  contratosxequipo.codcontratosxequipo  
            where contratosxequipo.numeroContrato = '" + numeroContrato + "' and codOtrosi=" + codOtroSi + @"
            group by contratosxequipo.codContratosxEquipo
    ) st on st.codContratosxEquipo =contratosxequipo.codContratosxEquipo
where contratosxequipo.numeroContrato = '" + numeroContrato + "' and contratosxequipo.codotroSi=" + codOtroSi + "";
            obj.ejecutarComando(sql);
            log.Insert(dsSpx1.contratos[0].numeroContrato,
                dsSpx1.contratos[0].codOtroSi, obj.fechaServer, true, serial, "", SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
            //actualizamos la orden de servicio
            ordenServicioTableAdapter1.UpdateInfoContrato(true, c, dsSpx1.contratos[0].numeroContrato, dsSpx1.contratos[0].codOtroSi, codOrdenServicio);
            return dsSpx1.contratos[0].numeroContrato.Trim();
        }


        public int crearOrdenServicio(string serial, string loginASignadoA, Nullable<DateTime> fechaProgramacion, Nullable<DateTime> fechaFinProgramacion,
   bool esInterna, int numeroEntrada,
    string codTipoServicio, int prioridad, string observaciones, string observacionesIng,
    string fallasReportadas, string diagnostico, int codAsesor)
        {

            string creadoPor = Session["ss_cod_usuario"].ToString();


            cls.ds2020TableAdapters.ordenServicioTableAdapter objOs = new cls.ds2020TableAdapters.ordenServicioTableAdapter();
            cls.ds2020TableAdapters.equiposTableAdapter objEqui = new cls.ds2020TableAdapters.equiposTableAdapter();


            cls.ds2020 ds = new cls.ds2020();
            ds.EnforceConstraints = false;


            string nitCliente, modalidad, codUbicacion;
            Nullable<DateTime> fechaNullo = new Nullable<DateTime>();
            Nullable<int> numeroEntradanullo = new Nullable<int>();
            if (numeroEntrada > 0)
                numeroEntradanullo = numeroEntrada;
            #region se carga la informacion del cliente la modalidad y la ubicacion
            string sql = "select * from equipo";



            objEqui.FillBySerial(ds.equipos, serial);
            nitCliente = ds.equipos[0].nitClienteUbica;
            modalidad = (ds.equipos[0].IscodModalidadEquipoNull()) ? "" : ds.equipos[0].codModalidadEquipo;
            codUbicacion = ds.equipos[0].codSucursalUbica;
            #endregion
            //cargamos los permisos del usuario logeado
            string estado = "PROGR";
            int id = objOs.verNextId().Value;


            #region Luego crea la orden de servicio
            Nullable<int> enteroNulo = new Nullable<int>();

            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            objOs.Insert(id, n,
               fechaProgramacion, fechaFinProgramacion, fechaNullo, fechaNullo, fechaNullo,
                creadoPor, null, (loginASignadoA == string.Empty) ? null : loginASignadoA,
                null, null,
                esInterna, serial, nitCliente, codUbicacion, codTipoServicio, (modalidad == string.Empty) ? null : modalidad,
                estado, prioridad, observaciones, observacionesIng, fallasReportadas, diagnostico, numeroEntradanullo,
                 "", "", "", (codAsesor == 0) ? enteroNulo : codAsesor, null, null, null, null, null, null, null,null,null,null);
            #endregion


            //actualizamos informacion del equipo
            objEqui.UpdatefechaProximaProgramacion(fechaProgramacion, serial);



            // a futuro aqui podria enviar emails
            return id;
        }



        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            crear();
            Response.Redirect("frmListado.aspx");
        }
        protected void btnGuardarYCrearOtra_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            crear();
            Response.Redirect("frmCrearOrden.aspx");
        }
    }
}
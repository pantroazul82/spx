using System;
using System.Collections.Generic;

using System.Text;

namespace spProcesos.ordenesTrabajo.cls
{
    public class osController
    {
        #region variables donde se cargan los permisos del usuario logeado
        private bool per_creaOrden = false;
        private bool per_aceptaOrden = false;
        private bool per_programaOrden = false;
        private bool per_reasignaOrden = false;
        private bool per_cierraOrden = false;
        private bool per_apruebaOrden = false;
        private bool per_anulaOrden = false;
        private bool per_realizaOrden = false;
        private bool per_modificaOrden = false;//este permite modificar la orden en cualquier estado de la misma
        #endregion

        private void cargarPermisos()
        {
            per_creaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1030);
            per_aceptaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1003);
            per_programaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1060);
            per_reasignaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1065);
            per_cierraOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1023);
            per_apruebaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1014);
            per_anulaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1011);
            per_realizaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1063);
            per_modificaOrden = SPXSeguridad.verificadorPermisos.ejecutarAccion(1052);
        }
   

        public osController() { }

        public int crearOrdenServicio(string serial, string loginASignadoA, Nullable<DateTime> fechaProgramacion, Nullable<DateTime> fechaFinProgramacion,
           bool esInterna,int numeroEntrada,
            string codTipoServicio,int prioridad,string observaciones,string observacionesIng,
            string fallasReportadas,string diagnostico,int codAsesor)
        {
            return crearOrdenServicio(serial, loginASignadoA, fechaProgramacion, fechaFinProgramacion,
           esInterna,numeroEntrada,
            codTipoServicio,prioridad,observaciones, observacionesIng,
            fallasReportadas,diagnostico,codAsesor,null);
        }

        public int crearOrdenServicio(string serial, string loginASignadoA, Nullable<DateTime> fechaProgramacion, Nullable<DateTime> fechaFinProgramacion,
           bool esInterna,int numeroEntrada,
            string codTipoServicio,int prioridad,string observaciones,string observacionesIng,
            string fallasReportadas,string diagnostico,int codAsesor,string _CreadoPor)
        {
        
        string creadoPor="";
            if(_CreadoPor == null || _CreadoPor.Trim() == string.Empty)
            {
            creadoPor=SPXSeguridad.logica.sesion.LoginUsuarioAutenticado;
            }else{
            creadoPor=_CreadoPor;
            }

            
            //creasmos el tableadapter
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter objOs = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter objEqui = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
       

            string nitCliente, modalidad, codUbicacion;
            Nullable<DateTime> fechaNullo= new Nullable<DateTime>();
            Nullable<int> numeroEntradanullo= new Nullable<int>();
            if (numeroEntrada > 0)
                numeroEntradanullo=numeroEntrada;
            #region se carga la informacion del cliente la modalidad y la ubicacion
            objEqui.FillBySerial(ds.equipos, serial);
            nitCliente= ds.equipos[0].nitClienteUbica;
            modalidad =(ds.equipos[0].IscodModalidadEquipoNull())?"":ds.equipos[0].codModalidadEquipo;
            codUbicacion = ds.equipos[0].codSucursalUbica;
            #endregion
            //cargamos los permisos del usuario logeado
            cargarPermisos();

            string estado = "PROGR";
            int id = objOs.verNextId().Value;


            #region Luego crea la orden de servicio
            Nullable<int> enteroNulo = new Nullable<int>();

            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            objOs.Insert(id, n,
               fechaProgramacion, fechaFinProgramacion, fechaNullo, fechaNullo, fechaNullo,
                creadoPor ,null, (loginASignadoA == string.Empty) ? null : loginASignadoA,
                null, null,
                esInterna, serial, nitCliente, codUbicacion, codTipoServicio, (modalidad == string.Empty) ? null : modalidad,
                estado, prioridad, observaciones, observacionesIng, fallasReportadas, diagnostico, numeroEntradanullo,
                 "", "", "",(codAsesor==0)?enteroNulo:codAsesor,null,null,null,null,null,null,null);
#endregion


            //actualizamos informacion del equipo
            objEqui.UpdatefechaProximaProgramacion(fechaProgramacion, serial);
            


            // a futuro aqui podria enviar emails
            return id;
        }

        public string vincularOrdenContrato(string serial, int codOrdenServicio)
        {
            SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter mantenimientosxContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter contratosxEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.logVinculacionesDesvinculacionesContratoTableAdapter log = new SPControladoraDatos.dsSpxTableAdapters.logVinculacionesDesvinculacionesContratoTableAdapter();
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            contratosTableAdapter1.FillByContratoActivoEquipo(dsSpx1.contratos, serial, obj.fechaServer);
            if (dsSpx1.contratos.Rows.Count > 0)
            {
                return vincularOrdenContrato(dsSpx1.contratos[0].numeroContrato, dsSpx1.contratos[0].codOtroSi, serial, codOrdenServicio);
            }
            return "";
        }

        public string vincularOrdenContrato(string numeroContrato,int codOtroSi,string serial, int codOrdenServicio)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter mantenimientosxContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter contratosxEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.logVinculacionesDesvinculacionesContratoTableAdapter log = new SPControladoraDatos.dsSpxTableAdapters.logVinculacionesDesvinculacionesContratoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter ts=new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            //carga la informacion del contrato
            contratosTableAdapter1.FillByNumeroContratoCodOtroSI(dsSpx1.contratos,numeroContrato,codOtroSi);
            if (dsSpx1.contratos.Rows.Count == 0) return "";

            mantenimientosxContratoTableAdapter1.FillByContratoOrden(dsSpx1.mantenimientosxContrato,
                codOrdenServicio, numeroContrato, codOtroSi);
            if (dsSpx1.mantenimientosxContrato.Count > 0)
            {
                throw new Exception("El contrato y la orden ya estan vinculados!");
            }
            //validemos que la orden no se encuentra ammarada ya a algun contrato
            ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, codOrdenServicio);
            if(!dsSpx1.ordenServicio[0].IsporContratoNull() && dsSpx1.ordenServicio[0].porContrato)
            {
                throw new Exception("La orden ya esta en el conteo de otro contrato!");
            }
            //cargamos el serial maestro
            contratosxEquipoTableAdapter1.FillBySerialNumContratoOtroSi(dsSpx1.contratosxEquipo,serial,numeroContrato,codOtroSi);
            //calculamos el consecutivo
            int c=mantenimientosxContratoTableAdapter1.verSiguienteConsecutivo(dsSpx1.contratosxEquipo[0].codContratosxEquipo).Value;
            //miramos el tipo de servicio de la orden.
            ts.FillBycodTipoServicio(dsSpx1.TipoServicio, dsSpx1.ordenServicio[0].codTiposervicio);
            //si es preventivo

            mantenimientosxContratoTableAdapter1.Insert(serial, codOrdenServicio,
                dsSpx1.ordenServicio[0].IsfechaProgramacionNull() ? n: dsSpx1.ordenServicio[0].fechaProgramacion,
                c, dsSpx1.contratosxEquipo[0].codContratosxEquipo,
                (dsSpx1.TipoServicio[0].IspreventivoNull())?false:dsSpx1.TipoServicio[0].preventivo,
                (dsSpx1.TipoServicio[0].IscorrectivoNull())?false:dsSpx1.TipoServicio[0].correctivo);
            //actualizamos la informacion de equipo por contrato
            string sql = @"update contratosxequipo  set mantenimientosRealizados=t,correctivos=c,preventivos=p from contratosxequipo 
    join 
    (
     select contratosxequipo.codContratosxEquipo,count(*) 't', sum( cast(preventivo as int)) 'p',sum( cast(correctivo as int)) 'c'
            from  contratosxequipo 
            join mantenimientosxcontrato on mantenimientosxcontrato.codcontratosxequipo =  contratosxequipo.codcontratosxequipo  
            where contratosxequipo.numeroContrato = '" + numeroContrato+"' and codOtrosi="+codOtroSi+@"
            group by contratosxequipo.codContratosxEquipo
    ) st on st.codContratosxEquipo =contratosxequipo.codContratosxEquipo
where contratosxequipo.numeroContrato = '"+numeroContrato+"' and contratosxequipo.codotroSi="+codOtroSi+"";
            obj.ejecutarComando(sql);
                log.Insert(dsSpx1.contratos[0].numeroContrato,
                    dsSpx1.contratos[0].codOtroSi, obj.fechaServer, true, serial, "", SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
                //actualizamos la orden de servicio
                ordenServicioTableAdapter1.UpdateInfoContrato(true, c, dsSpx1.contratos[0].numeroContrato, dsSpx1.contratos[0].codOtroSi, codOrdenServicio);
                return dsSpx1.contratos[0].numeroContrato.Trim();
        }

        public void desVincularOrdenContrato(int codOrdenServicio)
        {
              SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter contratosTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter mantenimientosxContratoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.mantenimientosxContratoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter ordenServicioTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.ordenServicioTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter contratosxEquipoTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.contratosxEquipoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.logVinculacionesDesvinculacionesContratoTableAdapter log = new SPControladoraDatos.dsSpxTableAdapters.logVinculacionesDesvinculacionesContratoTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter ts=new SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter();
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            ordenServicioTableAdapter1.FillByCodOrdenServicio(dsSpx1.ordenServicio, codOrdenServicio);
            if(dsSpx1.ordenServicio[0].IsporContratoNull() || !dsSpx1.ordenServicio[0].porContrato)return;
            string serial = dsSpx1.ordenServicio[0].serial;
            mantenimientosxContratoTableAdapter1.FillByContratoOrden(
                dsSpx1.mantenimientosxContrato,codOrdenServicio,
                dsSpx1.ordenServicio[0].numeroContrato,dsSpx1.ordenServicio[0].codOtroSi);
            if(dsSpx1.mantenimientosxContrato.Count<=0)return;

            mantenimientosxContratoTableAdapter1.DeleteQuery(dsSpx1.mantenimientosxContrato[0].codMantenimiento);

            //miramos el tipo de servicio de la orden.
            ts.FillBycodTipoServicio(dsSpx1.TipoServicio, dsSpx1.ordenServicio[0].codTiposervicio);

            //actualizamos la informacion de equipo por contrato
            string sql = @"update contratosxequipo  set mantenimientosRealizados=t,correctivos=c,preventivos=p from contratosxequipo 
    join 
    (
     select contratosxequipo.codContratosxEquipo,count(*) 't', sum( cast(preventivo as int)) 'p',sum( cast(correctivo as int)) 'c'
            
            from  contratosxequipo 
            join mantenimientosxcontrato on mantenimientosxcontrato.codcontratosxequipo =  contratosxequipo.codcontratosxequipo  
            where contratosxequipo.numeroContrato = '" + dsSpx1.ordenServicio[0].numeroContrato+"' and codOtrosi="+dsSpx1.ordenServicio[0].codOtroSi+@"
            group by contratosxequipo.codContratosxEquipo
    ) st on st.codContratosxEquipo =contratosxequipo.codContratosxEquipo
where contratosxequipo.numeroContrato = '"+ dsSpx1.ordenServicio[0].numeroContrato+"' and contratosxequipo.codotroSi="+dsSpx1.ordenServicio[0].codOtroSi+"";
            obj.ejecutarComando(sql);
                log.Insert(dsSpx1.ordenServicio[0].numeroContrato,
                   dsSpx1.ordenServicio[0].codOtroSi, obj.fechaServer, false, serial, "Desvinculacion Orden con Contrato", SPXSeguridad.logica.sesion.LoginUsuarioAutenticado);
                //actualizamos la orden de servicio
                ordenServicioTableAdapter1.UpdateInfoContrato(false, null,null, null, codOrdenServicio);
            }
        
    }
}

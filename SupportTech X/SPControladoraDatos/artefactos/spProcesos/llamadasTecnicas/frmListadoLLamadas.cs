using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.llamadasTecnicas
{
    public partial class frmListadoLLamadas : Form
    {
        public frmListadoLLamadas()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private string generarSQL() 
        {
        System.Text.StringBuilder sb= new StringBuilder();
        sb.Append(@" set dateformat ymd  
 select fechaSolucion,diasEnSolucionar,fechaUltimoSeguimiento, solucionado,
 fechaCierre,us2.nombre 'cerradaPor',usuarios.nombre 'abiertaPor', 
 idLlamadaSoporte,codEstadoLlamadaTecnica,
 'test' nombreEstado,
 fechaLlamada, clientes.nitCliente,
 clientes.nombreCliente,clientes.numeroSocio, 
 contactosClientes.nombreContacto,
 contactosClientes.apellidosContacto,
 contactosClientes.telefono1 'telefono1Contacto',
 contactosClientes.telefono2 'telefono2Contacto',
  contactosClientes.celular 'celularcontacto',contactosClientes.email 'emailContacto',
  infAdicionalContacto, v.nombreSucursal,v.Direccion 'direccionSucursal', v.Telefono1 'telefono1Sucursal',
  v.Telefono2 'telefono2Sucursal',v.NombreDepartamento,v.nombreCiudad ,
  v2.serial,v2.nombreModelo,v2.nombreFabricante,
  v2.nombreTipoEquipo,
  v2.nombreSubTipo ,
  nombreModalidadEquipo ,
  obsCliente,obsAsesorTelefonico,obsFinales ,
  tipo_asesoria.nombre_tipo_asesoria,
  resultado_final_llamada.resultado_final_llamada,asesorTelefonico,ingenieroAsesor
  
from LlamadaSoporte 
  join estadosLLamadasTecnicas on estadosLLamadasTecnicas.codEstadoLlamada = LlamadaSoporte.codEstadoLlamadaTecnica  
  left join usuario usuarios on usuarios.login = LlamadaSoporte.asesorTelefonico   
  left join usuario us2 on us2.login = LlamadaSoporte.cerradaPor  
  left join clientes on clientes.nitCliente  =LlamadaSoporte.nitCliente   
  left join dbo.vistaSucursal v on v.nitCliente = clientes.nitCliente and v.codSucursal = LlamadaSoporte.codUbicacion   
  left join contactosClientes on contactosClientes.nitCliente =LlamadaSoporte.nitCliente and   LlamadaSoporte.codContacto = contactosClientes.codContacto 
  left join dbo.vistaEquipo v2 on v2.serial =  LlamadaSoporte.serial  
  left join tipo_asesoria on tipo_asesoria.cod_tipo_asesoria =  LlamadaSoporte.cod_tipo_asesoria
  left join resultado_final_llamada on resultado_final_llamada.cod_resultado_final_llamada= llamadaSoporte.cod_resultado_final_llamada 
left join solicitudServicio on solicitudServicio.codsolicitudServicio = LlamadaSoporte.codsolicitud
");
        return sb.ToString();        
        }

        private void buscar() 
        {
            string sql = generarSQL()+" where ";
            switch(cmbCampo.Text.Trim())
            {
                case "Codigo Llamada": { sql += " LlamadaSoporte.idLlamadaSoporte like '" + txtFiltro.Text + "%'"; break; }
                case "Serial": { sql += " LlamadaSoporte.serial like '" + txtFiltro.Text + "%'"; break; }
                case "Nit CLiente": { sql += " LlamadaSoporte.nitCliente like '" + txtFiltro.Text + "%'"; break; }
                case "Estado": { sql += " LlamadaSoporte.codEstadoLLamadaTecnica like '" + cmbEstados.SelectedValue.ToString() + "'"; break; }
            }
            dsPlantillas1.pltListadoLlamadas.Clear();
            dsPlantillas1.EnforceConstraints = false;
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            string filtroFecha = "";
            if (chkCreadas.Checked)
            {
                filtroFecha = " and fechaLlamada between '" + calInicio.Value.Year + "/" + calInicio.Value.Month.ToString().PadLeft(2, '0') + "/" + calInicio.Value.Day.ToString().PadLeft(2, '0') + "' AND " +
                      "  '" + calFin.Value.Year + "/" + calFin.Value.Month.ToString().PadLeft(2, '0') + "/" + calFin.Value.Day.ToString().PadLeft(2, '0') + "'";

            }

            if (chkCerradasEntre.Checked)
            {
                filtroFecha = " and fechaCierre between '" + calInicioCerradas.Value.Year + "/" + calInicioCerradas.Value.Month.ToString().PadLeft(2, '0') + "/" + calInicioCerradas.Value.Day.ToString().PadLeft(2, '0') + "' AND " +
                      "  '" + calFinCerradas.Value.Year + "/" + calFinCerradas.Value.Month.ToString().PadLeft(2, '0') + "/" + calFinCerradas.Value.Day.ToString().PadLeft(2, '0') + "'";

            }

            if (chkSolicitudEntre.Checked)
            {
                filtroFecha = " and solicitudServicio.fechaCreacion between '" + calSolicitudIni.Value.Year + "/" + calSolicitudIni.Value.Month.ToString().PadLeft(2, '0') + "/" + calSolicitudIni.Value.Day.ToString().PadLeft(2, '0') + "' AND " +
                      "  '" + calSolciitudFin.Value.Year + "/" + calSolciitudFin.Value.Month.ToString().PadLeft(2, '0') + "/" + calSolciitudFin.Value.Day.ToString().PadLeft(2, '0') + "'";

            }
            dsPlantillas1.pltListadoLlamadas.Merge(objData.ejecutarConsulta(sql +filtroFecha+ " order by idLlamadaSoporte desc").Tables[0]);
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void frmListadoLLamadas_Load(object sender, EventArgs e)
        {
            calInicio.Value = DateTime.Now.AddDays(-60);
            calInicio.MonthCalendar.DisplayMonth = DateTime.Now;
            calFin.Value = DateTime.Now.AddDays(1);
            calFin.MonthCalendar.DisplayMonth = DateTime.Now;

            calInicioCerradas.Value = DateTime.Now.AddDays(-60);
            calInicioCerradas.MonthCalendar.DisplayMonth = DateTime.Now;
            calFinCerradas.Value = DateTime.Now.AddDays(1);
            calFinCerradas.MonthCalendar.DisplayMonth = DateTime.Now;

            calSolicitudIni.Value = DateTime.Now.AddDays(-60);
            calSolicitudIni.MonthCalendar.DisplayMonth = DateTime.Now;
            calSolciitudFin.Value = DateTime.Now.AddDays(1);
            calSolciitudFin.MonthCalendar.DisplayMonth = DateTime.Now;


            cmbCampo.SelectedIndex = 0;
            estadosLLamadasTecnicasTableAdapter1.Fill(dsSpx1.estadosLLamadasTecnicas);
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buscar();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampo.Text.Trim() == "Estado")
            {
                cmbEstados.Visible = true;
                txtFiltro.Visible = false;
                cmbEstados.Focus();
            }
            else {
                cmbEstados.Visible = false;
                txtFiltro.Visible = true;
                txtFiltro.Focus();
            }
        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEstados.Visible)
            buscar();
        }

        private void btnVerLlamada_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["idLlamadaSoporte"].Text.Trim() == string.Empty) return;
            int id = int.Parse(grdDatos.Columns["idLlamadaSoporte"].Text);
            //analizamos si la llamda es version nueva o vieja de llamada
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            ds.EnforceConstraints = false;
            SPControladoraDatos.dsSpxTableAdapters.LlamadaSoporteTableAdapter llamada = new SPControladoraDatos.dsSpxTableAdapters.LlamadaSoporteTableAdapter();
            llamada.FillByidLlamadaSoporte(ds.LlamadaSoporte, id);
            if (ds.LlamadaSoporte[0].IsversionReporteNull() || ds.LlamadaSoporte[0].versionReporte == 1)
            {
                spProcesos.llamadasTecnicas.frmLlamadasSoporte frmO = new spProcesos.llamadasTecnicas.frmLlamadasSoporte();
                frmO.CodLLamada = int.Parse(grdDatos.Columns["idLlamadaSoporte"].Text);
                frmO.Show();
            }
            else {
                spProcesos.llamadasTecnicas.frmLlamadasSoporteNuevaVersion frmO = new spProcesos.llamadasTecnicas.frmLlamadasSoporteNuevaVersion();
                frmO.CodLLamada = int.Parse(grdDatos.Columns["idLlamadaSoporte"].Text);
                frmO.Show();
            }
        }
    }
}

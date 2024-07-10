using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.cientifica.proceso
{
    public partial class frmListadoPrellamadas : Form
    {
        public frmListadoPrellamadas()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["idLlamadaSoportePre"].Text.Trim() == string.Empty)
            {
                return;
            }

            //valida permisos
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1004))
            {
                MessageBox.Show("No tiene permisos para realizar esta accion!!");
                return;
            }

            if (grdDatos.Columns["estadoLLamadaTecnica"].Text.Trim() != "NUEVA")
            {
                MessageBox.Show("La Pre llamada ya tuvo respuesta!","Alerta" );
                return;
            }
            //Crea la Llamada y clona la informacion
            llamadaSoportePreTableAdapter1.FillByidLlamadaSoportePre(dsSpx1.LlamadaSoportePre,
                int.Parse(grdDatos.Columns["idLlamadaSoportePre"].Text));

             int a=int.Parse( llamadaSoporteTableAdapter1.verNextId().Value.ToString() );
            SPXdata.BD.DataConector d=new SPXdata.BD.DataConector();
            DateTime dd= d.fechaServer;
            llamadaSoporteTableAdapter1.Insert(a, "ABIER", dd, true,
                dsSpx1.LlamadaSoportePre[0].nitCliente,
                dsSpx1.LlamadaSoportePre[0].codUbicacion,
                dsSpx1.LlamadaSoportePre[0].codContacto,
                dsSpx1.LlamadaSoportePre[0].infAdicionalContacto,
                dsSpx1.LlamadaSoportePre[0].serial,
                null, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
               dsSpx1.LlamadaSoportePre[0].IsingenieroAsesorNull()?null:  dsSpx1.LlamadaSoportePre[0].ingenieroAsesor,
                null,
                dsSpx1.LlamadaSoportePre[0].IscodAsesorNull()?(int?)null:  dsSpx1.LlamadaSoportePre[0].codAsesor,
                dsSpx1.LlamadaSoportePre[0].IsobsClienteNull()?null: dsSpx1.LlamadaSoportePre[0].obsCliente,
                dsSpx1.LlamadaSoportePre[0].IsobsAsesorTelefonicoNull()?null: dsSpx1.LlamadaSoportePre[0].obsAsesorTelefonico,
                dsSpx1.LlamadaSoportePre[0].IssolucionadoNull()?(bool?)null: dsSpx1.LlamadaSoportePre[0].solucionado,
                dsSpx1.LlamadaSoportePre[0].IsobsFinalesNull()?null: dsSpx1.LlamadaSoportePre[0].obsFinales,
                dsSpx1.LlamadaSoportePre[0].IsfechaCierreNull()?(DateTime?)null:dsSpx1.LlamadaSoportePre[0].fechaCierre,
                null, null, null, null,null,
                null,null,2);
            //version de reporte 1 es reporte normal 2 es el nuevo formato de reporte
            //actualizamos la prellamada
            llamadaSoportePreTableAdapter1.UpdateEstadoLLamadaTecnica("Aceptada", int.Parse(grdDatos.Columns["idLlamadaSoportePre"].Text));
            buscar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["idLlamadaSoportePre"].Text.Trim() == string.Empty)
            {
                return;
            }
            //valida permisos
            if (!SPXSeguridad.verificadorPermisos.ejecutarAccionWindows(1004))
            {
                MessageBox.Show("No tiene permisos para realizar esta accion!!");
                return;
            }

            if (grdDatos.Columns["EstadoLlamadaTecnica"].Text.Trim() != "NUEVA")
            {
                MessageBox.Show("La Pre llamada ya tuvo respuesta!","Alerta");
                return;
            }
            //valida que no este ya cancelada o aceptada
            prellamadas.frmRechazarPrellamada fr = new prellamadas.frmRechazarPrellamada();
            fr.codLlamada = int.Parse(grdDatos.Columns["idLlamadaSoportePre"].Text);
            if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                buscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void frmListadoPrellamadas_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calInicio.Value = n.AddMonths(-2);
            calFin.Value = n;
            calInicio.MonthCalendar.DisplayMonth = n;
            calFin.MonthCalendar.DisplayMonth = n;
            buscar();    
        }

        private void buscar() 
        {
            string sql = @"
                set dateformat ymd
select * from LlamadaSoportepre
where fechaLLamada between  '"+calInicio.Value.Year+ "-"+calInicio.Value.Month.ToString().PadLeft(2,'0')+"-"+calInicio.Value.Day.ToString().PadLeft(2,'0')+@" 00:00:00.000' 
AND '"+calFin.Value.Year+"-" + calFin.Value.Month.ToString().PadLeft(2,'0') 
                                                                   + "-" + calFin.Value.Day.ToString().PadLeft(2,'0') +
                                                                   "  23:59:59.999'";
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            dsSpx1.LlamadaSoportePre.Merge(obj.ejecutarConsulta(sql).Tables[0]);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpFrm.tool
{
    public partial class frmEstadistico : Form
    {
        public frmEstadistico()
        {
            InitializeComponent();
        }

        private void buscar() 
        {
            dsPlantillas1.pltEstadisticasOSxTipoServicio.Clear();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            dsPlantillas1.pltEstadisticasOSxTipoServicio.Merge(obj.ejecutarConsulta(sentenciaTipoServicio()).Tables[0]);
        //
            dsPlantillas1.pltEstadisticasOSxUsuario.Clear();
            dsPlantillas1.pltEstadisticasOSxUsuario.Merge(obj.ejecutarConsulta(sentenciaUsuario()).Tables[0]);
        

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();    
        }

        private void frmEstadistico_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            calInicio.Value = n.AddDays(-60);
            calFin.Value = n;
            buscar();
            txtBusquedaUsuario.strTabla = "usuario";
            
        }

        private string sentenciaUsuario() 
        {
        System.Text.StringBuilder sb=new StringBuilder();
        sb.Append(" set dateformat dmy ");
        sb.Append(" declare @fechaIni as datetime ");
        sb.Append(" declare @fechaFin as datetime ");
        sb.Append(" set @fechaIni ='" + calInicio.Value.Day + "-" + calInicio.Value.Month + "-" + calInicio.Value.Year + "' ");
        sb.Append(" set @fechaFin ='" + calFin.Value.Day + "-" + calFin.Value.Month + "-" + calFin.Value.Year + "' ");

        sb.Append(" select  ");
sb.Append(" asignadoA,max(nombre) 'usuario',count(*) 'cantidad' from ordenservicio ");
sb.Append(" join usuario usuarios on usuarios.login = ordenServicio.asignadoA ");
sb.Append(" join equipos on equipos.serial = ordenservicio.serial ");
            
sb.Append(" where fechaProgramacion between @fechaIni and @fechaFin ");

if (sentenciaFiltro() != string.Empty)
{
    sb.Append(" AND " + sentenciaFiltro());
}
if (txtBusquedaTipoServicio.Value != null && txtBusquedaTipoServicio.Value != "0")
{
    sb.Append(" AND ordenservicio.codTipoServicio ='" + txtBusquedaTipoServicio.Value + "'");
}
sb.Append(" group by asignadoA ");
sb.Append(" order by usuario ");
            //where
    return sb.ToString();
        }

        private string sentenciaTipoServicio()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" set dateformat dmy ");
sb.Append(" declare @fechaIni as datetime ");
sb.Append(" declare @fechaFin as datetime ");
sb.Append(" set @fechaIni ='" + calInicio.Value.Day + "-" + calInicio.Value.Month + "-" + calInicio.Value.Year + "' ");
sb.Append(" set @fechaFin ='" + calFin.Value.AddDays(1).Day + "-" + calFin.Value.AddDays(1).Month + "-" + calFin.Value.AddDays(1).Year + "' ");

sb.Append(" select tipoServicio.codTipoServicio,max(tipoServicio.nombretipoServicio) 'tipoServicio',count(*) 'cantidad' from ordenservicio ");
sb.Append(" join tipoServicio on tipoServicio.codTipoServicio = ordenServicio.codTipoServicio ");
sb.Append(" join equipos on equipos.serial = ordenservicio.serial ");
sb.Append(" where fechaProgramacion between @fechaIni and @fechaFin ");
if (sentenciaFiltro() != string.Empty)
{
    sb.Append(" AND "+sentenciaFiltro());
}
if (txtBusquedaUsuario.Value != null && txtBusquedaUsuario.Value != "0")
{
    sb.Append(" AND asignadoA ='" + txtBusquedaUsuario.Value + "'");
}
sb.Append(" group by tipoServicio.codTipoServicio ");
            return sb.ToString();
        }

        private string sentenciaFiltro() 
        {
            string filtro = "";
            if (txtBusquedaCliente.Value != null && txtBusquedaCliente.Value != "0")
            {
                filtro += " ordenservicio.nitCliente ='" + txtBusquedaCliente.Value + "' AND";
            }
            if (txtBusquedaModalidad.Value != null && txtBusquedaModalidad.Value != "0")
            {
                filtro += " ordenservicio.codModalidad ='" + txtBusquedaModalidad.Value + "' AND";
            }
            if (txtBusquedaSerial.Value != null && txtBusquedaSerial.Value != "0")
            {
                filtro += " ordenservicio.serial ='" + txtBusquedaSerial.Value + "' AND";
            }
            if (txtBusquedaFabricante.Value != null && txtBusquedaFabricante.Value != "0")
            {
                filtro += " equipos.codFabricante ='" + txtBusquedaFabricante.Value + "' AND";
            }
            if (txtBusquedaModelo.Value != null && txtBusquedaModelo.Value != "0")
            {
                filtro += " equipos.codModelo ='" + txtBusquedaModelo.Value + "' AND";
            }
            if (filtro.Trim() != string.Empty)
            {
                filtro = filtro.Substring(0, filtro.Length - 3);
            }
            return filtro;
        }
    }
}

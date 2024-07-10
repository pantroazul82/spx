using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.Equipos
{
    public partial class frmEquiposEliminados : Form
    {
        public frmEquiposEliminados()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdEquipos;
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = grdEquipos.Columns["serial"].Text.Trim();
            frm.ShowDialog();
        }

        private void frmEquiposEliminados_Load(object sender, EventArgs e)
        {
            cargarEqupos();
        }

        private void cargarEqupos()
        {
            //realizamos la busqueda primer validamos
            dsSpx1.vistaEquipo.Clear();
            string sql = @"SELECT        dbo.fabricante.nombre_fabricante AS nombrefabricante, ISNULL(dbo.Modelos.NombreModelo, '') AS nombremodelo, ISNULL(dbo.tipoEquipo.nombreTipoEquipo, '') 
                         AS nombretipoequipo, ISNULL(dbo.subTipoEquipo.nombreSubTipo, '') AS nombresubtipo, ISNULL(dbo.ModalidadEquipo.nombreModalidadEquipo, '') 
                         AS nombremodalidadequipo, ISNULL(dbo.estadoLocalEquipos.nombreEstadoLocal, '') AS nombreestadolocal, dbo.clientes.nitCliente, dbo.clientes.nombreCliente, 
                         dbo.sucursalCliente.nombreSucursal, dbo.paises.nombrePais, dbo.departamentos.NombreDepartamento, dbo.ciudades.nombreCiudad, dbo.equipos.serial, 
                         dbo.equipos.fechaLlegada, dbo.equipos.fechaSalida, dbo.equipos.fechaProximoMante, dbo.equipos.fechaUltimoMante, dbo.equipos.codTipoServicio, 
                         dbo.equipos.observacionesUltimoMante, dbo.equipos.fechaProximaProgramacion, dbo.equipos.codSucursalUbica, dbo.equipos.nitClienteUbicacionReal, 
                         cli.nombreCliente AS clientereal, sucli.nombreSucursal AS sucursallocal
FROM            dbo.equipos INNER JOIN
                         dbo.fabricante ON dbo.fabricante.codFabricante = dbo.equipos.codFabricante INNER JOIN
                         dbo.Modelos ON dbo.Modelos.codFabricante = dbo.equipos.codFabricante AND dbo.Modelos.codModelo = dbo.equipos.codModelo LEFT OUTER JOIN
                         dbo.tipoEquipo ON dbo.tipoEquipo.codTipoEquipo = dbo.Modelos.codTipoEquipo LEFT OUTER JOIN
                         dbo.subTipoEquipo ON dbo.subTipoEquipo.codTipoEquipo = dbo.Modelos.codTipoEquipo AND 
                         dbo.subTipoEquipo.codSubtipoEquipo = dbo.Modelos.codSubTipoEquipo LEFT OUTER JOIN
                         dbo.ModalidadEquipo ON dbo.ModalidadEquipo.codModalidadEquipo = dbo.equipos.codModalidadEquipo LEFT OUTER JOIN
                         dbo.estadoLocalEquipos ON dbo.estadoLocalEquipos.codEstadoLocal = dbo.equipos.codEstadoLocal LEFT OUTER JOIN
                         dbo.clientes ON dbo.clientes.nitCliente = dbo.equipos.nitClienteUbica LEFT OUTER JOIN
                         dbo.sucursalCliente ON dbo.sucursalCliente.nitCliente = dbo.equipos.nitClienteUbica AND 
                         dbo.sucursalCliente.codSucursal = dbo.equipos.codSucursalUbica LEFT OUTER JOIN
                         dbo.paises ON dbo.paises.codPais = dbo.sucursalCliente.codPais LEFT OUTER JOIN
                         dbo.departamentos ON dbo.departamentos.codPais = dbo.sucursalCliente.codPais AND 
                         dbo.departamentos.codDepartamento = dbo.sucursalCliente.codDepartamento LEFT OUTER JOIN
                         dbo.ciudades ON dbo.ciudades.codPais = dbo.sucursalCliente.codPais AND dbo.ciudades.codDepartamento = dbo.sucursalCliente.codDepartamento AND 
                         dbo.ciudades.codCiudad = dbo.sucursalCliente.codCiudad LEFT OUTER JOIN
                         dbo.clientes AS cli ON cli.nitCliente = dbo.equipos.nitClienteUbicacionReal LEFT OUTER JOIN
                         dbo.sucursalCliente AS sucli ON sucli.nitCliente = dbo.equipos.nitClienteUbicacionReal AND sucli.codSucursal = dbo.equipos.codSucursalUbicaReal
WHERE        (dbo.equipos.eliminado_por IS not NULL)  ";
            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            dsSpx1.vistaEquipo.Merge(objData.ejecutarConsulta(sql).Tables[0]);
            System.Media.SystemSounds.Asterisk.Play();
        }

        SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
        private void btnDesEliminar_Click(object sender, EventArgs e)
        {
            if (grdEquipos.Columns["serial"].Text.Trim() == string.Empty) return;

            if (MessageBox.Show("Esta seguro de activar de nuevo el equipo","Confirmacion",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                equiposTableAdapter1.UpdateEliminado(null, null, "", grdEquipos.Columns["serial"].Text.Trim());
                equiposTableAdapter1.UpdateRecreado(SPXSeguridad.logica.sesion.CodUsuarioAutenticado, DateTime.Now, grdEquipos.Columns["serial"].Text.Trim());
                cargarEqupos();
            }
        }
    }
}

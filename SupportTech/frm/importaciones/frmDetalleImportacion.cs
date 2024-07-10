using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupportTech.frm.importaciones
{
    public partial class frmDetalleImportacion : Form
    {
        public frmDetalleImportacion()
        {
            InitializeComponent();
            controladorColumnasSinSerializar.grilla = grdDetalle;
        }

        public long cod_movimiento { set; get; }

        string verMaestro()
        {
            string sql = @"select
cod_detalle_movimiento,fabricante.nombre_fabricante 'Fabricante',
modelos.NombreModelo 'Modelo',estado_fisico.nombre_estado_fisico 'Estado ', tipopropiedad.nombreTipoPropiedad 'Tipo Propiedad',
cantidad_definitiva 'Cantidad Serializado',Serial,
clientes.nombreCliente 'Cliente Reserva', sucursalCliente.nombreSucursal 'Sucursal Reserva', 
cal1 'Fecha Reserva'
 from detalle_movimiento
left join fabricante on fabricante.codfabricante = detalle_movimiento.texto1
left join modelos on modelos.codfabricante = detalle_movimiento.texto1 and modelos.codModelo = detalle_movimiento.texto2
left join estado_fisico on estado_fisico.cod_estado_fisico  = detalle_movimiento.cod_estado_fisico 
left join clientes on clientes.nitCliente = detalle_movimiento.documento_principal
left join SucursalCliente on 
SucursalCliente.nitCliente=clientes.nitCliente 
and sucursalCliente.codSucursal = detalle_movimiento.texto_adicional
left join tipopropiedad on tipopropiedad.codTipoPropiedad = detalle_movimiento.for1
where cod_movimiento =" + cod_movimiento;
            return sql;
        }

        

        private void frmDetalleImportacion_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            grdDetalle.DataSource= obj.ejecutarConsulta(verMaestro()).Tables[0];
            grdDetalle.Splits[0].DisplayColumns["cod_detalle_movimiento"].Visible = false;
            for (int k = 0; k < grdDetalle.Columns.Count; k++)
            {
                if (grdDetalle.Columns[k].Caption.IndexOf("cantidad") >= 0)
                {
                    grdDetalle.Columns[k].Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Sum;
                }
            }
           
            controladorColumnasSinSerializar.cargarDiseno();

        }
    }
}

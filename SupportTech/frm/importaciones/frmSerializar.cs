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
    public partial class frmSerializar : Form
    {
        public frmSerializar()
        {
            InitializeComponent();
            controladorColumnasSerializados.grilla = grdReservados;
            controladorColumnasSinSerializar.grilla = grdSinReserva;
        }

        public long cod_movimiento { set; get; }

        string verSerializados()
        {
            return verMaestroSerializado() + " and serial is not null";
        }

        string verNoSerializados()
        {
            return verMaestroSinSerializar() + " and serial is null order by cal1 asc";
        }



        string verMaestroSinSerializar()
        {
            string sql = @"select
cod_detalle_movimiento,fabricante.nombre_fabricante 'Fabricante',
modelos.NombreModelo 'Modelo',estado_fisico.nombre_estado_fisico 'Estado ',
tipopropiedad.nombreTipoPropiedad 'Tipo Propiedad',
cantidad, cantidad_definitiva 'Serializado',

clientes.nombreCliente 'Cliente', sucursalCliente.nombreSucursal 'Sucursal',cal1 'Fecha Reserva'
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

        string verMaestroSerializado()
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

        private void cargar()
        {
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            grdSinReserva.DataSource = obj.ejecutarConsulta(verNoSerializados()).Tables[0];
            grdReservados.Visible = true;
            grdSinReserva.Visible = true;
            grdReservados.DataSource = obj.ejecutarConsulta(verSerializados()).Tables[0];

            grdReservados.Splits[0].DisplayColumns["cod_detalle_movimiento"].Visible = false;

            grdSinReserva.Splits[0].DisplayColumns["cod_detalle_movimiento"].Visible = false;
            for (int k = 0; k < grdReservados.Columns.Count; k++)
            {
                if (grdReservados.Columns[k].Caption.IndexOf("cantidad") >= 0)
                {
                    grdReservados.Columns[k].Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Sum;
                }
            }
            for (int k = 0; k < grdSinReserva.Columns.Count; k++)
            {

                if (grdSinReserva.Columns[k].Caption.IndexOf("cantidad") >= 0)
                {
                    grdSinReserva.Columns[k].Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Sum;
                }
            }
            //restaura e layout
            controladorColumnasSerializados.cargarDiseno();
            controladorColumnasSinSerializar.cargarDiseno();
        }

        private void frmSerializar_Load(object sender, EventArgs e)
        {
            cargar();
        }

        /// <summary>
        /// serializar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarReserva_Click(object sender, EventArgs e)
        {
            if(grdSinReserva.Columns["cod_detalle_movimiento"].Text.Trim() == string.Empty)return;
            frmSerializarDetalle fr = new frmSerializarDetalle();
            fr.cod_detalle_movimiento = long.Parse(grdSinReserva.Columns["cod_detalle_movimiento"].Text);

            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargar();
                grdSinReserva.Focus();
                terminar(false);
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            terminar(true);
        }

        private void terminar(bool cerrar) 
        {
            string sql = @"select sum(cantidad) 'cantidad',sum(isnull(cantidad_definitiva,0)) 'cantidad_serializada'
from detalle_movimiento where cod_movimiento = "+cod_movimiento;
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            System.Data.DataTable tb= bd.ejecutarConsulta(sql).Tables[0];

            if (tb.Rows.Count > 0 && tb.Rows[0][0].ToString() == tb.Rows[0][1].ToString())
            {
                MessageBox.Show("Se termino de serializar toda la importacion!");
                DialogResult = DialogResult.OK;
                Close();
            }else {
                if (cerrar)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
        }
    }

}

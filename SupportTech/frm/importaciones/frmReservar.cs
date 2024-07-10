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
    public partial class frmReservar : Form
    {
        public frmReservar()
        {
            InitializeComponent();
        }

        public long cod_movimiento { set; get; }

        string verReservados()
        {
            return verMaestroReservadas() + " and cantidad_acumulada is not null";
        }

        string verNoReservados()
        {
            return verMaestroSinReservar() + " and cantidad_acumulada is null";
        }



        string verMaestroReservadas()
        {
            string sql = @"select
cod_detalle_movimiento,fabricante.nombre_fabricante 'Fabricante',
modelos.NombreModelo 'Modelo',estado_fisico.nombre_estado_fisico 'Estado ',cantidad_acumulada 'Cantidad Reservado',cal1 'Fecha Reserva',

clientes.nombreCliente 'Cliente', sucursalCliente.nombreSucursal 'Sucursal', 
tipopropiedad.nombreTipoPropiedad 'Tipo Propiedad'
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

        string verMaestroSinReservar()
        {
            string sql = @"select
cod_detalle_movimiento,fabricante.nombre_fabricante 'Fabricante',
modelos.NombreModelo 'Modelo',estado_fisico.nombre_estado_fisico 'Estado ',cantidad,
tipopropiedad.nombreTipoPropiedad 'Tipo Propiedad'
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
            grdSinReserva.DataSource= obj.ejecutarConsulta(verNoReservados()).Tables[0];
            grdReservados.Visible = true;
            grdSinReserva.Visible = true;
            grdReservados.DataSource = obj.ejecutarConsulta(verReservados()).Tables[0];

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
        }

        private void frmReservar_Load(object sender, EventArgs e)
        {
            cargar();   
        }

        private void btnQuitarReserva_Click(object sender, EventArgs e)
        {
            if (grdReservados.Columns["cod_detalle_movimiento"].Text.Trim() == string.Empty) return;
            if (MessageBox.Show("Esta seguro de quitar la reserva?","Confirmacion",MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes) return;

            SPXdata.BD.DataConector objData = new SPXdata.BD.DataConector();
            //traemos la informacion del detalle que va desaparecer
            string a = "select texto1,texto2,cantidad,for1 from detalle_movimiento where cod_detalle_movimiento ="+grdReservados.Columns["cod_detalle_movimiento"].Text;
            System.Data.DataTable tbOrigen=   objData.ejecutarConsulta(a).Tables[0];
            //miramos si todavia hay elementos sin reservar de el modelo a importar
            string sql = "select cod_detalle_movimiento from detalle_movimiento where cod_movimiento="+cod_movimiento+
                " and for1='" + tbOrigen.Rows[0]["for1"].ToString().Trim() + "' and  texto1= '" + tbOrigen.Rows[0]["texto1"].ToString().Trim() + "' and texto2 ='" + tbOrigen.Rows[0]["texto2"].ToString().Trim() + "' " +
                "and cantidad_acumulada is null";
            System.Data.DataTable tb2 = objData.ejecutarConsulta(sql).Tables[0];
            if (tb2.Rows.Count == 0)
            {
                sql = "update detalle_movimiento set cal1=null,cantidad_acumulada = null, documento_principal=null,texto_adicional=null where cod_detalle_movimiento =" +
                    grdReservados.Columns["cod_detalle_movimiento"].Text;
                objData.ejecutarComando(sql);
            }else {
                sql = "update detalle_movimiento set cal1=null,cantidad = cantidad+"+ tbOrigen.Rows[0]["cantidad"].ToString() +" where cod_detalle_movimiento =" +
                     tb2.Rows[0][0].ToString();
                objData.ejecutarComando(sql);

                sql = "delete from detalle_movimiento where cod_detalle_movimiento =" + grdReservados.Columns["cod_detalle_movimiento"].Text;
                objData.ejecutarComando(sql);
            }
            cargar();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (grdSinReserva.Columns["cod_detalle_movimiento"].Text.Trim() == string.Empty) return;
            frmReservaDetalle frmReservarDetalle = new frmReservaDetalle();
            frmReservarDetalle.cantidadDisponible = int.Parse(grdSinReserva.Columns["cantidad"].Text);

            if (frmReservarDetalle.ShowDialog() == DialogResult.OK)
            { 
                SPXdata.BD.DataConector objData=new SPXdata.BD.DataConector();
                //si la reserva es completa actualiza el detalle
//                if (frmReservarDetalle.cantidadDisponible == frmReservarDetalle.cantidadElegida)
//                {



//                    string sql = @"update detalle_movimiento set 
//                    cantidad_acumulada = " + frmReservarDetalle.cantidadElegida +
//                ", documento_principal='" + frmReservarDetalle.nitCliente + "'," +
//                  "texto_adicional='" + frmReservarDetalle.codSucursal + "' where cod_detalle_movimiento =" +
//                  grdReservados.Columns["cod_detalle_movimiento"].Text;
//                    objData.ejecutarComando(sql);
//                }else{ //actualizamos el original restandole lo reservado
                    string sql = @"update detalle_movimiento set 
                    cantidad = cantidad-" + frmReservarDetalle.cantidadElegida +
                    " where cod_detalle_movimiento =" + grdSinReserva.Columns["cod_detalle_movimiento"].Text;
                    objData.ejecutarComando(sql);
                    SPXFlujo.Data.dsFlujoTableAdapters.detalle_movimientoTableAdapter det = new SPXFlujo.Data.dsFlujoTableAdapters.detalle_movimientoTableAdapter();
                    SPXFlujo.Data.dsFlujo ds = new SPXFlujo.Data.dsFlujo();
                    det.FillBycod_detalle_movimiento(ds.detalle_movimiento, long.Parse(grdSinReserva.Columns["cod_detalle_movimiento"].Text));
                    
                    //localiza si ya hay un detalle para ese cliente y para ese modelo
                    sql = "select cod_detalle_movimiento from detalle_movimiento where cod_movimiento="+cod_movimiento+
                        " and documento_principal ='" + frmReservarDetalle.nitCliente + "'"+
                        " and texto_adicional='" + frmReservarDetalle.codSucursal + "' "+
                        " and texto1= '"+ds.detalle_movimiento[0].texto1+"'"+
                        " and texto2= '" + ds.detalle_movimiento[0].texto2 + "'"+
                        " and for1= '" + ds.detalle_movimiento[0].for1 + "'";

                    System.Data.DataTable tb= objData.ejecutarConsulta(sql).Tables[0];
                    if (tb.Rows.Count <= 0)
                    {
                        //inserta un nuevo detalle con todo reservado
                        long d=det.clonarDetalle(ds.detalle_movimiento[0].cod_detalle_movimiento );
                        det.UpdateCantidad(frmReservarDetalle.cantidadElegida, d);
                        det.UpdateCantidad_acumulada(frmReservarDetalle.cantidadElegida,d);
                        det.UpdateCal1(DateTime.Now, d);
                        det.UpdateDocumento_principal(frmReservarDetalle.nitCliente, d);
                        det.UpdateTexto_adicional(frmReservarDetalle.codSucursal, d);
                        //fecha cal1
                    }else{ 
                        //actualiza la cantidad 
                        sql = " update detalle_movimiento set cantidad = cantidad+" + frmReservarDetalle.cantidadElegida + ",cantidad_acumulada=cantidad_acumulada+" + frmReservarDetalle.cantidadElegida +
                            " where cod_detalle_movimiento = " + tb.Rows[0][0].ToString() ;
                        objData.ejecutarComando(sql);
                    }
                //si ya reserv todas deberia eliminar el detalle
                if(frmReservarDetalle.cantidadElegida == frmReservarDetalle.cantidadDisponible)
                {
                  sql = @"delete from detalle_movimiento "+
                    " where cod_detalle_movimiento =" + grdSinReserva.Columns["cod_detalle_movimiento"].Text;
                    objData.ejecutarComando(sql);
                }
                
                cargar();
            }
        }
    }
}

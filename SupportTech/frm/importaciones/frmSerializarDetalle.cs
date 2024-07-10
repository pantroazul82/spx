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
    public partial class frmSerializarDetalle : Form
    {
        public frmSerializarDetalle()
        {
            InitializeComponent();
        }

        public long cod_detalle_movimiento { set; get; }

        private void frmSerializarDetalle_Load(object sender, EventArgs e)
        {
            calFechaIngreso.Value = DateTime.Now;
            calFechaIngreso.MonthCalendar.DisplayMonth = DateTime.Now;
            detalle_movimientoTableAdapter1.FillBycod_detalle_movimiento(dsFlujo1.detalle_movimiento, cod_detalle_movimiento);

            txtBusquedaFabricante.Value = dsFlujo1.detalle_movimiento[0].texto1;
            txtBusquedaModelo.Value = dsFlujo1.detalle_movimiento[0].texto2;
            txtBusquedaModelo.filtroAdicional = " codFabricante='" + dsFlujo1.detalle_movimiento[0].texto1.Trim()+"'";
            estadoLocalEquiposTableAdapter1.Fill(dsSpx1.estadoLocalEquipos);
            if (!(dsFlujo1.detalle_movimiento[0].Isdocumento_principalNull() || dsFlujo1.detalle_movimiento[0].documento_principal.Trim() == string.Empty))
            {
                lblModalidad.Visible = true;
                cmbModalidad.Visible = true;
                modalidadEquipoTableAdapter1.Fill(dsSpx1.ModalidadEquipo);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty)
            {
                MessageBox.Show("El serial es obligatorio!");
                return;
            }
            if(txtBusquedaFabricante.Value == null || txtBusquedaFabricante.Value == string.Empty || txtBusquedaFabricante.Value=="0")
            {
                  MessageBox.Show("El Fabricante es obligatorio!");
                    return;
            }
            if(txtBusquedaModelo.Value == null || txtBusquedaModelo.Value == string.Empty || txtBusquedaModelo.Value=="0")
            {
                  MessageBox.Show("El Modelo es obligatorio!");
                    return;
            }

            if (cmbEstadoLocalEquipos.Visible && cmbEstadoLocalEquipos.SelectedValue == null)
            {
                MessageBox.Show("El Estado Local es obligatorio!");
                return;
            }

            if (cmbModalidad.Visible && cmbModalidad.SelectedValue == null)
            {
                MessageBox.Show("La modalidad es obligatoria!");
                return;
            }


            //validamos que el serial no este ingresado ya
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, txtSerial.Text.Trim());
            if (dsSpx1.equipos.Count > 0)
            {
                MessageBox.Show("El serial ya existe en la base de datos!");
                return;
            }
            string sql = "select top 1 codUbicacionTrasladoEntradas from defaults";
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            string sucuLocal= obj.ejecutarProcedimiento(sql).ToString();
            //insertamos el equipo
            equiposTableAdapter1.Insert(txtBusquedaFabricante.Value,
                txtBusquedaModelo.Value, txtSerial.Text, calFechaIngreso.Value,
                null, null, null,
                "local",
                 sucuLocal ,
                null, "", 
                null,
                cmbEstadoLocalEquipos.SelectedValue.ToString(),
                null, null, null, "",
                dsFlujo1.detalle_movimiento[0].for1, 
                DateTime.Now, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado,
                
                (dsFlujo1.detalle_movimiento[0].Isdocumento_principalNull())?"local":dsFlujo1.detalle_movimiento[0].documento_principal,
                (dsFlujo1.detalle_movimiento[0].Isdocumento_principalNull()) ? sucuLocal : dsFlujo1.detalle_movimiento[0].texto_adicional,
                ((cmbModalidad.Visible)?cmbModalidad.SelectedValue.ToString():null),
                ((!cmbModalidad.Visible) ? cmbEstadoLocalEquipos.SelectedValue.ToString() : null),null,null
                ,null,null,null,null,null,null,"",null
                );

            //ahora modificamos el detalle de movimiento para manejar los consecutivos
            long d = detalle_movimientoTableAdapter1.clonarDetalle(dsFlujo1.detalle_movimiento[0].cod_detalle_movimiento);
            detalle_movimientoTableAdapter1.UpdateCantidad(1, d);
            detalle_movimientoTableAdapter1.UpdateCantidad_acumulada(1, d);
            detalle_movimientoTableAdapter1.UpdateCantidad_definitiva(1, d);
            detalle_movimientoTableAdapter1.UpdateSerial(txtSerial.Text,d); 
            //en el caso que no esta reservado se pone el cliente local
                if (dsFlujo1.detalle_movimiento[0].Isdocumento_principalNull())
                {
                    detalle_movimientoTableAdapter1.UpdateDocumento_principal("local", d);
                    detalle_movimientoTableAdapter1.UpdateTexto_adicional(sucuLocal, d);

                }
            //ahora actualizamos el origen
            if (dsFlujo1.detalle_movimiento[0].cantidad == 1 ||
                
                (
                (!dsFlujo1.detalle_movimiento[0].Iscantidad_definitivaNull()) &&
                dsFlujo1.detalle_movimiento[0].cantidad == dsFlujo1.detalle_movimiento[0].cantidad_definitiva+1
                )
                )
            { //eliminamos el detalle
                detalle_movimientoTableAdapter1.DeleteQuery(dsFlujo1.detalle_movimiento[0].cod_detalle_movimiento);
            }else {
                detalle_movimientoTableAdapter1.UpdateCantidad_definitiva(
                    (decimal)(((dsFlujo1.detalle_movimiento[0].Iscantidad_definitivaNull()) ? 0 : dsFlujo1.detalle_movimiento[0].cantidad_definitiva) + 1),
                    dsFlujo1.detalle_movimiento[0].cod_detalle_movimiento);
               
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

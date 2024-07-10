using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace spProcesos.Herramientas
{
    public partial class frmTrasladosDeEquiposLocal : Form
    {
        public frmTrasladosDeEquiposLocal()
        {
            InitializeComponent();
        }
        string codSucursalOrigen = "";
        string codModaldidadOrigen = "";
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool validar() 
        {
            //primero la informacion de origen
            if (txtSerial.Text == string.Empty)
            {
                MessageBox.Show("El serial es obligatorio");
                txtSerial.Focus();
                return false;
            }
            if (txtNombrecliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ingrese un serial valido.");
                txtSerial.Focus();
                return false;
            }
            //informacion de destino
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Ingrese el Cliente de destino");
                return false;
            }
            string nitDEstio = cmbCliente.SelectedValue.ToString().Trim();
            if (cmbSucursalCliente.SelectedValue == null || cmbSucursalCliente.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Ingrese la Sucursal del destino");
                return false;
            }
            if (nitDEstio != "local")
            {
                if (cmbModaldad.SelectedValue == null || cmbModaldad.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Ingrese la modalidad del destino");
                    return false;
                }
            }else {
                if (cmbEstadoEquipoLocal.SelectedValue == null || cmbEstadoEquipoLocal.SelectedValue.ToString() == string.Empty)
                {
                    MessageBox.Show("Ingrese el Estado del Equipo");
                    return false;
                }
            }
            if (chkEnvioCliente.Checked && calUltimoEnvio.ValueObject == null)
            {
                MessageBox.Show("Ingrese la Fecha de Envio");
                return false;
            }
            if (cmbCliente.SelectedValue.ToString().Trim().ToLower() != "local" && !chkEnvioCliente.Checked)
            {
                MessageBox.Show("La fecha de envio es obligatoria cuando el equipo va fuera del taller!");
                return false;
            }
            return true;
        }

        private void guardar() 
        {
            trasladarLocal( cmbCliente.SelectedValue.ToString(),cmbSucursalCliente.SelectedValue.ToString(),
                txtSerial.Text,txtObservacionesIniciales.Text,
                (cmbModaldad.Visible)?"": cmbEstadoEquipoLocal.SelectedValue.ToString());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;
            guardar();
            //if (ejecutarReserva)
            //{
            //    spProcesos.disponibles.frmEjecutarReserva frmEjecu = new disponibles.frmEjecutarReserva();
            //    frmEjecu.ejecutarReserva(codMovimientoReserva, txtSerial.Text);
            //}
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBuscarSerial_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscarEquipo fr = new spProcesos.Equipos.frmBuscarEquipo();
            fr.NitCliente = "local";
            fr.FiltraSoloUbicacionReal = true;
            if (fr.ShowDialog() == DialogResult.OK)
            {
                txtSerial.Text = fr.Serial;
                txtSerial.Focus();
                cargarserial(txtSerial.Text);
            }
        }
        private bool cargarserial(string serial)
        {
            ejecutarReserva = false;
            codMovimientoReserva = 0;
            txtSerial.Text = serial;
            //miramos si existe el serial
            equiposTableAdapter1.FillBySerial(dsSpx1.equipos, serial);
           if (dsSpx1.equipos.Rows.Count <= 0)
            {
                MessageBox.Show("El equipo con serial " + serial.Trim() + " no existe en la base de datos.");
                return false;
            }

           //
           fabricanteTableAdapter1.FillBycodFabricante(dsSpx1.fabricante, dsSpx1.equipos[0].codFabricante.Trim());
           txtFabricante.Text = dsSpx1.fabricante[0].nombre_fabricante;
           //
           modelosTableAdapter1.FillByFabricanteModelo(dsSpx1.Modelos, dsSpx1.equipos[0].codFabricante.Trim(), dsSpx1.equipos[0].codModelo.Trim());
           txtModelo.Text = dsSpx1.Modelos[0].NombreModelo;

           //esto es para cargar la modalidad con el cual fue creada la orden de servicio si cambio de modadlidad no trae el actual si no el de ese entonces.
           codModaldidadOrigen = "";

           if (!dsSpx1.equipos[0].IscodModalidadEquipoNull())
           {
               codModaldidadOrigen = dsSpx1.equipos[0].codModalidadEquipo;
               txtModalidad.Text = modalidadEquipoTableAdapter1.verNombreModadlidad(codModaldidadOrigen).ToString();
           }
           #region informacion del cliente y de la sucursal
           //esto es para cargar el cliente con el cual fue creada la orden de servicio si cambio no trae el actual si no el de ese entonces.
           string nitCliente = "";
           string codSucursal = "";


           nitCliente = dsSpx1.equipos[0].nitClienteUbica;
           codSucursal = dsSpx1.equipos[0].codSucursalUbica;

           clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
           txtNitCliente.Text = dsSpx1.clientes[0].nitCliente;
           txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente;
           //informacion de la ubicacion

           sucursalClienteTableAdapter1.FillByCodSucursalNit(dsSpx1.sucursalCliente, nitCliente, codSucursal);
           txtSucursal.Text = dsSpx1.sucursalCliente[0].nombreSucursal;
           txtDireccionUbicacion.Text = (dsSpx1.sucursalCliente[0].IsDireccionNull()) ? "" : dsSpx1.sucursalCliente[0].Direccion;
           if (!dsSpx1.sucursalCliente[0].IscodPaisNull() && !dsSpx1.sucursalCliente[0].IscodDepartamentoNull()
               && !dsSpx1.sucursalCliente[0].IscodCiudadNull())
           {
               txtUbicacion.Text = "(" + paisesTableAdapter1.verNombrePais(dsSpx1.sucursalCliente[0].codPais).ToString().Trim();
               txtUbicacion.Text += ") " + departamentoTableAdapter1.verNombreDepartamento(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento).ToString().Trim();
               txtUbicacion.Text += ", " + ciudadesTableAdapter1.verNombreCiudad(dsSpx1.sucursalCliente[0].codPais, dsSpx1.sucursalCliente[0].codDepartamento, dsSpx1.sucursalCliente[0].codCiudad).ToString().Trim();
           }
#endregion
           #region validamos si esta reservado
           if (!dsSpx1.equipos[0].IsnitClienteReservaNull())
           {
               lblReservado.Visible = true;
               cmbCliente.SelectedValue = dsSpx1.equipos[0].nitClienteReserva;
               cargarSucursal();
               cmbSucursalCliente.SelectedValue = dsSpx1.equipos[0].codSucursalReserva;
               cargarSucursalCliente();
               if (!dsSpx1.equipos[0].IscodModadlidadReservaNull())
               cmbModaldad.SelectedValue = dsSpx1.equipos[0].codModadlidadReserva;

               if (!dsSpx1.equipos[0].IscodEstadoLocalReservaNull())
                   cmbEstadoEquipoLocal.SelectedValue = dsSpx1.equipos[0].codEstadoLocalReserva;
           }else{
               lblReservado.Visible = false;
           }
           SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
#endregion
           #region verificamos si hay reservas del mismo modelo, si hay reservas para el mismo modelo, alertamos!!!
           string sql = @"select 

cod_movimiento,tipo_movimiento.nombre_tipo_movimiento,fecha_creacion
,usuario.nombre 'Creado Por',
fabricante.nombre_Fabricante,modelos.nombreModelo,
clientes.nitCliente,clientes.nombreCliente,sucursalCliente.codSucursal,
observaciones_iniciales,
movimiento.num1 'Reservado',movimiento.num2 'Entregado',
color_r,color_g,color_b,texto_alarma,
fecha_ultimo_cambio
 from movimiento
left join fabricante on fabricante.codfabricante = movimiento.txt2
left join modelos on fabricante.codfabricante = modelos.codFabricante and movimiento.txt3 = modelos.codModelo
join usuario on usuario.cod_usuario = movimiento.usuario_creacion
left join tipo_movimiento on tipo_movimiento.cod_tipo_movimiento= movimiento.cod_tipo_movimiento
left join clientes on clientes.NitCliente = movimiento.txt4
left join sucursalCliente on sucursalCliente.nitCliente = clientes.nitCliente and movimiento.txt5 = sucursalCliente.codSucursal
where 
cod_proceso_semilla=2
and fabricante.codfabricante = '"+dsSpx1.equipos[0].codFabricante.Trim().Trim()+@"'
 and  modelos.codModelo ='"+dsSpx1.equipos[0].codModelo.Trim().Trim()+@"'
and movimiento.num1 - isnull(movimiento.num2,0) !=0 order by fecha_creacion asc";
           System.Data.DataTable tb= obj.ejecutarConsulta(sql).Tables[0];
           if (tb.Rows.Count > 0)
           {
               if (MessageBox.Show("Hay una reserva para un equipo de este modelo, desea aplicarla en este momento?", "Confirmacion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
               {
                   codMovimientoReserva = long.Parse(tb.Rows[0]["cod_movimiento"].ToString());
                   cmbCliente.SelectedValue = tb.Rows[0]["nitCliente"].ToString();
                   cargarSucursal();
                   cmbSucursalCliente.SelectedValue = tb.Rows[0]["codSucursal"].ToString();
                   cargarSucursalCliente();
                   cmbCliente.Enabled = false;
                   cmbSucursalCliente.Enabled = false;
                   ejecutarReserva = true;
                   
               }
           }
           #endregion
           return true;
        }

        bool ejecutarReserva = false;
        long codMovimientoReserva = 0;
        private void txtSerial_Validating(object sender, CancelEventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            e.Cancel = !cargarserial(txtSerial.Text);
            if (e.Cancel) txtSerial.Text = "";
        }

        private void frmTrasladosDeEquipos_Load(object sender, EventArgs e)
        {
            calUltimoEnvio.MonthCalendar.DisplayMonth = DateTime.Now;
            clientesTableAdapter1.FillByLocal(dsSpx2.clientes);
            sucursalClienteTableAdapter1.FillByActivaParaTraslados(dsSpx2.sucursalCliente,"local",true);
            modalidadEquipoTableAdapter1.Fill(dsSpx2.ModalidadEquipo);
            estadoLocalEquiposTableAdapter1.Fill(dsSpx2.estadoLocalEquipos);
            cmbSucursalCliente.SelectedValue = "";
            cmbCliente.SelectedValue = "local";
            cmbModaldad.SelectedValue = "";
            
        }

        private void btnInfEquipo_Click(object sender, EventArgs e)
        {
            if (txtSerial.Text.Trim() == string.Empty) return;
            spProcesos.Equipos.frmInformacionEquipo frm = new spProcesos.Equipos.frmInformacionEquipo();
            frm.Serial = txtSerial.Text.Trim();
            frm.ShowDialog();
        }

        private void cargarSucursal()
        {
            txtDireccion.Text = "";
            txtPais.Text = "";
            txtDepartamento.Text = "";
            txtCiudad.Text = "";

            if (cmbCliente.SelectedValue != null && cmbCliente.SelectedValue.ToString().Trim() != string.Empty)
            {
                sucursalClienteTableAdapter1.FillByActivaParaTraslados(dsSpx2.sucursalCliente, cmbCliente.SelectedValue.ToString(),true);
            }
        }

        private void mostrarModalidad(bool valor)
        {
            if (valor)
            {
                lblSucursal.Text = "Sucursal";
            }
            else
            {
                lblSucursal.Text = "Bodega o Ubicacion";
            }
            lblEstadoEquipo.Location = lblModalidad.Location;
            cmbEstadoEquipoLocal.Location = cmbModaldad.Location;

            lblModalidad.Visible = valor;
            cmbModaldad.Visible = valor;
            lblEstadoEquipo.Visible = !valor;
            cmbEstadoEquipoLocal.Visible = !valor;
            txtCiudad.Visible = valor;
            txtDepartamento.Visible = valor;
            txtPais.Visible = valor;
            txtDireccion.Visible = valor;
           
            //
            lblCiudad.Visible = valor;
            lblDepartamento.Visible = valor;
            lblPais.Visible = valor;
            lblDireccion.Visible = valor;

        }

        private void cargarSucursalCliente()
        {
            if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue.ToString() == string.Empty)
            {
                mostrarModalidad(true);
                return;
            }

            //miramos si el cliente elegido es el taller local y ocultamos un combo y mostrmos el otro
            if (cmbCliente.SelectedValue.ToString().ToString().Trim() == "local")
            {
                mostrarModalidad(false);
            }
            else
            {
                mostrarModalidad(true);
            }


            if (cmbSucursalCliente.SelectedValue == null || cmbSucursalCliente.SelectedValue.ToString() == string.Empty)
                return;
            //if (cgDataControler1.verValor("codSucursalUbica") != null && (!cmbSucursalCliente.Enabled))
            //    cmbSucursalCliente.SelectedValue = cgDataControler1.verValor("codSucursalUbica");
            if (cmbSucursalCliente.SelectedValue == null) return;
            SPControladoraDatos.dsSpx.sucursalClienteDataTable tab =
            sucursalClienteTableAdapter1.GetDataByCodSucursalNit(cmbCliente.SelectedValue.ToString(), cmbSucursalCliente.SelectedValue.ToString());
            if (tab.Count > 0)
            {
                txtDireccion.Text = tab[0].IsDireccionNull() ? "" : tab[0].Direccion;
                if (!tab[0].IscodPaisNull())
                {
                    txtPais.Text = paisesTableAdapter1.verNombrePais(tab[0].codPais).ToString();

                    if (!tab[0].IscodDepartamentoNull())
                    {
                        txtDepartamento.Text = departamentoTableAdapter1.verNombreDepartamento(tab[0].codPais, tab[0].codDepartamento).ToString();

                        if (!tab[0].IscodCiudadNull())
                            txtCiudad.Text = ciudadesTableAdapter1.verNombreCiudad(tab[0].codPais, tab[0].codDepartamento, tab[0].codCiudad).ToString();
                    }
                }
            }
        }

        private void btnBuscarNit_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscaCliente fc = new spProcesos.Equipos.frmBuscaCliente();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                cmbCliente.SelectedValue = fc.NitClente;
                cargarSucursal();
                cargarSucursalCliente();
            }
        }

        private void cmbSucursalCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSucursalCliente();
        }

        private void cmbModaldad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarSucursal();
            cargarSucursalCliente();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            cmbCliente.SelectedValue = "";
            cmbSucursalCliente.SelectedValue = "";
            cargarSucursal();
        }

        private void cmbEstadoEquipoLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// Esta funcion ejecuta los traslados con las correspondentes variables que debe tener en cuenta
        /// </summary>
        /// <param name="nitDestino"></param>
        /// <param name="sucursalDestino"></param>
        /// <param name="serial"></param>
        /// <param name="observaciones"></param>
        /// <param name="fechaEnvioCliente"></param>
        /// <param name="FechaEnvioCliente"></param>
        /// <param name="ingresarModalidad"></param>
        /// <param name="modalidad"></param>
        /// <param name="estadoLocal"></param>
        public static void trasladar(string nitDestino,string sucursalDestino,
            string serial,string observaciones,bool fechaEnvioCliente,DateTime FechaEnvioCliente,
            bool ingresarModalidad,string modalidad,string estadoLocal
            )
        {
            SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter logCambioUbicacionesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter equipoAuxiliarTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursal = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            equiposTableAdapter1.FillBySerial(ds.equipos, serial);
            
            #region Cargamos la informacion de origen del Equipo
            string nitOrigen = "";
            string sucursalOrigen = "";
            if (!ds.equipos[0].IsnitClienteUbicaNull())
            {
                nitOrigen = ds.equipos[0].nitClienteUbica;
                if (!ds.equipos[0].IscodSucursalUbicaNull())
                {
                    sucursalOrigen = ds.equipos[0].codSucursalUbica;
                }            
            }
#endregion

            if (nitOrigen.Trim() == nitDestino.Trim() && sucursalDestino.Trim() == sucursalOrigen.Trim()) return;
            
            int id = logCambioUbicacionesTableAdapter1.verNextId().Value;
            int codGeneral = id;
            string codModaldidadOrigen = "";
            if (!ds.equipos[0].IscodModalidadEquipoNull())
                codModaldidadOrigen = ds.equipos[0].codModalidadEquipo;



            //validamos si la uicacion de destino requiere de permisos especiales
            sucursal.FillByCodSucursalNit(ds.sucursalCliente, nitDestino, sucursalDestino);
            if (!ds.sucursalCliente[0].IsrequierePermisoParaTrasladosNull() && ds.sucursalCliente[0].requierePermisoParaTraslados)
            {
                if (!SPXSeguridad.verificadorPermisos.ejecutarAccion(2030))
                {
                    MessageBox.Show("La ubicacion de destino requiere de permisos especiales!");
                    return;
                }
            }


            Nullable<DateTime> fechaN = new Nullable<DateTime>();

            logCambioUbicacionesTableAdapter1.Insert(id, nitOrigen, sucursalOrigen, nitDestino,
                sucursalDestino, DateTime.Now, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, serial, observaciones,
                ((fechaEnvioCliente) ? FechaEnvioCliente: fechaN),
                (codModaldidadOrigen == string.Empty ? null : codModaldidadOrigen),
                (!ingresarModalidad ? null : modalidad));
            //ahora actualizamos la informacion del equipo
            equiposTableAdapter1.UpdateUbicacion(nitDestino, sucursalDestino, serial);
            equiposTableAdapter1.UpdateUbicacionReal(nitDestino, sucursalDestino, serial);
            equiposTableAdapter1.UpdateFechaUltimoTraslado(DateTime.Now, serial);

            ds.EnforceConstraints = false;
            if(fechaEnvioCliente)
            equiposTableAdapter1.UpdateFechaSalida(FechaEnvioCliente, serial);
            //ahora actualizamos la modadalidad
            if (ingresarModalidad)
            {
                equiposTableAdapter1.UpdatecodModalidadEquipo(modalidad, serial);
                equiposTableAdapter1.UpdateCodEstadoLocal(null, serial);
            }
            else
            {
                equiposTableAdapter1.UpdatecodModalidadEquipo(null, serial);
                equiposTableAdapter1.UpdateCodEstadoLocal(estadoLocal, serial);
            }
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            dsSpx1.EnforceConstraints = false;
            //Ahora Actualizamos los equipos auxiliares del Equipo que estamos trasladando
            equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, serial);
            for (int k = 0; k < dsSpx1.equipoAuxiliar.Rows.Count; k++)
            {
                id = logCambioUbicacionesTableAdapter1.verNextId().Value;
                logCambioUbicacionesTableAdapter1.Insert(id, nitDestino, sucursalOrigen, nitDestino,
    sucursalDestino, DateTime.Now, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, dsSpx1.equipoAuxiliar[k].serialAuxiliar,
 observaciones,
    ((fechaEnvioCliente) ? FechaEnvioCliente: fechaN),
    (codModaldidadOrigen == string.Empty ? null : codModaldidadOrigen),
                (!ingresarModalidad ? null : modalidad));

                equiposTableAdapter1.UpdateUbicacion(nitDestino, sucursalDestino, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                equiposTableAdapter1.UpdateUbicacionReal(nitDestino, sucursalDestino, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                equiposTableAdapter1.UpdateFechaUltimoTraslado(DateTime.Now, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                if (fechaEnvioCliente)
                    equiposTableAdapter1.UpdateFechaSalida(FechaEnvioCliente, dsSpx1.equipoAuxiliar[k].serialAuxiliar);

                if (ingresarModalidad)
                {
                    equiposTableAdapter1.UpdatecodModalidadEquipo(modalidad, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                    equiposTableAdapter1.UpdateCodEstadoLocal(null, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                }
                else
                {
                    equiposTableAdapter1.UpdatecodModalidadEquipo(null, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                    equiposTableAdapter1.UpdateCodEstadoLocal(estadoLocal, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                }
                equiposTableAdapter1.UpdateFechaUltimoTraslado(DateTime.Now, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                if (fechaEnvioCliente)
                {
                    equiposTableAdapter1.UpdateFechaSalida(FechaEnvioCliente, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                }
            }
            //ahora miramos si el equipo es auxiliar de algun equipo le perguntamos si debemos desenlazarlo o no
            equipoAuxiliarTableAdapter1.FillByserialAuxiliar(dsSpx1.equipoAuxiliar, serial);

            if (dsSpx1.equipoAuxiliar.Rows.Count > 0)
            {
                equipoAuxiliarTableAdapter1.DeletexAuxiliar(serial);
            }
            equiposTableAdapter1.UpdateReserva(null, null, null, null, serial);
            logCambioUbicacionesTableAdapter1.FillByCodLog(dsSpx1.logCambioUbicaciones, codGeneral);
            #region zona de notificacion
          //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
         //   mailsender.EjecutarAccion(701, "", (System.Data.DataRow)dsSpx1.logCambioUbicaciones[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
        }

        public static void trasladarLocal(string nitDestino, string sucursalDestino,
           string serial, string observaciones, string estadoLocal
           )
        {
            SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter logCambioUbicacionesTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.logCambioUbicacionesTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter equipoAuxiliarTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equipoAuxiliarTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter equiposTableAdapter1 = new SPControladoraDatos.dsSpxTableAdapters.equiposTableAdapter();
            SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter sucursal = new SPControladoraDatos.dsSpxTableAdapters.sucursalClienteTableAdapter();
            SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
            equiposTableAdapter1.FillBySerial(ds.equipos, serial);

            #region Cargamos la informacion de origen del Equipo
            string nitOrigen = "";
            string nitOrigenUbicacion = "";
            string sucursalOrigen = "";
            string sucursalRealOrigen = "";
            string sucursalRealDestino = "";
            string estadoLocalActual = "";
            if (!ds.equipos[0].IsnitClienteUbicacionRealNull())
            {
                nitOrigen = ds.equipos[0].nitClienteUbicacionReal;
                nitOrigenUbicacion = ds.equipos[0].nitClienteUbica;
                if (!ds.equipos[0].IscodSucursalUbicaNull())
                {
                    sucursalOrigen = ds.equipos[0].codSucursalUbica;
                }

                if (!ds.equipos[0].IscodSucursalUbicaNull())
                {
                    sucursalRealOrigen = ds.equipos[0].codSucursalUbicaReal;
                }
            }

            if (!ds.equipos[0].IscodEstadoLocalNull())
            {
                estadoLocalActual = ds.equipos[0].codEstadoLocal;
            }
            #endregion
            nitDestino = nitDestino.Trim();
            sucursalDestino = sucursalDestino.Trim();
            sucursalRealDestino = sucursalDestino.Trim();
            sucursalRealOrigen = sucursalRealOrigen.Trim();
            nitOrigen = nitOrigen.Trim();
            sucursalOrigen = sucursalOrigen.Trim();
            estadoLocal = estadoLocal.Trim();
            estadoLocalActual = estadoLocalActual.Trim();

            if (
                nitOrigen.Trim() == nitDestino.Trim() && sucursalDestino.Trim() == sucursalOrigen.Trim() && estadoLocalActual.Trim() == estadoLocal.Trim()
                && sucursalRealDestino == sucursalRealOrigen
                )
            {
                MessageBox.Show("La ubicacion de origen y destino y el estado son iguales, no se procedera a cambiar el estado!");
                return;
            }


            if (nitOrigen.Trim() == nitDestino.Trim() && sucursalDestino.Trim() == sucursalOrigen.Trim())
            {
                MessageBox.Show("La ubicacion de origen y destino son iguales, sin embargo se procedera a cambiar el estado!");
            }

            //validamos si la uicacion de destino requiere de permisos especiales
            sucursal.FillByCodSucursalNit(ds.sucursalCliente, nitDestino, sucursalDestino);
            if (!ds.sucursalCliente[0].IsrequierePermisoParaTrasladosNull() && ds.sucursalCliente[0].requierePermisoParaTraslados)
            { 
                if(!SPXSeguridad.verificadorPermisos.ejecutarAccion(2030))
                {
                    MessageBox.Show("La ubicacion de destino requiere de permisos especiales!");
                    return;
                }            
            }

            int id = logCambioUbicacionesTableAdapter1.verNextId().Value;
            int codGeneral = id;
            string codModaldidadOrigen = "";
            if (!ds.equipos[0].IscodModalidadEquipoNull())
                codModaldidadOrigen = ds.equipos[0].codModalidadEquipo;

            Nullable<DateTime> fechaN = new Nullable<DateTime>();

            logCambioUbicacionesTableAdapter1.Insert(id, nitOrigen, sucursalOrigen, nitDestino,
                sucursalDestino, DateTime.Now, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, serial, observaciones,
                 fechaN,
                (codModaldidadOrigen == string.Empty ? null : codModaldidadOrigen),
                null);
            //ahora actualizamos la informacion del equipo        
            equiposTableAdapter1.UpdateUbicacionReal(nitDestino, sucursalDestino, serial);
            equiposTableAdapter1.UpdateFechaUltimoTraslado(DateTime.Now, serial);
            if (nitDestino.Trim().ToLower() == nitOrigenUbicacion.ToLower().Trim())
            {
                equiposTableAdapter1.UpdateUbicacion(nitDestino, sucursalDestino, serial);
            }
            ds.EnforceConstraints = false;
          
            equiposTableAdapter1.UpdateCodEstadoLocal(estadoLocal, serial);
            
            SPControladoraDatos.dsSpx dsSpx1 = new SPControladoraDatos.dsSpx();
            dsSpx1.EnforceConstraints = false;
            //Ahora Actualizamos los equipos auxiliares del Equipo que estamos trasladando
            equipoAuxiliarTableAdapter1.FillByserialEquipo(dsSpx1.equipoAuxiliar, serial);
            for (int k = 0; k < dsSpx1.equipoAuxiliar.Rows.Count; k++)
            {
                id = logCambioUbicacionesTableAdapter1.verNextId().Value;
                logCambioUbicacionesTableAdapter1.Insert(id, nitDestino, sucursalOrigen, nitDestino,
    sucursalDestino, DateTime.Now, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, dsSpx1.equipoAuxiliar[k].serialAuxiliar,
 observaciones,
   fechaN,
    (codModaldidadOrigen == string.Empty ? null : codModaldidadOrigen),
                null );
                equiposTableAdapter1.UpdateUbicacionReal(nitDestino, sucursalDestino, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                equiposTableAdapter1.UpdateFechaUltimoTraslado(DateTime.Now, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
               
               equiposTableAdapter1.UpdateCodEstadoLocal(estadoLocal, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
                
                equiposTableAdapter1.UpdateFechaUltimoTraslado(DateTime.Now, dsSpx1.equipoAuxiliar[k].serialAuxiliar);
               
            }
            //ahora miramos si el equipo es auxiliar de algun equipo le perguntamos si debemos desenlazarlo o no
            equipoAuxiliarTableAdapter1.FillByserialAuxiliar(dsSpx1.equipoAuxiliar, serial);

            if (dsSpx1.equipoAuxiliar.Rows.Count > 0)
            {
                equipoAuxiliarTableAdapter1.DeletexAuxiliar(serial);
            }
            equiposTableAdapter1.UpdateReserva(null, null, null, null, serial);
            logCambioUbicacionesTableAdapter1.FillByCodLog(dsSpx1.logCambioUbicaciones, codGeneral);
            #region zona de notificacion
            //  CgSmtpEmailSender.core.clsSender mailsender = new CgSmtpEmailSender.core.clsSender();
            //   mailsender.EjecutarAccion(701, "", (System.Data.DataRow)dsSpx1.logCambioUbicaciones[0], null, CgSmtpEmailSender.core.clsSender.prioridad.media,"","");
            #endregion
        }
    }
}

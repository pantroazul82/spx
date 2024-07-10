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
    public partial class frmNuevaAsesoria : Form
    {
        public frmNuevaAsesoria()
        {
            InitializeComponent();
        }

        public int codAsesoria { set; get; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void cargarDatos()
        {
            prioridad_callcenter_cientificaTableAdapter1.Fill(dsSpx1.prioridad_callcenter_cientifica);
            string sql = "select cod_usuario,login,nombre from usuario order by nombre asc ";
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            cmbUsuarioInterno.DataSource= obj.ejecutarConsulta(sql).Tables[0];
            cmbUsuarioInterno.DisplayMember = "nombre";
            cmbUsuarioInterno.ValueMember = "cod_usuario";
            cmbUsuarioInterno.SelectedValue = -1;
        }

        public bool validar()
        {
            if (cmbPrioridad.SelectedValue == null || cmbPrioridad.SelectedValue.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione la Prioridad!!!");
                return false;
            }
            if (!rdDisponibilidad.Checked && !rdNoDisponibilidad.Checked)
            {
                MessageBox.Show("Seleccione si llamada es de disponibilidad o no!!!");
                return false;
            }
            if (nitCliente == null || nitCliente.Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione el Cliente !!!");
                return false;
            }
            if (codUbicacion == null || codUbicacion.Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione la Sucursal !!!");
                return false;
            }
            if (codContacto == null || codContacto.Trim() == string.Empty)
            {
                MessageBox.Show("Seleccione el contacto!!!");
                return false;
            }

            if (calSugerida.fechaValueObject == null )
            {
                MessageBox.Show("Seleccione una fecha sugerida valida!!!");
                return false;
            }
            if(calRespuestaInicial.Visible && calRespuestaInicial.fechaValueObject == null)
            {
                MessageBox.Show("Seleccione la fecha de respuesta inicial!!!");
                return false;
            }

            if (calRespuestaInicial.Visible && calRespuestaInicial.fechaValue < calFechaSolicitud.Value )
            {
                calFechaSolicitud.Value = calRespuestaInicial.fechaValue;
               // MessageBox.Show("La fecha de respuesta inicial no puede ser menor que la fecha de creacion!!!");
               // return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;

            if (codAsesoria == 0)
            {
                estado_asesoria_cientificaTableAdapter1.FillByCod_manual(dsSpx1.estado_asesoria_cientifica, "1");

                int est = dsSpx1.estado_asesoria_cientifica[0].cod_estado_asesoria_cientifica;
               
                asesoria_cientificaTableAdapter1.Insert(est, int.Parse(cmbPrioridad.SelectedValue.ToString()),
                    null, calFechaSolicitud.Value, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, nitCliente,
                    cmbSucursal.SelectedValue.ToString(),
                    codContacto, txtInfAdiContacto.Text, null,  txtMotivoConsulta.Text,
                    "", "", null, null, null, null, null, 0, "", null, null, "", null, null, null, null, null,
                    "", null, null, null, "", null, null, null, null, null, calSugerida.fechaValue,
                    null, null, null, null, null, null,null,null,null,null);
               int? codA= (int?)asesoria_cientificaTableAdapter1.verIdentity();
               if (!codA.HasValue || codA.Value == 0)
                {
                    codA = (int)asesoria_cientificaTableAdapter1.verIdentityForzado().Value;
                }
               asesoria_cientificaTableAdapter1.UpdateLlamada_recibida_disponibilidad(rdDisponibilidad.Checked, codA.Value);
               asesoria_cientificaTableAdapter1.UpdateInfoInterna(chkInterna.Checked,
                   (cmbUsuarioInterno.SelectedValue == null ||cmbUsuarioInterno.SelectedValue.ToString().Trim() == string.Empty)
                   ?null:cmbUsuarioInterno.SelectedValue.ToString(), codA.Value);
               
                if (lblRespuestaInicial.Visible == true)
                {
                    asesoria_cientificaTableAdapter1.UpdateFechaRespuestaInicial(calRespuestaInicial.fechaValue, codA.Value);    
                }
            }
            else
            {
                asesoria_cientificaTableAdapter1.UpdateQuery(int.Parse(cmbPrioridad.SelectedValue.ToString()),
                       null, calFechaSolicitud.Value, SPXSeguridad.logica.sesion.LoginUsuarioAutenticado, nitCliente,
                       cmbSucursal.SelectedValue.ToString() ,
                       codContacto, txtInfAdiContacto.Text, null, null, txtMotivoConsulta.Text,
                       "", "", null, null, null, null, null, 0, "", null, null, "", null, null, null, null, null,
                       "", null, null, null, "", codAsesoria);
                asesoria_cientificaTableAdapter1.UpdateFecha_sugerida(calSugerida.fechaValue, codAsesoria);

                asesoria_cientificaTableAdapter1.UpdateLlamada_recibida_disponibilidad(rdDisponibilidad.Checked, codAsesoria);

                if (lblRespuestaInicial.Visible == true)
                {
                    asesoria_cientificaTableAdapter1.UpdateFechaRespuestaInicial(calRespuestaInicial.fechaValue, codAsesoria);
                }
                asesoria_cientificaTableAdapter1.UpdateInfoInterna(chkInterna.Checked, (cmbUsuarioInterno.SelectedValue == null) ? null : cmbUsuarioInterno.SelectedValue.ToString(), codAsesoria);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void frmNuevaAsesoria_Load(object sender, EventArgs e)
        {
            cargarDatos();
            SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();
            calFechaSolicitud.Value = obj.fechaServer;
            calFechaSolicitud.Enabled = false;
            txtRegistadaPor.Text = SPXSeguridad.logica.sesion.NombreUsuarioAutenticado;
            calSugerida.fechaValue = obj.fechaServer;
            if (codAsesoria != 0)
            {
                cmbPrioridad.Enabled = false;
                asesoria_cientificaTableAdapter1.FillByCod_asesoria_cientifica(dsSpx1.asesoria_cientifica, codAsesoria);
                nitCliente = dsSpx1.asesoria_cientifica[0].nitCliente;
                codContacto = dsSpx1.asesoria_cientifica[0].codContacto;
                codUbicacion = dsSpx1.asesoria_cientifica[0].codSucursal;
                txtNumeroAsesoria.Text = codAsesoria.ToString();
                txtRegistadaPor.Text = dsSpx1.asesoria_cientifica[0].usuario_creacion;
                txtMotivoConsulta.Text = dsSpx1.asesoria_cientifica[0].motivo_consulta;
                if (!dsSpx1.asesoria_cientifica[0].Isfecha_sugeridaNull())
                calSugerida.fechaValue = dsSpx1.asesoria_cientifica[0].fecha_sugerida;
                txtInfAdiContacto.Text = dsSpx1.asesoria_cientifica[0].infAdicionalContacto;
                cmbPrioridad.SelectedValue = dsSpx1.asesoria_cientifica[0].cod_prioridad_sugerida;
                calFechaSolicitud.Value = dsSpx1.asesoria_cientifica[0].fecha_solicitud;
                //cargamos la informacion del cliente
                clientesTableAdapter1.FillByNitCliente(dsSpx1.clientes, nitCliente);
                txtNombrecliente.Text = dsSpx1.clientes[0].nombreCliente.Trim() + " (" + dsSpx1.clientes[0].nitCliente.Trim() + ")";
                
                if (!dsSpx1.clientes[0].IsnumeroSocioNull())
                txtSn.Text = dsSpx1.clientes[0].numeroSocio;

                sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, nitCliente);
                cmbSucursal.SelectedValue = codUbicacion;
                contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, nitCliente, codContacto);
                txtNombreContacto.Text = dsSpx1.contactosClientes[0].nombreContacto.Trim() + " " + dsSpx1.contactosClientes[0].apellidosContacto;
                txtTelefonoContacto.Text = dsSpx1.contactosClientes[0].telefono1;
                if (!dsSpx1.contactosClientes[0].IscelularNull()) txtCelularContacto.Text = dsSpx1.contactosClientes[0].celular;
                cargarInfAdcionalCliente();
                if (!dsSpx1.asesoria_cientifica[0].Isllamada_recibida_disponibilidadNull())
                {
                    if (dsSpx1.asesoria_cientifica[0].llamada_recibida_disponibilidad)
                    {
                        lblRespuestaInicial.Visible = true;
                        calRespuestaInicial.Visible = true;
                        rdDisponibilidad.Checked = true;
                        calRespuestaInicial.fechaValue = dsSpx1.asesoria_cientifica[0].fecha_respuesta_inicial;
                    }else{
                        lblRespuestaInicial.Visible = false;
                        calRespuestaInicial.Visible = false;
                        rdNoDisponibilidad.Checked = true;
                    }
                }
                if (!dsSpx1.asesoria_cientifica[0].Isind_internaNull())
                {
                    chkInterna.Checked = dsSpx1.asesoria_cientifica[0].ind_interna;
                }
                if (!dsSpx1.asesoria_cientifica[0].Isusuario_internaNull())
                {
                   cmbUsuarioInterno.SelectedValue = dsSpx1.asesoria_cientifica[0].usuario_interna;
                }

            }

        }
        string nitCliente = "";
        string codContacto = "";
        string codUbicacion = "";

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            spProcesos.Equipos.frmBuscaClienteCientifica fc = new spProcesos.Equipos.frmBuscaClienteCientifica();
            if (fc.ShowDialog() == DialogResult.OK)
            {
                if (fc.NitClente != nitCliente)
                {
                    nitCliente = fc.NitClente;
                    txtNombrecliente.Text = fc.NombreClente.Trim() + " (" + fc.NitClente.Trim() + ")";
                    txtSn.Text = fc.NumeroSocio;
                    sucursalClienteTableAdapter1.FillByNitCliente(dsSpx1.sucursalCliente, nitCliente);
                    cmbSucursal.SelectedIndex = 0;

                    if (cmbSucursal.SelectedValue == null || cmbSucursal.SelectedValue.ToString().Trim() == string.Empty)
                    {
                        MessageBox.Show("El cliente seleccionado no tiene sucursales", "Informacion!");
                        return;
                    }
                    codUbicacion = cmbSucursal.SelectedValue.ToString();
                    cargarInfAdcionalCliente();
                }
            }
        }

        private void btnInfCliente_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfCliente fr = new SpFrm.terceros.frmInfCliente();
            fr.nitCliente = nitCliente;
            fr.Show();
        }

        private void btnInfSucursal_Click(object sender, EventArgs e)
        {
            if (codUbicacion == string.Empty)
            {
                MessageBox.Show("Seleccione una Sucursal", "Confirmacion");
                return;
            }
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfSucursal fr = new SpFrm.terceros.frmInfSucursal();
            fr.NitCliente = nitCliente;
            fr.CodSucursal = codUbicacion;
            fr.Show();
        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty && txtNombrecliente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Primero debe ingresar el Cliente o el serial del Equipo");
                return;
            }
            spProcesos.Equipos.frmContactosCliente frm2 = new spProcesos.Equipos.frmContactosCliente();
            frm2.NitCliente = nitCliente;
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                codContacto = frm2.CodContacto;
                contactosClientesTableAdapter1.FillBycodContactoNit(dsSpx1.contactosClientes, nitCliente, codContacto);
                txtNombreContacto.Text = dsSpx1.contactosClientes[0].nombreContacto.Trim() + " " + dsSpx1.contactosClientes[0].apellidosContacto;
                txtTelefonoContacto.Text = dsSpx1.contactosClientes[0].telefono1;
                if (!dsSpx1.contactosClientes[0].IscelularNull()) txtCelularContacto.Text = dsSpx1.contactosClientes[0].celular;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (nitCliente.Trim() == string.Empty) return;
            SpFrm.terceros.frmInfContactoSucursal fr = new SpFrm.terceros.frmInfContactoSucursal();
            fr.NitCliente = nitCliente;
            fr.CodContacto = codContacto;
            fr.Show();
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarInfAdcionalCliente();
        }

        private void cargarInfAdcionalCliente()
        {
            if (cmbSucursal.SelectedValue == null || cmbSucursal.SelectedValue.ToString().Trim() == string.Empty) return;
            string sucursal =  cmbSucursal.SelectedValue.ToString() ;
            string cliente = nitCliente;
            SPControladoraDatos.dsSpx ds=new SPControladoraDatos.dsSpx();
            
            sucursalClienteTableAdapter1.FillByCodSucursalNit(ds.sucursalCliente, cliente, sucursal);
            if (ds.sucursalCliente.Count > 0)
            { 
                string pais = ds.sucursalCliente[0].codPais;
                string departamento= ds.sucursalCliente[0].codDepartamento;
                string ciudad = ds.sucursalCliente[0].codCiudad;
                txtCiudad.Text = 
                ciudadesTableAdapter1.verNombreCiudad(pais,departamento,ciudad).Trim()+" ("+
                departamentoTableAdapter1.verNombreDepartamento( pais,departamento).ToString().Trim()+")";
            }
            
        }

        private void rdDisponibilidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDisponibilidad.Checked)
            {
                lblRespuestaInicial.Visible = true;
                calRespuestaInicial.Visible = true;
                calRespuestaInicial.Enabled = true;
            }else{
                lblRespuestaInicial.Visible = false;
                calRespuestaInicial.Visible = false;
            }
        }

        private void chkInterna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInterna.Checked)
            {
                cmbUsuarioInterno.Enabled = true;
            }
            else
            {
                cmbUsuarioInterno.Enabled = false;
                cmbUsuarioInterno.SelectedValue = -1;
            }
        }
    }
}

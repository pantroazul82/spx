using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spHerramientas.tool
{
    public partial class frmDefaults : Form
    {
        public frmDefaults()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream st= new System.IO.MemoryStream();
            if (cmbCiudad.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una ciudad valida");
                return;
            }
            Nullable<DateTime> fechaN= new Nullable<DateTime>();
            picLogo.Image.Save(st, System.Drawing.Imaging.ImageFormat.Jpeg);
            defaultsTableAdapter1.UpdateQuery(cmbPais.SelectedValue.ToString(), cmbDepartamentos.SelectedValue.ToString(),cmbCiudad.SelectedValue.ToString(),st.ToArray(),txtTituloOrdenServicio.Text,
                txtVersionOrdenServicio.Text,chkPideFechaordenServicio.Checked,chkModificarOSSolicitudAbierta.Checked,
                txtTituloRptInsumos.Text.Trim(),txtVersionRptInsumos.Text.Trim(),txtTituloOrdenPrestamo.Text,txtVersionOrdenPrestamo.Text,txtTituloReporteServicio.Text,
                txtVersionReporteServicio.Text,txtTituloEntradaSalida.Text,txtVersionEntradaSalida.Text,(int)nmDias.Value,(int)nmMeses.Value,
                txtTituloViajes.Text,txtVersionProgramacionViajes.Text,txtTituloLlamadas.Text,txtVersionLlamadas.Text,txtTitulosolicitud.Text,
                txtVersionSolicitud.Text
                ,txtTipoOrdenServicio.Text,(calFechaVigenciaOs.ValueObject==null)?fechaN:calFechaVigenciaOs.Value
                ,txtTipoInsumos.Text,(calVigenciaInsumos.ValueObject==null)?fechaN:calVigenciaInsumos.Value
                ,txtTipoOrdenPrestamo.Text,(calVigenciaOrdenPrestamo.ValueObject==null)?fechaN:calVigenciaOrdenPrestamo.Value
                ,txtTipoReporteServicio.Text,(calVigenciaReporteServicio.ValueObject==null)?fechaN:calVigenciaReporteServicio.Value
                ,txtTipoES.Text,(calVigenciaES.ValueObject==null)?fechaN:calVigenciaES.Value
                ,txtTipoProgramacion.Text,(calVigenciaProgramacion.ValueObject==null)?fechaN:calVigenciaProgramacion.Value
                ,txtTipoDocumentoLlamadas.Text,(calVigenciaLLamadas.ValueObject==null)?fechaN:calVigenciaLLamadas.Value
                ,txtTipoSolicitud.Text,(calVigenciaSolicitud.ValueObject==null)?fechaN:calVigenciaSolicitud.Value
                );
            defaultsTableAdapter1.UpdateControlCalidad(txtTituloControlCalidad.Text, txtVersionControlCalidad.Text,
                (calVigenciaControlCalidad.ValueObject == null)?null:calVigenciaControlCalidad.Value.ToShortDateString()
                , txtTipoDocumentoControlCalidad.Text);
            defaultsTableAdapter1.UpdateNotaPieReportesServico(txtNotaPieReportes.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmDefaults_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector dc = new SPXdata.BD.DataConector();
            DateTime n = dc.fechaServer;
            paisesTableAdapter1.Fill(dsSpx1.paises);
            defaultsTableAdapter1.Fill(dsSpx1.defaults);
            calFechaVigenciaOs.MonthCalendar.DisplayMonth = n;
            calVigenciaES.MonthCalendar.DisplayMonth = n;
            calVigenciaInsumos.MonthCalendar.DisplayMonth = n;
            calVigenciaLLamadas.MonthCalendar.DisplayMonth = n;
            calVigenciaOrdenPrestamo.MonthCalendar.DisplayMonth = n;
            calVigenciaProgramacion.MonthCalendar.DisplayMonth = n;
            calVigenciaReporteServicio.MonthCalendar.DisplayMonth = n;
            calVigenciaSolicitud.MonthCalendar.DisplayMonth = n;


            Nullable<DateTime> fechaN= new Nullable<DateTime>();
            if (dsSpx1.defaults.Rows.Count <= 0)
            {
                defaultsTableAdapter1.Insert("", "", "",null,"","",false,false,"","","","","","","","","","",0,6,"","","","","","","","","",
                    fechaN,"",fechaN,"",fechaN,"",fechaN,"",fechaN,"",fechaN,"",fechaN,"",fechaN,false,false,null,null,null,null,null,null,"");
            }

            if (!dsSpx1.defaults[0].IstituloControlCalidadNull())
            txtTituloControlCalidad.Text= dsSpx1.defaults[0].tituloControlCalidad;

            if (!dsSpx1.defaults[0].IsversionControlCalidadNull())
            txtVersionControlCalidad.Text= dsSpx1.defaults[0].versionControlCalidad;

            if (!dsSpx1.defaults[0].IsfechaVigenciaControlCalidadNull())
            {
                try
                {
                    calVigenciaControlCalidad.Value = DateTime.Parse(dsSpx1.defaults[0].fechaVigenciaControlCalidad);
                }catch(Exception){}
            }

            if (!dsSpx1.defaults[0].IscodigoReporteControlCalidadNull())
            txtTipoDocumentoControlCalidad.Text = dsSpx1.defaults[0].codigoReporteControlCalidad;


            cmbPais.SelectedValue = dsSpx1.defaults[0].codPais;
            if (!dsSpx1.defaults[0].IscodDepartamentoNull())
            {
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento,cmbPais.SelectedValue.ToString());
                cmbDepartamentos.SelectedValue = dsSpx1.defaults[0].codDepartamento;
                if (!dsSpx1.defaults[0].IscodCiudadNull())
                {
                    ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(),cmbDepartamentos.SelectedValue.ToString());
                    cmbCiudad.SelectedValue = dsSpx1.defaults[0].codCiudad;
                }
            }
            if (!dsSpx1.defaults[0].IslogotipoNull())
            {
                byte[] arr = (byte[])dsSpx1.defaults[0].logotipo;
                System.IO.Stream st = new System.IO.MemoryStream(arr);
                System.Drawing.Image im = Image.FromStream(st);
                picLogo.Image = im;
            }
            if (!dsSpx1.defaults[0].IspedirFechaOrdenServicioNull())
            {
                chkPideFechaordenServicio.Checked = dsSpx1.defaults[0].pedirFechaOrdenServicio;
            }
            if (!dsSpx1.defaults[0].IsmodificaOrden_InsumosabiertaNull())
            {
                chkModificarOSSolicitudAbierta.Checked = dsSpx1.defaults[0].modificaOrden_Insumosabierta;
            }
            txtTituloOrdenServicio.Text = dsSpx1.defaults[0].tituloOrdenServicio.Trim();
            txtVersionOrdenServicio.Text = dsSpx1.defaults[0].versionOrdenServicio.Trim();
            if (!dsSpx1.defaults[0].IscodigoOrdenServicioNull())
                txtTipoOrdenServicio.Text = dsSpx1.defaults[0].codigoOrdenServicio.Trim();
            if (!dsSpx1.defaults[0].IsfechaVigenciaOrdenServicioNull())
                calFechaVigenciaOs.Value = dsSpx1.defaults[0].fechaVigenciaOrdenServicio;


            txtTituloOrdenPrestamo.Text = dsSpx1.defaults[0].tituloOrdenPrestamo.Trim();
            txtVersionOrdenPrestamo.Text = dsSpx1.defaults[0].versionOrdenPrestamo.Trim();
            if (!dsSpx1.defaults[0].IscodigoOrdenPrestamoNull())
                txtTipoOrdenPrestamo.Text = dsSpx1.defaults[0].codigoOrdenPrestamo.Trim();
            if (!dsSpx1.defaults[0].IsfechaVigenciaOrdenPrestamoNull())
                calVigenciaOrdenPrestamo.Value = dsSpx1.defaults[0].fechaVigenciaOrdenPrestamo;



            if(!dsSpx1.defaults[0].IsnombreReporteInsumosNull())
                txtTituloRptInsumos.Text = dsSpx1.defaults[0].nombreReporteInsumos.Trim();
            if (!dsSpx1.defaults[0].IsversionReporteInsumosNull())
                txtVersionRptInsumos.Text = dsSpx1.defaults[0].versionReporteInsumos.Trim();
            if (!dsSpx1.defaults[0].IscodigoReporteInsumosNull())
                txtTipoInsumos.Text = dsSpx1.defaults[0].codigoReporteInsumos.Trim();
            if (!dsSpx1.defaults[0].IsfechaVigenciaReporteInsumosNull())
                calVigenciaInsumos.Value = dsSpx1.defaults[0].fechaVigenciaReporteInsumos;



        
            if (!dsSpx1.defaults[0].IstituloReporteServicioNull())
                txtTituloReporteServicio.Text = dsSpx1.defaults[0].tituloReporteServicio.Trim();
            if (!dsSpx1.defaults[0].IsversionReporteServicioNull())
                txtVersionReporteServicio.Text = dsSpx1.defaults[0].versionReporteServicio.Trim();
            if (!dsSpx1.defaults[0].IscodigoReporteServicioNull())
                txtTipoReporteServicio.Text = dsSpx1.defaults[0].codigoReporteServicio.Trim();
            if (!dsSpx1.defaults[0].IsfechaVigenciaReporteServicioNull())
                calVigenciaReporteServicio.Value = dsSpx1.defaults[0].fechaVigenciaReporteServicio;



            if (!dsSpx1.defaults[0].IstituloRegistroEntradaSalidaNull())
                txtTituloEntradaSalida.Text = dsSpx1.defaults[0].tituloRegistroEntradaSalida.Trim();
            if (!dsSpx1.defaults[0].IsversionRegistroEntradaSalidaNull())
                txtVersionEntradaSalida.Text = dsSpx1.defaults[0].versionRegistroEntradaSalida.Trim();
            if (!dsSpx1.defaults[0].IscodigoEntradaSalidaNull())
                txtTipoES.Text = dsSpx1.defaults[0].codigoEntradaSalida.Trim();
            if (!dsSpx1.defaults[0].IsfechaVigenciaEntradaSalidaNull())
                calVigenciaES.Value = dsSpx1.defaults[0].fechaVigenciaEntradaSalida;


            //titulos de programacion de viajes y de llamadas
            if (!dsSpx1.defaults[0].IstituloViajesNull())
                txtTituloViajes.Text = dsSpx1.defaults[0].tituloViajes.Trim();
            if (!dsSpx1.defaults[0].IsversionViajesNull())
                txtVersionProgramacionViajes.Text = dsSpx1.defaults[0].versionViajes.Trim();
            if (!dsSpx1.defaults[0].IscodigoViajesNull())
                txtTipoProgramacion.Text = dsSpx1.defaults[0].codigoViajes.Trim();
            if (!dsSpx1.defaults[0].IsfechaVigenciaViajesNull())
                calVigenciaProgramacion.Value = dsSpx1.defaults[0].fechaVigenciaViajes;

            if (!dsSpx1.defaults[0].IstituloLlamadasNull())
                txtTituloLlamadas.Text = dsSpx1.defaults[0].tituloLlamadas.Trim();
            if (!dsSpx1.defaults[0].IsversionLlamadasNull())
                txtVersionLlamadas.Text = dsSpx1.defaults[0].versionLlamadas.Trim();
            if (!dsSpx1.defaults[0].IscodigoLLamadasNull())
                txtTipoDocumentoLlamadas.Text = dsSpx1.defaults[0].codigoLLamadas.Trim();
            if (!dsSpx1.defaults[0].IsfechaVigenciaLlamadasNull())
                calVigenciaLLamadas.Value = dsSpx1.defaults[0].fechaVigenciaLlamadas;
            //
            if (!dsSpx1.defaults[0].IstituloSolicitudNull())
                txtTitulosolicitud.Text = dsSpx1.defaults[0].tituloSolicitud.Trim();
            if (!dsSpx1.defaults[0].IsversionSolicitudNull())
                txtVersionSolicitud.Text = dsSpx1.defaults[0].versionSolicitud.Trim();
            if (!dsSpx1.defaults[0].IscodigoSolicitudNull())
                txtTipoSolicitud.Text = dsSpx1.defaults[0].codigoSolicitud.Trim();
            if (!dsSpx1.defaults[0].IsfechaVigenciaSolicitudNull())
                calVigenciaSolicitud.Value = dsSpx1.defaults[0].fechaVigenciaSolicitud;

            if (!dsSpx1.defaults[0].IsnotaPieReportesServicoNull())
                txtNotaPieReportes.Text = dsSpx1.defaults[0].notaPieReportesServico.Trim();


            //dias y meses por mantenmiento
            if (!dsSpx1.defaults[0].IsdiasxMantenimientoNull())
            nmDias.Value = (decimal)dsSpx1.defaults[0].diasxMantenimiento;
            if (!dsSpx1.defaults[0].IsmesesxMantenimientoNull())
            nmMeses.Value = (decimal)dsSpx1.defaults[0].mesesxMantenimiento;
        
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPais.SelectedValue != null)
            {
                departamentoTableAdapter1.FillByCodigoPais(dsSpx1.departamento, cmbPais.SelectedValue.ToString());
                cmbDepartamentos.SelectedValue = dsSpx1.defaults[0].codDepartamento;
            }
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartamentos.SelectedValue != null && cmbPais.SelectedValue != null)
            {
                ciudadesTableAdapter1.FillByCodPaisCodDepartamento(dsSpx1.ciudades, cmbPais.SelectedValue.ToString(), cmbDepartamentos.SelectedValue.ToString());
                cmbCiudad.SelectedValue = dsSpx1.defaults[0].codCiudad;
            }
        }

        private void btnSubirLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try {
                    picLogo.Image = Image.FromFile(openFileDialog1.FileName);
                }catch(Exception ex)
                {
                    MessageBox.Show("Error al subir la imagen\n"+ex.Message);
                }
            
            }
        }

        private void btnBajarLogo_Click(object sender, EventArgs e)
        {
            if (picLogo.Image == null) return;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image im = picLogo.Image;
                    im.Save(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la imagen\n" + ex.Message);
                }

            }
        }
    }
}
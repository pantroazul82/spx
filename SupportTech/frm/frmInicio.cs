using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupportTech.frm
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        //el invicible se da con opacity 1%
        public static System.Configuration.SettingsBase cnn;
        public static string nombrePropiedadCnn;
        public static bool validarUsuarios = false;
        public static int usuariosLicencia=3;

        private void frmInicio_Load(object sender, EventArgs e)
        {

            SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar fr = new SPControladoraDatos.artefactos.SPXUtilidades.Themes.FrmPersonalizar();
            SPControladoraDatos.artefactos.SPXUtilidades.Themes.ThemeManager.inicializar();
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.nombreSoftware = "SupportTech";
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.logotipoSoftware = Properties.Resources.logo;
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.iconoSoftware = Properties.Resources.icono;
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.menuInterface.parametrosSoftware.formularioWinInicio = 1;

            //creamos el login 
            SPXSeguridad.frmLogin.PasswordFuerte = true;
            SPXSeguridad.frmLogin.DiasCambioPassword = 30;
            SPXSeguridad.frmLogin.ExigeCambioPassword = true;

           SPXSeguridad.frmLogin frLogin = new SPXSeguridad.frmLogin();
           SPXdata.BD.DataConector objDAta = new SPXdata.BD.DataConector();
           
            if (frLogin.ShowDialog() == DialogResult.OK)
            {
                //configura la conexion del ejecutable que lanzo el software
                if (cnn != null)
                {

                    cnn[nombrePropiedadCnn] = objDAta.CadenaConexion;
                    cnn.Save();
                }
                //

                    string sql = "select count(*) from usuario";
                    SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
                if (validarUsuarios)
                {
                    string a = bd.ejecutarProcedimiento(sql).ToString();
                    int u = 0;
                    int.TryParse(a, out u);
                    if (u > usuariosLicencia-1)//siempre hay 1 usuario que es de kuxan
                    {
                        MessageBox.Show("alcanzo el numero maximo de usuarios de la licencia");

                        Application.Exit();
                        return;
                    }
                }
                //cargamos la version obligatoria y la comparamos con el valor guardado en versionObligatoriaSupportech
                 sql = "select versionObligatoria from defaults";
                object ob = bd.ejecutarProcedimiento(sql).ToString();
                if (ob != null && ob != System.DBNull.Value)
                {
                    int ver = 0;
                    int.TryParse(ob.ToString(), out ver);
                    if (ver > SupportTech.cnn.versionObligatoriaSupportech)
                    {
                        MessageBox.Show("Su version de Supportech es obsoleta debe actualizar a la ultima version del software.\n", "Actualizacion Obligatoria", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        Application.Exit();
                        return;
                    }
                }

                //aca debria agregarse las opciones que son exclusivamtente del spx.
                if (!SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloNotificaciones.HasValue)
                    SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloNotificaciones = true;
                if (!SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloReportes.HasValue)
                    SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloReportes = true;
                if (!SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloSeguridad.HasValue)
                    SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloSeguridad = true;
                if (!SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloTablasComunes.HasValue)
                    SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloTablasComunes = true;
                if (!SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloWMS.HasValue)
                    SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloWMS = true;

                if (!SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloFlujo.HasValue)
                    SPControladoraDatos.artefactos.SPXprincipal.logica.clsInicializador.moduloFlujo = true;
                //configuramos la cadena de conexion del controladora de datos de spx
                #region parametros del anterior spx se mantienen pero con el tiempo deberian desaparecer
                //temporalemente debemos asignar doble la conexion para el cgutil y el SPXdata
                //Cargamos todas las cadenas de conexion de los componentes
                SPControladoraDatos.cnn.cargarCnn();
                SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmSeleccionReporte.agregarCampoRpt("picLogo", "select logotipo from defaults",
                    SPControladoraDatos.artefactos.SPXQuery.frm.Reportes.frmSeleccionReporte.TipoCampoRpt.imagen);
                #endregion
                SPControladoraDatos.artefactos.SPXprincipal.frmPrincipal frPrinicpal = new SPControladoraDatos.artefactos.SPXprincipal.frmPrincipal();

                SPControladoraDatos.artefactos.SPXprincipal.frmPrincipal.quicks a1 = new SPControladoraDatos.artefactos.SPXprincipal.frmPrincipal.quicks();
                a1.frm = "spHorarios.Form1";
                a1.permiso = 0;
                a1.toolTip = "Calendario";
                a1.imagen = Properties.Resources.calendar30;
                frPrinicpal.accesos.Add(a1);

                SPControladoraDatos.artefactos.SPXprincipal.frmPrincipal.quicks a2 = new SPControladoraDatos.artefactos.SPXprincipal.frmPrincipal.quicks();
                a2.frm = "spHerramientas.consultas.frmSeguimiento";
                a2.permiso = 1095;
                a2.toolTip = "Seguimiento";
                a2.imagen = Properties.Resources.seguimiento;
                frPrinicpal.accesos.Add(a2);

                frPrinicpal.Show();
                Visible = false;
                Hide();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}

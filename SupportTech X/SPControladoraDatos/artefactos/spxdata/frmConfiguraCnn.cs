using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SPX2019.artefactos.SPXdata.frm
{
    public partial class frmConfiguraCnn : Form
    {

        public frmConfiguraCnn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// carga la tabla de el disco duro, generalmente esta en data/cnn.xml
        /// </summary>
        public System.Data.DataTable cargarCnn()
        {
            if (DesignMode) return null;
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!System.IO.Directory.Exists(ruta + @"\data"))
            {
                System.IO.Directory.CreateDirectory(ruta + @"\data");
            }
            //cargamos el archivo
            if (System.IO.File.Exists(ruta + @"\data\cnn.xml"))
            {
                tablaConexiones.Clear();
                tablaConexiones.ReadXml(ruta + @"\data\cnn.xml");
            }
            return tablaConexiones;
        }

        /// <summary>
        /// carga la tabla de el disco duro, generalmente esta en data/cnn.xml
        /// </summary>
        private void guardarCnn()
        {
            string ruta = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            if (!System.IO.Directory.Exists(ruta + @"\data"))
            {
                System.IO.Directory.CreateDirectory(ruta + @"\data");
            }
            //cargamos el archivo
           
            tablaConexiones.WriteXml(ruta + @"\data\cnn.xml");
            
        }     



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardarCnn();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (grdDatos.Columns[0].Text.Trim() == string.Empty) return;
            
                frm.cnn.frmTipoConexxion frm = new frm.cnn.frmTipoConexxion();
                int pos = grdDatos.Row;
                Cryptografia.CryptoRijndael objR = new Cryptografia.CryptoRijndael();

                switch (tablaConexiones.Rows[pos]["tipo_cnn"].ToString().ToUpper())
                {
                    case "MYSQL": { frm.tipo =DataConector.tipoMotor.mysql; break; }
                    case "ORACLE": { frm.tipo =DataConector.tipoMotor.oracle; break; }
                    case "POSTGRESS": { frm.tipo =DataConector.tipoMotor.postgress; break; }
                    case "SQLSERVER": { frm.tipo =DataConector.tipoMotor.SQLserver; break; }
                }
                #region asignamos propiedades
                frm.nombreConexion = tablaConexiones.Rows[pos]["nombre_conexion"].ToString();
                frm.login = tablaConexiones.Rows[pos]["login"].ToString();
                if (tablaConexiones.Rows[pos]["password"].ToString().Trim() != string.Empty)
                    frm.password = objR.DesEncriptar(tablaConexiones.Rows[pos]["password"].ToString(), "CGSF");
                frm.servidor = tablaConexiones.Rows[pos]["servidor"].ToString();
                frm.baseDatos = tablaConexiones.Rows[pos]["base_datos"].ToString();
                frm.puerto = tablaConexiones.Rows[pos]["puerto"].ToString();
                frm.sid = tablaConexiones.Rows[pos]["sid"].ToString();
                frm.conexionDirecta = (tablaConexiones.Rows[pos]["conexion_directa"].ToString() == "1");
                #endregion

                switch (tablaConexiones.Rows[pos]["tipo_cnn_oracle"].ToString())
                {
                    case "normal": { frm._tipoCnnOracle =DataConector.tipoCnnOracle.normal; break; }
                    case "sysdba": { frm._tipoCnnOracle =DataConector.tipoCnnOracle.sysdba; break; }
                    case "sysoper": { frm._tipoCnnOracle =DataConector.tipoCnnOracle.sysoper; break; }
                }
                int t = 0;
                int.TryParse(tablaConexiones.Rows[pos]["time_out"].ToString(), out t);
                frm.time_out = t;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    #region zona de campos y propiedades

                    switch (frm.tipo)
                    {
                        case DataConector.tipoMotor.mysql:
                            { tablaConexiones.Rows[pos]["tipo_cnn"] = "MYSQL"; break; }

                        case DataConector.tipoMotor.oracle:
                            { tablaConexiones.Rows[pos]["tipo_cnn"] = "ORACLE"; break; }

                        case DataConector.tipoMotor.postgress:
                            { tablaConexiones.Rows[pos]["tipo_cnn"] = "POSTGRESS"; break; }

                        case DataConector.tipoMotor.SQLserver:
                            { tablaConexiones.Rows[pos]["tipo_cnn"] = "SQLSERVER"; break; }
                    }

                    tablaConexiones.Rows[pos]["nombre_conexion"] = frm.nombreConexion;
                    tablaConexiones.Rows[pos]["login"] = frm.login;

                    if (frm.password == null || frm.password.Trim() == string.Empty)
                        tablaConexiones.Rows[pos]["password"] = "";
                    else
                        tablaConexiones.Rows[pos]["password"] = objR.Encriptar(frm.password, "CGSF");

                    tablaConexiones.Rows[pos]["servidor"] = frm.servidor;
                    tablaConexiones.Rows[pos]["base_datos"] = frm.baseDatos;
                    tablaConexiones.Rows[pos]["puerto"] = frm.puerto;
                    tablaConexiones.Rows[pos]["sid"] = frm.sid;
                    tablaConexiones.Rows[pos]["conexion_directa"] = frm.conexionDirecta ? "1" : "0";

                    switch (frm._tipoCnnOracle)
                    {
                        case DataConector.tipoCnnOracle.normal: { tablaConexiones.Rows[pos]["tipo_cnn_oracle"] = "normal"; break; }
                        case DataConector.tipoCnnOracle.sysdba: { tablaConexiones.Rows[pos]["tipo_cnn_oracle"] = "sysdba"; break; }
                        case DataConector.tipoCnnOracle.sysoper: { tablaConexiones.Rows[pos]["tipo_cnn_oracle"] = "sysoper"; break; }
                    }
                    tablaConexiones.Rows[pos]["time_out"] = frm.time_out.ToString();
                    #endregion
                }
            
        }
        
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {            
            Cryptografia.CryptoRijndael objR = new Cryptografia.CryptoRijndael();
            frm.cnn.frmTipoConexxion frm = new frm.cnn.frmTipoConexxion();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                System.Data.DataRow fila = tablaConexiones.NewRow();
                #region zona de campos y propiedades
                fila["tipo_cnn"] = frm.tipo;
                fila["nombre_conexion"] = frm.nombreConexion;
                fila["login"] = frm.login;
                if (frm.password == null || frm.password.Trim() == string.Empty)
                    fila["password"] = "";
                else
                    fila["password"] = objR.Encriptar(frm.password, "CGSF");
                fila["servidor"] = frm.servidor;
                fila["base_datos"] = frm.baseDatos;
                fila["puerto"] = frm.puerto;
                fila["sid"] = frm.sid;
                fila["conexion_directa"] = frm.conexionDirecta;
                fila["tipo_cnn_oracle"] = frm._tipoCnnOracle;
                fila["time_out"] = frm.time_out;
        #endregion
                tablaConexiones.Rows.Add(fila);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns[0].Text.Trim() == string.Empty) return;

            if (MessageBox.Show("Esta seguro de eliminar esta cadena de conexion?","Confirmacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    tablaConexiones.Rows.Remove(

                        tablaConexiones.Select(" tipo_cnn='" + grdDatos.Columns[0].Text.Trim() + "' and " +
                        " nombre_conexion ='" + grdDatos.Columns[1].Text.Trim() + "' and " +
                        " login ='" + grdDatos.Columns[2].Text.Trim() + "' and " +
                        " servidor ='" + grdDatos.Columns[4].Text.Trim() + "' and " +
                        " base_datos ='" + grdDatos.Columns[5].Text.Trim() + "' ")[0]
                        );
                }catch(Exception ){
                }
            }
        }

        private void frmConfiguraCnn_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;
            /*
            SPX2019.ajustar objFormResizer = new SPX2019.ajustar();
            objFormResizer.ResizeForm(this, Height, Width);
            */
            cargarCnn();
        }
    }
}
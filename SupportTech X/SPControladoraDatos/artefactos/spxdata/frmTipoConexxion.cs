using SPControladoraDatos.artefactos;
using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPControladoraDatos.artefactos.SPX2019.artefactos.SPXdata.frm.cnn;

namespace SPX2019.artefactos.SPXdata.frm.cnn
{
    public partial class frmTipoConexxion : Form
    {
        public frmTipoConexxion()
        {
            InitializeComponent();
        }

        #region zona de campos y propiedades
        public DataConector.tipoMotor tipo { set; get; }
        public string nombreConexion { set; get; }
        public string login { set; get; }
        public string password { set; get; }
        public string servidor { set; get; }
        public string baseDatos { set; get; }
        public string puerto { set; get; }
        public string sid { set; get; }
        public bool conexionDirecta { set; get; }
        public DataConector.tipoCnnOracle _tipoCnnOracle { set; get; }
        public int time_out { set; get; }
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmTipoConexxion_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            ajustar objFormResizer = new ajustar();
            objFormResizer.ResizeForm(this, Height, Width);

            switch (tipo)
            {
                case DataConector.tipoMotor.mysql: { rdMysql.Checked = true; break; }
                case DataConector.tipoMotor.SQLserver: { rdSqlServer.Checked = true; break; }
                case DataConector.tipoMotor.oracle: { rdOracle.Checked = true; break; }
                case DataConector.tipoMotor.postgress: { rdPostgress.Checked = true; break; }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult d= DialogResult.Cancel;
            if(rdMysql.Checked)
            {
                frmConfigurarMysql fr = new frmConfigurarMysql();
                #region zona de campos y propiedades
        fr.tipo =DataConector.tipoMotor.mysql;
        fr.nombreConexion=nombreConexion;
        fr.login =login;
        fr.password =password;
        fr.servidor =servidor;
        fr.baseDatos =baseDatos;
        fr.puerto =puerto;
        fr.sid=sid;
        fr.conexionDirecta=conexionDirecta;
        fr._tipoCnnOracle =_tipoCnnOracle;
        fr.time_out = time_out;
        #endregion
                d = fr.ShowDialog();
                #region asignamos los valores localmente
                if (d == DialogResult.OK)
                {
                  tipo = fr.tipo;
                  nombreConexion  =fr.nombreConexion;
                  login  =fr.login  ;
                  password  =fr.password  ;
                  servidor  =fr.servidor  ;
                  baseDatos  =fr.baseDatos  ;
                  puerto  =fr.puerto  ;
                  sid  =fr.sid  ;
                  conexionDirecta  =fr.conexionDirecta  ;
                  _tipoCnnOracle  =fr._tipoCnnOracle  ;
                  time_out  =fr.time_out  ;
                }
                #endregion
            }else if (rdOracle.Checked)
            {
                frmConfigurarOracle fr = new frmConfigurarOracle();
                #region zona de campos y propiedades
                fr.tipo = DataConector.tipoMotor.oracle;
                fr.nombreConexion = nombreConexion;
                fr.login = login;
                fr.password = password;
                fr.servidor = servidor;
                fr.baseDatos = baseDatos;
                fr.puerto = puerto;
                fr.sid = sid;
                fr.conexionDirecta = conexionDirecta;
                fr._tipoCnnOracle = _tipoCnnOracle;
                fr.time_out = time_out;
                #endregion
                d = fr.ShowDialog();
                #region asignamos los valores localmente
                if (d == DialogResult.OK)
                {
                    tipo = fr.tipo;
                    nombreConexion = fr.nombreConexion;
                    login = fr.login;
                    password = fr.password;
                    servidor = fr.servidor;
                    baseDatos = fr.baseDatos;
                    puerto = fr.puerto;
                    sid = fr.sid;
                    conexionDirecta = fr.conexionDirecta;
                    _tipoCnnOracle = fr._tipoCnnOracle;
                    time_out = fr.time_out;
                }
                #endregion
            }else if (rdSqlServer.Checked){
                frm.editaCnn fr = new editaCnn();
                #region zona de campos y propiedades
                fr.tipo =DataConector.tipoMotor.SQLserver;
                fr.nombreConexion = nombreConexion;
                fr.login = login;
                fr.password = password;
                fr.servidor = servidor;
                fr.baseDatos = baseDatos;
                fr.puerto = puerto;
                fr.sid = sid;
                fr.conexionDirecta = conexionDirecta;
                fr._tipoCnnOracle = _tipoCnnOracle;
                fr.time_out = time_out;
                #endregion
                d = fr.ShowDialog();
                #region asignamos los valores localmente
                if (d == DialogResult.OK)
                {
                    tipo = fr.tipo;
                    nombreConexion = fr.nombreConexion;
                    login = fr.login;
                    password = fr.password;
                    servidor = fr.servidor;
                    baseDatos = fr.baseDatos;
                    puerto = fr.puerto;
                    sid = fr.sid;
                    conexionDirecta = fr.conexionDirecta;
                    _tipoCnnOracle = fr._tipoCnnOracle;
                    time_out = fr.time_out;
                }
                #endregion
            }else if (rdPostgress.Checked){
                frm.cnn.frmConfigurarPostgress fr = new frmConfigurarPostgress();
                #region zona de campos y propiedades
                fr.tipo =DataConector.tipoMotor.postgress;
                fr.nombreConexion = nombreConexion;
                fr.login = login;
                fr.password = password;
                fr.servidor = servidor;
                fr.baseDatos = baseDatos;
                fr.puerto = puerto;
                fr.sid = sid;
                fr.conexionDirecta = conexionDirecta;
                fr._tipoCnnOracle = _tipoCnnOracle;
                fr.time_out = time_out;
                #endregion
                d = fr.ShowDialog();
                #region asignamos los valores localmente
                if (d == DialogResult.OK)
                {
                    tipo = fr.tipo;
                    nombreConexion = fr.nombreConexion;
                    login = fr.login;
                    password = fr.password;
                    servidor = fr.servidor;
                    baseDatos = fr.baseDatos;
                    puerto = fr.puerto;
                    sid = fr.sid;
                    conexionDirecta = fr.conexionDirecta;
                    _tipoCnnOracle = fr._tipoCnnOracle;
                    time_out = fr.time_out;
                }
                #endregion
            }


            //guardamos la tabla
            if (d == DialogResult.OK)
            {
                //guardamos la tabla
                DialogResult = DialogResult.OK;
                Close();
            }else {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}

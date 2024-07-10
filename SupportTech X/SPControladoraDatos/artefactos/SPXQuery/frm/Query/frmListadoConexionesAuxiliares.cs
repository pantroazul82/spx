using SPControladoraDatos.artefactos;
using SPControladoraDatos.artefactos.SPXQuery.data;
using SPX2019.artefactos.SPXdata.frm.cnn;
using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Query
{
    public partial class frmListadoConexionesAuxiliares : Form
    {
        public frmListadoConexionesAuxiliares()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cryptografia.CryptoRijndael objR = new Cryptografia.CryptoRijndael();
            frmTipoConexxion frm = new frmTipoConexxion();
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                origen_datosTableAdapter1.Insert(verTipoCnn(frm.tipo),
                    frm.nombreConexion,
                    frm.login,
                    (frm.password == null || frm.password.Trim() == string.Empty) ? "" : objR.Encriptar(frm.password, "CGSF"),
                    frm.servidor,
                    frm.baseDatos,
                    (frm.puerto == null || frm.puerto.Trim() == string.Empty) ? 0 : int.Parse(frm.puerto),
                    frm.sid,frm.conexionDirecta ,
                     verTipoCnnoracle(frm._tipoCnnOracle), frm.time_out);
            
                origen_datosTableAdapter1.Fill(dsSPXQuery1.origen_datos);
            }
        }

        public string verTipoCnn(DataConector.tipoMotor tipo)
        {
            if (tipo ==DataConector.tipoMotor.mysql)
                return "mysql";
            if (tipo ==DataConector.tipoMotor.oracle)
                return "oracle";

            if (tipo ==DataConector.tipoMotor.postgress)
                return "postgress";

            if (tipo ==DataConector.tipoMotor.SQLserver)
                return "SQLserver";
            
            return "";
        }

        public DataConector.tipoMotor  verTipoCnn(string tipo)
        {
            if (tipo == "mysql")
                return DataConector.tipoMotor.mysql;
            if (tipo == "oracle")
                return DataConector.tipoMotor.oracle;

            if (tipo == "postgress")
                return DataConector.tipoMotor.postgress;

            if (tipo == "SQLserver")
                return DataConector.tipoMotor.SQLserver;

            return DataConector.tipoMotor.SQLserver;
        }

        public string verTipoCnnoracle(DataConector.tipoCnnOracle tipo ) {
            if (tipo ==DataConector.tipoCnnOracle.normal)
                return "normal";
            if (tipo ==DataConector.tipoCnnOracle.sysdba)
                return "sysdba";
            if (tipo ==DataConector.tipoCnnOracle.sysoper)
                return "sysoper";
            return "";
        }

        public DataConector.tipoCnnOracle  verTipoCnnoracle( string tipo)
        {
            if (tipo == "normal")
                return DataConector.tipoCnnOracle.normal;
            if (tipo == "sysdba")
                return DataConector.tipoCnnOracle.sysdba;
            if (tipo =="sysoper" )
                return DataConector.tipoCnnOracle.sysoper;
            return DataConector.tipoCnnOracle.normal;
        }
        data.origen_datosTableAdapter origen_datosTableAdapter1 = new data.origen_datosTableAdapter();
        private void frmListadoConexionesAuxiliares_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            ajustar objFormResizer = new ajustar();
            objFormResizer.ResizeForm(this, Height, Width);

            origen_datosTableAdapter1.Fill(dsSPXQuery1.origen_datos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_origen_datos"].Text.Trim() != string.Empty)
            {
                if (MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.confirmacionDelete,SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.tituloConfirmacionDelete,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        string sql = "update cgq_query set cod_origen_datos =null where cod_origen_datos=" + grdDatos.Columns["cod_origen_datos"].Text;
                       DataConector bd = new DataConector();
                        bd.ejecutarComando(sql);
                        origen_datosTableAdapter1.DeleteQuery(int.Parse(grdDatos.Columns["cod_origen_datos"].Text.Trim()));
                        origen_datosTableAdapter1.Fill(dsSPXQuery1.origen_datos);
                    }catch(Exception ex){
                        MessageBox.Show(SPControladoraDatos.artefactos.SPXUtilidades.Textos.Enunciados.errorDelete+ "\n "+ex.Message);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["cod_origen_datos"].Text.Trim() == string.Empty) return;
            Cryptografia.CryptoRijndael objR = new Cryptografia.CryptoRijndael();
            frmTipoConexxion frm = new frmTipoConexxion();
            dsSPXQuery.origen_datosDataTable tb = new dsSPXQuery.origen_datosDataTable();
            origen_datosTableAdapter1.FillBycod_origen_datos(tb, int.Parse(grdDatos.Columns["cod_origen_datos"].Text.Trim()));
            //
            frm.tipo=verTipoCnn(tb[0].tipo_cnn);
             frm.nombreConexion= tb[0].nombre_conexion;
             frm.login = tb[0].login;
             frm.password = objR.DesEncriptar(tb[0].password, "CGSF");
                    frm.servidor=tb[0].servidor;
                    frm.baseDatos=tb[0].base_datos;
                    frm.puerto=tb[0].puerto.ToString();
                    if (!tb[0].IssidNull())        
                        frm.sid=tb[0].sid;
                    
                    frm.conexionDirecta =tb[0].conexion_directa;
                    frm._tipoCnnOracle=verTipoCnnoracle(tb[0].tipo_cnn_oracle);
                    frm.time_out=tb[0].time_out;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                origen_datosTableAdapter1.UpdateQuery(verTipoCnn(frm.tipo),
                    frm.nombreConexion,
                    frm.login,
                    (frm.password == null || frm.password.Trim() == string.Empty) ? "" : objR.Encriptar(frm.password, "CGSF"),
                    frm.servidor,
                    frm.baseDatos,
                    (frm.puerto == null || frm.puerto.Trim() == string.Empty) ? 0 : int.Parse(frm.puerto),
                    frm.sid, frm.conexionDirecta,
                     verTipoCnnoracle(frm._tipoCnnOracle), frm.time_out,
                     int.Parse(grdDatos.Columns["cod_origen_datos"].Text.Trim()));

                origen_datosTableAdapter1.Fill(dsSPXQuery1.origen_datos);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel obj = new SPControladoraDatos.artefactos.SPXUtilidades.Misc.clsExportarExcel();
            obj.exportar(grdDatos, "Cnn", false);
        }
    }
}

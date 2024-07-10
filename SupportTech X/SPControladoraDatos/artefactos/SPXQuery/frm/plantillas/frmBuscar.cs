using SPXdata.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.plantillas
{
    public partial class frmBuscar : frm.plantillas.frmListado
    {
        public frmBuscar()
        {
            InitializeComponent();
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

        }



        /// <summary>
        /// Cargar los datos del combo para buscarlos
        /// </summary>
        /// <param name="sql">Sentencia</param>
        protected void cargarDatosCombo(string sentencia)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(sentencia);

            if (DataConector.Tipo ==DataConector.tipoMotor.mysql)
                sql.Append(" LIMIT 1 ");
            else if (DataConector.Tipo ==DataConector.tipoMotor.SQLserver)
            {
                string s = sql.ToString();
                int p = s.IndexOf("SELECT");
                s = s.Insert(p + 6, " TOP 1 ");
                sql.Remove(0, sql.ToString().Length);
                sql.Append(s);
            }

           DataConector obj = new DataConector();
            var camposCombo = obj.ejecutarConsulta(sql.ToString()).Tables[0];
            var campos = new List<string>();
            for (int i = 0; i < camposCombo.Columns.Count; i++)
            {
                campos.Add(camposCombo.Columns[i].Caption.ToString());
            }
            cmbCampo.DataSource = campos;
        }

        protected string buscar(string sql)
        {
            string s = sql;
            int pos = s.IndexOf("WHERE");
                s = s.Insert(pos + 5, " " + cmbCampo.SelectedItem.ToString().Trim() +
                    " LIKE '%" + txtValor.Text.TrimEnd() + "%' AND ");


                return cargarQuery(s);
        }

        protected string cargarQuery( string sql)
        {
            string s = sql;
            int pos = 0;
            if (DataConector.Tipo ==DataConector.tipoMotor.mysql)
            {
                s = s.Insert(s.Length, " LIMIT 100 ");
            }

            else if (DataConector.Tipo ==DataConector.tipoMotor.SQLserver)
            {
                pos = s.IndexOf("SELECT");
                s = s.Insert(pos + 6, " TOP 100 ");
            }
            return s;
        }
    }
}

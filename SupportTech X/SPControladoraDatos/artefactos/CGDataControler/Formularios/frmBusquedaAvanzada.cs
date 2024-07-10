using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CGDataControler.Formularios
{
    public enum tiposDatos 
    {
        fecha,texto,numerica,flotante    
    }

    public struct campos 
    {
        public tiposDatos tipoDatos;
        public string nombreCampo;
        public string etiquetaCampo;
    }
    
    
    public partial class frmBusquedaAvanzada : Form
    {
        public frmBusquedaAvanzada()
        {
            InitializeComponent();
            posiciones = new List<int>();
            posicionesVisibles = new List<int>();
            listaCampos = new List<campos>();
        }

        /// <summary>
        /// Filtro que se debe ejecutar en la base de datos
        /// </summary>
        public string Filtro { set { filtro = value; } get { return filtro; } }
        private string filtro = "";
        private string filtroVisible = "";
        List<int> posiciones;
        List<int> posicionesVisibles;
        List<campos> listaCampos;
        tiposDatos tipoDatosActivo= tiposDatos.texto;

        public void anexarCampos(string etiqueta,string nombreCampo,tiposDatos tipo) 
        {
            campos campo;
            campo.etiquetaCampo = etiqueta;
            campo.nombreCampo = nombreCampo;
            campo.tipoDatos = tipo;
            listaCampos.Add(campo);
            cmbCampos.Items.Add(etiqueta);
        }


     
        private void btnAbrirParentesis_Click(object sender, EventArgs e)
        {
            string conector = "";
            if (verificaConector())
            {
                conector = " OR ";
            }
            agregarCondicion(conector + " ( ", conector + " ( ");
        }
        private void btnParentesisObligatorio_Click(object sender, EventArgs e)
        {
            string conector = "";
            if (verificaConector())
            {
                conector = " AND ";
            }
            agregarCondicion(conector + " ( ", conector + " ( ");
        }
        private void btnCerrarParentesis_Click(object sender, EventArgs e)
        {
            agregarCondicion(" ) ", " ) ");
        }

        private bool verificarCondiciones() 
        {
            if (cmbCampos.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir un campo");
                cmbCampos.Focus();
                return false;
            }
            if (cmbOperacion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir una operacion");
                cmbOperacion.Focus();
                return false;
            }
            if ( tipoDatosActivo == tiposDatos.texto && txtValor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir un valor");
                txtValor.Focus();
                return false;
            }
            if (tipoDatosActivo == tiposDatos.flotante && txtValorDoble.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe elejir un valor");
                txtValorDoble.Focus();
                return false;
            }
          
            return true;
        }

        private void agregarCondicion(string condicion,string condicionVisible) 
        {
            filtro = filtro + condicion;
            filtroVisible = filtroVisible + condicionVisible;
            txtFiltro.Text = filtroVisible;
            posiciones.Add(filtro.Length);
            posicionesVisibles.Add(filtroVisible.Length);
        }

     
        private void btnAgregarOr_Click(object sender, EventArgs e)
        {
            if (!verificarCondiciones()) return;
            string conector = "";
            string fvisible = "",f="";
            if (verificaConector()) conector = " OR ";
            f=generarFiltro(out fvisible);
            agregarCondicion(conector + f, conector + fvisible);
        }

        private void btnAgregarAnd_Click(object sender, EventArgs e)
        {
            if (!verificarCondiciones()) return;
            string conector = "";
            string fvisible = "", f = "";
            if (verificaConector()) conector = " AND ";
            f = generarFiltro(out fvisible);
            agregarCondicion(conector + f, conector + fvisible);
        }

        private void btnEliminarAnterior_Click(object sender, EventArgs e)
        {
            if (posicionesVisibles.Count <= 0) return;
            if (posicionesVisibles.Count == 1)
            {
                filtro = string.Empty;
                filtroVisible = string.Empty;
            }else {
                filtro = filtro.Substring(0, posiciones[posiciones.Count - 2]);
                filtroVisible = filtroVisible.Substring(0, posicionesVisibles[posicionesVisibles.Count - 2]);
            }
            txtFiltro.Text = filtroVisible;
            
            posiciones.RemoveAt(posiciones.Count - 1);
            posicionesVisibles.RemoveAt(posicionesVisibles.Count-1);
        }
   
    
        private bool verificaConector() 
        {
            
            if (posiciones.Count == 0) return false;
            int inicio=0,fin=0;
            if(posiciones.Count==1)
            {
                inicio=0;fin=posiciones[0];
            }else{
                inicio=posiciones[posiciones.Count-2];
                fin=posiciones[posiciones.Count-1];
            }

            string ultimaSentencia = filtro.Substring(inicio,fin-inicio);
            if (ultimaSentencia.IndexOf("(") > -1 && ultimaSentencia.Length <9)
            {
                return false;
            }


            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validar()) return;          
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private bool validar() 
        {
            if (posiciones.Count == 0)
            {
                MessageBox.Show("Debe por lo menos ingresar un filtro");
                return false;
            }

            int abiertos = 0;
            int cerrados = 0;
            int condiciones=0;
            string sentenciaActiva = filtroVisible.Substring(0,posicionesVisibles[0]);
            int inicio=0,fin=0;

            for (int k = 0; k < posicionesVisibles.Count; k++)
            {
                if (k == 0)
                {
                     inicio=0;
                    fin=posicionesVisibles[0];
                }else {
                    inicio=posicionesVisibles[k-1];
                    fin=posicionesVisibles[k];
                }
                sentenciaActiva = filtroVisible.Substring(inicio , fin - inicio);

                if (sentenciaActiva == " ( " )
                {
                    abiertos++;
                    condiciones = 0;

                }
                else if (sentenciaActiva == " ) ")
                {
                    if (condiciones==0)
                    {
                        MessageBox.Show("Dentro de un parentesis abierto y uno cerrado debe existir una condicion.");
                        txtFiltro.SelectionStart = inicio;
                        txtFiltro.SelectionLength = fin - inicio;
                        return false;
                    }
                    cerrados++;
                }else{
                    condiciones++;
                }

                if (cerrados > abiertos)
                { 
                    MessageBox.Show("Se esta cerrando un parentesis que no fue abierto");
                    txtFiltro.SelectionStart = inicio;
                    txtFiltro.SelectionLength = fin - inicio;
                    return false;
                }

            }
            //despues de for
            if (cerrados != abiertos)
            {
                MessageBox.Show("Falta cerrar uno o mas parentesis");
                return false;
            }
            return true;
        }

        private void frmBusquedaAvanzada_Load(object sender, EventArgs e)
        {
            calValor.Location = new Point(txtValor.Location.X, txtValor.Location.Y);
            txtValorDoble.Location = new Point(txtValor.Location.X, txtValor.Location.Y);
            numValor.Location = new Point(txtValor.Location.X, txtValor.Location.Y);
        }

        

        private void cmbCampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int k = 0; k < listaCampos.Count; k++ )
            {
                if (listaCampos[k].etiquetaCampo == cmbCampos.Text)
                {
                    tipoDatosActivo = listaCampos[k].tipoDatos;
                    break;
                }
            }
            calValor.Visible = false;
            txtValor.Visible = false;
            txtValorDoble.Visible = false;
            numValor.Visible = false;
            switch (tipoDatosActivo) 
            {
                case tiposDatos.fecha:
                    {
                        calValor.Visible = true;
                        break;
                    }
                case tiposDatos.flotante:
                    {
                        txtValorDoble.Visible = true;
                        break;
                    }
                case tiposDatos.numerica:
                    {
                        numValor.Visible = true;
                        break;
                    }
                case tiposDatos.texto:
                    {
                        txtValor.Visible = true;
                        break;
                    }
                default:
                    {
                        txtValor.Visible = true;
                        break;
                    }            
            }
        }

        private void txtValorDoble_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= !( (int)e.KeyChar<25  || char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
        }
        
        private string generarFiltro(out string filtroVisible)
        {
            string nombreCampo="";
            string filtro = "";
            filtroVisible = "";
            filtroVisible = cmbCampos.Text.Trim() + " " + cmbOperacion.Text.Trim() + " ";
            
            for (int k = 0; k < listaCampos.Count; k++)
            {
                if (listaCampos[k].etiquetaCampo.Trim() == cmbCampos.Text.Trim())
                { 
                filtro = listaCampos[k].nombreCampo.Trim() + " " + cmbOperacion.Text.Trim() + " ";
                    nombreCampo=listaCampos[k].nombreCampo.Trim();
                }
            }
            
            switch (tipoDatosActivo)
            {
                case tiposDatos.fecha:
                    {
                        #region opciones de fecha
                        if (cmbOperacion.Text == "=")
                        {
                            filtro = " (" +
                            " datepart(dd," + nombreCampo + ") = " + calValor.Value.Day + " and datepart(mm," + nombreCampo + ") = " + calValor.Value.Month
                            + " and datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + ")";
                            filtroVisible = " (" + cmbCampos.Text.Trim() + " " + cmbOperacion.Text.Trim() + " " +
                                 " " + calValor.Value.ToLongDateString() + ") ";
                        }else if (cmbOperacion.Text == "!=")
                        {
                            filtro = " (" +
                            " datepart(dd," + nombreCampo + ") != " + calValor.Value.Day + " or datepart(mm," + nombreCampo + ") != " + calValor.Value.Month
                            + " or datepart(yy," + nombreCampo + ") != " + calValor.Value.Year.ToString() + ")";
                            filtroVisible = " (" + cmbCampos.Text.Trim() + " " + cmbOperacion.Text.Trim() + " " +
                                 " " + calValor.Value.ToLongDateString() + ") ";
                        }
                        else if (cmbOperacion.Text == "<")
                        {
                            filtro = "((datepart(yy," + nombreCampo + ") < " + calValor.Value.Year.ToString() + ") OR" +
                                     "((datepart(mm," + nombreCampo + ") < " + calValor.Value.Month.ToString() + ") AND "+
                                     "(datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + ")) OR " +
                                "( datepart(dd," + nombreCampo + ") < " + calValor.Value.Day + " and datepart(mm," + nombreCampo + ") = " + calValor.Value.Month
                                + " and datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + "))";
                                filtroVisible = " (" + cmbCampos.Text.Trim() + " " + cmbOperacion.Text.Trim() + " " +
                                     " " + calValor.Value.ToLongDateString() + ") ";
                        }else if (cmbOperacion.Text == ">"){
                            filtro = "((datepart(yy," + nombreCampo + ") > " + calValor.Value.Year.ToString() + ") OR" +
                                  "((datepart(mm," + nombreCampo + ") > " + calValor.Value.Month.ToString() + ") AND " +
                                  "(datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + ")) OR " +
                             "( datepart(dd," + nombreCampo + ") > " + calValor.Value.Day + " and datepart(mm," + nombreCampo + ") = " + calValor.Value.Month
                             + " and datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + "))";
                            filtroVisible = " (" + cmbCampos.Text.Trim() + " " + cmbOperacion.Text.Trim() + " " +
                                 " " + calValor.Value.ToLongDateString() + ") ";
                            }
                            else if (cmbOperacion.Text == "<=")
                            {
                                filtro = "((datepart(yy," + nombreCampo + ") < " + calValor.Value.Year.ToString() + ") OR" +
                                   "((datepart(mm," + nombreCampo + ") < " + calValor.Value.Month.ToString() + ") AND " +
                                   "(datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + ")) OR " +
                              "( datepart(dd," + nombreCampo + ") <= " + calValor.Value.Day + " and datepart(mm," + nombreCampo + ") = " + calValor.Value.Month
                              + " and datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + "))";
                                filtroVisible = " (" + cmbCampos.Text.Trim() + " " + cmbOperacion.Text.Trim() + " " +
                                     " " + calValor.Value.ToLongDateString() + ") ";
                            }
                            else if (cmbOperacion.Text == ">=")
                            {
                                filtro = "((datepart(yy," + nombreCampo + ") > " + calValor.Value.Year.ToString() + ") OR" +
                                       "((datepart(mm," + nombreCampo + ") > " + calValor.Value.Month.ToString() + ") AND " +
                                       "(datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + ")) OR " +
                                  "( datepart(dd," + nombreCampo + ") >= " + calValor.Value.Day + " and datepart(mm," + nombreCampo + ") = " + calValor.Value.Month
                                  + " and datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + "))";
                                filtroVisible = " (" + cmbCampos.Text.Trim() + " " + cmbOperacion.Text.Trim() + " " +
                                     " " + calValor.Value.ToLongDateString() + ") ";
                            }else{
                                filtro = " (" +
                      " datepart(dd," + nombreCampo + ") = " + calValor.Value.Day + " and datepart(mm," + nombreCampo + ") = " + calValor.Value.Month
                      + " and datepart(yy," + nombreCampo + ") = " + calValor.Value.Year.ToString() + ")";
                                filtroVisible = " (" + cmbCampos.Text.Trim() + " " + cmbOperacion.Text.Trim() + " " +
                                     " " + calValor.Value.ToLongDateString() + ") ";
                            }
#endregion
                        break;
                    }
                case tiposDatos.flotante:
                    {
                        filtro = filtro + txtValorDoble.Text + " ";
                        filtroVisible = filtroVisible + txtValorDoble.Text + " ";
                        break;
                    }
                case tiposDatos.numerica:
                    {
                        filtro = filtro + numValor.Value.ToString() + " ";
                        filtroVisible = filtroVisible + numValor.Value.ToString() + " ";
                        break;
                    }
                case tiposDatos.texto:
                    {
                        filtro = filtro + "'" + txtValor.Text.Trim() + "'" + " ";
                        filtroVisible = filtroVisible + txtValor.Text.Trim() + " ";
                        break;
                    }
            }
            return filtro;
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPXSeguridad.frm;

namespace SPXSeguridad.frm
{
    public partial class frmPermisos : Form
    {
        public frmPermisos()
        {
            InitializeComponent();
        }
        SPXSeguridad.data.cls.clsTfuncionalidad_grupousuario funcionalidad_grupousuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTfuncionalidad_grupousuario();
        SPXSeguridad.data.cls.clsTmoduloseguridad_usuario moduloseguridad_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTmoduloseguridad_usuario();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cargarTipo()
        {
            System.Data.DataRow fila = dataTable1.NewRow();
            fila[0] = 1;
            fila[1] = "Usuario";
            dataTable1.Rows.Add(fila);
            //--
            System.Data.DataRow fila2 = dataTable1.NewRow();
            fila2[0] = 2;
            fila2[1] = "Grupo de Usuario";
            dataTable1.Rows.Add(fila2);
        }

        bool eventosEncendidos = false;
        SPXSeguridad.data.cls.clsTpltVinculados pltVinculadosTableAdapter1 = new SPXSeguridad.data.cls.clsTpltVinculados();
        SPXSeguridad.data.cls.clsTfuncionalidad_usuario funcionalidad_usuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTfuncionalidad_usuario();
        SPXSeguridad.data.cls.clsTmoduloseguridad_grupousuario moduloseguridad_grupousuarioTableAdapter1 = new SPXSeguridad.data.cls.clsTmoduloseguridad_grupousuario();

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;

            int Height = screen.Bounds.Height;

            int Width = screen.Bounds.Width;

            SPControladoraDatos.artefactos.ajustar  objFormResizer = new SPControladoraDatos.artefactos.ajustar ();
            objFormResizer.ResizeForm(this, Height, Width);

            eventosEncendidos = false;
            cargarTipo();
            SPXSeguridad.logica.clsInicializador obj = new SPXSeguridad.logica.clsInicializador();
            obj.cargarTablaModulos();
            obj.cargarTablaFuncionalidades();
            obj.tablaModulos(dsSPXSeguridad1.modulo_seguridad);
            obj.tablaFuncionalidades(dsSPXSeguridad1.funcionalidad);
            eventosEncendidos = true;
            cargarInfo();
        }

        private void rdGruposModulos_CheckedChanged(object sender, EventArgs e)
        {
            cargarInfo();
            grdGrupoModulo.Visible = rdGruposModulos.Checked;
            grdModulos.Visible = rdVerModulos.Checked;
        }

        private void rdVerModulos_CheckedChanged(object sender, EventArgs e)
        {
            grdGrupoModulo.Visible = rdGruposModulos.Checked;
            grdModulos.Visible = rdVerModulos.Checked;
            
        }

        private void btnAgregaUsuario_Click(object sender, EventArgs e)
        {
            frmConfigPermisos fr = new frmConfigPermisos();
            if (rdVerModulos.Checked)
            {
                if (grdModulos.Columns[0].Text.Trim() == string.Empty) return;
                fr.cod_modulo = int.Parse( grdModulos.Columns[0].Text);
                fr.nombreModulo = grdModulos.Columns[1].Text;
            }
            if (rdGruposModulos.Checked)
            {
                if (grdGrupoModulo.Columns[0].Text.Trim() == string.Empty) return;
                fr.cod_grupo_modulo = int.Parse( grdGrupoModulo.Columns[0].Text);
                fr.nombreGrupoModulo = grdGrupoModulo.Columns[1].Text;
            }
            
            if (fr.ShowDialog() == DialogResult.OK)
            {
                cargarInfo();
            }
        }

        private void cargarInfo() 
        {
            if (!eventosEncendidos) return;
            if (rdVerModulos.Checked)
            {
                if (grdModulos.Columns[0].Text.Trim() == string.Empty) { dsSPXSeguridad1.pltVinculados.Clear(); return; }
                int cod_funcionalidad = int.Parse(grdModulos.Columns[0].Text);
                pltVinculadosTableAdapter1.FillBycod_funcionalidad(dsSPXSeguridad1.pltVinculados, cod_funcionalidad);
            }
            if (rdGruposModulos.Checked)
            {
                if (grdGrupoModulo.Columns[0].Text.Trim() == string.Empty) { dsSPXSeguridad1.Clear(); return; }
                int cod_grupo_modulo = int.Parse(grdGrupoModulo.Columns[0].Text);
                pltVinculadosTableAdapter1.FillBycod_grupo_modulo(dsSPXSeguridad1.pltVinculados,cod_grupo_modulo);
            }
            grdVinculados.Columns["tipo"].SortDirection = C1.Win.C1TrueDBGrid.SortDirEnum.Ascending;
            
            Application.DoEvents();
            cargarInfoSecundaria();
        }

        private void grdModulos_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            if (!eventosEncendidos) return;
            cargarInfo();
        }

        private void grdGrupoModulo_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            if (!eventosEncendidos) return;
            cargarInfo();
        }

        private void cargarInfoSecundaria()
        {
            if (!eventosEncendidos) return;
            if (grdVinculados.Columns[0].Text.Trim() == string.Empty)
            {
                chkControlTotal.Checked = false;
                chkDenegar.Checked = false;
                chkEliminar.Checked = false;
                chkEscribir.Checked = false;
                chkImprimir.Checked = false;
                chkLectEjec.Checked = false;
                chkModificar.Checked = false;
                return;
            }

            if (rdVerModulos.Checked)//funcionalidades
            {
                #region permisos x funcionalidad
                int cod_funcionalidad = int.Parse(grdModulos.Columns[0].Text);
                if (grdVinculados.Columns["tipo"].Value.ToString().Trim() == "1")//funciones x usuario
                {
                    funcionalidad_usuarioTableAdapter1.FillBycod_funcionalidadCodUsuario(dsSPXSeguridad1.funcionalidad_usuario,
                        int.Parse(grdVinculados.Columns["codigo"].Text),cod_funcionalidad );

                    if (dsSPXSeguridad1.funcionalidad_usuario.Count > 0)
                    {
                        chkControlTotal.Checked = (dsSPXSeguridad1.funcionalidad_usuario[0].Iscontrol_totalNull()) ? false : dsSPXSeguridad1.funcionalidad_usuario[0].control_total;
                        chkDenegar.Checked = (dsSPXSeguridad1.funcionalidad_usuario[0].IsdenegarNull()) ? false : dsSPXSeguridad1.funcionalidad_usuario[0].denegar;
                        chkEliminar.Checked = (dsSPXSeguridad1.funcionalidad_usuario[0].IseliminarNull()) ? false : dsSPXSeguridad1.funcionalidad_usuario[0].eliminar;
                        chkEscribir.Checked = (dsSPXSeguridad1.funcionalidad_usuario[0].IsescribirNull()) ? false : dsSPXSeguridad1.funcionalidad_usuario[0].escribir;
                        chkImprimir.Checked = (dsSPXSeguridad1.funcionalidad_usuario[0].IsimprimirNull()) ? false : dsSPXSeguridad1.funcionalidad_usuario[0].imprimir;
                        chkLectEjec.Checked = (dsSPXSeguridad1.funcionalidad_usuario[0].Islectura_ejecucionNull()) ? false : dsSPXSeguridad1.funcionalidad_usuario[0].lectura_ejecucion;
                        chkModificar.Checked = (dsSPXSeguridad1.funcionalidad_usuario[0].IsmodificarNull()) ? false : dsSPXSeguridad1.funcionalidad_usuario[0].modificar;
                    }
                    else
                    {
                        chkControlTotal.Checked = false;
                        chkDenegar.Checked = false;
                        chkEliminar.Checked = false;
                        chkEscribir.Checked = false;
                        chkImprimir.Checked = false;
                        chkLectEjec.Checked = false;
                        chkModificar.Checked = false;
                    }
                }else{ //funciones x grupos
                   funcionalidad_grupousuarioTableAdapter1.FillBycod_grupo_usuarioandcod_funcionalidad(dsSPXSeguridad1.funcionalidad_grupousuario,
                       cod_funcionalidad, int.Parse(grdVinculados.Columns["codigo"].Text));
                   if (dsSPXSeguridad1.funcionalidad_grupousuario.Count > 0)
                    {
                        chkControlTotal.Checked = (dsSPXSeguridad1.funcionalidad_grupousuario[0].Iscontrol_totalNull()) ? false : dsSPXSeguridad1.funcionalidad_grupousuario[0].control_total;
                        chkDenegar.Checked = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IsdenegarNull()) ? false : dsSPXSeguridad1.funcionalidad_grupousuario[0].denegar;
                        chkEliminar.Checked = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IseliminarNull()) ? false : dsSPXSeguridad1.funcionalidad_grupousuario[0].eliminar;
                        chkEscribir.Checked = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IsescribirNull()) ? false : dsSPXSeguridad1.funcionalidad_grupousuario[0].escribir;
                        chkImprimir.Checked = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IsimprimirNull()) ? false : dsSPXSeguridad1.funcionalidad_grupousuario[0].imprimir;
                        chkLectEjec.Checked = (dsSPXSeguridad1.funcionalidad_grupousuario[0].Islectura_ejecucionNull()) ? false : dsSPXSeguridad1.funcionalidad_grupousuario[0].lectura_ejecucion;
                        chkModificar.Checked = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IsmodificarNull()) ? false : dsSPXSeguridad1.funcionalidad_grupousuario[0].modificar;
                    }
                   else
                   {
                       chkControlTotal.Checked = false;
                       chkDenegar.Checked = false;
                       chkEliminar.Checked = false;
                       chkEscribir.Checked = false;
                       chkImprimir.Checked = false;
                       chkLectEjec.Checked = false;
                       chkModificar.Checked = false;
                   }
                }
#endregion
            }
            else
            {
                #region permisos x modulo
                int cod_grupo_modulo = int.Parse(grdGrupoModulo.Columns[0].Text);
                if (grdVinculados.Columns["tipo"].Value.ToString().Trim() == "1")//usuario
                {
                    moduloseguridad_usuarioTableAdapter1.FillByForaneas(dsSPXSeguridad1.moduloseguridad_usuario,
                         int.Parse(grdVinculados.Columns["codigo"].Text),cod_grupo_modulo);
                    if (dsSPXSeguridad1.moduloseguridad_usuario.Count > 0)
                    {
                        chkControlTotal.Checked = (dsSPXSeguridad1.moduloseguridad_usuario[0].Iscontrol_totalNull()) ? false : dsSPXSeguridad1.moduloseguridad_usuario[0].control_total;
                        chkDenegar.Checked = (dsSPXSeguridad1.moduloseguridad_usuario[0].IsdenegarNull()) ? false : dsSPXSeguridad1.moduloseguridad_usuario[0].denegar;
                        chkEliminar.Checked = (dsSPXSeguridad1.moduloseguridad_usuario[0].IseliminarNull()) ? false : dsSPXSeguridad1.moduloseguridad_usuario[0].eliminar;
                        chkEscribir.Checked = (dsSPXSeguridad1.moduloseguridad_usuario[0].IsescribirNull()) ? false : dsSPXSeguridad1.moduloseguridad_usuario[0].escribir;
                        chkImprimir.Checked = (dsSPXSeguridad1.moduloseguridad_usuario[0].IsimprimirNull()) ? false : dsSPXSeguridad1.moduloseguridad_usuario[0].imprimir;
                        chkLectEjec.Checked = (dsSPXSeguridad1.moduloseguridad_usuario[0].Islectura_ejecucionNull()) ? false : dsSPXSeguridad1.moduloseguridad_usuario[0].lectura_ejecucion;
                        chkModificar.Checked = (dsSPXSeguridad1.moduloseguridad_usuario[0].IsmodificarNull()) ? false : dsSPXSeguridad1.moduloseguridad_usuario[0].modificar;
                    }
                    else
                    {
                        chkControlTotal.Checked = false;
                        chkDenegar.Checked = false;
                        chkEliminar.Checked = false;
                        chkEscribir.Checked = false;
                        chkImprimir.Checked = false;
                        chkLectEjec.Checked = false;
                        chkModificar.Checked = false;
                    }
                }
                else
                {//grupo usuario
                    moduloseguridad_grupousuarioTableAdapter1.FillByForaneas(dsSPXSeguridad1.moduloseguridad_grupousuario,
                       cod_grupo_modulo, int.Parse(grdVinculados.Columns["codigo"].Text));
                    if (dsSPXSeguridad1.moduloseguridad_grupousuario.Count > 0)
                    {
                        chkControlTotal.Checked = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].Iscontrol_totalNull()) ? false : dsSPXSeguridad1.moduloseguridad_grupousuario[0].control_total;
                        chkDenegar.Checked = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IsdenegarNull()) ? false : dsSPXSeguridad1.moduloseguridad_grupousuario[0].denegar;
                        chkEliminar.Checked = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IseliminarNull()) ? false : dsSPXSeguridad1.moduloseguridad_grupousuario[0].eliminar;
                        chkEscribir.Checked = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IsescribirNull()) ? false : dsSPXSeguridad1.moduloseguridad_grupousuario[0].escribir;
                        chkImprimir.Checked = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IsimprimirNull()) ? false : dsSPXSeguridad1.moduloseguridad_grupousuario[0].imprimir;
                        chkLectEjec.Checked = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].Islectura_ejecucionNull()) ? false : dsSPXSeguridad1.moduloseguridad_grupousuario[0].lectura_ejecucion;
                        chkModificar.Checked = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IsmodificarNull()) ? false : dsSPXSeguridad1.moduloseguridad_grupousuario[0].modificar;
                    } else {
                        chkControlTotal.Checked = false;
                        chkDenegar.Checked = false;
                        chkEliminar.Checked = false;
                        chkEscribir.Checked = false;
                        chkImprimir.Checked = false;
                        chkLectEjec.Checked = false;
                        chkModificar.Checked = false;
                    }
                }
                #endregion
            }
        }



        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (!eventosEncendidos) return;
            if (grdVinculados.Columns["codigo"].Value.ToString().Trim() == string.Empty) return;

            if (rdVerModulos.Checked)
            {
                int cod_funcionalidad = int.Parse(grdModulos.Columns[0].Text);
                if (grdVinculados.SelectedRows.Count <= 0)
                {
                    if (grdVinculados.Columns["tipo"].Value.ToString().Trim() == "1")
                    {
                        
                       funcionalidad_usuarioTableAdapter1.UpdateByForaneas(chkControlTotal.Checked, chkModificar.Checked, chkLectEjec.Checked, chkEscribir.Checked,
                            chkEliminar.Checked, chkImprimir.Checked, chkDenegar.Checked, cod_funcionalidad, int.Parse(grdVinculados.Columns["codigo"].Value.ToString()));
                    }
                    else
                    {
                       funcionalidad_grupousuarioTableAdapter1.UpdateByForaneas(int.Parse(grdVinculados.Columns["codigo"].Value.ToString()),cod_funcionalidad,chkControlTotal.Checked, chkModificar.Checked, chkLectEjec.Checked, chkEscribir.Checked,
                      chkEliminar.Checked, chkImprimir.Checked, chkDenegar.Checked );
                    }
                }else{//esto es para actualizar multiple
                    for (int k = 0; k < grdVinculados.SelectedRows.Count; k++)
                    {
                        if (grdVinculados[grdVinculados.SelectedRows[k], "codigo"].ToString().Trim() == string.Empty) continue;
                        if (grdVinculados[grdVinculados.SelectedRows[k], "tipo"].ToString().Trim() == "1")
                        {
                            funcionalidad_usuarioTableAdapter1.UpdateByForaneas(chkControlTotal.Checked, chkModificar.Checked, chkLectEjec.Checked, chkEscribir.Checked,
                                chkEliminar.Checked, chkImprimir.Checked, chkDenegar.Checked, cod_funcionalidad, int.Parse(grdVinculados[grdVinculados.SelectedRows[k], "codigo"].ToString()));
                        }
                        else
                        {
                            funcionalidad_grupousuarioTableAdapter1.UpdateByForaneas(cod_funcionalidad, int.Parse(grdVinculados[grdVinculados.SelectedRows[k], "codigo"].ToString()),
                                chkControlTotal.Checked, chkModificar.Checked, chkLectEjec.Checked, chkEscribir.Checked,
                          chkEliminar.Checked, chkImprimir.Checked, chkDenegar.Checked );

                        }
                    }
                }
            }
            else
            {
                int cod_modulo = int.Parse(grdGrupoModulo.Columns[0].Text);
                if (grdVinculados.SelectedRows.Count <= 0)
                {
                    if (grdVinculados.Columns["tipo"].Value.ToString().Trim() == "1")
                    {
                      moduloseguridad_usuarioTableAdapter1.UpdateByForaneas(chkControlTotal.Checked, chkModificar.Checked, chkLectEjec.Checked, chkEscribir.Checked,
                            chkEliminar.Checked, chkImprimir.Checked, chkDenegar.Checked, cod_modulo, int.Parse(grdVinculados.Columns["codigo"].Value.ToString()));
                    }
                    else
                    {
                       moduloseguridad_grupousuarioTableAdapter1.UpdateQuery( int.Parse(grdVinculados.Columns["codigo"].Value.ToString()),cod_modulo,chkControlTotal.Checked, chkModificar.Checked, chkLectEjec.Checked, chkEscribir.Checked,
                      chkEliminar.Checked, chkImprimir.Checked, chkDenegar.Checked);
                    }
                }
                else
                {
                    for (int k = 0; k < grdVinculados.SelectedRows.Count; k++)
                    {
                        if (grdVinculados[grdVinculados.SelectedRows[k], "codigo"].ToString().Trim() == string.Empty) continue;
                        if (grdVinculados[grdVinculados.SelectedRows[k], "tipo"].ToString().Trim() == "1")
                        {
                            moduloseguridad_usuarioTableAdapter1.UpdateByForaneas(chkControlTotal.Checked, chkModificar.Checked, chkLectEjec.Checked, chkEscribir.Checked,
                                chkEliminar.Checked, chkImprimir.Checked, chkDenegar.Checked,cod_modulo, int.Parse(grdVinculados[grdVinculados.SelectedRows[k], "codigo"].ToString()));
                        }
                        else
                        {
                            moduloseguridad_grupousuarioTableAdapter1.UpdateQuery(int.Parse(grdVinculados[grdVinculados.SelectedRows[k], "codigo"].ToString()),cod_modulo,chkControlTotal.Checked, chkModificar.Checked, chkLectEjec.Checked, chkEscribir.Checked,
                          chkEliminar.Checked, chkImprimir.Checked, chkDenegar.Checked );
                        }
                    }
                }
            }

            System.Media.SystemSounds.Beep.Play();
        }

        private void grdVinculados_RowColChange(object sender, C1.Win.C1TrueDBGrid.RowColChangeEventArgs e)
        {
            if(grdVinculados.SelectedRows.Count<=1)
            cargarInfoSecundaria();
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            //generamos el grupo
            C1.C1Excel.C1XLBook libro = new C1.C1Excel.C1XLBook();
            libro.Sheets[0].Name = "Funcionalidades";
            libro.Sheets[0].Columns[0].Width = 6000;
            libro.Sheets[0].Columns[1].Width = 1700;
            libro.Sheets[0].Columns[2].Width = 1700;
            libro.Sheets[0].Columns[3].Width = 1700;
            libro.Sheets[0].Columns[4].Width = 1700;
            libro.Sheets[0].Columns[5].Width = 1700;
            libro.Sheets[0].Columns[6].Width = 1700;
            libro.Sheets[0].Columns[7].Width = 1700;
            libro.Sheets[0].Columns[8].Width = 1700;
            libro.Sheets[0].Columns[9].Width = 1700;

            libro.Sheets.Add("Modulos");
            libro.Sheets[1].Columns[0].Width = 6000;
            libro.Sheets[1].Columns[1].Width = 1700;
            libro.Sheets[1].Columns[2].Width = 1700;
            libro.Sheets[1].Columns[3].Width = 1700;
            libro.Sheets[1].Columns[4].Width = 1700;
            libro.Sheets[1].Columns[5].Width = 1700;
            libro.Sheets[1].Columns[6].Width = 1700;
            libro.Sheets[1].Columns[7].Width = 1700;
            libro.Sheets[1].Columns[8].Width = 1700;
            libro.Sheets[1].Columns[9].Width = 1700;
           // libro.Sheets.Add("Usuarios");
           // libro.Sheets.Add("Grupos de Usuarios");


            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel|*.xls";
            int linea = 0;
            if (sf.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            linea = 0;
            SPXSeguridad.data.cls.clsTusuario usuario = new SPXSeguridad.data.cls.clsTusuario();
            SPXSeguridad.data.cls.clsTgrupo_usuario grupo = new SPXSeguridad.data.cls.clsTgrupo_usuario();
            libro.Sheets[0][linea, 0].Value = "Funcionalidades";
            C1.C1Excel.XLStyle st=new C1.C1Excel.XLStyle(libro);
            Font f = new System.Drawing.Font("Arial", 13,FontStyle.Bold);            
            st.Font = f;
            st.BackColor = Color.LightBlue;           
            libro.Sheets[0][linea, 0].Style = st;
            linea++;
            for (int k = 0; k < dsSPXSeguridad1.funcionalidad.Count; k++)
            {
                libro.Sheets[0][linea, 0].Value = dsSPXSeguridad1.funcionalidad[k].nombre_funcionalidad;
                libro.Sheets[0][linea, 0].Style = st;
                linea++;
                funcionalidad_usuarioTableAdapter1.FillBycod_funcionalidad(dsSPXSeguridad1.funcionalidad_usuario, dsSPXSeguridad1.funcionalidad[k].cod_funcionalidad);
                for (int j = 0; j < dsSPXSeguridad1.funcionalidad_usuario.Count; j++)
                {
                    libro.Sheets[0][linea, 0].Value ="Usuario: "+ usuario.verNombre(dsSPXSeguridad1.funcionalidad_usuario[j].cod_usuario).Trim();
                    
                    libro.Sheets[0][linea, 1].Value = (dsSPXSeguridad1.funcionalidad_usuario[0].Iscontrol_totalNull()) ? "" : (dsSPXSeguridad1.funcionalidad_usuario[0].control_total ? "Control Total" : "");
                    libro.Sheets[0][linea, 2].Value = (dsSPXSeguridad1.funcionalidad_usuario[0].Islectura_ejecucionNull()) ? "" : (dsSPXSeguridad1.funcionalidad_usuario[0].lectura_ejecucion? "Lectura/Ejecucion" : "");
                    libro.Sheets[0][linea, 3].Value = (dsSPXSeguridad1.funcionalidad_usuario[0].IsmodificarNull()) ? "" : (dsSPXSeguridad1.funcionalidad_usuario[0].modificar ? "Modificar" : "");
                    libro.Sheets[0][linea, 4].Value = (dsSPXSeguridad1.funcionalidad_usuario[0].IsdenegarNull()) ? "" : (dsSPXSeguridad1.funcionalidad_usuario[0].denegar ? "Denegar" : "");
                    libro.Sheets[0][linea, 5].Value = (dsSPXSeguridad1.funcionalidad_usuario[0].IseliminarNull()) ? "" : (dsSPXSeguridad1.funcionalidad_usuario[0].eliminar? "Eliminar" : "");
                    libro.Sheets[0][linea, 6].Value = (dsSPXSeguridad1.funcionalidad_usuario[0].IsescribirNull()) ? "" : (dsSPXSeguridad1.funcionalidad_usuario[0].escribir ? "Escribir" : "");
                    libro.Sheets[0][linea, 7].Value = (dsSPXSeguridad1.funcionalidad_usuario[0].IsimprimirNull()) ? "" : (dsSPXSeguridad1.funcionalidad_usuario[0].imprimir? "Imprimir" : "");
                    linea++;
                }
                //--
                funcionalidad_grupousuarioTableAdapter1.FillBycod_funcionalidad(dsSPXSeguridad1.funcionalidad_grupousuario,dsSPXSeguridad1.funcionalidad[k].cod_funcionalidad);
                for (int j = 0; j < dsSPXSeguridad1.funcionalidad_grupousuario.Count; j++)
                {

                    grupo.fillById(dsSPXSeguridad1.grupo_usuario,dsSPXSeguridad1.funcionalidad_grupousuario[j].cod_grupo_usuario);
                    libro.Sheets[0][linea, 0].Value = "Grupo: "+(dsSPXSeguridad1.grupo_usuario[0].nombre_grupo_usuario.Trim());

                    libro.Sheets[0][linea, 1].Value = (dsSPXSeguridad1.funcionalidad_grupousuario[0].Iscontrol_totalNull()) ? "" : (dsSPXSeguridad1.funcionalidad_grupousuario[0].control_total ? "Control Total" : "");
                    libro.Sheets[0][linea, 2].Value = (dsSPXSeguridad1.funcionalidad_grupousuario[0].Islectura_ejecucionNull()) ? "" : (dsSPXSeguridad1.funcionalidad_grupousuario[0].lectura_ejecucion ? "Lectura/Ejecucion" : "");
                    libro.Sheets[0][linea, 3].Value = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IsmodificarNull()) ? "" : (dsSPXSeguridad1.funcionalidad_grupousuario[0].modificar ? "Modificar" : "");
                    libro.Sheets[0][linea, 4].Value = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IsdenegarNull()) ? "" : (dsSPXSeguridad1.funcionalidad_grupousuario[0].denegar ? "Denegar" : "");
                    libro.Sheets[0][linea, 5].Value = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IseliminarNull()) ? "" : (dsSPXSeguridad1.funcionalidad_grupousuario[0].eliminar ? "Eliminar" : "");
                    libro.Sheets[0][linea, 6].Value = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IsescribirNull()) ? "" : (dsSPXSeguridad1.funcionalidad_grupousuario[0].escribir ? "Escribir" : "");
                    libro.Sheets[0][linea, 7].Value = (dsSPXSeguridad1.funcionalidad_grupousuario[0].IsimprimirNull()) ? "" : (dsSPXSeguridad1.funcionalidad_grupousuario[0].imprimir ? "Imprimir" : "");
                    linea++;
                }
            }
            //

            linea = 0;
            for (int k = 0; k < dsSPXSeguridad1.modulo_seguridad.Count; k++)
            {
                libro.Sheets[1][linea, 0].Value = dsSPXSeguridad1.modulo_seguridad[k].nombre_modulo_seguridad;
                libro.Sheets[1][linea, 0].Style = st;
                linea++;
                moduloseguridad_usuarioTableAdapter1.FillBycod_moduloseguridad(dsSPXSeguridad1.moduloseguridad_usuario, dsSPXSeguridad1.modulo_seguridad[k].cod_modulo_seguridad);
                for (int j = 0; j < dsSPXSeguridad1.moduloseguridad_usuario.Count; j++)
                {
                    libro.Sheets[1][linea, 0].Value = "Usuario: "+usuario.verNombre(dsSPXSeguridad1.moduloseguridad_usuario[j].cod_usuario).Trim();

                    libro.Sheets[1][linea, 1].Value = (dsSPXSeguridad1.moduloseguridad_usuario[0].Iscontrol_totalNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_usuario[0].control_total ? "Control Total" : "");
                    libro.Sheets[1][linea, 2].Value = (dsSPXSeguridad1.moduloseguridad_usuario[0].Islectura_ejecucionNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_usuario[0].lectura_ejecucion ? "Lectura/Ejecucion" : "");
                    libro.Sheets[1][linea, 3].Value = (dsSPXSeguridad1.moduloseguridad_usuario[0].IsmodificarNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_usuario[0].modificar ? "Modificar" : "");
                    libro.Sheets[1][linea, 4].Value = (dsSPXSeguridad1.moduloseguridad_usuario[0].IsdenegarNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_usuario[0].denegar ? "Denegar" : "");
                    libro.Sheets[1][linea, 5].Value = (dsSPXSeguridad1.moduloseguridad_usuario[0].IseliminarNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_usuario[0].eliminar ? "Eliminar" : "");
                    libro.Sheets[1][linea, 6].Value = (dsSPXSeguridad1.moduloseguridad_usuario[0].IsescribirNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_usuario[0].escribir ? "Escribir" : "");
                    libro.Sheets[1][linea, 7].Value = (dsSPXSeguridad1.moduloseguridad_usuario[0].IsimprimirNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_usuario[0].imprimir ? "Imprimir" : "");
                    linea++;
                }
                //--
                moduloseguridad_grupousuarioTableAdapter1.FillBycod_moduloseguridad(dsSPXSeguridad1.moduloseguridad_grupousuario, dsSPXSeguridad1.modulo_seguridad[k].cod_modulo_seguridad);
                for (int j = 0; j < dsSPXSeguridad1.moduloseguridad_grupousuario.Count; j++)
                {

                    grupo.fillById(dsSPXSeguridad1.grupo_usuario, dsSPXSeguridad1.moduloseguridad_grupousuario[j].cod_grupo_usuario);
                    libro.Sheets[1][linea, 0].Value ="Grupo: "+ (dsSPXSeguridad1.grupo_usuario[0].nombre_grupo_usuario.Trim());

                    libro.Sheets[1][linea, 1].Value = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].Iscontrol_totalNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_grupousuario[0].control_total ? "Control Total" : "");
                    libro.Sheets[1][linea, 2].Value = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].Islectura_ejecucionNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_grupousuario[0].lectura_ejecucion ? "Lectura/Ejecucion" : "");
                    libro.Sheets[1][linea, 3].Value = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IsmodificarNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_grupousuario[0].modificar ? "Modificar" : "");
                    libro.Sheets[1][linea, 4].Value = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IsdenegarNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_grupousuario[0].denegar ? "Denegar" : "");
                    libro.Sheets[1][linea, 5].Value = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IseliminarNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_grupousuario[0].eliminar ? "Eliminar" : "");
                    libro.Sheets[1][linea, 6].Value = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IsescribirNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_grupousuario[0].escribir ? "Escribir" : "");
                    libro.Sheets[1][linea, 7].Value = (dsSPXSeguridad1.moduloseguridad_grupousuario[0].IsimprimirNull()) ? "" : (dsSPXSeguridad1.moduloseguridad_grupousuario[0].imprimir ? "Imprimir" : "");
                    linea++;
                }
            }
            //--
            
            libro.Save(sf.FileName);
            cargarInfoSecundaria();
        }
    }
}

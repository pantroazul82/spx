using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPControladoraDatos.artefactos;

namespace SPXSeguridad.logica
{
  
    public class linea {
        public static int cod_linea_seleccionada;
        public static string nombre_linea_seleccionada;
        public static System.Drawing.Image logotipo_linea_seleccionada;
    }
     
    class Modulo
    {
        public int codigoModulo{set;get;}
        public string nombreModulo{set;get;}

        public Modulo()
        {
        
        }
    }

    class Funcionalidad
    {
        public int codigoModulo { set; get; }
        public int codigoFuncionalidad { set; get; }
        public string nombreFuncionalidad { set; get; }

        public Funcionalidad()
        {

        }
    }

    public class clsInicializador
    {
        public static System.Web.HttpServerUtility serverWeb{set;get;} 
        
        List<Modulo> modulos=new List<Modulo>();
        List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

        public clsInicializador()
        {
        
        }

        /// <summary>
        /// agrega modulos del listado
        /// </summary>
        /// <param name="codigo">Codigo </param>
        /// <param name="NombreModulo">Nombre Modulo </param>
        /// <returns></returns>
        public bool agregarModulo(int codigo,string NombreModulo )
        {
            foreach (Modulo m in modulos)
            {
                if (m.codigoModulo == codigo)
                { 
                throw(new Exception("Modulo con codigo "+codigo+" ya fue ingresado previamente"));
                }
            }
            Modulo mod=new Modulo();
            mod.codigoModulo = codigo;
            mod.nombreModulo= NombreModulo;
            modulos.Add(mod);
            return true;
        }

        /// <summary>
        /// Agregamos funcionalidades al software.
        /// </summary>
        /// <param name="codigoModulo"></param>
        /// <param name="codigofuncionalidad"></param>
        /// <param name="NombreFuncionalidad"></param>
        /// <returns></returns>
        public bool agregarFuncionalidad(int codigoModulo, int codigofuncionalidad, string NombreFuncionalidad)
        {
            #region validamos modulo
            bool moduloActivo = false;
            foreach (Modulo m in modulos)
            {
                if (m.codigoModulo == codigoModulo)
                {
                    moduloActivo = true;
                }
            }
            if (!moduloActivo)
            {
                throw (new Exception("Esta intentando agregar una funcionalidad "+NombreFuncionalidad+" sin modulo valido!"));
            }
#endregion
            foreach (Funcionalidad f in funcionalidades)
            {
                if (f.codigoFuncionalidad == codigofuncionalidad)
                {
                    throw (new Exception("Esta intentando agregar una funcionalidad con codigo repetido: " + NombreFuncionalidad + "."));
                }
            }

            Funcionalidad fun = new Funcionalidad();
            fun.codigoModulo = codigoModulo;
            fun.codigoFuncionalidad = codigofuncionalidad;
            fun.nombreFuncionalidad = NombreFuncionalidad;
            funcionalidades.Add(fun);
            return true;
        }

        /// <summary>
        /// Quita un modulo del listado
        /// </summary>
        /// <param name="codigo">codigo manual</param>
        /// <returns></returns>
        public bool quitarModulo(int codigo)
        {
            foreach (Modulo m in modulos)
            {
                if (m.codigoModulo == codigo)
                {
                    modulos.Remove(m);
                    return true;
                }
            }
            return false;
        }

        public void guardarTablaModulos() 
        {
            SPXSeguridad.data.dsSPXSeguridad.modulo_seguridadDataTable tb = new SPXSeguridad.data.dsSPXSeguridad.modulo_seguridadDataTable();
            tablaModulos(tb);
            string ruta = "";
            if (serverWeb != null) {
                ruta = serverWeb.MapPath("~");
            }else{
             ruta=   System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            }
            if (!System.IO.Directory.Exists(ruta + @"\wcgsecurity"))
            {
                System.IO.Directory.CreateDirectory(ruta + @"\wcgsecurity");
            }
            tb.WriteXml(ruta + @"\wcgsecurity\mdl.xnt", System.Data.XmlWriteMode.WriteSchema);
        }

        public void guardarTablaFuncionalidades()
        {
            SPXSeguridad.data.dsSPXSeguridad.funcionalidadDataTable tb = new SPXSeguridad.data.dsSPXSeguridad.funcionalidadDataTable();
            tablaFuncionalidades(tb);
            string ruta = "";
            if (serverWeb != null)
            {
                ruta = serverWeb.MapPath("~");
            }
            else
            {
                ruta = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            } if (!System.IO.Directory.Exists(ruta + @"\wcgsecurity"))
            {
                System.IO.Directory.CreateDirectory(ruta + @"\wcgsecurity");
            }
            tb.WriteXml(ruta + @"\wcgsecurity\fncl.xnt",System.Data.XmlWriteMode.WriteSchema);
        }

        public void cargarTablaModulos( ) 
        {
            string ruta = "";
            if (serverWeb != null)
            {
                ruta = serverWeb.MapPath("~");
            }
            else
            {
                ruta = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            }
            System.Data.DataTable tbb = new System.Data.DataTable();
            if (!System.IO.File.Exists(ruta + @"\wcgsecurity\mdl.xnt")) return;
            tbb.ReadXml(ruta + @"\wcgsecurity\mdl.xnt");

            modulos.Clear();

            for (int k = 0; k < tbb.Rows.Count; k++)
            { 
                Modulo m=new Modulo();
                m.codigoModulo = int.Parse(tbb.Rows[k]["cod_modulo_seguridad"].ToString());
                m.nombreModulo = tbb.Rows[k]["nombre_modulo_seguridad"].ToString();
                modulos.Add(m);
            }
        }

        public void cargarTablaFuncionalidades( )
        {

            string ruta = "";
            if (serverWeb != null)
            {
                ruta = serverWeb.MapPath("~");
            }
            else
            {
                ruta = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            } 
            System.Data.DataTable tb = new System.Data.DataTable();
            if (!System.IO.File.Exists(ruta + @"\wcgsecurity\fncl.xnt")) return;
               tb.ReadXml(ruta + @"\wcgsecurity\fncl.xnt");

           
            funcionalidades.Clear();
            for (int k = 0; k < tb.Rows.Count; k++)
            {
                Funcionalidad m = new Funcionalidad();
                m.codigoFuncionalidad = int.Parse(tb.Rows[k]["cod_funcionalidad"].ToString());
                m.codigoModulo = int.Parse(tb.Rows[k]["cod_modulo_seguridad"].ToString());
                m.nombreFuncionalidad = tb.Rows[k]["nombre_funcionalidad"].ToString();
                funcionalidades.Add(m);
            }
        }

        public void cargarTablaFuncionalidadesEspecial()
        {
            if (funcionalidades != null && funcionalidades.Count > 0) return;
            string ruta = "";
            if (serverWeb != null)
            {
                ruta = serverWeb.MapPath("~");
            }
            else
            {
                ruta = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            }
            System.Data.DataTable tb = new System.Data.DataTable();
            if (!System.IO.File.Exists(ruta + @"\wcgsecurity\fncl.xnt")) return;
            tb.ReadXml(ruta + @"\wcgsecurity\fncl.xnt");


            funcionalidades.Clear();
            for (int k = 0; k < tb.Rows.Count; k++)
            {
                Funcionalidad m = new Funcionalidad();
                m.codigoFuncionalidad = int.Parse(tb.Rows[k]["cod_funcionalidad"].ToString());
                m.codigoModulo = int.Parse(tb.Rows[k]["cod_modulo_seguridad"].ToString());
                m.nombreFuncionalidad = tb.Rows[k]["nombre_funcionalidad"].ToString();
                funcionalidades.Add(m);
            }
        }

        public void tablaModulos(System.Data.DataTable tabla)
        {
            tabla.Rows.Clear();
            if (modulos == null || modulos.Count == 0) return;

         
            foreach (Modulo m in modulos)
            {
                System.Data.DataRow fila = tabla.NewRow();
                fila["cod_modulo_seguridad"] = m.codigoModulo;
                fila["nombre_modulo_seguridad"] = m.nombreModulo;
               tabla.Rows.Add(fila);
            }

        }

        public void tablaFuncionalidades(System.Data.DataTable tabla)
        {
            tabla.Rows.Clear();
            if (funcionalidades == null || funcionalidades.Count == 0) return;
            
            foreach (Funcionalidad m in funcionalidades)
            {
                System.Data.DataRow fila = tabla.NewRow();
                fila["cod_modulo_seguridad"] = m.codigoModulo;
                fila["cod_funcionalidad"] = m.codigoFuncionalidad;
                fila["nombre_funcionalidad"] = m.nombreFuncionalidad;
                tabla.Rows.Add(fila);
            }
        }

        public void tablaFuncionalidadesEspecial(System.Data.DataTable tabla)
        {
            if (tabla.Rows.Count > 0) return;
            tabla.Rows.Clear();
            if (funcionalidades == null || funcionalidades.Count == 0) return;

            foreach (Funcionalidad m in funcionalidades)
            {
                System.Data.DataRow fila = tabla.NewRow();
                fila["cod_modulo_seguridad"] = m.codigoModulo;
                fila["cod_funcionalidad"] = m.codigoFuncionalidad;
                fila["nombre_funcionalidad"] = m.nombreFuncionalidad;
                tabla.Rows.Add(fila);
            }
        }
    }
}

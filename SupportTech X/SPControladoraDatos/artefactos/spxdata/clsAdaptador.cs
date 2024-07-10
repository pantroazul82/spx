using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPXdata.BD
{
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.ComponentModel.DataObjectAttribute(true)]
    [global::System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" +
        ", Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")]
    public abstract class clsAdaptador : global::System.ComponentModel.Component
    {
        public System.Data.DataTable tablaMaestra { set; get; }
        public long ultimo_id_insertado = 0;

        private bool EsSentenciaBaseAsignada = false;
        private string sentenciaBaseAsignada = "";

        /// <summary>
        /// Retrona la sentencia base con los campos y el nombre de la tabla sin el WHERE, si la sentencia base es asignada en algun momento
        /// se retorna el valor asignado, si nunca es asignada se retorna un calculo de la informacion.
        /// </summary>
        public string sentenciaBase
        {
            set
            {
                if (value != null && value.Trim() != string.Empty)
                {
                    EsSentenciaBaseAsignada = true; sentenciaBaseAsignada = value;
                }
            }
            get {
                if (EsSentenciaBaseAsignada && sentenciaBaseAsignada != null && sentenciaBaseAsignada.Trim() != string.Empty)
                    return sentenciaBaseAsignada;
                else return "SELECT "+camposSelect+" FROM "+nombreTabla+" ";
            } 
        }

        /// <summary>
        /// Retrona la sentencia base con los campos y el nombre de la tabla sin el WHERE, si la sentencia base es asignada en algun momento
        /// se retorna el valor asignado, si nunca es asignada se retorna un calculo de la informacion.
        /// </summary>
        public string sentenciaBaseDistinct
        {
            set { EsSentenciaBaseAsignada = true; sentenciaBaseAsignada = value; }
            get
            {
                if (EsSentenciaBaseAsignada) return sentenciaBaseAsignada;
                else return "SELECT distinct " + camposSelect + " FROM " + nombreTabla;
            }
        }

        private string camposSelect { set; get; }
        /// <summary>
        /// Indica el nombre de la tabla de la base de datos.
        /// </summary>
        public string nombreTabla { set; get; }

        /// <summary>
        /// Nombre de llave foranea, a partir del 2009 se dejaron de utilizar llaves compuestas.
        /// </summary>
        public string nombreLlave { set; get; }
        
        public clsAdaptador() 
        {
            cargarCamposSelect();
        }

        /// <summary>
        /// Este campo debe cargar los campos estandar que van en el select de la tabla
        /// </summary>
        protected void cargarCamposSelect() 
        {
            camposSelect = "";
            if (tablaMaestra == null) return;

            for (int k = 0; k < tablaMaestra.Columns.Count; k++)
            {
                camposSelect += 
                    nombreTabla.Trim()+"."+ tablaMaestra.Columns[k].ColumnName.Trim() + ((k == tablaMaestra.Columns.Count-1) ? "" : ",");
            }
        }

        /// <summary>
        /// retorna la llave primaria del ultimo registro entregado
        /// </summary>
        /// <returns></returns>
        public long verIdentity()
        {//SELECT @@IDENTITY AS 'Identity'
            if (ultimo_id_insertado != 0) return ultimo_id_insertado;

            string sql = "SELECT @@IDENTITY AS 'Identity'";
           DataConector obj = new DataConector();
            object objRes=obj.ejecutarProcedimiento(sql,null,null);
            if(objRes != null && objRes != System.DBNull.Value)
            {
              return long.Parse(objRes.ToString());
            }
            return 0;
        }

        /// <summary>
        /// actualiza un registro especifico de la base de datos por llave primaria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int updateCampoById(int id,string nombreCampo,object valor)
        {
            //dependiendo el tipo del motor y del tipo, deberia remplazar el valor y las comillas.
            string v = "'"+valor.ToString()+"'";


            string sql = " update " + nombreTabla +" set "+nombreCampo+"= "+v+ " where " + nombreLlave + "=" + id;
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql);
        }

      
        /// <summary>
        /// Borra un registro especifico de la base de datos por llave primaria
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteQuery(int id)
        {
            string sql = " delete from " + nombreTabla + " where " + nombreLlave + "=" + id;
           DataConector obj = new DataConector();
            return obj.ejecutarComando(sql);
        }
        
        /// <summary>
        /// Llena un datatable con todos los registros de la base de datos
        /// </summary>
        /// <param name="ds"></param>
        public virtual void Fill(System.Data.DataTable dt)
        {
            string sql = "select " + camposSelect + " from "+nombreTabla+" ";
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql,dt);
        }

        /// <summary>
        /// Trae una tabla con un unico registro de la base de datos.
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="id"></param>
        public void fillById(System.Data.DataTable dt, int id)
        {
            string sql = "select " + camposSelect + " from " + nombreTabla +" where "+nombreLlave+"="+id;
           DataConector obj = new DataConector();
            obj.ejecutarConsulta(sql, dt);
        }
    }
}

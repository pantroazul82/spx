using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace SPControladoraDatos.artefactos.SPXUtilidades.Misc
{
    public class clsUtilidadesReflection
    {

        public clsUtilidadesReflection() { }

        List<string> listaAssemblies = new List<string>();
        public AssemblyName buscarAssembly(Assembly ensamblado, string nameSpace)
        {
            if (listaAssemblies.Contains(ensamblado.Location)) return null;
            listaAssemblies.Add(ensamblado.Location);
            if (ensamblado.Location.IndexOf(Environment.GetEnvironmentVariable("windir")) >= 0 ||
                ensamblado.Location.IndexOf(Environment.GetEnvironmentVariable("SystemRoot")) >= 0 ||
                ensamblado.Location.IndexOf("C1.W") >= 0
                
                
                )
                return null;
           
            AssemblyName[] objAssemArr = ensamblado.GetReferencedAssemblies();
            AssemblyName objAssem = null;
            if (nameSpace.ToUpper().IndexOf(ensamblado.GetName().Name.ToUpper()) >= 0)
            {
                objAssem = ensamblado.GetName();
                return objAssem;
            }
            for (int k = 0; k < objAssemArr.Length; k++)
            {
                if (objAssemArr[k].Name.StartsWith("System") || 
                    objAssemArr[k].Name == "mscorlib" || objAssemArr[k].Name.StartsWith("C1")
                     || objAssemArr[k].Name.StartsWith("DevComponent")
                    || objAssemArr[k].Name.StartsWith("MySql.Data")
                    || objAssemArr[k].Name.StartsWith("PresentationFramework")
                    || objAssemArr[k].Name.StartsWith("WindowsFormsIntegration")
                    || objAssemArr[k].Name.StartsWith("PresentationCore")
                    || objAssemArr[k].Name.StartsWith("DevExpress")
                    || objAssemArr[k].Name.StartsWith("ICSharpCode")

                    ) continue;
                var g = nameSpace.ToUpper().IndexOf(objAssemArr[k].Name.ToUpper());
                if (nameSpace.ToUpper().IndexOf(objAssemArr[k].Name.ToUpper()) >= 0)
                {
                    objAssem = objAssemArr[k];
                    return objAssem;
                }
                try{
                    Assembly assemblyConcreta = Assembly.Load(objAssemArr[k]);
                    objAssem=buscarAssembly(assemblyConcreta, nameSpace);
                    if (objAssem != null)
                    {
                        return objAssem;
                    }
                 }catch(Exception ){
                 }
            }
            return objAssem;
        }



        public AssemblyName buscarAssemblyEspecial(Assembly ensamblado, string nameSpace)
        {
            if (ensamblado.Location.IndexOf(Environment.GetEnvironmentVariable("windir")) >= 0 ||
                ensamblado.Location.IndexOf(Environment.GetEnvironmentVariable("SystemRoot")) >= 0 ||
                ensamblado.Location.IndexOf("C1.W") >= 0


                )
                return null;

            AssemblyName[] objAssemArr = ensamblado.GetReferencedAssemblies();
            AssemblyName objAssem = null;
            if (ensamblado.FullName.ToLower().StartsWith("spcontroladoradatos"))
                return ensamblado.GetName();

            if (nameSpace.ToUpper().IndexOf(ensamblado.GetName().Name.ToUpper()) >= 0)
            {
                objAssem = ensamblado.GetName();
                return objAssem;
            }
            for (int k = 0; k < objAssemArr.Length; k++)
            {
                if (objAssemArr[k].Name.StartsWith("System") || objAssemArr[k].Name == "mscorlib" || objAssemArr[k].Name.StartsWith("C1")
                     || objAssemArr[k].Name.StartsWith("DevComponent")
                    || objAssemArr[k].Name.StartsWith("MySql.Data")
                    || objAssemArr[k].Name.StartsWith("PresentationFramework")
                    || objAssemArr[k].Name.StartsWith("WindowsFormsIntegration")
                    || objAssemArr[k].Name.StartsWith("PresentationCore")
                    || objAssemArr[k].Name.StartsWith("DevExpress")
                    || objAssemArr[k].Name.StartsWith("ICSharpCode")

                    ) continue;

                if (objAssemArr[k].Name.ToLower().StartsWith("spcontroladoradatos"))
                {
                    objAssem = objAssemArr[k];
                    return objAssem;
                }
                
               
            }
            return objAssem;
        }

        public bool showFormulario(string nameSpaceFormulario, bool dialogo, object[] parametros, string[] nombreParametros)
        {
            object ob = null;
            return showFormulario(nameSpaceFormulario, dialogo,  parametros, nombreParametros,out ob);
        }


        public bool showFormulario(string nameSpaceFormulario, bool dialogo, object[] parametros, string[] nombreParametros, out object respuesta)
        {
            return showFormulario(nameSpaceFormulario, dialogo,  parametros,  nombreParametros, out respuesta,null,null,false,null);
        }

        /// <summary>
        /// Lanza un formulario que puede estar parametrizado desde una cadena de texto
        /// </summary>
        /// <param name="nameSpaceFormulario"></param>
        /// <param name="dialogo"></param>
        /// <param name="parametros"></param>
        /// <param name="nombreParametros"></param>
        /// <returns></returns>
        public bool showFormulario(string nameSpaceFormulario, bool dialogo,object[] parametros,string[] nombreParametros,out object respuesta,
            System.Windows.Forms.Form mdiParent,System.Drawing.Icon  icono,bool maximizar,object tag)
        {
            respuesta = "";
            if(nameSpaceFormulario== null || nameSpaceFormulario.Trim() == string.Empty)return false;
            
                Assembly theAssembly = Assembly.GetEntryAssembly();
                if (theAssembly == null) theAssembly = Assembly.GetExecutingAssembly();
                string nm = nameSpaceFormulario;
                //AssemblyName[] objAssemArro = theAssembly.GetReferencedAssemblies();
                listaAssemblies.Clear();
                AssemblyName objAssem = buscarAssembly(theAssembly, nameSpaceFormulario);

            if (objAssem == null) {
                // con el tema de los artefactos nos va retornar en null entonces buscamos la assembly spcontraladora datos
                objAssem = buscarAssemblyEspecial(theAssembly, nameSpaceFormulario);
            }
            if (objAssem == null)
            {
                return false;
            }

                Assembly assemblyConcreta = Assembly.Load(objAssem);
                Type myType = assemblyConcreta.GetType(nameSpaceFormulario.Trim());
            if(myType== null)
            {
                System.Windows.Forms.MessageBox.Show("El formulario "+
                   nameSpaceFormulario.Trim()+ " no parece estar referenciado o no existe. ","Error de Parametrizacion del Flujo!",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                return false;
            }
            System.Windows.Forms.Form myForm = assemblyConcreta.CreateInstance(myType.FullName) as System.Windows.Forms.Form;
          
                if (tag != null)
                {
                    myForm.Tag = tag;
                }
                if (icono != null)
                {
                    myForm.Icon = icono;
                }
                //cargamos las propiedades que toca
                 for (int k = 0;(nombreParametros != null && parametros != null)&&  k < nombreParametros.Length; k++)
                {
                    if (nombreParametros[k] == null) continue;
                    if (myType.GetProperty(nombreParametros[k].Trim()) != null)
                        {
                            object a = null;
                            if (parametros[k]!= null && myType.GetProperty(nombreParametros[k].Trim()).GetValue(myForm, null) != null)
                            {
                                a=Convert.ChangeType(parametros[k], myType.GetProperty(nombreParametros[k].Trim()).GetValue(myForm, null).GetType());
                            }
                            myType.GetProperty(nombreParametros[k].Trim()).SetValue(myForm, a, new object[] { });
                        }
                }

                 

                 if (mdiParent != null)
                 {
                     mdiParent.SuspendLayout();
                     myForm.MdiParent = mdiParent;
                 }
                 if (maximizar)
                 {
                     myForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                 }
            //--
                 if (dialogo)
                 {
                     if (myForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                     {
                         if (nombreParametros != null && nombreParametros.Length > 0)
                         {
                             if (nombreParametros[0] != null && myType.GetProperty(nombreParametros[0].Trim()) != null)
                                 respuesta = myType.GetProperty(nombreParametros[0].Trim()).GetValue(myForm, null);
                         }
                         return true;
                     }
                     else
                     {
                         return false;
                     }
                 }
                 else
                 {
                     for (int k = 0; mdiParent != null && k < mdiParent.MdiChildren.Length; k++)
                     {
                         if (dialogo && mdiParent.MdiChildren[k].WindowState != FormWindowState.Minimized)
                         {
                             mdiParent.MdiChildren[k].WindowState = FormWindowState.Minimized;
                         }
                         if (mdiParent.MdiChildren[k].Name != myForm.Name && mdiParent.MdiChildren[k].Name.ToUpper().IndexOf("KARDEX") >= 0)
                         {
                             mdiParent.MdiChildren[k].WindowState = FormWindowState.Minimized;
                         }
                     }
                     myForm.FormClosing += new FormClosingEventHandler(myForm_FormClosing);
                     myForm.Show();
                 }
                 if (mdiParent != null)
                 {
                     mdiParent.ResumeLayout();
                     myForm.MdiParent = mdiParent;
                 }
            return true;
            }

        void myForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form f = (Form)sender;
            if (f.Name.IndexOf("Query") > 0) return;
            if (f.MdiParent != null && f.MdiParent.MdiChildren.Length>0)
            {
                f.MdiParent.MdiChildren[0].Activate();
                f.MdiParent.MdiChildren[0].WindowState = FormWindowState.Maximized;
            }
        }


        /// <summary>
        /// invoca un metodo de una clase
        /// </summary>
        /// <param name="nameSpaceObjeto"></param>
        /// <param name="metodo"></param>
        /// <param name="parametros"></param>
        /// <param name="nombreParametros"></param>
        /// <param name="respuesta"></param>
        /// <returns></returns>
        public bool invocarMetodo(string nameSpaceObjeto,string metodo, object[] parametros, string[] nombreParametros, out object respuesta)
        {
            respuesta = "";
            if (nameSpaceObjeto.Trim() == string.Empty) return false;

            Assembly theAssembly = Assembly.GetEntryAssembly();
            string nm = nameSpaceObjeto;
            AssemblyName[] objAssemArr = theAssembly.GetReferencedAssemblies();
            listaAssemblies.Clear();
            AssemblyName objAssem = buscarAssembly(theAssembly, nameSpaceObjeto);

            if (objAssem == null) return false;

            Assembly assemblyConcreta = Assembly.Load(objAssem);
            Type myType = assemblyConcreta.GetType(nameSpaceObjeto);
            object myForm = assemblyConcreta.CreateInstance(myType.FullName);
            //cargamos las propiedades que toca

            myType.InvokeMember(metodo,BindingFlags.InvokeMethod, null, myForm, parametros);
            if (nombreParametros != null && nombreParametros.Length>0)
            {
                if (myType.GetProperty(nombreParametros[0].Trim()) != null)
                    respuesta = myType.GetProperty(nombreParametros[0].Trim()).GetValue(myForm, null);
            }
            return true;
        }



        public DateTime verUltimaModificacion()
        {


            Assembly theAssembly = Assembly.GetEntryAssembly();

            AssemblyName[] objAssemArr = theAssembly.GetReferencedAssemblies();
            listaAssemblies.Clear();
            buscarAssemblyFecha(theAssembly);


            return fechaMaxima;
        }

        DateTime fechaMaxima= DateTime.MinValue;

        public void buscarAssemblyFecha(Assembly ensamblado)
        {
           

            if (listaAssemblies.Contains(ensamblado.Location)) return;
            listaAssemblies.Add(ensamblado.Location);
            System.IO.FileInfo fi = new System.IO.FileInfo(ensamblado.Location);
            
            if (ensamblado.Location.IndexOf(Environment.GetEnvironmentVariable("windir")) >= 0 ||
                ensamblado.Location.IndexOf(Environment.GetEnvironmentVariable("SystemRoot")) >= 0 ||
                ensamblado.Location.IndexOf("C1.W") >= 0)
                return;

            if (fechaMaxima < fi.LastWriteTime)
            {
                fechaMaxima = fi.LastWriteTime;
            }

            AssemblyName[] objAssemArr = ensamblado.GetReferencedAssemblies();

            for (int k = 0; k < objAssemArr.Length; k++)
            {
               
                try
                {
                    Assembly assemblyConcreta = Assembly.Load(objAssemArr[k]);
                    buscarAssemblyFecha(assemblyConcreta);
                }
                catch (Exception)
                {
                }
            }
        }

    }
}

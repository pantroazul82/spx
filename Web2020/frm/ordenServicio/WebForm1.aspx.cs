using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.ordenServicio
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Nombre" + " " + txtNombre.Text +
                                               "CC" + " " + txtCC.Text +
                                               "Correo" + " " + txtCorreo.Text +
                                               "Base64IMG" + " " + output.Text);
            var imgBase64 = output.Text.Split(',');
            string otherpath = @"temp\imgOs" +  Session["ss_login"].ToString().Trim() + ".jpg";
            System.Diagnostics.Debug.WriteLine(imgBase64[1]);
            string strPath = Server.MapPath("~") + otherpath;
            System.Diagnostics.Debug.WriteLine(strPath);


            var bytes = Convert.FromBase64String(imgBase64[1]);
            using (var imageFile = new FileStream(strPath, FileMode.Create))
            {
                imageFile.Write(bytes, 0, bytes.Length);
                imageFile.Flush();
            }

        }
    }
}
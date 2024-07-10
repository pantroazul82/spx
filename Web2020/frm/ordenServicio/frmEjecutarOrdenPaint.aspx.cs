using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2020.frm.ordenServicio
{
    public partial class frmEjecutarOrdenPaint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            signature.Visible = true;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            signature.Visible = false;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {  // Check if the signature file is generated or not
            if (FirmaValida.Value != "true")
            {
                // show the newly generated signature image in sign area (optional)
                // ctlMySignature.ShowSignature();

                // get the path of generated signature file
                //string finalImg = ctlSignature1.SignatureFile;

                // Open the final generated signature in new window (optional)
                ///    Page.RegisterClientScriptBlock("openSigImg", "<script language='javascript'>window.open('" + finalImg + "');</script>");

                // You can use [[finalImg]] to email or save in database. 
                // That is subjective
            }

        }
    }
}
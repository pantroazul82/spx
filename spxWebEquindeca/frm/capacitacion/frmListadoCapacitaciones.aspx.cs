using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_capacitacion_frmListadoCapacitaciones : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnNuevo_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("frmCapacitacion.aspx");
    }

    public bool verLinkEditarParticipacion(object cod_capacitacion)
    {
        SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter objcapactiacion = new SPControladoraDatos.dsSpxTableAdapters.capacitacionTableAdapter();
        SPControladoraDatos.dsSpx ds = new SPControladoraDatos.dsSpx();
        SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter objEstado = new SPControladoraDatos.dsSpxTableAdapters.estado_capacitacionTableAdapter();
        SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter asistentes = new SPControladoraDatos.dsSpxTableAdapters.asistente_capacitacionTableAdapter();
        objcapactiacion.FillBycod_capacitacion(ds.capacitacion, int.Parse(cod_capacitacion.ToString()));
        if (ds.capacitacion.Count <= 0) return false;

        objEstado.FillByCod_estado_capacitacion(ds.estado_capacitacion, ds.capacitacion[0].cod_estado_capacitacion);
        if (ds.estado_capacitacion[0].orden != 2) return false;
        //solo continua si es estado 2 programada
        asistentes.FillByUsuarioCapacitacion(ds.asistente_capacitacion,
            int.Parse(cod_capacitacion.ToString()), int.Parse(Session["ss_cod_usuario"].ToString()));
        if (ds.asistente_capacitacion.Count > 0) return true;
        else return false;
    }
}
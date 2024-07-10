using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frm_consultas_frmConsultaInventarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            calIni.SelectedDate = DateTime.Now.AddDays(30);
            calFin.SelectedDate = DateTime.Now;
            cmbFiltros.SelectedIndex = 0;
        }
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        buscar();
    }
    private void buscar()
    {
        string sql = generarSql();
        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        RadGrid1.DataSource = bd.ejecutarConsulta(sql).Tables[0];
        RadGrid1.DataBind();


    }
    public string generarSql()
    {
        string sql = @"select  
  inventario.cod_inventario, item.nombre_item,item.cod_alterno 
,inventario.fecha_ingreso, usuario.nombre 'ingresado_por',seccion_bodega.nombre_seccion_bodega, 
bodega_logica.nombre_bodega_logica,bodega_fisica= nombre_bodega_fisica, estado_conservacion.nombre_estado_conservacion, 
estado_subproceso.nombre_estado_subproceso,estado_proceso_interno.nombre_estado_proceso_interno, 
cantidad,cod_reserva_inventario,serial,fecha_vencimiento,numero_lote, cliente.nombre_cliente,cliente.documento  
from inventario   
left join usuario on usuario.cod_usuario=inventario.ingresado_por  
left join seccion_bodega on seccion_bodega.cod_seccion_bodega=inventario.cod_seccion_bodega    
left join bodega_logica on bodega_logica.cod_bodega_logica=inventario.cod_bodega_logica 
left join bodega_fisica on bodega_logica.cod_bodega_fisica = bodega_fisica.cod_bodega_fisica  
left join estado_conservacion on estado_conservacion.cod_estado_conservacion=inventario.cod_estado_conservacion   
left join estado_subproceso on estado_subproceso.cod_estado_subproceso=inventario.cod_estado_subproceso  
left join estado_proceso_interno on estado_proceso_interno.cod_estado_proceso_interno=inventario.cod_estado_proceso_interno   
left join item on item.cod_item=inventario.cod_item  
left join cliente on cliente.cod_cliente = inventario.cod_cliente 
 ";
        string filtro = "";

        if (chkIngrsos.Checked && (calIni.SelectedDate.HasValue  && calFin.SelectedDate.HasValue))
        {
            filtro = " fecha_ingreso between " +
            "'" + calIni.SelectedDate.Value.Year.ToString() + "-" + calIni.SelectedDate.Value.Month.ToString().PadLeft(2, '0') + "-" + calIni.SelectedDate.Value.Day.ToString().PadLeft(2, '0') + "' and " +
            "'" + calFin.SelectedDate.Value.Year.ToString() + "-" + calFin.SelectedDate.Value.Month.ToString().PadLeft(2, '0') + "-" + calFin.SelectedDate.Value.Day.ToString().PadLeft(2, '0') + "' ";
        }

        if (txtFiltros.Text.Trim() != string.Empty)
        {
            if (cmbFiltros.Text.Trim() == "Serial")
            {
                if (filtro != string.Empty) filtro = filtro + " and ";

                filtro = filtro + " inventario.serial like '" + txtFiltros.Text + "%'";
            }
            else if (cmbFiltros.Text.Trim() == "Cliente")
            {
                if (filtro != string.Empty) filtro = filtro + " and ";

                filtro = filtro + " (cliente.nombre_cliente like '" + txtFiltros.Text + "%' or cliente.documento like '" + txtFiltros.Text + "%') ";
            }
            else if (cmbFiltros.Text.Trim() == "Bodega")
            {
                if (filtro != string.Empty) filtro = filtro + " and ";

                filtro = filtro + " bodega.nombre_bodega like '" + txtFiltros.Text + "%'";
            }
            else if (cmbFiltros.Text.Trim() == "Seccion Bodega")
            {
                if (filtro != string.Empty) filtro = filtro + " and ";

                filtro = filtro + " seccion_bodega.nombre_seccion_bodega like '" + txtFiltros.Text + "%'";
            }
            else if (cmbFiltros.Text.Trim() == "Item")
            {
                if (filtro != string.Empty) filtro = filtro + " and ";

                filtro = filtro + " item.nombre_item like '" + txtFiltros.Text + "%'";
            }




        }
        //agregamos los demas filtros
        if (filtro != string.Empty)
        {
            filtro = " where " + filtro;
        }
        return sql + filtro;
    }
}
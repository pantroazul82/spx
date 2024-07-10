using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controles_controlLlamadas : System.Web.UI.UserControl
{

    public event EventHandler agregarElementos;



    protected void btnAgregarRepuesto_Click(object sender, EventArgs e)
    {
        Panel1_ModalPopupExtender.Show();
        lblEventosEnncedidos.Text = "ok";
        textItemPopPup.ListaItems.Clear();
        //--
        runQuery();
        for (int k = 0; k < textItemPagina.ListaItems.Count; k++)
        {

            textItemPopPup.agregar(new ListItem(textItemPagina.ListaItems[k].Text, textItemPagina.ListaItems[k].Value));
           
        }
    
       
 
        SearchText1.Text = "";
        SearchText1.Focus();
    }


    public void runQuery(){
        string filtro = @"select 
asesoria_cientifica.cod_asesoria_cientifica,
estado_asesoria_cientifica.nombre_estado_asesoria_cientifica,
 prioridad_callcenter_cientifica.nombre_prioridad 'prioridad_sugerida',
 p2.nombre_prioridad 'prioridad'  
  ,asesoria_cientifica.fecha_solicitud, asesoria_cientifica.usuario_creacion,
   asesoria_cientifica.nitCliente,clientes.nombreCliente, asesoria_cientifica.codSucursal,
   sucursalCliente.nombreSucursal,ciudades.nombreCiudad
   ,referencia_reactivo.nombre_referencia_reactivo,fabricante.nombre_fabricante 'fabricante_reactivo',
     asesoria_cientifica.motivo_consulta, asesoria_cientifica.respuesta_inicial,	  
      asesoria_cientifica.responsable,
asesoria_cientifica.llamada_recibida_disponibilidad,
fecha_solicitud
 from asesoria_cientifica
left join inconveniente_presentado_cientifica on inconveniente_presentado_cientifica.cod_inconveniente_presentado_cientifica= asesoria_cientifica.cod_inconveniente_presentado_cientifica
INNER JOIN estado_asesoria_cientifica 
                      ON asesoria_cientifica.cod_estado_asesoria_cientifica = estado_asesoria_cientifica.cod_estado_asesoria_cientifica 
left JOIN prioridad_callcenter_cientifica
					 ON asesoria_cientifica.cod_prioridad_sugerida = prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica 
left JOIN prioridad_callcenter_cientifica p2
                     ON asesoria_cientifica.cod_prioridad_callcenter_cientifica = p2.cod_prioridad_callcenter_cientifica 
left JOIN          clientes ON asesoria_cientifica.nitCliente = clientes.nitCliente 
left JOIN  sucursalCliente ON asesoria_cientifica.nitCliente = sucursalCliente.nitCliente AND asesoria_cientifica.codSucursal = sucursalCliente.codSucursal 
left join motivo_anulacion_cientifica on motivo_anulacion_cientifica.cod_motivo_anulacion_cientifica = asesoria_cientifica.cod_motivo_anulacion_cientifica
left JOIN referencia_reactivo ON asesoria_cientifica.cod_referencia_reactivo = referencia_reactivo.cod_referencia_reactivo 
left JOIN fabricante ON referencia_reactivo.codFabricante = fabricante.codFabricante 
left JOIN fabricante AS fabricante_1 ON asesoria_cientifica.codFabricante = fabricante_1.codFabricante
left JOIN Modelos ON asesoria_cientifica.codFabricante = Modelos.codFabricante AND asesoria_cientifica.codModelo =Modelos.codModelo 
left join ciudades on sucursalCliente.codDepartamento = ciudades.codDepartamento and sucursalCliente.codPais = ciudades.codPais and ciudades.codCiudad= sucursalCliente.codCiudad
left join usuario on usuario.login = asesoria_cientifica.usuario_interna
where  (requiere_control_calidad is not null and requiere_control_calidad =1)
and estado_asesoria_cientifica.cod_manual =32";
        if (cmbOpcion.SelectedValue == "1" && SearchText1.Text != "%" && SearchText1.Text.Trim() != string.Empty)
        {//codigo de llamada
            int a=0;
            int.TryParse(SearchText1.Text,out a);
            filtro = filtro+" and asesoria_cientifica.cod_asesoria_cientifica="+a;
        }else if (cmbOpcion.SelectedValue == "2"){
            //reactivo
            filtro = filtro + " and referencia_reactivo.nombre_referencia_reactivo like '%"+SearchText1.Text+"%'" ;
        }
        else if (cmbOpcion.SelectedValue == "3"){
            //nit cliente
            filtro = filtro + " and  asesoria_cientifica.nitCliente like '%" + SearchText1.Text + "%'";
        }
        else if (cmbOpcion.SelectedValue == "4"){
            //nombre cliente
            filtro = filtro + " and clientes.nombreCliente like '%" + SearchText1.Text + "%'";
        }

        SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
        RadGrid1.DataSource= bd.ejecutarConsulta(filtro).Tables[0];
        RadGrid1.DataBind();
    }

    public bool ReadOnly {
        set
        {
            btnAgregarRepuesto.Visible = !value;
        }
    }
    public string nitCliente
    {
        set { lblNitCliente.Text = value; }
        get { return lblNitCliente.Text; }
    }

  
    

     public List<string> verCodigos()
    {
        List<string> lista = new List<string>();
        for (int k = 0; k < textItemPagina.ListaItems.Count; k++)
        {
            lista.Add(textItemPagina.ListaItems[k].Value);
        }
        return lista;
    }

    public List<string> verText()
    {
        List<string> lista = new List<string>();
        for (int k = 0; k < textItemPagina.ListaItems.Count; k++)
        {
            lista.Add(textItemPagina.ListaItems[k].Text);
        }
        return lista;
    }

    public void asignarCodigos(List<string> lista)
    {

        for (int k = 0; k < lista.Count; k++)
        {
            textItemPagina.agregar(new ListItem(lista[k], lista[k]));
        }
    }

    #region --- Class Methods ---

    protected void Page_Load(object pSender, EventArgs pEventArgs)
    {
      //  if (lblEventosEnncedidos.Text.Trim() == "") return;
       
        runQuery();
    }

    protected void btnBuscar_Click(object pSender, EventArgs pEventArgs)
    {
        if (lblEventosEnncedidos.Text.Trim() == "") return;
        runQuery();
    }

    #endregion

    

    protected void btnCancelar_Click(object sender, ImageClickEventArgs e)
    {
        lblEventosEnncedidos.Text = "";
        Panel1_ModalPopupExtender.Hide();
    }

    protected void btnOk_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        ImageButton b = (ImageButton)sender;
      
 
        textItemPopPup.agregarSingleton(new ListItem(b.ValidationGroup, b.ValidationGroup));
        textItemPagina.agregarSingleton(new ListItem(b.ValidationGroup, b.ValidationGroup));
        
        lblEventosEnncedidos.Text = "";
        if (textItemPagina.ListaItems.Count > 0 && agregarElementos != null)
        {
            agregarElementos(textItemPagina.ListaItems[0].Value, new EventArgs());
        }
        updatePanelTexto.Update();
        Panel1_ModalPopupExtender.Hide();
    }

  
    protected void btnBuscar_Click(object sender, ImageClickEventArgs e)
    {
        runQuery();
    }
 
}

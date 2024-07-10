<%@ Control Language="C#" AutoEventWireup="true" 
CodeFile="controlLlamadas.ascx.cs" Inherits="controles_controlLlamadas" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>
<%@ Register src="controlTxtItem.ascx" tagname="controlTxtItem" tagprefix="uc1" %>
<%@ Register src="textItem.ascx" tagname="textItem" tagprefix="uc2" %>
 
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
 
<link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <div style="width:30px;padding-left:2px; padding-right:auto;display:inline;margin-right:3px;" runat="server" id="pnlControlContenedor">
        <asp:Label ID="lblEventosEnncedidos" Text="" runat="server" Visible="false"></asp:Label>

        <asp:UpdatePanel ID="updatePanelTexto" runat="server" UpdateMode="Conditional" RenderMode="Inline">
        <ContentTemplate> 
        
        <asp:ImageButton Width="26px" CausesValidation="false" ImageUrl="~/img/Crystal_Clear_action_edit_add.png"
        ToolTip="Agregar Llamada" ID="btnAgregarRepuesto" runat="server" AlternateText="Agregar Llamada" 
        OnClick="btnAgregarRepuesto_Click" />
        <uc2:textItem ID="textItemPagina" runat="server" />   
        </ContentTemplate>
        </asp:UpdatePanel>
   <asp:Label style=" display:none" ID="lblInvicible" runat="server"  />   
    </div>    
        
    <asp:Panel style="display:none" ID="pnlEmergente" Enabled="true" runat="server"
     Height="560px" Width="770px" BackColor="LightGray">
    
    <div id="baraSuperior" style="cursor:move;  background-image: url('../img/web/fondoBarra.png') !important;
	background-repeat: repeat;	background-position: left top;	width:770px;	margin-top:0px;">
    <asp:ImageButton ImageUrl="../img/web/Cerrar.png" ID="btnCancelarPopUp" runat="server" 
      style="cursor:pointer; position:static; margin-left:751px;"  Width="26px" />
    </div>
    
    
    <asp:Panel  ID="pnlContenido" runat="server" BackColor="white" style="padding-left:20px;padding-top:5px;">
   

        <br />
    <asp:Panel id="pnlResultados" runat="server">    
    <div class="tab" id="titulo2">Ingrese el Codigo de la Llamada
    <asp:DropDownList runat="server" ID="cmbOpcion" >
        <asp:ListItem Text="Codigo de Llamada" Value="1"></asp:ListItem>
        <asp:ListItem Text="Reactivo" Value="2"></asp:ListItem>
        <asp:ListItem Text="Nit Cliente" Value="3"></asp:ListItem>
        <asp:ListItem Text="Nombre Cliente" Value="4"></asp:ListItem>
    </asp:DropDownList>
        
    <asp:TextBox runat="server" ID="SearchText1"></asp:TextBox>
  <asp:ImageButton ID="btnBuscar" runat="server" AlternateText="Buscar" 
        ImageUrl="~/img/web/Ico_BuscarDir.png" onclick="btnBuscar_Click"  CausesValidation="false"
        ToolTip="Buscar" Width="26px" />  
  
 </div>
<div class= "Formulario">  
   
    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" GridLines="None" AllowPaging="True" PageSize="8"><MasterTableView><CommandItemSettings ExportToPdfText="Export to PDF" /><RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                Visible="True"><HeaderStyle Width="20px" /></RowIndicatorColumn><ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                Visible="True"><HeaderStyle Width="20px" /></ExpandCollapseColumn><Columns><telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                    UniqueName="TemplateColumn"><ItemTemplate><asp:ImageButton ID="btnOk" Width="26px" runat="server" AlternateText="Ok" 
        ImageUrl="~/img/web/ok.gif" 
        ValidationGroup='<%# Eval("cod_asesoria_cientifica") %>'
        
        onclick="btnOk_Click" ToolTip="Agregar" /></ItemTemplate></telerik:GridTemplateColumn><telerik:GridBoundColumn DataField="cod_asesoria_cientifica" 
                    FilterControlAltText="Filter column2 column" HeaderText="Cod" 
                    UniqueName="column22"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="nombre_estado_asesoria_cientifica" 
                    FilterControlAltText="Filter column2 column" HeaderText="Estado" 
                    UniqueName="column2"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="prioridad" 
                    FilterControlAltText="Filter column column" HeaderText="Prioridad" 
                    UniqueName="column"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="fecha_solicitud" 
                    FilterControlAltText="Filter column1 column" HeaderText="Fecha solicitud" 
                    UniqueName="column1"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="nitclienteusuario_creacion" 
                    FilterControlAltText="Filter column3 column" HeaderText="usuario creacion" 
                    UniqueName="column3"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="nitCliente" 
                    FilterControlAltText="Filter column5 column" HeaderText="Nit Cliente" 
                    UniqueName="column5"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="nombreCliente" 
                    FilterControlAltText="Filter column6 column" HeaderText="Cliente" 
                    UniqueName="column6"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="nombre_referencia_reactivo" 
                    FilterControlAltText="Filter column6 column" HeaderText="Reactivo" 
                    UniqueName="column16"></telerik:GridBoundColumn></Columns><EditFormSettings><EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn></EditFormSettings></MasterTableView><FilterMenu EnableImageSprites="False"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></FilterMenu><HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></HeaderContextMenu></telerik:RadGrid>
    <br />
    


 </div>   
    <uc2:textItem ID="textItemPopPup" runat="server" />
    <br />
    
    <asp:ImageButton Height="30px" CausesValidation="false" ID="btnCancelar" runat="server" AlternateText="Cancelar" 
                        ImageUrl="../img/web/cancelar.png"
            ToolTip="Cancelar" onclick="btnCancelar_Click" />  
            
        <asp:Label ID="lblNitCliente" runat="server" Visible="False"></asp:Label>

            
    </asp:Panel>  

        </asp:Panel>
     
           
    </asp:Panel>       
 
     
   <div style="display:none">
    <cca:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server"
     PopupControlID="pnlEmergente" 
     Drag="true" PopupDragHandleControlID="baraSuperior"
             TargetControlID="lblInvicible"
             BackgroundCssClass="modalBackground"
             DropShadow="true"
             CancelControlID="btnCancelarPopUp" Enabled="true">
</cca:ModalPopupExtender>   


    </div>


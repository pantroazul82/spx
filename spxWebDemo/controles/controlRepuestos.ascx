<%@ Control Language="C#" AutoEventWireup="true" CodeFile="controlRepuestos.ascx.cs" Inherits="controles_controlRepuestos" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>
<%@ Register src="controlTxtItem.ascx" tagname="controlTxtItem" tagprefix="uc1" %>
<%@ Register src="textItem.ascx" tagname="textItem" tagprefix="uc2" %>
 
<link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <div style="width:30px;padding-left:2px; padding-right:auto;display:inline;margin-right:3px;" runat="server" id="pnlControlContenedor">
        <asp:Label ID="lblEventosEnncedidos" Text="" runat="server" Visible=false></asp:Label>
        <asp:UpdatePanel ID="updatePanelTexto" runat="server" UpdateMode="Conditional" RenderMode="Inline">
        <ContentTemplate> 
        
        <asp:ImageButton Width="26px" CausesValidation="false" ImageUrl="~/img/Crystal_Clear_action_edit_add.png"
        ToolTip="Agregar Repuesto" ID="btnAgregarRepuesto" runat="server" AlternateText="Agregar Repuesto" 
        OnClick="btnAgregarRepuesto_Click" />
        <uc2:textItem ID="textItemPagina" runat="server" />   
        </ContentTemplate>
        </asp:UpdatePanel>
   <asp:Label style=" display:none" ID="lblInvicible" runat="server"  />   
    </div>    
        
    <asp:Panel style="display:none" ID="pnlEmergente" Enabled="true" runat="server"
     Height="360px" Width="840px" BackColor="LightGray">
    
    <div id="baraSuperior" style="background-repeat: repeat;	background-position: left top;	width:840px;	margin-top:0px;">
    <asp:ImageButton ImageUrl="../img/web/Cerrar.png" ID="btnCancelarPopUp" runat="server" 
      style="cursor:pointer; position:static; margin-left:825px;"  Width="16px" />
    </div>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
    <ContentTemplate> 
        
    <asp:Panel  ID="pnlContenido" runat="server" BackColor="white" style="padding-left:20px;padding-top:5px;">
    <asp:Panel id="pnlResultados" runat="server">    
    <div class="tabx" id="titulo2">Seleccione Los Repuestos.
    <asp:Label runat="server" ID="SearchLabel1">     Buscar:</asp:Label>
    <asp:TextBox runat="server" ID="SearchText1"></asp:TextBox>
  <asp:ImageButton ID="btnBuscar" runat="server" AlternateText="Buscar" 
        ImageUrl="~/img/web/Ico_BuscarDir.png" onclick="btnBuscar_Click"  CausesValidation="false"
        ToolTip="Buscar" Width="26px" />  
 </div>
<div class= "Formulario">
<asp:GridView runat="server" AllowPaging="True" AutoGenerateColumns="False" 
ID="Browse1" AllowSorting="True" 
PageSize="6" DataSourceID="ObjectDataSource1" DataKeyNames="CodRepuesto" 
OnRowDataBound="Browse1_RowDataBound" OnSorting="Browse1_Sorting" 
OnPreRender="Browse1_PreRender" >
 
<PagerSettings FirstPageImageUrl="../img/web/PagerFirst.gif" 
LastPageImageUrl="../img/web/PagerLast.gif" Mode="NextPreviousFirstLast" 
NextPageImageUrl="../img/web/PagerNext.gif" 
Position="TopAndBottom" PreviousPageImageUrl="../img/web/PagerPrevious.gif">
</PagerSettings>
 
 
<Columns>

<asp:TemplateField>
 <ItemTemplate>
     <asp:ImageButton ID="btnOk" Width="26px" runat="server" AlternateText="Ok" 
        ImageUrl="~/img/web/ok.gif" 
        ValidationGroup='<%# Eval("CodRepuesto") %>'
        CommandName='<%# Eval("Descripcion")  %>'
        onclick="btnOk_Click" ToolTip="Agregar" />
 </ItemTemplate>
 </asp:TemplateField>
 

<asp:TemplateField HeaderText="Codigo Repuesto" SortExpression="CodRepuesto">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("CodRepuesto") %>' ID="CodRepuestoLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
<asp:TemplateField HeaderText="Repuesto" SortExpression="Descripcion">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("Descripcion") %>' ID="DescripcionLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
<asp:TemplateField Visible="false" HeaderText="precio" SortExpression="Precio">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("Precio") %>' ID="PrecioLabel1"
>
</asp:Label>
</ItemTemplate>
 
<FooterStyle HorizontalAlign="Right">
</FooterStyle>
 
<HeaderStyle HorizontalAlign="Right">
</HeaderStyle>
 
<ItemStyle HorizontalAlign="Right" Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
<asp:TemplateField HeaderText="Cantidad">

 
<ItemTemplate>
<asp:DropDownList runat="server" ID="cmbCantidad">
    <asp:ListItem Text="1" Value="1"></asp:ListItem>
    <asp:ListItem Text="2" Value="2"></asp:ListItem>
    <asp:ListItem Text="3" Value="3"></asp:ListItem>
    <asp:ListItem Text="4" Value="4"></asp:ListItem>
    <asp:ListItem Text="5" Value="5"></asp:ListItem>
    <asp:ListItem Text="6" Value="6"></asp:ListItem>
    <asp:ListItem Text="7" Value="7"></asp:ListItem>
    <asp:ListItem Text="8" Value="8"></asp:ListItem>
    <asp:ListItem Text="9" Value="9"></asp:ListItem>
    <asp:ListItem Text="10" Value="10"></asp:ListItem>
    <asp:ListItem Text="11" Value="11"></asp:ListItem>
    <asp:ListItem Text="12" Value="12"></asp:ListItem>
    <asp:ListItem Text="13" Value="13"></asp:ListItem>
    <asp:ListItem Text="14" Value="14"></asp:ListItem>
    <asp:ListItem Text="15" Value="15"></asp:ListItem>
    <asp:ListItem Text="16" Value="16"></asp:ListItem>
    <asp:ListItem Text="17" Value="17"></asp:ListItem>
    <asp:ListItem Text="18" Value="18"></asp:ListItem>
    <asp:ListItem Text="19" Value="19"></asp:ListItem>
    <asp:ListItem Text="20" Value="20"></asp:ListItem>
</asp:DropDownList>
</ItemTemplate>
 
<FooterStyle HorizontalAlign="Right">
</FooterStyle>
 
<HeaderStyle HorizontalAlign="Right">
</HeaderStyle>
 
<ItemStyle HorizontalAlign="Right" Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
</Columns>
 
<EmptyDataTemplate>
No se Econtraron coincidencias!!! 
</EmptyDataTemplate>
 
</asp:GridView>







 </div>   
    <uc2:textItem ID="textItemPopPup" runat="server" />
    <br />
<div class="panelResultados" style="width:800px">
            <asp:Label ID="lblEncontrados" runat="server"></asp:Label> registro(s) encontrado(s)
            <br /><br />
            Mostrando de <asp:Label ID="lbldesde" runat="server"></asp:Label> Hasta <asp:Label ID="lblHasta" runat="server"></asp:Label>
            </div>
    
    <asp:ImageButton Height="30px" ID="btnAceptar" runat="server" AlternateText="Aceptar" 
                        ImageUrl="~/img/web/aceptar.png"  CausesValidation="false"
            ToolTip="Aceptar" onclick="btnSeleccionarMarcados_Click" />
             
    <asp:ImageButton Height="30px" CausesValidation="false" ID="btnCancelar" runat="server" AlternateText="Cancelar" 
                        ImageUrl="../img/web/cancelar.png"
            ToolTip="Cancelar" onclick="btnCancelar_Click" />  
            
    </asp:Panel>     

        <br />
        </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>  
           
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

   <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" TypeName="BOLayer.RepuestoFactory" SelectCountMethod="Count" EnablePaging="True" UpdateMethod="Save" DeleteMethod="Delete" SortParameterName="pSortExpression" MaximumRowsParameterName="pMaxResult" StartRowIndexParameterName="pFirstResult" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pSortExpression"></asp:Parameter>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>
<DeleteParameters>
<asp:Parameter Name="codRepuesto"></asp:Parameter>
</DeleteParameters>

</asp:ObjectDataSource>

    </div>




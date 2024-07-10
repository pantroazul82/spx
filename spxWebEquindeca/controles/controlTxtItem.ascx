<%@ Control Language="C#" AutoEventWireup="true" CodeFile="controlTxtItem.ascx.cs" Inherits="controles_controlTxtItem" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
<ContentTemplate>
<div runat="server" id="divContainer" style="background-color:#E1EBF2;color:Navy; border-color:Navy;border-style:solid;border-width:1px;
width:30px;padding-left:2px; padding-right:auto;display:inline;margin-right:3px;">

<asp:Label ID="lblCodigo" runat="server" Visible="False"></asp:Label>
<asp:Label ID="lblTexto" runat="server"></asp:Label>
<asp:ImageButton ID="btnCerrar" runat="server" AlternateText="x" 
   Width="10px"  ImageUrl="~/img/web/cerrar.png" onclick="btnCerrar_Click" ToolTip="Quitar"/>


</div>
</ContentTemplate>
</asp:UpdatePanel>

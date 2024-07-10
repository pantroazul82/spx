<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmenviarAprobacion.aspx.cs" Inherits="frm_controlcalidad_frmenviarAprobacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br>
<br>
<br>
Seleccione el usuario encargado de aprobar la orden

<asp:DropDownList ID="cmbUsuarios" runat="server" AppendDataBoundItems="True" 
        DataSourceID="SqlDataSource1" DataTextField="nombre" 
        DataValueField="cod_usuario">
    <asp:ListItem Text="--Seleccione--" Value="" />   
</asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [nombre], [cod_usuario] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
<br />
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    <br />
<asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
        onclick="btnAceptar_Click" />
<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
        onclick="btnCancelar_Click" />


</asp:Content>


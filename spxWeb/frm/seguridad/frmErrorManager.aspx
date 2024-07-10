<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmErrorManager.aspx.cs" Inherits="frm_seguridad_frmErrorManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br />
    <asp:Label runat="server" ID="lblTitulo" Text="Se presento un problema en la aplicacion" Font-Bold="true" Font-Size="20px"></asp:Label>
    <asp:Label runat="server" ID="lblError" Font-Size="14px"></asp:Label>
</asp:Content>


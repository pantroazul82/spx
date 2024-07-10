<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmErrorManager.aspx.cs" Inherits="Web2020.frm.seguridad.frmErrorManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br />
    <asp:Label runat="server" ID="lblTitulo" Text="Se presento un problema en la aplicacion" Font-Bold="true" Font-Size="20px"></asp:Label>
    <asp:Label runat="server" ID="lblError" Font-Size="14px"></asp:Label>
</asp:Content>

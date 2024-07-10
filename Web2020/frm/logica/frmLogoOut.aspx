<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmLogoOut.aspx.cs" Inherits="Web2020.frm.logica.frmLogoOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-family: "Times New Roman", Times, serif;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<asp:Panel ID="Panel1" runat="server" Height="204px" style="text-align: center" 
    Width="836px">
    <br />
    <p>
        <span class="style1">Se cerro la sesion satisfactoriamente si desea entrar de 
        nuevo al sistema de click
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/frm/logica/frmLogin.aspx">Aqui</asp:HyperLink>
        </span>
    </p>
&nbsp;
</asp:Panel>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmImprimir.aspx.cs" Inherits="frm_impresion_frmImprimir" %>

<%@ Register assembly="C1.Web.Wijmo.Controls.4" namespace="C1.Web.Wijmo.Controls.C1ReportViewer" tagprefix="wijmo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br />
<div id="titulo" class="tab">
<asp:Label ID="lblTitulo" Text="titulo" runat="server"></asp:Label>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />

<asp:Button ID="btnImprimir" runat="server" Text="Imprimir" 
        onclick="btnImprimir_Click" Visible="False" />
&nbsp;<asp:TextBox ID="txtEmail" runat="server" Width="338px"></asp:TextBox>
    <asp:Button ID="btnEnviarEmail" runat="server" onclick="btnEnviarEmail_Click" 
        Text="Enviar Email" />
        <asp:Label runat="server" ID="lblError" ForeColor="Red"></asp:Label>
    <wijmo:C1ReportViewer ID="C1ReportViewer1" runat="server" Height="800px" Cache-Enabled="false" Cache-ShareBetweenSessions="false"
        Width="900px" CollapseToolsPanel="True" StatusBarVisible="False">
    </wijmo:C1ReportViewer>
</div>

</asp:Content>


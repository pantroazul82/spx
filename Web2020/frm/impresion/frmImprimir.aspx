<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmImprimir.aspx.cs" Inherits="Web2020.frm.impresion.frmImprimir" %>

<%@ Register Assembly="C1.Web.Wijmo.Controls.4" Namespace="C1.Web.Wijmo.Controls.C1ReportViewer" TagPrefix="wijmo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link href="../../assets/css/EjecutarOrden.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
    <h2 class="titulo">Enviar Orden</h2></div>
    <div class="screen-1">
        <div class="container">
            <div id="titulo" class="tab">
                <asp:Label ID="lblTitulo" CssClass="titulo h4 " Text="titulo" runat="server" Visible="False"></asp:Label>
                <asp:Label runat="server" CssClass="h5">Por favor ingrese el correo electrónico al cual quiere enviar el servicio</asp:Label>
            
                <div>
                    <div>
                        &nbsp;
                    </div>
                </div>
                <asp:Button ID="btnImprimir" runat="server" Text="Imprimir"
                    OnClick="btnImprimir_Click" Visible="False" />
                &nbsp;<asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
                <asp:Button ID="btnEnviarEmail" runat="server" OnClick="btnEnviarEmail_Click"
                    Text="Enviar Email" CssClass="btn btn-primary" />
                <asp:Label runat="server" ID="lblError" ForeColor="Red"></asp:Label>
                <wijmo:C1ReportViewer ID="C1ReportViewer1" runat="server" Height="800px" Cache-Enabled="false" Cache-ShareBetweenSessions="false"
                    Width="900px" CollapseToolsPanel="True" StatusBarVisible="False">
                </wijmo:C1ReportViewer>
            </div>
        </div>
    </div>

</asp:Content>

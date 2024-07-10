<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="fmListadoGraduados.aspx.cs" Inherits="frm_capacitacion_fmListadoGraduados" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
<br />    <table class="style1">
        <tr>
            <td colspan="2">
Seleccione el Equipo o el Reactivo y oprima el boton Buscar&nbsp;
            </td>
        </tr>
        <tr>
            <td>
                Modelo</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Reactivo</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <telerik:RadButton ID="btnBuscar" runat="server" Text="Buscar">
                </telerik:RadButton>
            </td>
        </tr>
    </table> <br />
<div class="tab">Listado de Especializados</div>
   

    <div class="formulario">
        <telerik:RadGrid ID="RadGrid1" runat="server">
        </telerik:RadGrid>
    </div>
</asp:Content>


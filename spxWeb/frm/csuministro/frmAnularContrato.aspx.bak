<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmAnularContrato.aspx.cs" Inherits="frm_csuministro_frmAnularContrato" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 112px;
        }
        .auto-style1
        {
            width: 246px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<div class="tab">Anular contratos de suministro!!!</div>
<div class="formulario">
<table style="width: 491px">
<tr>
<td class="auto-style1"></td>
<td>
    <asp:Label ID="lblCodTipo" runat="server" Visible="False"></asp:Label>
    </td>
</tr>
<tr>
<td class="auto-style1">Anulado Por</td>
<td>
    <asp:DropDownList ID="cmbAnuladoPor" runat="server" DataSourceID="SqlDataSource2" DataTextField="nombre" DataValueField="cod_usuario" Enabled="False">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]"></asp:SqlDataSource>
    </td>
</tr>
<tr>
<td class="auto-style1">Fecha Anulacion</td>
<td>
    <dx:ASPxDateEdit ID="calFechaAnulacion" runat="server" Enabled="False">
    </dx:ASPxDateEdit>
    </td>
</tr>
<tr>
<td class="auto-style1">Motivo de Anulacion</td>
<td>
    <asp:DropDownList ID="cmbMotivoAnulacion" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre_motivo_anulacion_suministro" DataValueField="cod_motivo_anulacion_suministro">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_motivo_anulacion_suministro], [nombre_motivo_anulacion_suministro] FROM [motivo_anulacion_suministro] ORDER BY [nombre_motivo_anulacion_suministro]"></asp:SqlDataSource>
    </td>
</tr>
<tr>
<td class="auto-style1">Observaciones Anulacion</td>
<td>
    <asp:TextBox ID="txtObservaciones" runat="server" Height="100px" MaxLength="5000" style="margin-left: 0px" TextMode="MultiLine" Width="400px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="auto-style1">&nbsp;</td>
<td>
    &nbsp;</td>
</tr>
<tr>
<td class="auto-style1">&nbsp;</td>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>
<tr>
<td class="auto-style1">&nbsp;</td>
<td>
    <telerik:RadButton ID="btnAceptar" runat="server" 
        Text="Aceptar" OnClick="btnAceptar_Click">
    </telerik:RadButton>
    <telerik:RadButton ID="btnCancelar" runat="server" 
        Text="Cancelar" OnClick="btnCancelar_Click">
    </telerik:RadButton>
    </td>
</tr>
</table>

</div>

</asp:Content>
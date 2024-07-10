<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmNuevaOrden.aspx.cs" Inherits="Web2020.frm.ordenPrestamo.frmNuevaOrden" %>

<%@ Register src="../../controles/controlRepuestos.ascx" tagname="controlRepuestos" tagprefix="uc1" %>

<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 313px;
        }
        .style2
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<br />
<div class="tab">Solicitud de Repuestos</div>

<div class="Formulario">
<asp:Panel runat="server" ID="pnlInicio" Visible="true">
<table>
<tr>
<td colspan="4">
    <asp:Label ID="lblErrror" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>
<tr>
<td>Ingeniero Responsable</td>
<td>
    <asp:DropDownList ID="cmbIngenieroResponsable" runat="server">
    </asp:DropDownList>
    </td>
<td>Fecha de Creacion</td>
<td>
    <asp:Label ID="lblFechaCreacion" runat="server" Text="Label"></asp:Label>
    </td>
</tr>

<tr>
<td>Pais</td>
<td>
    <asp:DropDownList ID="cmbPais" runat="server" AutoPostBack="True" 
      DataTextField="nombrePais" DataValueField="codPais">
    </asp:DropDownList>
   
    </td>
<td colspan="2" rowspan="4">
    <uc1:controlRepuestos ID="controlRepuestos1" runat="server" />
    </td>
</tr>

<tr>
<td>Departamento</td>
<td>
    <asp:DropDownList ID="cmbDepartamento" runat="server" AutoPostBack="True" 
       DataTextField="NombreDepartamento" 
        DataValueField="codDepartamento">
    </asp:DropDownList>
    
    </td>
</tr>

<tr>
<td>Ciudad</td>
<td>
    <asp:DropDownList ID="cmbCiudad" runat="server" 
        DataTextField="nombreCiudad" DataValueField="codCiudad">
    </asp:DropDownList>

    </td>
</tr>

    <tr>
        <td>Serial</td>
        <td>
            <uc2:controlSerial ID="controlSerial1" runat="server" />
        </td>
    </tr>

<tr>
<td>Observaciones Serial</td>
<td colspan="3">
    <asp:TextBox ID="txtObservacionesSerial" runat="server" Height="50px" TextMode="MultiLine" Width="419px"></asp:TextBox>
    </td>
</tr>

    <tr>
        <td>Observaciones</td>
        <td colspan="3">
            <asp:TextBox ID="txtObsIniciales" runat="server" Height="49px" TextMode="MultiLine" Width="419px"></asp:TextBox>
        </td>
    </tr>

<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>

    <tr>
        <td>
            &nbsp;</td>
        <td colspan="3">
            <asp:ImageButton ID="btnAceptar" runat="server" ImageUrl="~/img/web/ok.gif" onclick="btnAceptar_Click" ToolTip="Aceptar" Width="30px" />
            <asp:ImageButton ID="btnCancelar" runat="server" ImageUrl="~/img/web/cancel.gif" onclick="btnCancelar_Click" ToolTip="Cancelar" Width="30px" />
        </td>
    </tr>

</table>
</asp:Panel>

<asp:Panel runat="server" ID="pnlResumen" Visible="false">
<table>
<tr>
<td colspan="4">
    <b>Resumen Orden de Prestamo</b></td>
</tr>
<tr>
<td>Codigo Orden Prestamo:</td>
<td class="style2">
    <asp:Label ID="lblCodOrden" runat="server" Text="Label"></asp:Label>
    </td>
<td>&nbsp;</td>
<td class="style1">
    &nbsp;</td>
</tr>

    <tr>
        <td>
            Ingeniero Responsable:</td>
        <td class="style2">
            <asp:Label ID="lblIngernieroResponsable" runat="server"></asp:Label>
        </td>
        <td>
            Creada Por:</td>
        <td class="style1">
            <asp:Label ID="lblCreadaPor" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Ciudad:</td>
        <td class="style2">
            <asp:Label ID="lblCiudad" runat="server"></asp:Label>
        </td>
        <td>
            Fecha de Creacion</td>
        <td class="style1">
            <asp:Label ID="lblFechaCreacion2" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Repuestos:</td>
        <td colspan="3">
            <asp:Label ID="lblRepuestos" runat="server"></asp:Label>
        </td>
    </tr>

<tr>
<td>Observaciones</td>
<td class="style2" colspan="3">
    <asp:Label ID="lblObservaciones" runat="server"></asp:Label>
    </td>
</tr>

    <tr>
        <td>
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style1">
            <asp:LinkButton ID="linkCrearOtra" runat="server" onclick="linkCrearOtra_Click">Crear Otra</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="linkImprimir" runat="server" onclick="linkImprimir_Click">Imprimir</asp:LinkButton>
        </td>
    </tr>

</table>
</asp:Panel>
</div>
</asp:Content>
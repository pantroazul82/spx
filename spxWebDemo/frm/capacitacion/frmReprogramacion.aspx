<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmReprogramacion.aspx.cs" Inherits="frm_capacitacion_frmReprogramacion" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">


.RadPicker
{
	vertical-align:middle;
}

.RadPicker
{
	vertical-align:middle;
}

.RadPicker
{
	vertical-align:middle;
}

.RadPicker .rcTable
{
	table-layout:auto;
}

.RadPicker .rcTable
{
	table-layout:auto;
}

.RadPicker .rcTable
{
	table-layout:auto;
}

.RadPicker .RadInput
{
	vertical-align:baseline;
}

.RadPicker .RadInput
{
	vertical-align:baseline;
}

.RadPicker .RadInput
{
	vertical-align:baseline;
}

.RadInput_Default
{
	font:12px "segoe ui",arial,sans-serif;
}

.RadInput
{
	vertical-align:middle;
}

.RadInput_Default
{
	font:12px "segoe ui",arial,sans-serif;
}

.RadInput
{
	vertical-align:middle;
}

.RadInput_Default
{
	font:12px "segoe ui",arial,sans-serif;
}

.RadInput
{
	vertical-align:middle;
}

.RadPicker_Default .rcCalPopup
{
	background-position:0 0;
}

.RadPicker_Default .rcCalPopup
{
	background-image:url('mvwres://Telerik.Web.UI, Version=2011.3.1115.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Calendar.sprite.gif');
}

.RadPicker .rcCalPopup
{
	display:block;
	overflow:hidden;
	width:22px;
	height:22px;
	background-color:transparent;
	background-repeat:no-repeat;
	text-indent:-2222px;
	text-align:center;
}

.RadPicker_Default .rcCalPopup
{
	background-position:0 0;
}

.RadPicker_Default .rcCalPopup
{
	background-image:url('mvwres://Telerik.Web.UI, Version=2011.3.1115.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Calendar.sprite.gif');
}

.RadPicker .rcCalPopup
{
	display:block;
	overflow:hidden;
	width:22px;
	height:22px;
	background-color:transparent;
	background-repeat:no-repeat;
	text-indent:-2222px;
	text-align:center;
}

.RadPicker_Default .rcCalPopup
{
	background-position:0 0;
}

.RadPicker_Default .rcCalPopup
{
	background-image:url('mvwres://Telerik.Web.UI, Version=2011.3.1115.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Calendar.sprite.gif');
}

.RadPicker .rcCalPopup
{
	display:block;
	overflow:hidden;
	width:22px;
	height:22px;
	background-color:transparent;
	background-repeat:no-repeat;
	text-indent:-2222px;
	text-align:center;
}

.RadPicker_Default .rcTimePopup
{
	background-position:0 -100px;
}

.RadPicker_Default .rcTimePopup
{
	background-image:url('mvwres://Telerik.Web.UI, Version=2011.3.1115.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Calendar.sprite.gif');
}

.RadPicker .rcTimePopup
{
	display:block;
	overflow:hidden;
	width:22px;
	height:22px;
	background-color:transparent;
	background-repeat:no-repeat;
	text-indent:-2222px;
	text-align:center;
}

.RadPicker_Default .rcTimePopup
{
	background-position:0 -100px;
}

.RadPicker_Default .rcTimePopup
{
	background-image:url('mvwres://Telerik.Web.UI, Version=2011.3.1115.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Calendar.sprite.gif');
}

.RadPicker .rcTimePopup
{
	display:block;
	overflow:hidden;
	width:22px;
	height:22px;
	background-color:transparent;
	background-repeat:no-repeat;
	text-indent:-2222px;
	text-align:center;
}

.RadPicker_Default .rcTimePopup
{
	background-position:0 -100px;
}

.RadPicker_Default .rcTimePopup
{
	background-image:url('mvwres://Telerik.Web.UI, Version=2011.3.1115.35, Culture=neutral, PublicKeyToken=121fae78165ba3d4/Telerik.Web.UI.Skins.Default.Calendar.sprite.gif');
}

.RadPicker .rcTimePopup
{
	display:block;
	overflow:hidden;
	width:22px;
	height:22px;
	background-color:transparent;
	background-repeat:no-repeat;
	text-indent:-2222px;
	text-align:center;
}

        .style1
        {
            width: 100%;
            border-style: none;
            border-color: inherit;
            border-width: 0;
            margin: 0;
            padding: 0;
        }
        .style2
        {
            width: 100%;
            vertical-align: middle;
        }
        .style3
        {
            position: relative;
            z-index: 2;
            text-decoration: none;
            margin: 0 2px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />

<div class="tab">Reprogramar Capacitacion</div>
<div class="Formulario">

<table>
<tr>
<td>Fecha de Inicio</td>
<td>
    <telerik:RadDateTimePicker ID="calClaseIni" Runat="server">
     <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
</tr>

<tr>
<td>Fecha de Fin</td>
<td>
    <telerik:RadDateTimePicker ID="calClaseFin" Runat="server">
     <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
</tr>

<tr>
<td>Observaciones reprogramacion</td>
<td>&nbsp;</td>
</tr>

<tr>
<td colspan="2">
    <asp:TextBox ID="txtObservacionesReprogramacion" runat="server" Height="51px" 
        TextMode="MultiLine" Width="455px"></asp:TextBox>
    </td>
</tr>

<tr>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td>&nbsp;</td>
</tr>

<tr>
<td>
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />
    <asp:Button ID="btnReprogramar" runat="server" Text="Reprogramar" OnClick="btnReprogramar_Click" />
    </td>
<td>
    <asp:HyperLink ID="linkConflicto" runat="server" Visible="False"></asp:HyperLink>
    </td>
</tr>

</table>

</div>
</asp:Content>


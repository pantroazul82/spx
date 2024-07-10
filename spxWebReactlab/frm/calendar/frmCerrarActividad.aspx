<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/masterCientifica.master" AutoEventWireup="true" CodeFile="frmCerrarActividad.aspx.cs" Inherits="frm_calendar_frmCerrarActividad" %>
<%@ Reference Control="~/controles/ctlSignature.ascx" %>
<%@ Register src="~/controles/ctlSignature.ascx" tagname="ctlSignature" tagprefix="uc" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<div class="tab">Cerrar Actividad <asp:Label runat="server" ID="lblCodActividad"></asp:Label></div>
<div class="Formulario">

<table>
<tr>
<td>&nbsp;</td>
<td colspan="2">
    Fecha de Inicio
    <telerik:RadDateTimePicker ID="calInicio" Runat="server">
    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    Fecha de Fin
    <telerik:RadDateTimePicker ID="calFin" Runat="server" Enabled="False">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
</tr>

<tr>
<td></td>
<td>
    Pendientes&nbsp;
    <asp:TextBox ID="txtPendiente" runat="server"></asp:TextBox>
    <telerik:RadButton ID="btnAgregarPendiente" runat="server" 
        onclick="btnAgregarPendiente_Click" Text="Agregar Pendiente">
    </telerik:RadButton>
    </td>
<td>&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td rowspan="2">
    <telerik:RadListBox ID="lstPendientes" runat="server" AllowDelete="True" 
        Width="305px">
<ButtonSettings TransferButtons="All"></ButtonSettings>

<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
    </telerik:RadListBox>
    <br />
    </td>
<td>&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:CheckBox ID="chkAdjuntarFirma" runat="server" Text="Adjuntar Firma" />
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>Observaciones Cierre</td>
<td>
    Contacto Cierre
    <asp:TextBox ID="txtContactoCierre" runat="server"></asp:TextBox>
    </td>
</tr>

<tr>
<td></td>
<td>
    <asp:TextBox ID="txtObservacionesAprobacion" runat="server" Height="129px" 
        TextMode="MultiLine" Width="443px"></asp:TextBox>
    </td>
<td rowspan="4">
 <uc:ctlSignature ID="ctlSignature1" runat="server" BackColor="White" 
                    PenColor="Black" PenWidth="1" SavePath="~/temp/"                     
                    SignatureCodePath="~/controles/" SignatureFileFormat="Gif" SignHeight="250" 
                    SignWidth="500"  NoSignMessage="No se encontro la Firma"
                     EnableViewState="True" />			
       
&nbsp;
&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    Solucionado
     <asp:RadioButton ID="rdSi" runat="server" GroupName="d" Text="Si" />
    <asp:RadioButton ID="rdNo" runat="server" GroupName="d" Text="No" />
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    Razon?</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:TextBox ID="txtRazon" runat="server" Height="129px" 
        TextMode="MultiLine" Width="443px"></asp:TextBox>
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
       
           <asp:Label runat="server" ID="lblErrorFirma" Text="" ForeColor="Red"></asp:Label>
       
    </td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td></td>
<td>
    <telerik:RadButton ID="btnCerrar" runat="server" onclick="btnCerrar_Click" 
        Text="Cerrar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar">
    </telerik:RadButton>
    </td>
<td>
<asp:Button ID="btnLimpiarFirma" runat="server" OnClientClick="ClearSignature();" Text="Limpiar Firma" Visible="true" />
             <asp:Panel runat="server" ID="pnlGuardar">
              <input type="button"  value="Guardar firma" onclick="SaveSignature();" />
              <label style="color:Red;" id="lblConfirmError"></label>
                 
              </asp:Panel>
              </td>
</tr>
</table>
</div>


</asp:Content>


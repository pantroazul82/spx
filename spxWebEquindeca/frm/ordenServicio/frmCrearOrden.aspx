<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCrearOrden.aspx.cs" Inherits="frm_ordenServicio_frmCrearOrden" %>

<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style2
        {
            width: 172px;
        }
        .style3
        {
            width: 144px;
        }
        .style4
        {
        }
        .style5
        {
            font-size: medium;
        }
        .style6
        {
            width: 237px;
        }
        .style7
        {
            width: 403px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">

    Creacion de Orden de servicio</div>
<div class="Formulario"> 
<asp:Panel runat="server" ID="PanelUno" Visible="true">
<table>
<tr>
<td class="style5"><strong>Serial</strong></td>
<td class="style7" style="font-size: large">
 <uc1:controlSerial ID="controlSerial2" runat="server" />
</td>
<td class="style6">&nbsp;</td>
</tr>
    <tr>
        <td>
            &nbsp;</td>
        <td class="style7">
            <asp:Label ID="lblErrorPAsoUno" runat="server" ForeColor="#CC0000"></asp:Label>
        </td>
        <td class="style6">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td class="style7">
            <asp:Button ID="btnPaso2" runat="server" onclick="btnPaso2_Click" 
                Text="Siguiente" />
        </td>
        <td class="style6">
            &nbsp;</td>
    </tr>
</table>
</asp:Panel>

<asp:Panel runat="server" ID="pnlDos" Visible="false">
<table>
<tr>
<td>&nbsp;</td>
<td>  
    &nbsp; &nbsp;<asp:Button ID="btnAtrasPaso" runat="server" Height="24px" 
        onclick="btnAtrasPaso_Click" Text="Atras" Width="76px" />
</td>
<td class="style4"> &nbsp;</td>
<td class="style3"> &nbsp;</td>
<td class="style2"> &nbsp;</td>
</tr>
<tr>
<td><strong>Serial</strong></td>
<td>  
    <asp:TextBox runat="server" id="txtSerial" ReadOnly="true"></asp:TextBox>
    &nbsp;
    <asp:HyperLink ID="lnkVerHojaVida" runat="server" Target="_blank">Ver Hoja de Vida</asp:HyperLink>
</td>
<td class="style4"> &nbsp;</td>
<td class="style3"> &nbsp;</td>
<td class="style2"> &nbsp;</td>
</tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:RadioButton ID="rdExterna" runat="server" AutoPostBack="True" 
                GroupName="int" oncheckedchanged="rdExterna_CheckedChanged" Text="Externa" />
            &nbsp;
            <asp:RadioButton ID="rdInterna" runat="server" AutoPostBack="True" 
                GroupName="int" oncheckedchanged="rdInterna_CheckedChanged" Text="Interna" />
            &nbsp;
            <asp:Label ID="lblEntrada" runat="server" Text="&lt;br&gt;Entrada" 
                Visible="False"></asp:Label>
            &nbsp;
            <asp:DropDownList ID="cmbEntradas" runat="server" Visible="False">
            </asp:DropDownList>
        </td>
        <td class="style4" colspan="3">
            Prioridad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="cmbPrioridad" runat="server" Width="300px">
            </asp:DropDownList>
        </td>
    </tr>
<tr>
<td>&nbsp;</td>
<td>  
    &nbsp;</td>
<td class="style4"> 
    &nbsp;</td>
<td class="style3"> &nbsp;</td>
<td class="style2"> 
    &nbsp;</td>
</tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:RadioButton ID="rdPorContratoNo" runat="server" AutoPostBack="True" 
                Checked="True" GroupName="porContrato" 
                oncheckedchanged="rdPorContratoNo_CheckedChanged" Text="Fuera de Contrato" />
            <asp:RadioButton ID="rdPorContrato" runat="server" AutoPostBack="True" 
                GroupName="porContrato" oncheckedchanged="rdPorContrato_CheckedChanged" 
                Text="Por Contrato" />
            &nbsp;</td>
        <td class="style4" colspan="3">
            <asp:Label ID="lblNumeroContrato" runat="server" Text="Numero Contrato" 
                Visible="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="cmbContrato" runat="server" Visible="False" Width="300px">
            </asp:DropDownList>
        </td>
    </tr>
<tr>
<td>&nbsp;</td>
<td>  
    &nbsp;</td>
<td class="style4"> &nbsp;</td>
<td class="style3"> &nbsp;</td>
<td class="style2"> &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>  
    Tipo de Servicio</td>
<td class="style4"> 
    <asp:DropDownList ID="cmbTipoServicio" runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="nombretipoServicio" 
        DataValueField="codTipoServicio">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.TipoServicioTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_codTipoServicio" Type="String" />
            <asp:Parameter Name="Original_nombretipoServicio" Type="String" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_devuelveTaller" Type="Boolean" />
            <asp:Parameter Name="Original_validoContrato" Type="Boolean" />
            <asp:Parameter Name="Original_preventivo" Type="Boolean" />
            <asp:Parameter Name="Original_correctivo" Type="Boolean" />
            <asp:Parameter Name="Original_devuelveEntrada" Type="Boolean" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="codTipoServicio" Type="String" />
            <asp:Parameter Name="nombretipoServicio" Type="String" />
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="devuelveTaller" Type="Boolean" />
            <asp:Parameter Name="validoContrato" Type="Boolean" />
            <asp:Parameter Name="preventivo" Type="Boolean" />
            <asp:Parameter Name="correctivo" Type="Boolean" />
            <asp:Parameter Name="devuelveEntrada" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nombretipoServicio" Type="String" />
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="devuelveTaller" Type="Boolean" />
            <asp:Parameter Name="validoContrato" Type="Boolean" />
            <asp:Parameter Name="preventivo" Type="Boolean" />
            <asp:Parameter Name="correctivo" Type="Boolean" />
            <asp:Parameter Name="devuelveEntrada" Type="Boolean" />
            <asp:Parameter Name="Original_codTipoServicio" Type="String" />
            <asp:Parameter Name="Original_nombretipoServicio" Type="String" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_devuelveTaller" Type="Boolean" />
            <asp:Parameter Name="Original_validoContrato" Type="Boolean" />
            <asp:Parameter Name="Original_preventivo" Type="Boolean" />
            <asp:Parameter Name="Original_correctivo" Type="Boolean" />
            <asp:Parameter Name="Original_devuelveEntrada" Type="Boolean" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </td>
<td class="style3"> Asesor Comercial</td>
<td class="style2"> 
    <asp:DropDownList ID="cmbAsesoresComerciales" runat="server" 
        DataSourceID="ObjectDataSourceAsesores" DataTextField="NombreAsesor" 
        DataValueField="codAsesor">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSourceAsesores" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.asesoresComercialesTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_codAsesor" Type="Int32" />
            <asp:Parameter Name="Original_NombreAsesor" Type="String" />
            <asp:Parameter Name="Original_correo" Type="String" />
            <asp:Parameter Name="Original_telefono" Type="String" />
            <asp:Parameter Name="Original_celular" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="codAsesor" Type="Int32" />
            <asp:Parameter Name="NombreAsesor" Type="String" />
            <asp:Parameter Name="correo" Type="String" />
            <asp:Parameter Name="telefono" Type="String" />
            <asp:Parameter Name="celular" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="NombreAsesor" Type="String" />
            <asp:Parameter Name="correo" Type="String" />
            <asp:Parameter Name="telefono" Type="String" />
            <asp:Parameter Name="celular" Type="String" />
            <asp:Parameter Name="Original_codAsesor" Type="Int32" />
            <asp:Parameter Name="Original_NombreAsesor" Type="String" />
            <asp:Parameter Name="Original_correo" Type="String" />
            <asp:Parameter Name="Original_telefono" Type="String" />
            <asp:Parameter Name="Original_celular" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </td>
</tr>
<tr>
<td>&nbsp;</td>
<td>  
    Responsable</td>
<td class="style4"> 
    <asp:DropDownList ID="cmbResponsable" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="nombre" 
        DataValueField="cod_usuario">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        
        
        SelectCommand="select rtrim(login) cod_usuario,nombre from usuario where es_bloqueado =0  or es_bloqueado is null order by nombre">
    </asp:SqlDataSource>
    </td>
<td class="style3"> &nbsp;</td>
<td class="style2"> &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>  
    Inicio</td>
<td class="style4"> 
    <telerik:RadDateTimePicker ID="calinicio" Runat="server">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td class="style3"> &nbsp;</td>
<td class="style2"> &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>  
    Fin</td>
<td class="style4"> 
    <telerik:RadDateTimePicker ID="calFin" Runat="server">
    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td class="style3"> &nbsp;</td>
<td class="style2"> &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>  
    Observaciones Iniciales</td>
<td class="style4"> &nbsp;</td>
<td class="style3"> &nbsp;</td>
<td class="style2"> &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td colspan="3">  
    <asp:TextBox ID="txtObservacionesIniciales" runat="server" Height="58px" 
        TextMode="MultiLine" Width="505px"></asp:TextBox>
</td>
<td class="style2">  
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td colspan="4">  
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>  
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
        onclick="btnGuardar_Click" />
    <asp:Button ID="btnGuardarYCrearOtra" runat="server" 
        Text="Guardar y Crear Otra" onclick="btnGuardarYCrearOtra_Click" />
</td>
<td class="style4"> &nbsp;</td>
<td class="style3"> &nbsp;</td>
<td class="style2"> &nbsp;</td>
</tr>
</table>
</asp:Panel>

</div>
</asp:Content>


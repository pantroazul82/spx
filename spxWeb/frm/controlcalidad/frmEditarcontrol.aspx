<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmEditarcontrol.aspx.cs" Inherits="frm_controlcalidad_frmEditarcontrol" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc1" %>
<%@ Register src="../../controles/controlLlamadas.ascx" tagname="controlLlamadas" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />   <style type="text/css">
    
    <style type='text/css'>
        .style1
        {
            width: 70px;
        }
        .style2
        {
            width: 11px;
        }
        .style3
        {  }
          .style4
                                                                                             {
                                                                                                 height: 41px;
                                                                                             }
                                                                                             .style5
                                                                                             {
                                                                                                 width: 11px;
                                                                                                 height: 41px;
                                                                                             }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><asp:Button ID="btnCliente"   runat="server" onclick="btnCliente_Click" 
    style="visibility:hidden; " Text="Cargar" Width="0px" />
<div class="tab">Control Calidad
    <asp:Label ID="lblCodControlCalidad" runat="server"></asp:Label>
    &nbsp;</div>
<div class="Formulario">
<table>

<tr>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td class="style3">
    &nbsp;&nbsp;</td>
<td colspan="2">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td class="style3">
    <asp:RadioButton ID="rdRealizadoAnnar" runat="server" GroupName="realizado" 
        Text="Realizado en Annar" />
    </td>
<td colspan="2">
    <asp:RadioButton ID="rdRealizadoCliente" runat="server" GroupName="realizado" 
        Text="Realizado en instalaciones de cliente" />
    </td>
<td class="style2">
    &nbsp;</td>
</tr>
<tr>
<td class="style4"></td>
<td class="style4">
    Asignado a</td>
<td class="style4">
    <asp:DropDownList ID="cmbAsignadoA" runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="nombre" 
        DataValueField="cod_usuario">
    </asp:DropDownList>
    </td>
<td class="style4">
<asp:Label runat="server" ID="lbl2" Width="210px"></asp:Label>
    Fecha de Creacion</td>
<td class="style4">
    <telerik:RadDateTimePicker ID="calCreacion" Runat="server" 
        Enabled="False">
        <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td class="style5">
    </td>
</tr>
<tr>
<td class="style4">&nbsp;</td>
<td class="style4">
<asp:Label runat="server" ID="lnl1" Text="Fecha de Programacion" Width="170px"></asp:Label>
    </td>
<td class="style4">
    <telerik:RadDateTimePicker ID="calInicioProgramacion" Runat="server">
    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td class="style4">
    Fecha Final de Programacion</td>
<td class="style4">
    <telerik:RadDateTimePicker ID="calFinProgramacion" Runat="server">
    <Calendar ID="Calendar3" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
<td class="style5">
    &nbsp;</td>
</tr>
<tr>
<td class="style4" colspan="6">&nbsp;</td>
</tr>
<tr>
<td colspan="6">
    <telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
        MultiPageID="RadMultiPage2" SelectedIndex="0">
        <Tabs>
            <telerik:RadTab runat="server" Selected="True" Text="Llamada">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Cliente Interno">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Cliente Externo">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
   
<telerik:RadMultiPage ID="RadMultiPage2" Runat="server" SelectedIndex="0">
        <telerik:RadPageView ID="RadPageView1" runat="server">
           Llamada: <uc2:controlLlamadas ID="controlLlamadas1" runat="server" />
                   <table>
        <tr>
<td>&nbsp;</td>
<td>Cliente</td>
<td class="style3">
    <asp:TextBox ID="txtClienteLlamada" runat="server" ReadOnly="true"   
        Width="200px"></asp:TextBox>
    </td>
<td>
    Socio de Negocio</td>
<td class="style1">
    <asp:TextBox ID="txtSocioNegocioLlamada" runat="server"   
        Width="200px" ReadOnly="True"></asp:TextBox>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td><asp:Label ID="Label1" runat="server" Text="Sucursal"  ></asp:Label>
    </td>
<td class="style3">
    <asp:DropDownList ID="cmbSucursalLlamada" runat="server" Enabled="false" >
    </asp:DropDownList>
    </td>
<td>
    <asp:Label ID="Label2" runat="server" Text="Contacto"  ></asp:Label>
    </td>
<td class="style1">
    <asp:DropDownList ID="cmbContactoLlamada" runat="server" Enabled="false"  >
    </asp:DropDownList>
 
    </td>
<td class="style2">
    &nbsp;</td>
</tr>
                       <tr>
                           <td>
                               &nbsp;</td>
                           <td>
                               Telefono</td>
                           <td class="style3">
                               <asp:TextBox ID="txtTelefonoContacto" runat="server" ReadOnly="True"></asp:TextBox>
                           </td>
                           <td>
                               Celular</td>
                           <td class="style1">
                               <asp:TextBox ID="txtCelularContacto" runat="server" ReadOnly="True"></asp:TextBox>
                           </td>
                           <td class="style2">
                               &nbsp;</td>
                       </tr>
        </table>

        </telerik:RadPageView>
        <telerik:RadPageView ID="RadPageView2" runat="server">
        Cliente Interno :
            <asp:TextBox ID="txtClienteInterno" runat="server"></asp:TextBox>
        </telerik:RadPageView>
        <telerik:RadPageView ID="RadPageView3" runat="server">
        <table>
        <tr>
<td>&nbsp;</td>
<td>Cliente</td>
<td class="style3">
    <asp:TextBox ID="txtCliente" runat="server"   
        Width="200px"></asp:TextBox>
    </td>
<td>
    Socio de Negocio</td>
<td class="style1">
    <asp:TextBox ID="txtSocioNegocio" runat="server"   
        Width="200px" ReadOnly="True"></asp:TextBox>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td><asp:Label ID="lblSucursal" runat="server" Text="Sucursal"  ></asp:Label>
    </td>
<td class="style3">
    <asp:DropDownList ID="cmbSucursal" runat="server"  >
    </asp:DropDownList>
    </td>
<td>
    <asp:Label ID="lblContacto" runat="server" Text="Contacto"  ></asp:Label>
    </td>
<td class="style1">
    <asp:DropDownList ID="cmbContacto" runat="server"  >
    </asp:DropDownList>
    <asp:ImageButton ID="btnCargarContactos" runat="server" 
        ImageUrl="~/img/web/GoBack.gif" onclick="btnCargarContactos_Click" 
        ToolTip="Cargar Contactos" Width="28px" />
    <asp:HyperLink ID="lnkNuevoContaco" runat="server" 
        ImageUrl="~/img/web/insert.gif" 
        NavigateUrl="~/frm/parametrizacion/frmContactos.aspx" Target="_blank">Nuevo Contacto</asp:HyperLink>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
        </table>
        </telerik:RadPageView>

    </telerik:RadMultiPage>

<hr />
    </td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td class="style3">
    &nbsp;</td>
<td>
    &nbsp;</td>
<td class="style1">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td colspan="6">
<hr />
&nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td colspan="2"><strong>Informacion del Producto</strong></td>
<td>
    &nbsp;</td>
<td class="style1">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>Casa Comercial:</td>
<td class="style3">
    <asp:DropDownList ID="cmbFabricante" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSourceFabricante" DataTextField="nombre_fabricante" 
        DataValueField="codFabricante">
    </asp:DropDownList>
    </td>
<td style="text-align: right">
    Producto</td>
<td class="style1">
    <asp:DropDownList ID="cmbReactivo" runat="server" 
        DataSourceID="SqlDataSourceReactivo" DataTextField="nombre_referencia_reactivo" 
        DataValueField="cod_referencia_reactivo">
    </asp:DropDownList>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>Fecha De Vencimiento</td>
<td class="style3">
   
<telerik:RadDatePicker ID="calVencimiento" Runat="server">
        <Calendar ID="Calendar8" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
	
    </td>
<td style="text-align: right">
    Lote</td>
<td class="style1">
    <asp:TextBox ID="txtNumeroLote" runat="server"></asp:TextBox>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>Cantidad Recibido</td>
<td class="style3" colspan="3">
    <asp:TextBox ID="txtcantidadRecibida" runat="server" Width="150px"></asp:TextBox>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>
<tr>
<td colspan="6">
<hr />
&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td colspan="3">
    <br />
    Entregado a servicio Técnico por</td>
<td class="style1">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td colspan="5">
    <asp:TextBox ID="txtEntregadoPor" runat="server" Width="300px"></asp:TextBox>
    </td>
</tr>
<tr>
<td>&nbsp;</td>
<td colspan="5">
    <br />
    Motivo  de la solicitud</td>
</tr>
<tr>
<td>&nbsp;</td>
<td colspan="5">
    <asp:TextBox ID="txtMotivo" runat="server" Width="425px" Height="78px" 
        MaxLength="500" TextMode="MultiLine"></asp:TextBox>
    </td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td class="style3" colspan="4">
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td colspan="5">
    Quien Recibe</td>
</tr>
<tr>
<td>&nbsp;</td>
<td>
    <asp:DropDownList ID="cmbQuienRecibe" runat="server" 
        DataSourceID="SqlDataSourceUsuarios" DataTextField="nombre" DataValueField="cod_usuario" 
       >
    </asp:DropDownList>
    </td>
<td colspan="4">
    &nbsp;</td>
</tr>
<tr>
<td>&nbsp;</td>
<td valign="top"><br />Observaciones Iniciales</td>
<td colspan="3">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td></td>
<td valign="top" colspan="4">
    <asp:TextBox ID="txtObservaciones" runat="server" Height="68px" Width="424px" 
        TextMode="MultiLine" MaxLength="500"></asp:TextBox>
    </td>
<td class="style2">
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td valign="top" colspan="4">
<table>



<tr>
<td>
<asp:Label runat="server" ID="lbl3" Text="Numero de Factura:" Width="150px"></asp:Label>

</td><td><asp:TextBox ID="txtFactura" runat="server"></asp:TextBox></td>
<td></td>
<td>Fecha de Factura</td><td><telerik:RadDatePicker ID="calfechaFactura" Runat="server">
        <Calendar ID="Calendar4" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker></td>

</tr>
<tr>
<td>Fecha Apertura del Producto:</td>
<td>
<telerik:RadDatePicker ID="calAperturaProducto" Runat="server">
        <Calendar ID="Calendar5" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
</td>
<td></td>
<td>Fecha inconveniente:</td><td>
<telerik:RadDatePicker ID="calFechaInconveniente" Runat="server">
        <Calendar ID="Calendar6" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
</td>

</tr>
<tr>
<td>Fecha Llegada del producto:</td>
<td><telerik:RadDatePicker ID="calFechaLlegadaProducto" Runat="server">
        <Calendar ID="Calendar7" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker></td>
<td></td>
<td></td><td></td>

</tr>
</table>
&nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>






<tr>
<td>&nbsp;</td>
<td colspan="3">
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td class="style1">&nbsp;</td>
<td class="style2">&nbsp;</td>
</tr>
<tr>
<td></td>
<td></td>
<td colspan="3">
    </td>
<td class="style2">&nbsp;</td>
</tr>
<tr>
<td></td>
<td>
    &nbsp;</td>
<td colspan="2">
    <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Guardar" />
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />
    <br />
    </td>
<td class="style1">
    &nbsp;</td>
<td class="style2">
    &nbsp;</td>
</tr>

</table>

</div>
    <asp:SqlDataSource ID="SqlDataSourceReactivo" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_referencia_reactivo], [nombre_referencia_reactivo] FROM [referencia_reactivo] WHERE ([codFabricante] = @codFabricante) ORDER BY [nombre_referencia_reactivo]">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbFabricante" Name="codFabricante" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceFabricante" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [codFabricante], [nombre_fabricante] FROM [fabricante] ORDER BY [nombre_fabricante]">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceUsuarios" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="getDataByGrupo" 
        TypeName="SPXSeguridad.data.cls.clsTusuario">
        <SelectParameters>
            <asp:Parameter DefaultValue="11" Name="cod_grupo_usuario" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSourceControlCAlidadInternos" 
                runat="server" DeleteMethod="Delete" InsertMethod="Insert" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByActivo" 
                TypeName="SPControladoraDatos.dsCientificaTableAdapters.control_calidad_internoTableAdapter" 
                UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_cod_control_calidad_interno" Type="Int32" />
                    <asp:Parameter Name="Original_descripcion" Type="String" />
                    <asp:Parameter Name="Original_activo" Type="Boolean" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="descripcion" Type="String" />
                    <asp:Parameter Name="activo" Type="Boolean" />
                </InsertParameters>
                <SelectParameters>
                    <asp:Parameter DefaultValue="True" Name="activo" Type="Boolean" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="descripcion" Type="String" />
                    <asp:Parameter Name="activo" Type="Boolean" />
                    <asp:Parameter Name="Original_cod_control_calidad_interno" Type="Int32" />
                    <asp:Parameter Name="Original_descripcion" Type="String" />
                    <asp:Parameter Name="Original_activo" Type="Boolean" />
                </UpdateParameters>
            </asp:ObjectDataSource>
</asp:Content>

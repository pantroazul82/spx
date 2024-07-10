<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmResumenDetalladoRevision.aspx.cs" Inherits="frm_revision_frmResumenDetalladoRevision" %>

<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc1" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
    <telerik:RadTabStrip ID="RadTabStrip1" runat="server">
    </telerik:RadTabStrip>
<br />
<br />
<div class="Formulario">

 <telerik:RadTabStrip ID="RadTabStrip2" runat="server" 
        MultiPageID="radMultiGeneral" SelectedIndex="0">
        <Tabs>
        <telerik:RadTab runat="server" Text="Informacion Aprobacion" Selected="True">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="General">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Archivos">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
    <telerik:RadMultiPage ID="radMultiGeneral" runat="server" SelectedIndex="0">
    <telerik:RadPageView ID="RadPageViewInfoaprobacion"  runat="server" ><table><tr><td>Concepto Cientifico</td><td class="style1"><asp:RadioButton 
                runat="server" ID="rdAdecuado" Text="Adecuado" GroupName="r3" Enabled="False" /></td><td></td><td><asp:RadioButton 
                runat="server" ID="rdNoAdecuado" Text="No Adecuado" GroupName="r3" 
                Enabled="False" /></td><td></td></tr><tr><td>Cerrado por</td><td class="style1"><asp:Label 
                ID="lblCerradoPor" runat="server"></asp:Label></td><td>Fecha de cierre</td><td><asp:Label 
                ID="lblFechaCierre" runat="server"></asp:Label></td><td>&nbsp;</td></tr><tr><td></td><td 
                class="style1">
                </td><td></td><td></td><td>&nbsp;</td></tr><tr><td>&nbsp;</td><td 
                class="style1">&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td>Observaciones </td><td class="style1">&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td>&nbsp;</td><td class="style1" colspan="3"><asp:TextBox 
                ID="txtObservaciones" runat="server" Height="42px" Width="840px" 
        TextMode="MultiLine" ReadOnly="True"></asp:TextBox></td><td>&nbsp;</td></tr><tr><td></td><td ></td><td></td><td></td><td></td></tr></table></telerik:RadPageView>  
    <telerik:RadPageView ID="RadPageView1"  runat="server" >
    
    <table>
    
<tr>
<td>Estado</td>
<td>
    <asp:Label ID="lblEstado" runat="server"></asp:Label>
</td>
<td>&nbsp;</td>
<td>Codigo Revision</td>
<td>
    <asp:Label ID="lblCodigoRevision" runat="server"></asp:Label>
    </td>
</tr>
    <tr>
        <td>
            Creado Por:</td>
        <td>
            <asp:Label ID="lblCreadoPor" runat="server"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
        <td>
            Fecha de Creacion</td>
        <td>
            <asp:Label ID="lblFechaCreacion" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            Origen Solicitud</td>
        <td>
            <asp:DropDownList ID="cmbOrigen" runat="server" AppendDataBoundItems="true" 
                DataSourceID="SqlDataSourceOrigen" 
                DataTextField="nombre_origen_revision_equipos" 
                DataValueField="cod_origen_revision_equipos" Width="200px" Enabled="False">
                <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
            Id FO</td>
        <td>
            <asp:TextBox ID="txtIdFo" runat="server" ReadOnly="True"></asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="txtIdFo_FilteredTextBoxExtender" 
                runat="server" Enabled="True" FilterType="Numbers" TargetControlID="txtIdFo">
            </cc1:FilteredTextBoxExtender>
        </td>
    </tr>
<tr>
<td>
<asp:Label runat="server" ID="lblinge" Text="Ingeniero que Entrega" Width="150px"></asp:Label></td>
<td><asp:DropDownList runat="server" ID="cmbIngenieroRecibe" AppendDataBoundItems="true"
        DataSourceID="SqlDataSourceIngenieroRecibe" DataTextField="nombre" 
        DataValueField="cod_usuario" Width="200px" Enabled="False">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
        </asp:DropDownList>
</td>
<td>&nbsp;</td>
<td>Colaborador que recibe</td>
<td><asp:DropDownList runat="server" ID="cmbAsesorRecibe" AppendDataBoundItems="true" 
        DataSourceID="SqlDataSourceIngenieroRecibe" DataTextField="nombre" 
        DataValueField="cod_usuario" Enabled="False">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
        </asp:DropDownList>
    </td>
</tr>
<tr>
<td>Asignado A:</td>
<td>
    <asp:DropDownList runat="server" ID="cmbAsignadoA" AppendDataBoundItems="true" 
        DataSourceID="SqlDataSourceIngenieroRecibe" DataTextField="nombre" 
        DataValueField="cod_usuario" Width="200px" Enabled="False">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
        </asp:DropDownList>
    </td>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td>Programacion:</td>
<td>
    <telerik:RadDateTimePicker ID="calInicio" Runat="server" Height="24px" 
        Enabled="False">

<Calendar runat="server" ID="calendar1">

    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>


    </telerik:RadDateTimePicker>



    </td>
<td>&nbsp;</td>
<td>
    Fin Programacion</td>
<td>
    <telerik:RadDateTimePicker ID="calFin" Runat="server" Enabled="False">
 <Calendar runat="server" ID="calendar2" >

    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
</tr>

<tr>
<td>Fecha Ejecucion:</td>
<td>
    <telerik:RadDateTimePicker ID="calInicioEjecucion" Runat="server" Height="24px" 
        Enabled="False">

<Calendar runat="server" ID="calendar3">

    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>


    </telerik:RadDateTimePicker>




    </td>
<td>&nbsp;</td>
<td>
    Fin Ejecucion:</td>
<td>
    <telerik:RadDateTimePicker ID="calFinEjecucion" Runat="server" Enabled="False">
 <Calendar runat="server" ID="calendar4" >

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
   
    </td>
<td>&nbsp;</td>
<td>
    </td>
<td>
    
    </td>
</tr>
<tr>
<td>Cliente local</td>
<td>
    <asp:HyperLink ID="txtCliente" runat="server">[txtCliente]</asp:HyperLink>
    </td>
<td>&nbsp;</td>
<td>
    Sucursal</td>
<td>
    <asp:DropDownList ID="cmbSucursal" runat="server" Enabled="False">
    </asp:DropDownList>
    </td>
</tr>
        <tr>
            <td>
                Cliente final</td>
            <td>
            <asp:HyperLink ID="txtclienteFinal" runat="server"></asp:HyperLink>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                Sucursal</td>
            <td>
                <asp:DropDownList ID="cmbSucursalFinal" runat="server" Enabled="False">
                </asp:DropDownList>
            </td>
        </tr>
<tr>
<td>&nbsp;</td>
<td>
    <asp:RadioButton ID="rdEquipoNuevo" runat="server" GroupName="r" 
        Text="Equipo Nuevo" Enabled="False" />
</td>
<td>&nbsp;&nbsp;&nbsp;</td>
<td>
    <asp:RadioButton ID="rdEquipoNoNuevo" runat="server" GroupName="r" Width="120px" 
         Text="Equipo Usado" Enabled="False" />
    </td>
<td>&nbsp;</td>
</tr>
<tr>
<td>Serial</td>
<td colspan="4">
    <uc1:controlSerial ID="controlSerial1" runat="server" ReadOnly="True" />
    <asp:Label ID="lblInformacionSerial" runat="server"></asp:Label>
</td>
</tr>
<tr>
<td>Orden de Servicio</td>
<td colspan="4">
    <asp:DropDownList ID="cmbOrdenServicio" runat="server" Enabled="False">
    </asp:DropDownList>
</td>
</tr>
<tr>
<td>Observaciones Iniciales</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td colspan="5">
    <asp:TextBox ID="txtObservacionesiniciales" runat="server" Height="65px" 
        TextMode="MultiLine" Width="575px" ReadOnly="True"></asp:TextBox>
    
    </td>
</tr>
        
        
        
        
        <tr><td></td><td colspan="4">&nbsp;</td></tr><tr><td></td><td>&nbsp;</td><td></td><td></td><td></td></tr></table></telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView8"  runat="server" >
        <asp:Button ID="btnAgregarArchivo" runat="server" Text="Agregar Archivo" 
                onclick="btnAgregarArchivo_Click" /><br />
        <telerik:RadGrid ID="RadGrid20" runat="server" AutoGenerateColumns="False" 
                CellSpacing="0" DataSourceID="SqlArchivos" GridLines="None">
                    <MasterTableView DataKeyNames="cod_archivos_revision_equipos" 
                    DataSourceID="SqlArchivos"><CommandItemSettings ExportToPdfText="Export to PDF" /><RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                        Visible="True"><HeaderStyle Width="20px" /></RowIndicatorColumn><ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                        Visible="True"><HeaderStyle Width="20px" /></ExpandCollapseColumn><Columns><telerik:GridBoundColumn DataField="cod_archivos_control_calidad" 
                            DataType="System.Int32" 
                            FilterControlAltText="Filter cod_archivos_revision_equipos column" 
                            HeaderText="cod_archivos_revision_equipos" ReadOnly="True" 
                            SortExpression="cod_archivos_revision_equipos" 
                            UniqueName="cod_archivos_revision_equipos" Visible="False"></telerik:GridBoundColumn>
                            
                            <telerik:GridBoundColumn DataField="tipo" 
                            FilterControlAltText="Filter tipo column" HeaderText="Tipo" 
                            SortExpression="tipo" UniqueName="tipo"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="fecha_subida" DataType="System.DateTime" 
                            FilterControlAltText="Filter fecha_subida column" HeaderText="Fecha subida" 
                            SortExpression="fecha_subida" UniqueName="fecha_subida"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="fecha_manual" DataType="System.DateTime" 
                            FilterControlAltText="Filter fecha_manual column" HeaderText="Fecha Manual" 
                            SortExpression="fecha_manual" UniqueName="fecha_manual"></telerik:GridBoundColumn><telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                            HeaderText="Opciones" UniqueName="TemplateColumn"><ItemTemplate><asp:Button ID="Button1" runat="server" Text="Ver Archivo" CommandArgument='<%# Eval("cod_archivos_revision_equipos") %>' OnClick="btnVerArchivo" /></ItemTemplate></telerik:GridTemplateColumn></Columns><EditFormSettings><EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn></EditFormSettings></MasterTableView><FilterMenu EnableImageSprites="False"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></FilterMenu><HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></HeaderContextMenu></telerik:RadGrid></telerik:RadPageView>

    </telerik:RadMultiPage>

                    <asp:SqlDataSource ID="SqlArchivos" runat="server" 
                ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                
                
        SelectCommand="SELECT [cod_archivos_revision_equipos], [tipo], [fecha_subida], [fecha_manual] FROM [archivos_revision_equipos] WHERE ([cod_revision_equipos] = @cod_revision_equipos)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="cod_revision_equipos" QueryStringField="cod" 
                        Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>











<asp:SqlDataSource ID="SqlDataSourceIngenieroRecibe" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] WHERE ([es_bloqueado] = @es_bloqueado) ORDER BY [nombre]">
        <SelectParameters>
            <asp:Parameter DefaultValue="false" Name="es_bloqueado" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSourceOrigen" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_origen_revision_equipos], [nombre_origen_revision_equipos] FROM [origen_revision_equipos] WHERE ([activo] = @activo2) ORDER BY [nombre_origen_revision_equipos]">
        <SelectParameters>
            <asp:Parameter DefaultValue="true" Name="activo2" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:Button ID="btnAtras" runat="server" onclick="btnAtras_Click" 
        Text="Atras" />
    <asp:Button ID="btnImprimir" runat="server" onclick="btnImprimir_Click" 
        Text="Imprimir" />
    <asp:Button ID="btnAnular" runat="server" onclick="btnCancelar_Click" 
        Text="Anular" />
    <asp:Button ID="btnCerrar" runat="server" onclick="btnCerrar_Click" 
        Text="Cerrar" />
    
    <asp:Button ID="btnEjecutar" runat="server" onclick="btnEjecutar_Click" 
        Text="Ejecutar" />
    <asp:Button ID="btnAsignar" runat="server" onclick="btnAsignar_Click" 
        Text="Asignar" />
    <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" />
    <asp:Button ID="btnReabrir" runat="server" OnClick="btnReabrir_Click" OnClientClick="return confirm('Esta seguro de reabrir la revision');" Text="Reabrir" />
</div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmResumenDetalladoControl.aspx.cs" Inherits="frm_controlcalidad_frmResumenDetalladoControl" %>


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
                                                                                             </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><asp:Button ID="btnCliente"   runat="server" onclick="btnCliente_Click" 
    style="visibility:hidden; " Text="Cargar" Width="0px" />
    <br />
            <table>
<tr>
<td></td>
<td colspan="4">
    <telerik:RadButton ID="btnImprimir" runat="server" onclick="btnImprimir_Click" 
        Skin="Web20" Text="Imprimir">
    </telerik:RadButton>
    <telerik:RadButton ID="btnAnular" runat="server" onclick="btnAnular_Click" 
        Skin="Web20" Text="Anular">
    </telerik:RadButton>
    <telerik:RadButton ID="btneditar" runat="server" onclick="btneditar_Click" 
        Skin="Web20" Text="Editar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnEjecutar" runat="server" onclick="btnEjecutar_Click" 
        Skin="Web20" Text="Ejecutar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnAprobar" runat="server" onclick="btnAprobar_Click" 
        Skin="Web20" Text="Aprobar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnReasignarApobador" runat="server" onclick="btnReasignarApobador_Click" 
        Skin="Web20" Text="Reasignar Aprobador">
    </telerik:RadButton>
    <telerik:RadButton ID="btnCerrar" runat="server" onclick="btnCerrar_Click" 
        Skin="Web20" Text="Cerrar/Cerrar en Seguimiento">
    </telerik:RadButton>
    <asp:Button ID="btnReabrir" runat="server" onclick="btnReabrir_Click"  Text="Reabrir" OnClientClick="return confirm('Esta seguro de reabrrir el control');" />
    
    <asp:Button ID="btnVolver" runat="server" onclick="btnCancelar_Click" 
        Text="Volver" />
    </td>
<td class="style2">&nbsp;</td>
</tr>
</table>
        <asp:SqlDataSource ID="SqlEncargadoAprobacion" runat="server" 
            ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
            
            
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
        </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceusuariostramite" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        
            
        SelectCommand="SELECT [nombre], [cod_usuario] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
<br />

<div class="tab">Control Calidad
    <asp:Label ID="lblCodControlCalidad" runat="server"></asp:Label>
    &nbsp;</div>

    
<div class="Formulario">


 <telerik:RadTabStrip ID="RadTabStrip2" runat="server" 
        MultiPageID="radMultiGeneral" SelectedIndex="0">
        <Tabs>
       
            <telerik:RadTab runat="server" Text="General" Selected="True">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Procedimientos Cientifica">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Conclusiones">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Informacion Aprobacion">
            </telerik:RadTab>

            <telerik:RadTab runat="server" Text="Seguimientos">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Archivos">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
    <telerik:RadMultiPage ID="radMultiGeneral" runat="server" SelectedIndex="0">
    <telerik:RadPageView ID="RadPageView1"  runat="server" ><table><tr><td>&nbsp;</td><td colspan="2">
        &nbsp;</td>
        <td>
            &nbsp;</td>
        <td colspan="2">&nbsp;</td><td >&nbsp;</td></tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="2">
                <asp:RadioButton ID="rdRealizadoAnnar" runat="server" Enabled="false" 
                    GroupName="realizado" Text="Realizado en Annar" />
            </td>
            <td colspan="3">
                <asp:RadioButton ID="rdRealizadoCliente" runat="server" Enabled="false" 
                    GroupName="realizado" Text="Realizado en instalaciones de cliente" 
                    Width="280px" />
            </td>
            
            <td>
                &nbsp;</td>
        </tr>
        <tr>
        <td>&nbsp;</td>
        <td>Consecutivo:<asp:Label ID="lblConsecutivo2" runat="server"></asp:Label>
            </td>
            <td >&nbsp;</td>
        <td colspan="4">
            Asignado a&nbsp;&nbsp;<asp:DropDownList ID="cmbAsignadoA" runat="server" 
                DataSourceID="ObjectDataSource1" DataTextField="nombre" 
                DataValueField="cod_usuario" Enabled="false">
            </asp:DropDownList>
            </td>
            </tr>

        
        <tr>
        <td colspan="7"/>
        <hr />
        </tr>
        <tr><td colspan="7"><telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
        MultiPageID="RadMultiPage2" SelectedIndex="1"><Tabs><telerik:RadTab runat="server" Text="Llamada"></telerik:RadTab><telerik:RadTab runat="server" Text="Cliente Interno" Selected="True"></telerik:RadTab><telerik:RadTab runat="server" Text="Cliente Externo"></telerik:RadTab></Tabs></telerik:RadTabStrip><telerik:RadMultiPage ID="RadMultiPage2" Runat="server" SelectedIndex="1" 
        Width="52px"><telerik:RadPageView ID="RadPageView2" runat="server"><table><tr><td>&nbsp;</td><td>
                Llamada:</td><td class="style3">
                    <uc2:controlLlamadas ID="controlLlamadas1" runat="server" />
                </td><td style="text-align: right">&nbsp;</td><td class="style1">&nbsp;</td><td class="style2">&#160;</td></tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        Cliente</td>
                    <td class="style3">
                        <asp:TextBox ID="txtClienteLlamada" runat="server" ReadOnly="true" 
                            Width="200px"></asp:TextBox>
                    </td>
                    <td style="text-align: right">
                        Socio de Negocio</td>
                    <td class="style1">
                        <asp:TextBox ID="txtSocioNegocioLlamada" runat="server" ReadOnly="True" 
                            Width="200px"></asp:TextBox>
                    </td>
                    <td class="style2">
                        &nbsp;</td>
                </tr>
                <tr><td>&nbsp;</td><td><asp:Label ID="Label2" runat="server" Text="Sucursal"  ></asp:Label></td><td class="style3"><asp:DropDownList ID="cmbSucursalLlamada" runat="server" Enabled="false" ></asp:DropDownList></td>
                <td style="text-align: right"><asp:Label ID="Label3" runat="server" Text="Contacto"  ></asp:Label></td><td class="style1"><asp:DropDownList ID="cmbContactoLlamada" runat="server" Enabled="false"  ></asp:DropDownList></td><td class="style2">&#160;</td></tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        Telefono</td>
                    <td class="style3">
                    <asp:TextBox runat="server" ID="txtTelefonoContacto" ReadOnly="true"></asp:TextBox>
                        &nbsp;</td>
                    <td style="text-align: right">
                        &nbsp;</td>
                    <td class="style1">
                        &nbsp;</td>
                    <td class="style2">
                        &nbsp;</td>
                </tr>
                </table></telerik:RadPageView><telerik:RadPageView ID="RadPageView3" runat="server"><asp:panel runat="server" Width="500px"><asp:Label runat="server" ID="lblclienteInterno" Text="Cliente Interno :" Width="200px"></asp:Label><asp:TextBox ID="txtClienteInterno" runat="server" ReadOnly="true"></asp:TextBox></asp:panel></telerik:RadPageView><telerik:RadPageView ID="RadPageView4" runat="server"><table><tr><td>&nbsp;</td><td>Cliente</td><td class="style3"><asp:TextBox ID="txtCliente" runat="server"   
        Width="200px"></asp:TextBox></td><td>Socio de Negocio</td><td class="style1"><asp:TextBox ID="txtSocioNegocio" runat="server"   
        Width="200px" ReadOnly="True"></asp:TextBox></td><td class="style2">&#160;</td></tr><tr><td>&nbsp;</td><td><asp:Label ID="lblSucursal" runat="server" Text="Sucursal"  ></asp:Label></td><td class="style3"><asp:DropDownList ID="cmbSucursal" runat="server" Enabled="false"   ></asp:DropDownList></td><td><asp:Label ID="lblContacto" runat="server" Text="Contacto"  ></asp:Label></td><td class="style1"><asp:DropDownList ID="cmbContacto" runat="server"  Enabled="false"  ></asp:DropDownList></td><td class="style2">&#160;</td></tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    Telefono:</td>
                <td class="style3">
                <asp:TextBox runat="server" ID="txtTelefonoCliente" ReadOnly="true"></asp:TextBox>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            </table></telerik:RadPageView></telerik:RadMultiPage><hr /></td></tr><tr><td>&nbsp;</td><td>Casa Comercial</td><td ><asp:DropDownList ID="cmbFabricante" runat="server" Enabled="false"  AutoPostBack="True" 
        DataSourceID="SqlDataSourceFabricante" DataTextField="nombre_fabricante" 
        DataValueField="codFabricante" ></asp:DropDownList></td>
        <td style="text-align: right">
            Producto</td>
        <td style="text-align: left" colspan="3">
            <asp:DropDownList ID="cmbReactivo" runat="server" 
                DataSourceID="SqlDataSourceReactivo" DataTextField="nombre_referencia_reactivo" 
                DataValueField="cod_referencia_reactivo" Enabled="false">
            </asp:DropDownList>
            </td></tr><tr><td>&nbsp;</td><td>Fecha De Vencimiento</td><td >
        <telerik:RadDatePicker ID="calVencimiento" Runat="server"  Enabled="false" ><Calendar ID="Calendar1" runat="server"><FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy"></FastNavigationSettings></Calendar></telerik:RadDatePicker></td>
            <td style="text-align: right">
                Lote</td>
            <td style="text-align: left">
                <asp:TextBox ID="txtNumeroLote" runat="server" Enabled="false"></asp:TextBox>
        </td><td >&nbsp;</td><td >&nbsp;</td></tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Cantidad Recibido</td>
            <td>
                <asp:TextBox ID="txtCantidadRecibido" runat="server" Enabled="false" 
                    Width="150px"></asp:TextBox>
            </td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="5">
            <hr />
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                No de Factura</td>
            <td>
                <asp:TextBox ID="txtFactura" runat="server"></asp:TextBox>
            </td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: left">
                Fecha de Factura</td>
            <td>
                <telerik:RadDatePicker ID="calFactura" Runat="server" Enabled="false">
                    <Calendar ID="Calendar2" runat="server">
                        <FastNavigationSettings EnableTodayButtonSelection="True" 
                            TodayButtonCaption="Hoy">
                        </FastNavigationSettings>
                    </Calendar>
                </telerik:RadDatePicker>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Fecha Llegada del producto" 
                    Width="200px"></asp:Label>
            </td>
            <td>
                <telerik:RadDatePicker ID="calLlegadaProducto" Runat="server" Enabled="false">
                    <Calendar ID="Calendar13" runat="server">
                        <FastNavigationSettings EnableTodayButtonSelection="True" 
                            TodayButtonCaption="Hoy">
                        </FastNavigationSettings>
                    </Calendar>
                </telerik:RadDatePicker>
            </td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: left">
                Fecha Apertura del Producto</td>
            <td>
                <telerik:RadDatePicker ID="calAperturaProducto" Runat="server">
                    <Calendar ID="Calendar3" runat="server">
                        <FastNavigationSettings EnableTodayButtonSelection="True" 
                            TodayButtonCaption="Hoy">
                        </FastNavigationSettings>
                    </Calendar>
                </telerik:RadDatePicker>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Fecha Inconveniente</td>
            <td>
                <telerik:RadDatePicker ID="calIncoveniente" Runat="server" Enabled="false">
                    <Calendar ID="Calendar4" runat="server">
                        <FastNavigationSettings EnableTodayButtonSelection="True" 
                            TodayButtonCaption="Hoy">
                        </FastNavigationSettings>
                    </Calendar>
                </telerik:RadDatePicker>
            </td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="5">
            <hr />
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Motivo de la solicitud</td>
            <td>
                &nbsp;</td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="5">
                <asp:TextBox ID="txtMotivo" runat="server" Enabled="false" Height="80px" 
                    MaxLength="500" TextMode="MultiLine" Width="552px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <strong>Resultados Previos del cliente Texto </strong> </td>
            <td>
                &nbsp;</td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="5">
                <asp:TextBox ID="txtResultadosPreviosTxt" runat="server" Height="150px" 
                    ReadOnly="True" TextMode="MultiLine" Width="700px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <strong>Resultados Previos del cliente Imagen</strong></td>
            <td>
                &nbsp;</td>
            <td style="text-align: right">
                &nbsp;</td>
            <td style="text-align: left">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr><td>&nbsp;</td><td colspan="5">
            <telerik:RadEditor ID="EditorResultadosPrevios" Runat="server" 
                EditModes="Preview" Height="269px" Skin="Web20" 
                ToolbarMode="ShowOnFocus">
                <Modules>
                    <telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                        Visible="false" />
                    <telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                        Visible="false" />
                    <telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                        Visible="false" />
                    <telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                        Visible="false" />
                </Modules>
                <Tools>
                    <telerik:EditorToolGroup>
                        <telerik:EditorTool Name="InsertTable" />
                        <telerik:EditorTool Name="InsertDate" />
                        <telerik:EditorTool Name="InsertTime" />
                        <telerik:EditorTool Name="InsertHorizontalRule" />
                        <telerik:EditorTool Name="InsertUnorderedList" />
                        <telerik:EditorTool Name="InsertSymbol" />
                        <telerik:EditorTool Name="Undo" />
                        <telerik:EditorTool Name="Redo" />
                        <telerik:EditorTool Name="Cut" />
                        <telerik:EditorTool Name="FindAndReplace" />
                        <telerik:EditorTool Name="ToggleScreenMode" />
                        <telerik:EditorTool Name="Zoom" />
                        <telerik:EditorTool Name="FontName" />
                        <telerik:EditorTool Name="FontSize" />
                        <telerik:EditorTool Name="Italic" />
                        <telerik:EditorTool Name="Bold" />
                        <telerik:EditorTool Name="StrikeThrough" />
                        <telerik:EditorTool Name="Underline" />
                        <telerik:EditorTool Name="ForeColor" />
                        <telerik:EditorTool Name="BackColor" />
                        <telerik:EditorTool Name="InsertParagraph" />
                        <telerik:EditorTool Name="Outdent" />
                        <telerik:EditorTool Name="JustifyCenter" />
                        <telerik:EditorTool Name="JustifyFull" />
                        <telerik:EditorTool Name="JustifyRight" />
                        <telerik:EditorTool Name="PasteFromWord" />
                        <telerik:EditorTool Name="PasteFromWordNoFontsNoSizes" />
                        <telerik:EditorTool Name="PastePlainText" />
                    </telerik:EditorToolGroup>
                </Tools>
            </telerik:RadEditor>
            </td>
            <td >&nbsp;</td></tr>
        <tr><td>&nbsp;</td><td>&nbsp;</td>
            <td  colspan="5">&nbsp;</td></tr><tr>
        <td colspan="7">&nbsp;</td></tr></table></telerik:RadPageView>

    <telerik:RadPageView ID="RadPageView5"  runat="server"><table><tr><td>&nbsp;</td><td colspan="5"><strong>Procedimientos Realizados por asesoria cientifica</strong></td></tr><tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td>&nbsp;</td>
        <td colspan="2">
            <asp:Label ID="Label4" runat="server" Enabled="false" 
                Text="Revisión estado físico del producto" Width="280px"></asp:Label>
        </td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="2">
                <asp:TextBox ID="txtRevisionEstadoProducto" runat="server" Enabled="false" 
                    TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr><td>&nbsp;</td><td>Calibracion</td><td>
            <asp:DropDownList ID="cmbCalibracion" runat="server" 
                AppendDataBoundItems="true" DataSourceID="SqlCalibracionCalidad" 
                DataTextField="calibracion_calidad" DataValueField="cod_calibracion_calidad" 
                Enabled="false">
                <asp:ListItem Text="--Seleccione--" Value="" />
            </asp:DropDownList>
            </td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="2">
                Procesamiento de muestras
                <asp:RadioButton ID="rdProcesamientoMuestrasSi" runat="server" Enabled="false" 
                    Text="Si" />
                <asp:RadioButton ID="rdProcesamientoMuestrasNo" runat="server" Enabled="false" 
                    Text="No" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr><td>&nbsp;</td><td>Numero de Muestras</td><td>
            <asp:TextBox ID="txtNumeroMuestras" runat="server" Enabled="false" 
                Width="283px"></asp:TextBox>
            </td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                Controles utilizados</td>
            <td>
                <asp:TextBox ID="txtControles" runat="server" Enabled="false" 
                    TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr><td>&nbsp;</td><td>Dispositivo Medico Utilizado</td><td colspan="4">
            <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" height="40px" 
                width="465px">
                <asp:DropDownList ID="cmbFabricanteModeloutilizado" runat="server" 
                    AppendDataBoundItems="true" AutoPostBack="True" 
                    DataSourceID="SqlFabricanteusado" DataTextField="nombre_fabricante" 
                    DataValueField="codFabricante" Enabled="false" Width="150px">
                    <asp:ListItem Text="--Seleccione--" Value="" />
                </asp:DropDownList>
                <asp:DropDownList ID="cmbModeloUtilizado" runat="server" 
                    DataSourceID="SqlModeloUtilizado" DataTextField="NombreModelo" 
                    DataValueField="codModelo" Enabled="false" Width="180px">
                </asp:DropDownList>
            </telerik:RadAjaxPanel>
            </td></tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="lblComp" runat="server" Text="Serial del Dispositivo Médico" 
                    Width="150px"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtComparacionResultados" runat="server" ReadOnly="true"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td> &nbsp;</td>
            <td colspan="2">
                <strong>Resultados del control de calidad Texto &nbsp;</strong>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr><td>&nbsp;</td><td colspan="5">
            <asp:TextBox ID="txtResultadosTxt" runat="server" Height="150px" 
                ReadOnly="True" TextMode="MultiLine" Width="700px"></asp:TextBox>
            </td></tr><tr><td>&nbsp;</td><td colspan="5"><strong>
            <br />
            Resultados del control de calidad Imagen </strong><br /><telerik:RadEditor 
                        ID="EditorResultados" Runat="server" EditModes="Preview" 
                Height="269px" Skin="Web20" ToolbarMode="ShowOnFocus"><Modules><telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                            Visible="false" /><telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                            Visible="false" /><telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                            Visible="false" /><telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                            Visible="false" /></Modules><Tools><telerik:EditorToolGroup><telerik:EditorTool Name="InsertTable" /><telerik:EditorTool Name="InsertDate" /><telerik:EditorTool Name="InsertTime" /><telerik:EditorTool Name="InsertHorizontalRule" /><telerik:EditorTool Name="InsertUnorderedList" /><telerik:EditorTool Name="InsertSymbol" /><telerik:EditorTool Name="Undo" /><telerik:EditorTool Name="Redo" /><telerik:EditorTool Name="Cut" /><telerik:EditorTool Name="FindAndReplace" /><telerik:EditorTool Name="ToggleScreenMode" /><telerik:EditorTool Name="Zoom" /><telerik:EditorTool Name="FontName" /><telerik:EditorTool Name="FontSize" /><telerik:EditorTool Name="Italic" /><telerik:EditorTool Name="Bold" /><telerik:EditorTool Name="StrikeThrough" /><telerik:EditorTool Name="Underline" /><telerik:EditorTool Name="ForeColor" /><telerik:EditorTool Name="BackColor" /><telerik:EditorTool Name="InsertParagraph" /><telerik:EditorTool Name="Outdent" /><telerik:EditorTool Name="JustifyCenter" /><telerik:EditorTool Name="JustifyFull" /><telerik:EditorTool Name="JustifyRight" /><telerik:EditorTool Name="PasteFromWord" /><telerik:EditorTool Name="PasteFromWordNoFontsNoSizes" /><telerik:EditorTool Name="PastePlainText" /></telerik:EditorToolGroup></Tools></telerik:RadEditor></td></tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="5">
                <strong>Analisis de posibles Fallas detectadas&nbsp; texto</strong><asp:CheckBox 
                    ID="chkAnalisisDeFallasConfidencial" runat="server" Enabled="false" 
                    Text="Confidencial" />
            </td>
        </tr>
        <tr><td>&nbsp;</td><td colspan="5">
            <asp:TextBox ID="txtAnalisisPosiblesFallasTxt" TextMode="MultiLine" Width="700" Height="150" ReadOnly="true" runat="server"></asp:TextBox>
            </td></tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="5">
                <strong>
                <br />
                Analisis de posibles Fallas detectadas imagen&nbsp; </strong>
                <br />
                <telerik:RadEditor ID="EditorPosiblesFallas" Runat="server" EditModes="Preview" 
                    Height="269px" Skin="Web20" ToolbarMode="ShowOnFocus">
                    <Modules>
                        <telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                            Visible="false" />
                        <telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                            Visible="false" />
                        <telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                            Visible="false" />
                        <telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                            Visible="false" />
                    </Modules>
                    <Tools>
                        <telerik:EditorToolGroup>
                            <telerik:EditorTool Name="InsertTable" />
                            <telerik:EditorTool Name="InsertDate" />
                            <telerik:EditorTool Name="InsertTime" />
                            <telerik:EditorTool Name="InsertHorizontalRule" />
                            <telerik:EditorTool Name="InsertUnorderedList" />
                            <telerik:EditorTool Name="InsertSymbol" />
                            <telerik:EditorTool Name="Undo" />
                            <telerik:EditorTool Name="Redo" />
                            <telerik:EditorTool Name="Cut" />
                            <telerik:EditorTool Name="FindAndReplace" />
                            <telerik:EditorTool Name="ToggleScreenMode" />
                            <telerik:EditorTool Name="Zoom" />
                            <telerik:EditorTool Name="FontName" />
                            <telerik:EditorTool Name="FontSize" />
                            <telerik:EditorTool Name="Italic" />
                            <telerik:EditorTool Name="Bold" />
                            <telerik:EditorTool Name="StrikeThrough" />
                            <telerik:EditorTool Name="Underline" />
                            <telerik:EditorTool Name="ForeColor" />
                            <telerik:EditorTool Name="BackColor" />
                            <telerik:EditorTool Name="InsertParagraph" />
                            <telerik:EditorTool Name="Outdent" />
                            <telerik:EditorTool Name="JustifyCenter" />
                            <telerik:EditorTool Name="JustifyFull" />
                            <telerik:EditorTool Name="JustifyRight" />
                            <telerik:EditorTool Name="PasteFromWord" />
                            <telerik:EditorTool Name="PasteFromWordNoFontsNoSizes" />
                            <telerik:EditorTool Name="PastePlainText" />
                        </telerik:EditorToolGroup>
                    </Tools>
                </telerik:RadEditor>
                <br />
                <strong>
                <br />
                <br />
                Antecedentes de situaciones Similares que involucran al producto</strong></td>
        </tr>
        <tr><td>&nbsp;</td><td colspan="5">
            <telerik:RadEditor 
                        ID="EditorAntecedentes" Runat="server" EditModes="Preview" 
                    Height="269px" Skin="Web20" ToolbarMode="ShowOnFocus"><Modules><telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                            Visible="false" /><telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                            Visible="false" /><telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                            Visible="false" /><telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                            Visible="false" /></Modules><Tools><telerik:EditorToolGroup><telerik:EditorTool Name="InsertTable" /><telerik:EditorTool Name="InsertDate" /><telerik:EditorTool Name="InsertTime" /><telerik:EditorTool Name="InsertHorizontalRule" /><telerik:EditorTool Name="InsertUnorderedList" /><telerik:EditorTool Name="InsertSymbol" /><telerik:EditorTool Name="Undo" /><telerik:EditorTool Name="Redo" /><telerik:EditorTool Name="Cut" /><telerik:EditorTool Name="FindAndReplace" /><telerik:EditorTool Name="ToggleScreenMode" /><telerik:EditorTool Name="Zoom" /><telerik:EditorTool Name="FontName" /><telerik:EditorTool Name="FontSize" /><telerik:EditorTool Name="Italic" /><telerik:EditorTool Name="Bold" /><telerik:EditorTool Name="StrikeThrough" /><telerik:EditorTool Name="Underline" /><telerik:EditorTool Name="ForeColor" /><telerik:EditorTool Name="BackColor" /><telerik:EditorTool Name="InsertParagraph" /><telerik:EditorTool Name="Outdent" /><telerik:EditorTool Name="JustifyCenter" /><telerik:EditorTool Name="JustifyFull" /><telerik:EditorTool Name="JustifyRight" /><telerik:EditorTool Name="PasteFromWord" /><telerik:EditorTool Name="PasteFromWordNoFontsNoSizes" /><telerik:EditorTool Name="PastePlainText" /></telerik:EditorToolGroup></Tools></telerik:RadEditor><br /><strong>
            <br />
            <br />
            Acciones Implementadas</strong></td></tr><tr><td>&nbsp;</td><td 
                        colspan="5">
            <telerik:RadEditor ID="EditorAcciones" Runat="server" 
                        EditModes="Preview" Height="269px" Skin="Web20" 
                        ToolbarMode="ShowOnFocus"><Modules><telerik:EditorModule Enabled="false" 
                                Name="RadEditorHtmlInspector" Visible="false" /><telerik:EditorModule 
                                Enabled="false" Name="RadEditorNodeInspector" Visible="false" /><telerik:EditorModule 
                                Enabled="false" Name="RadEditorDomInspector" Visible="false" /><telerik:EditorModule 
                                Enabled="false" Name="RadEditorStatistics" Visible="false" /></Modules><Tools><telerik:EditorToolGroup><telerik:EditorTool 
                                Name="InsertTable" /><telerik:EditorTool Name="InsertDate" /><telerik:EditorTool 
                                Name="InsertTime" /><telerik:EditorTool Name="InsertHorizontalRule" /><telerik:EditorTool 
                                Name="InsertUnorderedList" /><telerik:EditorTool Name="InsertSymbol" /><telerik:EditorTool 
                                Name="Undo" /><telerik:EditorTool Name="Redo" /><telerik:EditorTool 
                                Name="Cut" /><telerik:EditorTool Name="FindAndReplace" /><telerik:EditorTool 
                                Name="ToggleScreenMode" /><telerik:EditorTool Name="Zoom" /><telerik:EditorTool 
                                Name="FontName" /><telerik:EditorTool Name="FontSize" /><telerik:EditorTool 
                                Name="Italic" /><telerik:EditorTool Name="Bold" /><telerik:EditorTool 
                                Name="StrikeThrough" /><telerik:EditorTool Name="Underline" /><telerik:EditorTool 
                                Name="ForeColor" /><telerik:EditorTool Name="BackColor" /><telerik:EditorTool 
                                Name="InsertParagraph" /><telerik:EditorTool Name="Outdent" /><telerik:EditorTool 
                                Name="JustifyCenter" /><telerik:EditorTool Name="JustifyFull" /><telerik:EditorTool 
                                Name="JustifyRight" /><telerik:EditorTool Name="PasteFromWord" /><telerik:EditorTool 
                                Name="PasteFromWordNoFontsNoSizes" /><telerik:EditorTool 
                                Name="PastePlainText" /></telerik:EditorToolGroup></Tools></telerik:RadEditor></td></tr><tr><td></td><td>&nbsp;</td><td 
                        colspan="3">&nbsp;</td><td class="style2">&nbsp;</td></tr></table></telerik:RadPageView>

    <telerik:RadPageView ID="RadPageView6"  runat="server"><table><tr><td colspan="4">
        <br />
        <strong>Conclusiones texto</strong><br /> </td></tr><tr><td colspan="3">
            <asp:TextBox ID="txtconclusionestxt" runat="server" Height="150px" 
                ReadOnly="True" TextMode="MultiLine" Width="700px"></asp:TextBox>
            </td><td>&nbsp;</td></tr>
        <tr>
            <td>
                <strong>Conclusiones imagen</strong></td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <telerik:RadEditor ID="EditorConclusiones" Runat="server" EditModes="Preview" 
                    Height="269px" Skin="Web20" ToolbarMode="ShowOnFocus">
                    <Modules>
                        <telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                            Visible="false" />
                        <telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                            Visible="false" />
                        <telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                            Visible="false" />
                        <telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                            Visible="false" />
                    </Modules>
                    <Tools>
                        <telerik:EditorToolGroup>
                            <telerik:EditorTool Name="InsertTable" />
                            <telerik:EditorTool Name="InsertDate" />
                            <telerik:EditorTool Name="InsertTime" />
                            <telerik:EditorTool Name="InsertHorizontalRule" />
                            <telerik:EditorTool Name="InsertUnorderedList" />
                            <telerik:EditorTool Name="InsertSymbol" />
                            <telerik:EditorTool Name="Undo" />
                            <telerik:EditorTool Name="Redo" />
                            <telerik:EditorTool Name="Cut" />
                            <telerik:EditorTool Name="FindAndReplace" />
                            <telerik:EditorTool Name="ToggleScreenMode" />
                            <telerik:EditorTool Name="Zoom" />
                            <telerik:EditorTool Name="FontName" />
                            <telerik:EditorTool Name="FontSize" />
                            <telerik:EditorTool Name="Italic" />
                            <telerik:EditorTool Name="Bold" />
                            <telerik:EditorTool Name="StrikeThrough" />
                            <telerik:EditorTool Name="Underline" />
                            <telerik:EditorTool Name="ForeColor" />
                            <telerik:EditorTool Name="BackColor" />
                            <telerik:EditorTool Name="InsertParagraph" />
                            <telerik:EditorTool Name="Outdent" />
                            <telerik:EditorTool Name="JustifyCenter" />
                            <telerik:EditorTool Name="JustifyFull" />
                            <telerik:EditorTool Name="JustifyRight" />
                            <telerik:EditorTool Name="PasteFromWord" />
                            <telerik:EditorTool Name="PasteFromWordNoFontsNoSizes" />
                            <telerik:EditorTool Name="PastePlainText" />
                        </telerik:EditorToolGroup>
                    </Tools>
                </telerik:RadEditor>
            </td>
            <td>
            </td>
        </tr>
        <tr>
        <td colspan="3">Desempeño del producto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdDesempenoAdecuado" runat="server" Enabled="false" 
                GroupName="desempeno" Text="Adecuado" />
            &nbsp;<asp:RadioButton ID="rdDesempenoNoAdecuado" runat="server" Enabled="false" 
                GroupName="desempeno" Text="No Adecuado" />
        </td><td></td></tr><tr><td class="style4" colspan="3">Causa Identificada del desempeño
        <asp:RadioButton ID="rdMotivoIdentificadoSi" runat="server" Enabled="false" 
            GroupName="identificado" Text="Si" />
        <asp:RadioButton ID="rdIdentificadoNo" runat="server" Enabled="false" 
            GroupName="identificado" Text="No" />
        </td><td class="style4"></td></tr><tr><td colspan="4">Observaciones de la Causa del desempeño</td></tr><tr><td colspan="4"><asp:TextBox ID="txtTextoIdentificado" runat="server"  Enabled="false" Height="60px" 
                    TextMode="MultiLine" Width="600px"></asp:TextBox></td></tr><tr><td colspan="4"><hr />&nbsp;</td></tr><tr><td colspan="4"><strong>Recomendaciones</strong></td></tr><tr><td colspan="4"><asp:TextBox ID="txtRecomendaciones" runat="server"  Enabled="false" Height="60px" 
                    TextMode="MultiLine" Width="600px"></asp:TextBox></td></tr><tr><td >Concepto Cientifico Aplica Reposicion</td><td ><asp:RadioButton ID="rdSiReposicion" runat="server"  Enabled="false" GroupName="repo" 
                        Text="Si" /><asp:RadioButton ID="rdnoReposicion" runat="server"  Enabled="false" GroupName="repo" 
                        Text="No" /></td><td >&nbsp;</td><td >&nbsp;</td></tr><tr><td>Cantidad a Reponer</td><td><asp:TextBox ID="txtCantidadAReponer" runat="server" Enabled="false" ></asp:TextBox></td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td>Motivo reposicion</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td colspan="4"><asp:TextBox ID="txtMotivoReposicion" runat="server"  Enabled="false" Height="60px" 
                    TextMode="MultiLine" Width="600px"></asp:TextBox></td></tr><tr><td><strong>Disposición del producto</strong></td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td><asp:RadioButton ID="rdDispoDardeBaja" runat="server"  Enabled="false" GroupName="dispo" 
                    Text="Dar de Baja" /></td><td><asp:RadioButton ID="rdDispoDEvolucionCliente" runat="server"  Enabled="false" GroupName="dispo" 
                    Text="Devolucion al Cliente" /></td><td><asp:RadioButton ID="rdDispoDEvolucionProveedor" runat="server"  Enabled="false" 
                    GroupName="dispo" Text="Devolucion Proveedor" /></td><td>&nbsp;</td></tr><tr><td>
                    <telerik:RadDatePicker ID="calDarBaja" Runat="server"  Enabled="false" ><Calendar ID="Calendar5" runat="server"><FastNavigationSettings EnableTodayButtonSelection="True" 
                            TodayButtonCaption="Hoy"></FastNavigationSettings></Calendar></telerik:RadDatePicker></td><td>
                            <telerik:RadDatePicker ID="calDevolucionCliente" Runat="server"  Enabled="false" >
                            <Calendar ID="Calendar6" runat="server"><FastNavigationSettings EnableTodayButtonSelection="True" 
                            TodayButtonCaption="Hoy"></FastNavigationSettings></Calendar></telerik:RadDatePicker></td><td>
                            <telerik:RadDatePicker ID="calDevolucionProveedor" Runat="server"  Enabled="false" 
                    ><Calendar ID="Calendar7" runat="server"><FastNavigationSettings EnableTodayButtonSelection="True" 
                            TodayButtonCaption="Hoy"></FastNavigationSettings></Calendar></telerik:RadDatePicker></td><td>&nbsp;</td></tr></table></telerik:RadPageView>

    <telerik:RadPageView ID="RadPageViewInfoaprobacion"  runat="server" ><table><tr><td>Encargado aprobacion</td><td><asp:DropDownList ID="cmbResponsableAprobacion" runat="server" 
            DataSourceID="SqlEncargadoAprobacion" DataTextField="nombre" 
            DataValueField="cod_usuario" Enabled="False"></asp:DropDownList></td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td></td><td><asp:RadioButton ID="rdAplicaReclamo" runat="server" Enabled="false" 
                    GroupName="aplicaReclamo" Text="Aplica reclamo proveedor" /></td>
        <td colspan="2">
            <asp:RadioButton ID="rdNoAplicaReclamo" runat="server" Enabled="false" 
                GroupName="aplicaReclamo" Text="No Aplica reclamo proveedor" />
        </td></tr><tr><td>Fecha Envio Reclamo Proveedor: </td><td>
                    <telerik:RadDatePicker ID="calFEchaReclamoProveedor" runat="server" 
            Enabled="false"><Calendar ID="Calendar8" runat="server"><FastNavigationSettings EnableTodayButtonSelection="True" 
                    TodayButtonCaption="Hoy"></FastNavigationSettings></Calendar></telerik:RadDatePicker></td><td>&nbsp;</td><td></td></tr><tr><td>Reposición tramitada por: </td><td><asp:DropDownList ID="cmbTramitadoPor" runat="server" Enabled="false"  AppendDataBoundItems="True" 
        DataSourceID="SqlDataSourceusuariostramite" DataTextField="nombre" 
        DataValueField="cod_usuario"><asp:ListItem Text="--Seleccione--" Value="" /></asp:DropDownList></td><td>Respuesta Proveedor: </td><td>
        <telerik:RadDatePicker runat="server" ID="calFechaRespuestaProveedor" Enabled="false" ><Calendar ID="Calendar10" runat="server"><FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy"></FastNavigationSettings></Calendar></telerik:RadDatePicker></td></tr><tr><td>Garantía tramitada con el ID: </td><td><asp:TextBox runat="server" Enabled="false"  ID="txtIdGarantia"></asp:TextBox></td><td>Fecha Tramite</td><td>
        <telerik:RadDatePicker runat="server" Enabled="false"  ID="calFechaTramiteGarantia"><Calendar ID="Calendar9" runat="server"><FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy"></FastNavigationSettings></Calendar></telerik:RadDatePicker></td></tr><tr><td></td><td></td><td></td><td></td></tr></table></telerik:RadPageView>


    <telerik:RadPageView ID="RadPageView7"  runat="server" ><table class="style1"><tr><td><span lang="ES-CO" 
                        style="font-size: 11.0pt; line-height: 115%; font-family: &quot;Calibri&quot;,&quot;sans-serif&quot;; mso-ascii-theme-font: minor-latin; mso-fareast-font-family: Calibri; mso-fareast-theme-font: minor-latin; mso-hansi-theme-font: minor-latin; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-bidi-theme-font: minor-bidi; mso-ansi-language: ES-CO; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">Fecha de envío reporte asesor </span></td><td>
                        <telerik:RadDatePicker ID="calEnvioReporteAsesor" Runat="server"  Enabled="False">
                        <Calendar ID="Calendar12" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                        </telerik:RadDatePicker></td><td>&nbsp;</td><td><span lang="ES-CO" 
                        style="font-size: 11.0pt; line-height: 115%; font-family: &quot;Calibri&quot;,&quot;sans-serif&quot;; mso-ascii-theme-font: minor-latin; mso-fareast-font-family: Calibri; mso-fareast-theme-font: minor-latin; mso-hansi-theme-font: minor-latin; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-bidi-theme-font: minor-bidi; mso-ansi-language: ES-CO; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">Fecha envió reporte al cliente</span></td><td>
                        <telerik:RadDatePicker ID="calEnvioReporteCliente" Runat="server" 
                        Enabled="False">
                        <Calendar ID="Calendar11" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                        </telerik:RadDatePicker></td><td>&nbsp;</td></tr><tr><td colspan="5">&nbsp;</td><td>&nbsp;</td></tr><tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td><b style="mso-bidi-font-weight: normal"><span lang="ES-CO" 
                        style="font-size: 11.0pt; line-height: 115%; font-family: &quot;Calibri&quot;,&quot;sans-serif&quot;; mso-ascii-theme-font: minor-latin; mso-fareast-font-family: Calibri; mso-fareast-theme-font: minor-latin; mso-hansi-theme-font: minor-latin; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-bidi-theme-font: minor-bidi; mso-ansi-language: ES-CO; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">seguimiento posterior:</span></b></td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr><tr><td colspan="5"><telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                        CellSpacing="0" DataSourceID="SqlDataSource1" GridLines="None"><MasterTableView DataSourceID="SqlDataSource1"><CommandItemSettings ExportToPdfText="Export to PDF" /><RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                                Visible="True"><HeaderStyle Width="20px" /></RowIndicatorColumn><ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                                Visible="True"><HeaderStyle Width="20px" /></ExpandCollapseColumn><Columns><telerik:GridBoundColumn DataField="observaciones" 
                                    FilterControlAltText="Filter observaciones column" HeaderText="Observacion" 
                                    SortExpression="observaciones" UniqueName="observaciones"><HeaderStyle Width="400px" /></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="nombre" 
                                    FilterControlAltText="Filter nombre column" HeaderText="Observacion Por" 
                                    SortExpression="nombre" UniqueName="nombre"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="fecha_observacion" 
                                    DataType="System.DateTime" 
                                    FilterControlAltText="Filter fecha_observacion column" 
                                    HeaderText="Fecha observacion" SortExpression="fecha_observacion" 
                                    UniqueName="fecha_observacion"></telerik:GridBoundColumn></Columns><EditFormSettings><EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn></EditFormSettings></MasterTableView><FilterMenu EnableImageSprites="False"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></FilterMenu><HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></HeaderContextMenu></telerik:RadGrid><asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT 
observaciones,
usuario.nombre,fecha_observacion
FROM observicionesxseguimiento_control_calidad INNER JOIN usuario ON observicionesxseguimiento_control_calidad.observacion_por = usuario.cod_usuario
where 
cod_control_calidad=@cod_control_calidad"><SelectParameters><asp:QueryStringParameter Name="cod_control_calidad" QueryStringField="cod" /></SelectParameters></asp:SqlDataSource></td><td>&nbsp;</td></tr><tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr></table></telerik:RadPageView>
        <telerik:RadPageView ID="RadPageView8"  runat="server" ><asp:Button ID="btnAgregarArchivo" runat="server" Text="Agregar Archivo" 
                onclick="btnAgregarArchivo_Click" /><br /><telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
                CellSpacing="0" DataSourceID="SqlArchivos" GridLines="None"><MasterTableView DataKeyNames="cod_archivos_control_calidad" 
                    DataSourceID="SqlArchivos"><CommandItemSettings ExportToPdfText="Export to PDF" /><RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                        Visible="True"><HeaderStyle Width="20px" /></RowIndicatorColumn><ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                        Visible="True"><HeaderStyle Width="20px" /></ExpandCollapseColumn><Columns><telerik:GridBoundColumn DataField="cod_archivos_control_calidad" 
                            DataType="System.Int32" 
                            FilterControlAltText="Filter cod_archivos_control_calidad column" 
                            HeaderText="cod_archivos_control_calidad" ReadOnly="True" 
                            SortExpression="cod_archivos_control_calidad" 
                            UniqueName="cod_archivos_control_calidad" Visible="False"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="tipo" 
                            FilterControlAltText="Filter tipo column" HeaderText="Tipo" 
                            SortExpression="tipo" UniqueName="tipo"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="fecha_subida" DataType="System.DateTime" 
                            FilterControlAltText="Filter fecha_subida column" HeaderText="Fecha subida" 
                            SortExpression="fecha_subida" UniqueName="fecha_subida"></telerik:GridBoundColumn><telerik:GridBoundColumn DataField="fecha_manual" DataType="System.DateTime" 
                            FilterControlAltText="Filter fecha_manual column" HeaderText="Fecha Manual" 
                            SortExpression="fecha_manual" UniqueName="fecha_manual"></telerik:GridBoundColumn><telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
                            HeaderText="Opciones" UniqueName="TemplateColumn"><ItemTemplate><asp:Button runat="server" Text="Ver Archivo" CommandArgument='<%# Eval("cod_archivos_control_calidad") %>' OnClick="btnVerArchivo" /></ItemTemplate></telerik:GridTemplateColumn></Columns><EditFormSettings><EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn></EditFormSettings></MasterTableView><FilterMenu EnableImageSprites="False"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></FilterMenu><HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></HeaderContextMenu></telerik:RadGrid></telerik:RadPageView>
    </telerik:RadMultiPage>

    <br />
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    <br />
   
    &nbsp;<asp:SqlDataSource ID="SqlCalibracionCalidad" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_calibracion_calidad], [calibracion_calidad] FROM [calibracion_calidad]
where activo = 1 order by calibracion_calidad"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlModeloUtilizado" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [codModelo], [NombreModelo] FROM [Modelos] WHERE ([codFabricante] = @codFabricante) ORDER BY [NombreModelo]">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbFabricanteModeloutilizado" 
                Name="codFabricante" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlArchivos" runat="server" 
                ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                
                
        SelectCommand="SELECT [cod_archivos_control_calidad], [tipo], [fecha_subida], [fecha_manual] FROM [archivos_control_calidad] WHERE ([cod_control_calidad] = @cod_control_calidad)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="cod_control_calidad" QueryStringField="cod" 
                        Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlFabricanteusado" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [codFabricante], [nombre_fabricante] FROM [fabricante] ORDER BY [nombre_fabricante]">
    </asp:SqlDataSource>
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
    <asp:SqlDataSource ID="SqlrevisonEstadoProducto" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_revision_estado_producto], [descripcion] FROM [revision_estado_producto] where activo =1 
order by descripcion"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlControles" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_controles_calidad], [controles_calidad] FROM [controles_calidad] WHERE ([activo] = @activo) ORDER BY [cod_controles_calidad]">
        <SelectParameters>
            <asp:Parameter DefaultValue="true" Name="activo" Type="Boolean" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceFabricante" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [codFabricante], [nombre_fabricante] FROM [fabricante] ORDER BY [nombre_fabricante]">
    </asp:SqlDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="getDataByGrupo" 
        TypeName="SPXSeguridad.data.cls.clsTusuario">
        <SelectParameters>
            <asp:Parameter DefaultValue="11" Name="cod_grupo_usuario" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlDataSourceUsuarios" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSourceReactivo" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_referencia_reactivo], [nombre_referencia_reactivo] FROM [referencia_reactivo] WHERE ([codFabricante] = @codFabricante) ORDER BY [nombre_referencia_reactivo]">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbFabricante" Name="codFabricante" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>








</asp:Content>





<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCerrarControl.aspx.cs" Inherits="frm_controlcalidad_frmCerrarControl" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

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
<div class="tab">Cerrar control de calidad    </div>



<telerik:RadTabStrip ID="RadTabStrip2" runat="server" MultiPageID="radMultiSeguimiento" SelectedIndex="0">
        <Tabs>
            <telerik:RadTab runat="server" Text="Informacion Cierre" Selected="True">
            </telerik:RadTab>
             <telerik:RadTab runat="server" Text="Informacion Adicional" >
            </telerik:RadTab>
    
        </Tabs>
    </telerik:RadTabStrip>
    <telerik:RadMultiPage ID="radMultiSeguimiento" runat="server" SelectedIndex="0">
    <telerik:RadPageView ID="RadPageView1"  runat="server" >
        <table class="style1">
            <tr>
                <td>
                    <span lang="ES-CO" 
                        style="font-size: 11.0pt; line-height: 115%; font-family: &quot;Calibri&quot;,&quot;sans-serif&quot;; mso-ascii-theme-font: minor-latin; mso-fareast-font-family: Calibri; mso-fareast-theme-font: minor-latin; mso-hansi-theme-font: minor-latin; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-bidi-theme-font: minor-bidi; mso-ansi-language: ES-CO; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Fecha de envío reporte asesor </span>
                </td>
                <td>
                    <telerik:RadDatePicker ID="calEnvioReporteAsesor" Runat="server">
                    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                    </telerik:RadDatePicker>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <span lang="ES-CO" 
                        style="font-size: 11.0pt; line-height: 115%; font-family: &quot;Calibri&quot;,&quot;sans-serif&quot;; mso-ascii-theme-font: minor-latin; mso-fareast-font-family: Calibri; mso-fareast-theme-font: minor-latin; mso-hansi-theme-font: minor-latin; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-bidi-theme-font: minor-bidi; mso-ansi-language: ES-CO; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    Fecha envió reporte al cliente</span></td>
                <td>
                    <telerik:RadDatePicker ID="calEnvioReporteCliente" Runat="server">
                    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                    </telerik:RadDatePicker>
                </td>
                <td>
                    &nbsp;</td>
            </tr>

        </table>
        </telerik:RadPageView>

         <telerik:RadPageView ID="RadPageView2"  runat="server" >
         <div class="Formulario">
             <table>
    <tr>
    <td>   &nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
        <td>
            &nbsp;</td>
    <td>&nbsp;</td>
    </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:RadioButton ID="rdAplicaReclamo" runat="server" GroupName="aplicaReclamo" 
                    Text="Aplica reclamo proveedor" />
            </td>
            <td colspan="3">
                <asp:RadioButton ID="rdNoAplicaReclamo" runat="server" 
                    GroupName="aplicaReclamo" Text="No Aplica reclamo proveedor" />
            </td>
        </tr>
    <tr>
    <td>Fecha Envio Reclamo Proveedor:   </td>
    <td>  
        <telerik:RadDatePicker ID="calFEchaReclamoProveedor" runat="server">
            <Calendar ID="Calendar8" runat="server">
                <FastNavigationSettings EnableTodayButtonSelection="True" 
                    TodayButtonCaption="Hoy">
                </FastNavigationSettings>
            </Calendar>
        </telerik:RadDatePicker>
        </td>
    <td>&nbsp;</td>
        <td>
            &nbsp;</td>
    <td></td>
    </tr>
    <tr>
    <td>	Reposición tramitada por:     </td>
    <td>
    <asp:DropDownList ID="cmbTramitadoPor" runat="server" AppendDataBoundItems="True" 
        DataSourceID="SqlDataSourceusuariostramite" DataTextField="nombre" 
        DataValueField="cod_usuario">
    <asp:ListItem Text="--Seleccione--" Value="" />   
</asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSourceusuariostramite" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [nombre], [cod_usuario] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource></td>
    <td> 
    Respuesta Proveedor:
      </td>
        <td>
            &nbsp;</td>
    <td>
    <telerik:RadDatePicker runat="server" ID="calFechaRespuestaProveedor">
     <Calendar ID="Calendar10" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
    </Calendar>
    </telerik:RadDatePicker>
    </td>
    </tr>
    <tr>
    <td>Garantía tramitada con el ID:   </td>
    <td> <asp:TextBox runat="server" ID="txtIdGarantia"></asp:TextBox>  </td>
    <td>Fecha Tramite</td>
        <td>
            &nbsp;</td>
    <td><telerik:RadDatePicker runat="server" ID="calFechaTramiteGarantia">
     <Calendar ID="Calendar9" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
    </Calendar>
    </telerik:RadDatePicker></td>
    </tr>
    <tr>
    <td colspan="5">   <strong>Disposición del producto</strong></td>
    </tr>
    <tr>
    <td>   
        <asp:RadioButton ID="rdDispoDardeBaja" runat="server" GroupName="dispo" 
            Text="Dar de Baja" />
        </td>
    <td>
        <asp:RadioButton ID="rdDispoDEvolucionCliente" runat="server" GroupName="dispo" 
            Text="Devolucion al Cliente" />
        </td>
    <td colspan="3">
        <asp:RadioButton ID="rdDispoDEvolucionProveedor" runat="server" 
            GroupName="dispo" Text="Devolucion Proveedor" />
        </td>
    </tr>

    <tr>
    <td>   
        <telerik:RadDatePicker ID="calDarBaja" Runat="server">
            <calendar ID="Calendar5" runat="server">
                <fastnavigationsettings enabletodaybuttonselection="True" 
                    todaybuttoncaption="Hoy">
                </fastnavigationsettings>
            </calendar>
        </telerik:RadDatePicker>
        </td>
    <td>
        <telerik:RadDatePicker ID="calDevolucionCliente" Runat="server">
            <calendar ID="Calendar6" runat="server">
                <fastnavigationsettings enabletodaybuttonselection="True" 
                    todaybuttoncaption="Hoy">
                </fastnavigationsettings>
            </calendar>
        </telerik:RadDatePicker>
        </td>
    <td>
        <telerik:RadDatePicker ID="calDevolucionProveedor" Runat="server">
            <calendar ID="Calendar7" runat="server">
                <fastnavigationsettings enabletodaybuttonselection="True" 
                    todaybuttoncaption="Hoy">
                </fastnavigationsettings>
            </calendar>
        </telerik:RadDatePicker>
        </td>
        <td>
            &nbsp;</td>
    <td>
    <asp:Label runat="server" ID="lblw" Width="50px"></asp:Label>
    </td>
    </tr>

    <tr>
    <td>   </td>
    <td></td>
    <td></td>
        <td>
            &nbsp;</td>
    <td></td>
    </tr>
    </table>
    </div>
         </telerik:RadPageView>
    </telerik:RadMultiPage>
    <br />
    <table>    
     
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
           <tr>
                <td>
                    <asp:Button ID="btnCerrar" runat="server" onclick="btnCerrar_Click" 
                        Text="Cerrar" />
                    <asp:Button ID="btnGuardar" runat="server" onclick="btnAceptar_Click" 
                        Text="Guardar" />
                    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
                        Text="volver" />
                </td>
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
                    <b style="mso-bidi-font-weight: normal"><span lang="ES-CO" 
                        style="font-size: 11.0pt; line-height: 115%; font-family: &quot;Calibri&quot;,&quot;sans-serif&quot;; mso-ascii-theme-font: minor-latin; mso-fareast-font-family: Calibri; mso-fareast-theme-font: minor-latin; mso-hansi-theme-font: minor-latin; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-bidi-theme-font: minor-bidi; mso-ansi-language: ES-CO; mso-fareast-language: EN-US; mso-bidi-language: AR-SA">
                    seguimiento posterior:</span></b></td>
                <td>
                
                    <asp:Button ID="btnAgregarSeguimiento" runat="server" 
                        onclick="btnAgregarSeguimiento_Click" Text="Agregar Seguimiento" />
                </td>
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
                <td colspan="5">
                    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
                        CellSpacing="0" DataSourceID="SqlDataSource1" GridLines="None">
                        <MasterTableView DataSourceID="SqlDataSource1">
                            <CommandItemSettings ExportToPdfText="Export to PDF" />
                            <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column" 
                                Visible="True">
                                <HeaderStyle Width="20px" />
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column" 
                                Visible="True">
                                <HeaderStyle Width="20px" />
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="observaciones" 
                                    FilterControlAltText="Filter observaciones column" HeaderText="Observacion" 
                                    SortExpression="observaciones" UniqueName="observaciones">
                                    <HeaderStyle Width="400px" />
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="nombre" 
                                    FilterControlAltText="Filter nombre column" HeaderText="Observacion Por" 
                                    SortExpression="nombre" UniqueName="nombre">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="fecha_observacion" 
                                    DataType="System.DateTime" 
                                    FilterControlAltText="Filter fecha_observacion column" 
                                    HeaderText="Fecha observacion" SortExpression="fecha_observacion" 
                                    UniqueName="fecha_observacion">
                                </telerik:GridBoundColumn>
                            </Columns>
                            <EditFormSettings>
                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                </EditColumn>
                            </EditFormSettings>
                        </MasterTableView>
                        <FilterMenu EnableImageSprites="False">
                            <WebServiceSettings>
                                <ODataSettings InitialContainerName="">
                                </ODataSettings>
                            </WebServiceSettings>
                        </FilterMenu>
                        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
                            <WebServiceSettings>
                                <ODataSettings InitialContainerName="">
                                </ODataSettings>
                            </WebServiceSettings>
                        </HeaderContextMenu>
                    </telerik:RadGrid>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT 
observaciones,
usuario.nombre,fecha_observacion
FROM observicionesxseguimiento_control_calidad INNER JOIN usuario ON observicionesxseguimiento_control_calidad.observacion_por = usuario.cod_usuario
where 
cod_control_calidad=@cod_control_calidad">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="cod_control_calidad" QueryStringField="cod" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
    </table>
    </asp:Content>


﻿<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmEjecutarControl.aspx.cs" Inherits="frm_controlcalidad_frmEjecutarControl" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc1" %>
<%@ Register src="../../controles/controlLlamadas.ascx" tagname="controlLlamadas" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />  

    <style type="text/css">
        .style1
        {
            width: 785px;
        }
        .style2
        {
            width: 781px;
        }
        .style3
        {
            width: 776px;
        }
        .style4
        {
            height: 26px;
        }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <br /><asp:Button ID="btnCliente"   runat="server" onclick="btnCliente_Click" 
    style="visibility:hidden; " Text="Cargar" Width="0px" />
<div class="tab">Ejecutar Control Calidad
    &nbsp;</div>
<div class="Formulario">


 <telerik:RadTabStrip ID="RadTabStrip2" runat="server" 
        MultiPageID="radMultiGeneral" SelectedIndex="0">
        <Tabs>
            <telerik:RadTab runat="server" Text="Informacion General" Selected="True">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Procedimientos Cientifica">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Conclusiones">
            </telerik:RadTab>
               <telerik:RadTab runat="server" Text="Archivos">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
 <telerik:RadMultiPage ID="radMultiGeneral" runat="server" SelectedIndex="0">
    <telerik:RadPageView  runat="server" >
        <table>        
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
                <td colspan="3">              
                    &nbsp;</td>              
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    <asp:RadioButton ID="rdRealizadoAnnar" runat="server" GroupName="realizado" 
                        Text="Realizado en Annar" Width="150px" />
                </td>
                <td colspan="3">
                    &nbsp;<asp:RadioButton ID="rdRealizadoCliente" runat="server" GroupName="realizado" 
                        Text="Realizado en instalaciones de cliente" Width="260px" />
                    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;</td>
            </tr>
            <tr>                
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    Consecutivo:&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblCodControlCalidad" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp; </td>
                
                <td colspan="3">
&nbsp;&nbsp;&nbsp; Asignado a&nbsp;
&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="cmbAsignadoA" runat="server" 
                        DataSourceID="ObjectDataSource1" DataTextField="nombre" 
                        DataValueField="cod_usuario">

                    </asp:DropDownList>
                    
                    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;</td>                
                
            </tr>
            <tr>               
                <td colspan="6" >
                    <hr />
                    </td>    
                </tr>
                <tr>
                    <td colspan="6">
                        
&nbsp;&nbsp;&nbsp;
                        <telerik:RadTabStrip ID="RadTabStrip1" runat="server" 
                            MultiPageID="RadMultiPage2" SelectedIndex="1">
        <tabs>
            <telerik:RadTab runat="server" Text="Llamada">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Selected="True" Text="Cliente Interno">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Cliente Externo">
            </telerik:RadTab>
        </tabs>
    </telerik:RadTabStrip>
    <telerik:RadMultiPage ID="RadMultiPage2" Runat="server" SelectedIndex="1"  Width="52px">
        <telerik:RadPageView ID="RadPageView1" runat="server">
             &nbsp;<table>
                                    <tr>
                                        <td>
                                            Llamada:</td>
                    
                                           
                                                <td class="style3">
                                                    <uc2:controlLlamadas ID="controlLlamadas1" runat="server" />
                                                </td>
                    
                                           
                                                        <td>
                                                            &nbsp;</td>
                    
                                                            
                                                                <td class="style1">
                                                                    &nbsp;</td>
                                                                    
                                                                        <td class="style2">
                                                                            &nbsp;</td>
                        
                            </tr>                        
                                    <tr>
                                        <td>
                                            Cliente
                                        </td>
                                        <td class="style3">
                                            <asp:TextBox ID="txtClienteLlamada" runat="server" ReadOnly="true" 
                                                Width="200px"></asp:TextBox>
                                        </td>
                                        <td>
                                            Socio de Negocio</td>
                                        <td class="style1">
                                            <asp:TextBox ID="txtSocioNegocioLlamada" runat="server" ReadOnly="True" 
                                                Width="200px"></asp:TextBox>
                                        </td>
                                        <td class="style2">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Sucursal</td>
                                        <td class="style3">
                                            <asp:DropDownList ID="cmbSucursalLlamada" runat="server" Enabled="false">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            Contacto</td>
                                        <td class="style1">
                                            <asp:DropDownList ID="cmbContactoLlamada" runat="server" Enabled="false">
                                            </asp:DropDownList>
                                        </td>
                                        <td class="style2">
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Telefono</td>
                                        <td class="style3">
                                        <asp:TextBox runat="server" ID="txtTelefonoContacto" ReadOnly="true"></asp:TextBox>
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
        <telerik:RadPageView ID="RadPageView2" runat="server">
        <asp:Panel Width="400px" runat="server">
             Cliente Interno :            <asp:TextBox ID="txtClienteInterno" runat="server"></asp:TextBox>
             </asp:Panel>
        </telerik:RadPageView>
        <telerik:RadPageView ID="RadPageView3" runat="server">
            
            <table>
                <tr>
                    <td>
                        </td>
                    
                    <td>
                        Cliente
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="txtCliente" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td> Socio de Negocio</td>
                    <td class="style1">
                        <asp:TextBox ID="txtSocioNegocio" runat="server" ReadOnly="True" Width="200px"></asp:TextBox>
                        
                    </td>
                    <td class="style2">
                        </td>
                </tr>
                <tr>
                    <td>
                        </td>
                    <td>
                        
                       
                        <asp:Label ID="lblSucursal" runat="server" Text="Sucursal"></asp:Label>
                        
                        
                        
                           
                   
                    </td>
                    <td class="style3">
                        
                        
                        
                           
                       
                        <asp:DropDownList ID="cmbSucursal" runat="server">
                        </asp:DropDownList>
                        
                        
                        
                           
                   
                    </td>
                    <td>
                        
                        
                        
                           
                       
                        <asp:Label ID="lblContacto" runat="server" Text="Contacto"></asp:Label>
                        
                        
                        
                           
                   
                    </td>
                    <td class="style1">
                        
                        
                        
                           
                       
                        <asp:DropDownList ID="cmbContacto" runat="server">
                        </asp:DropDownList>
                        
                        
                        
                           
                   
                    </td>
                    <td class="style2">
                        
                        
                        
                             </td>
                </tr>
            </table>
            

        </telerik:RadPageView>

    </telerik:RadMultiPage>
                        <hr />
                    </td>    
                </tr>
             
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="lbl2a" runat="server" Text="Casa Comercial:" Width="150px"></asp:Label>
                    </td>
                    <td align="left" valign="bottom">
                        <asp:DropDownList ID="cmbFabricante" runat="server" AutoPostBack="True" 
                            DataSourceID="SqlDataSourceFabricante" DataTextField="nombre_fabricante" 
                            DataValueField="codFabricante">
                        </asp:DropDownList>
                    </td>
                    <td style="text-align: right">
                        
                        <asp:Label ID="lbl1" runat="server" Text="Producto" Width="90px" 
                            style="text-align: right"></asp:Label>
                    </td>
                    <td align="left" colspan="2" valign="bottom">
                        <asp:DropDownList ID="cmbReactivo" runat="server" 
                            DataSourceID="SqlDataSourceReactivo" DataTextField="nombre_referencia_reactivo" 
                            DataValueField="cod_referencia_reactivo">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
            </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        Fecha De Vencimiento</td>
                    <td align="left" valign="bottom">
                        <telerik:RadDatePicker ID="calVencimiento" Runat="server">
                            <calendar ID="Calendar1" runat="server">
                                <fastnavigationsettings enabletodaybuttonselection="True" 
                                    todaybuttoncaption="Hoy">
                                </fastnavigationsettings>
                            </calendar>
                        </telerik:RadDatePicker>
                    </td>
                    <td style="text-align: right">
                        Lote</td>
                    <td align="left" colspan="2" valign="bottom">
                        <asp:TextBox ID="txtNumeroLote" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
            </tr>

                <tr>
                    
                    <td>
                        &nbsp;</td>
                    
                    <td>
                        
 Cantidad Recibido</td>
                    
                    <td colspan="3">
                        
                        <asp:TextBox ID="txtCantidadRecibido" runat="server" Width="150px"></asp:TextBox>
                        

                    </td>
                    
                    <td></td>
                    
                </tr>
                  
                <tr>
                    <td colspan="7">
                        <hr />
                        &nbsp;</td>
                </tr>

            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    No de Factura</td>
                <td align="left" valign="bottom">
                    <asp:TextBox ID="txtFactura" runat="server"></asp:TextBox>
                </td>
                <td style="text-align: right">
                <asp:Label runat="server" ID="lbl3" Text="Fecha de Factura" Width="190px" 
                        style="text-align: right"></asp:Label>
                    </td>
                     <td>
                         <telerik:RadDatePicker ID="calFactura" Runat="server">
                             <calendar ID="Calendar2" runat="server">
                                 <fastnavigationsettings enabletodaybuttonselection="True" 
                                     todaybuttoncaption="Hoy">
                                 </fastnavigationsettings>
                             </calendar>
                         </telerik:RadDatePicker>
                </td>
                     <td>
                    &nbsp;</td>
                     <td>
                    &nbsp;</td>
                
            </tr>
              <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="lblLle" runat="server" Text="Fecha Llegada del producto" 
                        Width="200px"></asp:Label>
                  </td>
                <td align="left" valign="bottom">
                    <telerik:RadDatePicker ID="calLlegadaProducto" Runat="server">
                        <Calendar ID="Calendar8" runat="server">
                            <FastNavigationSettings EnableTodayButtonSelection="True" 
                                TodayButtonCaption="Hoy">
                            </FastNavigationSettings>
                        </Calendar>
                    </telerik:RadDatePicker>
                  </td>
                <td style="text-align: right">
                    Fecha Apertura del Producto</td>
                     <td>
                         <telerik:RadDatePicker ID="calAperturaProducto" Runat="server">
                             <calendar ID="Calendar3" runat="server">
                                 <fastnavigationsettings enabletodaybuttonselection="True" 
                                     todaybuttoncaption="Hoy">
                                 </fastnavigationsettings>
                             </calendar>
                         </telerik:RadDatePicker>
                  </td>
                     <td>
                    &nbsp;</td>
                     <td>
                    &nbsp;</td>
                
            </tr>
              <tr>
                <td>
                    &nbsp;</td>
                <td>
                    Fecha Inconveniente</td>
                <td align="left" valign="bottom">
                    <telerik:RadDatePicker ID="calIncoveniente" Runat="server">
                        <calendar ID="Calendar4" runat="server">
                            <fastnavigationsettings enabletodaybuttonselection="True" 
                                todaybuttoncaption="Hoy">
                            </fastnavigationsettings>
                        </calendar>
                    </telerik:RadDatePicker>
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
                    
                    <td>
                        &nbsp;</td>
                    
                    <td>
                        <br />
                        Motivo&nbsp; de la solicitud</td>
                    
                    <td colspan="5">
                        
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td colspan="5">
                        <asp:TextBox ID="txtMotivo" runat="server" Height="80px" MaxLength="500" 
                            TextMode="MultiLine" Width="552px"></asp:TextBox>
                    </td>
            </tr>
                <tr>
                    
                    <td>
                        &nbsp;</td>
                    
                    <td>
                        &nbsp;</td>
                    
                    <td colspan="4">
                        
                        &nbsp;</td>
                    
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td colspan="5">
                        <strong>Resultados Previos del cliente Texto </strong>
                    </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="5">
                    <asp:TextBox ID="txtResultadosPreviosTxt" runat="server" Height="150px" 
                        TextMode="MultiLine" Width="700px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <br />
                    <strong>Resultados Previos del cliente imagen</strong></td>
                <td colspan="4">
                    &nbsp;</td>
            </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td colspan="5">
                        &nbsp;&nbsp;&nbsp;
                        <telerik:RadEditor ID="EditorResultadosPrevios" Runat="server" 
                            EditModes="Design" Height="269px" Skin="Web20" ToolbarMode="ShowOnFocus">
                            <modules>
                                <telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                                    Visible="false" />
                            </modules>
                            <tools>
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
                                    <telerik:EditorTool Name="ImageManager" />
                                </telerik:EditorToolGroup>
                            </tools>
                        </telerik:RadEditor>
                        &nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
                <tr>
                    
                    <td colspan="6">
                        <hr />
                    </td>
                    
                </tr>
            </table>
    </telerik:RadPageView>
    <telerik:RadPageView  runat="server">
        <table>
                <tr>
                    <td colspan="5">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="5">
                        <strong>Procedimientos Realizados por asesoria cientifica</strong></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label3" runat="server" 
                            Text="Revisión estado físico del producto" Width="266px"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:TextBox ID="txtRevisionEstadoProducto" runat="server" 
                            TextMode="MultiLine" Width="300px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        Calibracion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="cmbCalibracion" runat="server" 
                            AppendDataBoundItems="true" DataSourceID="SqlCalibracionCalidad" 
                            DataTextField="calibracion_calidad" DataValueField="cod_calibracion_calidad">
                            <asp:ListItem Text="--Seleccione--" Value="" />
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <br />
                        Procesamientos de Muestras&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="rdSiProcesamientoMuestras" runat="server" GroupName="pmm" 
                            Text="Si" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="rdProcesamientoMuestrasNo" runat="server" GroupName="pmm" 
                            Text="No" />
                        &nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        &nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;
                    </td>
                    <td>
                        &nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <br />
                        Numero de Muestras&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtNumeroMuestras" runat="server" Width="283px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" valign="top">
                                        <br />
                                        Controles utilizados&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:TextBox ID="txtControles" runat="server" TextMode="MultiLine" 
                                            Width="300px"></asp:TextBox>
                                        </td>
                    <td>
                                                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                                                                        &nbsp;</td>
                </tr>                   
                <tr>
                    <td colspan="2">
                        Dispositivo Medico Utilizado<telerik:RadAjaxPanel ID="RadAjaxPanel1" 
                            runat="server" height="40px" width="465px">
                            <asp:DropDownList ID="cmbFabricanteModeloutilizado" runat="server" 
                                AppendDataBoundItems="true" AutoPostBack="True" 
                                DataSourceID="SqlFabricanteusado" DataTextField="nombre_fabricante" 
                                DataValueField="codFabricante" Width="150px">
                                <asp:ListItem Text="--Seleccione--" Value="" />
                            </asp:DropDownList>
                            <asp:DropDownList ID="cmbModeloUtilizado" runat="server" 
                                DataSourceID="SqlModeloUtilizado" DataTextField="NombreModelo" 
                                DataValueField="codModelo" Width="180px">
                            </asp:DropDownList>
                        </telerik:RadAjaxPanel>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbl2" runat="server" Text="Serial del Dispositivo Médico" 
                            Width="200px"></asp:Label>
                        <asp:TextBox ID="txtComparacionResultados" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                        <td colspan="5">
                            <hr /> </td>
                    </tr>
                <tr>
                            <td colspan="5">
                                <strong>Resultados del control de calidad Texto &nbsp;</strong></td>
                        </tr>
                <tr>
                    <td colspan="5">
                        <asp:TextBox ID="txtResultadosTxt" runat="server" Height="150px" 
                            TextMode="MultiLine" Width="700px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <strong>Resultados del control de calidad imagen</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <telerik:RadEditor ID="EditorResultados" Runat="server" EditModes="Design" 
                            Height="269px" Skin="Web20" ToolbarMode="ShowOnFocus">
                            <modules>
                                <telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                                    Visible="false" />
                            </modules>
                            <tools>
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
                                    <telerik:EditorTool Name="ImageManager" />
                                </telerik:EditorToolGroup>
                            </tools>
                        </telerik:RadEditor>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                                    <td colspan="5">
                                        <strong>Analisis de posibles Fallas detectadas texto
                                        <asp:CheckBox ID="chkAnalisisDeFallasConfidencial" runat="server" 
                                            Text="Confidencial" />
                                        </strong>
                                        
                                        </td>
                        </tr>
                <tr>
                    <td colspan="5">
                        <asp:TextBox ID="txtAnalisisPosiblesFallasTxt" runat="server" Height="150" 
                            TextMode="MultiLine" Width="700"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                        <strong>Analisis de posibles Fallas detectadas imagen&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <telerik:RadEditor ID="EditorPosiblesFallas" Runat="server" EditModes="Design" 
                            Height="269px" Skin="Web20" ToolbarMode="ShowOnFocus">
                            <modules>
                                <telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                                    Visible="false" />
                                <telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                                    Visible="false" />
                            </modules>
                            <tools>
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
                                    <telerik:EditorTool Name="ImageManager" />
                                </telerik:EditorToolGroup>
                            </tools>
                        </telerik:RadEditor>
                    </td>
                </tr>
                <tr>
                                            <td colspan="5">
                                                &nbsp;<strong><br /> Antecedentes de situaciones Similares que involucran al producto</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                              <br>
                                              <asp:TextBox ID="EditorAntecedentes" 
                                              heigth="150px" Width="700px" TextMode="MultiLine"
                                              Runat="server" Height="150px"></asp:TextBox>
                                                
                                                </td>
                                        </tr>
                <tr>
                                            
                                                <td colspan="5">
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> <strong>Acciones Implementadas</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                    <br>
                                                      <asp:TextBox ID="EditorAcciones" 
                                              heigth="150px" Width="700px" TextMode="MultiLine"
                                              Runat="server" Height="150px"></asp:TextBox>
                                                    
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                </td>
                                            </tr>
                <tr>
                                    <td>
                                        &nbsp;&nbsp;&nbsp; &nbsp;</td>
                                    <td colspan="3">
                                        &nbsp;&nbsp;&nbsp; &nbsp;</td>
                                    <td class="style2">
                                        &nbsp;&nbsp;&nbsp; &nbsp;</td>
                                </tr>
        </table>
    </telerik:RadPageView>
    <telerik:RadPageView  runat="server">
        <table>
            <tr>
                <td colspan="4">
                    <strong>Conclusiones texto</strong></td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:TextBox ID="txtconclusionestxt" runat="server" Height="150px" 
                        TextMode="MultiLine" Width="700px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <strong>
                    <br />
                    Conclusiones imagen</strong><br />
                    <telerik:RadEditor ID="EditorConclusiones" Runat="server" EditModes="Design" 
                        Height="269px" Skin="Web20" ToolbarMode="ShowOnFocus">
                        <modules>
                            <telerik:EditorModule Enabled="false" Name="RadEditorHtmlInspector" 
                                Visible="false" />
                            <telerik:EditorModule Enabled="false" Name="RadEditorNodeInspector" 
                                Visible="false" />
                            <telerik:EditorModule Enabled="false" Name="RadEditorDomInspector" 
                                Visible="false" />
                            <telerik:EditorModule Enabled="false" Name="RadEditorStatistics" 
                                Visible="false" />
                        </modules>
                        <tools>
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
                                <telerik:EditorTool Name="ImageManager" />
                            </telerik:EditorToolGroup>
                        </tools>
                    </telerik:RadEditor>
                </td>
            </tr>
            <tr>
            
                <td>
                </td>
            
                <td>
                </td>
            
                <td>
                </td>
            
                <td>
                </td>
            
            </tr>
            <tr>
                    <td>
                    Desempeño del producto
                    </td>
                    <td>
                            <asp:RadioButton ID="rdDesempenoAdecuado" runat="server" GroupName="desempeno" 
                                Text="Adecuado" />
                            &nbsp;
                            <asp:RadioButton ID="rdDesempenoNoAdecuado" runat="server" 
                                GroupName="desempeno" Text="No Adecuado" />
                    </td>
                    <td>
                        &nbsp;</td>

                    <td>
                    </td>
            </tr>
           
            <tr>
                    <td class="style4">
                        Causa Identificada del desempeño
                        </td>
                        <td class="style4">
                            <asp:RadioButton ID="rdMotivoIdentificadoSi" runat="server" 
                                GroupName="identificado" Text="Si" />
                         
                            &nbsp;<asp:RadioButton ID="rdIdentificadoNo" runat="server" GroupName="identificado" 
                                Text="No" />
                         
                        </td>
                           <td class="style4">
                                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </td>

                                <td>

                                </td>
             </tr>

                <tr>
                    <td colspan="4">
                        Observaciones de la Causa del desempeño
                        </td>
                </tr>
            <tr>
                <td colspan="4">
                 <asp:TextBox ID="txtTextoIdentificado" runat="server" Height="60px" 
                        TextMode="MultiLine" Width="600px"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>  
                <td colspan="4">
                    
                    <hr />
                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                
            </tr>
            <tr>
                <td colspan="4">
                    
                    <strong>
                    Recomendaciones</strong></td>
            </tr>
            <tr>
                <td colspan="4">
                    
                    &nbsp;<asp:TextBox ID="txtRecomendaciones" runat="server" Height="60px" 
                        TextMode="MultiLine" Width="600px"></asp:TextBox>
                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    
                    Concepto Cientifico Aplica Reposicion&nbsp;&nbsp;<asp:RadioButton ID="rdSiReposicion" 
                        runat="server" GroupName="repo" Text="Si" />
                    &nbsp;
                    <asp:RadioButton ID="rdnoReposicion" runat="server" GroupName="repo" 
                        Text="No" />
                </td>
                <td>
                    
                    &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                
            </tr>
            <tr>
                <td>
                    
                    Cantidad a Reponer</td>
                <td>
                    
                    &nbsp;<asp:TextBox ID="txtCantidadAReponer" runat="server"></asp:TextBox>
                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                <td>
                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            </tr>
           
                <tr>
                    <td>
                        &nbsp;Motivo reposicion
                     </td>
                     <td>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                     </td>
                     <td>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                        </td>
                                        <td>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                                                </td>

                                        </tr>

                                    
                <tr>
                    <td colspan="4">
                        &nbsp;<asp:TextBox ID="txtMotivoReposicion" runat="server" Height="60px" 
                            TextMode="MultiLine" Width="600px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                   
                </tr>
        
            
        
        </table>
    </telerik:RadPageView>

      <telerik:RadPageView ID="RadPageView8"  runat="server" >
      <asp:Button ID="btnAgregarArchivo" runat="server" Text="Agregar Archivo" 
                onclick="btnAgregarArchivo_Click" /><br />
                <telerik:RadGrid ID="RadGrid2" runat="server" AutoGenerateColumns="False" 
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
                            HeaderText="Opciones" UniqueName="TemplateColumn"><ItemTemplate><asp:Button ID="Button1" runat="server" Text="Ver Archivo" CommandArgument='<%# Eval("cod_archivos_control_calidad") %>' OnClick="btnVerArchivo" /></ItemTemplate></telerik:GridTemplateColumn></Columns><EditFormSettings><EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn></EditFormSettings></MasterTableView><FilterMenu EnableImageSprites="False"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></FilterMenu><HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default"><WebServiceSettings><ODataSettings InitialContainerName=""></ODataSettings></WebServiceSettings></HeaderContextMenu>
                            </telerik:RadGrid>
                            </telerik:RadPageView>

    </telerik:RadMultiPage>

    <br />
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <asp:Button ID="btnEnviarAprobacion" runat="server" Text="Enviar Aprobacion" onclick="btnEnviarAprobacion_Click" />
    &nbsp;<asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click"  Text="Guardar" />
    &nbsp;<asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click"  Text="Cancelar" />
</div>

<div id="sqlObjectsDatasourcesDiv">

    <asp:SqlDataSource ID="SqlArchivos" runat="server" 
                ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                
                
        SelectCommand="SELECT [cod_archivos_control_calidad], [tipo], [fecha_subida], [fecha_manual] FROM [archivos_control_calidad] WHERE ([cod_control_calidad] = @cod_control_calidad)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="cod_control_calidad" QueryStringField="cod" 
                        Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlCalibracionCalidad" runat="server" 
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


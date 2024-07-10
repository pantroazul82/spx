<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmHojaVida.aspx.cs" Inherits="frm_hojavida_frmHojaVida" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTabControl" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">
Hoja de vida de equipos
</div>

 <telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1" 
        SelectedIndex="0" >
        <Tabs>
            <telerik:RadTab runat="server" Text="Informacion General" Selected="True">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Traslados">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Equipos Auxiliares">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Historial de Mantenimiento">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Archivos">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>

    <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0" >
    

    <telerik:RadPageView ID="RadPageView1" runat="server">
    
                          <div class="Formulario">
        <table>
        <tr>

            <td colspan="2"><div class="style1">Informacion General</div></td>
            
            <td colspan="2"><div class="style1">Cliente</div></td>

        </tr>
        
        <tr>
            <td>Serial</td>
            <td><asp:TextBox runat="server" ID="txtSerial" ReadOnly="True"></asp:TextBox> </td>
            
            <td>Nombre Cliente</td>
            <td><asp:TextBox runat="server" ID="txtNombreCliente"  ReadOnly="True"></asp:TextBox> </td>
        </tr>
        
        <tr>
            <td>Fabricante</td>
            <td><asp:TextBox runat="server" ID="txtFabricante" ReadOnly="True"></asp:TextBox> </td>
            
            <td>Nit Cliente</td>
            <td><asp:TextBox runat="server" ID="txtNitCliente" ReadOnly="True" ></asp:TextBox> </td>
        </tr>
        
        <tr>

            <td>Modelo</td>
            <td><asp:TextBox runat="server" ID="txtModelo"  ReadOnly="True"></asp:TextBox> </td>
            
            <td>Modalidad</td>
            <td><asp:TextBox runat="server" ID="txtModalidad"  ReadOnly="True"></asp:TextBox> </td>

        </tr>
        <tr>

            <td>Codigo Adicional </td>
            <td><asp:TextBox runat="server" ID="txtCodigoAdicional" ReadOnly="True"></asp:TextBox> </td>
            
            <td colspan ="2"><div class="style1">Ubicacion</div>  </td>
            

<tr>

            <td>Tipo de Propiedad</td>
            <td><asp:TextBox runat="server" ID="txtTipoPropiedad"  ReadOnly="True"></asp:TextBox> </td>
            
            <td>Sucursal</td>
            <td><asp:TextBox runat="server" ID="txtSucursal"  ReadOnly="True" Width="280px"></asp:TextBox> </td>

<tr>

            <td>Fecha Primer Ingreso </td>
            <td><asp:TextBox runat="server" ID="txtFechaPrimerIngreso"  ReadOnly="True"></asp:TextBox> </td>
            
            <td>Telefono</td>
            <td><asp:TextBox runat="server" ID="txtTelefonoSucursal" ReadOnly="True" 
                    Width="280px"></asp:TextBox> </td>

<tr>

            <td>Fecha Ultimo Envio Cliente </td>
            <td><asp:TextBox runat="server" ID="txtFechaUltimoEnvioCliente" ReadOnly="True"></asp:TextBox> </td>
            
            <td>Ubicacion Geografica</td>
            <td><asp:TextBox runat="server" ID="txtUbicacionGeografica" ReadOnly="True" 
                    ValidationGroup="280px" Width="280px"></asp:TextBox> </td>

<tr>

            <td>Fecha Ultimo Mantenimiento</td>
            <td><asp:TextBox runat="server" ID="txtFechaUltimoMantenimiento" ReadOnly="True"></asp:TextBox> </td>
            
            <td>Direccion</td>
            <td><asp:TextBox runat="server" ID="txtDireccion" ReadOnly="True" Width="280px"></asp:TextBox> </td>

<tr>

            <td>Fecha Proximo Mantenimiento</td>
            <td><asp:TextBox runat="server" ID="txtFechaProximoMantemiento"  ReadOnly="True"></asp:TextBox> </td>
            
            <td>Contacto General</td>
            <td><asp:TextBox runat="server" ID="txtContactoGeneral"  ReadOnly="True" 
                    Width="280px"></asp:TextBox> </td>

        </tr>
        <tr>

            <td>&nbsp;</td>
            <td>&nbsp;</td>
            
            <td>Email General</td>
            <td><asp:TextBox runat="server" ID="txtemailGeneeral"  ReadOnly="True" 
                    Width="280px"></asp:TextBox> </td>

<tr>

            <td colspan="2"><div class="style1">Informacion Tecnica del Equipo</div></td>
            
            
            <td>Celular General</td>
            <td><asp:TextBox runat="server" ID="txtCelularGeneral"  ReadOnly="True" 
                    Width="280px"></asp:TextBox> </td>

        </tr>
        </tr>
        </tr>
        </tr>
        </tr>
        </tr>
        </tr>
            <tr>
                <td>
                    Tipo de Equipo</td>
                 <td><asp:TextBox runat="server" ID="txtTipoEquipo"  ReadOnly="True"></asp:TextBox> </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Subtipo de Equipo</td>
                <td><asp:TextBox runat="server" ID="txtSubTipoEquipo"  ReadOnly="True"></asp:TextBox> </td>
                <td>
                    <b>Contacto Principal</b></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Frecuencia Mantenimiento</td>
                <td><asp:TextBox runat="server" ID="txtFrecuenciaManetemiento"  ReadOnly="True"></asp:TextBox> </td>
                <td>
                    Telefono</td>
                <td><asp:TextBox runat="server" ID="txtTelefono"  ReadOnly="True" Width="280px"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    Duracion Mantenmiento</td>
                 <td><asp:TextBox runat="server" ID="txtDuracionMantenimiento"  ReadOnly="True"></asp:TextBox> </td>
                <td>
                    Email</td>
                 <td><asp:TextBox runat="server" ID="txtEmail"  ReadOnly="True" Width="280px"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    Voltaje</td>
                <td><asp:TextBox runat="server" ID="txtVoltaje"  ReadOnly="True"></asp:TextBox> </td>
                <td>
                    Celular</td>
                 <td><asp:TextBox runat="server" ID="txtCelular"  ReadOnly="True" Width="280px"></asp:TextBox> </td>
            </tr>
            <tr>
                <td>
                    Frecuencia</td>
                <td><asp:TextBox runat="server" ID="txtFrecuencia"  ReadOnly="True"></asp:TextBox> </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Watios</td>
                <td>
                    <asp:TextBox ID="txtWatios" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    Amperios</td>
                <td>
                    <asp:TextBox ID="txtAmperios" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td valign="top">
                    Peso</td>
                <td valign="top">
                    <asp:TextBox ID="txtPeso" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td colspan="2">
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                 <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    Observaciones Equipo<br />
                    <asp:TextBox ID="txtObservacionesEquipo" runat="server" Height="75px" 
                        ReadOnly="True" TextMode="MultiLine" Width="343px"></asp:TextBox>
                </td>
                <td colspan="2">
                    Observaciones Ultimo Mantemiento<br />
                    <asp:TextBox ID="txtObservacionesUltimoMantenimiento" runat="server" 
                        Height="78px" ReadOnly="True" TextMode="MultiLine" Width="428px"></asp:TextBox>
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
            </tr>
        </table>
        </div>
    </telerik:RadPageView>

    <telerik:RadPageView ID="RadPageView2" runat="server">
Listado de Traslados.<br />
                <br />
                <asp:GridView runat="server" id="grdTraslados" AllowPaging="True" 
                    AutoGenerateColumns="False" CellPadding="4" DataSourceID="odsTraslados" 
                    ForeColor="#333333" GridLines="None" PageSize="20">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="codLog" HeaderText="Cod" SortExpression="codLog" />
                        <asp:BoundField DataField="fechaCambio" HeaderText="Fecha Cambio" 
                            SortExpression="fechaCambio" />
                        <asp:BoundField DataField="fechaEnvio" HeaderText="Fecha Envio" 
                            SortExpression="fechaEnvio" />
                        <asp:BoundField DataField="nitDestino" HeaderText="Nit Destino" 
                            SortExpression="nitDestino" />
                        <asp:BoundField DataField="nombreDestino" HeaderText="Cliente Destino" 
                            SortExpression="nombreDestino" />
                        <asp:BoundField DataField="sucursalDestino" HeaderText="Sucursal Destino" 
                            SortExpression="sucursalDestino" />
                        <asp:BoundField DataField="nombreModalidadEquipo" 
                            HeaderText="nombreModalidadEquipo" SortExpression="nombreModalidadEquipo" 
                            Visible="False" />
                        <asp:BoundField DataField="razon" HeaderText="Motivo" SortExpression="razon" />
                    </Columns>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <EmptyDataTemplate>
                        No tiene resgitros de traslados
                    </EmptyDataTemplate>
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
                <asp:ObjectDataSource ID="odsTraslados" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataBySerial" 
                    TypeName="SPControladoraDatos.dsSpxTableAdapters.pltLogTrasladosTableAdapter">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
    
    </telerik:RadPageView>

    <telerik:RadPageView ID="RadPageView3" runat="server">
               &nbsp; Equipo Auxiliar de
                <asp:TextBox ID="txtSerialAuxiliarde" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="btnVerHojaVidaPadre" runat="server" 
                    onclick="btnVerHojaVidaPadre_Click" Text="Ver Hoja de Vida" />
                <br />
                <asp:GridView ID="grdAuxiliares" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" DataSourceID="odsAuxiliares" ForeColor="#333333" 
                    GridLines="None" onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="nombreFabricante" HeaderText="Fabricante" 
                            SortExpression="nombreFabricante" />
                        <asp:BoundField DataField="NombreModelo" HeaderText="Modelo" 
                            SortExpression="NombreModelo" />
                        <asp:BoundField DataField="nombreTipoEquipo" HeaderText="Tipo Equipo" 
                            SortExpression="nombreTipoEquipo" />
                        <asp:BoundField DataField="nombreSubTipo" HeaderText="SubTipo" 
                            SortExpression="nombreSubTipo" />
                        <asp:BoundField DataField="serial" HeaderText="Serial" 
                            SortExpression="serial" />
                        <asp:BoundField DataField="nombreModalidadEquipo" HeaderText="Modalidad" 
                            SortExpression="nombreModalidadEquipo" />
                        <asp:BoundField DataField="nombreEstadoLocal" HeaderText="Estado Local" 
                            SortExpression="nombreEstadoLocal" />
                        <asp:BoundField DataField="nitCliente" HeaderText="Nit Cliente" 
                            SortExpression="nitCliente" />
                        <asp:BoundField DataField="nombreCliente" HeaderText="Cliente" 
                            SortExpression="nombreCliente" />
                        <asp:BoundField DataField="nombreSucursal" HeaderText="Sucursal" 
                            SortExpression="nombreSucursal" />
                            <asp:TemplateField>
                            <ItemTemplate>
                            <asp:ImageButton ID="btnVerHojaAuxiliar" Width="30px" ToolTip="Ver Hoja de vida" 
                            runat="server" ImageUrl="~/img/frm/logos.png" OnClick="hojaHijo" ValidationGroup='<%# Eval("Serial") %>' />
                            </ItemTemplate>
                            </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EmptyDataTemplate>
                    no tiene nigun equipo auxiliar asignado
                    </EmptyDataTemplate>
                </asp:GridView>
                <asp:ObjectDataSource ID="odsAuxiliares" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataAuxiliares" 
                    TypeName="SPControladoraDatos.dsSpxTableAdapters.vistaEquipoTableAdapter">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="serialEquipo" QueryStringField="sx" 
                            Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
    
    </telerik:RadPageView>

    <telerik:RadPageView ID="RadPageView4" runat="server">

                <asp:GridView ID="grdOrdenServicio" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" CellPadding="4" DataKeyNames="codOrdenServicio" 
                    DataSourceID="odsOrdenServicio" ForeColor="#333333" GridLines="None">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="codOrdenServicio" HeaderText="Orden Servicio" 
                            ReadOnly="True" SortExpression="codOrdenServicio" />
                        <asp:BoundField DataField="estado" HeaderText="Estado" 
                            SortExpression="estado" />
                        <asp:BoundField DataField="fechaProgramacion" HeaderText="Fecha Programacion" 
                            SortExpression="fechaProgramacion" />
                        <asp:BoundField DataField="nombretipoServicio" HeaderText="Tipo Servicio" 
                            SortExpression="nombretipoServicio" />
                        <asp:BoundField DataField="asignado" HeaderText="asignado" 
                            SortExpression="asignado" />
                        <asp:BoundField DataField="observacionesIngeniero" 
                            HeaderText="Observaciones Ingeniero" SortExpression="observacionesIngeniero" />
                        <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" 
                            SortExpression="Prioridad" />
                            <asp:TemplateField>
                            <ItemTemplate>
                            
                             
                            <asp:ImageButton ID="btnVerOrdenServicio" Width="30px" ToolTip="Ver Orden Servicio" 
                            runat="server" ImageUrl="~/img/zoom.png" OnClick="verOrdenServicio" ValidationGroup='<%# Eval("codOrdenServicio") %>' />
                            </ItemTemplate>
                            
                            
                            </asp:TemplateField>
                            
                    </Columns>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
                <asp:ObjectDataSource ID="odsOrdenServicio" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataBySerial"
                    TypeName="SPControladoraDatos.dsPlantillasTableAdapters.pltinfEquipoOSTableAdapter">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
    
    </telerik:RadPageView>

    <telerik:RadPageView ID="RadPageView5" runat="server">
    
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" DataKeyNames="serial,codArchivo" DataSourceID="odsArchivos" 
                    ForeColor="#333333" GridLines="None">
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="serial" HeaderText="serial" ReadOnly="True" 
                            SortExpression="serial" />
                        <asp:BoundField DataField="codArchivo" HeaderText="codArchivo" ReadOnly="True" 
                            SortExpression="codArchivo" />
                        <asp:BoundField DataField="nombreArchivo" HeaderText="nombreArchivo" 
                            SortExpression="nombreArchivo" />
                        <asp:BoundField DataField="descripcion" HeaderText="descripcion" 
                            SortExpression="descripcion" />
                        <asp:BoundField DataField="codTipoArchivoxEquipo" 
                            HeaderText="codTipoArchivoxEquipo" SortExpression="codTipoArchivoxEquipo" />
                        
                        <asp:TemplateField>
                            <ItemTemplate>
                             
                            <asp:ImageButton ID="btnVerArchivo" Width="30px" ToolTip="Ver Archivo" 
                            runat="server" ImageUrl="~/img/zoom.png" OnClick="verArchivo"
                            ValidationGroup='<%# Eval("codArchivo")+"|"+Eval("nombreArchivo") %>'/>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                            
                    </Columns>
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#999999" />
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                </asp:GridView>
    </telerik:RadPageView>

  
    </telerik:RadMultiPage>
       <asp:ObjectDataSource ID="odsArchivos" runat="server" DeleteMethod="Delete" 
                    InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataBySerial" 
                    TypeName="SPControladoraDatos.dsSpxTableAdapters.archivosXequipoTableAdapter" 
                    UpdateMethod="Update">

                    <SelectParameters>
                        <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                    </SelectParameters>
                    <InsertParameters>
                        <asp:Parameter Name="serial" Type="String" />
                        <asp:Parameter Name="codArchivo" Type="Int32" />
                        <asp:Parameter Name="nombreArchivo" Type="String" />
                        <asp:Parameter Name="archivo" Type="Object" />
                        <asp:Parameter Name="descripcion" Type="String" />
                        <asp:Parameter Name="codTipoArchivoxEquipo" Type="String" />
                    </InsertParameters>
                </asp:ObjectDataSource>
</asp:Content>


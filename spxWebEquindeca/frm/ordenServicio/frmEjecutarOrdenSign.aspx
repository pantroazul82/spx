﻿<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" 
AutoEventWireup="true" CodeFile="frmEjecutarOrdenSign.aspx.cs" Inherits="frm_ordenServicio_frmEjecutarOrdenSign" %>
<%@ Reference Control="../../controles/ctlSignature.ascx" %>
<%@ Register src="../../controles/ctlSignature.ascx" tagname="ctlSignature" tagprefix="uc" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>
<%@ Register src="../../controles/controlRepuestos.ascx" tagname="controlRepuestos" tagprefix="uc1" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
	
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Orden de Servicio <asp:Label runat="server" ID="lblOrdenServicio"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Button ID="btnCerrarOrden" runat="server" Text="Cerrar" 
        onclick="btnCerrarOrden_Click" OnClientClick="return confirm('Esta seguro de Cerrar la orden de Servicio?');" />
<asp:Button ID="btnReabrirOrden" runat="server" Text="Reabrir Orden" 
        onclick="btnReabrirOrden_Click" OnClientClick="return confirm('Esta seguro de reabrir la orden de Servicio?');" />

<asp:HyperLink runat="server" Target="_blank" ID="lnkImprimir" Text="Imprimir" NavigateUrl="" ImageUrl=""></asp:HyperLink>

</div>



 <telerik:RadTabStrip ID="RadTabStrip1" runat="server"  width="900px" 
        MultiPageID="RadMultiPage1" SelectedIndex="0">
        <Tabs>
            <telerik:RadTab runat="server" Text="Ejecucion" Selected="True">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="General">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Archivos">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Informacion de Cierre">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
    <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0">
    <telerik:RadPageView ID="RadPageView1" runat="server">
  <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
<br />
<div class="Formulario"> 
      
    <table>
        
        <tr>
        <td>&nbsp;</td>
        <td>   &nbsp;</td>
        </tr>
        
    <tr>
    <td colspan="2"><b>Actividades Realizadas&nbsp;&nbsp;&nbsp;&nbsp; </b>
        <asp:ImageButton ID="btnEditarActividadesRealizadas" runat="server" 
            ImageUrl="~/img/web/edit.gif" onclick="btnEditarActividadesRealizadas_Click" 
            ToolTip="Editar"  Width="30px" />
        <asp:ImageButton ID="btnAceptarActividadesREalizadas" runat="server" 
            ImageUrl="~/img/web/ok.gif" onclick="btnAceptarActividadesREalizadas_Click" 
            ToolTip="Aceptar" Visible="False"  Width="30px" />
        <asp:ImageButton ID="btnCancelarActividadesRealizadas" runat="server" 
            ImageUrl="~/img/web/cancel.gif" 
            onclick="btnCancelarActividadesRealizadas_Click"
            ToolTip="Cancelar" Visible="False"  Width="30px" />
        </td>
    </tr>
        
        <tr>
              <td colspan="2">&nbsp;
              Ultimo Mantenimiento por parte del usuario
              <telerik:RadDatePicker 
        ID="calultimoMantenimientoxUsuario" Runat="server">
        <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker><br />
    Mantenimiento de la maquina según lo indicado
    <asp:RadioButton runat="server" ID="rdManteimientoIndicadoSi" GroupName="manteIndi" Text="Si" />
    <asp:RadioButton runat="server" ID="rdManteimientoIndicadoNo" GroupName="manteIndi" text="No"/>
    </td>
        </tr>
        
        <tr>
            <td>
                Fallas Reportadas </td>
            <td>
                <asp:TextBox ID="txtFallasReportadas" runat="server" Height="90px" TextMode="MultiLine" 
                    ReadOnly="True" Width="441px"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
        <td>Observaciones Ingeniero</td>
        <td>   
            <asp:TextBox runat="server" ID="txtObservacionesIngeniero"  TextMode="MultiLine"
                ReadOnly="True" Height="77px" Width="436px"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Diagnostico </td>
        <td>   
            <asp:TextBox ID="txtDiagnostico" runat="server" Height="89px"  TextMode="MultiLine" ReadOnly="True" 
                Width="439px"></asp:TextBox>
            &nbsp;</td>
        </tr>
        
        <tr>
            <td>
                <b>Repuestos Utilizados</b></td>
            <td>
                <uc1:controlRepuestos ID="controlRepuestos1" runat="server" />
                <asp:Button ID="btnGuardarRepuestos" runat="server" 
                    onclick="btnGuardarRepuestos_Click" Text="Guardar Repuestos" />
            </td>
        </tr>
        
        <tr>
            <td colspan="2" class="style1"><b>Trabajos Realizados&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </b>
                <asp:Button ID="btnAgregarActividad" runat="server" 
                    onclick="btnAgregarActividad_Click" Text="Agregar Actividad" />
            </td>
        </tr>
        
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" DataKeyNames="codOrdenServicio,codActividad" 
                    DataSourceID="odsTrabajosRealizados" ForeColor="#333333" GridLines="None" PageSize="30">
                    <RowStyle BackColor="#EFF3FB" />
                    <Columns>
                        <asp:BoundField DataField="loginAutor" HeaderText="Autor" 
                            SortExpression="loginAutor" />
                        <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
                        <asp:BoundField DataField="codOrdenServicio" HeaderText="codOrdenServicio" 
                            ReadOnly="True" SortExpression="codOrdenServicio" Visible="False" />
                        <asp:BoundField DataField="codActividad" HeaderText="codActividad" 
                            ReadOnly="True" SortExpression="codActividad" Visible="False" />
                        <asp:BoundField DataField="observacion" HeaderText="Observacion" 
                            SortExpression="observacion">
                            <ItemStyle Height="50px" Width="350px" />
                        </asp:BoundField>
                        <asp:TemplateField> 
                        <ItemTemplate>
                        <asp:ImageButton runat="server" ToolTip="Eliminar Observacion" ID="imgEliminar" Visible='<%#  (Eval("loginAutor").ToString().Trim().ToLower() == Session["ss_login"].ToString().Trim().ToLower() && btnCerrarOrden.Visible ) %>' ValidationGroup='<%#  Eval("codActividad") %>' OnClick="btnEliminar_Click" ImageUrl="~/img/web/cancel.gif" OnClientClick="return confirm('Esta Seguro de Eliminar Esta observacion.?\n');" />
                        </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <br />
                <asp:ObjectDataSource ID="odsTrabajosRealizados" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataBycodOrdenServicio" 
                    TypeName="SPControladoraDatos.dsSpxTableAdapters.actividadxordenServicioTableAdapter" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_codOrdenServicio" Type="Int32" />
                        <asp:Parameter Name="Original_codActividad" Type="Int32" />
                        <asp:Parameter Name="Original_fecha" Type="DateTime" />
                        <asp:Parameter Name="Original_observacion" Type="String" />
                        <asp:Parameter Name="Original_loginAutor" Type="String" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="fecha" Type="DateTime" />
                        <asp:Parameter Name="observacion" Type="String" />
                        <asp:Parameter Name="loginAutor" Type="String" />
                        <asp:Parameter Name="Original_codOrdenServicio" Type="Int32" />
                        <asp:Parameter Name="Original_codActividad" Type="Int32" />
                        <asp:Parameter Name="Original_fecha" Type="DateTime" />
                        <asp:Parameter Name="Original_observacion" Type="String" />
                        <asp:Parameter Name="Original_loginAutor" Type="String" />
                    </UpdateParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lblOrdenServicio" Name="codOrdenServicio" 
                            PropertyName="Text" Type="Int32" />
                    </SelectParameters>
                    <InsertParameters>
                        <asp:Parameter Name="codOrdenServicio" Type="Int32" />
                        <asp:Parameter Name="codActividad" Type="Int32" />
                        <asp:Parameter Name="fecha" Type="DateTime" />
                        <asp:Parameter Name="observacion" Type="String" />
                        <asp:Parameter Name="loginAutor" Type="String" />
                    </InsertParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        
    </table>
    </div>
    
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView2" runat="server">
    <div class="Formulario"> 
    <table>
    <tr>
    <td colspan="4"><b>Informacion del Equipo</b></td>
    </tr>
        <tr>
        <td>Serial</td>
        <td> 
            <asp:TextBox runat="server" ID="txtSerial" ReadOnly="True"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="verHojaVida" OnClick="verHojaVida" Width="30px" ImageUrl="~/img/frm/logos.png" />
        </td>
        <td>Fabricante</td>
        <td>   <asp:TextBox  Width="30px" runat="server" ID="txtFabricante" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Modelo </td>
        <td>   <asp:TextBox runat="server" ID="txtModelo" ReadOnly="True"></asp:TextBox></td>
        <td>Modalidad</td>
        <td>   <asp:TextBox runat="server" ID="txtModalidad" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Fecha Proximo Mantenimiento </td>
        <td>   <asp:TextBox runat="server" ID="txtFechaProximoMantenimiento" 
                ReadOnly="True"></asp:TextBox></td>
        <td>Fecha Ultimo Mantenimiento </td>
        <td>   <asp:TextBox runat="server" ID="txtFechaUltimoMantenimiento" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
              <td colspan="4"><b>Informacion de la Orden de Servicio</b></td>
        </tr>
        
        <tr>
            <td>Numero Orden Servicio</td>
            <td>   <asp:TextBox runat="server" ID="txtNumeroOrden" ReadOnly="True"></asp:TextBox></td>
            <td>Numero Entrada</td>
            <td>   <asp:TextBox runat="server" ID="txtNumeroEntrada" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Prioridad</td>
        <td>   <asp:TextBox runat="server" ID="txtPrioridad" ReadOnly="True"></asp:TextBox></td>
        <td></td>
        <td> <asp:RadioButton ID="rdInterna" runat="server" Text=" Interna " GroupName="r" />
             <asp:RadioButton ID="rdExterna" runat="server" Text=" Externa " GroupName="r" />
         </td>
        </tr>
              
        <tr>
        <td>Estado</td>
        <td>   <asp:TextBox runat="server" ID="txtEstado" ReadOnly="True"></asp:TextBox></td>
        <td>Tipo de Servicio</td>
        <td>   <asp:TextBox runat="server" ID="txtTipoServicio" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Ingeniero Asignado</td>
        <td>   <asp:TextBox runat="server" ID="txtIngenieroAsignado" ReadOnly="True"></asp:TextBox></td>
        <td>Asesor Comercial</td>
        <td>   <asp:TextBox runat="server" ID="txtAsesorComercial" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Fecha Tentativa Ejecucion</td>
        <td>   <asp:TextBox runat="server" ID="txtFechaTentativainicio" ReadOnly="True"></asp:TextBox></td>
        <td> Hasta</td>
        <td>   <asp:TextBox runat="server" ID="txtFechaTentativaFin" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td valign="top">Observaciones Iniciales</td>
        <td colspan="3">
            <asp:TextBox runat="server" ID="txtObservacionesIniciales" TextMode="MultiLine" 
                ReadOnly="True" Height="84px" Width="459px"></asp:TextBox>
        </td>
        </tr>
        
        <tr>
            <td colspan="4"><b>Informacion del Cliente</b></td>
        </tr>
        
        <tr>
        <td>Nit Cliente</td>
        <td>   <asp:TextBox runat="server" ID="txtNitCliente" ReadOnly="True"></asp:TextBox></td>
        <td>Nombre Cliente</td>
        <td>   <asp:TextBox runat="server" ID="txtNombreCliente" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Sucursal</td>
        <td>   <asp:TextBox runat="server" ID="txtSucursal" ReadOnly="True"></asp:TextBox></td>
        <td>Ciudad</td>
        <td>   <asp:TextBox runat="server" ID="txtCiudadSucursal" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Direccion</td>
            <td>   <asp:TextBox runat="server" ID="txtDireccionSucursal" ReadOnly="True" 
                    Width="200px"></asp:TextBox></td>
        <td>Telefono</td>
            <td>   <asp:TextBox runat="server" ID="txtTelefonoSucursal" ReadOnly="True"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Contacto Sucursal</td>
        <td>   <asp:TextBox runat="server" ID="txtContactoSucursal" ReadOnly="True"></asp:TextBox></td>
        <td>Celular Contacto</td>
        <td>   <asp:TextBox runat="server" ID="txtCelularContacto" ReadOnly="True"></asp:TextBox></td>
        </tr>
    
    </table>
    </div>
    
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView3" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnSubirArchivo" runat="server" onclick="btnSubirArchivo_Click" 
                Text="Subir Archivo" />
            <br />
        
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                CellPadding="4" DataKeyNames="codOrdenServicio,codArchivo" 
                DataSourceID="odsArchivosxOrden" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="codOrdenServicio" HeaderText="codOrdenServicio" 
                        ReadOnly="True" SortExpression="codOrdenServicio" Visible="False" />
                    <asp:BoundField DataField="codArchivo" HeaderText="codArchivo" ReadOnly="True" 
                        SortExpression="codArchivo" Visible="False" />
                    <asp:BoundField DataField="nombreArchivo" HeaderText="Nombre Archivo" 
                        SortExpression="nombreArchivo">
                    <ItemStyle Width="160px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="descripcion" HeaderText="Descripcion" 
                        SortExpression="descripcion">
                    <ItemStyle Width="290px" />
                    </asp:BoundField>
                    
                      <asp:TemplateField>
                            <ItemTemplate>
                             
                            <asp:ImageButton ID="btnVerArchivo" Width="30px" ToolTip="Ver Archivo" 
                            runat="server" ImageUrl="~/img/zoom.png" OnClick="verArchivo"
                            ValidationGroup='<%# Eval("codArchivo")+"|"+Eval("nombreArchivo") %>'/>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <EmptyDataTemplate>
                    La orden de Servicio no tiene ningun archivo
                </EmptyDataTemplate>
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:ObjectDataSource ID="odsArchivosxOrden" runat="server" 
                OldValuesParameterFormatString="original_{0}" 
                SelectMethod="GetDataByCodOrdenServicio" 
                
                TypeName="SPControladoraDatos.dsSpxTableAdapters.archivosXOrdenServicioTableAdapter">

                <SelectParameters>
                    <asp:ControlParameter ControlID="lblOrdenServicio" Name="codOrdenServicio" 
                        PropertyName="Text" Type="Int32" />
                </SelectParameters>

            </asp:ObjectDataSource>
      
    </telerik:RadPageView>
    <telerik:RadPageView ID="RadPageView4" runat="server">
    
    <div class="tab">Informacion de Aceptaction&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton  Width="30px" ID="btnEditarAceptacion" runat="server" 
            ImageUrl="~/img/web/edit.gif" OnClick="btnEditarAceptacion_Click" 
            ToolTip="Editar" />
        <asp:ImageButton  Width="30px" ID="btnAceptarAceptacion" runat="server" 
            ImageUrl="~/img/web/ok.gif" OnClick="btnAceptarAceptacion_Click" 
            OnClientClick="DirectSave();" ToolTip="Aceptar" Visible="False" />
        <asp:ImageButton  Width="30px" ID="btnCancelarAceptacion" runat="server" 
            ImageUrl="~/img/web/cancel.gif" OnClick="btnCancelarAceptacion_Click" 
            ToolTip="Cancelar" Visible="False" />
        </div>
    <table>
    
        <tr>
            <td rowspan="3">
                Firma<br />
                <uc:ctlSignature ID="ctlSignature1" runat="server" BackColor="White" 
                    PenColor="Black" PenWidth="1" SavePath="~/temp/"
                     
                    SignatureCodePath="~/controles/" SignatureFileFormat="gif" SignHeight="200" 
                    SignWidth="400" Visible="False" NoSignMessage="No se encontro la Firma"
                     EnableViewState="True" />
                <asp:Image ID="imgFirma" runat="server" Height="200px" Width="400px" />
                <br />
              
                <asp:Button ID="btnLimpiarFirma" runat="server" 
                    OnClientClick="ClearSignature();" Text="Limpiar Firma" Visible="false" />
            </td>
            <td>
                Hora de Llegada<br />
                <asp:DropDownList ID="cmbHoraLlegada" runat="server" Enabled="False">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="cmbMinutosLlegada" runat="server" Enabled="False">
                </asp:DropDownList>
                <asp:DropDownList ID="cmbAmPmLlegada" runat="server" Enabled="False">
                    <asp:ListItem>AM</asp:ListItem>
                    <asp:ListItem>PM</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    
    <tr>
        <td>
            Hora de Salida<br />
            <asp:DropDownList ID="cmbHoraSalida" runat="server" Enabled="False">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="cmbMinutosSalida" runat="server" Enabled="False">
            </asp:DropDownList>
            <asp:DropDownList ID="cmbAmPmSalida" runat="server" Enabled="False">
                <asp:ListItem>AM</asp:ListItem>
                <asp:ListItem>PM</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    
    <tr>
        <td>
            Nombre del Usuario que recibe<br />
            <asp:TextBox ID="txtUsuarioAceptacion" runat="server" ReadOnly="True" 
                Width="280px"></asp:TextBox>
        </td>
    </tr>
    
    <tr>
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
        </tr>
        <tr>
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
        </tr>
    
    </table>
    </telerik:RadPageView>
    </telerik:RadMultiPage>
</asp:Content>



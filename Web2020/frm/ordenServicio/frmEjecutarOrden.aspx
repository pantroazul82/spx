<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmEjecutarOrden.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmEjecutarOrden" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<%@ Register src="../../controles/controlRepuestos.ascx" tagname="controlRepuestos" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <div class="tab">Orden de Servicio <asp:Label runat="server" ID="lblOrdenServicio"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<asp:Button ID="btnCerrarOrden" CssClass="btn btn-danger" runat="server" Text="Cerrar Orden" 
        onclick="btnCerrarOrden_Click" OnClientClick="return confirm('Esta seguro de Cerrar la orden de Servicio?');" />

<asp:Button ID="btnReabrirOrden" class="btn btn-primary" runat="server" Text="Reabrir Orden" 
        onclick="btnReabrirOrden_Click" OnClientClick="return confirm('Esta seguro de reabrir la orden de Servicio?');" />

<asp:Button ID="btnImprimir" runat="server" Text="Imprimir" 
        onclick="btnImprimir_Click" />
<br />
</div>  <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
<br />
<cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" 
        Width="900px" >
    <cc1:TabPanel runat="server" HeaderText="Ejecucion" ID="TabPanel1">
      <ContentTemplate>
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
            ToolTip="Editar" Width="30px"  />
        <asp:ImageButton Width="30px"  ID="btnAceptarActividadesREalizadas" runat="server" 
            ImageUrl="~/img/web/ok.gif" onclick="btnAceptarActividadesREalizadas_Click" 
            ToolTip="Aceptar" Visible="False" />
        <asp:ImageButton Width="30px"  ID="btnCancelarActividadesRealizadas" runat="server" 
            ImageUrl="~/img/web/cancel.gif" 
            onclick="btnCancelarActividadesRealizadas_Click" style="height: 16px" 
            ToolTip="Cancelar" Visible="False" />
        </td>
    </tr>
        
        <tr>
              <td colspan="2">&nbsp;</td>
        </tr>
        
        <tr>
            <td>
                Fallas Reportadas </td>
            <td>
                <asp:TextBox ID="txtFallasReportadas" runat="server" Height="90px" 
                    ReadOnly="True" Width="441px"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
        <td>Observaciones Ingeniero</td>
        <td>   
            <asp:TextBox runat="server" ID="txtObservacionesIngeniero" 
                ReadOnly="True" Height="77px" Width="436px"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td>Diagnostico </td>
        <td>   
            <asp:TextBox ID="txtDiagnostico" runat="server" Height="89px" ReadOnly="True" 
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
                    DataSourceID="odsTrabajosRealizados" ForeColor="#333333" GridLines="None">
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
                    </Columns>
                    <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
                <asp:ObjectDataSource ID="odsTrabajosRealizados" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataBycodOrdenServicio" 
                    TypeName="Web2020.cls.ds2020TableAdapters.actividadxordenServicioTableAdapter" 
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
    </ContentTemplate>
    </cc1:TabPanel>

    <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="General">
    <ContentTemplate>
    <div class="Formulario"> 
    <table>
    <tr>
    <td colspan="4"><b>Informacion del Equipo</b></td>
    </tr>
        <tr>
        <td>Serial</td>
        <td> 
            <asp:TextBox runat="server" ID="txtSerial" ReadOnly="True"></asp:TextBox>
            <asp:ImageButton runat="server" ToolTip="verHojaVida" OnClick="verHojaVida" Width="30px" ImageUrl="~/img/frm/logos.png" />
        </td>
        <td>Fabricante</td>
        <td>   <asp:TextBox runat="server" ID="txtFabricante" ReadOnly="True"></asp:TextBox></td>
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
    </ContentTemplate>
    
    
    </cc1:TabPanel>
    <cc1:TabPanel ID="TabPanel3" runat="server" HeaderText="Archivos">
        <ContentTemplate>
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
                
                TypeName="Web2020.cls.ds2020TableAdapters.archivosXOrdenServicioTableAdapter">

                <SelectParameters>
                    <asp:ControlParameter ControlID="lblOrdenServicio" Name="codOrdenServicio" 
                        PropertyName="Text" Type="Int32" />
                </SelectParameters>

            </asp:ObjectDataSource>
        </ContentTemplate>
    </cc1:TabPanel>
    <cc1:TabPanel ID="TabPanel4" runat="server" HeaderText="Informacion de Cierre">
    <ContentTemplate>
    <div class="tab">Informacion de Aceptaction</div>
    
    <table>
    <tr>
    <td>&nbsp;</td>
    <td>
    <asp:ImageButton Width="30px" runat="server" ImageUrl="~/img/web/edit.gif" ToolTip="Editar" 
            ID="btnEditarAceptacion" onclick="btnEditarAceptacion_Click"></asp:ImageButton>
    <asp:ImageButton Width="30px" runat="server" ImageUrl="~/img/web/ok.gif" ToolTip="Aceptar" 
            ID="btnAceptarAceptacion" Visible="False" onclick="btnAceptarAceptacion_Click" ></asp:ImageButton>
    <asp:ImageButton Width="30px" runat="server" ImageUrl="~/img/web/cancel.gif" ToolTip="Cancelar" 
            ID="btnCancelarAceptacion" Visible="False"
            onclick="btnCancelarAceptacion_Click"></asp:ImageButton>
</td>
    </tr>
    
        <tr>
            <td>
                Hora de Llegada</td>
            <td>
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
    <td>Hora de Salida</td>
    <td>
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
    <td>Nombre del Usuario Que recibe</td>
    <td>
        <asp:TextBox ID="txtUsuarioAceptacion" runat="server" ReadOnly="True" 
            Width="379px"></asp:TextBox>
        </td>
    </tr>
    
    <tr>
    <td>Firma</td>
    <td>
        <asp:Image ID="imgFirma" runat="server" Height="57px" Width="188px" />
        </td>
    </tr>
    
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnCambiarFoto" runat="server" Text="Cambiar Firma" 
                    onclick="btnCambiarFoto_Click" />
                <asp:FileUpload ID="FileUploadFirma" runat="server" />
                <asp:Button ID="btnSubirFirma" runat="server" Text="Subir Firma" 
                    onclick="btnSubirFirma_Click" />
                <asp:Button ID="btnCancelarFirma" runat="server" 
                    onclick="btnCancelarFirma_Click" Text="Cancelar Firma" />
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
    
    </table>
    </ContentTemplate>
    
    </cc1:TabPanel>
    </cc1:TabContainer>

</asp:Content>
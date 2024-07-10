<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmHojaVida.aspx.cs" Inherits="Web2020.frm.hojavida.frmHojaVida" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>




<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link href="../../assets/css/EjecutarOrden.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <div class="screen-1" style="overflow: auto">
        <div class="container">
            <h2 class="titulo">Hoja de vida de equipos</h2>
            &nbsp;
        <div class="row">
            <telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1"
                SelectedIndex="0">
                <Tabs>
                    <telerik:RadTab runat="server" Text="Informacion General" Selected="True">
                    </telerik:RadTab>
                    <telerik:RadTab runat="server" Text="Traslados">
                    </telerik:RadTab>
                    <telerik:RadTab runat="server" Text="Equipos Auxiliares">
                    </telerik:RadTab>
                    <telerik:RadTab runat="server" Text="Historial de Mantenimiento">
                    </telerik:RadTab>
                    <telerik:RadTab runat="server" Text="Llamadas de Ingenieria">
                    </telerik:RadTab>

         
                    <telerik:RadTab runat="server" Text="Actividades">
                    </telerik:RadTab>
                    <telerik:RadTab runat="server" Text="Archivos">
                    </telerik:RadTab>
                </Tabs>
            </telerik:RadTabStrip>
        </div>
            <div>
                <div>&nbsp;</div>
            </div>
            <div class="row formContainer">

                <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0">


                    <telerik:RadPageView ID="RadPageView1" runat="server">

                        <div class="Formulario">

                            <div>

                                <div colspan="2">
                                    <div class="col-sm-6"><b>Informacion General</b></div>
                                </div>

                                <div colspan="2">
                                    <div class="col-sm-6"><b>Cliente</b></div>
                                </div>

                            </div>
                            <div>
                                <div>&nbsp;</div>
                            </div>

                            <div class="row">
                                <div class="col-sm-3">Serial</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtSerial" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3">Nombre Cliente</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtNombreCliente" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-sm-3">Fabricante</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtFabricante" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3">Nit Cliente</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtNitCliente" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row">

                                <div class="col-sm-3">Modelo</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtModelo" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3">Modalidad</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtModalidad" ReadOnly="True"></asp:TextBox>
                                </div>

                            </div>
                            <div class="row">

                                <div class="col-sm-3">Codigo Adicional </div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtCodigoAdicional" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3" colspan="2">
                                    <div class="style1"><b>Ubicacion</b></div>
                                </div>
                            </div>


                            <div class="row">

                                <div class="col-sm-3">Tipo de Propiedad</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtTipoPropiedad" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3">Sucursal</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtSucursal" ReadOnly="True"></asp:TextBox>
                                </div>

                            </div>
                            <div class="row">

                                <div class="col-sm-3">Fecha Primer Ingreso </div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtFechaPrimerIngreso" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3">Telefono</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtTelefonoSucursal" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row">

                                <div class="col-sm-3">Fecha Ultimo Envio Cliente </div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtFechaUltimoEnvioCliente" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3">Ubicacion Geografica</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtUbicacionGeografica" ReadOnly="True"
                                        ValidationGroup="280px"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row">

                                <div class="col-sm-3">Fecha Ultimo Mantenimiento</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtFechaUltimoMantenimiento" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3">Direccion</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtDireccion" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="row">

                                <div class="col-sm-3">Fecha Proximo Mantenimiento</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtFechaProximoMantemiento" ReadOnly="True"></asp:TextBox>
                                </div>

                                <div class="col-sm-3">Contacto General</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtContactoGeneral" ReadOnly="True"></asp:TextBox>
                                </div>

                            </div>

                            <div class="row">



                                <div class="col-sm-3">Email General</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtemailGeneeral" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div class="col-sm-3">Celular General</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtCelularGeneral" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div>
                                <div>&nbsp;</div>
                            </div>

                            <div class="row">

                                <div class="col-sm-3" colspan="2">
                                    <div class="style1"><b>Informacion Tecnica del Equipo</b></div>
                                </div>

                                <div class="col-sm-3"></div>
                                <div class="col-sm-3">
                                    <b>Contacto Principal</b>
                                </div>


                            </div>
                            <div>
                                <div>&nbsp;</div>
                            </div>


                            <div class="row">
                                <div class="col-sm-3">Tipo de Equipo</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtTipoEquipo" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div class="col-sm-3">Telefono</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtTelefono" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3">Subtipo de Equipo</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtSubTipoEquipo" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div class="col-sm-3">Email</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtEmail" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3">Frecuencia Mantenimiento</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtFrecuenciaManetemiento" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div class="col-sm-3">Celular</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtCelular" ReadOnly="True"></asp:TextBox>
                                </div>

                            </div>
                            <div class="row">
                                <div class="col-sm-3">Duracion Mantenmiento</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtDuracionMantenimiento" ReadOnly="True"></asp:TextBox>
                                </div>


                            </div>
                            <div class="row">
                                <div class="col-sm-3">Voltaje</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtVoltaje" ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3">Frecuencia</div>
                                <div class="col-sm-3">
                                    <asp:TextBox runat="server" ID="txtFrecuencia" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div>&nbsp;</div>
                                <div>&nbsp;</div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3">Watios</div>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtWatios" runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div colspan="2">&nbsp;</div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3">Amperios</div>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtAmperios" runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div colspan="2">&nbsp;</div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3" valign="top">Peso</div>
                                <div class="col-sm-3" valign="top">
                                    <asp:TextBox ID="txtPeso" runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                                <div colspan="2">
                                    <br />
                                </div>
                            </div>
                            <div class="row">
                                <div>&nbsp;</div>
                                <div>&nbsp;</div>
                                <div>&nbsp;</div>
                                <div>&nbsp;</div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3" colspan="2">
                                    Observaciones Equipo<br />
                                </div>
                                <div div class="col-lg-3">
                                    <asp:TextBox ID="txtObservacionesEquipo" runat="server"
                                        Width="183px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-3" colspan="2">
                                    Observaciones Ultimo Mantemiento<br />
                                </div>
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtObservacionesUltimoMantenimiento" runat="server"
                                        style="width: 183px;" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>

                                </div>
                            </div>
                            <div class="row">

                                <div>&nbsp;</div>
                            </div>
                        </div>
                    </telerik:RadPageView>

                    <telerik:RadPageView ID="RadPageView2" runat="server">
                        <div class="col-sm-6"><b>Listado de Traslados.</b></div>
                        <br />
                        <div>
                            <div>
                                &nbsp;
                            </div>
                        </div>
                        <dx:ASPxGridView runat="server" ID="grdTraslados2"
                            AutoGenerateColumns="False" DataSourceID="odsTraslados2"
                            ForeColor="#333333">

                            <Columns>
                                <dx:GridViewDataTextColumn FieldName="codLog" Caption="Cod" />
                                <dx:GridViewDataDateColumn FieldName="fechaCambio" Caption="Fecha Cambio" />
                                <dx:GridViewDataDateColumn FieldName="fechaEnvio" Caption="Fecha Envio" />
                                <dx:GridViewDataTextColumn FieldName="nitDestino" Caption="Nit Destino" />
                                <dx:GridViewDataTextColumn FieldName="nombreDestino" Caption="Cliente Destino" />
                                <dx:GridViewDataTextColumn FieldName="sucursalDestino" Caption="Sucursal Destino" />
                                <dx:GridViewDataTextColumn FieldName="nombreModalidadEquipo" Caption="nombreModalidadEquipo" Visible="False" />
                                <dx:GridViewDataTextColumn FieldName="razon" Caption="Motivo" />
                            </Columns>


                            <Settings ShowFilterRow="True" />
                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        </dx:ASPxGridView>


                        <asp:SqlDataSource runat="server" ID="odsTraslados2" ConnectionString="<%$ ConnectionStrings:spx2020ConnectionString %>" SelectCommand="

select 
logCambioUbicaciones.codLog,logCambioUbicaciones.serial,fabricante.nombre_fabricante,modelos.nombreModelo,
logCambioUbicaciones.fechaCambio,
sucOrigen.nombreSucursal sucursalOrigen,
sucDestino.nombreSucursal sucursalDestino,
origen.nitCliente nitOrigen,origen.nombreCliente nombreOrigen,
destino.nitCliente as nitDestino,destino.nombreCliente nombreDestino,
usuarios.login,usuarios.nombre,razon,fechaEnvio,modalidadEquipo.nombreModalidadEquipo
 from logCambioUbicaciones
join usuario usuarios on usuarios.login = logCambioUbicaciones.usuarioCambio
join equipos on equipos.serial = logCambioUbicaciones.serial
left join ModalidadEquipo on ModalidadEquipo.codModalidadEquipo = equipos.codModalidadEquipo
join fabricante on fabricante.codfabricante = equipos.codfabricante
join modelos on modelos.codfabricante = equipos.codfabricante AND modelos.codModelo = equipos.codModelo
left join clientes origen on origen.nitcliente = logCambioUbicaciones.nitClienteOrigen
left join sucursalCliente sucOrigen on logCambioUbicaciones.codSucursalOrigen = sucOrigen.codSucursal 
and sucOrigen.nitCliente = origen.nitcliente 
left join clientes destino on destino.nitcliente = logCambioUbicaciones.nitClienteDestino
left join sucursalCliente sucDestino on logCambioUbicaciones.codSucursaldestino = sucDestino.codSucursal 
and sucDestino.nitCliente = destino.nitcliente 
where 
logCambioUbicaciones.serial = @serial">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                            </SelectParameters>

                        </asp:SqlDataSource>
                    </telerik:RadPageView>

                    <telerik:RadPageView ID="RadPageView3" runat="server">
                        &nbsp; Equipo Auxiliar de
                <asp:TextBox ID="txtSerialAuxiliarde" runat="server"></asp:TextBox>
                        &nbsp;<asp:Button ID="btnVerHojaVidaPadre" runat="server" CssClass="btn btn-secondary"
                            OnClick="btnVerHojaVidaPadre_Click" Text="Ver Hoja de Vida" />
                        
                        <div>
                            <div>
                                &nbsp;
                            </div>
                        </div>
                        <dx:ASPxGridView ID="grdAuxiliares" runat="server" AutoGenerateColumns="False"
                            DataSourceID="odsAuxiliares2" ForeColor="#333333"
                            onselectedindexchanged="GridView1_SelectedIndexChanged">

                            <Columns>
                                <dx:GridViewDataColumn>
                                    <DataItemTemplate>
                                        <asp:ImageButton ID="btnVerHojaAuxiliar" Width="30px" ToolTip="Ver Hoja de vida"
                                                         runat="server" ImageUrl="~/img/frm/logos.png" OnClick="hojaHijo" ValidationGroup='<%# Eval("Serial") %>' />
                                    </DataItemTemplate>
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataTextColumn FieldName="nombrefabricante" Caption="Fabricante" />
                                <dx:GridViewDataTextColumn FieldName="nombremodelo" Caption="Modelo" />
                                <dx:GridViewDataTextColumn FieldName="nombretipoequipo" Caption="Tipo Equipo" />
                                <dx:GridViewDataTextColumn FieldName="nombresubtipo" Caption="SubTipo" />
                                <dx:GridViewDataTextColumn FieldName="serial" Caption="Serial" />
                                <dx:GridViewDataTextColumn FieldName="nombremodalidadequipo" Caption="Modalidad" />
                                <dx:GridViewDataTextColumn FieldName="nombreestadolocal" Caption="Estado Local" />
                                <dx:GridViewDataTextColumn FieldName="nitCliente" Caption="Nit Cliente" />
                                <dx:GridViewDataTextColumn FieldName="nombreCliente" Caption="Cliente" />
                                <dx:GridViewDataTextColumn FieldName="nombreSucursal" Caption="Sucursal" />
                     
                            </Columns>





                            <Settings ShowFilterRow="True" />
                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />



                        </dx:ASPxGridView>


                        <asp:SqlDataSource runat="server" ID="odsAuxiliares2" ConnectionString="<%$ ConnectionStrings:spx2020ConnectionString %>" SelectCommand="

SELECT        nombrefabricante, nombremodelo, nombretipoequipo, nombresubtipo, nombremodalidadequipo, nombreestadolocal, nitCliente, nombreCliente, nombreSucursal, 
                         nombrePais, NombreDepartamento, nombreCiudad, serial, fechaLlegada, fechaSalida, fechaProximoMante, fechaUltimoMante, codTipoServicio, 
                         observacionesUltimoMante, fechaProximaProgramacion, codSucursalUbica, nitClienteUbicacionReal, clientereal, sucursallocal, ultimo_responsable

 FROM dbo.vistaEquipo

join equipoAuxiliar on equipoAuxiliar.serialAuxiliar = vistaequipo.serial
where equipoAuxiliar.serialEquipo = @serial">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                            </SelectParameters>

                        </asp:SqlDataSource>


                    </telerik:RadPageView>

                    <telerik:RadPageView ID="RadPageView4" runat="server">

                        <dx:ASPxGridView ID="grdOrdenServicio" runat="server"
                            AutoGenerateColumns="False" DataKeyNames="codOrdenServicio"
                            DataSourceID="odsOrdenServicio2" ForeColor="#333333">

                            <Columns>
                                <dx:GridViewDataColumn>
                                    <DataItemTemplate>


                                        <asp:ImageButton ID="btnVerOrdenServicio" Width="30px" ToolTip="Ver Orden Servicio"
                                                         runat="server" ImageUrl="~/img/zoom.png" OnClick="verOrdenServicio" ValidationGroup='<%# Eval("codOrdenServicio") %>' />

                                        <asp:ImageButton ID="btnImprimirOrdenServicio" Width="30px" ToolTip="Email Servicio"
                                                         runat="server" ImageUrl="~/img/email.png" OnClick="ImprimirOrdenServicio" ValidationGroup='<%# Eval("codOrdenServicio") %>' />


                                    </DataItemTemplate>


                                </dx:GridViewDataColumn>
                                <dx:GridViewDataTextColumn FieldName="codOrdenServicio" Caption="Orden Servicio"
                                    ReadOnly="True" />
                                <dx:GridViewDataTextColumn FieldName="estado" Caption="Estado" />
                                <dx:GridViewDataDateColumn FieldName="fechaProgramacion" Caption="Fecha Programacion" />
                                <dx:GridViewDataTextColumn FieldName="nombretipoServicio" Caption="Tipo Servicio" />
                                <dx:GridViewDataTextColumn FieldName="asignado" Caption="asignado" />
                                <dx:GridViewDataTextColumn FieldName="observacionesIngeniero"
                                    Caption="Observaciones Ingeniero" />
                                <dx:GridViewDataTextColumn FieldName="Prioridad" Caption="Prioridad" />
             

                            </Columns>





                            <Settings ShowFilterRow="True" />
                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        </dx:ASPxGridView>


                        <asp:SqlDataSource runat="server" ID="odsOrdenServicio2" ConnectionString="<%$ ConnectionStrings:spx2020ConnectionString %>" SelectCommand="
select fechaProgramacion,TipoServicio.nombretipoServicio,
usuarios.nombre 'asignado',ordenServicio.codOrdenServicio,
ordenServicio.observacionesIngeniero
,estadosOrdenServicio.nombreEstado 'estado'
,prioridadesOrdenServicio.nombre 'Prioridad'
 from ordenServicio 
join TipoServicio on TipoServicio.codTipoServicio = ordenServicio.codTipoServicio
join estadosOrdenServicio on estadosOrdenServicio.codEstadoOrdenServicio = ordenServicio.codEstadoOrdenServicio
join prioridadesOrdenServicio on prioridadesOrdenServicio.codPrioridadOS =ordenServicio.codPrioridadOS
left join usuario usuarios on usuarios.login = ordenServicio.asignadoa
where ordenServicio.serial =@serial
order by ordenServicio.codOrdenServicio desc

">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                            </SelectParameters>

                        </asp:SqlDataSource>



                    </telerik:RadPageView>

                    <telerik:RadPageView ID="RadPageLlamadasIngnieria" runat="server">

                        <dx:ASPxGridView ID="grdLlamadasIngenieria" runat="server"
                            AutoGenerateColumns="False" DataKeyNames="idLlamadaSoporte"
                            DataSourceID="SqlDataSourceLLamadasIngenieria" ForeColor="#333333">

                            <Columns>
                                <dx:GridViewDataColumn>
                                    <DataItemTemplate>


                                        <asp:ImageButton ID="btnVerLLamadaIngenieria" Width="30px" ToolTip="Ver Llamada"
                                                         runat="server" ImageUrl="~/img/zoom.png" OnClick="btnVerLLamadaIngenieria_Click" ValidationGroup='<%# Eval("idLlamadaSoporte") %>' />
                                    </DataItemTemplate>


                                </dx:GridViewDataColumn>
                                <dx:GridViewDataTextColumn FieldName="idLlamadaSoporte" Caption="Cod"
                                    ReadOnly="True" />
                                <dx:GridViewDataTextColumn FieldName="nombreEstado" Caption="Estado" />
                                <dx:GridViewDataTextColumn FieldName="fechaLlamada" Caption="Fecha Llamada" />
                                <dx:GridViewDataCheckColumn FieldName="llamadaRecibida" Caption="LLamada Recibida" />
                                <dx:GridViewDataTextColumn FieldName="nitCliente" Caption="Nit Cliente" />
                                <dx:GridViewDataTextColumn FieldName="nombreCliente" Caption="Cliente" />
                                <dx:GridViewDataTextColumn FieldName="asesorTelefonico" Caption="Asesor Telefonico" />
                                <dx:GridViewDataTextColumn FieldName="ingenieroAsesor" Caption="Ingeniero Asesor" />
                                <dx:GridViewDataTextColumn FieldName="fechaCierre" Caption="Fecha Cierre" />

                  
                            </Columns>





                            <Settings ShowFilterRow="True" />
                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        </dx:ASPxGridView>
                        <asp:SqlDataSource ID="SqlDataSourceLLamadasIngenieria" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select 
LlamadaSoporte.idLlamadaSoporte,
estadosLLamadasTecnicas.nombreEstado,fechaLlamada,
llamadaRecibida,llamadaSoporte.nitCliente,clientes.nombreCliente,
serial,asesorTelefonico,ingenieroAsesor,
fechaCierre
 from LlamadaSoporte
join estadosLLamadasTecnicas on estadosLLamadasTecnicas.codEstadoLlamada = LlamadaSoporte.codEstadoLLamadaTecnica
join clientes on clientes.nitCliente = LlamadaSoporte.nitCliente
where serial = @serial order by LlamadaSoporte.idLlamadaSoporte desc">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="txtSerial" Name="serial" PropertyName="Text" />
                            </SelectParameters>
                        </asp:SqlDataSource>

                    </telerik:RadPageView>

       

                    <telerik:RadPageView ID="RadPageActividades" runat="server">

                        <dx:ASPxGridView ID="grdActividades" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceActividadesxEquipo">

                            <Columns>
                                <dx:GridViewDataColumn>
                                    <DataItemTemplate>

                                        <asp:ImageButton ID="btnVerLLamadaCientifica" Width="30px" ToolTip="Ver Tarea"
                                                         runat="server" ImageUrl="~/img/zoom.png" OnClick="btnVerLLamadaCientifica_Click1" ValidationGroup='<%# Eval("cod_tarea_calendario") %>' />

                                    </DataItemTemplate>
                                </dx:GridViewDataColumn>
                                <dx:GridViewDataTextColumn FieldName="cod_tarea_calendario" ReadOnly="True" VisibleIndex="0" Caption="Cod">
                                    <EditFormSettings Visible="False" />
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="creado_por" VisibleIndex="1" Caption="Creado Por">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataDateColumn FieldName="fecha_creacion" VisibleIndex="2" Caption="Fecha Creacion">
                                </dx:GridViewDataDateColumn>

                                <dx:GridViewDataTextColumn FieldName="nombre_estado_tarea" VisibleIndex="3" Caption="Estado">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="nit_cliente" VisibleIndex="4" Caption="Nit">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="nombreCliente" VisibleIndex="5" Caption="Cliente">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataTextColumn FieldName="responsable" VisibleIndex="6" Caption="Responsable">
                                </dx:GridViewDataTextColumn>
                                <dx:GridViewDataDateColumn FieldName="inicio" VisibleIndex="7" Caption="Inicio">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataDateColumn FieldName="fin" VisibleIndex="8" Caption="Fin">
                                </dx:GridViewDataDateColumn>
                                <dx:GridViewDataTextColumn FieldName="tipo_tarea" VisibleIndex="9" Caption="Tipo">
                                </dx:GridViewDataTextColumn>
                    
                            </Columns>
                            <SettingsPager>
                            </SettingsPager>
                            <Settings ShowFilterRow="True" />
                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        </dx:ASPxGridView>

                        <asp:SqlDataSource ID="SqlDataSourceActividadesxEquipo" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="
select 
cod_tarea_calendario, 
usuario.nombre 'creado_por', fecha_creacion, 
u2.nombre 'responsable', 
tarea_calendario.descripcion, observaciones, inicio, fin, activa,
tipo_tarea_calendario.descripcion 'tipo_tarea',
 tarea_calendario.cod_tipo_tarea_calendario, 
 requiere_aprobacion, requiere_compra_tiquetes, valor_tiquetes, 
 atado_cliente, nombreCliente,
 nombre_estado_tarea,
 nit_cliente, 
 cod_sucursal, 
 nombreSucursal,
 cod_contacto, 
 sub_tipo_tarea_calendario.cod_subtipo_tarea_calendario, 
 sub_tipo_tarea_calendario.descripcion
 obervaciones_aprobacion, u3.nombre aprobada_por, aprobada, fecha_aprobacion,
 tarea_calendario.serial
from tarea_calendario
join usuario on usuario.cod_usuario = tarea_calendario.cod_creador
join usuario u2 on u2.cod_usuario = tarea_calendario.cod_usuario
left join estado_tarea_calendario 
on estado_tarea_calendario.cod_estado_tarea_calendario = tarea_calendario.cod_estado_tarea_calendario
left join usuario u3 on u3.cod_usuario = tarea_calendario.aprobada_por
join tipo_tarea_calendario on tipo_tarea_calendario.cod_tipo_tarea_calendario = tarea_calendario.cod_tipo_tarea_calendario
left join sub_tipo_tarea_calendario on sub_tipo_tarea_calendario.cod_subtipo_tarea_calendario = tarea_calendario.cod_subtipo_tarea_calendario
left join clientes on clientes.nitcliente = tarea_calendario.nit_cliente
left join sucursalCliente on sucursalCliente.nitCliente = clientes.nitcliente  and
sucursalCliente.codSucursal = tarea_calendario.cod_sucursal
where tarea_calendario.serial =@serial
order by fecha_creacion desc">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="txtSerial" Name="serial" PropertyName="Text" />
                            </SelectParameters>
                        </asp:SqlDataSource>

                    </telerik:RadPageView>

                    <telerik:RadPageView ID="RadPageArchivos" runat="server">

                        <dx:ASPxGridView ID="grdArchivos" runat="server" AutoGenerateColumns="False"
                            DataKeyNames="serial,codArchivo" DataSourceID="odsArchivos2"
                            ForeColor="#333333" Visible="true">

                            <Columns>
                                <dx:GridViewDataColumn>
                                    <DataItemTemplate>

                                        <asp:ImageButton ID="btnVerArchivo" Width="30px" ToolTip="Ver Archivo"
                                                         runat="server" ImageUrl="~/img/zoom.png" OnClick="verArchivo"
                                                         ValidationGroup='<%# Eval("codArchivo")+"|"+Eval("nombreArchivo") %>' />
                                    </DataItemTemplate>

                                </dx:GridViewDataColumn>
                                <dx:GridViewDataTextColumn FieldName="serial" Caption="serial" ReadOnly="True" />
                                <dx:GridViewDataTextColumn FieldName="codArchivo" Caption="codArchivo" ReadOnly="True" />
                                <dx:GridViewDataTextColumn FieldName="nombreArchivo" Caption="nombreArchivo" />
                                <dx:GridViewDataTextColumn FieldName="descripcion" Caption="descripcion" />
                                <dx:GridViewDataTextColumn FieldName="codTipoArchivoxEquipo"
                                    Caption="codTipoArchivoxEquipo" />

                           

                            </Columns>








                            <Settings ShowFilterRow="True" />
                            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                        </dx:ASPxGridView>


                        <asp:SqlDataSource runat="server" ID="odsArchivos2" ConnectionString="<%$ ConnectionStrings:spx2020ConnectionString %>" SelectCommand="

SELECT archivo, codArchivo, codTipoArchivoxEquipo, descripcion, nombreArchivo, serial FROM archivosXequipo WHERE (serial = @serial)">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                            </SelectParameters>

                        </asp:SqlDataSource>


                    </telerik:RadPageView>




                </telerik:RadMultiPage>
            </div>
        </div>
    </div>
</asp:Content>

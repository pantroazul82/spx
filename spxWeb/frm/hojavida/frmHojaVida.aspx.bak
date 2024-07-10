<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmHojaVida.aspx.cs" Inherits="frm_hojavida_frmHojaVida" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTabControl" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

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
            <telerik:RadTab  runat="server" Text="Llamadas de Ingenieria">
            </telerik:RadTab>

            <telerik:RadTab  runat="server" Text="Llamadas de Cientifica">
            </telerik:RadTab>
            <telerik:RadTab  runat="server" Text="Actividades">
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
                <dx:ASPxGridView runat="server" id="grdTraslados"   
                    AutoGenerateColumns="False"   DataSourceID="odsTraslados" 
                    ForeColor="#333333"    >
                     
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="codLog" Caption="Cod"  />
                        <dx:GridViewDataDateColumn FieldName="fechaCambio" Caption="Fecha Cambio" />
                        <dx:GridViewDataDateColumn FieldName="fechaEnvio" Caption="Fecha Envio"  />
                        <dx:GridViewDataTextColumn FieldName="nitDestino" Caption="Nit Destino"  />
                        <dx:GridViewDataTextColumn FieldName="nombreDestino" Caption="Cliente Destino"  />
                        <dx:GridViewDataTextColumn FieldName="sucursalDestino" Caption="Sucursal Destino" />
                        <dx:GridViewDataTextColumn FieldName="nombreModalidadEquipo" Caption="nombreModalidadEquipo"  Visible="False" />
                        <dx:GridViewDataTextColumn FieldName="razon" Caption="Motivo"  />
                    </Columns>
                    
                     
                   <Settings ShowFilterRow="True" /> <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
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
                <dx:ASPxGridView ID="grdAuxiliares" runat="server" AutoGenerateColumns="False" 
                      DataSourceID="odsAuxiliares" ForeColor="#333333" 
                      onselectedindexchanged="GridView1_SelectedIndexChanged">
                     
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="nombrefabricante" Caption="Fabricante"  />
                        <dx:GridViewDataTextColumn FieldName="nombremodelo" Caption="Modelo"  />
                        <dx:GridViewDataTextColumn FieldName="nombretipoequipo" Caption="Tipo Equipo"  />
                        <dx:GridViewDataTextColumn FieldName="nombresubtipo" Caption="SubTipo"  />
                        <dx:GridViewDataTextColumn FieldName="serial" Caption="Serial"  />
                        <dx:GridViewDataTextColumn FieldName="nombremodalidadequipo" Caption="Modalidad"  />
                        <dx:GridViewDataTextColumn FieldName="nombreestadolocal" Caption="Estado Local"  />
                        <dx:GridViewDataTextColumn FieldName="nitCliente" Caption="Nit Cliente"  />
                        <dx:GridViewDataTextColumn FieldName="nombreCliente" Caption="Cliente" />
                        <dx:GridViewDataTextColumn FieldName="nombreSucursal" Caption="Sucursal" />
                            <dx:GridViewDataColumn>
                            <DataItemTemplate>
                            <asp:ImageButton ID="btnVerHojaAuxiliar" Width="30px" ToolTip="Ver Hoja de vida" 
                            runat="server" ImageUrl="~/img/frm/logos.png" OnClick="hojaHijo" ValidationGroup='<%# Eval("Serial") %>' />
                            </DataItemTemplate>
                            </dx:GridViewDataColumn>
                    </Columns>
                    
                    
                    
                     
                     
                   <Settings ShowFilterRow="True" /> <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                   
                    
                    
                </dx:ASPxGridView>
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

                <dx:ASPxGridView ID="grdOrdenServicio" runat="server"   
                    AutoGenerateColumns="False"   DataKeyNames="codOrdenServicio" 
                    DataSourceID="odsOrdenServicio" ForeColor="#333333"  >
                     
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="codOrdenServicio" Caption="Orden Servicio" 
                            ReadOnly="True"  />
                        <dx:GridViewDataTextColumn FieldName="estado" Caption="Estado" 
                             />
                        <dx:GridViewDataDateColumn FieldName="fechaProgramacion" Caption="Fecha Programacion" 
                             />
                        <dx:GridViewDataTextColumn FieldName="nombretipoServicio" Caption="Tipo Servicio" 
                             />
                        <dx:GridViewDataTextColumn FieldName="asignado" Caption="asignado" 
                             />
                        <dx:GridViewDataTextColumn FieldName="observacionesIngeniero" 
                            Caption="Observaciones Ingeniero" />
                        <dx:GridViewDataTextColumn FieldName="Prioridad" Caption="Prioridad" 
                             />
                            <dx:GridViewDataColumn>
                            <DataItemTemplate>
                            
                             
                            <asp:ImageButton ID="btnVerOrdenServicio" Width="30px" ToolTip="Ver Orden Servicio" 
                            runat="server" ImageUrl="~/img/zoom.png" OnClick="verOrdenServicio" ValidationGroup='<%# Eval("codOrdenServicio") %>' />
                            </DataItemTemplate>
                            
                            
                            </dx:GridViewDataColumn>
                            
                    </Columns>
                    
                    
                    
                     
                     
                   <Settings ShowFilterRow="True" /> <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
                <asp:ObjectDataSource ID="odsOrdenServicio" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataBySerial"
                    TypeName="SPControladoraDatos.dsPlantillasTableAdapters.pltinfEquipoOSTableAdapter">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
    
    </telerik:RadPageView>

            <telerik:RadPageView ID="RadPageLlamadasIngnieria" runat="server">

                <dx:ASPxGridView ID="grdLlamadasIngenieria" runat="server"   
                    AutoGenerateColumns="False"   DataKeyNames="idLlamadaSoporte" 
                    DataSourceID="SqlDataSourceLLamadasIngenieria" ForeColor="#333333"  >
                     
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="idLlamadaSoporte" Caption="Cod" 
                            ReadOnly="True"   />
                        <dx:GridViewDataTextColumn FieldName="nombreEstado" Caption="Estado" 
                             />
                        <dx:GridViewDataTextColumn FieldName="fechaLlamada" Caption="Fecha Llamada" 
                             />
                        <dx:GridViewDataCheckColumn FieldName="llamadaRecibida" Caption="LLamada Recibida"  />
                        <dx:GridViewDataTextColumn FieldName="nitCliente" Caption="Nit Cliente" />
                        <dx:GridViewDataTextColumn FieldName="nombreCliente" Caption="Cliente" />
                        <dx:GridViewDataTextColumn FieldName="asesorTelefonico" Caption="Asesor Telefonico" />
                        <dx:GridViewDataTextColumn FieldName="ingenieroAsesor" Caption="Ingeniero Asesor"  />
                            <dx:GridViewDataTextColumn FieldName="fechaCierre" Caption="Fecha Cierre"  />

                             <dx:GridViewDataColumn>
                            <DataItemTemplate>
                            
                             
                            <asp:ImageButton ID="btnVerLLamadaIngenieria" Width="30px" ToolTip="Ver Llamada" 
                            runat="server" ImageUrl="~/img/zoom.png" OnClick="btnVerLLamadaIngenieria_Click" ValidationGroup='<%# Eval("idLlamadaSoporte") %>' />
                            </DataItemTemplate>
                            
                            
                            </dx:GridViewDataColumn>
                    </Columns>
                    
                    
                    
                     
                     
                   <Settings ShowFilterRow="True" /> <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
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

            <telerik:RadPageView ID="RadPageLlamadasCientifica" runat="server">

                <dx:ASPxGridView ID="grdLlamadasCientificas" runat="server"   
                    AutoGenerateColumns="False"   DataKeyNames="cod_asesoria_cientifica" 
                    DataSourceID="SqlDataSourcellamadasCientifica" ForeColor="#333333"  >
                     
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="cod_asesoria_cientifica" Caption="Cod"  />
                        <dx:GridViewDataTextColumn FieldName="nombre_estado_asesoria_cientifica" Caption="Estado"  />
                        <dx:GridViewDataDateColumn FieldName="fecha_solicitud" Caption="Fecha solicitud" />
                        <dx:GridViewDataTextColumn FieldName="usuario_creacion" Caption="Usuario creacion" />
                        <dx:GridViewDataTextColumn FieldName="nitCliente" Caption="nitCliente"  />
                        <dx:GridViewDataTextColumn FieldName="nombreCliente" Caption="Cliente"  />
                        <dx:GridViewDataDateColumn FieldName="fechaRespuestaInicial" Caption="Respuesta Inicial"  />
                        <dx:GridViewDataTextColumn FieldName="nombre_referencia_reactivo" Caption="Referencia reactivo"  Visible="False" />
                        <dx:GridViewDataTextColumn FieldName="fabricante_reactivo" Caption="fabricante_reactivo"  Visible="False" />
                        <dx:GridViewDataTextColumn FieldName="responsable" Caption="responsable"  />
                        <dx:GridViewDataDateColumn FieldName="fecha_cierre" Caption="fecha_cierre"  />
                        <dx:GridViewDataCheckColumn FieldName="solucionado" Caption="solucionado"  />
                            			<dx:GridViewDataColumn>
				<DataItemTemplate>
                            <asp:ImageButton ID="btnVerLLamadaCientifica" Width="30px" ToolTip="Ver Llamada" 
                            runat="server" ImageUrl="~/img/zoom.png" OnClick="btnVerLLamadaCientifica_Click" ValidationGroup='<%# Eval("cod_asesoria_cientifica") %>' />
                </DataItemTemplate>
            </dx:GridViewDataColumn>
                    </Columns>
                    
                     
                   <Settings ShowFilterRow="True" /> <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
                <asp:SqlDataSource ID="SqlDataSourcellamadasCientifica" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select 
usuario.nombre 'interno',ind_interna,
asesoria_cientifica.cod_asesoria_cientifica,
estado_asesoria_cientifica.nombre_estado_asesoria_cientifica,
 asesoria_cientifica.cod_estado_asesoria_cientifica, asesoria_cientifica.cod_prioridad_sugerida,
 prioridad_callcenter_cientifica.nombre_prioridad 'prioridad_sugerida', asesoria_cientifica.cod_prioridad_callcenter_cientifica, 
 p2.nombre_prioridad 'prioridad'  
  ,asesoria_cientifica.fecha_solicitud, asesoria_cientifica.usuario_creacion,
   asesoria_cientifica.nitCliente,clientes.nombreCliente, asesoria_cientifica.codSucursal,
   sucursalCliente.nombreSucursal,ciudades.nombreCiudad
   , asesoria_cientifica.codContacto, asesoria_cientifica.infAdicionalContacto, asesoria_cientifica.fecha_respuesta_inicial fechaRespuestaInicial,
    asesoria_cientifica.cod_referencia_reactivo,referencia_reactivo.nombre_referencia_reactivo,fabricante.nombre_fabricante 'fabricante_reactivo',
     asesoria_cientifica.motivo_consulta, asesoria_cientifica.respuesta_inicial, asesoria_cientifica.informacionSuministradaInicial,
      asesoria_cientifica.responsable, 
asesoria_cientifica.codFabricante,fabricante_1.nombre_fabricante nombreFabricante, asesoria_cientifica.codModelo,Modelos.NombreModelo,
 asesoria_cientifica.serial, asesoria_cientifica.fecha_visita, asesoria_cientifica.dias_solucion, asesoria_cientifica.numero_reporte_qc,
  asesoria_cientifica.fecha_cierre, asesoria_cientifica.solucionado, 
asesoria_cientifica.no_porque, asesoria_cientifica.conforme, asesoria_cientifica.no_conforme_porque,
 asesoria_cientifica.cerrada_por, 
asesoria_cientifica.cod_inconveniente_presentado_cientifica,inconveniente_presentado_cientifica.nombre_inconveniente, 
asesoria_cientifica.cod_reactivo_cierre,
 asesoria_cientifica.lote_reactivo, asesoria_cientifica.vencimiento_reactivo, 
asesoria_cientifica.llamada_recibida_disponibilidad,
 asesoria_cientifica.cod_motivo_anulacion_cientifica,motivo_anulacion_cientifica.motivo_anulacion,
  asesoria_cientifica.informacionAdicionalAnulacion,
fecha_solicitud,

fecha_sugerida,fecha_primer_seguimiento,

DATEDIFF(day,fecha_solicitud,fecha_sugerida) - dbo.d_festivos (fecha_solicitud,fecha_sugerida) 'A',
DATEDIFF(day,fecha_solicitud,fecha_primer_seguimiento) - dbo.d_festivos (fecha_solicitud,fecha_primer_seguimiento) 'B',
DATEDIFF(day,fecha_solicitud,fecha_cerrada_seguimiento) - dbo.d_festivos (fecha_solicitud,fecha_cerrada_seguimiento) 'C',
DATEDIFF(day,fecha_solicitud,fecha_cierre) - dbo.d_festivos (fecha_solicitud,fecha_cierre) 'D',

DATEDIFF(day,fecha_sugerida,fecha_primer_seguimiento) - dbo.d_festivos (fecha_sugerida,fecha_primer_seguimiento) 'E',
DATEDIFF(day,fecha_sugerida,fecha_cerrada_seguimiento) - dbo.d_festivos (fecha_sugerida,fecha_cerrada_seguimiento) 'F',
DATEDIFF(day,fecha_sugerida,fecha_cierre) - dbo.d_festivos (fecha_sugerida,fecha_cierre) 'G',

DATEDIFF(day,fecha_primer_seguimiento,fecha_cerrada_seguimiento) - dbo.d_festivos (fecha_primer_seguimiento,fecha_cerrada_seguimiento) 'H',
DATEDIFF(day,fecha_primer_seguimiento,fecha_cierre) - dbo.d_festivos (fecha_primer_seguimiento,fecha_cierre) 'I',

DATEDIFF(day,fecha_cerrada_seguimiento,fecha_cierre) - dbo.d_festivos (fecha_cerrada_seguimiento,fecha_cierre) 'J'

 from asesoria_cientifica
left join inconveniente_presentado_cientifica on inconveniente_presentado_cientifica.cod_inconveniente_presentado_cientifica= asesoria_cientifica.cod_inconveniente_presentado_cientifica
INNER JOIN estado_asesoria_cientifica 
                      ON asesoria_cientifica.cod_estado_asesoria_cientifica = estado_asesoria_cientifica.cod_estado_asesoria_cientifica 
left JOIN prioridad_callcenter_cientifica
					 ON asesoria_cientifica.cod_prioridad_sugerida = prioridad_callcenter_cientifica.cod_prioridad_callcenter_cientifica 
left JOIN prioridad_callcenter_cientifica p2
                     ON asesoria_cientifica.cod_prioridad_callcenter_cientifica = p2.cod_prioridad_callcenter_cientifica 
left JOIN          clientes ON asesoria_cientifica.nitCliente = clientes.nitCliente 
left JOIN  sucursalCliente ON asesoria_cientifica.nitCliente = sucursalCliente.nitCliente AND asesoria_cientifica.codSucursal = sucursalCliente.codSucursal 
left join motivo_anulacion_cientifica on motivo_anulacion_cientifica.cod_motivo_anulacion_cientifica = asesoria_cientifica.cod_motivo_anulacion_cientifica
left JOIN referencia_reactivo ON asesoria_cientifica.cod_referencia_reactivo = referencia_reactivo.cod_referencia_reactivo 
left JOIN fabricante ON referencia_reactivo.codFabricante = fabricante.codFabricante 
left JOIN fabricante AS fabricante_1 ON asesoria_cientifica.codFabricante = fabricante_1.codFabricante
left JOIN Modelos ON asesoria_cientifica.codFabricante = Modelos.codFabricante AND asesoria_cientifica.codModelo =Modelos.codModelo 
left join ciudades on sucursalCliente.codDepartamento = ciudades.codDepartamento and sucursalCliente.codPais = ciudades.codPais and ciudades.codCiudad= sucursalCliente.codCiudad
left join usuario on usuario.login = asesoria_cientifica.usuario_interna
where serial = @serial order by cod_asesoria_cientifica desc">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="txtSerial" Name="serial" PropertyName="Text" />
                    </SelectParameters>
                </asp:SqlDataSource>
    
    </telerik:RadPageView>

            <telerik:RadPageView ID="RadPageActividades" runat="server">

                <dx:ASPxGridView ID="grdActividades" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceActividadesxEquipo" >
                    
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="cod_tarea_calendario"  ReadOnly="True" VisibleIndex="0" Caption="Cod">
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
                        <dx:GridViewDataColumn>
                            <DataItemTemplate>

                                   <asp:ImageButton ID="btnVerLLamadaCientifica" Width="30px" ToolTip="Ver Tarea" 
                            runat="server" ImageUrl="~/img/zoom.png" OnClick="btnVerLLamadaCientifica_Click1" ValidationGroup='<%# Eval("cod_tarea_calendario") %>' />

                </DataItemTemplate>
                        </dx:GridViewDataColumn>
                    </Columns>
                    <SettingsPager  >
                    </SettingsPager>
                    <Settings ShowFilterRow="True" /> <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
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
                      DataKeyNames="serial,codArchivo" DataSourceID="odsArchivos" 
                    ForeColor="#333333"   Visible="true">
                     
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="serial" Caption="serial" ReadOnly="True" 
                             />
                        <dx:GridViewDataTextColumn FieldName="codArchivo" Caption="codArchivo" ReadOnly="True" 
                            />
                        <dx:GridViewDataTextColumn FieldName="nombreArchivo" Caption="nombreArchivo" 
                            />
                        <dx:GridViewDataTextColumn FieldName="descripcion" Caption="descripcion" 
                             />
                        <dx:GridViewDataTextColumn FieldName="codTipoArchivoxEquipo" 
                            Caption="codTipoArchivoxEquipo"  />
                        
                        <dx:GridViewDataColumn>
                            <DataItemTemplate>
                             
                            <asp:ImageButton ID="btnVerArchivo" Width="30px" ToolTip="Ver Archivo" 
                            runat="server" ImageUrl="~/img/zoom.png" OnClick="verArchivo"
                            ValidationGroup='<%# Eval("codArchivo")+"|"+Eval("nombreArchivo") %>'/>
                            </DataItemTemplate>
                            
                        </dx:GridViewDataColumn>
                            
                    </Columns>
                   
                        
                    
                    
                    
                    
                     
                     
                   <Settings ShowFilterRow="True" /> <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>

   
       <asp:ObjectDataSource ID="odsArchivos" runat="server" DeleteMethod="Delete" 
                    InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                    SelectMethod="GetDataBySerial" 
                    TypeName="SPControladoraDatos.dsSpxTableAdapters.archivosXequipoTableAdapter" 
                    UpdateMethod="Update">

                    <SelectParameters>
                        <asp:QueryStringParameter Name="serial" QueryStringField="sx" Type="String" />
                    </SelectParameters>
                    
                </asp:ObjectDataSource>
    </telerik:RadPageView>

        

  
    </telerik:RadMultiPage>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmDetalleContrato.aspx.cs" Inherits="frm_csuministro_frmDetalleContrato" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />   <style type="text/css">
    
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
    </style>

    <script type="text/javascript">
        var qc = 0;
        function clickOnce(btn, msg) {
            if (qc > 0) {
                alert('Ya se envio el formulario. Por favor espere');
                return false;
            } else {
                qc = qc + 1;
                return true;
            }
        }
</script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Contratos de suministro"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>


    <table>
        <tr>            <td>Codigo contrato</td>
            <td><asp:Label ID="lblcodigoContrato" runat="server" Font-Size="12pt" ForeColor="#0033CC"></asp:Label></td>
            <td>ESTADO</td>
            <td><asp:Label ID="lblEstado" runat="server" Font-Size="12pt" ForeColor="#0033CC"></asp:Label></td>

        </tr>
    </table>

    <div class="tab">Contrato de Suministro.</div>

    <table>
        <tr>
            <td>
                <asp:Button id="btnImprimir" runat="server" Text="Imprimir" /> 

            </td>
            <td>
                <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" /> 

            </td>
            <td>
                <asp:Button ID="btnAprobarDinamico" runat="server" Text="Aprobar/Cambiar Estado" OnClick="btnAprobarDinamico_Click" /> 

                <asp:Button ID="btnAnular" runat="server" Text="Anular" OnClick="btnAnular_Click" /> 

            </td>
            <td>
    <asp:Button ID="btnReabrir" runat="server" Visible="false" Text="Re abrir" OnClick="btnReabrir_Click" OnClientClick="return confirm('Esta seguro de reabrir el contrato?');" /> 
         

            </td>
            <td>
                <asp:Button ID="btnGenerarOtroSi" runat="server" Text="Generar Otro Si" />

            </td>
            <td></td>
            <td>
             
            </td>
            <td>
               

            </td>
        </tr>
    </table>

    <telerik:RadTabStrip ID="RadTabStripFormulario" runat="server" 
        MultiPageID="radMultiGeneral" SelectedIndex="0">
        <Tabs>
       
            <telerik:RadTab runat="server" Text="General" Selected="True">
            </telerik:RadTab>

            <telerik:RadTab runat="server"  Text="Polizas/Pagos adicionales">

            </telerik:RadTab>

            <telerik:RadTab runat="server" Text="Otros si">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Documentos Anexos">
            </telerik:RadTab>
            <telerik:RadTab runat="server" Text="Archivos">
            </telerik:RadTab>
             <telerik:RadTab runat="server" Text="Experiencia">
            </telerik:RadTab>
             <telerik:RadTab runat="server" Text="Log de Cambios de estado">
            </telerik:RadTab>
        </Tabs>
    </telerik:RadTabStrip>
       <telerik:RadMultiPage ID="radMultiGeneral" runat="server" SelectedIndex="0">
           <telerik:RadPageView ID="RadPageViewGeneral"  runat="server"><div class="Formular6ioSimple" style="background-color:whitesmoke !important;font-size:11px;padding-left:8px;">
               
               <table class="auto-style1">
                   <tr>
                       <td></td>
                       <td></td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Fecha Creado</td>
                       <td>
                           <dx:ASPxDateEdit ID="calCreacion" runat="server" EditFormat="DateTime" Enabled="False" Width="180px"><timesectionproperties visible="True"></timesectionproperties></dx:ASPxDateEdit>
                       </td>
                       <td>&nbsp;</td>
                       <td>Creado por</td>
                       <td>
                           <asp:Label ID="lblCreadoPor" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Fecha de Inicio</td>
                       <td>
                           <div style="max-width:initial !important;">
                               <dx:ASPxDateEdit ID="calFechaInicio" runat="server" Enabled="False" Width="100px"></dx:ASPxDateEdit>
                           </div>
                       </td>
                       <td>&nbsp;</td>
                       <td>
                           <asp:Label ID="Label3" runat="server" Text="Fecha de terminacion"></asp:Label>
                       </td>
                       <td>
                           <dx:ASPxDateEdit ID="calFechaTerminacion" runat="server" Enabled="False" Width="100px"></dx:ASPxDateEdit>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Fecha Ultimo Otro Si</td>
                       <td>
                           <dx:ASPxDateEdit ID="calFechaUltimoOtroSi" runat="server" Enabled="False" Width="100px"></dx:ASPxDateEdit>
                       </td>
                       <td>&nbsp;</td>
                       <td>Otro Si</td>
                       <td>
                           <asp:Label ID="lblOtroSi" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Numero contrato</td>
                       <td>
                           <asp:Label ID="lblNumeroContrato" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>Consecutivo Interno</td>
                       <td>
                           <asp:Label ID="lblConsecutivoInterno" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>&nbsp;</td>
                       <td colspan="4">&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Cliente</td>
                       <td colspan="4">
                           <asp:Label ID="lblcliente" runat="server"></asp:Label>
                           &nbsp;&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="frmHojaVidaCliente.aspx?nit=" Target="_blank">Ver Hoja de Vida</asp:HyperLink></td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Sucursal</td>
                       <td colspan="4">
                           <asp:Label ID="lblSucursal" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Contacto</td>
                       <td>
                           <asp:Label ID="lblContacto" runat="server"></asp:Label>
                           &nbsp;</td>
                       <td>&nbsp;</td>
                       <td>
                           <asp:CheckBox ID="chkGeneraMulta" runat="server" Enabled="False" Text="Genera Multa" />
                       </td>
                       <td>
                           <asp:Label ID="lblFechaLimite" runat="server" Text="Fecha limite legalizacion"></asp:Label>
                       </td>
                       <td>
                           <dx:ASPxDateEdit ID="calLimiteLegalizacion" runat="server" EditFormat="DateTime" Enabled="False">
                           </dx:ASPxDateEdit>
                       </td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Direccion envio contrato</td>
                       <td colspan="4">
                           <asp:Label ID="lbldireccionEnvio" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Ciudad envio contrato</td>
                       <td>
                           <asp:Label ID="lblCiudadEnvioContrato" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Contacto Juridico</td>
                       <td>
                           <asp:Label ID="lblContactoJuridico" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>Celular contacto juridico</td>
                       <td>
                           <asp:Label ID="lblCelularContactoJuridico" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Valor Contrato</td>
                       <td>
                           <asp:Label ID="lblValorContrato" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>
                           <asp:CheckBox ID="chkAplicaEstampilla" runat="server" Enabled="False" Text="Aplica Estampilla" />
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Observaciones</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>
                           <asp:CheckBox ID="chkAplicaPolizas" runat="server" Enabled="False" Text="Aplica Polizas" />
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td colspan="4">
                           <asp:TextBox ID="txtObservaciones" runat="server" Enabled="False" Height="98px" TextMode="MultiLine" Width="680px"></asp:TextBox>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td colspan="5">&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td colspan="5">&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
               </table>
               </div></telerik:RadPageView>

            <telerik:RadPageView ID="radPolizas"  runat="server">Polizas <asp:Button ID="btnAgregarPoliza" runat="server" OnClick="btnAgregarPoliza_Click" Text="Agregar Poliza" /><br />
                <dx:ASPxGridView ID="grdPoliza" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourcePolizas" KeyFieldName="cod_polizas_contrato_suministro"><Columns><dx:GridViewDataTextColumn FieldName="cod_polizas_contrato_suministro" ReadOnly="True" Visible="false" VisibleIndex="0"><editformsettings visible="False" /></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Visible="false" VisibleIndex="1"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn Caption="Nombre" FieldName="nombre_poliza" VisibleIndex="2" Width="200px"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn Caption="%" FieldName="porcentaje" VisibleIndex="3"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn Caption="Valor" FieldName="valor_poliza" VisibleIndex="4"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn Caption="Vigencia Meses" FieldName="vigencia_meses" VisibleIndex="5"></dx:GridViewDataTextColumn><dx:GridViewDataColumn><dataitemtemplate><asp:Button ID="btnEditarPoliza" runat="server" CommandArgument='<%# Eval("cod_polizas_contrato_suministro") %>' OnClick="btnEditarPoliza_Click" Text="Editar" Visible="<%# btnAgregarPoliza.Visible %>" /><asp:Button ID="btnEliminarPoliza" runat="server" CommandArgument='<%# Eval("cod_polizas_contrato_suministro") %>' OnClick="btnEliminarPoliza_Click" OnClientClick="return confirm('Esta seguro de eliminar el registro?');" Text="Eliminar" Visible="<%# btnAgregarPoliza.Visible %>" /></dataitemtemplate></dx:GridViewDataColumn>
                </Columns>
                <settingspager visible="False">
                </settingspager>
                <settingsdatasecurity allowdelete="False" allowedit="False" allowinsert="False" />
                </dx:ASPxGridView>
                <br />Estampillas y Pagos Adicionales <asp:Button ID="btnAgregarPagoAdicional" runat="server" OnClick="btnAgregarPagoAdicional_Click" Text="Agregar Pago Adicional" /><br /><dx:ASPxGridView ID="grdPagoAdicional" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourcePagosAdicionales" KeyFieldName="cod_estampillas_contrato_sumisnistro"><Columns><dx:GridViewDataTextColumn FieldName="cod_estampillas_contrato_sumisnistro" ReadOnly="True" VisibleIndex="0" Visible="False"><EditFormSettings Visible="False" /></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" VisibleIndex="1" Visible="False"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="nombre" VisibleIndex="2" Width="200px"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="porcentaje" VisibleIndex="3"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="valor" VisibleIndex="4"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="dato_consignacion" 
                                                                                                                                                                                             VisibleIndex="5" Caption="Datos Consignacion" Width="200px">                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             </dx:GridViewDataTextColumn>
                    <dx:GridViewDataColumn VisibleIndex="6"><dataitemtemplate><asp:Button ID="btnEditarEstampilla" runat="server" CommandArgument='<%# Eval("cod_estampillas_contrato_sumisnistro") %>' OnClick="btnEditarEstampilla_Click" Text="Editar" Visible="<%# btnAgregarPagoAdicional.Visible %>" /><asp:Button ID="btnEliminarEstampilla" runat="server" CommandArgument='<%# Eval("cod_estampillas_contrato_sumisnistro") %>' OnClick="btnEliminarEstampilla_Click" OnClientClick="return confirm('Esta seguro de eliminar el registro?');" Text="Eliminar" Visible="<%# btnAgregarPagoAdicional.Visible %>" /></dataitemtemplate></dx:GridViewDataColumn>
                    </Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView>
                <asp:SqlDataSource ID="SqlDataSourcePagosAdicionales" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_estampillas_contrato_sumisnistro], [cod_contratos_suministro], [nombre], [porcentaje], [valor], [dato_consignacion] FROM [estampillas_contrato_sumisnistro] WHERE ([cod_contratos_suministro] = @cod_contratos_suministro)"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" Type="Int32" /></SelectParameters></asp:SqlDataSource><br />
                <asp:SqlDataSource ID="SqlDataSourcePolizas" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_polizas_contrato_suministro], [cod_contratos_suministro], [nombre_poliza], [porcentaje], [valor_poliza], [vigencia_meses] FROM [polizas_contrato_suministro] WHERE ([cod_contratos_suministro] = @cod_contratos_suministro)"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" Type="Int32" /></SelectParameters></asp:SqlDataSource></telerik:RadPageView>

           <telerik:RadPageView ID="RadPageViewOtrosSi"  runat="server">Listado de Otros si generados al contrato</telerik:RadPageView>

           <telerik:RadPageView ID="RadPageViewDocumentosAnexos"  runat="server"><asp:Button ID="btnAdjuntarDocumento" runat="server" Text="Adjuntar Documento" /><br /><dx:ASPxGridView ID="grdDocumentosAnexos" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceDocumentosAnexos" KeyFieldName="cod_adjunto_contrato_suministro"><Columns><dx:GridViewDataTextColumn FieldName="nombre_estado_contrato" VisibleIndex="0"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="nombre_tipo_adjunto_contrato_suministro" VisibleIndex="1"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="cod_adjunto_contrato_suministro" ReadOnly="True" VisibleIndex="2"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="nombre_archivo" VisibleIndex="3"></dx:GridViewDataTextColumn><dx:GridViewDataDateColumn FieldName="fecha_creacion" VisibleIndex="4"></dx:GridViewDataDateColumn><dx:GridViewDataDateColumn FieldName="fecha_aprobacion_cartera" VisibleIndex="5"></dx:GridViewDataDateColumn><dx:GridViewDataDateColumn FieldName="fecha_aprobacion_juridico" VisibleIndex="6"></dx:GridViewDataDateColumn><dx:GridViewDataDateColumn FieldName="fecha_aprobacion_inicial" VisibleIndex="7"></dx:GridViewDataDateColumn></Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView>
               <asp:SqlDataSource ID="SqlDataSourceDocumentosAnexos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT estado_adjunto_contrato_suministro.nombre_estado_contrato, tipo_adjunto_contrato_suministro.nombre_tipo_adjunto_contrato_suministro, adjunto_contrato_suministro.cod_adjunto_contrato_suministro, adjunto_contrato_suministro.nombre_archivo, adjunto_contrato_suministro.fecha_creacion, adjunto_contrato_suministro.fecha_aprobacion_cartera, adjunto_contrato_suministro.fecha_aprobacion_juridico, adjunto_contrato_suministro.fecha_aprobacion_inicial FROM adjunto_contrato_suministro INNER JOIN estado_adjunto_contrato_suministro ON adjunto_contrato_suministro.cod_estado_adjunto_contrato_suministro = estado_adjunto_contrato_suministro.cod_estado_adjunto_contrato_suministro INNER JOIN tipo_adjunto_contrato_suministro ON adjunto_contrato_suministro.cod_tipo_adjunto_contrato_suministro = tipo_adjunto_contrato_suministro.cod_tipo_adjunto_contrato_suministro
where adjunto_contrato_suministro.cod_contratos_suministro=@cod_contratos_suministro"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" /></SelectParameters></asp:SqlDataSource></telerik:RadPageView>

           <telerik:RadPageView ID="RadPageViewArchivos"  runat="server"><br />Tipo de Archivo <asp:DropDownList ID="cmbTipoArchivo" runat="server" DataSourceID="SqlDataSourceTipoArchivo" DataTextField="nombre_archivoxcontratos_suministro" DataValueField="cod_tipoarchivoxcontratos_suministro"></asp:DropDownList><asp:FileUpload ID="FileUploadArchivo" runat="server" /><asp:SqlDataSource ID="SqlDataSourceTipoArchivo" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_tipoarchivoxcontratos_suministro], [nombre_archivoxcontratos_suministro] FROM [tipoarchivoxcontratos_suministro] ORDER BY [nombre_archivoxcontratos_suministro]"></asp:SqlDataSource><asp:Button ID="btnSubirArchivo" runat="server" OnClick="btnSubirArchivo_Click" Text="Subir Archivo" /><br /><br />
               <asp:Label ID="lblErrorArchivo" runat="server" ForeColor="Red"></asp:Label><dx:ASPxGridView ID="grdArchivo" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceArchivos" KeyFieldName="cod_archivoxcontratos_suministro"><Columns><dx:GridViewDataDateColumn FieldName="fecha_creacion" VisibleIndex="0" Caption="Creado"></dx:GridViewDataDateColumn><dx:GridViewDataTextColumn FieldName="nombre_archivo" Caption="Archivo" VisibleIndex="1"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="tipo" VisibleIndex="3" Caption="Creado"></dx:GridViewDataTextColumn><dx:GridViewDataColumn  VisibleIndex="4"><DataItemTemplate><asp:LinkButton runat="server" ID="lnkVerArchivo" Text="Ver Archivo" CommandArgument='<%# Eval("cod_archivoxcontratos_suministro") %>' OnClick="lnkVerArchivo_Click"></asp:LinkButton></DataItemTemplate></dx:GridViewDataColumn></Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView>
               <asp:SqlDataSource ID="SqlDataSourceArchivos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT archivoxcontratos_suministro.fecha_creacion, archivoxcontratos_suministro.nombre_archivo, archivoxcontratos_suministro.cod_archivoxcontratos_suministro, tipoarchivoxcontratos_suministro.nombre_archivoxcontratos_suministro AS 'tipo' FROM archivoxcontratos_suministro INNER JOIN tipoarchivoxcontratos_suministro ON archivoxcontratos_suministro.cod_tipoarchivoxcontratos_suministro = tipoarchivoxcontratos_suministro.cod_tipoarchivoxcontratos_suministro
where cod_contratos_suministro=@cod_contratos_suministro"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" /></SelectParameters></asp:SqlDataSource></telerik:RadPageView>


            <telerik:RadPageView ID="RadPageGruposYdivisiones"  runat="server">
                <br />
                Grupos de Experiencia<br />
                <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceGruposExperiencia">
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="Grupo Experiencia" FieldName="nombre_grupo_reactivo_experiencia" VisibleIndex="0" Width="200px"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Visible="False" VisibleIndex="1"></dx:GridViewDataTextColumn>
                    </Columns>
                    <settingspager visible="False">
                    </settingspager>
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
                <asp:SqlDataSource ID="SqlDataSourceGruposExperiencia" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT grupo_reactivo_experiencia.nombre_grupo_reactivo_experiencia, grupo_reactivoxcontrato_suministro.cod_contratos_suministro FROM grupo_reactivo_experiencia INNER JOIN grupo_reactivoxcontrato_suministro ON grupo_reactivo_experiencia.cod_grupo_reactivo_experiencia = grupo_reactivoxcontrato_suministro.cod_grupo_reactivo_experiencia
where cod_contratos_suministro=@cod_contratos_suministro"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                Divisiones<br />
                <dx:ASPxGridView ID="ASPxGridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceDivisiones">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Visible="False" VisibleIndex="0"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Division Experiencia" FieldName="nombre_division_experiencia_contrato_suministro" VisibleIndex="1" Width="200px"></dx:GridViewDataTextColumn>
                    </Columns>
                    <settingspager visible="False">
                    </settingspager>
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
                <asp:SqlDataSource ID="SqlDataSourceDivisiones" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT divisionxcontrato_suministro.cod_contratos_suministro, division_experiencia_contrato_suministro.nombre_division_experiencia_contrato_suministro FROM division_experiencia_contrato_suministro INNER JOIN divisionxcontrato_suministro ON division_experiencia_contrato_suministro.cod_division_experiencia_contrato_suministro = divisionxcontrato_suministro.cod_division_experiencia_contrato_suministro
where divisionxcontrato_suministro.cod_contratos_suministro=@cod_contratos_suministro"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
 
                Productos<br />
                <dx:ASPxGridView ID="grdProductosExperiencia" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceProductos">
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="Fabricante" FieldName="nombre_fabricante" VisibleIndex="0"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Producto" FieldName="nombre_producto" VisibleIndex="1"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Referencia" FieldName="codigo_manual_referencia" VisibleIndex="2"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Visible="false" VisibleIndex="3"></dx:GridViewDataTextColumn>
                    </Columns>
                    <settingspager visible="False">
                    </settingspager>
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
                <asp:SqlDataSource ID="SqlDataSourceProductos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT fabricante.nombre_fabricante, producto_experiencia_contrato.nombre_producto, producto_experiencia_contrato.codigo_manual_referencia, producto_experiencia_contratoxcontrato_conmsumo.cod_contratos_suministro FROM producto_experiencia_contrato INNER JOIN producto_experiencia_contratoxcontrato_conmsumo ON producto_experiencia_contrato.cod_producto_experiencia_contrato = producto_experiencia_contratoxcontrato_conmsumo.cod_producto_experiencia_contrato INNER JOIN fabricante ON producto_experiencia_contrato.cod_fabricante = fabricante.cod_fabricante
where  
cod_contratos_suministro = @cod_contratos_suministro"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" />
                    </SelectParameters>
                </asp:SqlDataSource>
           </telerik:RadPageView>




           <telerik:RadPageView ID="RadPageLog"  runat="server">
                <br />
                Log de cambios de estado&nbsp;
                <asp:Button ID="btnExportarExcel" runat="server" OnClick="btnExportarExcel_Click" Text="Exportar" />
                <br />
                <dx:ASPxGridView ID="grdEstados" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceLog"><Columns><dx:GridViewDataTextColumn Caption="Usuario" FieldName="nombre" VisibleIndex="0"></dx:GridViewDataTextColumn><dx:GridViewDataColumn Caption="Fecha Cambio" FieldName="fecha_cambio" VisibleIndex="1"><dataitemtemplate><asp:Label ID="lblFecha" runat="server" Text='<%# ((DateTime)Eval("fecha_cambio")).ToShortDateString()+" "+((DateTime)Eval("fecha_cambio")).ToLongTimeString() %>'></asp:Label></dataitemtemplate></dx:GridViewDataColumn><dx:GridViewDataTextColumn Caption="Estado Original" FieldName="estado_original" VisibleIndex="2"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn Caption="Estado Final" FieldName="nombre_estado_contrato_suministro" VisibleIndex="3"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn Caption="Horas" FieldName="horas" VisibleIndex="4"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn Caption="Minutos" FieldName="minutos" VisibleIndex="5"></dx:GridViewDataTextColumn><dx:GridViewDataColumn Caption="Observaciones" FieldName="observaciones_cambio" VisibleIndex="6"><dataitemtemplate><asp:TextBox ID="txtobs" runat="server" Height="50px" ReadOnly="true" Text='<%# Eval("observaciones_cambio") %>' TextMode="MultiLine" Width="400px"></asp:TextBox></dataitemtemplate></dx:GridViewDataColumn>
                </Columns>
                <settingspager pagesize="20">
                </settingspager>
                <settingsdatasecurity allowdelete="False" allowedit="False" allowinsert="False" />
                </dx:ASPxGridView>
                <dx:ASPxGridViewExporter ID="ASPxGridViewExporterEstados" runat="server" GridViewID="grdEstados"></dx:ASPxGridViewExporter>
                <asp:SqlDataSource ID="SqlDataSourceLog" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT usuario.nombre, log_cambios_estado_contratos_suministro.fecha_cambio, 
ef.nombre_estado_contrato_suministro estado_original,horas,minutos,
estado_contrato_suministro.nombre_estado_contrato_suministro, log_cambios_estado_contratos_suministro.observaciones_cambio FROM log_cambios_estado_contratos_suministro INNER JOIN estado_contrato_suministro ON log_cambios_estado_contratos_suministro.cod_estado_contrato_suministro = estado_contrato_suministro.cod_estado_contrato_suministro

INNER JOIN estado_contrato_suministro ef ON log_cambios_estado_contratos_suministro.cod_estado_contrato_suministro_original
 = ef.cod_estado_contrato_suministro
 INNER JOIN usuario ON log_cambios_estado_contratos_suministro.usuario_cambio = usuario.cod_usuario
where cod_contratos_suministro = @cod_contratos_suministro
order by cod_log_cambios_estado_contratos_suministro desc"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" />
                    </SelectParameters>
                </asp:SqlDataSource>
           
           </telerik:RadPageView>
           </telerik:RadMultiPage>

       <asp:Label style=" display:none" ID="lblInvicible" runat="server"  />   

            
    <asp:Panel style="display:none" ID="pnlEmergente" Enabled="true" runat="server"
     Height="310px" Width="450px" BackColor="LightGray">
    
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline" UpdateMode=Always>
    <ContentTemplate> 
        
    <asp:Panel  ID="pnlContenido" runat="server" BackColor="white" style="padding-left:20px;padding-top:5px;">
   

        <br />
  
    <div class="tabx" id="titulo2">Enviar a Estado 
         <asp:DropDownList runat="server" ID="cmbEstado"  ></asp:DropDownList>

               
  
 </div>
<div class= "Formulario">  
    <asp:TextBox runat="server"
        TextMode="MultiLine" Width="400px" Height="200px" ID="txtObservacionesCambioEstado"></asp:TextBox>
    


 </div>   
        <asp:Label runat="server" ID="lblErrorCambioEstado" ForeColor="Red">

        </asp:Label>
        <br />
  <asp:Button runat="server" ID="btnAceptarCambioEstado" Text="Cambiar Estado" OnClick="btnAceptarCambioEstado_Click" />  
        <asp:Button runat="server" ID="btnCancelarCambioEstado" Text="Cancelar" OnClick="btnCancelarCambioEstado_Click"  />  


        </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>  
           
    </asp:Panel>       
 

        <cca:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server"
     PopupControlID="pnlEmergente" 
                  TargetControlID="lblInvicible"
             BackgroundCssClass="modalBackground"
             DropShadow="true"
              Enabled="true">
</cca:ModalPopupExtender>   


</asp:Content>

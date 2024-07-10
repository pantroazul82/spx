<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmDetalleContrato.aspx.cs" Inherits="frm_csuministro_frmDetalleContrato" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>
<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>





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
        <tr>            <td>Consecutivo contrato</td>
            <td><asp:Label ID="lblcodigoContrato" runat="server" Font-Size="12pt" ForeColor="#0033CC"></asp:Label></td>
            <td>ESTADO</td>
            <td><asp:Label ID="lblEstado" runat="server" Font-Size="12pt" ForeColor="#0033CC"></asp:Label></td>

        </tr>
        <tr>            <td colspan="2">Suma Cambios de Estados</td>
            <td>
                <asp:Label ID="lblSumaCambiosEstado" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>

        </tr>
        <tr>            <td colspan="2">tiempo hasta la fecha actual</td>
            <td>
                <asp:Label ID="lblTiempoHastaFechaActual" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td>&nbsp;</td>

        </tr>
    </table>

    <div class="tab">Contrato de Suministro.</div>

    <table>
        <tr>
            <td>
                <asp:Button id="btnImprimir" runat="server" Text="Imprimir" OnClick="btnImprimir_Click" /> 

            </td>
            <td>
                <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" /> 

            </td>
            <td>
                <asp:Button ID="btnAprobarDinamico" runat="server" 
                  
                    OnClientClick="this.disabled = true; this.value = 'Procesando...';" 
  UseSubmitBehavior="false" 

                    Text="Aprobar/Cambiar Estado" OnClick="btnAprobarDinamico_Click" /> 

                <asp:Button ID="btnAnular" runat="server" Text="Anular" OnClick="btnAnular_Click" /> 

            </td>
            <td>
    <asp:Button ID="btnReabrir" runat="server" Visible="false" Text="Re abrir" OnClick="btnReabrir_Click" OnClientClick="return confirm('Esta seguro de reabrir el contrato?');" /> 
         

            </td>
            <td>
                <asp:Button ID="btnGenerarOtroSi" runat="server" Text="Generar Otro Si" OnClick="btnGenerarOtroSi_Click" />
                 <asp:Button ID="btnAdjuntarDocumento" runat="server" Text="Generar documento anexo"
                    OnClick="btnAdjuntarDocumento_Click" Visible="False" />
            </td>
            <td>
                <asp:UpdatePanel UpdateMode="Conditional" runat="server" ID="pnlEstatusAdjuntos">
                    <ContentTemplate>
      <asp:Label runat="server" ID="lblEstatusAdjuntos" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
         

                    </ContentTemplate>

                </asp:UpdatePanel>
             </td>
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

            <telerik:RadTab runat="server"  Text="Polizas/Estampillas">

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
                   <asp:Panel runat="server" ID="pnlOtroSi">
                   <tr>
                       <td>Tipo otro si</td>
                       <td>
                           <asp:DropDownList ID="cmbTipoOtroSi" runat="server" DataSourceID="SqlDataSourcetipoOtroSi" DataTextField="nombre_tipo_otro_si_suministro" DataValueField="cod_tipo_otro_si_suministro" Enabled="False">
                           </asp:DropDownList>
                           <asp:SqlDataSource ID="SqlDataSourcetipoOtroSi" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_tipo_otro_si_suministro], [nombre_tipo_otro_si_suministro] FROM [tipo_otro_si_suministro]"></asp:SqlDataSource>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td>Observaciones Otro si</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
                   <tr>
                       <td colspan="5">
                           <asp:TextBox ID="txtObservacionesOtroSi" runat="server" Enabled="False" Height="98px" TextMode="MultiLine" Width="680px"></asp:TextBox>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                   </tr>
</asp:Panel>
                   <tr>
                       <td>Numero contrato</td>
                       <td>
                           <asp:Label ID="lblNumeroContrato" runat="server"></asp:Label>
                       </td>
                       <td>&nbsp;</td>
                       <td>&nbsp;</td>
                       <td>
                           &nbsp;</td>
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
                           <dx:ASPxDateEdit ID="calLimiteLegalizacion" runat="server" EditFormat="DateTime" Enabled="False">
                           </dx:ASPxDateEdit>
                       </td>
                       <td>
                           &nbsp;</td>
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

            <telerik:RadPageView ID="radPolizas"  runat="server">Polizas 
                <asp:Button ID="btnAgregarPoliza" runat="server" OnClick="btnAgregarPoliza_Click" Text="Agregar Poliza" Visible="false" /><br />
                <dx:ASPxGridView ID="grdPoliza" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSourcePolizas" KeyFieldName="cod_polizas_contrato_suministro"><Columns>
                    <dx:GridViewDataTextColumn FieldName="cod_polizas_contrato_suministro" ReadOnly="True" Visible="false" VisibleIndex="0">
                        <editformsettings visible="False" /></dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Visible="false" VisibleIndex="1"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_riesgo_poliza_consumo" Caption="Riesgo" Visible="true" VisibleIndex="1"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="porcentaje" Visible="true" VisibleIndex="2"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataColumn FieldName="valor_poliza" Visible="true"  VisibleIndex="3">
                            <DataItemTemplate >
                                <asp:Label runat="Server" text='<%# String.Format("{0:c}",Eval("valor_poliza")) %>'></asp:Label>
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                        <dx:GridViewDataTextColumn FieldName="vigencia_meses" Visible="true" Caption="Vigencia" VisibleIndex="4"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="observaciones" Visible="true" VisibleIndex="5"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_cod_aseguradora_suministro" Caption="Aseguradora" Visible="true" VisibleIndex="6"></dx:GridViewDataTextColumn>


                        <dx:GridViewDataColumn Visible="true"  Caption="Archivo" VisibleIndex="7">
         <dataitemtemplate>
                        <asp:HyperLink ID="lnkArchivoPoliza" runat="server"  NavigateUrl='<%# Eval("url_archivo_poliza") %>' 
                            Text="Ver Archivo" Target="_blank"
                            Visible='<%# (Eval("url_archivo_poliza") != null && Eval("url_archivo_poliza") != System.DBNull.Value) %>' />
        </dataitemtemplate>
                    </dx:GridViewDataColumn>
                        <dx:GridViewDataColumn Visible="true"><dataitemtemplate>
                        <asp:Button ID="btnEditarPoliza" runat="server" CommandArgument='<%# Eval("cod_polizas_contrato_suministro") %>' OnClick="btnEditarPoliza_Click" Text="Editar" Visible="<%# btnAgregarPoliza.Visible %>" />
                        <asp:Button ID="btnEliminarPoliza" runat="server" CommandArgument='<%# Eval("cod_polizas_contrato_suministro") %>' OnClick="btnEliminarPoliza_Click" OnClientClick="return confirm('Esta seguro de eliminar el registro?');" Text="Eliminar" 
                            Visible="<%# btnAgregarPoliza.Visible %>" /></dataitemtemplate>

                    </dx:GridViewDataColumn>
                </Columns>
                <settingspager visible="False">
                </settingspager>
                <settingsdatasecurity allowdelete="False" allowedit="False" allowinsert="False" />
                </dx:ASPxGridView>


                <br />Estampillas <asp:Button Visible="false" ID="btnAgregarEstampillas" runat="server" OnClick="btnAgregarPagoAdicional_Click" Text="Agregar Estampillas" /><br />
                <dx:ASPxGridView ID="grdPagoAdicional" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourcePagosAdicionales" KeyFieldName="cod_estampillas_contrato_sumisnistro">
                    <Columns>
                    <dx:GridViewDataTextColumn FieldName="cod_estampillas_contrato_sumisnistro" ReadOnly="True" VisibleIndex="0" Visible="False"><EditFormSettings Visible="False" /></dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" VisibleIndex="1" Visible="False"></dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Banco" FieldName="nombre_banco_suministro" VisibleIndex="2" Width="200px">                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Cuenta" FieldName="cuentabanco" VisibleIndex="3" Width="200px">                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tipo" FieldName="nombre_tipo_cuenta_banco" VisibleIndex="4" Width="200px">                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Beneficiario" FieldName="beneficiario" VisibleIndex="5" Width="200px">                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Destinacion" FieldName="nombre_destinacion_suministro" VisibleIndex="6" Width="200px">                    </dx:GridViewDataTextColumn>
                    
                    <dx:GridViewDataTextColumn Caption="%" FieldName="porcentaje" VisibleIndex="7"></dx:GridViewDataTextColumn>
                    <dx:GridViewDataColumn Caption="Valor" FieldName="valor" VisibleIndex="8">
                          <DataItemTemplate >
                                <asp:Label ID="Label2" runat="Server" text='<%# String.Format("{0:c}",Eval("valor")) %>'></asp:Label>
                            </DataItemTemplate>
                    </dx:GridViewDataColumn>

                        <dx:GridViewDataCheckColumn FieldName="pago_cliente" VisibleIndex="9" Caption="No Pago">
                        </dx:GridViewDataCheckColumn>

                        





                          <dx:GridViewDataColumn Visible="true" Caption="Archivo" VisibleIndex="10">
         <dataitemtemplate>
                        <asp:HyperLink ID="lnkArchivoEstampilla" runat="server"  NavigateUrl='<%# Eval("url_archivo") %>' 
                            Text="Ver Archivo" Target="_blank"
                            Visible='<%# (Eval("url_archivo") != null && Eval("url_archivo") != System.DBNull.Value && Eval("url_archivo").ToString() != string.Empty) %>' />
        </dataitemtemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn VisibleIndex="10" >
                        <dataitemtemplate><asp:Button ID="btnEditarEstampilla" runat="server" CommandArgument='<%# Eval("cod_estampillas_contrato_sumisnistro") %>' OnClick="btnEditarEstampilla_Click" Text="Editar" 
                        Visible="<%# btnAgregarEstampillas.Visible %>" /><asp:Button ID="btnEliminarEstampilla" runat="server" CommandArgument='<%# Eval("cod_estampillas_contrato_sumisnistro") %>' OnClick="btnEliminarEstampilla_Click" OnClientClick="return confirm('Esta seguro de eliminar el registro?');" Text="Eliminar" Visible="<%# btnAgregarEstampillas.Visible %>" /></dataitemtemplate></dx:GridViewDataColumn>
                    </Columns>
                    <SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView>
                <asp:SqlDataSource ID="SqlDataSourcePagosAdicionales" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                    SelectCommand="SELECT   url_archivo, estampillas_contrato_sumisnistro.cod_estampillas_contrato_sumisnistro, destinacion_suministro.cod_destinacion_suministro, 
                    pago_cliente,
                         destinacion_suministro.nombre_destinacion_suministro, tipo_cuenta_banco.cod_tipo_cuenta_banco, tipo_cuenta_banco.nombre_tipo_cuenta_banco, 
                         banco_suministro.cod_banco_suministro, banco_suministro.nombre_banco_suministro, estampillas_contrato_sumisnistro.porcentaje, 
                         estampillas_contrato_sumisnistro.valor, estampillas_contrato_sumisnistro.cod_contratos_suministro, estampillas_contrato_sumisnistro.beneficiario, 
                         estampillas_contrato_sumisnistro.cuentabanco
FROM            estampillas_contrato_sumisnistro INNER JOIN
                         banco_suministro ON estampillas_contrato_sumisnistro.cod_banco_suministro = banco_suministro.cod_banco_suministro INNER JOIN
                         tipo_cuenta_banco ON estampillas_contrato_sumisnistro.cod_tipo_cuenta_banco = tipo_cuenta_banco.cod_tipo_cuenta_banco INNER JOIN
                         destinacion_suministro ON estampillas_contrato_sumisnistro.cod_destinacion_suministro = destinacion_suministro.cod_destinacion_suministro
                    
               

                     WHERE (estampillas_contrato_sumisnistro.[cod_contratos_suministro] = @cod_contratos_suministro)"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" Type="Int32" /></SelectParameters></asp:SqlDataSource><br />
          
                
                      <asp:SqlDataSource ID="SqlDataSourcePolizas" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                    SelectCommand="SELECT 
 polizas_contrato_suministro.[cod_polizas_contrato_suministro],  polizas_contrato_suministro.[cod_contratos_suministro],
  polizas_contrato_suministro.[observaciones],  polizas_contrato_suministro.[cod_riesgo_poliza_consumo],
  polizas_contrato_suministro.[porcentaje],  polizas_contrato_suministro.[valor_poliza],
  polizas_contrato_suministro.[vigencia_meses],  riesgo_poliza_consumo.nombre_riesgo_poliza_consumo,
  aseguradora_suministro.nombre_cod_aseguradora_suministro,
  url_archivo_poliza
FROM [polizas_contrato_suministro] 
					join riesgo_poliza_consumo on riesgo_poliza_consumo.cod_riesgo_poliza_consumo = polizas_contrato_suministro.cod_riesgo_poliza_consumo
					left join aseguradora_suministro on aseguradora_suministro.cod_aseguradora_suministro=
					polizas_contrato_suministro.cod_aseguradora_suministro
                    WHERE ([cod_contratos_suministro] = @cod_contratos_suministro)"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" Type="Int32" /></SelectParameters></asp:SqlDataSource></telerik:RadPageView>

           <telerik:RadPageView ID="RadPageViewOtrosSi"  runat="server">Listado de Otros si generados al contrato<br />
            
                 <dx:ASPxGridView ID="grdOtroSi" runat="server" AutoGenerateColumns="False" ViewStateMode="Disabled" DataSourceID="SqlDataSourceOtroSi">
            <Columns>
                <dx:GridViewDataColumn VisibleIndex="0">
                    <DataItemTemplate>
                        <asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" Target="_blank" NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>
                    </DataItemTemplate>

                </dx:GridViewDataColumn>
                  <dx:GridViewDataTextColumn FieldName="nombre_estado_contrato_suministro" Visible="false" Caption="Estado" VisibleIndex="1">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="numero_contrato" Caption="Numero Contrato" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="consecutivo_interno" Caption="Consecutivo Interno" VisibleIndex="3">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="nitcliente" Caption="Nit Cliente" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="contacto_juridico" Caption="" VisibleIndex="5" Visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="numero_celular_contacto_juridico" Caption="" VisibleIndex="6" Visible="false">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn FieldName="fecha_incio" Caption="Inicia" VisibleIndex="7">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataDateColumn FieldName="fecha_terminacion" Caption="Termina" VisibleIndex="8">
                </dx:GridViewDataDateColumn>
               
                <dx:GridViewDataTextColumn FieldName="valor_contrato" Caption="Valor Contrato" VisibleIndex="12">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="otrosi" Caption="Otro Si" VisibleIndex="13">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="observaciones_otro_si" Caption="Observaciones" VisibleIndex="14">
                </dx:GridViewDataTextColumn>
            </Columns>
            <Settings ShowFilterRow="True" />
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        </dx:ASPxGridView>
           
               <asp:SqlDataSource ID="SqlDataSourceOtroSi" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT 
cod_contratos_suministro,[numero_contrato],observaciones_otro_si, [consecutivo_interno], [nitcliente], [contacto_juridico], [numero_celular_contacto_juridico], [fecha_incio],
                    [fecha_terminacion],  [valor_contrato],
 [otrosi],estado_contrato_suministro.nombre_estado_contrato_suministro 


 FROM 
 [contratos_suministro] 
 join estado_contrato_suministro on estado_contrato_suministro.cod_estado_contrato_suministro = contratos_suministro.cod_estado_contrato_suministro   
 where 
 cod_contratos_suministro != @codContrato and consecutivo_interno =@consecutivoInterno
 
 order by cod_contratos_suministro desc
">
                   <SelectParameters>
                       <asp:QueryStringParameter Name="codContrato" QueryStringField="cod" />
                       <asp:ControlParameter ControlID="lblNumeroContrato" Name="consecutivoInterno" PropertyName="Text" />
                   </SelectParameters>
               </asp:SqlDataSource>
           
           </telerik:RadPageView>

           <telerik:RadPageView ID="RadPageViewDocumentosAnexos"  runat="server">
              <br />

               <asp:UpdatePanel runat="server" ID="pnlGrillaAdjuntos" UpdateMode="Conditional">
                   <ContentTemplate>
                       
               <dx:ASPxGridView ID="grdDocumentosAnexos" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceDocumentosAnexos" 
                   KeyFieldName="cod_adjunto_contrato_suministro">
                   <Columns>
                       <dx:GridViewDataTextColumn Visible="false" FieldName="cod_adjunto_contrato_suministro" VisibleIndex="0" ReadOnly="True">
                           <EditFormSettings Visible="False" />
                       </dx:GridViewDataTextColumn>

                       <dx:GridViewDataTextColumn FieldName="nombre_tipo_adjunto_contrato_suministro" Caption="Tipo"
                            VisibleIndex="1">

                       </dx:GridViewDataTextColumn>
                       
                       <dx:GridViewDataTextColumn FieldName="nombre_estado_contrato" Caption="Estado" VisibleIndex="2">
                       </dx:GridViewDataTextColumn>

                       <dx:GridViewDataDateColumn FieldName="fecha_creacion" Caption="Creado" VisibleIndex="3">
                       </dx:GridViewDataDateColumn>

                       
                       <dx:GridViewDataTextColumn FieldName="nombre" Caption="Creado por" VisibleIndex="4">
                       </dx:GridViewDataTextColumn>
                       <dx:GridViewDataColumn Visible="true" Caption="Observaciones" VisibleIndex="5">
         <dataitemtemplate>
             <asp:TextBox runat="server" ID="txtObservacionesiniAdjuntos" Width="150" Height="30" TextMode="MultiLine"
                 text='<%# Eval("observaciones_inicial") %>' ReadOnly="true"></asp:TextBox>

         </dataitemtemplate></dx:GridViewDataColumn>
                       

                        <dx:GridViewDataColumn Visible="true" Caption="Archivo" VisibleIndex="6">
         <dataitemtemplate>
                        <asp:HyperLink ID="lnkArchivoEstampilla" runat="server"  NavigateUrl='<%# Eval("ruta_archivo") %>' 
                            Text="Ver Archivo" Target="_blank"
                            Visible='<%# (Eval("ruta_archivo") != null && Eval("ruta_archivo") != System.DBNull.Value) %>' />
        </dataitemtemplate>
                    </dx:GridViewDataColumn>
                    <dx:GridViewDataColumn VisibleIndex="10" >
                        <dataitemtemplate>
<asp:Button ID="btnAprobarAdjunto" runat="server"
                                 CommandArgument='<%# Eval("cod_adjunto_contrato_suministro") %>'
                                 OnClick="btnAprobarAdjunto_Click2" 
                                 Text="Cambiar Estado" Visible="<%# btnAdjuntarDocumento.Visible %>" />

                            <asp:Button ID="btnVerLogAdjunto" runat="server"
                                 CommandArgument='<%# Eval("cod_adjunto_contrato_suministro") %>'
                                 OnClick="btnVerLogAdjunto_Click" 
                                 Text="Ver log adjunto" />

                            <br />
                            <asp:Button ID="btnEditarAdjunto" runat="server"
                                 CommandArgument='<%# Eval("cod_adjunto_contrato_suministro") %>'
                                 OnClick="btnEditarAdjunto_Click1" Text="Editar" 
                        Visible="<%# btnAdjuntarDocumento.Visible %>" />
                            <br />
                            <asp:Button ID="btnEliminarEstampilla" runat="server"
                                 CommandArgument='<%# Eval("cod_adjunto_contrato_suministro") %>'
                                 OnClick="btnEliminarEstampilla_Click1" 
                                OnClientClick="return confirm('Esta seguro de eliminar el registro?');" Text="Eliminar" 
                                Visible="<%# btnAdjuntarDocumento.Visible %>" />
                            
                            
                        </dataitemtemplate></dx:GridViewDataColumn>

                   </Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView>
            
                          <asp:SqlDataSource ID="SqlDataSourceDocumentosAnexos" runat="server"
                               ConnectionString="<%$ ConnectionStrings:spxConnectionString %>"
                               SelectCommand="SELECT adjunto_contrato_suministro.cod_adjunto_contrato_suministro, adjunto_contrato_suministro.fecha_creacion, tipo_adjunto_contrato_suministro.nombre_tipo_adjunto_contrato_suministro, 
                              estado_adjunto_contrato_suministro.nombre_estado_contrato, 
                              usuario.nombre,
                               adjunto_contrato_suministro.ruta_archivo, 
                              adjunto_contrato_suministro.observaciones_inicial
                               FROM adjunto_contrato_suministro INNER JOIN tipo_adjunto_contrato_suministro ON adjunto_contrato_suministro.cod_tipo_adjunto_contrato_suministro = tipo_adjunto_contrato_suministro.cod_tipo_adjunto_contrato_suministro INNER JOIN estado_adjunto_contrato_suministro ON adjunto_contrato_suministro.cod_estado_adjunto_contrato_suministro = estado_adjunto_contrato_suministro.cod_estado_adjunto_contrato_suministro INNER JOIN usuario ON adjunto_contrato_suministro.cod_usuario_creacion = usuario.cod_usuario
where adjunto_contrato_suministro.cod_contratos_suministro=@codContrato

                              ">
                              <SelectParameters>
                                  <asp:QueryStringParameter Name="codContrato" QueryStringField="cod" />
                              </SelectParameters>
                       </asp:SqlDataSource>

                   </ContentTemplate>
               </asp:UpdatePanel>

           </telerik:RadPageView>

           <telerik:RadPageView ID="RadPageViewArchivos"  runat="server"><br />Tipo de Archivo 
               <asp:DropDownList ID="cmbTipoArchivo" runat="server" DataSourceID="SqlDataSourceTipoArchivo" DataTextField="nombre_archivoxcontratos_suministro" DataValueField="cod_tipoarchivoxcontratos_suministro"></asp:DropDownList>
               <div style="display:none;">
               <asp:FileUpload ID="FileUploadArchivo" runat="server" />
               </div>
               <asp:Button ID="btnFileUploadArchivo"  runat="server" Text="Seleccionar Archivo" />
               <asp:SqlDataSource ID="SqlDataSourceTipoArchivo" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_tipoarchivoxcontratos_suministro], [nombre_archivoxcontratos_suministro] FROM [tipoarchivoxcontratos_suministro] ORDER BY [nombre_archivoxcontratos_suministro]"></asp:SqlDataSource>
               
               <asp:Button ID="btnSubirArchivo" runat="server" OnClick="btnSubirArchivo_Click" Text="Subir Archivo" /><br /><br />
               <asp:Label ID="lblErrorArchivo" runat="server" ForeColor="Red"></asp:Label>
               <dx:ASPxGridView ID="grdArchivo" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceArchivos" KeyFieldName="cod_archivoxcontratos_suministro" EnableViewState="False">
                   <Columns>
                       <dx:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0">
                       </dx:GridViewCommandColumn>
                       <dx:GridViewDataTextColumn FieldName="otrosi" Caption="Otro Si" VisibleIndex="1"></dx:GridViewDataTextColumn>
                       <dx:GridViewDataDateColumn FieldName="fecha_creacion" VisibleIndex="2" Caption="Creado"></dx:GridViewDataDateColumn>
                       <dx:GridViewDataTextColumn FieldName="nombre_archivo" Caption="Archivo" VisibleIndex="3"></dx:GridViewDataTextColumn>
                       <dx:GridViewDataTextColumn FieldName="tipo" VisibleIndex="4" Caption="Tipo"></dx:GridViewDataTextColumn>
                       <dx:GridViewDataColumn  VisibleIndex="5">
                           <DataItemTemplate><asp:HyperLink runat="server" ID="lnkVerArchivo" Text="Ver Archivo" Target="_blank" NavigateUrl='<%# Eval("ruta_archivo") %>' ></asp:HyperLink>

                           </DataItemTemplate>

                       </dx:GridViewDataColumn></Columns><SettingsPager Visible="False"></SettingsPager>
                   <Settings ShowFilterRow="True" />
                   <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView>
               <asp:SqlDataSource ID="SqlDataSourceArchivos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                   SelectCommand="
                   
select cfinal.otrosi,
ruta_archivo,archivoxcontratos_suministro.fecha_creacion, archivoxcontratos_suministro.nombre_archivo, archivoxcontratos_suministro.cod_archivoxcontratos_suministro, tipoarchivoxcontratos_suministro.nombre_archivoxcontratos_suministro AS 'tipo' 
 from contratos_suministro
left join contratos_suministro c2 on c2.cod_contratos_suministro =contratos_suministro.numero_contrato_vinculado
join archivoxcontratos_suministro on archivoxcontratos_suministro.cod_contratos_suministro= c2.cod_contratos_suministro
or archivoxcontratos_suministro.cod_contratos_suministro=contratos_suministro.cod_contratos_suministro
INNER JOIN tipoarchivoxcontratos_suministro ON archivoxcontratos_suministro.cod_tipoarchivoxcontratos_suministro = tipoarchivoxcontratos_suministro.cod_tipoarchivoxcontratos_suministro
left join contratos_suministro cfinal on cfinal.cod_contratos_suministro= archivoxcontratos_suministro.cod_contratos_suministro
where contratos_suministro.cod_contratos_suministro=@cod_contratos_suministro
order by archivoxcontratos_suministro.cod_archivoxcontratos_suministro desc
"><SelectParameters><asp:QueryStringParameter Name="cod_contratos_suministro" QueryStringField="cod" /></SelectParameters></asp:SqlDataSource></telerik:RadPageView>


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
                Unidades de Negocio<br />
                <dx:ASPxGridView ID="ASPxGridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceDivisiones">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Visible="False" VisibleIndex="0"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Unidad de Negocio" FieldName="nombre_division_experiencia_contrato_suministro" VisibleIndex="1" Width="200px"></dx:GridViewDataTextColumn>
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

                    <dx:GridViewDataColumn VisibleIndex="50">
                        <DataItemTemplate>
                            <asp:HyperLink
                                runat="server"
                                Text="Ver Archivo"
                                target="_blank"
                                NavigateUrl='<%# Eval("ruta_archivo") %>'
                                Visible='<%# Eval("ruta_archivo") != null
                            && Eval("ruta_archivo") != System.DBNull.Value &&
                            Eval("ruta_archivo").ToString().Trim() != string.Empty 
                            %>'
                                
                                ></asp:HyperLink>
                        </DataItemTemplate>
                    </dx:GridViewDataColumn>
                </Columns>
                <settingspager pagesize="20">
                </settingspager>
                <settingsdatasecurity allowdelete="False" allowedit="False" allowinsert="False" />
                </dx:ASPxGridView>
                <dx:ASPxGridViewExporter ID="ASPxGridViewExporterEstados" runat="server" GridViewID="grdEstados"></dx:ASPxGridViewExporter>
                <asp:SqlDataSource ID="SqlDataSourceLog" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                    SelectCommand="SELECT archivoxcontratos_suministro.ruta_archivo,usuario.nombre, log_cambios_estado_contratos_suministro.fecha_cambio, 
ef.nombre_estado_contrato_suministro estado_original,horas,minutos,
estado_contrato_suministro.nombre_estado_contrato_suministro, log_cambios_estado_contratos_suministro.observaciones_cambio FROM log_cambios_estado_contratos_suministro INNER JOIN estado_contrato_suministro ON log_cambios_estado_contratos_suministro.cod_estado_contrato_suministro = estado_contrato_suministro.cod_estado_contrato_suministro

INNER JOIN estado_contrato_suministro ef ON log_cambios_estado_contratos_suministro.cod_estado_contrato_suministro_original = ef.cod_estado_contrato_suministro
 INNER JOIN usuario ON log_cambios_estado_contratos_suministro.usuario_cambio = usuario.cod_usuario
left join archivoxcontratos_suministro on archivoxcontratos_suministro.cod_archivoxcontratos_suministro = log_cambios_estado_contratos_suministro.cod_archivoxcontratos_suministro

where log_cambios_estado_contratos_suministro.cod_contratos_suministro = @cod_contratos_suministro
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
         <asp:DropDownList runat="server" ID="cmbEstado" OnSelectedIndexChanged="cmbEstado_SelectedIndexChanged" 
             AutoPostBack="true" ></asp:DropDownList>

               
  
 </div>
<div class= "Formulario">  
    <asp:TextBox runat="server"
        TextMode="MultiLine" Width="400px" Height="200px" ID="txtObservacionesCambioEstado"></asp:TextBox>
    
    <br />
    <asp:Panel runat="server" ID="pnlCambioEstadoArchivo" Visible="false">
           <table style="width:400px;">
        <tr>
            <td>Archivo:&nbsp;&nbsp; </td>
            
            <td>
                <asp:DropDownList ID="cmbTipoArchivoCambio" runat="server" DataSourceID="SqlDataSourceTipoArchivoCambio" DataTextField="nombre_archivoxcontratos_suministro" DataValueField="cod_tipoarchivoxcontratos_suministro">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceTipoArchivoCambio" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_tipoarchivoxcontratos_suministro], [nombre_archivoxcontratos_suministro] FROM [tipoarchivoxcontratos_suministro] WHERE ([cod_manual] = @cod_manual) ORDER BY [nombre_archivoxcontratos_suministro]">
                    <SelectParameters>
                        <asp:SessionParameter Name="cod_manual" SessionField="codmanualcambioestado" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            </tr>
               <tr>
            <td colspan="2">
                <div style="display:none;">
                <asp:FileUpload ID="FileUploadCambio"  runat="server" />
                    </div>
                <asp:Button ID="btnFileUploadCambio"  runat="server" Text="Seleccionar Archivo" />
                <asp:HyperLink Target="_blank" ID="lnkArchivoCambio" runat="server">Ver Archivo</asp:HyperLink>
            </td>
                   </tr>
               <tr >
            <td colspan="2">
                <asp:Button ID="btnSubirArchivoCambio" runat="server" OnClick="btnSubirArchivoCambio_Click" Text="Subir Archivo" />
            </td>
        </tr>
    </table> 
    </asp:Panel>

 </div>  
        
         
        <asp:Label runat="server" ID="lblErrorCambioEstado" ForeColor="Red">

        </asp:Label>
        <br />
  <asp:Button runat="server" ID="btnAceptarCambioEstado" Text="Cambiar Estado"
      OnClientClick="this.disabled = true; this.value = 'Procesando...';" 
  UseSubmitBehavior="false" 
       OnClick="btnAceptarCambioEstado_Click" />  
        <asp:Button runat="server" ID="btnCancelarCambioEstado" Text="Cancelar" OnClick="btnCancelarCambioEstado_Click"  />  


        </asp:Panel>
        </ContentTemplate>

          <Triggers>
         <asp:PostBackTrigger ControlID="btnSubirArchivoCambio" />
      </Triggers>
    </asp:UpdatePanel>  
           
    </asp:Panel>       
 

        <cca:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server"
     PopupControlID="pnlEmergente" 
                  TargetControlID="lblInvicible"
             BackgroundCssClass="modalBackground"
             DropShadow="true"
              Enabled="true">
</cca:ModalPopupExtender>   





           <asp:Label style=" display:none" ID="lblInvicibleAdjuntos" runat="server"  />   

    <asp:Panel style="display:none" ID="pnlEmergenteAdjuntos" Enabled="true" runat="server"
     Height="310px" Width="450px" BackColor="LightGray">
    
    
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" RenderMode="Inline" UpdateMode=Always>
    <ContentTemplate> 
 
    <asp:Panel  ID="Panel2" runat="server" BackColor="white" style="padding-left:20px;padding-top:5px;">
   

        <br />
  
    <div class="tabx" id="Div1">Estado
         <asp:DropDownList runat="server" ID="cmbEstadoAdjunto" DataSourceID="SqlDataSourceEstadoAdjunto" DataTextField="nombre_estado_contrato" DataValueField="cod_estado_adjunto_contrato_suministro"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceEstadoAdjunto" runat="server" 
            ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
            SelectCommand="SELECT [cod_estado_adjunto_contrato_suministro], [nombre_estado_contrato] 
            FROM [estado_adjunto_contrato_suministro] WHERE ([cod_manual] != @cod_manual) ORDER BY [cod_manual]">
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="cod_manual" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        
        </div>
<div class= "Formulario">  
    <asp:TextBox runat="server"
        TextMode="MultiLine" Width="400px" Height="200px" ID="txtObservacionesAdjunto"></asp:TextBox>
    
    <br />
   

 </div>  
         <asp:Label runat="server" ID="lblCodEstadoAdjuntoIni" Visible="false"></asp:Label>  
         <asp:Label runat="server" ID="lblCodAdjunto" Visible="false"></asp:Label>
        <asp:Label runat="server" ID="lblErrorAdjunto" ForeColor="Red">

        </asp:Label>
        <br />
        <asp:Button runat="server" ID="btnAprobarAdjunto" Text="Cambiar Estado"
      OnClientClick="this.disabled = true; this.value = 'Procesando...';" 
  UseSubmitBehavior="false" 
       OnClick="btnAprobarAdjunto_Click"  /> 
  
        <asp:Button runat="server" ID="btnCancelarAdjunto" 
            Text="Cancelar" OnClick="btnCancelarAdjunto_Click"  />  


        </asp:Panel>
        </ContentTemplate>

         
    </asp:UpdatePanel>  
           
    </asp:Panel>       
 

        <cca:ModalPopupExtender ID="ModalPopupExtenderAdjuntos" runat="server"
     PopupControlID="pnlEmergenteAdjuntos" 
                  TargetControlID="lblInvicibleAdjuntos"
             BackgroundCssClass="modalBackground"
             DropShadow="true"
              Enabled="true">
</cca:ModalPopupExtender>   


</asp:Content>

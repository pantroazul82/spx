<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmHojaVidaCliente.aspx.cs" Inherits="frm_csuministro_frmHojaVidaCliente" %>

<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>






<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            width: 194px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <br />
    <asp:Label runat="server" ID="lblTitulo" Text="Hoja de vida Cliente Contratos de Suministro." Font-Bold="True"></asp:Label>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Cliente</td>
            <td>
                <asp:TextBox ID="txtCliente" runat="server" ReadOnly="True" style="margin-left: 0px" Width="400px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Nit Cliente</td>
            <td>
                <asp:TextBox ID="txtNitCliente" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Número Socio<br />


            </td>
            <td>
                <asp:TextBox ID="txtNumeroSocio" runat="server" ReadOnly="True" style="margin-top: 0px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
<br />
      <telerik:RadTabStrip ID="RadTabStripFormulario" runat="server" 
        MultiPageID="radMultiGeneral" SelectedIndex="0">
        <Tabs>
       
            <telerik:RadTab runat="server" Text="Contratos de Suministro" Selected="True">
            </telerik:RadTab>

            <telerik:RadTab runat="server"  Text="Polizas/Pagos adicionales">

            </telerik:RadTab>

            <telerik:RadTab runat="server" Text="Archivos">
            </telerik:RadTab>
             <telerik:RadTab runat="server" Text="Experiencia">
            </telerik:RadTab>
             
        </Tabs>
    </telerik:RadTabStrip>

           <telerik:RadMultiPage ID="radMultiGeneral" runat="server" SelectedIndex="0">
           <telerik:RadPageView ID="RadPageViewGeneral"  runat="server">Listado de contratos del cliente &nbsp;&nbsp;&nbsp;<asp:Button runat="server" Text="Exportar Excel" id="btnExportar" OnClick="btnExportar_Click" />
               
               <dx:ASPxGridView ID="grdDatos"  runat="server" AutoGenerateColumns="False" ViewStateMode="Disabled"><Columns>
                   <dx:GridViewDataColumn VisibleIndex="0">
                       <DataItemTemplate><asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" 
                           NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>

                       </DataItemTemplate>

                   </dx:GridViewDataColumn>
                   <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Caption="Cod Contrato" VisibleIndex="0"></dx:GridViewDataTextColumn>


                   <dx:GridViewDataTextColumn FieldName="nombre_estado_contrato_suministro" Caption="Estado" VisibleIndex="1"></dx:GridViewDataTextColumn>
                   
                   <dx:GridViewDataTextColumn FieldName="numero_contrato" Caption="Numero Contrato" VisibleIndex="2"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="consecutivo_interno" Caption="Consecutivo Interno" VisibleIndex="3"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="contacto_juridico" Caption="" VisibleIndex="5" Visible="false"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="numero_celular_contacto_juridico" Caption="" VisibleIndex="6" Visible="false"></dx:GridViewDataTextColumn><dx:GridViewDataDateColumn FieldName="fecha_incio" Caption="Inicia" VisibleIndex="7"></dx:GridViewDataDateColumn><dx:GridViewDataDateColumn FieldName="fecha_terminacion" Caption="Termina" VisibleIndex="8"></dx:GridViewDataDateColumn><dx:GridViewDataTextColumn FieldName="valor_contrato" Caption="Valor Contrato" VisibleIndex="12"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="otrosi" Caption="Otro Si" VisibleIndex="13"></dx:GridViewDataTextColumn></Columns><Settings ShowFilterRow="True" /><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
            SelectCommand="SELECT [numero_contrato], [consecutivo_interno], [nitCliente], [contacto_juridico], [numero_celular_contacto_juridico], [fecha_incio], [fecha_terminacion], [fecha_aprobacion_cartera], [fecha_aprobacion_juridico], [fecha_aprobacion_inicial], [valor_contrato], [otrosi] FROM [contratos_suministro]"></asp:SqlDataSource><dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="grdDatos"></dx:ASPxGridViewExporter></telerik:RadPageView>

            <telerik:RadPageView ID="radPolizas"  runat="server">
                Polizas 
                <br />
                <dx:ASPxGridView ID="grdPoliza" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourcePolizas"
                     KeyFieldName="cod_polizas_contrato_suministro"><Columns>
                                 <dx:GridViewDataColumn VisibleIndex="0">
                       <DataItemTemplate><asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" 
                           NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>

                       </DataItemTemplate>

                   </dx:GridViewDataColumn>
                   <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Caption="Cod Contrato" VisibleIndex="0"></dx:GridViewDataTextColumn>

                         <dx:GridViewDataTextColumn FieldName="cod_polizas_contrato_suministro" Visible="false" ReadOnly="True" VisibleIndex="0"><EditFormSettings Visible="False" /></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" VisibleIndex="1" Visible="false"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="nombre_riesgo_poliza_consumo" Caption="Riesgo" Visible="true" VisibleIndex="1"></dx:GridViewDataTextColumn>
                   
                         <dx:GridViewDataTextColumn FieldName="porcentaje" VisibleIndex="3" Caption="%"></dx:GridViewDataTextColumn>
                         <dx:GridViewDataTextColumn FieldName="valor_poliza" VisibleIndex="4" Caption="Valor"></dx:GridViewDataTextColumn>
                         
                         <dx:GridViewDataTextColumn FieldName="vigencia_meses" VisibleIndex="5" Caption="Vigencia Meses"></dx:GridViewDataTextColumn>
                         
                        <dx:GridViewDataTextColumn FieldName="observaciones" Visible="true" VisibleIndex="6">
                     </dx:GridViewDataTextColumn>
                         <dx:GridViewDataColumn>       
                             <DataItemTemplate>
                             </DataItemTemplate></dx:GridViewDataColumn>

                         </Columns>
                    <SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView><br />
                Estampillas y Pagos Adicionales <br />
                <dx:ASPxGridView ID="grdPagoAdicional" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourcePagosAdicionales" KeyFieldName="cod_estampillas_contrato_sumisnistro">
                    <Columns>
                    <dx:GridViewDataColumn VisibleIndex="0">
                       <DataItemTemplate>
                           <asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" 
                           NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>

                       </DataItemTemplate>

                   </dx:GridViewDataColumn>
                   <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Caption="Cod Contrato" VisibleIndex="0"></dx:GridViewDataTextColumn>

                    <dx:GridViewDataTextColumn FieldName="cod_estampillas_contrato_sumisnistro" ReadOnly="True" VisibleIndex="0" Visible="False"><EditFormSettings Visible="False" /></dx:GridViewDataTextColumn>
                        
                    <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" VisibleIndex="1" Visible="False"></dx:GridViewDataTextColumn>
                        
                        
                  <dx:GridViewDataTextColumn Caption="Banco" FieldName="banco" VisibleIndex="2" Width="200px">                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Cuenta" FieldName="cuentabanco" VisibleIndex="3" Width="200px">                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Tipo" FieldName="tipocuenta" VisibleIndex="4" Width="200px">                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Beneficiario" FieldName="beneficiario" VisibleIndex="5" Width="200px">                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Destinacion" FieldName="destinacion" VisibleIndex="6" Width="200px">                    </dx:GridViewDataTextColumn>
                    
                    <dx:GridViewDataTextColumn Caption="%" FieldName="porcentaje" VisibleIndex="7"></dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn Caption="Valor" FieldName="valor" VisibleIndex="8"></dx:GridViewDataTextColumn>
                
                        
                            <dx:GridViewDataColumn VisibleIndex="9">
                        
                        <DataItemTemplate>
                                 </DataItemTemplate></dx:GridViewDataColumn></Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />

                </dx:ASPxGridView>
                <asp:SqlDataSource ID="SqlDataSourcePagosAdicionales" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="
                    SELECT

                    
 [cod_estampillas_contrato_sumisnistro], 
porcentaje,valor,estampillas_contrato_sumisnistro.cod_contratos_suministro,
banco_suministro.nombre_banco_suministro banco,cuentabanco,
tipo_cuenta_banco.nombre_tipo_cuenta_banco tipocuenta,
beneficiario,
destinacion_suministro.cod_destinacion_suministro
destinacion

FROM [estampillas_contrato_sumisnistro] 
join banco_suministro on [banco_suministro].cod_banco_suministro = estampillas_contrato_sumisnistro.cod_banco_suministro
join [tipo_cuenta_banco] on tipo_cuenta_banco.cod_tipo_cuenta_banco = estampillas_contrato_sumisnistro.cod_tipo_cuenta_banco
join destinacion_suministro on destinacion_suministro.cod_destinacion_suministro = estampillas_contrato_sumisnistro.cod_destinacion_suministro
join contratos_suministro on contratos_suministro.cod_contratos_suministro= estampillas_contrato_sumisnistro.cod_contratos_suministro

where nitcliente=@nitcliente"><SelectParameters><asp:QueryStringParameter Name="nitcliente" QueryStringField="nit" /></SelectParameters></asp:SqlDataSource><br />
                
<asp:SqlDataSource ID="SqlDataSourcePolizas" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
    SelectCommand="
    
                    SELECT 
 polizas_contrato_suministro.[cod_polizas_contrato_suministro],  polizas_contrato_suministro.[cod_contratos_suministro],
  polizas_contrato_suministro.[observaciones],  polizas_contrato_suministro.[cod_riesgo_poliza_consumo],
  polizas_contrato_suministro.[porcentaje],  polizas_contrato_suministro.[valor_poliza],
  polizas_contrato_suministro.[vigencia_meses],  riesgo_poliza_consumo.nombre_riesgo_poliza_consumo
					FROM [polizas_contrato_suministro] 
					join riesgo_poliza_consumo on riesgo_poliza_consumo.cod_riesgo_poliza_consumo = polizas_contrato_suministro.cod_riesgo_poliza_consumo
                  
join contratos_suministro on contratos_suministro.cod_contratos_suministro= polizas_contrato_suministro.cod_contratos_suministro
where nitcliente=@nit"><SelectParameters><asp:QueryStringParameter Name="nit" QueryStringField="nit" /></SelectParameters></asp:SqlDataSource></telerik:RadPageView>

           <telerik:RadPageView ID="RadPageViewArchivos"  runat="server">
               <dx:ASPxGridView ID="grdArchivo" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceArchivos" 
                   KeyFieldName="cod_archivoxcontratos_suministro"><Columns>
                       <dx:GridViewDataColumn VisibleIndex="0">
                       <DataItemTemplate><asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" 
                           NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>

                       </DataItemTemplate>

                   </dx:GridViewDataColumn>
                   <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Caption="Cod Contrato" VisibleIndex="0"></dx:GridViewDataTextColumn>

                       <dx:GridViewDataDateColumn FieldName="fecha_creacion" VisibleIndex="0" Caption="Creado"></dx:GridViewDataDateColumn>
                       <dx:GridViewDataTextColumn FieldName="nombre_archivo" Caption="Archivo" VisibleIndex="1"></dx:GridViewDataTextColumn>
                       <dx:GridViewDataTextColumn FieldName="tipo" VisibleIndex="3" Caption="Creado"></dx:GridViewDataTextColumn>
                       <dx:GridViewDataColumn  VisibleIndex="4"><DataItemTemplate>
                           <asp:HyperLink Target="_blank" runat="server" ID="lnkVerArchivo" Text="Ver Archivo" NavigateUrl='<%# Eval("ruta_archivo") %>' >

                           </asp:HyperLink></DataItemTemplate></dx:GridViewDataColumn></Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView><asp:SqlDataSource ID="SqlDataSourceArchivos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="
                           SELECT ruta_archivo,
archivoxcontratos_suministro.cod_contratos_suministro,
archivoxcontratos_suministro.fecha_creacion, archivoxcontratos_suministro.nombre_archivo, archivoxcontratos_suministro.cod_archivoxcontratos_suministro, tipoarchivoxcontratos_suministro.nombre_archivoxcontratos_suministro AS 'tipo' 
FROM archivoxcontratos_suministro 
INNER JOIN tipoarchivoxcontratos_suministro ON archivoxcontratos_suministro.cod_tipoarchivoxcontratos_suministro = tipoarchivoxcontratos_suministro.cod_tipoarchivoxcontratos_suministro



join contratos_suministro on contratos_suministro.cod_contratos_suministro= archivoxcontratos_suministro.cod_contratos_suministro
where nitcliente = @nit
"><SelectParameters><asp:QueryStringParameter Name="nit" QueryStringField="nit" /></SelectParameters></asp:SqlDataSource></telerik:RadPageView>


            <telerik:RadPageView ID="RadPageGruposYdivisiones"  runat="server"><br />Grupos de Experiencia<br /> 
                
                <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceGruposExperiencia">
                    <Columns>
                       <dx:GridViewDataColumn VisibleIndex="0">
                       <DataItemTemplate><asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" 
                           NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>

                       </DataItemTemplate>

                   </dx:GridViewDataColumn>
                   <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Caption="Cod Contrato" VisibleIndex="0"></dx:GridViewDataTextColumn>

                        <dx:GridViewDataTextColumn Caption="Grupo Experiencia" FieldName="nombre_grupo_reactivo_experiencia" VisibleIndex="0" Width="200px"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Visible="False" VisibleIndex="1"></dx:GridViewDataTextColumn></Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView><asp:SqlDataSource ID="SqlDataSourceGruposExperiencia" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT 
contratos_suministro.cod_contratos_suministro,
grupo_reactivo_experiencia.nombre_grupo_reactivo_experiencia, grupo_reactivoxcontrato_suministro.cod_contratos_suministro 
FROM grupo_reactivo_experiencia INNER JOIN 
grupo_reactivoxcontrato_suministro ON grupo_reactivo_experiencia.cod_grupo_reactivo_experiencia = grupo_reactivoxcontrato_suministro.cod_grupo_reactivo_experiencia

join contratos_suministro on contratos_suministro.cod_contratos_suministro= grupo_reactivoxcontrato_suministro.cod_contratos_suministro
where nitcliente=@nit"><SelectParameters><asp:QueryStringParameter Name="nit" QueryStringField="nit" /></SelectParameters></asp:SqlDataSource><br />
                Unidades de Negocio<br /> <dx:ASPxGridView ID="ASPxGridView2" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSourceDivisiones"><Columns>
                        <dx:GridViewDataColumn VisibleIndex="0">
                       <DataItemTemplate><asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" 
                           NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>

                       </DataItemTemplate>

                   </dx:GridViewDataColumn>
                   <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Caption="Cod Contrato" VisibleIndex="0"></dx:GridViewDataTextColumn>

                        <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Visible="False" VisibleIndex="0"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn Caption="Unidades de Negocio" FieldName="nombre_division_experiencia_contrato_suministro" VisibleIndex="1" Width="200px"></dx:GridViewDataTextColumn></Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView><asp:SqlDataSource ID="SqlDataSourceDivisiones" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT
contratos_suministro.cod_contratos_suministro,
 divisionxcontrato_suministro.cod_contratos_suministro, division_experiencia_contrato_suministro.nombre_division_experiencia_contrato_suministro 
FROM division_experiencia_contrato_suministro 
INNER JOIN divisionxcontrato_suministro 
ON division_experiencia_contrato_suministro.cod_division_experiencia_contrato_suministro = divisionxcontrato_suministro.cod_division_experiencia_contrato_suministro

join contratos_suministro on contratos_suministro.cod_contratos_suministro= divisionxcontrato_suministro.cod_contratos_suministro
where nitcliente=@nit"><SelectParameters><asp:QueryStringParameter Name="nit" QueryStringField="nit" /></SelectParameters></asp:SqlDataSource><br />Productos<br />
                 <dx:ASPxGridView ID="grdProductosExperiencia" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceProductos">
                     
                     <Columns>
                         <dx:GridViewDataColumn VisibleIndex="0">
                       <DataItemTemplate><asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" 
                           NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>

                       </DataItemTemplate>

                   </dx:GridViewDataColumn>
                   <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" Caption="Cod Contrato" VisibleIndex="0"></dx:GridViewDataTextColumn>

                         <dx:GridViewDataTextColumn FieldName="nombre_fabricante" VisibleIndex="0" Caption="Fabricante"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="nombre_producto" VisibleIndex="1" Caption="Producto"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="codigo_manual_referencia" VisibleIndex="2" Caption="Referencia"></dx:GridViewDataTextColumn><dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" VisibleIndex="3" Visible="false"></dx:GridViewDataTextColumn></Columns><SettingsPager Visible="False"></SettingsPager><SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" /></dx:ASPxGridView><asp:SqlDataSource ID="SqlDataSourceProductos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT
contratos_suministro.cod_contratos_suministro,

fabricante.nombre_fabricante, producto_experiencia_contrato.nombre_producto, producto_experiencia_contrato.codigo_manual_referencia, producto_experiencia_contratoxcontrato_conmsumo.cod_contratos_suministro 
FROM producto_experiencia_contrato 
INNER JOIN producto_experiencia_contratoxcontrato_conmsumo ON producto_experiencia_contrato.cod_producto_experiencia_contrato = producto_experiencia_contratoxcontrato_conmsumo.cod_producto_experiencia_contrato 
INNER JOIN fabricante ON producto_experiencia_contrato.cod_fabricante = fabricante.cod_fabricante


join contratos_suministro on contratos_suministro.cod_contratos_suministro= producto_experiencia_contratoxcontrato_conmsumo.cod_contratos_suministro
where nitcliente= @nit"><SelectParameters><asp:QueryStringParameter Name="nit" QueryStringField="nit" /></SelectParameters></asp:SqlDataSource></telerik:RadPageView>

           </telerik:RadMultiPage>


</asp:Content>


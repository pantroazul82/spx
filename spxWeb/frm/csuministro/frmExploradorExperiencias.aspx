﻿<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmExploradorExperiencias.aspx.cs" Inherits="frm_csuministro_frmExploradorExperiencias" %>
<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>


<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
      <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />  
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
    <br />

    

    <div class="tab">Seleccione los filtros de busqueda</div>
    <div class="FormularioSimple">
    <table>
        <tr>
            <td>Monto entre</td>
            <td>
                <asp:TextBox ID="txtMontoMenor" runat="server"></asp:TextBox>
                <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" FilterType="Numbers"
    TargetControlID="txtMontoMenor" />
            &nbsp;y
                <asp:TextBox ID="txtMontoMayor" runat="server"></asp:TextBox>
                <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Numbers"
    TargetControlID="txtMontoMayor" />
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5"><hr /></td>
        </tr>

    <tr>
            <td colspan="5">

    <telerik:RadTabStrip ID="RadTabStripFormulario" runat="server" 
        MultiPageID="radMultiGeneral" SelectedIndex="0">
        <Tabs>
            <telerik:RadTab runat="server" Text="Grupos de Reactivos" Selected="True">
            </telerik:RadTab>

            <telerik:RadTab runat="server"  Text="Unidades de Negocio">
            </telerik:RadTab>

            <telerik:RadTab runat="server" Text="Productos Experiencia">
            </telerik:RadTab>
            
        </Tabs>
    </telerik:RadTabStrip>
         <telerik:RadMultiPage ID="radMultiGeneral" runat="server" SelectedIndex="0">
           <telerik:RadPageView ID="RadPageViewGeneral"  runat="server">
        Grupos:               
                <asp:DropDownList ID="cmbGruposReactivos" runat="server" DataSourceID="SqlDataSourceGruposReactivos" DataTextField="nombre_grupo_reactivo_experiencia" DataValueField="cod_grupo_reactivo_experiencia">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceGruposReactivos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_grupo_reactivo_experiencia], [nombre_grupo_reactivo_experiencia] FROM [grupo_reactivo_experiencia] ORDER BY [nombre_grupo_reactivo_experiencia]"></asp:SqlDataSource>
                <asp:Button ID="btnAgregarGrupoReactivos" runat="server" OnClick="btnAgregarGrupoReactivos_Click" Text="Agregar" />
            <br />
                   <dx:ASPxGridView ID="grdGrupo" runat="server" AutoGenerateColumns="False" KeyFieldName="cod_grupo_reactivo_experiencia">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="cod_grupo_reactivo_experiencia" ReadOnly="True" VisibleIndex="0" Visible="false">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_grupo_reactivo_experiencia" VisibleIndex="1" Caption="Grupo Experiencia">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataColumn  VisibleIndex="2">
                            <DataItemTemplate>
                                <asp:Button runat="server" Text="Eliminar" id="EliminarGrupo" OnClick="EliminarGrupo_Click" CommandArgument='<%# Eval("cod_grupo_reactivo_experiencia") %>' />
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                    </Columns>
                    <SettingsPager Visible="False">
                    </SettingsPager>
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
              
           </telerik:RadPageView>
             <telerik:RadPageView ID="RadPageView1"  runat="server">
Unidades de Negocio:
           <asp:DropDownList ID="cmbDivisiones" runat="server" DataSourceID="SqlDataSourceDivisiones" DataTextField="nombre_division_experiencia_contrato_suministro" DataValueField="cod_division_experiencia_contrato_suministro">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceDivisiones" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_division_experiencia_contrato_suministro], [nombre_division_experiencia_contrato_suministro] FROM [division_experiencia_contrato_suministro] ORDER BY [nombre_division_experiencia_contrato_suministro]"></asp:SqlDataSource>
                <asp:Button ID="btnAgregarDivision" runat="server" OnClick="btnAgregarDivision_Click" Text="Agregar" />
        <br/>
                   <dx:ASPxGridView ID="grdDivisiones" runat="server" AutoGenerateColumns="False" KeyFieldName="cod_division_experiencia_contrato_suministro">
                    <Columns>
                        <dx:GridViewDataTextColumn Visible="false" FieldName="cod_division_experiencia_contrato_suministro" ReadOnly="True" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_division_experiencia_contrato_suministro" Caption="Division" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataColumn  VisibleIndex="2">
                            <DataItemTemplate>
                                <asp:Button runat="server" Text="Eliminar" id="EliminarDivision" OnClick="EliminarDivision_Click" CommandArgument='<%# Eval("cod_division_experiencia_contrato_suministro") %>' />
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                    </Columns>
                    <SettingsPager Visible="False">
                    </SettingsPager>
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>

           
           </telerik:RadPageView>
             <telerik:RadPageView ID="RadPageView2"  runat="server">
               Productos:
                <asp:TextBox ID="txtProductos" runat="server" Width="300px"></asp:TextBox>
                <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Producto" OnClick="btnAgregarProducto_Click" />
         <br />
                 <dx:ASPxGridView ID="grdProdcutos" runat="server">
                <Columns>
                        <dx:GridViewDataTextColumn Visible="false" FieldName="cod_producto_experiencia_contrato" ReadOnly="True" VisibleIndex="0">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_fabricante" Caption="Fabricante" VisibleIndex="0">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_producto" Caption="Producto" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="codigo_manual_referencia" Caption="Codigo manual (referencia)" VisibleIndex="2">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataColumn  VisibleIndex="3">
                            <DataItemTemplate>
                                <asp:Button runat="server" Text="Eliminar" id="EliminarProucto" OnClick="EliminarProucto_Click" CommandArgument='<%# Eval("cod_producto_experiencia_contrato") %>' />
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                    </Columns>
                    <SettingsPager Visible="False">
                    </SettingsPager>
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
         
           </telerik:RadPageView>
               </telerik:RadMultiPage>

  


            </td>
        </tr>
   


          <tr>
            <td>
               
                &nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>



          <tr>
            <td>
               
                vigente desde</td>
            <td>
                <dx:ASPxDateEdit ID="calIni" runat="server">
                </dx:ASPxDateEdit>
              </td>
            <td >hasta
               
              </td>
              <td>
                  <dx:ASPxDateEdit ID="calFin" runat="server">
                  </dx:ASPxDateEdit>
              </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </td>
        </tr>


          <tr>
            <td>
               
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                
              </td>
            <td>
                <asp:Button ID="btnExportarExcel" runat="server" Text="Exportar Excel" OnClick="btnExportarExcel_Click" />
              </td>
        </tr>

    </table>
        </div>
<dx:ASPxGridView ID="grdContratos" runat="server" AutoGenerateColumns="False">
    <Columns>
        <dx:GridViewDataColumn VisibleIndex="0">
            <DataItemTemplate>
                <asp:HyperLink runat="server" ID="link" Text="ver contrato"
                    NavigateUrl='<%# "~/frm/csuministro/frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'
                    ></asp:HyperLink>
            </DataItemTemplate>
         </dx:GridViewDataColumn>
        <dx:GridViewDataTextColumn FieldName="nombre_estado_contrato_suministro" VisibleIndex="0" Caption="Estado">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="numero_contrato" VisibleIndex="1" Caption="Numero Contrato">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="nombreasesor" VisibleIndex="2" Caption="Asesor">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="nitcliente" VisibleIndex="3" Caption="Nit">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="nombrecliente" VisibleIndex="4" Caption="Cliente">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="numerosocio" VisibleIndex="5" Caption="Socio Negocio">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="nombreciudad" VisibleIndex="6" Caption="Ciudad">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="nombredepartamento" VisibleIndex="7" Caption="Departamento">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_incio" VisibleIndex="9" Caption="Inicia">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_terminacion" VisibleIndex="10" Caption="Termina">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="valor_contrato" VisibleIndex="11" Caption="Monto">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="otrosi" VisibleIndex="12">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataCheckColumn FieldName="aplica_estampilla" VisibleIndex="13">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="aplica_polizas" VisibleIndex="14">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_creacion" VisibleIndex="8" Caption="Creado">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataCheckColumn FieldName="es_contrato" VisibleIndex="15">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="es_orden_compra" VisibleIndex="16">
        </dx:GridViewDataCheckColumn>
    </Columns>
    <SettingsPager Visible="False">
    </SettingsPager>
    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>

    <asp:SqlDataSource ID="SqlDataSourceContratos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT        estado_contrato_suministro.nombre_estado_contrato_suministro, contratos_suministro.numero_contrato, asesoresComerciales.NombreAsesor, 
                         contratos_suministro.nitCliente, clientes.nombreCliente, clientes.numeroSocio, ciudades.nombreCiudad, departamentos.NombreDepartamento, 
                         contratos_suministro.fecha_incio, contratos_suministro.fecha_terminacion, contratos_suministro.valor_contrato, contratos_suministro.otrosi, 
                         contratos_suministro.aplica_estampilla, contratos_suministro.aplica_polizas, contratos_suministro.fecha_creacion, contratos_suministro.es_contrato, 
                         contratos_suministro.es_orden_compra
FROM            contratos_suministro 
JOIN
estado_contrato_suministro ON contratos_suministro.cod_estado_contrato_suministro = estado_contrato_suministro.cod_estado_contrato_suministro 
JOIN
asesoresComerciales ON contratos_suministro.codAsesor = asesoresComerciales.codAsesor 
JOIN
clientes ON contratos_suministro.nitCliente = clientes.nitCliente 
JOIN
ciudades ON contratos_suministro.codPais_envio_contrato = ciudades.codPais AND 
                         contratos_suministro.codDepartamento_envio_contrato = ciudades.codDepartamento AND 
                         contratos_suministro.codCiudad_envio_contrato = ciudades.codCiudad 
JOIN
departamentos ON ciudades.codPais = departamentos.codPais AND ciudades.codDepartamento = departamentos.codDepartamento
"></asp:SqlDataSource>

</asp:Content>


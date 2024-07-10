<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmExploradorExperiencias.aspx.cs" Inherits="frm_csuministro_frmExploradorExperiencias" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>


<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
      <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />  
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
    <br />

    <table>
        <tr>
            <td>Monto entre</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;y
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td>Grupos de Reactivos</td>
               <td>
                <asp:DropDownList ID="cmbGruposReactivos" runat="server" DataSourceID="SqlDataSourceGruposReactivos" DataTextField="nombre_grupo_reactivo_experiencia" DataValueField="cod_grupo_reactivo_experiencia">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceGruposReactivos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_grupo_reactivo_experiencia], [nombre_grupo_reactivo_experiencia] FROM [grupo_reactivo_experiencia] ORDER BY [nombre_grupo_reactivo_experiencia]"></asp:SqlDataSource>
                <asp:Button ID="btnAgregarGrupoReactivos" runat="server" OnClick="btnAgregarGrupoReactivos_Click" Text="Agregar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td colspan="5">
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
                &nbsp;</td>
       
        </tr>

        <tr>
            <td>Divisiones</td>
            <td>     <asp:DropDownList ID="cmbDivisiones" runat="server" DataSourceID="SqlDataSourceDivisiones" DataTextField="nombre_division_experiencia_contrato_suministro" DataValueField="cod_division_experiencia_contrato_suministro">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceDivisiones" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_division_experiencia_contrato_suministro], [nombre_division_experiencia_contrato_suministro] FROM [division_experiencia_contrato_suministro] ORDER BY [nombre_division_experiencia_contrato_suministro]"></asp:SqlDataSource>
                <asp:Button ID="btnAgregarDivision" runat="server" OnClick="btnAgregarDivision_Click" Text="Agregar" />
        </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td colspan="5">
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

            </td>
        </tr>

          <tr>
            <td>
               Productos Experiencia
            </td>
            <td>      <asp:TextBox ID="txtProductos" runat="server" Width="300px"></asp:TextBox>
                <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Producto" OnClick="btnAgregarProducto_Click" />
         </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
            </td>
        </tr>

          <tr>
            <td colspan="5">
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
            </td>
        </tr>


          <tr>
            <td>
               
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
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
                &nbsp;</td>
        </tr>

    </table>
<dx:ASPxGridView ID="grdContratos" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceContratos" KeyFieldName="cod_contratos_suministro">
    <Columns>
        <dx:GridViewDataTextColumn FieldName="cod_contratos_suministro" ReadOnly="True" VisibleIndex="0">
            <EditFormSettings Visible="False" />
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="numero_contrato" VisibleIndex="1">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="cod_usuario_asesor" VisibleIndex="2">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="cod_estado_contrato_suministro" VisibleIndex="3">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="consecutivo_interno" VisibleIndex="4">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="nitCliente" VisibleIndex="5">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="codContacto" VisibleIndex="6">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="direccion_envio_contrato" VisibleIndex="7">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="codPais_envio_contrato" VisibleIndex="8">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="codDepartamento_envio_contrato" VisibleIndex="9">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="codCiudad_envio_contrato" VisibleIndex="10">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="contacto_juridico" VisibleIndex="11">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="numero_celular_contacto_juridico" VisibleIndex="12">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_incio" VisibleIndex="13">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_terminacion" VisibleIndex="14">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="valor_contrato" VisibleIndex="15">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="otrosi" VisibleIndex="16">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_otro_si" VisibleIndex="17">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="numero_contrato_vinculado" VisibleIndex="18">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="observaciones" VisibleIndex="19">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataCheckColumn FieldName="aplica_estampilla" VisibleIndex="20">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="aplica_polizas" VisibleIndex="21">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_creacion" VisibleIndex="22">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="codSucursal" VisibleIndex="23">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataCheckColumn FieldName="es_contrato" VisibleIndex="24">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="es_orden_compra" VisibleIndex="25">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="no_genera_flujo" VisibleIndex="26">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="incluye_apoyo_tecnologico" VisibleIndex="27">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataCheckColumn FieldName="genera_multa" VisibleIndex="28">
        </dx:GridViewDataCheckColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_limite_legalizacion" VisibleIndex="29">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="codAsesor" VisibleIndex="30">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="contrato_apoyo" VisibleIndex="31">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="cod_motivo_anulacion_suministro" VisibleIndex="32">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataDateColumn FieldName="fecha_anulacion" VisibleIndex="33">
        </dx:GridViewDataDateColumn>
        <dx:GridViewDataTextColumn FieldName="anulada_por" VisibleIndex="34">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="observaciones_anulacion" VisibleIndex="35">
        </dx:GridViewDataTextColumn>
    </Columns>
    <SettingsPager Visible="False">
    </SettingsPager>
    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>

    <asp:SqlDataSource ID="SqlDataSourceContratos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT * FROM [contratos_suministro]"></asp:SqlDataSource>

</asp:Content>


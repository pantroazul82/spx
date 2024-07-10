<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCrearContrato.aspx.cs" Inherits="frm_csuministro_frmCrearContrato" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>

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
        <asp:Button ID="btnCliente"   runat="server" onclick="btnCliente_Click" 
    style="visibility:hidden; " Text="Cargar" Width="0px" />
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Contratos de suministro"></asp:Label>
    </p>
    <div class="tab">Creacion de Contrato de Suministro.</div>
    <div class="Formular6ioSimple" style="background-color:whitesmoke !important;font-size:11px;padding-left:8px;">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:RadioButton ID="rdContrato" runat="server" Checked="True" GroupName="rd" Text="Contrato Suministro" />
            </td>
            <td>
                <asp:RadioButton ID="rdOrdenCompra" runat="server" GroupName="rd" Text="Orden de Compra" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Creado por</td>
            <td>
                <asp:DropDownList ID="cmbCreadoPor" runat="server" DataSourceID="SqlDataSourceUsuario" DataTextField="nombre" DataValueField="cod_usuario" Enabled="False">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceUsuario" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha Creado</td>
            <td>
                <dx:ASPxDateEdit ID="calCreacion" runat="server" EditFormat="DateTime" Enabled="False">
                </dx:ASPxDateEdit>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="chkGeneraMulta" runat="server" Text="Genera Multa" />
            </td>
            <td>
                <asp:Label ID="lblFechaLimite" runat="server" Text="Fecha limite legalizacion"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <dx:ASPxDateEdit ID="calLimiteLegalizacion" runat="server" EditFormat="DateTime">
                </dx:ASPxDateEdit>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="chkIncluyeapoyo" runat="server" Text="Incluye apoyo" />
            </td>
            <td>
                <asp:TextBox ID="txtContratoApoyo" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha de Inicio</td>
            <td>
                <div style="max-width:initial !important;">
                <dx:ASPxDateEdit ID="calFechaInicio" runat="server" Width="100px">
                </dx:ASPxDateEdit>
                    </div>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Fecha de terminacion"></asp:Label>
            </td>
            <td>
                <dx:ASPxDateEdit ID="calFechaTerminacion" runat="server" Width="100px">
                </dx:ASPxDateEdit>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Numero contrato</td>
            <td>
                <asp:TextBox ID="txtNumeroContrato" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Consecutivo Interno</td>
            <td>
                <asp:TextBox ID="txtConsecutivoInterno" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Cliente</td>
            <td colspan="4">
                <asp:TextBox ID="txtCliente" runat="server" Width="400px"></asp:TextBox>
                <asp:HyperLink ID="lnkCliente" runat="server" NavigateUrl="frmHojaVidaCliente.aspx?nit=" Target="_blank" Visible="False">Ver Hoja de Vida</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Socio de negocio</td>
            <td>
                <asp:TextBox ID="txtSocioNegocio" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Contacto</td>
            <td>
                <asp:DropDownList ID="cmbContacto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbContacto_SelectedIndexChanged">
                </asp:DropDownList>
                    <asp:ImageButton ID="btnCargarContactos" runat="server" 
        ImageUrl="~/img/web/GoBack.gif" onclick="btnCargarContactos_Click" 
        ToolTip="Cargar Contactos" Width="28px" />
    <asp:HyperLink ID="lnkNuevoContaco" runat="server" 
        ImageUrl="~/img/web/insert.gif" 
        NavigateUrl="~/frm/parametrizacion/frmContactos.aspx" Target="_blank">Nuevo Contacto</asp:HyperLink>

                <asp:Label ID="lblCargoContacto" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Sucursal</td>
            <td>
                <asp:DropDownList ID="cmbSucursal" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Asesor Comercial</td>
            <td>
                <asp:DropDownList ID="cmbAsesor" runat="server" DataSourceID="SqlDataSourceAsesor" DataTextField="NombreAsesor" DataValueField="codAsesor">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceAsesor" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [codAsesor], [NombreAsesor] FROM [asesoresComerciales] ORDER BY [NombreAsesor]"></asp:SqlDataSource>
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
            <td colspan="4">
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Direccion envio contrato</td>
            <td colspan="4">
                <asp:TextBox ID="txtDireccionEnvioContrato" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Pais envio contrato</td>
            <td>
                <asp:DropDownList ID="cmbPaisEnvioContrato" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourcePais" DataTextField="nombrePais" DataValueField="codPais">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourcePais" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [codPais], [nombrePais] FROM [paises] ORDER BY [nombrePais]"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Departamento envio contrato</td>
            <td>
                <asp:DropDownList ID="cmbDepartamentoEnvioContrato" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceDepartamentos" DataTextField="NombreDepartamento" DataValueField="codDepartamento">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceDepartamentos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [codDepartamento], [NombreDepartamento] FROM [departamentos] WHERE ([codPais] = @codPais) ORDER BY [NombreDepartamento]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="cmbPaisEnvioContrato" Name="codPais" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Ciudad envio contrato</td>
            <td>
                <asp:DropDownList ID="cmbCiudadEnvioContrato" runat="server" DataSourceID="SqlDataSourceCiudad" DataTextField="nombreCiudad" DataValueField="codCiudad">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceCiudad" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [nombreCiudad], [codCiudad] FROM [ciudades] WHERE (([codPais] = @codPais) AND ([codDepartamento] = @codDepartamento)) ORDER BY [nombreCiudad]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="cmbPaisEnvioContrato" Name="codPais" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="cmbDepartamentoEnvioContrato" Name="codDepartamento" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Contacto Juridico</td>
            <td>
                <asp:TextBox ID="txtContactojuridico" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Celular contacto juridico</td>
            <td>
                <asp:TextBox ID="txtCelularContactoJuridico" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Valor Contrato</td>
            <td>
                <asp:TextBox ID="txtValorContrato" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:CheckBox ID="chkAplicaEstampilla" runat="server" Text="Aplica Estampilla" />
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:CheckBox ID="chkAplicaPolizas" runat="server" Text="Aplica Polizas" />
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:CheckBox ID="chkOmiteFlujo" runat="server" Text="Omite Flujo Aprobaciones" />
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="7"><hr />&nbsp;</td>
        </tr>
        <tr>
            <td><strong>Grupos de Reactivos</strong></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="cmbGruposReactivos" runat="server" DataSourceID="SqlDataSourceGruposReactivos" DataTextField="nombre_grupo_reactivo_experiencia" DataValueField="cod_grupo_reactivo_experiencia">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceGruposReactivos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_grupo_reactivo_experiencia], [nombre_grupo_reactivo_experiencia] FROM [grupo_reactivo_experiencia] ORDER BY [nombre_grupo_reactivo_experiencia]"></asp:SqlDataSource>
                <asp:Button ID="btnAgregarGrupoReactivos" runat="server" OnClick="btnAgregarGrupoReactivos_Click" Text="Agregar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="7">
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
            </td>
        </tr>
        <tr>
            <td><strong>Divisiones</strong></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="cmbDivisiones" runat="server" DataSourceID="SqlDataSourceDivisiones" DataTextField="nombre_division_experiencia_contrato_suministro" DataValueField="cod_division_experiencia_contrato_suministro">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceDivisiones" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_division_experiencia_contrato_suministro], [nombre_division_experiencia_contrato_suministro] FROM [division_experiencia_contrato_suministro] ORDER BY [nombre_division_experiencia_contrato_suministro]"></asp:SqlDataSource>
                <asp:Button ID="btnAgregarDivision" runat="server" OnClick="btnAgregarDivision_Click" Text="Agregar" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
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
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <strong>Productos Experiencia</strong></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:TextBox ID="txtProductos" runat="server" Width="300px"></asp:TextBox>
                <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Producto" OnClick="btnAgregarProducto_Click" />
                <asp:Button ID="btnImportarProductos" runat="server" Text="Importar Productos" OnClick="btnImportarProductos_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="7">
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
            <td>Observaciones</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:TextBox ID="txtObservaciones" runat="server" Height="98px" Width="680px" TextMode="MultiLine"></asp:TextBox>
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
            <td colspan="5">
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Button ID="btnAceptar" runat="server" Text="Guardar" OnClick="btnAceptar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

        </div>


          <asp:Panel style="display:none" ID="pnlEmergente" Enabled="true" runat="server"
     Height="190px" Width="670px" BackColor="LightGray">
              
        
        <br /> 
               <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline" UpdateMode="Always">
    <ContentTemplate>
        <asp:Label runat="server" Text="Importación de Productos" Font-Size="18px" Font-Bold="true"></asp:Label>
       
              <br />
        Seleccione un archivo de excel, que contenga en la primera columna la referencia de los productos a agregar.
        <br />
        <asp:FileUpload runat="server" ID="fileImportar" />
        <br />
          <asp:Label runat="server" ID="lblErrorImportar" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button runat="server" Text="Importar" ID="btnImportar" OnClick="btnImportar_Click" />
        <asp:Button runat="server" Text="Cancelar" ID="btnCancelarImportacion" OnClick="btnCancelarImportacion_Click" />


        
    </ContentTemplate> 
                    <Triggers>
              
                <asp:PostBackTrigger ControlID="btnImportar" />
            </Triggers>

                   </asp:UpdatePanel>


          </asp:Panel>


            <asp:Label style=" display:none" ID="lblInvicible" runat="server"  /> 
    <cca:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server"
     PopupControlID="pnlEmergente"      
             TargetControlID="lblInvicible"
             BackgroundCssClass="modalBackground"
             DropShadow="true"
             Enabled="true">
</cca:ModalPopupExtender>   
       

</asp:Content>


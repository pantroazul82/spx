﻿<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCrearContrato.aspx.cs" Inherits="frm_csuministro_frmCrearContrato" %>

<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>


<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>

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

<script type = "text/javascript" language = "javascript">
    function formatCurrency(num) {
        var str = num.toString().replace("$", ""), parts = false, output = [], i = 1, formatted = null;
        if (str.indexOf(",") > 0) {
            parts = str.split(",");
            str = parts[0];
        }
        str = str.split("").reverse();
        for (var j = 0, len = str.length; j < len; j++) {
            if (str[j] != ".") {
                output.push(str[j]);
                if (i % 3 == 0 && j < (len - 1)) {
                    output.push(".");
                }
                i++;
            }
        }
        formatted = output.reverse().join("");
        return ("$" + formatted + ((parts) ? "," + parts[1].substr(0, 2) : ""));
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
            <td>
                <asp:Label ID="lblTipoOtroSi" runat="server" Text="Tipo Otro si" Visible="False"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cmbTipoOtroSi" Visible="false" runat="server" DataSourceID="SqlDataSourceTipoOtroSi" DataTextField="nombre_tipo_otro_si_suministro" DataValueField="cod_tipo_otro_si_suministro">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceTipoOtroSi" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_tipo_otro_si_suministro], [nombre_tipo_otro_si_suministro] FROM [tipo_otro_si_suministro] ORDER BY [nombre_tipo_otro_si_suministro]"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
            <td>
                </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <asp:Panel runat="server" ID="pnlOtroSi" Visible="false">
            
          <tr>
            <td>
                <asp:Label runat="server" ID="lblOtroSi" Visible="false"></asp:Label>
       
                Observaciones Otro Si</td>
            <td colspan="3">
                <asp:TextBox ID="txtObservacionesOtroSi" runat="server" Width="600px" TextMode="MultiLine" Height="100"></asp:TextBox>
            </td>
            
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        </asp:Panel>
        <tr>
            <td>
                Cliente<asp:Label ID="Label6" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCliente" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>
                <asp:HyperLink ID="lnkCliente" runat="server" NavigateUrl="frmHojaVidaCliente.aspx?nit=" Target="_blank" Visible="False">Ver Hoja de Vida</asp:HyperLink>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                Socio de negocio</td>
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
            <td>
                &nbsp;</td>
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
            <td>Creado por<asp:Label ID="Label7" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
            <td>Fecha Creado<asp:Label ID="Label8" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
                <asp:CheckBox ID="chkGeneraMulta" runat="server" Text="Genera Multa" AutoPostBack="True" OnCheckedChanged="chkGeneraMulta_CheckedChanged" />
            </td>
            <td align="right">
                <asp:Label ID="lblFechaLimite" runat="server" Text="Fecha limite legalizacion" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                <dx:ASPxDateEdit ID="calLimiteLegalizacion" runat="server" EditFormat="DateTime" Visible="False">
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
                <asp:CheckBox ID="chkIncluyeapoyo" runat="server" Text="Incluye apoyo" AutoPostBack="True" OnCheckedChanged="chkIncluyeapoyo_CheckedChanged" />
            </td>
            <td>
                <asp:TextBox ID="txtContratoApoyo" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fecha de Inicio<asp:Label ID="Label9" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
                <asp:Label ID="Label10" runat="server" ForeColor="Red" Text="*"></asp:Label>
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
            <td>Numero contrato<asp:Label ID="Label11" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNumeroContrato" runat="server" ></asp:TextBox>
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
            <td>Contacto<asp:Label ID="Label13" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
            <td>Sucursal<asp:Label ID="Label14" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
            <td>Asesor Comercial<asp:Label ID="Label15" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="cmbAsesor" runat="server" DataSourceID="SqlDataSourceAsesor" DataTextField="NombreAsesor" DataValueField="codAsesor">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceAsesor" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [codAsesor], [NombreAsesor] FROM [asesoresComerciales]
where activo is null or activo=1  ORDER BY [NombreAsesor]"></asp:SqlDataSource>
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
            <td>Direccion envio contrato<asp:Label ID="lblDireccionEnvioObligatorio" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td colspan="4">
                <asp:TextBox ID="txtDireccionEnvioContrato" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Pais envio contrato<asp:Label ID="Label17" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
            <td>Departamento envio contrato<asp:Label ID="Label18" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
            <td>Ciudad envio contrato<asp:Label ID="Label19" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
            <td>Contacto Juridico<asp:Label ID="lblContactoJuridicoObligatorio" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
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
            <td>Celular contacto juridico<asp:Label ID="lblCelularObligatorio" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCelularContactoJuridico" runat="server"></asp:TextBox>
                <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" FilterType="Numbers"
    TargetControlID="txtCelularContactoJuridico" />

            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Valor Contrato<asp:Label ID="Label22" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtValorContrato" runat="server" onblur = "this.value=formatCurrency(this.value);"></asp:TextBox>
                <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" FilterType="Custom"
                    ValidChars="01234567890.,$"
    TargetControlID="txtValorContrato" />
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
                &nbsp;</td>
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
                &nbsp;</td>
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
                <asp:CheckBox ID="chkOmiteFlujo" runat="server" Text="Omite Flujo Aprobaciones" AutoPostBack="True" OnCheckedChanged="chkOmiteFlujo_CheckedChanged" />
            </td>
            <td>&nbsp;</td>
            <td>
                
                </td>
            <td colspan="3">
                
            </td>
            
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="6">
                <asp:label Text="Consecutivo Interno:" Visible="false" runat="server" ID="lblConsecutivoInterno">
                </asp:label>
                <asp:TextBox TextMode="SingleLine" runat="server" Visible="false" ID="txtConsecutivoInterno"  ></asp:TextBox>
                <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server" TargetControlID="txtConsecutivoInterno"  FilterType="Numbers"></cca:FilteredTextBoxExtender>
            </td>

        </tr>
        <tr>
            <td colspan="7"><hr />&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
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
                <asp:CheckBox ID="chkAplicaPolizas" runat="server" Text="Aplica Polizas" AutoPostBack="True" OnCheckedChanged="chkAplicaPolizas_CheckedChanged" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        
        <asp:Panel runat="server" ID="pnlPolizas" Visible="false">
        <tr>
            <td>
                <strong>Polizas</strong></td>
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
                <asp:Button ID="btnAgregarPoliza" runat="server" Text="Agregar Poliza" OnClick="btnAgregarPoliza_Click" />
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
            <td colspan="4">
                        
                   <asp:UpdatePanel runat="server" ID="updatePanelPolizas" UpdateMode="Conditional">
                       <ContentTemplate>
                <dx:ASPxGridView ID="grdPoliza" runat="server" AutoGenerateColumns="False" KeyFieldName="cod_polizas_contrato_suministro">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="cod_polizas_contrato_suministro" ReadOnly="True" VisibleIndex="0" Visible="false">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_riesgo_poliza_consumo" VisibleIndex="1" Caption="Riesgo">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="vigencia_meses" VisibleIndex="2" Caption="vigencia">
                        </dx:GridViewDataTextColumn>
                        
                        <dx:GridViewDataTextColumn FieldName="porcentaje" VisibleIndex="7" Caption="Porcentaje">
                        </dx:GridViewDataTextColumn>

                        <dx:GridViewDataColumn  VisibleIndex="8">
                            <DataItemTemplate>
                                
                                <asp:Button runat="server" Text="Editar" id="btnEditarPolizas"
                                     OnClick="btnEditarPolizas_Click" CommandArgument='<%# Eval("cod_polizas_contrato_suministro") %>' />
                                <asp:Button runat="server" Text="Eliminar" id="EliminarPolizas" OnClientClick="return confirm('Esta seguro de eliminar el registro?, este cambio no se puede deshacer');"
                                     OnClick="EliminarPolizas_Click" CommandArgument='<%# Eval("cod_polizas_contrato_suministro") %>' />
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                    </Columns>
                    <SettingsPager Visible="False">
                    </SettingsPager>
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
                           
                       </ContentTemplate>
                   </asp:UpdatePanel> 
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
            </asp:Panel>
                
        <tr>
            <td>
                <asp:CheckBox ID="chkAplicaEstampilla" runat="server" Text="Aplica Estampilla" AutoPostBack="True" OnCheckedChanged="chkAplicaEstampilla_CheckedChanged" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        
            
        <asp:Panel runat="server" ID="pnlEstampillas" Visible="false">
        <tr>
            <td><strong>Estampillas</strong></td>
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
                <asp:Button ID="btnAgregarEstampilla" runat="server" OnClick="btnAgregarEstampilla_Click" Text="Agregar Estampilla" />
                <br />
                <asp:UpdatePanel runat="server" ID="pnlGrdEstampillas" UpdateMode="Conditional">
                    <ContentTemplate>
                        
                    
                <dx:ASPxGridView ID="grdEstampillas" runat="server" AutoGenerateColumns="False" KeyFieldName="cod_estampillas_contrato_sumisnistro">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="cod_estampillas_contrato_sumisnistro" ReadOnly="True" VisibleIndex="0" Visible="false">
                            <EditFormSettings Visible="False" />
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_banco_suministro" VisibleIndex="1" Caption="Banco">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="cuentabanco" VisibleIndex="2" Caption="Cuenta">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_tipo_cuenta_banco" VisibleIndex="3" Caption="Tipo">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="beneficiario" VisibleIndex="4" Caption="Beneficiario">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="nombre_destinacion_suministro" VisibleIndex="5" Caption="Destinacion">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="porcentaje" VisibleIndex="6" Caption="Porcentaje">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataColumn FieldName="valor" VisibleIndex="7" Caption="Valor">
                            <DataItemTemplate>
                                <asp:Label runat="server" Text='<%# string.Format("{0:c}", Eval("valor")) %>'></asp:Label>
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                        <dx:GridViewDataCheckColumn FieldName="pago_cliente" VisibleIndex="8" Caption="No Pago">
                        </dx:GridViewDataCheckColumn>

                        <dx:GridViewDataColumn FieldName="Archivo" VisibleIndex="9" Caption="Archivo">
                            <DataItemTemplate>
                                <asp:HyperLink ID="Label24" runat="server" Text="Ver Archivo" Target="_blank" 
                                    NavigateUrl='<%# (Eval("url_archivo") == null || Eval("url_archivo") == System.DBNull.Value)?"":Eval("url_archivo") %>'
                                    Visible='<%# (Eval("url_archivo") != null && Eval("url_archivo") != System.DBNull.Value && Eval("url_archivo") != string.Empty) %>'
                                    ></asp:HyperLink>
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>




                        <dx:GridViewDataColumn  VisibleIndex="10">
                            <DataItemTemplate>
                                
                                <asp:Button runat="server" Text="Editar" id="btnEditar"
                                     OnClick="btnEditarEstampilla_Click" CommandArgument='<%# Eval("cod_estampillas_contrato_sumisnistro") %>' />
                                <asp:Button runat="server" Text="Eliminar" id="EliminarEstampilla" OnClientClick="return confirm('Esta seguro de eliminar el registro?, este cambio no se puede deshacer');"
                                     OnClick="btnEliminarEstampilla_Click" CommandArgument='<%# Eval("cod_estampillas_contrato_sumisnistro") %>' />
                            </DataItemTemplate>
                        </dx:GridViewDataColumn>
                    </Columns>
                    <SettingsPager Visible="False">
                    </SettingsPager>
                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                </dx:ASPxGridView>
                        </ContentTemplate>
                </asp:UpdatePanel>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
            </asp:Panel>
        <tr>
            <td><strong>Unidades de Negocio<asp:Label ID="Label25" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </strong></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DropDownList ID="cmbDivisiones" runat="server" DataSourceID="SqlDataSourceDivisiones" DataTextField="nombre_division_experiencia_contrato_suministro" DataValueField="cod_division_experiencia_contrato_suministro">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceDivisiones" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_division_experiencia_contrato_suministro], [nombre_division_experiencia_contrato_suministro] FROM [division_experiencia_contrato_suministro] ORDER BY [nombre_division_experiencia_contrato_suministro]"></asp:SqlDataSource>
                <asp:Button ID="btnAgregarDivision" runat="server" OnClick="btnAgregarDivision_Click" Text="Agregar" />
            </td>
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
                        <dx:GridViewDataTextColumn FieldName="nombre_division_experiencia_contrato_suministro" Caption="Unidades de Negocio" VisibleIndex="1">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataColumn  VisibleIndex="2">
                            <DataItemTemplate>
                                <asp:Button runat="server" Text="Eliminar" id="EliminarDivision" 
                                         OnClientClick="return confirm('Esta seguro de eliminar el registro?, este cambio no se puede deshacer');"
                                    OnClick="EliminarDivision_Click" CommandArgument='<%# Eval("cod_division_experiencia_contrato_suministro") %>' />
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
            <td colspan="2">
                <asp:DropDownList ID="cmbGruposReactivos" runat="server" DataSourceID="SqlDataSourceGruposReactivos" DataTextField="nombre_grupo_reactivo_experiencia" DataValueField="cod_grupo_reactivo_experiencia">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceGruposReactivos" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_grupo_reactivo_experiencia], [nombre_grupo_reactivo_experiencia] FROM [grupo_reactivo_experiencia] ORDER BY [nombre_grupo_reactivo_experiencia]"></asp:SqlDataSource>
                <asp:Button ID="btnAgregarGrupoReactivos" runat="server" OnClick="btnAgregarGrupoReactivos_Click" Text="Agregar" />
            </td>
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
                                <asp:Button runat="server" Text="Eliminar" id="EliminarGrupo"
                                    OnClientClick="return confirm('Esta seguro de eliminar el registro?, este cambio no se puede deshacer');"
                                     OnClick="EliminarGrupo_Click" CommandArgument='<%# Eval("cod_grupo_reactivo_experiencia") %>' />
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
                <strong>Productos Experiencia<asp:Label ID="lblProductosObligatorio" runat="server" ForeColor="Red" Text="*"></asp:Label>
                </strong></td>
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
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><strong>Archivos</strong></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>


          <asp:Panel runat="server" ID="pnlDocumentoEscaneado">
        <tr>
            <td>Documento Escaneado<asp:Label ID="lblDocumentoEscaneado" runat="server" Visible="False"></asp:Label>
            </td>
            <td colspan="3">
                <div style="display:none;">
                <asp:FileUpload ID="FileUploadDocumentoEscaneado" runat="server" />
                    </div>
                <asp:Button ID="btnFileUploadDocumentoEscaneado"  runat="server" Text="Seleccionar Archivo" />
&nbsp;<asp:HyperLink ID="lnkVerDocumentoEscaneado" runat="server" Target="_blank" Visible="False">Ver Documento escaneado</asp:HyperLink>
&nbsp;<asp:Button ID="btnCargarDocumentoEscaneado" runat="server" OnClick="btnCargarDocumentoEscaneado_Click" Text="Cargar documento escaneado" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
              </asp:Panel>    
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>


        
        <tr>
            <td>Propuesta economica<asp:Label ID="lblArchivoPropuesta" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblObligatorioPropuesta" runat="server" ForeColor="Red" Text="*"></asp:Label>
            </td>
            <td colspan="3">
              
                <div style="display:none;">
                <asp:FileUpload ID="FileUploadPropuesta" runat="server" />
                    </div>
                <asp:Button ID="btnFileUploadPropuesta"  runat="server" Text="Seleccionar Archivo" />
&nbsp;<asp:HyperLink ID="linkPropuesta" runat="server" Target="_blank" Visible="False">Ver Propuesta</asp:HyperLink>
&nbsp;<asp:Button ID="btnCargarPropuesta" runat="server" OnClick="btnCargarPropuesta_Click" Text="Cargar Propuesta" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>


        <tr>
            <td>Ordenanza/Estatuto<asp:Label ID="lblOdenanza" runat="server" Visible="False"></asp:Label>
                <asp:Label ID="lblObligatorioOrdenanza" runat="server" ForeColor="Red" Text="*" Visible="False"></asp:Label>
            </td>
            <td colspan="3">
                <div style="display:none;">
                <asp:FileUpload ID="FileUploadOrdenanza" runat="server" />
                    </div>
                <asp:Button ID="btnFileUploadOrdenanza"  runat="server" Text="Seleccionar Archivo" />
&nbsp;<asp:HyperLink ID="lnkOrdenanza" runat="server" Target="_blank" Visible="False">Ver Ordenanza</asp:HyperLink>
&nbsp;<asp:Button ID="btnCargarOrdenanza" runat="server" OnClick="btnCargarOrdenanza_Click" Text="Cargar Ordenanza" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Aprobación coordinador comercial para estampillas<asp:Label ID="lblArchivoCorreo" runat="server" Visible="False"></asp:Label>
            </td>
            <td colspan="5">
                <div style="display:none;">
                <asp:FileUpload ID="FileUploadCorreoAprobacion" runat="server"  />
                    </div>
                <asp:Button ID="btnFileUploadCorreoAprobacion"  runat="server" Text="Seleccionar Archivo" />

&nbsp;<asp:HyperLink ID="lnkCorreoAprobacion" runat="server" Target="_blank" Visible="False">Ver Archivo</asp:HyperLink>
&nbsp;<asp:Button ID="btnCargarCorreoAprobacion" runat="server" OnClick="btnCargarCorreoAprobacion_Click" Text="Cargar Correo Aprobacion" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
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
       

        <asp:Panel style="display:none" ID="pnlEmergenteEstampilla" Enabled="true" runat="server"
     Height="310px" Width="500px" BackColor="LightGray">
        <asp:Label runat="server" ID="lblCodEstampilla" Visible="false"></asp:Label>      
        
        <br /> 
               <asp:UpdatePanel ID="updatePanelEstamilla" runat="server" RenderMode="Inline" UpdateMode="Always">
    <ContentTemplate>
        <asp:Label ID="Label2" runat="server" Text="Información de estampilla" Font-Size="18px" Font-Bold="true"></asp:Label>
       
              <br />
       Ingrese la información de la estampilla.
      
        <br />
        <table>
            <tr><td></td><td></td></tr>
            
            <tr><td>Banco</td><td>

                <asp:DropDownList ID="cmbBanco" runat="server" DataSourceID="SqlDataSourceBanco" DataTextField="nombre_banco_suministro" DataValueField="cod_banco_suministro">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceBanco" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_banco_suministro], [nombre_banco_suministro] FROM [banco_suministro] ORDER BY [nombre_banco_suministro]"></asp:SqlDataSource>


            </td></tr>
            <tr><td>Numero de cuenta</td><td>
                <asp:TextBox runat="server" ID="txtNrocuentaEstampilla" Width="200px"></asp:TextBox>
                <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Custom" ValidChars="0123456789"
    TargetControlID="txtNrocuentaEstampilla" />


                                         </td></tr>
            <tr><td>Tipo de cuenta</td><td>
                <asp:DropDownList ID="cmbtipocuenta" runat="server" DataSourceID="SqlDataSourceTipoCuenta" DataTextField="nombre_tipo_cuenta_banco" DataValueField="cod_tipo_cuenta_banco">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceTipoCuenta" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_tipo_cuenta_banco], [nombre_tipo_cuenta_banco] FROM [tipo_cuenta_banco] ORDER BY [nombre_tipo_cuenta_banco]"></asp:SqlDataSource>


            </td></tr>
            <tr><td>Beneficiario</td><td><asp:TextBox runat="server" ID="txtBeneficiarioEstampilla" Width="200px"></asp:TextBox></td></tr>
            <tr><td>Destinacion</td><td>

                <asp:DropDownList ID="cmbDestinacion" runat="server" DataSourceID="SqlDataSourceDestinacion" DataTextField="nombre_destinacion_suministro" DataValueField="cod_destinacion_suministro">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceDestinacion" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_destinacion_suministro], [nombre_destinacion_suministro] FROM [destinacion_suministro] ORDER BY [nombre_destinacion_suministro]"></asp:SqlDataSource>


            </td></tr>
            <tr><td>Porcentaje</td><td>
                <asp:TextBox runat="server" ID="txtPcEstampilla" Width="200px"></asp:TextBox>
                <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom" ValidChars="0123456789."
    TargetControlID="txtPcEstampilla" />

                                   </td></tr>
            <tr><td>Valor</td><td><asp:TextBox runat="server" ReadOnly="true" ID="txtValorEstampilla" Width="200px"></asp:TextBox>
                  
                <asp:Button runat="server" Text="Calcular Valor" id="btnCalcularValorEstampillas" OnClick="btnCalcularValorEstampillas_Click" />
                              </td></tr>

            <tr><td></td><td><asp:CheckBox runat="server"  ID="chkPagoClienteEstampilla" Text="Estampilla paga por el cliente" ></asp:CheckBox>
                  
                
                              </td></tr>


        </table>

          <asp:Label runat="server" ID="lblErrorEstampilla" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button runat="server" Text="Aceptar" ID="btnAceptarEstampilla" OnClick="btnAceptarEstampilla_Click" />
        <asp:Button runat="server" Text="Cancelar" ID="btnCancelarEstampilla" OnClick="btnCancelarEstampilla_Click" />


        
    </ContentTemplate> 
                    <Triggers>
              
                <asp:PostBackTrigger ControlID="btnImportar" />
            </Triggers>

                   </asp:UpdatePanel>


          </asp:Panel>
    
            <asp:Label style=" display:none" ID="lblInvicibleEstampilla" runat="server"  /> 
      <cca:ModalPopupExtender ID="Panel1_ModalPopupEstampilla" runat="server"
     PopupControlID="pnlEmergenteEstampilla"      
             TargetControlID="lblInvicibleEstampilla"
             BackgroundCssClass="modalBackground"             DropShadow="true"             Enabled="true">
</cca:ModalPopupExtender> 

             <asp:Panel style="display:none" ID="pnlEmergentePolizas" Enabled="true" runat="server"
     Height="290px" Width="500px" BackColor="LightGray">
        <asp:Label runat="server" ID="Label4"></asp:Label>      
        
        <br /> 
               <asp:UpdatePanel ID="updatePanel2" runat="server" RenderMode="Inline" UpdateMode="Always">
    <ContentTemplate>
        <asp:Label ID="Label5" runat="server" Text="Información de poliza" Font-Size="18px" Font-Bold="true"></asp:Label>
       <asp:Label runat="server" ID="lblCodPoliza" Visible="false"></asp:Label>
              <br />
       Ingrese la información de la poliza.
        <br />
        <table>
            <tr><td></td><td>&nbsp;</td></tr>
            
            <tr><td>Riesgo Poliza</td><td>
                <asp:DropDownList ID="cmbRiesgoPoliza" runat="server" DataSourceID="SqlDataSourceRiesgoPolizas" DataValueField="cod_riesgo_poliza_consumo" DataTextField="nombre_riesgo_poliza_consumo">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSourceRiesgoPolizas" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_riesgo_poliza_consumo], [nombre_riesgo_poliza_consumo] FROM [riesgo_poliza_consumo] ORDER BY [nombre_riesgo_poliza_consumo]"></asp:SqlDataSource>
                </td></tr>
           
            <tr><td>Porcentaje</td><td><asp:TextBox runat="server" ID="txtPorcentajePoliza" Width="200px"></asp:TextBox>
                     <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server" FilterType="Custom" ValidChars="0123456789."
    TargetControlID="txtPorcentajePoliza" />
                                   </td></tr>

            <%--<tr><td>Valor</td><td><asp:TextBox runat="server" ID="txtValorPoliza" Width="200px"></asp:TextBox>
                  <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" FilterType="Numbers"
    TargetControlID="txtValorPoliza" />

                              </td></tr>--%>

            <tr><td>Vigencia en meses</td>
                <td>
                    <asp:DropDownList ID="cmbVigenciaPoliza" runat="server">
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
                        <asp:ListItem>13</asp:ListItem>                        
                        <asp:ListItem>14</asp:ListItem>                        
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>                        
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                        <asp:ListItem>32</asp:ListItem>
                        <asp:ListItem>33</asp:ListItem>
                        <asp:ListItem>34</asp:ListItem>
                        <asp:ListItem>35</asp:ListItem>
                        <asp:ListItem>36</asp:ListItem>
                        <asp:ListItem>37</asp:ListItem>
                        <asp:ListItem>38</asp:ListItem>
                        <asp:ListItem>39</asp:ListItem>
                        <asp:ListItem>40</asp:ListItem>
                        <asp:ListItem>41</asp:ListItem>
                        <asp:ListItem>42</asp:ListItem>
                        <asp:ListItem>43</asp:ListItem>
                        <asp:ListItem>44</asp:ListItem>
                        <asp:ListItem>45</asp:ListItem>
                        <asp:ListItem>46</asp:ListItem>
                        <asp:ListItem>47</asp:ListItem>
                        <asp:ListItem>48</asp:ListItem>
                        <asp:ListItem>49</asp:ListItem>                        
                        <asp:ListItem>50</asp:ListItem>                        
                        <asp:ListItem>51</asp:ListItem>
                        <asp:ListItem>52</asp:ListItem>
                        <asp:ListItem>53</asp:ListItem>
                        <asp:ListItem>54</asp:ListItem>
                        <asp:ListItem>55</asp:ListItem>
                        <asp:ListItem>56</asp:ListItem>
                        <asp:ListItem>57</asp:ListItem>
                        <asp:ListItem>58</asp:ListItem>
                        <asp:ListItem>59</asp:ListItem>
                        <asp:ListItem>60</asp:ListItem>
                        <asp:ListItem>61</asp:ListItem>                        
                        <asp:ListItem>62</asp:ListItem>
                        <asp:ListItem>63</asp:ListItem>
                        <asp:ListItem>64</asp:ListItem>
                        <asp:ListItem>65</asp:ListItem>
                        <asp:ListItem>66</asp:ListItem>
                        <asp:ListItem>67</asp:ListItem>
                        <asp:ListItem>68</asp:ListItem>
                        <asp:ListItem>69</asp:ListItem>
                        <asp:ListItem>70</asp:ListItem>
                        <asp:ListItem>71</asp:ListItem>
                        <asp:ListItem>72</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr><td>Observaciones</td><td><asp:TextBox TextMode="MultiLine" Height="50px" runat="server" ID="txtObservacionesPoliza" Width="200px"></asp:TextBox></td></tr>
        </table>

          <asp:Label runat="server" ID="lblErrorPoliza" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button runat="server" Text="Aceptar" ID="btnAceptarPoliza" onclick="btnAceptarPoliza_Click" />
        <asp:Button runat="server" Text="Cancelar" ID="btnCancelarPoliza" OnClick="btnCancelarPoliza_Click" />


        
    </ContentTemplate> 
                    <Triggers>
              
                <asp:PostBackTrigger ControlID="btnImportar" />
            </Triggers>

                   </asp:UpdatePanel>


          </asp:Panel>
      <asp:Label style=" display:none" ID="lblInviciblePolizas" runat="server"  />
    
     
      <cca:ModalPopupExtender ID="ModalPopupExtenderPolizas" runat="server"
     PopupControlID="pnlEmergentePolizas"      
             TargetControlID="lblInviciblePolizas"
             BackgroundCssClass="modalBackground"
             DropShadow="true"
             Enabled="true">
</cca:ModalPopupExtender> 

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmEstampillas.aspx.cs" Inherits="frm_csuministro_frmEstampillas" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
   
       <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <div class="tab">Estampillas</div>
    <div class="Formulario">
        <table>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td>Banco</td>
                <td>
                    <asp:DropDownList ID="cmbBanco" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre_banco_suministro" DataValueField="cod_banco_suministro">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [nombre_banco_suministro], [cod_banco_suministro] FROM [banco_suministro] ORDER BY [nombre_banco_suministro]"></asp:SqlDataSource>
                </td>
            </tr>

            <tr>
                <td>Tipo Cuenta</td>
                <td>
                    <asp:DropDownList ID="cmbTipoCuenta" runat="server" DataSourceID="SqlDataSource2" DataTextField="nombre_tipo_cuenta_banco" DataValueField="cod_tipo_cuenta_banco">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_tipo_cuenta_banco], [nombre_tipo_cuenta_banco] FROM [tipo_cuenta_banco] ORDER BY [nombre_tipo_cuenta_banco]"></asp:SqlDataSource>
                </td>
            </tr>

            <tr>
                <td>Cuenta</td>
                <td>
                    <asp:TextBox ID="txtcuenta" runat="server" Width="250px"></asp:TextBox>
                    <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" FilterType="Custom" ValidChars="0123456789"
    TargetControlID="txtcuenta" />
                </td>
            </tr>

            <tr>
                <td>Destinacion</td>
                <td>
                    <asp:DropDownList ID="cmbDestinacion" runat="server" DataSourceID="SqlDataSource3" DataTextField="nombre_destinacion_suministro" DataValueField="cod_destinacion_suministro">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_destinacion_suministro], [nombre_destinacion_suministro] FROM [destinacion_suministro] ORDER BY [nombre_destinacion_suministro]"></asp:SqlDataSource>
                </td>
            </tr>

            <tr>
                <td>Beneficiario</td>
                <td>
                    <asp:TextBox ID="txtBeneficiario" runat="server" Width="258px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>

            <tr>
                <td>Porcentaje</td>
                <td>
                    <asp:TextBox ID="txtPorcentaje" runat="server"></asp:TextBox>

                    <cca:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" FilterType="Custom" ValidChars="0123456789.,"
    TargetControlID="txtPorcentaje" />
                    <asp:Button ID="btnCalcularValor" runat="server" OnClick="btnCalcularValor_Click" Text="Calcular Valor" />
                </td>
            </tr>

            <tr>
                <td>Valor</td>
                <td>
                    <asp:TextBox ID="txtValor" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Archivo</td>
                <td>
                    <div style="display:none;">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                        </div>
                    <asp:Button ID="btnFileUpload1"  runat="server" Text="Seleccionar Archivo" />
                    <asp:HyperLink ID="lnkVerArchivo" runat="server" Target="_blank" Visible="False">Ver Archivo</asp:HyperLink>
                    <asp:Button ID="btnCargarArchivo" runat="server" OnClick="btnCargarArchivo_Click" Text="Cargar Archivo" />
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:CheckBox ID="chkPagoCliente" runat="server" Text="Estampilla paga por el cliente" />
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                </td>
            </tr>

        </table>

    </div>

</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmPolizas.aspx.cs" Inherits="frm_csuministro_frmPolizas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
  <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
   
         <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <div class="tab">Poliza Contrato Suministro</div>
    <div class="Formulario">
        <table>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td>Riesgo</td>
                <td>
                    <asp:DropDownList ID="cmbRiesgo" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre_riesgo_poliza_consumo" DataValueField="cod_riesgo_poliza_consumo">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_riesgo_poliza_consumo], [nombre_riesgo_poliza_consumo] FROM [riesgo_poliza_consumo] ORDER BY [nombre_riesgo_poliza_consumo]"></asp:SqlDataSource>
                </td>
            </tr>

            <tr>
                <td>Porcentaje</td>
                <td>
                    <asp:TextBox ID="txtPorcentaje" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Valor</td>
                <td>
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Observaciones</td>
                <td>
                    <asp:TextBox ID="txtObservaciones" runat="server" Height="68px" TextMode="MultiLine" Width="293px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Vigencia en Meses</td>
                <td>
                    <asp:DropDownList ID="cmbVigencia" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>Aseguradora</td>
                <td>
                    <asp:DropDownList ID="cmbAseguradora" runat="server" AppendDataBoundItems="True" DataSourceID="SqlDataSource2" DataTextField="nombre_cod_aseguradora_suministro" DataValueField="cod_aseguradora_suministro">
                      
                       
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_aseguradora_suministro], [nombre_cod_aseguradora_suministro] FROM [aseguradora_suministro] ORDER BY [nombre_cod_aseguradora_suministro]"></asp:SqlDataSource>
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


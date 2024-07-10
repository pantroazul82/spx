<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCrearAdjunto.aspx.cs" Inherits="frm_csuministro_frmCrearAdjunto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
      <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <div class="tab">Adjuntos contrato suministro</div>
    <div class="Formulario">
        <table>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td>Estado</td>
                <td>
                    <asp:DropDownList ID="cmbEstado" runat="server" DataSourceID="SqlDataSource2" DataTextField="nombre_estado_contrato" DataValueField="cod_estado_adjunto_contrato_suministro" Enabled="False">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_estado_adjunto_contrato_suministro], [nombre_estado_contrato] FROM [estado_adjunto_contrato_suministro] ORDER BY [cod_manual]"></asp:SqlDataSource>
                </td>
            </tr>

            <tr>
                <td>Fecha creacion</td>
                <td>
                    <asp:Label ID="lblFechaCreacion" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>Creado por</td>
                <td>
                    <asp:Label ID="lblCreadoPor" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>Tipo adjunto</td>
                <td>
                    <asp:DropDownList ID="cmbTipoAdjunto" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre_tipo_adjunto_contrato_suministro" DataValueField="cod_tipo_adjunto_contrato_suministro">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [cod_tipo_adjunto_contrato_suministro], [nombre_tipo_adjunto_contrato_suministro] FROM [tipo_adjunto_contrato_suministro] ORDER BY [nombre_tipo_adjunto_contrato_suministro]"></asp:SqlDataSource>
                </td>
            </tr>

            <tr>
                <td>Observaciones Iniciales </td>
                <td>
                    <asp:TextBox ID="txtObservaciones" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Archivo</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <asp:HyperLink ID="lnkVerArchivo" runat="server" Target="_blank" Visible="False">Ver Archivo</asp:HyperLink>
                    <asp:Button ID="btnCargarArchivo" runat="server" OnClick="btnCargarArchivo_Click" Text="Cargar Archivo" />
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


<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoContratos.aspx.cs" Inherits="frm_csuministro_frmListadoContratos" %>

<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <style type="text/css">
        .auto-style1
        {
            width: 100%;
        }
        .auto-style2
        {
            width: 207px;
        }
        .auto-style3
        {
            width: 345px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20px" Text="Contratos de Suministro"></asp:Label>
    </p>
    <table class="auto-style1">
        <tr>
            <td>Vigentes desde</td>
            <td class="auto-style2">
                <dx:ASPxDateEdit ID="calInicio" runat="server">
                </dx:ASPxDateEdit>
            </td>
            <td class="auto-style3">
                <dx:ASPxDateEdit ID="calFin" runat="server">
                </dx:ASPxDateEdit>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Buscar por</td>
            <td class="auto-style2">
                <asp:DropDownList ID="cmbFiltro" runat="server">
                    <asp:ListItem>Numero Contrato</asp:ListItem>
                    <asp:ListItem>Cliente</asp:ListItem>
                    <asp:ListItem>Numero Socio Cliente</asp:ListItem>
                    <asp:ListItem>Nit Cliente</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtFiltro" runat="server" Width="300px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">
                <asp:CheckBox ID="chkProximosVencer" runat="server" Text="Proximos a Vencer" />
            </td>
            <td class="auto-style3">
                <asp:DropDownList ID="cmbProximosAvencer" runat="server">
                    <asp:ListItem Value="1">1 Mes</asp:ListItem>
                    <asp:ListItem Value="2">2 Meses</asp:ListItem>
                    <asp:ListItem Value="3">3 Meses</asp:ListItem>
                    <asp:ListItem Value="4">4 Meses</asp:ListItem>
                    <asp:ListItem Value="5">5 Meses</asp:ListItem>
                    <asp:ListItem Value="6">6 Meses</asp:ListItem>
                    <asp:ListItem Value="7">7 Meses</asp:ListItem>
                    <asp:ListItem Value="8">8 Meses</asp:ListItem>
                    <asp:ListItem Value="9">9 Meses</asp:ListItem>
                    <asp:ListItem Value="10">10 Meses</asp:ListItem>
                    <asp:ListItem Value="11">11 Meses</asp:ListItem>
                    <asp:ListItem Value="12">12 Meses</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                <asp:Button ID="btnExportarExcel" runat="server" Text="Exportar Excel" OnClick="btnExportarExcel_Click" />
            </td>
        </tr>
        </table>
    <p>
        <dx:ASPxGridView ID="grdDatos" runat="server" AutoGenerateColumns="False" ViewStateMode="Disabled">
            <Columns>
                <dx:GridViewDataColumn VisibleIndex="0">
                    <DataItemTemplate>
                        <asp:HyperLink runat="server" ID="lnk" Text="Ver Contrato" NavigateUrl='<%# "frmDetalleContrato.aspx?cod="+Eval("cod_contratos_suministro") %>'></asp:HyperLink>
                    </DataItemTemplate>

                </dx:GridViewDataColumn>
                  <dx:GridViewDataTextColumn FieldName="nombre_estado_contrato_suministro" Caption="Estado" VisibleIndex="1">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="numero_contrato" Caption="Numero Contrato" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
               
                <dx:GridViewDataTextColumn FieldName="nitcliente" Caption="Nit Cliente" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="nombrecliente" Caption="Nombre Cliente" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="numerosocio" Caption="Numero Socio" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
          
                <dx:GridViewDataDateColumn FieldName="fecha_incio" Caption="Inicio" VisibleIndex="7">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataDateColumn FieldName="fecha_terminacion" Caption="Fin" VisibleIndex="8">
                </dx:GridViewDataDateColumn>
               
                <dx:GridViewDataColumn FieldName="valor_contrato" Caption="Valor Contrato" VisibleIndex="12">
                    <DataItemTemplate>
                        <asp:Label runat="server" ID="lblLabelValor" Text='<%# string.Format("{0:c}", Eval("valor_contrato")) %>'></asp:Label>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>
                <dx:GridViewDataTextColumn FieldName="otrosi" Caption="Otro Si" VisibleIndex="13">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataCheckColumn FieldName="no_genera_flujo" Caption="Omite flujo" VisibleIndex="14">
                </dx:GridViewDataCheckColumn>
                
                <dx:GridViewDataDateColumn FieldName="horas" Caption="Suma horas cambio de estado" VisibleIndex="15">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataDateColumn FieldName="minutos" Caption="minutos" VisibleIndex="15" Visible="false">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataDateColumn FieldName="fecha_cambio" Caption="Ultimo cambio de estado" VisibleIndex="16">
                </dx:GridViewDataDateColumn>
            </Columns>
            <Settings ShowFilterRow="True" />
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        </dx:ASPxGridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
            SelectCommand="
            SELECT [numero_contrato], [consecutivo_interno], [nitCliente], [contacto_juridico], [numero_celular_contacto_juridico], [fecha_incio], [fecha_terminacion], [fecha_aprobacion_cartera], [fecha_aprobacion_juridico], [fecha_aprobacion_inicial], [valor_contrato], [otrosi] FROM [contratos_suministro]"></asp:SqlDataSource>
        <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="grdDatos">
        </dx:ASPxGridViewExporter>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>


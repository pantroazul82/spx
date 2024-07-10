<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmSolicitudGeneral.aspx.cs" Inherits="Web2020.frm.proceso.frmSolicitudGeneral" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />   <style type="text/css">
        .style1
        {
            width: 100%;
        }
                                                                                             .style2
                                                                                             {
                                                                                                 text-align: center;
                                                                                             }
                                                                                             .style3
                                                                                             {
                                                                                             }
                                                                                             .style4
                                                                                             {
                                                                                                 width: 95px;
                                                                                             }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<asp:Button ID="btnCliente" style="visibility:hidden;" runat="server" onclick="btnCliente_Click" 
                    Text="Cargar" Width="0px" />
<div class="tab">
                
            Solicitud General</div>
<div class="Formulario">

    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Asesor Comercial</td>
            <td class="style4">
                <asp:DropDownList ID="cmbAsesorComercial" runat="server" 
                    DataSourceID="SqlDataSource1" DataTextField="nombre" 
                    DataValueField="cod_usuario">
                </asp:DropDownList>
            </td>
            <td class="style3">
                Fecha de Solicitud</td>
            <td>
                <telerik:RadDatePicker ID="calFechaSolicitud" Runat="server">
                <Calendar ID="Calendar3" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                </telerik:RadDatePicker>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                Informacion de Cliente</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Cliente </td>
            <td class="style4">
                <asp:TextBox ID="txtCliente" runat="server" Width="300px"></asp:TextBox>
            </td>
            <td class="style3">
                Socio de Negocio</td>
            <td>
                <asp:TextBox ID="txtSociodeNegocio" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Sucursal</td>
            <td class="style4">
                <asp:DropDownList ID="cmbSucursal" runat="server">
                </asp:DropDownList>
            </td>
            <td class="style3">
                Contacto</td>
            <td>
                <asp:DropDownList ID="cmbContacto" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Contrato legalizado&nbsp;&nbsp;
                </td>
            <td class="style4">
                <asp:RadioButton ID="rdLegalizadoSi" runat="server" Text="Si" 
                    GroupName="contratoLegalizado" />
                <asp:RadioButton ID="rdLegalizadoNo" runat="server" Text="No" 
                    GroupName="contratoLegalizado" />
            </td>
            <td class="style3">
                Carta de Aceptacion condiciones de Instalacion</td>
            <td>
                <asp:RadioButton 
                    ID="rdAceptacionSi" runat="server" Text="Si" GroupName="cartaAceptacion" />
                <asp:RadioButton ID="rdAceptacionNo" runat="server" Text="No" 
                    GroupName="cartaAceptacion" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
            <hr />
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>

        <tr>
            <td>
                <strong>Equipos Involucrados</strong></td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                <strong>Reactivos Involucrados</strong></td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Serial"></asp:Label>
                &nbsp;<asp:DropDownList ID="cmbSerial" runat="server" Width="350px">
                </asp:DropDownList>
                <asp:ImageButton ID="btnAgregarEquipo" runat="server" 
                    ImageUrl="~/img/Crystal_Clear_action_edit_add.png" ToolTip="Agregar Equipo" 
                    Width="20px" onclick="btnAgregarEquipo_Click" />
                <asp:ImageButton ID="btnLimpiarEquipos" runat="server" 
                    ImageUrl="~/img/web/delete.gif" ToolTip="Limpiar Equipo" 
                    Width="20px" onclick="btnLimpiarEquipos_Click" />
                </td>
            <td class="style3" colspan="2">
                Reactivos
                <asp:TextBox ID="txtReactivo" runat="server" Width="250px"></asp:TextBox>
                <asp:ImageButton ID="btnAgregarReactivo" runat="server" 
                    ImageUrl="~/img/Crystal_Clear_action_edit_add.png" ToolTip="Agregar Reactivo" 
                    Width="20px" onclick="btnAgregarReactivo_Click" />
                <asp:ImageButton ID="btnLimpiarReactivo" runat="server" 
                    ImageUrl="~/img/web/delete.gif" ToolTip="Limpiar Reactivo" 
                    Width="20px" onclick="btnLimpiarReactivo_Click" />
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <telerik:RadListBox ID="rdEquipos" runat="server" Skin="Office2010Blue" 
                    Width="350px">
<ButtonSettings TransferButtons="All"></ButtonSettings>

<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
                </telerik:RadListBox>
            </td>
            <td class="style3" colspan="2">
                <telerik:RadListBox ID="rdReactivos" runat="server" Skin="Office2010Blue" 
                    Width="350px">
<ButtonSettings TransferButtons="All"></ButtonSettings>

<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
                </telerik:RadListBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
                <tr>
            <td colspan="4">
            <hr />
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="4">
                <strong>Tipo de Servicio</strong></td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Soporte Tecnico</td>
            <td colspan="3">
                <asp:DataList ID="dataTiposIng" runat="server" BackColor="White" 
                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                    DataSourceID="tiposIngenieria" GridLines="Horizontal" RepeatColumns="4" 
                    ForeColor="Black">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <ItemStyle Width="200px" />
                    <ItemTemplate>
                    <asp:CheckBox runat="server" ID="chkTipo" Text='<%# Eval("valor") %>' Checked="false" ValidationGroup='<%# Eval("cod_dominio") %>' />
                      
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td colspan="3">
            <hr />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                Asesoria Cientifica</td>
            <td colspan="3">
                <asp:DataList ID="dataTiposCientifica" runat="server" BackColor="White" 
                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                    DataSourceID="odsTiposCientifica" GridLines="Horizontal" RepeatColumns="4" 
                    ForeColor="Black">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <ItemStyle Width="200px" />
                    <ItemTemplate >
                     <asp:CheckBox ID="chkTipo" runat="server" Text='<%# Eval("valor") %>' Checked="false" ValidationGroup='<%# Eval("cod_dominio") %>' />
                    
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
                <tr>
            <td colspan="4">
            <hr />
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <strong>Numero de Personas que recibiran el entrenamiento.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                <asp:TextBox ID="txtNumeroPersonasEntrenamiento" runat="server" Width="30px"></asp:TextBox>
                <asp:FilteredTextBoxExtender ID="txtNumeroPersonasEntrenamiento_FilteredTextBoxExtender" 
                    runat="server" Enabled="True" TargetControlID="txtNumeroPersonasEntrenamiento" 
                    ValidChars="1234567890">
                </asp:FilteredTextBoxExtender>
            </td>
            <td class="style3">
                Modalidad Envio </td>
            <td>
                <asp:DropDownList ID="cmbModalidad" runat="server" DataSourceID="sqlModalidad" 
                    DataTextField="nombreModalidadEquipo" DataValueField="codModalidadEquipo">
                </asp:DropDownList>
                <asp:SqlDataSource ID="sqlModalidad" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                    SelectCommand="SELECT [nombreModalidadEquipo], [codModalidadEquipo] FROM [ModalidadEquipo] ORDER BY [nombreModalidadEquipo]">
                </asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                Fecha Tentativa de instalacion y entrenamiento por soporte tecnico</td>
            <td>
                <telerik:RadDatePicker ID="calInstalacionIngenieria" Runat="server">
                <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                </telerik:RadDatePicker>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                Fecha tentativa de entrenamiento por asesoria cientifica</td>
            <td>
                <telerik:RadDatePicker ID="calEntrenamientoCientifica" Runat="server">
                <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
                </telerik:RadDatePicker>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <strong>Observaciones</strong></td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:TextBox ID="txtObservaciones" runat="server" Height="76px" TextMode="MultiLine" 
                    Width="869px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4" style="text-align: center">
                &nbsp;</td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4" style="text-align: center">
                <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                <asp:SqlDataSource ID="odsTiposCientifica" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                    SelectCommand="SELECT [valor], [cod_dominio] FROM [dominio] WHERE ([cod_rango] = @cod_rango) ORDER BY [valor]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="TIPOSERVCIE" Name="cod_rango" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="tiposIngenieria" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                    SelectCommand="SELECT [valor], [cod_dominio] FROM [dominio] WHERE ([cod_rango] = @cod_rango) ORDER BY [valor]">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="TIPOSERVING" Name="cod_rango" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                    SelectCommand="SELECT [cod_usuario], [login], [nombre] FROM [usuario] ORDER BY [nombre]">
                </asp:SqlDataSource>
            </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4" style="text-align: center">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
                    onclick="btnAceptar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" 
                    onclick="btnCancelar_Click" />
            </td>
            <td style="text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>


</div>
</asp:Content>

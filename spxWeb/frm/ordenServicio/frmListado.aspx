<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" 
CodeFile="frmListado.aspx.cs" Inherits="frm_ordenServicio_frmListado" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br><br>
<asp:CheckBox ID="chkHistorico" runat="server" Text="Ver Historico" />
<br>
<asp:Label runat="server" ID="SearchLabel1">
Filtros
</asp:Label>
<asp:DropDownList runat="server" ID="cmbFiltros">
<asp:ListItem Text="Seleccione" Value="-1"> </asp:ListItem>
<asp:ListItem Text="Cod Orden Servicio" Value="5"> </asp:ListItem>
<asp:ListItem Text="Serial" Value="1"> </asp:ListItem>
<asp:ListItem Text="Nit Cliente" Value="2"> </asp:ListItem>
<asp:ListItem Text="Modelo" Value="3"> </asp:ListItem>
<asp:ListItem Text="Fabricante" Value="4"> </asp:ListItem>
<asp:ListItem Text="Asignado A" Value="6"> </asp:ListItem>

</asp:DropDownList>
<asp:TextBox runat="server" ID="txtFiltro">

</asp:TextBox>

<asp:Button runat="server" Text="Buscar" CausesValidation="False" ID="btnBuscar" >
</asp:Button>
<div class="tab">Ordenes de Servicio<dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="ASPxGridView1">
    </dx:ASPxGridViewExporter>
    <asp:ImageButton ID="imgExcel" runat="server" ImageUrl="~/img/web/xls.png" OnClick="imgExcel_Click" />
    </div>


    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" ViewStateMode="Disabled" Width="500px">
        <Columns>
            <dx:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="codordenservicio" VisibleIndex="1" Caption="Cod Orden" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn Caption="Fecha Tentativa" FieldName="fechaprogramacion" VisibleIndex="4" Width="40px">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="asignadoa" VisibleIndex="2" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Serial" FieldName="serial" VisibleIndex="6"  Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Estado" FieldName="nombreestado" VisibleIndex="3" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Servicio" FieldName="nombretiposervicio" VisibleIndex="5" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Modelo" FieldName="nombremodelo" VisibleIndex="7" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="nitcliente" VisibleIndex="8" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Cliente" FieldName="nombrecliente" VisibleIndex="9" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Sucursal" FieldName="nombresucursal" VisibleIndex="10" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Modalidad" FieldName="nombremodalidadequipo" VisibleIndex="11" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="codestadoordenservicio" Visible="False" VisibleIndex="12" Width="40px">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn Width="40px">
                <DataItemTemplate>
                    <asp:ImageButton ID="btnImprimir" runat="server" ImageUrl="~/img/web/print.png" OnClick="verOrdenServicio" ToolTip="Imprimir" ValidationGroup='<%# Eval("codordenservicio") %>' Width="30" />
                    <asp:ImageButton ID="btnEjecutarOrden" runat="server" ImageUrl="~/img/web/update.gif" OnClick="ejecutarOrdenServicio" ToolTip="Ejecutar Orden de Servicio" ValidationGroup='<%# Eval("CodOrdenServicio") %>'
                        Visible='<%# validarVisibilidadEjecutar( Eval("Codestadoordenservicio") ) %>'
                        Width="30" />
                </DataItemTemplate>
            </dx:GridViewDataColumn>
        </Columns>
        <SettingsPager PageSize="20">
        </SettingsPager>
        <Settings ShowFilterRow="True" ShowFooter="True" />
        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
    </dx:ASPxGridView>
  






</asp:Content>


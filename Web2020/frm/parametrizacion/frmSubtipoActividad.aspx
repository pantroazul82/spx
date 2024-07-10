<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmSubtipoActividad.aspx.cs" Inherits="Web2020.frm.parametrizacion.frmSubtipoActividad" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 204px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Formulario tipo de tarea calendario!!!</div>
<div class="formulario">
<table style="width: 571px">
<tr>
<td class="style1"></td>
<td>
    <asp:Label ID="lblCodSubTipo" runat="server" Visible="False"></asp:Label>
    </td>
</tr>
<tr>
<td class="style1">Tipo Actividad</td>
<td>
    <telerik:RadComboBox ID="cmbTipoActividad" Runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="descripcion" 
        DataValueField="cod_tipo_tarea_calendario">
    </telerik:RadComboBox>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.tipo_tarea_calendarioTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_tipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_url" Type="String" />
            <asp:Parameter Name="Original_activo" Type="Boolean" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="url" Type="String" />
            <asp:Parameter Name="activo" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="url" Type="String" />
            <asp:Parameter Name="activo" Type="Boolean" />
            <asp:Parameter Name="Original_cod_tipo_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_url" Type="String" />
            <asp:Parameter Name="Original_activo" Type="Boolean" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </td>
</tr>
<tr>
<td class="style1">Descripcion</td>
<td>
    <asp:TextBox ID="txtDescripcion" runat="server" Width="200px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">url</td>
<td>
    <asp:TextBox ID="txtUrl" runat="server" Width="400px"></asp:TextBox>
    </td>
</tr>
<tr>
<td class="style1">&nbsp;</td>
<td>
    <asp:CheckBox ID="chkActivo" runat="server" Text="Activo" />
    </td>
</tr>
<tr>
<td class="style1">&nbsp;</td>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>
<tr>
<td class="style1">&nbsp;</td>
<td>
    <telerik:RadButton ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Aceptar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar">
    </telerik:RadButton>
    </td>
</tr>
</table>

</div>

</asp:Content>
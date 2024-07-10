<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmNuevaOrden.aspx.cs" Inherits="frm_ordenPrestamo_frmNuevaOrden" %>

<%@ Register src="../../controles/controlRepuestos.ascx" tagname="controlRepuestos" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 313px;
        }
        .style2
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<div class="tab">Solicitud de Repuestos</div>

<div class="Formulario">
<asp:Panel runat="server" ID="pnlInicio" Visible="true">
<table>
<tr>
<td colspan="4">
    <asp:Label ID="lblErrror" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>
<tr>
<td>Ingeniero Responsable</td>
<td>
    <asp:DropDownList ID="cmbIngenieroResponsable" runat="server">
    </asp:DropDownList>
    </td>
<td>Fecha de Creacion</td>
<td>
    <asp:Label ID="lblFechaCreacion" runat="server" Text="Label"></asp:Label>
    </td>
</tr>

<tr>
<td>Pais</td>
<td>
    <asp:DropDownList ID="cmbPais" runat="server" AutoPostBack="True" 
        DataSourceID="odsPais" DataTextField="nombrePais" DataValueField="codPais">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="odsPais" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.paisesTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_codPais" Type="String" />
            <asp:Parameter Name="Original_nombrePais" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="nombrePais" Type="String" />
            <asp:Parameter Name="Original_codPais" Type="String" />
            <asp:Parameter Name="Original_nombrePais" Type="String" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="codPais" Type="String" />
            <asp:Parameter Name="nombrePais" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    </td>
<td colspan="2" rowspan="3">
    <uc1:controlRepuestos ID="controlRepuestos1" runat="server" />
    </td>
</tr>

<tr>
<td>Departamento</td>
<td>
    <asp:DropDownList ID="cmbDepartamento" runat="server" AutoPostBack="True" 
        DataSourceID="odsDepartamento" DataTextField="NombreDepartamento" 
        DataValueField="codDepartamento">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="odsDepartamento" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByCodigoPais" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.departamentoTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_codPais" Type="String" />
            <asp:Parameter Name="Original_codDepartamento" Type="String" />
            <asp:Parameter Name="Original_NombreDepartamento" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="NombreDepartamento" Type="String" />
            <asp:Parameter Name="Original_codPais" Type="String" />
            <asp:Parameter Name="Original_codDepartamento" Type="String" />
            <asp:Parameter Name="Original_NombreDepartamento" Type="String" />
        </UpdateParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbPais" Name="codPais" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <InsertParameters>
            <asp:Parameter Name="codPais" Type="String" />
            <asp:Parameter Name="codDepartamento" Type="String" />
            <asp:Parameter Name="NombreDepartamento" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    </td>
</tr>

<tr>
<td>Ciudad</td>
<td>
    <asp:DropDownList ID="cmbCiudad" runat="server" DataSourceID="odsCiudad" 
        DataTextField="nombreCiudad" DataValueField="codCiudad">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="odsCiudad" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByCodPaisCodDepartamento" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.ciudadesTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_codPais" Type="String" />
            <asp:Parameter Name="Original_codDepartamento" Type="String" />
            <asp:Parameter Name="Original_codCiudad" Type="String" />
            <asp:Parameter Name="Original_nombreCiudad" Type="String" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="nombreCiudad" Type="String" />
            <asp:Parameter Name="Original_codPais" Type="String" />
            <asp:Parameter Name="Original_codDepartamento" Type="String" />
            <asp:Parameter Name="Original_codCiudad" Type="String" />
            <asp:Parameter Name="Original_nombreCiudad" Type="String" />
        </UpdateParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbPais" Name="codPais" 
                PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="cmbDepartamento" Name="codDepartamento" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
        <InsertParameters>
            <asp:Parameter Name="codPais" Type="String" />
            <asp:Parameter Name="codDepartamento" Type="String" />
            <asp:Parameter Name="codCiudad" Type="String" />
            <asp:Parameter Name="nombreCiudad" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    </td>
</tr>

<tr>
<td>Observaciones</td>
<td colspan="3">
    <asp:TextBox ID="txtObsIniciales" runat="server" Height="129px" 
        TextMode="MultiLine" Width="419px"></asp:TextBox>
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>

    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="btnAceptar" runat="server" ImageUrl="~/img/web/ok.gif" 
                onclick="btnAceptar_Click" ToolTip="Aceptar" Width="30px" />
            <asp:ImageButton ID="btnCancelar" runat="server" 
                ImageUrl="~/img/web/cancel.gif" onclick="btnCancelar_Click" 
                ToolTip="Cancelar" Width="30px" />
        </td>
    </tr>

</table>
</asp:Panel>

<asp:Panel runat="server" ID="pnlResumen" Visible="false">
<table>
<tr>
<td colspan="4">
    <b>Resumen Orden de Prestamo</b></td>
</tr>
<tr>
<td>Codigo Orden Prestamo:</td>
<td class="style2">
    <asp:Label ID="lblCodOrden" runat="server" Text="Label"></asp:Label>
    </td>
<td>&nbsp;</td>
<td class="style1">
    &nbsp;</td>
</tr>

    <tr>
        <td>
            Ingeniero Responsable:</td>
        <td class="style2">
            <asp:Label ID="lblIngernieroResponsable" runat="server"></asp:Label>
        </td>
        <td>
            Creada Por:</td>
        <td class="style1">
            <asp:Label ID="lblCreadaPor" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Ciudad:</td>
        <td class="style2">
            <asp:Label ID="lblCiudad" runat="server"></asp:Label>
        </td>
        <td>
            Fecha de Creacion</td>
        <td class="style1">
            <asp:Label ID="lblFechaCreacion2" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Repuestos:</td>
        <td colspan="3">
            <asp:Label ID="lblRepuestos" runat="server"></asp:Label>
        </td>
    </tr>

<tr>
<td>Observaciones</td>
<td class="style2" colspan="3">
    <asp:Label ID="lblObservaciones" runat="server"></asp:Label>
    </td>
</tr>

    <tr>
        <td>
            &nbsp;</td>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td class="style1">
            <asp:LinkButton ID="linkCrearOtra" runat="server" onclick="linkCrearOtra_Click">Crear Otra</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="linkImprimir" runat="server" onclick="linkImprimir_Click">Imprimir</asp:LinkButton>
        </td>
    </tr>

</table>
</asp:Panel>
</div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmAprobarOrdenPrestamo.aspx.cs" Inherits="Web2020.frm.ordenPrestamo.frmAprobarOrdenPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="tab">Aceptar Orden de Prestamo</div>
<div class="Formulario">
<table>
<tr>
<td>
    Observaciones Aceptacion</td>
<td>
    &nbsp;</td>

</tr>
<tr>
<td>
    <asp:TextBox ID="txtObsRechazo" runat="server" Height="105px" 
        TextMode="MultiLine" Width="481px"></asp:TextBox>
</td>
<td>
    &nbsp;</td>

</tr>
<tr>
<td>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="codRepuesto" DataSourceID="odsRepuestos" 
        ForeColor="#333333" GridLines="None" 
        onrowdatabound="GridView1_RowDataBound">
        <RowStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundField DataField="codRepuesto" HeaderText="Cod Repuesto" 
                ReadOnly="True" SortExpression="codRepuesto" />
            <asp:BoundField DataField="repuesto" HeaderText="Repuesto" 
                SortExpression="repuesto" />
            <asp:BoundField DataField="cantidadsolicitada" HeaderText="Cantidad solicitada" 
                SortExpression="cantidadsolicitada" />
            <asp:TemplateField HeaderText="Cantidad Aprobada">
            <ItemTemplate>
            <asp:DropDownList runat="server" ID="cmbCantidadAprobada">
            
            </asp:DropDownList>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="cantidadPrestada" HeaderText="cantidadPrestada" 
                SortExpression="cantidadPrestada" Visible="False" />
            <asp:BoundField DataField="cantidadDevuelta" HeaderText="cantidadDevuelta" 
                SortExpression="cantidadDevuelta" Visible="False" />
            <asp:BoundField DataField="cantidadConNotaSalida" 
                HeaderText="cantidadConNotaSalida" SortExpression="cantidadConNotaSalida" 
                Visible="False" />
            <asp:CheckBoxField DataField="entregadoIngeniero" 
                HeaderText="entregadoIngeniero" SortExpression="entregadoIngeniero" 
                Visible="False" />
            <asp:CheckBoxField DataField="devueltoAlmacen" HeaderText="devueltoAlmacen" 
                SortExpression="devueltoAlmacen" Visible="False" />
            <asp:CheckBoxField DataField="notaSalida" HeaderText="notaSalida" 
                SortExpression="notaSalida" Visible="False" />
            <asp:BoundField DataField="obsNotaSalida" HeaderText="obsNotaSalida" 
                SortExpression="obsNotaSalida" Visible="False" />
            <asp:BoundField DataField="fechaEntregaIng" HeaderText="fechaEntregaIng" 
                SortExpression="fechaEntregaIng" Visible="False" />
            <asp:BoundField DataField="fechaDevolucion" HeaderText="fechaDevolucion" 
                SortExpression="fechaDevolucion" Visible="False" />
            <asp:BoundField DataField="fechaNotaSalida" HeaderText="fechaNotaSalida" 
                SortExpression="fechaNotaSalida" Visible="False" />
        </Columns>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <asp:ObjectDataSource ID="odsRepuestos" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataBycodOrdenPrestamo" 
        TypeName="SPControladoraDatos.dsPlantillasTableAdapters.pltRepuestoxOrdenPrestamoCompletaTableAdapter">
        <SelectParameters>
            <asp:SessionParameter Name="codOrdenPrestamo" SessionField="op" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</td>
<td>
    &nbsp;</td>

</tr>


<tr>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
</td>
<td>
    &nbsp;</td>

</tr>


<tr>
<td>
    <asp:ImageButton ID="btnOk" runat="server" ImageUrl="~/img/web/ok.gif" 
        onclick="btnOk_Click" ToolTip="Aceptar" Width="30px" />
    <asp:ImageButton ID="btnCancelar" runat="server" 
        ImageUrl="~/img/web/cancel.gif" onclick="btnCancelar_Click" 
        ToolTip="Cancelar" Width="30px" />
</td>
<td>
    &nbsp;</td>

</tr>


</table>


</div>
</asp:Content>
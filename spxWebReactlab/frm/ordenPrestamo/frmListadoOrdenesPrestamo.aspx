<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoOrdenesPrestamo.aspx.cs" Inherits="frm_ordenPrestamo_frmListadoOrdenesPrestamo" %>

<asp:Content ID="Content3" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br>
<asp:CheckBox runat="server" ID="chkAnuladas" Checked="true" Text="Ocultar ordenes Anuladas" />
<br>
Filtro <asp:DropDownList runat="server" id="cmbFiltros">
<asp:ListItem Text="Cod Orden Prestamo" Value="1"> </asp:ListItem>
<asp:ListItem Text="Responsable" Value="2"> </asp:ListItem>
<asp:ListItem Text="Estado Orden" Value="3"> </asp:ListItem>
</asp:DropDownList>
<asp:TextBox runat="server" ID="txtFiltro"></asp:TextBox>
<asp:ImageButton runat="server" ID="btnBuscar" ImageUrl="~/img/lupa.png" Width="30px" OnClick="SearchBtn1_Click" ToolTip="Buscar" />
<asp:ImageButton runat="server" ID="btnSolicitar" ImageUrl="~/img/web/insert.gif" Width="30px" OnClick="solicitar_click" ToolTip="Solicitar Repuesto" />


<div class="tab">Listado de Ordenes de Prestamo</div>
<div class="Formulario">

<asp:GridView runat="server" AllowPaging="True" AutoGenerateColumns="False" ID="Browse1" AllowSorting="True" 
DataSourceID="ObjectDataSource1" DataKeyNames="CodOrdenPrestamo" 
OnRowDataBound="Browse1_RowDataBound" OnSorting="Browse1_Sorting" OnPreRender="Browse1_PreRender" >
 
<PagerSettings FirstPageImageUrl="../../img/web/PagerFirst.gif" LastPageImageUrl="../../img/web/PagerLast.gif" Mode="NextPreviousFirstLast" NextPageImageUrl="../../img/web/PagerNext.gif" Position="TopAndBottom" PreviousPageImageUrl="../../img/web/PagerPrevious.gif">
</PagerSettings>
 
<Columns>
 
 
<asp:TemplateField HeaderText="Codigo Orden" SortExpression="CodOrdenPrestamo">
 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("CodOrdenPrestamo") %>' ID="CodOrdenPrestamoLabel1"
>
</asp:Label>
</ItemTemplate>
 
<FooterStyle HorizontalAlign="Right">
</FooterStyle>
 
<HeaderStyle HorizontalAlign="Right">
</HeaderStyle>
 
<ItemStyle HorizontalAlign="Right" Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 

<asp:TemplateField HeaderText="Estado" SortExpression="EstadosOrdenPrestamo.NombreEstadoOP">

 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetOrdenPrestamo_EstadosOrdenPrestamo_NombreEstadoOP ( Container.DataItem as BOLayer.OrdenPrestamo ) %>" ID="EstadosOrdenPrestamoNombreEstadoOPLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
  
<asp:TemplateField HeaderText="Ciudad" SortExpression="Ciudade.NombreCiudad">

 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetOrdenPrestamo_Ciudade_NombreCiudad ( Container.DataItem as BOLayer.OrdenPrestamo ) %>" ID="CiudadeNombreCiudadLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField> 

<asp:TemplateField HeaderText="Responsable" SortExpression="LoginResponsable">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("LoginResponsable") %>' ID="LoginResponsableLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
<asp:TemplateField HeaderText="Solicitado Por" SortExpression="LoginSolicito">
 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("LoginSolicito") %>' ID="LoginSolicitoLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>

<asp:TemplateField HeaderText="Fecha Orden" SortExpression="FechaOrden">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("FechaOrden_Date") %>' ID="FechaOrdenLabel1"
>
</asp:Label>
</ItemTemplate>
 
<FooterStyle HorizontalAlign="Right">
</FooterStyle>
 
<HeaderStyle HorizontalAlign="Right">
</HeaderStyle>
 
<ItemStyle HorizontalAlign="Right" Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
 
<asp:TemplateField Visible="false" HeaderText="codOrdenServicio" SortExpression="CodOrdenServicio">
 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("CodOrdenServicio") %>' ID="CodOrdenServicioLabel1">
</asp:Label>
</ItemTemplate>
 
<FooterStyle HorizontalAlign="Right">
</FooterStyle>
 
<HeaderStyle HorizontalAlign="Right">
</HeaderStyle>
 
<ItemStyle HorizontalAlign="Right" Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 

<asp:TemplateField HeaderText="Observaciones Iniciales" Visible="false" >

 
<ItemTemplate>
<asp:Label runat="server" id="ObsInicialesTextBox1" Text='<%# Eval("ObsIniciales") %>'
></asp:Label>

</ItemTemplate>
 
<ItemStyle Wrap="True" Width="120px">
</ItemStyle>
 
</asp:TemplateField>

<asp:TemplateField HeaderText="Repuestos">
<ItemTemplate>
<asp:label runat="server" ID="lblREpuesto"
 
 Text='<%# verREpuestos(Container.DataItem as BOLayer.OrdenPrestamo) %>' /> 
 
</ItemTemplate>
<ItemStyle Width="250px" />
</asp:TemplateField> 

 <asp:TemplateField HeaderText="Opciones">
 <ItemTemplate>
 <asp:ImageButton runat="server" ID="btnImprimir" ImageUrl="~/img/web/print.png" Width="30px" OnClick="linkImprimir_Click"
 ValidationGroup='<%# Eval("CodOrdenPrestamo") %>' ToolTip="Imprimir" /> 
 
 <asp:ImageButton runat="server" ID="btnAceptar"
 OnClientClick="return confirm('Esta seguro de Aceptar la orden de Prestamo?');"  ImageUrl="~/img/web/confirmar.png" Width="30px" OnClick="linkAprobar_Click"
 ValidationGroup='<%# Eval("CodOrdenPrestamo") %>' Visible='<%# verVisibleAutorizar(Container.DataItem as BOLayer.OrdenPrestamo) %>' ToolTip="Aprobar" /> 
 
  <asp:ImageButton runat="server" ID="btnRechazar"
 OnClientClick="return confirm('Esta seguro de Rechazar la orden de Prestamo?');"  ImageUrl="~/img/negras.png" Width="30px" OnClick="linkRechazar_Click"
 ValidationGroup='<%# Eval("CodOrdenPrestamo") %>' Visible='<%# verVisibleAutorizar(Container.DataItem as BOLayer.OrdenPrestamo) %>' ToolTip="Rechazar" /> 
 
  <asp:ImageButton runat="server" ID="btnRecibirRepuestos"
 OnClientClick="return confirm('Esta seguro de Recibir los repuestos?');"  ImageUrl="~/img/web/adelante.png" Width="30px" OnClick="linkRecibir_Click"
 ValidationGroup='<%# Eval("CodOrdenPrestamo") %>' Visible='<%# verVisibleRecibir(Container.DataItem as BOLayer.OrdenPrestamo) %>' ToolTip="Recibir Repuestos" /> 
 
  <asp:ImageButton runat="server" ID="btnEntregarRepuestos"
 OnClientClick="return confirm('Esta seguro de Recibir de vuelta los repuestos?');"  ImageUrl="~/img/web/back.png" Width="30px" OnClick="linkDevolver_Click"
 ValidationGroup='<%# Eval("CodOrdenPrestamo") %>' Visible='<%# verVisibleREcibirAlmacen(Container.DataItem as BOLayer.OrdenPrestamo) %>' ToolTip="Recibir Repuestos Almacen" /> 
 
  
  
 
 <asp:ImageButton runat="server" ID="btnAnular"
 OnClientClick="return confirm('Esta seguro de Anular la orden de Prestamo?');"  ImageUrl="~/img/web/cancelar.png" Width="30px" OnClick="linkAnular_Click"
 ValidationGroup='<%# Eval("CodOrdenPrestamo") %>' Visible='<%# verVisibleAnular(Container.DataItem as BOLayer.OrdenPrestamo) %>' ToolTip="Anular" /> 

 
 </ItemTemplate>
 
 </asp:TemplateField>
 

</Columns>
 
<EmptyDataTemplate>
 No se encontraron ordenes de prestamo
</EmptyDataTemplate>
 
</asp:GridView>

<div class="panelResultados" style="width:540px">
<asp:ImageButton Width="30px" ID="expExcel" runat="server" ImageUrl="~/img/web/xls.png"
ToolTip="Exportar a Excel" AlternateText="Excel" onclick="expExcel_Click" /><br />
            <asp:Label ID="lblEncontrados" runat="server"></asp:Label> registro(s) encontrado(s)
            <br /><br />
            Mostrando de <asp:Label ID="lbldesde" runat="server"></asp:Label> Hasta <asp:Label ID="lblHasta" runat="server"></asp:Label>
            </div>


<asp:ObjectDataSource runat="server" ID="ObjectDataSource3" TypeName="BOLayer.EstadosOrdenPrestamoFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource1" TypeName="BOLayer.OrdenPrestamoFactory" SelectCountMethod="Count" EnablePaging="True" UpdateMethod="Save" DeleteMethod="Delete" SortParameterName="pSortExpression" MaximumRowsParameterName="pMaxResult" StartRowIndexParameterName="pFirstResult" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pSortExpression"></asp:Parameter>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>
<DeleteParameters>
<asp:Parameter Name="codOrdenPrestamo"></asp:Parameter>
</DeleteParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource6" TypeName="BOLayer.Usuario0Factory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource8" TypeName="BOLayer.Usuario0Factory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource7" TypeName="BOLayer.Usuario0Factory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource5" TypeName="BOLayer.Usuario0Factory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource9" TypeName="BOLayer.Usuario0Factory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource2" TypeName="BOLayer.CiudadeFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

</div>
</asp:Content>



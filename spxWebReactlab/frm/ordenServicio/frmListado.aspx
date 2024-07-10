<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" 
CodeFile="frmListado.aspx.cs" Inherits="frm_ordenServicio_frmListado" %>

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

<asp:Button runat="server" Text="Buscar" CausesValidation="False" ID="btnBuscar" OnClick="SearchBtn1_Click">
</asp:Button>
<div class="tab">Ordenes de Servicio</div>

<div class="Formulario">
<asp:GridView runat="server" AllowPaging="True" AutoGenerateColumns="False" ID="Browse1" AllowSorting="True" 
DataSourceID="ObjectDataSource1" DataKeyNames="CodOrdenServicio" OnRowDataBound="Browse1_RowDataBound" OnSorting="Browse1_Sorting" 
OnPreRender="Browse1_PreRender" OnSelectedIndexChanged="Browse1_SelectedIndexChanged" PageSize="20">
 
<PagerSettings FirstPageImageUrl="../../img/web/PagerFirst.gif" LastPageImageUrl="../../img/web/PagerLast.gif" Mode="NextPreviousFirstLast" NextPageImageUrl="../../img/web/PagerNext.gif" Position="TopAndBottom" PreviousPageImageUrl="../../img/web/PagerPrevious.gif">
</PagerSettings>
 
<Columns>
 

<asp:TemplateField HeaderText="Cod Orden" SortExpression="CodOrdenServicio">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("CodOrdenServicio") %>' ID="CodOrdenServicioLabel1"
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
<asp:TemplateField  
HeaderText="Asignado A" SortExpression="AsignadoA"> 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_verASignadoA ( Container.DataItem as BOLayer.OrdenServicio ) %>" ID="EstadosOrdenServicioNombreEstadoLabel1zzz"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>    

<asp:TemplateField HeaderText="Estado" SortExpression="EstadosOrdenServicio.NombreEstado">
 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetOrdenServicio_EstadosOrdenServicio_NombreEstado ( Container.DataItem as BOLayer.OrdenServicio ) %>" ID="EstadosOrdenServicioNombreEstadoLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>  
<asp:TemplateField HeaderText="Fecha Tentativa" SortExpression="FechaProgramacion">

<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_verFEchaProgramacion ( Container.DataItem as BOLayer.OrdenServicio ) %>" ID="TipoServiciaoNombretipoServicioLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField> 


<asp:TemplateField HeaderText="Tipo Servicio" SortExpression="TipoServicio.NombretipoServicio">

<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetOrdenServicio_TipoServicio_NombretipoServicio ( Container.DataItem as BOLayer.OrdenServicio ) %>" ID="TipoServicioNombretipoServicioLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField> 


 
<asp:TemplateField Visible="false" HeaderText="Fecha Programacion" SortExpression="FechaProgramacion">
 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("FechaProgramacion_Date") %>' ID="FechaProgramacionLabel1"
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

 
<asp:TemplateField HeaderText="serial" SortExpression="Serial">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("Serial") %>' ID="SerialLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>

<asp:TemplateField HeaderText="Modelo" SortExpression="Equipo.Modelo.NombreModelo">
 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetOrdenServicio_Equipo_CodModelo ( Container.DataItem as BOLayer.OrdenServicio ) %>" ID="EquipoCodModeloLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
<asp:TemplateField HeaderText="Cliente" SortExpression="NitCliente">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("NitCliente") %>' ID="NitClienteLabel1">
</asp:Label>
<br>
<asp:Label runat="server" Text="<%# nombreCliente ( Container.DataItem as BOLayer.OrdenServicio ) %>" ID="Label1">
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>


<asp:TemplateField HeaderText="Sucursal" SortExpression="SucursalCliente.NombreSucursal">

 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetOrdenServicio_SucursalCliente_NombreSucursal ( Container.DataItem as BOLayer.OrdenServicio ) %>" ID="SucursalClienteNombreSucursalLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>


<asp:TemplateField HeaderText="Modalidad" SortExpression="ModalidadEquipo.NombreModalidadEquipo">

<ItemTemplate>
<asp:Label runat="server" 
Text="<%# Browse1_GetOrdenServicio_ModalidadEquipo_NombreModalidadEquipo ( Container.DataItem as BOLayer.OrdenServicio ) %>" ID="ModalidadEquipoNombreModalidadEquipoLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField> 
 
<asp:TemplateField Visible="false" HeaderText="observaciones" SortExpression="Observaciones">

 
<ItemTemplate>
<asp:TextBox runat="server" Rows="3" Columns="60" ReadOnly="True" MaxLength="500" ID="ObservacionesTextBox1" CssClass="MemoReadOnly" TextMode="MultiLine" Text='<%# Eval("Observaciones") %>'
>
</asp:TextBox>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>

<asp:TemplateField HeaderText="Opciones">

<ItemTemplate>
<asp:ImageButton runat="server" ValidationGroup= '<%# Eval("CodOrdenServicio") %>' ID="btnImprimir" OnClick="verOrdenServicio" ToolTip="Imprimir" ImageUrl="~/img/web/print.png" Width="30" />
<asp:ImageButton runat="server" ValidationGroup= '<%# Eval("CodOrdenServicio") %>' ID="btnEjecutarOrden" OnClick="ejecutarOrdenServicio"  ToolTip="Ejecutar Orden de Servicio"  ImageUrl="~/img/web/update.gif"
Visible="<%# validarVisibilidadEjecutar( Container.DataItem as BOLayer.OrdenServicio ) %>"
 Width="30"  />
</ItemTemplate>
 
<ItemStyle Wrap="True" Width="65px">
</ItemStyle>
 
</asp:TemplateField>


 
</Columns>
 
<EmptyDataTemplate>
 No Se encontraron ordenes de servicio. 
</EmptyDataTemplate>
 
</asp:GridView>

<div class="panelResultados" style="width:540px">
<asp:ImageButton ID="expExcel" Width="26px" runat="server" ImageUrl="~/img/web/xls.png"
ToolTip="Exportar a Excel" AlternateText="Excel" onclick="expExcel_Click" /><br />
            <asp:Label ID="lblEncontrados" runat="server"></asp:Label> registro(s) encontrado(s)
            <br /><br />
            Mostrando de <asp:Label ID="lbldesde" runat="server"></asp:Label> Hasta <asp:Label ID="lblHasta" runat="server"></asp:Label>
            </div>

</div>


<asp:ObjectDataSource runat="server" ID="ObjectDataSource1" TypeName="BOLayer.OrdenServicioFactory" SelectCountMethod="Count" EnablePaging="True" UpdateMethod="Save" DeleteMethod="Delete" SortParameterName="pSortExpression" MaximumRowsParameterName="pMaxResult" 
StartRowIndexParameterName="pFirstResult" SelectMethod="GetAll">
<SelectParameters>
<asp:Parameter Name="pSortExpression"></asp:Parameter>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>
<DeleteParameters>
<asp:Parameter Name="codOrdenServicio"></asp:Parameter>
</DeleteParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource4" TypeName="BOLayer.EstadosOrdenServicioFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource2" TypeName="BOLayer.AsesoresComercialeFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource3" TypeName="BOLayer.EquipoFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource7" TypeName="BOLayer.TipoServicioFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource6" TypeName="BOLayer.SucursalClienteFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource5" TypeName="BOLayer.ModalidadEquipoFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

</asp:Content>


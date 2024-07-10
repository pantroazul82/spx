<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmSeguimiento.aspx.cs" Inherits="frm_hojavida_frmSeguimiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br>
<br />
<asp:Label runat="server" ID="SearchLabel1">
Filtros
</asp:Label>
<asp:DropDownList runat="server" ID="cmbFiltros">
<asp:ListItem Text="Seleccione" Value="-1"> </asp:ListItem>
<asp:ListItem Text="Serial" Value="1"> </asp:ListItem>
<asp:ListItem Text="Nit Cliente" Value="2"> </asp:ListItem>
<asp:ListItem Text="Nombre Cliente" Value="3"> </asp:ListItem>
<asp:ListItem Text="Socio de Negocio" Value="4"> </asp:ListItem>
<asp:ListItem Text="Modelo" Value="5"> </asp:ListItem>

</asp:DropDownList>
<asp:TextBox runat="server" ID="SearchText1">

</asp:TextBox>

<asp:Button runat="server" Text="Buscar" CausesValidation="False" ID="SearchBtn1" OnClick="SearchBtn1_Click">
</asp:Button>


<div class="tab">Listado de Equipos</div>
<div class="Formulario">
<asp:GridView runat="server" AllowPaging="True" AutoGenerateColumns="False" ID="Browse1" 
AllowSorting="True" DataSourceID="ObjectDataSource1" DataKeyNames="Serial" 
OnRowDataBound="Browse1_RowDataBound" OnSorting="Browse1_Sorting" OnPreRender="Browse1_PreRender" 
OnSelectedIndexChanged="Browse1_SelectedIndexChanged" PageSize="20">
 
<PagerSettings FirstPageImageUrl="../../img/web/PagerFirst.gif" LastPageImageUrl="../../img/web/PagerLast.gif" Mode="NextPreviousFirstLast" NextPageImageUrl="../../img/web/PagerNext.gif" Position="TopAndBottom" PreviousPageImageUrl="../../img/web/PagerPrevious.gif">
</PagerSettings>
 
<Columns>
 

<asp:TemplateField HeaderText="Serial" SortExpression="Serial">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("Serial") %>' ID="SerialLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
<asp:TemplateField HeaderText="Fabricante" SortExpression="Fabricante.NombreFabricante">
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetEquipo_Modelo_NombreFabricante ( Container.DataItem as BOLayer.Equipo ) %>" ID="lblNombreFabricante"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
<asp:TemplateField HeaderText="Modelo" SortExpression="Modelo.NombreModelo">
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetEquipo_Modelo_NombreModelo ( Container.DataItem as BOLayer.Equipo ) %>" ID="ModeloNombreModeloLabel1"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>

 

 
<asp:TemplateField HeaderText="Nit Cliente" SortExpression="NitClienteUbica">

 
<ItemTemplate>
<asp:Label runat="server" Text='<%# Eval("NitClienteUbica") %>' ID="lblNitCliente"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
<asp:TemplateField HeaderText="Cliente"  SortExpression="Cliente.NombreCliente">

 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetNombreCliente ( Container.DataItem as BOLayer.Equipo ) %>" ID="lblNombreCLiente"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
<asp:TemplateField HeaderText="Modalidad" SortExpression="ModalidadEquipo.NombreModalidadEquipo">

 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetEquipo_ModalidadEquipo_NombreModalidadEquipo ( Container.DataItem as BOLayer.Equipo ) %>" ID="lblModalidad"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 

 
 

 
<asp:TemplateField HeaderText="Sucursal" SortExpression="SucursalCliente.NombreSucursal">

 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetEquipo_SucursalCliente_NombreSucursal ( Container.DataItem as BOLayer.Equipo ) %>" ID="lblSucursal"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>

<asp:TemplateField HeaderText="Ciudad" SortExpression="Ciudade.NombreCiudad" >

 
<ItemTemplate>
<asp:Label runat="server" Text="<%# Browse1_GetNombreCiudad ( Container.DataItem as BOLayer.Equipo ) %>" ID="lblNombreCiudad"
>
</asp:Label>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
 
<asp:TemplateField>

 
<ItemTemplate>
<asp:ImageButton runat="server" Height="26px" ImageUrl="~/img/frm/logos.png" AlternateText="Hoja de vida" 
ToolTip="Hoja de vida" OnClick="oprimirBoton" 
ID="ntmHojaVida" ValidationGroup= '<%# Eval("Serial") %>'>
</asp:ImageButton>
</ItemTemplate>
 
<ItemStyle Wrap="True">
</ItemStyle>
 
</asp:TemplateField>
 
 
 
</Columns>
 
<EmptyDataTemplate>
 No se Encontraron Equipos. 
</EmptyDataTemplate>
 
</asp:GridView>


</div>
<div class="panelResultados" style="width:540px">
            <asp:Label ID="lblEncontrados" runat="server"></asp:Label> registro(s) encontrado(s)
            <br /><br />
            Mostrando de <asp:Label ID="lbldesde" runat="server"></asp:Label> Hasta <asp:Label ID="lblHasta" runat="server"></asp:Label>
            </div>



<asp:ObjectDataSource runat="server" ID="ObjectDataSource1" TypeName="BOLayer.EquipoFactory" SelectCountMethod="Count" EnablePaging="True" UpdateMethod="Save" DeleteMethod="Delete" SortParameterName="pSortExpression" MaximumRowsParameterName="pMaxResult" StartRowIndexParameterName="pFirstResult" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pSortExpression"></asp:Parameter>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>
<DeleteParameters>
<asp:Parameter Name="serial"></asp:Parameter>
</DeleteParameters>

</asp:ObjectDataSource>


<asp:ObjectDataSource runat="server" ID="ObjectDataSource5" TypeName="BOLayer.SucursalClienteFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource4" TypeName="BOLayer.ModeloFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource3" TypeName="BOLayer.ModalidadEquipoFactory" SelectMethod="GetAll"
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

<asp:ObjectDataSource runat="server" ID="ObjectDataSource6" TypeName="BOLayer.TipoPropiedadFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

<asp:ObjectDataSource runat="server" ID="ObjectDataSource2" TypeName="BOLayer.EstadoLocalEquipoFactory" SelectMethod="GetAll"
>
<SelectParameters>
<asp:Parameter Name="pCriteria"></asp:Parameter>
</SelectParameters>

</asp:ObjectDataSource>

</asp:Content>


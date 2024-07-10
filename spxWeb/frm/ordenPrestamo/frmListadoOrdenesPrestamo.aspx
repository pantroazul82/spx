<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoOrdenesPrestamo.aspx.cs" Inherits="frm_ordenPrestamo_frmListadoOrdenesPrestamo" %>

<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<asp:Content ID="Content3" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br>
<asp:CheckBox runat="server" ID="chkAnuladas" Checked="true" Text="Ocultar ordenes Anuladas" />
<br>
    <asp:CheckBox runat="server" ID="chkTop" Checked="true" Text="Traer los primeros registros" />
    <asp:DropDownList ID="cmbtop" runat="server">
        <asp:ListItem Text="10" Value="10"></asp:ListItem>
        <asp:ListItem Text="50" Value="50"></asp:ListItem>
        <asp:ListItem Text="100" Value="100"></asp:ListItem>
        <asp:ListItem Text="200" Value="200"></asp:ListItem>
    </asp:DropDownList>
<br>
Filtro <asp:DropDownList runat="server" id="cmbFiltros">
<asp:ListItem Text="Cod Orden Prestamo" Value="1"> </asp:ListItem>
<asp:ListItem Text="Responsable" Value="2"> </asp:ListItem>
<asp:ListItem Text="Estado Orden" Value="3"> </asp:ListItem>
</asp:DropDownList>
<asp:TextBox runat="server" ID="txtFiltro"></asp:TextBox>
<asp:ImageButton runat="server" ID="btnBuscar" ImageUrl="~/img/lupa.png" Width="30px" OnClick="btnBuscar_Click" ToolTip="Buscar" />
<asp:ImageButton runat="server" ID="btnSolicitar" ImageUrl="~/img/web/insert.gif" Width="30px" OnClick="solicitar_click" ToolTip="Solicitar Repuesto" />


<div class="tab">Listado de Ordenes de Prestamo&nbsp;
    <asp:Button ID="btnExportarExcel" runat="server" OnClick="btnExportarExcel_Click" Text="Exportar Excel" />
    <br />
    <dx:ASPxGridView ID="grdDatos" runat="server" AutoGenerateColumns="False"  EnableViewState="False" KeyFieldName="codordenprestamo">
        <Columns>
            
            <dx:GridViewDataTextColumn FieldName="codordenprestamo" Caption="Cod" ReadOnly="True" VisibleIndex="0">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="codordenservicio" Caption="Cod Orden Servicio" VisibleIndex="1">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="nombreestadoop" Caption="Estado" VisibleIndex="2">
            </dx:GridViewDataTextColumn>

            <dx:GridViewDataTextColumn FieldName="loginresponsable" VisibleIndex="3">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="loginsolicito" VisibleIndex="4">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn FieldName="fechaorden" VisibleIndex="5">
            </dx:GridViewDataDateColumn>
            <dx:GridViewDataTextColumn FieldName="serial" VisibleIndex="6">

            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn Caption="Repuesto" VisibleIndex="7">
                <DataItemTemplate>
                  <asp:label runat="server" ID="lblREpuesto"
 
 Text='<%# verREpuestos(Eval("codordenprestamo")) %>' />
                </DataItemTemplate>
            </dx:GridViewDataColumn>

                <dx:GridViewDataColumn Caption="Opciones" VisibleIndex="9">
                <DataItemTemplate>
                    
<asp:ImageButton runat="server" ID="btnHojaVida" ImageUrl="~/img/frm/logos.png" Width="30px" OnClick="btnHojaVida_Click"
 ValidationGroup='<%# Eval("serial") %>' ToolTip="Hoja de vida" Visible='<%# Eval("serial ")!= null && Eval("serial ")!= System.DBNull.Value %>' /> 

<asp:ImageButton runat="server" ID="btnImprimir" ImageUrl="~/img/web/print.png" Width="30px" OnClick="linkImprimir_Click"
 ValidationGroup='<%# Eval("codordenprestamo") %>' ToolTip="Imprimir" /> 
 
 <asp:ImageButton runat="server" ID="btnAceptar"
 OnClientClick="return confirm('Esta seguro de Aceptar la orden de Prestamo?');"  ImageUrl="~/img/web/confirmar.png" Width="30px" OnClick="linkAprobar_Click"
 ValidationGroup='<%# Eval("codordenprestamo") %>' Visible='<%# verVisibleAutorizar(Eval("codestadoordenprestamo")) %>' ToolTip="Aprobar" /> 
 
  <asp:ImageButton runat="server" ID="btnRechazar"
 OnClientClick="return confirm('Esta seguro de Rechazar la orden de Prestamo?');"  ImageUrl="~/img/negras.png" Width="30px" OnClick="linkRechazar_Click"
 ValidationGroup='<%# Eval("codordenprestamo") %>' Visible='<%# verVisibleAutorizar(Eval("codestadoordenprestamo")) %>' ToolTip="Rechazar" /> 
 
  <asp:ImageButton runat="server" ID="btnRecibirRepuestos"
 OnClientClick="return confirm('Esta seguro de Recibir los repuestos?');"  ImageUrl="~/img/web/adelante.png" Width="30px" OnClick="linkRecibir_Click"
 ValidationGroup='<%# Eval("codordenprestamo") %>' Visible='<%# verVisibleRecibir(Eval("codestadoordenprestamo")) %>' ToolTip="Recibir Repuestos" /> 
 
  <asp:ImageButton runat="server" ID="btnEntregarRepuestos"
 OnClientClick="return confirm('Esta seguro de Recibir de vuelta los repuestos?');"  ImageUrl="~/img/web/back.png" Width="30px" OnClick="linkDevolver_Click"
 ValidationGroup='<%# Eval("codordenprestamo") %>' Visible='<%# verVisibleREcibirAlmacen(Eval("codestadoordenprestamo")) %>' ToolTip="Recibir Repuestos Almacen" /> 
 
  
  
 
 <asp:ImageButton runat="server" ID="btnAnular"
 OnClientClick="return confirm('Esta seguro de Anular la orden de Prestamo?');"  ImageUrl="~/img/web/cancelar.png" Width="30px" OnClick="linkAnular_Click"
 ValidationGroup='<%# Eval("codordenprestamo") %>' Visible='<%# verVisibleAnular(Eval("codestadoordenprestamo")) %>' ToolTip="Anular" /> 

                </DataItemTemplate>
            </dx:GridViewDataColumn>

        </Columns>
        <Settings ShowFilterRow="True" />
        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
    </dx:ASPxGridView>
   
    <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="grdDatos">
    </dx:ASPxGridViewExporter>
    <br />
    <br />
    </div>
<div class="Formulario">


</div>
</asp:Content>



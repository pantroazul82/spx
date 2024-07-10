<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmCerrarPendientes.aspx.cs" Inherits="Web2020.frm.calendar.frmCerrarPendientes" %>
<%@ Reference Control="~/controles/ctlSignature.ascx" %>
<%@ Register src="~/controles/ctlSignature.ascx" tagname="ctlSignature" tagprefix="uc" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../css/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<div class="tab">Cerrar Actividad <asp:Label runat="server" ID="lblCodActividad"></asp:Label></div>
<div class="Formulario">

<table>

<tr>
<td></td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>Pendientes
    
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="ObjectDataSourcePen" GridLines="None">
<MasterTableView DataKeyNames="cod_pendiente_tarea" DataSourceID="ObjectDataSourcePen">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="pendiente" 
            FilterControlAltText="Filter pendiente column" HeaderText="pendiente" 
            SortExpression="pendiente" UniqueName="pendiente">
        </telerik:GridBoundColumn>
        
        
        
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>  
            <asp:Label runat="server" ID="lblUser" Text='<%# verNombreUsuario(Eval("usuario_ejecucion")) %>'
            ></asp:Label>
            
    
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        

        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>  
            <telerik:RadDateTimePicker ID="RadDateTimePicker1" Runat="server" 
            SelectedDate='<%# ((Eval("fecha_ejecucion_pendiente") == null || Eval("fecha_ejecucion_pendiente") == System.DBNull.Value)?((DateTime?)null):(DateTime?)Eval("fecha_ejecucion_pendiente")) %>'
            Enabled='<%# (Eval("fecha_ejecucion_pendiente") == null || Eval("fecha_ejecucion_pendiente") == System.DBNull.Value) %>'
              >
    </telerik:RadDateTimePicker>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn1 column" 
            UniqueName="TemplateColumn1">
            <ItemTemplate>&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:ImageButton ValidationGroup='<%# Eval("cod_pendiente_tarea") %>' runat="server" ID="btnVisible"
            Visible='<%# (Eval("fecha_ejecucion_pendiente") == null || Eval("fecha_ejecucion_pendiente") == System.DBNull.Value) %>'
            ImageUrl="~/img/web/ok.gif" OnClick="btnGuardarFecha_Click"
             />
            </ItemTemplate>
        </telerik:GridTemplateColumn>
    </Columns>

<EditFormSettings>
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False">
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
</FilterMenu>

<HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
</HeaderContextMenu>
    </telerik:RadGrid>
    <asp:ObjectDataSource ID="ObjectDataSourcePen" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByCod_tarea_calendario" 
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.pendiente_tareaTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_pendiente_tarea" Type="Int32" />
            <asp:Parameter Name="Original_cod_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_pendiente" Type="String" />
            <asp:Parameter Name="Original_fecha_ejecucion_pendiente" Type="DateTime" />
            <asp:Parameter Name="Original_usuario_ejecucion" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cod_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="pendiente" Type="String" />
            <asp:Parameter Name="fecha_ejecucion_pendiente" Type="DateTime" />
            <asp:Parameter Name="usuario_ejecucion" Type="Int32" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="lblCodActividad" Name="cod_tarea_calendario" 
                PropertyName="Text" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="cod_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="pendiente" Type="String" />
            <asp:Parameter Name="fecha_ejecucion_pendiente" Type="DateTime" />
            <asp:Parameter Name="usuario_ejecucion" Type="Int32" />
            <asp:Parameter Name="Original_cod_pendiente_tarea" Type="Int32" />
            <asp:Parameter Name="Original_cod_tarea_calendario" Type="Int32" />
            <asp:Parameter Name="Original_pendiente" Type="String" />
            <asp:Parameter Name="Original_fecha_ejecucion_pendiente" Type="DateTime" />
            <asp:Parameter Name="Original_usuario_ejecucion" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    <br />
    Observaciones Finales</td>
</tr>

<tr>
<td></td>
<td>
    <asp:TextBox ID="txtObservacionesAprobacion" runat="server" Height="129px" 
        TextMode="MultiLine" Width="443px"></asp:TextBox>
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
       
           <asp:Label runat="server" ID="lblErrorFirma" Text="" ForeColor="Red"></asp:Label>
       
    </td>
</tr>

<tr>
<td></td>
<td>
    <telerik:RadButton ID="btnCerrar" runat="server" onclick="btnCerrar_Click" 
        Text="Cerrar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar">
    </telerik:RadButton>
    </td>
</tr>
</table>
</div>


</asp:Content>




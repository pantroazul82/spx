<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCapacitacion.aspx.cs" Inherits="frm_capacitacion_frmCapacitacion" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />


    <style type="text/css">
        .style1
        {
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br />
<div class="tab">
Formulario de Capacitaciones
</div>

<div class="Formulario">
<table>
<tr>
<td></td>
<td>
    <asp:Label ID="lblTituloEstado" runat="server" Text="Estado" Visible="False"></asp:Label>
    <asp:Label ID="lblCod" runat="server" Visible="False"></asp:Label>
    </td>
<td>
    <asp:Label ID="lblNombreEstado" runat="server" Visible="False"></asp:Label>
    </td>
<td class="style1">
    <asp:Button ID="btnCambiarDeEstado" runat="server" 
        onclick="btnCambiarDeEstado_Click" Text="Cambiar de Estado" 
        OnClientClick="return confirm('Esta seguro de cambiar estado a la capacitacion no podra cambiar horarios ni clases despues de hacer esta accion!');"
        Visible="False" />
    <asp:Button ID="btnReabrir" runat="server" onclick="btnReabrir_Click" 
        Text="Reabrir" Visible="False" />
    <asp:Label ID="lblConflicto" runat="server" Visible="False"></asp:Label>
    </td>
<td>&nbsp;</td>
</tr>

<tr>
<td></td>
<td>Tema</td>
<td><asp:TextBox runat="server" ID="txtNombre" Width="200px"></asp:TextBox> </td>
<td class="style1">Clases</td>
<td>Integrante</td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Fecha de Inicio</td>
<td>
    <telerik:RadDatePicker ID="calInicio" Runat="server">
     <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>


    </td>
<td class="style1">
    <telerik:RadDateTimePicker ID="calClaseIni" Runat="server">
     <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    <br />
    <telerik:RadDateTimePicker ID="calClaseFin" Runat="server">
     <Calendar ID="Calendar3" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    <br />
    <telerik:RadButton ID="btnAgregarClase" runat="server" 
        onclick="btnAgregarClase_Click" Text="Agregar">
    </telerik:RadButton>
    <asp:Label ID="lblErrorClases" runat="server" ForeColor="Red"></asp:Label>
    </td>
<td>
    <asp:DropDownList ID="cmbInscrito" Runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_usuario" 
        onprerender="cmbInscrito_PreRender"></asp:DropDownList>
    
    <br />
    <telerik:RadButton ID="btnAgregar" runat="server" Text="Agregar" 
        onclick="btnAgregar_Click">
    </telerik:RadButton>
    <asp:Label ID="lblErrorIntegrante" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
<td class="style1" colspan="2">
    <asp:HyperLink ID="linkConflicto" runat="server" Visible="False">[linkConflicto]</asp:HyperLink>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Fecha Final</td>
<td>
    <telerik:RadDatePicker ID="calFin" Runat="server">
     <Calendar ID="Calendar4" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
    </td>
<td rowspan="9" valign="top" class="style1">
    <telerik:RadGrid ID="grdClases" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="odsClases" GridLines="None" Skin="Web20">
<MasterTableView DataKeyNames="cod_sesion_capacitacion" DataSourceID="odsClases">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        

        <telerik:GridTemplateColumn HeaderText="Fecha de inicio">
        <ItemTemplate>
        <asp:HyperLink runat="server" ID="lnkListado" NavigateUrl='<%# "frmInscritosClases.aspx?cod="+Eval("cod_sesion_capacitacion") %>' Text='<%# Eval("fecha_inicio") %>'></asp:HyperLink>
        </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn HeaderText="Fecha de fin">
        <ItemTemplate>
        <asp:HyperLink runat="server" ID="lnkListado23" NavigateUrl='<%# "frmInscritosClases.aspx?cod="+Eval("cod_sesion_capacitacion") %>' Text='<%# Eval("fecha_fin") %>'></asp:HyperLink>
        </ItemTemplate>
        </telerik:GridTemplateColumn>

        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
            <asp:ImageButton runat="server" ID="btnQuitarClase" ValidationGroup='<%# Eval("cod_sesion_capacitacion") %>' Visible='<%# vervisible() %>'
             ImageUrl="~/img/web/cancel.gif" Width="20px" OnClick="btnQuitarclase" 
             OnClientClick="return confirm('Esta seguro de quitar este registro?');"
             />
             <asp:ImageButton runat="server" ID="ImageButton1" ValidationGroup='<%# Eval("cod_sesion_capacitacion") %>' Visible='<%# !vervisible() %>'
             ImageUrl="~/img/web/ok.gif" Width="20px" OnClick="btnEjecutarclase" tooltip="Ejecutar" AlternateText="Ejecutar"
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
    <asp:ObjectDataSource ID="odsClases" runat="server" DeleteMethod="Delete" 
        InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByCod_capacitacion" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.session_capacitacionTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_cod_sesion_capacitacion" Type="Int32" />
            <asp:Parameter Name="Original_cod_capacitacion" Type="Int32" />
            <asp:Parameter Name="Original_fecha_inicio" Type="DateTime" />
            <asp:Parameter Name="Original_fecha_fin" Type="DateTime" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="cod_capacitacion" Type="Int32" />
            <asp:Parameter Name="fecha_inicio" Type="DateTime" />
            <asp:Parameter Name="fecha_fin" Type="DateTime" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="lblCod" Name="cod_capacitacion" 
                PropertyName="Text" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="cod_capacitacion" Type="Int32" />
            <asp:Parameter Name="fecha_inicio" Type="DateTime" />
            <asp:Parameter Name="fecha_fin" Type="DateTime" />
            <asp:Parameter Name="Original_cod_sesion_capacitacion" Type="Int32" />
            <asp:Parameter Name="Original_cod_capacitacion" Type="Int32" />
            <asp:Parameter Name="Original_fecha_inicio" Type="DateTime" />
            <asp:Parameter Name="Original_fecha_fin" Type="DateTime" />
        </UpdateParameters>
    </asp:ObjectDataSource>
    </td>
<td rowspan="9" valign="top">
    <telerik:RadGrid ID="grdIntegrante" runat="server" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="sqlInscritos" GridLines="None" Skin="Web20">
<MasterTableView DataSourceID="sqlInscritos">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="usuario" 
            FilterControlAltText="Filter nombre column" HeaderText="Usuario" 
            SortExpression="usuario" UniqueName="usuario">
        </telerik:GridBoundColumn>
      
        <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column" 
            UniqueName="TemplateColumn">
            <ItemTemplate>
                        <asp:ImageButton runat="server" ID="btnQuitarInscrito" ValidationGroup='<%# Eval("cod_usuario") %>' Visible='<%# vervisible() %>'
             ImageUrl="~/img/web/cancel.gif" Width="20px" OnClick="QuitarInscrito" 
             OnClientClick="return confirm('Esta seguro de quitar este registro?');"
             />
             <asp:Label runat="server" ID="lblCaption" Text='<%# verTexto( Eval("cod_usuario") ) %>'></asp:Label>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
      
         <telerik:GridTemplateColumn HeaderText="Asistencia">
        <ItemTemplate>
        <asp:Label runat="server" Text='<%# verPorcentaje( Eval("asistencia") ,Eval("clases") )  %>' ID="lblMensaje"></asp:Label>
        </ItemTemplate>
        </telerik:GridTemplateColumn>       

         <telerik:GridTemplateColumn HeaderText="Comprobantes" >
         <ItemTemplate>
         <asp:ImageButton runat="server" OnClick="btnVerAsistencia_Click" ID="btnVerAsistencia" Visible='<%#  (Eval("adj_asistencia").ToString() == "1")?true:false %>' ImageUrl="~/img/web/lookup.gif" ToolTip="Ver Asistencia" ValidationGroup='<%# Eval("cod_usuario") %>' />
          <asp:ImageButton runat="server" OnClick="btnVerEvaluacion_Click" ID="btnVerEvaluacion" Visible='<%#  (Eval("evaluacion").ToString() == "1")?true:false %>' ImageUrl="~/img/web/lookup.gif" ToolTip="Ver Evaluacion" ValidationGroup='<%# Eval("cod_usuario") %>' />
         <asp:ImageButton runat="server" OnClick="btnVerCertificado_Click" ID="btnVerCertificado" Visible='<%#  (Eval("certificado").ToString() == "1")?true:false %>' ImageUrl="~/img/web/lookup.gif" ToolTip="Ver Certificado" ValidationGroup='<%# Eval("cod_usuario") %>' />
         

         </ItemTemplate>
         </telerik:GridTemplateColumn>

         
         <telerik:GridTemplateColumn HeaderText="Evaluacion Final" >
         <ItemTemplate>

         <asp:Label runat="server" ID="lblTexto" Text=' <%# (Eval("aprobo") == System.DBNull.Value)?"":((Eval("aprobo").ToString() == "1")?"Aprobo":"No Aprobo") %>' ForeColor="Black" Font-Bold="true"></asp:Label>
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
    <asp:SqlDataSource ID="sqlInscritos" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select 
asistente_capacitacion.cod_capacitacion,usuario.cod_usuario,max(usuario.nombre) 'usuario',
max(cast(asistente_capacitacion.aprobo as int)) aprobo,
case when max(cast(adj_certificado as varbinary(10))) is not null then 1 else 0 end 'certificado',
case when max(cast(adj_asistencia as varbinary(10))) is not null then 1 else 0 end 'adj_asistencia',
case when max(cast(adj_evaluacion as varbinary(10))) is not null then 1 else 0 end 'evaluacion',
sum( cast(asistio as int)) 'asistencia',count(codasistentexsession) 'clases'
 from asistente_capacitacion 
join usuario on usuario.cod_usuario = asistente_capacitacion.cod_usuario
left join asistentexsession on asistentexsession.cod_capacitacion = asistente_capacitacion.cod_capacitacion
and asistentexsession.cod_usuario = asistente_capacitacion.cod_usuario
where asistente_capacitacion.cod_capacitacion=@cod_capacitacion
group by asistente_capacitacion.cod_capacitacion,usuario.cod_usuario">
        <SelectParameters>
            <asp:ControlParameter ControlID="lblCod" Name="cod_capacitacion" 
                PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Modelo</td>
<td>
    <asp:TextBox ID="txtModelo" runat="server" Width="250px"></asp:TextBox>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Reactivo</td>
<td>
    <asp:TextBox ID="txtReactivo" runat="server" Width="248px"></asp:TextBox>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Dictada por</td>
<td>
    <asp:DropDownList ID="cmbDictadaPor" Runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="cod_usuario" 
        OnPreRender="cmbDictadaPor_PreRender"></asp:DropDownList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [cod_usuario], [nombre] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Otro: </td>
<td>
    <asp:TextBox ID="txtotro" runat="server" Width="250px"></asp:TextBox>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>Observaciones</td>
<td>
    <asp:TextBox ID="txtObservaciones" runat="server" Height="101px" 
        TextMode="MultiLine" Width="254px"></asp:TextBox>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
</tr>


<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
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


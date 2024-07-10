<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmCerrarCapacitacion.aspx.cs" Inherits="frm_capacitacion_frmCerrarCapacitacion" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<br />
<br /><asp:Label runat="server" ID="lblTexto"></asp:Label>
<div class="tab"> Listado de Inscritos&nbsp;<asp:Label runat="server" ID="lblcodigoSesion" Visible="false"></asp:Label>
    &nbsp;<asp:Button ID="btnVolver" runat="server" onclick="btnVolver_Click" 
        Text="Volver" Width="100px" />
    
    <asp:Button ID="btnCerrarCapacitacion" runat="server" 
        onclick="btnCerrarCapacitacion_Click" Text="Cerrar Capacitacion" 
        Width="130px" />
    
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowSorting="True" 
        AutoGenerateColumns="False" CellSpacing="0" DataSourceID="SqlDataSource1" 
        GridLines="None">
<MasterTableView datasourceid="SqlDataSource1">
<CommandItemSettings ExportToPdfText="Export to PDF"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="usuario" 
            FilterControlAltText="Filter nombre column" HeaderText="usuario" 
            SortExpression="usuario" UniqueName="usuario">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn HeaderText="Asistencia">
        <ItemTemplate>
        <asp:Label runat="server" Text='<%# ((int.Parse( (Eval("asistencia") == System.DBNull.Value)?("0"):(Eval("asistencia").ToString())) * 100 )/int.Parse( (Eval("clases")     == System.DBNull.Value)?("0"):(Eval("clases"    ).ToString()))).ToString()+"%" %>' ID="lblMensaje"></asp:Label>
        </ItemTemplate>
        </telerik:GridTemplateColumn>
         
         

         <telerik:GridTemplateColumn HeaderText="Comprobantes" >
         <ItemTemplate>
         <asp:ImageButton runat="server" OnClick="btnVerAsistencia_Click" ID="btnVerAsistencia" Visible='<%#  (Eval("adj_asistencia").ToString() == "1")?true:false %>' ImageUrl="~/img/web/lookup.gif" ToolTip="Ver Asistencia" ValidationGroup='<%# Eval("cod_usuario") %>' />
         <asp:ImageButton runat="server" OnClick="btnVerSubirAsistencia_Click" ID="btnSubirAsistencia"   Visible =' <%# (Eval("aprobo") == System.DBNull.Value)?true:false %>'  ImageUrl="~/img/web/select.gif" ToolTip="Subir Asistencia" ValidationGroup='<%# Eval("cod_usuario") %>' />
         <asp:ImageButton runat="server" OnClick="btnVerEvaluacion_Click" ID="btnVerEvaluacion" Visible='<%#  (Eval("evaluacion").ToString() == "1")?true:false %>' ImageUrl="~/img/web/lookup.gif" ToolTip="Ver Evaluacion" ValidationGroup='<%# Eval("cod_usuario") %>' />
         <asp:ImageButton runat="server" OnClick="btnVerSubirEvaluacion_Click" ID="btnSubirEvaluacion" Visible =' <%# (Eval("aprobo") == System.DBNull.Value)?true:false %>' ImageUrl="~/img/web/select.gif" ToolTip="Subir Evaluacion" ValidationGroup='<%# Eval("cod_usuario") %>' />
         <asp:ImageButton runat="server" OnClick="btnVerCertificado_Click" ID="btnVerCertificado" Visible='<%#  (Eval("certificado").ToString() == "1")?true:false %>' ImageUrl="~/img/web/lookup.gif" ToolTip="Ver Certificado" ValidationGroup='<%# Eval("cod_usuario") %>' />
         <asp:ImageButton runat="server" OnClick="btnVerSubirCertificado_Click" ID="btnSubirCertificado" Visible =' <%# (Eval("aprobo") == System.DBNull.Value)?true:false %>' ImageUrl="~/img/web/select.gif" ToolTip="Subir Certificado" ValidationGroup='<%# Eval("cod_usuario") %>' />


         </ItemTemplate>
         </telerik:GridTemplateColumn>

         
         <telerik:GridTemplateColumn HeaderText="Evaluacion Final" >
         <ItemTemplate>

           <asp:RadioButton runat="server" ID="rdSi" Text="Aprobo" GroupName="a" Checked=' <%# (Eval("aprobo").ToString() == "1")?true:false %>'  Enabled =' <%# (Eval("aprobo") == System.DBNull.Value)?true:false %>'   />

           
            <asp:RadioButton runat="server" ID="rdNo" Text="No Aprobo" GroupName="a" Checked=' <%# (Eval("aprobo").ToString() == "1")?true:false %>' Enabled =' <%# (Eval("aprobo") == System.DBNull.Value)?true:false %>' />
            <asp:Button runat="server"  ValidationGroup='<%# Eval("cod_usuario") %>' ID="btnGuardarinformacion" OnClick="btnGuardar_Click" Text="Guardar" Visible =' <%# (Eval("aprobo") == System.DBNull.Value) %>' />
            <asp:Label runat="server" ID="lblError" Text="" ForeColor="red"></asp:Label>
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="select 
asistente_capacitacion.cod_capacitacion,usuario.cod_usuario,max(usuario.nombre) 'usuario',
max(cast(asistente_capacitacion.aprobo as int)) aprobo,
case when max(cast(adj_certificado as varbinary(10))) is not null then 1 else 0 end 'certificado',
case when max(cast(adj_asistencia as varbinary(10))) is not null then 1 else 0 end 'adj_asistencia',
case when max(cast(adj_evaluacion as varbinary(10))) is not null then 1 else 0 end 'evaluacion',
sum( cast(asistio as int)) 'asistencia',count(codasistentexsession) 'clases'
 from asistente_capacitacion 
join usuario on usuario.cod_usuario = asistente_capacitacion.cod_usuario
join asistentexsession on asistentexsession.cod_capacitacion = asistente_capacitacion.cod_capacitacion
and asistentexsession.cod_usuario = asistente_capacitacion.cod_usuario
where asistente_capacitacion.cod_capacitacion=@cod_capacitacion
group by asistente_capacitacion.cod_capacitacion,usuario.cod_usuario">
        <SelectParameters>
            <asp:ControlParameter ControlID="lblcodigoSesion" Name="cod_capacitacion" 
                PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>

    <br />
    <br />
    </div>


</asp:Content>




<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmInscritosClases.aspx.cs" Inherits="frm_capacitacion_frmInscritosClases" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<br /><asp:Label runat="server" ID="lblTexto"></asp:Label>
<div class="tab"> Listado de Inscritos a la clase&nbsp;<asp:Label runat="server" ID="lblcodigoSesion" Visible="false"></asp:Label>
    &nbsp;<asp:Button ID="btnVolver" runat="server" onclick="btnVolver_Click" 
        Text="Volver" />
    &nbsp;<asp:Button ID="btnReprogramar" runat="server" onclick="btnReprogramar_click" 
        Text="Reprogramar" />
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
        <telerik:GridBoundColumn DataField="nombre" 
            FilterControlAltText="Filter nombre column" HeaderText="nombre" 
            SortExpression="nombre" UniqueName="nombre">
        </telerik:GridBoundColumn>
        
        <telerik:GridTemplateColumn HeaderText="Asistio">
            <ItemTemplate>
            <asp:RadioButton runat="server" ID="rdSi" Text="Si" Checked='<%# (Eval("asistio") == System.DBNull.Value || (bool)Eval("asistio"))   %>' GroupName="x" 
            Enabled='<%# verBotonEjecutar( Eval("codasistentexsession")) %>'
            />
            <asp:RadioButton runat="server" ID="rdNo" Text="No" Checked='<%# !(Eval("asistio") == System.DBNull.Value || (bool)Eval("asistio"))   %>' GroupName="x" 
            Enabled='<%# verBotonEjecutar( Eval("codasistentexsession")) %>'
            />
            </itemTemplate>
            </telerik:GridTemplateColumn>
            <telerik:GridTemplateColumn HeaderText="Observaciones">
            <ItemTemplate>
            <asp:TextBox runat="server" ID="txtObservaciones" Width="400px" Text='<%# Eval("observaciones") %>' 
            ReadOnly='<%# !verBotonEjecutar( Eval("codasistentexsession")) %>'
            ></asp:TextBox>
            <asp:ImageButton runat="server" ID="btnGuardarObs" OnClick="btnGuadarInformacion" ValidationGroup='<%# Eval("codasistentexsession") %>'
            ImageUrl="~/img/web/ok.gif" Visible='<%# verBotonEjecutar( Eval("codasistentexsession")) %>' />

            <asp:ImageButton runat="server" ID="btnEliminar" OnClick="btnEliminar" ToolTip="Eliminar Informacion" OnClientClick="return confirm('esta seguro de elimnar la informacion asociada a este registro!');" ValidationGroup='<%# Eval("codasistentexsession") %>'
            ImageUrl="~/img/web/cancel.gif" Visible='<%# verBotonCancelar( Eval("codasistentexsession")) %>' />

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
usuario.nombre,case
when aceptada is null then 'Pendiente respuesta'
when aceptada =1 then 'Aceptada'
else 'No Aceptada' end 'estado',
asistio,observaciones,codasistentexsession

from asistentexsession
join usuario on usuario.cod_usuario = asistentexsession.cod_usuario
join session_capacitacion on session_capacitacion.cod_sesion_capacitacion = asistentexsession.cod_session
where cod_session =@cod_sesion
order by usuario.nombre">
        <SelectParameters>
            <asp:ControlParameter ControlID="lblcodigoSesion" Name="cod_sesion" 
                PropertyName="Text" />
        </SelectParameters>
    </asp:SqlDataSource>

    <br />
    <asp:CheckBox runat="server" ID="chkReprogramada" Checked="true" Text="Session Reprogramada" Enabled="false" />
    <br />
    <asp:TextBox runat="server" ID="txtRazonReprogra" ReadOnly="true" TextMode="MultiLine" Width="600px" Height="250px"></asp:TextBox>
    </div>


</asp:Content>


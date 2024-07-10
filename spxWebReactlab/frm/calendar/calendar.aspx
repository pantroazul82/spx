<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="calendar.aspx.cs" Inherits="frm_calendar_calendar" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
<script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../App_Themes/blue/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    
    <style type="text/css">
        .style1
        {
            width: 584px;
        }
        .style2
        {
            width: 319px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <table>
    <tr>
    <td class="style2">
    <b>Mis Actividades </b>  
    
    <asp:HyperLink ID="linkActividad" runat="server" 
        NavigateUrl="~/frm/calendar/frmNewTask.aspx">Crear una Actividad</asp:HyperLink>
    </td>
    <td class="style1">
    <asp:Label runat="server" ID="lblIngeniero" Text="Responsable" 
            style="font-weight: 700" ></asp:Label> &nbsp;<asp:DropDownList 
            runat="server" ID="cmbIngeniro" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="nombre" 
            DataValueField="cod_usuario" 
            onselectedindexchanged="cmbIngeniro_SelectedIndexChanged"></asp:DropDownList>
        <asp:Button ID="btnImprimirSemana" runat="server" 
            onclick="btnImprimirSemana_Click" Text="Imprimir Semana" />
        </td>
    </tr>
    <tr>
    <td colspan="2">
   
        <telerik:RadPanelBar ID="RadPanelBar1" Runat="server"  
            Skin="Office2010Blue" Width="907px" >
            <Items>
                <telerik:RadPanelItem runat="server" Text="Filtros Avanzados">
                <Items>
                <telerik:RadPanelItem>
                <ContentTemplate>
                <table >
                <tr valign="top">
                <td>
                
                </td>

                <td>
                
                </td>
                <td></td>

                </tr>
                <tr valign="top">
                <td>
                
        
                </td>
                <td>
                Cliente: <asp:TextBox runat="server" ID="txtCliente" Width="300px"></asp:TextBox>
                </td>
                 <td>
                 <asp:CheckBox runat="server" ID="chkBuscoAvanzado" Visible="false" />
                 <asp:Button runat="server" ID="btnBuscar" OnClick="btnfiltrosAvanzados_Click" Text="Aplicar Filtros Avanzados" />
                 </td>
                </tr>
                </table>
                </ContentTemplate>
                </telerik:RadPanelItem>
                </Items>


                </telerik:RadPanelItem>
            </Items>
        </telerik:RadPanelBar>
        </div>
    </td>
    </tr>
    <tr>

    <td colspan="2">
    <div style="z-index:1000">
        <telerik:RadScheduler ID="RadScheduler1" runat="server" 
        DataDescriptionField="asunto" DataEndField="Fin" DataKeyField="Codigo" 
        DataSourceID="odsCalendario" DataStartField="Inicio" DataSubjectField="Descripcion" 
        EnableDescriptionField="True" Height="" 
        onappointmentclick="RadScheduler1_AppointmentClick" 
        onappointmentcommand="RadScheduler1_AppointmentCommand" AllowDelete="False" 
            AllowInsert="False" BorderStyle="None" Culture="es-CO" 
            DataReminderField="Inicio" 
            onappointmentdatabound="RadScheduler1_AppointmentDataBound" 
            Skin="Office2010Blue" 
            onappointmentspopulating="RadScheduler1_AppointmentsPopulating" 
            FirstDayOfWeek="Monday" SelectedView="WeekView" LastDayOfWeek="Sunday" 
            DayStartTime="07:00:00" WorkDayEndTime="18:00:00" WorkDayStartTime="07:00:00">
            <WeekView DayStartTime="07:00:00" EnableExactTimeRendering="True" 
                WorkDayEndTime="18:00:00" WorkDayStartTime="07:00:00" />
            <DayView DayStartTime="07:00:00" WorkDayEndTime="18:00:00" 
                WorkDayStartTime="07:00:00" />
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
    </telerik:RadScheduler>
    </div>
    </td>
    </tr>
    </table>

&nbsp;<asp:ObjectDataSource ID="odsCalendario" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="SPControladoraDatos.dsSpxTableAdapters.calendarioTableAdapter">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbIngeniro" Name="usuario" 
                PropertyName="SelectedValue" Type="Int32" />
            <asp:Parameter Name="RangoInicial" Type="DateTime" />
            <asp:Parameter Name="RangoFinal" Type="DateTime" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        SelectCommand="SELECT [nombre], [login], [cod_usuario] FROM [usuario] ORDER BY [nombre]">
    </asp:SqlDataSource>
</asp:Content>


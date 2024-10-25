﻿<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmCalendarComparativo.aspx.cs" Inherits="Web2020.frm.calendar.frmCalendarComparativo" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <script src="../../js/jquery.js" type="text/javascript"></script>
    <script src="../../js/jquery-ui-1.8rc3.custom.min.js" type="text/javascript"></script>
    <link href="../../css/jquery-ui-1.8rc3.custom.css" rel="stylesheet" type="text/css" />
    
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
        <b>Comparativo de Actividades </b>
    </td>
    <td class="style1">
        &nbsp;</td>
    </tr>
    <tr>
    <td colspan="2">
   
        </div>
    </td>
    </tr>
    <tr>
    <td>
    <asp:Label runat="server" ID="lblIngeniero" Text="Responsable" 
            style="font-weight: 700" ></asp:Label> <asp:DropDownList 
            runat="server" ID="cmbIngeniro" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="nombre" 
            DataValueField="cod_usuario" 
            onselectedindexchanged="cmbIngeniro_SelectedIndexChanged"></asp:DropDownList>
        </td>
    <td>
    <asp:Label runat="server" ID="lblIngeniero0" Text="Responsable" 
            style="font-weight: 700" ></asp:Label> 
        <asp:DropDownList 
            runat="server" ID="cmbIngeniro2" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="nombre" 
            DataValueField="cod_usuario" 
            onselectedindexchanged="cmbIngeniro_SelectedIndexChanged"></asp:DropDownList>
        </td>
    </tr>
    <tr>

    <td >
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
            Width="451px">
    </telerik:RadScheduler>
    </td>

    <td >
        <telerik:RadScheduler ID="RadScheduler2" runat="server" 
        DataDescriptionField="asunto" DataEndField="Fin" DataKeyField="Codigo" 
        DataSourceID="odsCalendario2" DataStartField="Inicio" DataSubjectField="Descripcion" 
        EnableDescriptionField="True" Height="" 
        onappointmentclick="RadScheduler1_AppointmentClick" 
        onappointmentcommand="RadScheduler1_AppointmentCommand" AllowDelete="False" 
            AllowInsert="False" BorderStyle="None" Culture="es-CO" 
            DataReminderField="Inicio" 
            onappointmentdatabound="RadScheduler1_AppointmentDataBound" 
            Skin="Office2010Blue" 
            onappointmentspopulating="RadScheduler1_AppointmentsPopulating" 
            Width="451px">
            <Reminders Enabled="True" />
<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
    </telerik:RadScheduler>
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
<asp:ObjectDataSource ID="odsCalendario2" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        
    TypeName="SPControladoraDatos.dsSpxTableAdapters.calendarioTableAdapter">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbIngeniro2" Name="usuario" 
                PropertyName="SelectedValue" Type="Int32" />
            <asp:Parameter Name="RangoInicial" Type="DateTime" />
            <asp:Parameter Name="RangoFinal" Type="DateTime" />
        </SelectParameters>
    </asp:ObjectDataSource>
    </asp:Content>




﻿<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmMisTareas.aspx.cs" Inherits="frm_calendar_frmMisTareas" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
<div class="tab">Mis Tareas</div>
 
    Desde
    <telerik:RadDatePicker ID="calInicio" Runat="server">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
&nbsp;hasta
    <telerik:RadDatePicker ID="calFin" Runat="server">
    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDatePicker>
    <asp:Button ID="btnBuscar" runat="server" Text="Actualizar" 
        onclick="btnBuscar_Click" />
    <telerik:RadGrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" 
        AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
        CellSpacing="0" DataSourceID="odsTareas" GridLines="None">
        <GroupingSettings CaseSensitive="false"  />

        <MasterTableView datasourceid="odsTareas">
            <CommandItemSettings ExportToPdfText="Export to PDF">
            </CommandItemSettings>
            <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
                <HeaderStyle Width="20px"></HeaderStyle>
            </RowIndicatorColumn>
            <ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
                <HeaderStyle Width="20px"></HeaderStyle>
            </ExpandCollapseColumn>
            <Columns>
                 <telerik:GridBoundColumn DataField="cod_tarea_calendario" 
                    FilterControlAltText="Filter column column" HeaderText="Consecutivo" 
                    UniqueName="column12">
                </telerik:GridBoundColumn>

            <telerik:GridTemplateColumn HeaderText="Tarea" SortExpression="descripcion" DataField="descripcion">
            <ItemTemplate>
            <asp:HyperLink runat="server" ID="lnk" 
            NavigateUrl='<%# "~/frm/calendar/frmNewTask.aspx?cod=tarea|"+Eval("cod_tarea_calendario") %>' Text='<%# Eval("descripcion") %>' 
            ></asp:HyperLink>
            </ItemTemplate>
            </telerik:GridTemplateColumn>
                <telerik:GridBoundColumn DataField="nombre_estado_tarea" 
                    FilterControlAltText="Filter column column" HeaderText="Estado" 
                    UniqueName="column">
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="inicio" DataType="System.DateTime" 
                    FilterControlAltText="Filter inicio column" HeaderText="inicio" 
                    SortExpression="inicio" UniqueName="inicio">
                </telerik:GridBoundColumn>
              
                <telerik:GridBoundColumn DataField="tipo_tarea" 
                    FilterControlAltText="Filter tipo_tarea column" HeaderText="tipo tarea" 
                    SortExpression="tipo tarea" UniqueName="tipo_tarea">
                </telerik:GridBoundColumn>
                
            
                <telerik:GridBoundColumn DataField="nombreCliente" 
                    FilterControlAltText="Filter nombreCliente column" HeaderText="Cliente" 
                    SortExpression="Cliente" UniqueName="nombreCliente">
                </telerik:GridBoundColumn>
                   <telerik:GridTemplateColumn HeaderText="Socio de Negocio" DataField="nit_cliente">
                <ItemTemplate>
                <asp:label ID="Label1" runat="server" Text='<%#  versocioNegocio( Eval("nit_cliente")) %>'></asp:label>
                </ItemTemplate>
                </telerik:GridTemplateColumn>

                <telerik:GridBoundColumn DataField="responsable" 
                    FilterControlAltText="Filter column column" HeaderText="Asignado A" 
                    UniqueName="column11">
                </telerik:GridBoundColumn>
               
            </Columns>
            <EditFormSettings>
                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                </EditColumn>
            </EditFormSettings>
        </MasterTableView>
        <FilterMenu EnableImageSprites="False">
            <WebServiceSettings>
                <ODataSettings InitialContainerName="">
                </ODataSettings>
            </WebServiceSettings>
        </FilterMenu>
        <HeaderContextMenu CssClass="GridContextMenu GridContextMenu_Default">
            <WebServiceSettings>
                <ODataSettings InitialContainerName="">
                </ODataSettings>
            </WebServiceSettings>
        </HeaderContextMenu>
    </telerik:RadGrid>
    <asp:ObjectDataSource ID="odsTareas" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByActivasUsuario" 
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.pltCalendarioTableAdapter">
        <SelectParameters>
        <asp:ControlParameter ControlID="calInicio" Name="fechaIni" 
                PropertyName="SelectedDate" Type="DateTime" />
            <asp:ControlParameter ControlID="calFin" Name="fechaFin" PropertyName="SelectedDate" 
                Type="DateTime" />

            <asp:SessionParameter Name="cod_usuario" SessionField="ss_cod_usuario" 
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
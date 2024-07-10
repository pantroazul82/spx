<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoRevision.aspx.cs" Inherits="frm_revision_frmListadoRevision" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v13.2, Version=13.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div class="tab">Listado Revision de Equipos&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <br />
    Desde
    <telerik:raddatepicker ID="calInicio" Runat="server">
    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:raddatepicker>
&nbsp;hasta
    <telerik:raddatepicker ID="calFin" Runat="server">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:raddatepicker>
    <asp:DropDownList ID="cmbEstados" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource1" DataTextField="nombre_estado_revision_equipos" 
        DataValueField="cod_manual" AppendDataBoundItems="True">
        <asp:ListItem Text="Seleccione" Value=""></asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="SELECT [nombre_estado_revision_equipos], [cod_manual] FROM [estado_revision_equipos] ORDER BY [nombre_estado_revision_equipos]"></asp:SqlDataSource>
&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Actualizar" OnClick="btnBuscar_Click1" />
&nbsp;<asp:Button ID="btnNuevo" runat="server" Text="Nuevo" 
        onclick="btnBuscar_Click" />
        <asp:Button ID="btnExportarExcel" runat="server"  Text="Exportar Excel" OnClick="btnExportar_Click" />
</div>

    <asp:ObjectDataSource ID="odsTareas" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetDataByEstadoFechas"
        
        
        TypeName="SPControladoraDatos.dsCientificaTableAdapters.pltRevisionEquiposTableAdapter">
        <SelectParameters>
            <asp:ControlParameter ControlID="calInicio" Name="fechaIni" 
                PropertyName="SelectedDate" Type="DateTime" />
            <asp:ControlParameter ControlID="calFin" Name="fechaFin" PropertyName="SelectedDate" 
                Type="DateTime" />
            <asp:ControlParameter ControlID="cmbEstados" Name="codManual" 
                PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsTareas" KeyFieldName="cod_revision_equipos">
        <Columns>
            <dx:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0">
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="cod_revision_equipos" Caption="Cod" ReadOnly="True" VisibleIndex="1">
                <EditFormSettings Visible="False" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn FieldName="nombre_estado_revision_equipos" VisibleIndex="2">
                <DataItemTemplate>
                    <asp:HyperLink runat="server" ID="lnkOrdn"
                        Text='<%# Eval("nombre_estado_revision_equipos") %>'
                         NavigateUrl='<%# "frmResumenDetalladoRevision.aspx?cod="+Eval("cod_revision_equipos") %>' ></asp:HyperLink>
                </DataItemTemplate>
            </dx:GridViewDataColumn>


            <dx:GridViewDataDateColumn FieldName="fecha_creacion" VisibleIndex="3" Caption="Fecha Creación">
            </dx:GridViewDataDateColumn>
            
            <dx:GridViewDataTextColumn FieldName="creado_por" VisibleIndex="4" Caption="Creado Por">
            </dx:GridViewDataTextColumn>

            <dx:GridViewDataTextColumn FieldName="nombreCliente" VisibleIndex="5" Caption="Cliente">
            </dx:GridViewDataTextColumn>

            <dx:GridViewDataTextColumn FieldName="nit_cliente" VisibleIndex="5">
            </dx:GridViewDataTextColumn>

            <dx:GridViewDataTextColumn FieldName="nombrefabricante" VisibleIndex="6" Caption="Fabricante">
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn FieldName="nombremodelo" ReadOnly="True" VisibleIndex="7" Caption="Modelo">
            </dx:GridViewDataTextColumn>

            <dx:GridViewDataTextColumn FieldName="serial" VisibleIndex="8" Caption="Serial">
            </dx:GridViewDataTextColumn>
            
            <dx:GridViewDataTextColumn FieldName="asignadoa" VisibleIndex="9" Caption="Asignado A">
            </dx:GridViewDataTextColumn>

            <dx:GridViewDataDateColumn FieldName="fecha_inicio_ejecucion" VisibleIndex="11" Caption="Fecha ejecucion">
            </dx:GridViewDataDateColumn>

            
            <dx:GridViewDataTextColumn FieldName="txtadecuado" ReadOnly="True" VisibleIndex="16" Caption="Adecuado">
            </dx:GridViewDataTextColumn>
        </Columns>
        <Settings ShowFilterRow="True" />
        <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
    </dx:ASPxGridView>
    <br />
    <br />
</asp:Content>


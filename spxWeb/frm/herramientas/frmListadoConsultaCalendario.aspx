<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmListadoConsultaCalendario.aspx.cs" Inherits="frm_herramientas_frmListadoConsultaCalendario" %>

<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <style type="text/css">
        .auto-style1
        {
            width: 205px;
        }
        .auto-style2
        {
            width: 191px;
        }
        .auto-style3
        {
            width: 68px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Listado General de actividades de calendario</p>
    <p>
&nbsp;<table class="dxflInternalEditorTable">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Desde</td>
                <td class="auto-style1">
                    <dx:ASPxDateEdit ID="calInicio" runat="server">
                    </dx:ASPxDateEdit>
                </td>
                <td>Hasta</td>
                <td class="auto-style2">
                    <dx:ASPxDateEdit ID="calfin" runat="server">
                    </dx:ASPxDateEdit>
                </td>
                <td>
                    <asp:Button ID="btnGenerar" runat="server" OnClick="btnGenerar_Click" Text="Generar" />
                </td>
                <td>
                    <asp:Button ID="btnExportarXls" runat="server" OnClick="btnExportarXls_Click" Text="Exportar Excel" />
                </td>
            </tr>
        </table>
    </p>
    <p>
        <dx:ASPxGridView ID="grdDatos" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" KeyFieldName="cod_usuario" ViewStateMode="Disabled">
            <Columns>  
                 <dx:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0">
                 </dx:GridViewCommandColumn>
                 <dx:GridViewDataTextColumn FieldName="login" VisibleIndex="1">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="nombre" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="tipo" VisibleIndex="3">
                </dx:GridViewDataTextColumn>
                 <dx:GridViewDataTextColumn FieldName="subtipo" VisibleIndex="4">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="codigo" VisibleIndex="5" Visible="false">
                </dx:GridViewDataTextColumn>
           
                <dx:GridViewDataTextColumn Caption="Cod" FieldName="codordenservicio" VisibleIndex="6">
                </dx:GridViewDataTextColumn>

                <dx:GridViewDataColumn Caption="Fecha Programacion" FieldName="fechaprogramacion" VisibleIndex="7">
                    <DataItemTemplate>
                        <asp:Label runat="server" ID="lblFini" Text='<%# Eval("fechaprogramacion") %>'></asp:Label>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>

                
                <dx:GridViewDataColumn Caption="Fecha fin Programacion" FieldName="fechafinprogramacion" VisibleIndex="8">
                    <DataItemTemplate>
                        <asp:Label runat="server" ID="lblFini" Text='<%# Eval("fechafinprogramacion") %>'></asp:Label>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>

                <dx:GridViewDataColumn FieldName="horas" Caption="Horas" VisibleIndex="9">
                    <DataItemTemplate>
                        <asp:Label runat="server" ID="lblFini11" Text='<%# Eval("horas")  %>'></asp:Label>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>

                <dx:GridViewDataTextColumn FieldName="serial" VisibleIndex="10">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="observaciones" VisibleIndex="11">
                </dx:GridViewDataTextColumn>
     
                <dx:GridViewDataCheckColumn FieldName="requiere_aprobacion" VisibleIndex="12">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataCheckColumn FieldName="activa" VisibleIndex="13">
                </dx:GridViewDataCheckColumn>
                <dx:GridViewDataCheckColumn FieldName="aprobada" VisibleIndex="14">
                </dx:GridViewDataCheckColumn>
     
             
            
            </Columns>
            <SettingsPager PageSize="50">
            </SettingsPager>
            <Settings ShowFilterRow="True" />
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        </dx:ASPxGridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" SelectCommand="listadoActividadesCientifica" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="calInicio" Name="fini" PropertyName="Value" />
                <asp:ControlParameter ControlID="calfin" Name="ffin" PropertyName="Value" />
            </SelectParameters>
        </asp:SqlDataSource>
        <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="grdDatos">
        </dx:ASPxGridViewExporter>
    </p>
</asp:Content>


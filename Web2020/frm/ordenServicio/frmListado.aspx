<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmListado.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmListado" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <link href="../../assets/css/listadoOrdenSeguimiento.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="screen-1">
        <div class="container">
            <div class="col">
                <h2 class="titulo">Listado de Ordenes de Servicio</h2>

            </div>
          
                <div> 
                    <div> &nbsp;</div>
                </div>
             
                      <div class="row">
                <div>
                    <asp:Label runat="server" ID="SearchLabel1">
                Filtros
                    </asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-3 filterSelector">
                    <asp:DropDownList runat="server" ID="cmbFiltros" CssClass="custom-select">
                        <asp:ListItem Text="Seleccione" Value="-1"> </asp:ListItem>
                        <asp:ListItem Text="Cod Orden Servicio" Value="5"> </asp:ListItem>
                        <asp:ListItem Text="Serial" Value="1"> </asp:ListItem>
                        <asp:ListItem Text="Nit Cliente" Value="2"> </asp:ListItem>
                        <asp:ListItem Text="Modelo" Value="3"> </asp:ListItem>
                        <asp:ListItem Text="Fabricante" Value="4"> </asp:ListItem>
                        <asp:ListItem Text="Asignado A" Value="6"> </asp:ListItem>

                    </asp:DropDownList>
                     </div>
                 <div class="col-sm-2 filterContainer">
                    <asp:TextBox CssClass="" runat="server" ID="txtFiltro">
                    </asp:TextBox>
                       </div>

                <div class ="buttonsContainer">
                      <div class="col-sm-3 submitBtnContainer">
                     <asp:Button runat="server" Text="Buscar" CausesValidation="False" class="btn btn-primary" ID="btnBuscar"></asp:Button>

                     </div>
                        <div class="col-sm-3"style="width:0;">
                            <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="ASPxGridView1">
                            </dx:ASPxGridViewExporter>
                        </div>
                    <div class="col-sm-1 exportExcelBtnContainer">
                        <asp:Button ID="Button1" runat="server" Text="Exportar Excel" CssClass="btn btn-success" OnClick="imgExcel_Click" ></asp:Button>
                    </div>
                </div>

                  <div class="row historicoContainer" style="display:flex;">
                <div class="col">
                    <asp:CheckBox ID="chkHistorico" runat="server" Text="" />
                    </div>
                    <div class="col-sm-2">
                    <asp:Label Text="Ver Historico" runat="server" />
                </div>
                   </div>
                </div>
            <br />
           <%--    <div class="row">
                <div class="col-sm-3"style="width:20%;">
                    <dx:ASPxGridViewExporter ID="ASPxGridViewExporter1" runat="server" GridViewID="ASPxGridView1">
                    </dx:ASPxGridViewExporter>
                      </div>
                  <div class="col-sm-1">
                    <asp:Button ID="imgExcel" runat="server" Text="Exportar Excel" CssClass="btn btn-success" OnClick="imgExcel_Click" ></asp:Button>
                </div>
                     </div>--%>
       
            <div>
                <div>
                    &nbsp;
                </div>
            </div>
        <div class="row tableContainer" >
            <div class="col-sm-8">
        <dx:ASPxGridView ID="ASPxGridView1" runat="server"
            AutoGenerateColumns="False" ViewStateMode="Disabled" Width="500px">

            <Columns>
                             <dx:GridViewDataColumn Width="40px" VisibleIndex="1">
                    <DataItemTemplate>
                        <asp:ImageButton ID="btnImprimir" runat="server" ImageUrl="~/img/web/print.png" OnClick="verOrdenServicio" ToolTip="Imprimir" ValidationGroup='<%# Eval("codordenservicio") %>' Width="30" />
                        <asp:ImageButton ID="btnEjecutarOrden" runat="server" ImageUrl="~/img/web/update.gif" OnClick="ejecutarOrdenServicio" ToolTip="Ejecutar Orden de Servicio" ValidationGroup='<%# Eval("CodOrdenServicio") %>'
                            Visible='<%# validarVisibilidadEjecutar( Eval("Codestadoordenservicio") ) %>'
                            Width="30" />
                    </DataItemTemplate>
                </dx:GridViewDataColumn>
                <dx:GridViewCommandColumn ShowClearFilterButton="True" VisibleIndex="0">
                </dx:GridViewCommandColumn>
                <dx:GridViewDataTextColumn FieldName="codordenservicio" VisibleIndex="2" Caption="Cod Orden" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataDateColumn Caption="Fecha Tentativa" FieldName="fechaprogramacion" VisibleIndex="3" Width="40px">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataTextColumn FieldName="asignadoa" VisibleIndex="4" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Serial" FieldName="serial" VisibleIndex="5" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Estado" FieldName="nombreestado" VisibleIndex="6" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Servicio" FieldName="nombretiposervicio" VisibleIndex="7" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Modelo" FieldName="nombremodelo" VisibleIndex="8" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="nitcliente" VisibleIndex="9" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Cliente" FieldName="nombrecliente" VisibleIndex="10" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Sucursal" FieldName="nombresucursal" VisibleIndex="11" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn Caption="Modalidad" FieldName="nombremodalidadequipo" VisibleIndex="12" Width="40px">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="codestadoordenservicio" Visible="False" VisibleIndex="13" Width="40px">
                </dx:GridViewDataTextColumn>
   
            </Columns>


            <SettingsPager PageSize="20">
            </SettingsPager>
            <Settings ShowFilterRow="True" ShowFooter="True" />
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
        </dx:ASPxGridView>

        </div>
        </div>
  
  





</asp:Content>

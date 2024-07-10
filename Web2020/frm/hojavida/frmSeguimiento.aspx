<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmSeguimiento.aspx.cs" Inherits="Web2020.frm.hojavida.frmSeguimiento" %>
<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>



<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <link href="../../assets/css/listado.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="screen-1">
        <div class="container">
            <div class="col">
                <h2 class="titulo">Listado de Equipos</h2>

            </div>
            <div class="row filterFields">
                <div class="col-sm-2">
                    <asp:Label runat="server" ID="SearchLabel1">
                Filtros
                    </asp:Label>
                </div>
                <div class="col-sm-2" style="display: flex; height: 37px;">
                    <asp:DropDownList runat="server" ID="cmbFiltros">
                        <asp:ListItem Text="Seleccione" Value="-1"> </asp:ListItem>
                        <asp:ListItem Text="Serial" Value="1"> </asp:ListItem>
                        <asp:ListItem Text="Nit Cliente" Value="2"> </asp:ListItem>
                        <asp:ListItem Text="Nombre Cliente" Value="3"> </asp:ListItem>
                        <asp:ListItem Text="Modelo" Value="4"> </asp:ListItem>

                    </asp:DropDownList>
                </div>
               
                
                <div class="col-lg-2 d-flex filterContainer">
                    <asp:TextBox runat="server" ID="SearchText1">

                    </asp:TextBox>
                </div>
                <div class="col-sm-2 d-flex buttonContainer">

                    <asp:Button runat="server" Text="Buscar" class="btn btn-primary" CausesValidation="False" ID="SearchBtn1" OnClick="SearchBtn1_Click"></asp:Button>
                </div>
            </div>
            <div>
                <div>&nbsp;</div>
            </div>
            <div class="row" style="display: table-cell;" >
                <div class="Formulario">
                    
                    <dx:ASPxGridView runat="server" 
                        AutoGenerateColumns="False"
                     ID="Browse1"
                         ViewStateMode="Disabled" 
                        Width="500px"

                        Style="width: 320px; max-width: 100%"
                        DataSourceID="SqlDataSource1"
                        DataKeyNames="Serial"
                        >



                        <Columns>
                            <dx:GridViewDataColumn>


                                <DataItemTemplate>
                                    <asp:ImageButton style=" column-gap: 40px;"  runat="server" Height="26px" ImageUrl="~/img/frm/logos.png" AlternateText="Hoja de vida"
                                                     ToolTip="Hoja de vida" OnClick="oprimirBoton"
                                                     ID="ntmHojaVida" ValidationGroup='<%# Eval("Serial") %>'></asp:ImageButton>
                                </DataItemTemplate>


                            </dx:GridViewDataColumn>

                            <dx:GridViewDataColumn Caption="Serial"  VisibleIndex="2"  FieldName="Serial">


                                <DataItemTemplate>
                                    <asp:Label  runat="server" Text='<%# Eval("serial") %>' ID="SerialLabel1">
                                    </asp:Label>
                                </DataItemTemplate>


                            </dx:GridViewDataColumn>
                            <dx:GridViewDataColumn Caption="Fabricante"  VisibleIndex="3" FieldName="Fabricante.NombreFabricante">
                                <DataItemTemplate>
                                    <asp:Label  runat="server" Text='<%# Eval("nombrefabricante") %>' ID="lblNombreFabricante">
                                    </asp:Label>
                                </DataItemTemplate>


                            </dx:GridViewDataColumn>
                            <dx:GridViewDataColumn Caption="Modelo" VisibleIndex="4" FieldName="Modelo.NombreModelo">
                                <DataItemTemplate>
                                    <asp:Label  runat="server" Text='<%# Eval("nombremodelo") %>' ID="ModeloNombreModeloLabel1">
                                    </asp:Label>
                                </DataItemTemplate>

                          

                            </dx:GridViewDataColumn>




                            <dx:GridViewDataColumn Caption="Nit Cliente" VisibleIndex="5" FieldName="NitClienteUbica">


                                <DataItemTemplate>
                                    <asp:Label  runat="server" Text='<%# Eval("nitCliente") %>' ID="lblNitCliente">
                                    </asp:Label>
                                </DataItemTemplate>


                            </dx:GridViewDataColumn>
                            <dx:GridViewDataColumn Caption="Cliente" VisibleIndex="6" FieldName="Cliente.NombreCliente">


                                <DataItemTemplate>
                                    <asp:Label  runat="server" Text='<%# Eval("nombreCliente") %>' ID="lblNombreCLiente">
                                    </asp:Label>
                                </DataItemTemplate>


                            </dx:GridViewDataColumn>
                            <dx:GridViewDataColumn Caption="Modalidad" VisibleIndex="7" FieldName="ModalidadEquipo.NombreModalidadEquipo">


                                <DataItemTemplate>
                                    <asp:Label   runat="server" Text='<%# Eval("nombremodalidadequipo") %>' ID="lblModalidad">
                                    </asp:Label>
                                </DataItemTemplate>


                            </dx:GridViewDataColumn>




                            <dx:GridViewDataColumn Caption="Sucursal" VisibleIndex="8" FieldName="SucursalCliente.NombreSucursal">


                                <DataItemTemplate>
                                    <asp:Label   runat="server" Text='<%# Eval("nombreSucursal") %>' ID="lblSucursal">
                                    </asp:Label>
                                </DataItemTemplate>


                            </dx:GridViewDataColumn>

                            <dx:GridViewDataColumn Caption="Ciudad" VisibleIndex="9" FieldName="Ciudade.NombreCiudad">


                                <DataItemTemplate>
                                    <asp:Label   runat="server" Text='<%# Eval("nombreCiudad") %>' ID="lblNombreCiudad">
                                    </asp:Label>
                                </DataItemTemplate>


                            </dx:GridViewDataColumn>


                    



                        </Columns>

                         <SettingsPager PageSize="20">
            </SettingsPager>
            <Settings ShowFilterRow="True" ShowFooter="True" />
            <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                   

                    </dx:ASPxGridView>
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:spx2020ConnectionString %>" SelectCommand="select 
                [serial],
                [nombrefabricante], [nombremodelo], 
                [nombretipoequipo], [nombresubtipo], 
                [nombremodalidadequipo], [nombreestadolocal], 
                [nitCliente], [nombreCliente], 
                [nombreSucursal], [nombreCiudad]



                from vistaEquipo"></asp:SqlDataSource>


                </div>
            </div>
        </div>
    </div>





</asp:Content>

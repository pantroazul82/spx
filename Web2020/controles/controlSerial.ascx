<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="controlSerial.ascx.cs" Inherits="Web2020.controles.controlSerial" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cca" %>
<%@ Register Src="controlTxtItem.ascx" TagName="controlTxtItem" TagPrefix="uc1" %>
<%@ Register Src="textItem.ascx" TagName="textItem" TagPrefix="uc2" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="~/controles/textItem.ascx" TagPrefix="uc1" TagName="textItem" %>


<link href="../../css/default.css" rel="stylesheet" type="text/css" />
<style>
    #titulo2{
        width:auto;
    }

    #ContentPlaceHolder1_controlSerial1_Panel1_ModalPopupExtender_foregroundElement {
        position: fixed !important;
        left: auto% !important;
        right: auto% !important;
        
    }

    #ContentPlaceHolder1_controlSerial1_pnlEmergente_DropShadow{
        visibility: hidden !important;
    }


    #ContentPlaceHolder1_controlSerial2_pnlControlContenedor{
        width: 100%!important;
    }
    
    #ContentPlaceHolder1_controlSerial2_pnlEmergente_DropShadow{
        visibility: hidden !important;
    }

    #ContentPlaceHolder1_controlSerial2_pnlResultados div:nth-child(1){
        margin-bottom:10px;
    }

      #ContentPlaceHolder1_controlSerial2_pnlResultados div:nth-child(2){
        margin-bottom:10px;
    }


     #ContentPlaceHolder1_controlSerial2_SearchText1{
         display:none;
     }

     #titulo2{
         display:none;
     }

     #ContentPlaceHolder1_controlSerial2_btnBuscar{
        width: 35px !important;
        height: 37px;
        border-left-width: 0px;
     }

    .modalBackground{
        padding-top: 5%;
    }

 
 
</style>


<div style="width: 30px; padding-left: 2px; padding-right: auto; display: inline; margin-right: 3px;" runat="server" id="pnlControlContenedor">
    <asp:Label ID="lblEventosEnncedidos" Text="" runat="server" Visible="false"></asp:Label>
    <asp:CheckBox runat="server" ID="chkMedicion" Visible="false" Checked="false" />
    <asp:CheckBox runat="server" ID="chkListaVisible" Visible="false" Checked="true" />
    <asp:UpdatePanel ID="updatePanelTexto" runat="server" UpdateMode="Conditional" RenderMode="Inline">
        <ContentTemplate>
            <asp:ImageButton Width="26px" style="margin-left: 5px;" CausesValidation="false" ImageUrl="~/img/Crystal_Clear_action_edit_add.png"
                ToolTip="Agregar Serial" ID="btnAgregarRepuesto" runat="server" AlternateText="Agregar Serial"
                OnClick="btnAgregarRepuesto_Click" />
            <div class="serialField"> 
                <uc2:textItem ID="textItemPagina" runat="server" />
            </div>
            
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Label Style="display: none" ID="lblInvicible" runat="server" />
</div>

<asp:Panel Style="display: none; margin-top: -250px;" ID="pnlEmergente" Enabled="true" runat="server"
    Height="350px" Width="350px" BackColor="LightGray">

    <div id="baraSuperior" style="cursor: move; background-image: url('../img/web/fondoBarra.png') !important; background-repeat: repeat; background-position: left top; width: 350px; margin-top: 0px;">
        <asp:ImageButton ImageUrl="../img/web/Cerrar.png" ID="btnCancelarPopUp" runat="server"
            Style="cursor: pointer; position: static; margin-left: 318px;" Width="16px" />
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline" UpdateMode="Always">
        <ContentTemplate>

            <asp:Panel ID="pnlContenido" runat="server" BackColor="white" Style="padding-left: 20px; padding-top: 5px;">


           
                <asp:Panel ID="pnlResultados" runat="server">
                         <div class="row">
                   
                    <div class="col-sm-3" id="titulo2">
                        Serial. 
                            </div>
                         <div class="col-sm-1">
    <asp:TextBox runat="server" ID="SearchText1"></asp:TextBox>
                        </div>
                        </div>
                             <div class="row" Style="display:flex; flex-wrap:wrap">
                    <div class="col-sm-3" Style="width:100%;">
                        <asp:Label runat="server" Text=" Serial / Nit / Nombre del cliente" ID="lblNitcliente"></asp:Label>
                        </div>
                                     <div class="col-sm-1"  Style="width:auto; padding-right:unset;">
                        <asp:TextBox runat="server" ID="txtNitcliente"></asp:TextBox>
                                         </div>
                                     <div class="col btnBuscar" style="left: 170px; width:auto;">
                        <asp:ImageButton ID="btnBuscar" runat="server" AlternateText="Buscar"
                            ImageUrl="~/img/web/Ico_BuscarDir.png" OnClick="btnBuscar_Click" CausesValidation="false"
                            ToolTip="Buscar" Width="26px" />
                                         </div>
                        </div>
                      <div class="row">
                          <div class="col-sm-3">
                          <asp:Label runat="server" Text="Fabricante" ID="Label1"></asp:Label>
                            </div>
                          <div class="col-sm-2">
                        <asp:DropDownList ID="cmbFabricante" runat="server" AutoPostBack="True"
                            DataSourceID="SqlDataSource1" DataTextField="nombre_fabricante"
                            DataValueField="codFabricante" OnDataBound="cmbFabricante_DataBound"
                            OnSelectedIndexChanged="cmbFabricante_SelectedIndexChanged">
                        </asp:DropDownList>
                              </div>
                              </div>
                         <div class="row">
                          <div class="col-sm-3">
                          <asp:Label runat="server" Text="Modelo" ID="Label2"></asp:Label>
                              </div>
                          <div class="col-sm-2">
                        <asp:DropDownList ID="cmbModelo" runat="server" AutoPostBack="True"
                            DataSourceID="SqlDataSource2" DataTextField="NombreModelo"
                            DataValueField="codModelo" OnDataBound="cmbModelo_DataBound"
                            OnSelectedIndexChanged="cmbModelo_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    </div>
                    <div class="row" style="width: min-content; margin-left: -19px;">
                    <div class="Formulario_tabla">
                        <telerik:RadGrid ID="RadGrid1" runat="server" AutoGenerateColumns="False"
                            CellSpacing="0" GridLines="None" AllowPaging="True" PageSize="4" Visible="true"
                            DataSourceID="SqlDataSource3">
                            <MasterTableView DataSourceID="SqlDataSource3">
                                <CommandItemSettings ExportToPdfText="Export to PDF" />
                                <RowIndicatorColumn FilterControlAltText="Filter RowIndicator column"
                                    Visible="True">
                                    <HeaderStyle Width="20px" />
                                </RowIndicatorColumn>
                                <ExpandCollapseColumn FilterControlAltText="Filter ExpandColumn column"
                                    Visible="True">
                                    <HeaderStyle Width="20px" />
                                </ExpandCollapseColumn>
                                <Columns>
                                    <telerik:GridTemplateColumn FilterControlAltText="Filter TemplateColumn column"
                                        UniqueName="TemplateColumn">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="btnOk" Width="26px" runat="server" AlternateText="Ok"
                                                ImageUrl="~/img/web/ok.gif"
                                                ValidationGroup='<%# Eval("serial") %>'
                                                OnClick="btnOk_Click" ToolTip="Agregar" />
                                        </ItemTemplate>
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridBoundColumn DataField="serial"
                                        FilterControlAltText="Filter column2 column" HeaderText="serial"
                                        UniqueName="column2">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="nombreFabricante"
                                        FilterControlAltText="Filter column column" HeaderText="Fabricante"
                                        UniqueName="column">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="nombreModelo"
                                        FilterControlAltText="Filter column1 column" HeaderText="Modelo"
                                        UniqueName="column1">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="nitcliente"
                                        FilterControlAltText="Filter column3 column" HeaderText="Nit cliente"
                                        UniqueName="column3">
                                    </telerik:GridBoundColumn>

                                    <telerik:GridBoundColumn DataField="nombreCliente"
                                        FilterControlAltText="Filter column5 column" HeaderText="Nombre Cliente"
                                        UniqueName="column5">
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="nombreCiudad"
                                        FilterControlAltText="Filter column6 column" HeaderText="Ciudad"
                                        UniqueName="column6">
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
                    </div>
                        <div>
                            <div>&nbsp</div>
                        </div>
                        </div>
                    <uc2:textItem ID="textItemPopPup" runat="server" />
                   
                    <asp:Button CssClass="btn btn-danger" CausesValidation="false" ID="btnCancelar" runat="server" Text="Cancelar"
                       
                        ToolTip="Cancelar" OnClick="btnCancelar_Click" ></asp:Button>


                    <asp:Label ID="lblModelo" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="lblFabricante" runat="server" Visible="False"></asp:Label>
                          <div>
                            <div>&nbsp</div>
                        </div>
                </asp:Panel>

            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Panel>


<div style="display: none">
    <cca:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server"
        PopupControlID="pnlEmergente"
        Drag="true" PopupDragHandleControlID="baraSuperior"
        TargetControlID="lblInvicible"
        BackgroundCssClass="modalBackground" 
        RepositionMode="None" 
        DropShadow="true"
        CancelControlID="btnCancelarPopUp" Enabled="true">
    </cca:ModalPopupExtender>

    <asp:SqlDataSource ID="SqlDataSource2" runat="server"
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>"
        SelectCommand="SELECT [codModelo], ltrim( rtrim([NombreModelo])) NombreModelo FROM [Modelos] WHERE ([codFabricante] = @codFabricante) ORDER BY [NombreModelo]">
        <SelectParameters>
            <asp:ControlParameter ControlID="cmbFabricante" Name="codFabricante"
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>"
        SelectCommand="SELECT [codFabricante], [nombre_fabricante] 
    FROM [fabricante] ORDER BY [nombre_fabricante]"></asp:SqlDataSource>

</div>


<asp:SqlDataSource ID="SqlDataSource3" runat="server"
    ConnectionString="<%$ ConnectionStrings:spxConnectionString %>"
    SelectCommand="
     SELECT        dbo.fabricante.nombre_fabricante AS nombreFabricante, ISNULL(dbo.Modelos.NombreModelo, '') AS NombreModelo, 
dbo.equipos.serial,dbo.clientes.nitCliente, dbo.clientes.nombreCliente,dbo.ciudades.nombreCiudad,
fabricante.codFabricante,modelos.codModelo

FROM            dbo.equipos INNER JOIN
                         dbo.fabricante ON dbo.fabricante.codFabricante = dbo.equipos.codFabricante INNER JOIN
                         dbo.Modelos ON dbo.Modelos.codFabricante = dbo.equipos.codFabricante AND dbo.Modelos.codModelo = dbo.equipos.codModelo LEFT OUTER JOIN
                         dbo.clientes ON dbo.clientes.nitCliente = dbo.equipos.nitClienteUbica INNER JOIN
                         dbo.sucursalCliente ON dbo.sucursalCliente.nitCliente = dbo.equipos.nitClienteUbica AND 
                         dbo.sucursalCliente.codSucursal = dbo.equipos.codSucursalUbica LEFT OUTER JOIN
                         dbo.paises ON dbo.paises.codPais = dbo.sucursalCliente.codPais LEFT OUTER JOIN
                         dbo.departamentos ON dbo.departamentos.codPais = dbo.sucursalCliente.codPais AND 
                         dbo.departamentos.codDepartamento = dbo.sucursalCliente.codDepartamento LEFT OUTER JOIN
                         dbo.ciudades ON dbo.ciudades.codPais = dbo.sucursalCliente.codPais AND dbo.ciudades.codDepartamento = dbo.sucursalCliente.codDepartamento AND 
                         dbo.ciudades.codCiudad = dbo.sucursalCliente.codCiudad
        join tipoEquipo on modelos.codTipoEquipo = tipoEquipo.codTipoEquipo
where
((dbo.clientes.nitCliente = @nitcliente or rtrim(@nitcliente) ='') OR
   (dbo.clientes.nombreCliente like '%'+@nitcliente +'%' or rtrim(@nitcliente) ='') OR
    (dbo.equipos.serial = @nitcliente or rtrim(@nitcliente) ='')
    )

and 
(fabricante.codFabricante=@fabricante or @fabricante = '-1')

and 
(modelos.codModelo =@codmodelo or @codmodelo = '-1')
        and
        ((tipoEquipo.dispositivo_medicion is not null and tipoEquipo.dispositivo_medicion=1) or @medicion='0')
order by nombreCliente desc ">
    <SelectParameters>
        <asp:ControlParameter ControlID="txtNitcliente" Name="nitcliente"
            PropertyName="Text" DefaultValue=" " />
        <asp:ControlParameter ControlID="SearchText1" Name="serial"
            PropertyName="Text" DefaultValue=" " />
        <asp:ControlParameter ControlID="cmbFabricante" DefaultValue=" "
            Name="fabricante" PropertyName="SelectedValue" />

        <asp:ControlParameter ControlID="cmbModelo" DefaultValue=" " Name="codmodelo"
            PropertyName="SelectedValue" />
        <asp:ControlParameter ControlID="chkMedicion" DefaultValue="0" Name="medicion"
            PropertyName="Checked" />


    </SelectParameters>
</asp:SqlDataSource>





<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="controlRepuestos.ascx.cs" Inherits="Web2020.controles.controlRepuestos" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cca" %>
<%@ Register Src="controlTxtItem.ascx" TagName="controlTxtItem" TagPrefix="uc1" %>
<%@ Register Src="textItem.ascx" TagName="textItem" TagPrefix="uc2" %>

<style>
    #ContentPlaceHolder1_controlRepuestos1_Panel1_ModalPopupExtender_foregroundElement {
        position: fixed !important;
        left: auto% !important;
        right: auto% !important;
        top: 10% !important;
        
    }

    @media (max-width: 600px) {
      #ContentPlaceHolder1_controlRepuestos1_Panel1_ModalPopupExtender_foregroundElement {
        width:100%;
    }

      #ContentPlaceHolder1_controlRepuestos1_pnlEmergente{
        width:100% !important;
    }

    #baraSuperior{
        width:100% !important;
    }
    #ContentPlaceHolder1_controlRepuestos1_pnlResultados{
        overflow:auto !important;
    }

    #ContentPlaceHolder1_controlRepuestos1_pnlResultados div:nth-child(3){
        padding-left:20px !important;
    }

    .searchInputContainer{
        width: 60%  !important;
    }

    .searchInputContainer> *:first-child{
        width:100%  !important;
    }

    .searchBtnContainer{
        width: 30%  !important;
        padding-left: 0px !important;
        padding-top: 5px  !important;
        left: 0px !important;
    }

    .btnSuccessContainer{
        width: auto  !important;
    }

    .btnCancelarContainer{
        width:auto  !important;
    }
        


      
    }
    @media (min-width: 600px) {
    
    #baraSuperior> *:first-child{
        margin-left:0 !important;
    }

    }

  
  
</style>

<link href="../../css/default.css" rel="stylesheet" type="text/css" />
<div style="width: 30px; padding-left: 2px; padding-right: auto; display: inline; margin-right: 3px;" runat="server" id="pnlControlContenedor">
    <asp:Label ID="lblEventosEnncedidos" Text="" runat="server" Visible="false"></asp:Label>
    <asp:UpdatePanel ID="updatePanelTexto" runat="server" UpdateMode="Conditional" RenderMode="Inline">
        <ContentTemplate>

            <asp:ImageButton Width="26px" CausesValidation="false" ImageUrl="~/img/Crystal_Clear_action_edit_add.png"
                ToolTip="Agregar Repuesto" ID="btnAgregarRepuesto" runat="server" AlternateText="Agregar Repuesto"
                OnClick="btnAgregarRepuesto_Click" />
            <uc2:textItem ID="textItemPagina" runat="server" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Label Style="display: none" ID="lblInvicible" runat="server" />
</div>

<asp:Panel Style="display: none" ID="pnlEmergente" Enabled="true" runat="server"
    Height="450px" Width="470px" BackColor="LightGray">

    <div id="baraSuperior" style="background-repeat: repeat; background-position: left top; width: 840px; margin-top: 0px;">
        <asp:ImageButton ImageUrl="../img/web/Cerrar.png" ID="btnCancelarPopUp" runat="server"
            Style="cursor: pointer; position: static; margin-left: 443px;" Width="16px" />
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
        <ContentTemplate>

            <asp:Panel ID="pnlContenido" runat="server" BackColor="white" Style="padding-left: 20px; padding-top: 5px;">
                <asp:Panel ID="pnlResultados" runat="server">
                    <div class="row">
                        <div class=" col-sm-12">

                            <asp:Label Text="Seleccione Los Repuestos." runat="server" ID="titulo2" />
                        </div>
                    </div>
                    <div class="row">
                        <div class=" col-sm-2">
                            <asp:Label runat="server" ID="SearchLabel1">     Buscar:</asp:Label>
                        </div>
                        <div class=" col-sm-2 searchInputContainer">
                            <asp:TextBox runat="server" ID="SearchText1"></asp:TextBox>
                        </div>
                        <div class=" col-sm-1 searchBtnContainer" style="left:115px;">

                            <asp:ImageButton ID="btnBuscar" runat="server" AlternateText="Buscar"
                                ImageUrl="~/img/web/Ico_BuscarDir.png" OnClick="btnBuscar_Click" CausesValidation="false"
                                ToolTip="Buscar" Width="26px" />

                        </div>
                    </div>
                    <div class="row" style="width: min-content; margin-bottom:10px;">
                        <div class="Formulario">
                            <asp:GridView runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                ID="Browse1" AllowSorting="True"
                                PageSize="6" DataSourceID="ObjectDataSource1" DataKeyNames="CodRepuesto"
                                OnRowDataBound="Browse1_RowDataBound" OnSorting="Browse1_Sorting"
                                OnPreRender="Browse1_PreRender">

                                <PagerSettings FirstPageImageUrl="../img/web/PagerFirst.gif"
                                    LastPageImageUrl="../img/web/PagerLast.gif" Mode="NextPreviousFirstLast"
                                    NextPageImageUrl="../img/web/PagerNext.gif"
                                    Position="TopAndBottom" PreviousPageImageUrl="../img/web/PagerPrevious.gif"></PagerSettings>


                                <Columns>

                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:ImageButton ID="btnOk" Width="26px" runat="server" AlternateText="Ok"
                                                ImageUrl="~/img/web/ok.gif"
                                                ValidationGroup='<%# Eval("CodRepuesto") %>'
                                                CommandName='<%# Eval("Descripcion")  %>'
                                                OnClick="btnOk_Click" ToolTip="Agregar" />
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                    <asp:TemplateField HeaderText="Codigo Repuesto" SortExpression="CodRepuesto">


                                        <ItemTemplate><%# Eval("CodRepuesto") %>
                                          
                                        </ItemTemplate>

                                        <ItemStyle Wrap="True"></ItemStyle>

                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Repuesto" SortExpression="Descripcion">


                                        <ItemTemplate><%# Eval("Descripcion") %>
                                           
                                        </ItemTemplate>

                                        <ItemStyle Wrap="True"></ItemStyle>

                                    </asp:TemplateField>

                                    <asp:TemplateField Visible="false" HeaderText="precio" SortExpression="Precio">


                                        <ItemTemplate><%# Eval("Precio") %>
                                           
                                        </ItemTemplate>

                                        <FooterStyle HorizontalAlign="Right"></FooterStyle>

                                        <HeaderStyle HorizontalAlign="Right"></HeaderStyle>

                                        <ItemStyle HorizontalAlign="Right" Wrap="True"></ItemStyle>

                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Cantidad">


                                        <ItemTemplate>
                                            <asp:DropDownList Width="25px" runat="server" ID="cmbCantidad">
                                                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                                <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                                <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                                <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                                <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                                <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                                <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                                <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                                <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                                <asp:ListItem Text="13" Value="13"></asp:ListItem>
                                                <asp:ListItem Text="14" Value="14"></asp:ListItem>
                                                <asp:ListItem Text="15" Value="15"></asp:ListItem>
                                                <asp:ListItem Text="16" Value="16"></asp:ListItem>
                                                <asp:ListItem Text="17" Value="17"></asp:ListItem>
                                                <asp:ListItem Text="18" Value="18"></asp:ListItem>
                                                <asp:ListItem Text="19" Value="19"></asp:ListItem>
                                                <asp:ListItem Text="20" Value="20"></asp:ListItem>
                                            </asp:DropDownList>
                                        </ItemTemplate>

                                        <FooterStyle HorizontalAlign="Right"></FooterStyle>

                                        <HeaderStyle HorizontalAlign="Right"></HeaderStyle>

                                        <ItemStyle HorizontalAlign="Right" Wrap="True"></ItemStyle>

                                    </asp:TemplateField>

                                </Columns>

                                <EmptyDataTemplate>
                                    No se Econtraron coincidencias!!! 
                                </EmptyDataTemplate>

                            </asp:GridView>







                        </div>
                    </div>

                    <uc2:textItem ID="textItemPopPup" runat="server" />
                    <br />
                    <div class="row">
                        <div class="panelResultados  col-sm-6">
                            <asp:Label ID="lblEncontrados" runat="server"></asp:Label>
                            registro(s) encontrado(s)
            <br />
                            <br />
                            Mostrando de
                        <asp:Label ID="lbldesde" runat="server"></asp:Label>
                            Hasta
                        <asp:Label ID="lblHasta" runat="server"></asp:Label>
                        </div>
                        <div class="col-sm-2 btnSuccessContainer">

                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="btn btn-success"
                                CausesValidation="false" ToolTip="Aceptar" OnClick="btnSeleccionarMarcados_Click"></asp:Button>
                        </div>
                        <div class="col-sm-2 btnCancelarContainer">
                            <asp:Button CausesValidation="false" ID="btnCancelar" runat="server"
                                class="btn btn-danger" Text="Cancelar" ToolTip="Cancelar" OnClick="btnCancelar_Click"></asp:Button>
                        </div>

                    </div>

                    <div>
                        <div>
                            &nbsp;
                        </div>
                    </div>

                </asp:Panel>

                <br />
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Panel>


<div style="display: none; position: fixed;">
    <cca:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server"
        PopupControlID="pnlEmergente"
        Drag="true" PopupDragHandleControlID="baraSuperior"
        TargetControlID="lblInvicible"
        BackgroundCssClass="modalBackground"
        DropShadow="true"
        CancelControlID="btnCancelarPopUp" Enabled="true">
    </cca:ModalPopupExtender>

    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" TypeName="BOLayer.RepuestoFactory" SelectCountMethod="Count" EnablePaging="True" UpdateMethod="Save" DeleteMethod="Delete" SortParameterName="pSortExpression" MaximumRowsParameterName="pMaxResult" StartRowIndexParameterName="pFirstResult" SelectMethod="GetAll">
        <SelectParameters>
            <asp:Parameter Name="pSortExpression"></asp:Parameter>
            <asp:Parameter Name="pCriteria"></asp:Parameter>
        </SelectParameters>
        <DeleteParameters>
            <asp:Parameter Name="codRepuesto"></asp:Parameter>
        </DeleteParameters>

    </asp:ObjectDataSource>

</div>




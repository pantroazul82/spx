<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmCambiarPassword.aspx.cs" Inherits="Web2020.frm.logica.frmCambiarPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="Server">
    <link href="../../css/default.css" rel="stylesheet" type="text/css" />
      <link href="../../assets/css/EjecutarOrden.css" rel="stylesheet">
    <style type="text/css">
        .style1 {
            width: 100%;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="screen-1">
        <div class="container">
            <div class="h2 passTitle">
                Formulario de Cambio de password
            </div>
            <hr />
            <div class="Formulario">
                <div>
                    <div class="row passFieldsContainer">
                        <div class="col-sm-4">Password anterior</div>
                        <div class="col-sm-3 style1">
                            <asp:TextBox ID="txtAnterior" runat="server"
                                Width="336px" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-4">Password nuevo</div>
                        <div class="style1 col-sm-3">
                            <asp:TextBox ID="txtNuevo" runat="server" Width="336px"
                                TextMode="Password"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-4">Confirmacion Password </div>
                        <div class="style1 col-sm-3">
                            <asp:TextBox ID="txtConfirmacion" runat="server" Width="339px"
                                TextMode="Password"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-3" colspan="2">
                            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div></div>
                        <div class="style1 col-sm-3">
                            <asp:Button runat="server" CssClass="btn btn-success" Text="Cambiar Password"
                                ID="btnCqmbiar" OnClick="btnCqmbiar_Click" />
                            <br />
                        </div>
                    </div>

                </div>
                <br />
            </div>
        </div>
    </div>
</asp:Content>


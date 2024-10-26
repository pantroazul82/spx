﻿<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmPolizas.aspx.cs" Inherits="frm_csuministro_frmPolizas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
      <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <div class="tab">Poliza Contrato Suministro</div>
    <div class="Formulario">
        <table>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td>Nombre</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Porcentaje</td>
                <td>
                    <asp:TextBox ID="txtPorcentaje" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Valor</td>
                <td>
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>Vigencia en Meses</td>
                <td>
                    <asp:DropDownList ID="cmbVigencia" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                </td>
            </tr>

        </table>

    </div>

</asp:Content>


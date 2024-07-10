<%@ Page Title="Entrar al Sistema" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frm_logica_frmLogin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/login.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>

<asp:UpdatePanel ID="UpdatePanel2" runat="server">
<ContentTemplate>
<div id="panelLogin" class="infGeneral">

    <span 
        style="border-collapse: separate; color: rgb(51, 51, 51); font-family: 'lucida grande'; font-size: 14px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0; ">
    Inicio de sesión
    <span
        style="border-collapse: separate; color: rgb(51, 51, 51); font-family: 'lucida grande'; font-size: 14px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0;"><hr 
        style="width: 564px; height: -12px" />
    </span>
    <br />
    </span>
    <table style="width: 400px">
        <tr>
            <td colspan="2" style="height: 60px;text-align:center">
                <asp:Label ID="lblError" runat="server" BackColor="#FFEBE8" 
                    BorderColor="#DD3C10" BorderStyle="Solid" BorderWidth="1px" Height="50px" 
                    Visible="False" Width="380px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                &nbsp;<asp:Label ID="Label1" runat="server" Text="Nombre de Usuario:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td align="left">
                <asp:TextBox ID="txtUsuario" runat="server" Width="200px"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ControlToValidate="txtUsuario"
                    ID="RequiredFieldValidator1" runat="server" ErrorMessage="El Nombre de Usuario es Obligatorio!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td align="left" style="height: 36px">
                <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td align="left" style="height: 36px">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 55px">
                <asp:CheckBox ID="chkRecordarme" runat="server" Text="Recordarme"  Visible="false" />
                <br />
                <asp:CheckBox ID="chkRecordarPass" runat="server" Text="Recordar Contraseña" Visible="false" />
            </td>
        </tr>
        <tr>
            <td style="text-align:center" colspan="2">
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" 
                    onclick="btnIngresar_Click" />
                     <asp:Label ID="lblEnviadoDesde" runat="server" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
        <span
        style="border-collapse: separate; color: rgb(51, 51, 51); font-family: 'lucida grande'; font-size: 14px; font-style: normal; font-variant: normal; font-weight: bold; letter-spacing: normal; line-height: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-border-horizontal-spacing: 0px; -webkit-border-vertical-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-size-adjust: auto; -webkit-text-stroke-width: 0;"><hr 
        style="width: 564px; height: -12px" />
    </span>
</div>
</ContentTemplate>
</asp:UpdatePanel>
<p>
</p>
</asp:Content>


<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmFirma.aspx.cs" Inherits="frm_ordenServicio_frmFirma" %>
<%@ Reference Control="~/controles/ctlSignature.ascx" %>
<%@ Register src="~/controles/ctlSignature.ascx" tagname="ctlSignature" tagprefix="uc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Firma</title>
    <link href="../../App_Themes/blue/tablas.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            font-size: x-large;
            }
        .style2
        {
        }
        .style4
        {
        }
        .style5
        {
            width: 63px;
            height: 44px;
        }
        .style9
        {
            width: 89px;
        }
        .style12
        {
        }
        .style13
        {
            width: 164px;
        }
        .style14
        {
            width: 100px;
        }
    </style>  
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="newspaper-a" 
            
            style=" width:755px; margin-top:5px !important;margin-bottom:5px !important;" >
    
        <tr>
    <td class="style1" colspan="5">
        <strong>
            <img alt="logo" class="style5" longdesc="logo" 
                src="../../img/frm/modo%20dos%20trasparente.png" /> Firma Aceptacion</strong></td>
    </tr>
        <tr>
    <td class="style14">
                Hora de Llegada:</td>
        <td class="style13">
                <asp:DropDownList ID="cmbHoraLlegada" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="cmbMinutosLlegada" runat="server" >
                </asp:DropDownList>
                <asp:DropDownList ID="cmbAmPmLlegada" runat="server" >
                    <asp:ListItem>AM</asp:ListItem>
                    <asp:ListItem>PM</asp:ListItem>
                </asp:DropDownList>
            </td>
        <td class="style9">
            Hora de Salida:</td>
        <td class="style12" colspan="2">
            <asp:DropDownList ID="cmbHoraSalida" runat="server" >
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="cmbMinutosSalida" runat="server" >
            </asp:DropDownList>
            <asp:DropDownList ID="cmbAmPmSalida" runat="server" >
                <asp:ListItem>AM</asp:ListItem>
                <asp:ListItem>PM</asp:ListItem>
            </asp:DropDownList>
            </td>
    </tr>
        <tr>
            <td class="style4" colspan="5">
            Nombre del Usuario que recibe:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
            <asp:TextBox ID="txtUsuarioAceptacion" runat="server"
                Width="280px"></asp:TextBox>
       
                </td>
        </tr>
    
        <tr>
            <td colspan="4">
                <uc:ctlSignature ID="ctlSignature1" runat="server" BackColor="White" 
                    PenColor="Black" PenWidth="1" SavePath="~/temp/"                     
                    SignatureCodePath="~/controles/" SignatureFileFormat="Gif" SignHeight="250" 
                    SignWidth="500"  NoSignMessage="No se encontro la Firma"
                     EnableViewState="True" />			
       
           <asp:Label runat="server" ID="lblError" Text="" ForeColor="Red"></asp:Label>
       
                </td>
            <td>
              <asp:Button ID="btnLimpiarFirma" runat="server" OnClientClick="ClearSignature();" Text="Limpiar Firma" Visible="true" />
              <input type="button"  value="Guardar firma" onclick="SaveSignature();" /><br />
        <asp:ImageButton  Width="30px" ID="btnAceptarAceptacion" runat="server" 
            ImageUrl="~/img/web/ok.gif" OnClick="btnAceptarAceptacion_Click" 
            ToolTip="Aceptar"  />
        <asp:ImageButton  Width="30px" ID="btnCancelarAceptacion" runat="server" 
            ImageUrl="~/img/web/cancel.gif" OnClick="btnCancelarAceptacion_Click" 
            ToolTip="Cancelar"  />

                </td>
        </tr>
    
        </table>
    </div>
    </form>
</body>
</html>

<%@ Control Language="C#" AutoEventWireup="true" CodeFile="menu.ascx.cs" Inherits="controles_menu" %>


<asp:Menu ID="menuUsuario" runat="server"  Orientation="Horizontal"
 
 StaticBottomSeparatorImageUrl="~/img/menus/sep.png">
 

<StaticMenuStyle HorizontalPadding="10px" Height="20px" Width="100px" BackColor="#FFFFFF" BorderWidth="0px" Font-Size="18px" Font-Names="Verdana" ForeColor="#000000"/>
<StaticHoverStyle Font-Bold="true"  Height="20px" Width="100px"  BackColor="White" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000"/>
<StaticSelectedStyle HorizontalPadding="10px"   Height="20px" Width="100px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />

<LevelMenuItemStyles>
<asp:MenuItemStyle  HorizontalPadding="10px"  Height="20px" Width="100px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:MenuItemStyle  HorizontalPadding="10px"  Height="20px" Width="100px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
</LevelMenuItemStyles>
  
  <LevelSelectedStyles>
  <asp:MenuItemStyle HorizontalPadding="10px"  Height="20px" Width="100px"   BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
  <asp:MenuItemStyle HorizontalPadding="10px"  Height="20px" Width="100px"   BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
  </LevelSelectedStyles>
  
  <LevelSubMenuStyles>
  <asp:SubMenuStyle  HorizontalPadding="0px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:SubMenuStyle  HorizontalPadding="10px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:SubMenuStyle  HorizontalPadding="10px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:SubMenuStyle  HorizontalPadding="10px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:SubMenuStyle  HorizontalPadding="10px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:SubMenuStyle  HorizontalPadding="10px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:SubMenuStyle  HorizontalPadding="10px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:SubMenuStyle  HorizontalPadding="10px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />
<asp:SubMenuStyle  HorizontalPadding="10px"  BackColor="#FFFFFF" BorderWidth="0px"  Font-Size="18px" Font-Names="Verdana" ForeColor="#000000" />

</LevelSubMenuStyles>
      
    <Items>
    
        <asp:MenuItem  Text="Equipos" Value="1" NavigateUrl="~/frm/hojavida/frmSeguimiento.aspx">
        </asp:MenuItem>
        <asp:MenuItem Text="Ordenes de Servicio" Value="3" NavigateUrl="~/frm/ordenServicio/frmListado.aspx">
        </asp:MenuItem>

        <asp:MenuItem Text="Ordenes de Prestamo" Value="4" NavigateUrl="~/frm/ordenPrestamo/frmListadoOrdenesPrestamo.aspx">
        </asp:MenuItem>

        <asp:MenuItem Text="Cambiar Password" Value="5" NavigateUrl="~/frm/logica/frmCambiarPassword.aspx">
             
        </asp:MenuItem>
    </Items>
</asp:Menu>

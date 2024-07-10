<%@ Page Title="" Language="C#" 
     AutoEventWireup="true" CodeBehind="ws.aspx.cs" Inherits="Web2020.frm.cg.ws" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Query<br />
        <asp:TextBox ID="txtSql" runat="server" BackColor="Black" ForeColor="Lime" 
            Height="222px" Width="1041px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnConsulta" runat="server" onclick="btnConsulta_Click" 
            Text="Ejecutar Consulta" />
        <asp:Button ID="btnCOmando" runat="server" onclick="btnCOmando_Click" 
            Text="Ejecutar Comando" />
        <asp:Button ID="btnEjecutarProcedimiento" runat="server" 
            onclick="btnEjecutarProcedimiento_Click" Text="Procedimiento" />
        <asp:Label ID="lblRespuesta" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    <telerik:RadGrid ID="grdDatos" runat="server">
    </telerik:RadGrid>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    </form>
</body>
</html>

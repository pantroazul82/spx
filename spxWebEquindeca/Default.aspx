<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>


<%@ Register assembly="C1.Web.Wijmo.Controls.4" namespace="C1.Web.Wijmo.Controls.C1ReportViewer" tagprefix="wijmo" %>


<%@ Register assembly="C1.Web.Wijmo.Controls.4" namespace="C1.Web.Wijmo.Controls.C1ToolTip" tagprefix="wijmo" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <wijmo:C1ReportViewer ID="C1ReportViewer1" runat="server" Height="600px" 
        Width="800px">
    </wijmo:C1ReportViewer>
    <wijmo:C1ToolTip ID="C1ToolTip1" runat="server">
    </wijmo:C1ToolTip>
    </form>
</body>
</html>

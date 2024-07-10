<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="frm_ordenServicio_Default" %>
<%@ Reference Control="../../controles/ctlSignature.ascx" %>
<%@ Register src="../../controles/ctlSignature.ascx" tagname="ctlSignature" tagprefix="uc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
      <script language="javascript" type="text/javascript">
            // This is the method that is directly called, this will save signature
            // and then call server code to do further processing. You can change
            // the delay of 5 seconds as per your needs
		    function DirectSave()
		    {
    	        SaveSignature();
		        
		        var date = new Date();
                var curDate = null;

                // delay of 5 seconds, 5000 milisecons, change as per requirement
                do { curDate = new Date(); }
                while(curDate-date < 5000);

                return true;
		    }
		</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <uc:ctlSignature ID="ctlSignature1" runat="server" BackColor="White" 
                    PenColor="Black" PenWidth="1" SavePath="~/temp/"
                     
                    SignatureCodePath="~/controles/" SignatureFileFormat="png" SignHeight="200" 
                    SignWidth="400" Visible="true" NoSignMessage="No se encontro la Firma"
                     />
              <asp:ImageButton  Width="30px" ID="btnAceptarAceptacion" runat="server" 
            ImageUrl="~/img/web/ok.gif" 
            OnClientClick="DirectSave();" ToolTip="Aceptar" Visible="true" />
            
             <asp:ImageButton  Width="30px" ID="ImageButton1" runat="server" 
            ImageUrl="~/img/web/ok.gif" 
            ToolTip="Aceptar 2" Visible="true" onclick="ImageButton1_Click" />

    
    
    
    
    
    
    
    
    
    </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="frmEjecutarOrdenPaint.aspx.cs" Inherits="frm_ordenServicio_frmEjecutarOrdenPaint" %>
<%@ Reference Control="../../controles/ctlSignature.ascx" %>
<%@ Register src="../../controles/ctlSignature.ascx" tagname="ctlSignature" tagprefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
   
    <p>
        <uc:ctlSignature Visible="false" ID="ctlSignature1" PenColor="Black" PenWidth="1" BackColor="White" SignWidth="400" SignHeight="200"
							SavePath="~/temp/" SignatureCodePath="~/controles/" SignatureFileFormat="gif" Runat="server">
							</uc:ctlSignature>
		
			
    </p>
    <asp:Panel ID="Panel1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="ok" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="cancel" />
        <asp:Button ID="Button3" runat="server" OnClientClick="SaveSignature();" onclick="Button3_Click" 
            Text="Guardar" />
            
            
           
            

						<input type="button" class="flatbutton" value="  Re-Sign " onclick="ClearSignature();">
    </asp:Panel>
    <p>
    </p>
    <p>
    </p>
</asp:Content>


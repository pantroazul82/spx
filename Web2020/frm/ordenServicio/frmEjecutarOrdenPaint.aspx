<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmEjecutarOrdenPaint.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmEjecutarOrdenPaint" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="server">
    <style>
        #signature {
            width: 400px;
            height: 200px;
            border: 1px solid black;
        }
    </style>
    <script src="https://cdn.jsdelivr.net/npm/signature_pad@2.3.2/dist/signature_pad.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            //console.log('Entro')
            var signaturePad = new SignaturePad(document.getElementById('signature-pad'));

            $('#click').click(function () {
                var data = signaturePad.toDataURL('image/png');
                $('#output').val(data);

                //$("#sign_prev").show();
                $("#sign_prev").attr("src", data);
                // Open image in the browser
                //window.open(data);
            });

            $('#LimpiarPad').click(function () {
                console.log('Limpiando')
                signaturePad.clear();
            })

            $('#btnAceptarAceptacion').click(function () {
                //alert('Guardar');
                var data = signaturePad.toDataURL('image/png');
                $('#output').val(data);
                $('#FirmaValida').val(signaturePad.isEmpty())
                return;
            })
        })
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
   
    <p>

        <div id="signature" style='' runat="server" ClientIDMode="Static">
                        <canvas id="signature-pad" class="signature-pad" width="400px" height="200px"></canvas>
                    </div>
                    <asp:TextBox runat="server" ID='output' ClientIDMode="Static" Style='display: none;'></asp:TextBox><br />
                    <asp:HiddenField runat="server" ID="FirmaValida" ClientIDMode="Static" />
		
			
    </p>
    <asp:Panel ID="Panel1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="ok" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="cancel" />
        <asp:Button ID="Button3" runat="server" OnClientClick="SaveSignature();" onclick="Button3_Click" 
            Text="Guardar" />
            
            
           
            

						<input type="button" id="LimpiarPad" class="flatbutton" value="Re-Sign " onclick="ClearSignature();">
    </asp:Panel>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

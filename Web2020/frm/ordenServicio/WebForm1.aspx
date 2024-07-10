<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web2020.frm.ordenServicio.WebForm1" %>




<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="server">
    <script src="https://cdn.jsdelivr.net/npm/signature_pad@2.3.2/dist/signature_pad.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            console.log('Entro')
            var signaturePad = new SignaturePad(document.getElementById('signature-pad'));

            $('#click').click(function () {
                var data = signaturePad.toDataURL('image/png');
                $('#output').val(data);

                //$("#sign_prev").show();
                $("#sign_prev").attr("src", data);
                // Open image in the browser
                //window.open(data);
            });

            $('#limpiar').click(function () {
                console.log('Limpiando')
                signaturePad.clear();
            })

            $('#Save').click(function () {
                alert('Guardar');
                var data = signaturePad.toDataURL('image/png');
                $('#output').val(data);
                $('#FirmaValida').val(signaturePad.isEmpty())
                alert($('#FirmaValida').val())
                return;
            })
        })
    </script>


    <style>
        #signature {
            width: 300px;
            height: 200px;
            border: 1px solid black;
        }
       
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label runat="server" Text="Ingrese su Nombre Completo"></asp:Label>
    <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
    <br />

    <asp:Label runat="server" Text="Ingrese su CC"></asp:Label>
    <asp:TextBox runat="server" ID="txtCC"></asp:TextBox>
    <br />

    <asp:Label runat="server" Text="Ingrese su Correo"></asp:Label>
    <asp:TextBox runat="server" ID="txtCorreo"></asp:TextBox>
    <br />
        
    <asp:Label runat="server" Text="Ingrese su Firma"></asp:Label><br />

    <div id="signature" style=''>
        <canvas id="signature-pad" class="signature-pad" width="300px" height="200px"></canvas>
    </div>
    <br />

    <input type='button' id='click' value='preview'><br />
    <input type='button' id='limpiar' value='Limpiar'><br />
    <asp:Button runat="server" Text="Guardar" ID="Save" ClientIDMode="Static" OnClick="Save_Click"  /><br />



    <asp:TextBox runat="server" ID='output' ClientIDMode="Static" style='display: none;'></asp:TextBox><br />
    <asp:HiddenField runat="server" ID="FirmaValida" ClientIDMode="Static" />

    <!-- Preview image -->
    <img src='' id='sign_prev' style='display: none;' />


</asp:Content>

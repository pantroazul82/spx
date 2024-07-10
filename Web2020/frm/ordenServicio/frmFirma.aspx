<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmFirma.aspx.cs" Inherits="Web2020.frm.ordenServicio.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="server">
    <title>Firma</title>
    <link href="../../css/tablas.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1 {
            font-size: x-large;
        }

        .style2 {
        }

        .style4 {
        }

        .style5 {
            width: 63px;
            height: 44px;
        }

        .style9 {
            width: 89px;
        }

        .style12 {
        }

        .style13 {
            width: 164px;
        }

        .style14 {
            width: 100px;
        }

        #signature {
            width: 500px;
            height: 250px;
            border: 1px solid black;
        }
    </style>
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

            $('#btnLimpiarFirma').click(function () {
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


    <div>
        <table id="newspaper-a"
            style="width: 755px; margin-top: 5px !important; margin-bottom: 5px !important;">

            <tr>
                <td class="style1" colspan="5">
                    <strong>
                        <img alt="logo" class="style5" longdesc="logo"
                            src="../../img/frm/modo%20dos%20trasparente.png" />
                        Firma Aceptacion</strong></td>
            </tr>
            <tr>
                <td class="style14">Hora de Llegada:</td>
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
                    <asp:DropDownList ID="cmbMinutosLlegada" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="cmbAmPmLlegada" runat="server">
                        <asp:ListItem>AM</asp:ListItem>
                        <asp:ListItem>PM</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style9">Hora de Salida:</td>
                <td class="style12" colspan="2">
                    <asp:DropDownList ID="cmbHoraSalida" runat="server">
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
                    <asp:DropDownList ID="cmbMinutosSalida" runat="server">
                    </asp:DropDownList>
                    <asp:DropDownList ID="cmbAmPmSalida" runat="server">
                        <asp:ListItem>AM</asp:ListItem>
                        <asp:ListItem>PM</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style4" colspan="5">Nombre del Usuario que recibe:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
            <asp:TextBox ID="txtUsuarioAceptacion" runat="server"
                Width="280px"></asp:TextBox>

                </td>
            </tr>

            <tr>
                <td colspan="4">
                    <h2> Firme en el espacio en blanco </h2>
                    <!--Pad firma aqui-->
                    <div id="signature" style='' runat="server" ClientIDMode="Static">
                        
                        <canvas id="signature-pad" class="signature-pad" width="500px" height="250px"></canvas>
                    </div>
                    <asp:TextBox runat="server" ID='output' ClientIDMode="Static" style='display: none;'></asp:TextBox><br />
                    <asp:HiddenField runat="server" ID="FirmaValida" ClientIDMode="Static" /><br />

                    <asp:Label runat="server" ID="lblError" Text="" ForeColor="Red"></asp:Label>

                </td>
                <td>
                    <asp:Button ID="btnLimpiarFirma" runat="server"  ClientIDMode="Static" Text="Limpiar Firma" Visible="true" />
                    
                    <asp:ImageButton Width="30px" ID="btnAceptarAceptacion" runat="server" ClientIDMode="Static"
                        ImageUrl="~/img/web/ok.gif" OnClick="btnAceptarAceptacion_Click"
                        ToolTip="Aceptar" />
                    <asp:ImageButton Width="30px" ID="btnCancelarAceptacion" runat="server"
                        ImageUrl="~/img/web/cancel.gif" OnClick="btnCancelarAceptacion_Click"
                        ToolTip="Cancelar" />

                    <br />

                </td>
            </tr>

        </table>
    </div>



</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmFirmaN.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmFirmaN" %>


<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="server">
    <title>Firma</title>
    <link href="../../App_Themes/blue/tablas.css" rel="stylesheet" type="text/css" />  
    <link href="../../assets/css/EjecutarOrden.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">



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
            height: 140px;
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

            $('#btnLimpiar').click(function () {
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



    <div class="screen-1">
        <div class="container">
         
                <div
                    style="width: auto; margin-top: 0px !important;">
                 
                        <div>
                            <div class="row signContainer" >
                             <h2> Firme en el espacio en blanco </h2>
                                <br>
                            <div class="col-sm-6" id="signature" style='max-width:330px !important;' runat="server" clientidmode="Static">
                                <canvas id="signature-pad" class="signature-pad" style="max-width: 100%;  "></canvas>
                          
                            <asp:TextBox runat="server" ID='output' ClientIDMode="Static" Style='display: none;'></asp:TextBox><br />
                            <asp:HiddenField runat="server" ID="FirmaValida" ClientIDMode="Static" />

                            </div>

                            </div>
                            <div>
                            </div>
                            <div class="row btnControlContainer">
                                <div class="col-sm-4">
                            <strong>Firma Aceptacion Supportech</strong>
                                </div>
                                <div class="col-sm-2">
                            <asp:Button runat="server" ID="btnLimpiar" CssClass="btn btn-success" Text="Limpiar firma" ClientIDMode="Static"
                                CausesValidation="false" />
                                    </div>
                                <div class="col-sm-3">
                            <asp:Button ID="btnAceptarAceptacion" runat="server" ClientIDMode="Static"
                                Text="Guardar Firma y Cerrar" OnClick="btnAceptarAceptacion_Click" CssClass="btn btn-primary"
                                ToolTip="Aceptar" />
                                    </div>
                                <div class="col-sm-2">
                            <asp:Button ID="btnCancelarAceptacion" runat="server"
                                ImageUrl="~/img/web/cancel.gif" OnClick="btnCancelarAceptacion_Click" CssClass="btn btn-danger"
                                CausesValidation="false" Text="Cancelar"
                                ToolTip="Cancelar" />
                                </div>
                                <div class="col-sm-1">
                                </div>
                                </div>
                                    <div class="col-sm-12">
                            <asp:Label runat="server" ID="lblError" Text="" ForeColor="Red"></asp:Label>

                        </div>
                      
                    <div class="row">
                        <div class="col-sm-3" colspan="5">Cantidad de Horas Efectivas    </div>
                    <div class="col-lg-3">
                            <asp:TextBox ID="txtcantidadDeHoras" runat="server" onkeypress="return isNumberKey(event)" Enabled="false" Text="0"></asp:TextBox>
                            </div>

                    
                    </div>
                          
                    <div class="row">
                        <div class="col-sm-3" colspan="5">Nombre del Usuario que recibe: 

                        </div>
                        <div class="col-sm-3">
            <asp:TextBox ID="txtUsuarioAceptacion" runat="server"></asp:TextBox>

                       
                    </div>
                        </div>
                         
                    <div class="row fechaLlegada">

                        <div class="col-sm-3">Fecha de Llegada<br />   </div>
                            <telerik:RadDatePicker Enabled="false" CssClass="col-lg-3 d-flex justify-content-center align-items-start" style="flex-direction: column-reverse;"
                                ID="calFechaLLegada" runat="server">
                                <Calendar ID="Calendar2" runat="server">
                                    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy"></FastNavigationSettings>
                                </Calendar>
                            </telerik:RadDatePicker>

                    </div>
                        <div class="row" >
                            <div class="col-sm-3">
                            <asp:Label runat="server" Text="Hora de Llegada:"  ></asp:Label>
                            </div>
                            
                        <div class="style12" colpsan="2" >
                            <div class="col-sm-3" style="display: flex;">
              
                            <asp:DropDownList style="width: min-content;" ID="cmbHoraLlegada" runat="server">
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
                            
             
                            <asp:DropDownList style="width: min-content;" ID="cmbMinutosLlegada" runat="server">
                            </asp:DropDownList>
                            <asp:DropDownList style="width: min-content;" ID="cmbAmPmLlegada" runat="server">
                                <asp:ListItem>AM</asp:ListItem>
                                <asp:ListItem>PM</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        </div>
                        </div>
                            
                               
                           
                            <div class="row fechaSalida">
                        <div class="col-sm-3">Fecha de Salida<br /></div>
                            <telerik:RadDatePicker Enabled="false" CssClass="col-sm-3 d-flex justify-content-center align-items-center" style="flex-direction: column-reverse;"
                                ID="calFechaDeSalida" runat="server">
                                <Calendar ID="Calendar3" runat="server">
                                    <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy"></FastNavigationSettings>
                                </Calendar>
                            </telerik:RadDatePicker>
                        
                        </div>
                           
                           
                            <div class="row">
                        <div class="col-sm-3">
                            <asp:Label runat="server" Text="Hora de Salida:" Width="125px"></asp:Label></div>
                        <div class="style12" colspan="2">
                            <div class="col-sm-3" style="display: flex;">
                            <asp:DropDownList style="width: min-content;" ID="cmbHoraSalida" runat="server">
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
                            <asp:DropDownList style="width: min-content;" ID="cmbMinutosSalida" runat="server">
                            </asp:DropDownList>
                            <asp:DropDownList style="width: min-content;" ID="cmbAmPmSalida" runat="server">
                                <asp:ListItem>AM</asp:ListItem>
                                <asp:ListItem>PM</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                          
                    </div>
                    </div>
                    </div>



               
            </div>
        </div>
    </div>
 


</asp:Content>

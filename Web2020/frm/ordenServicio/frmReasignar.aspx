<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmReasignar.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmReasignar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cca" %>



<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link href="../../assets/css/EjecutarOrden.css" rel="stylesheet">

    <style>

        .Formulario_tabla{
            padding-left:10px;
        }
        #signature {
            width: 400px;
            height: 200px;
            border: 1px solid black;
        }

        #ContentPlaceHolder1_pnlVariables{
         max-width: 100% !important;
         max-height: 100% !important;
         height:100% !important;
         width:320px !important;
         padding: 1rem !important;
        }
        #ContentPlaceHolder1_controlSerial1_pnlEmergente{
            width: 400px!important;
        }

     

        #ContentPlaceHolder1_rdInterna{
            position:relative;
            margin-right:5px;
        }

         #ContentPlaceHolder1_rdExterna{
            position: relative;
            margin-right:5px;
        }

         #ContentPlaceHolder1_controlSerial1_SearchText1{
             display:none;
         }

         #ContentPlaceHolder1_controlSerial1_btnCancelarPopUp{
             margin-left:3.5% !important;
         }

         #ContentPlaceHolder1_controlSerial1_btnBuscar{
              width: 37px !important;
               height: 37px;
         }

          .btnBuscar{
               padding-left: unset;
            }
        @media(max-width: 576px){
            .btnBuscar{
                left: unset !important;
            }

             #ContentPlaceHolder1_rdInterna{
            margin: 5px;
        }

        #ContentPlaceHolder1_rdExterna{
            margin: 5px;
        }

         
       
            
        }

    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            console.log('Entro')
            
        })
    </script>

    <style>
        st {
            color: #495057;
            background-color: #fff !important;
            border-color: #dee2e6 #dee2e6 #fff !important;
            color: unset !important;
            font: unset !important;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="screen-1">
        <div class="container">
            <div class="justify-content-md-center; orderTitleContainer">
                <div class="col col-lg-5">

                    <h2 style="color: black;" class="titulo">Orden de Servicio</h2>

                </div>
                <div class="col col-lg-auto">
                    <asp:Label Class="tituloCod" runat="server" ID="lblOrdenServicio" Text="Orden de servicio" Style="font-size: 2.8rem; font-weight: bold; color: black;"></asp:Label>

                </div>
            </div>
            <br />
            <hr />
            <div class="row">
                <div class="col col-sm-2">
                    <asp:Button ID="btnCancelar" class="btn btn-danger" runat="server" Text="Cerrar Orden"
                        OnClick="btnCancelar_Click"  />
                </div>
                <div class="col col-sm-2">
                    <asp:Button ID="btnReasignar" runat="server" Text="Reasignar Orden"
                        OnClick="btnREasginar_Click"  />

                </div>
             

            </div>

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />

            <div style="overflow-x: auto; ">
                <div class="container">

              

                     
                                <div class="Formulario">
                                    <div>
                                        <div>
                                            <div colspan="4"><b>Informacion del Equipo</b></div>
                                        </div>
                                        <div>
                                            <div>&nbsp;</div>


                                              <div class="row">
       <div class="col-sm-2">Ingeniero Asignado</div>
       <div class="col-sm-4">
           <asp:TextBox runat="server" ID="txtIngenieroAsignado" ReadOnly="True"></asp:TextBox>
       </div>
       
      
   </div>
                                            
                                              <div class="row">
       <div class="col-sm-2">Nuevo Ingeniero Asignado</div>
       <div class="col-sm-4">
           <asp:dropdownlist runat="server" ID="cmbIngenieros" ReadOnly="True"></asp:dropdownlist>
       </div>
       
   </div>



                                        </div>
                                    </div>
                                </div>
                           
                      
                    </div>
                </div>
               

            </div>
        </div>


</asp:Content>

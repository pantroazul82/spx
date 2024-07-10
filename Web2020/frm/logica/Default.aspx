<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web2020.frm.logica.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="Server">
    <link href="../../assets/css/default.css" rel="stylesheet">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <div class="screen-1">
        <div class="container">
            <div class="">
                <br />

            </div>
            <div class="row">
                <div class="content-container">
                    <div class="img-container">
                       <asp:Image ImageUrl="https://www.kuxan.co/img/logo%20supportech.png" CssClass="title-image"  viewbox="0 0 640 480" xml:space="preserve" runat="server" />
                    </div>

                    <div class="text-content-container">
                        <div class="title-container"> 
                            <h1 class="titulo">Bienvenido a SUPPORTECH</h1>
                        </div>
                 
                      
                        <p class="lead">
                            La Herramienta Indispensable para Optimizar su Taller de Mantenimiento. Mantenga el Control Total de su Departamento, Elimine Restricciones y 
                            Asegure una Planificación de Mantenimiento Efectiva. ¡Simplifique su Gestión y Aumente la Vida Útil de sus Equipos
                        </p>
                    </div>
                </div>
              <%--  <div class="col">
             
                    <div class="col invisible">Column</div>
                    <div class="col invisible">Column</div>

                    <asp:Image ImageUrl="https://www.kuxan.co/img/logo%20supportech.png" style="max-width: 100%; max-height: 100%"  Width="427px" Height="100px" viewbox="0 0 640 480" xml:space="preserve" runat="server" />
                </div>--%>
            </div>

        </div>

    </div>

</asp:Content>


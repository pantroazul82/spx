<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="frm_logica_Default" %>



<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1 {
            width: 100%;
        }
        .style2
        {
            text-align: left;
            font-family: "Myriad Pro";
            font-size: 17px;
            font-style: normal;
            color: #999999;
            text-indent: 20px;
            background-image: url('../../img/web/Fondo_tb_Caption.png');
            background-repeat: no-repeat;
            background-position: left top;
            padding-top: 22px;
            min-width: 400px;
            font-weight: bold;
        }
        .style3
        {
            width: 83px;
        }
        .style4
        {
            height: 11px;
        }
    .style5
    {
        text-align: justify;
    }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
    <div class="style2">Que es Supportech!</div>
    <div class="Formulario">
    
    
        <table class="style1">
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td rowspan="7">
                <asp:Image ID="imgLogo" runat="server" 
                        ImageUrl="~/img/frm/logo.jpg" AlternateText="Logo"
                 style="width: 300px; height: 250px"   />
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <img alt="calendario" src="../../img/frm/caja2.png" 
                        style="width: 96px; height: 124px" /></td>
                <td class="style5">
                    <b>Una Herramienta indispensable para su taller de mantenimiento
                    <br />
                    </b>
                    <br />
                    La implementación de nuevas tecnologías y el aumento en las actividades 
                    involucradas en un departamento técnico responsable de planear y controlar un 
                    programa de mantenimiento que asegure y aumente la vida útil de los equipos, 
                    nunca fue tan facil.</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <img alt="Reloj" src="../../img/frm/rpt.png" 
                        style="width: 71px; height: 71px" /></td>
                <td class="style5">
                    <b>Mantener y controlar la información<br />
                    </b>
                    <br />
                    Mantener y controlar la información del departamento de mantenimiento, 
                    eliminando las restricciones, asegurando confianza y veracidad en el proceso de 
                    planificación del mantenimiento, permitiendo realizar una trazabilidad efectiva 
                    y rápida de todas las acciones y eventos relacionados con cada uno de sus 
                    equipos.<br />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" rowspan="5" valign="top">
                    <img alt="" src="../../img/frm/stocks.png" style="width: 71px; height: 71px" /></td>
                <td rowspan="5" valign="top" class="style5">
                    <b>
                    <br />
                    Controle su Taller!</b><br />
                    <br />
                    SUPPORTECH es una herramienta que le facilitara el control del taller de 
                    mantenimiento brindando información precisa de los tiempos del personal a su 
                    cargo, puede consultar de una manera ágil y rápida el historial de mantenimiento 
                    de cada uno de sus equipos.</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td rowspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    </td>
                <td class="style4">
                    </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <img alt="Reloj" src="../../img/frm/publicidad.png" 
                        style="width: 300px; height: 85px" /></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
     </div>
</asp:Content>


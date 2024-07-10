<%@ page language="C#" autoeventwireup="true" CodeFile="frmFirmaN.aspx.cs" Inherits="frm_ordenServicio_frmFirmaN" %>

<%@ Register Assembly="SuperSignature" Namespace="SuperSignature" TagPrefix="cc1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Firma</title>
    <link href="../../App_Themes/blue/tablas.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            font-size: x-large;
            }
        .style2
        {
        }
        .style4
        {
        }
        .style5
        {
            width: 63px;
            height: 44px;
        }
        .style9
        {
            width: 89px;
        }
        .style12
        {
        }
        .style13
        {
            width: 164px;
        }
        .style14
        {
            width: 100px;
        }
    </style>  
</head>
<body>
       <script language="javascript" type="text/javascript">
function isNumberKey(evt)
      {
         var charCode = (evt.which) ? evt.which : event.keyCode
         if (charCode > 31 && (charCode < 48 || charCode > 57))
            return false;

         return true;
      }

           function Resize() {
               var ppi = dpi.get(false);
               ResizeSignature("<%= ctlSignatureN.uID %>", parseInt(window.innerWidth) - parseInt((40 * ppi / 100)), parseInt(window.innerHeight) - parseInt((55 * ppi / 100)));
      }

      var dpi = {
          v: 0,
          get: function (noCache) {
              if (noCache || dpi.v == 0) {
                  e = document.body.appendChild(document.createElement('DIV'));
                  e.style.width = '1in';
                  e.style.padding = '0';
                  dpi.v = e.offsetWidth;
                  e.parentNode.removeChild(e);
              }
              return dpi.v;
          }
      }

      $(document).ready(function () {

          window.addEventListener("resize", function () {
              ClearSignature("<%= ctlSignatureN.uID %>");
                Resize();
            }, false);


            $("<%= ctlSignatureN.uID %>_Container").css('margin', '0px');
            $('body').css('margin', '0px');
            $('body').css('height', '100%');
            $('body').css('width', '100%');
            $('#divRight').css('float', 'left');
            $('#divRight').css('margin', '0px');
            $('#divLeft').hide();
            $('#divBottom').delay(3000).fadeOut(500);

            dpi.get(true);

        });

        $(window).load(function () { Resize(); });


    </script>
    <form id="form1" runat="server">
     <asp:ScriptManager ID="ScriptManager1" runat="server" 
		EnablePageMethods="True" />
    <div style="position:absolute;top:0px;left:0px;z-index:10 !important;">   
         <cc1:MouseSignature ID="ctlSignatureN" SignZIndex="10" SignRefreshImage="~/web/img/spacer.gif" 
             SignStartMessage=" " SignSuccessMessage=" "
             SignPenColor="#000000"
              SignStatusBar="false" runat="server"  SignWidth="10" SignHeight="10" SignRequired="true" />
    </div>   

        <div style="z-index:150000000;position:absolute;top:0px;left:15px;background-color:whitesmoke;padding:2px 2px 2px 2px;font-size:12px;">
        <table  
            
            style=" width:auto; margin-top:0px !important;" >
    <tr>
        <td colspan="5">
             <strong> Firma Aceptacion Supportech</strong>
        <asp:Button runat="server" ID="btnLimpiar" OnClick="btnLimpiar_Click" Text="Limpiar firma" 
            CausesValidation="false"/>
      <asp:Button   ID="btnAceptarAceptacion" runat="server" 
           text="Guardar Firma y Cerrar" OnClick="btnAceptarAceptacion_Click" 
            ToolTip="Aceptar"  />
        <asp:Button   ID="btnCancelarAceptacion" runat="server" 
            ImageUrl="~/img/web/cancel.gif" OnClick="btnCancelarAceptacion_Click" 
            CausesValidation="false" Text="Cancelar"
            ToolTip="Cancelar"  />
           <asp:Label runat="server" ID="lblError" Text="" ForeColor="Red"></asp:Label>

        </td>
    </tr>
            <tr>
                <td  colspan="5" >
            Cantidad de Horas Efectivas <br />
              <asp:TextBox ID="txtcantidadDeHoras" runat="server" onkeypress="return isNumberKey(event)"  Enabled="false" Text="0"></asp:TextBox>
        </td>
            </tr>
 <tr>
            <td class="style4" colspan="5">
            Nombre del Usuario que recibe:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
            <asp:TextBox ID="txtUsuarioAceptacion" runat="server"
                Width="280px"></asp:TextBox>
       
                </td>
        </tr>
        <tr>
             
        
        
 
              <td>
                 Fecha de Llegada<br />
                 <telerik:RadDatePicker enabled="false"
        ID="calFechaLLegada" Runat="server">
                  <Calendar ID="Calendar2" runat="server">
                     <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy"> </FastNavigationSettings>
                  </Calendar>
                    </telerik:RadDatePicker>
            </td>
    <td class="style14">
             <asp:Label runat="server" Text="Hora de Llegada:" Width="125px"></asp:Label></td>
            
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
                <asp:DropDownList ID="cmbMinutosLlegada" runat="server" >
                </asp:DropDownList>
                <asp:DropDownList ID="cmbAmPmLlegada" runat="server" >
                    <asp:ListItem>AM</asp:ListItem>
                    <asp:ListItem>PM</asp:ListItem>
                </asp:DropDownList>
            </td>
              <td>
                 Fecha de Salida<br />
                 <telerik:RadDatePicker enabled="false"
        ID="calFechaDeSalida" Runat="server">
                  <Calendar ID="Calendar3" runat="server">
                     <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy"> </FastNavigationSettings>
                  </Calendar>
                    </telerik:RadDatePicker>
            </td>
        <td class="style9">
            <asp:Label runat="server" Text="Hora de Salida:" Width="100px"></asp:Label></td>
        <td class="style12" colspan="2">
            <asp:DropDownList ID="cmbHoraSalida" runat="server" >
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
            <asp:DropDownList ID="cmbMinutosSalida" runat="server" >
            </asp:DropDownList>
            <asp:DropDownList ID="cmbAmPmSalida" runat="server" >
                <asp:ListItem>AM</asp:ListItem>
                <asp:ListItem>PM</asp:ListItem>
            </asp:DropDownList>
            </td>
    </tr>
        
       

        </table>
            </div>
     
    </form>
</body>
</html>

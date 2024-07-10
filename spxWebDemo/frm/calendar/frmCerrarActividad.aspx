<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/masterCientifica.master" AutoEventWireup="true" CodeFile="frmCerrarActividad.aspx.cs" Inherits="frm_calendar_frmCerrarActividad" %>
<%@ Register Assembly="SuperSignature" Namespace="SuperSignature" TagPrefix="cc1" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <script language="javascript" type="text/javascript">

           function Resized() {
               var ppi = dpi.get(false);
               ResizeSignature("<%= ctlSignatureN.uID %>", parseInt(window.innerWidth) - parseInt((40 * ppi / 100)), parseInt(window.innerHeight) - parseInt((55 * ppi / 100)));
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
<br />

  
<br />
<div class="tab">Cerrar Actividad <asp:Label runat="server" ID="lblCodActividad"></asp:Label></div>
<div class="Formulario">

<table>
<tr>
<td>&nbsp;</td>
<td colspan="2">
    Fecha de Inicio
    <telerik:RadDateTimePicker ID="calInicio" Runat="server">
    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    Fecha de Fin
    <telerik:RadDateTimePicker ID="calFin" Runat="server" Enabled="False">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
    </td>
</tr>

<tr>
<td></td>
<td>
    Pendientes&nbsp;
    <asp:TextBox ID="txtPendiente" runat="server"></asp:TextBox>
    <telerik:RadButton ID="btnAgregarPendiente" runat="server" 
        onclick="btnAgregarPendiente_Click" Text="Agregar Pendiente">
    </telerik:RadButton>
    </td>
<td>&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td rowspan="2">
    <telerik:RadListBox ID="lstPendientes" runat="server" AllowDelete="True" 
        Width="305px">
<ButtonSettings TransferButtons="All"></ButtonSettings>

<WebServiceSettings>
<ODataSettings InitialContainerName=""></ODataSettings>
</WebServiceSettings>
    </telerik:RadListBox>
    <br />
    </td>
<td>&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>Contacto Cierre<asp:TextBox ID="txtContactoCierre" runat="server"></asp:TextBox>
    </td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>Observaciones Cierre</td>
<td>
    &nbsp;</td>
</tr>

<tr>
<td></td>
<td>
    <asp:TextBox ID="txtObservacionesAprobacion" runat="server" Height="129px" 
        TextMode="MultiLine" Width="443px"></asp:TextBox>
    </td>
<td rowspan="5">
		
       
&nbsp;
&nbsp;</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    Solucionado
     <asp:RadioButton ID="rdSi" runat="server" GroupName="d" Text="Si" />
    <asp:RadioButton ID="rdNo" runat="server" GroupName="d" Text="No" />
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    Razon?</td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    <asp:TextBox ID="txtRazon" runat="server" Height="129px" 
        TextMode="MultiLine" Width="443px"></asp:TextBox>
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
    
    &nbsp;<asp:Button runat="server" Text="Agregar/Modificar firma" 
       CausesValidation="false"  OnClick="btnIniciarFirma_Click" ID="btnIniciarFirma"  />

        
    </td>
</tr>

<tr>
<td>&nbsp;</td>
<td>
       
          
       <asp:UpdatePanel UpdateMode="Conditional" ID="pnlImgRef" runat="server">
       <ContentTemplate><asp:CheckBox ID="chkAdjuntarFirma" Enabled="false" runat="server" Text="Adjuntar Firma" />
       <br />
    <asp:Image ID="imgFirma" runat="server" Width="300px" />
         
       </ContentTemplate>
       </asp:UpdatePanel>
     
          
       
    </td>
<td>
    &nbsp;</td>
</tr>
<tr>
    <td></td>
    <td>
        <asp:Label runat="server" ID="lblError" ForeColor="Red" Text=""></asp:Label>
    </td>
    </tr>
<tr>
<td></td>
<td>
    <telerik:RadButton ID="btnCerrar" CausesValidation="false" runat="server" onclick="btnCerrar_Click" 
        Text="Cerrar">
    </telerik:RadButton>
    <telerik:RadButton ID="btnCancelar" CausesValidation="false" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar">
    </telerik:RadButton>
    </td>
<td>

    &nbsp;</td>
</tr>
</table>



</div>
 <asp:Label style=" display:none" ID="lblInvicible" runat="server"  /> 
<asp:Panel style="display:none;width:auto;height:auto;position:absolute;top:0px;" ID="pnlEmergente"
     Enabled="true" runat="server"     BackColor="LightGray">
     <asp:UpdatePanel runat="server" ID="pnlFirma"   >
     <ContentTemplate>
     
     
     <asp:Panel runat="server" ID="pnlGxuardar">   
        <asp:Label runat="server" ID="lblErrorFirma" Text="" ForeColor="Red"></asp:Label>

<asp:Button ID="btnLimpiarFirma" runat="server" 
     CausesValidation="false" OnClick="btnLimpiarFirma_Click" Text="Limpiar Firma" Visible="false" />
              
     <asp:Button runat="server" Text="Cancelar" OnClick="btnCancelarFirma_Click"
          CausesValidation="false" ID="btnCancelarFirma"  />
     <asp:Button runat="server" Text="Continuar" OnClick="btnContinuarFirma_Click" ID="btncontinuar"  />
              <label style="color:Red;" id="lblConfirmError"></label>
                 
              </asp:Panel>
        <cc1:MouseSignature ID="ctlSignatureN" SignZIndex="10" SignRefreshImage="~/web/img/spacer.gif" 
             SignStartMessage=" " SignSuccessMessage=" " 
             SignPenColor="#000000"
              SignStatusBar="false" runat="server"  SignWidth="10" SignHeight="10"  />
 

     </ContentTemplate>
     </asp:UpdatePanel>

     </asp:Panel>

 <cca:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server"
     PopupControlID="pnlEmergente" RepositionMode="RepositionOnWindowResize" X="0" Y="0"
        TargetControlID="lblInvicible"
             BackgroundCssClass="modalBackground"
             DropShadow="true"
              Enabled="true">
</cca:ModalPopupExtender>   

</asp:Content>


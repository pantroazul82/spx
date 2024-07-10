<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmCrearOrden.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmCrearOrden" %>

<%@ Register src="../../controles/controlSerial.ascx" tagname="controlSerial" tagprefix="uc1" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" Runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">


        function textCounter(field, countfield, maxlimit) {
            if (field.value.length > maxlimit)
                field.value = field.value.substring(0, maxlimit);
            else
                countfield.value = maxlimit - field.value.length;
        }
    </script>
    <style type="text/css">
        @import url('https://fonts.googleapis.com/css2?family=Poppins&display=swap');
        @import url('https://fonts.googleapis.com/css2?family=Dosis:wght@200&family=Poppins&display=swap');

        * {
            font-family: "Poppins";
        }

        .block-web{
            padding:0 20px 20px 20px !important;
            height: 100%;
        }

        h2.titulo {
            font-family: "Dosis" !important;
            margin-left:20px;
            font-size: 2rem;
            font-weight: bold;
            color: #4FBDDB;

        }
        .formulario {
            width:100%;
            
        }

      

        .Formulario_tabla{
            padding-left: 15px;
        }

         .Formulario_tabla input[type=text]{
            min-width: 30px !important;
        }.Formulario_tabla input[select=text]{
            min-width: 30px !important;
        }

        .frmSerial {
         margin-top: 20px;
         font-size: 1.4rem;
         display:flex;
        }

        .frmSerial p{
         width: auto;
         font-family: "Dosis" !important;
         text-align:left;
         font-weight: bold;
         color: #424a4d;
        }

        .frmError {
        margin-bottom: 20px; /* Espacio entre los elementos */
        color: #CC0000; /* Color del texto de error */
        }

         .frmBtn {
        margin-bottom: 20px; /* Espacio entre los elementos */
         }

          #ContentPlaceHolder1_btnPaso2{
            background-color: #4CAF50;
            border: none;
            color: white;
            padding: 8px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 1.1rem;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 10px;
            transition: background-color 0.3s;
          }

            #ContentPlaceHolder1_btnPaso2:hover{
                background-color: #45a049;
            }


        .style2
        {
            width: 172px;
        }
        .style3
        {
            width: 144px;
        }
        .style4
        {
        }
        .style5
        {
            padding:20px;
            font-size: medium;
        }
        .style6
        {
            width: 237px;
        }
        .style7
        {
            width: 403px;
        }

        .page-content{
            width:unset;
        }

    
        #ContentPlaceHolder1_controlSerial2_pnlEmergente{
            width:600px !important;
        }

        #ContentPlaceHolder1_controlSerial2_Panel1_ModalPopupExtender_foregroundElement{
            width:100%;
            height:100%;
            left: 0 !important;
        }

        #ContentPlaceHolder1_controlSerial2_pnlContenido{
            width:600px !important;
        }
        #baraSuperior{
            width:100% !important;
        }

        #ContentPlaceHolder1_controlSerial2_btnCancelarPopUp{
            margin-left:5px !important;
        }

        #ContentPlaceHolder1_btnAtrasPaso{

             background-color: #d9534f;
            border: none;
            color: white;
            text-align: center;
            text-decoration: none;
            display: inline-block;  
            font-size: 1.1rem;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 10px;
            transition: background-color 0.3s;

        }

         #ContentPlaceHolder1_btnAtrasPaso:hover{
                background-color: #d43f3a;
         }

         #ContentPlaceHolder1_cmbPrioridad{
             width: 30% !important;
         }

        #ContentPlaceHolder1_rdExterna{
            position:relative;
        }


        #ContentPlaceHolder1_rdInterna{
            position:relative;
        }

        #ContentPlaceHolder1_pnlDos > div {
            padding-left:30px;

        }

        #ContentPlaceHolder1_pnlDos div:nth-child(5){
            margin-bottom: 0px;
        }

         #ContentPlaceHolder1_pnlDos div:nth-child(11){
            margin-bottom: 0px;
        }

           
           #ctl00_ContentPlaceHolder1_calinicio_wrapper{
            width:35% !important;
            margin-top: -30px;
           }

          #ContentPlaceHolder1_pnlDos div:nth-child(12){
            margin-bottom: 0px;
            }

       
           #ctl00_ContentPlaceHolder1_calFin_wrapper{
            width:35% !important;
            margin-top: -30px;
           }

           #ContentPlaceHolder1_pnlDos div:nth-child(13){
             width: 100%;
             height: 100px;
            }

            #ContentPlaceHolder1_pnlDos div:nth-child(13) > *:first-child {
            height: 20px !important;
            }

            #ContentPlaceHolder1_txtObservacionesIniciales{
             width: 80% !important;
             height: 100% !important;
            }

            #ContentPlaceHolder1_pnlDos div:nth-child(14){
                margin-top: 50px;
            }

        #ContentPlaceHolder1_btnGuardar{
          
             background-color: #5cb85c;
            border: none;
            color: white;
            padding:7px;
            text-align: center;
            text-decoration: none;
            display: inline-block;  
            font-size: 1.1rem;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 10px;
            transition: background-color 0.3s;
        }

        
         #ContentPlaceHolder1_btnGuardar:hover{
                background-color: #4cae4c;
         }

         #ContentPlaceHolder1_btnGuardarYCrearOtra{
           background-color:#17a2b8;
            border: none;
            color: white;
            padding:7px;
            text-align: center;
            text-decoration: none;
            display: inline-block;  
            font-size: 1.1rem;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 10px;
            transition: background-color 0.3s;
         }

         #ContentPlaceHolder1_btnGuardarYCrearOtra:hover{
                background-color: #224f77;
         }

         #ContentPlaceHolder1_lnkVerHojaVida img {
        width: 30px; 
        height: 30px;
        margin-right: 5px; 
        }
        

        .tab{
            padding:10px;
        }
     
        td{
            padding:5px !important;
        }

        label{
            padding-left:5px;
        }
        .sr-only {
    position: absolute;
    width: 1px;
    height: 1px;
    padding: 0;
    margin: -1px;
    overflow: hidden;
    clip: rect(0, 0, 0, 0);
    border: 0;
}
 
        @media (max-width: 767px) {
         .block-web{
            width:100%   
         }

        #ContentPlaceHolder1_cmbPrioridad{
             width: 40% !important;
         }

        #ContentPlaceHolder1_cmbEntradas{
            width: 40% !important;
        }
         #ctl00_ContentPlaceHolder1_calinicio_wrapper { 
            width:40% !important;
        }

           #ctl00_ContentPlaceHolder1_calFin_wrapper{
            width:40% !important;
            }

        
            #ContentPlaceHolder1_txtObservacionesIniciales{
             width:50% !important;
            }

        }

        @media (max-width: 600px) {

             #ContentPlaceHolder1_cmbPrioridad{
             width: 80% !important;
         }

        #ContentPlaceHolder1_cmbEntradas{
            width: 80% !important;
        }
         #ctl00_ContentPlaceHolder1_calinicio_wrapper { 
            width:80% !important;
        }

           #ctl00_ContentPlaceHolder1_calFin_wrapper{
            width:80% !important;
            }

        
            #ContentPlaceHolder1_txtObservacionesIniciales{
             width:100% !important;
            }
        }


        @media (max-width: 360px) {

                #ctl00_ContentPlaceHolder1_calinicio_wrapper { 
            width:90% !important;
        }

           #ctl00_ContentPlaceHolder1_calFin_wrapper{
            width:90% !important;
            }

        }


      
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <div class="col">
                <h2 class="titulo">Creacion de Orden de servicio</h2>

            </div>
          
<div class="Formulario"> 

<asp:Panel runat="server" ID="PanelUno" Visible="true">
    <div class="frmSerial">
        <p>Añadir Serial: </p>
        <uc1:controlSerial ID="controlSerial2" runat="server" />
    </div>

     <div class="frmError">
        <asp:Label ID="lblErrorPAsoUno" runat="server" ForeColor="#CC0000"></asp:Label>
    </div>

    <div class="frmBtn">
           <asp:Button ID="btnPaso2" runat="server" onclick="btnPaso2_Click" 
                Text="Siguiente" />
    </div>
</asp:Panel>

<asp:Panel runat="server" ID="pnlDos" Visible="false">

        <div class="row">
   <asp:Button ID="btnAtrasPaso" runat="server" Height="24px" 
        onclick="btnAtrasPaso_Click" Text="Atras" Width="76px" />
         </div>
        <div class="row">
            <strong>Serial</strong>
            <asp:TextBox runat="server" id="txtSerial" ReadOnly="true"></asp:TextBox>
             <asp:HyperLink ID="lnkVerHojaVida" runat="server" Target="_blank">
                 <img src="../../img/frm/logos.png" alt="Icono" />
                 <span class="sr-only">Ver Hoja de Vida</span></asp:HyperLink>
         </div>
        <div class="row">
        <asp:RadioButton ID="rdExterna" runat="server" AutoPostBack="True" 
                GroupName="int" oncheckedchanged="rdExterna_CheckedChanged" Text="Externa" />
            &nbsp;
            <asp:RadioButton ID="rdInterna" runat="server" AutoPostBack="True" 
                GroupName="int" oncheckedchanged="rdInterna_CheckedChanged" Text="Interna" />
         </div>
        <div class="row">
            <p>Prioridad</p>
            <asp:DropDownList ID="cmbPrioridad" runat="server" Width="300px">
            </asp:DropDownList>
         </div>
        <div class="row">
            <p> Entrada </p>
   <asp:Label ID="lblEntrada" runat="server" Text="" 
                Visible="False"></asp:Label>
            <asp:DropDownList ID="cmbEntradas" runat="server" Visible="False">
            </asp:DropDownList> 
         </div>
        <div class="row">
      <asp:RadioButton ID="rdPorContratoNo" runat="server" AutoPostBack="True" 
                Checked="True" GroupName="porContrato" 
                oncheckedchanged="rdPorContratoNo_CheckedChanged" Text="Fuera de Contrato" Visible="False" />
            <asp:RadioButton ID="rdPorContrato" runat="server" AutoPostBack="True" 
                GroupName="porContrato" oncheckedchanged="rdPorContrato_CheckedChanged" 
                Text="Por Contrato" Visible="False" />
         </div>
        <div class="row">
   <asp:Label ID="lblNumeroContrato" runat="server" Text="Numero Contrato" 
                Visible="False"></asp:Label>
            <asp:DropDownList ID="cmbContrato" runat="server" Visible="False" Width="300px">
            </asp:DropDownList>
         </div>
        <div class="row">
    <p>Tipo de Servicio</p>
                <asp:DropDownList ID="cmbTipoServicio" runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="nombretipoServicio" 
        DataValueField="codTipoServicio">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="Web2020.cls.ds2020TableAdapters.TipoServicioTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_codTipoServicio" Type="String" />
            <asp:Parameter Name="Original_nombretipoServicio" Type="String" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_devuelveTaller" Type="Boolean" />
            <asp:Parameter Name="Original_validoContrato" Type="Boolean" />
            <asp:Parameter Name="Original_preventivo" Type="Boolean" />
            <asp:Parameter Name="Original_correctivo" Type="Boolean" />
            <asp:Parameter Name="Original_devuelveEntrada" Type="Boolean" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="codTipoServicio" Type="String" />
            <asp:Parameter Name="nombretipoServicio" Type="String" />
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="devuelveTaller" Type="Boolean" />
            <asp:Parameter Name="validoContrato" Type="Boolean" />
            <asp:Parameter Name="preventivo" Type="Boolean" />
            <asp:Parameter Name="correctivo" Type="Boolean" />
            <asp:Parameter Name="devuelveEntrada" Type="Boolean" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nombretipoServicio" Type="String" />
            <asp:Parameter Name="descripcion" Type="String" />
            <asp:Parameter Name="devuelveTaller" Type="Boolean" />
            <asp:Parameter Name="validoContrato" Type="Boolean" />
            <asp:Parameter Name="preventivo" Type="Boolean" />
            <asp:Parameter Name="correctivo" Type="Boolean" />
            <asp:Parameter Name="devuelveEntrada" Type="Boolean" />
            <asp:Parameter Name="Original_codTipoServicio" Type="String" />
            <asp:Parameter Name="Original_nombretipoServicio" Type="String" />
            <asp:Parameter Name="Original_descripcion" Type="String" />
            <asp:Parameter Name="Original_devuelveTaller" Type="Boolean" />
            <asp:Parameter Name="Original_validoContrato" Type="Boolean" />
            <asp:Parameter Name="Original_preventivo" Type="Boolean" />
            <asp:Parameter Name="Original_correctivo" Type="Boolean" />
            <asp:Parameter Name="Original_devuelveEntrada" Type="Boolean" />
        </UpdateParameters>
    </asp:ObjectDataSource>
         </div>
        <div class="row">
    <p>Asesor Comercial</p>
             <asp:DropDownList ID="cmbAsesoresComerciales" runat="server" 
        DataSourceID="ObjectDataSourceAsesores" DataTextField="NombreAsesor" 
        DataValueField="codAsesor">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="ObjectDataSourceAsesores" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="Web2020.cls.ds2020TableAdapters.asesoresComercialesTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_codAsesor" Type="Int32" />
            <asp:Parameter Name="Original_NombreAsesor" Type="String" />
            <asp:Parameter Name="Original_correo" Type="String" />
            <asp:Parameter Name="Original_telefono" Type="String" />
            <asp:Parameter Name="Original_celular" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="codAsesor" Type="Int32" />
            <asp:Parameter Name="NombreAsesor" Type="String" />
            <asp:Parameter Name="correo" Type="String" />
            <asp:Parameter Name="telefono" Type="String" />
            <asp:Parameter Name="celular" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="NombreAsesor" Type="String" />
            <asp:Parameter Name="correo" Type="String" />
            <asp:Parameter Name="telefono" Type="String" />
            <asp:Parameter Name="celular" Type="String" />
            <asp:Parameter Name="Original_codAsesor" Type="Int32" />
            <asp:Parameter Name="Original_NombreAsesor" Type="String" />
            <asp:Parameter Name="Original_correo" Type="String" />
            <asp:Parameter Name="Original_telefono" Type="String" />
            <asp:Parameter Name="Original_celular" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
         </div>
        <div class="row">
    <p>Responsable</p>
                <asp:DropDownList ID="cmbResponsable" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="nombre" 
        DataValueField="cod_usuario">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
        
        
        SelectCommand="select rtrim(login) cod_usuario,nombre from usuario where es_bloqueado =0  or es_bloqueado is null order by nombre">
    </asp:SqlDataSource>
         </div>
        <div class="row">
            <p> Inicio</p>
   <telerik:RadDateTimePicker ID="calinicio" Runat="server"  DateInput-DateFormat="dd/MM/yyyy HH:mm tt">
    <Calendar ID="Calendar1" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
         </div>
        <div class="row">
    <p> Fin</p>
    <telerik:RadDateTimePicker ID="calFin" Runat="server" DateInput-DateFormat="dd/MM/yyyy HH:mm tt">
    <Calendar ID="Calendar2" runat="server">
    <FastNavigationSettings EnableTodayButtonSelection="True" 
        TodayButtonCaption="Hoy">
    </FastNavigationSettings>
</Calendar>
    </telerik:RadDateTimePicker>
         </div>
        <div class="row">
     <p>Observaciones Iniciales</p>

    <asp:TextBox ID="txtObservacionesIniciales" runat="server" Height="58px" 
        TextMode="MultiLine" Width="505px" MaxLength="1490"
        onkeyup='textCounter(this, this.form.remLen, 1490);'
                onkeydown="textCounter(this, this.form.remLen, 1490);"
        ></asp:TextBox>
         </div>
        <div class="row">
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
         </div>
        <div class="row">
   
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
        onclick="btnGuardar_Click" />
    <asp:Button ID="btnGuardarYCrearOtra" runat="server" 
        Text="Guardar y Crear Otra" onclick="btnGuardarYCrearOtra_Click" />
         </div>
</asp:Panel>

</div>
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmCrearEquipo.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmCrearEquipo" %>

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

 

           
           #ctl00_ContentPlaceHolder1_calinicio_wrapper{
            width:35% !important;
            margin-top: -30px;
           }

  
       
           #ctl00_ContentPlaceHolder1_calFin_wrapper{
            width:35% !important;
            margin-top: -30px;
           }

      
            #ContentPlaceHolder1_txtObservacionesIniciales{
             width: 80% !important;
             height: 100% !important;
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
 
       #ctl00_ContentPlaceHolder1_RadDateTimePicker1_wrapper{
           width: 35% !important;
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


        #ctl00_ContentPlaceHolder1_RadDateTimePicker1_wrapper{
            width: auto !important;
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
                <h2 class="titulo">Creacion de Equipos</h2>

            </div>
          
<div class="Formulario"> 

<%--<asp:Panel runat="server" ID="PanelUno" Visible="true">
    <div class="frmEquipo">
        <p>Crear Nuevo Equipo </p>
    </div>

    <div class="frmBtn">
           <asp:Button ID="btnPaso2" runat="server" onclick="btnPaso2_Click" 
                Text="Siguiente" />
    </div>
</asp:Panel>--%>

<asp:Panel runat="server" ID="pnlDos" Visible="true">

<%--        <div class="row">
   <asp:Button ID="btnAtrasPaso" runat="server" Height="24px" 
        onclick="btnAtrasPaso_Click" Text="Atras" Width="76px" />
         </div>--%>
             <div class="frmError">
            <asp:Label ID="lblErrores" runat="server" ForeColor="#CC0000"></asp:Label>
        </div>
               <div class="row">
               <p>Serial</p>
               <asp:TextBox runat="server" id="txtSerial1"></asp:TextBox>
            </div>

       <div class="frmError">
      <asp:Label ID="lblErrorSerial" runat="server" ForeColor="#CC0000"></asp:Label>
  </div>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>
          <div class="row">
        <p>Fabricante</p>
        <asp:DropDownList ID="cmbFabricante" runat="server" 
       DataSourceID="SqlDataSourceFabricante" DataTextField="nombre_fabricante" 
       DataValueField="codFabricante"  AutoPostBack="True">
   </asp:DropDownList>
   <asp:SqlDataSource ID="SqlDataSourceFabricante" runat="server" 
       ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
       SelectCommand="SELECT codFabricante,nombre_fabricante FROM fabricante ORDER BY nombre_fabricante">
   </asp:SqlDataSource>
                   <div class="frmError">
    <asp:Label ID="lblErrorFabricante" runat="server" ForeColor="#CC0000"></asp:Label>
</div>
 </div>

   <div class="row">
         <p>Modelo</p>
       <asp:DropDownList ID="cmbModelo" runat="server" 
       DataSourceID="SqlDataSourceModelo" DataTextField="NombreModelo" 
       DataValueField="codModelo">
   </asp:DropDownList>
   <asp:SqlDataSource ID="SqlDataSourceModelo" runat="server" 
       ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
       SelectCommand="SELECT codModelo,NombreModelo FROM Modelos WHERE codFabricante=@codF ORDER BY NombreModelo">
       <SelectParameters>
           <asp:ControlParameter ControlID="cmbFabricante" Name="codF" PropertyName="SelectedValue" Type="String" />
       </SelectParameters>
   </asp:SqlDataSource>
            <div class="frmError">
    <asp:Label ID="lblErrorModelo" runat="server" ForeColor="#CC0000"></asp:Label>
</div>
</div>
    </ContentTemplate>
</asp:UpdatePanel>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="row">
            <p>Cliente</p>
            <asp:DropDownList ID="cmbClientes" runat="server" 
                DataSourceID="SqlDataSourceClientes" DataTextField="nombreCliente" 
                DataValueField="nitCliente" AutoPostBack="True">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSourceClientes" runat="server" 
                ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                SelectCommand="SELECT nitCliente, nombreCliente FROM clientes ORDER BY nombreCliente">
            </asp:SqlDataSource>
                        <div class="frmError">
    <asp:Label ID="lblErrorCliente" runat="server" ForeColor="#CC0000"></asp:Label>
</div>
        </div>

        <div class="row">
            <p>Sucursal</p>
            <asp:DropDownList ID="cmbSucursal" runat="server" 
                DataSourceID="SqlDataSourceSucursalCliente" DataTextField="nombreSucursal" 
                DataValueField="codSucursal">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSourceSucursalCliente" runat="server" 
                ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                SelectCommand="SELECT codSucursal, nombreSucursal FROM sucursalCliente WHERE nitCliente = @codSuc ORDER BY nombreSucursal">
                <SelectParameters>
                    <asp:ControlParameter ControlID="cmbClientes" Name="codSuc" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

<div class="frmError">
    <asp:Label ID="lblSucursal" runat="server" ForeColor="#CC0000"></asp:Label>
</div>

        </div>
    </ContentTemplate>
</asp:UpdatePanel>

         <div class="row">
                   <p>Modalidad</p>
                 <asp:DropDownList ID="cmbModalidad" runat="server" 
                 DataSourceID="SqlDataSourceModalidad" DataTextField="nombreModalidadEquipo" 
                 DataValueField="codModalidadEquipo">
             </asp:DropDownList>
             <asp:SqlDataSource ID="SqlDataSourceModalidad" runat="server" 
                 ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
                 SelectCommand="select codModalidadEquipo,nombreModalidadEquipo  from ModalidadEquipo order by nombreModalidadEquipo">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="cmbFabricante" Name="codF" PropertyName="SelectedValue" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
             <div class="frmError">
    <asp:Label ID="lblTipoModalidad" runat="server" ForeColor="#CC0000"></asp:Label>
</div>
          </div>

       <div class="row">
         <p>Tipo de propiedad</p>
       <asp:DropDownList ID="cmbTipoPropiedad" runat="server" 
       DataSourceID="SqlDataSourceTipoPropiedad" DataTextField="nombreTipoPropiedad" 
       DataValueField="codTipoPropiedad">
   </asp:DropDownList>
   <asp:SqlDataSource ID="SqlDataSourceTipoPropiedad" runat="server" 
       ConnectionString="<%$ ConnectionStrings:spxConnectionString %>" 
       SelectCommand="select codTipoPropiedad,nombreTipoPropiedad  from tipoPropiedad order by nombreTipoPropiedad">
   </asp:SqlDataSource>
                       <div class="frmError">
    <asp:Label ID="lblTipoPropiedad" runat="server" ForeColor="#CC0000"></asp:Label>
</div>
</div>

         


      <div class="row">
     <p>Observaciones</p>

    <asp:TextBox ID="TextBoxObservaciones" runat="server" Height="58px" 
        TextMode="MultiLine" MaxLength="1490"
        onkeyup='textCounter(this, this.form.remLen, 1490);'
                onkeydown="textCounter(this, this.form.remLen, 1490);"
        ></asp:TextBox>
         </div>
      
         

    <div class="row"> 
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar"/>

       <asp:Button ID="btnGuardarYCrearOtra" runat="server"  OnClick="btnGuardarYCrearOtra_Click"
           Text="Guardar y Crear Otra"  />

    </div>
         
   
 
   
</asp:Panel>

    </div>
</asp:Content>
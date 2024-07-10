 <%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmAgregarActividad.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmAgregarActividad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headerPlaceHolder" runat="Server">
    <link href="../../App_Themes/blue/default.css" rel="stylesheet" type="text/css" />
    <link href="../../assets/css/listado.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="h2">Actividad de la Orden de Servicio</div>
    <div class="formulario">
        <div class="screen-1">
            <div class="container">
                <div class="row">
                    <div class="col-sm-4">
                        <asp:Label ID="Label1" runat="server"
                            Text="Ingrese la descripcion de la actividad realizada"></asp:Label>
                    </div>
                </div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <div class="row confidencialContainer" style="display: table-caption;">
                <div class="col-sm-1">
                    <asp:CheckBox ID="chkConfidencial" runat="server" />
                </div>
                <div class="col-sm-3">
                    <asp:Label Text="Confidencial" runat="server" />
                </div>
            </div>

                <br />
                <div class="form-group">
                    
                    <asp:TextBox CssClass="form-control" style="max-width:480px" ID="txtObservaciones" runat="server" Height="168px"
                        TextMode="MultiLine" ></asp:TextBox>
                    <br />
                </div>
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <br />
                <div class="row btnControlContainer">
                    <div class="col-lg-2">
                        <asp:Button ID="btnGuardarCrearOtra" CssClass="btn btn-success" runat="server" OnClick="btnGuardarOtra_Click"
                            Text="Guardar y Crear Otra" />
                    </div>
                    <div class="col-lg-1">
                        <asp:Button CssClass="btn btn-primary" ID="btnGuardar" runat="server" OnClick="btnGuardar_Click"
                            Text="Guardar" />
                    </div>
                    <div class="col-lg-1">
                        <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" OnClick="btnCancelar_Click"
                            Text="Cancelar" />
                    </div>
    </div>


    </div>
</div>
</div>
</asp:Content>

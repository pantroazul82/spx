<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="Web2020.frm.logica.frmLogin" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Supportech X - Software de Mantenimiento</title>

    <!-- Bootstrap -->
    <link href="../../assets/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300' rel='stylesheet' type='text/css'>
    <link href="../../assets/css/font-awesome.min.css" rel="stylesheet">
    <link href="../../assets/css/style.css" rel="stylesheet">
    <link href="../../assets/css/login.css" rel="stylesheet">
    <link href="../../assets/css/style-responsive.css" rel="stylesheet">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
<form id="form2" runat="server" class="form-horizontal" style="margin-bottom: 0px !important;">
    <div class="screen-1">
        <br />
         
        <div class="img-container">
        <asp:image imageurl="../../img/logo_supportech.png" viewbox="0 0 640 480" xml:space="preserve" runat="server" />
        </div>

            <div class="email">
                <asp:Label for="email" >Nombre de Usuario:</asp:Label>
                <div class="sec-2">
                    <ion-icon name="mail-outline"></ion-icon>
                    <asp:TextBox ID="txtUsuario" runat="server" name="email" placeholder="Ingrese nombre de usuario" style="  width:-webkit-fill-available;"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtUsuario" ID="RequiredFieldValidator1" runat="server" ErrorMessage="El Nombre de Usuario es Obligatorio!"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="password">
                <asp:Label for="password" style="font-weight: bold;" >Contraseña:</asp:Label>
                <div class="sec-2">
                    <ion-icon name="lock-closed-outline"></ion-icon>
                    <asp:TextBox ID="txtPass" clas="pas" runat="server" type="password" name="password" style="  width:-webkit-fill-available;" placeholder="***********" />

                    <ion-icon class="show-hide" name="eye-outline"></ion-icon>
                </div>
            </div>
            <asp:Button ID="btnIngresar" class="login" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
            <asp:Label ID="lblEnviadoDesde" runat="server" Visible="False"></asp:Label>
            <div class="footer" style="justify-content:space-evenly;">
                <asp:Label ID="lblError" runat="server" BackColor="#FFEBE8"
                           BorderColor="#DD3C10" BorderStyle="Solid" BorderWidth="1px" Height="50px" 
                           Visible="False"  Style="height: auto; width: 90%; font-size: 15px; border-radius: 10px; padding: 6px; "></asp:Label>
            </div>
        </div>
</form>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="../../js/jquery-2.0.2.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="../../bootstrap/js/bootstrap.min.js"></script>
    <script src="../../js/accordion.js"></script>
    <script src="../../js/common-script.js"></script>
    <script src="../../js/jquery.nicescroll.js"></script>
</body>
</html>












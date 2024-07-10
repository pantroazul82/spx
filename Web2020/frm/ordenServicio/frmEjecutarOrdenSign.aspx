<%@ Page Title="" Language="C#" MasterPageFile="~/frm/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="frmEjecutarOrdenSign.aspx.cs" Inherits="Web2020.frm.ordenServicio.frmEjecutarOrdenSign" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cca" %>
<%@ Register Src="../../controles/controlRepuestos.ascx" TagName="controlRepuestos" TagPrefix="uc1" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<%@ Register Src="../../controles/controlSerial.ascx" TagName="controlSerial" TagPrefix="uc2" %>



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
            var signaturePad = new SignaturePad(document.getElementById('signature-pad'));

            $('#click').click(function () {
                var data = signaturePad.toDataURL('image/png');
                $('#output').val(data);

                //$("#sign_prev").show();
                $("#sign_prev").attr("src", data);
                // Open image in the browser
                //window.open(data);
            });

            $('#btnLimpiarFirma').click(function () {
                console.log('Limpiando')
                signaturePad.clear();
            })

            $('#btnAceptarAceptacion').click(function () {
                alert('Guardar');
                var data = signaturePad.toDataURL('image/png');
                $('#output').val(data);
                $('#FirmaValida').val(signaturePad.isEmpty())
                return;
            })
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
                    <asp:Button ID="btnCerrarOrden" class="btn btn-danger" runat="server" Text="Cerrar Orden"
                        OnClick="btnCerrarOrden_Click" OnClientClick="return confirm('Esta seguro de Cerrar la orden de Servicio?');" />
                </div>
                <div class="col col-sm-2">
                    <asp:Button ID="btnReabrirOrden" runat="server" Text="Reabrir Orden"
                        OnClick="btnReabrirOrden_Click" CssClass="btn btn-success" OnClientClick="return confirm('Esta seguro de reabrir la orden de Servicio?');" />

                </div>
                <div class="col col-sm-2">
                    <asp:HyperLink class="btn btn-info" runat="server" Target="_blank" ID="lnkImprimir" Text="Imprimir" NavigateUrl="" ImageUrl=""></asp:HyperLink>

                </div>

            </div>

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />

            <div style="overflow-x: auto; ">
                <div class="container">

                    <div class="row">

                        <telerik:RadTabStrip ID="RadTabStrip1" runat="server" Width="900px"
                            MultiPageID="RadMultiPage1" SelectedIndex="0">
                            <Tabs>

                                <telerik:RadTab runat="server" Text="Ejecucion" Selected="True">
                                </telerik:RadTab>
                                <telerik:RadTab class="nav-item" runat="server" Text="General">
                                </telerik:RadTab>
                                <telerik:RadTab class="nav-item" runat="server" Text="Archivos">
                                </telerik:RadTab>
                                <telerik:RadTab class="nav-item" runat="server" Text="Informacion de Cierre">
                                </telerik:RadTab>
                                <telerik:RadTab class="nav-item" runat="server" Text="Metrologia">
                                </telerik:RadTab>
                            </Tabs>
                        </telerik:RadTabStrip>

                    </div>
                    <div class="row formContentContainer">
                        <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0">

                            <telerik:RadPageView ID="RadPageView1" runat="server">
                                <br />
                                <div class="Formulario">



                                    <div>
                                        <div>&nbsp;</div>

                                    </div>

                                    <div>
                                        <div class="col-sm-6"><b>Actividades Realizadas&nbsp;&nbsp;&nbsp;&nbsp; </b></div>
                                        <div class="col-sm-6">
                                            <asp:Button ID="btnEditarActividadesRealizadas" runat="server"
                                                OnClick="btnEditarActividadesRealizadas_Click"
                                                ToolTip="Editar" Text="editar" class="btn btn-success"></asp:Button>
                                            <asp:ImageButton ID="btnAceptarActividadesREalizadas" runat="server"
                                                ImageUrl="~/img/web/ok.gif" OnClick="btnAceptarActividadesREalizadas_Click"
                                                ToolTip="Aceptar" Visible="False" Width="40px" class="btn btn-success" />
                                            <asp:ImageButton ID="btnCancelarActividadesRealizadas" runat="server"
                                                ImageUrl="~/img/web/cancel.gif"
                                                OnClick="btnCancelarActividadesRealizadas_Click"
                                                ToolTip="Cancelar" Visible="False" Width="40px" class="btn btn-danger" />
                                        </div>
                                    </div>


                                    <div>
                                        <div>&nbsp;</div>

                                    </div>




                                    <div class="row dateContainer">
                                        <div class="col-sm-5 dateText">
                                            <p>Ultimo Mantenimiento por parte del usuario</p> 
                                        </div>

                                        <telerik:RadDatePicker Enabled="false"
                                            ID="calultimoMantenimientoxUsuario" CssClass="col-sm-3 d-flex justify-content-center align-items-center" runat="server">
                                            <Calendar ID="Calendar1" runat="server">
                                                <FastNavigationSettings EnableTodayButtonSelection="True" TodayButtonCaption="Hoy">
                                                </FastNavigationSettings>
                                            </Calendar>
                                        </telerik:RadDatePicker>

                                    </div>

                                    <br />
                                    <div class="row mantenimientoMaquina">
                                        <div class="col-sm-5">
                                            Mantenimiento de la maquina según lo indicado
                                        </div>

                                        <div class="col-sm-1">

                                            <asp:RadioButton runat="server" Enabled="False" class="form-check-input" ID="rdManteimientoIndicadoSi" GroupName="manteIndi" />
                                            <asp:Label class="form-check-label" for="flexRadioDefault2" Style="margin: 15px;">
                                                    Sí
                                            </asp:Label>
                                        </div>
                                        <div class="col-sm-1">
                                            <asp:RadioButton runat="server" class="form-check-input" Enabled="False" ID="rdManteimientoIndicadoNo" GroupName="manteIndi" />
                                            <asp:Label class="form-check-label" for="flexRadioDefault2" Style="margin: 15px;">
                                                        No
                                            </asp:Label>

                                        </div>


                                    </div>


                                    <div class="row mantenimientoEquipo">
                                        <div class="col-sm-5">
                                            Equipo Adecuado despues del mantenimiento
                                        </div>
                                        <div class="col-sm-1">
                                            <asp:RadioButton ID="rdAdecuadoSi" class="form-check-input" Enabled="false" runat="server" GroupName="manteadecuado" Text="" />
                                            <asp:Label class="form-check-label" for="flexRadioDefault2" Style="margin: 15px;">
                                                    Sí
                                            </asp:Label>
                                        </div>
                                        <div class="col-sm-1">
                                            <asp:RadioButton ID="rdAdecuadoNo" Enabled="false" runat="server" GroupName="manteadecuado" />
                                            <asp:Label class="form-check-label" for="flexRadioDefault2" Style="margin: 15px;">
                                                No
                                            </asp:Label>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-sm-5">
                                            Fallas Reportadas

                                        </div>


                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtFallasReportadas" runat="server" class="form-control" Height="90px" TextMode="MultiLine"
                                                ReadOnly="True" Style="max-width: 100%;"></asp:TextBox>
                                        </div>

                                    </div>


                                    <div>
                                        <div>&nbsp;</div>
                                    </div>

                                    <div class="row">
                                        <div class="col-sm-5">
                                            Observaciones Ingeniero
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox runat="server" class="form-control" ID="txtObservacionesIngeniero" TextMode="MultiLine"
                                                ReadOnly="True" Style="max-width: 100%;"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div>
                                        <div>&nbsp;</div>
                                    </div>

                                    <div class="row">
                                        <div class="col-sm-5">
                                            Diagnostico 
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtDiagnostico" class="form-control" runat="server" Height="89px" TextMode="MultiLine" ReadOnly="True"
                                                Style="max-width: 100%;"></asp:TextBox>
                                            &nbsp;</>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-5">
                                            <b>Repuestos Utilizados</b>
                                        </div>
                                        <div class="col-sm-3">

                                            <uc1:controlRepuestos ID="controlRepuestos1" runat="server" />

                                            <asp:Button ID="btnGuardarRepuestos" class="btn btn-secondary" runat="server"
                                                OnClick="btnGuardarRepuestos_Click" Text="Guardar Repuestos" />
                                        </div>
                                    </div>

                                    <div>
                                        <div>&nbsp;</div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-5">
                                            <b>Trabajos Realizados</b>
                                        </div>

                                        <div class="col-sm-3">
                                            <asp:Button ID="btnAgregarActividad" runat="server" CssClass="btn btn-info"
                                                OnClick="btnAgregarActividad_Click" class="btn btn-secondary" Text="Agregar Actividad" />
                                        </div>
                                    </div>


                                    <div>
                                        <div>&nbsp;</div>

                                    </div>


                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
                                        CellPadding="4" DataKeyNames="codOrdenServicio,codActividad"
                                        DataSourceID="odsTrabajosRealizados" ForeColor="#333333" GridLines="None" PageSize="30">
                                        <RowStyle BackColor="#EFF3FB" />
                                        <Columns>
                                            <asp:BoundField DataField="loginAutor" HeaderText="Autor"
                                                SortExpression="loginAutor" />
                                            <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
                                            <asp:BoundField DataField="codOrdenServicio" HeaderText="codOrdenServicio"
                                                ReadOnly="True" SortExpression="codOrdenServicio" Visible="False" />
                                            <asp:BoundField DataField="codActividad" HeaderText="codActividad"
                                                ReadOnly="True" SortExpression="codActividad" Visible="False" />
                                            <asp:BoundField DataField="observacion" HeaderText="Observacion"
                                                SortExpression="observacion">
                                                <ItemStyle Height="50px" Width="350px" />
                                            </asp:BoundField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:ImageButton runat="server" ToolTip="Eliminar Observacion" ID="imgEliminar" Visible='<%#  (Eval("loginAutor").ToString().Trim().ToLower() == Session["ss_login"].ToString().Trim().ToLower() && btnCerrarOrden.Visible ) %>' ValidationGroup='<%#  Eval("codActividad") %>' OnClick="btnEliminar_Click" ImageUrl="~/img/web/cancel.gif" OnClientClick="return confirm('Esta Seguro de Eliminar Esta observacion.?\n');" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <EditRowStyle BackColor="#2461BF" />
                                        <AlternatingRowStyle BackColor="White" />
                                    </asp:GridView>
                                    <br />
                                    <asp:ObjectDataSource ID="odsTrabajosRealizados" runat="server"
                                        DeleteMethod="Delete" InsertMethod="Insert"
                                        OldValuesParameterFormatString="original_{0}"
                                        SelectMethod="GetDataBycodOrdenServicio"
                                        TypeName="Web2020.cls.ds2020TableAdapters.actividadxordenServicioTableAdapter"
                                        UpdateMethod="Update">
                                        <DeleteParameters>
                                            <asp:Parameter Name="Original_codOrdenServicio" Type="Int32" />
                                            <asp:Parameter Name="Original_codActividad" Type="Int32" />
                                            <asp:Parameter Name="Original_fecha" Type="DateTime" />
                                            <asp:Parameter Name="Original_observacion" Type="String" />
                                            <asp:Parameter Name="Original_loginAutor" Type="String" />
                                        </DeleteParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="fecha" Type="DateTime" />
                                            <asp:Parameter Name="observacion" Type="String" />
                                            <asp:Parameter Name="loginAutor" Type="String" />
                                            <asp:Parameter Name="Original_codOrdenServicio" Type="Int32" />
                                            <asp:Parameter Name="Original_codActividad" Type="Int32" />
                                            <asp:Parameter Name="Original_fecha" Type="DateTime" />
                                            <asp:Parameter Name="Original_observacion" Type="String" />
                                            <asp:Parameter Name="Original_loginAutor" Type="String" />
                                        </UpdateParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lblOrdenServicio" Name="codOrdenServicio"
                                                PropertyName="Text" Type="Int32" />
                                        </SelectParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="codOrdenServicio" Type="Int32" />
                                            <asp:Parameter Name="codActividad" Type="Int32" />
                                            <asp:Parameter Name="fecha" Type="DateTime" />
                                            <asp:Parameter Name="observacion" Type="String" />
                                            <asp:Parameter Name="loginAutor" Type="String" />
                                        </InsertParameters>
                                    </asp:ObjectDataSource>

                                </div>

                            </telerik:RadPageView>
                            <%-- General--%>
                            <telerik:RadPageView ID="RadPageView2" runat="server">
                                <div class="Formulario">
                                    <div>
                                        <div>
                                            <div colspan="4"><b>Informacion del Equipo</b></div>
                                        </div>
                                        <div>
                                            <div>&nbsp;</div>


                                            <div class="row">
                                                <div class="col-sm-2">Serial</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtSerial" ReadOnly="True"></asp:TextBox>
                                                    <asp:ImageButton ID="ImageButton1" runat="server" ToolTip="verHojaVida" OnClick="verHojaVida" Width="30px" ImageUrl="~/img/frm/logos.png" />
                                                </div>
                                                <div class="col-sm-2">Fabricante</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtFabricante" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Modelo </div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtModelo" ReadOnly="True"></asp:TextBox></>
                                                </div>
                                                <div class="col-sm-2">Modalidad</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtModalidad" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Fecha Proximo Mantenimiento </div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtFechaProximoMantenimiento"
                                                        ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Fecha Ultimo Mantenimiento </div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtFechaUltimoMantenimiento" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div>
                                                <div>&nbsp;</div>
                                                <div>&nbsp;</div>

                                            </div>
                                            <div>
                                                <div class="col-sm-12"><b>Informacion de la Orden de Servicio</b></div>
                                            </div>
                                            <div>
                                                <div>&nbsp;</div>

                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Numero Orden Servicio</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtNumeroOrden" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Numero Entrada</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtNumeroEntrada" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Prioridad</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtPrioridad" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div></div>
                                                <div class="col-sm-2 rdContainer">
                                                    <asp:RadioButton ID="rdInterna" runat="server" Text=" Interna " GroupName="r" />
                                                    <asp:RadioButton ID="rdExterna" runat="server" Text=" Externa " GroupName="r" />
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Estado</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtEstado" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Tipo de Servicio</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtTipoServicio" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Ingeniero Asignado</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtIngenieroAsignado" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Asesor Comercial</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtAsesorComercial" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Fecha Tentativa Ejecucion</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtFechaTentativainicio" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Hasta</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtFechaTentativaFin" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2" valign="top">Observaciones Iniciales</div>
                                                <div class="col-sm-4" colspan="3">
                                                    <asp:TextBox runat="server" ID="txtObservacionesIniciales" TextMode="MultiLine"
                                                        ReadOnly="True" Height="84px" Width="459px"></asp:TextBox>
                                                </div>
                                            </div>
                                            <div>
                                                <div>&nbsp;</div>
                                                <div>&nbsp;</div>

                                            </div>
                                            <div>
                                                <div class="col-sm-12"><b>Informacion del Cliente</b></div>
                                            </div>
                                            <div>
                                                <div>&nbsp;</div>
                                                <div>&nbsp;</div>

                                            </div>
                                            <div class="row">
                                                <div class="col-sm-2">Nit Cliente</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtNitCliente" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Nombre Cliente</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtNombreCliente" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Sucursal</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtSucursal" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Ciudad</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtCiudadSucursal" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Direccion</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtDireccionSucursal" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Telefono</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtTelefonoSucursal" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                            <div class="row">
                                                <div class="col-sm-2">Contacto Sucursal</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtContactoSucursal" ReadOnly="True"></asp:TextBox>
                                                </div>
                                                <div class="col-sm-2">Celular Contacto</div>
                                                <div class="col-sm-4">
                                                    <asp:TextBox runat="server" ID="txtCelularContacto" ReadOnly="True"></asp:TextBox>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </telerik:RadPageView>
                            <%--Archivos--%>
                            <telerik:RadPageView ID="RadPageView3" runat="server">
                                <div>
                                    <div>&nbsp;</div>

                                </div>
                                <div class="mb-2">
                                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                                </div>
                                <div>
                                    <div>&nbsp;</div>

                                </div>
                                <asp:Button ID="btnSubirArchivo" runat="server" class="btn btn-primary" OnClick="btnSubirArchivo_Click"
                                    Text="Subir Archivo" />
                                <div>
                                    <div>&nbsp;</div>

                                </div>
                                <div>
                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"
                                        CellPadding="4" DataKeyNames="codOrdenServicio,codArchivo"
                                        DataSourceID="odsArchivosxOrden" ForeColor="#333333" GridLines="None">
                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                        <Columns>
                                            <asp:BoundField DataField="codOrdenServicio" HeaderText="codOrdenServicio"
                                                ReadOnly="True" SortExpression="codOrdenServicio" Visible="False" />
                                            <asp:BoundField DataField="codArchivo" HeaderText="codArchivo" ReadOnly="True"
                                                SortExpression="codArchivo" Visible="False" />
                                            <asp:BoundField DataField="nombreArchivo" HeaderText="Nombre Archivo"
                                                SortExpression="nombreArchivo">
                                                <ItemStyle Width="160px" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="descripcion" HeaderText="Descripcion"
                                                SortExpression="descripcion">
                                                <ItemStyle Width="290px" />
                                            </asp:BoundField>

                                            <asp:TemplateField>
                                                <ItemTemplate>

                                                    <asp:ImageButton ID="btnVerArchivo" Width="30px" ToolTip="Ver Archivo"
                                                        runat="server" ImageUrl="~/img/zoom.png" OnClick="verArchivo"
                                                        ValidationGroup='<%# Eval("codArchivo")+"|"+Eval("nombreArchivo") %>' />
                                                </ItemTemplate>

                                            </asp:TemplateField>
                                        </Columns>
                                        <EditRowStyle BackColor="#999999" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                        <EmptyDataTemplate>
                                            La orden de Servicio no tiene ningun archivo
                                        </EmptyDataTemplate>
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    </asp:GridView>
                                    <br />
                                    <asp:ObjectDataSource ID="odsArchivosxOrden" runat="server"
                                        OldValuesParameterFormatString="original_{0}"
                                        SelectMethod="GetDataByCodOrdenServicio"
                                        TypeName="Web2020.cls.ds2020TableAdapters.archivosXOrdenServicioTableAdapter">

                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lblOrdenServicio" Name="codOrdenServicio"
                                                PropertyName="Text" Type="Int32" />
                                        </SelectParameters>

                                    </asp:ObjectDataSource>
                                </div>

                            </telerik:RadPageView>
                            <telerik:RadPageView ID="RadPageView4" runat="server">
                                <%--Información de cierra --%>
                                <div>
                                    <div>&nbsp;</div>

                                </div>
                                <div class="col-sm-6" style="margin-bottom:20px;">
                                    <b>Informacion de Aceptacion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </b>
                                    <br>
                                </div>
                                <div class="col-sm-6">
                                    <asp:Button ID="btnEditarAceptacion" runat="server"
                                        Text="Editar firma" OnClick="btnEditarAceptacion_Click"
                                        ToolTip="Editar" class="btn btn-success"></asp:Button>
                                    <asp:ImageButton Width="30px" ID="btnAceptarAceptacion" runat="server" ClientIDMode="Static"
                                        ImageUrl="~/img/web/ok.gif" OnClick="btnAceptarAceptacion_Click"
                                        ToolTip="Aceptar" Visible="False" />
                                    <asp:ImageButton Width="30px" ID="btnCancelarAceptacion" runat="server"
                                        ImageUrl="~/img/web/cancel.gif" OnClick="btnCancelarAceptacion_Click"
                                        ToolTip="Cancelar" Visible="False" />
                                </div>
                                <div>
                                    <div class="row signTitleContainer">
                                        <div class="col-sm-3 h5">
                                            Firma
                                        </div>
                                    </div>
                                    <div class="row signContainer">
                                        <div rowspan="3">
                                                  <asp:Image ID="imgFirma" runat="server"
                                                            Style="max-width: 100%;min-height:80px !important;min-width:150px !important;" />
                                                 
                                            <!--Pad firma aqui-->
                                            <div class="col-sm-6" style="max-width: 100%; max-height: 150px">
                                                <div id="signature" style="max-width: 100%; height: 130px; display:none" runat="server" clientidmode="Static">
                                                    <canvas id="signature-pad" class="signature-pad"></canvas>


                                                    <asp:TextBox runat="server" ID='output' ClientIDMode="Static" Style='display: none;'></asp:TextBox><br />
                                                    <asp:HiddenField runat="server" ID="FirmaValida" ClientIDMode="Static" />

                                                </div>
                                            </div>

                                            <asp:Button ID="btnLimpiarFirma" runat="server"
                                                Text="Limpiar Firma" Visible="false" />
                                        </div>
                                    </div>
                                    <div>
                                        <div>&nbsp;</div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-3">
                                            Hora de Llegada<br />
                                        </div>
                                        <div class="col-sm-3" style="display: flex;">
                                            <asp:DropDownList ID="cmbHoraLlegada" Style="width: min-content;" runat="server" Enabled="False">
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
                                            <asp:DropDownList ID="cmbMinutosLlegada" Style="width: min-content;" runat="server" Enabled="False">
                                            </asp:DropDownList>
                                            <asp:DropDownList ID="cmbAmPmLlegada" Style="width: min-content;" runat="server" Enabled="False">
                                                <asp:ListItem>AM</asp:ListItem>
                                                <asp:ListItem>PM</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div>
                                        <div>&nbsp;</div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-3">
                                            Hora de Salida<br />
                                        </div>
                                        <div class="col-sm-3" style="display: flex;">
                                            <asp:DropDownList ID="cmbHoraSalida" Style="width: min-content;" runat="server" Enabled="False">
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
                                            <asp:DropDownList ID="cmbMinutosSalida" Style="width: min-content;" runat="server" Enabled="False">
                                            </asp:DropDownList>
                                            <asp:DropDownList ID="cmbAmPmSalida" Style="width: min-content;" runat="server" Enabled="False">
                                                <asp:ListItem>AM</asp:ListItem>
                                                <asp:ListItem>PM</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div>
                                    <div>&nbsp;</div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-3">
                                        Nombre del Usuario que recibe<br />
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtUsuarioAceptacion" runat="server" ReadOnly="True"
                                            Width="280px"></asp:TextBox>

                                    </div>


                                </div>

                                <div>
                                    <div>&nbsp;</div>
                                    <div>&nbsp;</div>
                                </div>

                                <div>
                                    <div>&nbsp;</div>
                                    <div>&nbsp;</div>
                                </div>
                                <div>
                                    <div>&nbsp;</div>
                                    <div>&nbsp;</div>
                                </div>
                                <div>
                                    <div>&nbsp;</div>
                                    <div>&nbsp;</div>
                                </div>


                            </telerik:RadPageView>
                            <telerik:RadPageView ID="RadPageViewMetrologia" runat="server">
                                <%--metrología--%>
                                <asp:UpdatePanel runat="server" ID="pnlGrillasMetrologia" OnLoad="pnlGrillasMetrologia_Load" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <div>
                                            <div>
                                                &nbsp;
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-sm-4">
                                                <asp:Label runat="server" Text="Dispositivos de medicion utilizados" Font-Bold="true"></asp:Label>

                                            </div>
                                            <div class="col-sm-4">

                                                <asp:Button ID="btnDispostivoExterno" runat="server" CssClass="btn btn-secondary" Text="Agregar Dispositivo Externo" OnClick="btnDispostivoExterno_Click"></asp:Button>
                                            </div>
                                            <div class="col-sm-3">
                                                <uc2:controlSerial ID="controlSerial1" esListaVisible="false" runat="server" esMedicion="True" />
                                            </div>
                                            <br />
                                            <div>
                                                <div>
                                                    &nbsp;
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <dx:ASPxGridView ID="grdDispositivoMedicion" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceDispositivosMedicion" KeyFieldName="cod_dispositivosmedicionxordenservicio">
                                                    <Columns>
                                                        <dx:GridViewDataTextColumn FieldName="cod_dispositivosmedicionxordenservicio" ReadOnly="True" Visible="False" VisibleIndex="0">
                                                            <EditFormSettings Visible="False" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Serial Interno" FieldName="serial_herramienta" VisibleIndex="1">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Fabricante" FieldName="nombre_fabricante" VisibleIndex="2">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Modelo" FieldName="NombreModelo" VisibleIndex="3">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Ultimo Responsable" FieldName="ultimo_responsable" VisibleIndex="4">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Responsable Externo" FieldName="responsable_externo" VisibleIndex="6">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Serial Externo" FieldName="serial_externo" VisibleIndex="5">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataColumn VisibleIndex="7">
                                                            <DataItemTemplate>
                                                                <asp:ImageButton ID="btnHojaVidaMedicion" runat="server" CommandArgument='<%# Eval("serial_herramienta") %>' ImageUrl="~/img/frm/logos.png" OnClick="btnHojaVidaMedicion_Click" ToolTip="verHojaVida" Width="30px" />
                                                                <asp:ImageButton ID="btnElimnarDispositivo" runat="server" CommandArgument='<%# Eval("cod_dispositivosmedicionxordenservicio") %>' ImageUrl="~/img/web/delete.gif" OnClick="btnElimnarDispositivo_Click" OnClientClick="return confirm('Esta seguro de eliminar el registro');" ToolTip="Eliminar Dispositivo" Width="30px" />
                                                            </DataItemTemplate>
                                                        </dx:GridViewDataColumn>
                                                    </Columns>
                                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                                </dx:ASPxGridView>
                                            </div>
                                        </div>
                                        <asp:ObjectDataSource ID="ObjectDataSourceDispositivosMedicion" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByCodOrdenServicio" TypeName="Web2020.cls.dsPlantillas2020TableAdapters.pltDispositivosxOrdenTableAdapter">
                                            <SelectParameters>
                                                <asp:QueryStringParameter Name="codOrdenServicio" QueryStringField="osx" Type="Int32" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>
                                        &nbsp;<br />
                                        <div class="row">
                                            <div class="col-sm-3">
                                                <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="Variables de medicion"></asp:Label>
                                            </div>

                                            &nbsp;
                                                <div class="col-sm-3">
                                                    <asp:Button ID="btnAgregarVariable" runat="server" CssClass="btn btn-secondary" OnClick="btnAgregarVariable_Click" Text="Agregar Variable" />
                                                </div>
                                            <br />
                                            &nbsp;
                                        </div>
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <dx:ASPxGridView ID="grdVariablesxOrden" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSourceVariablesxOrden">
                                                    <Columns>
                                                        <dx:GridViewDataTextColumn FieldName="cod_variables_medicionxorden_servicio" ReadOnly="True" Visible="False" VisibleIndex="1">
                                                            <EditFormSettings Visible="False" />
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="codOrdenServicio" Visible="False" VisibleIndex="2">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="cod_sub_variable_medicion" Visible="False" VisibleIndex="3">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Resultado" FieldName="resultado_variable" VisibleIndex="4">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Variable" FieldName="nombre_variables_medicion" VisibleIndex="8">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn FieldName="unidades" ReadOnly="True" VisibleIndex="7">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Sub Variable" FieldName="nombre_subvariable" VisibleIndex="9">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Rango Inicial" FieldName="rango_inicial" VisibleIndex="5">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="Rango Final" FieldName="rango_final" VisibleIndex="6">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataTextColumn Caption="*" FieldName="alarma" ReadOnly="True" VisibleIndex="0">
                                                        </dx:GridViewDataTextColumn>
                                                        <dx:GridViewDataCheckColumn Caption="Realizado por Equipo" FieldName="relizado_por_equipo" VisibleIndex="11">
                                                        </dx:GridViewDataCheckColumn>
                                                        <dx:GridViewDataColumn VisibleIndex="12">
                                                            <DataItemTemplate>
                                                                <asp:ImageButton ID="btnEditarVariableMedicion" runat="server" CommandArgument='<%# Eval("cod_variables_medicionxorden_servicio") %>' ImageUrl="~/img/web/edit.gif" OnClick="btnEditarVariableMedicion_Click1" ToolTip="Editar Variable" Width="30px" />
                                                                <asp:ImageButton ID="btnElimnarVariable" runat="server" CommandArgument='<%# Eval("cod_variables_medicionxorden_servicio") %>' ImageUrl="~/img/web/delete.gif" OnClick="btnElimnarVariable_Click" OnClientClick="return confirm('Esta seguro de eliminar el registro');" ToolTip="Eliminar Variable" Width="30px" />
                                                            </DataItemTemplate>
                                                        </dx:GridViewDataColumn>
                                                    </Columns>
                                                    <SettingsDataSecurity AllowDelete="False" AllowEdit="False" AllowInsert="False" />
                                                </dx:ASPxGridView>
                                            </div>
                                        </div>
                                        <asp:ObjectDataSource ID="ObjectDataSourceVariablesxOrden" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetDataByCodOrdenServicio" TypeName="Web2020.cls.dsPlantillas2020TableAdapters.pltVariablesxOrdenServicioTableAdapter">
                                            <SelectParameters>
                                                <asp:QueryStringParameter Name="CodOrdenServicio" QueryStringField="osx" Type="Int32" />
                                            </SelectParameters>
                                        </asp:ObjectDataSource>

                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </telerik:RadPageView>

                        </telerik:RadMultiPage>
                    </div>
                </div>
                <div class="row mb-lg-3">

                    <asp:Panel Style="max-width: 100%; max-height: 100%;" ID="pnlDispositivos" Enabled="true" runat="server"
                        Width="320px" BackColor="LightGray" display="inline-table">
                        <asp:UpdatePanel ID="UpdatePanelDispositivos" runat="server" RenderMode="Inline" UpdateMode="Always">
                            <ContentTemplate>


                                <div class="p-3 ">
                                    <div class="row">
                                        <div class="col-sm-12 h4" colspan="2">Ingrese la Informacion del dispositivo externo</div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">Fabricante</div>
                                        <div class="col-sm-8">
                                            <asp:TextBox runat="server" ID="txtFabricanteExterno"></asp:TextBox>

                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-sm-4">Modelos</div>
                                        <div class="col-sm-8">
                                            <asp:TextBox runat="server" ID="txtModeloExterno"></asp:TextBox>


                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-sm-4">Serial Externo</div>
                                        <div class="col-sm-8">
                                            <asp:TextBox runat="server" ID="txtSerialExterno"></asp:TextBox><asp:Label runat="server" Text="" ID="lblcoddispositivoExterno" Visible="false"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-4">Responsable Externo</div>
                                        <div class="col-sm-8">
                                            <asp:TextBox runat="server" ID="txtResponsableExterno"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-5" colspan="2">
                                            <asp:Label runat="server" ID="lblErrorDispositivos" ForeColor="Red"></asp:Label>
                                        </div>
                                    </div>
                                    <div>
                                        <div>
                                            &nbsp;
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-12  d-flex justify-content-center" colspan="2">
                                            <asp:Button runat="server" Text="Aceptar" ID="btnAceptarDispositivos" CssClass="btn btn-primary" OnClick="btnAceptarDispositivos_Click" />
                                            <asp:Button runat="server" Text="Cancelar" ID="btnCancelarDispositivos" CssClass="btn btn-danger" OnClick="btnCancelarDispositivos_Click" />

                                        </div>
                                    </div>



                                </div>


                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </asp:Panel>
                </div>
                <asp:Panel Style="display: none" ID="pnlVariables" Enabled="true" runat="server"
                    Height="240px" Width="470px" BackColor="LightGray">
                    <asp:UpdatePanel ID="UpdatePanelVariables" OnLoad="UpdatePanelVariables_Load" runat="server" RenderMode="Inline" UpdateMode="Always">
                        <ContentTemplate>
                            <div>
                                <div class="row">
                                    <div class="col-sm-12" colspan="2"><b>Ingrese la Informacion de variable de medicion</b></div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-4">Variables de medicion</div>
                                    <div class="col-sm-3">

                                        <asp:DropDownList runat="server" ID="cmbVariableMedicion" AutoPostBack="True" DataSourceID="SqlDataSourceVariables" DataTextField="nombre_variables_medicion" DataValueField="cod_variables_medicion">
                                        </asp:DropDownList>
                                        <asp:SqlDataSource ID="SqlDataSourceVariables" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>"
                                            SelectCommand="
                    select distinct variables_medicion.[cod_variables_medicion], [nombre_variables_medicion] from ordenServicio 
  join equipos on equipos.serial= ordenServicio.serial
 join variables_medicionxmodelo on variables_medicionxmodelo.codFabricante = equipos.codFabricante and variables_medicionxmodelo.codModelo = equipos.codModelo 
 join variables_medicion on variables_medicionxmodelo.cod_variables_medicion = variables_medicion.cod_variables_medicion
 where codOrdenServicio=@codOrdenServicio order by nombre_variables_medicion">
                                            <SelectParameters>
                                                <asp:QueryStringParameter Name="codOrdenServicio" Type="Int32" QueryStringField="osx" />
                                            </SelectParameters>

                                        </asp:SqlDataSource>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-4">Sub Variables de medicion</div>
                                    <div class="col-sm-3">
                                        <asp:DropDownList runat="server" ID="cmbSubvariable" OnDataBound="cmbSubvariable_DataBound" AutoPostBack="True" DataSourceID="SqlDataSourceSubVariables" DataTextField="nombre_subvariable" DataValueField="cod_sub_variables_medicion" OnSelectedIndexChanged="cmbSubvariable_SelectedIndexChanged"></asp:DropDownList>

                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-1"></div>
                                    <div class="col-sm-5">
                                        <asp:Label runat="server" ID="lblRangosVariables"></asp:Label>
                                        <asp:Label runat="server" ID="lblCodVariable" Text="" Visible="false"></asp:Label>
                                    </div>

                                </div>
                                <div class="row">
                                    <div class="col-sm-3">Valor</div>
                                    <div class="col-sm-3">
                                        <asp:TextBox runat="server" ID="txtValorUnidades"></asp:TextBox></div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-3">Unidades</div>
                                    <div class="col-sm-3">
                                        <asp:TextBox runat="server" ID="txtUnidades" ReadOnly="True"></asp:TextBox></div>
                                </div>
                                <div class="row checkboxContainer">
                                    <div class="col-sm-1" colspan="2">
                                        <asp:CheckBox runat="server" ID="chkCalculadoPorEquipos" ></asp:CheckBox></div>
                                    <div class="col-sm-3"> 
                                    <asp:Label Text="Calculado por equipos" runat="server" /></div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-3" colspan="2">
                                        <asp:Label runat="server" ID="lblErrorVariables" ForeColor="Red"></asp:Label></div>
                                </div>
                                <div class="row btnContainer">
                                    <div class="col-sm-2" colspan="2">
                                        <asp:Button runat="server" CssClass="btn btn-primary" Text="Aceptar" ID="btnAceptarVariables" OnClick="btnAceptarVariables_Click" />

                                    </div>
                                    <div class=" col-sm-2">
                                        <asp:Button runat="server" CssClass="btn btn-danger" Text="Cancelar" ID="btnCancelarVariables" OnClick="btnCancelarVariables_Click" />
                                    </div>
                                </div>



                            </div>

                        </ContentTemplate>
                    </asp:UpdatePanel>
                </asp:Panel>
                <asp:SqlDataSource ID="SqlDataSourceSubVariables" runat="server" ConnectionString="<%$ ConnectionStrings:spxConnectionString %>"
                    SelectCommand="SELECT distinct [sub_variable_medicion].[cod_sub_variables_medicion], 
[sub_variable_medicion].[nombre_subvariable] FROM [sub_variable_medicion] 
join variables_medicionxmodelo on
 variables_medicionxmodelo.cod_variables_medicion = [sub_variable_medicion].cod_variables_medicion
 and variables_medicionxmodelo.cod_sub_variables_medicion = [sub_variable_medicion].cod_sub_variables_medicion

 join Modelos on 
 modelos.codModelo = variables_medicionxmodelo.codModelo and modelos.codFabricante =variables_medicionxmodelo.codFabricante
 join equipos on equipos.codModelo = modelos.codModelo and equipos.codFabricante = modelos.codFabricante
  
     WHERE (sub_variable_medicion.cod_variables_medicion = @cod_variables_medicion and equipos.serial=@serial) 
	 
	 ORDER BY [nombre_subvariable]">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="cmbVariableMedicion" Name="cod_variables_medicion" PropertyName="SelectedValue" Type="Int32" />
                        <asp:ControlParameter ControlID="txtSerial" Name="serial" PropertyName="Text" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:Label Style="display: none" ID="lblInvicible" runat="server" />
                <asp:Label Style="display: none" ID="lblInvicible2" runat="server" />
                <cca:ModalPopupExtender ID="ModalDispositivos" runat="server"
                    PopupControlID="pnlDispositivos"
                    TargetControlID="lblInvicible"
                    BackgroundCssClass="modalBackground"
                    DropShadow="true" Enabled="true">
                </cca:ModalPopupExtender>

                <cca:ModalPopupExtender ID="ModalVariables" runat="server"
                    PopupControlID="pnlVariables"
                    TargetControlID="lblInvicible2"
                    BackgroundCssClass="modalBackground"
                    DropShadow="true" Enabled="true">
                </cca:ModalPopupExtender>

            </div>
        </div>
    </div>

</asp:Content>

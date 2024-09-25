nunca cambie los tableadapter de este proyecto se enloquece por que los tableadapter son muy viejos

use los dataset del proyecto controladora datos y para llenarlos o cambiarlos

EJEMPLOw
  SPXdata.BD.DataConector obj = new SPXdata.BD.DataConector();

            var id = obj.ejecutarProcedimiento(sql);

            sql = @"INSERT INTO [reasignacionOrdenesTrabajo] ([codOrdenServicio], [codReasignacion], [loginOriginal]," +
                 " [loginNuevo], [fechaReAsignacion], [motivoReasignacion], [reasignadoPor]) " +
                 "VALUES (" + lblOrdenServicio.Text + "," + id + " ,'" + txtLoginIngenieroAsignado.Text + "' , '"
                 + cmbIngenieros.SelectedValue + "', getdate(), '" + txtMotivoReasignacion.Text + "', '" + Session["ss_login"].ToString() + "')";

            obj.ejecutarComando(sql);
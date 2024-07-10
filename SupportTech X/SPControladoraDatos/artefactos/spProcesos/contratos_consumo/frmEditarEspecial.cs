using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spProcesos.contratos_consumo
{
    public partial class frmEditarEspecial : Form
    {
        public frmEditarEspecial()
        {
            InitializeComponent();
        }

        public string numeroContrato = "";

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdDatos.Columns["numero_contrato"].Text.Trim() == string.Empty) return;
            contratosConsumo fr = new contratosConsumo();
            fr.NumeroContrato = grdDatos.Columns["numero_contrato"].Text.Trim();
            fr.CodEspecial = grdDatos.Columns["cod_contrato_consumo"].Text.Trim();
            fr.ShowDialog();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void frmEditarEspecial_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource = bd.ejecutarConsulta(generarSql()).Tables[0];
        }

        private string generarSql()
        {
            string sql = @"select distinct 
contrato_consumo.cod_contrato_consumo,
contrato_consumo.numero_contrato,
contrato_consumo.contrato_legalizado, contrato_consumo.otro_si, 
contrato_consumo.fecha_inicio_contrato, contrato_consumo.fecha_finalizacion_contrato,contrato_consumo.fecha_otro_si,

clientes.numeroSocio,clientes.nombreCliente,
modalidad_contrato.nombre_modalidad_contrato,sub_modalidad_contrato.nombresub_modalidad_contrato,

contrato_consumo.observaciones,us.nombre creado_por, contrato_consumo.fecha_creacion


 from contrato_consumo
 left join clientes on clientes.nitCliente = contrato_consumo.nitCliente
 left join usuario on usuario.cod_usuario= contrato_consumo.cod_asesor
 left join sub_modalidad_contrato on sub_modalidad_contrato.cod_sub_modalidad_contrato =contrato_consumo.cod_sub_modalidad_contrato
 left join modalidad_contrato on modalidad_contrato.cod_modalidad_contrato = sub_modalidad_contrato.cod_modalidad_contrato
 left join usuario us on us.cod_usuario= contrato_consumo.cod_asesor

where contrato_consumo.numero_contrato='" + numeroContrato+"' order by contrato_consumo.otro_si ";

            return sql ;
        }

    }
}

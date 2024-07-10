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
    public partial class contratosPorAsesor : Form
    {
        public contratosPorAsesor()
        {
            InitializeComponent();
            controladorColumnas1.grilla = grdDatos;
        }

        string sql = @"select max(usuario.nombre) 'Asesor',count(numero_contrato) 'Contratos'

 from contrato_consumo
join 
 (
 select 
max(cod_contrato_consumo) cod_contrato_consumo
 from contrato_consumo
 group by numero_contrato
 ) st on st.cod_contrato_consumo = contrato_consumo.cod_contrato_consumo

 left join usuario on usuario.cod_usuario= contrato_consumo.cod_asesor

 group by contrato_consumo.cod_asesor";

        private void contratosPorAsesor_Load(object sender, EventArgs e)
        {
            SPXdata.BD.DataConector bd = new SPXdata.BD.DataConector();
            grdDatos.DataSource = bd.ejecutarConsulta(sql).Tables[0];
        }
    }
}

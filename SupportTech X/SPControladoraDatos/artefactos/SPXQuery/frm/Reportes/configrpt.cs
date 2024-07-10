using SPControladoraDatos.artefactos.SPXQuery.data;
using System;
using System.Collections.Generic;

using System.Text;

namespace SPControladoraDatos.artefactos.SPXQuery.frm.Reportes 
{
    public class configrpt
    {

        public configrpt() { }

        public string verScriptCreacion()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" SET ANSI_NULLS ON ");
            sb.Append(" SET QUOTED_IDENTIFIER ON ");
            sb.Append(" SET ANSI_PADDING ON ");
            sb.Append(" CREATE TABLE [dbo].[tipoFiltroRpt]( ");
            sb.Append(" [codTipoFiltroRpt] [int] NOT NULL, ");
            sb.Append(" [descripcion] [char](10) COLLATE Modern_Spanish_CI_AS NULL, ");
            sb.Append(" CONSTRAINT [PK_tipoFiltroRpt] PRIMARY KEY CLUSTERED  ");
            sb.Append(" ( ");
            sb.Append(" [codTipoFiltroRpt] ASC ");
            sb.Append(" )WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY] ");
            sb.Append(" ) ON [PRIMARY] ");
            sb.Append(" CREATE TABLE [dbo].[rpt]( ");
            sb.Append(" [idRpt] [int] NOT NULL, ");
            sb.Append(" [nombreRpt] [char](100) COLLATE Modern_Spanish_CI_AS NULL, ");
            sb.Append(" [captionRpt] [char](100) COLLATE Modern_Spanish_CI_AS NULL, ");
            sb.Append(" [xml] [char](50) COLLATE Modern_Spanish_CI_AS NULL, ");
            sb.Append(" [filtroObligatorio] [bit] NULL, ");
            sb.Append(" CONSTRAINT [PK_rpt] PRIMARY KEY CLUSTERED  ");
            sb.Append(" ( ");
            sb.Append(" [idRpt] ASC ");
            sb.Append(" )WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY] ");
            sb.Append(" ) ON [PRIMARY] ");

            sb.Append(" CREATE TABLE [dbo].[filtrosRpt]( ");
            sb.Append(" [idRpt] [int] NOT NULL, ");
            sb.Append(" [codFiltroRpt] [int] NOT NULL, ");
            sb.Append(" [codTipoFiltroRpt] [int] NULL, ");
            sb.Append(" [nombre] [char](30) COLLATE Modern_Spanish_CI_AS NULL, ");
            sb.Append(" [campo] [char](50) COLLATE Modern_Spanish_CI_AS NULL, ");
            sb.Append(" CONSTRAINT [PK_filtrosRpt] PRIMARY KEY CLUSTERED  ");
            sb.Append(" ( ");
            sb.Append(" [idRpt] ASC, ");
            sb.Append(" [codFiltroRpt] ASC ");
            sb.Append(" )WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY] ");
            sb.Append(" ) ON [PRIMARY] ");


            sb.Append(" SET ANSI_PADDING OFF ");

            sb.Append(" ALTER TABLE [dbo].[filtrosRpt]  WITH CHECK ADD  CONSTRAINT [FK_filtrosRpt_rpt] FOREIGN KEY([idRpt]) ");
            sb.Append(" REFERENCES [dbo].[rpt] ([idRpt]) ");

            sb.Append(" ALTER TABLE [dbo].[filtrosRpt] CHECK CONSTRAINT [FK_filtrosRpt_rpt] ");

            sb.Append(" ALTER TABLE [dbo].[filtrosRpt]  WITH CHECK ADD  CONSTRAINT [FK_filtrosRpt_tipoFiltroRpt] FOREIGN KEY([codTipoFiltroRpt]) ");
            sb.Append(" REFERENCES [dbo].[tipoFiltroRpt] ([codTipoFiltroRpt]) ");

            sb.Append(" ALTER TABLE [dbo].[filtrosRpt] CHECK CONSTRAINT [FK_filtrosRpt_tipoFiltroRpt] ");
            sb.Append(" insert into tipoFiltrorpt values(1,'INT') ");
            sb.Append(" insert into tipoFiltrorpt values(2,'FLOAT') ");
            sb.Append(" insert into tipoFiltrorpt values(3,'STRING') ");
            sb.Append(" insert into tipoFiltrorpt values(4,'DATETIME') ");
            return sb.ToString();

        }

        public string verScriptDatos()
        {
            dsSPXQuery ds = new dsSPXQuery();
            data.dsSPXQueryTableAdapters.rptTableAdapter objReporte = new data.dsSPXQueryTableAdapters.rptTableAdapter();
            data.dsSPXQueryTableAdapters.rpt_parametrosTableAdapter objFiltros = new data.dsSPXQueryTableAdapters.rpt_parametrosTableAdapter();
            SPXQuery.data.cls.clsTtipofiltro_query_rpt objTiposFiltros = new data.cls.clsTtipofiltro_query_rpt();

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append(" delete filtrosRpt ");
            sb.Append(" delete tipoFiltroRpt ");
            sb.Append(" delete rpt ");
            objReporte.Fill(ds.rpt);
            objFiltros.Fill(ds.rpt_parametros);
            objTiposFiltros.Fill(ds.tipofiltro_query_rpt);
            //ahora insertamos
            for (int k = 0; k < ds.rpt.Rows.Count; k++)
            {
                sb.Append(" INSERT INTO [rpt] ([idRpt],[nombreRpt],[captionRpt] ,[xml] ,[filtroObligatorio]) VALUES ( ");
                sb.Append(" '" + ds.rpt[k].cod_rpt + "','" + ds.rpt[k].nombre_rpt.Trim() + "','" + ds.rpt[k].caption_rpt.Trim() + "' ,'" + ds.rpt[k].xml.Trim() + "' ,'" + ((ds.rpt[k].filtra_linea) ? "1" : "0") + "')  ");
            }
            for (int k = 0; k < ds.tipofiltro_query_rpt.Rows.Count; k++)
            {
                sb.Append(" INSERT into tipoFiltroRpt (codTipoFiltroRpt,descripcion) VALUES ( ");
                sb.Append(" '" + ds.tipofiltro_query_rpt[k].cod_tipo_filtro + "','" + ds.tipofiltro_query_rpt[k].descripcion.Trim() + "') ");
            }
            for (int k = 0; k < ds.rpt_parametros.Rows.Count; k++)
            {
                sb.Append(" INSERT INTO [filtrosRpt] ([idRpt] ,[codFiltroRpt],[codTipoFiltroRpt],[nombre]  ,[campo]) VALUES ( ");
                sb.Append(" '" + ds.rpt_parametros[k].cod_rpt+ "','" + ds.rpt_parametros[k].cod_rpt_parametro + "','" + ds.rpt_parametros[k].cod_tipo_filtro + "' ,'" + ds.rpt_parametros[k].nombre.Trim() + "' ,'" + ds.rpt_parametros[k].campo.Trim() + "')  ");
            }

            return sb.ToString();
        }
    }
}
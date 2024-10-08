USE [SUPPORTECH]
GO
/****** Object:  Table [dbo].[taskEstatus]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[taskEstatus](
	[codEstatus] [char](10) NOT NULL,
	[nombreEstatus] [varchar](50) NOT NULL,
	[DescripcionEstatus] [varchar](250) NULL,
	[indFin] [bit] NULL,
	[IndIni] [bit] NULL,
 CONSTRAINT [PK_taskEstatus] PRIMARY KEY CLUSTERED 
(
	[codEstatus] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[taskCategoria]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[taskCategoria](
	[codCategoria] [char](10) NOT NULL,
	[nombreCategoria] [char](30) NOT NULL,
	[color] [char](30) NULL,
	[procesoInterno] [bit] NULL,
	[nameSpace] [char](40) NULL,
	[parametros] [char](40) NULL,
 CONSTRAINT [PK_taskCategoria] PRIMARY KEY CLUSTERED 
(
	[codCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[unidadTiempo]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[unidadTiempo](
	[codUnidadTiempo] [int] NOT NULL,
	[descripcion] [char](20) NULL,
	[factorConversion] [float] NULL,
 CONSTRAINT [PK_unidadTiempo] PRIMARY KEY CLUSTERED 
(
	[codUnidadTiempo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[unidadPeso]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[unidadPeso](
	[codUnidadPeso] [int] NOT NULL,
	[nombreUnidadPeso] [char](30) NULL,
	[factorConversion] [float] NULL,
 CONSTRAINT [PK_unidadPeso] PRIMARY KEY CLUSTERED 
(
	[codUnidadPeso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[transportadora]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[transportadora](
	[codTransportadora] [int] NOT NULL,
	[nombreTransportadora] [char](100) NULL,
	[telefono] [char](50) NULL,
	[telefono2] [char](50) NULL,
	[celular] [char](50) NULL,
	[direccion] [char](100) NULL,
	[observaciones] [text] NULL,
 CONSTRAINT [PK_transportadora] PRIMARY KEY CLUSTERED 
(
	[codTransportadora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trabajosxReporteServicio]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trabajosxReporteServicio](
	[idReporteServicio] [int] NOT NULL,
	[idTrabajo] [int] NOT NULL,
	[loginAutor] [char](10) NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_trabajosxReporteServicio] PRIMARY KEY CLUSTERED 
(
	[idReporteServicio] ASC,
	[idTrabajo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tituloContacto]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tituloContacto](
	[codTituloContacto] [char](5) NOT NULL,
	[tituloContacto] [char](30) NULL,
 CONSTRAINT [PK_tituloContacto] PRIMARY KEY CLUSTERED 
(
	[codTituloContacto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoServicio]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoServicio](
	[codTipoServicio] [char](5) NOT NULL,
	[nombretipoServicio] [char](40) NULL,
	[descripcion] [varchar](250) NULL,
	[devuelveTaller] [bit] NULL,
	[validoContrato] [bit] NULL,
	[preventivo] [bit] NULL,
	[correctivo] [bit] NULL,
	[devuelveEntrada] [bit] NULL,
 CONSTRAINT [PK_TipoServicio] PRIMARY KEY CLUSTERED 
(
	[codTipoServicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposArchivoXequipo]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposArchivoXequipo](
	[codTipoArchivoxEquipo] [char](5) NOT NULL,
	[nombre] [char](40) NULL,
	[descripcion] [varchar](350) NULL,
	[esObligatorio] [bit] NULL,
 CONSTRAINT [PK_TiposArchivoXequipo] PRIMARY KEY CLUSTERED 
(
	[codTipoArchivoxEquipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipoPropiedad]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipoPropiedad](
	[codTipoPropiedad] [int] NOT NULL,
	[nombreTipoPropiedad] [char](50) NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_tipoPropiedad] PRIMARY KEY CLUSTERED 
(
	[codTipoPropiedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipoFiltroRpt]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipoFiltroRpt](
	[codTipoFiltroRpt] [int] NOT NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_tipoFiltroRpt] PRIMARY KEY CLUSTERED 
(
	[codTipoFiltroRpt] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipoEquipo]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipoEquipo](
	[codTipoEquipo] [char](5) NOT NULL,
	[nombreTipoEquipo] [char](30) NULL,
 CONSTRAINT [PK_tipoEquipo] PRIMARY KEY CLUSTERED 
(
	[codTipoEquipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipoDocumento]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipoDocumento](
	[codTipoDoc] [char](5) NOT NULL,
	[nombreTipoDoc] [char](30) NOT NULL,
	[abreviatura] [char](5) NULL,
 CONSTRAINT [PK_tipoDocumento] PRIMARY KEY CLUSTERED 
(
	[codTipoDoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipoContrato]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipoContrato](
	[codTipoContrato] [char](5) NOT NULL,
	[nombreTipoContrato] [char](60) NULL,
	[descripcion] [ntext] NULL,
	[deMantenimiento] [bit] NULL,
	[deConsumo] [bit] NULL,
 CONSTRAINT [PK_tipoContrato] PRIMARY KEY CLUSTERED 
(
	[codTipoContrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipoComprobante]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipoComprobante](
	[codTipoComprobante] [char](5) NOT NULL,
	[NombreTipoComprobante] [char](30) NULL,
 CONSTRAINT [PK_tipoComprobante] PRIMARY KEY CLUSTERED 
(
	[codTipoComprobante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipoComponente]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipoComponente](
	[codTipoComponente] [char](5) NOT NULL,
	[nombreTipoComponente] [char](30) NULL,
 CONSTRAINT [PK_tipoComponente] PRIMARY KEY CLUSTERED 
(
	[codTipoComponente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_actividad]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_actividad](
	[cod_tipo_actividad] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo_actividad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_actividad] PRIMARY KEY CLUSTERED 
(
	[cod_tipo_actividad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sysusersobjects]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sysusersobjects](
	[name] [ntext] NULL,
	[date] [datetime] NULL,
	[user_] [varchar](20) NULL,
	[object_] [varchar](100) NULL,
	[file_] [varchar](200) NULL,
	[file_size] [varchar](20) NULL,
	[file_date] [varchar](40) NULL,
	[file_time] [varchar](20) NULL,
	[pointer] [varchar](80) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[login] [char](10) NOT NULL,
	[nombre] [char](35) NOT NULL,
	[password] [ntext] NOT NULL,
	[esBloqueado] [bit] NULL,
	[esDeshabilitado] [bit] NULL,
	[correo] [varchar](200) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY NONCLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[parametro_cientifica]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[parametro_cientifica](
	[cod_parametro_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[version_formato_llamada] [varchar](50) NOT NULL,
	[tipo_documento_llamada] [varchar](50) NOT NULL,
	[codigo_documento_llamada] [varchar](50) NOT NULL,
	[implementacion_documento_llamada] [varchar](50) NOT NULL,
 CONSTRAINT [PK_parametro_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_parametro_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[paises]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[paises](
	[codPais] [char](5) NOT NULL,
	[nombrePais] [varchar](30) NULL,
 CONSTRAINT [PK_paises] PRIMARY KEY CLUSTERED 
(
	[codPais] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ModalidadEquipo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ModalidadEquipo](
	[codModalidadEquipo] [char](5) NOT NULL,
	[nombreModalidadEquipo] [char](30) NULL,
	[descripcion] [varchar](350) NULL,
 CONSTRAINT [PK_ModalidadEquipo] PRIMARY KEY CLUSTERED 
(
	[codModalidadEquipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[notificacion]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[notificacion](
	[cod_notificacion] [int] IDENTITY(1,1) NOT NULL,
	[login] [char](10) NOT NULL,
	[titulo] [varchar](150) NOT NULL,
	[mensaje] [varchar](500) NOT NULL,
 CONSTRAINT [PK_notificacion] PRIMARY KEY CLUSTERED 
(
	[cod_notificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[motivo_anulacion_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[motivo_anulacion_cientifica](
	[cod_motivo_anulacion_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[motivo_anulacion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_motivo_anulacion_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_motivo_anulacion_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[problemas_comunes_cientifica]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[problemas_comunes_cientifica](
	[cod_problemas_comunes_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[titulo_problema_comun] [char](40) NOT NULL,
	[descripcion_problema_comun] [text] NOT NULL,
	[solucion_propuesta] [text] NOT NULL,
 CONSTRAINT [PK_problemas_comunes_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_problemas_comunes_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[prioridadSolicitud]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[prioridadSolicitud](
	[codPrioridadSolicitud] [int] NOT NULL,
	[descripcionPrioridad] [char](10) NULL,
 CONSTRAINT [PK_prioridadSolicitud] PRIMARY KEY CLUSTERED 
(
	[codPrioridadSolicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[prioridadesOrdenServicio]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[prioridadesOrdenServicio](
	[codPrioridadOS] [int] NOT NULL,
	[nombre] [char](30) NULL,
	[orden] [int] NULL,
	[esOrdenInterna] [bit] NULL,
 CONSTRAINT [PK_prioridadesOrdenServicio] PRIMARY KEY CLUSTERED 
(
	[codPrioridadOS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[prioridad_callcenter_cientifica]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[prioridad_callcenter_cientifica](
	[cod_prioridad_callcenter_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[nombre_prioridad] [char](40) NOT NULL,
	[relevancia] [int] NOT NULL,
 CONSTRAINT [PK_prioridad_callcenter_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_prioridad_callcenter_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[prioridad]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[prioridad](
	[codPrioridad] [char](10) NOT NULL,
	[nombrePrioridad] [varchar](50) NOT NULL,
	[descripcionPrioridad] [varchar](250) NULL,
	[orden] [int] NULL,
 CONSTRAINT [PK_prioridad] PRIMARY KEY CLUSTERED 
(
	[codPrioridad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[smtpServer]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[smtpServer](
	[smtpServer] [varchar](250) NOT NULL,
	[smtpAutentificacion] [bit] NULL,
	[smtpUser] [varchar](250) NULL,
	[smtpPass] [varchar](250) NULL,
	[smtpDirOrigen] [varchar](250) NULL,
	[smtpEnableSsl] [bit] NULL,
	[smtpHabilitado] [bit] NULL,
 CONSTRAINT [PK_smtpServer] PRIMARY KEY CLUSTERED 
(
	[smtpServer] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[seguimiento_asesoria_cientifica]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[seguimiento_asesoria_cientifica](
	[cod_seguimiento_asesoria_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[fecha_seguimiento] [datetime] NOT NULL,
	[realizado_por] [char](10) NOT NULL,
	[observaciones] [text] NOT NULL,
	[cod_asesoria_cientifica] [int] NULL,
	[observaciones_tabla] [text] NULL,
 CONSTRAINT [PK_seguimiento_asesoria_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_seguimiento_asesoria_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rpt]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rpt](
	[idRpt] [int] NOT NULL,
	[nombreRpt] [char](100) NULL,
	[captionRpt] [char](100) NULL,
	[xml] [char](50) NULL,
	[filtroObligatorio] [bit] NULL,
 CONSTRAINT [PK_rpt] PRIMARY KEY CLUSTERED 
(
	[idRpt] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[repuestos]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[repuestos](
	[codRepuesto] [char](20) NOT NULL,
	[descripcion] [char](80) NULL,
	[precio] [money] NULL,
	[Observaciones] [varchar](250) NULL,
 CONSTRAINT [PK_repuestos] PRIMARY KEY CLUSTERED 
(
	[codRepuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[defaults]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[defaults](
	[codPais] [char](5) NULL,
	[codDepartamento] [char](5) NULL,
	[codCiudad] [char](5) NULL,
	[logotipo] [image] NULL,
	[tituloOrdenServicio] [char](200) NULL,
	[versionOrdenServicio] [char](10) NULL,
	[pedirFechaOrdenServicio] [bit] NULL,
	[modificaOrden_Insumosabierta] [bit] NULL,
	[nombreReporteInsumos] [char](200) NULL,
	[versionReporteInsumos] [char](10) NULL,
	[tituloOrdenPrestamo] [char](200) NULL,
	[versionOrdenPrestamo] [char](10) NULL,
	[codUbicacionTallerxDefecto] [char](5) NULL,
	[codEstadoLocalEquipos] [char](5) NULL,
	[tituloReporteServicio] [char](200) NULL,
	[versionReporteServicio] [char](10) NULL,
	[tituloRegistroEntradaSalida] [char](200) NULL,
	[versionRegistroEntradaSalida] [char](10) NULL,
	[diasxMantenimiento] [int] NULL,
	[mesesxMantenimiento] [int] NULL,
	[tituloViajes] [char](200) NULL,
	[versionViajes] [char](10) NULL,
	[tituloLlamadas] [char](200) NULL,
	[versionLlamadas] [char](10) NULL,
	[tituloSolicitud] [char](200) NULL,
	[versionSolicitud] [char](10) NULL,
	[codUbicacionTrasladoEntradas] [char](5) NULL,
	[codEstadoLocalTrasladoEntradas] [char](5) NULL,
	[codigoOrdenServicio] [char](20) NULL,
	[fechaVigenciaOrdenServicio] [datetime] NULL,
	[codigoReporteInsumos] [char](20) NULL,
	[fechaVigenciaReporteInsumos] [datetime] NULL,
	[codigoOrdenPrestamo] [char](20) NULL,
	[fechaVigenciaOrdenPrestamo] [datetime] NULL,
	[codigoReporteServicio] [char](20) NULL,
	[fechaVigenciaReporteServicio] [datetime] NULL,
	[codigoEntradaSalida] [char](20) NULL,
	[fechaVigenciaEntradaSalida] [datetime] NULL,
	[codigoViajes] [char](20) NULL,
	[fechaVigenciaViajes] [datetime] NULL,
	[codigoLLamadas] [char](20) NULL,
	[fechaVigenciaLlamadas] [datetime] NULL,
	[codigoSolicitud] [char](20) NULL,
	[fechaVigenciaSolicitud] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[consumosxContratos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[consumosxContratos](
	[idConsumo] [int] NOT NULL,
	[numeroContrato] [char](40) NULL,
	[mesConsumo] [char](20) NULL,
	[consumo] [money] NULL,
	[anoConsumo] [char](20) NULL,
	[codGrupoLineaConsumo] [char](5) NULL,
	[codLinea] [char](5) NULL,
 CONSTRAINT [PK_consumosxContratos] PRIMARY KEY CLUSTERED 
(
	[idConsumo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cgSmtpEmail]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpEmail](
	[idCgSmtpEmail] [int] NOT NULL,
	[enviado] [bit] NULL,
	[fechaRealEnvio] [datetime] NULL,
	[cuerpo] [ntext] NULL,
	[nombreFirma] [varchar](250) NULL,
	[emailFirma] [varchar](250) NULL,
	[asunto] [varchar](250) NULL,
	[IsBodyHtml] [bit] NULL,
	[prioridad] [char](50) NULL,
	[responderA] [varchar](250) NULL,
	[fechaEnvio] [datetime] NULL,
 CONSTRAINT [PK_cgSmtpEmail] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpEmail] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cgSmtpServer]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpServer](
	[idCgSmtpServer] [int] NOT NULL,
	[servidorSmtp] [varchar](250) NULL,
	[usuarioSmtp] [varchar](250) NULL,
	[passSmtp] [varchar](250) NULL,
	[conAutenticacion] [bit] NULL,
	[sslHabilitado] [bit] NULL,
	[puerto] [int] NULL,
	[correoOrigen] [varchar](250) NULL,
	[nombreOrigen] [varchar](250) NULL,
	[responderA] [varchar](250) NULL,
	[asuntoPrefijo] [varchar](250) NULL,
	[asuntoPostfijo] [varchar](250) NULL,
	[cuerpoPrefijo] [text] NULL,
	[cuerpoPostfijo] [text] NULL,
	[dejarCopiaTabla] [bit] NULL,
	[IsBodyHtml] [bit] NULL,
	[habilitado] [bit] NULL,
 CONSTRAINT [PK_cgSmtpServer] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpServer] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[accion_seguir_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[accion_seguir_cientifica](
	[cod_accion_seguir_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[nombre_accion_seguir] [char](40) NOT NULL,
	[ind_qc] [bit] NULL,
	[ind_visita] [bit] NULL,
 CONSTRAINT [PK_accion_seguir_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_accion_seguir_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[asesoresComerciales]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asesoresComerciales](
	[codAsesor] [int] NOT NULL,
	[NombreAsesor] [char](50) NULL,
	[correo] [varchar](250) NULL,
	[telefono] [char](15) NULL,
	[celular] [char](15) NULL,
 CONSTRAINT [PK_asesoresComerciales] PRIMARY KEY CLUSTERED 
(
	[codAsesor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cgSmtpAccion]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpAccion](
	[idCgSmtpAccion] [int] NOT NULL,
	[nombreAccion] [varchar](100) NOT NULL,
	[descripcion] [varchar](500) NULL,
	[cuerpoEmail] [ntext] NULL,
	[asunto] [varchar](250) NULL,
 CONSTRAINT [PK_cgSmtpAccion] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpAccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CGQ_TipoFiltro]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CGQ_TipoFiltro](
	[codTipoFiltro] [int] NOT NULL,
	[descripcion] [char](10) NULL,
 CONSTRAINT [PK_CGQ_TipoFiltro] PRIMARY KEY CLUSTERED 
(
	[codTipoFiltro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CGQ_Query]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CGQ_Query](
	[codQuery] [int] NOT NULL,
	[nombreQuery] [char](100) NULL,
	[sql] [ntext] NULL,
 CONSTRAINT [PK_CGQ_Query] PRIMARY KEY CLUSTERED 
(
	[codQuery] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fabricante]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fabricante](
	[codFabricante] [char](5) NOT NULL,
	[nombreFabricante] [varchar](50) NOT NULL,
	[numeroNit] [char](20) NULL,
	[paginaWeb] [varchar](50) NULL,
	[emailContacto] [varchar](50) NULL,
	[telefono1] [char](20) NULL,
	[telefono2] [char](20) NULL,
	[nombreContacto] [varchar](50) NULL,
	[tituloContacto] [char](10) NULL,
	[logoTipo] [image] NULL,
 CONSTRAINT [PK_fabricante] PRIMARY KEY CLUSTERED 
(
	[codFabricante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estadosSolicitud]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estadosSolicitud](
	[codEstadoSolicitud] [int] NOT NULL,
	[descripcionSolicitud] [nchar](10) NULL,
 CONSTRAINT [PK_estadosSolicitud] PRIMARY KEY CLUSTERED 
(
	[codEstadoSolicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estadosOrdenServicio]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estadosOrdenServicio](
	[codEstadoOrdenServicio] [char](5) NOT NULL,
	[nombreEstado] [char](30) NULL,
	[descripcion] [char](250) NULL,
 CONSTRAINT [PK_estadosOrdenServicio] PRIMARY KEY CLUSTERED 
(
	[codEstadoOrdenServicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estadosOrdenPrestamo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estadosOrdenPrestamo](
	[codEstadoOrdenPrestamo] [int] NOT NULL,
	[nombreEstadoOP] [char](50) NULL,
	[descripcionEstadoOP] [varchar](50) NULL,
 CONSTRAINT [PK_estadosOrdenPrestamo] PRIMARY KEY CLUSTERED 
(
	[codEstadoOrdenPrestamo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estadosLLamadasTecnicas]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estadosLLamadasTecnicas](
	[codEstadoLlamada] [char](5) NOT NULL,
	[nombreEstado] [char](30) NULL,
 CONSTRAINT [PK_estadosLLamadasTecnicas] PRIMARY KEY CLUSTERED 
(
	[codEstadoLlamada] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estadoRecoleccion]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estadoRecoleccion](
	[codEstadoRecoleccion] [int] NOT NULL,
	[jerarquiaEstadoRecoleccion] [int] NULL,
	[nombreEstadoRecoleccion] [char](50) NULL,
 CONSTRAINT [PK_estadoRecoleccion] PRIMARY KEY CLUSTERED 
(
	[codEstadoRecoleccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estadoLocalEquipos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estadoLocalEquipos](
	[codEstadoLocal] [char](5) NOT NULL,
	[nombreEstadoLocal] [char](40) NOT NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_estadoLocalEquipos] PRIMARY KEY CLUSTERED 
(
	[codEstadoLocal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EstadoFisicamente]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EstadoFisicamente](
	[codEstadoFisicamente] [char](5) NOT NULL,
	[NombreestadoFisicamente] [char](30) NULL,
 CONSTRAINT [PK_EstadoFisicamente] PRIMARY KEY CLUSTERED 
(
	[codEstadoFisicamente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[estado_asesoria_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[estado_asesoria_cientifica](
	[cod_estado_asesoria_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado_asesoria_cientifica] [char](40) NOT NULL,
	[ind_1] [bit] NULL,
	[ind_2] [bit] NULL,
	[cod_manual] [char](10) NOT NULL,
 CONSTRAINT [PK_estado_asesoria_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_estado_asesoria_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[medioSolicitud]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[medioSolicitud](
	[codMedioSolicitud] [int] NOT NULL,
	[descripcionMedio] [char](30) NULL,
 CONSTRAINT [PK_medioSolicitud] PRIMARY KEY CLUSTERED 
(
	[codMedioSolicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dias_festivos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dias_festivos](
	[cod_dias_festivos] [int] IDENTITY(1,1) NOT NULL,
	[dia] [int] NOT NULL,
	[mes] [int] NOT NULL,
	[ano] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_dias_festivos] PRIMARY KEY CLUSTERED 
(
	[cod_dias_festivos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fotografia]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fotografia](
	[codFotografia] [int] NOT NULL,
	[nombreArchivo] [varchar](100) NOT NULL,
	[archivo] [image] NOT NULL,
 CONSTRAINT [PK_fotografias] PRIMARY KEY CLUSTERED 
(
	[codFotografia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[incumplimientoConsumo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[incumplimientoConsumo](
	[numeroContrato] [char](20) NOT NULL,
	[codIncumplimiento] [int] NOT NULL,
	[descripcion] [varchar](150) NULL,
	[Observaciones] [text] NULL,
	[creadoPor] [char](10) NULL,
	[fechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_incumplimientoConsumo] PRIMARY KEY CLUSTERED 
(
	[numeroContrato] ASC,
	[codIncumplimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inconveniente_presentado_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inconveniente_presentado_cientifica](
	[cod_inconveniente_presentado_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[nombre_inconveniente] [char](40) NOT NULL,
 CONSTRAINT [PK_inconveniente_presentado_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_inconveniente_presentado_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposModulos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposModulos](
	[codGrupoModulo] [char](10) NOT NULL,
	[nombreGrupoModulo] [char](30) NULL,
	[descripcion] [ntext] NULL,
 CONSTRAINT [PK_gruposModulos] PRIMARY KEY CLUSTERED 
(
	[codGrupoModulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposLineasConsumo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposLineasConsumo](
	[codGrupoLineaConsumo] [char](5) NOT NULL,
	[Descricpion] [char](30) NULL,
 CONSTRAINT [PK_gruposLineasConsumo] PRIMARY KEY CLUSTERED 
(
	[codGrupoLineaConsumo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposUsuarios](
	[codGruposUsu] [char](10) NOT NULL,
	[nombreGru] [varchar](100) NOT NULL,
	[descripcionGru] [ntext] NULL,
 CONSTRAINT [PK_gruposUsuarios] PRIMARY KEY CLUSTERED 
(
	[codGruposUsu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposModulosxUsuario]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposModulosxUsuario](
	[codGrupoModulo] [char](10) NOT NULL,
	[login] [char](10) NOT NULL,
	[controlTotal] [bit] NULL,
	[modificar] [bit] NULL,
	[lecturaEjecucion] [bit] NULL,
	[escribir] [bit] NULL,
	[eliminar] [bit] NULL,
	[imprimir] [bit] NULL,
	[denegar] [bit] NULL,
 CONSTRAINT [PK_gruposModulosxUsuario] PRIMARY KEY CLUSTERED 
(
	[codGrupoModulo] ASC,
	[login] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposModulosxGruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposModulosxGruposUsuarios](
	[codGrupoModulo] [char](10) NOT NULL,
	[codGruposUsu] [char](10) NOT NULL,
	[controlTotal] [bit] NULL,
	[modificar] [bit] NULL,
	[lecturaEjecucion] [bit] NULL,
	[escribir] [bit] NULL,
	[eliminar] [bit] NULL,
	[imprimir] [bit] NULL,
	[denegar] [bit] NULL,
 CONSTRAINT [PK_gruposModulosxGruposUsuarios] PRIMARY KEY CLUSTERED 
(
	[codGrupoModulo] ASC,
	[codGruposUsu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposCopiaxSmtpAccion]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposCopiaxSmtpAccion](
	[idCgSmtpAccion] [int] NOT NULL,
	[codGruposUsu] [char](10) NOT NULL,
 CONSTRAINT [PK_gruposCopiaxSmtpAccion] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpAccion] ASC,
	[codGruposUsu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposCopiaOcultaxSmtpAccion]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposCopiaOcultaxSmtpAccion](
	[idCgSmtpAccion] [int] NOT NULL,
	[codGruposUsu] [char](10) NOT NULL,
 CONSTRAINT [PK_gruposCopiaOcultaxSmtpAccion] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpAccion] ASC,
	[codGruposUsu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposxSmtpAccion]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[gruposxSmtpAccion](
	[codGruposUsu] [char](10) NOT NULL,
	[idCgSmtpAccion] [int] NOT NULL,
	[enviarSoloPropietario] [bit] NULL,
 CONSTRAINT [PK_gruposxSmtpAccion] PRIMARY KEY CLUSTERED 
(
	[codGruposUsu] ASC,
	[idCgSmtpAccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposXgrupos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposXgrupos](
	[codGruposUsu] [char](10) NOT NULL,
	[subordinadoDe] [char](10) NOT NULL,
 CONSTRAINT [PK_gruposXgrupos] PRIMARY KEY CLUSTERED 
(
	[codGruposUsu] ASC,
	[subordinadoDe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gruposUsuariosxUsuario]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gruposUsuariosxUsuario](
	[login] [char](10) NOT NULL,
	[codGruposUsu] [char](10) NOT NULL,
 CONSTRAINT [PK_gruposUsuariosxUsuario] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[codGruposUsu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[filtrosRpt]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[filtrosRpt](
	[idRpt] [int] NOT NULL,
	[codFiltroRpt] [int] NOT NULL,
	[codTipoFiltroRpt] [int] NULL,
	[nombre] [char](30) NULL,
	[campo] [char](50) NULL,
 CONSTRAINT [PK_filtrosRpt] PRIMARY KEY CLUSTERED 
(
	[idRpt] ASC,
	[codFiltroRpt] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[lineasConsumo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[lineasConsumo](
	[codGrupoLineaConsumo] [char](5) NOT NULL,
	[codLinea] [char](5) NOT NULL,
	[Descripcion] [char](50) NULL,
 CONSTRAINT [PK_lineasConsumo] PRIMARY KEY CLUSTERED 
(
	[codGrupoLineaConsumo] ASC,
	[codLinea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CGQ_ParametrosQuery]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CGQ_ParametrosQuery](
	[codQuery] [int] NOT NULL,
	[codParametrosQuery] [int] NOT NULL,
	[campo] [char](100) NULL,
	[caption] [char](100) NULL,
	[codTipoFiltro] [int] NULL,
 CONSTRAINT [PK_CGQ_ParametrosQuery] PRIMARY KEY CLUSTERED 
(
	[codQuery] ASC,
	[codParametrosQuery] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[archivosxRepuesto]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[archivosxRepuesto](
	[codRepuesto] [char](20) NOT NULL,
	[codArchivo] [int] IDENTITY(1,1) NOT NULL,
	[nombreArchivo] [varchar](150) NOT NULL,
	[archivo] [image] NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_archivosxRepuesto] PRIMARY KEY CLUSTERED 
(
	[codArchivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[archivosxIncumplimiento]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[archivosxIncumplimiento](
	[numeroContrato] [char](20) NOT NULL,
	[codIncumplimiento] [int] NOT NULL,
	[codArchivo] [int] NOT NULL,
	[nombreArchivo] [char](30) NULL,
	[descripcion] [varchar](250) NULL,
	[archivo] [image] NULL,
 CONSTRAINT [PK_archivosxIncumplimiento] PRIMARY KEY CLUSTERED 
(
	[numeroContrato] ASC,
	[codIncumplimiento] ASC,
	[codArchivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[actividad_adicional]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[actividad_adicional](
	[cod_actividad_adicional] [int] IDENTITY(1,1) NOT NULL,
	[fecha_inicio] [datetime] NOT NULL,
	[fecha_fin] [datetime] NOT NULL,
	[nombre_actividad] [varchar](150) NOT NULL,
	[descripcion_actividad] [varchar](850) NULL,
	[ubicacion] [varchar](50) NULL,
	[cod_tipo_actividad] [int] NOT NULL,
	[login] [char](10) NOT NULL,
 CONSTRAINT [PK_actividad_adicional] PRIMARY KEY CLUSTERED 
(
	[cod_actividad_adicional] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[accion_seguirxseguimiento_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accion_seguirxseguimiento_cientifica](
	[cod_accion_seguirxseguimiento_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[cod_seguimiento_asesoria_cientifica] [int] NOT NULL,
	[cod_accion_seguir_cientifica] [int] NOT NULL,
 CONSTRAINT [PK_accion_seguirxseguimiento_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_accion_seguirxseguimiento_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cgSmtpEmailTo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpEmailTo](
	[idCgSmtpEmail] [int] NOT NULL,
	[idCgSmtpEmailTo] [int] NOT NULL,
	[nombreEmail] [varchar](250) NULL,
	[email] [varchar](250) NULL,
 CONSTRAINT [PK_cgSmtpEmailTo] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpEmailTo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cgSmtpEmailCCO]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpEmailCCO](
	[idCgSmtpEmail] [int] NOT NULL,
	[idCgSmtpEmailCCO] [int] NOT NULL,
	[nombreEmail] [varchar](250) NULL,
	[email] [varchar](250) NULL,
 CONSTRAINT [PK_cgSmtpEmailCCO] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpEmailCCO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cgSmtpEmailCC]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpEmailCC](
	[idCgSmtpEmail] [int] NOT NULL,
	[idCgSmtpEmailCC] [int] NOT NULL,
	[nombreEmail] [varchar](250) NULL,
	[email] [varchar](250) NULL,
 CONSTRAINT [PK_cgSmtpEmailCC] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpEmailCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cgSmtpAdjuntos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpAdjuntos](
	[idCgSmtpEmail] [int] NOT NULL,
	[idCgSmtpAdjuntos] [int] NOT NULL,
	[nombreAdjunto] [varchar](250) NULL,
	[archivo] [image] NULL,
 CONSTRAINT [PK_cgSmtpAdjuntos] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpAdjuntos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cgSmtpServerCCO]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpServerCCO](
	[idCgSmtpServer] [int] NOT NULL,
	[idCgSmtpServerCCO] [int] NOT NULL,
	[nombreEmail] [varchar](250) NULL,
	[email] [varchar](250) NULL,
 CONSTRAINT [PK_cgSmtpServerCCO] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpServerCCO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cgSmtpServerCC]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[cgSmtpServerCC](
	[idCgSmtpServer] [int] NOT NULL,
	[idCgSmtpServerCC] [int] NOT NULL,
	[nombreEmail] [varchar](250) NULL,
	[email] [varchar](250) NULL,
 CONSTRAINT [PK_cgSmtpServerCC] PRIMARY KEY CLUSTERED 
(
	[idCgSmtpServerCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[nitCliente] [char](20) NOT NULL,
	[nombreCliente] [varchar](100) NOT NULL,
	[logotipo] [image] NULL,
	[nombreContactoPrincipal] [char](20) NULL,
	[apellidosContacto] [char](20) NULL,
	[docContacto] [char](15) NULL,
	[codTipoDoc] [char](5) NULL,
	[tituloContacto] [char](5) NULL,
	[telefono1] [char](25) NULL,
	[telefono2] [char](25) NULL,
	[fax] [char](25) NULL,
	[celular] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[numeroSocio] [char](20) NULL,
	[esLocal] [bit] NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[nitCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contactosClientes]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contactosClientes](
	[nitCliente] [char](20) NOT NULL,
	[codContacto] [char](20) NOT NULL,
	[nombreContacto] [char](20) NOT NULL,
	[apellidosContacto] [char](20) NOT NULL,
	[docContacto] [char](15) NULL,
	[codTipoDoc] [char](5) NULL,
	[tituloContacto] [char](5) NULL,
	[telefono1] [char](25) NOT NULL,
	[telefono2] [char](25) NULL,
	[fax] [char](25) NULL,
	[celular] [char](50) NULL,
	[email] [varchar](50) NULL,
	[paginaWeb] [varchar](50) NULL,
	[cumpleanos] [datetime] NULL,
 CONSTRAINT [PK_contactosClientes] PRIMARY KEY CLUSTERED 
(
	[nitCliente] ASC,
	[codContacto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[departamento](
	[codPais] [char](5) NOT NULL,
	[codDepartamento] [char](5) NOT NULL,
	[NombreDepartamento] [varchar](30) NULL,
 CONSTRAINT [PK_departamento] PRIMARY KEY CLUSTERED 
(
	[codPais] ASC,
	[codDepartamento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[referencia_reactivo]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[referencia_reactivo](
	[cod_referencia_reactivo] [int] IDENTITY(1,1) NOT NULL,
	[codFabricante] [char](5) NOT NULL,
	[codigo_manual] [char](10) NULL,
	[nombre_referencia_reactivo] [char](50) NOT NULL,
 CONSTRAINT [PK_referencia_reactivo] PRIMARY KEY CLUSTERED 
(
	[cod_referencia_reactivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[parametrosxCgSmtpAccion]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[parametrosxCgSmtpAccion](
	[idCgSmtpAccion] [int] NULL,
	[idParametroxCgSmtpAccion] [int] NOT NULL,
	[parametro] [varchar](250) NULL,
 CONSTRAINT [PK_parametrosxCgSmtpAccion] PRIMARY KEY CLUSTERED 
(
	[idParametroxCgSmtpAccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[programacionViajes]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[programacionViajes](
	[codProgramacionViajes] [int] NOT NULL,
	[fechaCreacion] [datetime] NULL,
	[creadoPor] [char](10) NULL,
	[fechaViaje] [datetime] NULL,
	[fechaRegreso] [datetime] NULL,
	[ingenieroAsignado] [char](10) NULL,
	[programada] [bit] NULL,
	[codPais] [char](5) NULL,
	[codDepartamento] [char](5) NULL,
	[codCiudad] [char](5) NULL,
	[observaciones] [varchar](250) NULL,
	[codAsesor] [int] NULL,
 CONSTRAINT [PK_programacionViajes] PRIMARY KEY CLUSTERED 
(
	[codProgramacionViajes] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modalidadContrato]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modalidadContrato](
	[codModalidadContrato] [char](5) NOT NULL,
	[codTipoContrato] [char](5) NOT NULL,
	[nombreModalidadContrato] [char](30) NULL,
	[desccripcion] [ntext] NULL,
 CONSTRAINT [PK_modalidadContrato] PRIMARY KEY CLUSTERED 
(
	[codModalidadContrato] ASC,
	[codTipoContrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modulos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modulos](
	[codModulo] [char](10) NOT NULL,
	[codGrupoModulo] [char](10) NULL,
	[nombreMod] [varchar](100) NOT NULL,
	[linkMod] [varchar](300) NULL,
	[descripcionMod] [ntext] NULL,
	[esDeshabilitado] [bit] NULL,
 CONSTRAINT [PK_modulos] PRIMARY KEY CLUSTERED 
(
	[codModulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarioCopiaxSmtpAccion]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[usuarioCopiaxSmtpAccion](
	[login] [char](10) NOT NULL,
	[idCgSmtpAccion] [int] NOT NULL,
 CONSTRAINT [PK_usuarioCopiaxSmtpAccion] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[idCgSmtpAccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarioCopiaOcultaxSmtpAccion]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[usuarioCopiaOcultaxSmtpAccion](
	[login] [char](10) NOT NULL,
	[idCgSmtpAccion] [int] NOT NULL,
 CONSTRAINT [PK_usuarioCopiaOcultaxSmtpAccion] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[idCgSmtpAccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subTipoEquipo]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subTipoEquipo](
	[codTipoEquipo] [char](5) NOT NULL,
	[codSubtipoEquipo] [char](5) NOT NULL,
	[nombreSubTipo] [char](100) NULL,
 CONSTRAINT [PK_subTipoEquipo] PRIMARY KEY CLUSTERED 
(
	[codTipoEquipo] ASC,
	[codSubtipoEquipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subTipoComponente]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subTipoComponente](
	[codTipoComponente] [char](5) NOT NULL,
	[codSubTipoCom] [char](5) NOT NULL,
	[nombreSubTipocom] [char](30) NULL,
 CONSTRAINT [PK_subTipoComponente] PRIMARY KEY CLUSTERED 
(
	[codTipoComponente] ASC,
	[codSubTipoCom] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarioxSmtpAccion]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[usuarioxSmtpAccion](
	[login] [char](10) NOT NULL,
	[idCgSmtpAccion] [int] NOT NULL,
	[enviarSoloPropietario] [bit] NULL,
 CONSTRAINT [PK_usuarioxSmtpAccion] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[idCgSmtpAccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuariosXusuarios]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuariosXusuarios](
	[login] [char](10) NOT NULL,
	[subordinadoDe] [char](10) NOT NULL,
 CONSTRAINT [PK_usuariosXusuarios] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[subordinadoDe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[task]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[task](
	[codTarea] [int] NOT NULL,
	[loginAutor] [char](10) NULL,
	[codCategoria] [char](10) NULL,
	[loginPropietario] [char](10) NULL,
	[fechaCreacion] [datetime] NULL,
	[fechaInicio] [datetime] NULL,
	[fechaVencimiento] [datetime] NULL,
	[codEstatus] [char](10) NULL,
	[codPrioridad] [char](10) NULL,
	[pcCompletado] [int] NULL,
	[asunto] [varchar](250) NULL,
	[cuerpo] [ntext] NULL,
	[esCompletada] [bit] NULL,
	[esAprobada] [bit] NULL,
	[conservarEnPropias] [bit] NULL,
	[notificarFin] [bit] NULL,
	[esPrivada] [bit] NULL,
	[codTareaCompartida] [int] NULL,
	[aceptada] [bit] NULL,
	[asociadoA] [varchar](100) NULL,
	[fechaFinalizacion] [datetime] NULL,
	[fechaAprobacion] [datetime] NULL,
	[visibleAutor] [bit] NULL,
	[visiblePropietario] [bit] NULL,
	[parametrosInternos] [char](40) NULL,
 CONSTRAINT [PK_task] PRIMARY KEY CLUSTERED 
(
	[codTarea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[taskAdjuntos]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[taskAdjuntos](
	[codTarea] [int] NOT NULL,
	[codAdjunto] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[archivo] [image] NULL,
 CONSTRAINT [PK_taskAdjuntos] PRIMARY KEY CLUSTERED 
(
	[codTarea] ASC,
	[codAdjunto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaskReminder]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskReminder](
	[codReminder] [int] NOT NULL,
	[codTarea] [int] NOT NULL,
	[fechaReminder] [datetime] NULL,
 CONSTRAINT [PK_Reminder] PRIMARY KEY CLUSTERED 
(
	[codReminder] ASC,
	[codTarea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taskPatronRecurrencia]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[taskPatronRecurrencia](
	[codTarea] [int] NOT NULL,
	[codPatron] [int] NOT NULL,
	[diaria] [bit] NULL,
	[diariaCada] [bit] NULL,
	[diariaCadaDias] [int] NULL,
	[diariaSemanal] [bit] NULL,
	[semanal] [bit] NULL,
	[semLunes] [bit] NULL,
	[semMartes] [bit] NULL,
	[semMiercoles] [bit] NULL,
	[semJueves] [bit] NULL,
	[semViernes] [bit] NULL,
	[semSabado] [bit] NULL,
	[semDomingo] [bit] NULL,
	[Mensual] [bit] NULL,
	[menElDia] [bit] NULL,
	[menEldiaDia] [int] NULL,
	[menEldiaCada] [int] NULL,
	[menEl] [bit] NULL,
	[menElOrdenDia] [char](20) NULL,
	[menElNombreDia] [char](20) NULL,
	[menElCada] [int] NULL,
	[anual] [bit] NULL,
	[anuCada] [bit] NULL,
	[anuCadaMes] [char](20) NULL,
	[anuCadaDia] [char](20) NULL,
	[anuEl] [bit] NULL,
	[anuElOrden] [char](20) NULL,
	[anuElDia] [char](20) NULL,
	[anuElMes] [char](20) NULL,
	[inicia] [datetime] NULL,
	[sinFechaFin] [bit] NULL,
	[finalizaDespues] [bit] NULL,
	[finalizaOcurrencias] [int] NULL,
	[finalizaElDia] [bit] NULL,
	[finalizaDia] [datetime] NULL,
	[ultimoAviso] [datetime] NULL,
 CONSTRAINT [PK_taskPatronRecurrencia] PRIMARY KEY CLUSTERED 
(
	[codTarea] ASC,
	[codPatron] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[subCategoriaComponente]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[subCategoriaComponente](
	[codTipoComponente] [char](5) NOT NULL,
	[codSubTipoComponente] [char](5) NOT NULL,
	[codSubCategoriaCom] [char](5) NOT NULL,
	[nombreSubCategoriaCom] [char](30) NULL,
 CONSTRAINT [PK_subCategoriaComponente] PRIMARY KEY CLUSTERED 
(
	[codTipoComponente] ASC,
	[codSubTipoComponente] ASC,
	[codSubCategoriaCom] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modelos](
	[codFabricante] [char](5) NOT NULL,
	[codModelo] [char](5) NOT NULL,
	[NombreModelo] [varchar](30) NULL,
	[descripcion] [ntext] NULL,
	[fotografia] [image] NULL,
	[nombreManual] [varchar](150) NULL,
	[manual] [image] NULL,
	[codTipoEquipo] [char](5) NULL,
	[codSubTipoEquipo] [char](5) NULL,
	[voltaje] [char](10) NULL,
	[watios] [char](10) NULL,
	[amperios] [char](10) NULL,
	[frecuencia] [char](10) NULL,
	[duracionmantenimiento] [float] NULL,
	[diasxMantenimiento] [int] NULL,
	[mesesxMantenimiento] [int] NULL,
	[pesoEstimado] [numeric](18, 2) NULL,
	[codUnidadPeso] [int] NULL,
 CONSTRAINT [PK_Modelos] PRIMARY KEY CLUSTERED 
(
	[codFabricante] ASC,
	[codModelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modulosxUsuario]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modulosxUsuario](
	[codModulo] [char](10) NOT NULL,
	[login] [char](10) NOT NULL,
	[controlTotal] [bit] NULL,
	[modificar] [bit] NULL,
	[lecturaEjecucion] [bit] NULL,
	[escribir] [bit] NULL,
	[eliminar] [bit] NULL,
	[imprimir] [bit] NULL,
	[denegar] [bit] NULL,
 CONSTRAINT [PK_modulosxUsuario] PRIMARY KEY CLUSTERED 
(
	[codModulo] ASC,
	[login] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modulosxGruposUsuario]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modulosxGruposUsuario](
	[codModulo] [char](10) NOT NULL,
	[codGruposUsu] [char](10) NOT NULL,
	[controlTotal] [bit] NULL,
	[modificar] [bit] NULL,
	[lecturaEjecucion] [bit] NULL,
	[escribir] [bit] NULL,
	[eliminar] [bit] NULL,
	[imprimir] [bit] NULL,
	[denegar] [bit] NULL,
 CONSTRAINT [PK_modulosxGruposUsuario] PRIMARY KEY CLUSTERED 
(
	[codModulo] ASC,
	[codGruposUsu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contratos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contratos](
	[numeroContrato] [char](40) NOT NULL,
	[codOtroSi] [int] NOT NULL,
	[nitCliente] [char](20) NULL,
	[codTipoContrato] [char](5) NULL,
	[incluyeRepuestos] [bit] NULL,
	[NumeroMantenimientos] [int] NULL,
	[incluyeTiquetes] [bit] NULL,
	[tienePolizaConsumoMinimo] [bit] NULL,
	[consumoMinimoxLinea] [bit] NULL,
	[consumoMinimoGeneral] [bit] NULL,
	[consumoMinimoAcordado] [money] NULL,
	[fechaInicioContrato] [datetime] NULL,
	[mesesxMantenimiento] [int] NULL,
	[Observaciones] [ntext] NULL,
	[fechaFinContrato] [datetime] NULL,
	[timeRptaDiasHabiles] [int] NULL,
	[timeRptaHorasHabiles] [int] NULL,
	[porcentajeTiquetes] [int] NULL,
	[consumoMinimoTotalLinea] [money] NULL,
	[codModalidadContrato] [char](5) NULL,
	[montoContrato] [money] NULL,
	[loginCreacion] [char](10) NULL,
	[fechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_contratos] PRIMARY KEY CLUSTERED 
(
	[numeroContrato] ASC,
	[codOtroSi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[consumoContratoxLinea]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[consumoContratoxLinea](
	[numeroContrato] [char](20) NOT NULL,
	[codGrupoLineaConsumo] [char](5) NOT NULL,
	[codLinea] [char](5) NOT NULL,
	[codGrupo] [int] NULL,
	[montoConsumo] [money] NULL,
 CONSTRAINT [PK_consumoContratoxLinea] PRIMARY KEY CLUSTERED 
(
	[numeroContrato] ASC,
	[codGrupoLineaConsumo] ASC,
	[codLinea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ciudades]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ciudades](
	[codPais] [char](5) NOT NULL,
	[codDepartamento] [char](5) NOT NULL,
	[codCiudad] [char](5) NOT NULL,
	[nombreCiudad] [varchar](30) NULL,
 CONSTRAINT [PK_ciudades_1] PRIMARY KEY CLUSTERED 
(
	[codPais] ASC,
	[codDepartamento] ASC,
	[codCiudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ActividadesxModelo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ActividadesxModelo](
	[codFabricante] [char](5) NOT NULL,
	[codModelo] [char](5) NOT NULL,
	[codActividad] [int] NOT NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [PK_ActividadesxModelo] PRIMARY KEY CLUSTERED 
(
	[codFabricante] ASC,
	[codModelo] ASC,
	[codActividad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[accesoriosEquipo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[accesoriosEquipo](
	[codAccesoriosEquipos] [char](15) NOT NULL,
	[nombreAccesorio] [char](50) NULL,
	[descripcion] [varchar](250) NULL,
	[codFabricante] [char](5) NULL,
	[codModelo] [char](5) NULL,
	[codFoto] [int] NULL,
 CONSTRAINT [PK_accesoriosEquipo] PRIMARY KEY CLUSTERED 
(
	[codAccesoriosEquipos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[archivosxcontrato]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[archivosxcontrato](
	[numeroContrato] [char](40) NOT NULL,
	[codOtroSi] [int] NOT NULL,
	[codArchivo] [int] NOT NULL,
	[nombreArchivo] [char](50) NULL,
	[archivo] [image] NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_archivosxcontrato] PRIMARY KEY CLUSTERED 
(
	[numeroContrato] ASC,
	[codOtroSi] ASC,
	[codArchivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[componente]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[componente](
	[codFabricante] [char](5) NOT NULL,
	[codComponente] [char](15) NOT NULL,
	[nombreComponente] [char](30) NULL,
	[frecuenciaMantenimiento] [int] NULL,
	[codtipoComponente] [char](5) NULL,
	[codSubTipoComponente] [char](5) NULL,
	[codsubCategoriaCom] [char](5) NULL,
	[fotografia] [image] NULL,
	[descripcion] [ntext] NULL,
 CONSTRAINT [PK_componente] PRIMARY KEY CLUSTERED 
(
	[codFabricante] ASC,
	[codComponente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[archivosxModelo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[archivosxModelo](
	[codFabricante] [char](5) NOT NULL,
	[codModelo] [char](5) NOT NULL,
	[codArchivo] [int] NOT NULL,
	[nombreArchivo] [varchar](150) NULL,
	[archivo] [image] NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_archivosxModelo] PRIMARY KEY CLUSTERED 
(
	[codFabricante] ASC,
	[codModelo] ASC,
	[codArchivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[problemas_frecuentes]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[problemas_frecuentes](
	[cod_problema_frecuente] [int] IDENTITY(1,1) NOT NULL,
	[codFabricante] [char](5) NULL,
	[codModelo] [char](5) NULL,
	[cod_manual] [char](40) NULL,
	[nombre_problema] [char](50) NULL,
	[descripcion] [varchar](5000) NULL,
 CONSTRAINT [PK_problemas_frecuentes] PRIMARY KEY CLUSTERED 
(
	[cod_problema_frecuente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[regionesXusuarios]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[regionesXusuarios](
	[login] [char](10) NOT NULL,
	[codPais] [char](5) NOT NULL,
	[codDepartamento] [char](5) NOT NULL,
	[codCiudad] [char](5) NOT NULL,
 CONSTRAINT [PK_regionesXusuarios] PRIMARY KEY CLUSTERED 
(
	[login] ASC,
	[codPais] ASC,
	[codDepartamento] ASC,
	[codCiudad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[repuestosxContratos]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[repuestosxContratos](
	[numeroContrato] [char](40) NOT NULL,
	[codOtroSi] [int] NOT NULL,
	[codRepuesto] [char](20) NOT NULL,
	[cantidad] [int] NULL,
	[observaciones] [varchar](250) NULL,
 CONSTRAINT [PK_repuestosxContrato] PRIMARY KEY CLUSTERED 
(
	[numeroContrato] ASC,
	[codOtroSi] ASC,
	[codRepuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sucursalCliente]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sucursalCliente](
	[nitCliente] [char](20) NOT NULL,
	[codSucursal] [char](5) NOT NULL,
	[nombreSucursal] [varchar](50) NULL,
	[codPais] [char](5) NULL,
	[codDepartamento] [char](5) NULL,
	[codCiudad] [char](5) NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono1] [char](15) NULL,
	[Telefono2] [char](15) NULL,
	[codContacto] [char](20) NULL,
 CONSTRAINT [PK_sucursalCliente] PRIMARY KEY CLUSTERED 
(
	[nitCliente] ASC,
	[codSucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[soluciones_problemas]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[soluciones_problemas](
	[cod_soluciones_problemas] [int] IDENTITY(1,1) NOT NULL,
	[cod_problema_frecuente] [int] NULL,
	[nombre_solucion] [varchar](45) NULL,
	[descripcion_solucion] [varchar](5000) NULL,
 CONSTRAINT [PK_soluciones_problemas] PRIMARY KEY CLUSTERED 
(
	[cod_soluciones_problemas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[componentesxmodelos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[componentesxmodelos](
	[codFabricanteCom] [char](5) NOT NULL,
	[codComponente] [char](15) NOT NULL,
	[codFabricante] [char](5) NOT NULL,
	[codModelo] [char](5) NOT NULL,
 CONSTRAINT [PK_componentesxmodelos] PRIMARY KEY CLUSTERED 
(
	[codFabricanteCom] ASC,
	[codComponente] ASC,
	[codFabricante] ASC,
	[codModelo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ArchivosxComponente]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArchivosxComponente](
	[codFabricante] [char](5) NOT NULL,
	[codComponente] [char](15) NOT NULL,
	[codArchivo] [int] NOT NULL,
	[nombreArchivo] [varchar](150) NULL,
	[Archivo] [image] NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_ArchivosxComponente] PRIMARY KEY CLUSTERED 
(
	[codFabricante] ASC,
	[codComponente] ASC,
	[codArchivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[logCambioUbicaciones]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[logCambioUbicaciones](
	[codLog] [int] NOT NULL,
	[nitClienteOrigen] [char](20) NULL,
	[codSucursalOrigen] [char](5) NULL,
	[nitClienteDestino] [char](20) NULL,
	[codSucursalDestino] [char](5) NULL,
	[fechaCambio] [datetime] NULL,
	[usuarioCambio] [char](10) NULL,
	[serial] [char](30) NULL,
	[razon] [text] NULL,
	[fechaEnvio] [datetime] NULL,
 CONSTRAINT [PK_logCambioUbicaciones] PRIMARY KEY CLUSTERED 
(
	[codLog] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[equipos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[equipos](
	[codFabricante] [char](5) NOT NULL,
	[codModelo] [char](5) NOT NULL,
	[serial] [char](30) NOT NULL,
	[fechaLlegada] [datetime] NULL,
	[fechaSalida] [datetime] NULL,
	[fechaProximoMante] [datetime] NULL,
	[fechaUltimoMante] [datetime] NULL,
	[nitClienteUbica] [char](20) NULL,
	[codSucursalUbica] [char](5) NULL,
	[codTipoServicio] [char](5) NULL,
	[observacionesUltimoMante] [varchar](250) NULL,
	[codModalidadEquipo] [char](5) NULL,
	[codEstadoLocal] [char](5) NULL,
	[fechaProximaProgramacion] [datetime] NULL,
	[fechaUltimoTraslado] [datetime] NULL,
	[Codadicional] [char](50) NULL,
	[obsequipo] [ntext] NULL,
	[codTipoPropiedad] [int] NULL,
	[fechaCambioTipoPropiedad] [datetime] NULL,
	[usuarioCambio] [char](10) NULL,
 CONSTRAINT [PK_equipos_1] PRIMARY KEY CLUSTERED 
(
	[serial] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[equipoAuxiliar]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[equipoAuxiliar](
	[serialEquipo] [char](30) NOT NULL,
	[serialAuxiliar] [char](30) NOT NULL,
	[Observaciones] [text] NULL,
 CONSTRAINT [PK_equipoAuxiliar] PRIMARY KEY CLUSTERED 
(
	[serialEquipo] ASC,
	[serialAuxiliar] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntradaSalidaEquipos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EntradaSalidaEquipos](
	[codEntradaSalidaEquipos] [int] NOT NULL,
	[fechaEntrada] [datetime] NULL,
	[fechaSalida] [datetime] NULL,
	[serial] [char](30) NULL,
	[codEstadoFisicamente] [char](5) NULL,
	[codOrdenServicio] [int] NULL,
	[codTiposervicio] [char](5) NULL,
	[obsEntrada] [ntext] NULL,
	[obsSalida] [ntext] NULL,
	[nitcliente] [char](20) NULL,
	[codSucursal] [char](5) NULL,
	[codModalidad] [char](5) NULL,
	[fechaTerminacionMovto] [datetime] NULL,
	[creadoPor] [char](10) NULL,
	[fechaIngresoSeguimiento] [datetime] NULL,
	[fechaSeguimiento] [datetime] NULL,
	[usuarioSeguimiento] [char](10) NULL,
	[observaciones] [ntext] NULL,
	[funcionabien] [bit] NULL,
	[nitClienteSalida] [char](20) NULL,
	[codSucursalSalida] [char](5) NULL,
	[codModalidadSalida] [char](5) NULL,
	[codEstadoSalida] [char](5) NULL,
	[op] [char](30) NULL,
	[factura] [char](30) NULL,
	[fechaEntradaSistema] [datetime] NULL,
 CONSTRAINT [PK_EntradaSalidaEquipos] PRIMARY KEY CLUSTERED 
(
	[codEntradaSalidaEquipos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[mantenimientosxContrato]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[mantenimientosxContrato](
	[numeroContrato] [char](40) NOT NULL,
	[codOtroSi] [int] NOT NULL,
	[serial] [char](30) NOT NULL,
	[codMantenimientoxContrato] [int] NOT NULL,
	[codOrdenServicio] [int] NULL,
	[fechaMantenimiento] [datetime] NULL,
 CONSTRAINT [PK_mantenimientosxContrato] PRIMARY KEY CLUSTERED 
(
	[numeroContrato] ASC,
	[codOtroSi] ASC,
	[serial] ASC,
	[codMantenimientoxContrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[archivosXequipo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[archivosXequipo](
	[serial] [char](30) NOT NULL,
	[codArchivo] [int] NOT NULL,
	[nombreArchivo] [char](150) NULL,
	[archivo] [image] NULL,
	[descripcion] [varchar](250) NULL,
	[codTipoArchivoxEquipo] [char](5) NULL,
 CONSTRAINT [PK_archivosXequipo] PRIMARY KEY CLUSTERED 
(
	[serial] ASC,
	[codArchivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[contratosxEquipo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contratosxEquipo](
	[serial] [char](30) NOT NULL,
	[codOtroSi] [int] NOT NULL,
	[numeroContrato] [char](40) NOT NULL,
	[mantenimientosRealizados] [int] NULL,
	[mantenimientosxContrato] [int] NULL,
	[esActivo] [bit] NULL,
 CONSTRAINT [PK_contratosxEquipo] PRIMARY KEY CLUSTERED 
(
	[serial] ASC,
	[codOtroSi] ASC,
	[numeroContrato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ordenServicio]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ordenServicio](
	[codOrdenServicio] [int] NOT NULL,
	[fechaCreacion] [datetime] NULL,
	[fechaProgramacion] [datetime] NULL,
	[fechaFinProgramacion] [datetime] NULL,
	[fechaCierre] [datetime] NULL,
	[fechaAprobacion] [datetime] NULL,
	[fechaAnulacion] [datetime] NULL,
	[creadaPor] [char](10) NULL,
	[asignadoA] [char](10) NULL,
	[cerradaPor] [char](10) NULL,
	[aprobadaPor] [char](10) NULL,
	[anuladaPor] [char](10) NULL,
	[esInterno] [bit] NULL,
	[serial] [char](30) NULL,
	[nitCliente] [char](20) NULL,
	[codSucursal] [char](5) NULL,
	[codTiposervicio] [char](5) NULL,
	[codModalidad] [char](5) NULL,
	[codEstadoOrdenServicio] [char](5) NULL,
	[codPrioridadOS] [int] NULL,
	[observaciones] [varchar](500) NULL,
	[observacionesIngeniero] [varchar](500) NULL,
	[fallasReportadas] [varchar](500) NULL,
	[diagnostico] [varchar](500) NULL,
	[numEntrada] [int] NULL,
	[horaEntradaControl] [char](15) NULL,
	[horaSalidaControl] [char](15) NULL,
	[nombreUsuarioCliente] [char](40) NULL,
	[codAsesor] [int] NULL,
 CONSTRAINT [PK_ordenServicio] PRIMARY KEY CLUSTERED 
(
	[codOrdenServicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[recoleccion]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[recoleccion](
	[codRecoleccion] [int] NOT NULL,
	[codEstadoRecoleccion] [int] NULL,
	[nitCliente] [char](20) NULL,
	[codSucursal] [char](5) NULL,
	[codModalidad] [char](5) NULL,
	[serial] [char](30) NULL,
	[fechaSolicitud] [datetime] NULL,
	[solicitadoPor] [char](10) NULL,
	[observacionesSolicitud] [text] NULL,
	[motivoRecoleccion] [text] NULL,
	[fechaTentativaLlegada] [datetime] NULL,
	[responsableRecoleccion] [char](10) NULL,
	[codTransportadora] [int] NULL,
	[codRecoleccionTransportadora] [char](30) NULL,
	[nroGuia] [char](30) NULL,
	[obsIniciales] [text] NULL,
	[confirmada] [bit] NULL,
	[confirmadaPor] [char](10) NULL,
	[fechaConfirmacion] [datetime] NULL,
	[obsConfirmacion] [text] NULL,
	[fechaRecoleccion] [datetime] NULL,
	[codEntradaSalidaEquipos] [int] NULL,
 CONSTRAINT [PK_recoleccion] PRIMARY KEY CLUSTERED 
(
	[codRecoleccion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[solicitudServicio]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[solicitudServicio](
	[codSolicitudServicio] [int] NOT NULL,
	[fechaCreacion] [datetime] NULL,
	[fechaSugerida] [datetime] NULL,
	[fechaAceptacion] [datetime] NULL,
	[creadaPor] [char](10) NULL,
	[aceptadaPor] [char](10) NULL,
	[aceptada] [bit] NULL,
	[serial] [char](30) NULL,
	[nitCliente] [char](20) NULL,
	[codSucursal] [char](5) NULL,
	[codTipoServicio] [char](5) NULL,
	[codModalidad] [char](5) NULL,
	[codEstadoSolicitud] [int] NULL,
	[codPrioridadSolicitud] [int] NULL,
	[objetoServicio] [varchar](500) NULL,
	[fallasReportadas] [varchar](500) NULL,
	[Observaciones] [varchar](500) NULL,
	[codAsesor] [int] NULL,
	[codMedioSolicitud] [int] NULL,
	[codOrdenServicio] [int] NULL,
	[cod_asesoria_cientifica] [int] NULL,
 CONSTRAINT [PK_solicitudServicio] PRIMARY KEY CLUSTERED 
(
	[codSolicitudServicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[solicitudInsumos]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[solicitudInsumos](
	[codOrdenServicio] [int] NOT NULL,
	[codSolicitud] [int] NOT NULL,
	[aceptada] [bit] NULL,
	[aprobadaPor] [char](10) NULL,
	[fechaAprobacion] [datetime] NULL,
	[numeroFactura] [char](30) NULL,
	[horasMantPreventivo] [float] NULL,
	[horasMantCorrectivo] [float] NULL,
	[tiempoEstimadoEntrega] [int] NULL,
	[observaciones] [varchar](350) NULL,
	[fechaSolicitud] [datetime] NULL,
	[horasDiagnostico] [float] NULL,
	[autorizadoPor] [char](10) NULL,
	[autorizado] [bit] NULL,
	[fechaAutorizacion] [datetime] NULL,
	[codUnidadTiempo] [int] NULL,
 CONSTRAINT [PK_solicitudInsumos] PRIMARY KEY CLUSTERED 
(
	[codOrdenServicio] ASC,
	[codSolicitud] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleProgramacionViajes]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[detalleProgramacionViajes](
	[codProgramacionViajes] [int] NOT NULL,
	[codDetalleProgramacionViajes] [int] NOT NULL,
	[codOrdenServicio] [int] NULL,
	[confirmado] [bit] NULL,
	[serial] [char](30) NULL,
	[fechaInicio] [datetime] NULL,
	[fechaFin] [datetime] NULL,
	[codTipoServicio] [char](5) NULL
) ON [PRIMARY]
SET ANSI_PADDING ON
ALTER TABLE [dbo].[detalleProgramacionViajes] ADD [codPrioridadOS] [char](5) NULL
ALTER TABLE [dbo].[detalleProgramacionViajes] ADD [observaciones] [varchar](250) NULL
ALTER TABLE [dbo].[detalleProgramacionViajes] ADD  CONSTRAINT [PK_detalleProgramacionViajes] PRIMARY KEY CLUSTERED 
(
	[codProgramacionViajes] ASC,
	[codDetalleProgramacionViajes] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reasignacionOrdenesTrabajo]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reasignacionOrdenesTrabajo](
	[codOrdenServicio] [int] NOT NULL,
	[codReasignacion] [int] NOT NULL,
	[loginOriginal] [char](10) NULL,
	[loginNuevo] [nchar](10) NULL,
	[fechaReAsignacion] [datetime] NULL,
	[motivoReasignacion] [varchar](350) NULL,
	[reasignadoPor] [char](10) NULL,
 CONSTRAINT [PK_reasignacionOrdenesTrabajo] PRIMARY KEY CLUSTERED 
(
	[codOrdenServicio] ASC,
	[codReasignacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[repuestoxOrdenServicio]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[repuestoxOrdenServicio](
	[codOrdenServicio] [int] NOT NULL,
	[codRepuesto] [char](20) NOT NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_repuestoxOrdenServicio] PRIMARY KEY CLUSTERED 
(
	[codOrdenServicio] ASC,
	[codRepuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrdenPrestamo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrdenPrestamo](
	[codOrdenPrestamo] [int] NOT NULL,
	[loginResponsable] [char](10) NULL,
	[loginSolicito] [char](10) NULL,
	[loginAutorizo] [char](10) NULL,
	[loginAceptado] [char](10) NULL,
	[loginRecibido] [char](10) NULL,
	[loginAnulo] [char](10) NULL,
	[fechaOrden] [datetime] NULL,
	[fechaDevolucion] [datetime] NULL,
	[codPais] [char](5) NULL,
	[codDepartamento] [char](5) NULL,
	[codCiudad] [char](5) NULL,
	[codOrdenServicio] [int] NULL,
	[anulada] [bit] NULL,
	[obsIniciales] [ntext] NULL,
	[obsAprobacion] [ntext] NULL,
	[obsEntrega] [ntext] NULL,
	[obsDevolucion] [ntext] NULL,
	[codEstadoOrdenPrestamo] [int] NULL,
	[numeroFactura] [varchar](50) NULL,
	[numeroNotaSalida] [varchar](50) NULL,
 CONSTRAINT [PK_OrdenPrestamo] PRIMARY KEY CLUSTERED 
(
	[codOrdenPrestamo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[comprobantesAceptacionOrdenservicio]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comprobantesAceptacionOrdenservicio](
	[codComprobantesAceptacionOrdenservicio] [int] NOT NULL,
	[codOrdenServicio] [int] NOT NULL,
	[descripcion] [char](250) NULL,
	[codTipoComprobante] [char](5) NULL,
	[datos] [image] NULL,
	[NOMBRE] [char](150) NULL,
 CONSTRAINT [PK_comprobantesAceptacionOrdenservicio] PRIMARY KEY CLUSTERED 
(
	[codComprobantesAceptacionOrdenservicio] ASC,
	[codOrdenServicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[archivosXOrdenServicio]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[archivosXOrdenServicio](
	[codOrdenServicio] [int] NOT NULL,
	[codArchivo] [int] NOT NULL,
	[nombreArchivo] [char](100) NULL,
	[descripcion] [char](250) NULL,
	[archivo] [image] NULL,
 CONSTRAINT [PK_archivosXOrdenServicio] PRIMARY KEY CLUSTERED 
(
	[codOrdenServicio] ASC,
	[codArchivo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[archivosxEntradaSalidaEquipos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[archivosxEntradaSalidaEquipos](
	[codarchivosxEntradaSalidaEquipos] [int] NOT NULL,
	[codEntradaSalidaEquipos] [int] NULL,
	[nombreArchivo] [char](100) NULL,
	[descripcion] [varchar](250) NULL,
	[archivo] [image] NULL,
 CONSTRAINT [PK_archivosxEntradaSalidaEquipos] PRIMARY KEY CLUSTERED 
(
	[codarchivosxEntradaSalidaEquipos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[actividadxordenServicio]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[actividadxordenServicio](
	[codOrdenServicio] [int] NOT NULL,
	[codActividad] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[observacion] [varchar](500) NULL,
	[loginAutor] [char](10) NULL,
 CONSTRAINT [PK_actividadxordenServicio] PRIMARY KEY CLUSTERED 
(
	[codOrdenServicio] ASC,
	[codActividad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AccesoriosxEntradaSalidaEquipos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccesoriosxEntradaSalidaEquipos](
	[codEntradaSalidaEquipos] [int] NOT NULL,
	[Codigo] [int] NOT NULL,
	[sonDeEntrada] [bit] NOT NULL,
	[codAccesoriosEquipos] [char](15) NULL,
	[esOtro] [bit] NULL,
	[descripcion] [char](50) NULL,
	[cantidad] [float] NULL,
 CONSTRAINT [PK_AccesoriosxEntradaSalidaEquipos] PRIMARY KEY CLUSTERED 
(
	[codEntradaSalidaEquipos] ASC,
	[Codigo] ASC,
	[sonDeEntrada] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSolicitudInsumos]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSolicitudInsumos](
	[codOrdenServicio] [int] NOT NULL,
	[codSolicitud] [int] NOT NULL,
	[codDetalle] [int] NOT NULL,
	[codRepuesto] [char](20) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_detalleSolicitudInsumos] PRIMARY KEY CLUSTERED 
(
	[codOrdenServicio] ASC,
	[codSolicitud] ASC,
	[codDetalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LlamadaSoporte]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LlamadaSoporte](
	[idLlamadaSoporte] [int] NOT NULL,
	[codEstadoLLamadaTecnica] [char](5) NULL,
	[fechaLlamada] [datetime] NULL,
	[llamadaRecibida] [bit] NULL,
	[nitCliente] [char](20) NULL,
	[codUbicacion] [char](5) NULL,
	[codContacto] [char](20) NULL,
	[infAdicionalContacto] [varchar](150) NULL,
	[serial] [char](30) NULL,
	[codModalidadEquipo] [char](5) NULL,
	[asesorTelefonico] [char](10) NULL,
	[ingenieroAsesor] [char](10) NULL,
	[fechaAsignacionIngeniero] [datetime] NULL,
	[codAsesor] [int] NULL,
	[obsCliente] [text] NULL,
	[obsAsesorTelefonico] [text] NULL,
	[solucionado] [bit] NULL,
	[obsFinales] [text] NULL,
	[fechaCierre] [datetime] NULL,
	[cerradaPor] [char](10) NULL,
	[codSolicitud] [int] NULL,
	[nombreUsuarioCliente] [char](40) NULL,
	[fechaSolucion] [datetime] NULL,
	[diasEnSolucionar] [int] NULL,
	[fechaUltimoSeguimiento] [datetime] NULL,
 CONSTRAINT [PK_LlamadaSoporte] PRIMARY KEY CLUSTERED 
(
	[idLlamadaSoporte] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ObservacionesxOrdenPrestamo]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ObservacionesxOrdenPrestamo](
	[codOrdenPrestamo] [int] NOT NULL,
	[idObservacion] [int] NOT NULL,
	[fechaObservacion] [datetime] NULL,
	[loginAutor] [char](10) NULL,
	[observacion] [text] NULL,
 CONSTRAINT [PK_ObservacionesxOrdenPrestamo] PRIMARY KEY CLUSTERED 
(
	[codOrdenPrestamo] ASC,
	[idObservacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[repuestosxOrdenPrestamo]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[repuestosxOrdenPrestamo](
	[codOrdenPrestamo] [int] NOT NULL,
	[codRepuesto] [char](20) NOT NULL,
	[cantidadSolicitada] [int] NULL,
	[cantidadPrestada] [int] NULL,
	[cantidadDevuelta] [int] NULL,
	[cantidadConNotaSalida] [int] NULL,
	[entregadoIngeniero] [bit] NULL,
	[devueltoAlmacen] [bit] NULL,
	[notaSalida] [bit] NULL,
	[obsNotaSalida] [varchar](50) NULL,
	[fechaEntregaIng] [datetime] NULL,
	[fechaDevolucion] [datetime] NULL,
	[fechaNotaSalida] [datetime] NULL,
 CONSTRAINT [PK_repuestosxOrdenPrestamo] PRIMARY KEY CLUSTERED 
(
	[codOrdenPrestamo] ASC,
	[codRepuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[seguimiento]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[seguimiento](
	[idSeguimiento] [int] NOT NULL,
	[creadoPor] [char](10) NULL,
	[realizado] [bit] NULL,
	[realizadoPor] [nchar](10) NULL,
	[fechaSugerida] [datetime] NULL,
	[fechaRealizado] [datetime] NULL,
	[obsIniciales] [ntext] NULL,
	[obsFinales] [ntext] NULL,
	[idLlamadaSoporte] [int] NULL,
	[nitCliente] [char](20) NULL,
	[codContacto] [char](20) NULL,
	[serial] [char](30) NULL,
 CONSTRAINT [PK_seguimientos] PRIMARY KEY CLUSTERED 
(
	[idSeguimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[indicacionesLLamadas]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[indicacionesLLamadas](
	[idLLamadaSoporte] [int] NOT NULL,
	[codIndicacion] [int] NOT NULL,
	[ingresadaPor] [char](10) NULL,
	[descripcion] [ntext] NULL,
	[observaciones] [ntext] NULL,
	[fechaCreacion] [datetime] NULL,
	[fechaIndicacion] [datetime] NULL,
 CONSTRAINT [PK_indicacionesLLamadas] PRIMARY KEY CLUSTERED 
(
	[idLLamadaSoporte] ASC,
	[codIndicacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[asesoria_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[asesoria_cientifica](
	[cod_asesoria_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[cod_estado_asesoria_cientifica] [int] NOT NULL,
	[cod_prioridad_sugerida] [int] NULL,
	[cod_prioridad_callcenter_cientifica] [int] NULL,
	[fecha_solicitud] [datetime] NOT NULL,
	[usuario_creacion] [char](10) NOT NULL,
	[ind_noequipo_noreactivo] [bit] NULL,
	[ind_interna] [bit] NULL,
	[usuario_interna] [char](10) NULL,
	[nitCliente] [char](20) NOT NULL,
	[codSucursal] [char](5) NOT NULL,
	[codContacto] [char](20) NOT NULL,
	[infAdicionalContacto] [varchar](250) NULL,
	[cod_referencia_reactivo] [int] NULL,
	[motivo_consulta] [text] NULL,
	[respuesta_inicial] [text] NULL,
	[informacionSuministradaInicial] [text] NULL,
	[responsable] [char](10) NULL,
	[fecha_respuesta_inicial] [datetime] NULL,
	[codFabricante] [char](5) NULL,
	[codModelo] [char](5) NULL,
	[serial] [char](30) NULL,
	[fecha_visita] [datetime] NULL,
	[dias_solucion] [int] NULL,
	[numero_reporte_qc] [char](10) NULL,
	[fecha_cierre] [datetime] NULL,
	[solucionado] [bit] NULL,
	[no_porque] [varchar](500) NULL,
	[conforme] [bit] NULL,
	[no_conforme_porque] [varchar](500) NULL,
	[cerrada_por] [char](10) NULL,
	[cod_inconveniente_presentado_cientifica] [int] NULL,
	[cod_reactivo_cierre] [int] NULL,
	[lote_reactivo] [char](10) NULL,
	[vencimiento_reactivo] [datetime] NULL,
	[llamada_recibida_disponibilidad] [bit] NULL,
	[cod_motivo_anulacion_cientifica] [int] NULL,
	[informacionAdicionalAnulacion] [varchar](250) NULL,
	[idLlamadaSoporte] [int] NULL,
 CONSTRAINT [PK_asesoria_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_asesoria_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tarea_asesoria_cientifica]    Script Date: 02/17/2011 10:56:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tarea_asesoria_cientifica](
	[cod_tarea_asesoria_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[creada_por] [char](10) NOT NULL,
	[descripcion_tarea] [text] NOT NULL,
	[cod_asesoria_cientifica] [int] NOT NULL,
	[realizada] [bit] NOT NULL,
 CONSTRAINT [PK_tarea_asesoria_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_tarea_asesoria_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[accion_seguirxasesoria_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accion_seguirxasesoria_cientifica](
	[cod_accion_seguirxasesoria_cientifica] [int] IDENTITY(1,1) NOT NULL,
	[cod_accion_seguir_cientifica] [int] NOT NULL,
	[cod_asesoria_cientifica] [int] NOT NULL,
 CONSTRAINT [PK_accion_seguirxasesoria_cientifica] PRIMARY KEY CLUSTERED 
(
	[cod_accion_seguirxasesoria_cientifica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__usuarios__rowgui__5CD6CB2B]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF__usuarios__rowgui__5CD6CB2B]  DEFAULT (newid()) FOR [rowguid]
GO
/****** Object:  ForeignKey [FK_accesoriosEquipo_fotografia]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[accesoriosEquipo]  WITH CHECK ADD  CONSTRAINT [FK_accesoriosEquipo_fotografia] FOREIGN KEY([codFoto])
REFERENCES [dbo].[fotografia] ([codFotografia])
GO
ALTER TABLE [dbo].[accesoriosEquipo] CHECK CONSTRAINT [FK_accesoriosEquipo_fotografia]
GO
/****** Object:  ForeignKey [FK_accesoriosEquipo_Modelos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[accesoriosEquipo]  WITH CHECK ADD  CONSTRAINT [FK_accesoriosEquipo_Modelos] FOREIGN KEY([codFabricante], [codModelo])
REFERENCES [dbo].[Modelos] ([codFabricante], [codModelo])
GO
ALTER TABLE [dbo].[accesoriosEquipo] CHECK CONSTRAINT [FK_accesoriosEquipo_Modelos]
GO
/****** Object:  ForeignKey [FK_AccesoriosxEntradaSalidaEquipos_EntradaSalidaEquipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[AccesoriosxEntradaSalidaEquipos]  WITH CHECK ADD  CONSTRAINT [FK_AccesoriosxEntradaSalidaEquipos_EntradaSalidaEquipos] FOREIGN KEY([codEntradaSalidaEquipos])
REFERENCES [dbo].[EntradaSalidaEquipos] ([codEntradaSalidaEquipos])
GO
ALTER TABLE [dbo].[AccesoriosxEntradaSalidaEquipos] CHECK CONSTRAINT [FK_AccesoriosxEntradaSalidaEquipos_EntradaSalidaEquipos]
GO
/****** Object:  ForeignKey [FK_accion_seguirxasesoria_cientifica_accion_seguir_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[accion_seguirxasesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_accion_seguirxasesoria_cientifica_accion_seguir_cientifica] FOREIGN KEY([cod_accion_seguir_cientifica])
REFERENCES [dbo].[accion_seguir_cientifica] ([cod_accion_seguir_cientifica])
GO
ALTER TABLE [dbo].[accion_seguirxasesoria_cientifica] CHECK CONSTRAINT [FK_accion_seguirxasesoria_cientifica_accion_seguir_cientifica]
GO
/****** Object:  ForeignKey [FK_accion_seguirxasesoria_cientifica_asesoria_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[accion_seguirxasesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_accion_seguirxasesoria_cientifica_asesoria_cientifica] FOREIGN KEY([cod_asesoria_cientifica])
REFERENCES [dbo].[asesoria_cientifica] ([cod_asesoria_cientifica])
GO
ALTER TABLE [dbo].[accion_seguirxasesoria_cientifica] CHECK CONSTRAINT [FK_accion_seguirxasesoria_cientifica_asesoria_cientifica]
GO
/****** Object:  ForeignKey [FK_accion_seguirxseguimiento_cientifica_accion_seguir_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[accion_seguirxseguimiento_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_accion_seguirxseguimiento_cientifica_accion_seguir_cientifica] FOREIGN KEY([cod_accion_seguir_cientifica])
REFERENCES [dbo].[accion_seguir_cientifica] ([cod_accion_seguir_cientifica])
GO
ALTER TABLE [dbo].[accion_seguirxseguimiento_cientifica] CHECK CONSTRAINT [FK_accion_seguirxseguimiento_cientifica_accion_seguir_cientifica]
GO
/****** Object:  ForeignKey [FK_accion_seguirxseguimiento_cientifica_seguimiento_asesoria_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[accion_seguirxseguimiento_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_accion_seguirxseguimiento_cientifica_seguimiento_asesoria_cientifica] FOREIGN KEY([cod_seguimiento_asesoria_cientifica])
REFERENCES [dbo].[seguimiento_asesoria_cientifica] ([cod_seguimiento_asesoria_cientifica])
GO
ALTER TABLE [dbo].[accion_seguirxseguimiento_cientifica] CHECK CONSTRAINT [FK_accion_seguirxseguimiento_cientifica_seguimiento_asesoria_cientifica]
GO
/****** Object:  ForeignKey [FK_actividad_adicional_tipo_actividad]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[actividad_adicional]  WITH CHECK ADD  CONSTRAINT [FK_actividad_adicional_tipo_actividad] FOREIGN KEY([cod_tipo_actividad])
REFERENCES [dbo].[tipo_actividad] ([cod_tipo_actividad])
GO
ALTER TABLE [dbo].[actividad_adicional] CHECK CONSTRAINT [FK_actividad_adicional_tipo_actividad]
GO
/****** Object:  ForeignKey [FK_actividad_adicional_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[actividad_adicional]  WITH CHECK ADD  CONSTRAINT [FK_actividad_adicional_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[actividad_adicional] CHECK CONSTRAINT [FK_actividad_adicional_usuarios]
GO
/****** Object:  ForeignKey [FK_ActividadesxModelo_Modelos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[ActividadesxModelo]  WITH CHECK ADD  CONSTRAINT [FK_ActividadesxModelo_Modelos] FOREIGN KEY([codFabricante], [codModelo])
REFERENCES [dbo].[Modelos] ([codFabricante], [codModelo])
GO
ALTER TABLE [dbo].[ActividadesxModelo] CHECK CONSTRAINT [FK_ActividadesxModelo_Modelos]
GO
/****** Object:  ForeignKey [FK_actividadxordenServicio_ordenServicio]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[actividadxordenServicio]  WITH CHECK ADD  CONSTRAINT [FK_actividadxordenServicio_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[actividadxordenServicio] CHECK CONSTRAINT [FK_actividadxordenServicio_ordenServicio]
GO
/****** Object:  ForeignKey [FK_actividadxordenServicio_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[actividadxordenServicio]  WITH CHECK ADD  CONSTRAINT [FK_actividadxordenServicio_usuarios] FOREIGN KEY([loginAutor])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[actividadxordenServicio] CHECK CONSTRAINT [FK_actividadxordenServicio_usuarios]
GO
/****** Object:  ForeignKey [FK_ArchivosxComponente_componente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[ArchivosxComponente]  WITH CHECK ADD  CONSTRAINT [FK_ArchivosxComponente_componente] FOREIGN KEY([codFabricante], [codComponente])
REFERENCES [dbo].[componente] ([codFabricante], [codComponente])
GO
ALTER TABLE [dbo].[ArchivosxComponente] CHECK CONSTRAINT [FK_ArchivosxComponente_componente]
GO
/****** Object:  ForeignKey [FK_archivosxcontrato_contratos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[archivosxcontrato]  WITH CHECK ADD  CONSTRAINT [FK_archivosxcontrato_contratos] FOREIGN KEY([numeroContrato], [codOtroSi])
REFERENCES [dbo].[contratos] ([numeroContrato], [codOtroSi])
GO
ALTER TABLE [dbo].[archivosxcontrato] CHECK CONSTRAINT [FK_archivosxcontrato_contratos]
GO
/****** Object:  ForeignKey [FK_archivosxEntradaSalidaEquipos_EntradaSalidaEquipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[archivosxEntradaSalidaEquipos]  WITH CHECK ADD  CONSTRAINT [FK_archivosxEntradaSalidaEquipos_EntradaSalidaEquipos] FOREIGN KEY([codEntradaSalidaEquipos])
REFERENCES [dbo].[EntradaSalidaEquipos] ([codEntradaSalidaEquipos])
GO
ALTER TABLE [dbo].[archivosxEntradaSalidaEquipos] CHECK CONSTRAINT [FK_archivosxEntradaSalidaEquipos_EntradaSalidaEquipos]
GO
/****** Object:  ForeignKey [FK_archivosXequipo_equipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[archivosXequipo]  WITH CHECK ADD  CONSTRAINT [FK_archivosXequipo_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[archivosXequipo] CHECK CONSTRAINT [FK_archivosXequipo_equipos]
GO
/****** Object:  ForeignKey [FK_archivosXequipo_TiposArchivoXequipo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[archivosXequipo]  WITH CHECK ADD  CONSTRAINT [FK_archivosXequipo_TiposArchivoXequipo] FOREIGN KEY([codTipoArchivoxEquipo])
REFERENCES [dbo].[TiposArchivoXequipo] ([codTipoArchivoxEquipo])
GO
ALTER TABLE [dbo].[archivosXequipo] CHECK CONSTRAINT [FK_archivosXequipo_TiposArchivoXequipo]
GO
/****** Object:  ForeignKey [FK_archivosxIncumplimiento_incumplimientoConsumo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[archivosxIncumplimiento]  WITH CHECK ADD  CONSTRAINT [FK_archivosxIncumplimiento_incumplimientoConsumo] FOREIGN KEY([numeroContrato], [codIncumplimiento])
REFERENCES [dbo].[incumplimientoConsumo] ([numeroContrato], [codIncumplimiento])
GO
ALTER TABLE [dbo].[archivosxIncumplimiento] CHECK CONSTRAINT [FK_archivosxIncumplimiento_incumplimientoConsumo]
GO
/****** Object:  ForeignKey [FK_archivosxModelo_Modelos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[archivosxModelo]  WITH CHECK ADD  CONSTRAINT [FK_archivosxModelo_Modelos] FOREIGN KEY([codFabricante], [codModelo])
REFERENCES [dbo].[Modelos] ([codFabricante], [codModelo])
GO
ALTER TABLE [dbo].[archivosxModelo] CHECK CONSTRAINT [FK_archivosxModelo_Modelos]
GO
/****** Object:  ForeignKey [FK_archivosXOrdenServicio_ordenServicio]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[archivosXOrdenServicio]  WITH CHECK ADD  CONSTRAINT [FK_archivosXOrdenServicio_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[archivosXOrdenServicio] CHECK CONSTRAINT [FK_archivosXOrdenServicio_ordenServicio]
GO
/****** Object:  ForeignKey [FK_archivosxRepuesto_repuestos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[archivosxRepuesto]  WITH CHECK ADD  CONSTRAINT [FK_archivosxRepuesto_repuestos] FOREIGN KEY([codRepuesto])
REFERENCES [dbo].[repuestos] ([codRepuesto])
GO
ALTER TABLE [dbo].[archivosxRepuesto] CHECK CONSTRAINT [FK_archivosxRepuesto_repuestos]
GO
/****** Object:  ForeignKey [FK_asesoria_cientifica_contactosClientes]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[asesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_asesoria_cientifica_contactosClientes] FOREIGN KEY([nitCliente], [codContacto])
REFERENCES [dbo].[contactosClientes] ([nitCliente], [codContacto])
GO
ALTER TABLE [dbo].[asesoria_cientifica] CHECK CONSTRAINT [FK_asesoria_cientifica_contactosClientes]
GO
/****** Object:  ForeignKey [FK_asesoria_cientifica_estado_asesoria_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[asesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_asesoria_cientifica_estado_asesoria_cientifica] FOREIGN KEY([cod_estado_asesoria_cientifica])
REFERENCES [dbo].[estado_asesoria_cientifica] ([cod_estado_asesoria_cientifica])
GO
ALTER TABLE [dbo].[asesoria_cientifica] CHECK CONSTRAINT [FK_asesoria_cientifica_estado_asesoria_cientifica]
GO
/****** Object:  ForeignKey [FK_asesoria_cientifica_LlamadaSoporte]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[asesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_asesoria_cientifica_LlamadaSoporte] FOREIGN KEY([idLlamadaSoporte])
REFERENCES [dbo].[LlamadaSoporte] ([idLlamadaSoporte])
GO
ALTER TABLE [dbo].[asesoria_cientifica] CHECK CONSTRAINT [FK_asesoria_cientifica_LlamadaSoporte]
GO
/****** Object:  ForeignKey [FK_asesoria_cientifica_prioridad_callcenter_cientifica]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[asesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_asesoria_cientifica_prioridad_callcenter_cientifica] FOREIGN KEY([cod_prioridad_callcenter_cientifica])
REFERENCES [dbo].[prioridad_callcenter_cientifica] ([cod_prioridad_callcenter_cientifica])
GO
ALTER TABLE [dbo].[asesoria_cientifica] CHECK CONSTRAINT [FK_asesoria_cientifica_prioridad_callcenter_cientifica]
GO
/****** Object:  ForeignKey [FK_asesoria_cientifica_prioridad_callcenter_cientifica1]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[asesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_asesoria_cientifica_prioridad_callcenter_cientifica1] FOREIGN KEY([cod_prioridad_sugerida])
REFERENCES [dbo].[prioridad_callcenter_cientifica] ([cod_prioridad_callcenter_cientifica])
GO
ALTER TABLE [dbo].[asesoria_cientifica] CHECK CONSTRAINT [FK_asesoria_cientifica_prioridad_callcenter_cientifica1]
GO
/****** Object:  ForeignKey [FK_asesoria_cientifica_sucursalCliente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[asesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_asesoria_cientifica_sucursalCliente] FOREIGN KEY([nitCliente], [codSucursal])
REFERENCES [dbo].[sucursalCliente] ([nitCliente], [codSucursal])
GO
ALTER TABLE [dbo].[asesoria_cientifica] CHECK CONSTRAINT [FK_asesoria_cientifica_sucursalCliente]
GO
/****** Object:  ForeignKey [FK_CGQ_ParametrosQuery_CGQ_Query]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[CGQ_ParametrosQuery]  WITH CHECK ADD  CONSTRAINT [FK_CGQ_ParametrosQuery_CGQ_Query] FOREIGN KEY([codQuery])
REFERENCES [dbo].[CGQ_Query] ([codQuery])
GO
ALTER TABLE [dbo].[CGQ_ParametrosQuery] CHECK CONSTRAINT [FK_CGQ_ParametrosQuery_CGQ_Query]
GO
/****** Object:  ForeignKey [FK_CGQ_ParametrosQuery_CGQ_TipoFiltro]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[CGQ_ParametrosQuery]  WITH CHECK ADD  CONSTRAINT [FK_CGQ_ParametrosQuery_CGQ_TipoFiltro] FOREIGN KEY([codTipoFiltro])
REFERENCES [dbo].[CGQ_TipoFiltro] ([codTipoFiltro])
GO
ALTER TABLE [dbo].[CGQ_ParametrosQuery] CHECK CONSTRAINT [FK_CGQ_ParametrosQuery_CGQ_TipoFiltro]
GO
/****** Object:  ForeignKey [FK_cgSmtpAdjuntos_cgSmtpEmail]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[cgSmtpAdjuntos]  WITH CHECK ADD  CONSTRAINT [FK_cgSmtpAdjuntos_cgSmtpEmail] FOREIGN KEY([idCgSmtpEmail])
REFERENCES [dbo].[cgSmtpEmail] ([idCgSmtpEmail])
GO
ALTER TABLE [dbo].[cgSmtpAdjuntos] CHECK CONSTRAINT [FK_cgSmtpAdjuntos_cgSmtpEmail]
GO
/****** Object:  ForeignKey [FK_cgSmtpEmailCC_cgSmtpEmail]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[cgSmtpEmailCC]  WITH CHECK ADD  CONSTRAINT [FK_cgSmtpEmailCC_cgSmtpEmail] FOREIGN KEY([idCgSmtpEmail])
REFERENCES [dbo].[cgSmtpEmail] ([idCgSmtpEmail])
GO
ALTER TABLE [dbo].[cgSmtpEmailCC] CHECK CONSTRAINT [FK_cgSmtpEmailCC_cgSmtpEmail]
GO
/****** Object:  ForeignKey [FK_cgSmtpEmailCCO_cgSmtpEmail]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[cgSmtpEmailCCO]  WITH CHECK ADD  CONSTRAINT [FK_cgSmtpEmailCCO_cgSmtpEmail] FOREIGN KEY([idCgSmtpEmail])
REFERENCES [dbo].[cgSmtpEmail] ([idCgSmtpEmail])
GO
ALTER TABLE [dbo].[cgSmtpEmailCCO] CHECK CONSTRAINT [FK_cgSmtpEmailCCO_cgSmtpEmail]
GO
/****** Object:  ForeignKey [FK_cgSmtpEmailTo_cgSmtpEmail]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[cgSmtpEmailTo]  WITH CHECK ADD  CONSTRAINT [FK_cgSmtpEmailTo_cgSmtpEmail] FOREIGN KEY([idCgSmtpEmail])
REFERENCES [dbo].[cgSmtpEmail] ([idCgSmtpEmail])
GO
ALTER TABLE [dbo].[cgSmtpEmailTo] CHECK CONSTRAINT [FK_cgSmtpEmailTo_cgSmtpEmail]
GO
/****** Object:  ForeignKey [FK_cgSmtpServerCC_cgSmtpServer]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[cgSmtpServerCC]  WITH CHECK ADD  CONSTRAINT [FK_cgSmtpServerCC_cgSmtpServer] FOREIGN KEY([idCgSmtpServer])
REFERENCES [dbo].[cgSmtpServer] ([idCgSmtpServer])
GO
ALTER TABLE [dbo].[cgSmtpServerCC] CHECK CONSTRAINT [FK_cgSmtpServerCC_cgSmtpServer]
GO
/****** Object:  ForeignKey [FK_cgSmtpServerCCO_cgSmtpServer]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[cgSmtpServerCCO]  WITH CHECK ADD  CONSTRAINT [FK_cgSmtpServerCCO_cgSmtpServer] FOREIGN KEY([idCgSmtpServer])
REFERENCES [dbo].[cgSmtpServer] ([idCgSmtpServer])
GO
ALTER TABLE [dbo].[cgSmtpServerCCO] CHECK CONSTRAINT [FK_cgSmtpServerCCO_cgSmtpServer]
GO
/****** Object:  ForeignKey [FK_ciudades_departamento]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[ciudades]  WITH CHECK ADD  CONSTRAINT [FK_ciudades_departamento] FOREIGN KEY([codPais], [codDepartamento])
REFERENCES [dbo].[departamento] ([codPais], [codDepartamento])
GO
ALTER TABLE [dbo].[ciudades] CHECK CONSTRAINT [FK_ciudades_departamento]
GO
/****** Object:  ForeignKey [FK_clientes_tipoDocumento]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_tipoDocumento] FOREIGN KEY([codTipoDoc])
REFERENCES [dbo].[tipoDocumento] ([codTipoDoc])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_tipoDocumento]
GO
/****** Object:  ForeignKey [FK_clientes_tituloContacto]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_tituloContacto] FOREIGN KEY([tituloContacto])
REFERENCES [dbo].[tituloContacto] ([codTituloContacto])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_tituloContacto]
GO
/****** Object:  ForeignKey [FK_componente_subCategoriaComponente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[componente]  WITH CHECK ADD  CONSTRAINT [FK_componente_subCategoriaComponente] FOREIGN KEY([codtipoComponente], [codSubTipoComponente], [codsubCategoriaCom])
REFERENCES [dbo].[subCategoriaComponente] ([codTipoComponente], [codSubTipoComponente], [codSubCategoriaCom])
GO
ALTER TABLE [dbo].[componente] CHECK CONSTRAINT [FK_componente_subCategoriaComponente]
GO
/****** Object:  ForeignKey [FK_componentesxmodelos_componente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[componentesxmodelos]  WITH CHECK ADD  CONSTRAINT [FK_componentesxmodelos_componente] FOREIGN KEY([codFabricanteCom], [codComponente])
REFERENCES [dbo].[componente] ([codFabricante], [codComponente])
GO
ALTER TABLE [dbo].[componentesxmodelos] CHECK CONSTRAINT [FK_componentesxmodelos_componente]
GO
/****** Object:  ForeignKey [FK_componentesxmodelos_Modelos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[componentesxmodelos]  WITH CHECK ADD  CONSTRAINT [FK_componentesxmodelos_Modelos] FOREIGN KEY([codFabricante], [codModelo])
REFERENCES [dbo].[Modelos] ([codFabricante], [codModelo])
GO
ALTER TABLE [dbo].[componentesxmodelos] CHECK CONSTRAINT [FK_componentesxmodelos_Modelos]
GO
/****** Object:  ForeignKey [FK_comprobantesAceptacionOrdenservicio_ordenServicio]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[comprobantesAceptacionOrdenservicio]  WITH CHECK ADD  CONSTRAINT [FK_comprobantesAceptacionOrdenservicio_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[comprobantesAceptacionOrdenservicio] CHECK CONSTRAINT [FK_comprobantesAceptacionOrdenservicio_ordenServicio]
GO
/****** Object:  ForeignKey [FK_comprobantesAceptacionOrdenservicio_tipoComprobante]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[comprobantesAceptacionOrdenservicio]  WITH CHECK ADD  CONSTRAINT [FK_comprobantesAceptacionOrdenservicio_tipoComprobante] FOREIGN KEY([codTipoComprobante])
REFERENCES [dbo].[tipoComprobante] ([codTipoComprobante])
GO
ALTER TABLE [dbo].[comprobantesAceptacionOrdenservicio] CHECK CONSTRAINT [FK_comprobantesAceptacionOrdenservicio_tipoComprobante]
GO
/****** Object:  ForeignKey [FK_consumoContratoxLinea_lineasConsumo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[consumoContratoxLinea]  WITH CHECK ADD  CONSTRAINT [FK_consumoContratoxLinea_lineasConsumo] FOREIGN KEY([codGrupoLineaConsumo], [codLinea])
REFERENCES [dbo].[lineasConsumo] ([codGrupoLineaConsumo], [codLinea])
GO
ALTER TABLE [dbo].[consumoContratoxLinea] CHECK CONSTRAINT [FK_consumoContratoxLinea_lineasConsumo]
GO
/****** Object:  ForeignKey [FK_contactosClientes_tipoDocumento]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[contactosClientes]  WITH CHECK ADD  CONSTRAINT [FK_contactosClientes_tipoDocumento] FOREIGN KEY([codTipoDoc])
REFERENCES [dbo].[tipoDocumento] ([codTipoDoc])
GO
ALTER TABLE [dbo].[contactosClientes] CHECK CONSTRAINT [FK_contactosClientes_tipoDocumento]
GO
/****** Object:  ForeignKey [FK_contactosClientes_tituloContacto]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[contactosClientes]  WITH CHECK ADD  CONSTRAINT [FK_contactosClientes_tituloContacto] FOREIGN KEY([tituloContacto])
REFERENCES [dbo].[tituloContacto] ([codTituloContacto])
GO
ALTER TABLE [dbo].[contactosClientes] CHECK CONSTRAINT [FK_contactosClientes_tituloContacto]
GO
/****** Object:  ForeignKey [FK_contratos_modalidadContrato]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[contratos]  WITH CHECK ADD  CONSTRAINT [FK_contratos_modalidadContrato] FOREIGN KEY([codModalidadContrato], [codTipoContrato])
REFERENCES [dbo].[modalidadContrato] ([codModalidadContrato], [codTipoContrato])
GO
ALTER TABLE [dbo].[contratos] CHECK CONSTRAINT [FK_contratos_modalidadContrato]
GO
/****** Object:  ForeignKey [FK_contratosxEquipo_contratos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[contratosxEquipo]  WITH CHECK ADD  CONSTRAINT [FK_contratosxEquipo_contratos] FOREIGN KEY([numeroContrato], [codOtroSi])
REFERENCES [dbo].[contratos] ([numeroContrato], [codOtroSi])
GO
ALTER TABLE [dbo].[contratosxEquipo] CHECK CONSTRAINT [FK_contratosxEquipo_contratos]
GO
/****** Object:  ForeignKey [FK_contratosxEquipo_equipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[contratosxEquipo]  WITH CHECK ADD  CONSTRAINT [FK_contratosxEquipo_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[contratosxEquipo] CHECK CONSTRAINT [FK_contratosxEquipo_equipos]
GO
/****** Object:  ForeignKey [FK_departamento_paises]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[departamento]  WITH CHECK ADD  CONSTRAINT [FK_departamento_paises] FOREIGN KEY([codPais])
REFERENCES [dbo].[paises] ([codPais])
GO
ALTER TABLE [dbo].[departamento] CHECK CONSTRAINT [FK_departamento_paises]
GO
/****** Object:  ForeignKey [FK_detalleProgramacionViajes_equipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[detalleProgramacionViajes]  WITH CHECK ADD  CONSTRAINT [FK_detalleProgramacionViajes_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[detalleProgramacionViajes] CHECK CONSTRAINT [FK_detalleProgramacionViajes_equipos]
GO
/****** Object:  ForeignKey [FK_detalleProgramacionViajes_ordenServicio]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[detalleProgramacionViajes]  WITH CHECK ADD  CONSTRAINT [FK_detalleProgramacionViajes_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[detalleProgramacionViajes] CHECK CONSTRAINT [FK_detalleProgramacionViajes_ordenServicio]
GO
/****** Object:  ForeignKey [FK_detalleProgramacionViajes_programacionViajes]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[detalleProgramacionViajes]  WITH CHECK ADD  CONSTRAINT [FK_detalleProgramacionViajes_programacionViajes] FOREIGN KEY([codProgramacionViajes])
REFERENCES [dbo].[programacionViajes] ([codProgramacionViajes])
GO
ALTER TABLE [dbo].[detalleProgramacionViajes] CHECK CONSTRAINT [FK_detalleProgramacionViajes_programacionViajes]
GO
/****** Object:  ForeignKey [FK_detalleSolicitudInsumos_repuestos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[detalleSolicitudInsumos]  WITH CHECK ADD  CONSTRAINT [FK_detalleSolicitudInsumos_repuestos] FOREIGN KEY([codRepuesto])
REFERENCES [dbo].[repuestos] ([codRepuesto])
GO
ALTER TABLE [dbo].[detalleSolicitudInsumos] CHECK CONSTRAINT [FK_detalleSolicitudInsumos_repuestos]
GO
/****** Object:  ForeignKey [FK_detalleSolicitudInsumos_solicitudInsumos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[detalleSolicitudInsumos]  WITH CHECK ADD  CONSTRAINT [FK_detalleSolicitudInsumos_solicitudInsumos] FOREIGN KEY([codOrdenServicio], [codSolicitud])
REFERENCES [dbo].[solicitudInsumos] ([codOrdenServicio], [codSolicitud])
GO
ALTER TABLE [dbo].[detalleSolicitudInsumos] CHECK CONSTRAINT [FK_detalleSolicitudInsumos_solicitudInsumos]
GO
/****** Object:  ForeignKey [FK_EntradaSalidaEquipos_equipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[EntradaSalidaEquipos]  WITH CHECK ADD  CONSTRAINT [FK_EntradaSalidaEquipos_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[EntradaSalidaEquipos] CHECK CONSTRAINT [FK_EntradaSalidaEquipos_equipos]
GO
/****** Object:  ForeignKey [FK_EntradaSalidaEquipos_EstadoFisicamente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[EntradaSalidaEquipos]  WITH CHECK ADD  CONSTRAINT [FK_EntradaSalidaEquipos_EstadoFisicamente] FOREIGN KEY([codEstadoFisicamente])
REFERENCES [dbo].[EstadoFisicamente] ([codEstadoFisicamente])
GO
ALTER TABLE [dbo].[EntradaSalidaEquipos] CHECK CONSTRAINT [FK_EntradaSalidaEquipos_EstadoFisicamente]
GO
/****** Object:  ForeignKey [FK_EntradaSalidaEquipos_sucursalCliente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[EntradaSalidaEquipos]  WITH CHECK ADD  CONSTRAINT [FK_EntradaSalidaEquipos_sucursalCliente] FOREIGN KEY([nitcliente], [codSucursal])
REFERENCES [dbo].[sucursalCliente] ([nitCliente], [codSucursal])
GO
ALTER TABLE [dbo].[EntradaSalidaEquipos] CHECK CONSTRAINT [FK_EntradaSalidaEquipos_sucursalCliente]
GO
/****** Object:  ForeignKey [FK_EntradaSalidaEquipos_TipoServicio]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[EntradaSalidaEquipos]  WITH CHECK ADD  CONSTRAINT [FK_EntradaSalidaEquipos_TipoServicio] FOREIGN KEY([codTiposervicio])
REFERENCES [dbo].[TipoServicio] ([codTipoServicio])
GO
ALTER TABLE [dbo].[EntradaSalidaEquipos] CHECK CONSTRAINT [FK_EntradaSalidaEquipos_TipoServicio]
GO
/****** Object:  ForeignKey [FK_equipoAuxiliar_equipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[equipoAuxiliar]  WITH CHECK ADD  CONSTRAINT [FK_equipoAuxiliar_equipos] FOREIGN KEY([serialEquipo])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[equipoAuxiliar] CHECK CONSTRAINT [FK_equipoAuxiliar_equipos]
GO
/****** Object:  ForeignKey [FK_equipoAuxiliar_equipos1]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[equipoAuxiliar]  WITH CHECK ADD  CONSTRAINT [FK_equipoAuxiliar_equipos1] FOREIGN KEY([serialAuxiliar])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[equipoAuxiliar] CHECK CONSTRAINT [FK_equipoAuxiliar_equipos1]
GO
/****** Object:  ForeignKey [FK_equipos_estadoLocalEquipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[equipos]  WITH CHECK ADD  CONSTRAINT [FK_equipos_estadoLocalEquipos] FOREIGN KEY([codEstadoLocal])
REFERENCES [dbo].[estadoLocalEquipos] ([codEstadoLocal])
GO
ALTER TABLE [dbo].[equipos] CHECK CONSTRAINT [FK_equipos_estadoLocalEquipos]
GO
/****** Object:  ForeignKey [FK_equipos_ModalidadEquipo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[equipos]  WITH CHECK ADD  CONSTRAINT [FK_equipos_ModalidadEquipo] FOREIGN KEY([codModalidadEquipo])
REFERENCES [dbo].[ModalidadEquipo] ([codModalidadEquipo])
GO
ALTER TABLE [dbo].[equipos] CHECK CONSTRAINT [FK_equipos_ModalidadEquipo]
GO
/****** Object:  ForeignKey [FK_equipos_Modelos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[equipos]  WITH CHECK ADD  CONSTRAINT [FK_equipos_Modelos] FOREIGN KEY([codFabricante], [codModelo])
REFERENCES [dbo].[Modelos] ([codFabricante], [codModelo])
GO
ALTER TABLE [dbo].[equipos] CHECK CONSTRAINT [FK_equipos_Modelos]
GO
/****** Object:  ForeignKey [FK_equipos_sucursalCliente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[equipos]  WITH CHECK ADD  CONSTRAINT [FK_equipos_sucursalCliente] FOREIGN KEY([nitClienteUbica], [codSucursalUbica])
REFERENCES [dbo].[sucursalCliente] ([nitCliente], [codSucursal])
GO
ALTER TABLE [dbo].[equipos] CHECK CONSTRAINT [FK_equipos_sucursalCliente]
GO
/****** Object:  ForeignKey [FK_equipos_tipoPropiedad]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[equipos]  WITH CHECK ADD  CONSTRAINT [FK_equipos_tipoPropiedad] FOREIGN KEY([codTipoPropiedad])
REFERENCES [dbo].[tipoPropiedad] ([codTipoPropiedad])
GO
ALTER TABLE [dbo].[equipos] CHECK CONSTRAINT [FK_equipos_tipoPropiedad]
GO
/****** Object:  ForeignKey [FK_equipos_TipoServicio]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[equipos]  WITH CHECK ADD  CONSTRAINT [FK_equipos_TipoServicio] FOREIGN KEY([codTipoServicio])
REFERENCES [dbo].[TipoServicio] ([codTipoServicio])
GO
ALTER TABLE [dbo].[equipos] CHECK CONSTRAINT [FK_equipos_TipoServicio]
GO
/****** Object:  ForeignKey [FK_filtrosRpt_rpt]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[filtrosRpt]  WITH CHECK ADD  CONSTRAINT [FK_filtrosRpt_rpt] FOREIGN KEY([idRpt])
REFERENCES [dbo].[rpt] ([idRpt])
GO
ALTER TABLE [dbo].[filtrosRpt] CHECK CONSTRAINT [FK_filtrosRpt_rpt]
GO
/****** Object:  ForeignKey [FK_filtrosRpt_tipoFiltroRpt]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[filtrosRpt]  WITH CHECK ADD  CONSTRAINT [FK_filtrosRpt_tipoFiltroRpt] FOREIGN KEY([codTipoFiltroRpt])
REFERENCES [dbo].[tipoFiltroRpt] ([codTipoFiltroRpt])
GO
ALTER TABLE [dbo].[filtrosRpt] CHECK CONSTRAINT [FK_filtrosRpt_tipoFiltroRpt]
GO
/****** Object:  ForeignKey [FK_gruposCopiaOcultaxSmtpAccion_cgSmtpAccion]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposCopiaOcultaxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_gruposCopiaOcultaxSmtpAccion_cgSmtpAccion] FOREIGN KEY([idCgSmtpAccion])
REFERENCES [dbo].[cgSmtpAccion] ([idCgSmtpAccion])
GO
ALTER TABLE [dbo].[gruposCopiaOcultaxSmtpAccion] CHECK CONSTRAINT [FK_gruposCopiaOcultaxSmtpAccion_cgSmtpAccion]
GO
/****** Object:  ForeignKey [FK_gruposCopiaOcultaxSmtpAccion_gruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposCopiaOcultaxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_gruposCopiaOcultaxSmtpAccion_gruposUsuarios] FOREIGN KEY([codGruposUsu])
REFERENCES [dbo].[gruposUsuarios] ([codGruposUsu])
GO
ALTER TABLE [dbo].[gruposCopiaOcultaxSmtpAccion] CHECK CONSTRAINT [FK_gruposCopiaOcultaxSmtpAccion_gruposUsuarios]
GO
/****** Object:  ForeignKey [FK_gruposCopiaxSmtpAccion_cgSmtpAccion]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposCopiaxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_gruposCopiaxSmtpAccion_cgSmtpAccion] FOREIGN KEY([idCgSmtpAccion])
REFERENCES [dbo].[cgSmtpAccion] ([idCgSmtpAccion])
GO
ALTER TABLE [dbo].[gruposCopiaxSmtpAccion] CHECK CONSTRAINT [FK_gruposCopiaxSmtpAccion_cgSmtpAccion]
GO
/****** Object:  ForeignKey [FK_gruposCopiaxSmtpAccion_gruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposCopiaxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_gruposCopiaxSmtpAccion_gruposUsuarios] FOREIGN KEY([codGruposUsu])
REFERENCES [dbo].[gruposUsuarios] ([codGruposUsu])
GO
ALTER TABLE [dbo].[gruposCopiaxSmtpAccion] CHECK CONSTRAINT [FK_gruposCopiaxSmtpAccion_gruposUsuarios]
GO
/****** Object:  ForeignKey [FK_gruposModulosxGruposUsuarios_gruposModulos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposModulosxGruposUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_gruposModulosxGruposUsuarios_gruposModulos] FOREIGN KEY([codGrupoModulo])
REFERENCES [dbo].[gruposModulos] ([codGrupoModulo])
GO
ALTER TABLE [dbo].[gruposModulosxGruposUsuarios] CHECK CONSTRAINT [FK_gruposModulosxGruposUsuarios_gruposModulos]
GO
/****** Object:  ForeignKey [FK_gruposModulosxGruposUsuarios_gruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposModulosxGruposUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_gruposModulosxGruposUsuarios_gruposUsuarios] FOREIGN KEY([codGruposUsu])
REFERENCES [dbo].[gruposUsuarios] ([codGruposUsu])
GO
ALTER TABLE [dbo].[gruposModulosxGruposUsuarios] CHECK CONSTRAINT [FK_gruposModulosxGruposUsuarios_gruposUsuarios]
GO
/****** Object:  ForeignKey [FK_gruposModulosxUsuario_gruposModulos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposModulosxUsuario]  WITH CHECK ADD  CONSTRAINT [FK_gruposModulosxUsuario_gruposModulos] FOREIGN KEY([codGrupoModulo])
REFERENCES [dbo].[gruposModulos] ([codGrupoModulo])
GO
ALTER TABLE [dbo].[gruposModulosxUsuario] CHECK CONSTRAINT [FK_gruposModulosxUsuario_gruposModulos]
GO
/****** Object:  ForeignKey [FK_gruposModulosxUsuario_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposModulosxUsuario]  WITH CHECK ADD  CONSTRAINT [FK_gruposModulosxUsuario_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[gruposModulosxUsuario] CHECK CONSTRAINT [FK_gruposModulosxUsuario_usuarios]
GO
/****** Object:  ForeignKey [FK_gruposUsuariosxUsuario_gruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposUsuariosxUsuario]  WITH CHECK ADD  CONSTRAINT [FK_gruposUsuariosxUsuario_gruposUsuarios] FOREIGN KEY([codGruposUsu])
REFERENCES [dbo].[gruposUsuarios] ([codGruposUsu])
GO
ALTER TABLE [dbo].[gruposUsuariosxUsuario] CHECK CONSTRAINT [FK_gruposUsuariosxUsuario_gruposUsuarios]
GO
/****** Object:  ForeignKey [FK_gruposUsuariosxUsuario_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposUsuariosxUsuario]  WITH NOCHECK ADD  CONSTRAINT [FK_gruposUsuariosxUsuario_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[gruposUsuariosxUsuario] CHECK CONSTRAINT [FK_gruposUsuariosxUsuario_usuarios]
GO
/****** Object:  ForeignKey [FK_gruposXgrupos_gruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposXgrupos]  WITH CHECK ADD  CONSTRAINT [FK_gruposXgrupos_gruposUsuarios] FOREIGN KEY([codGruposUsu])
REFERENCES [dbo].[gruposUsuarios] ([codGruposUsu])
GO
ALTER TABLE [dbo].[gruposXgrupos] CHECK CONSTRAINT [FK_gruposXgrupos_gruposUsuarios]
GO
/****** Object:  ForeignKey [FK_gruposXgrupos_gruposUsuarios1]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposXgrupos]  WITH CHECK ADD  CONSTRAINT [FK_gruposXgrupos_gruposUsuarios1] FOREIGN KEY([subordinadoDe])
REFERENCES [dbo].[gruposUsuarios] ([codGruposUsu])
GO
ALTER TABLE [dbo].[gruposXgrupos] CHECK CONSTRAINT [FK_gruposXgrupos_gruposUsuarios1]
GO
/****** Object:  ForeignKey [FK_gruposxSmtpAccion_cgSmtpAccion]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_gruposxSmtpAccion_cgSmtpAccion] FOREIGN KEY([idCgSmtpAccion])
REFERENCES [dbo].[cgSmtpAccion] ([idCgSmtpAccion])
GO
ALTER TABLE [dbo].[gruposxSmtpAccion] CHECK CONSTRAINT [FK_gruposxSmtpAccion_cgSmtpAccion]
GO
/****** Object:  ForeignKey [FK_gruposxSmtpAccion_gruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[gruposxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_gruposxSmtpAccion_gruposUsuarios] FOREIGN KEY([codGruposUsu])
REFERENCES [dbo].[gruposUsuarios] ([codGruposUsu])
GO
ALTER TABLE [dbo].[gruposxSmtpAccion] CHECK CONSTRAINT [FK_gruposxSmtpAccion_gruposUsuarios]
GO
/****** Object:  ForeignKey [FK_indicacionesLLamadas_LlamadaSoporte]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[indicacionesLLamadas]  WITH CHECK ADD  CONSTRAINT [FK_indicacionesLLamadas_LlamadaSoporte] FOREIGN KEY([idLLamadaSoporte])
REFERENCES [dbo].[LlamadaSoporte] ([idLlamadaSoporte])
GO
ALTER TABLE [dbo].[indicacionesLLamadas] CHECK CONSTRAINT [FK_indicacionesLLamadas_LlamadaSoporte]
GO
/****** Object:  ForeignKey [FK_lineasConsumo_gruposLineasConsumo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[lineasConsumo]  WITH CHECK ADD  CONSTRAINT [FK_lineasConsumo_gruposLineasConsumo] FOREIGN KEY([codGrupoLineaConsumo])
REFERENCES [dbo].[gruposLineasConsumo] ([codGrupoLineaConsumo])
GO
ALTER TABLE [dbo].[lineasConsumo] CHECK CONSTRAINT [FK_lineasConsumo_gruposLineasConsumo]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_asesoresComerciales]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_asesoresComerciales] FOREIGN KEY([codAsesor])
REFERENCES [dbo].[asesoresComerciales] ([codAsesor])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_asesoresComerciales]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_contactosClientes]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_contactosClientes] FOREIGN KEY([nitCliente], [codContacto])
REFERENCES [dbo].[contactosClientes] ([nitCliente], [codContacto])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_contactosClientes]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_equipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_equipos]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_estadosLLamadasTecnicas]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_estadosLLamadasTecnicas] FOREIGN KEY([codEstadoLLamadaTecnica])
REFERENCES [dbo].[estadosLLamadasTecnicas] ([codEstadoLlamada])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_estadosLLamadasTecnicas]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_ModalidadEquipo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_ModalidadEquipo] FOREIGN KEY([codModalidadEquipo])
REFERENCES [dbo].[ModalidadEquipo] ([codModalidadEquipo])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_ModalidadEquipo]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_solicitudServicio]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_solicitudServicio] FOREIGN KEY([codSolicitud])
REFERENCES [dbo].[solicitudServicio] ([codSolicitudServicio])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_solicitudServicio]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_sucursalCliente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_sucursalCliente] FOREIGN KEY([nitCliente], [codUbicacion])
REFERENCES [dbo].[sucursalCliente] ([nitCliente], [codSucursal])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_sucursalCliente]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_usuarios] FOREIGN KEY([asesorTelefonico])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_usuarios]
GO
/****** Object:  ForeignKey [FK_LlamadaSoporte_usuarios1]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[LlamadaSoporte]  WITH CHECK ADD  CONSTRAINT [FK_LlamadaSoporte_usuarios1] FOREIGN KEY([ingenieroAsesor])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[LlamadaSoporte] CHECK CONSTRAINT [FK_LlamadaSoporte_usuarios1]
GO
/****** Object:  ForeignKey [FK_logCambioUbicaciones_sucursalCliente]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[logCambioUbicaciones]  WITH CHECK ADD  CONSTRAINT [FK_logCambioUbicaciones_sucursalCliente] FOREIGN KEY([nitClienteDestino], [codSucursalDestino])
REFERENCES [dbo].[sucursalCliente] ([nitCliente], [codSucursal])
GO
ALTER TABLE [dbo].[logCambioUbicaciones] CHECK CONSTRAINT [FK_logCambioUbicaciones_sucursalCliente]
GO
/****** Object:  ForeignKey [FK_logCambioUbicaciones_sucursalCliente1]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[logCambioUbicaciones]  WITH CHECK ADD  CONSTRAINT [FK_logCambioUbicaciones_sucursalCliente1] FOREIGN KEY([nitClienteDestino], [codSucursalDestino])
REFERENCES [dbo].[sucursalCliente] ([nitCliente], [codSucursal])
GO
ALTER TABLE [dbo].[logCambioUbicaciones] CHECK CONSTRAINT [FK_logCambioUbicaciones_sucursalCliente1]
GO
/****** Object:  ForeignKey [FK_logCambioUbicaciones_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[logCambioUbicaciones]  WITH CHECK ADD  CONSTRAINT [FK_logCambioUbicaciones_usuarios] FOREIGN KEY([usuarioCambio])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[logCambioUbicaciones] CHECK CONSTRAINT [FK_logCambioUbicaciones_usuarios]
GO
/****** Object:  ForeignKey [FK_mantenimientosxContrato_contratos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[mantenimientosxContrato]  WITH CHECK ADD  CONSTRAINT [FK_mantenimientosxContrato_contratos] FOREIGN KEY([numeroContrato], [codOtroSi])
REFERENCES [dbo].[contratos] ([numeroContrato], [codOtroSi])
GO
ALTER TABLE [dbo].[mantenimientosxContrato] CHECK CONSTRAINT [FK_mantenimientosxContrato_contratos]
GO
/****** Object:  ForeignKey [FK_mantenimientosxContrato_equipos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[mantenimientosxContrato]  WITH CHECK ADD  CONSTRAINT [FK_mantenimientosxContrato_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[mantenimientosxContrato] CHECK CONSTRAINT [FK_mantenimientosxContrato_equipos]
GO
/****** Object:  ForeignKey [FK_modalidadContrato_tipoContrato]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[modalidadContrato]  WITH CHECK ADD  CONSTRAINT [FK_modalidadContrato_tipoContrato] FOREIGN KEY([codTipoContrato])
REFERENCES [dbo].[tipoContrato] ([codTipoContrato])
GO
ALTER TABLE [dbo].[modalidadContrato] CHECK CONSTRAINT [FK_modalidadContrato_tipoContrato]
GO
/****** Object:  ForeignKey [FK_Modelos_fabricante]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [FK_Modelos_fabricante] FOREIGN KEY([codFabricante])
REFERENCES [dbo].[fabricante] ([codFabricante])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [FK_Modelos_fabricante]
GO
/****** Object:  ForeignKey [FK_Modelos_subTipoEquipo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [FK_Modelos_subTipoEquipo] FOREIGN KEY([codTipoEquipo], [codSubTipoEquipo])
REFERENCES [dbo].[subTipoEquipo] ([codTipoEquipo], [codSubtipoEquipo])
GO
ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [FK_Modelos_subTipoEquipo]
GO
/****** Object:  ForeignKey [FK_modulos_gruposModulos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[modulos]  WITH CHECK ADD  CONSTRAINT [FK_modulos_gruposModulos] FOREIGN KEY([codGrupoModulo])
REFERENCES [dbo].[gruposModulos] ([codGrupoModulo])
GO
ALTER TABLE [dbo].[modulos] CHECK CONSTRAINT [FK_modulos_gruposModulos]
GO
/****** Object:  ForeignKey [FK_modulosxGruposUsuario_gruposUsuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[modulosxGruposUsuario]  WITH CHECK ADD  CONSTRAINT [FK_modulosxGruposUsuario_gruposUsuarios] FOREIGN KEY([codGruposUsu])
REFERENCES [dbo].[gruposUsuarios] ([codGruposUsu])
GO
ALTER TABLE [dbo].[modulosxGruposUsuario] CHECK CONSTRAINT [FK_modulosxGruposUsuario_gruposUsuarios]
GO
/****** Object:  ForeignKey [FK_modulosxGruposUsuario_modulos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[modulosxGruposUsuario]  WITH CHECK ADD  CONSTRAINT [FK_modulosxGruposUsuario_modulos] FOREIGN KEY([codModulo])
REFERENCES [dbo].[modulos] ([codModulo])
GO
ALTER TABLE [dbo].[modulosxGruposUsuario] CHECK CONSTRAINT [FK_modulosxGruposUsuario_modulos]
GO
/****** Object:  ForeignKey [FK_modulosxUsuario_modulos]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[modulosxUsuario]  WITH CHECK ADD  CONSTRAINT [FK_modulosxUsuario_modulos] FOREIGN KEY([codModulo])
REFERENCES [dbo].[modulos] ([codModulo])
GO
ALTER TABLE [dbo].[modulosxUsuario] CHECK CONSTRAINT [FK_modulosxUsuario_modulos]
GO
/****** Object:  ForeignKey [FK_modulosxUsuario_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[modulosxUsuario]  WITH NOCHECK ADD  CONSTRAINT [FK_modulosxUsuario_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[modulosxUsuario] CHECK CONSTRAINT [FK_modulosxUsuario_usuarios]
GO
/****** Object:  ForeignKey [FK_ObservacionesxOrdenPrestamo_OrdenPrestamo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[ObservacionesxOrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_ObservacionesxOrdenPrestamo_OrdenPrestamo] FOREIGN KEY([codOrdenPrestamo])
REFERENCES [dbo].[OrdenPrestamo] ([codOrdenPrestamo])
GO
ALTER TABLE [dbo].[ObservacionesxOrdenPrestamo] CHECK CONSTRAINT [FK_ObservacionesxOrdenPrestamo_OrdenPrestamo]
GO
/****** Object:  ForeignKey [FK_ObservacionesxOrdenPrestamo_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[ObservacionesxOrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_ObservacionesxOrdenPrestamo_usuarios] FOREIGN KEY([loginAutor])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[ObservacionesxOrdenPrestamo] CHECK CONSTRAINT [FK_ObservacionesxOrdenPrestamo_usuarios]
GO
/****** Object:  ForeignKey [FK_OrdenPrestamo_ciudades]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[OrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPrestamo_ciudades] FOREIGN KEY([codPais], [codDepartamento], [codCiudad])
REFERENCES [dbo].[ciudades] ([codPais], [codDepartamento], [codCiudad])
GO
ALTER TABLE [dbo].[OrdenPrestamo] CHECK CONSTRAINT [FK_OrdenPrestamo_ciudades]
GO
/****** Object:  ForeignKey [FK_OrdenPrestamo_estadosOrdenPrestamo]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[OrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPrestamo_estadosOrdenPrestamo] FOREIGN KEY([codEstadoOrdenPrestamo])
REFERENCES [dbo].[estadosOrdenPrestamo] ([codEstadoOrdenPrestamo])
GO
ALTER TABLE [dbo].[OrdenPrestamo] CHECK CONSTRAINT [FK_OrdenPrestamo_estadosOrdenPrestamo]
GO
/****** Object:  ForeignKey [FK_OrdenPrestamo_ordenServicio]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[OrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPrestamo_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[OrdenPrestamo] CHECK CONSTRAINT [FK_OrdenPrestamo_ordenServicio]
GO
/****** Object:  ForeignKey [FK_OrdenPrestamo_usuarios]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[OrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPrestamo_usuarios] FOREIGN KEY([loginRecibido])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[OrdenPrestamo] CHECK CONSTRAINT [FK_OrdenPrestamo_usuarios]
GO
/****** Object:  ForeignKey [FK_OrdenPrestamo_usuarios1]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[OrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPrestamo_usuarios1] FOREIGN KEY([loginAceptado])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[OrdenPrestamo] CHECK CONSTRAINT [FK_OrdenPrestamo_usuarios1]
GO
/****** Object:  ForeignKey [FK_OrdenPrestamo_usuarios2]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[OrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPrestamo_usuarios2] FOREIGN KEY([loginAutorizo])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[OrdenPrestamo] CHECK CONSTRAINT [FK_OrdenPrestamo_usuarios2]
GO
/****** Object:  ForeignKey [FK_OrdenPrestamo_usuarios3]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[OrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPrestamo_usuarios3] FOREIGN KEY([loginSolicito])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[OrdenPrestamo] CHECK CONSTRAINT [FK_OrdenPrestamo_usuarios3]
GO
/****** Object:  ForeignKey [FK_OrdenPrestamo_usuarios4]    Script Date: 02/17/2011 10:56:38 ******/
ALTER TABLE [dbo].[OrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenPrestamo_usuarios4] FOREIGN KEY([loginResponsable])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[OrdenPrestamo] CHECK CONSTRAINT [FK_OrdenPrestamo_usuarios4]
GO
/****** Object:  ForeignKey [FK_ordenServicio_equipos]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[ordenServicio]  WITH CHECK ADD  CONSTRAINT [FK_ordenServicio_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[ordenServicio] CHECK CONSTRAINT [FK_ordenServicio_equipos]
GO
/****** Object:  ForeignKey [FK_ordenServicio_estadosOrdenServicio]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[ordenServicio]  WITH CHECK ADD  CONSTRAINT [FK_ordenServicio_estadosOrdenServicio] FOREIGN KEY([codEstadoOrdenServicio])
REFERENCES [dbo].[estadosOrdenServicio] ([codEstadoOrdenServicio])
GO
ALTER TABLE [dbo].[ordenServicio] CHECK CONSTRAINT [FK_ordenServicio_estadosOrdenServicio]
GO
/****** Object:  ForeignKey [FK_ordenServicio_ModalidadEquipo]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[ordenServicio]  WITH CHECK ADD  CONSTRAINT [FK_ordenServicio_ModalidadEquipo] FOREIGN KEY([codModalidad])
REFERENCES [dbo].[ModalidadEquipo] ([codModalidadEquipo])
GO
ALTER TABLE [dbo].[ordenServicio] CHECK CONSTRAINT [FK_ordenServicio_ModalidadEquipo]
GO
/****** Object:  ForeignKey [FK_ordenServicio_sucursalCliente]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[ordenServicio]  WITH CHECK ADD  CONSTRAINT [FK_ordenServicio_sucursalCliente] FOREIGN KEY([nitCliente], [codSucursal])
REFERENCES [dbo].[sucursalCliente] ([nitCliente], [codSucursal])
GO
ALTER TABLE [dbo].[ordenServicio] CHECK CONSTRAINT [FK_ordenServicio_sucursalCliente]
GO
/****** Object:  ForeignKey [FK_ordenServicio_TipoServicio]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[ordenServicio]  WITH CHECK ADD  CONSTRAINT [FK_ordenServicio_TipoServicio] FOREIGN KEY([codTiposervicio])
REFERENCES [dbo].[TipoServicio] ([codTipoServicio])
GO
ALTER TABLE [dbo].[ordenServicio] CHECK CONSTRAINT [FK_ordenServicio_TipoServicio]
GO
/****** Object:  ForeignKey [FK_parametrosxCgSmtpAccion_cgSmtpAccion]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[parametrosxCgSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_parametrosxCgSmtpAccion_cgSmtpAccion] FOREIGN KEY([idCgSmtpAccion])
REFERENCES [dbo].[cgSmtpAccion] ([idCgSmtpAccion])
GO
ALTER TABLE [dbo].[parametrosxCgSmtpAccion] CHECK CONSTRAINT [FK_parametrosxCgSmtpAccion_cgSmtpAccion]
GO
/****** Object:  ForeignKey [FK_problemas_frecuentes_Modelos]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[problemas_frecuentes]  WITH CHECK ADD  CONSTRAINT [FK_problemas_frecuentes_Modelos] FOREIGN KEY([codFabricante], [codModelo])
REFERENCES [dbo].[Modelos] ([codFabricante], [codModelo])
GO
ALTER TABLE [dbo].[problemas_frecuentes] CHECK CONSTRAINT [FK_problemas_frecuentes_Modelos]
GO
/****** Object:  ForeignKey [FK_programacionViajes_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[programacionViajes]  WITH CHECK ADD  CONSTRAINT [FK_programacionViajes_usuarios] FOREIGN KEY([ingenieroAsignado])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[programacionViajes] CHECK CONSTRAINT [FK_programacionViajes_usuarios]
GO
/****** Object:  ForeignKey [FK_programacionViajes_usuarios1]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[programacionViajes]  WITH CHECK ADD  CONSTRAINT [FK_programacionViajes_usuarios1] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[programacionViajes] CHECK CONSTRAINT [FK_programacionViajes_usuarios1]
GO
/****** Object:  ForeignKey [FK_reasignacionOrdenesTrabajo_ordenServicio]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[reasignacionOrdenesTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_reasignacionOrdenesTrabajo_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[reasignacionOrdenesTrabajo] CHECK CONSTRAINT [FK_reasignacionOrdenesTrabajo_ordenServicio]
GO
/****** Object:  ForeignKey [FK_recoleccion_equipos]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[recoleccion]  WITH CHECK ADD  CONSTRAINT [FK_recoleccion_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[recoleccion] CHECK CONSTRAINT [FK_recoleccion_equipos]
GO
/****** Object:  ForeignKey [FK_recoleccion_estadoRecoleccion]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[recoleccion]  WITH CHECK ADD  CONSTRAINT [FK_recoleccion_estadoRecoleccion] FOREIGN KEY([codEstadoRecoleccion])
REFERENCES [dbo].[estadoRecoleccion] ([codEstadoRecoleccion])
GO
ALTER TABLE [dbo].[recoleccion] CHECK CONSTRAINT [FK_recoleccion_estadoRecoleccion]
GO
/****** Object:  ForeignKey [FK_recoleccion_ModalidadEquipo]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[recoleccion]  WITH CHECK ADD  CONSTRAINT [FK_recoleccion_ModalidadEquipo] FOREIGN KEY([codModalidad])
REFERENCES [dbo].[ModalidadEquipo] ([codModalidadEquipo])
GO
ALTER TABLE [dbo].[recoleccion] CHECK CONSTRAINT [FK_recoleccion_ModalidadEquipo]
GO
/****** Object:  ForeignKey [FK_recoleccion_sucursalCliente]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[recoleccion]  WITH CHECK ADD  CONSTRAINT [FK_recoleccion_sucursalCliente] FOREIGN KEY([nitCliente], [codSucursal])
REFERENCES [dbo].[sucursalCliente] ([nitCliente], [codSucursal])
GO
ALTER TABLE [dbo].[recoleccion] CHECK CONSTRAINT [FK_recoleccion_sucursalCliente]
GO
/****** Object:  ForeignKey [FK_recoleccion_transportadora]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[recoleccion]  WITH CHECK ADD  CONSTRAINT [FK_recoleccion_transportadora] FOREIGN KEY([codTransportadora])
REFERENCES [dbo].[transportadora] ([codTransportadora])
GO
ALTER TABLE [dbo].[recoleccion] CHECK CONSTRAINT [FK_recoleccion_transportadora]
GO
/****** Object:  ForeignKey [FK_recoleccion_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[recoleccion]  WITH CHECK ADD  CONSTRAINT [FK_recoleccion_usuarios] FOREIGN KEY([confirmadaPor])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[recoleccion] CHECK CONSTRAINT [FK_recoleccion_usuarios]
GO
/****** Object:  ForeignKey [FK_recoleccion_usuarios1]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[recoleccion]  WITH CHECK ADD  CONSTRAINT [FK_recoleccion_usuarios1] FOREIGN KEY([solicitadoPor])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[recoleccion] CHECK CONSTRAINT [FK_recoleccion_usuarios1]
GO
/****** Object:  ForeignKey [FK_recoleccion_usuarios2]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[recoleccion]  WITH CHECK ADD  CONSTRAINT [FK_recoleccion_usuarios2] FOREIGN KEY([responsableRecoleccion])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[recoleccion] CHECK CONSTRAINT [FK_recoleccion_usuarios2]
GO
/****** Object:  ForeignKey [FK_referencia_reactivo_fabricante]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[referencia_reactivo]  WITH CHECK ADD  CONSTRAINT [FK_referencia_reactivo_fabricante] FOREIGN KEY([codFabricante])
REFERENCES [dbo].[fabricante] ([codFabricante])
GO
ALTER TABLE [dbo].[referencia_reactivo] CHECK CONSTRAINT [FK_referencia_reactivo_fabricante]
GO
/****** Object:  ForeignKey [FK_regionesXusuarios_ciudades]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[regionesXusuarios]  WITH CHECK ADD  CONSTRAINT [FK_regionesXusuarios_ciudades] FOREIGN KEY([codPais], [codDepartamento], [codCiudad])
REFERENCES [dbo].[ciudades] ([codPais], [codDepartamento], [codCiudad])
GO
ALTER TABLE [dbo].[regionesXusuarios] CHECK CONSTRAINT [FK_regionesXusuarios_ciudades]
GO
/****** Object:  ForeignKey [FK_regionesXusuarios_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[regionesXusuarios]  WITH CHECK ADD  CONSTRAINT [FK_regionesXusuarios_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[regionesXusuarios] CHECK CONSTRAINT [FK_regionesXusuarios_usuarios]
GO
/****** Object:  ForeignKey [FK_repuestosxContratos_contratos]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[repuestosxContratos]  WITH CHECK ADD  CONSTRAINT [FK_repuestosxContratos_contratos] FOREIGN KEY([numeroContrato], [codOtroSi])
REFERENCES [dbo].[contratos] ([numeroContrato], [codOtroSi])
GO
ALTER TABLE [dbo].[repuestosxContratos] CHECK CONSTRAINT [FK_repuestosxContratos_contratos]
GO
/****** Object:  ForeignKey [FK_repuestosxContratos_repuestos]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[repuestosxContratos]  WITH CHECK ADD  CONSTRAINT [FK_repuestosxContratos_repuestos] FOREIGN KEY([codRepuesto])
REFERENCES [dbo].[repuestos] ([codRepuesto])
GO
ALTER TABLE [dbo].[repuestosxContratos] CHECK CONSTRAINT [FK_repuestosxContratos_repuestos]
GO
/****** Object:  ForeignKey [FK_repuestosxOrdenPrestamo_OrdenPrestamo]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[repuestosxOrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_repuestosxOrdenPrestamo_OrdenPrestamo] FOREIGN KEY([codOrdenPrestamo])
REFERENCES [dbo].[OrdenPrestamo] ([codOrdenPrestamo])
GO
ALTER TABLE [dbo].[repuestosxOrdenPrestamo] CHECK CONSTRAINT [FK_repuestosxOrdenPrestamo_OrdenPrestamo]
GO
/****** Object:  ForeignKey [FK_repuestosxOrdenPrestamo_repuestos]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[repuestosxOrdenPrestamo]  WITH CHECK ADD  CONSTRAINT [FK_repuestosxOrdenPrestamo_repuestos] FOREIGN KEY([codRepuesto])
REFERENCES [dbo].[repuestos] ([codRepuesto])
GO
ALTER TABLE [dbo].[repuestosxOrdenPrestamo] CHECK CONSTRAINT [FK_repuestosxOrdenPrestamo_repuestos]
GO
/****** Object:  ForeignKey [FK_repuestoxOrdenServicio_ordenServicio]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[repuestoxOrdenServicio]  WITH CHECK ADD  CONSTRAINT [FK_repuestoxOrdenServicio_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[repuestoxOrdenServicio] CHECK CONSTRAINT [FK_repuestoxOrdenServicio_ordenServicio]
GO
/****** Object:  ForeignKey [FK_repuestoxOrdenServicio_repuestos]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[repuestoxOrdenServicio]  WITH CHECK ADD  CONSTRAINT [FK_repuestoxOrdenServicio_repuestos] FOREIGN KEY([codRepuesto])
REFERENCES [dbo].[repuestos] ([codRepuesto])
GO
ALTER TABLE [dbo].[repuestoxOrdenServicio] CHECK CONSTRAINT [FK_repuestoxOrdenServicio_repuestos]
GO
/****** Object:  ForeignKey [FK_seguimiento_contactosClientes]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[seguimiento]  WITH CHECK ADD  CONSTRAINT [FK_seguimiento_contactosClientes] FOREIGN KEY([nitCliente], [codContacto])
REFERENCES [dbo].[contactosClientes] ([nitCliente], [codContacto])
GO
ALTER TABLE [dbo].[seguimiento] CHECK CONSTRAINT [FK_seguimiento_contactosClientes]
GO
/****** Object:  ForeignKey [FK_seguimiento_LlamadaSoporte]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[seguimiento]  WITH CHECK ADD  CONSTRAINT [FK_seguimiento_LlamadaSoporte] FOREIGN KEY([idLlamadaSoporte])
REFERENCES [dbo].[LlamadaSoporte] ([idLlamadaSoporte])
GO
ALTER TABLE [dbo].[seguimiento] CHECK CONSTRAINT [FK_seguimiento_LlamadaSoporte]
GO
/****** Object:  ForeignKey [FK_solicitudInsumos_ordenServicio]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudInsumos]  WITH CHECK ADD  CONSTRAINT [FK_solicitudInsumos_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[solicitudInsumos] CHECK CONSTRAINT [FK_solicitudInsumos_ordenServicio]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_asesoresComerciales]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_asesoresComerciales] FOREIGN KEY([codAsesor])
REFERENCES [dbo].[asesoresComerciales] ([codAsesor])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_asesoresComerciales]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_clientes]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_clientes] FOREIGN KEY([nitCliente])
REFERENCES [dbo].[clientes] ([nitCliente])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_clientes]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_equipos]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_equipos] FOREIGN KEY([serial])
REFERENCES [dbo].[equipos] ([serial])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_equipos]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_estadosSolicitud]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_estadosSolicitud] FOREIGN KEY([codEstadoSolicitud])
REFERENCES [dbo].[estadosSolicitud] ([codEstadoSolicitud])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_estadosSolicitud]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_medioSolicitud]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_medioSolicitud] FOREIGN KEY([codMedioSolicitud])
REFERENCES [dbo].[medioSolicitud] ([codMedioSolicitud])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_medioSolicitud]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_ModalidadEquipo]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_ModalidadEquipo] FOREIGN KEY([codModalidad])
REFERENCES [dbo].[ModalidadEquipo] ([codModalidadEquipo])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_ModalidadEquipo]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_ordenServicio]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_ordenServicio] FOREIGN KEY([codOrdenServicio])
REFERENCES [dbo].[ordenServicio] ([codOrdenServicio])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_ordenServicio]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_prioridadSolicitud]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_prioridadSolicitud] FOREIGN KEY([codPrioridadSolicitud])
REFERENCES [dbo].[prioridadSolicitud] ([codPrioridadSolicitud])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_prioridadSolicitud]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_TipoServicio]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_TipoServicio] FOREIGN KEY([codTipoServicio])
REFERENCES [dbo].[TipoServicio] ([codTipoServicio])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_TipoServicio]
GO
/****** Object:  ForeignKey [FK_solicitudServicio_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[solicitudServicio]  WITH CHECK ADD  CONSTRAINT [FK_solicitudServicio_usuarios] FOREIGN KEY([creadaPor])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[solicitudServicio] CHECK CONSTRAINT [FK_solicitudServicio_usuarios]
GO
/****** Object:  ForeignKey [FK_soluciones_problemas_problemas_frecuentes]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[soluciones_problemas]  WITH CHECK ADD  CONSTRAINT [FK_soluciones_problemas_problemas_frecuentes] FOREIGN KEY([cod_problema_frecuente])
REFERENCES [dbo].[problemas_frecuentes] ([cod_problema_frecuente])
GO
ALTER TABLE [dbo].[soluciones_problemas] CHECK CONSTRAINT [FK_soluciones_problemas_problemas_frecuentes]
GO
/****** Object:  ForeignKey [FK_subCategoriaComponente_subTipoComponente]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[subCategoriaComponente]  WITH CHECK ADD  CONSTRAINT [FK_subCategoriaComponente_subTipoComponente] FOREIGN KEY([codTipoComponente], [codSubTipoComponente])
REFERENCES [dbo].[subTipoComponente] ([codTipoComponente], [codSubTipoCom])
GO
ALTER TABLE [dbo].[subCategoriaComponente] CHECK CONSTRAINT [FK_subCategoriaComponente_subTipoComponente]
GO
/****** Object:  ForeignKey [FK_subTipoComponente_tipoComponente]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[subTipoComponente]  WITH CHECK ADD  CONSTRAINT [FK_subTipoComponente_tipoComponente] FOREIGN KEY([codTipoComponente])
REFERENCES [dbo].[tipoComponente] ([codTipoComponente])
GO
ALTER TABLE [dbo].[subTipoComponente] CHECK CONSTRAINT [FK_subTipoComponente_tipoComponente]
GO
/****** Object:  ForeignKey [FK_subTipoEquipo_tipoEquipo]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[subTipoEquipo]  WITH CHECK ADD  CONSTRAINT [FK_subTipoEquipo_tipoEquipo] FOREIGN KEY([codTipoEquipo])
REFERENCES [dbo].[tipoEquipo] ([codTipoEquipo])
GO
ALTER TABLE [dbo].[subTipoEquipo] CHECK CONSTRAINT [FK_subTipoEquipo_tipoEquipo]
GO
/****** Object:  ForeignKey [FK_sucursalCliente_ciudades]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[sucursalCliente]  WITH CHECK ADD  CONSTRAINT [FK_sucursalCliente_ciudades] FOREIGN KEY([codPais], [codDepartamento], [codCiudad])
REFERENCES [dbo].[ciudades] ([codPais], [codDepartamento], [codCiudad])
GO
ALTER TABLE [dbo].[sucursalCliente] CHECK CONSTRAINT [FK_sucursalCliente_ciudades]
GO
/****** Object:  ForeignKey [FK_sucursalCliente_clientes]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[sucursalCliente]  WITH CHECK ADD  CONSTRAINT [FK_sucursalCliente_clientes] FOREIGN KEY([nitCliente])
REFERENCES [dbo].[clientes] ([nitCliente])
GO
ALTER TABLE [dbo].[sucursalCliente] CHECK CONSTRAINT [FK_sucursalCliente_clientes]
GO
/****** Object:  ForeignKey [FK_sucursalCliente_contactosClientes]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[sucursalCliente]  WITH CHECK ADD  CONSTRAINT [FK_sucursalCliente_contactosClientes] FOREIGN KEY([nitCliente], [codContacto])
REFERENCES [dbo].[contactosClientes] ([nitCliente], [codContacto])
GO
ALTER TABLE [dbo].[sucursalCliente] CHECK CONSTRAINT [FK_sucursalCliente_contactosClientes]
GO
/****** Object:  ForeignKey [FK_tarea_asesoria_cientifica_asesoria_cientifica]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[tarea_asesoria_cientifica]  WITH CHECK ADD  CONSTRAINT [FK_tarea_asesoria_cientifica_asesoria_cientifica] FOREIGN KEY([cod_asesoria_cientifica])
REFERENCES [dbo].[asesoria_cientifica] ([cod_asesoria_cientifica])
GO
ALTER TABLE [dbo].[tarea_asesoria_cientifica] CHECK CONSTRAINT [FK_tarea_asesoria_cientifica_asesoria_cientifica]
GO
/****** Object:  ForeignKey [FK_task_prioridad]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[task]  WITH CHECK ADD  CONSTRAINT [FK_task_prioridad] FOREIGN KEY([codPrioridad])
REFERENCES [dbo].[prioridad] ([codPrioridad])
GO
ALTER TABLE [dbo].[task] CHECK CONSTRAINT [FK_task_prioridad]
GO
/****** Object:  ForeignKey [FK_task_taskCategoria]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[task]  WITH CHECK ADD  CONSTRAINT [FK_task_taskCategoria] FOREIGN KEY([codCategoria])
REFERENCES [dbo].[taskCategoria] ([codCategoria])
GO
ALTER TABLE [dbo].[task] CHECK CONSTRAINT [FK_task_taskCategoria]
GO
/****** Object:  ForeignKey [FK_task_taskEstatus]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[task]  WITH CHECK ADD  CONSTRAINT [FK_task_taskEstatus] FOREIGN KEY([codEstatus])
REFERENCES [dbo].[taskEstatus] ([codEstatus])
GO
ALTER TABLE [dbo].[task] CHECK CONSTRAINT [FK_task_taskEstatus]
GO
/****** Object:  ForeignKey [FK_task_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[task]  WITH CHECK ADD  CONSTRAINT [FK_task_usuarios] FOREIGN KEY([loginAutor])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[task] CHECK CONSTRAINT [FK_task_usuarios]
GO
/****** Object:  ForeignKey [FK_task_usuarios1]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[task]  WITH CHECK ADD  CONSTRAINT [FK_task_usuarios1] FOREIGN KEY([loginPropietario])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[task] CHECK CONSTRAINT [FK_task_usuarios1]
GO
/****** Object:  ForeignKey [FK_taskAdjuntos_task]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[taskAdjuntos]  WITH CHECK ADD  CONSTRAINT [FK_taskAdjuntos_task] FOREIGN KEY([codTarea])
REFERENCES [dbo].[task] ([codTarea])
GO
ALTER TABLE [dbo].[taskAdjuntos] CHECK CONSTRAINT [FK_taskAdjuntos_task]
GO
/****** Object:  ForeignKey [FK_taskPatronRecurrencia_task]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[taskPatronRecurrencia]  WITH CHECK ADD  CONSTRAINT [FK_taskPatronRecurrencia_task] FOREIGN KEY([codTarea])
REFERENCES [dbo].[task] ([codTarea])
GO
ALTER TABLE [dbo].[taskPatronRecurrencia] CHECK CONSTRAINT [FK_taskPatronRecurrencia_task]
GO
/****** Object:  ForeignKey [FK_TaskReminder_task]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[TaskReminder]  WITH CHECK ADD  CONSTRAINT [FK_TaskReminder_task] FOREIGN KEY([codTarea])
REFERENCES [dbo].[task] ([codTarea])
GO
ALTER TABLE [dbo].[TaskReminder] CHECK CONSTRAINT [FK_TaskReminder_task]
GO
/****** Object:  ForeignKey [FK_usuarioCopiaOcultaxSmtpAccion_cgSmtpAccion]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuarioCopiaOcultaxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_usuarioCopiaOcultaxSmtpAccion_cgSmtpAccion] FOREIGN KEY([idCgSmtpAccion])
REFERENCES [dbo].[cgSmtpAccion] ([idCgSmtpAccion])
GO
ALTER TABLE [dbo].[usuarioCopiaOcultaxSmtpAccion] CHECK CONSTRAINT [FK_usuarioCopiaOcultaxSmtpAccion_cgSmtpAccion]
GO
/****** Object:  ForeignKey [FK_usuarioCopiaOcultaxSmtpAccion_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuarioCopiaOcultaxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_usuarioCopiaOcultaxSmtpAccion_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[usuarioCopiaOcultaxSmtpAccion] CHECK CONSTRAINT [FK_usuarioCopiaOcultaxSmtpAccion_usuarios]
GO
/****** Object:  ForeignKey [FK_usuarioCopiaxSmtpAccion_cgSmtpAccion]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuarioCopiaxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_usuarioCopiaxSmtpAccion_cgSmtpAccion] FOREIGN KEY([idCgSmtpAccion])
REFERENCES [dbo].[cgSmtpAccion] ([idCgSmtpAccion])
GO
ALTER TABLE [dbo].[usuarioCopiaxSmtpAccion] CHECK CONSTRAINT [FK_usuarioCopiaxSmtpAccion_cgSmtpAccion]
GO
/****** Object:  ForeignKey [FK_usuarioCopiaxSmtpAccion_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuarioCopiaxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_usuarioCopiaxSmtpAccion_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[usuarioCopiaxSmtpAccion] CHECK CONSTRAINT [FK_usuarioCopiaxSmtpAccion_usuarios]
GO
/****** Object:  ForeignKey [FK_usuariosXusuarios_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuariosXusuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuariosXusuarios_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[usuariosXusuarios] CHECK CONSTRAINT [FK_usuariosXusuarios_usuarios]
GO
/****** Object:  ForeignKey [FK_usuariosXusuarios_usuarios1]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuariosXusuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuariosXusuarios_usuarios1] FOREIGN KEY([subordinadoDe])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[usuariosXusuarios] CHECK CONSTRAINT [FK_usuariosXusuarios_usuarios1]
GO
/****** Object:  ForeignKey [FK_usuarioxSmtpAccion_cgSmtpAccion]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuarioxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_usuarioxSmtpAccion_cgSmtpAccion] FOREIGN KEY([idCgSmtpAccion])
REFERENCES [dbo].[cgSmtpAccion] ([idCgSmtpAccion])
GO
ALTER TABLE [dbo].[usuarioxSmtpAccion] CHECK CONSTRAINT [FK_usuarioxSmtpAccion_cgSmtpAccion]
GO
/****** Object:  ForeignKey [FK_usuarioxSmtpAccion_usuarios]    Script Date: 02/17/2011 10:56:39 ******/
ALTER TABLE [dbo].[usuarioxSmtpAccion]  WITH CHECK ADD  CONSTRAINT [FK_usuarioxSmtpAccion_usuarios] FOREIGN KEY([login])
REFERENCES [dbo].[usuarios] ([login])
GO
ALTER TABLE [dbo].[usuarioxSmtpAccion] CHECK CONSTRAINT [FK_usuarioxSmtpAccion_usuarios]
GO

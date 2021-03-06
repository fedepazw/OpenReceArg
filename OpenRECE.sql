USE [master]
GO
/****** Object:  Database [OpenRECE]    Script Date: 07/04/2016 19:58:19 ******/
CREATE DATABASE [OpenRECE] ON  PRIMARY 
( NAME = N'OpenRECE', FILENAME = N'C:\MSSQL\Data\OpenRECE.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OpenRECE_log', FILENAME = N'C:\MSSQL\Data\OpenRECE_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OpenRECE] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OpenRECE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OpenRECE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OpenRECE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OpenRECE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OpenRECE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OpenRECE] SET ARITHABORT OFF 
GO
ALTER DATABASE [OpenRECE] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [OpenRECE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OpenRECE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OpenRECE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OpenRECE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OpenRECE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OpenRECE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OpenRECE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OpenRECE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OpenRECE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OpenRECE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OpenRECE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OpenRECE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OpenRECE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OpenRECE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OpenRECE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OpenRECE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OpenRECE] SET RECOVERY FULL 
GO
ALTER DATABASE [OpenRECE] SET  MULTI_USER 
GO
ALTER DATABASE [OpenRECE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OpenRECE] SET DB_CHAINING OFF 
GO
USE [OpenRECE]
GO
/****** Object:  Table [dbo].[Comprobantes]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comprobantes](
	[Id_Transaccion] [int] NOT NULL,
	[Id_PtoVenta] [smallint] NOT NULL,
	[Id_TipoCbte] [int] NOT NULL,
	[Id_TipoConcepto] [int] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Nro_CbteDesde] [int] NOT NULL,
	[Nro_CbteHasta] [int] NOT NULL,
	[CbteFch] [datetime] NULL,
	[ImpTotal] [decimal](15, 2) NOT NULL,
	[ImpTotConc] [decimal](15, 2) NOT NULL,
	[ImpNeto] [decimal](15, 2) NOT NULL,
	[ImpOpEx] [decimal](15, 2) NOT NULL,
	[ImpTrib] [decimal](15, 2) NOT NULL,
	[ImpIVA] [decimal](15, 2) NOT NULL,
	[FchServDesde] [datetime] NULL,
	[FchServHasta] [datetime] NULL,
	[FchVtoPago] [datetime] NULL,
	[Id_TipoMoneda] [varchar](3) NOT NULL,
	[MonCotiz] [decimal](10, 6) NOT NULL,
 CONSTRAINT [PK_Comprobantes] PRIMARY KEY CLUSTERED 
(
	[Id_Transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comprobantes_Autorizados]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comprobantes_Autorizados](
	[Id_PtoVenta] [smallint] NOT NULL,
	[Id_TipoCbte] [int] NOT NULL,
	[Id_TipoConcepto] [int] NOT NULL,
	[Id_TipoDoc] [int] NOT NULL,
	[DocNro] [bigint] NOT NULL,
	[Nro_CbteDesde] [int] NOT NULL,
	[Nro_CbteHasta] [int] NOT NULL,
	[CbteFch] [datetime] NULL,
	[ImpTotal] [decimal](15, 2) NOT NULL,
	[ImpTotConc] [decimal](15, 2) NOT NULL,
	[ImpNeto] [decimal](15, 2) NOT NULL,
	[ImpOpEx] [decimal](15, 2) NOT NULL,
	[ImpTrib] [decimal](15, 2) NOT NULL,
	[ImpIVA] [decimal](15, 2) NOT NULL,
	[FchServDesde] [datetime] NULL,
	[FchServHasta] [datetime] NULL,
	[FchVtoPago] [datetime] NULL,
	[Id_TipoMoneda] [varchar](3) NOT NULL,
	[MonCotiz] [decimal](10, 6) NOT NULL,
	[Resultado] [varchar](100) NOT NULL,
	[CodAutorizacion] [varchar](20) NOT NULL,
	[EmisionTipo] [varchar](5) NOT NULL,
	[FchVto] [datetime] NOT NULL,
	[FchProceso] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Configuracion_Certificado]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Configuracion_Certificado](
	[Id_Configuracion] [int] NOT NULL,
	[Cuit] [bigint] NULL,
	[ArchivoCertificadoPFX] [varchar](300) NULL,
	[PasswordPFX] [varchar](20) NULL,
	[TipoAprobacion] [char](1) NULL,
 CONSTRAINT [PK_Configuracion_Certificado] PRIMARY KEY CLUSTERED 
(
	[Id_Configuracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Errores_WS]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Errores_WS](
	[Id_Error] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NULL,
	[Mensaje] [varchar](300) NULL,
	[Fecha] [datetime] NULL,
	[Observaciones] [varchar](500) NULL,
 CONSTRAINT [PK_Errores_WS] PRIMARY KEY CLUSTERED 
(
	[Id_Error] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Eventos_WS]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Eventos_WS](
	[Id_Evento] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [int] NULL,
	[Mensaje] [varchar](300) NULL,
	[Fecha] [datetime] NULL,
	[Observaciones] [varchar](500) NULL,
 CONSTRAINT [PK_Eventos_WS] PRIMARY KEY CLUSTERED 
(
	[Id_Evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PtosVenta]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PtosVenta](
	[Id_PtoVenta] [smallint] NOT NULL,
	[EmisionTipo] [varchar](8) NULL,
	[Bloqueado] [char](1) NULL,
	[FchBaja] [datetime] NULL,
 CONSTRAINT [PK_PtosVenta] PRIMARY KEY CLUSTERED 
(
	[Id_PtoVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tickets_acceso]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tickets_acceso](
	[id_ticket] [int] IDENTITY(1,1) NOT NULL,
	[fecha_generacion] [datetime] NULL,
	[fecha_expiracion] [datetime] NULL,
	[sign] [varchar](2000) NULL,
	[token] [varchar](2000) NULL,
	[TipoAprobacion] [char](1) NULL,
	[Cuit] [bigint] NULL,
 CONSTRAINT [PK_tickets_acceso] PRIMARY KEY CLUSTERED 
(
	[id_ticket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposCbtes]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposCbtes](
	[Id_TipoCbte] [int] NOT NULL,
	[Descripcion] [varchar](250) NULL,
	[FchDesde] [datetime] NULL,
	[FchHasta] [datetime] NULL,
 CONSTRAINT [PK_TiposCbtes] PRIMARY KEY CLUSTERED 
(
	[Id_TipoCbte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposConceptos]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposConceptos](
	[Id_TipoConcepto] [int] NOT NULL,
	[Descripcion] [varchar](250) NULL,
	[FchDesde] [datetime] NULL,
	[FchHasta] [datetime] NULL,
 CONSTRAINT [PK_TiposConceptos] PRIMARY KEY CLUSTERED 
(
	[Id_TipoConcepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposDocumentos]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposDocumentos](
	[Id_TipoDocumento] [int] NOT NULL,
	[Descripcion] [varchar](250) NULL,
	[FchDesde] [datetime] NULL,
	[FchHasta] [datetime] NULL,
 CONSTRAINT [PK_TiposDocumentos] PRIMARY KEY CLUSTERED 
(
	[Id_TipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposIva]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposIva](
	[Id_TipoIva] [varchar](10) NOT NULL,
	[Descripcion] [varchar](250) NULL,
	[FchDesde] [datetime] NULL,
	[FchHasta] [datetime] NULL,
 CONSTRAINT [PK_TiposIva] PRIMARY KEY CLUSTERED 
(
	[Id_TipoIva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposMonedas]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposMonedas](
	[id_TipoMoneda] [varchar](20) NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[FchDesde] [datetime] NULL,
	[FchHasta] [datetime] NULL,
 CONSTRAINT [PK_TiposMonedas] PRIMARY KEY CLUSTERED 
(
	[id_TipoMoneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposOpcionales]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposOpcionales](
	[Id_TipoOpcional] [varchar](20) NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[FchDesde] [datetime] NULL,
	[FchHasta] [datetime] NULL,
 CONSTRAINT [PK_TiposOpcionales] PRIMARY KEY CLUSTERED 
(
	[Id_TipoOpcional] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposPaises]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposPaises](
	[Id_Pais] [int] NOT NULL,
	[Descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_TiposPaises] PRIMARY KEY CLUSTERED 
(
	[Id_Pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposTributos]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposTributos](
	[Id_TipoTributo] [smallint] NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[FchDesde] [datetime] NULL,
	[FchHasta] [datetime] NULL,
 CONSTRAINT [PK_TiposTributos] PRIMARY KEY CLUSTERED 
(
	[Id_TipoTributo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UltCbtesAutorizados]    Script Date: 07/04/2016 19:58:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UltCbtesAutorizados](
	[Id_PtoVenta] [smallint] NULL,
	[Id_TipoCbte] [int] NULL,
	[Nro_Cbte] [int] NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [OpenRECE] SET  READ_WRITE 
GO

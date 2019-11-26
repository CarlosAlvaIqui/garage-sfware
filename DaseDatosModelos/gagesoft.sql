USE [db_gagesoft]
GO
/****** Object:  User [usr1]    Script Date: 26/11/2019 14:24:12 ******/
CREATE USER [usr1] FOR LOGIN [usr1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[boleta]    Script Date: 26/11/2019 14:24:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[boleta](
	[botela_id] [int] IDENTITY(1,1) NOT NULL,
	[parkingLot_id] [int] NULL,
	[usuarios_id] [int] NULL,
	[carros_id] [int] NULL,
	[inicioHora] [datetime] NULL,
	[finalHora] [datetime] NULL,
	[monto] [float] NULL,
	[descuento] [float] NULL,
	[total] [float] NULL,
 CONSTRAINT [PK_boleta] PRIMARY KEY CLUSTERED 
(
	[botela_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[carros]    Script Date: 26/11/2019 14:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carros](
	[car_id] [int] NOT NULL,
	[placa] [nvarchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[tipo] [nvarchar](50) NULL,
	[propietario] [nvarchar](50) NULL,
 CONSTRAINT [PK_carros] PRIMARY KEY CLUSTERED 
(
	[car_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empleados]    Script Date: 26/11/2019 14:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[empleados_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellidos] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[direccion] [nvarchar](50) NULL,
	[cargo] [nvarchar](50) NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[empleados_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[parkingLot]    Script Date: 26/11/2019 14:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parkingLot](
	[parkingLot_id] [int] IDENTITY(1,1) NOT NULL,
	[usuarios_id] [int] NULL,
	[nombre_local] [nvarchar](50) NULL,
	[ubicacion] [nvarchar](50) NULL,
	[cobroHora] [float] NULL,
 CONSTRAINT [PK_parkingLot] PRIMARY KEY CLUSTERED 
(
	[parkingLot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Table_1]    Script Date: 26/11/2019 14:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_1](
	[clientes_id] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [nvarchar](50) NULL,
	[apellidos] [nvarchar](50) NULL,
	[car_id] [int] NULL,
	[score] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[clientes_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_usuario]    Script Date: 26/11/2019 14:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_usuario](
	[tipo_user_id] [int] NULL,
	[tipo_name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 26/11/2019 14:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usuarios_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[empleado_id] [int] NULL,
	[tipoUser_id] [int] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[usuarios_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

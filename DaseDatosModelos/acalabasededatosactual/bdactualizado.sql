USE [softwaregarege_db]
GO
/****** Object:  Table [dbo].[automoviles]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[automoviles](
	[carros_id] [int] IDENTITY(1,1) NOT NULL,
	[placa] [nvarchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[propietario] [nvarchar](50) NULL,
	[tipo_carro_id] [int] NULL,
 CONSTRAINT [PK_automoviles] PRIMARY KEY CLUSTERED 
(
	[carros_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[boleta]    Script Date: 08/12/2019 9:52:38 ******/
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
/****** Object:  Table [dbo].[empleados]    Script Date: 08/12/2019 9:52:38 ******/
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
/****** Object:  Table [dbo].[parkingLot]    Script Date: 08/12/2019 9:52:38 ******/
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
	[lugares] [int] NULL,
	[saldo] [float] NULL,
	[coches_actuales] [int] NULL,
	[Pago_realizado] [int] NULL,
 CONSTRAINT [PK_parkingLot] PRIMARY KEY CLUSTERED 
(
	[parkingLot_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_automoviles]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_automoviles](
	[tipo_carro_id] [int] IDENTITY(1,1) NOT NULL,
	[tipo_carro] [nvarchar](50) NULL,
 CONSTRAINT [PK_tipo_carro] PRIMARY KEY CLUSTERED 
(
	[tipo_carro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_user]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_user](
	[tipoUser_id] [int] IDENTITY(1,1) NOT NULL,
	[tipo_name] [nchar](10) NULL,
 CONSTRAINT [PK_tipo_user] PRIMARY KEY CLUSTERED 
(
	[tipoUser_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 08/12/2019 9:52:38 ******/
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
ALTER TABLE [dbo].[automoviles]  WITH CHECK ADD  CONSTRAINT [FK_automoviles_tipo_automoviles] FOREIGN KEY([tipo_carro_id])
REFERENCES [dbo].[tipo_automoviles] ([tipo_carro_id])
GO
ALTER TABLE [dbo].[automoviles] CHECK CONSTRAINT [FK_automoviles_tipo_automoviles]
GO
ALTER TABLE [dbo].[boleta]  WITH CHECK ADD  CONSTRAINT [FK_boleta_automoviles] FOREIGN KEY([carros_id])
REFERENCES [dbo].[automoviles] ([carros_id])
GO
ALTER TABLE [dbo].[boleta] CHECK CONSTRAINT [FK_boleta_automoviles]
GO
ALTER TABLE [dbo].[boleta]  WITH CHECK ADD  CONSTRAINT [FK_boleta_parkingLot] FOREIGN KEY([parkingLot_id])
REFERENCES [dbo].[parkingLot] ([parkingLot_id])
GO
ALTER TABLE [dbo].[boleta] CHECK CONSTRAINT [FK_boleta_parkingLot]
GO
ALTER TABLE [dbo].[boleta]  WITH CHECK ADD  CONSTRAINT [FK_boleta_usuarios] FOREIGN KEY([usuarios_id])
REFERENCES [dbo].[usuarios] ([usuarios_id])
GO
ALTER TABLE [dbo].[boleta] CHECK CONSTRAINT [FK_boleta_usuarios]
GO
ALTER TABLE [dbo].[parkingLot]  WITH CHECK ADD  CONSTRAINT [FK_parkingLot_usuarios] FOREIGN KEY([usuarios_id])
REFERENCES [dbo].[usuarios] ([usuarios_id])
GO
ALTER TABLE [dbo].[parkingLot] CHECK CONSTRAINT [FK_parkingLot_usuarios]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_empleados] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleados] ([empleados_id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_empleados]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_tipo_user] FOREIGN KEY([tipoUser_id])
REFERENCES [dbo].[tipo_user] ([tipoUser_id])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_tipo_user]
GO
/****** Object:  StoredProcedure [dbo].[createemployer]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[createemployer]
@nombre nvarchar(45),
@apellidos nvarchar(45),
@email nvarchar(45),
@direccion nvarchar(45),
@cargo nvarchar(45)
as
insert into empleados(nombre,apellidos,email,direccion,cargo)
values(@nombre,@apellidos,@email,@direccion,@cargo);
GO
/****** Object:  StoredProcedure [dbo].[createParkingt]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[createParkingt]
@usuarios_id int,
@nombre_local nvarchar(45),
@ubicacion nvarchar(45),
@cobroHora float,
@lugares int,
@saldo float,
@coches_actuales int
as
insert into parkingLot(usuarios_id,nombre_local,ubicacion,cobroHora,lugares,saldo,coches_actuales)
values(@usuarios_id,@nombre_local,@ubicacion,@cobroHora,@lugares,@saldo,@coches_actuales);
GO
/****** Object:  StoredProcedure [dbo].[createuser]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[createuser]
@username nvarchar(45),
@password nvarchar(45),
@empleado_id int,
@tipoUser_id int
as
insert into usuarios(username,password,empleado_id,tipoUser_id)
values(@username,@password,@empleado_id,@tipoUser_id);
GO
/****** Object:  StoredProcedure [dbo].[createuserempo]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[createuserempo]
@nombre nvarchar(45),
@apellidos nvarchar(45),
@email nvarchar(45),
@direccion nvarchar(45),
@cargo nvarchar(45),

@username nvarchar(45),
@password nvarchar(45),
@tipoUser_id int
as
	insert into empleados(nombre,apellidos,email,direccion,cargo)
	values(@nombre,@apellidos,@email,@direccion,@cargo)

BEGIN
	BEGIN TRANSACTION
			DECLARE @TagID int;
			SELECT @TagID = coalesce((select max(empleados_id) from empleados), 1)
	COMMIT 

	insert into usuarios(username,password,empleado_id,tipoUser_id)
	values(@username,@password,@TagID,@tipoUser_id);
	
end
GO
/****** Object:  StoredProcedure [dbo].[findautos]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[findautos]
@placa nvarchar(45)
as
select * from automoviles where placa like '%'+@placa+'%';
GO
/****** Object:  StoredProcedure [dbo].[highid]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[highid]
AS
    SELECT isnull(MAX(empleados_id),0) AS Valor FROM empleados
RETURN
GO
/****** Object:  StoredProcedure [dbo].[LOGEO]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOGEO](
	@username nvarchar(25),
	@password nvarchar(25)
)
as 
begin 
	select usuarios_id from usuarios
		where username=@username and password=@password
end
GO
/****** Object:  StoredProcedure [dbo].[registrarautos]    Script Date: 08/12/2019 9:52:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registrarautos]
@placa nvarchar(45),
@descripcion nvarchar(45),
@propietario nvarchar(45),
@tipo_carro_id int 
as
insert into automoviles(placa,descripcion,propietario,tipo_carro_id)
values(@placa,@descripcion,@propietario,@tipo_carro_id);
GO

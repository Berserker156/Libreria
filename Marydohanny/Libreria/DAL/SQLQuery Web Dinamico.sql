CREATE DATABASE DinamitaWeb
GO
USE DinamitaWeb

CREATE TABLE Roles(
IdRol INT PRIMARY KEY IDENTITY (1,1),
Rol VARCHAR(50) NOT NULL,
Activo BIT DEFAULT(1),
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
CREATE TABLE Usuarios
(
IdUsuario INT PRIMARY KEY IDENTITY (1,1),
NombreCompleto VARCHAR(200) NOT NULL,
Correo VARCHAR(200) NOT NULL,
UserName VARCHAR(50) NOT NULL,
Password VARBINARY(MAX) NOT NULL,
Bloqueado BIT NOT NULL,
IntentosFallidos SMALLINT NOT NULL DEFAULT(0),
IdRol INT FOREIGN KEY REFERENCES Roles(IdRol),
Activo BIT DEFAULT(1),
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
CREATE TABLE Formularios(
IdFormulario INT PRIMARY KEY IDENTITY(1,1),
Formulario VARCHAR(50) NOT NULL,
Activo BIT DEFAULT(1),
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
GO
CREATE TABLE Permisos(
IdPermiso INT PRIMARY KEY IDENTITY(1,1),
Permiso VARCHAR(50) NOT NULL,
Activo BIT DEFAULT(1),
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
CREATE TABLE RolFormularios
(
IdRolFormulario INT PRIMARY KEY IDENTITY(1,1),
IdRol INT FOREIGN KEY REFERENCES Roles(IdRol),
IdFormulario INT FOREIGN KEY REFERENCES Formularios(IdFormulario),
Activo BIT DEFAULT(1),
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)
GO
CREATE TABLE RolPermisos
(
IdRolPermiso INT PRIMARY KEY IDENTITY (1,1),
IdRol INT FOREIGN KEY REFERENCES Roles(IdRol),
IdPermiso INT FOREIGN KEY REFERENCES Permisos(IdPermiso),
Activo BIT DEFAULT(1),
IdUsuarioRegistra INT NOT NULL,
FechaRegistro DATETIME NOT NULL,
IdUsuarioActualiza INT NULL,
FechaActualizacion DATETIME NULL
)

create table Libros(
ID INT primary key, 
nombre Nvarchar(50),
Area Nvarchar(100), 
Autor Nvarchar(100), 
Idioma Nvarchar(50), 
editorial Nvarchar(50), 
fecha_publicación date, 
páginas int);

create table Libros_Descargados (
nombre_del_libro Nvarchar(50) primary key,
hora time, 
fecha date, 
id_usuario int);

create table comentarios(
Correo VARCHAR(200) primary key, 
comentario Nvarchar(500));

create table Editorial(
Nombre Nvarchar(50) primary key,
fecha_de_publicaion date,
locacion Nvarchar(50));

create table Autor(
ID int ,
nombre  Nvarchar(100) primary key,
apellido Nvarchar(50),
edad int);


/* PROCEDIMIENTOS ALMACENADOS */
/* Procedimientos almacenados  de usuarios*/
USE DinamitaWeb
go
CREATE PROC InsertUsuarios 

@IdUsuario INT,
@NombreCompleto VARCHAR(200),
@Correo VARCHAR(200),
@Password VARBINARY(MAX),
@Bloqueado BIT,
@IntentosFallidos SMALLINT,
@IdRol INT,
@Activo BIT,
@IdUsuarioRegistra INT,
@FechaRegistro DATETIME,
@IdUsuarioActualiza INT,
@FechaActualizacion DATETIME
as
begin
insert into Usuarios (IdUsuario, NombreCompleto, Correo, Password ,Bloqueado,IntentosFallidos,IdRol, Activo,IdUsuarioRegistra,
FechaRegistro,IdUsuarioActualiza, FechaActualizacion)
	Values (@IdUsuario, @NombreCompleto, @Correo , @Password,@Bloqueado,@IntentosFallidos,@IdRol,1 ,@IdUsuarioRegistra,@FechaRegistro ,
	@IdUsuarioActualiza, @FechaActualizacion);
end
go
/*PROCESO DE ACTUALIZAR USUARIO*/ 
--El Id es Autoincrementable por lo cual no puede ser actualizado eso es todo; muchas gracias// oki doki
CREATE PROC UpdateUsuarios 
@IdUsuario INT,
@NombreCompleto VARCHAR(200),
@Correo VARCHAR(200),
@Password VARBINARY(MAX),
@Bloqueado BIT,
@IntentosFallidos SMALLINT,
@IdRol INT,
@Activo BIT,
@IdUsuarioRegistra INT,
@FechaRegistro DATETIME,
@IdUsuarioActualiza INT,
@FechaActualizacion DATETIME
AS
begin
UPDATE Usuarios
set 
	NombreCompleto= @NombreCompleto,
	Correo = @Correo,
	Password = @Password,
	IntentosFallidos = @IntentosFallidos,
	IdRol = @IdRol,
	Activo = @Activo,
	IdUsuarioRegistra = @IdUsuarioRegistra,
	FechaRegistro = @FechaRegistro,
	IdUsuarioActualiza = @IdUsuarioActualiza, 
	FechaActualizacion = GETDATE()
where IdUsuario= @IdUsuario;
	SELECT SCOPE_IDENTITY()
END
go
/*PROCESO DE BORRADO DE USUARIOS*/
CREATE PROC DeleteUsuarios
@IdUsuario INT,
@IdUsuarioActualiza INT
AS
BEGIN
UPDATE Usuarios
SET
Activo = 0,
IdUsuarioActualiza = @IdUsuarioActualiza,
FechaActualizacion = GETDATE()
WHERE IdUsuario = @IdUsuario;
SELECT SCOPE_IDENTITY()
END
go

/*proceso de almacenamiento Libros*/
CREATE PROC InsertLibros 
@ID INT,
@nombre Nvarchar(50),
@Area Nvarchar(100),
@Autor Nvarchar(100),
@Idioma Nvarchar(50), 
@editorial Nvarchar(50),
@fecha_publicación date,
@paginas int
as
begin
insert into Libros(ID, nombre, Area, Autor, Idioma, editorial, fecha_publicación, páginas)
	Values (@ID, @nombre, @Area, @Autor, @Idioma, @editorial, @fecha_publicación, @paginas);
end
go

/*proceso de actualizacion de libros*/
CREATE PROC UpdateLibros 
@ID INT,
@nombre Nvarchar(100),
@Area Nvarchar(100),
@Autor Nvarchar(100),
@Idioma Nvarchar(50), 
@editorial Nvarchar(50),
@fecha_publicación date,
@paginas int
as
begin
UPDATE Libros
set ID = @ID,
	nombre = @nombre,
	Area = @Area,
	Autor = @Autor,
	Idioma = @Idioma,
	editorial =@editorial,
	fecha_publicación = @fecha_publicación,
	@paginas = @paginas
where ID= @ID;
	SELECT SCOPE_IDENTITY()
END
go

/*PROCESO DE BORRADO DE LIBROS*/
Create proc DeleteLibros
@Id	Int
as
	delete from Libros where id=@id;
GO


/*PROCEDIMIENTO DE INSERTAR LIBROS DESCARGADOS*/
CREATE PROC InsertLibroDescargado
@nombre_del_libro Nvarchar(50),
@id_usuario int
as
begin
insert into Libros_Descargados (nombre_del_libro, hora, fecha, id_usuario)
	Values (@nombre_del_libro, GETDATE(), GETDATE(), @id_usuario);
end
go


/*PROCEDIMIENTO DE ACTUALIZAR EN LIBROS DESCARGADOS*/
CREATE PROC UpdateLibrosDescargados 
@nombre_del_libro Nvarchar(50),
@id_usuario int,
@hora time,
@fecha date
as
begin
UPDATE Libros_Descargados
set id_usuario = @id_usuario,
	nombre_del_libro = @nombre_del_libro,
	fecha = GETDATE(),
	hora = GETDATE()
where id_usuario= @id_usuario;
	SELECT SCOPE_IDENTITY()
END
go

/*PROCEDIMIENTO DE BORRADO DE LIBROS DESCARGADOS*/
create proc DeleteLibrosDescargado
@nombre_del_libro Nvarchar(50)
as
	delete from Libros_Descargados where nombre_del_libro = @nombre_del_libro;
go

/*PROCEDIMIENTO INSERTAR AUTOR*/
CREATE PROC InsertAutor
@Nombre Nvarchar(100),
@apellido Nvarchar(50),
@edad int
as
begin
insert into Autor(Nombre, apellido, edad)
	Values (@Nombre, @apellido, @edad);
		SELECT SCOPE_IDENTITY()
end
go

/*PROCEDIMIENTO DE ACTUALIZAR EDITORIAL*/
CREATE PROC UpdateAutor
@Nombre Nvarchar(100),
@apellido Nvarchar(50),
@edad int
as
begin
UPDATE Autor
set Nombre = @Nombre,
	apellido = @apellido,
	edad = @edad
where Nombre = @Nombre
	SELECT SCOPE_IDENTITY()
END
go

/*PROCEDIMIENTO DE BORRADO DE LIBROS DESCARGADOS*/
create proc DeleteAutor
@Nombre Nvarchar(100)
as
	delete from Editorial where Nombre= @Nombre;
		SELECT SCOPE_IDENTITY()
go

/*PROCEDIMIENTO INSERTAR EDITORIAL*/
CREATE PROC InsertEditorial
@Nombre Nvarchar(50),
@fecha_de_publicación date,
@locacion Nvarchar(50)
as
begin
insert into Editorial (Nombre, fecha_de_publicaion, locacion)
	Values (@Nombre, GETDATE(), @locacion);

		SELECT SCOPE_IDENTITY()
end
go

/*PROCEDIMIENTO DE ACTUALIZAR EDITORIAL*/
CREATE PROC UpdateEditorial
@Nombre Nvarchar(50),
@fecha_de_publicación date,
@locacion Nvarchar(50)
as
begin
UPDATE Editorial
set Nombre = @Nombre,
	fecha_de_publicaion = GETDATE(),
	locacion = @locacion
where Nombre = @Nombre
	SELECT SCOPE_IDENTITY()
END
go

/*PROCEDIMIENTO ALAMACENADO ELMINAR EDITORIAL*/
create proc DeleteEditorial
@Nombre Nvarchar(50)
as
	delete from Editorial where Nombre= @Nombre;
go
CREATE DATABASE SIC
GO 

USE SIC
GO

CREATE TABLE Tab_Perfiles
(
	Id_Perfil	Int PRIMARY KEY,
	Nombre_Perfil	VARCHAR(30)
);

CREATE TABLE Tab_Usuarios
(
	Cedula	INT UNIQUE,
	Nombre_Usuario	VARCHAR(25) PRIMARY KEY,
	Nombre	Varchar(30),
	Apellido1	Varchar(30),
	Apellido2	Varchar(30),
	Contrasena	Varchar(max),
	Genero Varchar(2),
	Id_Perfil	INT,
	CONSTRAINT Fk_Usu_Per FOREIGN KEY(Id_Perfil) REFERENCES Tab_Perfiles(Id_Perfil)
);

CREATE TABLE Tab_Permisos
(	
	Id_Perfil	Int ,
	Modulo	INT,
	Agregar	VARCHAR(2),
	Modificar	VARCHAR(2),
	Consultar	VARCHAR(2),
	Eliminar	VARCHAR(2),
	PRIMARY KEY(Id_Perfil,Modulo),
	CONSTRAINT Fk_Per_Per FOREIGN KEY(Id_Perfil) REFERENCES Tab_Perfiles(Id_Perfil)
);

CREATE TABLE Tab_Bitacora_Sesiones
(	
	Id_Sesion	INT PRIMARY KEY IDENTITY(1,1),
	Fecha_inicio	DATETIME,
	fecha_Salio	DATETIME,
	Usuario	VARCHAR(25),
	Direccion_Ip VARCHAR(15),
	CONSTRAINT Fk_Bit_Usu FOREIGN KEY(Usuario) REFERENCES Tab_Usuarios(Nombre_Usuario)
);

CREATE TABLE Tab_Bitacora_Movimientos
(	
	Fecha_Hora	DATETIME,
	Id_Movimiento	INT PRIMARY KEY IDENTITY(1,1),
	Accion	VARCHAR(16),
	Modulo	VARCHAR(25),
	Usuario	VARCHAR(25),
	CONSTRAINT Fk_Mov_Usu FOREIGN KEY(Usuario) REFERENCES Tab_Usuarios(Nombre_Usuario)
);

CREATE TABLE Tab_Procedimiento
(	
	Id_Procedimiento	INT IDENTITY(1,1) PRIMARY KEY,
	Nombre_Procedimiento	VARCHAR(25),
	Descripcion_Procedimiento	VARCHAR(MAX)
);

CREATE TABLE Tab_Funcionarios
(	
	Cedula	INT PRIMARY KEY,
	Nombre	VARCHAR(30),
	Apellido1	VARCHAR(30),
	Apellido2	VARCHAR(30),
	Genero	VARCHAR(30)
);

CREATE TABLE Tab_Expedientes
(	
	Cedula INT,
	Num_Expediente	VARCHAR(50) PRIMARY KEY,
	Parte_Procesal	VARCHAR(30),
	Usuario_Generador	VARCHAR(25),
	Lugar_Trabajo	VARCHAR(30),
	Descripcion	VARCHAR(MAX),
	Id_Tipo_Procedimiento	INT,
	Medida_Cautelar	VARCHAR(MAX),
	Organo_Director	VARCHAR(25),
	Estado VARCHAR(25),
	CONSTRAINT Fk_Exp_Usu FOREIGN KEY(Usuario_Generador) REFERENCES Tab_Usuarios(Nombre_Usuario),
	CONSTRAINT Fk_Exp_Pro FOREIGN KEY(Id_Tipo_Procedimiento) REFERENCES Tab_Procedimiento(Id_Procedimiento),
	CONSTRAINT Fk_Exp_Fun FOREIGN KEY(Cedula) REFERENCES Tab_Funcionarios(Cedula)
);
INSERT INTO Tab_Perfiles(Id_Perfil,Nombre_Perfil) values(1,'Administrador')
INSERT INTO Tab_Permisos(Id_Perfil,Modulo,Agregar,Modificar,Consultar,Eliminar) values(1,1,'S','S','S','S')
INSERT INTO Tab_Permisos(Id_Perfil,Modulo,Agregar,Modificar,Consultar,Eliminar) values(1,2,'S','S','S','S')
INSERT INTO Tab_Permisos(Id_Perfil,Modulo,Agregar,Modificar,Consultar,Eliminar) values(1,3,'S','S','S','S')
INSERT INTO Tab_Permisos(Id_Perfil,Modulo,Agregar,Modificar,Consultar,Eliminar) values(1,4,'S','S','S','S')
INSERT INTO Tab_Permisos(Id_Perfil,Modulo,Agregar,Modificar,Consultar,Eliminar) values(1,5,'S','S','S','S')
INSERT INTO Tab_Permisos(Id_Perfil,Modulo,Agregar,Modificar,Consultar,Eliminar) values(1,6,'S','S','S','S')
INSERT INTO Tab_Usuarios (Nombre,Cedula,Nombre_Usuario,Apellido1,Apellido2,Contrasena,Id_Perfil) values('Administrador',123456789,'Admin','Admin','Admin','rIQeOq7XMQ4ZE1g/tfO3/Da5jKI=',1);
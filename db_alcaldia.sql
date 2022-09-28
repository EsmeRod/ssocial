use master;
go
create database db_alcaldia;
go
use db_alcaldia;

create table secciones(
id_secccion int primary key identity,
nombre_seccion varchar(50) not null
)

insert into secciones(nombre_seccion) values('Consejo municipal'),('Administracion'),('Finanzas'),('Servicios municipales');

create table subsecciones(
id_subseccion int primary key identity,
id_secccion int foreign key references secciones(id_secccion) ON UPDATE CASCADE ON DELETE CASCADE not null,
nombre_subseccion varchar(200) not null
)

create table series(
id_serie int primary key identity,
id_subseccion int foreign key references subsecciones(id_subseccion) ON UPDATE CASCADE ON DELETE CASCADE not null,
nombre_serie varchar(200) not null,
)


create table subseries(
id_subserie int primary key identity,
id_serie int foreign key references series(id_serie) ON UPDATE CASCADE ON DELETE CASCADE not null,
nombre_subserie varchar(200) not null,
codigo_subserie nchar(5) not null,
)


create table unidades_productoras(
id_unidad_productora int primary key identity,
nombre_unidad_productora varchar(250) not null
)

create table cargos(
id_cargo int primary key identity,
nombre_cargo varchar(50) not null
)

insert into cargos(nombre_cargo) values ('Jefe');

create table usuarios(
id_usuario int primary key identity,
id_cargo int foreign key references cargos(id_cargo) ON UPDATE CASCADE ON DELETE CASCADE,
nombre varchar(50) not null,
apellido varchar(50) not null,
carnet nchar(6) not null,
correo varchar(150) not null,
contrasenia varchar(20) not null
)

insert into usuarios(id_cargo,nombre,apellido,carnet,correo,contrasenia) 
values(1,'Juan Ernesto','Navas Iraheta','NI0001','juannavas@gmail.com','hola123');

create table documentos(
id_documento int primary key identity,
id_subserie int foreign key references subseries(id_subserie) ON UPDATE CASCADE ON DELETE CASCADE,
id_unidad_productora int foreign key references unidades_productoras(id_unidad_productora) ON UPDATE CASCADE ON DELETE CASCADE not null,
id_usuario int foreign key references usuarios(id_usuario) ON UPDATE CASCADE ON DELETE CASCADE,
codigo_documento nchar(9) not null,
descripcion varchar(255) not null,
anio nchar(4) not null,
ubicacion varchar(25) not null
)

alter database db_alcaldia add filegroup bitacoras

alter database db_alcaldia add file(
name = 'bitacora_documento',
filename = 'C:\BasesDatos\bitacoras\bitacora_documento.ndf',
size = 1mb,
filegrowth = 1mb ) to filegroup bitacoras;

exec sp_helpfilegroup
exec sp_helpfile

create table bitacora_documentos(
id_bitacora int primary key identity,
evento varchar(10) not null,
tipo_reg varchar(3) not null,
hostame varchar(30) not null,
fecha datetime not null,

id_documento int not null,
id_subserie int not null,
id_unidad_productora int not null,
id_usuario int not null,
codigo_documento nchar(9) not null,
descripcion varchar(255) not null,
anio nchar(4) not null,
ubicacion varchar(25) not null,

constraint ck_eventos check(evento in ('I','U','D')),
constraint ck_tipo_reg check(tipo_reg in ('OLD','NEW'))
) on bitacoras
go
create trigger trigger_insert_documento
on documentos
after insert
not for replication
as
	insert into bitacora_documentos(evento,tipo_reg,hostame,fecha,
	id_documento,id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion) 
	select 'I','NEW',HOST_NAME(),getdate(),
	id_documento,id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion from inserted;

	print 'Trigger after insert on documentos triggered';
go
create trigger trigger_update_documento
on documentos
after update
not for replication
as
	insert into bitacora_documentos(evento,tipo_reg,hostame,fecha,
	id_documento,id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion) 
	select 'U','OLD',HOST_NAME(),getdate(),
	id_documento,id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion from deleted;

	insert into bitacora_documentos(evento,tipo_reg,hostame,fecha,
	id_documento,id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion) 
	select 'U','NEW',HOST_NAME(),getdate(),
	id_documento,id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion from inserted;

	print 'Trigger after update on documentos triggered';
go
create trigger trigger_delete_documento
on documentos
after delete
not for replication
as
	insert into bitacora_documentos(evento,tipo_reg,hostame,fecha,
	id_documento,id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion) 
	select 'D','OLD',HOST_NAME(),getdate(),
	id_documento,id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion from deleted

	print 'Trigger after delete on documentos triggered';
go

insert into documentos(id_subserie, id_unidad_productora,id_usuario,codigo_documento,descripcion,anio,ubicacion) 
values(1,1,1,'EA00001', 'Miss Santa Ana', 2022, 'B1-E3-F2-C5');

update documentos set anio = 2021 where id_documento = 1;

delete from documentos where id_documento = 1;

select * from  bitacora_documentos;

select * from documentos
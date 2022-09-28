create procedure UpdateDoc

@codigodoc nchar(9), @descripcion varchar(250), @año nchar(4), @ubicacion varchar(25), @carnet nchar(6), @unidad varchar(250), @subs varchar(200)
as
DECLARE @Idsub int,  @Idunidad int, @Idus int, @Iddoc int
if EXISTS(SELECT id_usuario from usuarios where carnet = @carnet) 
	SET @Idus = (SELECT id_usuario from usuarios where carnet = @carnet)

if EXISTS (SELECT id_unidad_productora from unidades_productoras where nombre_unidad_productora = @unidad)
	SET @Idunidad = (SELECT id_unidad_productora from unidades_productoras where nombre_unidad_productora = @unidad)

if EXISTS (SELECT id_subserie from subseries where nombre_subserie = @subs)
	SET @Idsub = (SELECT id_subserie from subseries where nombre_subserie = @subs)

if EXISTS (SELECT id_documento from documentos where codigo_documento = @codigodoc)
	SET @Iddoc = (SELECT id_documento from documentos where codigo_documento = @codigodoc )
	 

update documentos set id_subserie=@Idsub,id_unidad_productora=@Idunidad,id_usuario=@Idus,codigo_documento= @codigodoc, descripcion=@descripcion, anio=@año, ubicacion=@ubicacion WHERE id_documento=@Iddoc


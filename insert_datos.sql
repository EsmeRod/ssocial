BULK INSERT 
	subsecciones
FROM 
	'\\Mac\Home\Desktop\HorasSociales-1\csv\subsecciones.csv'
WITH(
	FIELDTERMINATOR= ';',
	ROWTERMINATOR = '\n',
	FIRSTROW = 2
)

select*from subsecciones

BULK INSERT
	series
FROM 
	'\\Mac\Home\Desktop\HorasSociales-1\csv\series.csv'
WITH(
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n',
	FIRSTROW = 2
)

select*from series

BULK INSERT 
	subseries
FROM 
	'\\Mac\Home\Desktop\HorasSociales-1\csv\subseries.csv'
WITH(
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n',
	FIRSTROW = 2
)

select*from subseries

INSERT INTO cargos(nombre_cargo) values ('Subjefe'), ('Secretaria'), ('Operador')
select*from cargos

BULK INSERT 
	unidades_productoras
FROM 
	'\\Mac\Home\Desktop\HorasSociales-1\csv\unidades.csv'
WITH(
	FIELDTERMINATOR = ';',
	ROWTERMINATOR = '\n',
	FIRSTROW = 2
)

select*from unidades_productoras

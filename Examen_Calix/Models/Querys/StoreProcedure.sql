--Insercion de datos a las tablas Album y Artista
Insert into Music.Artista(Nombre,Estado)
values('Joaquin Sabina',0),
		('Andres Calamaro',1)

Insert into Music.Album(Nombre,Artista)
values('Lo Niego Todo',1),
		('Sin Documentos',2)
--Procedimiento para agregar canciones 
CREATE PROCEDURE SP_AgregarCancion
(
	@nombre NVARCHAR(200),
	@artista INT ,
	@album INT,
	@genero NVARCHAR(100),
	@añoCreacion NVARCHAR(4)
)
AS
	BEGIN
		INSERT INTO Music.Cancion(Nombre, Artista,Album,Genero, AñoCreacion)
		VALUES(@nombre, @artista,@album,@genero,@añoCreacion)
	END
GO

---Procedimiento para eliminar una cancion según su ID
CREATE PROCEDURE SP_EliminarCancion
(
	@id INT
)
AS
BEGIN
	DECLARE @existe int;
	SET @existe = 0;
			SELECT @existe = COUNT(Music.Cancion.Id) FROM Music.Cancion WHERE Id=@id;
		IF (@existe = 0)
			BEGIN
				RAISERROR(N'No existe La Cancion con el Id %d"', 16, 1, @id);
				RETURN 0
			END 	
		ELSE
			BEGIN
				DELETE FROM Music.Cancion	WHERE Id=@id;
				RETURN 1
			END
END
GO
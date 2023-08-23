-----------------PROCEDIMIENTOS ALMACENADOS Y VISTAS GENERAL

--**********ESTADOS CIVILES**********--

/*Vista estados civiles*/
--CREATE OR ALTER VIEW gral.VW_tbEstadosCiviles
--AS
--SELECT escv_Id AS estadoCivilId, 
--	   escv_Nombre AS estadoCivilNombre, 
--	   escv.usua_UsuarioCreacion AS usuarioCreacion, 
--	   usuaCrea.usua_Nombre AS usuarioCreacionNombre,
--	   escv_FechaCreacion AS fechaCreacion, 
--	   escv.usua_UsuarioModificacion AS usuarioModificacion, 
--	   usuaModifica.usua_Nombre AS usuarioModificacionNombre,
--	   escv_FechaModificacion AS fechaModificacion, 
--	   escv_Estado AS estadoCivilEstado
--FROM [Gral].[tbEstadosCiviles] escv INNER JOIN [Acce].[tbUsuarios] usuaCrea
--ON escv.usua_UsuarioCreacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaModifica
--ON escv.usua_UsuarioModificacion = usuaCrea.usua_Id
--GO


/*Listar estados civiles*/
--CREATE OR ALTER PROCEDURE gral.UDP_tbEstadosCiviles_Listar
--AS
--BEGIN
--	SELECT [escv_Id], 
--		   [escv_Nombre]
--    FROM  [Gral].[tbEstadosCiviles]
--	WHERE [escv_Estado] = 1
--END
--GO

--/*Insertar estados civiles*/
--CREATE OR ALTER PROCEDURE gral.UDP_tbEstadosCiviles_Insertar
--	@escv_Nombre			NVARCHAR(150),
--	@usua_UsuarioCreacion	INT,
--	@escv_FechaCreacion     DATETIME
--AS 
--BEGIN
	
--	BEGIN TRY

--		IF EXISTS (SELECT * FROM [Gral].[tbEstadosCiviles]
--						WHERE @escv_Nombre = [escv_Nombre]
--						AND [escv_Estado] = 0)
--		BEGIN
--			UPDATE [Gral].[tbEstadosCiviles]
--			SET	   [escv_Estado] = 1
--			WHERE  [escv_Nombre] = @escv_Nombre

--			SELECT 1
--		END
--		ELSE 
--			BEGIN
--				INSERT INTO [Gral].[tbEstadosCiviles] (escv_Nombre, 
--													   usua_UsuarioCreacion, 
--													   escv_FechaCreacion)
--			VALUES(@escv_Nombre,	
--				   @usua_UsuarioCreacion,
--				   @escv_FechaCreacion)


--			SELECT 1
--		END
--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH 
--END
--GO

--/*Editar estados civiles*/
--CREATE OR ALTER PROCEDURE gral.UDP_tbEstadosCiviles_Editar
--	@escv_Id					INT,
--	@escv_Nombre				NVARCHAR(150),
--	@usua_UsuarioModificacion	INT,
--	@escv_FechaModificacion     DATETIME
--AS
--BEGIN
--	BEGIN TRY
--		UPDATE  [Gral].[tbEstadosCiviles]
--		SET		[escv_Nombre] = @escv_Nombre,
--				[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
--				[escv_FechaModificacion] = @escv_FechaModificacion
--		WHERE	[escv_Id] = @escv_Id

--		SELECT 1
--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH
--END
--GO

--/*Eliminar estados civiles*/
--CREATE OR ALTER PROCEDURE gral.UDP_tbEstadosCiviles_Eliminar 
--	@escv_Id					INT
--AS
--BEGIN
--	BEGIN TRY
		
--		BEGIN
--			DECLARE @respuesta INT
--			EXEC dbo.UDP_ValidarReferencias 'escv_Id', @escv_Id, 'gral.tbEstadosCiviles', @respuesta OUTPUT

--			SELECT @respuesta AS Resultado
--			IF(@respuesta) = 1
--				BEGIN
--					UPDATE	[Gral].[tbEstadosCiviles]
--					SET		[escv_Estado] = 0
--					WHERE	[escv_Id] = @escv_Id

--				END
--		END
--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH
--END
--GO

--**********OFICINAS**********--

/*Vista oficinas*/
--CREATE OR ALTER VIEW gral.VW_tbOficinas
--AS
--SELECT ofic_Id AS oficinaId, 
--	   ofic_Nombre AS oficinaNombre, 
--	   ofic.usua_UsuarioCreacion AS usuarioCreacion, 
--	   usuaCrea.usua_Nombre AS usuarioCreacionNombre,
--	   ofic_FechaCreacion AS fechaCreacion, 
--	   ofic.usua_UsuarioModificacion AS usuarioModificacion, 
--	   usuaModifica.usua_Nombre AS usuarioModificacionNombre,
--	   ofic_FechaModificacion AS fechaModificacion, 
--	   ofic.usua_UsuarioEliminacion AS usuarioEliminacion, 
--	   usuaElimina.usua_Nombre AS usuarioEliminacionNombre,
--	   ofic_FechaEliminacion AS fechaEliminacion, 
--	   ofic_Estado AS oficinaEstado
--FROM [Gral].[tbOficinas] ofic INNER JOIN [Acce].[tbUsuarios] usuaCrea
--ON ofic.usua_UsuarioCreacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaModifica
--ON ofic.usua_UsuarioModificacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaElimina
--ON ofic.usua_UsuarioEliminacion = usuaCrea.usua_Id
--GO


/*Listar oficinas*/
CREATE OR ALTER PROCEDURE gral.UDP_tbOficinas_Listar
AS
BEGIN
	SELECT	ofic_Id							--AS oficinaId, 
			,ofic_Nombre						--AS oficinaNombre, 
			,ofic.usua_UsuarioCreacion		--AS usuarioCreacion, 
			,usuaCrea.usua_Nombre			--AS usuarioCreacionNombre,
			,ofic_FechaCreacion				--AS fechaCreacion, 
			,ofic.usua_UsuarioModificacion	--AS usuarioModificacion, 
			,usuaModifica.usua_Nombre		--AS usuarioModificacionNombre,
			,ofic_FechaModificacion			--AS fechaModificacion, 
			,ofic.usua_UsuarioEliminacion	--AS usuarioEliminacion, 
			,usuaElimina.usua_Nombre			--AS usuarioEliminacionNombre,
			,ofic_FechaEliminacion			--AS fechaEliminacion, 
			,ofic_Estado						--AS oficinaEstado
	FROM [Gral].[tbOficinas] ofic 
	INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON ofic.usua_UsuarioCreacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaModifica  ON ofic.usua_UsuarioModificacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaElimina   ON ofic.usua_UsuarioEliminacion = usuaCrea.usua_Id
	WHERE ofic_Estado = 1
END
GO

/*Insertar oficinas*/
CREATE OR ALTER PROCEDURE gral.UDP_tbOficinas_Insertar 
	@ofic_Nombre			NVARCHAR(150),
	@usua_UsuarioCreacion	INT,
	@ofic_FechaCreacion     DATETIME
AS 
BEGIN
	
	BEGIN TRY

		IF EXISTS (SELECT * FROM [Gral].[tbOficinas]
						WHERE @ofic_Nombre = [ofic_Nombre]
						AND [ofic_Estado] = 0)
		BEGIN
			UPDATE [Gral].[tbOficinas]
			SET	   [ofic_Estado] = 1
			WHERE  [ofic_Nombre] = @ofic_Nombre

			SELECT 1
		END
		ELSE 
			BEGIN
				INSERT INTO [Gral].[tbOficinas] (ofic_Nombre, 
											     usua_UsuarioCreacion, 
											     ofic_FechaCreacion)
			VALUES(@ofic_Nombre,	
				   @usua_UsuarioCreacion,
				   @ofic_FechaCreacion)


			SELECT 1
		END
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH 
END
GO

/*Editar oficinas*/
CREATE OR ALTER PROCEDURE gral.UDP_tbOficinas_Editar 
	@ofic_Id					INT,
	@ofic_Nombre				NVARCHAR(150),
	@usua_UsuarioModificacion	INT,
	@ofic_FechaModificacion     DATETIME
AS
BEGIN
	BEGIN TRY
		UPDATE  [Gral].[tbOficinas]
		SET		[ofic_Nombre] = @ofic_Nombre,
				[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
				[ofic_FechaModificacion] = @ofic_FechaModificacion
		WHERE	[ofic_Id] = @ofic_Id

		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

/*Eliminar oficinas*/
CREATE OR ALTER PROCEDURE gral.UDP_tbOficinas_Eliminar 
	@ofic_Id					INT,
	@usua_UsuarioEliminacion	INT,
	@ofic_FechaEliminacion		DATETIME
AS
BEGIN
	BEGIN TRY

		BEGIN
			DECLARE @respuesta INT
			EXEC dbo.UDP_ValidarReferencias 'ofic_Id', @ofic_Id, 'gral.tbOficinas', @respuesta OUTPUT

			SELECT @respuesta AS Resultado
			IF(@respuesta) = 1
				BEGIN
					UPDATE	[Gral].[tbOficinas]
					SET		[ofic_Estado] = 0,
							[usua_UsuarioEliminacion] = @usua_UsuarioEliminacion,
							[ofic_FechaEliminacion] = @ofic_FechaEliminacion
					WHERE	[ofic_Id] = @ofic_Id
				END
		END
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

--**********OFICIO/PROFESIÓN**********--

/*Vista oficio/profesión*/
--CREATE OR ALTER VIEW gral.VW_tbOficio_Profesiones
--AS
--SELECT ofpr_Id AS oficioId, 
--	   ofpr_Nombre AS oficioNombre, 
--	   ofpr.usua_UsuarioCreacion AS usuarioCreacion, 
--	   usuaCrea.usua_Nombre AS usuarioCreacionNombre,
--	   ofpr_FechaCreacion AS fechaCreacion, 
--	   ofpr.usua_UsuarioModificacion AS usuarioModificacion, 
--	   usuaModifica.usua_Nombre AS usuarioModificacionNombre,
--	   ofpr_FechaModificacion AS fechaModificacion, 
--	   --ofpr.usua_UsuarioEliminacion AS usuarioEliminacion, 
--	   --usuaElimina.usua_Nombre AS usuarioEliminacionNombre,
--	   --ofpr_FechaEliminacion AS fechaEliminacion, 
--	   ofpr_Estado AS oficioEstado
--FROM [Gral].[tbOficio_Profesiones] ofpr INNER JOIN [Acce].[tbUsuarios] usuaCrea
--ON ofpr.usua_UsuarioCreacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaModifica
--ON ofpr.usua_UsuarioModificacion = usuaCrea.usua_Id --LEFT JOIN [Acce].[tbUsuarios] usuaElimina
----ON ofpr.usua_UsuarioEliminacion = usuaCrea.usua_Id
--GO


/*Listar oficio/profesión*/
CREATE OR ALTER PROCEDURE gral.UDP_tbOficio_Profesiones_Listar
AS
BEGIN
	SELECT ofpr_Id							--AS oficioId, 
			,ofpr_Nombre					--	AS oficioNombre, 
			,ofpr.usua_UsuarioCreacion		--AS usuarioCreacion, 
			,usuaCrea.usua_Nombre			AS usuarioCreacionNombre
			,ofpr_FechaCreacion				--AS fechaCreacion, 
			,ofpr.usua_UsuarioModificacion	--AS usuarioModificacion, 
			,usuaModifica.usua_Nombre		AS usuarioModificacionNombre
			,ofpr_FechaModificacion			--AS fechaModificacion, 
			,ofpr_Estado					--	AS oficioEstado
	FROM [Gral].[tbOficio_Profesiones] ofpr 
	INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON ofpr.usua_UsuarioCreacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaModifica	ON ofpr.usua_UsuarioModificacion = usuaCrea.usua_Id 
	WHERE ofpr_Estado = 1
END
GO


/*Insertar oficio/profesión*/
CREATE OR ALTER PROCEDURE gral.UDP_tbOficio_Profesiones_Insertar 
	@ofpr_Nombre			NVARCHAR(150),
	@usua_UsuarioCreacion	INT,
	@ofpr_FechaCreacion     DATETIME
AS 
BEGIN
	
	BEGIN TRY

		IF EXISTS (SELECT * FROM [Gral].[tbOficio_Profesiones]
						WHERE @ofpr_Nombre = [ofpr_Nombre]
						AND [ofpr_Estado] = 0)
		BEGIN
			UPDATE [Gral].[tbOficio_Profesiones]
			SET	   [ofpr_Estado] = 1
			WHERE  [ofpr_Nombre] = @ofpr_Nombre

			SELECT 1
		END
		ELSE 
			BEGIN
				INSERT INTO [Gral].[tbOficio_Profesiones] (ofpr_Nombre, 
														   usua_UsuarioCreacion, 
														   ofpr_FechaCreacion)
			VALUES(@ofpr_Nombre,	
				   @usua_UsuarioCreacion,
				   @ofpr_FechaCreacion)


			SELECT 1
		END
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH 
END
GO

/*Editar oficio/profesión*/
CREATE OR ALTER PROCEDURE gral.UDP_tbOficio_Profesiones_Editar 
	@ofpr_Id					INT,
	@ofpr_Nombre				NVARCHAR(150),
	@usua_UsuarioModificacion	INT,
	@ofpr_FechaModificacion     DATETIME
AS
BEGIN
	BEGIN TRY
		UPDATE  [Gral].[tbOficio_Profesiones]
		SET		[ofpr_Nombre] = @ofpr_Nombre,
				[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
				[ofpr_FechaModificacion] = @ofpr_FechaModificacion
		WHERE	[ofpr_Id] = @ofpr_Id

		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

--/*Eliminar oficio/profesión*/
--CREATE OR ALTER PROCEDURE gral.UDP_tbOficio_Profesiones_Eliminar 
--	@ofpr_Id					INT,
--	@usua_UsuarioEliminacion	INT,
--	@ofpr_FechaEliminacion		DATETIME
--AS
--BEGIN
--	BEGIN TRY
		
--		BEGIN
--			DECLARE @respuesta INT
--			EXEC dbo.UDP_ValidarReferencias 'ofpr_Id', @ofpr_Id, 'gral.tbOficio_Profesiones', @respuesta OUTPUT

--			SELECT @respuesta AS Resultado
--			IF(@respuesta) = 1
--				BEGIN
--					UPDATE	[Gral].[tbOficio_Profesiones]
--					SET		[ofpr_Estado] = 0
--							--[usua_UsuarioEliminacion] = @usua_UsuarioEliminacion,
--							--[ofpr_FechaEliminacion] = @ofpr_FechaEliminacion
--					WHERE	[ofpr_Id] = @ofpr_Id
--				END
--		END
--	END TRY
--	BEGIN CATCH
--		SELECT 'Error Message: ' + ERROR_MESSAGE()
--	END CATCH
--END
--GO

--**********CARGOS**********--

/*Vista cargos*/
--CREATE OR ALTER VIEW gral.VW_tbCargos
--AS
--SELECT carg_Id AS cargoId, 
--	   carg_Nombre AS cargoNombre, 
--	   carg.usua_UsuarioCreacion AS usuarioCreacion, 
--	   usuaCrea.usua_Nombre AS usuarioCreacionNombre,
--	   carg_FechaCreacion AS fechaCreacion, 
--	   carg.usua_UsuarioModificacion AS usuarioModificacion, 
--	   usuaModifica.usua_Nombre AS usuarioModificacionNombre,
--	   carg_FechaModificacion AS fechaModificacion, 
--	   carg.usua_UsuarioEliminacion AS usuarioEliminacion, 
--	   usuaElimina.usua_Nombre AS usuarioEliminacionNombre,
--	   carg_FechaEliminacion AS fechaEliminacion, 
--	   carg_Estado AS cargoEstado
--FROM [Gral].[tbCargos] carg INNER JOIN [Acce].[tbUsuarios] usuaCrea
--ON carg.usua_UsuarioCreacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaModifica
--ON carg.usua_UsuarioModificacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaElimina
--ON carg.usua_UsuarioEliminacion = usuaCrea.usua_Id
--GO


/*Listar cargos*/
CREATE OR ALTER PROCEDURE gral.UDP_tbCargos_Listar
AS
BEGIN
	SELECT carg_Id							--AS cargoId, 
		   ,carg_Nombre						--AS cargoNombre, 
	       ,carg.usua_UsuarioCreacion		--AS usuarioCreacion, 
	       ,usuaCrea.usua_Nombre			--	AS usuarioCreacionNombre,
	       ,carg_FechaCreacion				--AS fechaCreacion, 
	       ,carg.usua_UsuarioModificacion	--AS usuarioModificacion, 
	       ,usuaModifica.usua_Nombre		--	AS usuarioModificacionNombre,
	       ,carg_FechaModificacion			--AS fechaModificacion, 
	       ,carg.usua_UsuarioEliminacion	--	AS usuarioEliminacion, 
	       ,usuaElimina.usua_Nombre			--AS usuarioEliminacionNombre,
	       ,carg_FechaEliminacion			--AS fechaEliminacion, 
	       ,carg_Estado						--AS cargoEstado
    FROM [Gral].[tbCargos] carg 
	INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON carg.usua_UsuarioCreacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaModifica	ON carg.usua_UsuarioModificacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaElimina	ON carg.usua_UsuarioEliminacion = usuaCrea.usua_Id
	WHERE carg_Estado = 1
END
GO

/*Insertar cargos*/
CREATE OR ALTER PROCEDURE gral.UDP_tbCargos_Insertar 
	@carg_Nombre			NVARCHAR(150),
	@usua_UsuarioCreacion	INT,
	@carg_FechaCreacion     DATETIME
AS 
BEGIN
	
	BEGIN TRY

		IF EXISTS (SELECT * FROM [Gral].[tbCargos]
						WHERE @carg_Nombre = [carg_Nombre]
						AND [carg_Estado] = 0)
		BEGIN
			UPDATE [Gral].[tbCargos]
			SET	   [carg_Estado] = 1
			WHERE  [carg_Nombre] = @carg_Nombre

			SELECT 1
		END
		ELSE 
			BEGIN
				INSERT INTO [Gral].[tbCargos] (carg_Nombre, 
											   usua_UsuarioCreacion, 
											   carg_FechaCreacion)
			VALUES(@carg_Nombre,	
				   @usua_UsuarioCreacion,
				   @carg_FechaCreacion)


			SELECT 1
		END
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH 
END
GO

/*Editar cargos*/
CREATE OR ALTER PROCEDURE gral.UDP_tbCargos_Editar 
	@carg_Id					INT,
	@carg_Nombre				NVARCHAR(150),
	@usua_UsuarioModificacion	INT,
	@carg_FechaModificacion     DATETIME
AS
BEGIN
	BEGIN TRY
		UPDATE  [Gral].[tbCargos]
		SET		[carg_Nombre] = @carg_Nombre,
				[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
				[carg_FechaModificacion] = @carg_FechaModificacion
		WHERE	[carg_Id] = @carg_Id

		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

/*Eliminar cargos*/
CREATE OR ALTER PROCEDURE gral.UDP_tbCargos_Eliminar 
	@carg_Id					INT,
	@usua_UsuarioEliminacion	INT,
	@carg_FechaEliminacion		DATETIME
AS
BEGIN
	BEGIN TRY

		BEGIN
			DECLARE @respuesta INT
			EXEC dbo.UDP_ValidarReferencias 'carg_Id', @carg_Id, 'gral.tbCargos', @respuesta OUTPUT

			SELECT @respuesta AS Resultado
			IF(@respuesta) = 1
				BEGIN
					UPDATE	[Gral].[tbCargos]
					SET		[carg_Estado] = 0,
							[usua_UsuarioEliminacion] = @usua_UsuarioEliminacion,
							[carg_FechaEliminacion] = @carg_FechaEliminacion
					WHERE	[carg_Id] = @carg_Id
				END
		END

	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

--**********COLONIAS**********--

/*Vista colonias*/
--CREATE OR ALTER VIEW gral.VW_tbColonias
--AS
--SELECT colo_Id AS coloniaId, 
--	   colo_Nombre AS coloniaNombre, 
--	   colo.alde_Id AS aldeaId,
--	   alde.alde_Nombre AS aldeaNombre,
--	   colo.ciud_Id AS ciudadId,
--	   ciud.ciud_Nombre AS ciudadNombre,
--	   colo.usua_UsuarioCreacion AS usuarioCreacion, 
--	   usuaCrea.usua_Nombre AS usuarioCreacionNombre,
--	   colo_FechaCreacion AS fechaCreacion, 
--	   colo.usua_UsuarioModificacion AS usuarioModificacion, 
--	   usuaModifica.usua_Nombre AS usuarioModificacionNombre,
--	   colo_FechaModificacion AS fechaModificacion, 
--	   colo.usua_UsuarioEliminacion AS usuarioEliminacion, 
--	   usuaElimina.usua_Nombre AS usuarioEliminacionNombre,
--	   colo_FechaEliminacion AS fechaEliminacion, 
--	   colo_Estado AS coloniaEstado
--FROM [Gral].[tbColonias] colo LEFT JOIN [Gral].[tbAldeas] alde
--ON colo.alde_Id = alde.alde_Id LEFT JOIN [Gral].[tbCiudades] ciud
--ON colo.ciud_Id = ciud.ciud_Id INNER JOIN [Acce].[tbUsuarios] usuaCrea
--ON colo.usua_UsuarioCreacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaModifica
--ON colo.usua_UsuarioModificacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaElimina
--ON colo.usua_UsuarioEliminacion = usuaCrea.usua_Id
--GO


/*Listar colonias*/
CREATE OR ALTER PROCEDURE gral.UDP_tbColonias_Listar
AS
BEGIN
	SELECT colo_Id								--AS coloniaId, 
	       ,colo_Nombre							--AS coloniaNombre, 
	       ,colo.alde_Id						--	AS aldeaId,
	       ,alde.alde_Nombre					--	AS aldeaNombre,
	       ,colo.ciud_Id						--	AS ciudadId,
	       ,ciud.ciud_Nombre					--	AS ciudadNombre,
	       ,colo.usua_UsuarioCreacion			--AS usuarioCreacion, 
	       ,usuaCrea.usua_Nombre				--	AS usuarioCreacionNombre,
	       ,colo_FechaCreacion					--AS fechaCreacion, 
	       ,colo.usua_UsuarioModificacion		--AS usuarioModificacion, 
	       ,usuaModifica.usua_Nombre			--	AS usuarioModificacionNombre,
	       ,colo_FechaModificacion				--AS fechaModificacion, 
	       ,colo.usua_UsuarioEliminacion		--	AS usuarioEliminacion, 
	       ,usuaElimina.usua_Nombre				--AS usuarioEliminacionNombre,
	       ,colo_FechaEliminacion				--AS fechaEliminacion, 
	       ,colo_Estado							--AS coloniaEstado
   FROM [Gral].[tbColonias] colo 
   LEFT JOIN [Gral].[tbAldeas] alde				ON colo.alde_Id = alde.alde_Id 
   LEFT JOIN [Gral].[tbCiudades] ciud			ON colo.ciud_Id = ciud.ciud_Id 
   INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON colo.usua_UsuarioCreacion = usuaCrea.usua_Id 
   LEFT JOIN [Acce].[tbUsuarios] usuaModifica	ON colo.usua_UsuarioModificacion = usuaCrea.usua_Id 
   LEFT JOIN [Acce].[tbUsuarios] usuaElimina	ON colo.usua_UsuarioEliminacion = usuaCrea.usua_Id
   WHERE colo_Estado = 1
END
GO

/*Insertar colonias*/
CREATE OR ALTER PROCEDURE gral.UDP_tbColonias_Insertar 
	@colo_Nombre			NVARCHAR(150),
	@alde_Id				INT,
	@ciud_Id				INT,
	@usua_UsuarioCreacion	INT,
	@colo_FechaCreacion     DATETIME
AS 
BEGIN
	
	BEGIN TRY

		IF @alde_Id IS NOT NULL
			BEGIN
				IF EXISTS (SELECT * FROM [Gral].[tbColonias]
						WHERE @colo_Nombre = [colo_Nombre]
						AND alde_Id = @alde_Id)
					BEGIN
						SELECT 0
					END
				--ELSE IF EXISTS (SELECT * FROM [Gral].[tbColonias]
				--		WHERE @colo_Nombre = [colo_Nombre]
				--		AND alde_Id = @alde_Id
				--		AND [colo_Estado] = 0)
				--	BEGIN
				--		UPDATE [Gral].[tbColonias]
				--		SET	   [colo_Estado] = 1
				--		WHERE  [colo_Nombre] = @colo_Nombre
				--		AND [alde_Id] = @alde_Id

				--		SELECT 1
				--	END
				ELSE
					BEGIN
						INSERT INTO [Gral].[tbColonias] (colo_Nombre, 
														 alde_Id,
														 ciud_Id,
														 usua_UsuarioCreacion, 
														 colo_FechaCreacion)
						VALUES(@colo_Nombre,	
							   @alde_Id,
							   @ciud_Id,
							   @usua_UsuarioCreacion,
							   @colo_FechaCreacion)

						SELECT 1
					END
			END
		
		ELSE 
			BEGIN
				IF EXISTS (SELECT * FROM [Gral].[tbColonias]
						WHERE @colo_Nombre = [colo_Nombre]
						AND ciud_Id = @ciud_Id)
					BEGIN
						SELECT 0
					END
				--ELSE IF EXISTS (SELECT * FROM [Gral].[tbColonias]
				--		WHERE @colo_Nombre = [colo_Nombre]
				--		AND ciud_Id = @ciud_Id
				--		AND [colo_Estado] = 0)
				--	BEGIN
				--		UPDATE [Gral].[tbColonias]
				--		SET	   [colo_Estado] = 1
				--		WHERE  [colo_Nombre] = @colo_Nombre
				--		AND ciud_Id = @ciud_Id

				--		SELECT 1 
			
				--	END
				ELSE
					BEGIN
						INSERT INTO [Gral].[tbColonias] (colo_Nombre, 
														 ciud_Id,
														 usua_UsuarioCreacion, 
														 colo_FechaCreacion)
						VALUES(@colo_Nombre,	
							   @ciud_Id,
							   @usua_UsuarioCreacion,
							   @colo_FechaCreacion)

						SELECT 1
					END
		END

		--MERGE [Gral].[tbColonias] AS target
		--USING (SELECT @colo_Nombre AS colo_Nombre, @alde_Id AS alde_Id, @ciud_Id AS ciud_Id) AS source
		--ON target.[colo_Nombre] = source.[colo_Nombre]
		--AND (target.[alde_Id] = source.[alde_Id] OR (target.[ciud_Id] = source.[ciud_Id] AND source.[alde_Id] IS NULL))
		--WHEN MATCHED AND target.[colo_Estado] = 1 THEN
		--	-- The record exists and is active, so return 0
		--	OUTPUT 0
		--WHEN MATCHED AND target.[colo_Estado] = 0 THEN
		--	-- The record exists but is inactive, so update and return 1
		--	UPDATE SET target.[colo_Estado] = 1
		--	OUTPUT 1;
		--WHEN NOT MATCHED THEN
		--	-- The record doesn't exist, so insert and return 1
		--	INSERT (colo_Nombre, alde_Id, ciud_Id, usua_UsuarioCreacion, colo_FechaCreacion)
		--	VALUES (source.colo_Nombre, source.alde_Id, source.ciud_Id, @usua_UsuarioCreacion, @colo_FechaCreacion)
		--	OUTPUT 1;
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH 
END
GO

/*Editar colonias*/
CREATE OR ALTER PROCEDURE gral.UDP_tbColonias_Editar 
	@colo_Id					INT,
	@colo_Nombre				NVARCHAR(150),
	@alde_Id					INT,
	@ciud_Id					INT,
	@usua_UsuarioModificacion	INT,
	@colo_FechaModificacion     DATETIME
AS
BEGIN
	BEGIN TRY
		IF @alde_Id IS NOT NULL
			BEGIN
				IF EXISTS (SELECT colo_Id FROM [Gral].[tbColonias]
						   WHERE [colo_Nombre] = @colo_Nombre
						   AND [alde_Id] = @alde_Id
						   AND colo_Id != @colo_Id)
					BEGIN
						SELECT 0
					END
				ELSE
					BEGIN
						UPDATE  [Gral].[tbColonias]
						SET		[colo_Nombre] = @colo_Nombre,
								[alde_Id] = @alde_Id,
								[ciud_Id] = NULL,
								[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
								[colo_FechaModificacion] = @colo_FechaModificacion
						WHERE	[colo_Id] = @colo_Id

						SELECT 1
					END
			END
		ELSE
			BEGIN
				IF EXISTS (SELECT colo_Id FROM [Gral].[tbColonias]
						   WHERE [colo_Nombre] = @colo_Nombre
						   AND [ciud_Id] = @ciud_Id
						   AND colo_Id != @colo_Id
						   )
					BEGIN
						SELECT 0
					END
				ELSE
					BEGIN
						UPDATE  [Gral].[tbColonias]
						SET		[colo_Nombre] = @colo_Nombre,
								[ciud_Id] = @ciud_Id,
								[alde_Id] = NULL,
								[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
								[colo_FechaModificacion] = @colo_FechaModificacion
						WHERE	[colo_Id] = @colo_Id

						SELECT 1
					END
			END
		
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

/*Eliminar colonias*/
--CREATE OR ALTER PROCEDURE gral.UDP_tbColonias_Eliminar 2, 1, '2023-07-18 13:15:06'
--	@colo_Id					INT,
--	@usua_UsuarioEliminacion	INT,
--	@colo_FechaEliminacion		DATETIME
--AS
--BEGIN
--	BEGIN TRY

--		BEGIN
--			DECLARE @respuesta INT
--			EXEC dbo.UDP_ValidarReferencias 'colo_Id', @colo_Id, 'gral.tbColonias', @respuesta OUTPUT

--			SELECT @respuesta AS Resultado
--			IF(@respuesta) = 1
--				BEGIN
--					UPDATE	[Gral].[tbColonias]
--					SET		[colo_Estado] = 0,
--							[usua_UsuarioEliminacion] = @usua_UsuarioEliminacion,
--							[colo_FechaEliminacion] = @colo_FechaEliminacion
--					WHERE	[colo_Id] = @colo_Id
--				END
--		END

--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH
--END
--GO

--**********MONEDAS**********--

/*Vista monedas*/
--CREATE OR ALTER VIEW gral.VW_tbMonedas
--AS
--SELECT mone_Id AS monedaId, 
--	   mone_Codigo AS monedaCodigo,
--	   mone_Descripcion AS monedaNombre, 
--	   mone.usua_UsuarioCreacion AS usuarioCreacion, 
--	   usuaCrea.usua_Nombre AS usuarioCreacionNombre,
--	   mone_FechaCreacion AS fechaCreacion, 
--	   mone.usua_UsuarioModificacion AS usuarioModificacion, 
--	   usuaModifica.usua_Nombre AS usuarioModificacionNombre,
--	   mone_FechaModificacion AS fechaModificacion, 
--	   mone.usua_UsuarioEliminacion AS usuarioEliminacion, 
--	   usuaElimina.usua_Nombre AS usuarioEliminacionNombre,
--	   mone_FechaEliminacion AS fechaEliminacion, 
--	   mone_Estado AS monedaEstado
--FROM [Gral].[tbMonedas] mone INNER JOIN [Acce].[tbUsuarios] usuaCrea
--ON mone.usua_UsuarioCreacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaModifica
--ON mone.usua_UsuarioModificacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaElimina
--ON mone.usua_UsuarioEliminacion = usuaCrea.usua_Id
--GO


/*Listar monedas*/
CREATE OR ALTER PROCEDURE gral.UDP_tbMonedas_Listar
AS
BEGIN
	SELECT mone_Id								--AS monedaId, 
	       ,mone_Codigo							--AS monedaCodigo,
	       ,mone_Descripcion					--	AS monedaNombre, 
	       ,mone.usua_UsuarioCreacion			--AS usuarioCreacion, 
	       ,usuaCrea.usua_Nombre				--	AS usuarioCreacionNombre,
	       ,mone_FechaCreacion					--AS fechaCreacion, 
	       ,mone.usua_UsuarioModificacion		--AS usuarioModificacion, 
	       ,usuaModifica.usua_Nombre			--	AS usuarioModificacionNombre,
	       ,mone_FechaModificacion				--AS fechaModificacion, 
	       ,mone.usua_UsuarioEliminacion		--	AS usuarioEliminacion, 
	       ,usuaElimina.usua_Nombre				--AS usuarioEliminacionNombre,
	       ,mone_FechaEliminacion				--AS fechaEliminacion, 
	       ,mone_Estado							--AS monedaEstado
   FROM [Gral].[tbMonedas] mone 
   INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON mone.usua_UsuarioCreacion = usuaCrea.usua_Id 
   LEFT JOIN [Acce].[tbUsuarios] usuaModifica   ON mone.usua_UsuarioModificacion = usuaCrea.usua_Id 
   LEFT JOIN [Acce].[tbUsuarios] usuaElimina	ON mone.usua_UsuarioEliminacion = usuaCrea.usua_Id
   WHERE mone_Estado = 1
END
GO

/*Insertar monedas*/
CREATE OR ALTER PROCEDURE gral.UDP_tbMonedas_Insertar 
	@mone_Codigo			CHAR(3),
	@mone_Descripcion		NVARCHAR(150),
	@usua_UsuarioCreacion	INT,
	@mone_FechaCreacion     DATETIME
AS 
BEGIN
	
	BEGIN TRY

		--IF EXISTS (SELECT * FROM [Gral].[tbMonedas]
		--				WHERE ([mone_Descripcion] = @mone_Descripcion
		--				OR [mone_Codigo] = @mone_Codigo)
		--				AND [mone_Estado] = 0)
		--BEGIN
		--	UPDATE [Gral].[tbMonedas]
		--	SET	   [mone_Estado] = 1,
		--		   [mone_Descripcion] = @mone_Descripcion,
		--		   [mone_Codigo] = @mone_Codigo
		--	WHERE  [mone_Descripcion] = @mone_Descripcion
		--	OR	   [mone_Codigo] = @mone_Codigo

		--	SELECT 1
		--END
		--ELSE 
		--	BEGIN
				INSERT INTO [Gral].[tbMonedas] ( mone_Codigo,
												 mone_Descripcion, 
											     usua_UsuarioCreacion, 
											     mone_FechaCreacion)
			VALUES(@mone_Codigo,
				   @mone_Descripcion,	
				   @usua_UsuarioCreacion,
				   @mone_FechaCreacion)


			SELECT 1
		--END
	END TRY
	BEGIN CATCH
		SELECT 'Error_Message: ' + ERROR_MESSAGE () 
	END CATCH 
END
GO

/*Editar monedas*/
CREATE OR ALTER PROCEDURE gral.UDP_tbMonedas_Editar
	@mone_Id					INT,
	@mone_Codigo				CHAR(3),
	@mone_Descripcion			NVARCHAR(150),
	@usua_UsuarioModificacion	INT,
	@mone_FechaModificacion     DATETIME
AS
BEGIN
	BEGIN TRY
		UPDATE  [Gral].[tbMonedas]
		SET		[mone_Descripcion] = @mone_Descripcion,
				[mone_Codigo] = @mone_Codigo,
				[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
				[mone_FechaModificacion] = @mone_FechaModificacion
		WHERE	[mone_Id] = @mone_Id

		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

--/*Eliminar monedas*/
--CREATE OR ALTER PROCEDURE gral.UDP_tbMonedas_Eliminar 
--	@mone_Id					CHAR(3),
--	@usua_UsuarioEliminacion	INT,
--	@mone_FechaEliminacion		DATETIME
--AS
--BEGIN
--	BEGIN TRY

--		BEGIN
--			DECLARE @respuesta INT
--			EXEC dbo.UDP_ValidarReferencias 'mone_Id', @mone_Id, 'gral.tbMonedas', @respuesta OUTPUT

--			SELECT @respuesta AS Resultado
--			IF(@respuesta) = 1
--				BEGIN
--					UPDATE	[Gral].[tbMonedas]
--					SET		[mone_Estado] = 0,
--							[usua_UsuarioEliminacion] = @usua_UsuarioEliminacion,
--							[mone_FechaEliminacion] = @mone_FechaEliminacion
--					WHERE	[mone_Id] = @mone_Id
--				END
--		END

--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH
--END
--GO

--WITH AKT AS ( SELECT f.name AS ForeignKey
--                    ,OBJECT_NAME(f.parent_object_id) AS TableName
--                    ,COL_NAME(fc.parent_object_id, fc.parent_column_id) AS ColumnName
--					,SCHEMA_NAME(schema_id) SchemaName
--                    ,OBJECT_NAME (f.referenced_object_id) AS ReferenceTableName
--                    ,COL_NAME(fc.referenced_object_id, fc.referenced_column_id) AS ReferenceColumnName
--              FROM   sys.foreign_keys AS f
--                     INNER JOIN sys.foreign_key_columns AS fc ON f.OBJECT_ID = fc.constraint_object_id
--              WHERE  f.referenced_object_id = object_id('gral.tbColonias'))
--SELECT 'SELECT ' + ColumnName + ' FROM ' + SchemaName + '.' + TableName + ' WHERE  RR.' + ColumnName + ' = OO.' + ReferenceColumnName + ' UNION ALL'
--FROM   AKT


--DECLARE @QUERY NVARCHAR(MAX)

--WITH AKT AS ( SELECT ROW_NUMBER() OVER (ORDER BY f.name) RN, f.name AS ForeignKey
--                    ,OBJECT_NAME(f.parent_object_id) AS TableName
--                    ,COL_NAME(fc.parent_object_id, fc.parent_column_id) AS ColumnName
--                    ,SCHEMA_NAME(f.schema_id) SchemaName
--                    ,OBJECT_NAME (f.referenced_object_id) AS ReferenceTableName
--                    ,COL_NAME(fc.referenced_object_id, fc.referenced_column_id) AS ReferenceColumnName
--              FROM   sys.foreign_keys AS f
--                     INNER JOIN sys.foreign_key_columns AS fc ON f.OBJECT_ID = fc.constraint_object_id
--                     INNER JOIN sys.objects oo ON oo.object_id = fc.referenced_object_id
--              WHERE  f.referenced_object_id = object_id('gral.tbColonias'))

--    ,bs AS (SELECT AKT.RN
--                  ,'SELECT ' + ColumnName + ' FROM ' + SchemaName + '.' + TableName + ' WHERE ' + ColumnName + ' = OO.' + ReferenceColumnName  SubQuery
--            FROM   AKT)
--    ,re AS (SELECT bs.RN, CAST(RTRIM(bs.SubQuery) AS VARCHAR(MAX)) Joined
--            FROM   bs
--            WHERE  bs.RN = 1
--            UNION  ALL
--            SELECT bs2.RN, CAST(re.Joined + ' UNION ALL ' + ISNULL(RTRIM(bs2.SubQuery), '') AS VARCHAR(MAX)) Joined
--            FROM   re, bs bs2 
--            WHERE  re.RN = bs2.RN - 1 )
--    ,fi AS (SELECT ROW_NUMBER() OVER (ORDER BY RN DESC) RNK, Joined
--            FROM   re)
--SELECT @QUERY  = 'SELECT OO.colo_Id, CASE WHEN XX.REFERENCED IS NULL THEN ''No'' ELSE ''Yes'' END Referenced
--FROM   gral.tbColonias OO
--       OUTER APPLY (SELECT SUM(1) REFERENCED
--                    FROM   (' + Joined + ') II) XX'
--FROM   fi
--WHERE  RNK = 1

--EXEC (@QUERY)

-----------------PROCEDIMIENTOS ALMACENADOS Y VISTAS MÓDULO ADUANA
--**********FORMAS DE PRESENTACIÓN**********--

/*Vista forma presentación*/
--CREATE OR ALTER VIEW adua.VW_tbFormaPresentacion
--AS
--SELECT pres_Id AS presentacionId, 
--	   pres_Descripcion AS presentacionNombre, 
--	   pres.usua_UsuarioCreacion AS usuarioCreacion, 
--	   usuaCrea.usua_Nombre AS usuarioCreacionNombre,
--	   pres_FechaCreacion AS fechaCreacion, 
--	   pres.usua_UsuarioModificacion AS usuarioModificacion, 
--	   usuaModifica.usua_Nombre AS usuarioModificacionNombre,
--	   pres_FechaModificacion AS fechaModificacion, 
--	   pres.usua_UsuarioEliminacion AS usuarioEliminacion, 
--	   usuaElimina.usua_Nombre AS usuarioEliminacionNombre,
--	   pres_FechaEliminacion AS fechaEliminacion, 
--	   pres_Estado AS presentacionEstado
--FROM [Adua].[tbFormaPresentacion] pres INNER JOIN [Acce].[tbUsuarios] usuaCrea
--ON pres.usua_UsuarioCreacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaModifica
--ON pres.usua_UsuarioModificacion = usuaCrea.usua_Id LEFT JOIN [Acce].[tbUsuarios] usuaElimina
--ON pres.usua_UsuarioEliminacion = usuaCrea.usua_Id
--GO


--/*Listar forma presentación*/
--CREATE OR ALTER PROCEDURE adua.UDP_VW_tbFormaPresentacion_Listar
--AS
--BEGIN
--	SELECT *
--    FROM adua.VW_tbFormaPresentacion
--	WHERE presentacionEstado = 1
--END
--GO

--/*Insertar forma presentación*/
--CREATE OR ALTER PROCEDURE adua.UDP_tbFormaPresentacion_Insertar
--	@pres_Descripcion		NVARCHAR(150),
--	@usua_UsuarioCreacion	INT,
--	@pres_FechaCreacion     DATETIME
--AS 
--BEGIN
	
--	BEGIN TRY

--		IF EXISTS (SELECT * FROM [Adua].[tbFormaPresentacion]
--						WHERE [pres_Descripcion] = @pres_Descripcion
--						AND [pres_Estado] = 0)
--		BEGIN
--			UPDATE [Adua].[tbFormaPresentacion]
--			SET	   [pres_Estado] = 1
--			WHERE  [pres_Descripcion] = @pres_Descripcion

--			SELECT 1
--		END
--		ELSE 
--			BEGIN
--				INSERT INTO [Adua].[tbFormaPresentacion] (pres_Descripcion, 
--														  usua_UsuarioCreacion, 
--														  pres_FechaCreacion)
--			VALUES(@pres_Descripcion,	
--				   @usua_UsuarioCreacion,
--				   @pres_FechaCreacion)


--			SELECT 1
--		END
--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH 
--END
--GO

--/*Editar forma presentación*/
--CREATE OR ALTER PROCEDURE adua.UDP_tbFormaPresentacion_Editar
--	@pres_Id					INT,
--	@pres_Descripcion			NVARCHAR(150),
--	@usua_UsuarioModificacion	INT,
--	@pres_FechaModificacion     DATETIME
--AS
--BEGIN
--	BEGIN TRY
--		UPDATE  [Adua].[tbFormaPresentacion]
--		SET		[pres_Descripcion] = @pres_Descripcion,
--				[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
--				[pres_FechaModificacion] = @pres_FechaModificacion
--		WHERE	[pres_Id] = @pres_Id

--		SELECT 1
--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH
--END
--GO

--/*Eliminar forma presentación*/
--CREATE OR ALTER PROCEDURE adua.UDP_tbFormaPresentacion_Eliminar 
--	@pres_Id					INT,
--	@usua_UsuarioEliminacion	INT,
--	@pres_FechaEliminacion		DATETIME
--AS
--BEGIN
--	BEGIN TRY

--		BEGIN
--			DECLARE @respuesta INT
--			EXEC dbo.UDP_ValidarReferencias 'pres_Id', @pres_Id, 'adua.tbFormaPresentacion', @respuesta OUTPUT

--			SELECT @respuesta AS Resultado
--			IF(@respuesta) = 1
--				BEGIN
--					UPDATE	[Adua].[tbFormaPresentacion]
--					SET		[pres_Estado] = 0,
--							[usua_UsuarioEliminacion] = @usua_UsuarioEliminacion,
--							[pres_FechaEliminacion] = @pres_FechaEliminacion
--					WHERE	[pres_Id] = @pres_Id
--				END
--		END

--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH
--END
--GO

--**********INCOTERM**********--

/*Vista incoterm*/
--CREATE OR ALTER VIEW adua.VW_tbIncoterm
--AS
--	SELECT inco_Id								AS incotermId, 
--		   inco_Codigo							AS incotermCodigo,
--		   inco_Descripcion						AS incotermNombre, 
--		   inco.usua_UsuarioCreacion			AS usuarioCreacion, 
--		   usuaCrea.usua_Nombre					AS usuarioCreacionNombre,
--		   inco_FechaCreacion					AS fechaCreacion, 
--		   inco.usua_UsuarioModificacion		AS usuarioModificacion, 
--		   usuaModifica.usua_Nombre				AS usuarioModificacionNombre,
--		   inco_FechaModificacion				AS fechaModificacion, 
--		   inco.usua_UsuarioEliminacion			AS usuarioEliminacion, 
--		   usuaElimina.usua_Nombre				AS usuarioEliminacionNombre,
--		   inco_FechaEliminacion				AS fechaEliminacion, 
--		   inco_Estado							AS incotermEstado
--	FROM [Adua].[tbIncoterm] inco 
--	INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON inco.usua_UsuarioCreacion = usuaCrea.usua_Id 
--	LEFT JOIN [Acce].[tbUsuarios] usuaModifica	ON inco.usua_UsuarioModificacion = usuaCrea.usua_Id 
--	LEFT JOIN [Acce].[tbUsuarios] usuaElimina	ON inco.usua_UsuarioEliminacion = usuaCrea.usua_Id
--	WHERE inco_Estado = 1
--GO


/*Listar incoterm*/
CREATE OR ALTER PROCEDURE adua.UDP_tbIncoterm_Listar
AS
BEGIN
	SELECT inco_Id								--AS incotermId, 
		   ,inco_Codigo							--AS incotermCodigo,
		   ,inco_Descripcion						--AS incotermNombre, 
		   ,inco.usua_UsuarioCreacion			--AS usuarioCreacion, 
		   ,usuaCrea.usua_Nombre					--AS usuarioCreacionNombre,
		   ,inco_FechaCreacion					--AS fechaCreacion, 
		   ,inco.usua_UsuarioModificacion		--AS usuarioModificacion, 
		   ,usuaModifica.usua_Nombre				--AS usuarioModificacionNombre,
		   ,inco_FechaModificacion				--AS fechaModificacion, 
		   ,inco.usua_UsuarioEliminacion			--AS usuarioEliminacion, 
		   ,usuaElimina.usua_Nombre				--AS usuarioEliminacionNombre,
		   ,inco_FechaEliminacion				--AS fechaEliminacion, 
		   ,inco_Estado							--AS incotermEstado
	FROM [Adua].[tbIncoterm] inco 
	INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON inco.usua_UsuarioCreacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaModifica	ON inco.usua_UsuarioModificacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaElimina	ON inco.usua_UsuarioEliminacion = usuaCrea.usua_Id
	WHERE inco_Estado = 1
END
GO

/*Insertar incoterm*/
CREATE OR ALTER PROCEDURE adua.UDP_tbIncoterm_Insertar 
	@inco_Codigo			CHAR(3),
	@inco_Descripcion		NVARCHAR(150),
	@usua_UsuarioCreacion	INT,
	@inco_FechaCreacion     DATETIME
AS 
BEGIN
	
	BEGIN TRY

		--IF EXISTS (SELECT * FROM [Adua].[tbIncoterm]
		--				WHERE ([inco_Descripcion] = @inco_Descripcion
		--				OR [inco_Codigo] = @inco_Codigo)
		--				AND [inco_Estado] = 0)
		--BEGIN
		--	UPDATE [Adua].[tbIncoterm]
		--	SET	   [inco_Estado] = 1,
		--		   [inco_Descripcion] = @inco_Descripcion,
		--		   [inco_Codigo] = @inco_Codigo
		--	WHERE  [inco_Descripcion] = @inco_Descripcion

		--	SELECT 1
		--END
		--ELSE 
		--	BEGIN
				INSERT INTO [Adua].[tbIncoterm] (inco_Codigo,
												 inco_Descripcion, 
											     usua_UsuarioCreacion, 
											     inco_FechaCreacion)
			VALUES(@inco_Codigo,
				   @inco_Descripcion,	
				   @usua_UsuarioCreacion,
				   @inco_FechaCreacion)


			SELECT 1
		--END
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH 
END
GO

/*Editar incoterm*/
CREATE OR ALTER PROCEDURE adua.UDP_tbIncoterm_Editar
	@inco_Id					INT,
	@inco_Codigo				CHAR(3),
	@inco_Descripcion			NVARCHAR(150),
	@usua_UsuarioModificacion	INT,
	@inco_FechaModificacion     DATETIME
AS
BEGIN
	BEGIN TRY
		UPDATE  [Adua].[tbIncoterm]
		SET		[inco_Descripcion] = @inco_Descripcion,
		        [inco_Codigo] = @inco_Codigo,
 				[usua_UsuarioModificacion] = @usua_UsuarioModificacion,
				[inco_FechaModificacion] = @inco_FechaModificacion
		WHERE	[inco_Id] = @inco_Id

		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

/*Eliminar incoterm*/
--CREATE OR ALTER PROCEDURE adua.UDP_tbIncoterm_Eliminar 
--	@inco_Id					CHAR(3),
--	@usua_UsuarioEliminacion	INT,
--	@inco_FechaEliminacion		DATETIME
--AS
--BEGIN
--	BEGIN TRY

--		BEGIN
--			DECLARE @respuesta INT
--			EXEC dbo.UDP_ValidarReferencias 'inco_Id', @inco_Id, 'adua.tbIncoterm', @respuesta OUTPUT

--			SELECT @respuesta AS Resultado
--			IF(@respuesta) = 1
--				BEGIN
--					UPDATE	[Adua].[tbIncoterm]
--					SET		[inco_Estado] = 0,
--							[usua_UsuarioEliminacion] = @usua_UsuarioEliminacion,
--							[inco_FechaEliminacion] = @inco_FechaEliminacion
--					WHERE	[inco_Id] = @inco_Id
--				END
--		END

--	END TRY
--	BEGIN CATCH
--		SELECT 0
--	END CATCH
--END
--GO

-----------------PROCEDIMIENTOS ALMACENADOS Y VISTAS MÓDULO PRODUCCIÓN

/*Vista que trae todos los campos de la parte  1 del formulario de la declaración de valor, incluso los que están en 
  otras tablas conectadas a tbDeclaraciones_Valor (no se incluyen las facturas ni las condiciones)*/
GO
CREATE OR ALTER PROCEDURE adua.UDP_tbDeclaraciones_ValorCompleto_Listar
AS
BEGIN
	SELECT [deva_Id]							--AS declaracionId, 
		   ,[deva_Aduana_Ingreso_Id]				--AS aduanaIngresoId, 
		   ,aduaIngreso.adua_Nombre				--AS aduanaIngresoNombre,
		   ,[deva_Aduana_Despacho_Id]			--AS aduanaDespachoId, 
		   ,aduaDespacho.adua_Nombre				--AS aduanaDespachoNombre,
		   ,[deva_Declaracion_Mercancia]			--AS declaracionMercancia, 
		   ,[deva_Fecha_Aceptacion]				--AS declaracionFechaAceptacion, 

		   ,deva.[impo_Id]						--AS importadorId, 
		   ,declaImpo.decl_Nombre_Raso			AS importadorNombreRazonSocial
		   ,impo.impo_RTN						AS importadorRTN
		   ,impo.impo_NumRegistro				AS importadorNumeroRegistro
		   ,declaImpo.decl_Direccion_Exacta		AS importadorDireccionExacta
		   ,declaImpo.decl_Correo_Electronico	AS importadorCorreo
		   ,declaImpo.decl_Telefono				AS importadorTelefono
		   ,declaImpo.decl_Fax					AS importadorFax
		   ,declaImpo.ciud_Id					AS importadorCiudad
		   ,impo.nico_Id							
		   ,nico.nico_Descripcion				
		   ,impo.impo_NivelComercial_Otro		

		   ,deva.[pvde_Id]						--AS proveedorId, 
		   ,declaProv.decl_Nombre_Raso			AS proveedorNombreRazonSocial
		   ,declaProv.decl_Direccion_Exacta		AS proveedorDireccionExacta
		   ,declaProv.decl_Correo_Electronico	AS proveedorCorreo
		   ,declaProv.decl_Telefono				AS proveedorTelefono
		   ,declaProv.decl_Fax					AS proveedorFax
		   ,declaProv.ciud_Id					AS proveedorCiudad
		   ,prov.coco_Id						--AS proveedorCondicionComercialId,
		   ,coco.coco_Descripcion				--AS proveedorCondicionComercialDescripcion,
		   ,prov.pvde_Condicion_Otra			--AS proveedorCondicionComercialOtra,

		   ,deva.[inte_Id]						--AS intermediarioId, 
		   ,declaInte.decl_Nombre_Raso			AS intermediarioNombreRazonSocial
		   ,declaInte.decl_Direccion_Exacta		AS intermediarioDireccionExacta
		   ,declaInte.decl_Correo_Electronico	AS intermediarioCorreo
		   ,declaInte.decl_Telefono				AS intermediarioTelefono
		   ,declaInte.decl_Fax					AS intermediarioFax
		   ,declaInte.ciud_Id					AS intermediarioCiudad
		   ,inte.tite_Id						--AS tipoIntermediarioId,
		   ,tite.tite_Descripcion				--AS tipoIntermediarioDescripcion,

		   ,[deva_Lugar_Entrega]					--AS declaracionLugarEntrega, 
		   ,deva.[inco_Id]							--AS incotermId, 
		   ,inco.inco_Descripcion
		   ,[deva_numero_contrato]				--AS declaracionNumContrato, 
		   ,[deva_Fecha_Contrato]				--AS declaracionFechaContrato, 
		   ,deva.[foen_Id]							--AS formaEnvioId, 
		   ,foen.foen_Descripcion
		   ,[deva_Forma_Envio_Otra]				--AS formaEnvioOtra, 
		   ,[deva_Pago_Efectuado]				--AS declaracionPagoEfectuado, 
		   ,[fopa_Id]							--AS formaPagoId, 
		   ,[deva_Forma_Pago_Otra]				--AS formaPagoOtra, 
		   ,[emba_Id]							--AS declaracionLugarEmbarque, 
		   ,[pais_Exportacion_Id]				--AS paisExportacionId, 
		   ,[deva_Fecha_Exportacion]			--	AS declaracionFechaExportacion, 
		   ,[mone_Id]							--AS monedaId, 
		   ,[mone_Otra]							--AS monedaOtra, 
		   ,[deva_Conversion_Dolares]			--AS conversionDolares, 
		   ,[deva_Condiciones]					--AS declaracionCondiciones, 
		   ,deva.[usua_UsuarioCreacion]			--AS usuaCreacionId, 
		   ,[deva_FechaCreacion]				--AS fechaCreacion, 
		   ,deva.[usua_UsuarioModificacion]		--AS usuarioModificacionId, 
		   ,[deva_FechaModificacion]			--AS fechaModificacion, 
		   --,deva.[usua_UsuarioEliminacion]		--AS usuarioEliminacionId, 
		   --,[deva_FechaEliminacion]				--AS fechaEliminacion, 
		   ,[deva_Estado]						--AS declaracionEstado
	FROM   [Adua].[tbDeclaraciones_Valor] deva 
		   INNER JOIN [Adua].[tbAduanas] aduaIngreso			ON deva.deva_Aduana_Ingreso_Id = aduaIngreso.adua_Id
		   INNER JOIN [Adua].[tbAduanas] aduaDespacho			ON deva.deva_Aduana_Despacho_Id = aduaDespacho.adua_Id
		   INNER JOIN [Adua].[tbImportadores] impo				ON deva.impo_Id = impo.impo_Id
		   INNER JOIN [Adua].[tbDeclarantes] declaImpo			ON impo.decl_Id = declaImpo.decl_Id
		   INNER JOIN [Adua].[tbNivelesComerciales] nico		ON impo.nico_Id = nico.nico_Id
		   INNER JOIN [Adua].[tbProveedoresDeclaracion] prov	ON prov.pvde_Id = deva.pvde_Id
		   INNER JOIN [Adua].[tbDeclarantes] declaProv			ON prov.decl_Id = declaProv.decl_Id
		   INNER JOIN [Adua].[tbCondicionesComerciales] coco	ON prov.coco_Id = coco.coco_Id
		   LEFT JOIN  [Adua].[tbIntermediarios] inte			ON inte.inte_Id = deva.inte_Id
		   LEFT JOIN  [Adua].[tbDeclarantes] declaInte			ON declaInte.decl_Id = inte.decl_Id
		   LEFT JOIN  [Adua].[tbTipoIntermediario] tite			ON inte.tite_Id = tite.tite_Id
		   LEFT JOIN  [Adua].[tbIncoterm] inco					ON inco.inco_Id = deva.inco_Id
		   LEFT JOIN  [Gral].[tbFormas_Envio] foen				ON foen.foen_Id = deva.foen_Id
END
GO

CREATE OR ALTER PROCEDURE adua.UDP_tbDeclarantes_Insertar
	@decl_Nombre_Raso				NVARCHAR(250),
	@decl_Direccion_Exacta			NVARCHAR(250),
	@ciud_Id						INT,
	@decl_Correo_Electronico		NVARCHAR(150),
	@decl_Telefono					NVARCHAR(50),
	@decl_Fax						NVARCHAR(50),
	@usua_UsuarioCreacion			INT,
	@decl_FechaCreacion				DATETIME,
	@decl_Id						INT OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO [Adua].[tbDeclarantes](decl_Nombre_Raso, 
										   decl_Direccion_Exacta, 
										   ciud_Id, 
										   decl_Correo_Electronico, 
										   decl_Telefono, 
										   decl_Fax, 
										   usua_UsuarioCreacion, 
										   decl_FechaCreacion)
		VALUES(@decl_Nombre_Raso,
			   @decl_Direccion_Exacta,
			   @ciud_Id,
			   @decl_Correo_Electronico,
			   @decl_Telefono,
			   @decl_Fax,
			   @usua_UsuarioCreacion,
			   @decl_FechaCreacion)

		SET @decl_Id = SCOPE_IDENTITY()

		RETURN @decl_Id
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO

CREATE OR ALTER PROCEDURE adua.UDP_tbDeclarantes_Editar
	@decl_Id						INT,
	@decl_Nombre_Raso				NVARCHAR(250),
	@decl_Direccion_Exacta			NVARCHAR(250),
	@ciud_Id						INT,
	@decl_Correo_Electronico		NVARCHAR(150),
	@decl_Telefono					NVARCHAR(50),
	@decl_Fax						NVARCHAR(50),
	@usua_UsuarioModificacion		INT,
	@decl_FechaModificacion			DATETIME
AS
BEGIN
	BEGIN TRY
		
		UPDATE [Adua].[tbDeclarantes]
		SET decl_Nombre_Raso = @decl_Nombre_Raso, 
			decl_Direccion_Exacta = @decl_Direccion_Exacta, 
			ciud_Id = @ciud_Id, 
			decl_Correo_Electronico = @decl_Correo_Electronico, 
			decl_Telefono = @decl_Telefono, 
			decl_Fax = @decl_Fax, 
			usua_UsuarioModificacion = @usua_UsuarioModificacion, 
			decl_FechaModificacion = @decl_FechaModificacion
		WHERE decl_Id = @decl_Id

	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO


CREATE OR ALTER PROCEDURE adua.UDP_tbDeclaraciones_Valor_Tab1_Insertar 
	@deva_Aduana_Ingreso_Id				INT,
	@deva_Aduana_Despacho_Id			INT,
	@deva_Fecha_Aceptacion				DATETIME,
	@decl_Nombre_Raso					NVARCHAR(250),
	@impo_RTN							NVARCHAR(40),
	@impo_NumRegistro					NVARCHAR(40),
	@decl_Direccion_Exacta				NVARCHAR(250),
	@ciud_Id							INT,
	@decl_Correo_Electronico			NVARCHAR(150),
	@decl_Telefono						NVARCHAR(50),
	@decl_Fax							NVARCHAR(50),
	@nico_Id							INT,
	@impo_NivelComercial_Otro			NVARCHAR(300),
	@usua_UsuarioCreacion				INT,
	@deva_FechaCreacion					DATETIME
AS
BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
		
		DECLARE @decl_Id INT;

		EXEC adua.UDP_tbDeclarantes_Insertar @decl_Nombre_Raso,
										   @decl_Direccion_Exacta,
										   @ciud_Id,
										   @decl_Correo_Electronico,
										   @decl_Telefono,
										   @decl_Fax,
										   @usua_UsuarioCreacion,
										   @deva_FechaCreacion,
										   @decl_Id OUTPUT

		--INSERT INTO [Adua].[tbDeclaraciones_ValorHistorial]()

		INSERT INTO [Adua].[tbImportadores](nico_Id, 
											decl_Id, 
											impo_NivelComercial_Otro, 
											impo_RTN, 
											impo_NumRegistro, 
											usua_UsuarioCreacion, 
											impo_FechaCreacion)
		VALUES(@nico_Id, 
			   @decl_Id,
			   @impo_NivelComercial_Otro,
			   @impo_RTN,
			   @impo_NumRegistro,
			   @usua_UsuarioCreacion,
			   @deva_FechaCreacion)

		DECLARE @impo_Id INT = SCOPE_IDENTITY()

		INSERT INTO [Adua].[tbDeclaraciones_Valor](deva_Aduana_Ingreso_Id, 
												   deva_Aduana_Despacho_Id, 
												   deva_Fecha_Aceptacion, 
												   impo_Id, 
												   usua_UsuarioCreacion, 
												   deva_FechaCreacion)
		VALUES(@deva_Aduana_Ingreso_Id,
			   @deva_Aduana_Despacho_Id,
			   @deva_Fecha_Aceptacion,
			   @impo_Id,
			   @usua_UsuarioCreacion,
			   @deva_FechaCreacion)


		DECLARE @deva_Id INT = SCOPE_IDENTITY()

		INSERT INTO [Adua].[tbDeclaraciones_ValorHistorial](deva_Id, 
															deva_Aduana_Ingreso_Id, 
															deva_Aduana_Despacho_Id,  
															deva_Fecha_Aceptacion, 
															impo_Id,
															hdev_UsuarioAccion, 
															hdev_FechaAccion, 
															hdev_Accion)
		VALUES (@deva_Id,
				@deva_Aduana_Ingreso_Id,
				@deva_Aduana_Despacho_Id,
				@deva_Fecha_Aceptacion,
				@impo_Id,
				@usua_UsuarioCreacion,
				@deva_FechaCreacion,
				'Insertar tab1')

		SELECT @deva_Id

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO


CREATE OR ALTER PROCEDURE adua.UDP_tbDeclaraciones_Valor_Tab1_Editar 
	@deva_Id							INT,
	@deva_Aduana_Ingreso_Id				INT,
	@deva_Aduana_Despacho_Id			INT,
	@deva_Fecha_Aceptacion				DATETIME,
	@decl_Nombre_Raso					NVARCHAR(250),
	@impo_RTN							NVARCHAR(40),
	@impo_NumRegistro					NVARCHAR(40),
	@decl_Direccion_Exacta				NVARCHAR(250),
	@ciud_Id							INT,
	@decl_Correo_Electronico			NVARCHAR(150),
	@decl_Telefono						NVARCHAR(50),
	@decl_Fax							NVARCHAR(50),
	@nico_Id							INT,
	@impo_NivelComercial_Otro			NVARCHAR(300),
	@usua_UsuarioModificacion			INT,
	@deva_FechaModificacion				DATETIME
AS
BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
		
		DECLARE @decl_Id INT;

		SET @decl_Id = (SELECT decl_Id
						FROM [Adua].[tbImportadores]
						WHERE impo_Id = (SELECT impo_Id 
										 FROM [Adua].[tbDeclaraciones_Valor]
										 WHERE deva_Id = @deva_Id))

		EXEC adua.UDP_tbDeclarantes_Editar @decl_Id,
										   @decl_Nombre_Raso,
										   @decl_Direccion_Exacta,
										   @ciud_Id,
										   @decl_Correo_Electronico,
										   @decl_Telefono,
										   @decl_Fax,
										   @usua_UsuarioModificacion,
										   @deva_FechaModificacion

		DECLARE @impo_Id INT = (SELECT impo_Id 
								FROM [Adua].[tbDeclaraciones_Valor]
								WHERE deva_Id = @deva_Id)

		UPDATE [Adua].[tbImportadores]
		SET		nico_Id = @nico_Id, 
			    decl_Id = @decl_Id, 
			    impo_NivelComercial_Otro = @impo_NivelComercial_Otro, 
			    impo_RTN = @impo_RTN, 
			    impo_NumRegistro = @impo_NumRegistro, 
			    usua_UsuarioModificacion = @usua_UsuarioModificacion, 
			    impo_FechaModificacion = @deva_FechaModificacion
		WHERE impo_Id = @impo_Id


		UPDATE [Adua].[tbDeclaraciones_Valor]
		SET deva_Aduana_Ingreso_Id = @deva_Aduana_Ingreso_Id, 
			deva_Aduana_Despacho_Id = @deva_Aduana_Despacho_Id, 
			deva_Fecha_Aceptacion = @deva_Fecha_Aceptacion, 
			impo_Id = @impo_Id,
			usua_UsuarioModificacion = @usua_UsuarioModificacion,
			deva_FechaModificacion = @deva_FechaModificacion
		WHERE deva_Id = @deva_Id


		INSERT INTO [Adua].[tbDeclaraciones_ValorHistorial](deva_Id, 
															deva_Aduana_Ingreso_Id, 
															deva_Aduana_Despacho_Id, 
															deva_Declaracion_Mercancia, 
															deva_Fecha_Aceptacion, 
															impo_Id, 
															pvde_Id, 
															inte_Id, 
															deva_Lugar_Entrega, 
															pais_Entrega_Id, 
															inco_Id, 
															inco_Version, 
															deva_numero_contrato, 
															deva_Fecha_Contrato, 
															foen_Id, 
															deva_Forma_Envio_Otra, 
															deva_Pago_Efectuado, 
															fopa_Id, 
															deva_Forma_Pago_Otra, 
															emba_Id, 
															pais_Exportacion_Id, 
															deva_Fecha_Exportacion, 
															mone_Id, 
															mone_Otra, 
															deva_Conversion_Dolares, 
															deva_Condiciones,
															hdev_UsuarioAccion, 
															hdev_FechaAccion, 
															hdev_Accion)
		SELECT deva_Id, 
			   deva_Aduana_Ingreso_Id, 
			   deva_Aduana_Despacho_Id, 
			   deva_Declaracion_Mercancia, 
			   deva_Fecha_Aceptacion, 
			   impo_Id, 
			   pvde_Id, 
			   inte_Id, 
			   deva_Lugar_Entrega, 
			   pais_Entrega_Id, 
			   inco_Id, 
			   inco_Version, 
			   deva_numero_contrato, 
			   deva_Fecha_Contrato, 
			   foen_Id, 
			   deva_Forma_Envio_Otra, 
			   deva_Pago_Efectuado, 
			   fopa_Id, 
			   deva_Forma_Pago_Otra, 
			   emba_Id, 
			   pais_Exportacion_Id, 
			   deva_Fecha_Exportacion, 
			   mone_Id, 
			   mone_Otra, 
			   deva_Conversion_Dolares, 
			   deva_Condiciones,
			   @usua_UsuarioModificacion,
			   @deva_FechaModificacion,
			   'Editar tab1'
		FROM [Adua].[tbDeclaraciones_Valor]
		WHERE deva_Id = @deva_Id

		SELECT 1

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
GO

CREATE OR ALTER PROCEDURE adua.UDP_tbDeclaraciones_Valor_Tab2_Insertar
	@deva_Id						INT,
	@prov_decl_Nombre_Raso			NVARCHAR(250),
	@prov_decl_Direccion_Exacta		NVARCHAR(250),
	@prov_ciud_Id					INT,
	@prov_decl_Correo_Electronico	NVARCHAR(150),
	@prov_decl_Telefono				NVARCHAR(50),
	@prov_decl_Fax					NVARCHAR(50),
	@coco_Id						INT,
	@pvde_Condicion_Otra			NVARCHAR(30),
	@inte_decl_Nombre_Raso			NVARCHAR(250),
	@inte_decl_Direccion_Exacta		NVARCHAR(250),
	@inte_ciud_Id					INT,
	@inte_decl_Correo_Electronico	NVARCHAR(150),
	@inte_decl_Telefono				NVARCHAR(50),
	@inte_decl_Fax					NVARCHAR(50),
	@tite_Id						INT,
	@inte_Tipo_Otro					NVARCHAR(30),
	@usua_UsuarioCreacion			INT,
	@deva_FechaCreacion				DATETIME
AS
BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY

		DECLARE @prov_decl_Id INT;
		DECLARE @inte_decl_Id INT;
		
		EXEC adua.UDP_tbDeclarantes_Insertar @prov_decl_Nombre_Raso,
										   @prov_decl_Direccion_Exacta,
										   @prov_ciud_Id,
										   @prov_decl_Correo_Electronico,
										   @prov_decl_Telefono,
										   @prov_decl_Fax,
										   @usua_UsuarioCreacion,
										   @deva_FechaCreacion,
										   @prov_decl_Id OUTPUT

		INSERT INTO [Adua].[tbProveedoresDeclaracion](coco_Id, 
													  pvde_Condicion_Otra, 
													  decl_Id, 
													  usua_UsuarioCreacion, 
													  pvde_FechaCreacion)
		VALUES(@coco_Id, 
			   @pvde_Condicion_Otra,
			   @prov_decl_Id,
			   @usua_UsuarioCreacion,
			   @deva_FechaCreacion)

		DECLARE @prov_Id INT = SCOPE_IDENTITY()

		EXEC adua.UDP_tbDeclarantes_Insertar @inte_decl_Nombre_Raso,
										   @inte_decl_Direccion_Exacta,
										   @inte_ciud_Id,
										   @inte_decl_Correo_Electronico,
										   @inte_decl_Telefono,
										   @inte_decl_Fax,
										   @usua_UsuarioCreacion,
										   @deva_FechaCreacion,
										   @inte_decl_Id OUTPUT


		INSERT INTO [Adua].[tbIntermediarios](tite_Id, 
											  inte_Tipo_Otro,
											  decl_Id, 
											  usua_UsuarioCreacion, 
											  inte_FechaCreacion)
		VALUES (@tite_Id, 
				@inte_Tipo_Otro, 
				@inte_decl_Id,
				@usua_UsuarioCreacion,
				@deva_FechaCreacion)

		DECLARE @inte_Id INT = SCOPE_IDENTITY()

		UPDATE [Adua].[tbDeclaraciones_Valor]
		SET [inte_Id] = @inte_Id,
			[pvde_Id] = @prov_Id
		WHERE [deva_Id] = @deva_Id

		INSERT INTO [Adua].[tbDeclaraciones_ValorHistorial](deva_Id, 
															deva_Aduana_Ingreso_Id, 
															deva_Aduana_Despacho_Id, 
															deva_Declaracion_Mercancia, 
															deva_Fecha_Aceptacion, 
															impo_Id, 
															pvde_Id, 
															inte_Id, 
															hdev_UsuarioAccion, 
															hdev_FechaAccion, 
															hdev_Accion)
		SELECT deva_Id,
			   deva_Aduana_Ingreso_Id,
			   deva_Aduana_Despacho_Id,
			   deva_Declaracion_Mercancia,
			   deva_Fecha_Aceptacion,
			   impo_Id,
			   @prov_Id,
			   @inte_Id,
			   @usua_UsuarioCreacion,
			   @deva_FechaCreacion,
			   'Insertar tab2'
		FROM [Adua].[tbDeclaraciones_Valor]
		WHERE deva_Id = @deva_Id

		SELECT 1
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

GO
CREATE OR ALTER PROCEDURE adua.UDP_tbDeclaraciones_Valor_Tab2_Editar
	@deva_Id						INT,
	@prov_decl_Nombre_Raso			NVARCHAR(250),
	@prov_decl_Direccion_Exacta		NVARCHAR(250),
	@prov_ciud_Id					INT,
	@prov_decl_Correo_Electronico	NVARCHAR(150),
	@prov_decl_Telefono				NVARCHAR(50),
	@prov_decl_Fax					NVARCHAR(50),
	@coco_Id						INT,
	@pvde_Condicion_Otra			NVARCHAR(30),
	@inte_decl_Nombre_Raso			NVARCHAR(250),
	@inte_decl_Direccion_Exacta		NVARCHAR(250),
	@inte_ciud_Id					INT,
	@inte_decl_Correo_Electronico	NVARCHAR(150),
	@inte_decl_Telefono				NVARCHAR(50),
	@inte_decl_Fax					NVARCHAR(50),
	@tite_Id						INT,
	@inte_Tipo_Otro					NVARCHAR(30),
	@usua_UsuarioModificacion		INT,
	@deva_FechaModificacion			DATETIME
AS
BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY

		DECLARE @prov_decl_Id INT = (SELECT decl_Id
									 FROM [Adua].[tbProveedoresDeclaracion]
									 WHERE pvde_Id = (SELECT pvde_Id
													  FROM [Adua].[tbDeclaraciones_Valor]
													  WHERE deva_Id = @deva_Id));
		DECLARE @inte_decl_Id INT = (SELECT decl_Id
									 FROM [Adua].[tbIntermediarios]
									 WHERE inte_Id = (SELECT inte_Id
													  FROM [Adua].[tbDeclaraciones_Valor]
													  WHERE deva_Id = @deva_Id));
		
		EXEC adua.UDP_tbDeclarantes_Editar @prov_decl_Id,
										   @prov_decl_Nombre_Raso,
										   @prov_decl_Direccion_Exacta,
										   @prov_ciud_Id,
										   @prov_decl_Correo_Electronico,
										   @prov_decl_Telefono,
										   @prov_decl_Fax,
										   @usua_UsuarioModificacion,
										   @deva_FechaModificacion

		DECLARE @pvde_Id INT = (SELECT pvde_Id
								FROM [Adua].[tbDeclaraciones_Valor]
								WHERE deva_Id = @deva_Id)

		UPDATE [Adua].[tbProveedoresDeclaracion]
		SET coco_Id = @coco_Id, 
			pvde_Condicion_Otra = @pvde_Condicion_Otra, 
			decl_Id = @prov_decl_Id, 
			usua_UsuarioModificacion = @usua_UsuarioModificacion, 
			pvde_FechaModificacion = @deva_FechaModificacion
		WHERE pvde_Id = @pvde_Id


		EXEC adua.UDP_tbDeclarantes_Editar @inte_decl_Id,
										   @inte_decl_Nombre_Raso,
										   @inte_decl_Direccion_Exacta,
										   @inte_ciud_Id,
										   @inte_decl_Correo_Electronico,
										   @inte_decl_Telefono,
										   @inte_decl_Fax,
										   @usua_UsuarioModificacion,
										   @deva_FechaModificacion

		DECLARE @inte_Id INT = (SELECT inte_Id
								FROM [Adua].[tbDeclaraciones_Valor]
								WHERE deva_Id = @deva_Id)

		UPDATE [Adua].[tbIntermediarios]
		SET tite_Id = @tite_Id, 
			inte_Tipo_Otro = @inte_Tipo_Otro,
			decl_Id = @inte_decl_Id, 
			usua_UsuarioModificacion = @usua_UsuarioModificacion,
			inte_FechaModificacion = @deva_FechaModificacion
		WHERE inte_Id = @inte_Id

		UPDATE [Adua].[tbDeclaraciones_Valor]
		SET [inte_Id] = @inte_Id,
			[pvde_Id] = @pvde_Id
		WHERE [deva_Id] = @deva_Id

		INSERT INTO [Adua].[tbDeclaraciones_ValorHistorial](deva_Id, 
															deva_Aduana_Ingreso_Id, 
															deva_Aduana_Despacho_Id, 
															deva_Declaracion_Mercancia, 
															deva_Fecha_Aceptacion, 
															impo_Id, 
															pvde_Id, 
															inte_Id, 
															deva_Lugar_Entrega, 
															pais_Entrega_Id, 
															inco_Id, 
															inco_Version, 
															deva_numero_contrato, 
															deva_Fecha_Contrato, 
															foen_Id, 
															deva_Forma_Envio_Otra, 
															deva_Pago_Efectuado, 
															fopa_Id, 
															deva_Forma_Pago_Otra, 
															emba_Id, 
															pais_Exportacion_Id, 
															deva_Fecha_Exportacion, 
															mone_Id, 
															mone_Otra, 
															deva_Conversion_Dolares, 
															deva_Condiciones,
															hdev_UsuarioAccion, 
															hdev_FechaAccion, 
															hdev_Accion)
		SELECT deva_Id, 
			   deva_Aduana_Ingreso_Id, 
			   deva_Aduana_Despacho_Id, 
			   deva_Declaracion_Mercancia, 
			   deva_Fecha_Aceptacion, 
			   impo_Id, 
			   pvde_Id, 
			   inte_Id, 
			   deva_Lugar_Entrega, 
			   pais_Entrega_Id, 
			   inco_Id, 
			   inco_Version, 
			   deva_numero_contrato, 
			   deva_Fecha_Contrato, 
			   foen_Id, 
			   deva_Forma_Envio_Otra, 
			   deva_Pago_Efectuado, 
			   fopa_Id, 
			   deva_Forma_Pago_Otra, 
			   emba_Id, 
			   pais_Exportacion_Id, 
			   deva_Fecha_Exportacion, 
			   mone_Id, 
			   mone_Otra, 
			   deva_Conversion_Dolares, 
			   deva_Condiciones,
			   @usua_UsuarioModificacion,
			   @deva_FechaModificacion,
			   'Editar tab2'
		FROM [Adua].[tbDeclaraciones_Valor]
		WHERE deva_Id = @deva_Id

		SELECT 1
			
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END


GO
CREATE OR ALTER PROCEDURE adua.UDP_tbDeclaraciones_Valor_Tab3_Insertar 
	@deva_Id					INT,	
	@deva_Lugar_Entrega			NVARCHAR(800),
	@pais_Entrega_Id			INT,
	@inco_Id					INT,
	@inco_Version				NVARCHAR(10),
	@deva_numero_contrato		NVARCHAR(200),
	@deva_Fecha_Contrato		DATE,
	@foen_Id					INT,
	@deva_Forma_Envio_Otra		NVARCHAR(500),
	@deva_Pago_Efectuado		BIT,
	@fopa_Id					INT,
	@deva_Forma_Pago_Otra		NVARCHAR(200),
	@emba_Id					INT,
	@pais_Exportacion_Id		INT,
	@deva_Fecha_Exportacion		DATE,
	@mone_Id					INT,
	@mone_Otra					NVARCHAR(200),
	@deva_Conversion_Dolares	DECIMAL(18,2),
	@deva_UsuarioCreacion		INT,
	@deva_FechaCreacion			DATETIME
AS 
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY

			UPDATE [Adua].[tbDeclaraciones_Valor]
			SET deva_Lugar_Entrega = @deva_Lugar_Entrega,
				pais_Entrega_Id = @pais_Entrega_Id,
				inco_Id = @inco_Id,
				inco_Version = @inco_Version,
				deva_numero_contrato = @deva_numero_contrato,
				deva_Fecha_Contrato = @deva_Fecha_Contrato,
				foen_Id = @foen_Id,
				deva_Forma_Envio_Otra = @deva_Forma_Envio_Otra,
				deva_Pago_Efectuado = @deva_Pago_Efectuado,
				fopa_Id = @fopa_Id,
				deva_Forma_Pago_Otra = @deva_Forma_Pago_Otra,
				emba_Id = @emba_Id,
				pais_Exportacion_Id = @pais_Exportacion_Id,
				deva_Fecha_Exportacion = @deva_Fecha_Exportacion,
				mone_Id = @mone_Id,
				mone_Otra = @mone_Otra,
				deva_Conversion_Dolares = @deva_Conversion_Dolares
			WHERE deva_id = @deva_Id

			INSERT INTO [Adua].[tbDeclaraciones_ValorHistorial](deva_Id, 
																deva_Aduana_Ingreso_Id, 
																deva_Aduana_Despacho_Id, 
																deva_Declaracion_Mercancia, 
																deva_Fecha_Aceptacion, 
																impo_Id, 
																pvde_Id, 
																inte_Id, 
																deva_Lugar_Entrega, 
																pais_Entrega_Id,
																inco_Id, 
																inco_Version,
																deva_numero_contrato, 
																deva_Fecha_Contrato, 
																foen_Id, 
																deva_Forma_Envio_Otra, 
																deva_Pago_Efectuado, 
																fopa_Id, 
																deva_Forma_Pago_Otra, 
																emba_Id, 
																pais_Exportacion_Id, 
																deva_Fecha_Exportacion, 
																mone_Id, 
																mone_Otra, 
																deva_Conversion_Dolares, 
																hdev_UsuarioAccion, 
																hdev_FechaAccion, 
																hdev_Accion)

				SELECT deva_Id, 
					   deva_Aduana_Ingreso_Id, 
					   deva_Aduana_Despacho_Id, 
					   deva_Declaracion_Mercancia, 
					   deva_Fecha_Aceptacion, 
					   impo_Id, 
					   pvde_Id, 
					   inte_Id, 
					   @deva_Lugar_Entrega,
					   @pais_Entrega_Id,
					   @inco_Id, 
					   @inco_Version,
					   @deva_numero_contrato, 
					   @deva_Fecha_Contrato, 
					   @foen_Id, 
					   @deva_Forma_Envio_Otra, 
					   @deva_Pago_Efectuado, 
					   @fopa_Id, 
					   @deva_Forma_Pago_Otra, 
					   @emba_Id, 
					   @pais_Exportacion_Id, 
					   @deva_Fecha_Exportacion, 
					   @mone_Id, 
					   @mone_Otra, 
					   @deva_Conversion_Dolares, 
					   @deva_UsuarioCreacion, 
					   @deva_FechaCreacion, 
					   'Insertar tab3'
				FROM [Adua].[tbDeclaraciones_Valor]
				WHERE deva_Id = @deva_Id

			SELECT 1
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

GO
CREATE OR ALTER PROCEDURE adua.UDP_tbDeclaraciones_Valor_Tab3_Editar 
	@deva_Id					INT,	
	@deva_Lugar_Entrega			NVARCHAR(800),
	@pais_Entrega_Id			INT,
	@inco_Id					INT,
	@inco_Version				NVARCHAR(10),
	@deva_numero_contrato		NVARCHAR(200),
	@deva_Fecha_Contrato		DATE,
	@foen_Id					INT,
	@deva_Forma_Envio_Otra		NVARCHAR(500),
	@deva_Pago_Efectuado		BIT,
	@fopa_Id					INT,
	@deva_Forma_Pago_Otra		NVARCHAR(200),
	@emba_Id					INT,
	@pais_Exportacion_Id		INT,
	@deva_Fecha_Exportacion		DATE,
	@mone_Id					INT,
	@mone_Otra					NVARCHAR(200),
	@deva_Conversion_Dolares	DECIMAL(18,2),
	@deva_UsuarioModificacion	INT,
	@deva_FechaModificacion		DATETIME
AS 
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY

			UPDATE [Adua].[tbDeclaraciones_Valor]
			SET deva_Lugar_Entrega = @deva_Lugar_Entrega,
				pais_Entrega_Id = @pais_Entrega_Id,
				inco_Id = @inco_Id,
				inco_Version = @inco_Version,
				deva_numero_contrato = @deva_numero_contrato,
				deva_Fecha_Contrato = @deva_Fecha_Contrato,
				foen_Id = @foen_Id,
				deva_Forma_Envio_Otra = @deva_Forma_Envio_Otra,
				deva_Pago_Efectuado = @deva_Pago_Efectuado,
				fopa_Id = @fopa_Id,
				deva_Forma_Pago_Otra = @deva_Forma_Pago_Otra,
				emba_Id = @emba_Id,
				pais_Exportacion_Id = @pais_Exportacion_Id,
				deva_Fecha_Exportacion = @deva_Fecha_Exportacion,
				mone_Id = @mone_Id,
				mone_Otra = @mone_Otra,
				deva_Conversion_Dolares = @deva_Conversion_Dolares
			WHERE deva_id = @deva_Id

			INSERT INTO [Adua].[tbDeclaraciones_ValorHistorial](deva_Id, 
															deva_Aduana_Ingreso_Id, 
															deva_Aduana_Despacho_Id, 
															deva_Declaracion_Mercancia, 
															deva_Fecha_Aceptacion, 
															impo_Id, 
															pvde_Id, 
															inte_Id, 
															deva_Lugar_Entrega, 
															pais_Entrega_Id, 
															inco_Id, 
															inco_Version, 
															deva_numero_contrato, 
															deva_Fecha_Contrato, 
															foen_Id, 
															deva_Forma_Envio_Otra, 
															deva_Pago_Efectuado, 
															fopa_Id, 
															deva_Forma_Pago_Otra, 
															emba_Id, 
															pais_Exportacion_Id, 
															deva_Fecha_Exportacion, 
															mone_Id, 
															mone_Otra, 
															deva_Conversion_Dolares, 
															deva_Condiciones,
															hdev_UsuarioAccion, 
															hdev_FechaAccion, 
															hdev_Accion)
			SELECT deva_Id, 
				   deva_Aduana_Ingreso_Id, 
				   deva_Aduana_Despacho_Id, 
				   deva_Declaracion_Mercancia, 
				   deva_Fecha_Aceptacion, 
				   impo_Id, 
				   pvde_Id, 
				   inte_Id, 
				   deva_Lugar_Entrega, 
				   pais_Entrega_Id, 
				   inco_Id, 
				   inco_Version, 
				   deva_numero_contrato, 
				   deva_Fecha_Contrato, 
				   foen_Id, 
				   deva_Forma_Envio_Otra, 
				   deva_Pago_Efectuado, 
				   fopa_Id, 
				   deva_Forma_Pago_Otra, 
				   emba_Id, 
				   pais_Exportacion_Id, 
				   deva_Fecha_Exportacion, 
				   mone_Id, 
				   mone_Otra, 
				   deva_Conversion_Dolares, 
				   deva_Condiciones,
				   @deva_UsuarioModificacion,
				   @deva_FechaModificacion,
				   'Editar tab3'
			FROM [Adua].[tbDeclaraciones_Valor]
			WHERE deva_Id = @deva_Id

			SELECT 1
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbFacturas_Listar
	@deva_Id				INT
AS
BEGIN
	SELECT fact_Id, 
		   deva_Id, 
		   fact_Fecha, 
		   fact.usua_UsuarioCreacion, 
		   usuaCrea.usua_Nombre					AS usuarioCreacionNombre,
		   fact_FechaCreacion, 
		   fact.usua_UsuarioModificacion, 
		   usuaModifica.usua_Nombre				AS usuarioModificacionNombre,
		   fact_FechaModificacion, 
		   fact_Estado
	FROM [Adua].[tbFacturas] fact 
	INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON fact.usua_UsuarioCreacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaModifica  ON fact.usua_UsuarioModificacion = usuaModifica.usua_Id
	WHERE deva_Id = @deva_Id
END


GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbFacturas_Insertar
	@deva_Id					INT,
	@fact_Numero				NVARCHAR(4000),
	@fact_Fecha					DATE, 
	@usua_UsuarioCreacion		INT, 
	@fact_FechaCreacion			DATETIME
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO [Adua].[tbFacturas](deva_Id, 
										fact_Numero,
										fact_Fecha, 
										usua_UsuarioCreacion, 
										fact_FechaCreacion)
		VALUES(@deva_Id, 
			   @fact_Numero,
			   @fact_Fecha, 
			   @usua_UsuarioCreacion, 
			   @fact_FechaCreacion)

		SELECT SCOPE_IDENTITY()


		INSERT INTO [Adua].[tbFacturasHistorial](fact_Id, 
												 fact_Numero,
												 deva_Id, 
												 fect_Fecha, 
												 hfact_UsuarioAccion, 
												 hfact_FechaAccion, 
												 hfact_Accion)
		VALUES (SCOPE_IDENTITY(),
				@fact_Numero,
				@deva_Id, 
			    @fact_Fecha, 
			    @usua_UsuarioCreacion, 
			    @fact_FechaCreacion,
				'Insertar')

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH 
END

GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbFacturas_Editar
	@fact_Id					INT, 
	@fact_Numero				NVARCHAR(4000),
	@deva_Id					INT,
	@fact_Fecha					DATE, 
	@usua_UsuarioCreacion		INT, 
	@fact_FechaCreacion			DATETIME
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY

		UPDATE [Adua].[tbFacturas]
		SET   deva_Id = @deva_Id, 
		      fact_Numero = @fact_Numero,
			  fact_Fecha = @fact_Fecha, 
			  usua_UsuarioCreacion = @usua_UsuarioCreacion, 
			  fact_FechaCreacion = @fact_FechaCreacion
		WHERE fact_Id = @fact_Id


		INSERT INTO [Adua].[tbFacturasHistorial](fact_Id, 
												 fact_Numero,
												 deva_Id, 
												 fect_Fecha, 
												 hfact_UsuarioAccion, 
												 hfact_FechaAccion, 
												 hfact_Accion)
		VALUES (@fact_Id,
				@fact_Numero,
				@deva_Id, 
			    @fact_Fecha, 
			    @usua_UsuarioCreacion, 
			    @fact_FechaCreacion,
				'Editar')

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH 
END

GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbItems_Listar 
	@fact_Id				INT
AS
BEGIN
	SELECT item_Id, 
	       fact_Id, 
		   item_Cantidad, 
		   item_PesoNeto, 
		   item_PesoBruto, 
		   unme_Id, 
		   item_IdentificacionComercialMercancias, 
		   item_CaracteristicasMercancias, 
		   item_Marca, 
		   item_Modelo, 
		   merc_Id, 
		   pais_IdOrigenMercancia, 
		   item_ClasificacionArancelaria, 
		   item_ValorUnitario, 
		   item_GastosDeTransporte, 
		   item_ValorTransaccion, 
		   item_Seguro, 
		   item_OtrosGastos, 
		   item_ValorAduana, 
		   item_CuotaContingente, 
		   item_ReglasAccesorias, 
		   item_CriterioCertificarOrigen,
		   item.usua_UsuarioCreacion, 
		   usuaCrea.usua_Nombre					AS usuarioCreacionNombre,
		   item_FechaCreacion, 
		   item.usua_UsuarioModificacion, 
		   usuaModifica.usua_Nombre				AS usuarioModificacionNombre,
		   item_FechaModificacion, 
		   item_Estado
	FROM [Adua].[tbItems] item 
	INNER JOIN [Acce].[tbUsuarios] usuaCrea		ON item.usua_UsuarioCreacion = usuaCrea.usua_Id 
	LEFT JOIN [Acce].[tbUsuarios] usuaModifica  ON item.usua_UsuarioModificacion = usuaModifica.usua_Id
	WHERE fact_Id = @fact_Id
END


GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbItems_Insertar
	@fact_Id									INT, 
	@item_Cantidad								INT, 
	@item_PesoNeto								DECIMAL(18,2), 
	@item_PesoBruto								DECIMAL(18,2), 
	@unme_Id									INT, 
	@item_IdentificacionComercialMercancias		NVARCHAR(300), 
	@item_CaracteristicasMercancias				NVARCHAR(400), 
	@item_Marca									NVARCHAR(50), 
	@item_Modelo								NVARCHAR(100), 
	@merc_Id									INT, 
	@pais_IdOrigenMercancia						INT, 
	@item_ClasificacionArancelaria				CHAR(16), 
	@item_ValorUnitario							DECIMAL(18,2), 
	@item_GastosDeTransporte					DECIMAL(18,2), 
	@item_ValorTransaccion						DECIMAL(18,2), 
	@item_Seguro								DECIMAL(18,2), 
	@item_OtrosGastos							DECIMAL(18,2), 
	@item_ValorAduana							DECIMAL(18,2), 
	@item_CuotaContingente						DECIMAL(18,2), 
	@item_ReglasAccesorias						NVARCHAR(MAX), 
	@item_CriterioCertificarOrigen				NVARCHAR(MAX), 
	@usua_UsuarioCreacion						INT, 
	@item_FechaCreacion							DATETIME
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO [Adua].[tbItems](fact_Id, 
									 item_Cantidad, 
									 item_PesoNeto, 
									 item_PesoBruto, 
									 unme_Id, 
									 item_IdentificacionComercialMercancias, 
									 item_CaracteristicasMercancias, 
									 item_Marca, 
									 item_Modelo, 
									 merc_Id, 
									 pais_IdOrigenMercancia, 
									 item_ClasificacionArancelaria, 
									 item_ValorUnitario, 
									 item_GastosDeTransporte, 
									 item_ValorTransaccion, 
									 item_Seguro, 
									 item_OtrosGastos, 
									 item_ValorAduana, 
									 item_CuotaContingente, 
									 item_ReglasAccesorias, 
									 item_CriterioCertificarOrigen, 
									 usua_UsuarioCreacion, 
									 item_FechaCreacion)
		VALUES (@fact_Id, 
				@item_Cantidad, 
				@item_PesoNeto, 
				@item_PesoBruto, 
				@unme_Id, 
				@item_IdentificacionComercialMercancias, 
				@item_CaracteristicasMercancias, 
				@item_Marca, 
				@item_Modelo, 
				@merc_Id, 
				@pais_IdOrigenMercancia, 
				@item_ClasificacionArancelaria, 
				@item_ValorUnitario, 
				@item_GastosDeTransporte, 
				@item_ValorTransaccion, 
				@item_Seguro, 
				@item_OtrosGastos, 
				@item_ValorAduana, 
				@item_CuotaContingente, 
				@item_ReglasAccesorias, 
				@item_CriterioCertificarOrigen, 
				@usua_UsuarioCreacion, 
				@item_FechaCreacion)

		DECLARE @item_Id INT = SCOPE_IDENTITY()

		INSERT INTO [Adua].[tbItemsHistorial](item_Id, 
											  fact_Id, 
											  item_Cantidad, 
											  item_PesoNeto, 
											  item_PesoBruto, 
											  unme_Id, 
											  item_IdentificacionComercialMercancias, 
											  item_CaracteristicasMercancias, 
											  item_Marca, 
											  item_Modelo, 
											  merc_Id, 
											  pais_IdOrigenMercancia, 
											  item_ClasificacionArancelaria, 
											  item_ValorUnitario, 
											  item_GastosDeTransporte, 
											  item_ValorTransaccion, 
											  item_Seguro, 
											  item_OtrosGastos, 
											  item_ValorAduana, 
											  item_CuotaContingente, 
											  item_ReglasAccesorias, 
											  item_CriterioCertificarOrigen, 
											  hduc_UsuarioAccion, 
											  hduc_FechaAccion, 
											  hduc_Accion)

			VALUES (@item_Id, 
					@fact_Id, 
					@item_Cantidad, 
					@item_PesoNeto, 
					@item_PesoBruto, 
					@unme_Id, 
					@item_IdentificacionComercialMercancias, 
					@item_CaracteristicasMercancias, 
					@item_Marca, 
					@item_Modelo, 
					@merc_Id, 
					@pais_IdOrigenMercancia, 
					@item_ClasificacionArancelaria, 
					@item_ValorUnitario, 
					@item_GastosDeTransporte, 
					@item_ValorTransaccion, 
					@item_Seguro, 
					@item_OtrosGastos, 
					@item_ValorAduana, 
					@item_CuotaContingente, 
					@item_ReglasAccesorias, 
					@item_CriterioCertificarOrigen,
					@usua_UsuarioCreacion, 
					@item_FechaCreacion,
					'Insertar')

		SELECT 1

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END


GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbItems_Editar
	@item_Id									INT,
	@fact_Id									INT, 
	@item_Cantidad								INT, 
	@item_PesoNeto								DECIMAL(18,2), 
	@item_PesoBruto								DECIMAL(18,2), 
	@unme_Id									INT, 
	@item_IdentificacionComercialMercancias		NVARCHAR(300), 
	@item_CaracteristicasMercancias				NVARCHAR(400), 
	@item_Marca									NVARCHAR(50), 
	@item_Modelo								NVARCHAR(100), 
	@merc_Id									INT, 
	@pais_IdOrigenMercancia						INT, 
	@item_ClasificacionArancelaria				CHAR(16), 
	@item_ValorUnitario							DECIMAL(18,2), 
	@item_GastosDeTransporte					DECIMAL(18,2), 
	@item_ValorTransaccion						DECIMAL(18,2), 
	@item_Seguro								DECIMAL(18,2), 
	@item_OtrosGastos							DECIMAL(18,2), 
	@item_ValorAduana							DECIMAL(18,2), 
	@item_CuotaContingente						DECIMAL(18,2), 
	@item_ReglasAccesorias						NVARCHAR(MAX), 
	@item_CriterioCertificarOrigen				NVARCHAR(MAX), 
	@usua_UsuarioModificacion					INT, 
	@item_FechaModificacion						DATETIME
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		
		UPDATE [Adua].[tbItems]
		SET fact_Id = @fact_Id, 
			item_Cantidad = @item_Cantidad, 
			item_PesoNeto = @item_PesoNeto, 
			item_PesoBruto = @item_PesoBruto, 
			unme_Id = @unme_Id, 
			item_IdentificacionComercialMercancias = @item_IdentificacionComercialMercancias, 
			item_CaracteristicasMercancias = @item_CaracteristicasMercancias, 
			item_Marca = @item_Marca, 
			item_Modelo = @item_Modelo, 
			merc_Id = @merc_Id, 
			pais_IdOrigenMercancia = @pais_IdOrigenMercancia, 
			item_ClasificacionArancelaria = @item_ClasificacionArancelaria, 
			item_ValorUnitario = @item_ValorUnitario, 
			item_GastosDeTransporte = @item_GastosDeTransporte, 
			item_ValorTransaccion = @item_ValorTransaccion, 
			item_Seguro = @item_Seguro, 
			item_OtrosGastos = @item_OtrosGastos, 
			item_ValorAduana = @item_ValorAduana, 
			item_CuotaContingente = @item_CuotaContingente, 
			item_ReglasAccesorias = @item_ReglasAccesorias, 
			item_CriterioCertificarOrigen = @item_CriterioCertificarOrigen, 
			usua_UsuarioModificacion = @usua_UsuarioModificacion, 
			item_FechaModificacion = @item_FechaModificacion
		WHERE item_Id = @item_Id

		INSERT INTO [Adua].[tbItemsHistorial](item_Id, 
											  fact_Id, 
											  item_Cantidad, 
											  item_PesoNeto, 
											  item_PesoBruto, 
											  unme_Id, 
											  item_IdentificacionComercialMercancias, 
											  item_CaracteristicasMercancias, 
											  item_Marca, 
											  item_Modelo, 
											  merc_Id, 
											  pais_IdOrigenMercancia, 
											  item_ClasificacionArancelaria, 
											  item_ValorUnitario, 
											  item_GastosDeTransporte, 
											  item_ValorTransaccion, 
											  item_Seguro, 
											  item_OtrosGastos, 
											  item_ValorAduana, 
											  item_CuotaContingente, 
											  item_ReglasAccesorias, 
											  item_CriterioCertificarOrigen, 
											  hduc_UsuarioAccion, 
											  hduc_FechaAccion, 
											  hduc_Accion)

			VALUES (@item_Id, 
					@fact_Id, 
					@item_Cantidad, 
					@item_PesoNeto, 
					@item_PesoBruto, 
					@unme_Id, 
					@item_IdentificacionComercialMercancias, 
					@item_CaracteristicasMercancias, 
					@item_Marca, 
					@item_Modelo, 
					@merc_Id, 
					@pais_IdOrigenMercancia, 
					@item_ClasificacionArancelaria, 
					@item_ValorUnitario, 
					@item_GastosDeTransporte, 
					@item_ValorTransaccion, 
					@item_Seguro, 
					@item_OtrosGastos, 
					@item_ValorAduana, 
					@item_CuotaContingente, 
					@item_ReglasAccesorias, 
					@item_CriterioCertificarOrigen,
					@usua_UsuarioModificacion, 
					@item_FechaModificacion,
					'Editar')

		SELECT 1

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END


GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbBaseCalculos_Listar
	@deva_Id			INT
AS
BEGIN
	SELECT base_Id, 
		   deva_Id, 
		   base_PrecioFactura, 
		   base_PagosIndirectos, 
		   base_PrecioReal, 
		   base_MontCondicion, 
		   base_MontoReversion, 
		   base_ComisionCorrelaje,
		   base_Gasto_Envase_Embalaje, 
		   base_ValoresMateriales_Incorporado, 
		   base_Valor_Materiales_Utilizados, 
		   base_Valor_Materiales_Consumidos, 
		   base_Valor_Ingenieria_Importado, 
		   base_Valor_Canones, 
		   base_Gasto_TransporteM_Importada, 
		   base_Gastos_Carga_Importada, 
		   base_Costos_Seguro, 
		   base_Total_Ajustes_Precio_Pagado, 
		   base_Gastos_Asistencia_Tecnica, 
		   base_Gastos_Transporte_Posterior,
		   base_Derechos_Impuestos, 
		   base_Monto_Intereses, 
		   base_Deducciones_Legales, 
		   base_Total_Deducciones_Precio, 
		   base_Valor_Aduana, 
		   usua_UsuarioCreacion, 
		   base_FechaCreacion, 
		   usua_UsuarioModificacion, 
		   base_FechaModificacion
	FROM [Adua].[tbBaseCalculos]
	WHERE deva_Id = @deva_Id
END

GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbBaseCalculos_Insertar 
	@deva_Id								INT, 
	@base_PrecioFactura						DECIMAL(18,2), 
	@base_PagosIndirectos					DECIMAL(18,2), 
	@base_PrecioReal						DECIMAL(18,2), 
	@base_MontCondicion						DECIMAL(18,2), 
	@base_MontoReversion					DECIMAL(18,2), 
	@base_ComisionCorrelaje					DECIMAL(18,2),
	@base_Gasto_Envase_Embalaje				DECIMAL(18,2), 
	@base_ValoresMateriales_Incorporado		DECIMAL(18,2), 
	@base_Valor_Materiales_Utilizados		DECIMAL(18,2), 
	@base_Valor_Materiales_Consumidos		DECIMAL(18,2), 
	@base_Valor_Ingenieria_Importado		DECIMAL(18,2), 
	@base_Valor_Canones						DECIMAL(18,2), 
	@base_Gasto_TransporteM_Importada		DECIMAL(18,2), 
	@base_Gastos_Carga_Importada			DECIMAL(18,2), 
	@base_Costos_Seguro						DECIMAL(18,2), 
	@base_Total_Ajustes_Precio_Pagado		DECIMAL(18,2), 
	@base_Gastos_Asistencia_Tecnica			DECIMAL(18,2),
	@base_Gastos_Transporte_Posterior		DECIMAL(18,2),
	@base_Derechos_Impuestos				DECIMAL(18,2), 
	@base_Monto_Intereses					DECIMAL(18,2), 
	@base_Deducciones_Legales				DECIMAL(18,2), 
	@base_Total_Deducciones_Precio			DECIMAL(18,2), 
	@base_Valor_Aduana						DECIMAL(18,2), 
	@usua_UsuarioCreacion					INT, 
	@base_FechaCreacion						DATETIME
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO [Adua].[tbBaseCalculos](deva_Id, 
											base_PrecioFactura, 
											base_PagosIndirectos, 
											base_PrecioReal, 
											base_MontCondicion, 
											base_MontoReversion, 
											base_ComisionCorrelaje, 
											base_Gasto_Envase_Embalaje, 
											base_ValoresMateriales_Incorporado, 
											base_Valor_Materiales_Utilizados, 
											base_Valor_Materiales_Consumidos, 
											base_Valor_Ingenieria_Importado, 
											base_Valor_Canones, 
											base_Gasto_TransporteM_Importada, 
											base_Gastos_Carga_Importada, 
											base_Costos_Seguro, 
											base_Total_Ajustes_Precio_Pagado, 
											base_Gastos_Asistencia_Tecnica, 
											base_Gastos_Transporte_Posterior, 
											base_Derechos_Impuestos, 
											base_Monto_Intereses, 
											base_Deducciones_Legales, 
											base_Total_Deducciones_Precio, 
											base_Valor_Aduana, 
											usua_UsuarioCreacion, 
											base_FechaCreacion)
		VALUES (@deva_Id, 
				@base_PrecioFactura, 
				@base_PagosIndirectos, 
				@base_PrecioReal, 
				@base_MontCondicion, 
				@base_MontoReversion, 
				@base_ComisionCorrelaje, 
				@base_Gasto_Envase_Embalaje, 
				@base_ValoresMateriales_Incorporado, 
				@base_Valor_Materiales_Utilizados, 
				@base_Valor_Materiales_Consumidos, 
				@base_Valor_Ingenieria_Importado, 
				@base_Valor_Canones, 
				@base_Gasto_TransporteM_Importada, 
				@base_Gastos_Carga_Importada, 
				@base_Costos_Seguro, 
				@base_Total_Ajustes_Precio_Pagado, 
				@base_Gastos_Asistencia_Tecnica, 
				@base_Gastos_Transporte_Posterior, 
				@base_Derechos_Impuestos, 
				@base_Monto_Intereses, 
				@base_Deducciones_Legales, 
				@base_Total_Deducciones_Precio, 
				@base_Valor_Aduana, 
				@usua_UsuarioCreacion, 
				@base_FechaCreacion)

		INSERT INTO [Adua].[tbBaseCalculosHistorial](base_Id,
													 deva_Id, 
													 base_PrecioFactura, 
													 base_PagosIndirectos, 
													 base_PrecioReal, 
													 base_MontCondicion, 
													 base_MontoReversion, 
													 base_ComisionCorrelaje, 
													 base_Gasto_Envase_Embalaje, 
													 base_ValoresMateriales_Incorporado, 
													 base_Valor_Materiales_Utilizados, 
													 base_Valor_Materiales_Consumidos, 
													 base_Valor_Ingenieria_Importado, 
													 base_Valor_Canones, 
													 base_Gasto_TransporteM_Importada, 
													 base_Gastos_Carga_Importada, 
													 base_Costos_Seguro, 
													 base_Total_Ajustes_Precio_Pagado, 
													 base_Gastos_Asistencia_Tecnica, 
													 base_Gastos_Transporte_Posterior, 
													 base_Derechos_Impuestos, 
													 base_Monto_Intereses, 
													 base_Deducciones_Legales, 
													 base_Total_Deducciones_Precio, 
													 base_Valor_Aduana, 
													 hbas_UsuarioAccion,
													 hbas_FechaAccion,
													 hbas_Accion)
		VALUES (SCOPE_IDENTITY(),
				@deva_Id, 
				@base_PrecioFactura, 
				@base_PagosIndirectos, 
				@base_PrecioReal, 
				@base_MontCondicion, 
				@base_MontoReversion, 
				@base_ComisionCorrelaje, 
				@base_Gasto_Envase_Embalaje, 
				@base_ValoresMateriales_Incorporado, 
				@base_Valor_Materiales_Utilizados, 
				@base_Valor_Materiales_Consumidos, 
				@base_Valor_Ingenieria_Importado, 
				@base_Valor_Canones, 
				@base_Gasto_TransporteM_Importada, 
				@base_Gastos_Carga_Importada, 
				@base_Costos_Seguro, 
				@base_Total_Ajustes_Precio_Pagado, 
				@base_Gastos_Asistencia_Tecnica, 
				@base_Gastos_Transporte_Posterior, 
				@base_Derechos_Impuestos, 
				@base_Monto_Intereses, 
				@base_Deducciones_Legales, 
				@base_Total_Deducciones_Precio, 
				@base_Valor_Aduana, 
				@usua_UsuarioCreacion, 
				@base_FechaCreacion,
				'Insertar')

		SELECT 1

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbBaseCalculos_Editar 
	@base_Id								INT,
	@deva_Id								INT, 
	@base_PrecioFactura						DECIMAL(18,2), 
	@base_PagosIndirectos					DECIMAL(18,2), 
	@base_PrecioReal						DECIMAL(18,2), 
	@base_MontCondicion						DECIMAL(18,2), 
	@base_MontoReversion					DECIMAL(18,2), 
	@base_ComisionCorrelaje					DECIMAL(18,2),
	@base_Gasto_Envase_Embalaje				DECIMAL(18,2), 
	@base_ValoresMateriales_Incorporado		DECIMAL(18,2), 
	@base_Valor_Materiales_Utilizados		DECIMAL(18,2), 
	@base_Valor_Materiales_Consumidos		DECIMAL(18,2), 
	@base_Valor_Ingenieria_Importado		DECIMAL(18,2), 
	@base_Valor_Canones						DECIMAL(18,2), 
	@base_Gasto_TransporteM_Importada		DECIMAL(18,2), 
	@base_Gastos_Carga_Importada			DECIMAL(18,2), 
	@base_Costos_Seguro						DECIMAL(18,2), 
	@base_Total_Ajustes_Precio_Pagado		DECIMAL(18,2), 
	@base_Gastos_Asistencia_Tecnica			DECIMAL(18,2),
	@base_Gastos_Transporte_Posterior		DECIMAL(18,2),
	@base_Derechos_Impuestos				DECIMAL(18,2), 
	@base_Monto_Intereses					DECIMAL(18,2), 
	@base_Deducciones_Legales				DECIMAL(18,2), 
	@base_Total_Deducciones_Precio			DECIMAL(18,2), 
	@base_Valor_Aduana						DECIMAL(18,2), 
	@usua_UsuarioModificacion				INT, 
	@base_FechaModificacion					DATE
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		UPDATE [Adua].[tbBaseCalculos]
		SET		deva_Id = @deva_Id, 
				base_PrecioFactura = @base_PrecioFactura, 
				base_PagosIndirectos = @base_PagosIndirectos, 
				base_PrecioReal = @base_PrecioReal, 
				base_MontCondicion = @base_MontCondicion, 
				base_MontoReversion = @base_MontoReversion, 
				base_ComisionCorrelaje = @base_ComisionCorrelaje, 
				base_Gasto_Envase_Embalaje = @base_Gasto_Envase_Embalaje, 
				base_ValoresMateriales_Incorporado = @base_ValoresMateriales_Incorporado, 
				base_Valor_Materiales_Utilizados = @base_Valor_Materiales_Utilizados, 
				base_Valor_Materiales_Consumidos = @base_Valor_Materiales_Consumidos, 
				base_Valor_Ingenieria_Importado = @base_Valor_Ingenieria_Importado, 
				base_Valor_Canones = @base_Valor_Canones, 
				base_Gasto_TransporteM_Importada = @base_Gasto_TransporteM_Importada, 
				base_Gastos_Carga_Importada = @base_Gastos_Carga_Importada, 
				base_Costos_Seguro = @base_Costos_Seguro, 
				base_Total_Ajustes_Precio_Pagado = @base_Total_Ajustes_Precio_Pagado, 
				base_Gastos_Asistencia_Tecnica = @base_Gastos_Asistencia_Tecnica, 
				base_Gastos_Transporte_Posterior = @base_Gastos_Transporte_Posterior, 
				base_Derechos_Impuestos = @base_Derechos_Impuestos, 
				base_Monto_Intereses = @base_Monto_Intereses, 
				base_Deducciones_Legales = @base_Deducciones_Legales, 
				base_Total_Deducciones_Precio = @base_Total_Deducciones_Precio, 
				base_Valor_Aduana = @base_Valor_Aduana, 
				usua_UsuarioModificacion = @usua_UsuarioModificacion, 
				base_FechaModificacion = @base_FechaModificacion
		WHERE base_Id = @base_Id

		INSERT INTO [Adua].[tbBaseCalculosHistorial](base_Id,
													 deva_Id, 
													 base_PrecioFactura, 
													 base_PagosIndirectos, 
													 base_PrecioReal, 
													 base_MontCondicion, 
													 base_MontoReversion, 
													 base_ComisionCorrelaje, 
													 base_Gasto_Envase_Embalaje, 
													 base_ValoresMateriales_Incorporado, 
													 base_Valor_Materiales_Utilizados, 
													 base_Valor_Materiales_Consumidos, 
													 base_Valor_Ingenieria_Importado, 
													 base_Valor_Canones, 
													 base_Gasto_TransporteM_Importada, 
													 base_Gastos_Carga_Importada, 
													 base_Costos_Seguro, 
													 base_Total_Ajustes_Precio_Pagado, 
													 base_Gastos_Asistencia_Tecnica, 
													 base_Gastos_Transporte_Posterior, 
													 base_Derechos_Impuestos, 
													 base_Monto_Intereses, 
													 base_Deducciones_Legales, 
													 base_Total_Deducciones_Precio, 
													 base_Valor_Aduana, 
													 hbas_UsuarioAccion,
													 hbas_FechaAccion,
													 hbas_Accion)
		VALUES (@base_Id,
				@deva_Id, 
				@base_PrecioFactura, 
				@base_PagosIndirectos, 
				@base_PrecioReal, 
				@base_MontCondicion, 
				@base_MontoReversion, 
				@base_ComisionCorrelaje, 
				@base_Gasto_Envase_Embalaje, 
				@base_ValoresMateriales_Incorporado, 
				@base_Valor_Materiales_Utilizados, 
				@base_Valor_Materiales_Consumidos, 
				@base_Valor_Ingenieria_Importado, 
				@base_Valor_Canones, 
				@base_Gasto_TransporteM_Importada, 
				@base_Gastos_Carga_Importada, 
				@base_Costos_Seguro, 
				@base_Total_Ajustes_Precio_Pagado, 
				@base_Gastos_Asistencia_Tecnica, 
				@base_Gastos_Transporte_Posterior, 
				@base_Derechos_Impuestos, 
				@base_Monto_Intereses, 
				@base_Deducciones_Legales, 
				@base_Total_Deducciones_Precio, 
				@base_Valor_Aduana, 
				@usua_UsuarioModificacion, 
				@base_FechaModificacion,
				'Editar')

		SELECT 1

		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END

GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbDeclaraciones_Valor_Eliminar
	@deva_Id					INT,
	@usua_UsuarioEliminacion	INT,
	@deva_FechaEliminacion		DATETIME
AS
BEGIN
	BEGIN TRANSACTION 
	BEGIN TRY
		INSERT INTO [Adua].[tbBaseCalculosHistorial](base_Id, 
													 deva_Id, 
													 base_PrecioFactura, 
													 base_PagosIndirectos, 
													 base_PrecioReal, 
													 base_MontCondicion, 
													 base_MontoReversion, 
													 base_ComisionCorrelaje, 
													 base_Gasto_Envase_Embalaje, 
													 base_ValoresMateriales_Incorporado, 
													 base_Valor_Materiales_Utilizados, 
													 base_Valor_Materiales_Consumidos, 
													 base_Valor_Ingenieria_Importado, 
													 base_Valor_Canones, 
													 base_Gasto_TransporteM_Importada, 
													 base_Gastos_Carga_Importada, 
													 base_Costos_Seguro, 
													 base_Total_Ajustes_Precio_Pagado, 
													 base_Gastos_Asistencia_Tecnica, 
													 base_Gastos_Transporte_Posterior, 
													 base_Derechos_Impuestos, 
													 base_Monto_Intereses, 
													 base_Deducciones_Legales, 
													 base_Total_Deducciones_Precio, 
													 base_Valor_Aduana, 
													 hbas_UsuarioAccion, 
													 hbas_FechaAccion, 
													 hbas_Accion)
			SELECT base_Id, 
				   deva_Id, 
				   base_PrecioFactura, 
				   base_PagosIndirectos, 
				   base_PrecioReal, 
				   base_MontCondicion, 
				   base_MontoReversion, 
				   base_ComisionCorrelaje, 
				   base_Gasto_Envase_Embalaje, 
				   base_ValoresMateriales_Incorporado, 
				   base_Valor_Materiales_Utilizados, 
				   base_Valor_Materiales_Consumidos, 
				   base_Valor_Ingenieria_Importado, 
				   base_Valor_Canones, 
				   base_Gasto_TransporteM_Importada, 
				   base_Gastos_Carga_Importada, 
				   base_Costos_Seguro, 
				   base_Total_Ajustes_Precio_Pagado, 
				   base_Gastos_Asistencia_Tecnica, 
				   base_Gastos_Transporte_Posterior, 
				   base_Derechos_Impuestos, 
				   base_Monto_Intereses, 
				   base_Deducciones_Legales, 
				   base_Total_Deducciones_Precio, 
				   base_Valor_Aduana,
				   @usua_UsuarioEliminacion,
				   @deva_FechaEliminacion,
				   'Eliminar'
			FROM [Adua].[tbBaseCalculos]
			WHERE deva_Id = @deva_Id

		DELETE [Adua].[tbBaseCalculos]
		WHERE deva_Id =  @deva_Id
		
-------------------------------------------------------------------------------------	
		INSERT INTO [Adua].[tbCondicionesHistorial](codi_Id, 
													deva_Id, 
													codi_Restricciones_Utilizacion, 
													codi_Indicar_Restricciones_Utilizacion, 
													codi_Depende_Precio_Condicion, 
													codi_Indicar_Existe_Condicion, 
													codi_Condicionada_Revertir, 
													codi_Vinculacion_Comprador_Vendedor, 
													codi_Tipo_Vinculacion, 
													codi_Vinculacion_Influye_Precio, 
													codi_Pagos_Descuentos_Indirectos, 
													codi_Concepto_Monto_Declarado, 
													codi_Existen_Canones, 
													codi_Indicar_Canones,
													hcod_UsuarioAccion, 
													hcod_FechaAccion, 
													hcod_Accion)
		SELECT codi_Id, 
			   deva_Id, 
			   codi_Restricciones_Utilizacion, 
			   codi_Indicar_Restricciones_Utilizacion, 
			   codi_Depende_Precio_Condicion, 
			   codi_Indicar_Existe_Condicion, 
			   codi_Condicionada_Revertir, 
			   codi_Vinculacion_Comprador_Vendedor, 
			   codi_Tipo_Vinculacion, 
			   codi_Vinculacion_Influye_Precio, 
			   codi_Pagos_Descuentos_Indirectos, 
			   codi_Concepto_Monto_Declarado, 
			   codi_Existen_Canones, 
			   codi_Indicar_Canones, 
			   @usua_UsuarioEliminacion,
			   @deva_FechaEliminacion,
			   'Eliminar'
		FROM [Adua].[tbCondiciones]
		WHERE deva_Id = @deva_Id

		DELETE [Adua].[tbCondiciones]
		WHERE deva_Id = @deva_Id
		
-------------------------------------------------------------------------------------	
		DECLARE @fact_Id INT = (SELECT fact_Id
								FROM [Adua].[tbFacturas]
								WHERE deva_Id = @deva_Id)

		INSERT INTO [Adua].[tbItemsHistorial](item_Id, 
											  fact_Id, 
											  item_Cantidad, 
											  item_PesoNeto, 
											  item_PesoBruto, 
											  unme_Id, 
											  item_IdentificacionComercialMercancias, 
											  item_CaracteristicasMercancias, 
											  item_Marca, 
											  item_Modelo, 
											  merc_Id, 
											  pais_IdOrigenMercancia, 
											  item_ClasificacionArancelaria, 
											  item_ValorUnitario, 
											  item_GastosDeTransporte, 
											  item_ValorTransaccion, 
											  item_Seguro, 
											  item_OtrosGastos, 
											  item_ValorAduana, 
											  item_CuotaContingente, 
											  item_ReglasAccesorias, 
											  item_CriterioCertificarOrigen, 
											  hduc_UsuarioAccion, 
											  hduc_FechaAccion, 
											  hduc_Accion)
		SELECT item_Id, 
			   fact_Id, 
			   item_Cantidad, 
			   item_PesoNeto, 
			   item_PesoBruto, 
			   unme_Id, 
			   item_IdentificacionComercialMercancias, 
			   item_CaracteristicasMercancias, 
			   item_Marca, 
			   item_Modelo, 
			   merc_Id, 
			   pais_IdOrigenMercancia, 
			   item_ClasificacionArancelaria, 
			   item_ValorUnitario, 
			   item_GastosDeTransporte, 
			   item_ValorTransaccion, 
			   item_Seguro, 
			   item_OtrosGastos, 
			   item_ValorAduana, 
			   item_CuotaContingente, 
			   item_ReglasAccesorias, 
			   item_CriterioCertificarOrigen, 
			   @usua_UsuarioEliminacion,
			   @deva_FechaEliminacion,
			   'Eliminar'
		FROM [Adua].[tbItems]
		WHERE fact_Id = @fact_Id


		DELETE [Adua].[tbItems]
		WHERE fact_Id = @fact_Id

-------------------------------------------------------------------------------------		
		INSERT INTO [Adua].[tbFacturasHistorial](fact_Id, 
												 deva_Id, 
												 fect_Fecha, 
												 hfact_UsuarioAccion, 
												 hfact_FechaAccion, 
												 hfact_Accion)
		SELECT fact_Id, 
			   deva_Id, 
			   fact_Fecha, 
			   @usua_UsuarioEliminacion,
			   @deva_FechaEliminacion,
			   'Eliminar'
		FROM [Adua].[tbFacturas]
		WHERE deva_Id = @deva_Id

		DELETE [Adua].[tbFacturas]
		WHERE deva_Id = @deva_Id
		
-------------------------------------------------------------------------------------	
		INSERT INTO [Adua].[tbDeclaraciones_ValorHistorial](deva_Id, 
															deva_Aduana_Ingreso_Id, 
															deva_Aduana_Despacho_Id, 
															deva_Declaracion_Mercancia, 
															deva_Fecha_Aceptacion, 
															impo_Id, 
															pvde_Id, 
															inte_Id, 
															deva_Lugar_Entrega, 
															pais_Entrega_Id,
															inco_Id, 
															inco_Version,
															deva_numero_contrato, 
															deva_Fecha_Contrato, 
															foen_Id, 
															deva_Forma_Envio_Otra, 
															deva_Pago_Efectuado, 
															fopa_Id, 
															deva_Forma_Pago_Otra, 
															emba_Id, 
															pais_Exportacion_Id, 
															deva_Fecha_Exportacion, 
															mone_Id, 
															mone_Otra, 
															deva_Conversion_Dolares, 
															deva_Condiciones, 
															hdev_UsuarioAccion, 
															hdev_FechaAccion, 
															hdev_Accion)
		SELECT deva_Id, 
			   deva_Aduana_Ingreso_Id, 
			   deva_Aduana_Despacho_Id, 
			   deva_Declaracion_Mercancia, 
			   deva_Fecha_Aceptacion, 
			   impo_Id, 
			   pvde_Id, 
			   inte_Id, 
			   deva_Lugar_Entrega, 
			   pais_Entrega_Id, 
			   inco_Id, 
			   inco_Version, 
			   deva_numero_contrato, 
			   deva_Fecha_Contrato, 
			   foen_Id, 
			   deva_Forma_Envio_Otra, 
			   deva_Pago_Efectuado, 
			   fopa_Id, 
			   deva_Forma_Pago_Otra, 
			   emba_Id, 
			   pais_Exportacion_Id, 
			   deva_Fecha_Exportacion, 
			   mone_Id, 
			   mone_Otra, 
			   deva_Conversion_Dolares, 
			   deva_Condiciones,
			   @usua_UsuarioEliminacion,
			   @deva_FechaEliminacion,
			   'Eliminar'
		FROM [Adua].[tbDeclaraciones_Valor]
		WHERE deva_Id = @deva_Id

		DELETE [Adua].[tbDeclaraciones_Valor]
		WHERE deva_Id = @deva_Id

		SELECT 1
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
		ROLLBACK TRAN
	END CATCH
END
	
--IF NOT EXISTS ((select [deva_Id], [deva_AduanaIngresoId], [deva_DeclaracionMercancia] 
--				from [Adua].[tbDeclaraciones_Valor] 
--				EXCEPT select [deva_Id], [deva_AduanaIngresoId], [deva_DeclaracionMercancia] 
--				from [Adua].[tbDeclaraciones_ValorHistorial]))
		
--	BEGIN
--		SELECT 'son iguales papá'
--	END 
--	ELSE 
--		SELECT 'NO ESTÁN IGUALES'

--UNION ALL
--(select [deva_Id], [deva_AduanaIngresoId], [deva_DeclaracionMercancia] from [Adua].[tbDeclaraciones_ValorHistorial] EXCEPT select [deva_Id], [deva_AduanaIngresoId], [deva_DeclaracionMercancia] from [Adua].[tbDeclaraciones_Valor])

--EXEC adua.UDP_tbDeclaraciones_Valor_Tab1_Insertar 10, 5, '2023-07-12', 'rtrtrtyrty', '0501-2005-010101', '05012005632458', 'dirección perrona', 2, 'empresa@empresa.com', '85478965', NULL, 2, null, 1, '10-16-2004'
--GO

--EXEC adua.UDP_tbDeclaraciones_Valor_Tab2_Insertar 1, 'OTRA RAZÓN WTF', 'HOGAR DULCE HOGAR', 3, 'asjds@sdl.com', '45874589', null, '1',2, null, 'MÁS NOMBRES WN', 'CASA EVERYWHERE', 2, 'ASD@MSD.COM', '5874786554', null, '2 ',1, null, 1, '2023-07-20'

--GO

--GO
--EXEC adua.UDP_tbDeclaraciones_Valor_Tab3_Insertar 1, 'lolol' , 2, 2, '??', null, '2023-03-01', 2, null, 1, 6, null, 1, 10, '2023-05-02', 5, null, null, 1, '2023-07-22 22:59:01'

--EXEC Adua.UDP_tbFacturas_Insertar 1, '2023-05-21', 1, '2023-07-23 01:11:45'
--EXEC Adua.UDP_tbItems_Insertar 1, 4, 25, 28, 4, 'IDENTIFICACIÓN NI IDEA DE QUIÉN SOS', 'CARACTERÍSTICAS DE MI PRODUCTO UWUWUW CARACARACRACARA', 'NISSAN', 'VALOLOL', 2, 25, '123.324.24.255.1', 451.15, null, null, null, null, null, null, null, null, 1, '2023-07-23 01:11:45'
--EXEC Adua.UDP_tbItems_Editar 1, 1, 4, 25, 28, 4, 'PIPIPIPI', 'EDITANDO TODO PAPÁ', 'O CHEVROLET?', 'LOLSIOTO', 1, 42, '723.324.24.255.1', 485, 4582, 1111, null, 222, 5555, 145, 25, null, 1, '2023-07-23 01:11:45'
--EXEC Adua.UDP_tbCondiciones_Insertar 1, 1, 'texto??', 0, null, 1, 1, 'jrjj', 0, 0, null, 0, null, 1, '2023-07-23 17:14:45'
--EXEC Adua.UDP_tbCondiciones_Editar 1, 1, 0, null, 1, 'SDDFG', 0, 0, null, 1, 1, 'hola', 1, 'adios', 1, '2023-07-23 17:14:45'
--GO
--EXEC Adua.UDP_tbBaseCalculos_Insertar 1, 487.25, 0, 487.25, 0, 0, 0, 45, 0, 0, 78, 98, 0, 0, 0, 12, 32, 0, 41, 0, 0, 0, 0, 0, 1, '2023-07-24 10:57'
--EXEC Adua.UDP_tbBaseCalculos_Editar 1, 1, 0, 487.25, 0, 487.25, 4445, 85, 0, 74, 72, 0, 0, 78, 487.25, 487.25, 0, 0, 45, 0, 8, 45, 78, 25, 14, 1, '2023-07-24 10:57'

--EXEC Adua.UDP_tbDeclaraciones_Valor_Tab1_Editar 1, 5, 4, '2023-10-12', 'NOMBRE DE RAZÓN JAJA NO SÉ XD EDITADA', 
--												'0501-2005-632458', '05012005632458', 'dirección perrona pero editada', 2, 'empresa@empresa.com editada', 
--												'85478965', 'uy', 2, 'ay', 1, '2023-07-24'

--EXEC adua.UDP_tbDeclaraciones_Valor_Tab2_Editar 1, 'OTRA RAZÓN WTF editadita', 'HOGAR DULCE HOGAR uwuwu', 
--												2, 'asjds@sdl.com edit', '45874589', 'owo', 2, 'uwu', 'MÁS NOMBRES WN edit', 
--												'CASA EVERYWHERE edit', 2, 'ASD@MSD.COM edit', '5874786554', 'jeje', 1, 'jij', 1, '2023-07-20'
--GO
--EXEC adua.UDP_tbDeclaraciones_Valor_Tab3_Editar 1, 'lolol editado también' , 4, 3, '!?', 'iii', '2023-03-01', 3, 'cómo', 1, 6, 'aaa', 1, 10, 
--													'2023-05-02', 5, 'sdf', 45.3, 1, '2023-07-24 10:51:01'

--EXEC Adua.UDP_tbDeclaraciones_Valor_Eliminar 1, 1, '2023-07-24 11:09:45'
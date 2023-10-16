USE SIMEXPRO
GO
------------------------------------ [Adua].[tbEcotasa] ------------------------------------ 
--- Listar
CREATE OR ALTER PROCEDURE Adua.UDP_tbEcotasa_Listar
AS
BEGIN
	SELECT 
			ecot.[ecot_Id], 
			ecot.[ecot_RangoIncial], 
			ecot.[ecot_RangoFinal], 
			ecot.[ecot_CantidadPagar], 

			usuaCrea.usua_Nombre AS usua_UsuarioCreacionNombre,
			ecot.[usua_UsuarioCreacion], 
			ecot.[ecot_FechaCreacion], 

			usuaModifica.usua_Nombre AS usua_UsuarioModificacionNombre,
			ecot.[usua_UsuarioModificacion], 
			ecot.[ecot_FechaModificacion]
	FROM Adua.tbEcotasa AS ecot
	INNER JOIN Acce.tbUsuarios AS usuaCrea ON ecot.usua_UsuarioCreacion = usuaCrea.usua_Id
	LEFT JOIN Acce.tbUsuarios AS usuaModifica ON ecot.usua_UsuarioModificacion = usuaModifica.usua_Id
	ORDER BY ecot_FechaCreacion ASC
END
GO




--- Insertar
CREATE OR ALTER PROCEDURE Adua.UDP_tbEcotasa_Insertar --11, 19, 5, 1, '10-12-2023'
	@ecot_RangoIncial		DECIMAL(18,2), 
	@ecot_RangoFinal		DECIMAL(18,2),
	@ecot_CantidadPagar		DECIMAL(18,2),  
	@usua_UsuarioCreacion	INT, 
	@ecot_FechaCreacion		DATETIME
AS
BEGIN
	BEGIN TRY	

		IF	(@ecot_RangoIncial IN (SELECT ecot_RangoIncial FROM Adua.tbEcotasa) AND @ecot_RangoFinal IN (SELECT ecot_RangoFinal FROM Adua.tbEcotasa))
			BEGIN
				SELECT 0
			END
		ELSE
			BEGIN
				IF EXISTS (SELECT * FROM Adua.tbEcotasa WHERE @ecot_RangoIncial BETWEEN ecot_RangoIncial AND ecot_RangoFinal) AND EXISTS (SELECT * FROM Adua.tbEcotasa WHERE @ecot_RangoFinal BETWEEN ecot_RangoIncial AND ecot_RangoFinal) 
					BEGIN
						SELECT 2
					END
				ELSE
					BEGIN
						INSERT INTO Adua.tbEcotasa ([ecot_RangoIncial], [ecot_RangoFinal], [ecot_CantidadPagar], [usua_UsuarioCreacion], [ecot_FechaCreacion])
						VALUES(@ecot_RangoIncial, @ecot_RangoFinal, @ecot_CantidadPagar, @usua_UsuarioCreacion, @ecot_FechaCreacion)
						SELECT 1
					END
			END
	END TRY
	BEGIN CATCH 
		SELECT 'Error Message: ' + ERROR_MESSAGE() 
	END CATCH
END
GO



--- Editar
CREATE OR ALTER PROCEDURE Adua.UDP_tbEcotasa_Editar --3, 16666.01, 18000, 10000, 1, '10-13-2023'
	@ecot_Id					INT,
	@ecot_RangoIncial			DECIMAL(18,2), 
	@ecot_RangoFinal			DECIMAL(18,2),
	@ecot_CantidadPagar			DECIMAL(18,2), 
	@usua_UsuarioModificacion	INT, 
	@ecot_FechaModificacion		DATETIME
AS
BEGIN
	BEGIN TRY

		IF EXISTS (SELECT * FROM Adua.tbEcotasa WHERE ecot_Id = @ecot_Id AND ecot_RangoIncial = @ecot_RangoIncial AND ecot_RangoFinal = @ecot_RangoFinal)
			BEGIN
				UPDATE Adua.tbEcotasa
				SET ecot_RangoIncial = @ecot_RangoIncial, 
					ecot_RangoFinal = @ecot_RangoFinal, 
					ecot_CantidadPagar = @ecot_CantidadPagar, 
					usua_UsuarioModificacion = @usua_UsuarioModificacion, 
					ecot_FechaModificacion = @ecot_FechaModificacion
				WHERE ecot_Id = @ecot_Id
				
				SELECT 1
			END
		ELSE
			BEGIN
				IF	(@ecot_RangoIncial IN (SELECT ecot_RangoIncial FROM Adua.tbEcotasa) AND @ecot_RangoFinal IN (SELECT ecot_RangoFinal FROM Adua.tbEcotasa))	
					BEGIN
						SELECT 0
					END
				ELSE
					BEGIN
						IF EXISTS (SELECT * FROM Adua.tbEcotasa WHERE @ecot_RangoIncial BETWEEN ecot_RangoIncial AND ecot_RangoFinal) AND EXISTS (SELECT * FROM Adua.tbEcotasa WHERE @ecot_RangoFinal BETWEEN ecot_RangoIncial AND ecot_RangoFinal) 
							BEGIN
								SELECT 2
							END
						ELSE
							BEGIN

								UPDATE Adua.tbEcotasa
								SET ecot_RangoIncial = @ecot_RangoIncial, 
									ecot_RangoFinal = @ecot_RangoFinal, 
									ecot_CantidadPagar = @ecot_CantidadPagar, 
									usua_UsuarioModificacion = @usua_UsuarioModificacion, 
									ecot_FechaModificacion = @ecot_FechaModificacion
								WHERE ecot_Id = @ecot_Id 

								SELECT 1
							END
					END				
			END
		
	END TRY
	BEGIN CATCH 
		SELECT 'Error Message: ' + ERROR_MESSAGE() 
	END CATCH		
END
GO



--- Eliminar
CREATE OR ALTER PROCEDURE Adua.UDP_tbEcotasa_Eliminar
	@ecot_Id	INT
AS
BEGIN
	BEGIN TRY

			DELETE FROM Adua.tbEcotasa
			WHERE ecot_Id = @ecot_Id
			
			SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()		
	END CATCH
END
GO



------------------------------------ [Adua].[tbImpuestoSelectivoConsumoCondicionesVehiculos] ------------------------------------ 


--- Listar
CREATE OR ALTER PROCEDURE Adua.UDP_tbImpuestoSelectivoConsumoCondicionesVehiculos_Listar
AS
BEGIN
	SELECT 
		isccv.[selh_Id],
		isccv.[selh_EsNuevo],
		isccv.[selh_RangoInicio], 
		isccv.[selh_RangoFin], 
		isccv.[selh_ImpuestoCobrar],

		usuaCrea.usua_Nombre AS usua_UsuarioCreacionNombre,
		isccv.[usua_UsuarioCreacion], 
		isccv.[selh_FechaCreacion], 

		usuaModifica.usua_Nombre AS usua_UsuarioModificacionNombre,
		isccv.[usua_UsuarioModificacion], 
		isccv.[selh_FechaModificacion]
	FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos AS isccv
	INNER JOIN Acce.tbUsuarios AS usuaCrea ON isccv.usua_UsuarioCreacion = usuaCrea.usua_Id
	LEFT JOIN Acce.tbUsuarios AS usuaModifica ON isccv.usua_UsuarioModificacion = usuaModifica.usua_Id
	ORDER BY [selh_FechaCreacion] ASC
END
GO


--- Insertar
CREATE OR ALTER PROCEDURE Adua.UDP_tbImpuestoSelectivoConsumoCondicionesVehiculos_Insertar
	@selh_EsNuevo			BIT, 
	@selh_RangoInicio		DECIMAL(18,2), 
	@selh_RangoFin			DECIMAL(18,2), 
	@selh_ImpuestoCobrar	DECIMAL(18,2), 
	@usua_UsuarioCreacion	INT, 
	@selh_FechaCreacion		DATETIME
AS
BEGIN
	BEGIN TRY

		IF	(@selh_RangoInicio IN (SELECT selh_RangoInicio FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos) AND @selh_RangoFin IN (SELECT selh_RangoFin FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos))
			BEGIN
				SELECT 0
			END
		ELSE
			BEGIN
				IF EXISTS (SELECT * FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos WHERE @selh_RangoInicio BETWEEN selh_RangoInicio AND selh_RangoFin)
					AND EXISTS (SELECT * FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos WHERE @selh_RangoFin BETWEEN selh_RangoInicio AND selh_RangoFin)
					BEGIN
						SELECT 2
					END
				ELSE
					BEGIN
						INSERT INTO Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos ([selh_EsNuevo], [selh_RangoInicio], [selh_RangoFin], [selh_ImpuestoCobrar], [usua_UsuarioCreacion], [selh_FechaCreacion])
						VALUES (@selh_EsNuevo, @selh_RangoInicio, @selh_RangoFin, @selh_ImpuestoCobrar, @usua_UsuarioCreacion, @selh_FechaCreacion)

						SELECT 1
					END
			END
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()
	END CATCH
END
GO



--- Editar
CREATE OR ALTER PROCEDURE Adua.UDP_tbImpuestoSelectivoConsumoCondicionesVehiculos_Editar
	@selh_Id					INT,
	@selh_EsNuevo				BIT, 
	@selh_RangoInicio			DECIMAL(18,2), 
	@selh_RangoFin				DECIMAL(18,2), 
	@selh_ImpuestoCobrar		DECIMAL(18,2), 
	@usua_UsuarioModificacion	INT, 
	@selh_FechaModificacion		DATETIME
AS
BEGIN
	BEGIN TRY
		
		DECLARE @minRangoInicial DECIMAL (18,2) = (SELECT MIN(selh_RangoInicio) FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos)
		DECLARE @maxRangoFinal DECIMAL (18,2) = (SELECT MAX(selh_RangoFin) FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos)

		IF EXISTS (SELECT * FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos WHERE selh_Id = @selh_Id AND selh_RangoInicio = @selh_RangoInicio AND selh_RangoFin = @selh_RangoFin)
			BEGIN
				UPDATE Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos
				SET 
					selh_EsNuevo				= @selh_EsNuevo,	
					selh_RangoInicio			= @selh_RangoInicio,
					selh_RangoFin				= @selh_RangoFin,
					selh_ImpuestoCobrar			= @selh_ImpuestoCobrar,
					usua_UsuarioModificacion	= @usua_UsuarioModificacion,
					selh_FechaModificacion		= @selh_FechaModificacion	
				WHERE selh_Id = @selh_Id
				
				SELECT 1
			END
		ELSE
			BEGIN
				IF	(@selh_RangoInicio IN (SELECT selh_RangoInicio FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos) AND @selh_RangoFin IN (SELECT selh_RangoFin FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos))
					BEGIN
						SELECT 0
					END
				ELSE
					BEGIN
						IF EXISTS (SELECT * FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos WHERE @selh_RangoInicio BETWEEN selh_RangoInicio AND selh_RangoFin)
							AND EXISTS (SELECT * FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos WHERE @selh_RangoFin BETWEEN selh_RangoInicio AND selh_RangoFin)
							BEGIN
								SELECT 2
							END
						ELSE
							BEGIN
								UPDATE Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos
								SET 
									selh_EsNuevo			= @selh_EsNuevo,	
									selh_RangoInicio		= @selh_RangoInicio,
									selh_RangoFin			= @selh_RangoFin,
									selh_ImpuestoCobrar		= @selh_ImpuestoCobrar,
									usua_UsuarioModificacion	= @usua_UsuarioModificacion,
									selh_FechaModificacion		= @selh_FechaModificacion	
								WHERE selh_Id = @selh_Id

								SELECT 1
							END
					END			
			END
	END TRY
	BEGIN CATCH 
		SELECT 'Error Message: ' + ERROR_MESSAGE() 
	END CATCH		
END
GO



--- Eliminar
CREATE OR ALTER PROCEDURE Adua.UDP_tbImpuestoSelectivoConsumoCondicionesVehiculos_Eliminar
	@selh_Id	INT
AS
BEGIN
	BEGIN TRY

		DELETE FROM Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos
		WHERE selh_Id = @selh_Id

		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE()		
	END CATCH
END
GO

CREATE TABLE Adua.tbItemsDEVAPorDuca (
		dedu_Id						INT IDENTITY(1,1),
		duca_Id						INT,
		deva_Id						INT,

		usua_UsuarioCreacion		INT,
		dedu_FechaCreacion			DATETIME,
		usua_UsuarioModificacion	INT,
		dedu_FechaModificacion		DATETIME

		CONSTRAINT PK_Adua_tbItemsDEVAPorDuca_dedu_Id										PRIMARY KEY (dedu_Id),
		CONSTRAINT FK_Adua_tbItemsDEVAPorDuca_duca_Id_Adua_tbDuca_duca_Id			FOREIGN KEY (duca_Id)  REFERENCES Adua.tbDuca (duca_Id),
		CONSTRAINT FK_Adua_tbItemsDEVAPorDuca_deva_Id_Adua_tbDeclaraciones_Valor_deva_Id	FOREIGN KEY (deva_Id)		REFERENCES Adua.tbDeclaraciones_Valor (deva_Id),

		CONSTRAINT FK_Acce_tbUsuarios_Adua_tbItemsDEVAPorDuca_usua_UsuarioCreacion 			FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
		CONSTRAINT FK_Acce_tbUsuarios_Adua_tbItemsDEVAPorDuca_usua_UsuarioModificacion		FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id),
);

-- PROCS ---

/*Insertar ITEMXDUCA*/
GO
CREATE OR ALTER PROCEDURE Adua.UDP_tbItemsDEVAPorDuca_Insertar 
(   @duca_Id						INT,
	@deva_Id						INT,
	@usua_UsuarioCreacion 			INT,
	@dedu_FechaCreacion				DATETIME
)
AS
BEGIN
	BEGIN TRY	
			BEGIN
				INSERT INTO Adua.tbItemsDEVAPorDuca (duca_Id, deva_Id, usua_UsuarioCreacion, dedu_FechaCreacion)
				     VALUES							(@duca_Id, @deva_Id, @usua_UsuarioCreacion, @dedu_FechaCreacion )
				     SELECT  1
			END
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE() AS Resultado
	END CATCH
END
GO


/*Editar ITEMXDUCA*/
CREATE OR ALTER PROCEDURE Adua.UDP_tbItemsDEVAPorDuca_Editar
(
	@dedu_Id						INT,
	@duca_Id						INT,
	@deva_Id						INT,
	@usua_UsuarioModificacion		INT,
	@dedu_FechaModificacion			DATETIME
)
AS
BEGIN
	BEGIN TRY
		UPDATE Adua.tbItemsDEVAPorDuca
		   SET duca_Id = @duca_Id,
		       deva_Id = @deva_Id,
			   usua_UsuarioModificacion = @usua_UsuarioModificacion,
			   dedu_FechaModificacion = @dedu_FechaModificacion
		 WHERE dedu_Id = @dedu_Id

		SELECT 1 AS Resultado
	END TRY
	BEGIN CATCH
		SELECT 'Error Message: ' + ERROR_MESSAGE() AS Resultado
	END CATCH
END
GO
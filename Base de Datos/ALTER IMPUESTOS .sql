CREATE TABLE Adua.tbImpuestoSelectivoConsumoCondicionesVehiculos
(
selh_Id							INT IDENTITY(1,1) 
,aran_Id						INT
,selh_EsNuevo					BIT
,selh_EsHibrido					BIT
,selh_RangoInicio				DECIMAL(18,2)
,selh_RangoFin					DECIMAL(18,2)
,selh_ImpuestoCobrar			DECIMAL(18,2)
,usua_UsuarioCreacion			INT
,selh_FechaCreacion				DATETIME
,usua_UsuarioModificacion		INT
,selh_FechaModificacion			DATETIME

CONSTRAINT PK_adua_tbImpuestoSelectivoConsumoCondicionesVehiculos_selh_Id PRIMARY KEY(selh_Id),
CONSTRAINT FK_adua_tbImpuestoSelectivoConsumoCondicionesVehiculos_adua_tbAranceles_aran_Id		FOREIGN KEY(aran_Id) REFERENCES adua.tbAranceles(aran_Id),
CONSTRAINT FK_adua_tbImpuestoSelectivoConsumoCondicionesVehiculos_Acce_tbUsuarios_usua_UsuarioCreacion		FOREIGN KEY(usua_UsuarioCreacion) 	  REFERENCES Acce.tbUsuarios (usua_Id),
CONSTRAINT FK_adua_tbImpuestoSelectivoConsumoCondicionesVehiculos_Acce_tbUsuarios_usua_UsuarioModificacion		FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),

)


CREATE TABLE Adua.tbImpuestoProduccionComsumoCondiciones
(
ipcc_Id								INT IDENTITY(1,1)
,aran_Id							INT
,ipcc_Impuesto						DECIMAL(18,2)
,ipcc_Unidad						INT
,usua_UsuarioCreacion				INT
,ipcc_FechaCreacion					DATETIME
,usua_UsuarioModificacion			INT
,ipcc_FechaModificacion				DATETIME

CONSTRAINT PK_adua_tbImpuestoProduccionComsumoCondiciones_ipcc_Id PRIMARY KEY(ipcc_Id),
CONSTRAINT FK_adua_tbImpuestoProduccionComsumoCondiciones_adua_tbAranceles_aran_Id		FOREIGN KEY(aran_Id) REFERENCES adua.tbAranceles(aran_Id),
CONSTRAINT FK_adua_tbImpuestoProduccionComsumoCondiciones_Acce_tbUsuarios_usua_UsuarioCreacion		FOREIGN KEY(usua_UsuarioCreacion) 	  REFERENCES Acce.tbUsuarios (usua_Id),
CONSTRAINT FK_adua_tbImpuestoProduccionComsumoCondiciones_Acce_tbUsuarios_usua_UsuarioModificacion		FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),

)


ALTER TABLE adua.tbAranceles
ADD		aran_DAI INT
		,aran_SEL INT
		,aran_ISV INT
		,aran_ProdCons INT

		
ALTER TABLE adua.tbAranceles
ADD		
CONSTRAINT FK_adua_tbAranceler_tbImpuestos_aran_ISV FOREIGN KEY (aran_ISV) REFERENCES adua.tbImpuestos(impu_Id)

GO




CREATE TABLE adua.tbTratados
(
tlcs_Id								INT IDENTITY(1,1)
,tlcs_Nombre						NVARCHAR(500) NOT NULL
,tlcs_Descripcion					NVARCHAR(4000) NULL
,tlcs_Cantidad						DECIMAL(18,2) NOT NULL
,pais_Id							INT NOT NULL
,usua_UsuarioCreacion				INT NOT NULL
,tlcs_FechaCreacion					DATETIME NOT NULL
,usua_UsuarioModificacion			INT NULL
,tlcs_FechaModificacion				DATETIME NULL
,tlcs_Estado						BIT NOT NULL DEFAULT(1)

CONSTRAINT PK_adua_tbTratados_tlcs_Id										PRIMARY KEY(tlcs_Id),
CONSTRAINT FK_adua_tbTratados_gral_tbPaises_pais_Id							FOREIGN KEY(pais_Id) REFERENCES gral.tbpaises(pais_Id),
CONSTRAINT FK_adua_tbTratados_Acce_tbUsuarios_usua_UsuarioCreacion			FOREIGN KEY(usua_UsuarioCreacion) 	  REFERENCES Acce.tbUsuarios (usua_Id),
CONSTRAINT FK_adua_tbTratados_Acce_tbUsuarios_usua_UsuarioModificacion		FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
)

CREATE TABLE adua.tbArancelesPorTratado
(
atlc_Id							INT IDENTITY(1,1)
,aran_Id						INT
,tlcs_Id						INT 
,usua_UsuarioCreacion			INT
,atlc_FechaCreacion				DATETIME
,usua_UsuarioModificacion		INT
,atlc_FechaModificacion			DATETIME

CONSTRAINT PK_adua_tbArancelesPorTratado_atlc_Id										PRIMARY KEY(atlc_Id),
CONSTRAINT FK_adua_tbArancelesPorTratado_adua_tbAranceles_aran_Id						FOREIGN KEY(aran_Id) REFERENCES adua.tbAranceles(aran_Id),
CONSTRAINT FK_adua_tbArancelesPorTratado_adua_tbTratados_tlcs_Id						FOREIGN KEY(tlcs_Id) REFERENCES adua.tbTratados(tlcs_Id),
CONSTRAINT FK_adua_tbArancelesPorTratado_Acce_tbUsuarios_usua_UsuarioCreacion			FOREIGN KEY(usua_UsuarioCreacion) 	  REFERENCES Acce.tbUsuarios (usua_Id),
CONSTRAINT FK_adua_tbArancelesPorTratado_Acce_tbUsuarios_usua_UsuarioModificacion		FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),

)
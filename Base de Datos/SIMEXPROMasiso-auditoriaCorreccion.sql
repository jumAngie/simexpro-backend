/*
		DROP DATABASE SIMEXPRO
		GO
		DROP SCHEMA Adua
		GO
		DROP SCHEMA Prod
		GO
		DROP SCHEMA Acce
		GO
		DROP SCHEMA Gral
		GO
		*/
	/*
	
	Primero crear y luego correr script
	*/


	CREATE SCHEMA Adua
	GO  
	CREATE SCHEMA Prod
	GO
	CREATE SCHEMA Acce
	GO
	CREATE SCHEMA Gral
	GO

--**********************************************************--
--*************** SCHEMA Acceso ***************************--
--**********************************************************--
CREATE TABLE Acce.tbUsuarios(
		usua_Id 					INT IDENTITY(1,1),
		usua_Nombre					NVARCHAR(100) 	NOT NULL,
		usua_Contrasenia			NVARCHAR(MAX) 	NOT NULL,
		--usua_Correo					NVARCHAR(200) 	NOT NULL,
		empl_Id						INT 			NOT NULL,
		usua_esAduana				BIT NOT NULL,
		usua_Image					NVARCHAR(500) 	NULL,
		role_Id						INT				NOT NULL,
		usua_EsAdmin				BIT 			NOT NULL,
		pant_subCategoria			NVARCHAR(150),
		usua_UsuarioCreacion 		INT				NOT NULL,
		usua_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		usua_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion 	INT				DEFAULT NULL,
		usua_FechaEliminacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioActivacion		INT				NULL,
		usua_FechaActivacion		DATETIME		NULL,
		usua_Estado					BIT				DEFAULT 1,
	CONSTRAINT PK_Acce_tbUsuarios_usua_Id 				 PRIMARY KEY (usua_Id),
	CONSTRAINT UQ_acce_tbUsuarios_usua_Nombre_esAduana UNIQUE(usua_Nombre, usua_esAduana),
	CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioActivacion FOREIGN KEY(usua_UsuarioActivacion) REFERENCES Acce.tbUsuarios(usua_Id),
);
GO

CREATE TABLE Acce.tbUsuariosHistorial(
		hist_Id						INT 			IDENTITY(1,1),
		usua_Id 					INT,
		usua_Nombre					NVARCHAR(100),
		usua_Contrasenia			NVARCHAR(MAX),
		--usua_Correo					NVARCHAR(200),
		empl_Id						INT,
		usua_esAduana				BIT,
		usua_Image					NVARCHAR(500),
		role_Id						INT,
		usua_EsAdmin				BIT 			NOT NULL,

		hist_UsuarioAccion 			INT,
		hist_FechaAccion 			DATETIME 		NOT NULL,
		hist_Accion					NVARCHAR(100)
);


GO
CREATE TABLE Acce.tbRoles
(
		role_Id						INT 			IDENTITY(1,1),
		role_Descripcion			NVARCHAR(500),
		role_Aduana					BIT				NOT NULL,				

		usua_UsuarioCreacion 		INT				NOT NULL,
		role_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		role_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion 	INT				DEFAULT NULL,
		role_FechaEliminacion		DATETIME 		DEFAULT NULL,
		role_Estado					BIT				DEFAULT 1,

	CONSTRAINT PK_Acce_tbRoles_role_Id 				PRIMARY KEY (role_Id),
	CONSTRAINT UQ_acce_tbRoles_role_Descripcion 	UNIQUE(role_Descripcion, role_Aduana),
	CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioCreacion_Acce_tbRoles_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioModificacion_Acce_tbRoles_usua_Id FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioEliminacion_Acce_tbRoles_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios (usua_Id)

);
GO

CREATE TABLE Acce.tbPantallas(
		pant_Id						INT 			IDENTITY(1,1),
		pant_Nombre					NVARCHAR(100),
		pant_URL					NVARCHAR(100),
		pant_Identificador			NVARCHAR(MAX),
		pant_Icono					NVARCHAR(50),
		pant_Subcategoria			NVARCHAR(500),
		pant_Esquema				NVARCHAR(100),
		pant_EsAduana				BIT	         ,
		usua_UsuarioCreacion 		INT				NOT NULL,
		pant_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		pant_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion		INT 			DEFAULT NULL,
		pant_FechaEliminacion		DATETIME 		DEFAULT NULL,
		pant_Estado					BIT				DEFAULT 1,




	CONSTRAINT PK_Acce_tbPantallas_pant_Id	PRIMARY KEY (pant_Id),

	CONSTRAINT FK_Acce_tbPantallas_pant_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 	 FOREIGN KEY(usua_UsuarioCreacion) 	   REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Acce_tbPantallas_pant_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id)
);
GO


CREATE TABLE Acce.tbRolesXPantallas(
		ropa_Id						INT	IDENTITY(1,1),
		pant_Id						INT,
		role_Id						INT,
		pant_Identificador			NVARCHAR(MAX),	
		usua_UsuarioCreacion 		INT				NOT NULL,
		ropa_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		ropa_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion 	INT				DEFAULT NULL,
		ropa_FechaEliminacion		DATETIME 		DEFAULT NULL,
		ropa_Estado					BIT				DEFAULT 1,

	CONSTRAINT PK_Acce_tbRolesXPantallas_ropa_Id PRIMARY KEY (ropa_Id),
	CONSTRAINT UQ_Acce_tbRolesXPantallas_pant_Id_role_Id					UNIQUE(role_Id, pant_Id),
	CONSTRAINT FK_Acce_tbRolesXPantallas_pant_Id_Acce_tbPantallas_pant_Id   FOREIGN KEY(pant_Id) REFERENCES Acce.tbPantallas (pant_Id),
	CONSTRAINT FK_Acce_tbRolesXPantallas_role_Id_Acce_tbRoles_role_Id 		FOREIGN KEY(role_Id) REFERENCES Acce.tbRoles (role_Id),

	CONSTRAINT FK_Acce_tbRolesXPantallas_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id     FOREIGN KEY(usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Acce_tbRolesXPantallas_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Acce_tbRolesXPantallas_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

--**********************************************************--
--**************** SCHEMA GENERAL **************************--
--**********************************************************--
CREATE TABLE Adua.tbIncoterm(
		inco_Id						INT 			IDENTITY(1,1),
		inco_Codigo					CHAR(3),
		inco_Descripcion			NVARCHAR(150) 	NOT NULL,

		usua_UsuarioCreacion 		INT				NOT NULL,
		inco_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		inco_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion	    INT				DEFAULT NULL,
		inco_FechaEliminacion		DATETIME 		DEFAULT NULL,
		inco_Estado					BIT				DEFAULT 1,
 
	CONSTRAINT PK_Adua_tbIncoterm_inco_Id 	       PRIMARY KEY (inco_Id),
	CONSTRAINT UQ_Adua_tbIncoterm_inco_Codigo 	   UNIQUE (inco_Codigo),
	CONSTRAINT UQ_Adua_tbIncoterm_inco_Descripcion UNIQUE (inco_Descripcion),
	CONSTRAINT FK_Adua_tbIncoterm_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY(usua_UsuarioCreacion) 	  REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbIncoterm_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbIncoterm_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)

);
GO

-- Cambio de identity

CREATE TABLE Gral.tbPaises(
		pais_Id						INT 			IDENTITY(1,1),
		pais_Codigo 				CHAR(2)			NOT NULL,
		pais_Nombre 				NVARCHAR(150) 	NOT NULL,
		pais_EsAduana				BIT				NOT NULL,
		pais_prefijo				NVARCHAR(4)		NOT NULL,
		usua_UsuarioCreacion 		INT				NOT NULL,
		pais_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		pais_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion	    INT				DEFAULT NULL,
		pais_FechaEliminacion		DATETIME 		DEFAULT NULL,
		pais_Estado					BIT				DEFAULT 1,
	
	CONSTRAINT PK_Gral_tbPaises_pais_Id		PRIMARY KEY (pais_Id),
	CONSTRAINT UQ_Gral_tbPaises_pais_Nombre UNIQUE (pais_Nombre, pais_EsAduana),
	CONSTRAINT UQ_Gral_tbPaises_pais_Codigo UNIQUE (pais_Codigo, pais_EsAduana),
	CONSTRAINT FK_Gral_tbPaises_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY(usua_UsuarioCreacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbPaises_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
    CONSTRAINT FK_Gral_tbPaises_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
	
);
GO


CREATE TABLE Gral.tbFormas_Envio(
		foen_Id 					INT IDENTITY(1,1),
		foen_Codigo					CHAR(2),
		foen_Descripcion			NVARCHAR(500),

		usua_UsuarioCreacion 		INT			NOT NULL,
		foen_FechaCreacion 			DATETIME 	NOT NULL,
		usua_UsuarioModificacion	INT			DEFAULT NULL,
		foen_FechaModificacion		DATETIME 	DEFAULT NULL,
		usua_UsuarioEliminacion		INT			DEFAULT NULL,
		foen_FechaEliminacion		DATETIME 	DEFAULT NULL,
		foen_Estado					BIT 		NOT NULL DEFAULT 1,

	CONSTRAINT PK_Gral_tbFormas_Envio_foen_Id 			PRIMARY KEY (foen_Id),
	CONSTRAINT UQ_Gral_tbFormas_Envio_foen_Descripcion  UNIQUE (foen_Descripcion),
	CONSTRAINT UQ_Gral_tbFormas_Envio_foen_Codigo  UNIQUE (foen_Codigo),
	CONSTRAINT FK_Gral_tbFormas_Envio_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 		FOREIGN KEY(usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbFormas_Envio_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbFormas_Envio_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id   FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
	
);
GO

-- Cambio de identity
CREATE TABLE Gral.tbMonedas 
(
		mone_Id						INT 		IDENTITY(1,1),
		mone_Codigo					CHAR(3),
		mone_Descripcion			NVARCHAR(500),
		mone_EsAduana				BIT			NOT NULL,

		usua_UsuarioCreacion 		INT			NOT NULL,
		mone_FechaCreacion 			DATETIME 	NOT NULL,
		usua_UsuarioModificacion	INT			DEFAULT NULL,
		mone_FechaModificacion		DATETIME 	DEFAULT NULL,
		--usua_UsuarioEliminacion	    INT			DEFAULT NULL,
		--mone_FechaEliminacion		DATETIME    DEFAULT NULL,
		mone_Estado					BIT 		NOT NULL DEFAULT 1,

	CONSTRAINT PK_Gral_tbMonedas_mone_Id 		  PRIMARY KEY (mone_Id),
	CONSTRAINT UQ_Gral_tbMonedas_mone_Codigo 	  UNIQUE (mone_Codigo),
	CONSTRAINT UQ_Gral_tbMonedas_mone_Descripcion UNIQUE (mone_Descripcion, mone_EsAduana),
	CONSTRAINT FK_Gral_tbMonedas_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 	  FOREIGN KEY(usua_UsuarioCreacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbMonedas_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Gral_tbMonedas_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion) 	REFERENCES Acce.tbUsuarios (usua_Id)

);
GO

CREATE TABLE Gral.tbProvincias(
		pvin_Id						INT 			IDENTITY(1,1),
		pvin_Nombre 				NVARCHAR(150) 	NOT NULL,
		pvin_Codigo 				NVARCHAR(20) 	NOT NULL,
		pais_Id						INT				NOT NULL,
		pvin_EsAduana				BIT				NOT NULL,

		usua_UsuarioCreacion 		INT				NOT NULL,
		pvin_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		pvin_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion	    INT				DEFAULT NULL,
		pvin_FechaEliminacion		DATETIME 		DEFAULT NULL,
		pvin_Estado					BIT				DEFAULT 1,
	
	CONSTRAINT PK_Gral_tbProvincias_pvin_Id 			  PRIMARY KEY (pvin_Id),
	CONSTRAINT UQ_Gral_tbProvincias_pvin_Codigo 		  UNIQUE(pvin_Codigo, pvin_EsAduana),
	CONSTRAINT UQ_tbProvincias_pvin_Nombre_pvin_Codigo	  UNIQUE (pvin_Codigo, pvin_Nombre),
	CONSTRAINT FK_Gral_tbPaises_Gral_tbProvincias_pais_Id FOREIGN KEY (pais_Id) 	 REFERENCES Gral.tbPaises(pais_Id),

	CONSTRAINT FK_Gral_tbProvincias_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 	 FOREIGN KEY(usua_UsuarioCreacion) 		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbProvincias_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion)  REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbProvincias_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion)   REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Gral.tbCiudades(
		ciud_Id						INT 			IDENTITY(1,1),
		ciud_Nombre 				NVARCHAR(150) 	NOT NULL,
		pvin_Id 					INT				NOT NULL,
		ciud_EsAduana				BIT				NOT NULL,

		usua_UsuarioCreacion 		INT				NOT NULL,
		ciud_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		ciud_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion  	INT				DEFAULT NULL,
		ciud_FechaEliminacion		DATETIME 		DEFAULT NULL,
		ciud_Estado					BIT				DEFAULT 1,
	
	CONSTRAINT PK_Gral_tbCiudades_ciud_Id 					PRIMARY KEY (ciud_Id),
	CONSTRAINT FK_Gral_tbProvincias_Gral_tbCiudades_pvin_Id FOREIGN KEY (pvin_Id) REFERENCES Gral.tbProvincias(pvin_Id),
	CONSTRAINT UQ_Gral_tbCiudades_ciud_Nombre_pvin_Id	    UNIQUE		(pvin_Id, ciud_Nombre, ciud_EsAduana),
	CONSTRAINT FK_Gral_tbCiudades_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 	   FOREIGN KEY(usua_UsuarioCreacion) 	 REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbCiudades_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbCiudades_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Gral.tbAldeas(
		alde_Id						INT 			IDENTITY(1,1),
		alde_Nombre 				NVARCHAR(150) 	NOT NULL,
		ciud_Id 					INT				NOT NULL,

		usua_UsuarioCreacion 		INT				NOT NULL,
		alde_FechaCreacion 			DATETIME 		NOT NULL,
		usua_UsuarioModificacion	INT				DEFAULT NULL,
		alde_FechaModificacion		DATETIME 		DEFAULT NULL,
		usua_UsuarioEliminacion 	INT				DEFAULT NULL,
		alde_FechaEliminacion   	DATETIME 		DEFAULT NULL,
		alde_Estado					BIT				DEFAULT 1,

	CONSTRAINT PK_Gral_tbAldeas_alde_Id 				PRIMARY KEY (alde_Id),
	CONSTRAINT UQ_tbAldeas_alde_Nombre_ciud_Id			UNIQUE(alde_Nombre, ciud_Id),
	CONSTRAINT FK_Gral_tbCiudades_Gral_tbAldeas_ciud_Id FOREIGN KEY (ciud_Id)    REFERENCES Gral.tbCiudades(ciud_Id),

	CONSTRAINT FK_Gral_tbAldeas_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 	 FOREIGN KEY(usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbAldeas_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbAldeas_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)

);
GO

CREATE TABLE Gral.tbColonias(
		colo_Id						INT IDENTITY(1,1),
		colo_Nombre 				NVARCHAR(150) 		NULL,
		alde_Id 					INT,
		ciud_Id						INT,

		usua_UsuarioCreacion 		INT					NOT NULL,
		colo_FechaCreacion 			DATETIME 			NOT NULL,
		usua_UsuarioModificacion	INT					DEFAULT NULL,
		colo_FechaModificacion		DATETIME 			DEFAULT NULL,	
		usua_UsuarioEliminacion	    INT					DEFAULT NULL,
		colo_FechaEliminacion		DATETIME 			DEFAULT NULL,
		colo_Estado					BIT					DEFAULT 1,

	CONSTRAINT PK_Gral_tbColonias_colo_Id PRIMARY KEY (colo_Id),
	CONSTRAINT FK_Gral_tbAldeas_Gral_tbColonias_alde_Id 	FOREIGN KEY (alde_Id) REFERENCES Gral.tbAldeas(alde_Id),
	CONSTRAINT FK_Gral_tbCiudades_Gral_tbColonias_ciud_Id   FOREIGN KEY (ciud_Id) REFERENCES Gral.tbCiudades(ciud_Id),
	CONSTRAINT UQ_Gral_tbAldeas_colo_Nombre_alde_Id_ciud_Id UNIQUE(colo_Nombre,alde_Id,ciud_Id),

	CONSTRAINT FK_Gral_tbColonias_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id     FOREIGN KEY(usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbColonias_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbColonias_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Gral.tbEstadosCiviles(
		escv_Id						   INT 				IDENTITY(1,1),
		escv_Nombre 				   NVARCHAR(150) 		NOT NULL,
		escv_EsAduana				   BIT NOT NULL,
		usua_UsuarioCreacion 		   INT					NOT NULL,
		escv_FechaCreacion 			   DATETIME 			NOT NULL,
		usua_UsuarioModificacion	   INT					DEFAULT NULL,
		escv_FechaModificacion		   DATETIME 			DEFAULT NULL,	
		usua_UsuarioEliminacion 	   INT					DEFAULT NULL,
		escv_FechaEliminacion		   DATETIME 			DEFAULT NULL,
		escv_Estado					   BIT					DEFAULT 1,
		
	CONSTRAINT PK_Gral_tbEstadosCiviles_escv_Id PRIMARY KEY (escv_Id),
	CONSTRAINT UQ_Gral_tbEstadosCiviles_escv_Nombre UNIQUE(escv_Nombre,escv_EsAduana),
	CONSTRAINT FK_Gral_tbEstadosCiviles_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 	 FOREIGN KEY(usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbEstadosCiviles_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbEstadosCiviles_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
	
);
GO


CREATE TABLE Gral.tbOficinas(
		ofic_Id						    INT 				IDENTITY(1,1),
		ofic_Nombre 				    NVARCHAR(150) 		NOT NULL,
	    
		usua_UsuarioCreacion 		    INT					NOT NULL,
		ofic_FechaCreacion 			    DATETIME 			NOT NULL,
		usua_UsuarioModificacion	    INT					DEFAULT NULL,
		ofic_FechaModificacion		    DATETIME 			DEFAULT NULL,
		    
		usua_UsuarioEliminacion	        INT					DEFAULT NULL,
		ofic_FechaEliminacion		    DATETIME 			DEFAULT NULL,
		ofic_Estado					    BIT					DEFAULT 1,
	
	CONSTRAINT PK_Gral_tbOficinas_ofic_Id PRIMARY KEY (ofic_Id),
	CONSTRAINT UQ_Gral_tbOficinas_ofic_Nombre UNIQUE(ofic_Nombre),
	CONSTRAINT FK_Gral_tbOficinas_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 		FOREIGN KEY(usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbOficinas_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbOficinas_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id   FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Gral.tbCargos(
		carg_Id							INT 			IDENTITY(1,1),
		carg_Nombre 					NVARCHAR(150) 	NOT NULL,
		carg_Aduana						BIT				NOT NULL,

		usua_UsuarioCreacion 			INT				NOT NULL,
		carg_FechaCreacion 				DATETIME 		NOT NULL,
		usua_UsuarioModificacion		INT				DEFAULT NULL,
		carg_FechaModificacion			DATETIME 		DEFAULT NULL,
	
		--usua_UsuarioEliminacion	    	INT				DEFAULT NULL,
		--carg_FechaEliminacion			DATETIME 		DEFAULT NULL,
		carg_Estado						BIT				DEFAULT 1,

	CONSTRAINT PK_Gral_tbCargos_carg_Id 	 PRIMARY KEY (carg_Id),
	CONSTRAINT UQ_Gral_tbCargos__carg_Nombre UNIQUE(carg_Nombre, carg_Aduana),
	CONSTRAINT FK_Gral_tbCargos_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 	 FOREIGN KEY(usua_UsuarioCreacion) 		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Gral_tbCargos_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion)  REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Gral_tbCargos_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion)   REFERENCES Acce.tbUsuarios (usua_Id)
);
GO


--Seccion 2 Chris

--select * from Gral.tbUnidadMedidas

CREATE TABLE Gral.tbUnidadMedidas
(
		unme_Id							INT 			IDENTITY(1,1),
		unme_Descripcion				NVARCHAR(500) 	NOT NULL,
		usua_UsuarioCreacion			INT 			NOT NULL,
		unme_FechaCreacion				DATETIME 		NOT NULL,
		usua_UsuarioModificacion		INT,
		unme_FechaModificacion		    DATETIME 		DEFAULT NULL,
		unme_EsAduana					BIT				NOT NULL,
		
		usua_UsuarioEliminacion 		INT,
		unme_FechaEliminacion		    DATETIME 		DEFAULT NULL,
		unme_Estado						BIT				DEFAULT 1,

CONSTRAINT PK_Gral_tbUnidadMedida_unme_Id PRIMARY KEY (unme_Id),
CONSTRAINT UQ_Gral_tbUnidadMedida_unme_Descripcion UNIQUE (unme_Descripcion, unme_EsAduana),
CONSTRAINT FK_Acce_tbUsuarios_Gral_tbUnidadesMedidas_unme_UsuarioCreacion 		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
CONSTRAINT FK_Acce_tbUsuarios_Gral_tbUnidadesMedidas_unme_UsuarioModificacion   FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id),
CONSTRAINT FK_Acce_tbUsuarios_Gral_tbUnidadesMedidas_unme_UsuarioEliminacion    FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios(usua_Id)
);
GO


CREATE TABLE Gral.tbEmpleados(
		empl_Id							INT 			IDENTITY(1,1),
		empl_Nombres 					NVARCHAR(150)	NOT NULL,
		empl_Apellidos					NVARCHAR(150) 	NOT NULL,
		empl_DNI	 					NVARCHAR(20) 	NOT NULL,
		escv_Id							INT				NOT NULL,
		empl_Sexo						CHAR(1)			NOT NULL,
		empl_FechaNacimiento			DATE 			NOT NULL,
		empl_Telefono					NVARCHAR(20)	NOT NULL,
		empl_DireccionExacta			NVARCHAR(500)   NOT NULL,
		pvin_Id							INT				NOT NULL,
		empl_CorreoElectronico			NVARCHAR(150)   NOT NULL,
		carg_Id							INT				NOT NULL,
		empl_EsAduana					BIT				NOT NULL,
		
		usua_UsuarioCreacion			INT 			NOT NULL,
		empl_FechaCreacion 				DATETIME 		NOT NULL,
		usua_UsuarioModificacion		INT,
		empl_FechaModificacion  		DATETIME,
		usua_UsuarioEliminacion		    INT,
		empl_FechaEliminacion 		    DATETIME,
		usua_UsuarioActivacion			INT,
		empl_FechaActivacion			DATETIME,
		empl_Estado						BIT 			NOT NULL DEFAULT 1,

		CONSTRAINT PK_Adua_tbEmpleados_emad_Id  PRIMARY KEY (empl_Id),
		CONSTRAINT UQ_Gral_tbEmpleados_empl_DNI UNIQUE (empl_DNI),
		CONSTRAINT FK_Gral_tbEstadosCiviles_Adua_tbEmpleados_escv_Id 					FOREIGN KEY (escv_Id) REFERENCES Gral.tbEstadosCiviles(escv_Id),
		CONSTRAINT FK_Gral_tbProvincias_Adua_tbEmpleados_pvin_Id 	 					FOREIGN KEY (pvin_Id) REFERENCES Gral.tbProvincias(pvin_Id),
		CONSTRAINT FK_Gral_tbCargos_Adua_tbasEmpleados_carg_Id 		 					FOREIGN KEY (carg_Id) REFERENCES Gral.tbCargos(carg_Id),
		CONSTRAINT FK_Acce_tbUsuarios_Gral_tbEmpleados_empl_UsuarioCreacion 			FOREIGN KEY (usua_UsuarioCreacion) 	   REFERENCES Acce.tbUsuarios (usua_Id),
		CONSTRAINT FK_Acce_tbUsuarios_Gral_tbEmpleados_empl_UsuarioModificacion			FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
		CONSTRAINT FK_Acce_tbUsuarios_Gral_tbEmpleados_empl_UsuarioEliminacion			FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id),
		CONSTRAINT FK_Gral_tbEmpleados_usua_UsuarioActivacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioActivacion)  REFERENCES Acce.tbUsuarios (usua_Id)
)
GO

--**********************************************************--
--**************** SCHEMA Aduana ***************************--
--**********************************************************--

CREATE TABLE Adua.tbAduanas
(
		adua_Id							INT 			IDENTITY(1,1),
		adua_Codigo						CHAR(4)			NOT NULL,
		adua_Nombre						NVARCHAR(500) 	NOT NULL,
		ciud_Id                         INT,
		adua_Direccion_Exacta			NVARCHAR(800) 	NOT NULL,
		usua_UsuarioCreacion			INT 			NOT NULL,
		adua_FechaCreacion				DATETIME		NOT NULL,
		usua_UsuarioModificacion		INT,
		adua_FechaModificacion	     	DATETIME 		DEFAULT NULL,

		usua_UsuarioEliminacion 		INT,
		adua_FechaEliminacion		    DATETIME 		DEFAULT NULL,
		adua_Estado						BIT 			NOT NULL DEFAULT 1,

CONSTRAINT PK_Adua_tbAduanas_adua_Id 	 PRIMARY KEY (adua_Id),
--CONSTRAINT UQ_Adua_tbAduanas_adua_Nombre UNIQUE (adua_Nombre),
CONSTRAINT UQ_Adua_tbAduanas_adua_Codigo UNIQUE (adua_Codigo, adua_Nombre),
CONSTRAINT FK_Adua_tbAduanas_tbUsuarios_adua_UsucCrea								FOREIGN KEY (usua_UsuarioCreacion)			REFERENCES Acce.tbUsuarios (usua_Id),
CONSTRAINT FK_Adua_tbAduanas_tbUsuarios_adua_usua_UsuarioModificacion				FOREIGN KEY (usua_UsuarioModificacion) 		REFERENCES Acce.tbUsuarios (usua_Id),
CONSTRAINT FK_Adua_tbAduanas_tbUsuarios_adua_usua_UsuarioEliminacion				FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios (usua_Id),
CONSTRAINT FK_Adua_tbAduanas_Gral_tbCiudades_Adua_ciud_Id FOREIGN KEY (ciud_Id) REFERENCES Gral.tbCiudades (ciud_Id)
);

ALTER TABLE Adua.tbAduanas
ADD CONSTRAINT UQ_Adua_tbAduanas_adua_Codigo1 UNIQUE (adua_Codigo)



/*Factura Detalles*/
GO

CREATE TABLE Adua.tbNivelesComerciales(
		nico_Id							INT 			IDENTITY(1,1),
		nico_Codigo						CHAR(3)			NOT NULL,
		nico_Descripcion				NVARCHAR(150) 	NOT NULL,
		usua_UsuarioCreacion			INT 			NOT NULL,
		nico_FechaCreacion				DATETIME 		NOT NULL,
		usua_UsuarioModificacion		INT,
		nico_FechaModificacion         	DATETIME,
	
		usua_UsuarioEliminacion			INT,
		nico_FechaEliminacion         	DATETIME,
		nico_Estado						BIT 			NOT NULL DEFAULT 1,

   CONSTRAINT PK_Adua_tbNivelesComerciales_nico_Id 			PRIMARY KEY (nico_Id),
   CONSTRAINT UK_Adua_tbNivelesComerciales_nico_Codigo		UNIQUE(nico_Codigo),
   constraint UQ_Adua_tbNivelesComerciales_nico_Descripcion UNIQUE(nico_Descripcion),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbNivelesComerciales_nico_UsuarioCreacion 		 FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios(usua_Id),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbNivelesComerciales_nico_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbNivelesComerciales_nico_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios(usua_Id)
   );
   GO

CREATE TABLE Adua.tbCondicionesComerciales(
   		coco_Id							INT 			IDENTITY(1,1),
		coco_Codigo						CHAR(2)			NOT NULL,
   		coco_Descripcion				NVARCHAR(150) 	NOT NULL,
   		usua_UsuarioCreacion            INT 			NOT NULL,
   		coco_FechaCreacion				DATETIME 		NOT NULL,
   		usua_UsuarioModificacion        INT,
   		coco_FechaModificacion          DATETIME,
   		usua_UsuarioEliminacion         INT,
   		coco_FechaEliminacion           DATETIME,
   		coco_Estado						BIT 			NOT NULL DEFAULT 1,

   CONSTRAINT PK_Adua_tbCondicionesComerciales_coco_Id PRIMARY KEY (coco_Id),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbCondicionesComerciales_coco_UsuarioCreacion 		 FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios(usua_Id),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbCondicionesComerciales_coco_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbCondicionesComerciales_coco_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios(usua_Id)
   );
   GO

CREATE TABLE Adua.tbFormasdePago(
	fopa_Id							INT 			IDENTITY(1,1),
	fopa_Descripcion				NVARCHAR(150) 	NOT NULL,
	usua_UsuarioCreacion			INT 			NOT NULL,
	fopa_FechaCreacion				DATETIME 		NOT NULL,
	usua_UsuarioModificacion		INT,
	fopa_FechaModificacion          DATETIME,
	
	usua_UsuarioEliminacion		    INT,
	fopa_FechaEliminacion           DATETIME,
	fopa_Estado						BIT	 			NOT NULL DEFAULT 1,

CONSTRAINT PK_Adua_tbFormasdePago_fopa_Id 		  PRIMARY KEY (fopa_Id),
CONSTRAINT UQ_Adua_tbFormasdePago_fopa_Descripcion UNIQUE(fopa_Descripcion),
CONSTRAINT FK_Acce_tbFormasdePago_Adua_tbIncoterm_Valor_fopa_UsuarioCreacion 		 FOREIGN KEY (usua_UsuarioCreacion) 	REFERENCES Acce.tbUsuarios(usua_Id),
CONSTRAINT FK_Acce_tbFormasdePago_Adua_tbIncoterm_Valor_fopa_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id),
CONSTRAINT FK_Acce_tbFormasdePago_Adua_tbIncoterm_Valor_fopa_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios(usua_Id)
);
GO

CREATE TABLE Adua.tbDeclarantes(
   	decl_Id                  		INT 			IDENTITY(1,1),
	decl_NumeroIdentificacion		NVARCHAR(50),
   	decl_Nombre_Raso         		NVARCHAR(250) 	NOT NULL,
   	decl_Direccion_Exacta    		NVARCHAR(250) 	NOT NULL,
   	ciud_Id                  		INT             NOT NULL,
   	decl_Correo_Electronico  		NVARCHAR(150) 	NOT NULL,
   	decl_Telefono            		NVARCHAR(50) 	NOT NULL,
   	decl_Fax                 		NVARCHAR(50)	NULL, 


   	usua_UsuarioCreacion            INT 			NOT NULL,
   	decl_FechaCreacion				DATETIME 		NOT NULL,
   	usua_UsuarioModificacion		INT,
   	decl_FechaModificacion      	DATETIME,
   	--usua_UsuarioEliminacion			INT,
   	--decl_FechaEliminacion      		DATETIME,
   	decl_Estado						BIT 			NOT NULL DEFAULT 1

CONSTRAINT PK_Adua_tbDeclarantes_decl_Id PRIMARY KEY (decl_Id),
CONSTRAINT FK_Adua_tbDeclarantes_esta_Id_Adua_tbCiudades_ciud_Id 					FOREIGN KEY (ciud_Id) 					REFERENCES Gral.tbCiudades(ciud_Id),
CONSTRAINT FK_Acce_tbDeclarantes_Adua_tbIncoterm_Valor_fopa_UsuarioCreacion 			FOREIGN KEY (usua_UsuarioCreacion) 		REFERENCES Acce.tbUsuarios(usua_Id),
CONSTRAINT FK_Acce_tbDeclarantes_Adua_tbIncoterm_Valor_fopa_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion)  REFERENCES Acce.tbUsuarios(usua_Id),
--CONSTRAINT FK_Acce_tbDeclarantes_Adua_tbIncoterm_Valor_fopa_usua_UsuarioEliminacion 	FOREIGN KEY (usua_UsuarioEliminacion)   REFERENCES Acce.tbUsuarios(usua_Id)
);
GO


CREATE TABLE Adua.tbDeclarantesHistorial(
	hdec_Id							INT 			IDENTITY(1,1),
   	decl_Id                  		INT,
	decl_NumeroIdentificacion		NVARCHAR(50),
   	decl_Nombre_Raso         		NVARCHAR(250) 	NOT NULL,
   	decl_Direccion_Exacta    		NVARCHAR(250) 	NOT NULL,
   	ciud_Id                  		INT             NOT NULL,
   	decl_Correo_Electronico  		NVARCHAR(150) 	NOT NULL,
   	decl_Telefono            		NVARCHAR(50) 	NOT NULL,
   	decl_Fax                 		NVARCHAR(50)	NULL, 
	usua_UsuarioCreacion            INT 			NOT NULL,
   	decl_FechaCreacion				DATETIME 		NOT NULL,


   	hdec_UsuarioModificacion		INT				NOT NULL,
	hdec_FechaModificacion			DATETIME		NOT NULL

CONSTRAINT PK_Adua_tbDeclarantesHistorial_hdec_Id PRIMARY KEY (hdec_Id),
CONSTRAINT FK_Adua_tbDeclarantesHistorial_tbDeclarantes_decl_Id 						FOREIGN KEY (decl_Id) 					REFERENCES Adua.tbDeclarantes(decl_Id)
);
GO

CREATE TABLE Adua.tbImportadores(
		impo_Id                  		INT 			IDENTITY(1,1),
		nico_Id                  		INT,
		decl_Id							INT				NOT NULL,
		impo_NivelComercial_Otro		NVARCHAR(300),
		impo_RTN                 		NVARCHAR(40) 	NOT NULL,
		impo_NumRegistro         		NVARCHAR(40) 	NOT NULL,
		usua_UsuarioCreacion     		INT 			NOT NULL,
		impo_FechaCreacion				DATETIME 		NOT NULL,
		usua_UsuarioModificacion		INT,
		impo_FechaModificacion			DATETIME,

		usua_UsuarioEliminacion			INT,
		impo_FechaEliminacion 			DATETIME,
		impo_Estado						BIT 			NOT NULL DEFAULT 1,

   CONSTRAINT PK_Adua_tbImportadores_impo_Id PRIMARY KEY (impo_Id),
   CONSTRAINT FK_Adua_tbImportadores_nico_Id_Adua_tbNivelesComerciales_nico_Id 			 FOREIGN KEY (nico_Id) 					REFERENCES Adua.tbNivelesComerciales(nico_Id),
   CONSTRAINT FK_Adua_tbImportadores_decl_Id_Adua_tbDeclarantes_decl_Id 		 		 FOREIGN KEY (decl_Id)					REFERENCES Adua.tbDeclarantes(decl_Id),
   CONSTRAINT FK_Acce_tbImportadores_Adua_tbIncoterm_Valor_impo_UsuarioCreacion 		 FOREIGN KEY (usua_UsuarioCreacion) 	REFERENCES Acce.tbUsuarios(usua_Id),
   CONSTRAINT FK_Acce_tbImportadores_Adua_tbIncoterm_Valor_impo_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id),
   CONSTRAINT FK_Acce_tbImportadores_Adua_tbIncoterm_Valor_impo_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios(usua_Id)
);
GO

CREATE TABLE Adua.tbImportadoresHistorial(
		himp_Id							INT				IDENTITY(1,1),
		impo_Id                  		INT 			NOT NULL,
		nico_Id                  		INT 			NOT NULL,
		decl_Id							INT				NOT NULL,
		impo_NivelComercial_Otro		NVARCHAR(300),
		impo_RTN                 		NVARCHAR(40) 	NOT NULL,
		impo_NumRegistro         		NVARCHAR(40) 	NOT NULL,
		usua_UsuarioCreacion     		INT 			NOT NULL,
		impo_FechaCreacion				DATETIME 		NOT NULL,

		himp_UsuarioModificacion		INT				NOT NULL,
		himp_FechaModificacion			DATETIME		NOT NULL

   CONSTRAINT PK_Adua_tbImportadoresHistorial_himp_Id PRIMARY KEY (himp_Id),
   CONSTRAINT FK_Adua_tbImportadoresHistorial_tbImportadores_impo_Id 						FOREIGN KEY (impo_Id) 					REFERENCES Adua.tbImportadores(impo_Id)   
);
GO

CREATE TABLE Adua.tbTipoIntermediario(
		tite_Id							INT 			IDENTITY(1,1),
		tite_Codigo						CHAR(2)			NOT NULL,
		tite_Descripcion				NVARCHAR(150) 	NOT NULL,
		usua_UsuarioCreacion			INT 			NOT NULL,
		tite_FechaCreacion				DATETIME 		NOT NULL,
		usua_UsuarioModificacion		INT,
		tite_FechaModificacion			DATETIME,
		usua_UsuarioEliminacion 		INT				DEFAULT NULL,
		tite_FechaEliminacion			DATETIME 		DEFAULT NULL,
		tite_Estado						BIT 			NOT NULL DEFAULT 1,

   CONSTRAINT PK_Adua_tbNivelesComerciales PRIMARY KEY (tite_Id),
   CONSTRAINT UQ_Adua_tbTipoIntermediario  UNIQUE(tite_Descripcion),
   CONSTRAINT UQ_Adua_tbTipoItermediario_tite_Codigo UNIQUE (tite_Codigo),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbTipoIntermediario_inte_UsuarioCreacion 			FOREIGN KEY (usua_UsuarioCreacion) 	   REFERENCES Acce.tbUsuarios(usua_Id),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbTipoIntermediario_inte_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id),
   CONSTRAINT FK_Acce_tbUsuarios_Adua_tbTipoIntermediario_inte_usua_UsuarioEliminacion 	FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios(usua_Id)
);
GO

CREATE TABLE Adua.tbIntermediarios(
		inte_Id							INT 			IDENTITY(1,1),
		tite_Id							INT,
		inte_Tipo_Otro					NVARCHAR(30),
		decl_Id							INT 			NOT NULL,
		usua_UsuarioCreacion            INT 			NOT NULL,
		inte_FechaCreacion				DATETIME 		NOT NULL,
		usua_UsuarioModificacion   		INT,
		inte_FechaModificacion     		DATETIME,
		--usua_UsuarioEliminacion 		INT				DEFAULT NULL,
		--inte_FechaEliminacion			DATETIME 		DEFAULT NULL,
		inte_Estado						BIT 			NOT NULL DEFAULT 1,

	CONSTRAINT PK_Adua_tbIntermediarios_inte_Id PRIMARY KEY (inte_Id),
	CONSTRAINT FK_Adua_tbIntermediarios_tite_Id_Adua_tbTipoIntermediario_tite_Id 	  FOREIGN KEY (tite_Id) REFERENCES Adua.tbTipoIntermediario(tite_Id),
	CONSTRAINT FK_Adua_tbIntermediarios_decl_Id_Adua_tbDeclarantes_decl_Id 		 	  FOREIGN KEY (decl_Id) REFERENCES Adua.tbDeclarantes(decl_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbIntermediarios_inte_UsuarioCreacion 	 	  FOREIGN KEY (usua_UsuarioCreacion) 	 REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbIntermediarios_inte_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id),
	--CONSTRAINT FK_Acce_tbUsuarios_Adua_tbIntermediarios_inte_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios(usua_Id)
);
GO

CREATE TABLE Adua.tbIntermediariosHistorial(
	hint_Id							INT 			IDENTITY(1,1),
	inte_Id							INT 			NOT NULL,
	tite_Id							INT 			NOT NULL,
	inte_Tipo_Otro					NVARCHAR(30),
	decl_Id							INT 			NOT NULL,
	usua_UsuarioCreacion            INT 			NOT NULL,
	inte_FechaCreacion				DATETIME 		NOT NULL,

	himp_UsuarioModificacion		INT				NOT NULL,
	himp_FechaModificacion			DATETIME		NOT NULL

	CONSTRAINT PK_Adua_tbIntermediariosHistorial_hint_Id PRIMARY KEY (hint_Id),
	CONSTRAINT FK_Adua_tbIntermediariosHistorial_tbIntermediarios_inte_Id 	  FOREIGN KEY (inte_Id) REFERENCES Adua.tbIntermediarios(inte_Id)
);
GO

CREATE TABLE Adua.tbProveedoresDeclaracion(
	pvde_Id								INT				IDENTITY(1,1),
	coco_Id								INT,
	pvde_Condicion_Otra					NVARCHAR(300),
	decl_Id								INT				NOT NULL,
	usua_UsuarioCreacion				INT 			NOT NULL,
	pvde_FechaCreacion					DATETIME 		NOT NULL,
	usua_UsuarioModificacion   			INT,
	pvde_FechaModificacion     			DATETIME,
	usua_UsuarioEliminacion 			INT				DEFAULT NULL,
	pvde_FechaEliminacion				DATETIME 		DEFAULT NULL,
	pvde_Estado							BIT 			NOT NULL DEFAULT 1
	CONSTRAINT PK_Adua_tbProveedoresDeclaracion_pvde_Id PRIMARY KEY(pvde_Id),
	CONSTRAINT FK_Adua_tbProveedoresDeclaracion_tbCondicionesComerciales_coco_Id			  FOREIGN KEY (coco_Id)					REFERENCES Adua.tbCondicionesComerciales(coco_Id),
	CONSTRAINT FK_Adua_tbProveedoresDeclaracion_decl_Id_Adua_tbDeclarantes_decl_Id 		 	  FOREIGN KEY (decl_Id)					REFERENCES Adua.tbDeclarantes(decl_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbProveedoresDeclaracion_pvde_UsuarioCreacion 	 	  FOREIGN KEY (usua_UsuarioCreacion) 	 REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbProveedoresDeclaracion_pvde_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbProveedoresDeclaracion_pvde_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios(usua_Id)

);
GO

CREATE TABLE Adua.tbProveedoresDeclaracionHistorial(
	hpvd_Id								INT				IDENTITY(1,1),
	pvde_Id								INT				NOT NULL,
	coco_Id								INT				NOT NULL,
	pvde_Condicion_Otra					NVARCHAR(300),
	decl_Id								INT				NOT NULL,
	usua_UsuarioCreacion				INT 			NOT NULL,
	pvde_FechaCreacion					DATETIME 		NOT NULL,

	hpvd_UsuarioModificacion			INT				NOT NULL,
	hpvd_FechaModificacion				DATETIME		NOT NULL


	CONSTRAINT PK_Adua_tbProveedoresDeclaracionHistorial_hpvd_Id							  PRIMARY KEY(hpvd_Id),
	CONSTRAINT FK_Adua__tbProveedoresDeclaracionHistorial_tbProveedoresDeclaracion_pvde_Id 	  FOREIGN KEY (pvde_Id)					REFERENCES Adua.tbProveedoresDeclaracion(pvde_Id)
);
GO


CREATE TABLE Gral.tbProveedores(
		prov_Id   						INT IDENTITY(1,1),
		prov_NombreCompania				NVARCHAR(200)		NOT NULL,
		prov_NombreContacto				NVARCHAR(200)		NOT NULL,
		prov_Telefono					NVARCHAR(20)		NOT NULL,
		prov_CodigoPostal				VARCHAR(5)			NOT NULL,
		prov_Ciudad						INT					NOT NULL,
		prov_DireccionExacta			NVARCHAR(350),
		prov_CorreoElectronico			NVARCHAR(250)		NOT NULL,
		prov_Fax						NVARCHAR(20),
		usua_UsuarioCreacion			INT					NOT NULL,
		prov_FechaCreacion				DATETIME 			NOT NULL,
		usua_UsuarioModificacion 		INT,
		prov_FechaModificacion 			DATETIME, 
		usua_UsuarioEliminacion 		INT					DEFAULT NULL,
		prov_FechaEliminacion			DATETIME 			DEFAULT NULL,
		prov_Estado 					BIT					NOT NULL DEFAULT 1, 

	CONSTRAINT PK_Prod_tbProveedores_prov_Id 								  PRIMARY KEY (prov_Id),
	CONSTRAINT UQ_Prod_tbProveedores_prov_NombreCompania 					  UNIQUE	  (prov_NombreCompania),
	CONSTRAINT FK_Prod_tbProveedores_prov_Ciudad 							  FOREIGN KEY (prov_Ciudad) 			 REFERENCES Gral.tbCiudades(ciud_Id),
	CONSTRAINT FK_Prod_tbProveedores_tbUsuarios_prov_UsuarioCreacion		  FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbProveedores_tbUsuarios_prov_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbProveedores_tbUsuarios_prov_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Adua.tbLugaresEmbarque
(
	emba_Id							INT IDENTITY(1,1),
	emba_Codigo						CHAR(5),
	emba_Descripcion				NVARCHAR(200),

	usua_UsuarioCreacion			INT					NOT NULL,
	emba_FechaCreacion				DATETIME 			NOT NULL,
	usua_UsuarioModificacion 		INT,
	emba_FechaModificacion 			DATETIME, 
	usua_UsuarioEliminacion 		INT					DEFAULT NULL,
	emba_FechaEliminacion			DATETIME 			DEFAULT NULL,
	emba_Estado 					BIT					NOT NULL DEFAULT 1

	CONSTRAINT PK_Adua_tbLugaresEmbarque_emba_Id 								  PRIMARY KEY (emba_Id),
	CONSTRAINT UQ_Adua_tbLugaresEmbarque_prov_emba_Codigo 						  UNIQUE	  (emba_Codigo),
	--CONSTRAINT UQ_Adua_tbLugaresEmbarque_prov_emba_Descripcion 					  UNIQUE	  (emba_Descripcion),
	CONSTRAINT FK_Adua_tbLugaresEmbarque_tbUsuarios_prov_UsuarioCreacion		  FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbLugaresEmbarque_tbUsuarios_prov_usua_UsuarioModificacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbLugaresEmbarque_tbUsuarios_prov_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);

CREATE TABLE Adua.tbRegimenesAduaneros(
		regi_Id 					INT IDENTITY(1,1),
		regi_Codigo					VARCHAR(10),
		regi_Descripcion			NVARCHAR(500),

		usua_UsuarioCreacion 		INT			NOT NULL,
		regi_FechaCreacion 			DATETIME 	NOT NULL,
		usua_UsuarioModificacion	INT			DEFAULT NULL,
		regi_FechaModificacion		DATETIME 	DEFAULT NULL,
		usua_UsuarioEliminacion		INT			DEFAULT NULL,
		regi_FechaEliminacion		DATETIME 	DEFAULT NULL,
		regi_Estado					BIT 		NOT NULL DEFAULT 1,

	CONSTRAINT PK_Adua_tbRegimenesAduaneros_regi_Id 											PRIMARY KEY (regi_Id),
	CONSTRAINT UQ_Adua_tbRegimenesAduaneros_regi_Codigo  										UNIQUE (regi_Codigo),
	CONSTRAINT UQ_Adua_tbRegimenesAduaneros_regi_Descripcion  									UNIQUE (regi_Descripcion),
	CONSTRAINT FK_Adua_tbRegimenesAduaneros_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 		FOREIGN KEY(usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbRegimenesAduaneros_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id  	FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbRegimenesAduaneros_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id   	FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);

GO

CREATE TABLE Adua.tbDeclaraciones_Valor
(
		deva_Id 						INT IDENTITY(1,1),
		deva_AduanaIngresoId 			INT NOT NULL, 
		deva_AduanaDespachoId 			INT NOT NULL,
		deva_DeclaracionMercancia 		NVARCHAR(500),
		regi_Id							INT NOT NULL,
		deva_FechaAceptacion 			DATETIME,
		impo_Id 						INT,
		pvde_Id 						INT,
		inte_Id 						INT,
		deva_LugarEntrega 				NVARCHAR(800),
		pais_EntregaId					INT,
		inco_Id 						INT,
		inco_Version					NVARCHAR(10),
		deva_NumeroContrato 			NVARCHAR(200),
		deva_FechaContrato 				DATE,
		foen_Id 						INT,
		deva_FormaEnvioOtra 			NVARCHAR(500),
		deva_PagoEfectuado 				BIT,
		fopa_Id 						INT,
		deva_FormaPagoOtra	 			NVARCHAR(200),
		emba_Id 						INT,
		--pais_Embarque_Id 				INT,
		pais_ExportacionId 				INT,
		deva_FechaExportacion  			DATE,
		mone_Id 						INT,
		mone_Otra 						NVARCHAR(200),
		deva_ConversionDolares 			DECIMAL(18,2),
		--deva_Condiciones 				NVARCHAR(MAX),
		deva_Finalizacion				BIT default(0),
		usua_UsuarioCreacion 			INT,
		deva_FechaCreacion  			DATETIME,
		usua_UsuarioModificacion		INT,
		deva_FechaModificacion  		DATETIME,
		--usua_UsuarioEliminacion 		INT					DEFAULT NULL,
		--deva_FechaEliminacion			DATETIME 			DEFAULT NULL,
		deva_Estado 					BIT					NOT NULL DEFAULT 1,

	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_deva_Id 												PRIMARY KEY (deva_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_deva_AduanaIngresoId_Adua_tbAduanas					FOREIGN KEY (deva_AduanaIngresoId)		REFERENCES Adua.tbAduanas (adua_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_deva_AduanaDespachoId_Adua_tbAduanas					FOREIGN KEY (deva_AduanaDespachoId)		REFERENCES Adua.tbAduanas (adua_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_regi_Id_Adua_tbRegimenesAduaneros						FOREIGN KEY (regi_Id)					REFERENCES Adua.tbRegimenesAduaneros(regi_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_impo_Id_Adua_tbImportadores							FOREIGN KEY (impo_Id)					REFERENCES Adua.tbImportadores (impo_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_pvde_Id_Adua_tbProveedoresDeclaracion					FOREIGN KEY (pvde_Id)					REFERENCES Adua.tbProveedoresDeclaracion (pvde_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_inte_Id_Adua_tbIntermediarios							FOREIGN KEY (inte_Id)					REFERENCES Adua.tbIntermediarios (inte_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_inco_Id_Adua_tbIncoterm								FOREIGN KEY (inco_Id)					REFERENCES Adua.tbIncoterm (inco_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_foen_Id_Gral_tbFormas_Envio_foen_Id 					FOREIGN KEY (foen_Id)					REFERENCES Gral.tbFormas_Envio (foen_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_fopa_Id_Adua_tbFormasdePago_fopa_Id					FOREIGN KEY (fopa_Id)					REFERENCES Adua.tbFormasdePago (fopa_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_emba_Id_Adua_tbLugaresEmbarque_emba_Id					FOREIGN KEY (emba_Id)					REFERENCES Adua.tbLugaresEmbarque (emba_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_pais_EntregaId_Gral_tbPaises_pais_Id 					FOREIGN KEY (pais_EntregaId) 			REFERENCES Gral.tbPaises (pais_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_pais_Exportacion_Id_Gral_tbPaises_pais_Exportacion_Id 	FOREIGN KEY (pais_ExportacionId) 		REFERENCES Gral.tbPaises (pais_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_mone_Id_Gral_tbMonedas_mone_Id							FOREIGN KEY (mone_Id) 					REFERENCES Gral.tbMonedas (mone_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id)
	--CONSTRAINT Gral_tbPaises_Adua_tbDeclaraciones_Valor_pais_Embarque_Id 		 FOREIGN KEY (pais_Embarque_Id)    	   REFERENCES Gral.tbPaises (pais_Id),
	--CONSTRAINT FK_Acce_tbUsuarios_Adua_tbDeclaraciones_Valor_deva_usua_UsuarioEliminacion  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios(usua_Id)
)

go

CREATE TABLE Adua.tbDeclaraciones_ValorHistorial
(
		hdev_Id							INT IDENTITY(1,1),
		deva_Id 						INT,
		deva_AduanaIngresoId 			INT NOT NULL, 
		deva_AduanaDespachoId 			INT NOT NULL,
		deva_DeclaracionMercancia 		NVARCHAR(500),
		deva_FechaAceptacion 			DATETIME,
		impo_Id 						INT,
		pvde_Id 						INT,
		inte_Id 						INT,
		deva_LugarEntrega 				NVARCHAR(800),
		pais_EntregaId					INT,
		inco_Id 						INT,
		inco_Version					NVARCHAR(10),
		deva_NumeroContrato 			NVARCHAR(200),
		deva_FechaContrato 				DATE,
		foen_Id 						INT,
		deva_FormaEnvioOtra 			NVARCHAR(500),
		deva_PagoEfectuado 				BIT,
		fopa_Id 						INT,
		deva_FormaPagoOtra	 			NVARCHAR(200),
		emba_Id 						INT,
		--pais_Embarque_Id 				INT,
		pais_ExportacionId 				INT,
		deva_FechaExportacion  			DATE,
		mone_Id 						INT,
		mone_Otra 						NVARCHAR(200),
		deva_ConversionDolares 			DECIMAL(18,2),
		deva_Condiciones 				NVARCHAR(MAX),

		hdev_UsuarioAccion 				INT,
		hdev_FechaAccion 				DATETIME,
		hdev_Accion						NVARCHAR(100)

		CONSTRAINT PK_Adua_tbDeclaraciones_ValorHistorial_hdev_Id PRIMARY KEY(hdev_Id)
);
CREATE TABLE Adua.tbFacturas
(
		fact_Id							INT 			IDENTITY(1,1),
		fact_Numero						NVARCHAR(4000)	NOT NULL,
		deva_Id							INT 			NOT NULL,
		fact_Fecha						DATE 			NOT NULL,
		usua_UsuarioCreacion			INT 			NOT NULL,
		fact_FechaCreacion				DATETIME 		NOT NULL ,
		usua_UsuarioModificacion		INT,
		fact_FechaModificacion			DATETIME,
		--usua_UsuarioEliminacion			INT,
		--fact_FechaEliminacion			DATETIME,
		fact_Estado						BIT 			NOT NULL DEFAULT 1,

CONSTRAINT PK_Adua_tbFactura_fact_Id 									PRIMARY KEY (fact_Id),
CONSTRAINT FK_Adua_tbFacturas_tbDeclaraciones_Valor_deva_Id				FOREIGN KEY (deva_Id)						REFERENCES Adua.tbDeclaraciones_Valor(deva_Id),
CONSTRAINT FK_Adua_tbFacturas_tbUsuarios_fact_UsucCrea					FOREIGN KEY (usua_UsuarioCreacion)			REFERENCES Acce.tbUsuarios (usua_Id),
CONSTRAINT FK_Adua_tbFacturas_tbUsuarios_fact_usua_UsuarioModificacion	FOREIGN KEY (usua_UsuarioModificacion) 		REFERENCES Acce.tbUsuarios (usua_Id),
--CONSTRAINT FK_Adua_tbFacturas_tbUsuarios_fact_usua_UsuarioEliminacion	FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios (usua_Id)

);
GO

CREATE TABLE Adua.tbFacturasHistorial
(
		hfact_Id						INT 			IDENTITY(1,1),
		fact_Id							INT				NOT NULL,
		fact_Numero						NVARCHAR(4000)	NOT NULL,
		deva_Id							INT	 			NOT NULL,
		fect_Fecha						DATETIME 		NOT NULL,

		hfact_UsuarioAccion 			INT,
		hfact_FechaAccion 				DATETIME,
		hfact_Accion					NVARCHAR(100)
);
GO

--/*Factura Declaracion de valor*/
--GO
--CREATE TABLE Adua.tbFacturas_Declaracion_Valor 
--(
--	fava_Id INT IDENTITY(1,1),
--	deva_Id INT NOT NULL,
--	fact_Id INT NOT NULL,
--	usua_UsuarioCreacion INT NOT NULL,
--	fava_FechaCreacion  DATETIME NOT NULL,
--	usua_UsuarioModificacion INT,
--	fava_FechaModificacion DATETIME,
--	usua_UsuarioEliminacion 	INT	DEFAULT NULL,
--	fava_FechaEliminacion		DATETIME DEFAULT NULL,
--	feva_Estado BIT	NOT NULL DEFAULT 1

--	CONSTRAINT PK_Adua_tbFacturas_Declaracion_Valor_feva_Id PRIMARY KEY (fava_Id),
--	CONSTRAINT FK_Adua_tbFacturas_Adua_tbFacturas_Declaracion_Valor_fact_Id FOREIGN KEY (fact_Id) REFERENCES Adua.tbFacturas (fact_Id),
--	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_Adua_tbFacturas_Declaracion_Valor_deva_Id FOREIGN KEY (deva_Id) REFERENCES Adua.tbDeclaraciones_Valor (deva_Id),
--	CONSTRAINT FK_Prod_tbFacturas_Declaracion_Valor_tbUsuarios_fava_UsuarioCreacion				FOREIGN KEY (usua_UsuarioCreacion)      REFERENCES Acce.tbUsuarios (usua_Id),
--	CONSTRAINT FK_Prod_tbFacturas_Declaracion_Valor_tbUsuarios_fava_usua_UsuarioModificacion			FOREIGN KEY (usua_UsuarioModificacion) 		REFERENCES Acce.tbUsuarios (usua_Id),
--	CONSTRAINT FK_Prod_tbFacturas_Declaracion_Valor_tbUsuarios_fava_usua_UsuarioEliminacion			FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios (usua_Id)

--) 

GO
CREATE TABLE Adua.tbCondiciones
(
		codi_Id 	INT 	IDENTITY(1,1),
		deva_Id 	INT 	NOT NULL,
		codi_Restricciones_Utilizacion 			BIT 			NOT NULL,
		codi_Indicar_Restricciones_Utilizacion  NVARCHAR(500),
		codi_Depende_Precio_Condicion 			BIT 			NOT NULL,
		codi_Indicar_Existe_Condicion 			NVARCHAR(500),
		codi_Condicionada_Revertir 				BIT 			NOT NULL,
		codi_Vinculacion_Comprador_Vendedor 	BIT 			NOT NULL,
		codi_Tipo_Vinculacion 					NVARCHAR(500),
		codi_Vinculacion_Influye_Precio 		BIT 			NOT NULL,
		codi_Pagos_Descuentos_Indirectos 		BIT 			NOT NULL,
		codi_Concepto_Monto_Declarado 			NVARCHAR(500),
		codi_Existen_Canones 					BIT 			NOT NULL,
		codi_Indicar_Canones 					NVARCHAR(500),
		usua_UsuarioCreacion 					INT 			NOT NULL,
		codi_FechaCreacion  					DATETIME 		NOT NULL,
		usua_UsuarioModificacion 				INT,
		codi_FechaModificacion 					DATETIME,
		--usua_UsuarioEliminacion 				INT				DEFAULT NULL,
		--codi_FechaEliminacion					DATETIME 		DEFAULT NULL,
		codi_Estado 							BIT				NOT NULL DEFAULT 1,

	CONSTRAINT PK_Adua_tbCondiciones_codi_Id 									PRIMARY KEY (codi_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_Adua_tbCondiciones_deva_Id 		FOREIGN KEY (deva_Id) REFERENCES Adua.tbDeclaraciones_Valor (deva_Id),
	CONSTRAINT FK_Prod_tbCondiciones_tbUsuarios_base_UsuarioCreacion			FOREIGN KEY (usua_UsuarioCreacion)      REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbCondiciones_tbUsuarios_base_usua_UsuarioModificacion	FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Prod_tbCondiciones_tbUsuarios_base_usua_UsuarioEliminacion	FOREIGN KEY (usua_UsuarioEliminacion) 	REFERENCES Acce.tbUsuarios (usua_Id)

)
GO

GO
CREATE TABLE Adua.tbCondicionesHistorial
(
	hcod_Id INT IDENTITY(1,1),
	codi_Id INT,
	deva_Id INT,
	codi_Restricciones_Utilizacion BIT,
	codi_Indicar_Restricciones_Utilizacion NVARCHAR(500),
	codi_Depende_Precio_Condicion BIT,
	codi_Indicar_Existe_Condicion NVARCHAR(500),
	codi_Condicionada_Revertir BIT ,
	codi_Vinculacion_Comprador_Vendedor BIT ,
	codi_Tipo_Vinculacion NVARCHAR(500) ,
	codi_Vinculacion_Influye_Precio BIT ,
	codi_Pagos_Descuentos_Indirectos BIT ,
	codi_Concepto_Monto_Declarado NVARCHAR(500) ,
	codi_Existen_Canones BIT ,
	codi_Indicar_Canones NVARCHAR(500) ,
	usua_UsuarioCreacion INT ,
	codi_FechaCreacion  DATETIME ,
	usua_UsuarioModificacion INT,
	codi_FechaModificacion DATETIME,
	usua_UsuarioEliminacion 	INT,
	codi_FechaEliminacion		DATETIME,
	codi_Estado BIT	 DEFAULT 1,

	hcod_UsuarioAccion 			INT,
	hcod_FechaAccion 			DATETIME,
	hcod_Accion					NVARCHAR(100)
)
GO

CREATE TABLE Adua.tbBaseCalculos
(
	base_Id									INT IDENTITY(1,1),
	deva_Id									INT NOT NULL,
	base_PrecioFactura						DECIMAL(18,2) NOT NULL,
	base_PagosIndirectos					DECIMAL(18,2) NOT NULL,
	base_PrecioReal							DECIMAL(18,2) NOT NULL,
	base_MontCondicion						DECIMAL(18,2) NOT NULL,
	base_MontoReversion						DECIMAL(18,2) NOT NULL,
	base_ComisionCorrelaje					DECIMAL(18,2) NOT NULL,
	base_Gasto_Envase_Embalaje				DECIMAL(18,2) NOT NULL,
	base_ValoresMateriales_Incorporado		DECIMAL(18,2) NOT NULL,
	base_Valor_Materiales_Utilizados		DECIMAL(18,2) NOT NULL,
	base_Valor_Materiales_Consumidos		DECIMAL(18,2) NOT NULL,
	base_Valor_Ingenieria_Importado			DECIMAL(18,2) NOT NULL,
	base_Valor_Canones						DECIMAL(18,2) NOT NULL,
	base_Gasto_TransporteM_Importada		DECIMAL(18,2) NOT NULL,
	base_Gastos_Carga_Importada				DECIMAL(18,2) NOT NULL,
	base_Costos_Seguro						DECIMAL(18,2) NOT NULL,
	base_Total_Ajustes_Precio_Pagado		DECIMAL(18,2) NOT NULL,
	base_Gastos_Asistencia_Tecnica			DECIMAL(18,2) NOT NULL,
	base_Gastos_Transporte_Posterior		DECIMAL(18,2) NOT NULL,
	base_Derechos_Impuestos					DECIMAL(18,2) NOT NULL,
	base_Monto_Intereses					DECIMAL(18,2) NOT NULL,
	base_Deducciones_Legales				DECIMAL(18,2) NOT NULL,
	base_Total_Deducciones_Precio			DECIMAL(18,2) NOT NULL,
	base_Valor_Aduana						DECIMAL(18,2) NOT NULL,
	usua_UsuarioCreacion					INT NOT NULL,
	base_FechaCreacion						DATETIME NOT NULL,
	usua_UsuarioModificacion				INT,
	base_FechaModificacion					DATETIME,
	--usua_UsuarioEliminacion 	INT	DEFAULT NULL,
	--base_FechaEliminacion		DATETIME DEFAULT NULL,
	base_Estado								BIT	NOT NULL DEFAULT 1,
	CONSTRAINT PK_Adua_tbBaseCalculos_base_Id PRIMARY KEY(base_Id),
	CONSTRAINT FK_Adua_tbDeclaraciones_Valor_Adua_tbBaseCalculos_deva_Id                     FOREIGN KEY (deva_Id) 			            REFERENCES Adua.tbDeclaraciones_Valor (deva_Id),
	CONSTRAINT FK_Prod_tbBaseCalculos_tbUsuarios_base_UsuarioCreacion				        FOREIGN KEY (usua_UsuarioCreacion)          REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbBaseCalculos_tbUsuarios_base_usua_UsuarioModificacion				FOREIGN KEY (usua_UsuarioModificacion) 		REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Prod_tbBaseCalculos_tbUsuarios_base_usua_UsuarioEliminacion				FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios (usua_Id)
)

CREATE TABLE Adua.tbBaseCalculosHistorial
(
	hbas_Id									INT IDENTITY(1,1),
	base_Id									INT,
	deva_Id									INT NOT NULL,
	base_PrecioFactura						DECIMAL(18,2) NOT NULL,
	base_PagosIndirectos					DECIMAL(18,2) NOT NULL,
	base_PrecioReal							DECIMAL(18,2) NOT NULL,
	base_MontCondicion						DECIMAL(18,2) NOT NULL,
	base_MontoReversion						DECIMAL(18,2) NOT NULL,
	base_ComisionCorrelaje					DECIMAL(18,2) NOT NULL,
	base_Gasto_Envase_Embalaje				DECIMAL(18,2) NOT NULL,
	base_ValoresMateriales_Incorporado		DECIMAL(18,2) NOT NULL,
	base_Valor_Materiales_Utilizados		DECIMAL(18,2) NOT NULL,
	base_Valor_Materiales_Consumidos		DECIMAL(18,2) NOT NULL,
	base_Valor_Ingenieria_Importado			DECIMAL(18,2) NOT NULL,
	base_Valor_Canones						DECIMAL(18,2) NOT NULL,
	base_Gasto_TransporteM_Importada		DECIMAL(18,2) NOT NULL,
	base_Gastos_Carga_Importada				DECIMAL(18,2) NOT NULL,
	base_Costos_Seguro						DECIMAL(18,2) NOT NULL,
	base_Total_Ajustes_Precio_Pagado		DECIMAL(18,2) NOT NULL,
	base_Gastos_Asistencia_Tecnica			DECIMAL(18,2) NOT NULL,
	base_Gastos_Transporte_Posterior		DECIMAL(18,2) NOT NULL,
	base_Derechos_Impuestos					DECIMAL(18,2) NOT NULL,
	base_Monto_Intereses					DECIMAL(18,2) NOT NULL,
	base_Deducciones_Legales				DECIMAL(18,2) NOT NULL,
	base_Total_Deducciones_Precio			DECIMAL(18,2) NOT NULL,
	base_Valor_Aduana						DECIMAL(18,2) NOT NULL,

	hbas_UsuarioAccion 			INT,
	hbas_FechaAccion 			DATETIME,
	hbas_Accion					NVARCHAR(100)
)

GO
--Seccion #3

CREATE TABLE Prod.tbEstilos(
	esti_Id						INT  IDENTITY(1,1),
	esti_Descripcion			NVARCHAR(200) NOT NULL,
	usua_UsuarioCreacion 		INT NOT NULL,
	esti_FechaCreacion			DATETIME NOT NULL, 
	usua_UsuarioModificacion	INT ,
	esti_FechaModificacion		DATETIME DEFAULT NULL ,
	usua_UsuarioEliminacion 	INT	DEFAULT NULL,
	esti_FechaEliminacion		DATETIME DEFAULT NULL,
	esti_Estado					BIT DEFAULT 1,
	CONSTRAINT PK_Prod_tbEstilos_esti_Id												PRIMARY KEY (esti_Id),
	CONSTRAINT UQ_Prod_tbEstilos_esti_Descripcion 										UNIQUE(esti_Descripcion),
	CONSTRAINT FK_Prod_tbEstilos_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 			FOREIGN KEY (usua_UsuarioCreacion )     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbEstilos_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbEstilos_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios (usua_Id)

);

--CREATE TABLE Prod.tbModelos(
--	mode_Id						INT  IDENTITY(1,1),
--	mode_Descripcion			INT ,
--	esti_Id						INT ,
--	usua_UsuarioCreacion 		INT ,
--	mode_FechaCreacion			DATETIME NOT NULL, 
--	usua_UsuarioModificacion	INT ,
--	mode_FechaModificacion		DATETIME DEFAULT NULL, 
--	usua_UsuarioEliminacion 	INT	DEFAULT NULL,
--	mode_FechaEliminacion		DATETIME DEFAULT NULL,
--	mode_Estado					BIT DEFAULT 1

--	CONSTRAINT PK_Prod_tbModelos_mode_Id												PRIMARY KEY (mode_Id),
--	CONSTRAINT FK_Prod_tbModelos_esti_Id_Prod_tbEstilos_esti_Id							FOREIGN KEY (esti_Id)					REFERENCES Prod.tbEstilos (esti_Id),
--	CONSTRAINT FK_Prod_tbModelos_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion )     REFERENCES Acce.tbUsuarios (usua_Id),
--	CONSTRAINT FK_Prod_tbModelos_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
--	CONSTRAINT FK_Prod_tbModelos_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios (usua_Id),


--);
--GO

CREATE TABLE Prod.tbColores(
	colr_Id						INT  IDENTITY(1,1),
	colr_Nombre					NVARCHAR(200) NOT NULL,
	colr_Codigo					NVARCHAR(50),
	colr_CodigoHtml				NVARCHAR(50),
	usua_UsuarioCreacion		INT,
	colr_FechaCreacion			DATETIME NOT NULL, 
	usua_UsuarioModificacion	INT,
	colr_FechaModificacion		DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion 	INT	DEFAULT NULL,
	colr_FechaEliminacion		DATETIME DEFAULT NULL,
	colr_Estado					BIT DEFAULT 1,
	CONSTRAINT PK_Prod_tbColores_colr_Id													PRIMARY KEY (colr_Id),
	--CONSTRAINT UQ_Prod_tbColores_colr_Nombre 												UNIQUE(colr_Nombre),
	--CONSTRAINT UQ_Prod_tbColores_colr_Codigo 												UNIQUE(colr_Codigo),
	CONSTRAINT FK_Prod_tbColores_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbColores_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbColores_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);
GO
CREATE TABLE Prod.tbProcesos(
	proc_Id						INT  IDENTITY(1,1), 
	proc_Descripcion			NVARCHAR(200) NOT NULL,
	proc_CodigoHtml				NVARCHAR(50) NOT NULL,
	usua_UsuarioCreacion 		INT,
	proc_FechaCreacion			DATETIME NOT NULL,  
	usua_UsuarioModificacion	INT, 
	proc_FechaModificacion		DATETIME DEFAULT NULL, 
	usua_UsuarioEliminacion 	INT	DEFAULT NULL,
	proc_FechaEliminacion		DATETIME DEFAULT NULL,
	proc_Estado					BIT DEFAULT 1,
	CONSTRAINT PK_Prod_tbProcesos_proc_Id													PRIMARY KEY (proc_Id),
	CONSTRAINT UQ_Prod_tbProcesos_proc_Descripcion 											UNIQUE(proc_Descripcion),
	CONSTRAINT FK_Prod_tbProcesos_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbProcesos_Acce_tbUsuarios_proce_UsuModifica							FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbProcesos_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioEliminacion) 	REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Prod.tbArea(
	tipa_Id						INT IDENTITY(1,1),
	tipa_area					NVARCHAR(200)		NOT NULL,
	proc_Id						INT 				NOT NULL,
	usua_UsuarioCreacion		INT					NOT NULL,
	tipa_FechaCreacion			DATETIME			NOT NULL,
	usua_UsuarioModificacion 	INT 			,
	tipa_FechaModificacion		DATETIME DEFAULT NULL		, 
	usua_UsuarioEliminacion 	INT	DEFAULT NULL,
	tipa_FechaEliminacion		DATETIME DEFAULT NULL,
	tipa_Estado 				BIT					NOT NULL DEFAULT 1, 

	CONSTRAINT PK_Prod_tbArea_tipa_Id 													PRIMARY KEY (tipa_Id),
	CONSTRAINT UQ_Prod_tbArea_tipa_area													UNIQUE		(tipa_area),
	CONSTRAINT FK_Prod_tbArea_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 				FOREIGN KEY (usua_UsuarioCreacion) 		REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Prod_tbArea_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id 			FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Prod_tbArea_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioEliminacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbArea_proc_Id_Prod_tbProcesos_proc_Id			 				FOREIGN KEY (proc_Id) 					REFERENCES Prod.tbProcesos(proc_Id),
)
GO

CREATE TABLE Prod.tbTipoEmbalaje(
	tiem_Id  					INT IDENTITY(1,1),
	tiem_Descripcion 			NVARCHAR(200) NOT NULL,
	usua_UsuarioCreacion		INT			  NOT NULL,
	tiem_FechaCreacion			DATETIME			NOT NULL,
	usua_UsuarioModificacion 	INT,
	tiem_FechaModificacion		DATETIME DEFAULT NULL		,
	usua_UsuarioEliminacion 	INT	DEFAULT NULL,
	tiem_FechaEliminacion		DATETIME DEFAULT NULL, 
	tiem_Estado 				BIT					NOT NULL DEFAULT 1, 
	
	CONSTRAINT PK_Prod_tbTipoEmbalaje_tiem_Id												PRIMARY KEY (tiem_Id),
	CONSTRAINT UQ_Prod_tbTipoEmbalaje_tiem_Descripcion										UNIQUE		(tiem_Descripcion),
	CONSTRAINT FK_Prod_tbTipoEmbalaje_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbTipoEmbajale_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbTipoEmbajale_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id),
);
GO


CREATE TABLE Prod.tbFuncionesMaquina(
	func_Id   					INT IDENTITY(1,1),
	func_Nombre  				NVARCHAR(200)		NOT NULL,
	usua_UsuarioCreacion		INT					NOT NULL,
	func_FechaCreacion			DATETIME			NOT NULL,
	usua_UsuarioModificacion 	INT,
	func_FechaModificacion		DATETIME 			DEFAULT NULL, 
	usua_UsuarioEliminacion 	INT					DEFAULT NULL,
	func_FechaEliminacion		DATETIME 			DEFAULT NULL, 
	func_Estado 				BIT					NOT NULL DEFAULT 1, 

	CONSTRAINT PK_Prod_tbFuncionesMaquina_func_Id												PRIMARY KEY (func_Id),
	CONSTRAINT UQ_Prod_tbFuncionesMaquina_func_Nombre											UNIQUE		(func_Nombre),
	CONSTRAINT FK_Prod_tbFuncionesMaquina_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbFuncionesMaquina_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbFuncionesMaquina_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

CREATE TABLE Prod.tbCategoria(
	cate_Id   					INT IDENTITY(1,1),
	cate_Descripcion  			NVARCHAR(200)		NOT NULL,
	usua_UsuarioCreacion		INT					NOT NULL,
	cate_FechaCreacion			DATETIME			NOT NULL,
	usua_UsuarioModificacion 	INT,
	cate_FechaModificacion		DATETIME 			DEFAULT NULL, 
	usua_UsuarioEliminacion 	INT					DEFAULT NULL,
	cate_FechaEliminacion		DATETIME 			DEFAULT NULL, 
	cate_Estado 				BIT					NOT NULL DEFAULT 1, 

	CONSTRAINT PK_Prod_tbCategoria_cate_Id														PRIMARY KEY (cate_Id),
	CONSTRAINT UQ_Prod_tbCategoria_cate_Descripcion												UNIQUE		(cate_Descripcion),
	CONSTRAINT FK_Prod_tbCategoria_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id					FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbCategoria_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbCategoria_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id),
);
GO


CREATE TABLE Prod.tbSubcategoria(
	subc_Id   					INT IDENTITY(1,1),
	cate_Id  					INT,
	subc_Descripcion			NVARCHAR(200),
	usua_UsuarioCreacion		INT					NOT NULL,
	subc_FechaCreacion			DATETIME			NOT NULL,
	usua_UsuarioModificacion 	INT,
	subc_FechaModificacion		DATETIME 			DEFAULT NULL, 
	usua_UsuarioEliminacion 	INT					DEFAULT NULL,
	subc_FechaEliminacion		DATETIME 			DEFAULT NULL, 
	subc_Estado 				BIT					NOT NULL DEFAULT 1, 

	CONSTRAINT PK_Prod_tbSubcategoria_subc_Id													PRIMARY KEY (subc_Id),
	CONSTRAINT FK_Prod_tbSubcategoria_cate_Id_subc_Descripcion									UNIQUE		(subc_Descripcion, cate_Id),
	CONSTRAINT FK_Prod_tbSubcategoria_cate_Id_Prod_tbCategoria_cate_Id							FOREIGN KEY (cate_Id) 					REFERENCES Prod.tbCategoria(cate_Id),
	CONSTRAINT FK_Prod_tbSubCategoria_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbSubCategoria_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios (usua_Id),
);

GO

CREATE TABLE Adua.tbEstadoMercancias(
	merc_Id						INT IDENTITY(1,1),
	merc_Codigo					CHAR(2),
	merc_Descripcion			NVARCHAR(150) NOT NULL,
	usua_UsuarioCreacion        INT NOT NULL,
	merc_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion    INT DEFAULT NULL,
	merc_FechaModificacion      DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion 	INT	DEFAULT NULL,
	merc_FechaEliminacion		DATETIME DEFAULT NULL, 
	merc_Estado					BIT DEFAULT 1

	CONSTRAINT PK_Adua_tbEstadoMercancias_merc_Id											PRIMARY KEY (merc_Id),
	CONSTRAINT UQ_Adua_tbEstadoMercancias_merc_Codigo										UNIQUE(merc_Codigo),
	CONSTRAINT UQ_Adua_tbEstadoMercancias_merc_Descripcion									UNIQUE(merc_Descripcion),
	CONSTRAINT FK_Adua_tbEstadoMercancias_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Adua_tbEstadoMercancias_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Adua_tbEstadoMercancias_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios(usua_Id)
);
GO

CREATE TABLE Adua.tbAranceles(
	aran_Id						INT IDENTITY(1,1),
	aran_Codigo					NVARCHAR(100) NOT NULL,
	aran_Descripcion			NVARCHAR(MAX) NOT NULL,
	usua_UsuarioCreacion		INT NOT NULL,
	aran_FechaCreacion			DATETIME NOT NULL ,
	usua_UsuarioModificacion	INT,
	aran_FechaModificacion		DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion 	INT	DEFAULT NULL, 
	--aren_FechaEliminacion		DATETIME DEFAULT NULL, 
	aram_Estado					BIT NOT NULL DEFAULT 1

	CONSTRAINT PK_Adua_tbAranceles_aran_Id													PRIMARY KEY (aran_Id),
	CONSTRAINT UQ_Adua_tbAranceles_aran_Codigo												UNIQUE(aran_Codigo),
	CONSTRAINT FK_Adua_tbAranceles_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbAranceles_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Adua_tbAranceles_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Adua.tbItems(
	item_Id                                   INT IDENTITY(1,1),
	fact_Id									  INT NOT NULL,
	item_Cantidad                             INT NOT NULL,
	item_PesoNeto                             DECIMAL(18,2),
	item_PesoBruto                            DECIMAL(18,2),
	unme_Id                                   INT NOT NULL,
	item_IdentificacionComercialMercancias    NVARCHAR(300) NOT NULL,
	item_CaracteristicasMercancias            NVARCHAR(400) NOT NULL,
	item_Marca                                NVARCHAR(50) NOT NULL,
	item_Modelo                               NVARCHAR(100) NOT NULL,
	merc_Id                                   INT NOT NULL,
	pais_IdOrigenMercancia                    INT,
	item_Cantidad_Bultos					  INT,
	item_ClaseBulto							  NVARCHAR(100),
	item_Acuerdo							  NVARCHAR(100),
	item_ClasificacionArancelaria             CHAR(16),
	item_ValorUnitario                        DECIMAL(18,2), 
	item_GastosDeTransporte                   DECIMAL(18,2), 
	item_ValorTransaccion                     DECIMAL(18,2), 
	item_Seguro                               DECIMAL(18,2),
	item_OtrosGastos                          DECIMAL(18,2),
	item_ValorAduana                          DECIMAL(18,2),
	aran_Id									  INT,
	item_CuotaContingente                     DECIMAL(18,2),
	item_ReglasAccesorias                     NVARCHAR(MAX),
	item_CriterioCertificarOrigen             NVARCHAR(MAX),
	item_EsNuevo									  BIT,
	item_EsHibrido								  BIT,
	item_LitrosTotales							  DECIMAL(18,2),
	item_CigarrosTotales							  INT,

	usua_UsuarioCreacion                      INT NOT NULL, 
	item_FechaCreacion                        DATETIME NOT NULL ,
	usua_UsuarioModificacion                  INT,
	item_FechaModificacion                    DATETIME,
	--usua_UsuarioEliminacion 				  INT	DEFAULT NULL, 
	--item_FechaEliminacion					  DATETIME DEFAULT NULL, 
	item_Estado                               BIT NOT NULL DEFAULT 1 

	CONSTRAINT PK_Adua_tbItems_item_Id												PRIMARY KEY (item_Id),

	CONSTRAINT PK_Adua_tbItems_Adua_tbFactura_fact_Id								FOREIGN KEY (fact_Id)					REFERENCES Adua.tbFacturas (fact_Id),
	CONSTRAINT FK_Adua_tbItems_unme_Id_Adua_tbUnidadesdeMedida_unme_Id				FOREIGN KEY (unme_Id)					REFERENCES gral.tbUnidadMedidas(unme_Id),
	CONSTRAINT FK_Adua_tbItems_Adua_tbAranceles_aran_Id								FOREIGN KEY(aran_Id)					REFERENCES Adua.tbAranceles(aran_Id),
	CONSTRAINT FK_Adua_tbItems_merc_Id_Adua_tbMercancias_merc_Id					FOREIGN KEY (merc_Id)					REFERENCES Adua.tbEstadoMercancias(merc_Id),
	CONSTRAINT FK_Adua_tbItems_pais_IdOrigenMercancia_Adua_tbPais_pais_Id			FOREIGN KEY (pais_IdOrigenMercancia)	REFERENCES Gral.tbPaises(pais_Id),
    CONSTRAINT FK_Adua_tbItems_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Adua_tbItems_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id),
	--CONSTRAINT FK_Adua_tbItems_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios(usua_Id)
);
GO




CREATE TABLE Adua.tbItemsHistorial(
	hite_Id									  INT IDENTITY(1,1),
	item_Id                                   INT,
	fact_Id									  INT,
	item_Cantidad                             INT,
	item_PesoNeto                             DECIMAL(18,2),
	item_PesoBruto                            DECIMAL(18,2),
	unme_Id                                   INT,
	item_IdentificacionComercialMercancias    NVARCHAR(300),
	item_CaracteristicasMercancias            NVARCHAR(400),
	item_Marca                                NVARCHAR(50),
	item_Modelo                               NVARCHAR(100),
	merc_Id                                   INT,
	pais_IdOrigenMercancia                    INT,
	item_ClasificacionArancelaria             CHAR(16),
	item_ValorUnitario                        DECIMAL(18,2), 
	item_GastosDeTransporte                   DECIMAL(18,2), 
	item_ValorTransaccion                     DECIMAL(18,2), 
	item_Seguro                               DECIMAL(18,2),
	item_OtrosGastos                          DECIMAL(18,2),
	item_ValorAduana                          DECIMAL(18,2),

	item_CuotaContingente                     DECIMAL(18,2),
	item_ReglasAccesorias                     NVARCHAR(MAX),
	item_CriterioCertificarOrigen             NVARCHAR(MAX),

	hduc_UsuarioAccion 						  INT,
	hduc_FechaAccion 						  DATETIME,
	hduc_Accion								  NVARCHAR(100)
);
GO

-- CREATE TABLE Adua.tbFactura_Detalles
-- (
-- 	facd_Id						INT IDENTITY(1,1),
-- 	fact_Id						INT NOT NULL,
-- 	item_Id						INT NOT NULL,
-- 	usua_UsuarioCreacion		INT NOT NULL,
-- 	facd_FechaCreacion			DATETIME NOT NULL ,
-- 	usua_UsuarioModificacion	INT,
-- 	facd_FechaModificacion		DATETIME DEFAULT NULL,
-- 	usua_UsuarioEliminacion 	INT	DEFAULT NULL, 
-- 	facd_FechaEliminacion		DATETIME DEFAULT NULL, 
-- 	facd_Estado					BIT NOT NULL DEFAULT 1
	
-- 	CONSTRAINT PK_Adua_tbFacturaDetalles_facd_Id													PRIMARY KEY (facd_Id),
-- 	CONSTRAINT PK_Adua_tbFactura_fact_Id_Adua_tbFactura_Detalles_fact_Id							FOREIGN KEY (fact_Id)					REFERENCES Adua.tbFacturas (fact_Id),
-- 	CONSTRAINT FK_Adua_tbFacturaDetalles_item_Id_Adua_tbFactura_Detalles_item_Id					FOREIGN KEY (item_Id)					REFERENCES Adua.tbItems (item_Id),
-- 	CONSTRAINT FK_Adua_tbFacturaDetalles_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioCreacion)      REFERENCES Acce.tbUsuarios (usua_Id),
-- 	CONSTRAINT FK_Adua_tbFacturaDetalles_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
-- 	CONSTRAINT FK_Adua_tbFacturaDetalles_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioEliminacion) 	REFERENCES Acce.tbUsuarios (usua_Id)

-- );

CREATE TABLE Prod.tbMateriales(
	mate_Id   					INT IDENTITY(1,1),
	mate_Descripcion			NVARCHAR(200),
	subc_Id  					INT,
	--colr_Id                     INT,
	--mate_Precio					DECIMAL (18,2),
	mate_Imagen					NVARCHAR(MAX) NOT NULL,
	usua_UsuarioCreacion		INT					NOT NULL,
	mate_FechaCreacion			DATETIME			NOT NULL ,
	usua_UsuarioModificacion 	INT 			,
	mate_FechaModificacion		DATETIME DEFAULT NULL		, 
	--usua_UsuarioEliminacion 	INT	DEFAULT NULL, 
	--mate_FechaEliminacion		DATETIME DEFAULT NULL, 
	mate_Estado 				BIT					NOT NULL DEFAULT 1, 

	CONSTRAINT PK_Prod_tbMateriales_mate_Id PRIMARY KEY (mate_Id),
	--CONSTRAINT FK_Prod_tbMateriales_colr_Id_Prod_tbColores_colr_Id                                  FOREIGN KEY (colr_Id)                   REFERENCES Prod.tbColores(colr_Id),
	CONSTRAINT FK_Prod_tbMateriales_subc_Id_Prod_tbSubcategoria_subc_Id								FOREIGN KEY (subc_Id) 					REFERENCES Prod.tbSubcategoria(subc_Id),
	CONSTRAINT FK_Prod_tbMateriales_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id					FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbMateriales_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
    CONSTRAINT UQ_Prod_tbMateriales_mate_Descripcion UNIQUE(mate_Descripcion)

	--CONSTRAINT FK_Prod_tbMateriales_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id					FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

CREATE TABLE Adua.tbImpuestos(
	impu_Id						INT IDENTITY(1,1),
	impu_Descripcion			NVARCHAR(150) NOT NULL,
	
	usua_UsuarioCreacion		INT NOT NULL, 
	impu_FechaCreacion			DATETIME NOT NULL ,
	usua_UsuarioModificacion    INT,
	impu_FechaModificacion      DATETIME,
	--usua_UsuarioEliminacion 	INT	DEFAULT NULL, 
	--impu_FechaEliminacion		DATETIME DEFAULT NULL, 
	impu_Estado					BIT NOT NULL DEFAULT 1
	CONSTRAINT PK_Adua_tbImpuestos_impu_Id													PRIMARY KEY (impu_Id),
	CONSTRAINT FK_Adua_tbImpuestos_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbImpuestos_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT UQ_Adua_tbImpuestos_impu_Descripcion											UNIQUE (impu_Descripcion)
	--CONSTRAINT FK_Adua_tbImpuestos_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Adua.tbImpuestosPorArancel( 
    imar_Id						INT IDENTITY(1,1),
	impu_Id						INT NOT NULL,
	aran_Id						INT NOT NULL,
	imar_PorcentajeImpuesto		DECIMAL(18,2),
	usua_UsuarioCreacion		INT NOT NULL, 
	imar_FechaCreacion			DATETIME NOT NULL ,
	usua_UsuarioModificacion    INT,
	imar_FechaModificacion		DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion 	INT	DEFAULT NULL, 
	--imar_FechaEliminacion		DATETIME DEFAULT NULL, 
	imar_Estado					BIT NOT NULL DEFAULT 1,
	
	CONSTRAINT PK_Adua_tbImpuestosPorArancel_imar_Id											PRIMARY KEY (imar_Id),
	CONSTRAINT FK_Adua_tbImpuestoPorArancel_imar_Id_Adua_tbImpuesto_impu_Id						FOREIGN KEY (impu_Id)					REFERENCES Adua.tbImpuestos(impu_Id),
	CONSTRAINT FK_Adua_tbImpuestoPorArancel_aran_Id_Adua_tbAranceles_aran_Id					FOREIGN KEY (aran_Id)					REFERENCES Adua.tbAranceles(aran_Id),
    CONSTRAINT FK_Adua_tbImpuestosPorArancel_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Adua_tbImpuestosPorArancel_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id),
	--CONSTRAINT FK_Adua_tbImpuestosPorArancel_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios(usua_Id)
);
GO


--Sección #4 Alex
CREATE TABLE Adua.tbTipoLiquidacion (
	tipl_Id             		INT IDENTITY(1,1),
	tipl_Descripcion    		NVARCHAR(200)  NOT NULL,
    
	usua_UsuarioCreacion       	INT NOT NULL,
    tipl_FechaCreacion         	DATETIME NOT NULL,
    usua_UsuarioModificacion   	INT DEFAULT NULL,
    tipl_FechaModificacion     	DATETIME DEFAULT NULL,
    tipl_Estado                	BIT DEFAULT 1,
	
   	CONSTRAINT PK_Adua_tbTipoLiquidacion_tipl_Id PRIMARY KEY (tipl_Id),
	CONSTRAINT UQ_Adua_tbTipoLiquidacion_tipl_Descripcion UNIQUE (tipl_Descripcion),
	CONSTRAINT FK_Adua_tbTipoLiquidacion_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios (usua_Id),
   	CONSTRAINT FK_Adua_tbTipoLiquidacion_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Adua.tbEstadoBoletin (
    esbo_Id           			INT IDENTITY(1,1),
    esbo_Descripcion  			NVARCHAR(200) NOT NULL,
    
    usua_UsuarioCreacion       	INT NOT NULL,
    esbo_FechaCreacion         	DATETIME NOT NULL,
    usua_UsuarioModificacion   	INT DEFAULT NULL,
    esbo_FechaModificacion     	DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--esbo_FechaEliminacion		DATETIME DEFAULT NULL,
    esbo_Estadoo               	BIT DEFAULT 1,

 	CONSTRAINT PK_Adua_tbEstadoBoletin_esbo_Id PRIMARY KEY (esbo_Id),
	CONSTRAINT UQ_Adua_tbEstadoBoletin_esbo_Descripcion UNIQUE (esbo_Descripcion),
 	CONSTRAINT FK_Adua_tbEstadoBoletin_esbo_UsuarioCreacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
 	CONSTRAINT FK_Adua_tbEstadoBoletin_esbo_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
 	--CONSTRAINT FK_Adua_tbEstadoBoletin_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

CREATE TABLE Adua.tbConceptoPago (
    copa_Id           			INT IDENTITY(1,1),
    copa_Descripcion  			NVARCHAR(200) NOT NULL,
   
	usua_UsuarioCreacion       	INT NOT NULL,
    copa_FechaCreacion         	DATETIME NOT NULL,
    usua_UsuarioModificacion   	INT DEFAULT NULL,
    copa_FechaModificacion     	DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--copa_FechaEliminacion		DATETIME DEFAULT NULL,
    copa_Estado                	BIT DEFAULT 1,

	CONSTRAINT PK_Adua_tbConceptoPago_copa_Id PRIMARY KEY (copa_Id),
	CONSTRAINT UQ_Adua_tbConceptoPago_copa_Descripcion UNIQUE(copa_Descripcion),
	CONSTRAINT FK_Adua_tbConceptoPago_copa_UsuarioCreacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbConceptoPago_copa_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Adua_tbConceptoPago_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

CREATE TABLE Prod.tbClientes(
	clie_Id						INT IDENTITY(1,1),
	clie_Nombre_O_Razon_Social	NVARCHAR(200)NOT NULL,
	clie_Direccion				NVARCHAR(250)NOT NULL,
	clie_RTN					NVARCHAR(40)NOT NULL,
	clie_Nombre_Contacto		NVARCHAR(200)NOT NULL,
	clie_Numero_Contacto		VARCHAR(15)NOT NULL,
	clie_Correo_Electronico		NVARCHAR(200)NOT NULL,
	clie_FAX					NVARCHAR(50),
	pvin_Id						INT NOT NULL,

	usua_UsuarioCreacion       	INT NOT NULL,
	clie_FechaCreacion         	DATETIME NOT NULL,
	usua_UsuarioModificacion   	INT DEFAULT NULL,
	clie_FechaModificacion     	DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	clie_FechaEliminacion		DATETIME DEFAULT NULL,
    clie_Estado                	BIT DEFAULT 1,
	
	CONSTRAINT PK_Prod_tbClientes_clie_Id											PRIMARY KEY	(clie_Id),
	CONSTRAINT UQ_Prod_tbClientes_clie_Numero_Contacto								UNIQUE ([clie_Numero_Contacto]),
	CONSTRAINT UQ_Prod_tbClientes_clie_Correo_Electronico							UNIQUE ([clie_Correo_Electronico]),
	CONSTRAINT UQ_Prod_tbClientes_clie_FAX											UNIQUE (clie_FAX),
	CONSTRAINT UQ_Prod_tbClientes_clie_RTN											UNIQUE (clie_RTN),
	CONSTRAINT FK_Prod_tbClientes_pvin_Id_Gral_tbProvincias_pvin_Id					FOREIGN KEY (pvin_Id)					REFERENCES Gral.tbProvincias (pvin_Id),
	CONSTRAINT FK_Prod_tbClientes_clie_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbClientes_clie_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbClientes_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioEliminacion)	REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

CREATE TABLE Adua.tbCodigoImpuesto (
    coim_Id          			INT IDENTITY(1,1),
    coim_Descripcion 			NVARCHAR(200)  NOT NULL,
    
	usua_UsuarioCreacion       	INT NOT NULL,
    coim_FechaCreacion         	DATETIME NOT NULL,
    usua_UsuarioModificacion   	INT DEFAULT NULL,
    coim_FechaModificacion     	DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	coim_FechaEliminacion		DATETIME DEFAULT NULL,
    coim_Estado                	BIT DEFAULT 1,

	CONSTRAINT PK_Adua_tbCodigoImpuesto_coim_Id PRIMARY KEY (coim_Id),
	CONSTRAINT UQ_Adua_tbCodigoImpuesto_coim_Descripcion UNIQUE (coim_Descripcion),
	CONSTRAINT FK_Adua_tbCodigoImpuesto_coim_UsuarioCreacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios (usua_Id),
    CONSTRAINT FK_Adua_tbCodigoImpuesto_coim_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
    CONSTRAINT FK_Adua_tbCodigoImpuesto_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios (usua_Id),
);
GO


--CREATE TABLE Adua.tbFormaPresentacion (
--    pres_Id 					INT IDENTITY(1,1),
--    pres_Descripcion 			NVARCHAR(200) NOT NULL,
	
--	usua_UsuarioCreacion       	INT NOT NULL,
--    pres_FechaCreacion         	DATETIME NOT NULL,
--    usua_UsuarioModificacion   	INT DEFAULT NULL,
--    pres_FechaModificacion     	DATETIME DEFAULT NULL,
--	usua_UsuarioEliminacion		INT DEFAULT NULL,
--	pres_FechaEliminacion		DATETIME DEFAULT NULL,
--    Pres_Estado                	BIT DEFAULT 1,
	
--	CONSTRAINT PK_Adua_tbFormaPresentacion_pres_Id PRIMARY KEY (pres_Id),
--	CONSTRAINT FK_Adua_tbFormaPresentacion_pres_UsuarioCreacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios (usua_Id),
--	CONSTRAINT FK_Adua_tbFormaPresentacion_pres_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
--	CONSTRAINT FK_Adua_tbFormaPresentacion_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios (usua_Id),
	
--);
--GO

CREATE TABLE Gral.tbOficio_Profesiones(
	ofpr_Id						INT IDENTITY(1,1),
	ofpr_Nombre 				NVARCHAR(150) NOT NULL,
		
	usua_UsuarioCreacion        INT NOT NULL,
	ofpr_FechaCreacion          DATETIME NOT NULL,
	usua_UsuarioModificacion    INT DEFAULT NULL,
	ofpr_FechaModificacion      DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--ofpr_FechaEliminacion		DATETIME DEFAULT NULL,
	ofpr_Estado                	BIT DEFAULT 1,
	
	CONSTRAINT PK_Gral_tbOficinasProfesiones_ofpr_Id PRIMARY KEY (ofpr_Id),
	CONSTRAINT UQ_Gral_tbOficinasProfesiones_ofpr_Nombre UNIQUE(ofpr_Nombre),
	CONSTRAINT FK_Gral_tbOficio_Profesiones_ofpr_UsuarioCreacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Gral_tbOficio_Profesiones_ofpr_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id),
	--CONSTRAINT FK_Gral_tbOficio_Profesiones_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios(usua_Id),
);
GO

CREATE TABLE Adua.tbPersonas (
	pers_Id 					INT IDENTITY(1,1),
	pers_RTN 					NVARCHAR(40) NOT NULL,
	pers_Nombre					NVARCHAR(150) NOT NULL,
	ofic_Id 					INT NOT NULL,
	escv_Id 					INT NOT NULL,
	ofpr_Id 					INT NOT NULL,
	pers_escvRepresentante 		INT,
	pers_OfprRepresentante 		INT ,
 
	usua_UsuarioCreacion      	INT NOT NULL,
	pers_FechaCreacion        	DATETIME NOT NULL,
	usua_UsuarioModificacion  	INT DEFAULT NULL,
	pers_FechaModificacion    	DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--pers_FechaEliminacion		DATETIME DEFAULT NULL,
	pers_Estado               	BIT	DEFAULT 1,

	CONSTRAINT PK_Adua_tbPersonas_pers_Id PRIMARY KEY (pers_Id),
	CONSTRAINT UQ_Adua_tbPersonas_pers_RTN UNIQUE (pers_RTN),
	CONSTRAINT FK_Adua_Personas_ofic_Id_Gral_Oficina_ofic_Id FOREIGN KEY (ofic_Id) REFERENCES Gral.tbOficinas(ofic_Id),
	CONSTRAINT FK_Adua_Personas_escv_Id_Gral_EstadoCivil_escv_Id FOREIGN KEY (escv_Id) REFERENCES Gral.tbEstadosCiviles(escv_Id),
	CONSTRAINT FK_Adua_Personas_ofpr_Id_Gral_OficioProfesion_ofpr_Id FOREIGN KEY (ofpr_Id) REFERENCES Gral.tbOficio_Profesiones(ofpr_Id),
	--CONSTRAINT FK_Adua_Personas_fopr_Id_Adua_FormaPresentacion_pres_Id FOREIGN KEY (fopr_Id) REFERENCES Adua.tbFormaPresentacion(pres_Id),
	CONSTRAINT FK_Adua_Personas_pers_escvRepresentante_EstadoCivilRepresentante_escv_Id FOREIGN KEY (pers_escvRepresentante) REFERENCES Gral.tbEstadosCiviles(escv_Id),
	CONSTRAINT FK_Adua_Personas_pers_OfprRepresentante_OficioProfesionRepresentante_escv_Id FOREIGN KEY (pers_OfprRepresentante) REFERENCES Gral.tbOficio_Profesiones(ofpr_Id),
  
	CONSTRAINT FK_Adua_Personas_pers_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_Personas_pers_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Adua_Personas_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

CREATE TABLE Adua.tbComercianteIndividual (
  	coin_Id                           	INT IDENTITY(1,1),
  	pers_Id                           	INT NOT NULL,

  	pers_FormaRepresentacion 			BIT NOT NULL,
	ciud_Id								INT, --nuevo
	alde_Id								INT,  --nuevo
	colo_Id								INT, -- nuevo
	coin_NumeroLocalApart				NVARCHAR(150), --nuevo
	coin_coloniaIdRepresentante			INT, --nuevo
	coin_NumeroLocaDepartRepresentante	NVARCHAR(150),-- nuevo

  	coin_PuntoReferencia			  	NVARCHAR(200),
	coin_CiudadRepresentante			INT, -- nuevo
	coin_AldeaRepresentante		  		INT, -- nuevo

  	coin_PuntoReferenciaReprentante   	NVARCHAR(200),
  	coin_TelefonoCelular			    NVARCHAR(20),
  	coin_TelefonoFijo				    NVARCHAR(20),
  	coin_CorreoElectronico		    	NVARCHAR(30),
  	coin_CorreoElectronicoAlternativo 	NVARCHAR(30),
	
  	usua_UsuarioCreacion       			INT NOT NULL,
  	coin_FechaCreacion         			DATETIME NOT NULL,
  	usua_UsuarioModificacion   			INT DEFAULT NULL,
  	coin_FechaModificacion     			DATETIME DEFAULT NULL,	
	--usua_UsuarioEliminacion		    INT DEFAULT NULL,
	--coin_FechaEliminacion		        DATETIME DEFAULT NULL,
  	coin_Estado                			BIT DEFAULT 1,
	coin_Finalizacion					BIT DEFAULT 0
  
  	CONSTRAINT PK_Adua_tbComercianteIndividual_coin_Id PRIMARY KEY (coin_Id),
  	CONSTRAINT FK_ComercianteIndividual_pers_Id_Adua_Personas_pers_Id                           FOREIGN KEY (pers_Id) REFERENCES Adua.tbPersonas(pers_Id),
	CONSTRAINT FK_ComercianteIndividual_alde_Id_Gral_tbAldeas		                            FOREIGN KEY (alde_Id) REFERENCES Gral.tbAldeas(alde_Id),--nuevo
	CONSTRAINT FK_ComercianteIndividual_coin_AldeaRepresentante_Gral_tbAldeas		            FOREIGN KEY (coin_AldeaRepresentante) REFERENCES Gral.tbAldeas(alde_Id), -- nuevo
	CONSTRAINT FK_ComercianteIndividual_colo_Id_Gral_tbColonia									FOREIGN KEY (colo_Id) REFERENCES Gral.tbColonias(colo_Id), --nuevo
	CONSTRAINT FK_ComercianteIndividual_coin_coloniaIdRepresentante_Gral_tbColonias				FOREIGN KEY (coin_coloniaIdRepresentante) REFERENCES Gral.tbColonias(colo_Id), --nuevo
    CONSTRAINT FK_ComercianteIndividual_ciud_Id_Gral_tbCiudades	                                FOREIGN KEY (ciud_Id) REFERENCES Gral.tbCiudades(ciud_Id), -- nuevo
	CONSTRAINT FK_ComercianteIndividual_coin_CiudadRepresentante_Gral_tbCiudades				FOREIGN KEY (coin_CiudadRepresentante) REFERENCES Gral.tbCiudades(ciud_Id), --nuevo

  
  	CONSTRAINT FK_Adua_ComercianteIndividual_coin_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
  	CONSTRAINT FK_Adua_ComercianteIndividual_coin_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
  	--CONSTRAINT FK_Adua_ComercianteIndividual_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
	
);
GO





CREATE TABLE Adua.tbPersonaNatural (
	pena_Id						INT IDENTITY(1,1),
  	pers_Id						INT NOT NULL,
  	pena_DireccionExacta		NVARCHAR(200) NOT NULL,
  	ciud_Id						INT NOT NULL,
  	pena_TelefonoFijo			NVARCHAR(20),
  	pena_TelefonoCelular		NVARCHAR(20),
  	pena_CorreoElectronico		NVARCHAR(50) NOT NULL,
  	pena_CorreoAlternativo		NVARCHAR(50),
  	pena_RTN					NVARCHAR(40) NOT NULL,
  	pena_ArchivoRTN				NVARCHAR(MAX) NOT NULL,
  	pena_DNI					NVARCHAR(40) NOT NULL,
  	pena_ArchivoDNI				NVARCHAR(MAX) NOT NULL,
  	pena_NumeroRecibo			VARCHAR(100) NOT NULL,
  	pena_ArchivoNumeroRecibo	NVARCHAR(MAX) NOT NULL,

    pena_NombreArchDNI			NVARCHAR(200),
	pena_NombreArchRTN			NVARCHAR(200),
	pena_NombreArchRecibo		NVARCHAR(200),
	pena_Finalizado				BIT DEFAULT 0,
  	usua_UsuarioCreacion       	INT NOT NULL,
  	pena_FechaCreacion         	DATETIME NOT NULL,
  	usua_UsuarioModificacion   	INT DEFAULT NULL,
  	pena_FechaModificacion     	DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--pena_FechaEliminacion		DATETIME DEFAULT NULL,
  	pena_Estado                	BIT	DEFAULT 1,

  	CONSTRAINT PK_Adua_tbPersonaNatural_pena_Id PRIMARY KEY (pena_Id),
  
  	CONSTRAINT FK_Adua_PersonaNatural_pers_Id_Adua_Persona_pers_Id FOREIGN KEY (pers_Id) REFERENCES Adua.tbPersonas(pers_Id),
  	CONSTRAINT FK_Adua_PersonaNatural_ciud_Id_Gral_Ciudades FOREIGN KEY (ciud_Id) REFERENCES Gral.tbCiudades(ciud_Id),
 
  	CONSTRAINT FK_Adua_PersonaNatural_pena_UsuarioCreacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
  	CONSTRAINT FK_Adua_PersonaNatural_pena_UsuarioModificacion_Acce_tbUsuarios_usua_Id	    FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Adua_PersonaNatural_pena_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


CREATE TABLE Adua.tbPersonaJuridica (
	peju_Id							  				INT IDENTITY(1,1) ,
	pers_Id							  				INT NOT NULL,

	colo_Id							  				INT ,
	ciud_Id                                         INT,   -- nuevo
	alde_Id								            INT,            --nuevo
	peju_PuntoReferencia							NVARCHAR(200),
	peju_NumeroLocalApart				            NVARCHAR(150),  --nuevo

    peju_CiudadIdRepresentante                      INT,            --nuevo
	peju_ColoniaRepresentante						INT ,   --nuevo
	peju_AldeaIdRepresentante                       INT,            --nuevo
	peju_NumeroLocalRepresentante		  			NVARCHAR(200),
	peju_PuntoReferenciaRepresentante	  			NVARCHAR(200) ,

	peju_TelefonoEmpresa							NVARCHAR(200) ,
	peju_TelefonoFijoRepresentanteLegal 			NVARCHAR(200) ,
	peju_TelefonoRepresentanteLegal	  				NVARCHAR(200) ,
	peju_CorreoElectronico              			NVARCHAR(200),
	peju_CorreoElectronicoAlternativo   			NVARCHAR(200) ,
    peju_ContratoFinalizado                         BIT,
	usua_UsuarioCreacion       						INT NOT NULL,
	peju_FechaCreacion         						DATETIME NOT NULL,
	usua_UsuarioModificacion   						INT DEFAULT NULL,
	peju_FechaModificacion     						DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion							INT DEFAULT NULL,
	--peju_FechaEliminacion							DATETIME DEFAULT NULL,
	peju_Estado                						BIT DEFAULT 1,

	CONSTRAINT PK_Adua_tbPersonaJuridica_peju_Id PRIMARY KEY (peju_Id),
	CONSTRAINT FK_Adua_tbPersonaJuridica_pers_Id_Adua_Personas_pers_Id                               FOREIGN KEY (pers_Id)                    REFERENCES Adua.tbPersonas(pers_Id),
	CONSTRAINT FK_Adua_tbPersonaJuridica_colo_Id_Gral_tbColonias_colo_Id                             FOREIGN KEY (colo_Id)                    REFERENCES Gral.tbColonias(colo_Id),
	CONSTRAINT FK_Adua_tbPersonaJuridica_peju_ColoniaRepresentante_Gral_ColoniaRepresentante_colo_Id FOREIGN KEY (peju_ColoniaRepresentante)  REFERENCES Gral.tbColonias(colo_Id),
	CONSTRAINT FK_Adua_tbPersonaJuridica_alde_Id_tbAldeas                                            FOREIGN KEY (alde_Id)                    REFERENCES Gral.tbAldeas(alde_Id),
	CONSTRAINT FK_Adua_tbPersonaJuridica_AldeaIdRepresentante_tbAldea                                FOREIGN KEY (peju_AldeaIdRepresentante)  REFERENCES Gral.tbAldeas(alde_Id),
	CONSTRAINT FK_Adua_tbPersonaJuridica_Ciudad_Id_tbCiudad                                          FOREIGN KEY (ciud_Id)                    REFERENCES Gral.tbCiudades(ciud_Id),
	CONSTRAINT FK_Adua_tbPersonaJuridica_CiudadIdRepresentante_tbCiudad                              FOREIGN KEY (peju_CiudadIdRepresentante) REFERENCES Gral.tbCiudades(ciud_Id),
	CONSTRAINT FK_Adua_PersonaJuridica_peju_UsuarioCreacion_Acce_tbUsuarios_usua_Id			  	     FOREIGN KEY (usua_UsuarioCreacion)       REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_PersonaJuridica_peju_UsuarioModificacion_Acce_tbUsuarios_usua_Id		         FOREIGN KEY (usua_UsuarioModificacion)   REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Adua_PersonaJuridica_peju_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

--Se identificarán los tipos de documentos según acortaciones
--RTN-CI:  REGISTRO TRIBUTARIO NACIONAL (RTN) DEL COMERCIANTE INDIVIDUAL
--DNI-CI:  DOCUMENTO O TARJETA DE IDENTIDAD DEL COMERCIANTE INDIVIDUAL
--RTN-RL:  REGISTRO TRIBUTARIO NACIONAL (RTN) DEL REPRESENTANTE LEGAL (SI HA INFORMADO REPRESENTACION BAJO REPRESENTANTE LEGAL)
--DNI-RL:  DOCUMENTO O TARJETA DE IDENTIDAD DEL REPRESENTANTE LEGAL (SI HA INFORMADO REPRESENTACION BAJO REPRESENTANTE LEGAL)
--DECL-CI: DECLARACIÓN DE COMERCIANTE INDIVIDUAL Y SUS MODIFICACIONES SI LAS HUBIERA
--RTN-SM:  REGISTRO TRIBUTARIO NACIONAL (RTN) DE LA SOCIEDAD MERCANTIL
--EPC-SM:  ESCRITURA PUBLICA DE CONSTITUCIÓN Y SUS MODIFICACIONES SI LAS HUBIERA (DE LA SOCIEDAD MERCANTIL)

CREATE TABLE Adua.tbDocumentosContratos(
	doco_Id								INT IDENTITY(1,1),
	coin_Id								INT,
	peju_Id								INT,
	doco_Numero_O_Referencia			NVARCHAR(50) NOT NULL,
	doco_TipoDocumento					NVARCHAR(7),
	doco_URLImagen                      NVARCHAR(MAX),
	doco_NombreImagen                   NVARCHAR(350),

	usua_UsuarioCreacion       			INT NOT NULL,
  	doco_FechaCreacion         			DATETIME NOT NULL,
  	usua_UsuarioModificacion   			INT DEFAULT NULL,
  	doco_FechaModificacion     			DATETIME DEFAULT NULL,	
  	doco_Estado                			BIT DEFAULT 1,

	CONSTRAINT PK_Adua_tbDocumentosContratos_doco_Id PRIMARY KEY(doco_Id),
	CONSTRAINT CK_Adua_tbDocumentosContratos_doco_TipoDocumento CHECK(doco_TipoDocumento IN('RTN-CI', 'DNI-CI', 'RTN-RL', 'DNI-RL', 'DECL-CI', 'RTN-SM', 'EPC-SM')),
	CONSTRAINT FK_Adua_tbDocumentosContratos_tbComercianteIndividual_coin_Id						  FOREIGN KEY(coin_Id)					 REFERENCES Adua.tbComercianteIndividual(coin_Id),
	CONSTRAINT FK_Adua_tbDocumentosContratos_tbPersonaJuridica_peju_Id								  FOREIGN KEY(peju_Id)					 REFERENCES Adua.tbPersonaJuridica(peju_Id),
	CONSTRAINT FK_Adua_tbDocumentosContratos_coin_UsuarioCreacion_Acce_tbUsuarios_usua_Id		   	  FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
  	CONSTRAINT FK_Adua_tbDocumentosContratos_coin_UsuarioModificacion_Acce_tbUsuarios_usua_Id		  FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id)
);


-----------------------------------------------------------


--**********************************************************--
--*******************  PRODUCCION **************************--
--**********************************************************--

------------------Orden de Servicio---------------------------

CREATE TABLE Prod.tbOrdenCompra(
	orco_Id						INT IDENTITY(1,1),
	orco_IdCliente				INT NOT NULL,
	orco_Codigo					NVARCHAR(100)  NOT NULL,	
	orco_FechaEmision			DATETIME NOT NULL,
	orco_FechaLimite			DATETIME NOT NULL,
	orco_MetodoPago 			INT NOT NULL,
	orco_Materiales				BIT NOT NULL,
	orco_IdEmbalaje 			INT NOT NULL,
	orco_EstadoOrdenCompra		CHAR(1) NOT NULL,
	orco_DireccionEntrega		NVARCHAR(250)NOT NULL,
	orco_EstadoFinalizado       BIT DEFAULT 0 NOT NULL,
	usua_UsuarioCreacion       	INT NOT NULL,
	orco_FechaCreacion         	DATETIME NOT NULL,
	usua_UsuarioModificacion   	INT DEFAULT NULL,
	orco_FechaModificacion     	DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--orco_FechaEliminacion		DATETIME DEFAULT NULL,
	orco_Estado                	BIT DEFAULT 1,

	CONSTRAINT PK_Prod_tbOrdenCompra_orco_Id PRIMARY KEY(orco_Id),
	CONSTRAINT FK_Prod_tbOrdenCompra_orco_IdCliente_Prod_tbClientes_clie_Id              FOREIGN KEY(orco_IdCliente)  REFERENCES	Prod.tbClientes(clie_Id),
	CONSTRAINT FK_Prod_tbOrdenCompra_orco_MetodoPago_Gral_tbFormasPago_mepa_Id           FOREIGN KEY(orco_MetodoPago) REFERENCES	Adua.tbFormasdePago(fopa_Id),
	CONSTRAINT FK_Prod_tbOrdenCompra_orco_IdEmbalaje_Prod_tbTipoEmbalaje_emba_Id         FOREIGN KEY(orco_IdEmbalaje) REFERENCES	Prod.tbTipoEmbalaje(tiem_Id),
	
	CONSTRAINT FK_Prod_tbOrdenCompra_orco_UsuarioCreacion_Acce_tbUsuarios_usua_Id					FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbOrdenCompra_orco_UsuarioModificacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Prod_tbOrdenCompra_orco__Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

CREATE TABLE Prod.tbTallas(
	tall_Id						INT IDENTITY(1,1),
	tall_Codigo 				CHAR(5),
	tall_Nombre					NVARCHAR(200) NOT NULL,
	
	usua_UsuarioCreacion       	INT NOT NULL,
	tall_FechaCreacion         	DATETIME NOT NULL,
	usua_UsuarioModificacion   	INT DEFAULT NULL,
	tall_FechaModificacion     	DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	tall_FechaEliminacion		DATETIME DEFAULT NULL,
	tall_Estado                	BIT	DEFAULT 1,

	CONSTRAINT PK_Prod_tbTalla_tall_Id														PRIMARY KEY (tall_Id),
	CONSTRAINT UQ_Prod_tbTallas_tall_Codigo													UNIQUE (tall_Codigo),
	CONSTRAINT UQ_Prod_tbTallas_tall_Nombre													UNIQUE (tall_Nombre),
	CONSTRAINT FK_Prod_tbOrdenCompra_tall_UsuarioCreacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbOrdenCompra_tall_UsuarioModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbOrdenCompra_tall__Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
)
GO


--Campo proc_IdActual = si es 0 está pendiente, si tiene un número está asignado a un proceso, si es null ya terminó
CREATE TABLE Prod.tbOrdenCompraDetalles(
	code_Id						INT IDENTITY(1,1),
	orco_Id						INT NOT NULL,
	code_CantidadPrenda			INT NOT NULL,
	esti_Id						INT NOT NULL,
	tall_Id						INT NOT NULL,
	code_Sexo					CHAR(1) NOT NULL,
	colr_Id						INT NOT NULL,
	proc_IdComienza				INT NOT NULL,
	proc_IdActual				INT NOT NULL,
	code_Unidad					DECIMAL(18,2) NOT NULL,
	code_Valor					DECIMAL(18,2) NOT NULL,
	code_Impuesto				DECIMAL(18,2) NOT NULL,
	code_EspecificacionEmbalaje	NVARCHAR(200) NOT NULL,
	
	usua_UsuarioCreacion       	INT NOT NULL,
	code_FechaCreacion         	DATETIME NOT NULL,
	usua_UsuarioModificacion   	INT DEFAULT NULL,
	code_FechaModificacion     	DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--code_FechaEliminacion		DATETIME DEFAULT NULL,
	code_FechaProcActual		DATETIME,
	code_Estado                	BIT DEFAULT 1,
	
	CONSTRAINT PK_Prod_tbOrdenCompraDetalles_code_Id PRIMARY KEY(code_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_orco_Id_Prod_tbOrdenCompra_orco_Id			 FOREIGN KEY(orco_Id) REFERENCES Prod.tbOrdenCompra(orco_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_esti_Id_Prod_tbEstilos_esti_Id				 FOREIGN KEY(esti_Id) REFERENCES Prod.tbEstilos(esti_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_colr_Id_Prod_tbColores_colr_Id				 FOREIGN KEY (colr_Id) REFERENCES Prod.tbColores(colr_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_tall_Id_Prod_tbTalla_tall_Id				 FOREIGN KEY(tall_Id) REFERENCES Prod.tbTallas(tall_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_proc_IdComienza_Prod_tbProcesos_proc_Id     FOREIGN KEY(proc_IdComienza) REFERENCES Prod.tbProcesos(proc_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_proc_IdActual_Prod_tbProcesos_proc_Id       FOREIGN KEY(proc_IdActual) REFERENCES Prod.tbProcesos(proc_Id),
	CONSTRAINT CK_Prod_tbOrdenCompraDetalles_code_Sexo									 CHECK (code_Sexo IN ('F','M','U')),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_code_UsuarioCreacion_Acce_tbUsuarios_usua_Id					FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_code_UsuarioModificacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Prod_tbOrdenCompraDetalles__Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


CREATE TABLE Prod.tbProcesoPorOrdenCompraDetalle(
	poco_Id						INT IDENTITY(1,1),
	code_Id						INT NOT NULL,
	proc_Id						INT NOT NULL,

	usua_UsuarioCreacion       	INT				 NOT NULL,
	poco_FechaCreacion         	DATETIME		 NOT NULL,
	usua_UsuarioModificacion   	INT DEFAULT		 NULL,
	poco_FechaModificacion     	DATETIME DEFAULT NULL,
	code_Estado                	BIT DEFAULT 1

	CONSTRAINT PK_Prod_tbProcesoPorOrdenCompraDetalle_poco_Id											PRIMARY KEY(poco_Id),
	CONSTRAINT FK_Prod_tbProcesoPorOrdenCompraDetalle_code_Id_Prod_tbOrdenCompraDetalles_code_Id		FOREIGN KEY(code_Id) REFERENCES Prod.tbOrdenCompraDetalles(code_Id),
	CONSTRAINT FK_Prod_tbProcesoPorOrdenCompraDetalle_proc_Id_Prod_tbProcesos_proc_Id					FOREIGN KEY(proc_Id) REFERENCES Prod.tbProcesos(proc_Id),
	CONSTRAINT FK_Prod_tbProcesoPorOrdenCompraDetalle_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY(usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbProcesoPorOrdenCompraDetalle_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY(usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Prod.tbDocumentosOrdenCompraDetalles(
	dopo_Id						INT IDENTITY(1,1),
	code_Id						INT				 NOT NULL,
	dopo_NombreArchivo          NVARCHAR(MAX)    NOT NULL,
	dopo_Archivo				NVARCHAR(MAX)	 NOT NULL,
	dopo_TipoArchivo			NVARCHAR(40)	 NOT NULL,
												 
	usua_UsuarioCreacion       	INT				 NOT NULL,
	dopo_FechaCreacion         	DATETIME		 NOT NULL,
	usua_UsuarioModificacion   	INT DEFAULT		 NULL,
	dopo_FechaModificacion     	DATETIME DEFAULT NULL,
	code_Estado                	BIT DEFAULT 1

	CONSTRAINT PK_Prod_tbDocumentosOrdenCompraDetalles_dopo_Id											PRIMARY KEY(dopo_Id),
	CONSTRAINT FK_Prod_tbDocumentosOrdenCompraDetalles_tbOrdenCompraDetalles_code_Id					FOREIGN KEY(code_Id)					REFERENCES Prod.tbOrdenCompraDetalles(code_Id),
	CONSTRAINT FK_Prod_tbDocumentosOrdenCompraDetalles_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY(usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbDocumentosOrdenCompraDetalles_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY(usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Prod.tbMaterialesBrindar(
	mabr_Id						INT IDENTITY(1,1),
	code_Id						INT NOT NULL,
	mate_Id						INT NOT NULL,
	mabr_Cantidad				INT NOT NULL,
    unme_Id                     INT NOT NULL,
	
	usua_UsuarioCreacion       	INT NOT NULL,
	mabr_FechaCreacion         	DATETIME NOT NULL,
	usua_UsuarioModificacion   	INT DEFAULT NULL,
	mabr_FechaModificacion     	DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--mabr_FechaEliminacion		DATETIME DEFAULT NULL,
	mabr_Estado                	BIT DEFAULT 1,

	CONSTRAINT PK_Prod_tbMaterialesBrindar_mabr_Id PRIMARY KEY(mabr_Id),
	CONSTRAINT FK_Prod_tbtbMaterialesBrindar_code_Id_Prod_tbOrdenCompraDetalles_code_Id 			FOREIGN KEY(code_Id) REFERENCES  Prod.tbOrdenCompraDetalles(code_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_mate_Id_Prod_tbMateriales_mate_Id 						FOREIGN KEY(mate_Id) REFERENCES  Prod.tbMateriales(mate_Id),
	CONSTRAINT FK_Prod_tbOrdenCompraDetalles_unme_Id_Gral_tbUnidadMedidas                           FOREIGN KEY(unme_Id) REFERENCES  Gral.tbUnidadMedidas(unme_Id),
	CONSTRAINT FK_Prod_tbMaterialesBrindar_mabr_UsuarioCreacion_Acce_tbUsuarios_usua_Id         	FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbMaterialesBrindar_mabr_UsuarioModificacion_Acce_tbUsuarios_code_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Prod_tbMaterialesBrindar_mabr__Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
)
GO


CREATE TABLE Prod.tbModulos(
	modu_Id						INT IDENTITY(1,1),
	modu_Nombre					NVARCHAR(150) NOT NULL,
	proc_Id						INT NOT NULL,
	empr_Id 					INT NOT NULL,
	
	usua_UsuarioCreacion       	INT NOT NULL,
	modu_FechaCreacion         	DATETIME NOT NULL,
	usua_UsuarioModificacion   	INT DEFAULT NULL,
	modu_FechaModificacion     	DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	modu_FechaEliminacion		DATETIME DEFAULT NULL,
	modu_Estado                	BIT DEFAULT 1,

	CONSTRAINT PK_Prod_tbModulos_modu_Id 									 PRIMARY KEY (modu_Id),
	CONSTRAINT FK_Prod_tbModulos_proc_Id_Prod_tbProcesos_proc_Id 			 FOREIGN KEY (proc_Id) REFERENCES Prod.tbProcesos(proc_Id),
	CONSTRAINT FK_Prod_tbModulos_empr_Id_Gral_tbEmpleados_empe_IdSupervisor  FOREIGN KEY (empr_Id) REFERENCES Gral.tbEmpleados(empl_Id),
	CONSTRAINT UQ_Prod_tbModulos_modu_Nombre								 UNIQUE (modu_Nombre),
	CONSTRAINT FK_Prod_tbModulos_modu_UsuarioCreacion_Acce_tbUsuarios_usua_Id				FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbModulos_modu_UsuarioModificacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbModulos_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO	

------------------Planificación y programación----------------

CREATE TABLE Prod.tbMarcasMaquina(
	marq_Id							INT IDENTITY(1,1),
	marq_Nombre						NVARCHAR(250)NOT NULL,

	usua_UsuarioCreacion			INT NOT NULL,
	marq_FechaCreacion				DATETIME NOT NULL,
	usua_UsuarioModificacion		INT DEFAULT NULL,
	marq_FechaModificacion			DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion			INT DEFAULT NULL,
	marq_FechaEliminacion			DATETIME DEFAULT NULL,
	marq_Estado						BIT	DEFAULT 1
	
	CONSTRAINT PK_Prod_tbMarcasMaquina_marq_Id 										PRIMARY KEY (marq_Id),
	CONSTRAINT UQ_Prod_tbMarcasMaquina_marq_Nombre									UNIQUE (marq_Nombre),
	CONSTRAINT FK_Prod_tbMarcasMaquina_usua_UsuarioCreacion_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)     			REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbMarcasMaquina_usua_UsuarioModificacion_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) 			REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbMarcasMaquina_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


--CREATE TABLE Prod.tbMaquinasModulos(
--	moma_Id						INT IDENTITY(1,1),
--	modu_Id						INT NOT NULL,
--	maqu_Id						INT NOT NULL,

--	usua_UsuarioCreacion		INT NOT NULL,
--	moma_FechaCreacion			DATETIME NOT NULL,
--	usua_UsuarioModificacion	INT DEFAULT NULL,
--	moma_FechaModificacion		DATETIME DEFAULT NULL,
--	usua_UsuarioEliminacion		INT DEFAULT NULL,
--	moma_FechaEliminacion		DATETIME DEFAULT NULL,
--	moma_Estado					BIT	DEFAULT 1

--	CONSTRAINT PK_Prod_tbMaquinasModulos_moma_Id 									PRIMARY KEY(moma_Id),
--	CONSTRAINT FK_Prod_tbMaquinasModulos_Prod_tbModulos_modu_Id 					FOREIGN KEY(modu_Id) 					REFERENCES Prod.tbModulos(modu_Id),
--	CONSTRAINT FK_Prod_tbMaquinasModulos_Prod_tbMaquinas_maqu_Id 					FOREIGN KEY(maqu_Id) 					REFERENCES Prod.tbMaquinas(maqu_Id),
--	CONSTRAINT FK_Prod_tbMaquinasModulos_tbUsuarios_moma_UsuaCrea					FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
--	CONSTRAINT FK_Prod_tbMaquinasModulos_tbUsuarios_moma_UsuModificacion			FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
--	CONSTRAINT FK_Prod_tbMaquinasModulos_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
--);
--GO


CREATE TABLE Prod.tbModelosMaquina(
	mmaq_Id						INT IDENTITY(1,1),
	mmaq_Nombre					NVARCHAR(250)NOT NULL,
	marq_Id						INT NOT NULL,
	func_Id						INT NOT NULL,
	mmaq_Imagen					NVARCHAR(MAX)NOT NULL,

	usua_UsuarioCreacion		INT NOT NULL,
	mmaq_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	mmaq_FechaModificacion		DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	mmaq_FechaEliminacion		DATETIME DEFAULT NULL,
	mmaq_Estado					BIT DEFAULT 1,
	
	CONSTRAINT PK_Prod_tbModelosMaquina_mmaq_Id 								PRIMARY KEY(mmaq_Id),
	CONSTRAINT FK_Prod_tbModelosMaquina_marq_Id_Prod_tbMarcasMaquina_marq_Id 				FOREIGN KEY(marq_Id) 				REFERENCES Prod.tbMarcasMaquina(marq_Id),
	CONSTRAINT FK_Prod_tbModelosMaquina_func_Id_Prod_tbFunciones_func_Id 					FOREIGN KEY(func_Id) 				REFERENCES Prod.tbFuncionesMaquina(func_Id),
	CONSTRAINT FK_Prod_tbModelosMaquina_usua_UsuaCreaciaon_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)     	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbModelosMaquina_usua_UsuaModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbModelosMaquina_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


--Sección #5
CREATE TABLE Prod.tbMaquinas(
	maqu_Id						INT IDENTITY(1,1),
	maqu_NumeroSerie			NVARCHAR(100),
	mmaq_Id						INT NOT NULL,
	modu_Id						INT NOT NULL,

	usua_UsuarioCreacion		INT NOT NULL,
	maqu_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	maqu_FechaModificacion		DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	maqu_FechaEliminacion		DATETIME DEFAULT NULL,
	maqu_Estado					BIT	DEFAULT 1
	
	CONSTRAINT PK_Prod_tbMaquinas_maqu_Id										PRIMARY KEY (maqu_Id),
	CONSTRAINT FK_Prod_tbMaquinas_Prod_tbModulos_modu_Id 						FOREIGN KEY(modu_Id) 							REFERENCES Prod.tbModulos(modu_Id),
	CONSTRAINT UQ_Prdo_tbMaquinas_maqu_NumeroSerie								UNIQUE(maqu_NumeroSerie),
	CONSTRAINT FK_Prod_tbMaquinas_Prod_tbModelosMaquina_mmaq_Id					FOREIGN KEY (mmaq_Id)					REFERENCES Prod.tbModelosMaquina(mmaq_Id),
	CONSTRAINT FK_Prod_tbMaquinas_usua_UsuarioCreacion_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbMaquinas_usua_UsuarioModificacion_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbMaquinas_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO



CREATE TABLE Prod.tbMaquinaHistorial(
	mahi_Id						INT IDENTITY(1,1),
	maqu_Id						INT NOT NULL,
	mahi_FechaInicio			DATETIME NOT NULL,
	mahi_FechaFin				DATETIME NOT NULL,
	mahi_Observaciones			NVARCHAR(250)NOT NULL,

	usua_UsuarioCreacion		INT NOT NULL,
	mahi_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	mahi_FechaModificacion		DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	mahi_FechaEliminacion		DATETIME DEFAULT NULL,
	mahi_Estado					BIT DEFAULT 1,

	CONSTRAINT PK_Prod_tbMaquinaHistorial_mahi_Id								PRIMARY KEY(mahi_Id),
	CONSTRAINT FK_Prod_tbMaquinaHistorial_Prod_tbMaquinas_maqu_Id				FOREIGN KEY(maqu_Id) REFERENCES Prod.tbMaquinas(maqu_Id),
	CONSTRAINT FK_Prod_tbMaquinaHistorial_tbUsuarios_mahi_UsuaCrea				FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbMaquinaHistorial_tbUsuarios_mahi_UsuModificacion		FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbMaquinaHistorial_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


CREATE TABLE Prod.tbAsignacionesOrden(
	asor_Id						INT IDENTITY(1,1),
	asor_OrdenDetId				INT NOT NULL,
	asor_FechaInicio			DATE NOT NULL,
	asor_FechaLimite			DATE NOT NULL,
	--asor_EstadoDet				NVARCHAR NOT NULL,
	asor_Cantidad				INT NOT NULL,
	proc_Id						INT NOT NULL,
	empl_Id						INT NOT NULL,


	usua_UsuarioCreacion		INT NOT NULL,
	asor_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	asor_FechaModificacion		DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion	INT DEFAULT NULL,
	--asor_FechaEliminacion		DATETIME DEFAULT NULL,
	--asor_Estado					BIT DEFAULT 1

	CONSTRAINT PK_Prod_tbAsignacionesOrden_asor_Id									PRIMARY KEY (asor_Id),
	CONSTRAINT FK_Prod_tbAsignacionesOrden_tbOrdenCompraDetalles_asor_OrdenDetId	FOREIGN KEY	(asor_OrdenDetId) 		   REFERENCES Prod.tbOrdenCompraDetalles (code_Id),
	CONSTRAINT FK_Prod_tbAsignacionesOrden_tbProcesos_proc_Id						FOREIGN KEY	(proc_Id) 				   REFERENCES Prod.tbProcesos			 (proc_Id),
	CONSTRAINT FK_Prod_tbAsignacionesOrden_Gral_tbEmpleados_empl_Id					FOREIGN KEY	(empl_Id) 				   REFERENCES Gral.tbEmpleados			 (empl_Id),
	CONSTRAINT FK_Prod_tbAsignacionesOrden_tbUsuarios_asor_UsuCrea					FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios			 (usua_Id),
	CONSTRAINT FK_Prod_tbAsignacionesOrden_tbUsuarios_asor_UsuModifica				FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios			 (usua_Id),
);
GO


CREATE TABLE Prod.tbReporteModuloDia(
	remo_Id						INT IDENTITY(1,1),
	modu_Id						INT NOT NULL, 
	remo_Fecha					DATE NOT NULL,
	remo_TotalDia				INT NOT NULL, 
	remo_TotalDanado			INT NOT NULL,
	remo_Finalizado				BIT DEFAULT 0 NULL,
	usua_UsuarioCreacion		INT NOT NULL,
	remo_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	remo_FechaModificacion		DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--remo_FechaEliminacion		DATETIME DEFAULT NULL,
	remo_Estado					BIT DEFAULT 1 

	CONSTRAINT PK_Prod_tbReporteModuloDia_remo_Id								PRIMARY KEY (remo_Id)
	CONSTRAINT FK_Prod_tbReporteModuloDia_tbModulos_modu_Id						FOREIGN KEY (modu_Id)				   REFERENCES Prod.tbModulos (modu_Id),
	CONSTRAINT FK_Prod_tbReporteModuloDia_tbUsuarios_remo_UsuCrea				FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbReporteModuloDia_tbUsuarios_remo_UsuModifica			FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Prod_tbReporteModuloDia_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

CREATE TABLE Prod.tbPedidosProduccion(
	ppro_Id              			INT IDENTITY(1,1),
	empl_Id              			INT NOT NULL,
	ppro_Fecha           			DATETIME NOT NULL,
	ppro_Estados          			NVARCHAR(150) NOT NULL,
	ppro_Observaciones   			NVARCHAR(MAX) NOT NULL,
	ppro_Finalizado					BIT DEFAULT 0 NOT NULL,
	usua_UsuarioCreacion			INT NOT NULL,
	ppro_FechaCreacion				DATETIME NOT NULL,
	usua_UsuarioModificacion		INT DEFAULT NULL,
	ppro_FechaModificacion			DATETIME DEFAULT NULL, 
	--usua_UsuarioEliminacion			INT DEFAULT NULL,
	--ppro_FechaEliminacion			DATETIME DEFAULT NULL,
	ppro_Estado						BIT DEFAULT 1

   	CONSTRAINT PK_prod_tbPedidosProduccion PRIMARY KEY (ppro_Id),
   	CONSTRAINT FK_prod_tbPedidosProduccion_Prod_tbEmpleadosProduccion_empl_Id 	FOREIGN KEY (empl_Id)					REFERENCES Gral.tbEmpleados(empl_Id),
	CONSTRAINT FK_Prod_tbPedidosProduccion_tbUsuarios_ppro_UsuCrea				FOREIGN KEY (usua_UsuarioCreacion)     	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbPedidosProduccion_tbUsuarios_ppro_UsuModifica			FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id),   
	--CONSTRAINT FK_Prod_tbPedidosProduccion_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

CREATE TABLE Prod.tbOrde_Ensa_Acab_Etiq(
	ensa_Id						INT IDENTITY(1,1),
	ensa_Cantidad				INT NOT NULL,
	empl_Id						INT NOT NULL,
	code_Id						INT NOT NULL,
	ensa_FechaInicio			DATE NOT NULL,
	ensa_FechaLimite			DATE NOT NULL, 
	ppro_Id						INT NOT NULL,
	modu_Id						INT,
 
	usua_UsuarioCreacion		INT NOT NULL,
	ensa_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	ensa_FechaModificacion		DATETIME DEFAULT NULL,

	ensa_Estado					BIT DEFAULT 1  

	CONSTRAINT PK_Prod_tbOrdenCorte_Ensamblado_Acabado_Etiquetado_orde_Id											PRIMARY KEY (ensa_Id)
	CONSTRAINT FK_Prod_tbOrdenCorte_Ensamblado_Acabado_Etiquetado_empl_Id_Gral_tbEmpleados_empl_Id					FOREIGN KEY (empl_Id)					REFERENCES Gral.tbEmpleados					(empl_Id),
	CONSTRAINT FK_Prod_tbOrdenCorte_Ensamblado_Acabado_Etiquetado_code_Id_Prod_tbOrdenCompraDetalle_code_Id			FOREIGN KEY (code_Id)					REFERENCES Prod.tbOrdenCompraDetalles		(code_Id),
	CONSTRAINT FK_Prod_tbOrdenCorte_Ensamblado_Acabado_Etiquetado_ppro_Id_Prod_tbPedidoProduccion_ppro_Id			FOREIGN KEY (ppro_Id)					REFERENCES Prod.tbPedidosProduccion			(ppro_Id),
	CONSTRAINT FK_Prod_tbOrdenCorte_Ensamblado_Acabado_Etiquetado_usua_UsuarioCreacion_Acce_tbUsuario_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios					(usua_Id),
	CONSTRAINT FK_Prod_tbOrdenCorte_Ensamblado_Acabado_Etiquetado_usua_UsuarioModificacion_Acce_tbUsuario_usua_Id	FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios					(usua_Id),
	CONSTRAINT FK_Prod_tbOrdenCorte_Ensamblado_Acabado_Etiquetado_Prod_tbModulos_modu_Id							FOREIGN KEY (modu_Id) REFERENCES Prod.tbModulos (modu_Id)
);
GO

CREATE TABLE Prod.tbReporteModuloDiaDetalle(
	rdet_Id 					INT  IDENTITY(1,1),
	remo_Id 					INT NOT NULL,
	rdet_TotalDia				INT NOT NULL,
	rdet_TotalDanado			INT NOT NULL,
	code_Id                     INT NOT NULL,
	[ensa_Id]					INT,
	usua_UsuarioCreacion		INT NOT NULL,
	rdet_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	rdet_FechaModificacion		DATETIME DEFAULT NULL,
	rdet_Estado					BIT DEFAULT 1  

	CONSTRAINT PK_Prod_tbReporteModuloDiaDetalle_rdet_Id						PRIMARY KEY (rdet_Id)
	CONSTRAINT FK_Prod_tbReporteModuloDiaDetalle_tbReporteModuloDia_remo_Id		FOREIGN KEY (remo_Id)		   		   REFERENCES Prod.tbReporteModuloDia (remo_Id),
	CONSTRAINT FK_Prod_tbReporteModuloDiaDetalle_tbOrdenCompraDetalle_code_Id	FOREIGN KEY (code_Id)		   	       REFERENCES Prod.tbOrdenCompraDetalles (code_Id),
	CONSTRAINT FK_Prod_ReporteModuloDiaDetalle_OrdenDeProceso_ensa_Id FOREIGN KEY ([ensa_Id]) REFERENCES  [Prod].[tbOrde_Ensa_Acab_Etiq]([ensa_Id]),
	CONSTRAINT FK_Prod_tbReporteModuloDiaDetalle_tbUsuarios_rdet_UsuCrea		FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbReporteModuloDiaDetalle_tbUsuarios_rdet_UsuModifica	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

--------------------- Multimuncional -----------------------


-----------------Adquisicion de material--------------------


CREATE TABLE Adua.tbMarcas(
	marc_Id							INT IDENTITY(1,1),
	marc_Descripcion				NVARCHAR(20) NOT NULL,

	usua_UsuarioCreacion			INT NOT NULL,
	marc_FechaCreacion				DATETIME NOT NULL,
	usua_UsuarioModificacion 		INT DEFAULT NULL,
	marc_FechaModificacion			DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion	    INT	DEFAULT NULL,
	marc_FechaEliminacion		DATETIME DEFAULT NULL,
	marc_Estado 					BIT DEFAULT 1
	CONSTRAINT PK_Adua_tbMarcas_marc_Id PRIMARY KEY(marc_Id),
	CONSTRAINT FK_Prod_tbMarcas_tbUsuarios_marc_UsuarioCreacion		FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Prod_tbMarcas_tbUsuarios_marc_UsuarioModificacion	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios 	(usua_Id),
    CONSTRAINT UQ_Adua_tbMarcas_marc_Descripcion UNIQUE(marc_Descripcion),
	CONSTRAINT FK_Prod_tbMarcas_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


CREATE TABLE Adua.tbTransporte( 
	tran_Id							INT IDENTITY(1,1),
	tran_IdUnidadTransporte			VARCHAR(50) NOT NULL,
	pais_Id							INT,
	tran_Chasis						NVARCHAR(100) NOT NULL,
	marca_Id						INT NOT NULL,
	tran_Remolque					NVARCHAR(50) NULL,
	tran_CantCarga					INT NOT NULL,
	tran_NumDispositivoSeguridad	INT NULL,
	tran_Equipamiento				NVARCHAR(200) NULL,
	tran_TamanioEquipamiento		VARCHAR(50) NOT NULL,
	tran_TipoCarga					NVARCHAR(200) NOT NULL,
	tran_IdContenedor				NVARCHAR(100) NOT NULL,

	usua_UsuarioCreacio				INT NOT NULL,
	tran_FechaCreacion				DATETIME NOT NULL,
	usua_UsuarioModificacion		INT DEFAULT NULL,
	tran_FechaModificacion			DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion			INT DEFAULT NULL,
	trant_FechaEliminacion			DATETIME DEFAULT NULL,
	tran_Estado 					BIT	NOT NULL DEFAULT 1,

	CONSTRAINT PK_Adua_tbTransporte_tran_Id PRIMARY KEY(tran_Id),
	CONSTRAINT FK_Prod_tbTransporte_tbUsuarios_tran_UsuCrea							 FOREIGN KEY (usua_UsuarioCreacio)		REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Prod_tbTransporte_tbUsuarios_tran_UsuModifica						 FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Adua_tbTransporte_tbMarca_marca_id                                 FOREIGN KEY (marca_Id)                 REFERENCES Adua.tbMarcas    (marc_Id),
	CONSTRAINT FK_Gral_tbPaises_pais_Id_Adua_tbTransporte_pais_Id 					 FOREIGN KEY (pais_Id)					REFERENCES Gral.tbPaises    (pais_Id),
	CONSTRAINT PK_Adua_tbTransporte_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 	REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


CREATE TABLE Adua.tbConductor(
	cont_Id							INT IDENTITY(1,1),
	cont_NoIdentificacion			VARCHAR(50) NOT NULL,
	cont_Nombre						NVARCHAR(200) NOT NULL,
	cont_Apellido					NVARCHAR(200) NOT NULL,
	cont_Licencia					NVARCHAR(50) NOT NULL,
	pais_IdExpedicion				INT,
	tran_Id							INT NOT NULL,
	
	usua_UsuarioCreacion			INT NOT NULL,
	cont_FechaCreacion				DATETIME NOT NULL,
	usua_UsuarioModificacion 		INT DEFAULT NULL,
	cont_FechaModificacion			DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion			INT DEFAULT NULL, 
	cont_FechaEliminacion			DATETIME DEFAULT NULL,
	cont_Estado 					BIT	NOT NULL DEFAULT 1,

	CONSTRAINT PK_Adua_tbConductor_cont_Id PRIMARY KEY(cont_Id),
	CONSTRAINT FK_Prod_tbConductor_tbUsuarios_cont_UsuCrea					FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Prod_tbConductor_tbUsuarios_cont_UsuModifica				FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Gral_tbPaises_pais_Id_Adua_tbConductor_pais_IdExpedicion 	FOREIGN KEY (pais_IdExpedicion) 	   REFERENCES Gral.tbPaises 	(pais_Id),
	CONSTRAINT FK_Adua_tbTransporte_tran_Id_Adua_tbConductor_tran_Id 		FOREIGN KEY (tran_Id)    			   REFERENCES Adua.tbTransporte (tran_Id),
	CONSTRAINT FK_Prod_tbConductor_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


--CREATE TABLE Adua.tbTransportista
--(  
--    tras_Id                         INT IDENTITY(1,1),
--    tras_Codigo                     NVARCHAR(150),
--    tras_Nombre                     NVARCHAR(350),

--    usua_UsuarioCreacion			INT NOT NULL,
--	tras_FechaCreacion				DATETIME NOT NULL,
--	usua_UsuarioModificacion 		INT DEFAULT NULL,
--	tras_FechaModificacion			DATETIME DEFAULT NULL,
--	usua_UsuarioEliminacion			INT DEFAULT NULL, 
--	tras_FechaEliminacion			DATETIME DEFAULT NULL,
--	tras_Estado 					BIT	NOT NULL DEFAULT 1,

--	CONSTRAINT 	PK_Adua_tbTransportista_tras_Id  PRIMARY KEY(tras_Id),
--	CONSTRAINT FK_Adua_tbTransportista_tbUsuarios_cont_UsuarioCreacion					FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios 	(usua_Id),
--	CONSTRAINT FK_Adua_tbTransportista_tbUsuarios_cont_UsuarioModificacion				FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios 	(usua_Id),
--	CONSTRAINT FK_Adua_tbTransportista_tbUsuarios_cont_UsuarioEliminacion				FOREIGN KEY (usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios 	(usua_Id),
	    
--)

GO

--CREATE TABLE Prod.tbOrdenCorte_Ensamblado_Acabado_Etiquetado(

CREATE TABLE Adua.tbModoTransporte(
	motr_Id				     INT IDENTITY(1,1),
	motr_Descripcion	     NVARCHAR(75) NOT NULL,

	usua_UsuarioCreacion 	 INT NOT NULL,
	motr_FechaCreacion		 DATETIME NOT NULL,
	usua_UsuarioModificacion INT DEFAULT NULL,
	motr_FechaModificacion	 DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	motr_FechaEliminacion		DATETIME DEFAULT NULL,
	motr_Estado 		     BIT DEFAULT 1
	CONSTRAINT PK_Adua_tbModoTransporte_motr_Id PRIMARY KEY(motr_Id),
	CONSTRAINT FK_Prod_tbModoTransporte_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Prod_tbModoTransporte_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios 	(usua_Id),
    CONSTRAINT UQ_Adua_tbModoTransporte_iden_Descripcion UNIQUE(motr_Descripcion),
	CONSTRAINT FK_Prod_tbModoTransporte__Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

CREATE TABLE Adua.tbTiposIdentificacion(
	iden_Id						INT IDENTITY(1,1),
	iden_Descripcion			NVARCHAR(75) NOT NULL,

	usua_UsuarioCreacion		INT NOT NULL,
	iden_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion 	INT DEFAULT NULL,
	iden_FechaModificacion		DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion	    INT	DEFAULT NULL,
	iden_FechaEliminacion		DATETIME DEFAULT NULL,
	iden_Estado 				BIT DEFAULT 1
	CONSTRAINT PK_Adua_tbTiposIdentificacion_iden_Id PRIMARY KEY(iden_Id),
	CONSTRAINT FK_Prod_tbTiposIdentificacion_tbUsuarios_iden_UsuarioCreacion		FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Prod_tbTiposIdentificacion_tbUsuarios_iden_UsuarioModificacion	FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios 	(usua_Id),
    CONSTRAINT UQ_Adua_tbTiposIdentificacion_iden_Descripcion UNIQUE(iden_Descripcion),
	CONSTRAINT FK_Prod_tbTiposIdentificacion_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

----**************IMPORTANTE****************----
CREATE TABLE Adua.tbDuca(
	duca_Id							INT IDENTITY (1,1),
	duca_No_Duca					NVARCHAR(100) DEFAULT NULL,
	duca_No_Correlativo_Referencia	NVARCHAR(MAX) DEFAULT NULL,
	duca_AduanaRegistro				INT DEFAULT NULL,
	duca_AduanaDestino				INT DEFAULT NULL,
	duca_Regimen_Aduanero			INT DEFAULT NULL,
	duca_Modalidad					NVARCHAR(MAX) DEFAULT NULL,
	duca_Clase						NVARCHAR(MAX) DEFAULT NULL,
	duca_FechaVencimiento			DATE DEFAULT NULL,
	duca_Pais_Procedencia			INT DEFAULT NULL,
	duca_Pais_Destino				INT DEFAULT NULL,
	duca_Deposito_Aduanero			NVARCHAR(MAX) DEFAULT NULL,
	duca_Lugar_Desembarque			INT DEFAULT NULL,
	duca_Manifiesto					NVARCHAR(MAX) DEFAULT NULL,
	duca_Titulo						NVARCHAR(MAX) DEFAULT NULL,
	trli_Id							INT DEFAULT NULL,

	duca_Codigo_Declarante			NVARCHAR(200) DEFAULT NULL,
	duca_Numero_Id_Declarante		NVARCHAR(200) DEFAULT NULL,
	duca_NombreSocial_Declarante	NVARCHAR(MAX) DEFAULT NULL,
	duca_DomicilioFiscal_Declarante NVARCHAR(MAX) DEFAULT NULL,
	duca_Codigo_Transportista		NVARCHAR(200) DEFAULT NULL,
	duca_Transportista_Nombre		NVARCHAR(MAX) DEFAULT NULL,
	motr_Id                 		INT DEFAULT NULL,
	duca_Conductor_Id				INT DEFAULT NULL,
	
	duca_ValorTransaccionTotal		DECIMAL(18,2) DEFAULT NULL,
	duca_GastosTransporteTotal		DECIMAL(18,2) DEFAULT NULL,
	duca_GastosSeguroTotal			DECIMAL(18,2) DEFAULT NULL,
	duca_OtrosGastosTotal			DECIMAL(18,2) DEFAULT NULL,
	duca_ValorTotalEnAduana			DECIMAL(18,2) DEFAULT NULL,
	duca_PesoBrutoTotal				DECIMAL(18,2) DEFAULT NULL,
	duca_PesoNetoTotal				DECIMAL(18,2) DEFAULT NULL,

	duca_Finalizado					BIT DEFAULT 0,
	usua_UsuarioCreacion			INT,
	duca_FechaCreacion				DATETIME,
	usua_UsuarioModificacion		INT DEFAULT NULL,
	duca_FechaModificacion			DATETIME DEFAULT NULL,
	duca_Estado 					BIT DEFAULT 1
	
	CONSTRAINT PK_Adua_tbDuca_duca_Id PRIMARY KEY (duca_Id),
	CONSTRAINT FK_Adua_tbDuca_duca_AduanaRegistro_Adua_tbAduana_adua_Id					FOREIGN KEY (duca_AduanaRegistro)               REFERENCES Adua.tbAduanas				(adua_Id),
	CONSTRAINT FK_Adua_tbDuca_duca_AduanaDestino_Adua_tbAduana_adua_Id					FOREIGN KEY (duca_AduanaDestino)				REFERENCES Adua.tbAduanas				(adua_Id),
	CONSTRAINT FK_Adua_tbDuca_duca_Regimen_Aduanero_Adua_tbRegimenesAduaneros_regi_Id	FOREIGN KEY (duca_Regimen_Aduanero)				REFERENCES Adua.tbRegimenesAduaneros	(regi_Id),
	CONSTRAINT FK_Adua_tbDuca_duca_Pais_Procedencia_Gral_tbPaises_pais_Id				FOREIGN KEY	(duca_Pais_Procedencia) 	        REFERENCES Gral.tbPaises				(pais_Id),
	CONSTRAINT FK_Adua_tbDuca_duca_Pais_Destino_Gral_tbPaises_pais_Id					FOREIGN KEY	(duca_Pais_Destino) 		        REFERENCES Gral.tbPaises				(pais_Id),
	CONSTRAINT FK_Adua_tbDuca_duca_Lugar_Desembarque_Adua_tbLugaresEmbarque_emba_Id		FOREIGN KEY (duca_Lugar_Desembarque)			REFERENCES Adua.tbLugaresEmbarque		(emba_Id),
	CONSTRAINT FK_Adua_tbDuca_trli_Id_Adua_tbTratadosLibreComercio_trli_Id				FOREIGN KEY (trli_Id)							REFERENCES Adua.tbTratadosLibreComercio	(trli_Id),
	CONSTRAINT FK_Adua_tbDuca_motr_Id_Adua_tbModoTransporte_motr_Id						FOREIGN KEY (motr_Id)							REFERENCES Adua.tbModoTransporte		(motr_Id),
	CONSTRAINT FK_Adua_tbConductor_cont_Id_Adua_tbDuca_duca_Conductor_Id				FOREIGN KEY	(duca_Conductor_Id) 		        REFERENCES Adua.tbConductor				(cont_Id),
	CONSTRAINT FK_Adua_tbDuca_tbUsuarios_duca_UsuCrea			               			FOREIGN KEY (usua_UsuarioCreacion)     			REFERENCES Acce.tbUsuarios 				(usua_Id),
	CONSTRAINT FK_Prod_tbDuca_tbUsuarios_duca_UsuModifica		               			FOREIGN KEY (usua_UsuarioModificacion) 			REFERENCES Acce.tbUsuarios 				(usua_Id),
);
GO

CREATE TABLE Adua.tbDucaHistorial(
	hduc_Id 						INT IDENTITY(1,1),
	duca_No_Duca					NVARCHAR(100),
	duca_No_Correlativo_Referencia	NVARCHAR(MAX) NOT NULL,
	deva_Id							INT NOT NULL,
	duca_AduanaRegistro				INT NOT NULL,
	duca_AduanaSalida				INT NOT NULL,
	duca_DomicilioFiscal_Exportador NVARCHAR(MAX) NOT NULL,
	duca_Tipo_Iden_Exportador		NVARCHAR(100) NOT NULL,
	duca_Pais_Emision_Exportador	INT NOT NULL,
	duca_Numero_Id_Importador		NVARCHAR(100) NOT NULL,
	duca_Pais_Emision_Importador	INT NOT NULL,
	duca_DomicilioFiscal_Importador NVARCHAR(MAX) NOT NULL,
	duca_Regimen_Aduanero			NVARCHAR(MAX) NOT NULL,
	duca_Modalidad					NVARCHAR(MAX) NOT NULL,
	duca_Clase						NVARCHAR(MAX) NOT NULL,
	duca_Codigo_Declarante			NVARCHAR(200) NOT NULL,
	duca_Numero_Id_Declarante		NVARCHAR(200) NOT NULL,
	duca_NombreSocial_Declarante	NVARCHAR(MAX) NOT NULL,
	duca_DomicilioFiscal_Declarante NVARCHAR(MAX) NOT NULL,
	duca_Pais_Procedencia			INT NOT NULL,
	duca_Pais_Exportacion			INT NOT NULL,
	duca_Pais_Destino				INT NOT NULL,
	duca_Deposito_Aduanero			NVARCHAR(MAX) NOT NULL,
	duca_Lugar_Embarque				NVARCHAR(MAX) NOT NULL,
	duca_Lugar_Desembarque			NVARCHAR(MAX) NOT NULL,
	duca_Manifiesto					NVARCHAR(MAX) NOT NULL,
	duca_Titulo						NVARCHAR(MAX) NOT NULL,
	duca_Codigo_Transportista		NVARCHAR(200) NULL,
	motr_id                 		INT NULL,
	duca_Transportista_Nombre		NVARCHAR(MAX) NULL,
	duca_Conductor_Id				INT NULL,
	duca_Codigo_Tipo_Documento		CHAR(3) NOT NULL,


	hduc_UsuarioAccion 				INT,
	hduc_FechaAccion 				DATETIME NOT NULL,
	hduc_Accion						NVARCHAR(100)
);
GO


CREATE TABLE Prod.tbPedidosOrden(--No se podrá eliminar de ninguna manera
	peor_Id   					INT IDENTITY(1,1),
	peor_Codigo					NVARCHAR(100) NOT NULL,
	peor_Impuestos				NVARCHAR(MAX),
	prov_Id						INT,
	duca_Id						INT,
	ciud_Id						INT,
	peor_DireccionExacta		NVARCHAR(500), 
	peor_FechaEntrada			DATETIME,
	peor_Obsevaciones			NVARCHAR(400),
	peor_finalizacion			BIT NOT NULL default(0),
	peor_DadoCliente			BIT,
	peor_Est					BIT,
	usua_UsuarioCreacion		INT NOT NULL,
	peor_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion 	INT DEFAULT NULL,
	peor_FechaModificacion		DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion	    INT	DEFAULT NULL,
	--peor_FechaEliminacion		DATETIME DEFAULT NULL,
	peor_Estado 				BIT DEFAULT 1 
	
	CONSTRAINT PK_Prod_tbPedidosOrden_peor_Id PRIMARY KEY (peor_Id),
	CONSTRAINT UQ_Prod_tbPedidosOrden_peor_Codigo UNIQUE(peor_Codigo),
	CONSTRAINT FK_Prod_tbPedidosOrden_prov_Id_Prod_tbProveedores_prov_Id 			FOREIGN KEY (prov_Id)					REFERENCES Gral.tbProveedores(prov_Id),
	CONSTRAINT FK_Prod_tbPedidosOrden_Gral_tbCiudades_ciud_Id			 			FOREIGN KEY (ciud_Id)					REFERENCES Gral.tbCiudades(ciud_Id),
	CONSTRAINT FK_Prod_tbPedidosOrden_tbUsuarios_peor_UsuarioCreacion				FOREIGN KEY (usua_UsuarioCreacion)     	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbPedidosOrden_tbUsuarios_peor_UsuarioModificacion			FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbPedidosOrden_tbDuca_Duca_Id FOREIGN KEY (duca_Id) REFERENCES Adua.tbDuca (duca_Id)
	--CONSTRAINT FK_Prod_tbPedidosOrden__Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

CREATE TABLE Prod.tbPedidosOrdenDetalle(--No se podrá eliminar de ninguna manera
	prod_Id							INT IDENTITY(1,1),
	pedi_Id							INT NOT NULL,
	mate_Id							INT NOT NULL,
	prod_Cantidad					INT NOT NULL,
	prod_Precio						DECIMAL(18,2) NOT NULL,
--	prod_Peso						DECIMAL(18,2) NOT NULL,

	usua_UsuarioCreacion			INT NOT NULL,
	prod_FechaCreacion				DATETIME NOT NULL,
	usua_UsuarioModificacion		INT DEFAULT NULL,
	prod_FechaModificacion			DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion	    INT	DEFAULT NULL,
	--prod_FechaEliminacion			DATETIME DEFAULT NULL,
	prod_Estado						BIT DEFAULT 1
	CONSTRAINT PK_Prod_tbPedidosOrdenDetalle_prod_Id PRIMARY KEY (prod_Id),
	CONSTRAINT FK_Prod_tbPedidosOrdenDetalle_pedi_Id_Pro_tbPedidos		FOREIGN KEY (pedi_Id)	REFERENCES Prod.tbPedidosOrden(peor_Id),
	CONSTRAINT FK_Prod_tbPedidosOrdenDetalle_mate_Id_Pro_tbMateriales	FOREIGN KEY (mate_Id)	REFERENCES Prod.tbMateriales(mate_Id),
	CONSTRAINT FK_Prod_tbPedidosOrdenDetalle_tbUsuarios_prod_UsuarioCreacion					FOREIGN KEY (usua_UsuarioCreacion)     	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbPedidosOrdenDetalle_tbUsuarios_prod_UsuarioModificacion				FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Prod_tbPedidosOrdenDetalle_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

-----------------Detalles de PO según el detalles de la orden de pedido-------------------

--Créditos a Dani por nomenclatura popo
CREATE TABLE Prod.tbPODetallePorPedidoOrdenDetalle(
	ocpo_Id						INT IDENTITY(1,1),
	prod_Id						INT NOT NULL,
	code_Id						INT NULL,
	orco_Id						INT NULL,

	usua_UsuarioCreacion		INT NOT NULL,
	ocpo_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	ocpo_FechaModificacion		DATETIME DEFAULT NULL

	CONSTRAINT PK_Prod_tbPODetallePorPedidoOrdenDetalle_ocpo_Id										PRIMARY KEY(ocpo_Id),
	CONSTRAINT FK_Prod_tbPODetallePorPedidoOrdenDetalle_tbPedidosOrdenDetalle_prod_Id				FOREIGN KEY(prod_Id)					REFERENCES Prod.tbPedidosOrdenDetalle(prod_Id),
	CONSTRAINT FK_Prod_tbPODetallePorPedidoOrdenDetalle_tbOrdenCompraDetalle_code_Id				FOREIGN KEY(code_Id)					REFERENCES Prod.tbOrdenCompraDetalles(code_Id),
	CONSTRAINT FK_Prod_tbPODetallePorPedidoOrdenDetalle_tbOrdenCompra_orco_Id						FOREIGN KEY(orco_Id)					REFERENCES Prod.tbOrdenCompra(orco_Id),
	CONSTRAINT FK_Prod_tbPODetallePorPedidoOrdenDetalle_Acce_tbUsuarios_usua_UsuarioCreacion		FOREIGN KEY(usua_UsuarioCreacion)       REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Prod_tbPODetallePorPedidoOrdenDetalle_Acce_tbUsuarios_usua_UsuarioModificacion	FOREIGN KEY(usua_UsuarioModificacion)   REFERENCES Acce.tbUsuarios(usua_Id)
);
GO


CREATE TABLE Prod.tbLotes(
	lote_Id   					INT IDENTITY(1,1),
	lote_CodigoLote             NVARCHAR(150) NOT NULL,
	mate_Id						INT NOT NULL,
	unme_Id						INT NOT NULL,
	prod_Id						INT,
	lote_Stock  				DECIMAL(18,2) NOT NULL,
	lote_CantIngresada			DECIMAL(18,2) NOT NULL,
	lote_Observaciones			NVARCHAR(500),
	tipa_Id						INT NOT NULL,
	colr_Id                     INT NOT NULL,
	usua_UsuarioCreacion		INT NOT NULL,
	lote_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion 	INT DEFAULT NULL,
	lote_FechaModificacion		DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion		INT DEFAULT NULL,
	lote_FechaEliminacion		DATETIME DEFAULT NULL,
	lote_Estado 				BIT	DEFAULT 1, 

	CONSTRAINT PK_Prod_tbLotes_lote_Id PRIMARY KEY (lote_Id),
	CONSTRAINT UQ_Prod_tbLotes_lote_CodigoLote UNIQUE(lote_CodigoLote),
	CONSTRAINT FK_Prod_tbLotes_colr_Id_Prod_tbColores_colr_Id       FOREIGN KEY (colr_Id)                   REFERENCES Prod.tbColores(colr_Id),
	CONSTRAINT FK_Prod_tbLotes_mate_Id_Prod_tbMateriales_mate_Id	FOREIGN KEY (mate_Id) 					REFERENCES Prod.tbMateriales(mate_Id),
	CONSTRAINT FK_Prod_tbLotes_unme_Id_Gral_tbUnidadMedidas_unme_Id	FOREIGN KEY (unme_Id) 					REFERENCES Gral.tbUnidadMedidas(unme_Id),
	CONSTRAINT FK_Prod_tbLotes_Prod_tbPedidosOrdenDetalle_prod_Id	FOREIGN KEY (prod_Id) 					REFERENCES Prod.tbPedidosOrdenDetalle(prod_Id),
	CONSTRAINT FK_Prod_tbLotes_tipa_Id_Prod_tbTipoArea_tipa_Id		FOREIGN KEY (tipa_Id) 					REFERENCES Prod.tbArea(tipa_Id),
	CONSTRAINT FK_Prod_tbLotes_tbUsuarios_lote_UsuCrea				FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbLotes_tbUsuarios_lote_UsuModifica			FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbLotes_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

CREATE TABLE Prod.tbAsignacionesOrdenDetalle(
	adet_Id						INT IDENTITY(1,1), 
	lote_Id						INT NOT NULL, 
	adet_Cantidad				INT NOT NULL, 
	asor_Id						INT NOT NULL,

	usua_UsuarioCreacion		INT NOT NULL,
	adet_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	adet_FechaModificacion		DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion	INT DEFAULT NULL,
	--amod_FechaEliminacion		DATETIME DEFAULT NULL,
	--adet_Estado				BIT DEFAULT 1 

	CONSTRAINT PK_Prod_tbAsignacionesModuloDetalle_adet_Id								PRIMARY KEY (adet_Id),
	CONSTRAINT FK_Prod_tbAsignacionesModuloDetalle_tbLotes_lote_Id						FOREIGN KEY (lote_Id)				   REFERENCES Prod.tbLotes (lote_Id),
	CONSTRAINT FK_Prod_tbAsignacionesModuloDetalle_tbtbAsignacionesOrden_asor_Id		FOREIGN KEY	(asor_Id)				   REFERENCES Prod.tbAsignacionesOrden(asor_Id),	
	CONSTRAINT FK_Prod_tbAsignacionesModuloDetalle_tbUsuarios_amod_UsuCrea				FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbAsignacionesModuloDetalle_tbUsuarios_amod_UsuModifica			FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Prod_tbAsignacionesModuloDetalle_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO
--select * from Prod.tbPedidosProduccionDetalles
CREATE TABLE Prod.tbPedidosProduccionDetalles(
	ppde_Id               			INT IDENTITY(1,1),
	ppro_Id               			INT NOT NULL,
	lote_Id               			INT NOT NULL,
	ppde_Cantidad         			INT NOT NULL,

	usua_UsuarioCreacion			INT NOT NULL,
	ppde_FechaCreacion				DATETIME NOT NULL,
	usua_UsuarioModificacion		INT DEFAULT NULL,
	ppde_FechaModificacion			DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		INT DEFAULT NULL,
	--ppde_FechaEliminacion		DATETIME DEFAULT NULL,
	ppde_Estado						BIT DEFAULT 1
	CONSTRAINT PK_Prod_tbPedidosProduccionDetalle PRIMARY KEY (ppde_Id),
	CONSTRAINT FK_Prod_tbPedidosProduccionDetalle_ppro_Id_Prod_tbPedidosProduccion FOREIGN KEY (ppro_Id) REFERENCES Prod.tbPedidosProduccion(ppro_Id),
	CONSTRAINT FK_Prod_tbPedidosProduccionDetalle_lote_Id_Prod_tbLotes FOREIGN KEY (lote_Id) REFERENCES Prod.tbLotes(lote_Id),
	CONSTRAINT FK_Prod_tbPedidosProduccionDetalle_tbUsuarios_ppde_UsuCrea				FOREIGN KEY (usua_UsuarioCreacion)     	REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbPedidosProduccionDetalle_tbUsuarios_ppde_UsuModifica			FOREIGN KEY (usua_UsuarioModificacion) 	REFERENCES Acce.tbUsuarios (usua_Id), 
	---CONSTRAINT FK_Prod_tbPedidosProduccionDetalle_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

-----------------Inspeccion-------------------

CREATE TABLE Prod.tbRevisionDeCalidad(
	reca_Id						INT IDENTITY(1,1),
	ensa_Id						INT NOT NULL,
	reca_Descripcion			NVARCHAR(200) NOT NULL,
	reca_Cantidad				INT NOT NULL,
	reca_Scrap					BIT NOT NULL,
	reca_FechaRevision          DATETIME NOT NULL,
	reca_Imagen					NVARCHAR(MAX),


	usua_UsuarioCreacion		INT NOT NULL,
	reca_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	reca_FechaModificacion		DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion	    INT	DEFAULT NULL,
	--reca_FechaEliminacion		DATETIME DEFAULT NULL,
	reca_Estado					BIT DEFAULT 1

	CONSTRAINT PK_Prod_tbRevisiondeCalidad_reca_Id 										PRIMARY KEY (reca_Id),
	CONSTRAINT FK_Prod_tbRevisionDeCalidad_reca_Orden 									FOREIGN KEY (ensa_Id) 					REFERENCES Prod.tbOrde_Ensa_Acab_Etiq(ensa_Id),
	CONSTRAINT FK_Prod_tbRevisionDeCalidad_tbUsuarios_reca_UsuarioCreacion				FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Prod_tbRevisionDeCalidad_tbUsuarios_reca_UsuarioModificacion			FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios 	(usua_Id),
	--CONSTRAINT FK_Prod_tbRevisionDeCalidad_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

-----------------Factura de exportación-------------------
CREATE TABLE Prod.tbFacturasExportacion(
	faex_Id						INT IDENTITY(1,1), 
	duca_Id						INT NULL,
	faex_Fecha					DATETIME	  NOT NULL,
	orco_Id						INT			  NOT NULL,
	faex_Total					DECIMAL		  NOT NULL,

	usua_UsuarioCreacion		INT NOT NULL,
	faex_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	faex_FechaModificacion		DATETIME DEFAULT NULL,
	faex_Finalizado				BIT DEFAULT 0,
	faex_Estado					BIT DEFAULT 1

	CONSTRAINT PK_Prod_tbFacturasExportacion_faex_Id									PRIMARY KEY(faex_Id),
	CONSTRAINT FK_Prod_tbFacturasExportacion_Adua_tbDuca_duca_Id						FOREIGN KEY(duca_Id)				 REFERENCES Adua.tbDuca	    (duca_Id),
	CONSTRAINT FK_Prod_tbFacturasExportacion_tbOrdenCompra_orco_Id						FOREIGN KEY(orco_Id)				   REFERENCES Prod.tbOrdenCompra(orco_Id),
	CONSTRAINT FK_Prod_tbFacturasExportacion_Acce_tbUsuarios_usua_UsuarioCreacion		FOREIGN KEY(usua_UsuarioCreacion)	   REFERENCES Acce.tbUsuarios   (usua_Id),	
	CONSTRAINT FK_Prod_tbFacturasExportacion_Acce_tbUsuarios_usua_UsuarioModificacion	FOREIGN KEY(usua_UsuarioModificacion)  REFERENCES Acce.tbUsuarios   (usua_Id)
);
GO


CREATE TABLE Prod.tbFacturasExportacionDetalles(
	fede_Id						INT IDENTITY(1,1),
	faex_Id						INT			  NOT NULL, 
	code_Id						INT			  NOT NULL,
	fede_Cajas					INT			  NOT NULL,
	fede_Cantidad				DECIMAL(18,2) NOT NULL,
	fede_PrecioUnitario			DECIMAL(18,2) NOT NULL,
	fede_TotalDetalle			DECIMAL(18,2) NOT NULL,

	usua_UsuarioCreacion		INT NOT NULL,
	fede_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT DEFAULT NULL,
	fede_FechaModificacion		DATETIME DEFAULT NULL

	CONSTRAINT PK_Prod_tbFacturasExportacionDetalles_fede_Id									PRIMARY KEY(fede_Id),
	CONSTRAINT FK_Prod_tbFacturasExportacionDetalles_tbFacturasExportacion_faex_Id				FOREIGN KEY(faex_Id)				   REFERENCES Prod.tbFacturasExportacion(faex_Id),
	CONSTRAINT FK_Prod_tbFacturasExportacionDetalles_tbOrdenCompraDetalles_code_Id				FOREIGN KEY(code_Id)				   REFERENCES Prod.tbOrdenCompraDetalles(code_Id),
	CONSTRAINT FK_Prod_tbFacturasExportacionDetalles_Acce_tbUsuarios_usua_UsuarioCreacion		FOREIGN KEY(usua_UsuarioCreacion)	   REFERENCES Acce.tbUsuarios			(usua_Id),	
	CONSTRAINT FK_Prod_tbFacturasExportacionDetalles_Acce_tbUsuarios_usua_UsuarioModificacion	FOREIGN KEY(usua_UsuarioModificacion)  REFERENCES Acce.tbUsuarios			(usua_Id)
);
GO


--Seccion pt2
CREATE TABLE Adua.tbLiquidacionGeneral(
	lige_Id					 INT IDENTITY(1,1),
	duca_Id				     INT NOT NULL,
	lige_TipoTributo		 NVARCHAR(50),
	lige_TotalPorTributo	 DECIMAL(18,2),
	lige_ModalidadPago		 NVARCHAR(55),
	lige_TotalGral			 DECIMAL(18,2),
	
	CONSTRAINT PK_Adua_tbLiquidacionGeneral_lige_Id PRIMARY KEY(lige_Id),
	CONSTRAINT FK_Adua_tbDuca_duca_Id_Adua_tbLiquidacionGeneral_duca_Id FOREIGN KEY (duca_Id) REFERENCES Adua.tbDuca (duca_Id)
	--CONSTRAINT FK_Adua_tbLiquidacionGeneral_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id	    FOREIGN KEY (usua_UsuarioCreacion)     		REFERENCES Acce.tbUsuarios 	(usua_Id),
	--CONSTRAINT FK_Adua_tbLiquidacionGeneral_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id	FOREIGN KEY (usua_UsuarioModificacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id),
	--CONSTRAINT FK_Adua_tbLiquidacionGeneral_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO


CREATE TABLE Adua.tbLiquidacionGeneralHistorial(
	hlig_Id 				 INT IDENTITY(1,1),
	lige_Id					 INT,
	lige_TipoTributo		 DECIMAL(18,2),
	lige_TotalPorTributo	 NVARCHAR(25),
	lige_ModalidadPago		 NVARCHAR(55),
	lige_TotalGral			 DECIMAL(18,2),
	duca_Id				     NVARCHAR(100),

	hlig_UsuarioAccion 		 INT,
	hlig_FechaAccion 		 DATETIME NOT NULL,
	hlig_Accion				 NVARCHAR(100)
);
GO




CREATE TABLE Adua.tbLiquidacionPorLinea(
	lili_Id					 INT	IDENTITY(1,1),
	lili_Tipo				 NVARCHAR(100),
	lili_Alicuota			 DECIMAL(18,2),
	lili_Total				 DECIMAL(18,2),
	lili_ModalidadPago		 NVARCHAR(150),
	lili_TotalGral			 DECIMAL(18,2),
	item_Id					 INT	NOT NULL,
	CONSTRAINT PK_Adua_tbLiquidacionPorLinea_lili_Id				 PRIMARY KEY(lili_Id),
	CONSTRAINT FK_Adua_tbItems_item_Id_tbLiquidacionPorLinea_item_Id FOREIGN KEY(item_Id) REFERENCES Adua.tbItems(item_Id)
	
);
GO


CREATE TABLE Adua.tbTipoDocumento(
	tido_Id				        INT IDENTITY(1,1),
	tido_Codigo     			CHAR(4) NOT NULL,
	tido_Descripcion	        NVARCHAR(50),

	usua_UsuarioCreacion		INT NOT NULL,
	tido_FechaCreacion		    DATETIME NOT NULL,
	usua_UsuarioModificacion 	INT DEFAULT NULL,
	tido_FechaModificacion		DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion	    INT	DEFAULT NULL,
	tido_FechaEliminacion		DATETIME DEFAULT NULL,
	tido_Estado 		        BIT DEFAULT 1
	CONSTRAINT PK_Adua_tbTipoDocumento_tido_Id 			PRIMARY KEY(tido_Id),
	CONSTRAINT UQ_Adua_tbTipoDocumento_tido_Codigo 		UNIQUE(tido_Codigo),
	CONSTRAINT UQ_Adua_tbTipoDocumento_tido_Descripcion UNIQUE(tido_Descripcion),
	CONSTRAINT FK_Adua_tbTipoDocumento_Acce_tbUsuarios_usua_UsuarioCreacion_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)     		REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Adua_tbTipoDocumento_Acce_tbUsuarios_usua_UsuarioModificacion_usua_Id		FOREIGN KEY (usua_UsuarioModificacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Adua_tbTipoDocumento__Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

CREATE TABLE Adua.tbDocumentosPDF(
    dpdf_Id                    INT IDENTITY (1,1),
	deva_Id					   INT NOT NULL,
    dpdf_CA                    NVARCHAR(200) NOT NULL,
    dpdf_DVA                   NVARCHAR(200) NOT NULL,
    dpdf_DUCA                  NVARCHAR(200) NOT NULL,
    dpdf_Boletin               NVARCHAR(200) NOT NULL,

	usua_UsuarioCreacion       INT NOT NULL,
    dpdf_FechaCreacion         DATETIME NOT NULL,
    usua_UsuarioModificacion   INT DEFAULT NULL,
    dpdf_FechaModificacion	   DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion	   INT	DEFAULT NULL,
	dpdf_FechaEliminacion	   DATETIME DEFAULT NULL,
    dpdf_Estado                BIT DEFAULT 1,
	CONSTRAINT PK_Adua_tbDocumentosPDF_dpdf_Id PRIMARY KEY (dpdf_Id),
	CONSTRAINT FK_Adua_tbDocumentosPDF_Adua_tbDeclaraciones_Valor_deva_Id			  FOREIGN KEY(deva_Id)				 REFERENCES Adua.tbDeclaraciones_Valor(deva_Id),
	CONSTRAINT FK_Acce_tbUsuarios_usua_Id_Gral_tbDocumentosPDF_usua_UsuarioCreacion   FOREIGN KEY (usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_usua_Id_Gral_tbDocumentosPDF_usua_UsuarioModicacion FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbDocumentosPDF_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
); 
GO

CREATE TABLE Adua.tbDocumentosPDFHistorial(
	hpdf_Id					   INT IDENTITY (1,1),
    dpdf_Id                    INT,
	deva_Id					   INT NOT NULL,
    dpdf_CA                    NVARCHAR(200) NOT NULL,
    dpdf_DVA                   NVARCHAR(200) NOT NULL,
    dpdf_DUCA                  NVARCHAR(200) NOT NULL,
    dpdf_Boletin               NVARCHAR(200) NOT NULL,

	hpdf_UsuarioAccion 			INT,
	hpdf_FechaAccion 			DATETIME,
	hpdf_Accion					NVARCHAR(100)
); 
GO

CREATE TABLE Adua.tbBoletinPago(
    boen_Id                        INT IDENTITY(1,1),
    liqu_Id                        INT NOT NULL,
	duca_No_Duca				   NVARCHAR(100),
    tipl_Id                        INT NOT NULL,
    boen_FechaEmision              DATE NOT NULL,
    esbo_Id                        INT NOT NULL,
    boen_Observaciones	           NVARCHAR(200) NOT NULL,
    boen_NDeclaracion	           NVARCHAR(200) NOT NULL,
    --pena_RTN                       NVARCHAR(40) NOT NULL,
    boen_Preimpreso                NVARCHAR(MAX) NOT NULL,
    --boen_Declarante                NVARCHAR(200) NOT NULL,
    boen_TotalPagar                DECIMAL(18,2) NULL,
    boen_TotalGarantizar           DECIMAL(18,2) NULL,
    --boen_RTN                       NVARCHAR(40) NOT NULL,
    --boen_TipoEncabezado            NVARCHAR(200) NOT NULL,
    coim_Id                        INT NOT NULL,
    copa_Id                        INT NOT NULL,

    usua_UsuarioCreacion           INT NOT NULL,
    boen_FechaCreacion             DATETIME NOT NULL,
    usua_UsuarioModificacion       INT DEFAULT NULL,
    boen_FechaModificacion         DATETIME DEFAULT NULL,
	--usua_UsuarioEliminacion		   INT	DEFAULT NULL,
	--boen_FechaEliminacion		   DATETIME DEFAULT NULL,
    boen_Estado                    BIT DEFAULT 1 NOT NULL,
    CONSTRAINT PK_Adua_tbBoletinPago_boen_Id 									      PRIMARY KEY (boen_Id),
	CONSTRAINT FK_Adua_tbBoletinPago_lige_Id_Adua_tbLiquidacionGeneral_lige_Id 		  FOREIGN KEY (liqu_Id)                  REFERENCES Adua.tbLiquidacionGeneral(lige_Id),
	CONSTRAINT FK_Adua_tbBoletinPago_tipl_Id_Adua_tbTipoLiquidacion_tipl_Id 		  FOREIGN KEY (tipl_Id)                  REFERENCES Adua.tbTipoLiquidacion(tipl_Id),
    CONSTRAINT FK_Adua_tbBoletinPago_esbo_Id_Adua_tbEstadoBoletin_esbo_Id 			  FOREIGN KEY (esbo_Id)                  REFERENCES Adua.tbEstadoBoletin(esbo_Id),
    CONSTRAINT FK_Adua_tbBoletinPago_coim_Id_Adua_tbCodigoImpuesto_coim_Id 			  FOREIGN KEY (coim_Id)                  REFERENCES Adua.tbCodigoImpuesto(coim_Id),
	CONSTRAINT FK_Adua_tbBoletinPago_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id     FOREIGN KEY (usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
    CONSTRAINT FK_Adua_tbBoletinPago_Acce_tbUsuarios_usua_UsuModificacion_usua_Id     FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	--CONSTRAINT FK_Adua_tbBoletinPago_Acce_tbUsuarios_usua_UsuarioEliminacion_usua_Id  FOREIGN KEY (usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Adua.tbBoletinPagoDetalles(
	bode_Id						   INT IDENTITY(1,1),
	boen_Id						   INT NOT NULL,
	lige_Id						   INT NOT NULL,
	bode_Concepto				   VARCHAR(50) NOT NULL,
	bode_TipoObligacion			   VARCHAR(50) NOT NULL,
	bode_CuentaPA01				   INT NOT NULL,

	usua_UsuarioCreacion           INT NOT NULL,
    bode_FechaCreacion             DATETIME NOT NULL,
    usua_UsuarioModificacion       INT DEFAULT NULL,
    bode_FechaModificacion         DATETIME DEFAULT NULL,
	CONSTRAINT PK_Adua_tbBoletinPagoDetalles_bode_Id PRIMARY KEY (bode_Id),
	CONSTRAINT FK_Adua_tbBoletinPagoDetalles_boen_Id_Adua_tbBoletinPago_boen_Id FOREIGN KEY (boen_Id) REFERENCES Adua.tbBoletinPago (boen_Id),
	CONSTRAINT FK_Adua_tbBoletinPagoDetalles_lige_Id_Adua_tbLiquidacionGeneral_lige_Id FOREIGN KEY (lige_Id) REFERENCES Adua.tbLiquidacionGeneral (lige_Id),
	CONSTRAINT FK_Adua_tbBoletinPagoDetalles_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Adua_tbBoletinPagoDetalles_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
);
GO

CREATE TABLE Adua.tbDocumentosDeSoporte(
	doso_Id						        INT IDENTITY(1,1),
	tido_Id					        	INT NOT NULL,
	duca_Id								INT NOT NULL,
	doso_NumeroDocumento		        NVARCHAR(15) NOT NULL,
	doso_FechaEmision			        DATE,
	doso_FechaVencimiento		        DATE,
	doso_PaisEmision			        INT ,
	doso_LineaAplica			        CHAR(4),
	doso_EntidadEmitioDocumento         NVARCHAR(75),
	doso_Monto				           	NVARCHAR(50),

	usua_UsuarioCreacion				INT NOT NULL,
	doso_FechaCreacion			        DATETIME NOT NULL,
	usua_UsuarioModificacion 		    INT DEFAULT NULL,
	doso_FechaModificacion		        DATETIME DEFAULT NULL,
	usua_UsuarioEliminacion				INT	DEFAULT NULL,
	doso_FechaEliminacion				DATETIME DEFAULT NULL,
	doso_Estado 				        BIT DEFAULT 1
	CONSTRAINT PK_Adua_tbDocumentosDeSoporte_doso_Id PRIMARY KEY(doso_Id),
	CONSTRAINT FK_tbDocumentosDeSoporte_Adua_tbTipoDocumento_tido_Id	            				FOREIGN KEY (tido_Id) 			        	REFERENCES Adua.tbTipoDocumento(tido_Id),
	CONSTRAINT FK_Adua_tbDocumentosDeSoporte_Adua_tbDuca_duca_Id FOREIGN KEY (duca_Id) REFERENCES Adua.tbDuca(duca_Id),
	CONSTRAINT FK_Adua_tbDocumentosDeSoporte_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id			FOREIGN KEY (usua_UsuarioCreacion)     		REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Adua_tbDocumentosDeSoporte_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id		FOREIGN KEY (usua_UsuarioModificacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id),
	CONSTRAINT FK_Adua_tbDocumentosDeSoporte_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id 		FOREIGN KEY (usua_UsuarioEliminacion) 		REFERENCES Acce.tbUsuarios 	(usua_Id)
);
GO

CREATE TABLE Prod.tbRevisionDeCalidadErrores(
		rcer_Id						   INT 				IDENTITY(1,1),
		rcer_Nombre 				   NVARCHAR(150) 		NOT NULL,
		usua_UsuarioCreacion 		   INT					NOT NULL,
		rcer_FechaCreacion 			   DATETIME 			NOT NULL,
		usua_UsuarioModificacion	   INT					DEFAULT NULL,
		rcer_FechaModificacion		   DATETIME 			DEFAULT NULL,	
		usua_UsuarioEliminacion 	   INT					DEFAULT NULL,
		rcer_FechaEliminacion		   DATETIME 			DEFAULT NULL,
		rcer_Estado					   BIT					DEFAULT 1,
		
	CONSTRAINT PK_Prod_tbRevisionDeCalidadErros_rcer_Id PRIMARY KEY (rcer_Id),
	CONSTRAINT FK_Prod_tbRevisionDeCalidadErros_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id 	 FOREIGN KEY(usua_UsuarioCreacion)     REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbRevisionDeCalidadErros_usua_UsuarioModificacion_Acce_tbUsuarios_usua_Id FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios (usua_Id),
	CONSTRAINT FK_Prod_tbRevisionDeCalidadErros_usua_UsuarioEliminacion_Acce_tbUsuarios_usua_Id  FOREIGN KEY(usua_UsuarioEliminacion)  REFERENCES Acce.tbUsuarios (usua_Id)
	
);
GO

CREATE TABLE Adua.tbDocumentosSanciones(
	dosa_Id						INT IDENTITY(1,1),
	dosa_NombreDocumento		NVARCHAR(150) NOT NULL,
	dosa_UrlDocumento			NVARCHAR(250) NOT NULL,
	usua_UsuarioCreacion		INT NOT NULL,
	dosa_FechaCreacion			DATETIME NOT NULL,
	CONSTRAINT PK_Adua_tbDocumentosSanciones_dosa_Id PRIMARY KEY (dosa_Id),
	CONSTRAINT FK_Adua_tbDocumentosSanciones_usua_UsuarioCreacion_Acce_tbUsuarios_usua_Id FOREIGN KEY (usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios (usua_Id)
);
GO

CREATE TABLE Prod.tbImpuestosProd
(
	impr_Id				INT IDENTITY(1,1),
	impr_Descripcion	NVARCHAR(MAX),
	impr_Valor			DECIMAL(18,4),
	CONSTRAINT PK_Prod_tbImpuestosProd_impr_Id PRIMARY KEY(impr_Id)
);
GO

CREATE TABLE Adua.tbItemsDEVAPorDuca (
		dedu_Id						INT IDENTITY(1,1),
		duca_Id						INT,
		deva_Id						INT,

		usua_UsuarioCreacion		INT,
		dedu_FechaCreacion			DATETIME,
		usua_UsuarioModificacion	INT,
		dedu_FechaModificacion		DATETIME

		CONSTRAINT PK_Adua_tbItemsDEVAPorDuca_dedu_Id										PRIMARY KEY (dedu_Id),
		CONSTRAINT FK_Adua_tbItemsDEVAPorDuca_duca_Id_Adua_tbDuca_duca_Id					FOREIGN KEY (duca_Id)  REFERENCES Adua.tbDuca (duca_Id),
		CONSTRAINT FK_Adua_tbItemsDEVAPorDuca_deva_Id_Adua_tbDeclaraciones_Valor_deva_Id	FOREIGN KEY (deva_Id)  REFERENCES Adua.tbDeclaraciones_Valor (deva_Id),

		CONSTRAINT FK_Acce_tbUsuarios_Adua_tbItemsDEVAPorDuca_usua_UsuarioCreacion 			FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
		CONSTRAINT FK_Acce_tbUsuarios_Adua_tbItemsDEVAPorDuca_usua_UsuarioModificacion		FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id),
);
GO

CREATE TABLE Adua.tbTratadosLibreComercio(
	trli_Id						INT IDENTITY(1,1),
	trli_NombreTratado			NVARCHAR(500) NOT NULL,
	trli_FechaInicio			DATE NOT NULL,
	usua_UsuarioCreacion		INT NOT NULL,
	trli_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT,
	trli_FechaModificacion		DATETIME

	CONSTRAINT PK_Adua_tbTratadosLibreComercio_trli_Id											PRIMARY KEY (trli_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbTratadosLibreComercio_usua_UsuarioCreacion 			FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbTratadosLibreComercio_usua_UsuarioModificacion			FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id),
);

GO

CREATE TABLE Adua.tbPaisesEstanTratadosConHonduras(
	patr_Id						INT IDENTITY(1,1),
	trli_Id						INT,
	pais_Id						INT,
	usua_UsuarioCreacion		INT NOT NULL,
	patr_FechaCreacion			DATETIME NOT NULL,
	usua_UsuarioModificacion	INT,
	patr_FechaModificacion		DATETIME

	CONSTRAINT PK_Adua_tbPaisesEstanTratadoConHonduras_patr_Id											PRIMARY KEY(patr_Id),
	CONSTRAINT FK_Adua_tbPaisesEstanTratadoConHonduras_Adua_tbTratadosLibreComercio_trli_Id 			FOREIGN KEY (trli_Id)		REFERENCES Adua.tbTratadosLibreComercio(trli_Id),
	CONSTRAINT FK_Adua_tbPaisesEstanTratadoConHonduras_Gral_tbPaises_pais_Id							FOREIGN KEY (pais_Id)		REFERENCES Gral.tbPaises(pais_Id),

	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbPaisesEstanTratadoConHonduras_usua_UsuarioCreacion 			FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbPaisesEstanTratadoConHonduras_usua_UsuarioModificacion			FOREIGN KEY (usua_UsuarioModificacion)	REFERENCES Acce.tbUsuarios(usua_Id),
);
GO

CREATE TABLE Adua.tbArancelesPorTratados(
	axtl_Id					INT IDENTITY(1,1),
	aran_Id					INT NOT NULL,
	trli_Id					INT NOT NULL,
	axtl_TasaActual			DECIMAL(18,4) NOT NULL,
	usua_usuarioCreacion	INT NOT NULL,
	axtl_FechaCreacion		DATETIME  NOT NULL

	CONSTRAINT PK_Adua_tbArancelesPorTratados_axtl_Id											PRIMARY KEY(axtl_Id),
	CONSTRAINT FK_Acce_tbUsuarios_Adua_tbArancelesPorTratados_usua_UsuarioCreacion 			FOREIGN KEY (usua_UsuarioCreacion)		REFERENCES Acce.tbUsuarios(usua_Id),
);

--**********************************************************************************************
--********** TABLA PAISES / procedimientos tomando en cuenta los uniques ***********************
ALTER TABLE Acce.tbUsuarios
ADD CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioCreacion FOREIGN KEY(usua_UsuarioCreacion) REFERENCES Acce.tbUsuarios(usua_Id)
GO
ALTER TABLE Acce.tbUsuarios
ADD CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioModificacion FOREIGN KEY(usua_UsuarioModificacion) REFERENCES Acce.tbUsuarios(usua_Id)
GO
ALTER TABLE Acce.tbUsuarios
ADD CONSTRAINT FK_Acce_tbUsuarios_usua_UsuarioEliminacion FOREIGN KEY(usua_UsuarioEliminacion) REFERENCES Acce.tbUsuarios(usua_Id)
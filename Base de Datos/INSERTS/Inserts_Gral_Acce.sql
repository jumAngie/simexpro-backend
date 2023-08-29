
--- AQUI ESTAN LOS INSERTS DE LAS TABLAS DE ACCESO Y GENERALES ---



-----------------------------------------------------------------
-- *************************** ACCESO *************************--

/*---------------------------------*/
--***** INSERT TABLA ROLES --******--
GO
INSERT INTO [Acce].[tbRoles]
    ([role_Descripcion]
    ,[usua_UsuarioCreacion]
    ,[role_FechaCreacion]
    ,[usua_UsuarioModificacion]
    ,[role_FechaModificacion]
    ,[usua_UsuarioEliminacion]
    ,[role_FechaEliminacion]
    ,[role_Estado]
	,role_Aduana)
VALUES
    ('Gerente de Operaciones',					1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Ejecutivo de Ventas',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Analista de Logística',					1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Agente de Aduanas',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Asistente Administrativo',				1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Coordinador de Transporte',				1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Operador de Almacén',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Inspector Aduanero',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Analista de Documentación',				1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 1),
    ('Asesor Comercial',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Operario de Máquina de Tejido',			1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Técnico de Mantenimiento de Telares',		1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Supervisor de Producción',				1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Control de Calidad',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Operario de Acabado',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Jefe de Línea de Producción',				1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Ingeniero Textil',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Auxiliar de Almacén de Materias Primas',	1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Diseñador Textil',						1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0),
    ('Operario de Corte de Telas',				1, '10-16-2004', NULL, NULL, NULL, NULL, 1, 0);


/*---------------------------------*/
--***** INSERT TABLA USUARIOS --******--
--GO
--INSERT INTO Acce.tbUsuarios (usua_Nombre, usua_Contrasenia, empl_Id, usua_Image, role_Id, usua_EsAdmin, usua_UsuarioCreacion, usua_FechaCreacion)
--VALUES	('Juan Perez',		'contrasenia123',	1, 'imagen_juan.jpg',	1,	0, 1,'10-16-2004'),
--		('Maria Rodriguez',	'maria2023',		1, 'imagen_maria.jpg',	2,	0, 1,'10-16-2004'),
--		('Pedro Gomez',		'12345678',			1, 'imagen_pedro.jpg',	3,	0, 1,'10-16-2004'),
--		('Ana Torres',		'ana2023',			1, 'imagen_ana.jpg',	4,	0, 1,'10-16-2004'),
--		('Carlos Ramirez',	'carlos789',		1, 'imagen_carlos.jpg', 5,	0, 1,'10-16-2004'),
--		('Luisa Chavez',	'luisa123',			1, 'imagen_luisa.jpg',	10, 0, 1,'10-16-2004'),
--		('Sofia Fernandez',	'sofia2023',		1, 'imagen_sofia.jpg',	11, 0, 1,'10-16-2004'),
--		('Diego Morales',	'morales321',		1, 'imagen_diego.jpg',	12, 0, 1,'10-16-2004'),
--		('Laura Ramirez',	'laura456',			1, 'imagen_laura.jpg',	13, 0, 1,'10-16-2004'),
--		('Ricardo Herrera',	'ricardo2023',		1, 'imagen_ricardo.jpg',14, 0, 1,'10-16-2004');



/*------------------------------------*/
--***** INSERT TABLA PANTALLAS --******--
--GO
--INSERT INTO Acce.tbPantallas(pant_Nombre, pant_URL, pant_Icono, usua_UsuarioCreacion, pant_FechaCreacion)
--VALUES
--        ('Generales.monedas', 'Monedas/Index', '', 1, GETDATE()),
--        ('Personas.oficinas', 'Oficinas/Index', '', 1, GETDATE()),
--        ('Personas.oficios_profesiones', 'OficiosProfesiones/Index', '', 1, GETDATE()),
--        ('Ubicaciones.paises', 'Paises/Index', '', 1, GETDATE()),
--        ('Ubicaciones.provincias', 'Provincias/Index', '', 1, GETDATE()),
--        ('Ubicaciones.ciudades', 'Ciudades/Index', '', 1, GETDATE()),
--        ('Ubicaciones.aldeas', 'Aldea/Index', '', 1, GETDATE()),
--        ('Ubicaciones.colonias', 'Colonias/Index', '', 1, GETDATE()),
--        ('Personas.cargos', 'Cargos/Index', '', 1, GETDATE())
--Acceso
INSERT INTO [Acce].[tbPantallas](	[pant_Nombre],	[pant_URL],				[pant_Icono],						[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES (						'Inicio',		'/dashboards/analytics','heroicons-outline:clipboard-check','Gral',			null, null,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Usuarios','/Usuarios/Index','material-outline:hail','Acce', 'Acceso', null,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Roles','/Roles/Index','material-outline:manage_search','Acce',  'Acceso', null,1,GETDATE())
GO
--//Acceso//

--Generales

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Formas de envío','/FormasEnvio/Index','material-outline:taxi_alert','Gral', 'Generales',NULL,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Monedas','Monedas/Index','material-outline:attach_money','Gral', 'Generales',NULL,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Tipos de Identificacion','TipoIdentificacion/Index','heroicons-outline:identification','Gral', 'Generales',NULL,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])--???????????????????????????
     VALUES ('Oficinas','Oficinas/Index','material-outline:computer','Adua', 'Administración', 1,1,GETDATE())
GO


INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Oficios y Profesiones','OficiosProfesiones/Index','heroicons-outline:academic-cap','Gral', 'Generales',NULL,1,GETDATE())
GO
--//Generales//

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Unidades de medida','UnidadesMedida/Index','material-outline:aspect_ratio','Gral', 'Generales', NULL,1,GETDATE())
GO

--UBICACION
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Aldeas','/Aldeas/Index','material-outline:cabin','Gral', 'Ubicaciones', 0,1,GETDATE())
GO
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Ciudades','Ciudades/Index','material-outline:business','Gral', 'Ubicaciones', NULL,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Colonias','/Colonias/Index','material-outline:holiday_village','Gral', 'Ubicaciones', 0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Países','Paises/Index','material-outline:map','Gral',  'Ubicaciones', NULL,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Provincias','Provincias/Index','material-outline:house','Gral', 'Ubicaciones', NULL,1,GETDATE())
GO
--//UBICACION//
--PERSONAS
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Cargos','Cargos/Index','material-outline:cleaning_services','Gral', 'Personas', 0,1,GETDATE())
GO
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])--???????????????????????????
     VALUES ('Clientes','Clientes/Index','material-outline:airline_seat_recline_normal','Gral', 'Personas',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Estados Civiles','EstadosCiviles/Index','material-outline:male','Gral', 'Personas',NULL,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Empleados','Empleados/Index','material-outline:groups','Gral', 'Personas',NULL,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Proveedores','/Proveedores/Index','heroicons-solid:user','Gral', 'Personas',NULL,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Personas','Personas/Index','heroicons-solid:users','Gral', 'Personas',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Tipos de Intermediarios','/TipoIntermediario/Index','heroicons-solid:user-add','Gral', 'Personas',1,1,GETDATE())
GO
--//PERSONAS//




--//Generales//
--Aduanas

--Contrato de adhesion
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Persona Natural','/Contrato-de-Adhesion-Persona-Natural/Index','heroicons-solid:user','Adua', 'Contrato de Adhesión', 1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Comerciante Individual','/Contrato-de-Adhesion-Comerciante-Individual/Index','heroicons-solid:user','Adua', 'Contrato de Adhesión', 1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Persona Juridica','/Contrato-de-Adhesion-Persona-Juridica/Index','heroicons-solid:user','Adua', 'Contrato de Adhesión', 1,1,GETDATE())
GO
--//Contrato de adhesion//
--Declaracion de valor
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Declaracion de valor','Declaracion_Valor/Index','material-outline:fact_check','Adua', null, 1,1,GETDATE())
GO

--//Declaracion de valor//
--DUCA
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Duca','Duca/Index','material-outline:article','Adua', null, 1,1,GETDATE())
GO
--//DUCA//
--Boletin de pago
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Boletin de Pago','BoletindePago/BoletinDePagoIndex','material-outline:price_check','Adua', null, 1,1,GETDATE())
GO
--//Boletin de pago//
--Documento de Sanciones
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Documento de Sanciones','Documentos/Sanciones','material-twotone:find_in_page','Adua', null, 1,1,GETDATE())
GO
--//Documento de Sanciones//
--Impuestos

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Aranceles','/Aranceles/Index','heroicons-solid:newspaper','Adua', 'Impuestos', 1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Código de Impuestos','/CodigoImpuesto/Index','heroicons-solid:qrcode','Adua', 'Impuestos',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Concepto de Pago','/ConceptoPago/Index','heroicons-solid:receipt-refund','Adua', 'Impuestos',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Impuestos','/Impuestos/Index','heroicons-solid:scale','Adua', 'Impuestos',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Íncoterms','/Incoterm/Index','heroicons-solid:table','Adua', 'Impuestos',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Liquidación General','/LiquidacionGeneral/Index','material-solid:campaign','Adua', 'Impuestos',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Liquidación Por Línea','/LiquidacionPorLinea/Index','material-solid:charging_station','Adua', 'Impuestos',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Tipo de Liquidación','/TipoLiquidacion/Index','material-solid:donut_small','Adua','Impuestos',1,1,GETDATE())
GO
--//Impuestos//
--Transporte

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Marcas de Carros','/MarcasCarros/Index','material-solid:directions_car','Adua', 'Transporte',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Modo de Transporte','/ModoTransporte/Index','material-solid:local_shipping','Adua', 'Transporte',1,1,GETDATE())
GO

--//Transporte//
--Facturacion
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Formas de Pago','/FormasPago/Index','material-solid:file_present','Adua', 'Facturación',1,1,GETDATE())
GO
--//Facturacion//


--Administracion

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Estados del Boletín','/EstadoBoletin/Index','material-solid:nfc','Adua', 'Administración',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Estados de las mercancías','/EstadoMercancia/Index','material-solid:offline_pin','Adua', 'Administración',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Lugares de Embarque','/LugaresEmbarque/Index','material-solid:sailing','Adua', 'Administración',1,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Niveles Comerciales','/NivelesComerciales/Index','material-solid:shopping_cart','Adua', 'Administración',1,1,GETDATE())
GO

--// Administracion//

--//Aduanas//






INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])--???????????????????????????
     VALUES ('Tipo de Documento','/TipoDocumento/Index','material-outline:backup_table','Adua', 'Administración', 1,1,GETDATE())
GO




--Producción

--Producción 2 xd
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Planificación','/Planificacion/Index','material-outline:hail','Prod', 'Producción',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Módulos','/Modulos/Index','material-outline:iron','Prod', 'Producción',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Orden de Procesos','/OrdenProcesos/Index','material-outline:insights','Prod', 'Producción',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Órden de Compra','/OrdenCompra/Index','material-outline:library_books','Prod', 'Producción',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Órden de Pedido','/OrdenPedido/Index','material-outline:library_books','Prod', 'Producción',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Pedidos de Producción','PedidosProduccion/Index','material-outline:local_mall','Prod', 'Producción',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Procesos','/Procesos/Index','material-outline:mediation','Prod', 'Producción',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Revisión de Calidad','/RevisionCalidad/Index','material-outline:pageview','Prod', 'Producción',0,1,GETDATE())
GO
--//Producción//

--Maquinaria
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Funciones de Máquinas','/FuncionesMaquina/Index','material-outline:bike_scooter','Prod', 'Maquinaria',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Historial de Máquinas','/MaquinaHistorial/Index','material-outline:all_inbox','Prod', 'Maquinaria',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Marcas de Máquinas','/MarcasMaquina/Index','material-outline:auto_stories','Prod', 'Maquinaria',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Máquinas','/Maquinas/Index','material-outline:auto_stories','Prod', 'Maquinaria',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Modelos de Máquinas','/ModelosMaquina/Index','material-outline:biotech','Prod', 'Maquinaria',0,1,GETDATE())
GO
--//Maquinaria//

--Inventario
INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Áreas','/Areas/Index','material-outline:all_inbox','Prod', 'Inventario',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Categorías','/Categorias/Index','material-outline:category','Prod', 'Inventario',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Lotes','/Lotes/Index','material-outline:card_membership','Prod', 'Inventario',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Materiales','/Materiales/Index','material-outline:bakery_dining','Prod', 'Inventario',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Materiales a Brindar','/MaterialesBrindar/Index','material-outline:business_center','Prod', 'Inventario',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Subcategorias','/Subcategorias/Index','material-outline:apps','Prod', 'Inventario',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Tipo de Embalaje','/TipoEmbalaje/Index','material-outline:integration_instructions','Prod', 'Inventario',0,1,GETDATE())
GO
--//Inventario//

--Prendas

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Colores','/Colores/Index','material-outline:format_color_fill','Prod', 'Prendas',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Estilos','/Estilos/Index','material-outline:design_services','Prod', 'Prendas',0,1,GETDATE())
GO

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Tallas','/Tallas/Index','material-outline:dry_cleaning','Prod', 'Prendas',0,1,GETDATE())
GO
--//Prendas//

--Reportes

INSERT INTO [Acce].[tbPantallas]([pant_Nombre],[pant_URL],[pant_Icono],[pant_Esquema], [pant_Subcategoria],[pant_EsAduana],[usua_UsuarioCreacion],[pant_FechaCreacion])
     VALUES ('Reportes de Módulos','/ReporteModulo/Index','heroicons-outline:document-report','Prod', null,0,1,GETDATE())
GO

--Reportes

INSERT INTO acce.tbRolesXPantallas( [pant_Id], [role_Id], [usua_UsuarioCreacion], [ropa_FechaCreacion], [ropa_Estado])
VALUES
	  (11, 2,  1, '2023-08-11', 1),
	  (12, 2,  1, '2023-08-11', 1),
	  (13, 2,  1, '2023-08-11', 1),
	  (14, 2,  1, '2023-08-11', 1),
	  (15, 3,  1, '2023-08-11', 1),
	  (16, 3,  1, '2023-08-11', 1),
	  (17, 3,  1, '2023-08-11', 1),
	  (18, 3,  1, '2023-08-11', 1),
	  (19, 4,  1, '2023-08-11', 1),
	  (20, 4,  1, '2023-08-11', 1),
	  (21, 4,  1, '2023-08-11', 1),
	  (22, 4,  1, '2023-08-11', 1),
	  (23, 5,  1, '2023-08-11', 1),
	  (24, 5,  1, '2023-08-11', 1),
	  (25, 5,  1, '2023-08-11', 1),
	  (26, 5,  1, '2023-08-11', 1),
	  (27, 6,  1, '2023-08-11', 1),
	  (28, 6,  1, '2023-08-11', 1),
	  (29, 6,  1, '2023-08-11', 1),
	  (30, 6,  1, '2023-08-11', 1),
	  (31, 7,  1, '2023-08-11', 1),
	  (32, 7,  1, '2023-08-11', 1),
	  (33, 7,  1, '2023-08-11', 1),
	  (34, 7,  1, '2023-08-11', 1),
	  (35, 8,  1, '2023-08-11', 1),
	  (36, 8,  1, '2023-08-11', 1),
	  (37, 8,  1, '2023-08-11', 1),
	  (38, 8,  1, '2023-08-11', 1),
	  (39, 9,  1, '2023-08-11', 1),
	  (40, 9,  1, '2023-08-11', 1),
	  (41, 9,  1, '2023-08-11', 1),
	  (42, 9,  1, '2023-08-11', 1),
	  (10, 10, 1, '2023-08-11', 1),
	  (11, 10, 1, '2023-08-11', 1),
	  (12, 10, 1, '2023-08-11', 1),
	  (13, 11, 1, '2023-08-11', 1),
	  (14, 11, 1, '2023-08-11', 1),
	  (15, 11, 1, '2023-08-11', 1),
	  (16, 12, 1, '2023-08-11', 1),
	  (17, 12, 1, '2023-08-11', 1),
	  (18, 12, 1, '2023-08-11', 1),
	  (19, 13, 1, '2023-08-11', 1),
	  (21, 13, 1, '2023-08-11', 1),
	  (22, 13, 1, '2023-08-11', 1),
	  (23, 15, 1, '2023-08-11', 1),
	  (24, 15, 1, '2023-08-11', 1),
	  (25, 15, 1, '2023-08-11', 1),
	  (26, 16, 1, '2023-08-11', 1),
	  (27, 16, 1, '2023-08-11', 1),
	  (54, 16, 1, '2023-08-11', 1),
	  (55, 17, 1, '2023-08-11', 1),
	  (56, 17, 1, '2023-08-11', 1),
	  (57, 17, 1, '2023-08-11', 1),
	  (58, 18, 1, '2023-08-11', 1),
	  (59, 18, 1, '2023-08-11', 1),
	  (60, 18, 1, '2023-08-11', 1),
	  (61, 19, 1, '2023-08-11', 1),
	  (62, 19, 1, '2023-08-11', 1),
	  (10, 19, 1, '2023-08-11', 1),
	  (10, 20, 1, '2023-08-11', 1),
	  (11, 20, 1, '2023-08-11', 1),
	  (12, 20, 1, '2023-08-11', 1),
	  (13, 12, 1, '2023-08-11', 1),
	  (14, 12, 1, '2023-08-11', 1),
	  (15, 12, 1, '2023-08-11', 1),
	  (10, 12, 1, '2023-08-11', 1);

--------------------------------------------------------------------
-- *************************** GENERALES *************************--

/*-----------------------------------*/
--***** INSERT TABLA CARGOS --******--
GO
INSERT INTO [Gral].[tbCargos] ([carg_Nombre], usua_UsuarioCreacion, [carg_FechaCreacion], carg_Aduana)
VALUES ('Operario',					1, GETDATE(), 0),
	   ('Supervisor de módulo',		1, GETDATE(), 0),
	   ('Coordinador de logística', 1, GETDATE(), 0),
	   ('Gerente de RRHH',			1, GETDATE(), 0);


/*-------------------------------------------*/
--***** INSERT TABLA ESTADOS CIVILES Aduanas --******--
GO
INSERT INTO [Gral].[tbEstadosCiviles] ([escv_Nombre], [escv_EsAduana],[usua_UsuarioCreacion], [escv_FechaCreacion], [usua_UsuarioModificacion], [escv_FechaModificacion], [usua_UsuarioEliminacion], [escv_FechaEliminacion], [escv_Estado])
VALUES ('Soltero(a)',		1,1, GETDATE(),NULL,NULL,NULL,NULL,1),
	   ('Casado(a)',		1,1, GETDATE(),NULL,NULL,NULL,NULL,1),
	   ('Divorciado(a)',	1,1, GETDATE(),NULL,NULL,NULL,NULL,1),
	   ('Viudo(a)',			1,1, GETDATE(),NULL,NULL,NULL,NULL,1),
	   ('Unión Libre',		1,1, GETDATE(),NULL,NULL,NULL,NULL,1);

 --***** INSERT TABLA ESTADOS CIVILES Produccion --******--
INSERT INTO [Gral].[tbEstadosCiviles] ([escv_Nombre], [escv_EsAduana],[usua_UsuarioCreacion], [escv_FechaCreacion], [usua_UsuarioModificacion], [escv_FechaModificacion], [usua_UsuarioEliminacion], [escv_FechaEliminacion], [escv_Estado])
VALUES ('Soltero(a)',		0,1, GETDATE(),NULL,NULL,NULL,NULL,1),
	   ('Casado(a)',		0,1, GETDATE(),NULL,NULL,NULL,NULL,1),
	   ('Divorciado(a)',	0,1, GETDATE(),NULL,NULL,NULL,NULL,1),
	   ('Viudo(a)',			0,1, GETDATE(),NULL,NULL,NULL,NULL,1),
	   ('Unión Libre',		0,1, GETDATE(),NULL,NULL,NULL,NULL,1);

/*------------------------------------*/
--***** INSERT TABLA OFICINAS --******--
GO
INSERT INTO [Gral].[tbOficinas] ([ofic_Nombre], usua_UsuarioCreacion, [ofic_FechaCreacion])
VALUES ('TEGUCIGALPA, M.D.C.',		1, GETDATE()),
	   ('SAN PEDRO SULA, CORTÉS',	1, GETDATE());


/*----------------------------------------------*/
--***** INSERT TABLA OFICIO PROFESIONES --******--
GO
INSERT INTO [Gral].[tbOficio_Profesiones] ([ofpr_Nombre], usua_UsuarioCreacion, [ofpr_FechaCreacion])
VALUES ('OFICIALES DE LAS FUERZAS ARMADAS',								1, GETDATE()),
	   ('SUBOFICIALES DE LAS FUERZAS ARMADAS',							1, GETDATE()),	
	   ('OTROS MIEMBROS DE LAS FUERZAS ARMADAS',						1, GETDATE()),
	   ('MIEMBROS DEL PODER EJECUTIVO Y DE LOS CUERPOS LEGISLATIVOS',	1, GETDATE());


/*---------------------------------------------*/
--***** INSERT TABLA UNIDAD DE MEDIDAS --******--
GO
INSERT INTO [Gral].[tbUnidadMedidas](unme_Descripcion, usua_UsuarioCreacion, unme_FechaCreacion, [unme_EsAduana], unme_Estado)
VALUES('01 - KILOGRAMO NETO',	1, GETDATE(),1,1), 
	  ('METRO CUADRADO',		1, GETDATE(),1,1), 
	  ('METRO',					1, GETDATE(),1,1), 
	  ('TONELADA METRICA',		1, GETDATE(),1,1), 
	  ('PAR',					1, GETDATE(),1,1), 
	  ('DOCENA',				1, GETDATE(),1,1), 
	  ('TONELADA BRUTA',		1, GETDATE(),1,1), 
	  ('CENTILITRO ALC PURO',	1, GETDATE(),1,1), 
	  ('LITRO',					1, GETDATE(),1,1), 
	  ('GRAMO NETO',			1, GETDATE(),1,1), 
	  ('METRO CUBICO',			1, GETDATE(),1,1), 
	  ('GALON',					1, GETDATE(),1,1), 
	  ('YARDA',					1, GETDATE(),1,1), 
	  ('UNIDAD',				1, GETDATE(),1,1), 
	  ('KILATAJE',				1, GETDATE(),1,1), 
	  ('KILOWATT HORA',			1, GETDATE(),1,1), 
	  ('PIEZA',					1, GETDATE(),1,1), 
	  ('CABEZA',				1, GETDATE(),1,1), 
	  ('PAQUETE',				1, GETDATE(),1,1), 
	  ('LIBRA',					1, GETDATE(),1,1), 
	  ('PARTE Y PIEZA SUELTA',	1, GETDATE(),1,1), 
	  ('BARRIL',				1, GETDATE(),1,1), 
	  ('MILILITRO',				1, GETDATE(),1,1), 
	  ('PIES',					1, GETDATE(),1,1), 
	  ('PIES CUBICOS',			1, GETDATE(),1,1), 
	  ('MILLAR PULGADA CUADR',	1, GETDATE(),1,1), 
	  ('PULGADA IMPERIAL',		1, GETDATE(),1,1), 
	  ('UNIDAD DE MILLAR',		1, GETDATE(),1,1), 
	  ('DECENA DE MILLAR',		1, GETDATE(),1,1), 
	  ('CENTENA DE MILLAR',		1, GETDATE(),1,1), 
	  ('KILOGRAMO BRUTO',		1, GETDATE(),1,1);

/*-----------------------------------*/
--***** INSERT TABLA PAISES --******--
GO

INSERT INTO [Gral].[tbPaises] ([pais_Codigo], [pais_Nombre], [pais_EsAduana], [usua_UsuarioCreacion], [pais_FechaCreacion])
VALUES	('AD', 'ANDORRA',					1, 1, GETDATE()),
		('AE', 'EMIRATOS ARABES UNIDOS',	1, 1, GETDATE()),
		('AF', 'AFGANISTAN',				1, 1, GETDATE()),
		('AG', 'ANTIGUA Y BARBUDA',			1, 1, GETDATE()),
		('AI', 'ANGUILLA',					1, 1, GETDATE()),
		('AL', 'ALBANIA',					1, 1, GETDATE()),
		('AM', 'ARMENIA',					1, 1, GETDATE()),
		('AN', 'ANTILLAS HOLANDESAS',		1, 1, GETDATE()),
		('AO', 'ANGOLA',					1, 1, GETDATE()),
		('AQ', 'ANTARTIDA',					1, 1, GETDATE()),
		('AR', 'ARGENTINA',					1, 1, GETDATE()),
		('AS', 'SAMOA AMERICANA',			1, 1, GETDATE()),
		('AT', 'AUSTRIA',					1, 1, GETDATE()),
		('AU', 'AUSTRALIA',					1, 1, GETDATE()),
		('AW', 'ARUBA',						1, 1, GETDATE()),
		('AX', 'ALAND, ISLAS',				1, 1, GETDATE()),
		('AZ', 'AZERBALIAN',				1, 1, GETDATE()),
		('BA', 'BOSNIA Y HERZSEGOVINA',		1, 1, GETDATE()),
		('BB', 'BARBADOS',					1, 1, GETDATE()),
		('BD', 'BANGLADESH',				1, 1, GETDATE()),
		('BE', 'BELGICA',					1, 1, GETDATE()),
		('BF', 'BURKINA FASO',				1, 1, GETDATE()),
		('BG', 'BULGARIA',					1, 1, GETDATE()),
		('BH', 'BAHREIN',					1, 1, GETDATE()),
		('BI', 'BURUNDI',					1, 1, GETDATE()),
		('BJ', 'BENIN',						1, 1, GETDATE()),
		('BL', 'SAINT BARTHELEMY',			1, 1, GETDATE()),
		('BM', 'BERMUDA',					1, 1, GETDATE()),
		('BN', 'BRUNEI DARUSSALAM',			1, 1, GETDATE()),
		('BO', 'BOLIVIA',					1, 1, GETDATE()),
		('BQ', 'BONAIRE, SINT EUSTATIUS AND SABA', 0, 1, GETDATE()),
		('BR', 'BRASIL',					1, 1, GETDATE()),
		('BS', 'BAHAMAS',					1, 1, GETDATE()),
		('BT', 'BUTAN',						1, 1, GETDATE()),
		('BV', 'BOUVET, ISLA',				1, 1, GETDATE()),
		('BW', 'BOTSWANA',					1, 1, GETDATE()),
		('BY', 'BIELORRUSIA',				1, 1, GETDATE()),
		('BZ', 'BELICE',					1, 1, GETDATE()),
		('CA', 'CANADA',					1, 1, GETDATE()),
		('CC', 'COCOS (KEELING) ISLAS',		1, 1, GETDATE()),
		('CD', 'CONGO, REPUBLICA DEMOCRATICA', 0, 1, GETDATE()),
		('CF', 'CENTROAFRICANA, REPUBLICA', 1, 1, GETDATE()),
		('CG', 'CONGO, REP. POPULAR DEL',	1, 1, GETDATE()),
		('CH', 'SUIZA',						1, 1, GETDATE()),
		('CI', 'COSTA DE MARFIL (COTE D''IVOIRE)', 0, 1, GETDATE()),
		('CK', 'COOK ISLAS',				1, 1, GETDATE()),
		('CL', 'CHILE',						1, 1, GETDATE()),
		('CM', 'CAMERUN',					1, 1, GETDATE()),
		('CN', 'CHINA',						1, 1, GETDATE()),
		('CO', 'COLOMBIA',					1, 1, GETDATE()),
		('CR', 'COSTA RICA',				1, 1, GETDATE()),
		('CU', 'CUBA',						1, 1, GETDATE()),
		('CV', 'CABO VERDE',				1, 1, GETDATE()),
		('CW', 'CURAZAO',					1, 1, GETDATE()),
		('CX', 'NAVIDAD, ISLAS',			1, 1, GETDATE()),
		('CY', 'CHIPRE',					1, 1, GETDATE()),
		('CZ', 'CHECA, REPUBLICA',			1, 1, GETDATE()),
		('DE', 'ALEMANIA, REPUBLICA FEDERAL', 0, 1, GETDATE()),
		('DJ', 'DJIBOUTH',					1, 1, GETDATE()),
		('DK', 'DINAMARCA',					1, 1, GETDATE()),
		('DM', 'DOMINICA',					1, 1, GETDATE()),
		('DO', 'DOMINICANA, REPUBLICA',		1, 1, GETDATE()),
		('DZ', 'ARGELIA',					1, 1, GETDATE()),
		('EC', 'ECUADOR',					1, 1, GETDATE()),
		('EE', 'ESTONIA',					1, 1, GETDATE()),
		('EG', 'EGIPTO',					1, 1, GETDATE()),
		('EH', 'SAHARA DEL OESTE',			1, 1, GETDATE()),
		('ER', 'ERITREA',					1, 1, GETDATE()),
		('ES', 'ESPAÑA',					1, 1, GETDATE()),
		('ET', 'ETIOPIA',					1, 1, GETDATE()),
		('FI', 'FINLANDIA',					1, 1, GETDATE()),
		('FJ', 'FIJI',						1, 1, GETDATE()),
		('FK', 'FALKLAND ISLAS (MALVINAS)', 1, 1, GETDATE()),
		('FM', 'MICRONESIA,ESTADO FEDERAL DE', 0, 1, GETDATE()),
		('FO', 'FAROE, ISLAS',				1, 1, GETDATE()),
		('FR', 'FRANCIA',					1, 1, GETDATE()),
		('GA', 'GABON',						1, 1, GETDATE()),
		('GB', 'REINO UNIDO (INGLATERRA, IRLANDA NORTE, ESCOCIA, GALES)', 0, 1, GETDATE()),
		('GD', 'GRENADA',					1, 1, GETDATE()),
		('GE', 'GEORGIA',					1, 1, GETDATE()),
		('GF', 'FRANCESA,GUINEA',			1, 1, GETDATE()),
		('GH', 'GHANA',						1, 1, GETDATE()),
		('GI', 'GIBRALTAR',					1, 1, GETDATE()),
		('GL', 'GROENLANDIA',				1, 1, GETDATE()),
		('GM', 'GAMBIA',					1, 1, GETDATE()),
		('GN', 'GUINEA',					1, 1, GETDATE()),
		('GP', 'GUADALUPE',					1, 1, GETDATE()),
		('GQ', 'ECUATORIAL, GUINEA',		1, 1, GETDATE()),
		('GR', 'GRECIA',					1, 1, GETDATE()),
		('GS', 'GEORGIA DEL SUR E ISLAS SAND', 0, 1, GETDATE()),
		('GT', 'GUATEMALA',					1, 1, GETDATE()),
		('GU', 'GUAN',						1, 1, GETDATE()),
		('GW', 'GUINEA-BISSAU',				1, 1, GETDATE()),
		('GY', 'GUYANA (ANTIGUA GUYANA INGLESA', 0, 1, GETDATE()),
		('HK', 'HONG KONG',					1, 1, GETDATE()),
		('HM', 'HEARD Y MC DONALD ISLAS',	1, 1, GETDATE()),
		('HN', 'HONDURAS',					1, 1, GETDATE()),
		('HR', 'CROACIA',					1, 1, GETDATE()),
		('HT', 'HAITI',						1, 1, GETDATE()),
		('HU', 'HUNGRIA',					1, 1, GETDATE()),
		('ID', 'INDONESIA',					1, 1, GETDATE()),
		('IE', 'IRLANDA',					1, 1, GETDATE()),
		('IL', 'ISRAEL',					1, 1, GETDATE()),
		('IN', 'INDIA',						1, 1, GETDATE()),
		('IO', 'TERRITORIO BRITANICO DEL OCEANO INDICO', 0, 1, GETDATE()),
		('IQ', 'IRAQ',						1, 1, GETDATE()),
		('IR', 'IRAN, REPUBLICA ISLAMICA',	1, 1, GETDATE()),
		('IS', 'ISLANDIA',					1, 1, GETDATE()),
		('IT', 'ITALIA',					1, 1, GETDATE()),
		('JM', 'JAMAICA',					1, 1, GETDATE()),
		('JO', 'JORDANIA',					1, 1, GETDATE()),
		('JP', 'JAPON',						1, 1, GETDATE()),
		('KE', 'KENIA',						1, 1, GETDATE()),
		('KG', 'KIRGHIZISTAN',				1, 1, GETDATE()),
		('KH', 'CAMBOYA',					1, 1, GETDATE()),
		('KI', 'KIRIBATI',					1, 1, GETDATE()),
		('KM', 'COMORES',					1, 1, GETDATE()),
		('KN', 'SAINT KITTS AND NEVIS',		1, 1, GETDATE()),
		('KP', 'KOREA, REP. POPULAR DEMOCRATICA',	0, 1, GETDATE()),
		('KR', 'KOREA, REP. DE (KOREA DEL SUR)',	0, 1, GETDATE()),
		('KW', 'KUWAIT',					1, 1, GETDATE()),
		('KY', 'CAIMAN ISLAS',				1, 1, GETDATE()),
		('KZ', 'KAZAKSTAN',					1, 1, GETDATE()),
		('LA', 'LAOS, REPUBLICA POPULAR DEMOCRATICA', 0, 1, GETDATE()),
		('LB', 'LIBANO',					 1, 1, GETDATE()),
		('LC', 'SANTA LUCIA',				 1, 1, GETDATE()),
		('LI', 'LIECHTENSTEIN',				 1, 1, GETDATE()),
		('LK', 'SRI LANKA (CEILAN)',		 1, 1, GETDATE()),
		('LR', 'LIBERIA',					 1, 1, GETDATE()),
		('LS', 'LESOTHO',					 1, 1, GETDATE()),
		('LT', 'LITUANIA',					 1, 1, GETDATE()),
		('LU', 'LUXEMBURGO',				 1, 1, GETDATE()),
		('LV', 'LETONIA',					 1, 1, GETDATE()),
		('LY', 'LIBIA ARABE JAMAHIRIYA',	 1, 1, GETDATE()),
		('MA', 'MARRUECOS',					 1, 1, GETDATE()),
		('MC', 'MONACO',					 1, 1, GETDATE()),
		('MD', 'MOLDAVIA, REPUBLICA DE',	 1, 1, GETDATE()),
		('ME', 'MONTENEGRO',				 1, 1, GETDATE()),
		('MF', 'SAINT MARTIN (FRENCH PART)', 1, 1, GETDATE()),
		('MG', 'MADAGASCAR',				 1, 1, GETDATE()),
		('MH', 'MARSHALL, ISLAS',			 1, 1, GETDATE()),
		('MK', 'MACEDONIA, LA ANT.REP.DE YUGOS', 0, 1, GETDATE()),
		('ML', 'MALI',						1, 1, GETDATE()),
		('MM', 'MYANMAR (ANTIGUA REP. DE BIRMANIA)', 1, 1, GETDATE()),
		('MN', 'MONGOLIA',					0, 1, GETDATE()),
		('MO', 'MACAU',						0, 1, GETDATE()),
		('MP', 'MARIANAS SEPTENTRIONALES, ISLAS', 0, 1, GETDATE()),
		('MQ', 'MARTINICA',					1, 1, GETDATE()),
		('MR', 'MAURITANIA',				1, 1, GETDATE()),
		('MS', 'MONTSERRAT',				1, 1, GETDATE()),
		('MT', 'MALTA',						1, 1, GETDATE()),
		('MU', 'MAURICIOS',					1, 1, GETDATE()),
		('MV', 'MALDIVAS',					1, 1, GETDATE()),
		('MW', 'MALAWI',					1, 1, GETDATE()),
		('MX', 'MEXICO',					1, 1, GETDATE()),
		('MY', 'MALASIA',					1, 1, GETDATE()),
		('MZ', 'MOZAMBIQUE',				1, 1, GETDATE()),
		('NA', 'NAMIBIA',					1, 1, GETDATE()),
		('NC', 'NUEVA CALEDONIA',			1, 1, GETDATE()),
		('NE', 'NIGER',						1, 1, GETDATE()),
		('NF', 'NORFOLK, ISLAS',			1, 1, GETDATE()),
		('NG', 'NIGERIA',					1, 1, GETDATE()),
		('NI', 'NICARAGUA',					1, 1, GETDATE()),
		('NL', 'PAISES BAJOS',				1, 1, GETDATE()),
		('NO', 'NORUEGA',					1, 1, GETDATE()),
		('NP', 'NEPAL',						1, 1, GETDATE()),
		('NR', 'NAURO',						1, 1, GETDATE()),
		('NU', 'NIUE',						1, 1, GETDATE()),
		('NZ', 'NUEVA ZELANDA',				1, 1, GETDATE()),
		('OM', 'OMAN',						1, 1, GETDATE()),
		('PA', 'PANAMA',					1, 1, GETDATE()),
		('PE', 'PERU',						1, 1, GETDATE()),
		('PF', 'FRANCESA POLINESIA',		1, 1, GETDATE()),
		('PG', 'PAPUA NUEVA GUINEA',		1, 1, GETDATE()),
		('PH', 'FILIPINAS',					1, 1, GETDATE()),
		('PK', 'PAKISTAN',					1, 1, GETDATE()),
		('PL', 'POLONIA',					1, 1, GETDATE()),
		('PM', 'SAN PEDRO Y MIGUELON',		1, 1, GETDATE()),
		('PN', 'PITCAIRN',					1, 1, GETDATE()),
		('PR', 'PUERTO RICO',				1, 1, GETDATE()),
		('PS', 'TERRITORIO PALESTINO OCUPADO', 0, 1, GETDATE()),
		('PT', 'PORTUGAL',					1, 1, GETDATE()),
		('PW', 'PALAU',						1, 1, GETDATE()),
		('PY', 'PARAGUAY',					1, 1, GETDATE()),
		('QA', 'QATAR',						1, 1, GETDATE()),
		('RE', 'REUNION',					1, 1, GETDATE()),
		('RO', 'RUMANIA',					1, 1, GETDATE()),
		('RS', 'SERBIA',					1, 1, GETDATE()),
		('RU', 'RUSA, FEDERACION',			1, 1, GETDATE()),
		('RW', 'RUANDA',					1, 1, GETDATE()),
		('SA', 'SAUDITA ARABIA',			1, 1, GETDATE()),
		('SB', 'SOLOMON, ISLAS',			1, 1, GETDATE()),
		('SC', 'SEYCHELLES, ISLAS',			1, 1, GETDATE()),
		('SD', 'SUDAN',						1, 1, GETDATE()),
		('SE', 'SUECIA',					1, 1, GETDATE()),
		('SG', 'SINGAPUR',					1, 1, GETDATE()),
		('SH', 'SANTA HELENA',				1, 1, GETDATE()),
		('SI', 'ESLOVENIA',					1, 1, GETDATE()),
		('SJ', 'SVALBARD AND JAN MAYEN ISLAS', 0, 1, GETDATE()),
		('SK', 'ESLOVAKIA',					1, 1, GETDATE()),
		('SL', 'SIERRA LEONA',				1, 1, GETDATE()),
		('SM', 'SAN MARINO',				1, 1, GETDATE()),
		('SN', 'SENEGAL',					1, 1, GETDATE()),
		('SO', 'SOMALIA',					1, 1, GETDATE()),
		('SR', 'SURINAM (GUAYANA HOLANDESAS)', 0, 1, GETDATE()),
		('SS', 'SUDAN DEL SUR',				1, 1, GETDATE()),
		('ST', 'SAO TOME Y PRINCIPE',		1, 1, GETDATE()),
		('SV', 'EL SALVADOR',				1, 1, GETDATE()),
		('SX', 'SINT MAARTEN (DUTCH PART)', 1, 1, GETDATE()),
		('SY', 'SIRIA, REPUBLICA ARABE',	1, 1, GETDATE()),
		('SZ', 'SUAZILANDIA',				1, 1, GETDATE()),
		('TC', 'TURCOS Y CAICOS ISLAS',		1, 1, GETDATE()),
		('TD', 'CHAD',						1, 1, GETDATE()),
		('TF', 'FRANCESES, TERRITORIOS DEL SURESTE', 0, 1, GETDATE()),
		('TG', 'TOGO',						 1, 1, GETDATE()),
		('TH', 'TAILANDIA',					 1, 1, GETDATE()),
		('TJ', 'TADJIKISTAN',				 1, 1, GETDATE()),
		('TK', 'TOKELAU',					 1, 1, GETDATE()),
		('TL', 'TIMOR DEL ESTE',			 1, 1, GETDATE()),
		('TM', 'TURKMENISTAN',				 1, 1, GETDATE()),
		('TN', 'TUNISIA',					 1, 1, GETDATE()),
		('TO', 'TONGA',						 1, 1, GETDATE()),
		('TR', 'TURQUIA',					 1, 1, GETDATE()),
		('TT', 'TRINIDAD Y TOBAGO',			 1, 1, GETDATE()),
		('TV', 'TUVALU',					 1, 1, GETDATE()),
		('TW', 'TAIWAN, PROVINCIA CHINA DE', 1, 1, GETDATE()),
		('TZ', 'TANZANIA, REPUBLICA UNIDA DE', 0, 1, GETDATE()),
		('UA', 'UCRANIA',					1, 1, GETDATE()),
		('UG', 'UGANDA',					1, 1, GETDATE()),
		('UM', 'ISLAS ULTRAMARINAS MENORES (EEUU)', 0, 1, GETDATE()),
		('US', 'ESTADOS UNIDOS',			1, 1, GETDATE()),
		('UY', 'URUGUAY',					1, 1, GETDATE()),
		('UZ', 'UZBEKISTAN',				1, 1, GETDATE()),
		('VA', 'SANTA SEDE (CIUDAD DEL VATICANO)', 0, 1, GETDATE()),
		('VC', 'SAN VICENTE Y LAS GRANADINAS', 0, 1, GETDATE()),
		('VE', 'VENEZUELA',					1, 1, GETDATE()),
		('VG', 'VIRGENES, ISLAS (BRITANICAS)', 0, 1, GETDATE()),
		('VI', 'VIRGENES, ISLAS (ESTADOS UNIDOS)', 0, 1, GETDATE()),
		('VN', 'VIETNAM',					1, 1, GETDATE()),
		('VU', 'VANUATU',					1, 1, GETDATE()),
		('WF', 'WALLIS Y FUTUNA, ISLAS',	1, 1, GETDATE()),
		('WS', 'SAMOA',						1, 1, GETDATE()),
		('YE', 'YEMEN',						1, 1, GETDATE()),
		('YT', 'MAYOTTE',					1, 1, GETDATE()),
		('ZA', 'SURAFRICA',					1, 1, GETDATE()),
		('ZM', 'ZAMBIA',					1, 1, GETDATE()),
		('ZW', 'ZIMBABWE',					1, 1, GETDATE()),
		('HN', 'HONDURAS',					0, 1, GETDATE()),
		('US', 'ESTADOS UNIDOS',			0, 1, GETDATE()),
		('SV', 'EL SALVADOR',				0, 1, GETDATE()),
		('SE', 'SUECIA',					0, 1, GETDATE()),
		('PR', 'PUERTO RICO',				0, 1, GETDATE()),
		('PE', 'PERU',						0, 1, GETDATE()),
		('PA', 'PANAMA',					0, 1, GETDATE()),
		('MX', 'MEXICO',					0, 1, GETDATE()),
		('GT', 'GUATEMALA',					0, 1, GETDATE()),
		('CR', 'COSTA RICA',				0, 1, GETDATE()),
		('AR', 'ARGENTINA',					0, 1, GETDATE());


/*--------------------------------------*/
--***** INSERT TABLA PROVINCIAS --******--
GO
INSERT INTO [Gral].[tbProvincias] ([pvin_Nombre], [pvin_Codigo], [pais_Id], [pvin_EsAduana], [usua_UsuarioCreacion], [pvin_FechaCreacion])
VALUES	-- Provinces for Argentina (AR)
		('Buenos Aires',	'BA', 11, 1, 1, GETDATE()),
		('Córdoba',			'CO', 11, 1, 1, GETDATE()),
		('Santa Fe',		'SF', 11, 1, 1, GETDATE()),
		('Mendoza',			'MZ', 11, 1, 1, GETDATE()),
		('Tucumán',			'TU', 258,0, 1, GETDATE()),
		
		-- Provinces for Brazil (BR)
		('Sao Paulo',			'SP', 32, 0, 1, GETDATE()),
		('Rio de Janeiro',		'RJ', 32, 0, 1, GETDATE()),
		('Minas Gerais',		'MG', 32, 0, 1, GETDATE()),
		('Bahia',				'BA', 32, 0, 1, GETDATE()),
		('Rio Grande do Sul',	'RS', 32, 0, 1, GETDATE()),
		
		-- Provinces for Canada (CA)
		('Ontario',				'ON', 39, 1, 1, GETDATE()),
		('Quebec',				'QC', 39, 1, 1, GETDATE()),
		('British Columbia',	'BC', 39, 1, 1, GETDATE()),
		('Alberta',				'AB', 39, 1, 1, GETDATE()),
		('Manitoba',			'MB', 39, 1, 1, GETDATE()),
		
		-- Provinces for United States (US)
		('California',	'CA', 231, 0, 1, GETDATE()),
		('Texas',		'TX', 231, 0, 1, GETDATE()),
		('Florida',		'FL', 231, 0, 1, GETDATE()),
		('New York',	'NY', 231, 0, 1, GETDATE()),
		('Illinois',	'IL', 231, 0, 1, GETDATE()),
		
		-- Provinces for United Kingdom (GB)
		('England',				'ENG', 78, 1, 1, GETDATE()),
		('Scotland',			'SCT', 78, 1, 1, GETDATE()),
		('Wales',				'WLS', 78, 1, 1, GETDATE()),
		('Northern Ireland',	'NIR', 78, 1, 1, GETDATE()),
		
		-- Provinces for Australia (AU)
		('New South Wales',		'NSW', 14, 0, 1, GETDATE()),
		('Queensland',			'QLD', 14, 0, 1, GETDATE()),
		('Victoria',			'VIC', 14, 0, 1, GETDATE()),
		('Western Australia',	'WA', 14, 0, 1, GETDATE()),
		('South Australia',		'SA', 14, 0, 1, GETDATE()),
		
		-- Provinces for India (IN)
		('Maharashtra',		'MH', 104, 1, 1, GETDATE()),
		('Uttar Pradesh',	'UP', 104, 1, 1, GETDATE()),
		('Tamil Nadu',		'TN', 104, 1, 1, GETDATE()),
		('Karnataka',		'KA', 104, 1, 1, GETDATE()),
		('Gujarat',			'GJ', 104, 1, 1, GETDATE()),
		
		-- Provinces for China (CN)
		('Guangdong',		'GD', 49, 0, 1, GETDATE()),
		('Shandong',		'SD', 49, 0, 1, GETDATE()),
		('Jiangsu',			'JS', 49, 0, 1, GETDATE()),
		('Zhejiang',		'ZJ', 49, 0, 1, GETDATE()),
		('Henan',			'HA', 49, 0, 1, GETDATE()),
		
		-- Provinces for Russia (RU)
		('Moscow',				'MOW', 189, 1, 1, GETDATE()),
		('Saint Petersburg',	'SPE', 189, 1, 1, GETDATE()),
		('Novosibirsk',			'NVS', 189, 1, 1, GETDATE()),
		('Yekaterinburg',		'EKB', 189, 1, 1, GETDATE()),
		('Nizhny Novgorod',		'NIZ', 189, 1, 1, GETDATE()),
		
		-- Provinces for France (FR)
		('Ile-de-France',			'IDF', 76, 0, 1, GETDATE()),
		('Auvergne-Rhone-Alpes',	'ARA', 76, 0, 1, GETDATE()),
		('Hauts-de-France',			'HDF', 76, 0, 1, GETDATE()),
		('Occitanie',				'OCC', 76, 0, 1, GETDATE()),
		('Normandy',				'NOR', 76, 0, 1, GETDATE()),
		
		-- Provinces for Germany (DE)
		('North Rhine-Westphalia',	'NRW', 58, 1, 1, GETDATE()),
		('Bavaria',					'BY', 58, 1, 1, GETDATE()),
		('Baden-Wurttemberg',		'BW', 58, 1, 1, GETDATE()),
		('Lower Saxony',			'NI', 58, 1, 1, GETDATE()),
		('Hesse',					'HE', 58, 1, 1, GETDATE()),
		
		-- Provinces for Italy (IT)
		('Lombardy',	'LOM', 109, 0, 1, GETDATE()),
		('Lazio',		'LAZ', 109, 0, 1, GETDATE()),
		('Campania',	'CAM', 109, 0, 1, GETDATE()),
		('Sicily',		'SIC', 109, 0, 1, GETDATE()),
		('Veneto',		'VEN', 109, 0, 1, GETDATE()),
		
		-- Provinces for Spain (ES)
		('Madrid',		'MAD', 69, 1, 1, GETDATE()),
		('Catalonia',	'CAT', 69, 1, 1, GETDATE()),
		('Andalusia',	'AND', 69, 1, 1, GETDATE()),
		('Valencia',	'VAL', 69, 1, 1, GETDATE()),
		('Galicia',		'GAL', 69, 1, 1, GETDATE()),

		-- Provinces for Honduras (HN)
		('Atlantida',			'01', 97, 0, 1, GETDATE()),
		('Colon',				'02', 97, 0, 1, GETDATE()),
		('Comayagua',			'03', 97, 0, 1, GETDATE()),
		('Copan',				'04', 97, 0, 1, GETDATE()),
		('Cortes',				'05', 97, 0, 1, GETDATE()),
		('Choluteca',			'06', 97, 0, 1, GETDATE()),
		('El Paraiso',			'07', 97, 0, 1, GETDATE()),
		('Francisco Morazan',	'08', 97, 0, 1, GETDATE()),
		('Gracias a Dios',		'09', 97, 0, 1, GETDATE()),
		('Intibuca',			'10', 97, 0, 1, GETDATE()),
		('Islas de La Bahia',	'11', 97, 0, 1, GETDATE()),
		('La Paz',				'12', 97, 0, 1, GETDATE()),
		('Lempira',				'13', 97, 0, 1, GETDATE()),
		('Ocotepeque',			'14', 97, 0, 1, GETDATE()),
		('Olancho',				'15', 97, 0, 1, GETDATE()),
		('Santa Barbara',		'16', 97, 0, 1, GETDATE()),
		('Valle',				'17', 97, 0, 1, GETDATE()),
		('Yoro',				'18', 97, 0, 1, GETDATE()),
		('Cortés',				'05',248, 0, 1, GETDATE());

/*-------------------------------------*/
--***** INSERT TABLA CIUDADES --******--
GO
INSERT INTO [Gral].[tbCiudades] ([ciud_Nombre], [pvin_Id], [ciud_EsAduana], [usua_UsuarioCreacion], [ciud_FechaCreacion])
VALUES
	('La Ceiba', 65, 1, 1, GETDATE()),
	('El Porvenir', 65, 1, 1, GETDATE()),
	('Tela', 65, 1, 1, GETDATE()),
	('Jutiapa', 65, 1, 1, GETDATE()),
	('La Masica', 65, 1, 1, GETDATE()),
	('San Francisco', 65, 1, 1, GETDATE()),
	('Arizona', 65, 1, 1, GETDATE()),
	('Esparta', 65, 1, 1, GETDATE()),
	('Trujillo', 66, 1, 1, GETDATE()),
	('Balfate', 66, 1, 1, GETDATE()),
	('Iriona', 66, 1, 1, GETDATE()),
	('Limón', 66, 1, 1, GETDATE()),
	('Sabe', 66, 1, 1, GETDATE()),
	('Santa Fe', 66, 1, 1, GETDATE()),
	('Santa Rosa de Aguán', 66, 1, 1, GETDATE()),
	('Sonaguera', 66, 1, 1, GETDATE()),
	('Tocoa', 66, 1, 1, GETDATE()),
	('Bonito Oriental', 66, 1, 1, GETDATE()),
	('Comayagua', 67, 1, 1, GETDATE()),
	('Ajuterique', 67, 1, 1, GETDATE()),
	('El Rosario', 67, 1, 1, GETDATE()),
	('Esquías', 67, 1, 1, GETDATE()),
	('Humuya', 67, 1, 1, GETDATE()),
	('La Libertad', 67, 1, 1, GETDATE()),
	('Laman�', 67, 1, 1, GETDATE()),
	('La Trinidad', 67, 1, 1, GETDATE()),
	('Lejaman�', 67, 1, 1, GETDATE()),
	('Me�mbar', 67, 1, 1, GETDATE()),
	('Minas de Oro', 67, 1, 1, GETDATE()),
	('Ojos de Agua', 67, 1, 1, GETDATE()),
	('San Jerónimo', 67, 1, 1, GETDATE()),
	('San José de Comayagua', 67, 1, 1, GETDATE()),
	('San José del Potrero', 67, 1, 1, GETDATE()),
	('San Luis', 67, 1, 1, GETDATE()),
	('San Sebastián', 67, 1, 1, GETDATE()),
	('Siguatepeque', 67, 1, 1, GETDATE()),
	('Villa de San Antonio', 67, 1, 1, GETDATE()),
	('Las Lajas', 67, 1, 1, GETDATE()),
	('Taulabé', 67, 1, 1, GETDATE()),
	('Santa Rosa de Copán', 68, 1, 1, GETDATE()),
	('Cabañas', 68, 1, 1, GETDATE()),
	('Concepción', 68, 1, 1, GETDATE()),
	('Copán Ruinas', 68, 1, 1, GETDATE()),
	('Corqu�n', 68, 1, 1, GETDATE()),
	('Cucuyagua', 68, 1, 1, GETDATE()),
	('Dolores', 68, 1, 1, GETDATE()),
	('Dulce Nombre', 68, 1, 1, GETDATE()),
	('El Paraíso', 68, 1, 1, GETDATE()),
	('Florida', 68, 1, 1, GETDATE()),
	('La Jigua', 68, 1, 1, GETDATE()),
	('La Unión', 68, 1, 1, GETDATE()),
	('Nueva Arcadia', 68, 1, 1, GETDATE()),
	('San Agustín', 68, 1, 1, GETDATE()),
	('San Antonio', 68, 1, 1, GETDATE()),
	('San Jerónimo', 68, 1, 1, GETDATE()),
	('San José', 68, 1, 1, GETDATE()),
	('San Juan de Opoa', 68, 1, 1, GETDATE()),
	('San Nicolás', 68, 1, 1, GETDATE()),
	('San Pedro', 68, 1, 1, GETDATE()),
	('Santa Rita', 68, 1, 1, GETDATE()),
	('Trinidad de Copán', 68, 1, 1, GETDATE()),
	('Veracruz', 68, 1, 1, GETDATE()),
	('San Pedro Sula', 69, 1, 1, GETDATE()),
	('Choloma', 69, 1, 1, GETDATE()),
	('Omoa', 69, 1, 1, GETDATE()),
	('Pimienta', 69, 1, 1, GETDATE()),
	('Potrerillos', 69, 1, 1, GETDATE()),
	('Puerto Cortés', 69, 1, 1, GETDATE()),
	('San Antonio de Cortés', '69', 1, 1, GETDATE()),
	('San Francisco de Yojoa', 69, 1, 1, GETDATE()),
	('San Manuel', 69, 1, 1, GETDATE()),
	('Santa Cruz de Yojoa', 69, 1, 1, GETDATE()),
	('Villanueva', 69, 1, 1, GETDATE()),
	('La Lima', 69, 1, 1, GETDATE()),
	
	('Choluteca', 70, 1, 1, GETDATE()),
	('Apacilagua', 70, 1, 1, GETDATE()),
	('Concepción de María', 70, 1, 1, GETDATE()),
	('Duyure', 70, 1, 1, GETDATE()),
	('El Corpus', 70, 1, 1, GETDATE()),
	('El Triunfo', 70, 1, 1, GETDATE()),
	('Marcovia', 70, 1, 1, GETDATE()),
	('Morolica', 70, 1, 1, GETDATE()),
	('Namasigüe', 70, 1, 1, GETDATE()),
	('Orocuina', 70, 1, 1, GETDATE()),
	('Pespire', 70, 1, 1, GETDATE()),
	('San Antonio de Flores', 70, 1, 1, GETDATE()),
	('San Isidro', 70, 1, 1, GETDATE()),
	('San José', 70, 1, 1, GETDATE()),
	('San Marcos de Colón', 70, 1, 1, GETDATE()),
	('Santa Ana de Yusguare', 70, 1, 1, GETDATE()),
	
	('Yuscarán', 71,  1, 1, GETDATE()),
	('Alauca', 71,  1, 1, GETDATE()),
	('Danlí', 71,  1, 1, GETDATE()),
	('El Paraíso', 71, 1, 1, GETDATE()),
	('Güinope', 71, 1, 1, GETDATE()),
	('Jacaleapa', 71,  1, 1, GETDATE()),
	('Liure', 71, 1,  1, GETDATE()),
	('Morocel�', 71,  1, 1, GETDATE()),
	('Oropol�', 71, 1, 1, GETDATE()),
	('Potrerillos', 71, 1, 1, GETDATE()),
	('San Antonio de Flores', 71, 1, 1, GETDATE()),
	('San Lucas', 71, 1, 1, GETDATE()),
	('San Matías', 71, 1, 1, GETDATE()),
	('Soledad', 71, 1, 1, GETDATE()),
	('Teupasenti', 71, 1, 1, GETDATE()),
	('Texiguat', 71, 1, 1, GETDATE()),
	('Vado Ancho', 71, 1, 1, GETDATE()),
	('Yauyupe', 71, 1, 1, GETDATE()),
	('Trojes', 71, 1, 1, GETDATE()),
	
	('Distrito Central', 72, 1, 1, GETDATE()),
	('Alubar�n', 72, 1, 1, GETDATE()),
	('Cedros', 72, 1, 1, GETDATE()),
	('Curar�n', 72, 1, 1, GETDATE()),
	('El Porvenir', 72, 1, 1, GETDATE()),
	('Guaimaca', 72, 1, 1, GETDATE()),
	('La Libertad', 72, 1, 1, GETDATE()),
	('La Venta', 72, 1, 1, GETDATE()),
	('Lepaterique', 72, 1, 1, GETDATE()),
	('Maraita', 72, 1, 1, GETDATE()),
	('Marale', 72, 1, 1, GETDATE()),
	('Nueva Armenia', 72, 1, 1, GETDATE()),
	('Ojojona', 72, 1, 1, GETDATE()),
	('Orica', 72, 1, 1, GETDATE()),
	('Reitoca', 72, 1, 1, GETDATE()),
	('Sabanagrande', 72, 1, 1, GETDATE()),
	('San Antonio de Oriente', 72, 1, 1, GETDATE()),
	('San Buenaventura', 72, 1, 1, GETDATE()),
	('San Ignacio', 72, 1, 1, GETDATE()),
	('San Juan de Flores', 72, 1, 1, GETDATE()),
	('San Miguelito', 72, 1, 1, GETDATE()),
	('Santa Ana', 72, 1, 1, GETDATE()),
	('Santa Lucía', 72, 1, 1, GETDATE()),
	('Talanga', 72, 1, 1, GETDATE()),
	('Tatumbla', 72, 1, 1, GETDATE()),
	('Valle de Ángeles', 72, 1, 1, GETDATE()),
	('Villa de San Francisco', 72, 1, 1, GETDATE()),
	('Vallecillo', 72, 1, 1, GETDATE()),
	
	('Puerto Lempira', 73, 1, 1, GETDATE()),
	('Brus Laguna', 73, 1, 1, GETDATE()),
	('Ahuas', 73, 1, 1, GETDATE()),
	('Juan Francisco Bulnes', 73, 1, 1, GETDATE()),
	('Ramón Villeda Morales', 73, 1, 1, GETDATE()),
	('Wampusirpe', 73, 1, 1, GETDATE()),
	
	('La Esperanza', 74, 1, 1, GETDATE()),
	('Camasca', 74, 1, 1, GETDATE()),
	('Colomoncagua', 74, 1, 1, GETDATE()),
	('Concepción', 74, 1, 1, GETDATE()),
	('Dolores', 74, 1, 1, GETDATE()),
	('Intibucá', 74, 1, 1, GETDATE()),
	('Jesús de Otoro', 74, 1, 1, GETDATE()),
	('Magdalena', 74, 1, 1, GETDATE()),
	('Masaguara', 74, 1, 1, GETDATE()),
	('San Antonio', 74, 1, 1, GETDATE()),
	('San Isidro', 74, 1, 1, GETDATE()),
	('San Juan', 74, 1, 1, GETDATE()),
	('San Marcos de la Sierra', 74, 1, 1, GETDATE()),
	('San Miguel Guancapla', 74, 1, 1, GETDATE()),
	('Santa Lucía', 74, 1, 1, GETDATE()),
	('Yamaranguila', 74, 1, 1, GETDATE()),
	('San Francisco de Opalaca', 74, 1, 1, GETDATE()),
	
	('Roatán', 75, 1, 1, GETDATE()),
	('Guanaja', 75, 1, 1, GETDATE()),
	('José Santos Guardiola', 75, 1, 1, GETDATE()),
	('Utila', 75, 1, 1, GETDATE()),
	
	('La Paz', 76, 1, 1, GETDATE()),
	('Aguanqueterique', 76, 1, 1, GETDATE()),
	('Cabañas', 76, 1, 1, GETDATE()),
	('Cane', 76, 1, 1, GETDATE()),
	('Chinacla', 76, 1, 1, GETDATE()),
	('Guajiquiro', 76, 1, 1, GETDATE()),
	('Lauterique', 76, 1, 1, GETDATE()),
	('Marcala', 76, 1, 1, GETDATE()),
	('Mercedes de Oriente', 76, 1, 1, GETDATE()),
	('Opatoro', 76, 1, 1, GETDATE()),
	('San Antonio del Norte', 76, 1, 1, GETDATE()),
	('San José', 76, 1, 1, GETDATE()),
	('San Juan', 76, 1, 1, GETDATE()),
	('San Pedro de Tutule', 76, 1, 1, GETDATE()),
	('Santa Ana', 76, 1, 1, GETDATE()),
	('Santa Elena', 76, 1, 1, GETDATE()),
	('Santa María', 76, 1, 1, GETDATE()),
	('Santiago de Puringla', 76, 1, 1, GETDATE()),
	('Yarula', 76, 1, 1, GETDATE()),
	('Gracias', 77, 1, 1, GETDATE()),
	('Belén', 77, 1, 1, GETDATE()),
	('Candelaria', 77, 1, 1, GETDATE()),
	('Cololaca', 77, 1, 1, GETDATE()),
	('Erandique', 77, 1, 1, GETDATE()),
	('Gualcince', 77, 1, 1, GETDATE()),
	('Guarita', 77, 1, 1, GETDATE()),
	('La Campa', 77, 1, 1, GETDATE()),
	('La Iguala', 77, 1, 1, GETDATE()),
	('Las Flores', 77, 1, 1, GETDATE()),
	('La Unión', 77, 1, 1, GETDATE()),
	('La Virtud', 77, 1, 1, GETDATE()),
	('Lepaera', 77, 1, 1, GETDATE()),
	('Mapulaca', 77, 1, 1, GETDATE()),
	('Piraera', 77, 1, 1, GETDATE()),
	('San Andrés', 77, 1, 1, GETDATE()),
	('San Francisco', 77, 1, 1, GETDATE()),
	('San Juan Guarita', 77, 1, 1, GETDATE()),
	('San Manuel Colohete', 77, 1, 1, GETDATE()),
	('San Rafael', 77, 1, 1, GETDATE()),
	('San Sebastián', 77, 1, 1, GETDATE()),
	('Santa Cruz', 77, 1, 1, GETDATE()),
	('Talgua', 77, 1, 1, GETDATE()),
	('Tambla', 77, 1, 1, GETDATE()),
	('Tomal�', 77, 1, 1, GETDATE()),
	('Valladolid', 77, 1, 1, GETDATE()),
	('Virginia', 77, 1, 1, GETDATE()),
	('San Marcos de Caiqu�n', 77, 1, 1, GETDATE()),
	('Ocotepeque', 78, 1, 1, GETDATE()),
	('Belén Gualcho', 78, 1, 1, GETDATE()),
	('Concepción', 78, 1, 1, GETDATE()),
	('Dolores Merendón', 78, 1, 1, GETDATE()),
	('Fraternidad', 78, 1, 1, GETDATE()),
	('La Encarnación', 78, 1, 1, GETDATE()),
	('La Labor', 78, 1, 1, GETDATE()),
	('Lucerna', 78, 1, 1, GETDATE()),
	('Mercedes', 78, 1, 1, GETDATE()),
	('San Fernando', 78, 1, 1, GETDATE()),
	('San Francisco del Valle', 78, 1, 1, GETDATE()),
	('San Jorge', 78, 1, 1, GETDATE()),
	('San Marcos', 78, 1, 1, GETDATE()),
	('Santa Fe', 78, 1, 1, GETDATE()),
	('Sensenti', 78, 1, 1, GETDATE()),
	('Sinuapa', 78, 1, 1, GETDATE()),
	('Juticalpa', 79, 1, 1, GETDATE()),
	('Campamento', 79, 1, 1, GETDATE()),
	('Catacamas', 79, 1, 1, GETDATE()),
	('Concordia', 79, 1, 1, GETDATE()),
	('Dulce Nombre de Culm�', 79, 1, 1, GETDATE()),
	('El Rosario', 79, 1, 1, GETDATE()),
	('Esquipulas del Norte', 79, 1, 1, GETDATE()),
	('Gualaco', 79, 1, 1, GETDATE()),
	('Guarizama', 79, 1, 1, GETDATE()),
	('Guata', 79, 1, 1, GETDATE()),
	('Guayape', 79, 1, 1, GETDATE()),
	('Jano', 79, 1, 1, GETDATE()),
	('La Unión', 79, 1, 1, GETDATE()),
	('Mangulile', 79, 1, 1, GETDATE()),
	('Manto', 79, 1, 1, GETDATE()),
	('Salam�', 79, 1, 1, GETDATE()),
	('San Esteban', 79, 1, 1, GETDATE()),
	('San Francisco de Becerra', 79, 1, 1, GETDATE()),
	('San Francisco de la Paz', 79, 1, 1, GETDATE()),
	('Santa María del Real', 79, 1, 1, GETDATE()),
	('Silca', 79, 1, 1, GETDATE()),
	('Yoc�n', 79, 1, 1, GETDATE()),
	('Patuca', 79, 1, 1, GETDATE()),
	('Santa Bárbara', 80, 1, 1, GETDATE()),
	('Arada', 80, 1, 1, GETDATE()),
	('Atima', 80, 1, 1, GETDATE()),
	('Azacualpa', 80, 1, 1, GETDATE()),
	('Ceguaca', 80, 1, 1, GETDATE()),
	('Concepción del Norte', 80, 1, 1, GETDATE()),
	('Concepción del Sur', 80, 1, 1, GETDATE()),
	('Chinda', 80, 1, 1, GETDATE()),
	('El N�spero', 80, 1, 1, GETDATE()),
	('Gualala', 80, 1, 1, GETDATE()),
	('Ilama', 80, 1, 1, GETDATE()),
	('Las Vegas', 80, 1, 1, GETDATE()),
	('Macuelizo', 80, 1, 1, GETDATE()),
	('Naranjito', 80, 1, 1, GETDATE()),
	('Nuevo Celilac', 80, 1, 1, GETDATE()),
	('Nueva Frontera', 80, 1, 1, GETDATE()),
	('Petoa', 80, 1, 1, GETDATE()),
	('Protección', 80, 1, 1, GETDATE()),
	('Quimistán', 80, 1, 1, GETDATE()),
	('San Francisco de Ojuera', 80, 1, 1, GETDATE()),
	('San José de las Colinas', 80, 1, 1, GETDATE()),
	('San Luis', 80, 1, 1, GETDATE()),
	('San Marcos', 80, 1, 1, GETDATE()),
	('San Nicolás', 80, 1, 1, GETDATE()),
	('San Pedro Zacapa', 80, 1, 1, GETDATE()),
	('San Vicente Centenario', 80, 1, 1, GETDATE()),
	('Santa Rita', 80, 1, 1, GETDATE()),
	('Trinidad', 80, 1, 1, GETDATE()),
	('Nacaome', 81, 1, 1, GETDATE()),
	('Alianza', 81, 1, 1, GETDATE()),
	('Amapala', 81, 1, 1, GETDATE()),
	('Aramecina', 81, 1, 1, GETDATE()),
	('Caridad', 81, 1, 1, GETDATE()),
	('Goascorán', 81, 1, 1, GETDATE()),
	('Langue', 81, 1, 1, GETDATE()),
	('San Francisco de Coray', 81, 1, 1, GETDATE()),
	('San Lorenzo', 81, 1, 1, GETDATE()),
	('Yoro', 82, 1, 1, GETDATE()),
	('Arenal', 82, 1, 1, GETDATE()),
	('El Negrito', 82, 1, 1, GETDATE()),
	('El Progreso', 82, 1, 1, GETDATE()),
	('Joc�n', 82, 1, 1, GETDATE()),
	('Morazán', 82, 1, 1, GETDATE()),
	('Olanchito', 82, 1, 1, GETDATE()),
	('Santa Rita', 82, 1, 1, GETDATE()),
	('Sulaco', 82, 1, 1, GETDATE()),
	('Victoria', 82, 1, 1, GETDATE()),
	('Yorito', 82, 1, 1, GETDATE()),
	('San pedro sula', 83, 0, 1, GETDATE());

/*-----------------------------------*/
--***** INSERT TABLA ALDEAS --******--
GO
INSERT INTO [Gral].[tbAldeas] ([alde_Nombre], [ciud_Id], [usua_UsuarioCreacion], [alde_FechaCreacion])
VALUES ('El Carmen', 63, 1, GETDATE()),
	   ('El Hatillo', 69, 1, GETDATE()),
	   ('Los Lirios', 12, 1, GETDATE()),
	   ('El Rosario', 25, 1, GETDATE());



/*-----------------------------------*/
--***** INSERT TABLA COLONIAS --******--
GO
INSERT INTO Gral.tbColonias (colo_Nombre, alde_Id, ciud_Id, usua_UsuarioCreacion, colo_FechaCreacion)
VALUES	('Colonia Trejo', NULL, 63, 1,GETDATE()),
		('El Pedregal', NULL, 63, 1,GETDATE()),
		('Colonia Satélite', NULL, 63, 1,GETDATE()),
		('Colonia El Prado', NULL, 63, 1,GETDATE()),
		('Colonia Altiplano', NULL, 63, 1,GETDATE()),
		('Colonia Altamira', NULL, 63, 1,GETDATE()),
		('Colonia Villa Eugenia', NULL, 63, 1,GETDATE()),
		('Colonia Hernadez', NULL, 63, 1,GETDATE()),
		('Colonia Figueroa', NULL, 63, 1,GETDATE()),
		('Colonia Dubon', NULL, 63, 1,GETDATE()),
		('Colonia El Chamelecon', NULL, 63, 1,GETDATE()),
		('Colonia Moderna', NULL, 63, 1,GETDATE()),
		('Colonia San Rafael', NULL, 64, 1,GETDATE()),
		('Colonia  Brisas de la Bueso', NULL, 64, 1,GETDATE()),
		('Colonia Veinte y Seis de Septie', NULL, 64, 1,GETDATE()),
		('Colonia Copeco Bid', NULL, 64, 1,GETDATE()),
		('Colonia Menonita', NULL, 64, 1,GETDATE()),
		('Colonia La Venta', NULL, 64, 1,GETDATE()),
		('Colonia Brisas de Chamelecón', NULL, 64, 1,GETDATE()),
		('Colonia Santa Lucia', NULL, 64, 1,GETDATE()),
		('Colonia Twana', NULL, 64, 1,GETDATE()),
		('Colonia La Victoria', NULL, 64, 1,GETDATE()),
		('Colonia Canahuati', NULL, 64, 1,GETDATE()),
		('Colonia Angel Salinas', NULL, 1, 1,GETDATE()),
		('Colonia Bonitillo/El 8', NULL, 1, 1,GETDATE()),
		('Colonia Brisas del Atlantico', NULL, 1, 1,GETDATE()),
		('Colonia Brisas del Caribe', NULL, 1, 1,GETDATE()),
		('Colonia Aguán', NULL, 9, 1,GETDATE()),
		('Colonia 10 de Mayo', NULL, 19, 1,GETDATE()),
		('Colonia 1° de Mayo', NULL, 19, 1,GETDATE()),
		('Colonia 2 de Mayo', NULL, 19, 1,GETDATE()),
		('Colonia Boquin', NULL, 19, 1,GETDATE()),
		('Colonia Brisas de Suyapa', NULL, 19, 1,GETDATE()),
		('Colonia Brisas del Humuya', NULL, 19, 1,GETDATE()),
		('Colonia Brisas del Valle', NULL, 19, 1,GETDATE()),
		('Colonia Centenario', NULL, 19, 1,GETDATE()),
		('Colonia Concepción', NULL, 19, 1,GETDATE()),
		('Colonia El Sauce', NULL, 19, 1,GETDATE()),
		('Colonia Escoto', NULL, 19, 1,GETDATE()),
		('Colonia Fiallos', NULL, 19, 1,GETDATE()),
		('Colonia Francisco Morazán', NULL, 19, 1,GETDATE()),
		('Colonia Fuerzas Armadas', NULL, 19, 1,GETDATE()),
		('Colonia Incehsa', NULL, 19, 1,GETDATE()),
		('Colonia Lomas del Río', NULL, 19, 1,GETDATE()),
		('Colonia Los Almendros', NULL, 19, 1,GETDATE()),
		('Colonia Los Jazmines', NULL, 19, 1,GETDATE()),
		('Colonia Mazzarela', NULL, 19, 1,GETDATE()),
		('Colonia Mejicapa', NULL, 19, 1,GETDATE()),
		('Colonia Mejores Alimentos', NULL, 19, 1,GETDATE()),
		('Colonia Mejia Fiallos', NULL, 19, 1,GETDATE()),
		('Colonia Milagro de Dios', NULL, 19, 1,GETDATE()),
		('Colonia Nueva Comayagua', NULL, 19, 1,GETDATE()),
		('Colonia Piedras Bonitas', NULL, 19, 1,GETDATE()),
		('Colonia Sitramedys', NULL, 19, 1,GETDATE()),
		('Colonia San Carlos', NULL, 19, 1,GETDATE()),
		('Colonia San Francisco', NULL, 19, 1,GETDATE()),
		('Colonia San Martín', NULL, 19, 1,GETDATE()),
		('Colonia San Miguel 1', NULL, 19, 1,GETDATE()),
		('Colonia San Miguel 2', NULL, 19, 1,GETDATE()),
		('Colonia San Rafael', NULL, 19, 1,GETDATE()),
		('Colonia. Nueva Valladolid', NULL, 19, 1,GETDATE()),
		('Colonia brisar del sur', NULL, 75, 1,GETDATE()),
		('Colonia Pedro Diaz', NULL, 75, 1,GETDATE()),
		('Colonia 9 De Enero', NULL, 75, 1,GETDATE()),
		('Colonia Las Acacias', NULL, 75, 1,GETDATE()),
		('Colonia Santa Martha', NULL, 75, 1,GETDATE()),
		('Colonia Venecia', NULL, 75, 1,GETDATE()),
		('Colonia Marcelo Gerin', NULL, 75, 1,GETDATE()),
		('Colonia Iberia', NULL, 75, 1,GETDATE()),
		('Colonia Victor Argeñal', NULL, 75, 1,GETDATE()),
		('Colonia 15 De Septiembre', NULL, 75, 1,GETDATE()),
		('Colonia Miramontes', NULL, 75, 1,GETDATE()),
		('Colonia Las Delicias', NULL, 75, 1,GETDATE()),
		('Colonia Isidro Pineda Rodriguez', NULL, 75, 1,GETDATE()),
		('Colonia Manuel Valladares', NULL, 75, 1,GETDATE()),
		('Colonia Las Acacias Ii Etapa', NULL, 75, 1,GETDATE()),
		('Colonia Thelmo Ruiz', NULL, 75, 1,GETDATE()),
		('Colonia San Antonio', NULL, 75, 1,GETDATE()),
		('Colonia El Eden', NULL, 75, 1,GETDATE()),
		('Colonia Villa De Jerez', NULL, 75, 1,GETDATE()),
		('Colonia Panamericana', NULL, 75, 1,GETDATE()),
		('Colonia Samaritana', NULL, 75, 1,GETDATE()),
		('Colonia Nueva Jerusalen', NULL, 75, 1,GETDATE()),
		('Colonia Santa Fe', NULL, 75, 1,GETDATE()),
		('Colonia Loma Linda', NULL, 75, 1,GETDATE()),
		('Colonia Lomas Del Sur', NULL, 75, 1,GETDATE()),
		('Colonia Prados De La Universidad', NULL, 75, 1,GETDATE()),
		('Colonia El Prado', NULL, 75, 1,GETDATE()),
		('Colonia Loma Redonda', NULL, 94, 1,GETDATE()),
		('Colonia Los Quiscamotes', NULL, 94, 1,GETDATE()),
		('Colonia Piedra Ancha', NULL, 94, 1,GETDATE()),
		('Colonia Villa Ahumada', NULL, 94, 1,GETDATE()),
		('Colonia 21 de febrero', NULL, 110, 1,GETDATE()),
		('Colonia Reyniel Funez', NULL, 110, 1,GETDATE()),
		('Colonia Matamoros', NULL, 110, 1,GETDATE()),
		('Colonia 1 de diciembre', NULL, 110, 1,GETDATE()),
		('Colonia Enmanuel', NULL, 110, 1,GETDATE()),
		('Colonia Suyapa', NULL, 110, 1,GETDATE()),
		('Colonia Israel Norte', NULL, 110, 1,GETDATE()),
		('Colonia Los Alpes', NULL, 110, 1,GETDATE()),
		('Colonia Divino Paraíso', NULL, 110, 1,GETDATE()),
		('Colonia San Martin', NULL, 110, 1,GETDATE()),
		('Colonia Santa Cecilia', NULL, 110, 1,GETDATE()),
		('Colonia Nueva Esperanza', NULL, 110, 1,GETDATE()),
		('Colonia Los Pinos', NULL, 110, 1,GETDATE()),
		('Colonia Flor del Campo', NULL, 110, 1,GETDATE()),
		('Colonias Las Pavas', NULL, 110, 1,GETDATE()),
		('Colonia Independencia', NULL, 110, 1,GETDATE()),
		('Colonia Rosa Linda', NULL, 110, 1,GETDATE()),
		('Colonia Estados Unidos', NULL, 110, 1,GETDATE()),
		('Colonia La Alemania', NULL, 110, 1,GETDATE()),
		('Colonia Villa Morales', NULL, 110, 1,GETDATE()),
		('Colonia Rosalinda', NULL, 110, 1,GETDATE()),
		('Colonia 14 de marzo', NULL, 110, 1,GETDATE()),
		('Colonia Rivera de La Vega', NULL, 110, 1,GETDATE()),
		('Colonia Hato de Enmedio', NULL, 110, 1,GETDATE()),
		('Colonia Puerto Lempira', NULL, 138, 1,GETDATE()),
		('Colonia Awasvila', NULL, 138, 1,GETDATE()),
		('Colonia San Ramon', NULL, 138, 1,GETDATE()),
		('Colonia Antigua Ocotepeque', NULL, 212, 1,GETDATE()),
		('Colonia El Barreal', NULL, 212, 1,GETDATE()),
		('Colonia El Volcán', NULL, 212, 1,GETDATE()),
		('Colonia La Comunidad', NULL, 212, 1,GETDATE()),
		('Colonia Pie del Cerro', NULL, 212, 1,GETDATE()),
		('Colonia San José de la Reunión', NULL, 212, 1,GETDATE()),
		('Colonia San Miguel', NULL, 212, 1,GETDATE()),
		('Colonia San Rafael', NULL, 212, 1,GETDATE()),
		('Colonia Vega Grande', NULL, 212, 1,GETDATE()),
		('Colonia Agua Blanquita', NULL, 251, 1,GETDATE()),
		('Colonia 5 de Enero', NULL, 288, 1,GETDATE()),
		('Colonia España', NULL, 288, 1,GETDATE()),
		('Colonia Pinos', NULL, 288, 1,GETDATE()),
		('Colonia Jerusalen', NULL, 288, 1,GETDATE()),
		('Colonia Porfirio Martínez', NULL, 288, 1,GETDATE()),
		('Colonia Lando Burgos', NULL, 288, 1,GETDATE()),
		('Colonia Rotario', NULL, 288, 1,GETDATE()),
		('Colonia Hawitt', NULL, 288, 1,GETDATE()),
		('Colonia Emanuel I, II y III', NULL, 288, 1,GETDATE()),
		('Colonia Reino Unido', NULL, 288, 1,GETDATE());


/*-----------------------------------*/
--***** INSERT TABLA MONEDAS --******--
GO
INSERT INTO [Gral].[tbMonedas]([mone_Codigo], [mone_Descripcion], [mone_EsAduana], [usua_UsuarioCreacion], [mone_FechaCreacion])
VALUES	('EUR', 'COMUNIDAD EUROPEA, EURO', 1, 1,  GETDATE()),
		('HNL', 'HONDURAS, LEMPIRA', 1, 1,  GETDATE()),
		('USD', 'DOLAR NORTEAMERICANO', 1, 1,  GETDATE()),
		('AED', 'EMIRATOS ARABES UNIDOS, DIRHAM', 1, 1,  GETDATE()),
		('AFN', 'AFGANISTAN, AFGANI', 1, 1,  GETDATE()),
		('ALL', 'ALBANIA, LEK', 1, 1,  GETDATE()),
		('AMD', 'ARMENIA, DRAM ARMENIO', 1, 1,  GETDATE()),
		('ANG', 'HOLANDESAS ANTILLAS, FLORIN ANTILLANO NEERLANDES', 1, 1,  GETDATE()),
		('AOA', 'ANGOLA, KWANZA', 1, 1,  GETDATE()),
		('ARS', 'ARGENTINA, PESO ARGENTINO', 1, 1,  GETDATE()),
		('AUD', 'AUSTRALIA, DOLAR AUSTRALIANO', 1, 1,  GETDATE()),
		('AWG', 'ARUBA, FLORIN ARUBEÑO', 1, 1,  GETDATE()),
		('AZN', 'AZERBALIAN, MANAT AZERBAIYANO', 1, 1,  GETDATE()),
		('BAM', 'BOSNIA HERZSEGOVINA, MARCO CONVERTIBLE', 1, 1,  GETDATE()),
		('BBD', 'BARBADOS, DOLAR DE BARBADOS', 1, 1,  GETDATE()),
		('BDT', 'BANGLADESH, TAKA', 1, 1,  GETDATE()),
		('BGN', 'BULGARIA, LEV BULGARO', 1, 1,  GETDATE()),
		('BHD', 'BAHREIN, DINAR BAREINI', 1, 1,  GETDATE()),
		('BIF', 'BURUNDI, FRANCO DE BURUNDI', 1, 1,  GETDATE()),
		('BMD', 'BARMUDA, DOLAR BERMUDEÑO', 1, 1,  GETDATE()),
		('BND', 'BRUNEI, DOLAR DE BRUNEI', 1, 1,  GETDATE()),
		('BOB', 'BOLIVIA, BOLIVIANO', 1, 1,  GETDATE()),
		('BRL', 'BRASIL, REAL BRASILEÑO', 1, 1,  GETDATE()),
		('BSD', 'BAHAMAS, DOLAR BAHAMEÑO', 1, 1,  GETDATE()),
		('BTN', 'BUTAN, NGULTRUM', 1, 1,  GETDATE()),
		('BWP', 'BOTSWANA, PULA', 1, 1,  GETDATE()),
		('BYR', 'BIELORRUSIA, RUBLO BIELORRUSO', 1, 1,  GETDATE()),
		('BZD', 'BELICE, DOLAR BELICEÑO', 1, 1,  GETDATE()),
		('CAD', 'CANADA, DOLAR CANADIENSE', 1, 1,  GETDATE()),
		('CDF', 'CONGO, REPUBLICA DEMOCRATICA, FRANCO CONGOLEÑO', 1, 1,  GETDATE()),
		('CHF', 'SUIZA, FRANCO SUIZO', 1, 1,  GETDATE()),
		('CLP', 'CHILE, PESO CHILENO', 1, 1,  GETDATE()),
		('CNY', 'CHINA, YUAN CHINO', 1, 1,  GETDATE()),
		('COP', 'COLOMBIA, PESO COLOMBIANO', 1, 1,  GETDATE()),
		('CRC', 'COSTA RICA, COLON COSTARRICENSE', 1, 1,  GETDATE()),
		('CUC', 'CUBA, PESO CONVERTIBLE', 1, 1,  GETDATE()),
		('CUP', 'CUBA, PESO CUBANO', 1, 1,  GETDATE()),
		('CVE', 'CABO VERDE, ESCUDO CABOVERDIANO', 1, 1,  GETDATE()),
		('CZK', 'CHECA REPUBLICA, CORONA CHECA', 1, 1,  GETDATE()),
		('DJF', 'DJIBOUTH, FRANCO YIBUTIANO', 1, 1,  GETDATE()),
		('DKK', 'DINAMARCA, CORONA DANESA', 1, 1,  GETDATE()),
		('DOP', 'DOMINICANA REPUBLICA, PESO DOMINICANO', 1, 1,  GETDATE()),
		('DZD', 'ARGELIA, DINAR ARGELINO', 1, 1,  GETDATE()),
		('EGP', 'EGIPTO, LIBRA EGIPCIA', 1, 1,  GETDATE()),
		('ERN', 'ERITREA, NAKFA', 1, 1,  GETDATE()),
		('ETB', 'ETIOPIA, BIRR ETIOPE', 1, 1,  GETDATE()),
		('FJD', 'FIJI, DOLAR FIYIANO', 1, 1,  GETDATE()),
		('FKP', 'ISLAS MALVINAS, LIBRA MALVINENSE', 1, 1,  GETDATE()),
		('GBP', 'REINO UNIDO, LIBRA ESTERLINA', 1, 1,  GETDATE()),
		('GEL', 'GEORGIA, LARI', 1, 1,  GETDATE()),
		('GHS', 'GHANA, CEDI GHANES', 1, 1,  GETDATE()),
		('GIP', 'GIBRALTAR, LIBRA DE GIBRALTAR', 1, 1,  GETDATE()),
		('GMD', 'GAMBIA, DALASI', 1, 1,  GETDATE()),
		('GNF', 'GUINEA, FRANCO GUINEANO', 1, 1,  GETDATE()),
		('GTQ', 'GUATEMALA, QUETZAL', 1, 1,  GETDATE()),
		('GYD', 'GUYANA, DOLAR GUYANES', 1, 1,  GETDATE()),
		('HKD', 'HONG KONG, DOLAR DE HONG KONG', 1, 1,  GETDATE()),
		('HRK', 'CROACIA, KUNA', 1, 1,  GETDATE()),
		('HTG', 'HAITI, GOURDE', 1, 1,  GETDATE()),
		('HUF', 'HUNGRIA, FORINTO', 1, 1,  GETDATE()),
		('IDR', 'INDONESIA, RUPIA INDONESIA', 1, 1,  GETDATE()),
		('ILS', 'ISRAEL, NUEVO SHEQUEL ISRAELI', 1, 1,  GETDATE()),
		('INR', 'INDIA, RUPIA INDIA', 1, 1,  GETDATE()),
		('IQD', 'IRAQ, DINAR IRAQUI', 1, 1,  GETDATE()),
		('IRR', 'IRAN, RIAL IRANI', 1, 1,  GETDATE()),
		('ISK', 'ISLANDIA, CORONA ISLANDESA', 1, 1,  GETDATE()),
		('JMD', 'JAMAICA, DOLAR JAMAIQUINO', 1, 1,  GETDATE()),
		('JOD', 'JORDANIA, DINAR JORDANO', 1, 1,  GETDATE()),
		('JPY', 'JAPON, YEN', 1, 1,  GETDATE()),
		('KES', 'KENIA, CHELIN KENIANO', 1, 1,  GETDATE()),
		('KGS', 'KIRGHIZISTAN, SOM', 1, 1,  GETDATE()),
		('KHR', 'CAMBOYA, RIEL', 1, 1,  GETDATE()),
		('KMF', 'COMORES, FRANCO COMORENSE', 1, 1,  GETDATE()),
		('KPW', 'KOREA, REPUBLICA POPULAR, WON NORCOREANO', 1, 1,  GETDATE()),
		('KRW', 'KOREA, REPUBLICA DEMOCRATICA, WON', 1, 1,  GETDATE()),
		('KWD', 'KUWAIT, DINAR KUWAITI', 1, 1,  GETDATE()),
		('KYD', 'CAIMAN ISLAS, DOLAR DE LAS ISLAS CAIMAN', 1, 1,  GETDATE()),
		('KZT', 'KAZAKSTAN, TENGE', 1, 1,  GETDATE()),
		('LAK', 'LAOS, REPUBLICA POPULAR DEMOCRATICA, KIP', 1, 1,  GETDATE()),
		('LBP', 'LIBANO, LIBRA LIBANESA', 1, 1,  GETDATE()),
		('LKR', 'SRI LANKA, RUPIA DE SRI LANKA', 1, 1,  GETDATE()),
		('LRD', 'LIBERIA, DOLAR LIBERIANO', 1, 1,  GETDATE()),
		('LSL', 'LESOTHO, LOTI', 1, 1,  GETDATE()),
		('LYD', 'LIBIA ARABE, DINAR LIBIO', 1, 1,  GETDATE()),
		('MAD', 'MARRUECOS, DIRHAM MARROQUI', 1, 1,  GETDATE()),
		('MDL', 'MOLDAVIA, REPUBLICA DE, LEU MOLDAVO', 1, 1,  GETDATE()),
		('MGA', 'MADAGASCAR, ARIARY MALGACHE', 1, 1,  GETDATE()),
		('MKD', 'MACEDONIA, DENAR', 1, 1,  GETDATE()),
		('MMK', 'MYANMA, KYAT', 1, 1,  GETDATE()),
		('MNT', 'MONGOLIA, TUGRIK', 1, 1,  GETDATE()),
		('MOP', 'MACAU, PATACA', 1, 1,  GETDATE()),
		('MRO', 'MAURITANIA, UQUIYA', 1, 1,  GETDATE()),
		('MUR', 'MAURICIOS, RUPIA DE MAURICIO', 1, 1,  GETDATE()),
		('MVR', 'MALDIVAS, RUFIYAA', 1, 1,  GETDATE()),
		('MWK', 'MALAWI, KWACHA', 1, 1,  GETDATE()),
		('MXN', 'MEXICO, PESO MEXICANO', 1, 1,  GETDATE()),
		('MYR', 'MALASIA, RINGGIT MALAYO', 1, 1,  GETDATE()),
		('MZN', 'MOZAMBIQUE, METICAL MOZAMBIQUEÑO', 1, 1,  GETDATE()),
		('NAD', 'NAMIBIA, DOLAR NAMIBIO', 1, 1,  GETDATE()),
		('NGN', 'NIGERIA, NAIRA', 1, 1,  GETDATE()),
		('NIO', 'NICARAGUA, CORDOBA', 1, 1,  GETDATE()),
		('NOK', 'NORUEGA, CORONA NORUEGA', 1, 1,  GETDATE()),
		('NPR', 'NEPAL, RUPIA NEPALI', 1, 1,  GETDATE()),
		('NZD', 'NUEVA ZELANDA, DOLAR NEOZELANDES', 1, 1,  GETDATE()),
		('OMR', 'OMAN, RIAL OMANI', 1, 1,  GETDATE()),
		('PAB', 'PANAMA, BALBOA', 1, 1,  GETDATE()),
		('PEN', 'PERU, SOL PERUANO', 1, 1,  GETDATE()),
		('PGK', 'PAPUA NUEVA GUINEA, KINA', 1, 1,  GETDATE()),
		('PHP', 'FILIPINAS, PESO FILIPINO', 1, 1,  GETDATE()),
		('PKR', 'PAKISTAN, RUPIA PAKISTANI', 1, 1,  GETDATE()),
		('PLN', 'POLONIA, ZLOTY', 1, 1,  GETDATE()),
		('PYG', 'PARAGUAY, GUARANI', 1, 1,  GETDATE()),
		('QAR', 'QATAR, RIYAL QATARI', 1, 1,  GETDATE()),
		('RON', 'RUMANIA, LEU RUMANO', 1, 1,  GETDATE()),
		('RSD', 'SERBIA, DINAR SERBIO', 1, 1,  GETDATE()),
		('RUB', 'RUSA FEDERACION, RUBLO RUSO', 1, 1,  GETDATE()),
		('RWF', 'RUANDA, FRANCO RUANDES', 1, 1,  GETDATE()),
		('SAR', 'SAUDITA ARABIA, RIYAL SAUDI', 1, 1,  GETDATE()),
		('SBD', 'SOLOMON ISLAS, DOLAR DE LAS ISLAS SALOMON', 1, 1,  GETDATE()),
		('SCR', 'SEYCHELLES ISLAS, RUPIA SEYCHELENSE', 1, 1,  GETDATE()),
		('SDG', 'SUDAN, DINAR SUDANES', 1, 1,  GETDATE()),
		('SEK', 'SUECIA, CORONA SUECA', 1, 1,  GETDATE()),
		('SGD', 'SINGAPUR, DOLAR DE SINGAPUR', 1, 1,  GETDATE()),
		('SHP', 'SANTA HELENA, LIBRA DE SANTA ELENA', 1, 1,  GETDATE()),
		('SLL', 'SIERRA LEONA, LEONE', 1, 1,  GETDATE()),
		('SOS', 'SOMALIA, CHELIN SOMALI', 1, 1,  GETDATE()),
		('SRD', 'SURINAM, DOLAR SURINAMES', 1, 1,  GETDATE()),
		('SSP', 'SUDAN DEL SUR, LIBRA SURSUDANESA', 1, 1,  GETDATE()),
		('STD', 'SAO TOME Y PRINCIPE, DOBRA', 1, 1,  GETDATE()),
		('SYP', 'SIRIA REPUBLICA ARABE, LIBRA SIRIA', 1, 1,  GETDATE()),
		('SZL', 'SUAZILANDIA, LILANGENI', 1, 1,  GETDATE()),
		('THB', 'TAILANDIA, BAHT', 1, 1,  GETDATE()),
		('TJS', 'TADJIKISTAN, SOMONI TAYIKO', 1, 1,  GETDATE()),
		('TMT', 'TURKMENISTAN, MANAT TURCOMANO', 1, 1,  GETDATE()),
		('TND', 'TUNISIA, DINAR TUNECINO', 1, 1,  GETDATE()),
		('TOP', 'TONGA, PA''ANGA', 1, 1,  GETDATE()),
		('TRY', 'TURQUIA, LIRA TURCA', 1, 1,  GETDATE()),
		('TTD', 'TRINIDAD Y TOBAGO, DOLAR DE TRINIDAD Y TOBAGO', 1, 1,  GETDATE()),
		('TWD', 'TAIWAN, NUEVO DOLAR TAIWANES', 1, 1,  GETDATE()),
		('TZS', 'TANZANIA, CHELIN TANZANO', 1, 1,  GETDATE()),
		('UAH', 'UCRANIA, GRIVNA', 1, 1,  GETDATE()),
		('UGX', 'UGANDA, CHELIN UGANDES', 1, 1,  GETDATE()),
		('UYU', 'URUGUAY, PESO URUGUAYO', 1, 1,  GETDATE()),
		('UZS', 'UZBEKISTAN, SOM UZBEKO', 1, 1,  GETDATE()),
		('VEF', 'VENEZUELA, BOLIVAR', 1, 1,  GETDATE()),
		('VND', 'VIETNAM, DONG VIETNAMITA', 1, 1,  GETDATE()),
		('VUV', 'VANUATU, VATU', 1, 1,  GETDATE()),
		('WST', 'SAMOA, TALA', 1, 1,  GETDATE()),
		('XAF', 'FRANCO CFA DE AFRICA CENTRAL', 1, 1,  GETDATE()),
		('XCD', 'DOLAR DEL CARIBE ORIENTAL', 1, 1,  GETDATE()),
		('XOF', 'FRANCO CFA DE AFRICA OCCIDENTAL', 1, 1,  GETDATE()),
		('XPF', 'FRANCO CFP', 1, 1,  GETDATE()),
		('XSU', 'SUCRE', 1, 1,  GETDATE()),
		('YER', 'YEMEN, RIAL YEMENI', 1, 1,  GETDATE()),
		('ZAR', 'SURAFRICA, RAND', 1, 1,  GETDATE()),
		('ZMW', 'ZAMBIA, KWACHA ZAMBIANO', 1, 1,  GETDATE()),
		('ZWL', 'ZIMBABWE, DOLAR ZIMBABUENSE', 1, 1,  GETDATE());

/*-----------------------------------*/
--***** INSERT TABLA EMPLEADOS --******--
GO
INSERT INTO [Gral].[tbEmpleados](empl_Nombres, empl_Apellidos, empl_DNI, escv_Id, empl_Sexo, empl_FechaNacimiento, empl_Telefono, empl_DireccionExacta, pvin_Id, empl_CorreoElectronico, carg_Id, empl_EsAduana, usua_UsuarioCreacion, empl_FechaCreacion)
values('Mario Antoni','Lopez Suazo','0311-2005-00908',1,'M','05-10-2022','+504 9785-6222','col. el Amatillo casa #5',1,'mario@gmail.com',1,1,1,'05-06-2000');

INSERT INTO Gral.tbEmpleados([empl_Nombres], [empl_Apellidos],[empl_DNI], [escv_Id], [empl_Sexo], [empl_FechaNacimiento],[empl_Telefono],
								[empl_DireccionExacta],[pvin_Id], [empl_CorreoElectronico],[carg_Id],[empl_EsAduana],[usua_UsuarioCreacion],
								[empl_FechaCreacion])
VALUES							('Angie Yahaira', 'Campos Arias', '0512-2003-00736', 1, 'F', '2003-01-03', '+504 9588-7062', 
								'Res. Oro Verde, La Lima', 24, 'angie.camposyc03@gmail.com',2, 0, 1, '2023-08-18')

GO
INSERT INTO Gral.tbEmpleados (empl_Nombres, empl_Apellidos, empl_DNI, escv_Id, empl_Sexo, empl_FechaNacimiento, empl_Telefono, empl_DireccionExacta, pvin_Id, empl_CorreoElectronico, carg_Id, empl_EsAduana, usua_UsuarioCreacion, empl_FechaCreacion)
VALUES ('Karla Melissa',		'Lopez Medina',		'0502-2000-01549',1,'F','10-16-2004','9804-1263','Calle principal', 65,'karlamedina12@gmail.com',1,1,1,GETDATE()),
       ('Paulo Gustavo',		'Mejia Vides',		'0502-2000-96478',1,'M','10-16-2004','9901-1263','Calle principal', 66,'gustavomejia2@gmail.com',2,1,1,GETDATE()),
	   ('Alex',					'Mendez',			'0502-1994-96478',1,'M','10-16-2004','3301-1263','1  Calle 2 Avenida', 66,'alexmendez43@gmail.com',2,1,1,GETDATE()),
	   ('Jose Luis',			'Velazquez',		'0501-1996-96478',1,'M','10-16-2004','9789-4321','3  Calle 2 Avenida', 66,'joseluis3@gmail.com',1,1,1,GETDATE()),
	   ('Luis',					'Molina',			'0501-2002-96478',1,'M','10-16-2004','3252-4321','3  Calle 2 Avenida', 67,'luismedina12@gmail.com',1,1,1,GETDATE()),
	   ('Marcia Patricia',		'Hernandez Rauda',	'0501-7002-96478',1,'F','10-16-2004','3352-4321','3  Calle 3 Avenida', 68,'marciarauda@gmail.com',1,1,1,GETDATE()),
	   ('Alonso',				'Medina',			'0501-2000-96478',1,'M','10-16-2004','3252-4321','3  Calle 3 Avenida', 69,'marciarauda@gmail.com',1,1,1,GETDATE()),
	   ('Claudia Esmeralda',	'Portillo',			'0503-2000-96400',1,'F','10-16-2004','9552-4321','Calle principal', 69,'marciarauda@gmail.com',1,1,1,GETDATE()),
	   ('Mauricio',				'Lopez',			'0503-2001-90400',1,'M','10-16-2004','9092-4321','Calle principal', 70,'mauriciolopez@gmail.com',1,1,1,GETDATE()),
	   ('Maria Julia',			'Matute',			'0503-2001-90110',1,'F','10-16-2004','9992-4321','Calle principal', 70,'maria@gmail.com',1,1,1,GETDATE());


/*-----------------------------------*/
--***** INSERT TABLA PROVEEDORES --******--
GO
INSERT INTO [Gral].[tbProveedores]
(prov_NombreCompania, prov_NombreContacto, prov_Telefono, prov_CodigoPostal, prov_Ciudad, prov_DireccionExacta, prov_CorreoElectronico, usua_UsuarioCreacion, prov_FechaCreacion, prov_Estado)
VALUES
('ECOMODA','BEATRIZ PINZON ZOLANO','9815-9299','21004',1,'--------','is@hotmail.com',1,GETDATE(),1);

/*-----------------------------------*/
--***** INSERT TABLA FORMAS DE ENVIO --******--
GO
INSERT INTO Gral.tbFormas_Envio (foen_Codigo,foen_Descripcion, usua_UsuarioCreacion, foen_FechaCreacion)
VALUES	('FR', 'FRACCIONADO',	1, GETDATE()),
		('OT', 'OTRO',			1, GETDATE()),
		('PR', 'PARCIAL',		1, GETDATE()),
		('TT', 'TOTAL',			1, GETDATE())

CREATE OR ALTER PROC Prod.UDP_Reporte_ProduccionPorModulo -- '01-01-2023','11-08-2023'
@fecha_inicio   DATE,
@fecha_fin      DATE
AS
BEGIN
	SELECT
			Modulo.modu_Nombre,
			SUM(ReporteModuloDiaDetalle.rdet_TotalDia) AS TotalProduccion,
			AVG(rdet_TotalDia) AS PromedioCantidad,
			AVG(rdet_TotalDanado) AS PromedioDanio,
			CAST(SUM(CAST(ReporteModuloDiaDetalle.rdet_TotalDia  AS DECIMAL(18,2))) * 100.0 / SUM(SUM(CAST(ReporteModuloDiaDetalle.rdet_TotalDia AS DECIMAL(18,2))))OVER() AS DECIMAL(18,2)) AS PorcentajeProduccion
	FROM	Prod.tbReporteModuloDiaDetalle  ReporteModuloDiaDetalle
			INNER JOIN Prod.tbReporteModuloDia ReporteModuloDia ON ReporteModuloDiaDetalle.remo_Id = ReporteModuloDia.remo_Id
			INNER JOIN Prod.tbModulos AS Modulo ON ReporteModuloDia.modu_Id = Modulo.modu_Id
	WHERE rdet_FechaCreacion BETWEEN @fecha_inicio  AND @fecha_fin 
	GROUP BY Modulo.modu_Nombre;
END

GO

CREATE OR ALTER PROC Prod.UDP_Reporte_Planificación_Produccion --1
@orco_Id INT
AS
BEGIN
		SELECT	asor_Id,
				asor_OrdenDetId,
				esti.esti_Descripcion,
				colr.colr_Nombre,
				tall.tall_Nombre,
				orco.orco_Id,
				clie.clie_Nombre_O_Razon_Social,
				asor_FechaInicio,
				asor_FechaLimite,
				asor_Cantidad,
				pro.proc_Descripcion,
				empl.empl_Nombres + ' ' + empl_Apellidos AS empl_NombreCompleto
		FROM	Prod.tbAsignacionesOrden AS asignacionesOrden
				INNER JOIN Prod.tbProcesos pro ON asignacionesOrden.proc_Id = pro.proc_Id
				INNER JOIN Gral.tbEmpleados empl ON asignacionesOrden.empl_Id = empl.empl_Id
				INNER JOIN Prod.tbOrdenCompraDetalles code ON asignacionesOrden.asor_OrdenDetId = code.code_Id
				INNER JOIN Prod.tbEstilos esti ON code.esti_Id = esti.esti_Id
				INNER JOIN Prod.tbColores colr ON code.colr_Id = colr.colr_Id
				INNER JOIN Prod.tbTallas tall ON code.tall_Id = tall.tall_Id
				INNER JOIN Prod.tbOrdenCompra orco ON code.orco_Id = orco.orco_Id
				INNER JOIN Prod.tbClientes clie ON orco.orco_IdCliente = clie.clie_Id
		WHERE orco.orco_Id = @orco_Id
		ORDER BY asor_OrdenDetId
END

GO

CREATE OR ALTER PROCEDURE Prod.UDP_CostosMaterialesNoBrindados -- '01-01-2023','11-08-2023'
	@mate_FechaInicio			DATE,
	@mate_FechaLimite			DATE
AS
BEGIN
	SELECT		mate.mate_Descripcion,
				(SUM(peod.prod_Cantidad)) as TotalCantidad,
				CONVERT( DECIMAL(18,2), (CONVERT(DECIMAL(18,2), SUM(peod.prod_Cantidad) * 100)) / CONVERT(DECIMAL(18,2),(SELECT SUM(prod_Cantidad)FROM Prod.tbPedidosOrdenDetalle))) AS PorcentajeProductos,
				AVG(peod.prod_Precio) AS PrecioPromedioMaterial
		FROM	Prod.tbPedidosOrdenDetalle peod  LEFT JOIN Prod.tbMateriales mate ON peod.mate_Id = mate.mate_Id
		WHERE	peod.prod_FechaCreacion BETWEEN @mate_FechaInicio AND @mate_FechaLimite
		GROUP BY mate.mate_Descripcion;
END

GO

CREATE OR ALTER PROC Prod.UDP_Reporte_Consumo_Materiales --'01-01-2023','11-08-2023'
@fecha_inicio   DATE,
@fecha_fin      DATE
AS
BEGIN
	SELECT		mat.[mate_Descripcion],
				SUM(pep.[ppde_Cantidad]) AS TotalMaterial,
				AVG(pep.[ppde_Cantidad]) AS PromedioMaterial,
				CAST(CAST(SUM(pep.[ppde_Cantidad]) AS DECIMAL(18,2)) / SUM(SUM(pep.[ppde_Cantidad])) OVER () * 100 AS DECIMAL(18,2)) AS PorcentajeMaterial
	FROM		[Prod].[tbPedidosProduccionDetalles] pep 
	INNER JOIN	[Prod].[tbLotes] lot ON pep.[lote_Id] = lot.[lote_Id]
	INNER JOIN	[Prod].[tbMateriales] mat ON lot.[mate_Id] = mat.[mate_Id]
	WHERE		pep.[ppde_FechaCreacion] BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY	mat.[mate_Descripcion]
	ORDER BY	TotalMaterial;
END

GO

CREATE OR ALTER PROC Adua.UDP_Reporte_Contratos_Persona_Natural_Por_Fecha -- '2023-09-11','2023-09-12'
@fecha_inicio   DATE,
@fecha_fin      DATE
AS
BEGIN
	SELECT
		ISNULL(tbps.[pers_Nombre], 'N/D')									AS [pers_Nombre],
		ISNULL([pena_DireccionExacta], 'N/D')								AS [pena_DireccionExacta],
		ISNULL(tbcd.[ciud_Nombre], 'N/D')									AS [ciud_Nombre],
		ISNULL([pena_TelefonoFijo], 'N/D')									AS [pena_TelefonoFijo],
		ISNULL([pena_TelefonoCelular], 'N/D')								AS [pena_TelefonoCelular],
		ISNULL([pena_CorreoElectronico], 'N/D')								AS [pena_CorreoElectronico],
		ISNULL([pena_CorreoAlternativo], 'N/D')								AS [pena_CorreoAlternativo],
		ISNULL([pena_RTN], 'N/D')											AS [pena_RTN],
		ISNULL([pena_ArchivoRTN], 'N/D')									AS [pena_ArchivoRTN],
		ISNULL([pena_DNI], 'N/D')											AS [pena_DNI],
		ISNULL([pena_ArchivoDNI], 'N/D')									AS [pena_ArchivoDNI],
		ISNULL([pena_NumeroRecibo], 'N/D')									AS [pena_NumeroRecibo],
		ISNULL([pena_ArchivoNumeroRecibo], 'N/D')							AS [pena_ArchivoNumeroRecibo],
		ISNULL([pena_NombreArchDNI], 'N/D')									AS [pena_NombreArchDNI],
		ISNULL([pena_NombreArchRTN], 'N/D')									AS [pena_NombreArchRTN],
		ISNULL([pena_NombreArchRecibo], 'N/D')								AS [pena_NombreArchRecibo],
		[pena_FechaCreacion]
FROM	[Adua].[tbPersonaNatural]			tbpn

		LEFT JOIN	[Adua].[tbPersonas]		tbps ON tbpn.pers_Id = tbps.pers_Id
		LEFT JOIN	[Gral].[tbCiudades]		tbcd ON tbpn.ciud_Id = tbcd.ciud_Id

WHERE	tbpn.[pena_FechaCreacion] >= @fecha_inicio AND tbpn.[pena_FechaCreacion] <=  @fecha_fin
END

GO


CREATE OR ALTER PROC Adua.UDP_Reporte_Contratos_Persona_Juridica_Por_Fecha -- '2023-09-11','2023-09-20'
@fecha_inicio   DATE,
@fecha_fin      DATE
AS
BEGIN
	SELECT
		ISNULL(tbps.[pers_Nombre], 'N/D')								AS [pers_Nombre],
		ISNULL([peju_PuntoReferencia], 'N/D')							AS [peju_PuntoReferencia],
		ISNULL([peju_NumeroLocalRepresentante], 'N/D')					AS [peju_NumeroLocalRepresentante],
		ISNULL([peju_PuntoReferenciaRepresentante], 'N/D')				AS [peju_PuntoReferenciaRepresentante],
		ISNULL([peju_TelefonoEmpresa], 'N/D')							AS [peju_TelefonoEmpresa],
		ISNULL([peju_TelefonoFijoRepresentanteLegal], 'N/D')			AS [peju_TelefonoFijoRepresentanteLegal],
		ISNULL([peju_TelefonoRepresentanteLegal], 'N/D')				AS [peju_TelefonoRepresentanteLegal],
		ISNULL([peju_CorreoElectronico], 'N/D')							AS [peju_CorreoElectronico],
		ISNULL([peju_CorreoElectronicoAlternativo], 'N/D')				AS [peju_CorreoElectronicoAlternativo],
		ISNULL(tbcd.[ciud_Nombre], 'N/D')								AS [ciud_Nombre],
		ISNULL(tbcl.[colo_Nombre], 'N/D')								AS [colo_Nombre],
		ISNULL(tbal.[alde_Nombre], 'N/D')								AS [alde_Nombre],
		ISNULL(tbcd2.[ciud_Nombre], 'N/D')								AS [peju_CiudadIdRepresentante],
		ISNULL(tbcl2.[colo_Nombre], 'N/D')								AS [peju_ColoniaRepresentante],
		ISNULL(tbal2.[alde_Nombre], 'N/D')								AS [peju_AldeaIdRepresentante],
		ISNULL([peju_NumeroLocalApart], 'N/D')							AS [peju_NumeroLocalApart],
		[peju_FechaCreacion]
FROM	[Adua].[tbPersonaJuridica]			tbpj

		LEFT JOIN	[Adua].[tbPersonas]		tbps ON tbpj.pers_Id = tbps.pers_Id
		LEFT JOIN	[Gral].[tbCiudades]		tbcd ON tbpj.ciud_Id = tbcd.ciud_Id
		LEFT JOIN	[Gral].[tbColonias]		tbcl ON tbpj.colo_Id = tbcl.colo_Id
		LEFT JOIN	[Gral].[tbAldeas]		tbal ON tbpj.alde_Id = tbal.alde_Id
		
		LEFT JOIN	[Gral].[tbCiudades]		tbcd2 ON tbpj.ciud_Id = tbcd2.ciud_Id
		LEFT JOIN	[Gral].[tbColonias]		tbcl2 ON tbpj.colo_Id = tbcl2.colo_Id
		LEFT JOIN	[Gral].[tbAldeas]		tbal2 ON tbpj.alde_Id = tbal2.alde_Id


WHERE	tbpj.[peju_FechaCreacion] >= @fecha_inicio AND tbpj.[peju_FechaCreacion] <=  @fecha_fin
END

GO

CREATE OR ALTER PROC Adua.UDP_Reporte_Contratos_Comerciante_Individual_Por_Fecha --'2023-09-11','2023-09-18'
@fecha_inicio   DATE,
@fecha_fin      DATE
AS
BEGIN
		SELECT
		ISNULL(tbps.[pers_Nombre], 'N/D')					AS [pers_Nombre],
		ISNULL([pers_FormaRepresentacion], 'N/D')			AS [pers_FormaRepresentacion],
		ISNULL(tbcd.[ciud_Nombre], 'N/D')					AS [ciud_Nombre],
		ISNULL(tbcl.[colo_Nombre], 'N/D')					AS [colo_Nombre],
		ISNULL(tbal.[alde_Nombre], 'N/D')					AS [alde_Nombre],
		ISNULL([coin_TelefonoCelular], 'N/D')				AS [coin_TelefonoCelular],
		ISNULL([coin_TelefonoFijo], 'N/D')					AS [coin_TelefonoFijo],
		ISNULL([coin_CorreoElectronico], 'N/D')				AS [coin_CorreoElectronico],
		ISNULL([coin_CorreoElectronicoAlternativo], 'N/D')	AS [coin_CorreoElectronicoAlternativo],
		[coin_FechaCreacion]
FROM	[Adua].[tbComercianteIndividual]	tbci
		
		LEFT JOIN	[Adua].[tbPersonas]		tbps ON tbci.pers_Id = tbps.pers_Id
		LEFT JOIN	[Gral].[tbCiudades]		tbcd ON tbci.ciud_Id = tbcd.ciud_Id
		LEFT JOIN	[Gral].[tbColonias]		tbcl ON tbci.colo_Id = tbcl.colo_Id
		LEFT JOIN	[Gral].[tbAldeas]		tbal ON tbci.alde_Id = tbal.alde_Id

WHERE	tbci.[coin_FechaCreacion] >= @fecha_inicio AND tbci.[coin_FechaCreacion] <=  @fecha_fin
END

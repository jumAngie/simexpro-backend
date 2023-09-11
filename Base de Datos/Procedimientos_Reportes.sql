CREATE OR ALTER PROC Prod.UDP_Reporte_ProduccionPorModulo 
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

CREATE OR ALTER PROC Prod.UDP_Reporte_Planificación_Produccion
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

CREATE OR ALTER PROCEDURE Prod.UDP_CostosMaterialesNoBrindados --'01-01-2023','11-08-2023'
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
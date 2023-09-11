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

END
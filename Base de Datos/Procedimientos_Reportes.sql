CREATE OR ALTER PROC Prod.UDP_Reporte_ProduccionPorModulo 
@fecha_inicio   DATE,
@fecha_fin      DATE
AS
BEGIN
    SELECT
        Modulo.modu_Nombre,
        SUM(ReporteModulo.remo_TotalDia) AS TotalProduccionDia,
        SUM(ReporteModulo.remo_TotalDia) * 100.0 / SUM(SUM(ReporteModulo.remo_TotalDia)) OVER() AS PorcentajeProduccion
    FROM Prod.tbReporteModuloDia AS ReporteModulo
        INNER JOIN Prod.tbModulos AS Modulo ON ReporteModulo.modu_Id = Modulo.modu_Id
    WHERE remo_FechaCreacion BETWEEN @fecha_inicio  AND @fecha_fin 
    GROUP BY Modulo.modu_Nombre;
END

GO


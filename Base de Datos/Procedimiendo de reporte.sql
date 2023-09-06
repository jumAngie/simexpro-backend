

--CREATE OR ALTER PROCEDURE Prod.UPD_Reporte_TiemposMaquinas 
--@maqu_Id INT
--AS
--BEGIN
--	SELECT	maqu.maqu_Id
--			,DATEDIFF(day, maqu.maqu_FechaCreacion, GETDATE()) AS diasActiva
--			,DATEDIFF(day, mahi.mahi_FechaInicio, mahi.mahi_FechaFin) AS diasInactiva
--			,(SELECT SUM(DATEDIFF(day, mahia.mahi_FechaInicio, mahia.mahi_FechaFin)) FROM [Prod].[tbMaquinaHistorial] mahia WHERE mahia.maqu_Id = maqu.maqu_Id ) as diasTotalesInactiva
--			,mahi.mahi_Observaciones
--	FROM [Prod].[tbMaquinas] maqu LEFT JOIN [Prod].[tbMaquinaHistorial] mahi
--	ON maqu.maqu_Id = mahi.maqu_Id 
--	WHERE maqu.maqu_Id = @maqu_Id
--END



SELECT * 
FROM [Prod].[tbOrdenCompra] PO INNER JOIN [Prod].[tbClientes] Clie
ON PO.orco_IdCliente = Clie.clie_Id LEFT JOIN [Prod].[tbOrdenCompraDetalles] OD
ON PO.orco_Id = OD.orco_Id
WHERE PO.orco_Id = 1



SELECT * FROM [Prod].[tbOrdenCompraDetalles]
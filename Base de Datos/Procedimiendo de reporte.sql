

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




--CREATE OR ALTER PROCEDURE Prod.UDP_Reporte_PedidosCliente --1
--@clie_Id INT
--AS
--BEGIN 
--SELECT	(SELECT COUNT (*) FROM [Prod].[tbOrdenCompra] PO1 WHERE PO1.orco_IdCliente = PO.orco_IdCliente AND PO1.orco_EstadoOrdenCompra = 'T') AS PedidosTerminados
--		,(SELECT COUNT (*) FROM [Prod].[tbOrdenCompra] PO1 WHERE PO1.orco_IdCliente = PO.orco_IdCliente AND PO1.orco_EstadoOrdenCompra = 'P') AS PedidosPendientes
--		,(SELECT COUNT (*) FROM [Prod].[tbOrdenCompra] PO1 WHERE PO1.orco_IdCliente = PO.orco_IdCliente AND PO1.orco_EstadoOrdenCompra = 'C') AS PedidosCurso
--		,ISNULL((SELECT SUM(reca_Cantidad-reca_Scrap) FROM [Prod].[tbRevisionDeCalidad] RVS  INNER JOIN [Prod].[tbOrde_Ensa_Acab_Etiq] OER ON OER.ensa_Id = RVS.ensa_Id INNER JOIN [Prod].[tbModulos] MDU ON OER.modu_Id = MDU.modu_Id WHERE MDU.proc_Id >= 6 AND OER.[code_Id] = OD.code_Id),0) AS CantidadCompletada
--		,(ISNULL((SELECT SUM(reca_Cantidad-reca_Scrap) FROM [Prod].[tbRevisionDeCalidad] RVS  INNER JOIN [Prod].[tbOrde_Ensa_Acab_Etiq] OER ON OER.ensa_Id = RVS.ensa_Id INNER JOIN [Prod].[tbModulos] MDU ON OER.modu_Id = MDU.modu_Id WHERE MDU.proc_Id >= 6 AND OER.[code_Id] = OD.code_Id),0) / ISNULL(OD.code_CantidadPrenda,1)) * 100 AS PorcentajeCompleado
--		,ISNULL(OD.code_CantidadPrenda,0) AS code_CantidadPrenda
--		,code_Sexo
--		,clie_Nombre_O_Razon_Social
--		,clie_RTN
--		,clie_Nombre_Contacto
--		,clie_Numero_Contacto
--		,clie_Correo_Electronico
--		--,*
--FROM [Prod].[tbOrdenCompra] PO INNER JOIN [Prod].[tbClientes] Clie
--ON PO.orco_IdCliente = Clie.clie_Id INNER JOIN [Prod].[tbOrdenCompraDetalles] OD
--ON PO.orco_Id = OD.orco_Id 
--WHERE PO.orco_IdCliente = @clie_Id
--END



SELECT * FROM [Prod].[tbRevisionDeCalidad]
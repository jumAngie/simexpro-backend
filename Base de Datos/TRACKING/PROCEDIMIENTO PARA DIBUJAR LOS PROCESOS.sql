
CREATE OR ALTER PROC Prod.UDP_DibujarProcesos
	@orco_Codigo NVARCHAR(100)
AS
BEGIN
SELECT	DISTINCT 
		proce.proc_Descripcion,
		proce.proc_CodigoHTML,
		procxorder.proc_Id
FROM	[Prod].[tbProcesoPorOrdenCompraDetalle] procxorder	INNER JOIN [Prod].[tbProcesos] proce
ON		procxorder.proc_Id = proce.proc_Id					INNER JOIN [Prod].[tbOrdenCompraDetalles] orderdet
ON		procxorder.code_Id = orderdet.code_Id				INNER JOIN [Prod].[tbOrdenCompra] orderhead
ON		orderdet.orco_Id = orderhead.orco_Id
WHERE	orco_Codigo = @orco_Codigo
END


-- ///
go
CREATE OR ALTER PROC Prod.UDP_DibujarDetalles
	@orco_Codigo NVARCHAR(100)
AS
BEGIN
	SELECT	orden.orco_Id, code_Id, code_CantidadPrenda, estilos.esti_Descripcion, [tall_Nombre]  , proc_IdActual, [proc_Descripcion]
	FROM	[Prod].[tbOrdenCompraDetalles] orderdet	INNER JOIN [Prod].[tbOrdenCompra] orden
	ON		orderdet.orco_Id = orden.orco_Id		INNER JOIN [Prod].[tbEstilos] estilos
	ON		orderdet.esti_Id = estilos.esti_Id		INNER JOIN [Prod].[tbTallas] tallas
	ON		orderdet.tall_Id = tallas.tall_Id		INNER JOIN [Prod].[tbProcesos] procesos
	ON		orderdet.proc_IdActual = procesos.proc_Id
	WHERE	orco_Codigo = @orco_Codigo
END
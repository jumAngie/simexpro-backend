CREATE OR ALTER PROC Prod.UPD_DibujarProcesos
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

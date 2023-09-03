select poco_Id, OCDET.orco_Id , PODET.code_Id,  [proc_Descripcion] from
[Prod].[tbProcesoPorOrdenCompraDetalle] PODET INNER JOIN [Prod].[tbProcesos] PROCESO 
ON	PODET.proc_Id = PROCESO.proc_Id			  INNER JOIN [Prod].[tbOrdenCompraDetalles] OCDET
ON  PODET.code_Id = OCDET.code_Id
WHERE OCDET.orco_Id = 4


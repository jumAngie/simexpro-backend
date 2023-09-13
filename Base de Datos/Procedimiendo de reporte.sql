

CREATE OR ALTER PROCEDURE Prod.UPD_Reporte_TiemposMaquinas
@maqu_Id INT
AS
BEGIN
	SELECT	 maqu.maqu_Id
			,maqu.maqu_NumeroSerie
			,mmq.marq_Nombre
			,DATEDIFF(day, maqu.maqu_FechaCreacion, GETDATE()) AS diasActiva
			,DATEDIFF(day, mahi.mahi_FechaInicio, mahi.mahi_FechaFin) AS diasInactiva
			,(SELECT SUM(DATEDIFF(day, mahia.mahi_FechaInicio, mahia.mahi_FechaFin)) FROM [Prod].[tbMaquinaHistorial] mahia WHERE mahia.maqu_Id = maqu.maqu_Id ) as diasTotalesInactiva
			,mahi.mahi_Observaciones
	FROM [Prod].[tbMaquinas] maqu LEFT JOIN [Prod].[tbMaquinaHistorial] mahi
	ON maqu.maqu_Id = mahi.maqu_Id 
	LEFT JOIN [Prod].[tbMarcasMaquina] mmq 
	ON maqu.mmaq_Id = mmq.marq_Id
	WHERE maqu.maqu_Id = @maqu_Id
END




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

GO

CREATE OR ALTER PROCEDURE Prod.UDP_Reporte_MaquinaUso
@modu_Id INT
AS 
BEGIN 
SELECT  maq.maqu_Id
		,maq.maqu_NumeroSerie
		,maq.mmaq_Id
		,marca.marq_Nombre
		,maq.modu_Id
		,modulo.modu_Nombre
		,CASE
			WHEN hmq.mahi_Id IS NULL
				THEN 1
			ELSE 0
		END AS EnUso
		,(SELECT MAX(mahi_FechaInicio) FROM [Prod].[tbMaquinaHistorial] x WHERE x.maqu_Id = maq.maqu_Id ) deshabilitada
		,(SELECT MAX(mahi_FechaFin) FROM [Prod].[tbMaquinaHistorial] x WHERE x.maqu_Id = maq.maqu_Id )	habilitada
FROM [Prod].[tbMaquinas] maq LEFT JOIN [Prod].[tbMaquinaHistorial] hmq
ON maq.maqu_Id  = hmq.maqu_Id AND GETDATE() BETWEEN hmq.mahi_FechaInicio AND hmq.mahi_FechaFin
LEFT JOIN [Prod].[tbMarcasMaquina] marca ON maq.mmaq_Id = marca.marq_Id
LEFT JOIN [Prod].[tbModulos] modulo ON modulo.modu_Id = maq.modu_Id
WHERE @modu_Id = 0 OR modulo.modu_Id = @modu_Id

END

GO


CREATE OR ALTER PROCEDURE Prod.UDP_Reporte_OrdenesDeCompraFecha
AS
BEGIN

	
	SELECT	 ordenCompra.orco_Id
	-- Informacion del cliente
			,ordenCompra.orco_Codigo
			,ordenCompra.orco_IdCliente
			,cliente.clie_Nombre_O_Razon_Social
			,cliente.clie_Direccion
			,cliente.clie_RTN
			,cliente.clie_Nombre_Contacto
			,cliente.clie_Numero_Contacto
			,cliente.clie_Correo_Electronico
			,cliente.clie_FAX
			,ordenCompra.orco_EstadoFinalizado
			,ordenCompra.orco_FechaEmision
			,ordenCompra.orco_FechaLimite
			,ordenCompra.orco_Materiales

			,ordenCompra.orco_MetodoPago
			,fomapago.fopa_Descripcion

	--Informacion del Embalaje
			,ordenCompra.orco_IdEmbalaje
			,tipoEmbajale.tiem_Descripcion

			,ordenCompra.orco_EstadoOrdenCompra
			,ordenCompra.orco_DireccionEntrega
			,ordenCompra.usua_UsuarioCreacion
			,usuarioCreacion.usua_Nombre		AS usuarioCreacionNombre
			,ordenCompra.orco_FechaCreacion
			,ordenCompra.usua_UsuarioModificacion
			,usuarioModificacion.usua_Nombre	AS usuarioModificacionNombre
			,ordenCompra.orco_FechaModificacion
			,ordenCompra.orco_Estado
		--	,(SELECT	PPOCD.[poco_Id], 
		--		PPOCD.[code_Id], 
		--		PPOCD.[proc_Id], 
		--		PROCE.[proc_Descripcion],
		--		PPOCD.[usua_UsuarioCreacion], 
		--		PPOCD.[poco_FechaCreacion], 
		--		PPOCD.[usua_UsuarioModificacion], 
		--		PPOCD.[poco_FechaModificacion], 
		--		PPOCD.[code_Estado]
		--FROM Prod.tbProcesoPorOrdenCompraDetalle PPOCD
		--	INNER JOIN Prod.tbOrdenCompraDetalles OCD
		--	ON PPOCD.code_Id = OCD.code_Id
		--	INNER JOIN Prod.tbProcesos PROCE
		--	ON PPOCD.proc_Id = PROCE.proc_Id
		--	WHERE PPOCD.code_Id = )
	  FROM  Prod.tbOrdenCompra							ordenCompra
			INNER JOIN  Prod.tbClientes					cliente				ON ordenCompra.orco_IdCliente  = cliente.clie_Id
			INNER JOIN  Prod.tbTipoEmbalaje				tipoEmbajale		ON ordenCompra.orco_IdEmbalaje = tipoEmbajale.tiem_Id
			INNER JOIN	Adua.tbFormasdePago				fomapago			ON ordenCompra.orco_MetodoPago = fomapago.fopa_Id
		    INNER JOIN  Acce.tbUsuarios					usuarioCreacion		ON ordenCompra.usua_UsuarioCreacion			= usuarioCreacion.usua_Id
			LEFT  JOIN  Acce.tbUsuarios					usuarioModificacion ON ordenCompra.usua_UsuarioModificacion		= usuarioModificacion.usua_Id
END
GO

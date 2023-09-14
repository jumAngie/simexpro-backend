

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
-----------------------------



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
@FechaInicio	DATE,
@FechaFin		DATE
AS
BEGIN

	SELECT	 
			ordenCompra.orco_Id
			,cliente.clie_Nombre_O_Razon_Social
			,cliente.clie_Direccion
			,cliente.clie_RTN
			,cliente.clie_Nombre_Contacto
			,cliente.clie_Numero_Contacto
			,cliente.clie_Correo_Electronico
			,cliente.clie_FAX
			,ordenCompra.orco_FechaEmision
			,ordenCompra.orco_FechaLimite
			,ordenCompra.orco_Materiales
			,fomapago.fopa_Descripcion
			,tipoEmbajale.tiem_Descripcion
			,ordenCompra.orco_EstadoOrdenCompra
			,ordenCompra.orco_DireccionEntrega
			,(
			SELECT m.* 
				FROM 
			(SELECT	 ordenCompraDetalle.code_Id
					,ordenCompraDetalle.orco_Id
					,ordenCompraDetalle.code_CantidadPrenda
					,estilo.esti_Descripcion
					,talla.tall_Nombre
					,ordenCompraDetalle.code_Sexo
					,colores.colr_Nombre
					,ordenCompraDetalle.code_Unidad
					,ordenCompraDetalle.code_Valor
					,ordenCompraDetalle.code_Impuesto
					,ordenCompraDetalle.code_EspecificacionEmbalaje
			  FROM	Prod.tbOrdenCompraDetalles			    ordenCompraDetalle
					INNER JOIN	Prod.tbEstilos				estilo						ON	ordenCompraDetalle.esti_Id						= estilo.esti_Id
					INNER JOIN	Prod.tbTallas				talla						ON	ordenCompraDetalle.tall_Id						= talla.tall_Id
					INNER JOIN  Prod.tbColores				colores						ON	ordenCompraDetalle.colr_Id						= colores.colr_Id
					WHERE ordenCompraDetalle.orco_Id	=	ordenCompra.orco_Id) AS m
			FOR JSON PATH ) AS Detalles
		FROM  Prod.tbOrdenCompra							ordenCompra
			INNER JOIN  Prod.tbClientes					cliente				ON ordenCompra.orco_IdCliente  = cliente.clie_Id
			INNER JOIN  Prod.tbTipoEmbalaje				tipoEmbajale		ON ordenCompra.orco_IdEmbalaje = tipoEmbajale.tiem_Id
			INNER JOIN	Adua.tbFormasdePago				fomapago			ON ordenCompra.orco_MetodoPago = fomapago.fopa_Id	
		WHERE @fechaInicio <= orco_FechaEmision AND @fechaFin >= orco_FechaEmision

END
GO



CREATE OR ALTER PROCEDURE Prod.UDP_Reporte_Inventaro --0
@mate_Id INT
AS
BEGIN

SELECT	DISTINCT mate.mate_id
		,mate.mate_Descripcion
		,[mate_Imagen]
		,subc.subc_Descripcion
		,cate.cate_Descripcion
		,(SELECT SUM(lote_Stock) FROM Prod.tbLotes suma WHERE suma.mate_Id = lt.mate_Id) AS StockTotal
		,(SELECT m.* 
				FROM 
			(SELECT 
				   --CAMPOS PROPIOS DE LOTES
				   lote_Id, 
				   lotes.prod_Id,
				   lotes.unme_Id,
				   UnidadesMedida.unme_Descripcion,
				   lotes.lote_CodigoLote,
				   lotes.lote_Observaciones,
				   lote_Stock,
				   lote_CantIngresada,
				   areas.tipa_area,
				   lotes.tipa_id,
				   lotes.colr_Id,
				   color.colr_Nombre,
				   color.colr_Codigo,
				   color.colr_CodigoHtml
			  FROM Prod.tbLotes lotes
				   LEFT JOIN Prod.tbArea							AS areas             ON lotes.tipa_id                  = areas.tipa_id
				   LEFT JOIN Prod.tbColores                         AS color             ON lotes.colr_Id                  = color.colr_Id
				   LEFT JOIN Gral.tbUnidadMedidas					AS UnidadesMedida    ON lotes.unme_Id                  = UnidadesMedida.unme_Id
				WHERE lotes.mate_Id = mate.mate_Id) AS m
						FOR JSON PATH ) AS Detalles

FROM [Prod].[tbMateriales] mate INNER JOIN Prod.tbLotes lt
ON lt.mate_Id = mate.mate_Id LEFT JOIN Prod.tbSubcategoria subc			
ON mate.subc_Id = subc.subc_Id LEFT JOIN Prod.tbCategoria  cate            
ON cate.cate_Id = subc.cate_Id
WHERE mate.mate_Id = @mate_Id OR @mate_Id = 0
ORDER BY mate_Descripcion

END
GO




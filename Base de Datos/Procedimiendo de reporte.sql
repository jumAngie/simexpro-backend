

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








SELECT  DISTINCT duca.duca_Id
		,tbDeva.deva_Id
		--Identificacion de la declaracion
		,[duca_No_Correlativo_Referencia]
		,[duca_No_Duca]
		,[deva_FechaAceptacion]
		,aduaRegistro.[adua_Codigo] + ', ' + aduaRegistro.[adua_Nombre] AS duca_AduanaRegistro
		,[adua_DespachoCodigo] + ', ' + [adua_DespachoNombre] AS adua_SalidaNombre
		,[adua_IngresoCodigo] + ', ' + [adua_IngresoNombre] AS adua_IngresoNombre
		,aduaDestino.[adua_Codigo] + ', ' + aduaDestino.[adua_Nombre] AS duca_AduanaDestino


		--Exportador
		,[prov_NumeroIdentificacion]
		,tipoExportador.[iden_Descripcion] AS duca_TipoIdentificacionExportador
		,paisExportador.pais_Codigo AS duca_PaisExportador 
		,[prov_Nombre_Raso]
		,[duca_DomicilioFiscal_Exportador]

		--Importador
		,[impo_NumRegistro]
		,[impo_Nombre_Raso]
		,paisImportador.pais_Codigo AS duca_PaisImportador
		,[duca_DomicilioFiscal_Importador]

		--Declarante
		,[duca_Codigo_Declarante]
		,[duca_Numero_Id_Declarante]
		,[duca_NombreSocial_Declarante]
		,[duca_DomicilioFiscal_Declarante]

		--OTROS
		,regi_Codigo + ', ' + regi_Descripcion AS duca_RegimenAduanero
		,[duca_Modalidad]
		,[duca_Clase]
		,[duca_FechaVencimiento]

		--Otros XD 
		,paisProcedencia.pais_Codigo +', '+ paisProcedencia.pais_Nombre AS duca_PaisProcedencia
		,paisExportacion.pais_Codigo +', '+ paisExportacion.pais_Nombre AS duca_PaisExportacion
		,paisDestino.pais_Codigo +', '+ paisDestino.pais_Nombre AS duca_PaisDestino
		,[duca_Deposito_Aduanero]
		,lugarDesembarque.[emba_Codigo] +', '+ [emba_Descripcion] AS [duca_Lugar_Desembarque]
		,tbDeva.[emba_Codigo] +', '+ tbDeva.[LugarEmbarque] AS [duca_Lugar_Embarque]
		,[duca_Manifiesto]
		,[duca_Titulo]

		--Transportista
		,[duca_Codigo_Transportista]
		,[duca_Transportista_Nombre]
		,modoTranspote.motr_Descripcion AS duca_ModoTransporte

		--Conductor
		,conductor.[cont_NoIdentificacion]
		,conductor.[cont_Licencia]
		,paisConductor.pais_Codigo + ', '+ paisConductor.pais_Nombre AS [pais_Expedicion]
		,ISNULL([cont_Nombre] + ' ' + [cont_Apellido], '----') AS conductorNombres

		--transporte
		,transporte.[tran_IdUnidadTransporte]
		,paisTransporte.pais_Codigo + ', '+ paisTransporte.pais_Nombre AS [pais_Transporte]
		,marcas.[marc_Descripcion]
		,[tran_Chasis]
		,[tran_Remolque]
		,[tran_CantCarga]
		,[tran_NumDispositivoSeguridad]
		,[tran_Equipamiento]
		,[tran_TamanioEquipamiento]
		,[tran_TipoCarga]
		,[tran_IdContenedor]

		,tbDeva.inco_Codigo
		,tbDeva.[deva_ConversionDolares]
		--Valores totales
		--,(SELECT	 SUM([item_ValorTransaccion]) AS [item_ValorTransaccion]
		--			,SUM([item_OtrosGastos]) AS [item_OtrosGastos]
		--			,SUM([item_GastosDeTransporte]) AS [item_GastosDeTransporte]
		--			,SUM([item_Seguro]) AS [item_Seguro]
		--			,SUM([item_ValorAduana]) AS [item_ValorAduana]
		--			,SUM([item_PesoBruto]) AS [item_PesoBruto]
		--			,SUM([item_PesoNeto]) AS [item_PesoNeto]
		--FROM [Adua].[tbItems] items INNER JOIN [Adua].[tbFacturas] fact
		--ON fact.fact_Id = items.fact_Id INNER JOIN [Adua].[tbDeclaraciones_Valor] deva
		--ON deva.deva_Id = fact.deva_Id INNER JOIN [Adua].[tbItemsDEVAPorDuca] dvd
		--ON dvd.deva_Id = deva.deva_Id INNER JOIN [Adua].[tbDuca] duca1
		--ON duca1.duca_Id = dvd.duca_Id
		--WHERE duca1.duca_Id = duca.duca_Id FOR JSON AUTO ) AS ValoresTotales 

		--,(SELECT   [lige_Id]
		--		, [lige_TipoTributo]
		--		, [lige_TotalPorTributo]
		--		, [lige_ModalidadPago]
		--		, [lige_TotalGral]
		--FROM [Adua].[tbLiquidacionGeneral] liquiG
		--WHERE liquiG.duca_Id = duca.duca_Id FOR JSON AUTO) AS LiquidacionGeneral

		--,(SELECT m.* 
		--		FROM 
		--		 (SELECT	ROW_NUMBER() OVER(ORDER BY items.[item_Id] DESC) AS Row
		--				,[item_Cantidad_Bultos]
		--				,[item_ClaseBulto]
		--				,[item_PesoNeto]
		--				,[item_PesoBruto]
		--				,[item_CuotaContingente]
		--				,paisOrigen.pais_Codigo + ', '+ paisOrigen.pais_Nombre AS [pais_Origen]
		--				,[unme_Descripcion]
		--				,[item_Cantidad]
		--				,[item_Acuerdo]
		--				,[aran_Codigo]
		--				,[item_CaracteristicasMercancias]
		--				,[item_CriterioCertificarOrigen]
		--				,[item_ReglasAccesorias]
		--				,[item_ValorTransaccion]
		--				,[item_GastosDeTransporte]
		--				,[item_Seguro]
		--				,[item_OtrosGastos]
		--				,[item_ValorAduana]
		--				,(SELECT * FROM [Adua].[tbLiquidacionPorLinea] lli WHERE lli.item_Id = items.item_Id FOR JSON AUTO) AS liquidacion
		--FROM [Adua].[tbItems] items INNER JOIN [Adua].[tbFacturas] fact
		--ON fact.fact_Id = items.fact_Id INNER JOIN [Adua].[tbDeclaraciones_Valor] deva
		--ON deva.deva_Id = fact.deva_Id INNER JOIN [Adua].[tbItemsDEVAPorDuca] dvd
		--ON dvd.deva_Id = deva.deva_Id INNER JOIN [Adua].[tbDuca] duca1
		--ON duca1.duca_Id = dvd.duca_Id LEFT JOIN [Gral].[tbPaises] paisOrigen
		--ON paisOrigen.pais_Id = [pais_IdOrigenMercancia]  LEFT JOIN [Gral].[tbUnidadMedidas] unidadesMed
		--ON unidadesMed.[unme_Id] = items.[unme_Id] LEFT JOIN [Adua].[tbAranceles] aranceles
		--ON aranceles.[aran_Id] = items.[aran_Id] 
		--WHERE duca1.duca_Id = duca.duca_Id) AS m
  --       FOR JSON AUTO) AS Mercancias 
			

			--, AS Mercancias 
		--	,(SELECT m.* 
		--		FROM 
		--		 (SELECT --* 
		--		[tido_Codigo]
		--		,doso_NumeroDocumento
		--		,[doso_FechaEmision]
		--		,[doso_FechaVencimiento]
		--		,[doso_PaisEmision]
		--		,paisDocumento.pais_Codigo + ', '+ paisDocumento.pais_Nombre AS PaisEmision
		--		,[doso_LineaAplica]
		--		,[doso_EntidadEmitioDocumento]
		--		,[doso_Monto]
		--FROM [Adua].[tbDocumentosDeSoporte] tdc INNER JOIN [Adua].[tbTipoDocumento] tpd
		--ON tpd.[tido_Id] = tdc.[tido_Id]  LEFT JOIN [Gral].[tbPaises] paisDocumento
		--ON paisDocumento.pais_Id =  [doso_PaisEmision] 
		--WHERE tdc.duca_Id = duca.duca_Id) AS m
  --       FOR JSON AUTO) AS Documentos

		--,(SELECT --* 
		--		[tido_Codigo]
		--		,doso_NumeroDocumento
		--		,[doso_FechaEmision]
		--		,[doso_FechaVencimiento]
		--		,[doso_PaisEmision]
		--		,paisDocumento.pais_Codigo + ', '+ paisDocumento.pais_Nombre AS PaisEmision
		--		,[doso_LineaAplica]
		--		,[doso_EntidadEmitioDocumento]
		--		,[doso_Monto]
		--FROM [Adua].[tbDocumentosDeSoporte] tdc INNER JOIN [Adua].[tbTipoDocumento] tpd
		--ON tpd.[tido_Id] = tdc.[tido_Id]  LEFT JOIN [Gral].[tbPaises] paisDocumento
		--ON paisDocumento.pais_Id =  [doso_PaisEmision] 
		--WHERE tdc.duca_Id = duca.duca_Id FOR JSON AUTO   ) AS Documentos


		,[duca_CanalAsignado]

		--,*
FROM [Adua].[tbDuca] duca INNER JOIN [Adua].[tbItemsDEVAPorDuca] dvd
ON dvd.duca_Id = duca.duca_Id INNER JOIN [Adua].[VW_tbDeclaraciones_ValorCompleto] tbDeva
ON tbDeva.deva_Id = dvd.deva_Id LEFT JOIN [Adua].[tbAduanas] aduaRegistro
ON duca.[duca_AduanaRegistro] = aduaRegistro.[adua_Id] LEFT JOIN [Adua].[tbAduanas] aduaDestino
ON duca.[duca_AduanaDestino] = aduaDestino.[adua_Id] LEFT JOIN [Adua].[tbTiposIdentificacion] tipoExportador
ON tipoExportador.[iden_Id] = duca.[duca_Tipo_Iden_Exportador] LEFT JOIN [Gral].[tbPaises] paisExportador
ON paisExportador.pais_Id = [duca_Pais_Emision_Exportador] LEFT JOIN [Gral].[tbPaises] paisImportador
ON paisImportador.pais_Id = [duca_Pais_Emision_Importador] LEFT JOIN [Adua].[tbRegimenesAduaneros] reginAduana
ON reginAduana.regi_Id = [duca_Regimen_Aduanero] LEFT JOIN [Gral].[tbPaises] paisProcedencia
ON paisProcedencia.pais_Id =  [duca_Pais_Procedencia] LEFT JOIN [Gral].[tbPaises] paisExportacion
ON paisExportacion.pais_Id =  [duca_Pais_Exportacion] LEFT JOIN [Gral].[tbPaises] paisDestino
ON paisDestino.pais_Id =  [duca_Pais_Destino] LEFT JOIN [Adua].[tbLugaresEmbarque] lugarDesembarque
ON lugarDesembarque.emba_Id = [duca_Lugar_Desembarque] LEFT JOIN [Adua].[tbModoTransporte] modoTranspote
ON modoTranspote.motr_Id = duca.[motr_Id] LEFT JOIN [Adua].[tbConductor] conductor
ON conductor.[cont_Id] = duca.[duca_Conductor_Id] LEFT JOIN [Gral].[tbPaises] paisConductor
ON paisConductor.pais_Id =  conductor.[pais_IdExpedicion] LEFT JOIN [Adua].[tbTransporte] transporte
ON transporte.[tran_Id] =  conductor.[tran_Id] LEFT JOIN [Gral].[tbPaises] paisTransporte
ON paisTransporte.pais_Id =  transporte.[pais_Id] LEFT JOIN [Adua].[tbMarcas] marcas
ON marcas.[marc_Id] =  transporte.[marca_Id] 




------
--VAMOS CON EL OTRO 
GO
CREATE OR ALTER PROCEDURE adua.UDP_Reporte_Importaciones
@fechaInicio DATE,
@fechaFin	 DATE
AS 
BEGIN 
SELECT *
		,(SELECT TOP(1)* 
		FROM [Adua].[VW_tbDeclaraciones_ValorCompleto]
		WHERE deva_Id IN (SELECT deva_Id FROM [Adua].[tbItemsDEVAPorDuca] dvd 
		WHERE dvd.duca_Id = duca.duca_Id) FOR JSON AUTO) AS detalles
		,(SELECT TOP(1)	 SUM([item_ValorTransaccion]) AS [item_ValorTransaccion]
					,SUM([item_OtrosGastos]) AS [item_OtrosGastos]
					,SUM([item_GastosDeTransporte]) AS [item_GastosDeTransporte]
					,SUM([item_Seguro]) AS [item_Seguro]
					,SUM([item_ValorAduana]) AS [item_ValorAduana]
					,SUM([item_PesoBruto]) AS [item_PesoBruto]
					,SUM([item_PesoNeto]) AS [item_PesoNeto]
		FROM [Adua].[tbItems] items INNER JOIN [Adua].[tbFacturas] fact
		ON fact.fact_Id = items.fact_Id INNER JOIN [Adua].[tbDeclaraciones_Valor] deva
		ON deva.deva_Id = fact.deva_Id INNER JOIN [Adua].[tbItemsDEVAPorDuca] dvd
		ON dvd.deva_Id = deva.deva_Id INNER JOIN [Adua].[tbDuca] duca1
		ON duca1.duca_Id = dvd.duca_Id
		WHERE duca1.duca_Id = duca.duca_Id FOR JSON AUTO ) AS ValoresTotales 
		,(SELECT TOP(1)[lige_TotalGral]
		FROM [Adua].[tbLiquidacionGeneral] liquiG
		WHERE liquiG.duca_Id = duca.duca_Id ) AS Impuestos
FROM [Adua].[tbDuca] duca 
WHERE duca_Id IN (SELECT duca_Id FROM [Adua].[tbItemsDEVAPorDuca])  AND (duca.duca_fechaCreacion >= @fechaInicio AND duca.duca_fechaCreacion <= @fechaFin )
END
GO


CREATE OR ALTER PROCEDURE adua.UDP_Reporte_DevasPendientes
@fechaInicio DATE,
@fechaFin	 DATE
AS
BEGIN
SELECT * 
FROM [Adua].[VW_tbDeclaraciones_ValorCompleto]
WHERE deva_Id NOT IN (SELECT deva_Id FROM [Adua].[tbItemsDEVAPorDuca]) AND (deva_fechaCreacion >= @fechaInicio AND deva_fechaCreacion <= @fechaFin )
END

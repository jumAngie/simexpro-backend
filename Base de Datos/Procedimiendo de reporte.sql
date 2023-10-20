

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



GO


CREATE OR ALTER PROCEDURE Prod.UDP_Reporte_PedidosCliente --1
@clie_Id INT
AS
BEGIN 

	
	SELECT	
			PO.orco_Codigo AS modu_Nombre
			,(SELECT COUNT (*) FROM [Prod].[tbOrdenCompra] PO1 WHERE PO1.orco_IdCliente = PO.orco_IdCliente AND PO1.orco_EstadoOrdenCompra = 'T') AS PedidosTerminados
			,(SELECT COUNT (*) FROM [Prod].[tbOrdenCompra] PO1 WHERE PO1.orco_IdCliente = PO.orco_IdCliente AND PO1.orco_EstadoOrdenCompra = 'P') AS PedidosPendientes
			,(SELECT COUNT (*) FROM [Prod].[tbOrdenCompra] PO1 WHERE PO1.orco_IdCliente = PO.orco_IdCliente AND PO1.orco_EstadoOrdenCompra = 'C') AS PedidosCurso
			,clie_RTN
			,clie_Nombre_Contacto
			,clie_Numero_Contacto
			,clie_Nombre_O_Razon_Social
			,clie_Correo_Electronico
			--detalles
			,(
				SELECT
				ISNULL(estil.[esti_Descripcion], 'N/D') AS esti_Descripcion,
				ISNULL(OCD.code_CantidadPrenda, 0) AS code_CantidadPrenda,
				OCD.code_Sexo,
				ISNULL(talla.[tall_Codigo], 'N/D') AS tall_Nombre,
				ISNULL(color.[colr_Nombre], 'N/D') AS colr_Nombre,
				ISNULL(color.[colr_CodigoHtml], 'N/D') AS proc_Descripcion

				,ISNULL((SELECT	 
								SUM(reca_Cantidad-reca_Scrap) 
				FROM [Prod].[tbRevisionDeCalidad]				RVS  
				INNER JOIN [Prod].[tbOrde_Ensa_Acab_Etiq]		OER		ON OER.ensa_Id = RVS.ensa_Id 
				INNER JOIN [Prod].[tbModulos]					MDU		ON OER.modu_Id = MDU.modu_Id 
				INNER JOIN [Prod].[tbOrdenCompraDetalles]		OD		ON	PO.orco_Id = OD.orco_Id 
				WHERE MDU.proc_Id >= 6 AND OER.[code_Id] = OD.code_Id),0) AS CantidadCompletada

				,ISNULL((SELECT 
								(SUM(reca_Cantidad-reca_Scrap)  / ISNULL(OCD.code_CantidadPrenda,1)) * 100
				FROM [Prod].[tbRevisionDeCalidad]				RVS  
				INNER JOIN [Prod].[tbOrde_Ensa_Acab_Etiq]		OER		ON	OER.ensa_Id = RVS.ensa_Id 
				INNER JOIN [Prod].[tbOrdenCompraDetalles]		OD		ON	PO.orco_Id	= OD.orco_Id 
				INNER JOIN [Prod].[tbModulos]					MDU		ON	OER.modu_Id = MDU.modu_Id 
				WHERE MDU.proc_Id >= 6 AND OER.[code_Id] = OD.code_Id),0) AS PorcentajeCompleado


			FROM [Prod].[tbOrdenCompraDetalles] OCD
			INNER JOIN [Prod].[tbTallas] talla ON talla.tall_Id = OCD.tall_Id
			INNER JOIN [Prod].[tbColores] color ON color.colr_Id = OCD.colr_Id
			INNER JOIN [Prod].[tbEstilos] estil ON estil.esti_Id = OCD.esti_Id
			WHERE OCD.orco_Id = PO.orco_Id
			FOR JSON PATH
			) AS detalles
	FROM [Prod].[tbOrdenCompra] PO	INNER JOIN [Prod].[tbClientes]	Clie	ON	PO.orco_IdCliente	= Clie.clie_Id 
	WHERE PO.orco_IdCliente = @clie_Id
	
END


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








--SELECT  DISTINCT duca.duca_Id
--		,tbDeva.deva_Id
--		--Identificacion de la declaracion
--		,[duca_No_Correlativo_Referencia]
--		,[duca_No_Duca]
--		,[deva_FechaAceptacion]
--		,aduaRegistro.[adua_Codigo] + ', ' + aduaRegistro.[adua_Nombre] AS duca_AduanaRegistro
--		,[adua_DespachoCodigo] + ', ' + [adua_DespachoNombre] AS adua_SalidaNombre
--		,[adua_IngresoCodigo] + ', ' + [adua_IngresoNombre] AS adua_IngresoNombre
--		,aduaDestino.[adua_Codigo] + ', ' + aduaDestino.[adua_Nombre] AS duca_AduanaDestino


--		--Exportador
--		,[prov_NumeroIdentificacion]
--		,tipoExportador.[iden_Descripcion] AS duca_TipoIdentificacionExportador
--		,paisExportador.pais_Codigo AS duca_PaisExportador 
--		,[prov_Nombre_Raso]
--		,[duca_DomicilioFiscal_Exportador]

--		--Importador
--		,[impo_NumRegistro]
--		,[impo_Nombre_Raso]
--		,paisImportador.pais_Codigo AS duca_PaisImportador
--		,[duca_DomicilioFiscal_Importador]

--		--Declarante
--		,[duca_Codigo_Declarante]
--		,[duca_Numero_Id_Declarante]
--		,[duca_NombreSocial_Declarante]
--		,[duca_DomicilioFiscal_Declarante]

--		--OTROS
--		,regi_Codigo + ', ' + regi_Descripcion AS duca_RegimenAduanero
--		,[duca_Modalidad]
--		,[duca_Clase]
--		,[duca_FechaVencimiento]

--		--Otros XD 
--		,paisProcedencia.pais_Codigo +', '+ paisProcedencia.pais_Nombre AS duca_PaisProcedencia
--		,paisExportacion.pais_Codigo +', '+ paisExportacion.pais_Nombre AS duca_PaisExportacion
--		,paisDestino.pais_Codigo +', '+ paisDestino.pais_Nombre AS duca_PaisDestino
--		,[duca_Deposito_Aduanero]
--		,lugarDesembarque.[emba_Codigo] +', '+ [emba_Descripcion] AS [duca_Lugar_Desembarque]
--		,tbDeva.[emba_Codigo] +', '+ tbDeva.[LugarEmbarque] AS [duca_Lugar_Embarque]
--		,[duca_Manifiesto]
--		,[duca_Titulo]

--		--Transportista
--		,[duca_Codigo_Transportista]
--		,[duca_Transportista_Nombre]
--		,modoTranspote.motr_Descripcion AS duca_ModoTransporte

--		--Conductor
--		,conductor.[cont_NoIdentificacion]
--		,conductor.[cont_Licencia]
--		,paisConductor.pais_Codigo + ', '+ paisConductor.pais_Nombre AS [pais_Expedicion]
--		,ISNULL([cont_Nombre] + ' ' + [cont_Apellido], '----') AS conductorNombres

--		--transporte
--		,transporte.[tran_IdUnidadTransporte]
--		,paisTransporte.pais_Codigo + ', '+ paisTransporte.pais_Nombre AS [pais_Transporte]
--		,marcas.[marc_Descripcion]
--		,[tran_Chasis]
--		,[tran_Remolque]
--		,[tran_CantCarga]
--		,[tran_NumDispositivoSeguridad]
--		,[tran_Equipamiento]
--		,[tran_TamanioEquipamiento]
--		,[tran_TipoCarga]
--		,[tran_IdContenedor]

--		,tbDeva.inco_Codigo
--		,tbDeva.[deva_ConversionDolares]
--		--Valores totales
--		--,(SELECT	 SUM([item_ValorTransaccion]) AS [item_ValorTransaccion]
--		--			,SUM([item_OtrosGastos]) AS [item_OtrosGastos]
--		--			,SUM([item_GastosDeTransporte]) AS [item_GastosDeTransporte]
--		--			,SUM([item_Seguro]) AS [item_Seguro]
--		--			,SUM([item_ValorAduana]) AS [item_ValorAduana]
--		--			,SUM([item_PesoBruto]) AS [item_PesoBruto]
--		--			,SUM([item_PesoNeto]) AS [item_PesoNeto]
--		--FROM [Adua].[tbItems] items INNER JOIN [Adua].[tbFacturas] fact
--		--ON fact.fact_Id = items.fact_Id INNER JOIN [Adua].[tbDeclaraciones_Valor] deva
--		--ON deva.deva_Id = fact.deva_Id INNER JOIN [Adua].[tbItemsDEVAPorDuca] dvd
--		--ON dvd.deva_Id = deva.deva_Id INNER JOIN [Adua].[tbDuca] duca1
--		--ON duca1.duca_Id = dvd.duca_Id
--		--WHERE duca1.duca_Id = duca.duca_Id FOR JSON AUTO ) AS ValoresTotales 

--		--,(SELECT   [lige_Id]
--		--		, [lige_TipoTributo]
--		--		, [lige_TotalPorTributo]
--		--		, [lige_ModalidadPago]
--		--		, [lige_TotalGral]
--		--FROM [Adua].[tbLiquidacionGeneral] liquiG
--		--WHERE liquiG.duca_Id = duca.duca_Id FOR JSON AUTO) AS LiquidacionGeneral

--		--,(SELECT m.* 
--		--		FROM 
--		--		 (SELECT	ROW_NUMBER() OVER(ORDER BY items.[item_Id] DESC) AS Row
--		--				,[item_Cantidad_Bultos]
--		--				,[item_ClaseBulto]
--		--				,[item_PesoNeto]
--		--				,[item_PesoBruto]
--		--				,[item_CuotaContingente]
--		--				,paisOrigen.pais_Codigo + ', '+ paisOrigen.pais_Nombre AS [pais_Origen]
--		--				,[unme_Descripcion]
--		--				,[item_Cantidad]
--		--				,[item_Acuerdo]
--		--				,[aran_Codigo]
--		--				,[item_CaracteristicasMercancias]
--		--				,[item_CriterioCertificarOrigen]
--		--				,[item_ReglasAccesorias]
--		--				,[item_ValorTransaccion]
--		--				,[item_GastosDeTransporte]
--		--				,[item_Seguro]
--		--				,[item_OtrosGastos]
--		--				,[item_ValorAduana]
--		--				,(SELECT * FROM [Adua].[tbLiquidacionPorLinea] lli WHERE lli.item_Id = items.item_Id FOR JSON AUTO) AS liquidacion
--		--FROM [Adua].[tbItems] items INNER JOIN [Adua].[tbFacturas] fact
--		--ON fact.fact_Id = items.fact_Id INNER JOIN [Adua].[tbDeclaraciones_Valor] deva
--		--ON deva.deva_Id = fact.deva_Id INNER JOIN [Adua].[tbItemsDEVAPorDuca] dvd
--		--ON dvd.deva_Id = deva.deva_Id INNER JOIN [Adua].[tbDuca] duca1
--		--ON duca1.duca_Id = dvd.duca_Id LEFT JOIN [Gral].[tbPaises] paisOrigen
--		--ON paisOrigen.pais_Id = [pais_IdOrigenMercancia]  LEFT JOIN [Gral].[tbUnidadMedidas] unidadesMed
--		--ON unidadesMed.[unme_Id] = items.[unme_Id] LEFT JOIN [Adua].[tbAranceles] aranceles
--		--ON aranceles.[aran_Id] = items.[aran_Id] 
--		--WHERE duca1.duca_Id = duca.duca_Id) AS m
--  --       FOR JSON AUTO) AS Mercancias 
			

--			--, AS Mercancias 
--		--	,(SELECT m.* 
--		--		FROM 
--		--		 (SELECT --* 
--		--		[tido_Codigo]
--		--		,doso_NumeroDocumento
--		--		,[doso_FechaEmision]
--		--		,[doso_FechaVencimiento]
--		--		,[doso_PaisEmision]
--		--		,paisDocumento.pais_Codigo + ', '+ paisDocumento.pais_Nombre AS PaisEmision
--		--		,[doso_LineaAplica]
--		--		,[doso_EntidadEmitioDocumento]
--		--		,[doso_Monto]
--		--FROM [Adua].[tbDocumentosDeSoporte] tdc INNER JOIN [Adua].[tbTipoDocumento] tpd
--		--ON tpd.[tido_Id] = tdc.[tido_Id]  LEFT JOIN [Gral].[tbPaises] paisDocumento
--		--ON paisDocumento.pais_Id =  [doso_PaisEmision] 
--		--WHERE tdc.duca_Id = duca.duca_Id) AS m
--  --       FOR JSON AUTO) AS Documentos

--		--,(SELECT --* 
--		--		[tido_Codigo]
--		--		,doso_NumeroDocumento
--		--		,[doso_FechaEmision]
--		--		,[doso_FechaVencimiento]
--		--		,[doso_PaisEmision]
--		--		,paisDocumento.pais_Codigo + ', '+ paisDocumento.pais_Nombre AS PaisEmision
--		--		,[doso_LineaAplica]
--		--		,[doso_EntidadEmitioDocumento]
--		--		,[doso_Monto]
--		--FROM [Adua].[tbDocumentosDeSoporte] tdc INNER JOIN [Adua].[tbTipoDocumento] tpd
--		--ON tpd.[tido_Id] = tdc.[tido_Id]  LEFT JOIN [Gral].[tbPaises] paisDocumento
--		--ON paisDocumento.pais_Id =  [doso_PaisEmision] 
--		--WHERE tdc.duca_Id = duca.duca_Id FOR JSON AUTO   ) AS Documentos


--		,[duca_CanalAsignado]

--		--,*
--FROM [Adua].[tbDuca] duca INNER JOIN [Adua].[tbItemsDEVAPorDuca] dvd
--ON dvd.duca_Id = duca.duca_Id INNER JOIN [Adua].[VW_tbDeclaraciones_ValorCompleto] tbDeva
--ON tbDeva.deva_Id = dvd.deva_Id LEFT JOIN [Adua].[tbAduanas] aduaRegistro
--ON duca.[duca_AduanaRegistro] = aduaRegistro.[adua_Id] LEFT JOIN [Adua].[tbAduanas] aduaDestino
--ON duca.[duca_AduanaDestino] = aduaDestino.[adua_Id] LEFT JOIN [Adua].[tbTiposIdentificacion] tipoExportador
--ON tipoExportador.[iden_Id] = duca.[duca_Tipo_Iden_Exportador] LEFT JOIN [Gral].[tbPaises] paisExportador
--ON paisExportador.pais_Id = [duca_Pais_Emision_Exportador] LEFT JOIN [Gral].[tbPaises] paisImportador
--ON paisImportador.pais_Id = [duca_Pais_Emision_Importador] LEFT JOIN [Adua].[tbRegimenesAduaneros] reginAduana
--ON reginAduana.regi_Id = [duca_Regimen_Aduanero] LEFT JOIN [Gral].[tbPaises] paisProcedencia
--ON paisProcedencia.pais_Id =  [duca_Pais_Procedencia] LEFT JOIN [Gral].[tbPaises] paisExportacion
--ON paisExportacion.pais_Id =  [duca_Pais_Exportacion] LEFT JOIN [Gral].[tbPaises] paisDestino
--ON paisDestino.pais_Id =  [duca_Pais_Destino] LEFT JOIN [Adua].[tbLugaresEmbarque] lugarDesembarque
--ON lugarDesembarque.emba_Id = [duca_Lugar_Desembarque] LEFT JOIN [Adua].[tbModoTransporte] modoTranspote
--ON modoTranspote.motr_Id = duca.[motr_Id] LEFT JOIN [Adua].[tbConductor] conductor
--ON conductor.[cont_Id] = duca.[duca_Conductor_Id] LEFT JOIN [Gral].[tbPaises] paisConductor
--ON paisConductor.pais_Id =  conductor.[pais_IdExpedicion] LEFT JOIN [Adua].[tbTransporte] transporte
--ON transporte.[tran_Id] =  conductor.[tran_Id] LEFT JOIN [Gral].[tbPaises] paisTransporte
--ON paisTransporte.pais_Id =  transporte.[pais_Id] LEFT JOIN [Adua].[tbMarcas] marcas
--ON marcas.[marc_Id] =  transporte.[marca_Id] 




------
--VAMOS CON EL OTRO 
GO
CREATE OR ALTER PROCEDURE adua.UDP_Reporte_Importaciones '2022-09-25','2023-10-25'
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


GO 
-------------------------------------------------------------

CREATE OR ALTER PROCEDURE prod.UDP_Reporte_ProduccionAreas
@fechaInicio DATE,
@fechaFin DATE,
@tipa_Id INT
AS
BEGIN
SELECT	area.tipa_area
		,SUM(rdet_TotalDia) AS TotalPeriodo
		,SUM(rdet_TotalDanado) AS TotalDanado
		,SUM(rdet_TotalDia) - SUM(rdet_TotalDanado) AS TotalExitoso
		,AVG(rdet_TotalDia) AS PromedioDia
		,AVG(rdet_TotalDanado) AS PromedioDanado
		,AVG(rdet_TotalDia - rdet_TotalDanado) AS PromedioExitoso
		,(SUM(rdet_TotalDanado) * 100) / CAST (SUM(rdet_TotalDia) AS DECIMAL(18,2)) AS PorcentajeDanado
		,100 - ((SUM(rdet_TotalDanado) * 100) / CAST (SUM(rdet_TotalDia) AS DECIMAL(18,2))) AS PorcentajeBueno
		,(SELECT m.*
			FROM 
			(SELECT  rdd.rdet_Id
					 ,rdd.remo_Id
					 ,rdd.rdet_TotalDia
					 ,rdd.rdet_TotalDanado
					 ,ensa2.code_Id
					 ,code2.esti_Id
					 ,esti.esti_Descripcion
					 ,code2.code_Sexo
					 ,code_Valor
					 ,code2.code_Impuesto
					 ,remd2.remo_Fecha
			  FROM prod.tbReporteModuloDiaDetalle rdd 
			  LEFT JOIN prod.tbReporteModuloDia remd2 ON remd2.remo_Id = rdd.remo_Id
			  LEFT JOIN prod.tbModulos modu2 ON remd2.modu_Id = modu2.modu_Id 
			  LEFT JOIN Prod.tbOrde_Ensa_Acab_Etiq ensa2 ON ensa2.ensa_Id = rdd.ensa_Id
			  LEFT JOIN Prod.tbOrdenCompraDetalles code2 ON code2.code_Id = ensa2.code_Id
			  LEFT JOIN [Prod].[tbEstilos] esti ON esti.esti_Id = code2.esti_Id
			  WHERE rdd.remo_Id IN (
								SELECT remo_Id FROM Prod.tbArea area1 INNER JOIN [Prod].tbProcesos prox1
								ON prox1.proc_Id = area1.proc_Id INNER JOIN prod.tbModulos modu1
								ON modu1.proc_Id = prox1.proc_Id INNER JOIN prod.tbReporteModuloDia remd1
								ON remd1.modu_Id = modu1.modu_Id WHERE area1.tipa_Id = area.tipa_Id)			
		)AS m FOR JSON AUTO)
		
		 AS Detalles
FROM Prod.tbArea area INNER JOIN [Prod].tbProcesos prox
ON prox.proc_Id = area.proc_Id INNER JOIN prod.tbModulos modu
ON modu.proc_Id = prox.proc_Id INNER JOIN prod.tbReporteModuloDia remd
ON remd.modu_Id = modu.modu_Id INNER JOIN prod.tbReporteModuloDiaDetalle rmdd
ON rmdd.remo_Id = remd.remo_Id
WHERE (remd.remo_Fecha BETWEEN @fechaInicio AND @fechaFin) AND (area.tipa_Id = @tipa_Id OR @tipa_Id = 0)
GROUP BY area.tipa_area, area.tipa_Id
END

GO


CREATE OR ALTER PROCEDURE Prod.UDP_Reportes_MateriasDePO --168
@orco_Id INT
AS
BEGIN
SELECT  ordenCompra.orco_Id
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


		,lote.lote_Id
		,lote.lote_CodigoLote
		,lote.lote_Observaciones
		,mate.mate_Descripcion
		,subc_Descripcion
		,cate_Descripcion
		,ppdd.ppde_Cantidad
		,UnidadesMedida.unme_Descripcion
		,areas.tipa_area
		,color.colr_Nombre
		,color.colr_Codigo
		,color.colr_CodigoHtml


		,prov_NombreCompania
		,prov_CorreoElectronico
		,prov_Telefono
		,pvin_Codigo
		,pvin_Nombre
		,pais_Codigo
		,pais_Nombre
		,pdod.peor_FechaEntrada


		,esti_Descripcion
		,code.code_Sexo
		,tall.tall_Codigo
		,tall.tall_Nombre

  FROM [Prod].[tbOrde_Ensa_Acab_Etiq] ensa 
		LEFT JOIN [Prod].[tbOrdenCompraDetalles] code ON code.code_Id = ensa.code_Id 
		LEFT JOIN Prod.tbOrdenCompra ordenCompra ON ordenCompra.orco_Id = code.orco_Id
		INNER JOIN  Prod.tbClientes	cliente	ON ordenCompra.orco_IdCliente  = cliente.clie_Id
		INNER JOIN  Prod.tbTipoEmbalaje	tipoEmbajale ON ordenCompra.orco_IdEmbalaje = tipoEmbajale.tiem_Id
		INNER JOIN	Adua.tbFormasdePago	fomapago ON ordenCompra.orco_MetodoPago = fomapago.fopa_Id
		LEFT JOIN [Prod].[tbPedidosProduccion] prod ON prod.ppro_Id = ensa.ppro_Id 
		INNER JOIN [Prod].[tbPedidosProduccionDetalles] ppdd ON ppdd.ppro_Id = prod.ppro_Id 
		INNER JOIN [Prod].[tbLotes] lote ON lote.lote_Id = ppdd.lote_Id
		INNER JOIN [Prod].[tbMateriales] mate ON mate.mate_Id = lote.mate_Id
		LEFT JOIN Prod.tbArea AS areas ON lote.tipa_id = areas.tipa_id
		LEFT JOIN Prod.tbColores AS color ON lote.colr_Id = color.colr_Id
		LEFT JOIN Gral.tbUnidadMedidas AS UnidadesMedida ON lote.unme_Id = UnidadesMedida.unme_Id
		LEFT JOIN [Prod].[tbSubcategoria] subc	ON subc.subc_Id = mate.subc_Id
		LEFT JOIN [Prod].[tbCategoria] cate	ON cate.cate_Id = subc.cate_Id 
		LEFT JOIN [Prod].[tbPedidosOrdenDetalle] pord ON pord.prod_Id = lote.prod_Id
		INNER JOIN [Prod].[tbPedidosOrden] pdod ON pdod.peor_Id = pord.pedi_Id
		LEFT JOIN [Gral].[tbProveedores] prov ON pdod.prov_Id = prov.prov_Id
		LEFT JOIN [Gral].[tbProvincias] pvin ON pvin.pvin_Id = pdod.prov_Id
		LEFT JOIN [Gral].[tbPaises] pais ON pais.pais_Id = pvin.pais_Id 
		LEFT JOIN [Prod].[tbEstilos] esti ON esti.esti_Id = code.esti_Id
		LEFT JOIN [Prod].[tbTallas] tall ON code.tall_Id = tall.tall_Id
  WHERE ordenCompra.orco_Id = @orco_Id 
  END 


  GO 

  CREATE OR ALTER PROCEDURE prod.UDP_Reportes_MaterialesIngreso
@fechaInicio DATE,
@fechaFin DATE
AS 
BEGIN
SELECT	peor_Id, 
		po.peor_Codigo,
		prov.prov_Id, 
		prov.prov_NombreCompania,
		prov.prov_NombreContacto,
		po.duca_Id, 
		ciud.ciud_Id,
		ciud.ciud_Nombre,
		pais.pais_Codigo,
		pais.pais_Id,
		pais.pais_Nombre,
		pvin.pvin_Codigo,
		pvin.pvin_Id,
		pvin.pvin_Nombre,
		po.peor_DireccionExacta,
		peor_FechaEntrada, 
		peor_Obsevaciones, 
		peor_DadoCliente, 
	    prod_Id,
		pedi_Id,
		pod.mate_Id,
		mate_Descripcion,
		prod_Cantidad,
		prod_Precio

FROM	Prod.tbPedidosOrden po
		INNER JOIN  Gral.tbProveedores				prov			    ON po.prov_Id   = prov.prov_Id
		LEFT JOIN   Prod.tbPedidosOrdenDetalle		pod					ON po.peor_Id = pod.pedi_Id
		LEFT JOIN   Prod.tbMateriales				mates				ON pod.mate_Id = mates.mate_Id
		LEFT JOIN   gral.tbCiudades					ciud			    ON po.ciud_Id = ciud.ciud_Id
		LEFT JOIN   Gral.tbProvincias				pvin				ON pvin.pvin_Id = ciud.pvin_Id
		LEFT JOIN   Gral.tbPaises					pais				ON pvin.pais_Id = pais.pais_Id
		LEFT JOIN   Adua.tbDuca						duca			    ON po.duca_Id = duca.duca_Id
		LEFT JOIN   Acce.tbUsuarios					crea				ON crea.usua_Id = po.usua_UsuarioCreacion 
		LEFT JOIN   Acce.tbUsuarios					modi				ON modi.usua_Id = po.usua_UsuarioModificacion 
WHERE (po.peor_FechaEntrada BETWEEN @fechaInicio AND @fechaFin)
END

GO

CREATE OR  ALTER PROCEDURE [Prod].[UDP_ReporteSeguimientoProcesosPO] 
@orco_Codigo NVARCHAR(100)
AS
BEGIN

SELECT DISTINCT
     orco.orco_Id,
	 orco.orco_Codigo,
	 clie.clie_Nombre_O_Razon_Social,
	 orco.orco_EstadoFinalizado,
	 orco.orco_EstadoOrdenCompra,

	 
	 orde.code_Id,
	 proceActual.proc_Descripcion AS proc_Actual,
	 proceComienza.proc_Descripcion as proc_Comienza,
	 orde.code_CantidadPrenda,
	 estilo.esti_Descripcion,
	 talla.tall_Nombre,
	 orde.code_Sexo,
	 colores.colr_Nombre,

	 todo.ppro_Id AS OrdenProduccion,

	 faex.faex_Id,
	 faex.faex_Fecha AS FechaExportacion, 
	 fade.fede_Cantidad AS CantidadExportada, 
	 fade.fede_Cajas, 
	 fade.fede_TotalDetalle,
	 
	 (
		SELECT p.* 
					FROM 
				(  SELECT	 pros.proc_Descripcion,	
				             modu2.modu_Nombre ,    
							   
				
				CASE
				   WHEN asor.ensa_FechaInicio IS NULL THEN 'NADA'
				ELSE CONVERT(NVARCHAR, asor.ensa_FechaInicio, 120)
			    END AS asor_FechaInicio,
			    CASE
				   WHEN asor.ensa_FechaLimite IS NULL THEN 'NADA'
				ELSE CONVERT(NVARCHAR, asor.ensa_FechaLimite, 120)
			   END AS asor_FechaLimite,
			    CASE
				   WHEN asor.ensa_Cantidad IS NULL THEN 'NADA'
				ELSE CONVERT(NVARCHAR, asor.ensa_Cantidad, 120)
			   END AS asor_Cantidad,
			  
			  CASE
				   WHEN empl.empl_Nombres + ' '+ empl_Apellidos IS NULL THEN 'Nada'
				ELSE CONVERT(NVARCHAR, (empl.empl_Nombres + ' '+ empl_Apellidos), 120)
			   END AS Empleado

			  
				             
										
					FROM	Prod.tbOrdenCompraDetalles ordenCompraDetalle
						LEFT JOIN	Prod.tbProcesoPorOrdenCompraDetalle	procesos ON	ordenCompraDetalle.code_Id = procesos.code_Id
						LEFT JOIN	Prod.tbProcesos	pros                         ON	pros.proc_Id = procesos.proc_Id		
							
						LEFT JOIN   Prod.tbOrde_Ensa_Acab_Etiq oeae              ON oeae.code_Id = ordenCompraDetalle.code_Id 

						LEFT JOIN   Prod.tbModulos modu                          ON modu.modu_Id = oeae.modu_Id

					    LEFT JOIN   Prod.tbOrde_Ensa_Acab_Etiq asor              ON asor.code_Id = ordenCompraDetalle.code_Id AND modu.proc_Id = pros.proc_Id
					
					    LEFT JOIN   Gral.tbEmpleados empl                        ON asor.empl_Id = empl.empl_Id
					   
					   LEFT JOIN   Prod.tbModulos modu2                          ON modu2.modu_Id = asor.modu_Id
						

						WHERE       orde.code_Id = procesos.code_Id) AS p
				FOR JSON PATH ) AS SeguimientoProcesos

			
			
FROM 
Prod.tbOrdenCompraDetalles orde
INNER JOIN Prod.tbOrdenCompra orco                       ON orco.orco_Id        = orde.orco_Id
INNER JOIN Prod.tbProcesos	proceActual                  ON	proceActual.proc_Id = orde.proc_IdActual	
INNER JOIN Prod.tbProcesos	proceComienza                ON	proceComienza.proc_Id = orde.proc_IdComienza	
INNER JOIN Prod.tbClientes clie                          ON orco.orco_IdCliente = clie.clie_Id 
INNER JOIN Prod.tbEstilos estilo			             ON	orde.esti_Id		= estilo.esti_Id
INNER JOIN Prod.tbTallas	talla	                     ON	orde.tall_Id		= talla.tall_Id
INNER JOIN Prod.tbColores	colores	                     ON	orde.colr_Id	    = colores.colr_Id
LEFT  JOIN Prod.tbOrde_Ensa_Acab_Etiq todo               ON todo.code_Id        = orde.code_Id
LEFT  JOIN Prod.tbFacturasExportacionDetalles fade       ON orde.code_Id        = fade.code_Id
LEFT  JOIN Prod.tbFacturasExportacion faex               ON fade.faex_Id        = faex.faex_Id 
WHERE  orco.orco_Codigo = @orco_Codigo
END


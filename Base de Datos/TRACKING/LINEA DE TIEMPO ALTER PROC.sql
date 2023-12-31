/****** Object:  StoredProcedure [Prod].[UDP_tbOrdenCompra_ObtenerPorId_Para_LineaTiempo]    Script Date: 11 sep. 2023 00:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-----------------PROCEDIMIENTOS ALMACENADOS Y VISTAS MÓDULO PRODUCCION

-----------------------------------------------/UDPS Para orden de compra---------------------------------------------

CREATE OR ALTER   PROCEDURE Prod.UDP_tbOrdenCompra_ObtenerPorId_Para_LineaTiempo
(
	@orco_Codigo		nvarchar(100)
)	
AS
BEGIN
	 SELECT ordenCompra.orco_Id,
			ordenCompra.orco_Codigo,
		    --Informacion del cliente
		    ordenCompra.orco_IdCliente,
			cliente.clie_Nombre_O_Razon_Social,
			cliente.clie_Direccion,
			cliente.clie_RTN,
			cliente.clie_Nombre_Contacto,
			cliente.clie_Numero_Contacto,
			cliente.clie_Correo_Electronico,
			cliente.clie_FAX,
			
			ordenCompra.orco_FechaEmision,
			ordenCompra.orco_FechaLimite,
			ordenCompra.orco_MetodoPago,
			formasPago.fopa_Descripcion,
			ordenCompra.orco_Materiales,

			--Informacion del Embalaje
			ordenCompra.orco_IdEmbalaje,
			tipoEmbajale.tiem_Descripcion,

			ordenCompra.orco_EstadoOrdenCompra,
			ordenCompra.orco_DireccionEntrega,
			ordenCompra.usua_UsuarioCreacion,
			usuarioCreacion.usua_Nombre				AS usuarioCreacionNombre,
			ordenCompra.orco_FechaCreacion,
			ordenCompra.usua_UsuarioModificacion,
			usuarioModificacion.usua_Nombre			AS usuarioModificacionNombre,
			ordenCompra.orco_FechaModificacion,
			ordenCompra.orco_Estado
	   FROM Prod.tbOrdenCompra		ordenCompra
 INNER JOIN Prod.tbClientes			cliente					ON ordenCompra.orco_IdCliente				= cliente.clie_Id
  LEFT JOIN Adua.tbFormasdePago     formasPago				ON ordenCompra.orco_MetodoPago				= formasPago.fopa_Id
 INNER JOIN Prod.tbTipoEmbalaje		tipoEmbajale			ON ordenCompra.orco_IdEmbalaje				= tipoEmbajale.tiem_Id
 INNER JOIN Acce.tbUsuarios			usuarioCreacion			ON ordenCompra.usua_UsuarioCreacion			= usuarioCreacion.usua_Id
  LEFT JOIN Acce.tbUsuarios			usuarioModificacion		ON ordenCompra.usua_UsuarioModificacion		= usuarioModificacion.usua_Id
	  WHERE orco_Codigo = @orco_Codigo
END

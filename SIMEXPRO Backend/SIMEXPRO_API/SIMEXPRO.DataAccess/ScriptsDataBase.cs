using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.DataAccess
{
    public class ScriptsDataBase
    {

        #region Acceso

        #region Usuarios
        public static string ListarUsuarios = "acce.UDP_tbUsuarios_Listar";
        public static string InsertarUsuarios = "acce.UDP_tbUsuarios_Insertar";
        public static string EditarUsuarios = "acce.UDP_tbUsuarios_Editar";
        public static string EliminarUsuarios = "acce.UDP_tbUsuarios_Eliminar";

        public static string CorreoSegunUsuario = "acce.UDP_CorreoUsuario";
        public static string CambiarContrasenia = "acce.UDP_CambiarContrasena";
        public static string ActivarEstadoUsuarios = "Acce.UDP_tbUsuarios_Activar";
        public static string CambiarFotoPerfil = "acce.UDP_tbUsuarios_CambiarFoto";
        #endregion

        #region Pantallas
        public static string ListarPantallas = "Acce.UDP_tbPantallas_Listar";
        #endregion

        #region Roles
        public static string ListarRoles = "Acce.UDP_tbRoles_Listar";
        public static string InsertarRoles = "Acce.UDP_tbRoles_Insertar";
        public static string EditarRoles = "Acce.UDP_tbRoles_Editar";
        public static string EliminarRoles = "Acce.UDP_tbRoles_Eliminar";
        #endregion

        #region RolesXPantallas
        public static string ListarRolesXPantallas = "Acce.UDP_tbRolesXPantallas_Listar";
        public static string InsertarRolesXPantallas = "Acce.UDP_tbRolesXPantallas_Insertar";
        public static string EditarRolesXPantallas = "Acce.UDP_tbRolesXPantallas_Editar";
        public static string EliminarRolesXPantallas = "Acce.UDP_tbRolesXPantallas_Eliminar";
        public static string DibujarMenuRolesXPantallas = "Acce.UDP_RolesPorPantalla_DibujadoMenu";
        public static string DibujadoMenu = "Acce.UDP_RolesPorPantalla_DibujarMenu";
        #endregion

        #region Login
        public static string IniciarSesion = "Acce.UDP_IniciarSesion";
        public static string CambiarContrasena = "Acce.UDP_CambiarContrasena";
        #endregion

        #endregion

        #region Generales

        #region Estados Civiles
        public static string ListarEstadosCiviles = "gral.UDP_tbEstadosCiviles_Listar";
        public static string InsertarEstadosCiviles = "gral.UDP_tbEstadosCiviles_Insertar";
        public static string EditarEstadosCiviles = "gral.UDP_tbEstadosCiviles_Editar";
        public static string EliminarEstadosCiviles = "gral.UDP_tbEstadosCiviles_Eliminar";
        #endregion

        #region Oficinas
        public static string ListarOficinas = "gral.UDP_tbOficinas_Listar";
        public static string InsertarOficinas = "gral.UDP_tbOficinas_Insertar";
        public static string EditarOficinas = "gral.UDP_tbOficinas_Editar";
        public static string EliminarOficinas = "gral.UDP_tbOficinas_Eliminar";
        #endregion

        #region Oficio/Profesión
        public static string ListarOficioProfesion = "gral.UDP_tbOficio_Profesiones_Listar";
        public static string InsertarOficioProfesion = "gral.UDP_tbOficio_Profesiones_Insertar";
        public static string EditarOficioProfesion = "gral.UDP_tbOficio_Profesiones_Editar";
        #endregion

        #region Cargos
        public static string ListarCargos = "gral.UDP_tbCargos_Listar";
        public static string InsertarCargos = "gral.UDP_tbCargos_Insertar";
        public static string EditarCargos = "gral.UDP_tbCargos_Editar";
        #endregion

        #region Colonias
        public static string ListarColonias = "gral.UDP_tbColonias_Listar";
        public static string InsertarColonias = "gral.UDP_tbColonias_Insertar";
        public static string EditarColonias = "gral.UDP_tbColonias_Editar";
        public static string EliminarColonias = "gral.UDP_tbColonias_Eliminar";
        public static string ColoniasPorCiudades = "Gral.UDP_FiltrarColoniasPorCiudad";

        #endregion

        #region Monedas
        public static string ListarMonedas = "gral.UDP_tbMonedas_Listar";
        public static string InsertarMonedas = "gral.UDP_tbMonedas_Insertar";
        public static string EditarMonedas = "gral.UDP_tbMonedas_Editar";
        public static string EliminarMonedas = "gral.UDP_tbMonedas_Eliminar";
        #endregion

        #region Paises
        public static string ListarPaises = "Gral.UDP_tbPaises_Listar";
        public static string InsertarPaises = "Gral.UDP_tbPaises_Insertar";
        public static string EditarPaises = "Gral.UDP_tbPaises_Editar";
        #endregion

        #region Ciudades
        public static string ListarCiudades = "Gral.UDP_tbCiudades_Listar";
        public static string InsertarCiudades = "Gral.UDP_tbCiudades_Insertar";
        public static string EditarCiudades = "Gral.UDP_tbCiudades_Editar";
        public static string EliminarCiudades = "Gral.UDP_tbCiudades_Eliminar";
        public static string CiudadesPorProvincia = "Gral.UDP_FiltrarCiudadesPorProvincia";
        #endregion

        #region Provincias
        public static string ListarProvincias = "Gral.UDP_tbProvincias_Listar";
        public static string InsertarProvincias = "GrAL.UDP_tbProvincias_Insertar";
        public static string EditarProvincias = "Gral.UDP_tbProvinvias_Editar";
        public static string EliminarProvincias = "Gral.UDP_tbProvincias_Eliminar";
        public static string ProvinciasPorPais = "Gral.UDP_FiltrarProvinciasPorPais";

        public static string ProvinciaPaisYesAduana = "Gral.UDP_FiltrarProvinciasPorPaisYaduana";
        #endregion

        #region Aldeas
        public static string ListarAldeas = "Gral.UDP_tbAldeas_Listar";
        public static string InsertarAldeas = "Gral.UDP_tbAldeas_Insertar";
        public static string EditarAldeas = "Gral.UDP_tbAldeas_Editar";
        public static string EliminarAldeas = "Gral.UDP_tbAldeas_Eliminar";
        public static string AldeasPorCiudad = "Gral.UDP_FiltrarAldeasPorCiudades";
        #endregion

        #region Proveedores
        public static string ListarProveedores = "Gral.UDP_tbProveedores_Listar";
        public static string InsertaProveedores = "Gral.UDP_tbProveedores_Insertar";
        public static string EditarProveedores = "Gral.UDP_tbProveedores_Editar";
        public static string EliminarProveedores = "Gral.UDP_tbProveedores_Eliminar";
        #endregion

        #region Formas de Envio
        public static string ListarFormasEnvio = "Gral.UDP_tbFormas_Envio_Listar";
        public static string InsertarFormasEnvio = "Gral.UDP_tbFormas_Envio_Insertar";
        public static string EditarFormasEnvio = "Gral.UDP_tbFormas_Envio_Editar";
        public static string EliminarFormasEnvio = "Gral.UDP_tbFormas_Envio_Eliminar";
        #endregion

        #region Empleados
        public static string ListarEmpleados = "Gral.UDP_tbEmpleados_Listar";
        public static string ListarEmpleadosSinUsuario = "Gral.UDP_tbEmpleados_ListarNoTieneUsuario";
        public static string InsertarEmpleados = "gral.UDP_tbEmpleados_Insertar";
        public static string EditarEmpleados = "gral.UDP_tbEmpleados_Editar";
        public static string EliminarEmpleados = "gral.UDP_tbEmpleados_Eliminar";
        public static string ReactivarEmpleados = "Gral.UDP_tbEmpleados_Reactivar";
        #endregion

        #region Unidad de Medidas
        public static string ListarUnidadMedidas = "Gral.UDP_tbUnidadMedidas_Listar";
        public static string InsertarUnidadMedidas = "Gral.UDP_tbUnidadMedidas_Insertar";
        public static string EditarUnidadMedidas = "Gral.UDP_tbUnidadMedidas_Editar";
        public static string EliminarUnidadMedidas = "Gral.UDP_tbUnidadMedidas_Eliminar";
        #endregion


        #endregion

        #region Aduanas

        #region Aduanas
        public static string ListarAduanas = "Adua.UDP_tbAduanas_Listar";
        public static string ListarAduanasById = "Adua.UDP_tbAduanas_Listar_ById";
        public static string InsertarAduanas = "Adua.UDP_tbAduanas_Insertar";
        public static string EditarAduanas = "Adua.UDP_tbAduanas_Editar";
        public static string EliminarAduanas = "Adua.UDP_tbAduanas_Eliminar";
        public static string ListarAduasByCode = "Adua.tbAduanas_ListarByCode";
        #endregion

        #region Aranceles
        public static string ListarAranceles = "Adua.UDP_tbAranceles_Listar";
        public static string ListarArancelesFiltrado = "Adua.UDP_tbAranceles_ListarByCodigo";
        public static string ListarArancelesCapitulo = "Adua.UDP_tbAranceles_ListarPorCapitulo";
        public static string ListarArancelById = "Adua.UDP_tbAranceles_ListarById";
        public static string InsertarAranceles = "Adua.UDP_tbAranceles_Insertar";
        public static string EditarAranceles = "Adua.UDP_tbAranceles_Editar";
        #endregion

        #region Base Calculos
        public static string ListarBaseCalculos = "Adua.UDP_tbBaseCalculos_Listar";
        public static string InsertarBaseCalculos = "Adua.UDP_tbBaseCalculos_Insertar";
        public static string EditarBaseCalculos = "Adua.UDP_tbBaseCalculos_Editar";
        #endregion

        #region Boletin de Pago
        public static string ListarBoletinPago = "Adua.UDP_tbBoletinPago_Listar";
        public static string ListarBoletinPagoHistorial = "Adua.UDP_Historial_BolentinPagos";
        public static string InsertarBoletinPago = "Adua.UDP_tbBoletinPago_Insertar";
        public static string EditarBoletinPago = "Adua.UDP_tbBoletinPago_Editar";
        #endregion

        #region Boletin de Pago detalles
        public static string ListarBoletinPagoDetallesByIdBoletin = "Adua.UDP_tbBoletinPagoDetalles_Listado_ByIdBoletin";
        public static string InsertarBoletinPagoDetalles = "Adua.UDP_tbBoletinPagoDetalles_Insertar";
        public static string EditarBoletinPagoDetalles = "Adua.UDP_tbBoletinPagoDetalles_Editar";
        #endregion

        #region Codigo Impuesto
        public static string ListarCodigoImpuesto = "Adua.UDP_tbCodigoImpuesto_Listar";
        public static string InsertarCodigoImpuesto = "Adua.UDP_tbCodigoImpuesto_Insertar";
        public static string EditarCodigoImpuesto = "Adua.UDP_tbCodigoImpuesto_Editar";
        public static string EliminarCodigoImpuesto = "Adua.UDP_tbCodigoImpuesto_Eliminar";
        #endregion

        #region Comerciante Individual
        public static string ListarComercianteIndividual = "Adua.UDP_tbComercianteIndividual_Listar";
        public static string InsertarComercianteIndividual = "Adua.UDP_tbComercianteIndividual_InsertarTap1";
        public static string InsertarComercianteIndividualTap2 = "Adua.UDP_tbComercianteIndividual_InsertarTap2";
        public static string InsertarComercianteIndividualTap3 = "Adua.UDP_tbComercianteIndividual_InsertarTap3";
        public static string InsertarComercianteIndividualTap4 = "Adua.UDP_tbComercianteIndividual_InsertarTap4";

        public static string EditarComercianteIndividual = "Adua.UDP_tbComercianteIndividual_Editar";
        public static string EliminarComerciante = "Adua.UDP_tbComercianteIndividual_Eliminar";
        public static string FinalizarContratoComerciante = "Adua.UDP_tbComercianteIndividual_FinalizarContrato";

        #endregion

        #region Concepto  de Pago 
        public static string ListarConceptoPago = "Adua.UDP_tbConceptoPago_Listar";
        public static string InsertarConceptoPago = "Adua.UDP_tbConceptoPago_Insertar";
        public static string EditarConceptoPago = "Adua.UDP_tbConceptoPago_Editar";
        #endregion

        #region Condiciones 
        public static string ListarCondiciones = "Adua.UDP_tbCondiciones_Listar";
        public static string InsertarCondiciones = "Adua.UDP_tbCondiciones_Insertar";
        public static string EditarCondiciones = "Adua.UDP_tbCondiciones_Editar";
        #endregion

        #region Condiciones Comerciales
        public static string ListarCondicionesComerciales = "Adua.UDP_tbCondicionesComerciales_Listar";
        public static string InsertarCondicionesComerciales = "Adua.UDP_tbCondicionesComerciales_Insertar";
        public static string EditarCondicionesComerciales = "Adua.UDP_tbCondicionesComerciales_Editar";
        public static string EliminarCondicionesComerciales = "Adua.UDP_tbCondicionesComerciales_Eliminar";
        #endregion

        #region Conductor
        public static string ListarConductor = "adua.UDP_tbConductor_Listar";
        public static string InsertarConductor = "Adua.UDP_tbConductor_Insert";
        public static string EditarConductor = "Adua.UDP_tbConductor_Editar";
        public static string EliminarConductor = "Adua.UDP_tbConductor_Eliminar";
        #endregion

        #region Declaraciones de Valor
        public static string ListarDeclaracionesValor = "adua.UDP_tbDeclaraciones_ValorCompleto_Listar";
        public static string ListarDeclaracionesValorHistorial = "Adua.UDP_Historial_DevaSinDuca";
        public static string ListarFacturasPorDeva = "Adua.UDP_FacturaByDevaId";

        public static string InsertarDeclaracionesValorTAP1 = "adua.UDP_tbDeclaraciones_Valor_Tab1_Insertar";
        public static string EditarDeclaracionesValorTAP1 = "adua.UDP_tbDeclaraciones_Valor_Tab1_Editar";

        public static string InsertarDeclaracionesValorTAP2 = "adua.UDP_tbDeclaraciones_Valor_Tab2_Insertar";
        public static string EditarDeclaracionesValorTAP2 = "adua.UDP_tbDeclaraciones_Valor_Tab2_Editar";
        public static string CancelarIntermediario = "Adua.tbDeclaranciones_Valor_EliminarIntermediario";

        public static string InsertarDeclaracionesValorTAP3 = "adua.UDP_tbDeclaraciones_Valor_Tab3_Insertar";
        public static string EditarDeclaracionesValorTAP3 = "adua.UDP_tbDeclaraciones_Valor_Tab3_Editar";

        public static string EliminarDeclaracionesValor = "Adua.UDP_tbDeclaraciones_Valor_Eliminar";

        public static string EncontrarDeclarantes = "Adua.tbDeclarantes_Find";

        public static string FinalizarDeva = "Adua.UDP_tbdeclaracion_Valor_Finalizar";

        public static string CancelarDeva = "Adua.UDP_tbDeclaracionValor_Eliminar";

        public static string ListarDevaById = "adua.UDP_tbDeclaraciones_ValorCompleto_ListarById";
        #endregion

        #region Declarantes
        public static string ListarDeclarantes = "Adua.UDP_tbDeclarantes_Listar";
        public static string InsertarDeclarantes = "adua.UDP_tbDeclarantes_Insertar";
        public static string EditarDeclarantes = "adua.UDP_tbDeclarantes_Editar";
        public static string EliminarDeclarantes = "Adua.UDP_tbDeclarantes_Eliminar";
        public static string BuscarDeclarante = "Adua.UDP_tbDeclarantes_Find";
        #endregion

        #region Documentos Contrato
        public static string ListarDocumentosContratos = "Adua.UDP_tbDocumentosContratos_Listar";
        public static string EliminarDocumentosContratos = "Adua.UDP_tbDocumentosContratos_Eliminar";

        public static string InsertarDocumentosComerciante = "Adua.UDP_tbDocumentosContrato_ComercianteInsertar";
        public static string CargarDocuemntosComerciante = "Adua.UDP_tbDocumentosContrato_CargarDocuComerciante";
        public static string EditarDocumentosComerciante = "Adua.UDP_tbDocumentosContrato_ComercianteEditar";

        public static string InsertDocumentosPersonaJuridica = "Adua.UDP_tbDocumentosContrato_JuridicaInsertar";
        public static string CargarDocumentosPersonaJuridica = "Adua.UDP_tbDocumentosContrato_CargarDocuJuridica";
        public static string EditarDocumentosPersonaJuridica = "Adua.UDP_tbDocumentosContrato_PersonaJuridicaEditar";
        public static string EliminarDocumentosByPeju_Id = "Adua.UDP_tbDocumentosContratos_DeleteByPeju_Id";
        public static string EliminarDocumentosCoin_Id = "Adua.UDP_tbDocumentosContratos_DeleteByCoin_Id";
        #endregion

        #region Documentos de Soporte
        public static string ListarDocumentosSoporte = "Adua.UDP_tbDocumentosDeSoporte_Listar";
        public static string InsertarDocumentosSoporte = "Adua.UDP_tbDocumentosDeSoporte_Insertar";
        public static string EliminarDocumentosSoporte = "Adua.UDP_tbDocumentosDeSoporte_Eliminar";
        #endregion

        #region Documentos PDF
        public static string ListarDocumentosPDF = "Adua.UDP_tbDocumentosPDF_Listar";
        public static string InsertarDocumentosPDF = "Adua.UDP_tbDocumentosPDF_Insertar";
        public static string EditarDocumentosPDF = "Adua.UDP_tbDocumentosPDF_Editar";
        public static string EliminarDocumentosPDF = "Adua.UDP_tbDocumentosPDF_Eliminar";
        #endregion

        #region Documentos de Sanciones
        public static string InsertarDocumentodeSanciones = "Adua.UDP_tbDocumentosSanciones_Insertar";
        public static string ListarDocumentosdeSanciones = "Adua.UDP_tbDocumentosSanciones_Listar";
        #endregion

        #region Duca
        public static string ListarDuca = "Adua.UDP_tbDuca_Listar";
        public static string ListarDucaHistorial = "Adua.UDP_Historial_DUCAS";
        public static string ListarDuca_ById = "Adua.UDP_tbDuca_Listar_ById";
        public static string ListarDevaNoDuca = "Adua.UDP_tbDUCA_PreInsertarListado";

        public static string PreInsertDuca = "Adua.UDP_tbDuca_PreInsertar";

        public static string InsertarDucaTAP1 = "Adua.UDP_tbDuca_InsertarTab1";
        public static string EditarDucaTAP1 = "Adua.UDP_tbDuca_EditarTab1";

        public static string InsertarDucaTAP2 = "Adua.UDP_tbDuca_InsertarTab2";
        public static string EditarDucaTAP2 = "Adua.UDP_tbDuca_EditarTab2";

        public static string InsertarDucaTAP3 = "Adua.UDP_tbDuca_InsertarTab3";
        public static string EditarDucaTAP3 = "Adua.UDP_tbDuca_EditarTab3";

        public static string CancelarEliminarDuca = "Adua.UDP_tbDuca_CancelarEliminarDuca";

        public static string FinalizarDuca = "Adua.UDP_tbDuca_Finalizado";
        public static string ListarDevasByDucaId = "Adua.UDP_tbItemsDevaByDuca_Id";
        #endregion

        #region Ecotasa
        public static string ListarEcotasa = "Adua.UDP_tbEcotasa_Listar";
        public static string InsertarEcotasa = "Adua.UDP_tbEcotasa_Insertar";
        public static string EditarEcotasa = "Adua.UDP_tbEcotasa_Editar";
        public static string EliminarEcotasa = "Adua.UDP_tbEcotasa_Eliminar";

        #endregion

        #region Estado Boletin
        public static string ListarEstadoBoletin = "Adua.UDP_tbEstadoBoletin_Listar";
        public static string InsertarEstadoBoletin = "Adua.UDP_tbEstadoBoletin_Insertar";
        public static string EditarEstadoBoletin = "Adua.UDP_tbEstadoBoletin_Editar";
        #endregion

        #region Estado Mercancias
        public static string ListarEstadoMercancias = "Adua.UDP_VW_tbEstadoMercancias_Listar";
        public static string InsertarEstadoMercancias = "Adua.UDP_tbEstadoMercancias_Insertar";
        public static string EditarEstadoMercancias = "Adua.UDP_tbEstadoMercancias_Editar";
        public static string EliminarEstadoMercancias = "Adua.UDP_tbEstadoMercancias_Eliminar";
        #endregion

        #region Facturas
        public static string ListarFacturas = "Adua.UDP_tbFacturas_Listar";
        public static string InsertarFacturas = "Adua.UDP_tbFacturas_Insertar";
        public static string EditarFacturas = "Adua.UDP_tbFacturas_Editar";
        public static string EliminarFacturas = "Adua.UDP_tbFacturas_Eliminar";
        public static string VerificarFacturas = "Adua.UDP_tbFacturas_VerificarFacturas";
        #endregion

        #region Formas de Pago
        public static string ListarFormasdePago = "Adua.UDP_tbFormadePago_Listar";
        public static string InsertarFormasdePago = "Adua.UDP_tbFormasdePago_Insertar";
        public static string EditarFormasdePago = "Adua.UDP_tbFormasdePago_Editar";
        public static string EliminarFormasdePago = "Adua.UDP_tbFormasdePago_Eliminar";
        #endregion

        #region Impuestos
        public static string ListarImpuestos = "Adua.UDP_tbImpuestos_Listar";
        public static string InsertarImpuestos = "Adua.UDP_tbImpuestos_Insertar";
        public static string EditarImpuestos = "Adua.UDP_tbImpuestos_Editar";
        #endregion

        #region Impuestos Por Arancel
        public static string ListarImpuestosPorArancelFiltrado = "Adua.UDP_tbImpuestosPorArancel_ListarPorArancel";
        public static string ListarImpuestosPorArancel = "Adua.UDP_tbImpuestosPorArancel_Listar";
        public static string InsertarImpuestosPorArancel = "Adua.UDP_tbImpuestosPorArancel_Insertar";
        public static string EditarImpuestosPorArancel = "Adua.UDP_tbImpuestosPorArancel_Editar";
        public static string EliminarImpuestosPorArancel = "Adua.UDP_tbImpuestosPorArancel_Eliminar";
        public static string CategoriaAranceles = "Adua.UDP_tbArancelesBuscarCategoria";
        #endregion

        #region Impuesto Selectivo Consumo Condiciones Vehiculos 
        public static string ListarISCCV = "Adua.UDP_tbImpuestoSelectivoConsumoCondicionesVehiculos_Listar";
        public static string InsertarISCCV = "Adua.UDP_tbImpuestoSelectivoConsumoCondicionesVehiculos_Insertar";
        public static string EditarISCCV = "Adua.UDP_tbImpuestoSelectivoConsumoCondicionesVehiculos_Editar";
        public static string EliminarISCCV = "Adua.UDP_tbImpuestoSelectivoConsumoCondicionesVehiculos_Eliminar";

        #endregion

        #region Incoterm
        public static string ListarIncoterm = "adua.UDP_tbIncoterm_Listar";
        public static string InsertarIncoterm = "adua.UDP_tbIncoterm_Insertar";
        public static string EditarIncoterm = "adua.UDP_tbIncoterm_Editar";
        #endregion

        #region Items
        public static string ListarItems = "Adua.UDP_tbItems_Listar";
        public static string InsertarItems = "Adua.UDP_tbItems_Insertar";
        public static string EditarItemDuca = "Adua.UDP_tbItems_EditarItemDuca";
        public static string EditarItems = "Adua.UDP_tbItems_Editar";
        public static string EliminarItems = "Adua.UDP_tbItems_Eliminar";
        public static string CalcularValorAduana = "Adua.UDP_tbItems_CalcularValorAduana";
        public static string ListarItemsByFactId = "Adua.UDP_tbItemsByfact_Id";
        #endregion

        #region Importadores
        public static string ListarImportadores = "Adua.UDP_tbImportadores_Listar";
        public static string ListarImportadoresById = "Adua.UDP_tbImportadores_ById";
        #endregion

        #region Liquidacion General
        public static string ListarLiquidacionGeneral = "Adua.UDP_tbLiquidacionGeneral_Listar";
        public static string InsertarLiquidacionGeneral = "Adua.UDP_tbLiquidacionGeneral_Insertar";
        public static string EditarLiquidacionGeneral = "Adua.UDP_tbLiquidacionGeneral_Editar";
        #endregion

        #region Liquidacion Por Linea
        public static string ListarLiquidacionPorLinea = "adua.UDP_tbLiquidacionPorLinea_Listar";
        public static string InsertarLiquidacionPorLinea = "adua.UDP_tbLiquidacionPorLinea_Insertar";
        public static string EditarLiquidacionPorLinea = "adua.UDP_tbLiquidacionPorLinea_Editar";
        #endregion

        #region Lugares de Embarque
        public static string ListarLugaresEmbarque = "Adua.UDP_tbLugaresEmbarque_Listar";
        public static string InsertarLugaresEmbarque = "Adua.UDP_tbLugaresEmbarque_Insertar";
        public static string EditarLugaresEmbarque = "Adua.UDP_tbLugaresEmbarque_Editar";
        public static string EliminarLugaresEmbarque = "Adua.UDP_tbLugaresEmbarque_Eliminar";
        #endregion

        #region Marcas
        public static string ListarMarcas = "Adua.UDP_tbMarcas_Listar";
        public static string InsertarMarcas = "Adua.UDP_tbMarcas_Insertar";
        public static string EditarMarcas = "Adua.UDP_tbMarcas_Editar";
        public static string EliminarMarcas = "Adua.UDP_tbMarcas_Eliminar";
        #endregion

        #region Modo Transporte
        public static string ListarModoTransporte = "Adua.UDP_tbModoTransporte_Listar";
        public static string InsertarModoTransporte = "Adua.UDP_tbModoTransporte_Insertar";
        public static string EditarModoTransporte = "Adua.UDP_tbModoTransporte_Editar";
        #endregion

        #region Niveles Comerciales
        public static string ListarNivelesComerciales = "Adua.UDP_tbNivelesComerciales_Listar";
        public static string InsertarNivelesComerciales = "Adua.UDP_tbNivelesComerciales_Insertar";
        public static string EditarNivelesComerciales = "Adua.UDP_tbNivelesComerciales_Editar";
        public static string EliminarNivelesComerciales = "Adua.UDP_tbNivelesComerciales_Eliminar";
        #endregion

        #region Persona Juridica
        public static string ListarPersonaJuridica = "Adua.UDP_tbPersonaJuridica_Listar";
        public static string InsertarPersonaJuridica = "Adua.UDP_tbPersonaJuridica_InsertarTab1";
        public static string InsertarPersonaJuridicaTap2 = "Adua.UDP_tbPersonaJuridica_InsertarTab2";
        public static string InsertarPersonaJuridicaTap3 = "Adua.UDP_tbPersonaJuridica_InsertarTab3";
        public static string InsertarPersonaJuridicaTap4 = "Adua.UDP_tbPersonaJuridica_InsertarTab4";
        public static string EditarPersonaJuridica = "Adua.UDP_tbPersonaJuridica_Editar";
        public static string FinalizarPersonaJuridica = "Adua.UDP_tbPersonaJuridica_ContratoFinalizado";
        public static string EliminarJuridica = "Adua.UDP_tbPersonaJuridica_Eliminar";
        #endregion

        #region Persona Natural
        public static string ListarPersonaNatural = "Adua.UDP_tbPersonaNatural_Listar";
        public static string InsertarPersonaNatural = "Adua.UDP_tbPersonaNatural_Insertar";
        public static string EditarPersonaNatural = "Adua.UDP_tbPersonaNatural_Editar";
        public static string FinalizarPersonaNatural = "Adua.UDP_tbPersonaNatural_Finalizado";
        #endregion

        #region Personas
        public static string ListarPersonas = "Adua.UDP_tbPersonas_Listar";
        public static string InsertarPersonas = "Adua.UDP_tbPersonas_Insertar";
        public static string EditarPersonas = "Adua.UDP_tbPersonas_Editar";
        #endregion

        #region PaisesEstanTratadosConHonduras
        public static string TratadoByPaisId = "Adua.UDP_tbPaisesEstanTratadosConHonduras_TratadoByPaisId";
        #endregion

        #region TratadosLibreComercio
        public static string ListarTLC = "Adua.tbTratados_Listar";
        public static string InsertarTLC = "Adua.tbTratados_Insertar";
        public static string EditarTLC = "Adua.tbTratados_Editar";
        public static string ListTratadosById = "Adua.UDP_tbTratadosLibreComercio_ListById";
        public static string ListAcuerdosPorTratado = "Adua.UDP_tbArancelesPorTratado_PorTratadoYCapitulo";
        #endregion

        #region ArancelesPorTratado

        public static string InsertarArancelPorTratado = "Adua.tbArancelesPorTratadoInsertar";
        public static string EditarArancelPorTratado = "Adua.tbArancelesPorTratadoEditar";
        public static string EliminarArancelPorTratado = "Adua.tbArancelesPorTratadoEliminar";

        #endregion

        #region Tipo Documentos
        public static string ListarTipoDocumento = "Adua.UDP_tbTipoDocumento_Listar";
        public static string InsertarTipoDocumento = "Adua.UDP_tbTipoDocumento_Insertar";
        public static string EditarTipoDocumento = "Adua.UDP_tbTipoDocumento_Editar";
        #endregion

        #region Tipo Intermediario
        public static string ListarTipoIntermediario = "Adua.UDP_tbTipoIntermediario_Listar";
        public static string InsertarTipoIntermediario = "Adua.UDP_tbTipoIntermediario_Insertar";
        public static string EditarTipoIntermediario = "Adua.UDP_tbTipoIntermediario_Editar";
        public static string EliminarTipoIntermediario = "Adua.UDP_tbTipoIntermediario_Eliminar";
        #endregion

        #region Tipo Liquidación
        public static string ListarTipoLiquidacion = "Adua.UDP_tbTipoLiquidacion_Listar";
        public static string InsertarTipoLiquidacion = "Adua.UDP_tbTipoLiquidacion_Insertar";
        public static string EditarTipoLiquidacion = "Adua.UDP_tbTipoLiquidacion_Editar";
        #endregion

        #region Tipo Identificacion
        public static string ListarTiposIdentificacion = "Adua.UDP_tbTiposIdentificacion_Listar";
        public static string InsertarTiposIdentificacion = "Adua.UDP_tbTiposIdentificacion_Insertar";
        public static string EditarTiposIdentificacion = "Adua.UDP_tbTiposIdentificacion_Editar";
        public static string EliminarTiposIdentificacion = "Adua.UDP_tbTiposIdentificacion_Eliminar";
        #endregion

        #region Transporte
        public static string ListarTransporte = "Adua.UDP_tbTransporte_Listar";
        public static string InsertarTransporte = "Adua.UDP_tbTransporte_Insert";
        public static string EditarTransporte = "Adua.UDP_tbTransporte_Editar";
        #endregion

        #region Regimenes Aduaneros
        public static string ListarRegimenesAduaneros = "Adua.UDP_tbRegimenesAduaneros_Listar";
        public static string InsertarRegimenesAduaneros = "Adua.UDP_tbRegimenesAduaneros_Insertar";
        public static string EditarRegimenesAduaneros = "Adua.UDP_tbRegimenesAduaneros_Editar";
        public static string EliminarRegimenesAduaneros = "Adua.UDP_tbRegimenesAduaneros_Eliminar";
        #endregion

        #region Items DEVA X DUCA
        public static string ListadoDevasPorducaId = "Adua.UDP_tbItemsDEVAPorDuca_ListadoDevasPorduca_Id";
        public static string LitarItemDEVAxDuca = "Adua.UPD_tbItemsDEVAPorDuca_DEVAsPorDUCANo";
        public static string InsertarItemDEVAxDuca = "Adua.UDP_tbItemsDEVAPorDuca_InsertarDuca";
        public static string EditarItemDevaxDuca = "Adua.UDP_tbItemsDEVAPorDuca_Editar";
        public static string LiberarDevasPorDucaId = "Adua.UDP_tbItemsDEVAPorDuca_LiberarDevasPorDucaId";
        #endregion

        #endregion

        #region Produccion

        #region Procesos
        public static string ListarProcesos = "Prod.UDP_tbProcesos_Listar";
        public static string InsertarProcesos = "Prod.UDP_tbProcesos_Insertar";
        public static string EditaProcesos = "Prod.UDP_tbProcesos_Editar";
        public static string EliminarProcesis = "Prod.UDP_tbProcesos_Eliminar";
        #endregion

        #region Reporte Modulo del Dia
        public static string ListarReporteModuloDia = "Prod.UDP_tbReporteModuloDia_Listar";
        public static string ListarReporteModuloDiaPorFechas = "Prod.UDP_tbReporteModuloDia_ListarPorFechas";
        public static string InsertarReporteModuloDia = "Prod.UDP_tbReporteModuloDia_Insertar";
        public static string EditarReporteModuloDia = "Prod.UDP_tbReporteModuloDia_Editar";
        public static string FinalizarReporteModuloDia = "Prod.UDP_tbReporteModuloDia_Finalizado";

        #endregion

        #region Reporte Modulo del Dia Detalle
        public static string ListarReporteModuloDiaDetalle = "Prod.UDP_tbReporteModuloDiaDetalle_Listar";
        public static string InsertarReporteModuloDiaDetalle = "Prod.UDP_tbReporteModuloDiaDetalle_Insertar";
        public static string EditarReporteModuloDiaDetalle = "Prod.UDP_tbReporteModuloDiaDetalle_Editar";
        public static string EliminarReporteModuloDiaDetalle = "Prod.UDP_tbReporteModuloDiaDetalle_Eliminar";
        #endregion

        #region Revision de Calidad
        public static string ListarRevisionDeCalidad = "Prod.UDP_tbRevisionDeCalidad_Listar";
        public static string NuevoListarRevisionDeCalidad = "Prod.UDP_tbRevisionCalidad_NuevoListar";
        public static string InsertaRevisionDeCalidad = "Prod.UDP_tbRevisionDeCalidad_Insertar";
        public static string EditarRevisionDeCalidad = "Prod.UDP_tbRevisionDeCalidad_Editar";
        public static string EliminarRevisionDeCalidad = "Prod.UDP_tbRevisionDeCalidad_Eliminar";
        #endregion

        #region Sub Categoria
        public static string ListarSubCategoria = "Prod.UDP_tbSubcategoria_Listar";
        public static string InsertarSubCategoria = "Prod.UDP_tbSubcategoria_Insertar";
        public static string EditarSubCategoria = "Prod.UDP_tbSubcategoria_Editar";
        public static string EliminarSubCategoria = "Prod.UDP_tbSubcategoria_Eliminar";
        public static string ListarSubcategoriaByIdCategoria = "Prod.UDP_tbSubcategoria_ListarByIdCategoria";
        #endregion

        #region Tallas
        public static string ListarTallas = "Prod.UDP_tbTallas_Listar";
        public static string InsertarTallas = "Prod.UDP_tbTallas_Insertar";
        public static string EditarTallas = "Prod.UDP_tbTallas_Editar";
        #endregion

        #region Tipo Embalaje
        public static string ListarTipoEmbalaje = "Prod.UDP_tbTipoEmbalaje_Listar";
        public static string InsertarTipoEmbalaje = "Prod.UDP_tbTipoEmbalaje_Insertar";
        public static string EditarTipoEmbalaje = "Prod.UDP_tbTipoEmbalaje_Editar";
        public static string EliminarTipoEmbalaje = "Prod.UDP_tbTipoEmbalaje_Eliminar";
        #endregion

        #region Areas
        public static string ListarAreas = "Prod.UDP_tbArea_Listar";
        public static string InsertarAreas = "Prod.UDP_tbArea_Insertar";
        public static string EditarAreas = "Prod.UDP_tbArea_Editar";
        public static string EliminarAreas = "Prod.UDP_tbArea_Eliminar";
        #endregion

        #region Asignaciones Orden
        public static string ListarAsignacionesOrden = "Prod.UDP_tbAsignacionesOrden_Listado";
        public static string InsertarAsignacinesOrden = "Prod.UDP_tbAsignacionesOrden_Insertar";
        public static string EditarAsignacionesOrden = "Prod.UDP_tbAsignacionesOrden_Editar";
        public static string EliminarAsignacionesOrden = "Prod.UDP_tbAsignacionesOrden_Eliminar";

        public static string FindOrdenCompraDetalle = "Prod.UDP_tbOrdenCompraDetalles_Find";
        #endregion

        #region Asignaciones Orden Detalle
        public static string ListarAsignacionesOrdenDetalle = "Prod.UDP_tbAsignacionesOrdenDetalle_Listado";
        public static string InsertarAsignacinesOrdenDetalle = "Prod.UDP_tbAsignacionesOrdenDetalle_Insertar";
        public static string EditarAsignacionesOrdenDetalle = "Prod.UDP_tbAsignacionesOrdenDetalle_Editar";
        public static string EliminarAsignacionesOrdenDetalle = "Prod.UDP_tbAsignacionesOrdenDetalle_Eliminar";
        #endregion

        #region Categorias
        public static string ListarCategorias = "prod.UDP_tbCategoria_Listar";
        public static string InsertarCategorias = "prod.UDP_tbCategoria_Insertar";
        public static string EditarCategorias = "prod.UDP_tbCategoria_Editar";
        public static string EliminarCategorias = "prod.UDP_tbCategoria_Eliminar";
        #endregion

        #region Clientes
        public static string ListarClientes = "Prod.UDP_tbClientes_Listar";
        public static string InsertarClientes = "prod.UDP_tbClientes_Insertar";
        public static string EditarClientes = "Prod.UDP_tbClientes_Editar";
        public static string EliminarClientes = "Prod.UDP_tbClientes_Eliminar";
        public static string ActivarEstadoClientes = "Prod.UDP_tbClientes_Activar";
        #endregion

        #region Colores
        public static string ListarColores = "Prod.UDP_tbColores_Listar";
        public static string InsertarColores = "Prod.UDP_tbColores_Insertar";
        public static string EditarColores = "Prod.UDP_tbColores_Editar";
        public static string EliminarColores = "Prod.UDP_tbColores_Eliminar";
        #endregion

        #region Estilos
        public static string ListarEstilos = "Prod.UDP_tbEstilos_Listar";
        public static string InsertarEstilos = "Prod.UDP_tbEstilos_Insertar";
        public static string EditarEstilos = "Prod.UDP_tbEstilos_Editar";
        public static string EliminarEstilos = "Prod.UDP_tbEstilos_Eliminar";
        #endregion

        #region Funciones Maquinas
        public static string ListarFuncionesMaquinas = "prod.UDP_tbFuncionesMaquina_Listar";
        public static string InsertarFuncionesMaquinas = "prod.UDP_tbFuncionesMaquina_Insertar";
        public static string EditarFuncionesMaquinas = "prod.UDP_tbFuncionesMaquina_Editar";
        public static string EliminarFuncionesMaquinas = "prod.UDP_tbFuncionesMaquina_Eliminar";
        #endregion

        #region Lotes
        public static string ListarLotes = "Prod.UDP_tbLotes_Listar";
        public static string InsertarLotes = "Prod.UDP_tbLotes_Insertar";
        public static string EditarLotes = "Prod.UDP_tbLotes_Editar";
        public static string EliminarLotes = "Prod.UDP_tbLotes_Eliminar";
        public static string LotesMateriales = "Prod.UDP_tbLotes_Materiales";
        #endregion

        #region MaquinasHitorial
        public static string ListarMaquinasHistorial = "Prod.UDP_tbMaquinaHistorial_Listar";
        public static string InsertarMaquinasHistorial = "Prod.UDP_tbMaquinaHistorial_Insertar";
        public static string EditarMaquinasHistorial = "Prod.UDP_tbMaquinaHistorial_Editar";
        public static string EliminarMaquinasHistorial = "Prod.UDP_tbMaquinaHistorial_Eliminar";
        #endregion

        #region Maquinas
        public static string ListarMaquinas = "Prod.UDP_tbMaquinas_Listar";
        public static string InsertarMaquinas = "Prod.UDP_tbMaquinas_Insertar";
        public static string EditarMaquinas = "Prod.UDP_tbMaquinas_Editar";
        public static string EliminarMaquinas = "Prod.UDP_tbMaquinas_Eliminar";
        #endregion

        #region Marcas Maquina
        public static string ListarMarcasMaquina = "Prod.UDP_tbMarcasMaquinas_Listar";
        public static string InsertarMarcasMaquina = "Prod.UDP_tbMarcasMaquina_Insertar";
        public static string EditarMarcasMaquina = "Prod.UDP_tbMarcasMaquina_Editar";
        public static string EliminarMarcasMaquina = "Prod.UDP_tbMarcasMaquina_Eliminar";
        #endregion

        #region Materiales
        public static string ListarMateriales = "Prod.UDP_tbMateriales_Listar";
        public static string InsertarMateriales = "Prod.UDP_tbMateriales_Insertar";
        public static string EditarMateriales = "Prod.UDP_tbMateriales_Editar";
        public static string EliminarMateriales = "Prod.UDP_tbMateriales_Eliminar";
        #endregion

        #region Materiales Brindar
        public static string ListarMaterialesBrindar = "prod.UDP_tbMaterialesBrindar_Listar";
        public static string ListarMaterialesBrindarFiltrado = "Prod.UDP_tbMaterialesBrindarPorOrdenCompraDetalle_Listar";
        public static string InsertarMaterialesBrindar = "prod.UDP_tbMaterialesBrindar_Insertar";
        public static string EditarMaterialesBrindar = "prod.UDP_tbMaterialesBrindar_Editar";
        public static string EliminarMaterialesBrindar = "Prod.UDP_tbMaterialesBrindar_Eliminar";
        #endregion

        #region Modelos Maquina
        public static string ListarModelosMaquina = "Prod.UDP_tbModelosMaquina_Listar";
        public static string InsertarModelosMaquina = "Prod.UDP_tbModelosMaquina_Insertar";
        public static string EditarModelosMaquina = "Prod.UDP_tbModelosMaquina_Editar";
        public static string EliminarModelosMaquina = "Prod.UDP_tbModelosMaquina_Eliminar";
        #endregion

        #region Modulos
        public static string ListarModulos = "Prod.UDP_tbModulos_Listar";
        public static string InsertarModulos = "Prod.UDP_tbModulos_Insertar";
        public static string EditarModulos = "Prod.UDP_tbModulos_Editar";
        public static string EliminarModulos = "Prod.UDP_tbModulos_Eliminar";
        #endregion

        #region DocumentosOrdenCompraDetalles
        public static string ListarDocumentosOrdenCompraDetalles   = "Prod.UDP_tbDocumentosOrdenCompraDetalles_Listar";
        public static string InsertarDocumentosOrdenCompraDetalles = "Prod.UDP_tbDocumentosOrdenCompraDetalles_Insertar";
        public static string EditarDocumentosOrdenCompraDetalles   = "Prod.UDP_tbDocumentosOrdenCompraDetalles_Editar";
        public static string EliminarDocumentosOrdenCompraDetalles = "Prod.UDP_tbDocumentosOrdenCompraDetalles_Eliminar";
        #endregion

        #region Orden Ensamblado - Acabado - Etiquetado
        public static string ListarOrde_Ensa_Acab_Etiq = "Prod.UDP_tbOrde_Ensa_Acab_Etiq_Listar";
        public static string InsertarOrde_Ensa_Acab_Etiq = "Prod.UDP_tbOrde_Ensa_Acab_Etiq_Insertar";
        public static string EditarOrde_Ensa_Acab_Etiq = "Prod.UDP_tbOrde_Ensa_Acab_Etiq_Editar";
        #endregion

        #region Orden de Compra
        public static string ObtenerOrdenCompraPorIdParaLineaTiempo = "Prod.UDP_tbOrdenCompra_ObtenerPorId_Para_LineaTiempo";
        public static string ListarOrdenCompra = "Prod.UDP_tbOrdenCompra_Listado";
        public static string InsertarOrdenCompra = "Prod.UDP_tbOrdenCompra_Insertar";
        public static string EditarOrdenCompra = "Prod.UDP_tbOrdenCompra_Editar";
        public static string EliminarOrdenCompra = "Prod.UDP_OrdenCompra_Delete";
        public static string FinalizarOrdenCompra = "Prod.UDP_OrdenCompra_Finalizado";

        public static string PO_ExportData = "Prod.UDP_OrdenCompraDataToExport";
        #endregion

        #region Orden de Compra Detalles
        public static string ObtenerDetallesPorIdCompraParaLineaTiempo = "Prod.UDP_tbOrdenCompraDetalle_ObtenerPorIdOrdenCompra_ParaLineaTiempo";
        public static string ListarOrdenCompraDetalles = "Prod.UDP_tbOrdenCompraDetalle_Listado";
        public static string InsertarOrdenCompraDetalles = "Prod.UDP_tbOrdenCompraDetalles_Insertar";
        public static string EditarOrdenCompraDetalles = "Prod.UDP_tbOrdenCompraDetalles_Editar";
        public static string EliminarOrdenCompraDetalles = "Prod.UDP_tbOrdenCompraDetalles_Eliminar";
        public static string DibujarDetalles = "Prod.UDP_DibujarDetalles";
        #endregion

        #region Proceso por Orden de compra detalle
        public static string ListarProcesoPorOrdenCompraDetalle = "Prod.UDP_tbProcesoPorOrdenCompraDetalle_Listado_PorDetalle";
        public static string InsertarProcesoPorOrdenCompraDetalle = "Prod.UDP_tbProcesoPorOrdenCompraDetalle_Insertar";
        public static string EliminarProcesoPorOrdenCompraDetalle = "Prod.UDP_tbProcesoPorOrdenCompraDetalle_Eliminar";
        public static string DibujarProcesos = "Prod.UDP_DibujarProcesos";
        public static string FiltrarProceso = "Prod.UDP_tbOrdenCompraDetalles_FiltrarProceso";
        #endregion

        #region Orden de Pedido
        public static string ListarPedidosOrden = "Prod.UDP_tbPedidosOrden_Listar";
        public static string InsertarPedidosOrden = "Prod.UDP_tbPedidosOrden_Insertar";
        public static string EditarPedidosOrden = "Prod.UDP_tbPedidosOrden_Editar";
        public static string FinalizarPedidosOrden = "Prod.UDP_tbPedidosOrden_Finalizado";
        public static string PedidosOrdenFind = "Prod.UDP_tbPedidosOrden_FindCodigo";
        public static string ItemsOrdenPedido  = "Prod.UDP_tbItems_OrdenDePedido";
        #endregion

        #region Orden de Pedido Detalles
        public static string ListarPedidosOrdenDetalles = "Prod.UDP_tbPedidosOrdenDetalle_Listar";
        public static string InsertarPedidosOrdenDetalles = "Prod.UDP_tbPedidosOrdenDetalle_Insertar";
        public static string EditarPedidosOrdenDetalles = "Prod.UDP_tbPedidosOrdenDetalle_Editar";
        public static string PedidosOrdenDetallesFind = "Prod.UDP_tbPedidosOrdenDetalle_Find";
        public static string PedidosOrdenDetallesEliminar = "Prod.UDP_tbPedidosOrdenDetalle_Eliminar";
        public static string InsertarItemsPedidosOrdenDetalles = "Prod.UDP_tbOrdenPedido_InsertDuca";
        public static string EliminarDetalleConDuca = "Prod.UDP_tbPedidosOrden_Eliminar";

        #endregion

        #region Pedidos Produccion
        public static string ListarPedidosProduccion = "Prod.UDP_tbPedidosProduccion_Listar";
        public static string InsertarPedidosProduccion = "Prod.UDP_tbPedidosProduccion_Insertar";
        public static string EditarPedidosProduccion = "Prod.UDP_tbPedidosProduccion_Editar";
        public static string EliminarPedidosProduccion = "Prod.UDP_tbPedidosProduccion_Eliminar";
        public static string FinalizarPedidosProduccion = "Prod.UDP_tbPedidosProduccion_Finalizado";
        public static string BuscarPedidosProduccion = "Prod.UDP_tbPedidosProduccion_Find" ;
        #endregion

        #region Pedidos Produccion Detalles
        public static string ListarPedidosProduccionDetalles = "Prod.UDP_tbPedidosProduccionDetalle_Listar";
        public static string InsertarPedidosProduccionDetalles = "Prod.UDP_tbPedidosProduccionDetalle_Insertar";
        public static string EditarPedidosProduccionDetalles = "Prod.UDP_tbPedidosProduccionDetalle_Editar";
        public static string EliminarPedidosProduccionDetalles = "Prod.UDP_tbPedidosProduccionDetalle_Eliminar";
        public static string FiltrarPedidosProduccionDetalles = "Prod.UDP_tbPedidosProduccionDetalle_Filtrar_Estado";
        #endregion

        #region PO Detalle Por Pedido Orden Detalle
        public static string ListarPODetallePorPedidoOrdenDetalle = "Prod.UDP_tbPODetallePorPedidoOrdenDetalle_Listar";
        public static string InsertarPODetallePorPedidoOrdenDetalle = "Prod.UDP_tbPODetallePorPedidoOrdenDetalle_Insertar";
        public static string EliminarPedidosOrdenDetalles = "Prod.UDP_tbPODetallePorPedidoOrdenDetalle_Eliminar";
        #endregion

        #region Procesos
        public static string FiltrarProcesos = "Prod.UDP_tbProcesos_Filtrar_Modulos";
        #endregion

        #region FacturasExportacion
        public static string ListarFacturasExportacion = "Prod.UDP_tbFacturasExportacion_Listar";
        public static string InsertarFacturasExportacion = "Prod.UDP_tbFacturasExportacion_Insertar";
        public static string EditarFacturasExportacion = "Prod.UDP_tbFacturasExportacion_Editar";
        public static string EliminarFacturasExportacion = "Prod.UDP_tbFacturasExportacion_Eliminar";
        public static string FinalizarFacturasExportacion = "Prod.UDP_tbFacturasExportacion_Finalizado";

        public static string OrdenesCompraDDL = "Prod.UDP_OrdenesCompraDDL";
        public static string DUCAsDDL = "Prod.UDP_DUCAsDDL";
        public static string ComprobarNoDUCA = "Prod.UDP_ComprobarNoDUCA";
        #endregion

        #region FacturasExportacionDetalles
        public static string ListarFacturasExportacionDetalles = "Prod.UDP_tbFacturasExportacionDetalles_Listar";
        public static string InsertarFacturasExportacionDetalles = "Prod.UDP_tbFacturasExportacionDetalles_Insertar";
        public static string EditarFacturasExportacionDetalles = "Prod.UDP_tbFacturasExportacionDetalles_Editar";
        public static string EliminarFacturasExportacionDetalles = "Prod.UDP_tbFacturasExportacionDetalle_Eliminar";

        public static string PODetallesDDL = "Prod.UDP_PODetallesByID";
        #endregion

        #region ImpuestosProd
        public static string ListarImpuestosProd = "Prod.UDP_tbImpuestosProd_Listar";
        public static string EditarImpuestosProd = "Prod.UDP_tbImpuestosProd_Editar";
        #endregion

        #endregion

        #region Graficas
        public static string GR_AvanceOrdenCompraPorID = "Prod.UDP_AvanceOrdenCompraByID";
        public static string GR_TotalOrdenesCompraAnual = "Prod.UDP_TotalOrdenesCompraAnual";
        public static string GR_TotalOrdenesCompraMensual = "Prod.UDP_TotalOrdenesCompraMensual";
        public static string GR_TotalOrdenesCompraDiario = "Prod.UDP_TotalOrdenesCompraDiario";
        public static string GR_ContadorOrdenesCompraPorEstado = "Prod.UDP_ContadorOrdenesCompra_PorEstado";
        public static string GR_ContadorOrdenesCompraPorEstado_UltimaSemana = "Prod.UDP_ContadorOrdenesCompra_PorEstado_UltimaSemana";
        public static string GR_VentasSemanales = "Prod.UDP_VentasSemanales";
        public static string GR_VentasMensuales = "Prod.UDP_VentasMensuales";
        public static string GR_VentasAnuales = "Prod.UDP_VentasAnuales";
        public static string GR_OrdenenesEntregadasPendientes_Anual = "Prod.UDP_PO_EntregadasPendientes_Anualmente";
        public static string GR_OrdenenesEntregadasPendientes_Mensual = "Prod.UDP_PO_EntregadasPendientes_Mensualmente";
        public static string GR_OrdenenesEntregadasPendientes_Semanal = "Prod.UDP_PO_EntregadasPendientes_Semanalmente";

        public static string GR_PrendasPedidas = "Prod.UDP_CantidadPrendas_SegunIDEstilo";
        public static string GR_ClientesProductivos = "Prod.UDP_ClientesMasProductivos";
        public static string GR_ProductividadModulos = "Prod.UDP_ProduccionModulo_CantidadPorcentaje";
        public static string Adua_UDP_ExportadoresPorPais_CantidadPorcentaje = "Adua.UDP_ExportadoresPorPais_CantidadPorcentaje";
        public static string Adua_UDP_EstadosMercancias_CantidadPorcentaje = "Adua.UDP_EstadosMercancias_CantidadPorcentaje";
        public static string Adua_UDP_AduanasIngreso_CantidadPorcentaje = "Adua.UDP_AduanasIngreso_CantidadPorcentaje";
        public static string Adua_UDP_Importaciones_Contador_Anio = "Adua.UDP_Importaciones_Contador_Anio";
        public static string Adua_UDP_Importaciones_Contador_Mes = "Adua.UDP_Importaciones_Contador_Mes";
        public static string Adua_UDP_Importaciones_Contador_Semana = "Adua.UDP_Importaciones_Contador_Semana";
        public static string Importaciones_Semana = "Adua.UDP_Importaciones_Semana";
        public static string Importaciones_Mes = "Adua.UDP_Importaciones_Mes";
        public static string Importaciones_Anio = "Adua.UDP_Importaciones_Anio";
        public static string RegimenesAduaneros_CantidadPorcentaje = "Adua.UDP_RegimenesAduaneros_CantidadPorcentaje";
        public static string PaisesMasExportadores = "Adua.UDP_PaisesConImportacionesRealizadas";
        public static string TratadosMasUsados = "Adua.TratadosLibreComercioMasUsado";
        #endregion

        #region Reportes
        public static string MaquinasTiempos = "Prod.UPD_Reporte_TiemposMaquinas";
        public static string ModuloProduccion = "Prod.UDP_Reporte_ProduccionPorModulo";
        public static string PedidosCliente = "Prod.UDP_Reporte_PedidosCliente";
        public static string PlanificacionPO = "Prod.UDP_Reporte_Planificación_Produccion";
        public static string CostosMaterialesNoBrindados = "Prod.UDP_CostosMaterialesNoBrindados";
        public static string Consumo_Materiales = "Prod.UDP_Reporte_Consumo_Materiales";
        public static string MaquinasUso = "Prod.UDP_Reporte_MaquinaUso";
        public static string OrdenesCompraFecha = "Prod.UDP_Reporte_OrdenesDeCompraFecha";
        public static string Inventario = "Prod.UDP_Reporte_Inventaro";
        public static string Importaciones = "adua.UDP_Reporte_Importaciones";
        public static string DevaPendiente = "adua.UDP_Reporte_DevasPendientes";
        public static string MateriasDePO = "Prod.UDP_Reportes_MateriasDePO";
        public static string ProduccionAreas = "Prod.UDP_Reporte_ProduccionAreas";
        public static string MaterialesIngreso = "Prod.UDP_Reportes_MaterialesIngreso";

        public static string Contrato_PN = "Adua.UDP_Reporte_Contratos_Persona_Natural_Por_Fecha";
        public static string Contrato_PJ = "Adua.UDP_Reporte_Contratos_Persona_Juridica_Por_Fecha";
        public static string Contrato_CI = "Adua.UDP_Reporte_Contratos_Comerciante_Individual_Por_Fecha";

        public static string SeguimientoProcesos = "Prod.UDP_ReporteSeguimientoProcesosPO";
        public static string ExportacionPorPais = "Adua.UDP_ExportacionesPorPais";

        #endregion

    }
}


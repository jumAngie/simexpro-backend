using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class DucaViewModel
    {
        public int duca_Id { get; set; } 
        public string duca_No_Duca { get; set; }
        public string duca_No_Correlativo_Referencia { get; set; }
        public int duca_AduanaRegistro { get; set; }
        public int duca_AduanaDestino { get; set; }
        public string duca_DomicilioFiscal_Exportador { get; set; }
        public int duca_Tipo_Iden_Exportador { get; set; }
        public int duca_Pais_Emision_Exportador { get; set; }
        public string duca_Numero_Id_Importador { get; set; }
        public int duca_Pais_Emision_Importador { get; set; }
        public string duca_DomicilioFiscal_Importador { get; set; }
        public int duca_Regimen_Aduanero { get; set; }
        public string tran_IdUnidadTransporte { get; set; }

        public string emba_Codigo { get; set; }
        public string tran_TamanioEquipamiento { get; set; }
        public string duca_Modalidad { get; set; }
        public string duca_Clase { get; set; }
        public string duca_Codigo_Declarante { get; set; }
        public string duca_Numero_Id_Declarante { get; set; }
        public string duca_NombreSocial_Declarante { get; set; }
        public string duca_DomicilioFiscal_Declarante { get; set; }
        public int duca_Pais_Procedencia { get; set; }
        public int duca_Pais_Exportacion { get; set; }
        public int duca_Pais_Destino { get; set; }
        public string duca_Deposito_Aduanero { get; set; }
        public int? duca_Lugar_Desembarque { get; set; }
        public string duca_Manifiesto { get; set; }
        public string duca_Titulo { get; set; }
        public string duca_Codigo_Transportista { get; set; }
        public decimal? duca_PesoBrutoTotal { get; set; }
        public decimal? duca_PesoNetoTotal { get; set; }
        public int? motr_Id { get; set; }
        public string duca_Transportista_Nombre { get; set; }
        public int? duca_Conductor_Id { get; set; }
        public string duca_Codigo_Tipo_Documento { get; set; }
        public DateTime duca_FechaVencimiento { get; set; }
        public string duca_CanalAsignado { get; set; }
        public string duca_Ventaja { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime duca_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? duca_FechaModificacion { get; set; }
        public bool? duca_Estado { get; set; }
        public bool duca_Finalizado { get; set; }

        public DateTime deva_FechaAceptacion { get; set; }

       
        public string decl_NumeroIdentificacion { get; set; }

       
        public string tipo_identidad_exportador_descripcion { get; set; }

       
        public string Nombre_pais_exportador { get; set; }

       
        public string decl_Nombre_Raso { get; set; }

       
        public string Nombre_Aduana_Registro { get; set; }

       
        public string Nombre_Aduana_Salida { get; set; }

       
        public int deva_AduanaIngresoId { get; set; }

       
        public string Nombre_Aduana_Ingreso { get; set; }

       
        public int deva_AduanaDespachoId { get; set; }

       
        public string Nombre_Aduana_Despacho { get; set; }

       
        public string Nombre_pais_importador { get; set; }

       
        public string Nombre_pais_procedencia { get; set; }

       
        public string Nombre_pais_exportacion { get; set; }

       
        public string Nombre_pais_destino { get; set; }



       
        public int cont_Id { get; set; }

       
        public string cont_Licencia { get; set; }

       
        public string Nombre_pais_conductor { get; set; }

        public string cont_NoIdentificacion { get; set; }

        public string cont_Nombre { get; set; }

       
        public string cont_Apellido { get; set; }

       
        public int pais_IdExpedicion { get; set; }



       
        public int tran_Id { get; set; }

       
        public int Id_pais_transporte { get; set; }

       
        public string Nombre_pais_transporte { get; set; }

       
        public int marca_Id { get; set; }

       
        public int Transporte_marca_Id { get; set; }

       
        public string Transporte_marc_Descripcion { get; set; }

       
        public string tran_Chasis { get; set; }

       
        public string tran_Remolque { get; set; }

       
        public int tran_CantCarga { get; set; }

       
        public int tran_NumDispositivoSeguridad { get; set; }

       
        public string tran_Equipamiento { get; set; }

       
        public string tran_TipoCarga { get; set; }

       
        public string tran_IdContenedor { get; set; }

       
        public decimal base_Gasto_TransporteM_Importada { get; set; }

       
        public decimal base_Costos_Seguro { get; set; }

       
        public int baseCalculos_inco_Id { get; set; }

       
        public string baseCalculos_inco_Descripcion { get; set; }

       
        public decimal base_Valor_Aduana { get; set; }

       
        public decimal deva_ConversionDolares { get; set; }

       
        public string usua_NombreCreacion { get; set; }

       
        public string usua_NombreModificacion { get; set; }

    }
}

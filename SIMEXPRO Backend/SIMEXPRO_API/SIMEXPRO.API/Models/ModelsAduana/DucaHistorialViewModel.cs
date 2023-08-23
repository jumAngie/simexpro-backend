using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class DucaHistorialViewModel
    {
        public int hduc_Id { get; set; }
        public string duca_No_Duca { get; set; }
        public string duca_No_Correlativo_Referencia { get; set; }
        public int deva_Id { get; set; }
        public int duca_AduanaRegistro { get; set; }
        public int duca_AduanaSalida { get; set; }
        public string duca_DomicilioFiscal_Exportador { get; set; }
        public string duca_Tipo_Iden_Exportador { get; set; }
        public int duca_Pais_Emision_Exportador { get; set; }
        public string duca_Numero_Id_Importador { get; set; }
        public int duca_Pais_Emision_Importador { get; set; }
        public string duca_DomicilioFiscal_Importador { get; set; }
        public string duca_Regimen_Aduanero { get; set; }
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
        public string duca_Lugar_Embarque { get; set; }
        public string duca_Lugar_Desembarque { get; set; }
        public string duca_Manifiesto { get; set; }
        public string duca_Titulo { get; set; }
        public string duca_Codigo_Transportista { get; set; }
        public int? motr_id { get; set; }
        public string duca_Transportista_Nombre { get; set; }
        public int? duca_Conductor_Id { get; set; }
        public string duca_Codigo_Tipo_Documento { get; set; }
        public int? hduc_UsuarioAccion { get; set; }
        public DateTime hduc_FechaAccion { get; set; }
        public string hduc_Accion { get; set; }
    }
}

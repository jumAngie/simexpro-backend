using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ItemsHistorialViewModel
    {
        public int hite_Id { get; set; }
        public int? item_Id { get; set; }
        public int? fact_Id { get; set; }
        public int? item_Cantidad { get; set; }
        public decimal? item_PesoNeto { get; set; }
        public decimal? item_PesoBruto { get; set; }
        public int? unme_Id { get; set; }
        public string item_IdentificacionComercialMercancias { get; set; }
        public string item_CaracteristicasMercancias { get; set; }
        public string item_Marca { get; set; }
        public string item_Modelo { get; set; }
        public int? merc_Id { get; set; }
        public int? pais_IdOrigenMercancia { get; set; }
        public string item_ClasificacionArancelaria { get; set; }
        public decimal? item_ValorUnitario { get; set; }
        public decimal? item_GastosDeTransporte { get; set; }
        public decimal? item_ValorTransaccion { get; set; }
        public decimal? item_Seguro { get; set; }
        public decimal? item_OtrosGastos { get; set; }
        public decimal? item_ValorAduana { get; set; }
        public decimal? item_CuotaContingente { get; set; }
        public string item_ReglasAccesorias { get; set; }
        public string item_CriterioCertificarOrigen { get; set; }
        public int? hduc_UsuarioAccion { get; set; }
        public DateTime? hduc_FechaAccion { get; set; }
        public string hduc_Accion { get; set; }
    }
}

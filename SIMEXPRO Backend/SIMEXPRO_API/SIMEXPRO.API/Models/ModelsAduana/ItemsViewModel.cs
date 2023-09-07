using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ItemsViewModel
    {
        public int item_Id { get; set; }
        public int fact_Id { get; set; }
        public int item_Cantidad { get; set; }
        public int item_Cantidad_Bultos { get; set; }
        public string item_ClaseBulto { get; set; }
        public string item_Acuerdo { get; set; }
        public decimal? item_PesoNeto { get; set; }
        public decimal? item_PesoBruto { get; set; }
        public int unme_Id { get; set; }
        public string item_IdentificacionComercialMercancias { get; set; }
        public string item_CaracteristicasMercancias { get; set; }
        public string item_Marca { get; set; }
        public string item_Modelo { get; set; }
        public int merc_Id { get; set; }
        public int? pais_IdOrigenMercancia { get; set; }
        public string item_ClasificacionArancelaria { get; set; }
        public int? aran_Id { get; set; }
        public string aran_Descripcion { get; set; }
        public string aran_Codigo { get; set; }
        public decimal? item_ValorUnitario { get; set; }
        public decimal? item_GastosDeTransporte { get; set; }
        public decimal? item_ValorTransaccion { get; set; }
        public decimal? item_Seguro { get; set; }
        public decimal? item_OtrosGastos { get; set; }
        public decimal? item_ValorAduana { get; set; }
        public decimal? item_CuotaContingente { get; set; }
        public string item_ReglasAccesorias { get; set; }
        public string item_CriterioCertificarOrigen { get; set; }
        public int usua_UsuarioCreacion { get; set; }

         public string usuarioCreacionNombre { get; set; }
        public DateTime item_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }

         public string usuarioModificacionNombre { get; set; }

         public int? usua_UsuarioEliminacion { get; set; }
        public DateTime item_FechaEliminacion { get; set; }

        public DateTime? item_FechaModificacion { get; set; }
        public bool? item_Estado { get; set; }
    }
}

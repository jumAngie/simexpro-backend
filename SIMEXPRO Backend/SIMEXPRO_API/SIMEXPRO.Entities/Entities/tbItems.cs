
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbItems
    {
        public tbItems()
        {
            tbLiquidacionPorLinea = new HashSet<tbLiquidacionPorLinea>();
        }

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
        [NotMapped]
        public string NombrePaisOrigen { get; set; }
        [NotMapped]
        public int? aran_Id { get; set; }
        [NotMapped]
        public string aran_Descripcion { get; set; }
        [NotMapped]
        public string aran_Codigo { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime item_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        [NotMapped]
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime item_FechaEliminacion { get; set; }

        public DateTime? item_FechaModificacion { get; set; }
        public bool? item_Estado { get; set; }

        public virtual tbFacturas fact { get; set; }
        public virtual tbAranceles aran { get; set; }
        public virtual tbEstadoMercancias merc { get; set; }
        public virtual tbPaises pais_IdOrigenMercanciaNavigation { get; set; }
        public virtual tbUnidadMedidas unme { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbLiquidacionPorLinea> tbLiquidacionPorLinea { get; set; }
    }
}
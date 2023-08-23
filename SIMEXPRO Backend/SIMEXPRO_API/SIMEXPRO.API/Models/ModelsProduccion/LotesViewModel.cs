using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class LotesViewModel
    {
        public int lote_Id { get; set; }
        public int mate_Id { get; set; }
        public int unme_Id { get; set; }
        public int lote_Stock { get; set; }
        public int? prod_Id { get; set; }
        public int lote_CantIngresada { get; set; }
        public string lote_Observaciones { get; set; }
        public int tipa_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime lote_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? lote_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? lote_FechaEliminacion { get; set; }
        public bool? lote_Estado { get; set; }

        public string unme_Descripcion { get; set; }
        public string mate_Descripcion { get; set; }
        public string tipa_area { get; set; }
        public int peor_Id { get; set; }
        public string prov_NombreCompania { get; set; }
        public string prov_NombreContacto { get; set; }
        public string prov_DireccionExacta { get; set; }
        public string UsuarioCreacionNombre { get; set; }
        public string UsuarioModificacionNombre { get; set; }
        public string UsuarioEliminacionNombre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class PedidosProduccionDetalleViewModel
    {
        public int ppde_Id { get; set; }
        public int ppro_Id { get; set; }
        public int lote_Id { get; set; }
        public string lote_Stock { get; set; }
        public string lote_CodigoLote { get; set; }
        public int ppde_Cantidad { get; set; }
        public int mate_Id { get; set; }
        public string mate_Descripcion { get; set; }
        public string colr_Codigo { get; set; }
        public string colr_Nombre { get; set; }
        public int tipa_Id { get; set; }
        public string tipa_area { get; set; }
        public string ppro_Estados { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public string usuarioCreacionNombre { get; set; }
        public DateTime ppde_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public DateTime? ppde_FechaModificacion { get; set; }
        public bool? ppde_Estado { get; set; }

    }
}

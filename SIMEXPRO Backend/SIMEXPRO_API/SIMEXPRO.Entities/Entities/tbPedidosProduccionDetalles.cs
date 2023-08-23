
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPedidosProduccionDetalles
    {
        public int ppde_Id { get; set; }
        public int ppro_Id { get; set; }
        public int lote_Id { get; set; }
        [NotMapped]
        public string lote_Stock { get; set; }
        public int ppde_Cantidad { get; set; }
        [NotMapped]
        public int mate_Id { get; set; }
        [NotMapped]
        public string mate_Descripcion { get; set; }
        [NotMapped]
        public int tipa_Id { get; set; }
        [NotMapped]
        public string tipa_area { get; set; }
        [NotMapped]
        public string ppro_Estados { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime ppde_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime? ppde_FechaModificacion { get; set; }
        public bool? ppde_Estado { get; set; }

        public virtual tbLotes lote { get; set; }
        public virtual tbPedidosProduccion ppro { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
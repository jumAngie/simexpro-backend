
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbLotes
    {
        public tbLotes()
        {
            tbAsignacionesOrdenDetalle = new HashSet<tbAsignacionesOrdenDetalle>();
            tbPedidosProduccionDetalles = new HashSet<tbPedidosProduccionDetalles>();
        }

        public int lote_Id { get; set; }
        public int mate_Id { get; set; }
        public int unme_Id { get; set; }
        public int? prod_Id { get; set; }
        public int lote_Stock { get; set; }
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
        
        [NotMapped]
        public string unme_Descripcion { get; set; }
        [NotMapped]
        public string mate_Descripcion { get; set; }
        [NotMapped]
        public string tipa_area { get; set; }
        [NotMapped]
        public int peor_Id { get; set; }
        [NotMapped]
        public string prov_NombreCompania { get; set; }
        [NotMapped]
        public string prov_NombreContacto { get; set; }
        [NotMapped]
        public string prov_DireccionExacta { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        [NotMapped]
        public string UsuarioEliminacionNombre { get; set; }

        public virtual tbPedidosOrdenDetalle prod { get; set; }
        public virtual tbMateriales mate { get; set; }
        public virtual tbArea tipa { get; set; }
        public virtual tbUnidadMedidas unme { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbAsignacionesOrdenDetalle> tbAsignacionesOrdenDetalle { get; set; }
        public virtual ICollection<tbPedidosProduccionDetalles> tbPedidosProduccionDetalles { get; set; }
    }
}
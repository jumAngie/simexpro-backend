
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbTallas
    {
        public tbTallas()
        {
            tbOrdenCompraDetalles = new HashSet<tbOrdenCompraDetalles>();
        }

        public int tall_Id { get; set; }
        public string tall_Codigo { get; set; }
        public string tall_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime tall_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tall_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? tall_FechaEliminacion { get; set; }
        public bool? tall_Estado { get; set; }

        [NotMapped]
        public string usarioCreacion { get; set; }

        [NotMapped]
        public string usuarioModificacion { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOrdenCompraDetalles> tbOrdenCompraDetalles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbTipoEmbalaje
    {
        public tbTipoEmbalaje()
        {
            tbOrdenCompra = new HashSet<tbOrdenCompra>();
        }

        public int tiem_Id { get; set; }
        public string tiem_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime tiem_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tiem_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? tiem_FechaEliminacion { get; set; }
        public bool? tiem_Estado { get; set; }

        [NotMapped]
        public string usarioCreacion { get; set; }

        [NotMapped]
        public string usuarioModificacion { get; set; }

        [NotMapped]
        public string usuarioEliminacion { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOrdenCompra> tbOrdenCompra { get; set; }
    }
}
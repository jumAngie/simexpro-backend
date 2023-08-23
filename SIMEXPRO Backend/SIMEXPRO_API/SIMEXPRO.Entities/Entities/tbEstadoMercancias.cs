
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbEstadoMercancias
    {
        public tbEstadoMercancias()
        {
            tbItems = new HashSet<tbItems>();
        }

        public int merc_Id { get; set; }
        public string merc_Codigo { get; set; }
        public string merc_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime merc_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? merc_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? merc_FechaEliminacion { get; set; }
        public bool? merc_Estado { get; set; }

        [NotMapped]
        public string usua_NombreCreacion { get; set; }

        [NotMapped]
        public string usua_NombreModificacion { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbItems> tbItems { get; set; }
    }
}
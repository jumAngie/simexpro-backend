
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbOficio_Profesiones
    {
        public tbOficio_Profesiones()
        {
            tbPersonasofpr = new HashSet<tbPersonas>();
            tbPersonaspers_OfprRepresentanteNavigation = new HashSet<tbPersonas>();
        }

        public int ofpr_Id { get; set; }
        public string ofpr_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime ofpr_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? ofpr_FechaModificacion { get; set; }
        public bool? ofpr_Estado { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPersonas> tbPersonasofpr { get; set; }
        public virtual ICollection<tbPersonas> tbPersonaspers_OfprRepresentanteNavigation { get; set; }
    }
}
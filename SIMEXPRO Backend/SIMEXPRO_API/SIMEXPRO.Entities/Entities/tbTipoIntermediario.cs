
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbTipoIntermediario
    {
        public tbTipoIntermediario()
        {
            tbIntermediarios = new HashSet<tbIntermediarios>();
        }

        public int tite_Id { get; set; }
        public string tite_Codigo { get; set; }
        public string tite_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime tite_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tite_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? tite_FechaEliminacion { get; set; }
        public bool? tite_Estado { get; set; }

        [NotMapped]
        public string usarioCreacion { get; set; }

        [NotMapped]
        public string usuarioModificacion { get; set; }

 

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbIntermediarios> tbIntermediarios { get; set; }
    }
}
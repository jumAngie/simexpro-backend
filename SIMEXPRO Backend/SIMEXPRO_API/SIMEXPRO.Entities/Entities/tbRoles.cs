
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbRoles
    {
        public tbRoles()
        {
            tbRolesXPantallas = new HashSet<tbRolesXPantallas>();
        }

        public int role_Id { get; set; }
        public string role_Descripcion { get; set; }
        public bool role_Aduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }

        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }


        [NotMapped]
        public string Aduanero { get; set; }

        [NotMapped]
        public string Detalles { get; set; }
        [NotMapped]
        public string pant_Ids { get; set; }
        public DateTime role_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? role_FechaModificacion { get; set; }

        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }


        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? role_FechaEliminacion { get; set; }
        public bool? role_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRolesXPantallas> tbRolesXPantallas { get; set; }
    }
}
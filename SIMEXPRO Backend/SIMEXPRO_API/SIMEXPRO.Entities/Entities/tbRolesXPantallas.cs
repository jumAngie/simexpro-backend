
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbRolesXPantallas
    {
        public int ropa_Id { get; set; }
        public int? pant_Id { get; set; }
        [NotMapped]
        public string pant_Nombre { get; set; }
        [NotMapped]
        public string pant_URL { get; set; }
        [NotMapped]
        public string pant_Icono { get; set; }
        [NotMapped]
        public string pant_Esquema { get; set; }
        [NotMapped]
        public bool? pant_EsAduana { get; set; }
        [NotMapped]
        public string pant_Subcategoria { get; set; }
        public int? role_Id { get; set; }
        [NotMapped]
        public string Asignada { get; set; }
        public string pant_Identificador { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime ropa_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? ropa_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? ropa_FechaEliminacion { get; set; }
        public bool? ropa_Estado { get; set; }

        public virtual tbPantallas pant { get; set; }
        public virtual tbRoles role { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
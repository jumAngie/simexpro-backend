
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPantallas
    {

        public tbPantallas()
        {
            tbRolesXPantallas = new HashSet<tbRolesXPantallas>();
        }

        public int pant_Id { get; set; }
        public string pant_Nombre { get; set; }
        public string pant_URL { get; set; }
        public string pant_Icono { get; set; }
        public string pant_Esquema { get; set; }
        public string pant_Identificador { get; set; }
        public string pant_Subcategoria { get; set; }
        [NotMapped]
        public string Detalles { get; set; }
        public bool? pant_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime pant_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? pant_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? pant_FechaEliminacion { get; set; }
        public bool? pant_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRolesXPantallas> tbRolesXPantallas { get; set; }
    }
}
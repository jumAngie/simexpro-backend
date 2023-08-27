using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAcceso
{
    public class RolesPorPantallasViewModel
    {
        public int ropa_Id { get; set; }
        public int? pant_Id { get; set; }
        public string pant_Nombre { get; set; }
        public string pant_URL { get; set; }
        public string pant_Icono { get; set; }
        public string pant_Esquema { get; set; }
        public string pant_Subcategoria { get; set; }
        public string pant_Identificador { get; set; }
        public bool? pant_EsAduana { get; set; }
        public int? role_Id { get; set; }
        public string Asignada { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime ropa_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? ropa_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? ropa_FechaEliminacion { get; set; }
        public bool? ropa_Estado { get; set; }
    }
}

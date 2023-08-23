using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class ProveedoresViewModel
    {
        public int prov_Id { get; set; }
        public string prov_NombreCompania { get; set; }
        public string prov_NombreContacto { get; set; }
        public string prov_Telefono { get; set; }
        public string prov_CodigoPostal { get; set; }
        public int prov_Ciudad { get; set; }
         public string ciud_Nombre { get; set; }
        public string pvin_Id { get; set; }
        public string pvin_Nombre { get; set; }
        public string pais_Nombre { get; set; }

         public string pais_Codigo { get; set; }
        public string pais_Id { get; set; }
        public string prov_DireccionExacta { get; set; }
        public string prov_CorreoElectronico { get; set; }
        public string prov_Fax { get; set; }
        public string UsuarioCreacionNombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime prov_FechaCreacion { get; set; }
        public string UsuarioModificadorNombre { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? prov_FechaModificacion { get; set; }
        public string UsuarioEliminacionNombre { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? prov_FechaEliminacion { get; set; }
        public bool? prov_Estado { get; set; }

    }
}

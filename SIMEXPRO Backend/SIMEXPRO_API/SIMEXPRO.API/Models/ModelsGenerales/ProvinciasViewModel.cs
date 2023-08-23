using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class ProvinciasViewModel
    {

        public int pvin_Id { get; set; }
        public string pvin_Nombre { get; set; }
        public string pvin_Codigo { get; set; }
        public int pais_Id { get; set; }
        public bool pvin_EsAduana { get; set; }

         public string pais_Nombre { get; set; }

        public int usua_UsuarioCreacion { get; set; }

         public string UsuarioCreacionNombre { get; set; }

        public DateTime pvin_FechaCreacion { get; set; }

        public int? usua_UsuarioModificacion { get; set; }

         public string UsuarioModificadorNombre { get; set; }

        public DateTime? pvin_FechaModificacion { get; set; }

        public int? usua_UsuarioEliminacion { get; set; }

        public DateTime? pvin_FechaEliminacion { get; set; }

        public bool? pvin_Estado { get; set; }
    }
}

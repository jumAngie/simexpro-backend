using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class RegimenesAduanerosViewModel
    {
        public int regi_Id { get; set; }
        public string regi_Codigo { get; set; }
        public string regi_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime regi_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? regi_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? regi_FechaEliminacion { get; set; }
        public bool? regi_Estado { get; set; }
        public string usuarioCreacionNombre { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public string usuarioEliminacionNombre { get; set; }
    }
}

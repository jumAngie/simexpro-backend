using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class MaquinasViewModel
    {
        public int maqu_Id { get; set; }
        public string maqu_NumeroSerie { get; set; }
        public int mmaq_Id { get; set; }
        public int modu_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime maqu_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? maqu_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? maqu_FechaEliminacion { get; set; }
        public bool? maqu_Estado { get; set; }

        public string mmaq_Nombre { get; set; }
        public string modu_Nombre { get; set; }
        public string usuarioCreacionNombre { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public string usuarioEliminacionNombre { get; set; }
    }
}

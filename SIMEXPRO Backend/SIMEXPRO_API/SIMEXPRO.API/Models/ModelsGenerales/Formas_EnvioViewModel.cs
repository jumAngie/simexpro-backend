using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class Formas_EnvioViewModel
    {

        public int foen_Id { get; set; }
        public string foen_Codigo { get; set; }
        public string foen_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime foen_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? foen_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }

         public string UsuarioCreacionNombre { get; set; }

         public string UsuarioModificacionNombre { get; set; }

         public string UsuarioEliminacionNombre { get; set; }
        public DateTime? foen_FechaEliminacion { get; set; }
        public bool? foen_Estado { get; set; }
    }
}

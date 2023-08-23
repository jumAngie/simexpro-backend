using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class FacturasViewModel
    {
        public int fact_Id { get; set; }
        public int deva_Id { get; set; }
        public string fact_Numero { get; set; }
        public DateTime fact_Fecha { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime fact_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? fact_FechaModificacion { get; set; }
        public bool? fact_Estado { get; set; }

         public string usuarioCreacionNombre { get; set; }
         public string usuarioModificacionNombre { get; set; }
    }
}

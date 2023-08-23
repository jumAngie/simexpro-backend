using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class EstadoBoletinViewModel
    {
        public int esbo_Id { get; set; }
        public string esbo_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime esbo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? esbo_FechaModificacion { get; set; }
        public bool? esbo_Estadoo { get; set; }

        public string usua_NombreCreacion { get; set; }
        public string usua_NombreModificacion { get; set; }
    }
}

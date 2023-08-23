using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ModoTransporteViewModel
    {
        public int motr_Id { get; set; }
        public string motr_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime motr_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? motr_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? motr_FechaEliminacion { get; set; }
        public bool? motr_Estado { get; set; }


        public string usuarioCreacionNombre { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public string usuarioEliminacionNombre { get; set; }
    }
}

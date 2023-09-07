using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class ColoresViewModel
    {
        public int colr_Id { get; set; }
        public string colr_Nombre { get; set; }
        public string colr_Codigo { get; set; }
        public string colr_CodigoHtml { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioNombreCreacion { get; set; }
        public DateTime colr_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioNombreModificacion { get; set; }
        public DateTime? colr_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string UsuarioNombreEliminacion { get; set; }
        public DateTime? colr_FechaEliminacion { get; set; }
        public bool? colr_Estado { get; set; }


    }
}

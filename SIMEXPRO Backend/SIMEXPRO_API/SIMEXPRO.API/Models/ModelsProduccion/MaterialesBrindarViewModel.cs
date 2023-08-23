using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class MaterialesBrindarViewModel
    {
        public int mabr_Id { get; set; }
        public int code_Id { get; set; }
        [NotMapped]
        public string code_CantidadPrenda { get; set; }
        public int mate_Id { get; set; }
        [NotMapped]
        public string mate_Descripcion { get; set; }
        public int mabr_Cantidad { get; set; }

        public int unme_Id { get; set; }

        [NotMapped]
        public string unme_Descripcion { get; set; }

        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime mabr_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime? mabr_FechaModificacion { get; set; }
        public bool? mabr_Estado { get; set; }

    }
}

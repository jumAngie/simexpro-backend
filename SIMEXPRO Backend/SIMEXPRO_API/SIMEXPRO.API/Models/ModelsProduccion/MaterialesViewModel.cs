using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class MaterialesViewModel
    {
        public int mate_Id { get; set; }
        public string mate_Descripcion { get; set; }
        public int? subc_Id { get; set; }
        public string subc_Descripcion { get; set; }
        public int cate_Id { get; set; }
        public string cate_Descripcion { get; set; }
        public int colr_Id { get; set; }
        public string colr_Nombre { get; set; }
        //   public decimal? mate_Precio { get; set; }
        public string mate_Imagen { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public string usuarioCreacionNombre { get; set; }
        public DateTime mate_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public string usuarioModificaNombre { get; set; }
        public DateTime? mate_FechaModificacion { get; set; }
        public bool? mate_Estado { get; set; }
    }
}

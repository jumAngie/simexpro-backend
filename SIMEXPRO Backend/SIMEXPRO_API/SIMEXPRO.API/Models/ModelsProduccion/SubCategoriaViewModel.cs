using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class SubCategoriaViewModel
    {
        public int subc_Id { get; set; }
        public string subc_Descripcion { get; set; }
        public int? cate_Id { get; set; }
        [NotMapped]
        public string cate_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime subc_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificaNombre { get; set; }
        public DateTime? subc_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string usuarioEliminaNombre { get; set; }
        public DateTime? subc_FechaEliminacion { get; set; }
        public bool? subc_Estado { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class MarcasMaquinaViewModel
    {
        public int marq_Id { get; set; }
        public string marq_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacion { get; set; }
        public DateTime marq_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificador { get; set; }
        public DateTime? marq_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string UsuarioEliminacion { get; set; }
        public DateTime? marq_FechaEliminacion { get; set; }
        public bool? marq_Estado { get; set; }

    }
}

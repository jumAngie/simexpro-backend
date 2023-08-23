using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class ProcesoPorOrdenCompraDetalleViewModel
    {
        public int poco_Id { get; set; }
        public int code_Id { get; set; }
        public int proc_Id { get; set; }
        public string proc_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime poco_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? poco_FechaModificacion { get; set; }
        public bool? code_Estado { get; set; }
    }
}

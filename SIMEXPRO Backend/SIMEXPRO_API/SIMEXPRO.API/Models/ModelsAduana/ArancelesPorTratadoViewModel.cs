using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ArancelesPorTratadoViewModel
    {
        public int axtl_Id { get; set; }
        public int aran_Id { get; set; }
        public int trli_Id { get; set; }
        [NotMapped]
        public string aran_Codigo { get; set; }
        [NotMapped]
        public string aran_Descripcion { get; set; }
        [NotMapped]
        public string trli_NombreTratado { get; set; }
        public decimal axtl_TasaActual { get; set; }
        public int usua_usuarioCreacion { get; set; }
        public DateTime axtl_FechaCreacion { get; set; }

    }
}

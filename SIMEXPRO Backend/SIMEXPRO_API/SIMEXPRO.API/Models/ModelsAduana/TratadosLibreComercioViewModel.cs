using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class TratadosLibreComercioViewModel
    {
        public int trli_Id { get; set; }
        public string trli_NombreTratado { get; set; }
        public DateTime trli_FechaInicio { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime trli_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? trli_FechaModificacion { get; set; }
    }
}

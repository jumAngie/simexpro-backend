using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class ReporteModuloDiaViewModel
    {
        public int remo_Id { get; set; }
        public int modu_Id { get; set; }
        public string modu_Nombre { get; set; }

        public DateTime remo_Fecha { get; set; }
        public int remo_TotalDia { get; set; }
        public int remo_TotalDanado { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime remo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? remo_FechaModificacion { get; set; }
        public bool? remo_Estado { get; set; }

         public string usua_UsuarioCrea { get; set; }
         public string usua_UsuarioModifica { get; set; }

    }
}

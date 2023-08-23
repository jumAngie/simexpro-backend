using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class DocumentosOrdenCompraDetallesViewModel
    {

        public int dopo_Id { get; set; }
        public int code_Id { get; set; }
        public string dopo_Archivo { get; set; }
        public string dopo_TipoArchivo { get; set; }
        public int usua_UsuarioCreacion { get; set; }

        public string UsuarioCreacionNombre { get; set; }
        public DateTime dopo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }

        public string UsuarioModificacionNombre { get; set; }
        public DateTime? dopo_FechaModificacion { get; set; }
        public bool? code_Estado { get; set; }

    }
}

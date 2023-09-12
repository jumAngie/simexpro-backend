using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class DocumentosSancionesViewModel
    {
        public int dosa_Id { get; set; }
        public string dosa_NombreDocumento { get; set; }
        public string dosa_UrlDocumento { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime dosa_FechaCreacion { get; set; }
    }
}

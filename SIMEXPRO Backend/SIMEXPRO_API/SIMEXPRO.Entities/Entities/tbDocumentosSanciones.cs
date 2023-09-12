
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbDocumentosSanciones
    {
        public int dosa_Id { get; set; }
        public string dosa_NombreDocumento { get; set; }
        public string dosa_UrlDocumento { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime dosa_FechaCreacion { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
    }
}
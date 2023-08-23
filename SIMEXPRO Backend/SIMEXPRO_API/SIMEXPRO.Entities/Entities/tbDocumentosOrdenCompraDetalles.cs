
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbDocumentosOrdenCompraDetalles
    {
        public int dopo_Id { get; set; }
        public int code_Id { get; set; }
        public string dopo_Archivo { get; set; }
        public string dopo_TipoArchivo { get; set; }
        public int usua_UsuarioCreacion { get; set; }

        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        public DateTime dopo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }

        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        public DateTime? dopo_FechaModificacion { get; set; }
        public bool? code_Estado { get; set; }

        public virtual tbOrdenCompraDetalles code { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
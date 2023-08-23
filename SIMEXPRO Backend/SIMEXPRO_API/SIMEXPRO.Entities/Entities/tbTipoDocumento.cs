
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbTipoDocumento
    {
        public tbTipoDocumento()
        {
            tbDocumentosDeSoporte = new HashSet<tbDocumentosDeSoporte>();
        }

        public int tido_Id { get; set; }
        public string tido_Codigo { get; set; }
        public string tido_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string? usarioCreacion { get; set; }
        public DateTime tido_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string? usuarioModificacion { get; set; }

        public DateTime? tido_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? tido_FechaEliminacion { get; set; }
        public bool? tido_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosDeSoporte> tbDocumentosDeSoporte { get; set; }
    }
}
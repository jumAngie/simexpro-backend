
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbConceptoPago
    {
        public int copa_Id { get; set; }
        public string copa_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuaCreacion { get; set; }
        public DateTime copa_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string? usuaModificacion { get; set; }
        public DateTime? copa_FechaModificacion { get; set; }
        public bool? copa_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
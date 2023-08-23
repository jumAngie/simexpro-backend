
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbMaquinaHistorial
    {
        public int mahi_Id { get; set; }
        public int maqu_Id { get; set; }

        [NotMapped]
        public string MaquinaNumeroSerie { get; set; }
        public DateTime mahi_FechaInicio { get; set; }
        public DateTime mahi_FechaFin { get; set; }
        public string mahi_Observaciones { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime mahi_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? mahi_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? mahi_FechaEliminacion { get; set; }
        public bool? mahi_Estado { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        [NotMapped]
        public string usuarioModificaNombre { get; set; }
        [NotMapped]
        public string usuarioEliminaNombre { get; set; }

        public virtual tbMaquinas maqu { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
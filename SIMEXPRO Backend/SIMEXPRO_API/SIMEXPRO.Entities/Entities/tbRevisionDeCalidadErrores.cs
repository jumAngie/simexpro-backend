
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbRevisionDeCalidadErrores
    {
        public tbRevisionDeCalidadErrores()
        {
            tbRevisionDeCalidad = new HashSet<tbRevisionDeCalidad>();
        }

        public int rcer_Id { get; set; }
        public string rcer_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime rcer_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? rcer_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? rcer_FechaEliminacion { get; set; }
        public bool? rcer_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }

        public virtual ICollection<tbRevisionDeCalidad> tbRevisionDeCalidad { get; set; }

    }
}
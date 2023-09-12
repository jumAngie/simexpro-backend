
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbRegimenesAduaneros
    {
        public tbRegimenesAduaneros()
        {
            tbDuca = new HashSet<tbDuca>();
        }

        public int regi_Id { get; set; }
        public string regi_Codigo { get; set; }
        public string regi_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime regi_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? regi_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? regi_FechaEliminacion { get; set; }
        public bool? regi_Estado { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        [NotMapped]
        public string usuarioEliminacionNombre { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }

        public virtual ICollection<tbDuca> tbDuca { get; set; }
    }
}
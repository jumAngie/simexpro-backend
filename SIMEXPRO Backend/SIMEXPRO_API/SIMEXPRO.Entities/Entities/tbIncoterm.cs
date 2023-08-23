
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbIncoterm
    {
        public tbIncoterm()
        {
            tbDeclaraciones_Valor = new HashSet<tbDeclaraciones_Valor>();
        }

        public int inco_Id { get; set; }
        public string inco_Codigo { get; set; }
        public string inco_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime inco_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? inco_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? inco_FechaEliminacion { get; set; }
        public bool? inco_Estado { get; set; }

        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valor { get; set; }
    }
}
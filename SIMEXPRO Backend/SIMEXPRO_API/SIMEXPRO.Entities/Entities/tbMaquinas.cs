
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbMaquinas
    {
        public tbMaquinas()
        {
            tbMaquinaHistorial = new HashSet<tbMaquinaHistorial>();
        }

        public int maqu_Id { get; set; }
        public string maqu_NumeroSerie { get; set; }
        public int mmaq_Id { get; set; }
        public int modu_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime maqu_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? maqu_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? maqu_FechaEliminacion { get; set; }
        public bool? maqu_Estado { get; set; }
        [NotMapped]
        public DateTime? deshabilitada { get; set; }
        [NotMapped]
        public DateTime? habilitada { get; set; }
        [NotMapped]
        public bool EnUso { get; set; }
        [NotMapped]
        public string mmaq_Nombre { get; set; }

        [NotMapped]
        public string modu_Nombre { get; set; }
      
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        [NotMapped]
        public string usuarioEliminacionNombre { get; set; }
        [NotMapped]
        public string marq_Nombre{ get; set; }

        public virtual tbModelosMaquina mmaq { get; set; }
        public virtual tbModulos modu { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMaquinaHistorial> tbMaquinaHistorial { get; set; }
    }
}
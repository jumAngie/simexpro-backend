
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbEstadosCiviles
    {
        public tbEstadosCiviles()
        {
            tbEmpleados = new HashSet<tbEmpleados>();
            tbPersonasescv = new HashSet<tbPersonas>();
            tbPersonaspers_escvRepresentanteNavigation = new HashSet<tbPersonas>();
        }

        public int escv_Id { get; set; }
        public string escv_Nombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime escv_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? escv_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? escv_FechaEliminacion { get; set; }
        public bool? escv_Estado { get; set; }
        [NotMapped]
        public bool? escv_EsAduana { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        public virtual ICollection<tbPersonas> tbPersonasescv { get; set; }
        public virtual ICollection<tbPersonas> tbPersonaspers_escvRepresentanteNavigation { get; set; }
    }
}
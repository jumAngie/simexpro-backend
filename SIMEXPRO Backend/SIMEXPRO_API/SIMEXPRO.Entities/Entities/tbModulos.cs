
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbModulos
    {
        public tbModulos()
        {
            tbMaquinas = new HashSet<tbMaquinas>();
            tbReporteModuloDia = new HashSet<tbReporteModuloDia>();
            tbOrde_Ensa_Acab_Etiq = new HashSet<tbOrde_Ensa_Acab_Etiq>();
        }

        public int modu_Id { get; set; }
        public string modu_Nombre { get; set; }
        public int proc_Id { get; set; }
        [NotMapped]
        public string proc_Descripcion { get; set; }
        public int empr_Id { get; set; }
        [NotMapped]
        public string empl_NombreCompleto { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacion { get; set; }
        public DateTime modu_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModifica { get; set; }
        public DateTime? modu_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string UsuarioEliminacion { get; set; }
        public DateTime? modu_FechaEliminacion { get; set; }
        public bool? modu_Estado { get; set; }

        public bool? remo_Finalizado { get; set; }

        public virtual tbEmpleados empr { get; set; }
        public virtual tbProcesos proc { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMaquinas> tbMaquinas { get; set; }
        public virtual ICollection<tbReporteModuloDia> tbReporteModuloDia { get; set; }
        public virtual ICollection<tbOrde_Ensa_Acab_Etiq> tbOrde_Ensa_Acab_Etiq { get; set; }
    }
}
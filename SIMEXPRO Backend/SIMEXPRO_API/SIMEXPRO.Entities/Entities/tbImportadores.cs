
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbImportadores
    {
        public tbImportadores()
        {
            tbDeclaraciones_Valor = new HashSet<tbDeclaraciones_Valor>();
            tbImportadoresHistorial = new HashSet<tbImportadoresHistorial>();
        }

        public int impo_Id { get; set; }
        public int nico_Id { get; set; }
        public int decl_Id { get; set; }
        public string impo_NivelComercial_Otro { get; set; }
        public string impo_RTN { get; set; }
        public string impo_NumRegistro { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime impo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? impo_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? impo_FechaEliminacion { get; set; }
        public bool? impo_Estado { get; set; }

        public virtual tbNivelesComerciales nico { get; set; }
        public virtual tbDeclarantes decl { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbImportadoresHistorial> tbImportadoresHistorial { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valor { get; set; }
    }
}
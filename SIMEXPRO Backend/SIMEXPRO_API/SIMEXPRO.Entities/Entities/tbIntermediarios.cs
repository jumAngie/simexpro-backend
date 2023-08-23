
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbIntermediarios
    {
        public tbIntermediarios()
        {
            tbDeclaraciones_Valor = new HashSet<tbDeclaraciones_Valor>();
            tbIntermediariosHistorial = new HashSet<tbIntermediariosHistorial>();
        }

        public int inte_Id { get; set; }
        public int tite_Id { get; set; }
        public string inte_Tipo_Otro { get; set; }
        public int decl_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime inte_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? inte_FechaModificacion { get; set; }
        public int usua_UsuarioEliminacion { get; set; }
        public DateTime inte_FechaEliminacion { get; set; }
        public bool? inte_Estado { get; set; }

        public virtual tbTipoIntermediario tite { get; set; }
        public virtual tbDeclarantes decl { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbIntermediariosHistorial> tbIntermediariosHistorial { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbFormas_Envio
    {
        public tbFormas_Envio()
        {
            tbDeclaraciones_Valor = new HashSet<tbDeclaraciones_Valor>();
        }

        public int foen_Id { get; set; }
        public string foen_Codigo { get; set; }
        public string foen_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime foen_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? foen_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }

        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }

        [NotMapped]
        public string UsuarioEliminacionNombre { get; set; }
        public DateTime? foen_FechaEliminacion { get; set; }
        public bool? foen_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valor { get; set; }
    }
}
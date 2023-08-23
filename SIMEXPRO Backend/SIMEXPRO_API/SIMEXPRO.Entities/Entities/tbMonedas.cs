
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbMonedas
    {
        public tbMonedas()
        {
            tbDeclaraciones_Valor = new HashSet<tbDeclaraciones_Valor>();
        }

        public int mone_Id { get; set; }
        public string mone_Codigo { get; set; }
        public string mone_Descripcion { get; set; }
        public bool mone_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime mone_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime? mone_FechaModificacion { get; set; }
        public bool? mone_Estado { get; set; }


        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valor { get; set; }
    }
}
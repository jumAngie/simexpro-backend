
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbFacturas
    {
        public tbFacturas()
        {
            tbItems = new HashSet<tbItems>();
        }

        public int fact_Id { get; set; }
        public int deva_Id { get; set; }
        public string fact_Numero { get; set; }
        public DateTime fact_Fecha { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime fact_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? fact_FechaModificacion { get; set; }
        public bool? fact_Estado { get; set; }
        
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        public virtual tbDeclaraciones_Valor deva { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbItems> tbItems { get; set; }
    }
}
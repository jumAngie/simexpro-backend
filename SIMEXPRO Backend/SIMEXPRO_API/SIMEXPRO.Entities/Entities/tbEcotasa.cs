
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbEcotasa
    {
        public int ecot_Id { get; set; }
        public decimal ecot_RangoIncial { get; set; }
        public decimal ecot_RangoFinal { get; set; }
        public decimal ecot_CantidadPagar { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime ecot_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? ecot_FechaModificacion { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
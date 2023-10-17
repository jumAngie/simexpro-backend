
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbImpuestosProd
    {
        public int impr_Id { get; set; }
        public string impr_Descripcion { get; set; }
        public decimal? impr_Valor { get; set; }
        public int usua_UsuarioModificacion { get; set; }
        public DateTime impr_FechaModificacion { get; set; }

        [NotMapped]
        public string usuarioNombre { get; set; }

        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
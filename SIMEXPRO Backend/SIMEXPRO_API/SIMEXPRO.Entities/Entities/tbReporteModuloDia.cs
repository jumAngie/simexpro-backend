
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbReporteModuloDia
    {
        public tbReporteModuloDia()
        {
            tbReporteModuloDiaDetalle = new HashSet<tbReporteModuloDiaDetalle>();
        }

        public int remo_Id { get; set; }
        public int modu_Id { get; set; }
        [NotMapped]
        public string modu_Nombre { get; set; }
        public DateTime remo_Fecha { get; set; }
        public int remo_TotalDia { get; set; }
        public int remo_TotalDanado { get; set; }
        [NotMapped]
        public string detalles { get; set; }
        [NotMapped]
        public decimal CantidadTotal { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime remo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? remo_FechaModificacion { get; set; }
        public bool? remo_Estado { get; set; }

        [NotMapped]
        public string usua_UsuarioCrea { get; set; }
        [NotMapped]
        public string usua_UsuarioModifica { get; set; }

        public virtual tbModulos modu { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbReporteModuloDiaDetalle> tbReporteModuloDiaDetalle { get; set; }
    }
}
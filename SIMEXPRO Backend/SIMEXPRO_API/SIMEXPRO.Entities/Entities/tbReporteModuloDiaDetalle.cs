
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbReporteModuloDiaDetalle
    {
        public int rdet_Id { get; set; }
        public int remo_Id { get; set; }
        public int rdet_TotalDia { get; set; }
        public int rdet_TotalDanado { get; set; }

        [NotMapped]
        public int orco_Id { get; set; }
        [NotMapped]
        public string Sexo { get; set; }


        [NotMapped]
        public string colr_Nombre { get; set; }
        [NotMapped]
        public string clie_Nombre_Contacto { get; set; }

        [NotMapped]
        public string clie_RTN { get; set; }
        public int code_Id { get; set; }

        [NotMapped]
        public string esti_Descripcion { get; set; }


        public int usua_UsuarioCreacion { get; set; }
        public DateTime rdet_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? rdet_FechaModificacion { get; set; }
        public bool? rdet_Estado { get; set; }

        [NotMapped]
        public string usua_NombreUsuarioCreacion { get; set; }

        [NotMapped]
        public string usua_NombreUsuarioModificacion { get; set; }

        public virtual tbOrdenCompraDetalles code { get; set; }
        public virtual tbReporteModuloDia remo { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
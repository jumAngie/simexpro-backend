
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbImpuestoSelectivoConsumoCondicionesVehiculos
    {
        public int selh_Id { get; set; }
        public int? aran_Id { get; set; }
        public bool? selh_EsNuevo { get; set; }
        public bool? selh_EsHibrido { get; set; }
        public decimal? selh_RangoInicio { get; set; }
        public decimal? selh_RangoFin { get; set; }
        public decimal? selh_ImpuestoCobrar { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        public DateTime? selh_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? selh_FechaModificacion { get; set; }
        [NotMapped]
        public string usua_UsuarioCreacionNombre { get; set; }
        [NotMapped]
        public string usua_UsuarioModificacionNombre { get; set; }

        public virtual tbAranceles aran { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }

    }
}
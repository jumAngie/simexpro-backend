
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbImpuestoProduccionComsumoCondiciones
    {
        public int ipcc_Id { get; set; }
        public int? aran_Id { get; set; }
        public decimal? ipcc_Impuesto { get; set; }
        public decimal? ipcc_Unidad { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        public DateTime? ipcc_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? ipcc_FechaModificacion { get; set; }

        public virtual tbAranceles aran { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
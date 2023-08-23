
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbAsignacionesOrdenDetalle
    {
        public int adet_Id { get; set; }
        public int lote_Id { get; set; }
        public int adet_Cantidad { get; set; }
        public int asor_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime adet_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? adet_FechaModificacion { get; set; }

        public virtual tbAsignacionesOrden asor { get; set; }
        public virtual tbLotes lote { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
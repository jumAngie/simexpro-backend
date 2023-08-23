
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbTipoLiquidacion
    {
        public tbTipoLiquidacion()
        {
            tbBoletinPago = new HashSet<tbBoletinPago>();
        }

        public int tipl_Id { get; set; }
        public string tipl_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime tipl_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tipl_FechaModificacion { get; set; }
        public bool? tipl_Estado { get; set; }

        [NotMapped]
        public string usarioCreacion { get; set; }

        [NotMapped]
        public string usuarioModificacion { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbBoletinPago> tbBoletinPago { get; set; }
    }
}
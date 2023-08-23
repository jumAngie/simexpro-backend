using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbEstadoBoletin
    {
        public tbEstadoBoletin()
        {
            tbBoletinPago = new HashSet<tbBoletinPago>();
        }

        public int esbo_Id { get; set; }
        public string esbo_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime esbo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? esbo_FechaModificacion { get; set; }
        public bool? esbo_Estadoo { get; set; }

        [NotMapped]
        public string usua_NombreCreacion { get; set; }

        [NotMapped]
        public string usua_NombreModificacion { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbBoletinPago> tbBoletinPago { get; set; }
    }
}
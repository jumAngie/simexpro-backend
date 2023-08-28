
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbColores
    {
        public tbColores()
        {
            tbOrdenCompraDetalles = new HashSet<tbOrdenCompraDetalles>();
        }

        public int colr_Id { get; set; }
        public string colr_Nombre { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioNombreCreacion { get; set; }
        public DateTime colr_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioNombreModificacion { get; set; }
        public DateTime? colr_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string UsuarioNombreEliminacion { get; set; }
        public DateTime? colr_FechaEliminacion { get; set; }
        public bool? colr_Estado { get; set; }



        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOrdenCompraDetalles> tbOrdenCompraDetalles { get; set; }
        public virtual ICollection<tbMateriales> tbMateriales { get; set; }
        public virtual ICollection<tbLotes> tbLotes { get; set; }

    }
}
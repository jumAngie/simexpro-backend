
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbCondicionesComerciales
    {
        public tbCondicionesComerciales()
        {
            tbProveedoresDeclaracion = new HashSet<tbProveedoresDeclaracion>();
        }

        public int coco_Id { get; set; }
        public string coco_Codigo { get; set; }
        public string coco_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioNombreCreacion { get; set; }
        public DateTime coco_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioNombreModificacion { get; set; }
        public DateTime? coco_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string UsuarioNombreEliminacion { get; set; }
        public DateTime? coco_FechaEliminacion { get; set; }
        public bool? coco_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbProveedoresDeclaracion> tbProveedoresDeclaracion { get; set; }
    }
}
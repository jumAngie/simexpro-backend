
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbProveedoresDeclaracion
    {
        public tbProveedoresDeclaracion()
        {
            tbDeclaraciones_Valor = new HashSet<tbDeclaraciones_Valor>();
            tbProveedoresDeclaracionHistorial = new HashSet<tbProveedoresDeclaracionHistorial>();
        }

        public int pvde_Id { get; set; }
        public int coco_Id { get; set; }
        public string pvde_Condicion_Otra { get; set; }
        public int decl_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime pvde_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? pvde_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? pvde_FechaEliminacion { get; set; }
        public bool? pvde_Estado { get; set; }

        public virtual tbCondicionesComerciales coco { get; set; }
        public virtual tbDeclarantes decl { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual ICollection<tbProveedoresDeclaracionHistorial> tbProveedoresDeclaracionHistorial { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valor { get; set; }

    }
}
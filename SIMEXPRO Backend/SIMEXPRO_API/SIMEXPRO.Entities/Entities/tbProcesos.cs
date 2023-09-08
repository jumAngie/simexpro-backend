
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbProcesos
    {
        public tbProcesos()
        {
            tbArea = new HashSet<tbArea>();
            tbAsignacionesOrden = new HashSet<tbAsignacionesOrden>();
            tbModulos = new HashSet<tbModulos>();
            tbOrdenCompraDetalles = new HashSet<tbOrdenCompraDetalles>();
            tbProcesoPorOrdenCompraDetalle = new HashSet<tbProcesoPorOrdenCompraDetalle>();
        }

        public int proc_Id { get; set; }
        public string proc_Descripcion { get; set; }
        [NotMapped]
        public string proc_CodigoHtml { get; set; }
        [NotMapped]
        public int modu_Id { get; set; }
        [NotMapped]
        public string modu_Nombre { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usarioCreacion { get; set; }
        public DateTime proc_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacion { get; set; }
        public DateTime? proc_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string usuarioEliminacion { get; set; }
        public DateTime? proc_FechaEliminacion { get; set; }
        public bool? proc_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbArea> tbArea { get; set; }
        public virtual ICollection<tbAsignacionesOrden> tbAsignacionesOrden { get; set; }
        public virtual ICollection<tbModulos> tbModulos { get; set; }
        public virtual ICollection<tbOrdenCompraDetalles> tbOrdenCompraDetalles { get; set; }
        public virtual ICollection<tbOrde_Ensa_Acab_Etiq> tbOrde_Ensa_Acab_Etiq { get; set; }
        public virtual ICollection<tbProcesoPorOrdenCompraDetalle> tbProcesoPorOrdenCompraDetalle { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbAsignacionesOrden
    {
        public tbAsignacionesOrden()
        {
            tbAsignacionesOrdenDetalle = new HashSet<tbAsignacionesOrdenDetalle>();
        }

        public int asor_Id { get; set; }
        public int asor_OrdenDetId { get; set; }
        [NotMapped]
        public int orco_Id { get; set; }
        [NotMapped]
        public string Validacion { get; set; }
        [NotMapped]
        public string clie_Nombre_O_Razon_Social { get; set; }
        public DateTime asor_FechaInicio { get; set; }
        public DateTime asor_FechaLimite { get; set; }
        public int asor_Cantidad { get; set; }
        public int proc_Id { get; set; }
        [NotMapped]
        public string proc_Descripcion { get; set; }
        public int empl_Id { get; set; }
        [NotMapped]
        public string empl_NombreCompleto { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime asor_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime? asor_FechaModificacion { get; set; }
        [NotMapped]
        public string tall_Nombre { get; set; }
        [NotMapped]
        public string colr_Nombre { get; set; }
        [NotMapped]
        public string esti_Descripcion { get; set; }

        public virtual tbOrdenCompraDetalles asor_OrdenDet { get; set; }
        public virtual tbEmpleados empl { get; set; }
        public virtual tbProcesos proc { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbAsignacionesOrdenDetalle> tbAsignacionesOrdenDetalle { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbImpuestos
    {
        public tbImpuestos()
        {
            tbImpuestosPorArancel = new HashSet<tbImpuestosPorArancel>();
        }

        public int impu_Id { get; set; }
        public string aran_Codigo { get; set; }
        public string impu_Descripcion { get; set; }
        public decimal impu_Impuesto { get; set; }
        public decimal impu_Cantidad { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime impu_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? impu_FechaModificacion { get; set; }
        public bool? impu_Estado { get; set; }

        [NotMapped]
        public string UsuarioCreacion { get; set; }

        [NotMapped]
        public string UsuarioModificacion { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbImpuestosPorArancel> tbImpuestosPorArancel { get; set; }
    }
}
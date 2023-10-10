
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbAranceles
    {
        public tbAranceles()
        {
            tbImpuestosPorArancel = new HashSet<tbImpuestosPorArancel>();
            tbItems = new HashSet<tbItems>();
        }

        public int aran_Id { get; set; }
        public string aran_Codigo { get; set; }
        public string aran_Descripcion { get; set; }
        public decimal aran_DAI { get; set; }
        public int aran_ISV { get; set; }
        public decimal aran_SEL { get; set; }
        public decimal aran_ProdCons { get; set; }
        public bool aran_AplicaVehiculos { get; set; }
        [NotMapped]
        public bool aran_ArancelVehicular { get; set; } 
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacion { get; set; }
        public DateTime aran_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificacion { get; set; }
        [NotMapped]
        public string impu_Descripcion { get; set; }
        [NotMapped]
        public int impu_Cantidad { get; set; }
        public DateTime? aran_FechaModificacion { get; set; }
        public bool? aram_Estado { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbImpuestosPorArancel> tbImpuestosPorArancel { get; set; }
        public virtual ICollection<tbItems> tbItems { get; set; }
    }
}
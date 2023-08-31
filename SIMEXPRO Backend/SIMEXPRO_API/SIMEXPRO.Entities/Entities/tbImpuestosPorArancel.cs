
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbImpuestosPorArancel
    {
        public int imar_Id { get; set; }
        public int impu_Id { get; set; }
        public int aran_Id { get; set; }
        [NotMapped]
        public string DescripcionArancel { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime imar_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? imar_FechaModificacion { get; set; }


        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        public bool? imar_Estado { get; set; }

        public virtual tbAranceles aran { get; set; }
        public virtual tbImpuestos impu { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
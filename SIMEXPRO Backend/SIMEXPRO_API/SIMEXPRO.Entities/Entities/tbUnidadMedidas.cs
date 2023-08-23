
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbUnidadMedidas
    {
        public tbUnidadMedidas()
        {
            tbItems = new HashSet<tbItems>();
            tbLotes = new HashSet<tbLotes>();
            tbMaterialesBrindar = new HashSet<tbMaterialesBrindar>();
        }

        public int unme_Id { get; set; }
        public string unme_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime unme_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? unme_FechaModificacion { get; set; }
        public bool unme_EsAduana { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? unme_FechaEliminacion { get; set; }
        public bool? unme_Estado { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        [NotMapped]
        public string usuarioEliminacionNombre { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbItems> tbItems { get; set; }
        public virtual ICollection<tbLotes> tbLotes { get; set; }
        public virtual ICollection<tbMaterialesBrindar> tbMaterialesBrindar { get; set; }
    }
}
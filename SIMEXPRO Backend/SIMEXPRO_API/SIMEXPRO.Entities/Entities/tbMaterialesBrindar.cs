
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbMaterialesBrindar
    {
        public int mabr_Id { get; set; }
        public int code_Id { get; set; }
        [NotMapped]
        public string code_CantidadPrenda { get; set; }
        public int mate_Id { get; set; }
        [NotMapped]
        public string mate_Descripcion { get; set; }
        public int mabr_Cantidad { get; set; }

        public int unme_Id { get; set; }

        [NotMapped]
        public string unme_Descripcion { get; set; }

        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime mabr_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime? mabr_FechaModificacion { get; set; }
        public bool? mabr_Estado { get; set; }

      

        public virtual tbUnidadMedidas unme { get; set; }
        public virtual tbOrdenCompraDetalles code { get; set; }
        public virtual tbMateriales mate { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
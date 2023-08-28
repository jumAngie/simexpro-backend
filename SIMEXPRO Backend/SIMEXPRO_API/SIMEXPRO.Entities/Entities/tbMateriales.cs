
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbMateriales
    {
        public tbMateriales()
        {
            tbLotes = new HashSet<tbLotes>();
            tbMaterialesBrindar = new HashSet<tbMaterialesBrindar>();
            tbPedidosOrdenDetalle = new HashSet<tbPedidosOrdenDetalle>();
        }

        public int mate_Id { get; set; }
        public string mate_Descripcion { get; set; }
        public int? subc_Id { get; set; }
        [NotMapped]
        public string subc_Descripcion { get; set; }
        [NotMapped]
        public int cate_Id { get; set; }

        [NotMapped]
        public string cate_Descripcion { get; set; }

        [NotMapped]
        public int colr_Id { get; set; }

        [NotMapped]
        public string colr_Nombre { get; set; }
        //public decimal? mate_Precio { get; set; }
        public string mate_Imagen { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime mate_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificaNombre { get; set; }
        public DateTime? mate_FechaModificacion { get; set; }
        public bool? mate_Estado { get; set; }

        public virtual tbSubcategoria subc { get; set; }
        public virtual tbColores colr { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbLotes> tbLotes { get; set; }
        public virtual ICollection<tbMaterialesBrindar> tbMaterialesBrindar { get; set; }
        public virtual ICollection<tbPedidosOrdenDetalle> tbPedidosOrdenDetalle { get; set; }
    }
}
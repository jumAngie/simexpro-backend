    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPedidosOrdenDetalle
    {
        public tbPedidosOrdenDetalle()
        {
            tbLotes = new HashSet<tbLotes>();
            tbPODetallePorPedidoOrdenDetalle = new HashSet<tbPODetallePorPedidoOrdenDetalle>();
        }

        public int prod_Id { get; set; }
        public int pedi_Id { get; set; }

        public int mate_Id { get; set; }
        [NotMapped]
        public string mate_Descripcion { get; set; }
        public int prod_Cantidad { get; set; }
        public decimal prod_Precio { get; set; }
        public decimal prod_Peso { get; set; }
        [NotMapped]
        public string detalles { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        public DateTime prod_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        public DateTime? prod_FechaModificacion { get; set; }
        public bool? prod_Estado { get; set; }

        [NotMapped]
        public int? item_Id { get; set; }

        public virtual tbMateriales mate { get; set; }
        public virtual tbPedidosOrden pedi { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbLotes> tbLotes { get; set; }
        public virtual ICollection<tbPODetallePorPedidoOrdenDetalle> tbPODetallePorPedidoOrdenDetalle { get; set; }
    }
}
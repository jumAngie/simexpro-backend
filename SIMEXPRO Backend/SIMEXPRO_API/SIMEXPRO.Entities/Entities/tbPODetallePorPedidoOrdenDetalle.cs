
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPODetallePorPedidoOrdenDetalle
    {
        public int ocpo_Id { get; set; }
        public int prod_Id { get; set; }
        public int? code_Id { get; set; }
        public int orco_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime ocpo_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? ocpo_FechaModificacion { get; set; }


        [NotMapped]
        public string tall_Nombre { get; set; }
        [NotMapped]
        public int code_CantidadPrenda { get; set; }
        [NotMapped]
        public string code_Sexo { get; set; }
        [NotMapped]
        public string colr_Nombre { get; set; }
        [NotMapped]
        public string esti_Descripcion { get; set; }
        [NotMapped]
        public string usua_UsuarioCreacionNombre { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }

        public virtual tbOrdenCompra orco { get; set; }
        public virtual tbOrdenCompraDetalles code { get; set; }
        public virtual tbPedidosOrdenDetalle prod { get; set; }
    }
}
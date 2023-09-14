using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class PedidosOrdenDetalleViewModel
    {
        public int prod_Id { get; set; }

        public int pedi_Id { get; set; }
        public int mate_Id { get; set; }
        public int prod_Cantidad { get; set; }
        public decimal prod_Precio { get; set; }

        [NotMapped]
        public string detalles { get; set; }
        public string mate_Descripcion { get; set; }
        //public decimal prod_Peso { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        public DateTime prod_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        public DateTime? prod_FechaModificacion { get; set; }
        public bool? prod_Estado { get; set; }


    }
}

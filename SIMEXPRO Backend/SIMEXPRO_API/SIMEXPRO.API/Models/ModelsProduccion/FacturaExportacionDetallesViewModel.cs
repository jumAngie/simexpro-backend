using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class FacturaExportacionDetallesViewModel
    {
        public int fede_Id { get; set; }
        public int faex_Id { get; set; }
        public int code_Id { get; set; }
        public int fede_Cajas { get; set; }
        public decimal fede_Cantidad { get; set; }
        public decimal fede_PrecioUnitario { get; set; }
        public decimal fede_TotalDetalle { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime fede_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? fede_FechaModificacion { get; set; }


        [NotMapped]
        public int code_CantidadPrenda { get; set; }
        [NotMapped]
        public string esti_Descripcion { get; set; }
        [NotMapped]
        public string tall_Codigo { get; set; }
        [NotMapped]
        public string code_Sexo { get; set; }
        [NotMapped]
        public string colr_Nombre { get; set; }
        [NotMapped]
        public decimal code_Unidad { get; set; }
        [NotMapped]
        public decimal code_Valor { get; set; }
        [NotMapped]
        public decimal code_Impuesto { get; set; }
        [NotMapped]
        public string code_EspecificacionEmbalaje { get; set; }

        [NotMapped]
        public string code_Descripcion { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class AsignacionesOrdenDetalleViewModel
    {
        public int adet_Id { get; set; }
        public int lote_Id { get; set; }
        public int adet_Cantidad { get; set; }
        public int asor_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime adet_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? adet_FechaModificacion { get; set; }

    }
}

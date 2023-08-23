using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class BoletinPagoDetallesViewModel
    {
        public int bode_Id { get; set; }
        public int boen_Id { get; set; }
        public int lige_Id { get; set; }
        public string bode_Concepto { get; set; }
        public string bode_TipoObligacion { get; set; }
        public int bode_CuentaPA01 { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime bode_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? bode_FechaModificacion { get; set; }
    }
}

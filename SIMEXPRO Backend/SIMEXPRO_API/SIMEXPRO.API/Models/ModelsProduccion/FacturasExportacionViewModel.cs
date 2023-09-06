using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class FacturasExportacionViewModel
    {
        public int faex_Id { get; set; }
        public int duca_Id { get; set; }
        public DateTime faex_Fecha { get; set; }
        public int orco_Id { get; set; }
        public decimal faex_Total { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime faex_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? faex_FechaModificacion { get; set; }

        [NotMapped]
        public int faex_Estado { get; set; }

        [NotMapped]
        public int faex_Finalizado { get; set; }


        [NotMapped]
        public string clie_Nombre_O_Razon_Social { get; set; }


        [NotMapped]
        public string clie_Direccion { get; set; }

        [NotMapped]
        public string clie_Numero_Contacto { get; set; }

        [NotMapped]
        public string clie_RTN { get; set; }

        [NotMapped]
        public string clie_Correo_Electronico { get; set; }

        [NotMapped]
        public string clie_FAX { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        [NotMapped]
        public string Detalles { get; set; }

        [NotMapped]
        public string orco_Descripcion { get; set; }


    }
}

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
        public bool faex_Estado { get; set; }
        public bool faex_Finalizado { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime faex_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? faex_FechaModificacion { get; set; }
        
        public string duca_No_Duca { get; set; }

        public string clie_Nombre_O_Razon_Social { get; set; }

        public string clie_Direccion { get; set; }

        public string clie_Numero_Contacto { get; set; }

        public string clie_RTN { get; set; }

        public string clie_Correo_Electronico { get; set; }

        public string clie_FAX { get; set; }

        public string usuarioCreacionNombre { get; set; }

        public string usuarioModificacionNombre { get; set; }

        public string Detalles { get; set; }

        public string orco_Descripcion { get; set; }

        public string orco_Codigo { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class ReportesViewModel
    {
          
        //Reporte Tiempos de maquina
        public int maqu_Id { get; set; }
        public int diasActiva { get; set; }
        public int diasInactiva  { get; set; }
        public int diasTotalesInactiva { get; set; }
        public string mahi_Observaciones { get; set; }



        //Reportes Produccion por Modulo

        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public string modu_Nombre { get; set; }
        public int TotalProduccion { get; set; }
        public int PromedioCantidad { get; set; }
        public int PromedioDanio { get; set; }
        public int PromedioProduccion { get; set; }


    }
}

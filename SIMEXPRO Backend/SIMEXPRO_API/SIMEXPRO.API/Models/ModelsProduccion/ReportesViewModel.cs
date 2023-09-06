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


    }
}

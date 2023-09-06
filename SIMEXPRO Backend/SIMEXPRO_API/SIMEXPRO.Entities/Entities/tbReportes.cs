using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.Entities.Entities
{
    public class tbReportes
    {
        //Reporte Tiempos de maquina
        public int maqu_Id { get; set; }
        public int diasActiva { get; set; }
        public int diasInactiva { get; set; }
        public int diasTotalesInactiva { get; set; }
        public string mahi_Observaciones { get; set; }
    }
}

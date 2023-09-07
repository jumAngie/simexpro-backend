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

        //Reportes Produccion por Modulo

        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public string modu_Nombre { get; set; }
        public int TotalProduccion{ get; set; }
        public int PromedioCantidad{ get; set; }
        public int PromedioDanio{ get; set; }
        public int PromedioProduccion{ get; set; }

        //Reportes Pedidos Cliente

        public int clie_Id { get; set; }
        public int PedidosTerminados { get; set; }
        public int PedidosCurso { get; set; }
        public int PedidosPendientes { get; set; }
        public int CantidadCompletada { get; set; }
        public int ProcentajeCompletado { get; set; }
        public int code_CantidadPrenda { get; set; }
        public string code_Sexo { get; set; }
        public string clie_Nombre_O_Razon_Social { get; set; }
        public string clie_RTN { get; set; }
        public string clie_Nombre_Contacto { get; set; }
        public string clie_Numero_Contacto { get; set; }
        public string clie_Correo_Electronico { get; set; }

    }
}

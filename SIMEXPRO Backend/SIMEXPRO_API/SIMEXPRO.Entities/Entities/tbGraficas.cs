using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMEXPRO.Entities.Entities
{
    public class tbGraficas
    {
        // DATOS PARA LA GRAFICA DE AVANCES ORDEN DE COMPRA
        public int orco_Id { get; set; }
        public string orco_FechaEmision { get; set; }
        public string orco_FechaLimite { get; set; }
        public string orco_Avance { get; set; }
        public int clie_Id { get; set; }
        public string clie_Nombre_O_Razon_Social { get; set; }
        public string clie_Direccion { get; set; }
        public string clie_RTN { get; set; }
        public string clie_Nombre_Contacto { get; set; }
        public string clie_Numero_Contacto { get; set; }
        public string clie_Correo_Electronico { get; set; }
        public string clie_FAX { get; set; }

        // DATOS PARA LA GRAFICA TOTAL ORDENES COMPRA ANUALES
        public int orco_Conteo { get; set; }
        public string orco_FechaCreacion { get; set; }
        public string Anio { get; set; }
        public string Mes { get; set; }
        public string Semana { get; set; }
        public string MesLabel { get; set; }
        public string Fecha { get; set; }


        // DATOS PARA LAS GRAFICAS DE FACTURAS 
        public string FechaAntigua { get; set; }
        public string FechaReciente { get; set; }
        public int NumeroMes { get; set; }
        public int NumeroSemana { get; set; }
        public int NumeroDia { get; set; }
        public int TotalIngresos { get; set; }


        // GRAFICA DE CANTIDAD DE PRENDAS AGRUPADAS POR SEXO
        public int esti_Id { get; set; }
        public int PrendasSumatoria { get; set; }
        public string code_Sexo { get; set; }
        public string esti_Descripcion { get; set; }


        // GRAFICA DE PRODUCCION POR MODULOS
        public string modu_Nombre { get; set; }
        public int TotalProduccionDia { get; set; }
        public string PorcentajeProduccion { get; set; }


        // CLIENTES MAS PRODUCTIVOS
        public int CantidadIngresos { get; set; }

        // Pasies de Origen de exportadores

        public string pais_Nombre { get; set; }
        public int duca_Pais_Emision_Exportador { get; set; }
        public string Porcentaje { get; set; }

        // Estados Mercancias Cantidad Porcentaje

        public string merc_Descripcion { get; set; }
        public int Cantidad { get; set; }

        // Aduanas con mas importaciones

        public string adua_Nombre {get;set;}
    }
}

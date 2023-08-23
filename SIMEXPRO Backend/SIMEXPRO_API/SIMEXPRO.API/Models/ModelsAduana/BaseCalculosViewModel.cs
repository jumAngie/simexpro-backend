using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class BaseCalculosViewModel
    {
        public int base_Id { get; set; }
        public int deva_Id { get; set; }
        public decimal base_PrecioFactura { get; set; }
        public decimal base_PagosIndirectos { get; set; }
        public decimal base_PrecioReal { get; set; }
        public decimal base_MontCondicion { get; set; }
        public decimal base_MontoReversion { get; set; }
        public decimal base_ComisionCorrelaje { get; set; }
        public decimal base_Gasto_Envase_Embalaje { get; set; }
        public decimal base_ValoresMateriales_Incorporado { get; set; }
        public decimal base_Valor_Materiales_Utilizados { get; set; }
        public decimal base_Valor_Materiales_Consumidos { get; set; }
        public decimal base_Valor_Ingenieria_Importado { get; set; }
        public decimal base_Valor_Canones { get; set; }
        public decimal base_Gasto_TransporteM_Importada { get; set; }
        public decimal base_Gastos_Carga_Importada { get; set; }
        public decimal base_Costos_Seguro { get; set; }
        public decimal base_Total_Ajustes_Precio_Pagado { get; set; }
        public decimal base_Gastos_Asistencia_Tecnica { get; set; }
        public decimal base_Gastos_Transporte_Posterior { get; set; }
        public decimal base_Derechos_Impuestos { get; set; }
        public decimal base_Monto_Intereses { get; set; }
        public decimal base_Deducciones_Legales { get; set; }
        public decimal base_Total_Deducciones_Precio { get; set; }
        public decimal base_Valor_Aduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime base_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? base_FechaModificacion { get; set; }
        public bool? base_Estado { get; set; }

    }
}

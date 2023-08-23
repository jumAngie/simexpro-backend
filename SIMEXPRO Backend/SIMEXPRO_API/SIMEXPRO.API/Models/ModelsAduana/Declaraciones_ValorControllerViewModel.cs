using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class Declaraciones_ValorControllerViewModel
    {
        public Declaraciones_ValorViewModel Declaraciones_ValorViewModel { get; set; }
        public DeclarantesViewModel DeclarantesImpo_ViewModel { get; set; }
        public DeclarantesViewModel DeclarantesProv_ViewModel { get; set; }
        public DeclarantesViewModel DeclarantesInte_ViewModel { get; set; }
        public ImportadoresViewModel ImportadoresViewModel { get; set; }
        public ProveedoresDeclaracionViewModel ProveedoresDeclaracionViewModel { get; set; }
        public IntermediarioViewModel IntermediarioViewModel { get; set; }

    }
}

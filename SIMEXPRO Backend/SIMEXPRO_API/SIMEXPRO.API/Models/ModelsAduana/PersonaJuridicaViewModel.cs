using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class PersonaJuridicaViewModel
    {
        public int peju_Id { get; set; }
        public int pers_Id { get; set; }
         public string pers_RTN { get; set; }
         public int ofic_Id { get; set; }
         public string pais_RepresentanteNombre { get; set; }

        public int peju_EstadoRepresentante { get; set; }
        public int colo_Id { get; set; }
        public string peju_PuntoReferencia { get; set; }
        public int peju_ColoniaRepresentante { get; set; }
        public string peju_NumeroLocalRepresentante { get; set; }
        public string peju_PuntoReferenciaRepresentante { get; set; }
        public string peju_TelefonoEmpresa { get; set; }
        public string peju_TelefonoFijoRepresentanteLegal { get; set; }
        public string peju_TelefonoRepresentanteLegal { get; set; }
        public string peju_CorreoElectronico { get; set; }
        public string peju_CorreoElectronicoAlternativo { get; set; }
        public int usua_UsuarioCreacion { get; set; }
         public string usuarioCreacionNombre { get; set; }
        public DateTime peju_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
         public string usuarioModificaNombre { get; set; }
        public DateTime? peju_FechaModificacion { get; set; }
        public bool? peju_Estado { get; set; }

    }
}

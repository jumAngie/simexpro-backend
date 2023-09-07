using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class PersonaJuridicaViewModel
    {
        //tab1
        public int peju_Id { get; set; }
        public int pers_Id { get; set; }
        public string pers_RTN { get; set; }
        public int ofic_Id { get; set; }
        public string ofic_Nombre { get; set; }
        public int escv_Id { get; set; }
        public string escv_Nombre { get; set; }
        public int ofpr_Id { get; set; }
        public string ofpr_Nombre { get; set; }

        //tab2
        public int colo_Id { get; set; }
        public string ColiniaEmpresa { get; set; }
        public int ciud_Id { get; set; }
        public string CiudadEmpresa { get; set; }
        public int alde_Id { get; set; }
        public string AldeaEmpresa { get; set; }
        public int pvin_Id { get; set; }
        public string ProvinciaEmpresa { get; set; }
        public string peju_PuntoReferencia { get; set; }

        //tab3
        public int peju_ColoniaRepresentante { get; set; }
        public string ColoniaRepresentante { get; set; }
        public int peju_CiudadIdRepresentante { get; set; }
        public string CiudadRepresentante { get; set; }
        public int peju_AldeaIdRepresentante { get; set; }
        public string AldeaRepresemtante { get; set; }
        public int ProvinciaIdRepresentante { get; set; }
        public string ProvinciaRepresentante { get; set; }
        public string peju_NumeroLocalRepresentante { get; set; }
        public string peju_PuntoReferenciaRepresentante { get; set; }

        //tab4
        public string peju_TelefonoEmpresa { get; set; }
        public string peju_TelefonoFijoRepresentanteLegal { get; set; }
        public string peju_TelefonoRepresentanteLegal { get; set; }
        public string peju_CorreoElectronico { get; set; }
        public string peju_CorreoElectronicoAlternativo { get; set; }

        //tab5
        public string doco_URLImagen { get; set; }
        public string doco_NombreImagen { get; set; }
        public string doco_Numero_O_Referencia { get; set; }
        public string doco_TipoDocumento { get; set; }
        public bool peju_ContratoFinalizado { get; set; }
        public string peju_NumeroLocalApart { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public string usuarioCreacionNombre { get; set; }
        public DateTime peju_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public string usuarioModificaNombre { get; set; }
        public DateTime? peju_FechaModificacion { get; set; }
        public bool? peju_Estado { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class PersonaNaturalViewModel
    {
        public int pena_Id { get; set; }
        public int pers_Id { get; set; }
        public string pena_DireccionExacta { get; set; }
        public int ciud_Id { get; set; }
        public int pvin_Id { get; set; }
        public string pvin_Nombre { get; set; }

        public int escv_Id { get; set; }

        public string escv_Nombre { get; set; }

        public int ofic_Id { get; set; }

        public string ofic_Nombre { get; set; }

        public int ofpr_Id { get; set; }

        public string ofpr_Nombre { get; set; }
        public string ciud_Nombre { get; set; }
        public string pena_TelefonoFijo { get; set; }
        public string pena_TelefonoCelular { get; set; }
        public string pena_CorreoElectronico { get; set; }
        public string pena_CorreoAlternativo { get; set; }
        public string pena_RTN { get; set; }
        public string pena_ArchivoRTN { get; set; }
        public string pena_DNI { get; set; }
        public string pena_ArchivoDNI { get; set; }
        public string pena_NumeroRecibo { get; set; }
        public string pena_ArchivoNumeroRecibo { get; set; }
        public string pena_NombreArchRTN { get; set; }
        public string pena_NombreArchRecibo { get; set; }
        public string pena_NombreArchDNI { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime pena_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? pena_FechaModificacion { get; set; }
        public bool? pena_Estado { get; set; }
        public bool? pena_Finalizado { get; set; }

        public string usuarioCreacion { get; set; }

         public string usuarioModificacion { get; set; }

    }
}

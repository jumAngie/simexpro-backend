
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPersonaNatural
    {
        public int pena_Id { get; set; }
        public int pers_Id { get; set; }
        public string pena_DireccionExacta { get; set; }
        [NotMapped]
        public string Cliente { get; set; }
        public int ciud_Id { get; set; }

        [NotMapped]
        public string ciud_Nombre { get; set; }
        [NotMapped]
        public int pvin_Id { get; set; }
        [NotMapped]
        public string pvin_Nombre { get; set; }

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
        public int usua_UsuarioCreacion { get; set; }
        public DateTime pena_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? pena_FechaModificacion { get; set; }
        public bool? pena_Estado { get; set; }
        public bool? pena_Finalizado { get; set; }
        public string pena_NombreArchRTN { get; set; }
        public string pena_NombreArchRecibo { get; set; }
        public string pena_NombreArchDNI { get; set; }

        [NotMapped]
        public string usuarioCreacion { get; set; }

        [NotMapped]
        public string usuarioModificacion { get; set; }


        [NotMapped]
        public int escv_Id { get; set; }
        [NotMapped]
        public string escv_Nombre { get; set; }
        [NotMapped]
        public int ofic_Id { get; set; }
        [NotMapped]
        public string ofic_Nombre { get; set; }
        [NotMapped]
        public int ofpr_Id { get; set; }
        [NotMapped]

        public string ofpr_Nombre { get; set; }

        [NotMapped]
        public string peju_CiudadRepresentanteNombre { get; set; }
        [NotMapped]
        public string peju_ColoniaRepresentanteNombre { get; set; }
        [NotMapped]
        public string peju_AldeaRepresentanteNombre { get; set; }
        [NotMapped]
        public string pers_Nombre { get; set; }
        [NotMapped]
        public string colo_Nombre { get; set; }
        [NotMapped]
        public string alde_Nombre { get; set; }

        public virtual tbCiudades ciud { get; set; }
        public virtual tbPersonas pers { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
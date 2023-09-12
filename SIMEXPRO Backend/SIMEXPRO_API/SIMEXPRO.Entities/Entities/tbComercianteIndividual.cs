
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbComercianteIndividual
    {
        public int coin_Id { get; set; }
        public int pers_Id { get; set; }
        public bool pers_FormaRepresentacion { get; set; }
        public string coin_PuntoReferencia { get; set; }
        public string coin_PuntoReferenciaReprentante { get; set; }
        public string coin_TelefonoCelular { get; set; }
        public string coin_TelefonoFijo { get; set; }
        public string coin_CorreoElectronico { get; set; }
        public string coin_CorreoElectronicoAlternativo { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime coin_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? coin_FechaModificacion { get; set; }
        public bool? coin_Estado { get; set; }
        public int? ciud_Id { get; set; }
        public int? alde_Id { get; set; }
        public int? coin_CiudadRepresentante { get; set; }
        public int? coin_AldeaRepresentante { get; set; }
        public int? colo_Id { get; set; }
        public string coin_NumeroLocalApart { get; set; }
        public int? coin_coloniaIdRepresentante { get; set; }
        public string coin_NumeroLocaDepartRepresentante { get; set; }
    
        [NotMapped]
        public string doco_Numero_O_Referencia { get; set; }
        [NotMapped]
        public string doco_TipoDocumento { get; set; }
        [NotMapped]
        public string doco_URLImagen { get; set; }
        [NotMapped]
        public string doco_NombreImagen { get; set; }


        [NotMapped]
        public string pers_RTN { get; set; }
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
        public string colo_Nombre { get; set; }

        [NotMapped]
        public string ciud_Nombre { get; set; }
        [NotMapped]
        public int pvin_Id { get; set; }
        [NotMapped]
        public string pvin_Codigo { get; set; }
        [NotMapped]
        public string pvin_Nombre { get; set; }
        [NotMapped]
        public int pais_Id { get; set; }
        [NotMapped]
        public string pais_Codigo { get; set; }
        [NotMapped]
        public string pais_Nombre { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        [NotMapped]
        public string formaRepresentacionDesc { get; set; }
        [NotMapped]
        public string estadoCivilRepresentante { get; set; }
        [NotMapped]
        public int pers_escvRepresentante { get; set; }
        [NotMapped]
        public int pers_OfprRepresentante { get; set; }
        [NotMapped]
        public string oficioProfesRepresentante { get; set; }

        [NotMapped]
        public string alde_Nombre { get; set; }


        [NotMapped]
        public string aldeaNombreRepresentante { get; set; }
        [NotMapped]
        public string ciudadNrepresentante { get; set; }

        [NotMapped]
        public int pvin_IdRepresentante { get; set; }

        [NotMapped]
        public string pvin_CodigoRepresentante { get; set; }

        [NotMapped]
        public string pvin_NombreRepresentante { get; set; }


        [NotMapped]
        public string coloniaNombreRepresentante { get; set; }



        public virtual tbColonias coin_ColoniaRepresentanteNavigation { get; set; }
        public virtual tbColonias colo { get; set; }
        public virtual tbPersonas pers { get; set; }
        public virtual tbAldeas alde { get; set; }
        public virtual tbCiudades ciud { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }

        public virtual tbColonias coin_coloniaIdRepresentanteNavigation { get; set; }

        public virtual tbCiudades coin_CiudadRepresentanteNavigation { get; set; }
        public virtual tbAldeas coin_AldeaRepresentanteNavigation { get; set; }

        public virtual ICollection<tbDocumentosContratos> tbDocumentosContratos { get; set; }

    }
}
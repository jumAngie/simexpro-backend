
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPersonaJuridica
    {

        public tbPersonaJuridica()
        {
            tbDocumentosContratos = new HashSet<tbDocumentosContratos>();
        }

        public int peju_Id { get; set; }

        public int pers_Id { get; set; }
        [NotMapped]
        public string pers_RTN { get; set; }
        [NotMapped]
        public int ofic_Id { get; set; }
        [NotMapped] 
        public string pais_RepresentanteNombre { get; set; }

        public string peju_DNI { get; set; }
        public string peju_DNIRepresentante { get; set; }
        public string peju_EscrituraPublica { get; set; }
        public int ciud_Id { get; set; }
        public int alde_Id { get; set; }
        public string peju_NumeroLocalApart { get; set; }
        public int colo_Id { get; set; }
        public string peju_PuntoReferencia { get; set; }
        public int peju_ColoniaRepresentante { get; set; }
        public int peju_CiudadIdRepresentante { get; set; }
        public int peju_AldeaIdRepresentante { get; set; }
        public string peju_NumeroLocalRepresentante { get; set; }
        public string peju_PuntoReferenciaRepresentante { get; set; }
        public string peju_TelefonoEmpresa { get; set; }
        public string peju_TelefonoFijoRepresentanteLegal { get; set; }
        public string peju_TelefonoRepresentanteLegal { get; set; }
        public string peju_CorreoElectronico { get; set; }
        public string peju_CorreoElectronicoAlternativo { get; set; }

        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime peju_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificaNombre { get; set; }
        public DateTime? peju_FechaModificacion { get; set; }
        public bool? peju_Estado { get; set; }

        public string peju_DNI { get; set; }
        public string peju_DNIRepresentante { get; set; }
        public string peju_EscrituraPublica { get; set; }
        public string peju_NumeroLocalApart { get; set; }
        public int alde_Id { get; set; }
        public int ciud_Id { get; set; }
        public int peju_AldeaIdRepresentante { get; set; }
        public int peju_CiudadIdRepresentante { get; set; }

        public virtual tbCiudades ciud { get; set; }
        public virtual tbAldeas alde { get; set; }
        public virtual tbColonias colo { get; set; }
        public virtual tbAldeas peju_AldeaIdRepresentanteNavigation { get; set; }
        public virtual tbColonias peju_ColoniaRepresentanteNavigation { get; set; }
        public virtual tbAldeas peju_AldeaIdRepresentanteNavigation { get; set; }

        public virtual tbCiudades peju_CiudadIdRepresentanteNavigation { get; set; }


        public virtual tbProvincias peju_EstadoRepresentanteNavigation { get; set; }
        public virtual tbCiudades peju_CiudadIdRepresentanteNavigation { get; set; }
        public virtual tbPersonas pers { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosContratos> tbDocumentosContratos { get; set; }
    }
}
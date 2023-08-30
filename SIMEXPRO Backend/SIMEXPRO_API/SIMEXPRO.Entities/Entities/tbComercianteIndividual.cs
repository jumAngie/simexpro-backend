
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbComercianteIndividual
    {
        public tbComercianteIndividual()
        {
            tbDocumentosContratos = new HashSet<tbDocumentosContratos>();
        }

        public int coin_Id { get; set; }
        public int pers_Id { get; set; }

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
        public bool pers_FormaRepresentacion { get; set; }
        public int colo_Id { get; set; }
        [NotMapped]
        public string colo_Nombre { get; set; }
        [NotMapped]
        public int ciud_Id { get; set; }
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
        public string coin_PuntoReferencia { get; set; }
        public int coin_ColoniaRepresentante { get; set; }
        public string coin_NumeroLocalReprentante { get; set; }
        public string coin_PuntoReferenciaReprentante { get; set; }
        public string coin_TelefonoCelular { get; set; }
        public string coin_TelefonoFijo { get; set; }
        public string coin_CorreoElectronico { get; set; }
        public string coin_CorreoElectronicoAlternativo { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime coin_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime? coin_FechaModificacion { get; set; }
        public bool? coin_Estado { get; set; }

        [NotMapped]
        public string formaRepresentacionDesc { get; set; }
        [NotMapped]
        public string estadoCivilRepresentante { get; set; }
        [NotMapped]
        public string pers_escvRepresentante  {get; set; }
        [NotMapped]
        public string pers_OfprRepresentante  {get; set; }
        [NotMapped]      
        public string oficioProfesRepresentante { get; set; }

        public virtual tbColonias coin_ColoniaRepresentanteNavigation { get; set; }
        public virtual tbColonias colo { get; set; }
        public virtual tbPersonas pers { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosContratos> tbDocumentosContratos { get; set; }
    }
}
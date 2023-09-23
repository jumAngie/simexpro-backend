
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

        public bool? peju_ContratoFinalizado { get; set; }
        //tab1
        public int peju_Id { get; set; }
        public int pers_Id { get; set; }
        [NotMapped]
        public string pers_RTN { get; set; }
        [NotMapped]
        public int ofic_Id { get; set; }
        [NotMapped]
        public string ofic_Nombre { get; set; }
        [NotMapped]
        public int escv_Id { get; set; }
        [NotMapped]
        public string escv_Nombre { get; set; }
        [NotMapped]
        public int ofpr_Id { get; set; }
        [NotMapped]
        public string ofpr_Nombre { get; set; }

        //tab2
        [NotMapped]
        public int? colo_Id { get; set; }
        [NotMapped]
        public string ColiniaEmpresa { get; set; }
        [NotMapped]
        public int? ciud_Id { get; set; }
        [NotMapped]
        public string CiudadEmpresa { get; set; }
        [NotMapped]
        public int? alde_Id { get; set; }
        [NotMapped]
        public string AldeaEmpresa { get; set; }
        [NotMapped]
        public int pvin_Id { get; set; }
        [NotMapped]
        public string ProvinciaEmpresa { get; set; }
        public string peju_PuntoReferencia { get; set; }

        //tab3
        [NotMapped]
        public int? peju_ColoniaRepresentante { get; set; }
        [NotMapped]
        public string ColoniaRepresentante { get; set; }
        [NotMapped]
        public int? peju_CiudadIdRepresentante { get; set; }
        [NotMapped]
        public string CiudadRepresentante { get; set; }
        [NotMapped]
        public int? peju_AldeaIdRepresentante { get; set; }
        [NotMapped]
        public string AldeaRepresemtante { get; set; }
        [NotMapped]
        public int ProvinciaIdRepresentante { get; set; }
        public string ProvinciaRepresentante { get; set; }
        public string peju_NumeroLocalRepresentante { get; set; }
        public string peju_PuntoReferenciaRepresentante { get; set; }
        public string peju_NumeroLocalApart { get; set; }

        //tab4
        public string peju_TelefonoEmpresa { get; set; }
        public string peju_TelefonoFijoRepresentanteLegal { get; set; }
        public string peju_TelefonoRepresentanteLegal { get; set; }
        public string peju_CorreoElectronico { get; set; }
        public string peju_CorreoElectronicoAlternativo { get; set; }

        //tab5
        [NotMapped]
        public string doco_URLImagen { get; set; }
        [NotMapped]
        public string doco_NombreImagen { get; set; }
        [NotMapped]
        public string doco_Numero_O_Referencia { get; set; }
        [NotMapped]
        public string doco_TipoDocumento { get; set; }

        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime peju_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificaNombre { get; set; }
        public DateTime? peju_FechaModificacion { get; set; }
        public bool? peju_Estado { get; set; }
        public string pais_Nombre { get; set; }

        [NotMapped]
        public string peju_CiudadRepresentanteNombre { get; set; }
        [NotMapped]
        public string peju_ColoniaRepresentanteNombre { get; set; }
        [NotMapped]
        public string peju_AldeaRepresentanteNombre { get; set; }
        [NotMapped]
        public string pers_Nombre { get; set; }
        [NotMapped]
        public string ciud_Nombre { get; set; }
        [NotMapped]
        public string colo_Nombre { get; set; }
        [NotMapped]
        public string alde_Nombre { get; set; }


        public virtual tbCiudades ciud { get; set; }
        public virtual tbAldeas alde { get; set; }
        public virtual tbColonias colo { get; set; }
        public virtual tbAldeas peju_AldeaIdRepresentanteNavigation { get; set; }
        public virtual tbColonias peju_ColoniaRepresentanteNavigation { get; set; }

        public virtual tbCiudades peju_CiudadIdRepresentanteNavigation { get; set; }


        public virtual tbProvincias peju_EstadoRepresentanteNavigation { get; set; }
        public virtual tbPersonas pers { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDocumentosContratos> tbDocumentosContratos { get; set; }
    }
}
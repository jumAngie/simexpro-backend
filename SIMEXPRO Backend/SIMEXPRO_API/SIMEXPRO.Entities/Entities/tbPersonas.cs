
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPersonas
    {
        public tbPersonas()
        {
            tbComercianteIndividual = new HashSet<tbComercianteIndividual>();
            tbPersonaJuridica = new HashSet<tbPersonaJuridica>();
            tbPersonaNatural = new HashSet<tbPersonaNatural>();
        }

        public int pers_Id { get; set; }
        public string pers_RTN { get; set; }
        public int ofic_Id { get; set; }

        [NotMapped]
        public string ofic_Nombre { get; set; }
        public int escv_Id { get; set; }
        [NotMapped]
        public string escv_Nombre { get; set; }
        public int ofpr_Id { get; set; }
        [NotMapped]
        public string ofpr_Nombre { get; set; }
        public bool pers_FormaRepresentacion { get; set; }
        public int pers_escvRepresentante { get; set; }
        [NotMapped]
        public string EstadoCivilRepresentante { get; set; }
        public int pers_OfprRepresentante { get; set; }
        [NotMapped]
        public string OficioProfecionRepresentante { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacion { get; set; }
        public DateTime pers_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacion { get; set; }
        public DateTime? pers_FechaModificacion { get; set; }
        public bool? pers_Estado { get; set; }

        public virtual tbEstadosCiviles escv { get; set; }
        public virtual tbOficinas ofic { get; set; }
        public virtual tbOficio_Profesiones ofpr { get; set; }
        public virtual tbOficio_Profesiones pers_OfprRepresentanteNavigation { get; set; }
        public virtual tbEstadosCiviles pers_escvRepresentanteNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbComercianteIndividual> tbComercianteIndividual { get; set; }
        public virtual ICollection<tbPersonaJuridica> tbPersonaJuridica { get; set; }
        public virtual ICollection<tbPersonaNatural> tbPersonaNatural { get; set; }
    }
}
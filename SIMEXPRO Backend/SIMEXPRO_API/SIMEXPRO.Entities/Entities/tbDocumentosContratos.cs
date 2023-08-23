
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbDocumentosContratos
    {
        public int doco_Id { get; set; }
        public int? coin_Id { get; set; }
        [NotMapped]
        public string pers_RTN { get; set; }
        [NotMapped]
        public string coin_CorreoElectronico { get; set; }
        [NotMapped]
        public string coin_TelefonoFijo { get; set; }
        public int? peju_Id { get; set; }
        public string doco_Numero_O_Referencia { get; set; }
        public string doco_TipoDocumento { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime doco_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }
        public DateTime? doco_FechaModificacion { get; set; }
        public bool? doco_Estado { get; set; }
        public virtual tbComercianteIndividual coin { get; set; }
        public virtual tbPersonaJuridica peju { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbCiudades
    {

        public tbCiudades()
        {
            tbAldeas = new HashSet<tbAldeas>();
            tbColonias = new HashSet<tbColonias>();
            tbDeclarantes = new HashSet<tbDeclarantes>();
            tbPersonaNatural = new HashSet<tbPersonaNatural>();
            tbProveedores = new HashSet<tbProveedores>();
            tbPedidosOrden = new HashSet<tbPedidosOrden>();
            tbAduanas = new HashSet<tbAduanas>();
        }

        public int ciud_Id { get; set; }
        public string ciud_Nombre { get; set; }
        public int pvin_Id { get; set; }
        [NotMapped]
        public string pvin_Nombre { get; set; }
        [NotMapped]
        public string pvin_Codigo { get; set; }
        [NotMapped]
        public string pais_Codigo { get; set; }
        [NotMapped]
        public string pais_Nombre { get; set; }

        [NotMapped]
        public int pais_Id { get; set; }
        public bool ciud_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        public DateTime ciud_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }
        public DateTime? ciud_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string UsuarioEliminacionNombre { get; set; }
        public DateTime? ciud_FechaEliminacion { get; set; }
        public bool? ciud_Estado { get; set; }

        public virtual tbProvincias pvin { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }

        public virtual ICollection<tbComercianteIndividual> tbComercianteIndividualcoin_CiudadRepresentanteNavigation { get; set; }
        public virtual ICollection<tbComercianteIndividual> tbComercianteIndividualciud { get; set; }
        public virtual ICollection<tbPersonaJuridica> tbPersonaJuridicaciud { get; set; }
        public virtual ICollection<tbPersonaJuridica> tbPersonaJuridicapeju_CiudadIdRepresentanteNavigation { get; set; }

        public virtual ICollection<tbAldeas> tbAldeas { get; set; }
        public virtual ICollection<tbColonias> tbColonias { get; set; }
        public virtual ICollection<tbDeclarantes> tbDeclarantes { get; set; }
        public virtual ICollection<tbPersonaNatural> tbPersonaNatural { get; set; }
        public virtual ICollection<tbProveedores> tbProveedores { get; set; }
        public virtual ICollection<tbPedidosOrden> tbPedidosOrden { get; set; }
        public virtual ICollection<tbAduanas> tbAduanas { get; set; }
    }
}
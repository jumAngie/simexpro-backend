
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbProvincias
    {
        public tbProvincias()
        {
            tbCiudades = new HashSet<tbCiudades>();
            tbEmpleados = new HashSet<tbEmpleados>();
            tbPersonaJuridica = new HashSet<tbPersonaJuridica>();
            tbClientes = new HashSet<tbClientes>();
        }

        public int pvin_Id { get; set; }
        public string pvin_Nombre { get; set; }
        public string pvin_Codigo { get; set; }
        public int pais_Id { get; set; }
        public bool pvin_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime pvin_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? pvin_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? pvin_FechaEliminacion { get; set; }
        public bool? pvin_Estado { get; set; }

        [NotMapped]
        public string pais_Nombre { get; set; }

        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }

        public virtual tbPaises pais { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCiudades> tbCiudades { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        public virtual ICollection<tbPersonaJuridica> tbPersonaJuridica { get; set; }
        public virtual ICollection<tbClientes> tbClientes { get; set; }
    }
}
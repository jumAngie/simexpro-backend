
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbProveedores
    {
        public tbProveedores()
        {
            tbPedidosOrden = new HashSet<tbPedidosOrden>();
        }

        public int prov_Id { get; set; }
        public string prov_NombreCompania { get; set; }
        public string prov_NombreContacto { get; set; }
        public string prov_Telefono { get; set; }
        public string prov_CodigoPostal { get; set; }
        public int prov_Ciudad { get; set; }
        [NotMapped]
        public string ciud_Nombre { get; set; }
        public string pvin_Id { get; set; }
        public string pvin_Nombre { get; set; }
        public string pais_Nombre { get; set; }

        [NotMapped]
        public string pais_Codigo { get; set; }
        public string pais_Id { get; set; }
        public string prov_DireccionExacta { get; set; }
        public string prov_CorreoElectronico { get; set; }
        public string prov_Fax { get; set; }
        public string UsuarioCreacionNombre { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime prov_FechaCreacion { get; set; }
        public string UsuarioModificadorNombre { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? prov_FechaModificacion { get; set; }
        public string UsuarioEliminacionNombre { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? prov_FechaEliminacion { get; set; }
        public bool? prov_Estado { get; set; }

        public virtual tbCiudades prov_CiudadNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPedidosOrden> tbPedidosOrden { get; set; }
    }
}
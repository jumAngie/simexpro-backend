
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPedidosOrden
    {
        public tbPedidosOrden()
        {
            tbPedidosOrdenDetalle = new HashSet<tbPedidosOrdenDetalle>();
        }

        public int peor_Id { get; set; }
        public int? prov_Id { get; set; }
        public int? duca_Id { get; set; }
        public int ciud_Id { get; set; }
        public string peor_DireccionExacta { get; set; }
        public DateTime? peor_FechaEntrada { get; set; }
        public string peor_Obsevaciones { get; set; }
        public bool? peor_DadoCliente { get; set; }
        public bool? peor_Est { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime peor_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? peor_FechaModificacion { get; set; }
        public bool? peor_Estado { get; set; }
        [NotMapped]
        public bool peor_finalizacion { get; set; }

        [NotMapped]
        public string prov_NombreCompania { get; set; }
        [NotMapped]
        public string prov_Telefono { get; set; }
        [NotMapped]
        public string duca_No_Duca { get; set; }
        [NotMapped]
        public string empl_Creador { get; set; }
        [NotMapped]
        public int Total { get; set; }
        [NotMapped]
        public int prod_Cantidad { get; set; }
        [NotMapped]
        public int prod_Precio { get; set; }
        [NotMapped]
        public string prov_NombreContacto { get; set; }
        [NotMapped]
        public int prov_Ciudad { get; set; }
        [NotMapped]
        public string ciud_Nombre { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        [NotMapped]
        public string DadoCliente { get; set; }
        [NotMapped]
        public string Detalles { get; set; }

        [NotMapped]
        public int pais_Id { get; set; }

        [NotMapped]
        public string pais_Codigo { get; set; }

        [NotMapped]
        public string pais_Nombre { get; set; }

        [NotMapped]
        public int pvin_Id { get; set; }

        [NotMapped]
        public string pvin_Codigo { get; set; }

        [NotMapped]
        public string pvin_Nombre { get; set; }

        public virtual tbCiudades ciud { get; set; }
        public virtual tbDuca duca { get; set; }
        public virtual tbProveedores prov { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPedidosOrdenDetalle> tbPedidosOrdenDetalle { get; set; }
    }
}
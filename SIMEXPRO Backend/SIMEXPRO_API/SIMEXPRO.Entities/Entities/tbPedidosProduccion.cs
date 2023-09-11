
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPedidosProduccion
    {
        public tbPedidosProduccion()
        {
            tbOrde_Ensa_Acab_Etiq = new HashSet<tbOrde_Ensa_Acab_Etiq>();
            tbPedidosProduccionDetalles = new HashSet<tbPedidosProduccionDetalles>();
        }

        public int ppro_Id { get; set; }
        public int empl_Id { get; set; }
        public string empl_NombreCompleto { get; set; }
        public DateTime ppro_Fecha { get; set; }
        public string ppro_Estados { get; set; }
        public string ppro_Observaciones { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime ppro_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? ppro_FechaModificacion { get; set; }
        public bool? ppro_Estado { get; set; }

        [NotMapped]
        public int lote_Id { get; set; }

        [NotMapped]
        public int ppro_Finalizado { get; set; }

        [NotMapped]
        public int ppde_Cantidad { get; set; }


        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }

        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        [NotMapped]
        public string detalles { get; set; }
        [NotMapped]
        public string mensaje { get; set; }


        public virtual tbEmpleados empl { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbOrde_Ensa_Acab_Etiq> tbOrde_Ensa_Acab_Etiq { get; set; }
        public virtual ICollection<tbPedidosProduccionDetalles> tbPedidosProduccionDetalles { get; set; }
    }
}
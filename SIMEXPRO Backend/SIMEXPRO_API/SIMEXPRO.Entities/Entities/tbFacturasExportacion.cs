
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbFacturasExportacion
    {
        public tbFacturasExportacion()
        {
            tbDuca = new HashSet<tbDuca>();
            tbFacturasExportacionDetalles = new HashSet<tbFacturasExportacionDetalles>();
        }

        public int faex_Id { get; set; }
        public string duca_No_Duca { get; set; }
        public DateTime faex_Fecha { get; set; }
        public int orco_Id { get; set; }
        public decimal faex_Total { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime faex_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? faex_FechaModificacion { get; set; }

        [NotMapped]
        public string clie_Nombre_O_Razon_Social { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        [NotMapped]
        public string Detalles { get; set; }

        public virtual tbOrdenCompra orco { get; set; }
        public virtual tbDuca duca_No_DucaNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFacturasExportacionDetalles> tbFacturasExportacionDetalles { get; set; }
        public virtual ICollection<tbDuca> tbDuca { get; set; }
    }
}
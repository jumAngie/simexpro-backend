using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbFormasdePago
    {
        public tbFormasdePago()
        {
            tbDeclaraciones_Valor = new HashSet<tbDeclaraciones_Valor>();
            tbOrdenCompra = new HashSet<tbOrdenCompra>();
        }

        public int fopa_Id { get; set; }
        public string fopa_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime fopa_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? fopa_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? fopa_FechaEliminacion { get; set; }
        public bool? fopa_Estado { get; set; }

        [NotMapped]
        public string usua_NombreCreacion { get; set; }

        [NotMapped]
        public string usua_NombreModificacion { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valor { get; set; }
        public virtual ICollection<tbOrdenCompra> tbOrdenCompra { get; set; }
    }
}
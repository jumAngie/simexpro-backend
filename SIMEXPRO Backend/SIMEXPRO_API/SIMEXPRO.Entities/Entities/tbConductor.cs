
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbConductor
    {
        public tbConductor()
        {
            tbDuca = new HashSet<tbDuca>();
        }

        public int cont_Id { get; set; }
        public string cont_Nombre { get; set; }
        public string cont_Apellido { get; set; }
        public string cont_Licencia { get; set; }
        public int? pais_IdExpedicion { get; set; }
        [NotMapped]
        public string pais_Nombre { get; set; }
        public int tran_Id { get; set; }
        [NotMapped]
        public int marca_Id { get; set; }
        [NotMapped]
        public string marc_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime cont_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre{ get; set; }
        public DateTime? cont_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string usuarioEliminacionNombre { get; set; }    
        public DateTime? cont_FechaEliminacion { get; set; }
        public bool? cont_Estado { get; set; }

        public virtual tbPaises pais_IdExpedicionNavigation { get; set; }
        public virtual tbTransporte tran { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDuca { get; set; }

    }
}
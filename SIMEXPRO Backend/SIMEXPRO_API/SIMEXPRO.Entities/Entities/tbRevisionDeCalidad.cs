
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbRevisionDeCalidad
    {
        public int reca_Id { get; set; }
        public int ensa_Id { get; set; }
        [NotMapped]
        public string modu_Nombre { get; set; }
        public string reca_Descripcion { get; set; }
        public int reca_Cantidad { get; set; }
        public bool reca_Scrap { get; set; }
        public DateTime reca_FechaRevision { get; set; }
        public string reca_Imagen { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime reca_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? reca_FechaModificacion { get; set; }
        public bool? reca_Estado { get; set; }

        [NotMapped]
        public string usua_NombreUsuarioCreacion { get; set; }

        [NotMapped]
        public string usua_NombreUsuarioModificacion { get; set; }
        public virtual tbOrde_Ensa_Acab_Etiq ensa { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPaisesEstanTratadosConHonduras
    {
        public int patr_Id { get; set; }
        public int? trli_Id { get; set; }
        public int? pais_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime patr_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? patr_FechaModificacion { get; set; }

        public virtual tbTratadosLibreComercio trli { get; set; }
        public virtual tbPaises pais { get; set; }

        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}
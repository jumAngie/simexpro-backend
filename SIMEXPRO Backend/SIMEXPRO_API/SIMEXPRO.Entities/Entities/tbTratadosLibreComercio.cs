
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbTratadosLibreComercio
    {
        public tbTratadosLibreComercio()
        {
            tbDuca = new HashSet<tbDuca>();
            tbPaisesEstanTratadosConHonduras = new HashSet<tbPaisesEstanTratadosConHonduras>();
        }

        public int trli_Id { get; set; }
        public string trli_NombreTratado { get; set; }
        public DateTime trli_FechaInicio { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime trli_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? trli_FechaModificacion { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDuca { get; set; }
        public virtual ICollection<tbPaisesEstanTratadosConHonduras> tbPaisesEstanTratadosConHonduras { get; set; }
    }
}
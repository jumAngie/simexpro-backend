
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbArancelesPorTratados
    {
        public int axtl_Id { get; set; }
        public int aran_Id { get; set; }
        public int trli_Id { get; set; }
        [NotMapped]
        public string aran_Codigo { get; set; }
        [NotMapped]
        public string aran_Descripcion { get; set; }
        [NotMapped]
        public string trli_NombreTratado { get; set; }
        public decimal axtl_TasaActual { get; set; }
        public int usua_usuarioCreacion { get; set; }
        public DateTime axtl_FechaCreacion { get; set; }

        public virtual tbUsuarios usua_usuarioCreacionNavigation { get; set; }
    }
}
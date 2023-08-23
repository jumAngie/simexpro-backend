using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class RevisionDeCalidadViewModel
    {
        public int reca_Id { get; set; }
        public int ensa_Id { get; set; }
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

        public string usuarioCreacionNombre { get; set; }

        public string usuarioModificacionNombre { get; set; }


    }
}

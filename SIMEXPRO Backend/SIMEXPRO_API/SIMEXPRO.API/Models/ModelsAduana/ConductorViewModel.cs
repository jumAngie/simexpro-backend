using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ConductorViewModel
    {
        public int cont_Id { get; set; }
        public string cont_NoIdentificacion { get; set; }
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
        public string usuarioModificacionNombre { get; set; }
        public DateTime? cont_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string usuarioEliminacionNombre { get; set; }
        public DateTime? cont_FechaEliminacion { get; set; }
        public bool? cont_Estado { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class AduanasViewModel
    {
        public int adua_Id { get; set; }
        public string adua_Codigo { get; set; }
        public string adua_Nombre { get; set; }
        public string adua_Direccion_Exacta { get; set; }
        public int ciud_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime adua_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? adua_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? adua_FechaEliminacion { get; set; }
        public bool? adua_Estado { get; set; }

        
        public string usarioCreacion { get; set; }
        public string usuarioModificacion { get; set; }
    }
}

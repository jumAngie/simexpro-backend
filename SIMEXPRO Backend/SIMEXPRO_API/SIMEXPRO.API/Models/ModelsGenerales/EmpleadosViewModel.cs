using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models
{
    public class EmpleadosViewModel
    {
        public int empl_Id { get; set; }
        public string empl_Nombres { get; set; }
        public string empl_Apellidos { get; set; }
        public string empl_DNI { get; set; }
        public int escv_Id { get; set; }
        public string escv_Nombre { get; set; }
        public string empl_NombreCompleto { get; set; }
        public string empl_Sexo { get; set; }
        public DateTime empl_FechaNacimiento { get; set; }
        public string empl_Telefono { get; set; }
        public string empl_DireccionExacta { get; set; }
        public int pvin_Id { get; set; }
        public string pvin_Nombre { get; set; }
        public int pais_Id { get; set; }
        public string pais_Codigo { get; set; }
        public string pais_Nombre { get; set; }
        public string empl_CorreoElectronico { get; set; }
        public int carg_Id { get; set; }
        public string carg_Nombre { get; set; }       
        public bool empl_EsAduana { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public string usuarioCreacionNombre { get; set; }
        public DateTime empl_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public DateTime? empl_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public string usuarioEliminacionNombre { get; set; }
        public DateTime? empl_FechaEliminacion { get; set; }
        public bool? empl_Estado { get; set; }
        public int? usua_UsuarioActivacion { get; set; }
        public string usuarioActivacionNombre { get; set; }
        public DateTime? empl_FechaActivacion { get; set; }
    }
}

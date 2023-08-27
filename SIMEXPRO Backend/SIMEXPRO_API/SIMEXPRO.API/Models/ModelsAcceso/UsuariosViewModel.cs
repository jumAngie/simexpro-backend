using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAcceso
{
    public class UsuariosViewModel
    {
        public int usua_Id { get; set; }
        public string usua_Nombre { get; set; }
        public string usua_Contrasenia { get; set; }
        public string empl_CorreoElectronico { get; set; }
        public string emplNombreCompleto { get; set; }
        public string role_Descripcion { get; set; }
        public bool empl_EsAduana { get; set; }
        public int empl_Id { get; set; }
        public string usua_Image { get; set; }
        public string usua_URLInicial { get; set; }
        public int role_Id { get; set; }
        public bool usua_EsAdmin { get; set; }
        public int usua_UsuarioCreacion { get; set; }        
        public string usuarioCreacionNombre { get; set; }
        public DateTime usua_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public DateTime? usua_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public string usuarioEliminacionNombre { get; set; }
        public DateTime? usua_FechaEliminacion { get; set; }
        public bool? usua_Estado { get; set; }
        public int? usua_UsuarioActivacion { get; set; }
        public string usuarioActivacionNombre { get; set; }
        public DateTime? usua_FechaActivacion { get; set; }
    }
}

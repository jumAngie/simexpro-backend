
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbUsuariosHistorial
    {
        public int hist_Id { get; set; }
        public int? usua_Id { get; set; }
        public string usua_Nombre { get; set; }
        public string usua_Contrasenia { get; set; }
        public string usua_Correo { get; set; }
        public int? empl_Id { get; set; }
        public string usua_Image { get; set; }
        public int? role_Id { get; set; }
        public bool usua_EsAdmin { get; set; }
        public int? hist_UsuarioAccion { get; set; }
        public DateTime hist_FechaAccion { get; set; }
        public string hist_Accion { get; set; }
    }
}
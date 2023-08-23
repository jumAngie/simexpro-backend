
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbDeclarantesHistorial
    {
        public int hdec_Id { get; set; }
        public int? decl_Id { get; set; }
        public string decl_NumeroIdentificacion { get; set; }
        public string decl_Nombre_Raso { get; set; }
        public string decl_Direccion_Exacta { get; set; }
        public int ciud_Id { get; set; }
        public string decl_Correo_Electronico { get; set; }
        public string decl_Telefono { get; set; }
        public string decl_Fax { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime decl_FechaCreacion { get; set; }
        public int hdec_UsuarioModificacion { get; set; }
        public DateTime hdec_FechaModificacion { get; set; }

        public virtual tbDeclarantes decl { get; set; }
    }
}
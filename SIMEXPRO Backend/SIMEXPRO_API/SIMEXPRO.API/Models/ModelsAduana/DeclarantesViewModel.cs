using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class DeclarantesViewModel
    {
        public int decl_Id { get; set; }
        public string decl_NumeroIdentificacion { get; set; }
        public string decl_Nombre_Raso { get; set; }
        public string decl_Direccion_Exacta { get; set; }
        public int ciud_Id { get; set; }
        public string decl_Correo_Electronico { get; set; }
        public string decl_Telefono { get; set; }
        public string decl_Fax { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime decl_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? decl_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? decl_FechaEliminacion { get; set; }
        public bool? decl_Estado { get; set; }
        [NotMapped]
        public int nico_Id { get; set; }
        [NotMapped]
        public string impo_NivelComercial_Otro { get; set; }
        [NotMapped]
        public string impo_RTN { get; set; }
        [NotMapped]
        public string impo_NumRegistro { get; set; }
        [NotMapped]
        public int tite_Id { get; set; }
        [NotMapped]
        public string inte_Tipo_Otro { get; set; }
        [NotMapped]
        public int coco_Id { get; set; }
        [NotMapped]
        public string pvde_Condicion_Otra { get; set; }
    }
}

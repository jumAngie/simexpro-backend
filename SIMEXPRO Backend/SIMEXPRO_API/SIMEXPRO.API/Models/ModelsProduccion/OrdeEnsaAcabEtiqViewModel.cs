using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsProduccion
{
    public class OrdeEnsaAcabEtiqViewModel
    {
        [NotMapped]
        public string orco_Codigo { get; set; }
        [NotMapped]
        public string orco_EstadoFinalizado { get; set; }
        [NotMapped]
        public int orco_Id { get; set; }
        public int ensa_Id { get; set; }
        public int ensa_Cantidad { get; set; }
        public int empl_Id { get; set; }
        [NotMapped]
        public string empl_NombreCompleto { get; set; }
        public int rcer_Id { get; set; }
        [NotMapped]
        public string rcer_Nombre { get; set; }
        public int code_Id { get; set; }
        [NotMapped]
        public string code_Sexo { get; set; }
        [NotMapped]
        public int esti_Id { get; set; }
        [NotMapped]
        public string esti_Descripcion { get; set; }
        public DateTime ensa_FechaInicio { get; set; }
        public DateTime ensa_FechaLimite { get; set; }
        public int ppro_Id { get; set; }

        [NotMapped]
        public int proc_Id { get; set; }
        [NotMapped]
        public string proc_Descripcion { get; set; }
        [NotMapped]
        public int modu_Id { get; set; }
        [NotMapped]
        public string modu_Nombre { get; set; }
        public string detalles { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsurioCreacionNombre { get; set; }
        public DateTime ensa_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificacionNombre { get; set; }
        public DateTime? ensa_FechaModificacion { get; set; }
        public bool? ensa_Estado { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class TransportesViewModel
    {
        public int tran_Id { get; set; }
        public int? pais_Id { get; set; }
        public string tran_Chasis { get; set; }
        public int marca_Id { get; set; }
        public string tran_Remolque { get; set; }
        public int tran_CantCarga { get; set; }
        public int? tran_NumDispositivoSeguridad { get; set; }
        public string tran_Equipamiento { get; set; }
        public string tran_TipoCarga { get; set; }
        public string tran_IdContenedor { get; set; }
        public int usua_UsuarioCreacio { get; set; }
        public DateTime tran_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tran_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? trant_FechaEliminacion { get; set; }
        public bool? tran_Estado { get; set; }

         public string paisNombre { get; set; }
 
        public string marcaDescripcion { get; set; }
 
        public string usuarioCreacionNombre { get; set; }
 
        public string usuarioModificacionNombre { get; set; }
 
        public string usuarioEliminacionNombre { get; set; }

    }
}

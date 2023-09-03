
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbTransporte
    {
        public tbTransporte()
        {
            tbConductor = new HashSet<tbConductor>();
        }

        public int tran_Id { get; set; }
        public int? pais_Id { get; set; }
        public string tran_Chasis { get; set; }
        public int marca_Id { get; set; }
        public string tran_Remolque { get; set; }
        public int tran_CantCarga { get; set; }
        public int? tran_NumDispositivoSeguridad { get; set; }
        public string tran_Equipamiento { get; set; }

        public string tran_IdUnidadTransporte { get; set; }

        public string tran_TamanioEquipamiento { get; set; }
        public string tran_TipoCarga { get; set; }
        public string tran_IdContenedor { get; set; }
        public int usua_UsuarioCreacio { get; set; }
        public DateTime tran_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? tran_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? trant_FechaEliminacion { get; set; }
        public bool? tran_Estado { get; set; }

        [NotMapped]
        public string paisNombre { get; set; }

        [NotMapped]
        public string marcaDescripcion { get; set; }

        [NotMapped]
        public string usuarioCreacionNombre { get; set; }

        [NotMapped]
        public string usuarioModificacionNombre { get; set; }

        [NotMapped]
        public string usuarioEliminacionNombre { get; set; }

        public virtual tbMarcas marca { get; set; }
        public virtual tbPaises pais { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacioNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbConductor> tbConductor { get; set; }
    }
}
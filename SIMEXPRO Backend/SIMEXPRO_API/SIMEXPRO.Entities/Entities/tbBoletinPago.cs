using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbBoletinPago
    {
        public tbBoletinPago()
        {
            tbBoletinPagoDetalles = new HashSet<tbBoletinPagoDetalles>();
        }

        public int boen_Id { get; set; }
        public int liqu_Id { get; set; }
        public int duca_Id { get; set; }
        [NotMapped]
        public int duca_No_Duca { get; set; }
        [NotMapped]
        public string lige_TotalGral { get; set; }
        public int tipl_Id { get; set; }
        [NotMapped]
        public  string tipl_Descripcion { get; set; }
        public DateTime boen_FechaEmision { get; set; }
        public int esbo_Id { get; set; }
        [NotMapped]
        public string esbo_Descripcion { get; set; }
        public string boen_Observaciones { get; set; }
        public string boen_NDeclaracion { get; set; }
        public string boen_Preimpreso { get; set; }
        public decimal? boen_TotalPagar { get; set; }
        public decimal? boen_TotalGarantizar { get; set; }
        public int coim_Id { get; set; }
        [NotMapped]
        public string coim_Descripcion { get; set; }
        public int copa_Id { get; set; }

        [NotMapped]
        public string copa_Descripcion { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string usuarioCreacionNombre { get; set; }
        public DateTime boen_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string usuarioModificacionNombre { get; set; }
        public DateTime? boen_FechaModificacion { get; set; }
        public bool boen_Estado { get; set; }

        [NotMapped]
        public string Detalles { get; set; }

        public virtual tbCodigoImpuesto coim { get; set; }
        public virtual tbDuca duca { get; set; }
        public virtual tbEstadoBoletin esbo { get; set; }
        public virtual tbLiquidacionGeneral liqu { get; set; }
        public virtual tbTipoLiquidacion tipl { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbBoletinPagoDetalles> tbBoletinPagoDetalles { get; set; }
    }
}
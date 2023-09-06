
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbDocumentosDeSoporte
    {
        public int doso_Id { get; set; }
        public int tido_Id { get; set; }

        [NotMapped]
        public string tido_Codigo { get; set; }
        [NotMapped]
        public string tido_Descripcion { get; set; }

        public int duca_Id { get; set; }
        public string doso_NumeroDocumento { get; set; }
        public DateTime? doso_FechaEmision { get; set; }
        public DateTime? doso_FechaVencimiento { get; set; }
        public int doso_PaisEmision { get; set; }
        public string doso_LineaAplica { get; set; }
        public string doso_EntidadEmitioDocumento { get; set; }
        public string doso_Monto { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        public DateTime doso_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }
        public DateTime? doso_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        [NotMapped]
        public string UsuarioElimincionNombre { get; set; }
        public DateTime? doso_FechaEliminacion { get; set; }
        public bool? doso_Estado { get; set; }

        public virtual tbDuca duca { get; set; }
        public virtual tbTipoDocumento tido { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbDocumentosPDFHistorial
    {
        public int hpdf_Id { get; set; }
        public int? dpdf_Id { get; set; }
        public int deva_Id { get; set; }
        public string dpdf_CA { get; set; }
        public string dpdf_DVA { get; set; }
        public string dpdf_DUCA { get; set; }
        public string dpdf_Boletin { get; set; }
        public int? hpdf_UsuarioAccion { get; set; }
        public DateTime? hpdf_FechaAccion { get; set; }
        public string hpdf_Accion { get; set; }
    }
}
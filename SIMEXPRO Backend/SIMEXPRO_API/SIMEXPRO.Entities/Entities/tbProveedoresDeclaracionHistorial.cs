
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbProveedoresDeclaracionHistorial
    {
        public int hpvd_Id { get; set; }
        public int pvde_Id { get; set; }
        public int coco_Id { get; set; }
        public string pvde_Condicion_Otra { get; set; }
        public int decl_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime pvde_FechaCreacion { get; set; }
        public int hpvd_UsuarioModificacion { get; set; }
        public DateTime hpvd_FechaModificacion { get; set; }

        public virtual tbProveedoresDeclaracion pvde { get; set; }
    }
}
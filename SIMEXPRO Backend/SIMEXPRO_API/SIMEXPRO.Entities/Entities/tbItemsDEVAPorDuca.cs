
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbItemsDEVAPorDuca
    {
        public int dedu_Id { get; set; }
        public int duca_Id { get; set; }
        public int? deva_Id { get; set; }
        public int? usua_UsuarioCreacion { get; set; }
        public DateTime? dedu_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? dedu_FechaModificacion { get; set; }


        public virtual tbDeclaraciones_Valor deva { get; set; }
        public virtual tbDuca duca { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }

    }
}
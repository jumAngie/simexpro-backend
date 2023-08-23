
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbAduanas
    {
        public tbAduanas()
        {
            tbDeclaraciones_Valordeva_AduanaDespacho = new HashSet<tbDeclaraciones_Valor>();
            tbDeclaraciones_Valordeva_AduanaIngreso = new HashSet<tbDeclaraciones_Valor>();
            tbDucaduca_AduanaRegistroNavigation = new HashSet<tbDuca>();
            tbDucaduca_AduanaSalidaNavigation = new HashSet<tbDuca>();
        }

        public int adua_Id { get; set; }
        public string adua_Codigo { get; set; }
        public string adua_Nombre { get; set; }
        public string adua_Direccion_Exacta { get; set; }
        public int ciud_Id { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public DateTime adua_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public DateTime? adua_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? adua_FechaEliminacion { get; set; }
        public bool? adua_Estado { get; set; }

        [NotMapped]
        public string usarioCreacion { get; set; }
        [NotMapped]
        public string usuarioModificacion { get; set; }

        public virtual tbCiudades ciud { get; set; }
        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valordeva_AduanaDespacho { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valordeva_AduanaIngreso { get; set; }
        public virtual ICollection<tbDuca> tbDucaduca_AduanaRegistroNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDucaduca_AduanaSalidaNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class tbPaises
    {
        public tbPaises()
        {
            tbConductor = new HashSet<tbConductor>();
            tbPaisesEstanTratadosConHonduras = new HashSet<tbPaisesEstanTratadosConHonduras>();
            tbDucaduca_Pais_DestinoNavigation = new HashSet<tbDuca>();
            tbDucaduca_Pais_Emision_ExportadorNavigation = new HashSet<tbDuca>();
            tbDucaduca_Pais_Emision_ImportadorNavigation = new HashSet<tbDuca>();
            tbDucaduca_Pais_ExportacionNavigation = new HashSet<tbDuca>();
            tbDucaduca_Pais_ProcedenciaNavigation = new HashSet<tbDuca>();
            tbItems = new HashSet<tbItems>();
            tbProvincias = new HashSet<tbProvincias>();
            tbTransporte = new HashSet<tbTransporte>();
        }

        public int pais_Id { get; set; }
        public string pais_Codigo { get; set; }
        public string pais_Nombre { get; set; }
        public bool pais_EsAduana { get; set; }
        [NotMapped]
        public string pais_prefijo { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        [NotMapped]
        public string UsuarioCreacionNombre { get; set; }
        public DateTime pais_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        [NotMapped]
        public string UsuarioModificadorNombre { get; set; }
        public DateTime? pais_FechaModificacion { get; set; }
        public int? usua_UsuarioEliminacion { get; set; }
        public DateTime? pais_FechaEliminacion { get; set; }
        public bool? pais_Estado { get; set; }


        public virtual tbUsuarios usua_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioEliminacionNavigation { get; set; }
        public virtual tbUsuarios usua_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbConductor> tbConductor { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valor { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valorpais_Entrega { get; set; }
        public virtual ICollection<tbDeclaraciones_Valor> tbDeclaraciones_Valorpais_Exportacion { get; set; }
        public virtual ICollection<tbDuca> tbDucaduca_Pais_DestinoNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDucaduca_Pais_Emision_ExportadorNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDucaduca_Pais_Emision_ImportadorNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDucaduca_Pais_ExportacionNavigation { get; set; }
        public virtual ICollection<tbDuca> tbDucaduca_Pais_ProcedenciaNavigation { get; set; }
        public virtual ICollection<tbItems> tbItems { get; set; }
        public virtual ICollection<tbProvincias> tbProvincias { get; set; }
        public virtual ICollection<tbTransporte> tbTransporte { get; set; }
        public virtual ICollection<tbPaisesEstanTratadosConHonduras> tbPaisesEstanTratadosConHonduras { get; set; } 
    }
}
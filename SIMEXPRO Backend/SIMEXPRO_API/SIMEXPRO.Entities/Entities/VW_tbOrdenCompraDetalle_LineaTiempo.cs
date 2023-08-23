
using System;
using System.Collections.Generic;

#nullable disable

namespace SIMEXPRO.Entities.Entities
{
    public partial class VW_tbOrdenCompraDetalle_LineaTiempo
    {
        public int code_Id { get; set; }
        public int orco_Id { get; set; }
        public int code_CantidadPrenda { get; set; }
        public int esti_Id { get; set; }
        public string esti_Descripcion { get; set; }
        public int tall_Id { get; set; }
        public string tall_Codigo { get; set; }
        public string tall_Nombre { get; set; }
        public string code_Sexo { get; set; }
        public int colr_Id { get; set; }
        public string colr_Nombre { get; set; }
        public int proc_IdComienza { get; set; }
        public string proc_DescripcionComienza { get; set; }
        public DateTime procInicio_FechaInicio { get; set; }
        public DateTime procInicio_FechaLimite { get; set; }
        public string dni_empleado_procInicio { get; set; }
        public string nombre_empleado_procInicio { get; set; }
        public int proc_IdActual { get; set; }
        public string proc_DescripcionActual { get; set; }
        public DateTime procActual_FechaInicio { get; set; }
        public DateTime procActual_FechaLimite { get; set; }
        public string dni_empleado_procActual { get; set; }
        public string nombre_empleado_procActual { get; set; }
        public decimal code_Unidad { get; set; }
        public decimal code_Valor { get; set; }
        public decimal code_Impuesto { get; set; }
        public string code_EspecificacionEmbalaje { get; set; }
        public int usua_UsuarioCreacion { get; set; }
        public string usuarioCreacionNombre { get; set; }
        public DateTime code_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
        public string usuarioModificacionNombre { get; set; }
        public DateTime? code_FechaModificacion { get; set; }
        public bool? code_Estado { get; set; }
    }
}
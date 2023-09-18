using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Models.ModelsAduana
{
    public class ComercianteIndividual
    {
        public int coin_Id { get; set; }
        public int pers_Id { get; set; }

      
        public string pers_RTN { get; set; }
      
        public int escv_Id { get; set; }
      
        public string escv_Nombre { get; set; }
      
        public int ofic_Id { get; set; }
      
        public string ofic_Nombre { get; set; }
      
        public int ofpr_Id { get; set; }

        public string ofpr_Nombre { get; set; }
        public bool pers_FormaRepresentacion { get; set; }
        public int colo_Id { get; set; }
   
        public string colo_Nombre { get; set; }

        public int ciud_Id { get; set; }

        public string ciud_Nombre { get; set; }

        [NotMapped]
        public string doco_Numero_O_Referencia { get; set; }
        [NotMapped]
        public string doco_TipoDocumento { get; set; }
        [NotMapped]
        public string doco_URLImagen { get; set; }
        [NotMapped]
        public string doco_NombreImagen { get; set; }

        public int pvin_Id { get; set; }

        public string pvin_Codigo { get; set; }

        public string pvin_Nombre { get; set; }
        public int pais_Id { get; set; }
        public string pais_Codigo { get; set; }
        public string pais_Nombre { get; set; }
        public string formaRepresentacionDesc { get; set; }
        public string estadoCivilRepresentante { get; set; }
        public int pers_escvRepresentante { get; set; }
        public int pers_OfprRepresentante { get; set; }
        public string oficioProfesRepresentante { get; set; }
        public string coin_PuntoReferencia { get; set; }
        public int coin_ColoniaRepresentante { get; set; }
        public string coin_NumeroLocalReprentante { get; set; }
        public string coin_PuntoReferenciaReprentante { get; set; }
        public string coin_TelefonoCelular { get; set; }
        public string coin_TelefonoFijo { get; set; }
        public string coin_CorreoElectronico { get; set; }
        public string coin_CorreoElectronicoAlternativo { get; set; }
        public int usua_UsuarioCreacion { get; set; }
      
        public string usuarioCreacionNombre { get; set; }
        public DateTime coin_FechaCreacion { get; set; }
        public int? usua_UsuarioModificacion { get; set; }
      
        public string usuarioModificacionNombre { get; set; }
        public DateTime? coin_FechaModificacion { get; set; }
        public bool? coin_Estado { get; set; }
        public bool? coin_Finalizacion { get; set; }


        public string aldeaNombreRepresentante { get; set; }  
        public string ciudadNrepresentante { get; set; }  
        public int pvin_IdRepresentante { get; set; }     
        public string pvin_CodigoRepresentante { get; set; }  
        public string pvin_NombreRepresentante { get; set; }
        public string coloniaNombreRepresentante { get; set; }


        public string coin_DNI { get; set; }
        public string coin_DNIrepresentante { get; set; }


        public int? alde_Id { get; set; }
        public int? coin_CiudadRepresentante { get; set; }
        public int? coin_AldeaRepresentante { get; set; }
        public string coin_NumeroLocalApart { get; set; }
        public int? coin_coloniaIdRepresentante { get; set; }
        public string coin_NumeroLocaDepartRepresentante { get; set; }
        public string coin_DeclaracionComerciante { get; set; }
        public string alde_Nombre { get; set; }



    }
}

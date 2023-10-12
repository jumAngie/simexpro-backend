using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]
    public class Declaracion_ValorController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public Declaracion_ValorController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarDeclaraciones_Valor();
            return Ok(listado);
        }

        [HttpGet("Listar_ByDucaId")]
        public IActionResult Index(int id)
        {
            var listado = _aduanaServices.ListarDeclaraciones_Valor_ByDucaId(id);
            return Ok(listado);
        }

        [HttpGet("Listar_ByDevaId")]
        public IActionResult list(int id)
        {
            var listado = _aduanaServices.ListarDeclaraciones_Valor_ByDevaId(id);
            return Ok(listado);
        }

        [HttpGet("ListarHistorial")]
        public IActionResult IndexHistorial()
        {
            var listado = _aduanaServices.ListarDeclaraciones_ValorHistorial();
            return Ok(listado);
        }
        
        
        [HttpGet("ListarFacturasByDeva")]
        
        public IActionResult ListarFacturasByDeva(int deva_Id)
        {
            var listado = _aduanaServices.ListarFacturasByDeva(deva_Id);
            listado.Data = _mapper.Map<IEnumerable<FacturasViewModel>>(listado.Data);
            return Ok(listado);
        }




        [HttpPost("InsertarTab1")]
        public IActionResult InsertTab1(Declaraciones_ValorControllerViewModel item)
        {
            var itemMap = _mapper.Map<tbDeclaraciones_Valor>(item.Declaraciones_ValorViewModel);
            var declImpoMap = _mapper.Map<tbDeclarantes>(item.DeclarantesImpo_ViewModel);
            var itemImpMap = _mapper.Map<tbImportadores>(item.ImportadoresViewModel);

            var result = _aduanaServices.InsertarDeclaraciones_ValorTab1(itemMap, declImpoMap, itemImpMap);

            if (result.Code == 200)
                return Ok(result);
            else
                return BadRequest(result);

        }

        [HttpPost("InsertarTab2")]
        public IActionResult InsertTab2(Declaraciones_ValorControllerViewModel item)
        {
            var itemMap = _mapper.Map<tbDeclaraciones_Valor>(item.Declaraciones_ValorViewModel);
            var declProvMap = _mapper.Map<tbDeclarantes>(item.DeclarantesProv_ViewModel);
            var declInteMap = _mapper.Map<tbDeclarantes>(item.DeclarantesInte_ViewModel);
            var itemProvMap = _mapper.Map<tbProveedoresDeclaracion>(item.ProveedoresDeclaracionViewModel);
            var itemInteMap = _mapper.Map<tbIntermediarios>(item.IntermediarioViewModel);

            var result = _aduanaServices.InsertarDeclaraciones_ValorTab2(itemMap, declProvMap, declInteMap, itemProvMap, itemInteMap);

            if (result.Code == 200)
                return Ok(result);
            else
                return BadRequest(result);

        }

        [HttpGet("CancelarIntermediario")]
        public IActionResult CancelarIntermediario(int deva_Id)
        {
            var respuesta = _aduanaServices.CancelarIntermediario(deva_Id);

            return Ok(respuesta);
        }

        [HttpPost("InsertarTab3")]
        public IActionResult InsertTab3(Declaraciones_ValorViewModel item)
        {
            var itemMap = _mapper.Map<tbDeclaraciones_Valor>(item);

            var result = _aduanaServices.InsertarDeclaraciones_ValorTab3(itemMap);

            if (result.Code == 200)
                return Ok(result);
            else
                return BadRequest(result);

        }

        [HttpPost("EditarTab1")]
        public IActionResult UpdateTab1(Declaraciones_ValorControllerViewModel item)
        {
            var itemMap = _mapper.Map<tbDeclaraciones_Valor>(item.Declaraciones_ValorViewModel);
            var declImpoMap = _mapper.Map<tbDeclarantes>(item.DeclarantesImpo_ViewModel);
            var itemImpMap = _mapper.Map<tbImportadores>(item.ImportadoresViewModel);

            var result = _aduanaServices.ActualizarDeclaraciones_ValorTab1(itemMap, declImpoMap, itemImpMap);

            if (result.Code == 200)
                return Ok(result);
            else
                return BadRequest(result);

        }

        //[HttpPost("EditarTab2")]
        //public IActionResult UpdateTab2(Declaraciones_ValorControllerViewModel item)
        //{
        //    var itemMap = _mapper.Map<tbDeclaraciones_Valor>(item.Declaraciones_ValorViewModel);
        //    var declProvMap = _mapper.Map<tbDeclarantes>(item.DeclarantesProv_ViewModel);
        //    var declInteMap = _mapper.Map<tbDeclarantes>(item.DeclarantesInte_ViewModel);
        //    var itemProvMap = _mapper.Map<tbProveedoresDeclaracion>(item.ProveedoresDeclaracionViewModel);
        //    var itemInteMap = _mapper.Map<tbIntermediarios>(item.IntermediarioViewModel);

        //    var result = _aduanaServices.ActualizarDeclaraciones_ValorTab2(itemMap, declProvMap, declInteMap, itemProvMap, itemInteMap);

        //    if (result.Code == 200)
        //        return Ok(result);
        //    else
        //        return BadRequest(result);

        //}

        //[HttpPost("EditarTab3")]
        //public IActionResult UpdateTab3(Declaraciones_ValorViewModel item)
        //{
        //    var itemMap = _mapper.Map<tbDeclaraciones_Valor>(item);

        //    var result = _aduanaServices.ActualizarDeclaraciones_ValorTab3(itemMap);

        //    if (result.Code == 200)
        //        return Ok(result);
        //    else
        //        return BadRequest(result);

        //}

        [HttpGet("FindDeclarante")]
        public IActionResult FindDeclarante(string decl_NumeroIdentificacion)
        {
            var result = _aduanaServices.FindDeclarante(decl_NumeroIdentificacion);

                return Ok(result);

        }

        [HttpPost("FinalizarDeclaracionValor")]
        public IActionResult FinalizarPedidoOrden(string deva_Id)
        {
            var datos = _aduanaServices.FinalizarDeva(deva_Id);
            return Ok(datos);
        }

        [HttpPost("CancelarDeclaracionValor")]
        public IActionResult CancelarDeclaracionValor(int deva_Id, int fact_Id, int codi_Id, int base_Id)
        {
            var datos = _aduanaServices.CancelarDeva(deva_Id, fact_Id, codi_Id, base_Id);
            return Ok(datos);
        }
    }
}

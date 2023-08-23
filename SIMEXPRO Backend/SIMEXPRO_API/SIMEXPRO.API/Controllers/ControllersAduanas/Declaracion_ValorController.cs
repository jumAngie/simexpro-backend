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
    public class Declaracion_ValorController : ControllerBase
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
    }
}

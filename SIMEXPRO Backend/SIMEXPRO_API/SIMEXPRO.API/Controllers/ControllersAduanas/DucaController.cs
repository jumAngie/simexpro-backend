using AutoMapper;
using Microsoft.AspNetCore.Http;
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
    public class DucaController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public DucaController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult List()
        {
            var list = _aduanaServices.ListarDuca();

            list.Data = _mapper.Map<IEnumerable<DucaViewModel>>(list.Data);

            return Ok(list);
        }

        [HttpPost("Listar_ById")]
        public IActionResult List_ById(int id)
        {
            var list = _aduanaServices.ListarDuca_ById(id);

            list.Data = _mapper.Map<IEnumerable<DucaViewModel>>(list.Data);

            return Ok(list);
        }

        [HttpGet("GenerarDuca")]
        public IActionResult Genera(int duca_Id)
        {
            var listado = _aduanaServices.GenerarDuca(duca_Id);
            return Ok(listado);
        }

        [HttpGet("ListaDevaNoDuca")]
        public IActionResult ListaDevaNoDuca()
        {
            var listado = _aduanaServices.ListaDevaNoDuca();
            return Ok(listado);
        }


        [HttpPost("PreInsertar")]
        public IActionResult PreInsertar()
        {
            var result = _aduanaServices.PreInsertar();

            return Ok(result);
        }


        [HttpPost("InsertPart1")]
        public IActionResult InsertPart1(DucaViewModel item)
        {
            var result = _aduanaServices.InsertarDucaTap1(_mapper.Map<tbDuca>(item));

            return Ok(result);
        }

        [HttpPost("InsertPart2")]
        public IActionResult InsertPart2(DucaViewModel item)
        {
            var result = _aduanaServices.InsertarDucaTap2(_mapper.Map<tbDuca>(item));

            return Ok(result);
        }

        [HttpPost("InsertPart3")]
        public IActionResult InsertPart3(DocumentosDeSoporteViewModel item)
        {
            var result = _aduanaServices.InsertarDucaTap3(_mapper.Map<tbDocumentosDeSoporte>(item));

            return Ok(result);
        }

        [HttpPost("EditarPart1")]
        public IActionResult EditarPart1(DucaViewModel item)
        {
            var result = _aduanaServices.ActualizarDucaTap1(_mapper.Map<tbDuca>(item));

            return Ok(result);
        }

        [HttpPost("EditarPart2")]
        public IActionResult EditarPart2(DucaViewModel item)
        {
            var result = _aduanaServices.ActualizarDucaTap2(_mapper.Map<tbDuca>(item));

            return Ok(result);
        }

        [HttpPost("EditarPart3")]
        public IActionResult EditarPart3(DocumentosDeSoporteViewModel item)
        {
            var result = _aduanaServices.ActualizarDucaTap3(_mapper.Map<tbDocumentosDeSoporte>(item));

            return Ok(result);
        }

        [HttpPost("FinalizarDuca")]
        public IActionResult FinalizarDuca(int duca_Id)
        {
            var datos = _aduanaServices.FinalizarDuca(duca_Id);
            return Ok(datos);
        }

        [HttpPost("CancelarEliminar")]
        public IActionResult CancelarEliminarDuca(int duca_Id)
        {
            var datos = _aduanaServices.CancelarEliminarDuca(duca_Id);
            return Ok(datos);
        }
    }
}

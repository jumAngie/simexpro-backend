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

        [HttpGet("VerificarExistencia")]
        public IActionResult VerificarExistencia(string duca_No_Duca)
        {
            var datos = _aduanaServices.VerificarExistencia(duca_No_Duca);
            return Ok(datos);
        }

        [HttpPost("PreInsertar")]
        public IActionResult PreInsertar(DucaViewModel item)
        {
            var result = _aduanaServices.PreInsertar(_mapper.Map<tbDuca>(item));

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
            var result = _aduanaServices.InsertarDucaTap3(_mapper.Map<tbDocumentosDeSoporte>(item));

            return Ok(result);
        }
    }
}

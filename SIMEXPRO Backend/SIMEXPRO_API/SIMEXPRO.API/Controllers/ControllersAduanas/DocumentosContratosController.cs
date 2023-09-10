using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.BussinessLogic.Services.EventoServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SIMEXPRO.API.Models.ModelsAduana;
using SIMEXPRO.Entities.Entities;

namespace SIMEXPRO.API.Controllers.ControllersAduanas
{
    [Route("api/[controller]")]
    [ApiController]

    public class DocumentosContratosController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public DocumentosContratosController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarDocumentosContratos();
            listado.Data = _mapper.Map<IEnumerable<DocumentosContratosViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("InsertarDocuComerciante")]
        public IActionResult Insert(DocumentosContratosViewModel documentosContratosViewModel)
        {
            var item = _mapper.Map<tbDocumentosContratos>(documentosContratosViewModel);
            var respuesta = _aduanaServices.InsertarDocumentosComerciante(item);
            return Ok(respuesta);
        }

        [HttpPost("EditarDocuComerciante")]
        public IActionResult Update(DocumentosContratosViewModel documentosContratosViewModel)
        {
            var item = _mapper.Map<tbDocumentosContratos>(documentosContratosViewModel);
            var respuesta = _aduanaServices.ActualizarDocumentosComerciante(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(DocumentosContratosViewModel documentosContratosViewModel)
        {
            var item = _mapper.Map<tbDocumentosContratos>(documentosContratosViewModel);
            var respuesta = _aduanaServices.EliminarDocumentosContratos(item);
            return Ok(respuesta);
        }
    }

}


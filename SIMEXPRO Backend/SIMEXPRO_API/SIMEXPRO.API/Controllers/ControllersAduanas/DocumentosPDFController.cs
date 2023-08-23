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
    public class DocumentosPDFController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public DocumentosPDFController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarDocumentosPDF();
            listado.Data = _mapper.Map<IEnumerable<DocumentosPDFViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(DocumentosPDFViewModel documentosContratosViewModel)
        {
            var item = _mapper.Map<tbDocumentosPDF>(documentosContratosViewModel);
            var respuesta = _aduanaServices.InsertarDocumentosPDF(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(DocumentosPDFViewModel documentosContratosViewModel)
        {
            var item = _mapper.Map<tbDocumentosPDF>(documentosContratosViewModel);
            var respuesta = _aduanaServices.ActualizarDocumentosPDF(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(DocumentosPDFViewModel documentosContratosViewModel)
        {
            var item = _mapper.Map<tbDocumentosPDF>(documentosContratosViewModel);
            var respuesta = _aduanaServices.EliminarDocumentosPDF(item);
            return Ok(respuesta);
        }
    }
}

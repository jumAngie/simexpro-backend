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
    public class DocumentosDeSoporteController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public DocumentosDeSoporteController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarDocumentosdeSoporte();
            listado.Data = _mapper.Map<IEnumerable<DocumentosDeSoporteViewModel>>(listado.Data);
            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(DocumentosDeSoporteViewModel documentosContratosViewModel)
        {
            var item = _mapper.Map<tbDocumentosDeSoporte>(documentosContratosViewModel);
            var respuesta = _aduanaServices.InsertarDocumentosdeSoporte(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(int doso_Id)
        {
            var respuesta = _aduanaServices.EliminarDocumentosdeSoporte(doso_Id);

            return Ok(respuesta);
        }
    }
}

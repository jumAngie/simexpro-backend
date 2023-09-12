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
    public class DocumentosSancionesController : ControllerBase
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public DocumentosSancionesController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult List()
        {
            var list = _aduanaServices.ListarDocumentosSanciones();

            list.Data = _mapper.Map<IEnumerable<DocumentosSancionesViewModel>>(list.Data);

            return Ok(list);
        }

        [HttpPost("Insertar")]
        public IActionResult Insert(DocumentosSancionesViewModel item)
        {
            var result = _aduanaServices.InsertarDocumentoSanciones(_mapper.Map<tbDocumentosSanciones>(item));

            return Ok(result);
        }

    }
}

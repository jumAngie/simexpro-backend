using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models;
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
    public class TipoDocumentoController : Controller
    {
        private readonly AduanaServices _aduanaServices;
        private readonly IMapper _mapper;

        public TipoDocumentoController(AduanaServices AduanaServices, IMapper mapper)
        {
            _aduanaServices = AduanaServices;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _aduanaServices.ListarTipoDocumento();
            listado.Data = _mapper.Map<IEnumerable<TipoDocumentoViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(TipoDocumentoViewModel tipoDocumentoViewModel)
        {
            var item = _mapper.Map<tbTipoDocumento>(tipoDocumentoViewModel);
            var respuesta = _aduanaServices.InsertarTipoDocumento(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(TipoDocumentoViewModel tipoDocumentoViewModel)
        {
            var item = _mapper.Map<tbTipoDocumento>(tipoDocumentoViewModel);
            var respuesta = _aduanaServices.ActualizarTipoDocumento(item);
            return Ok(respuesta);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(TipoDocumentoViewModel tipoDocumentoViewModel)
        //{
        //    var item = _mapper.Map<tbTipoDocumento>(tipoDocumentoViewModel);
        //    var respuesta = _aduanaServices.EliminarTipoDocumento(item);
        //    return Ok(respuesta);
        //}
    }
}

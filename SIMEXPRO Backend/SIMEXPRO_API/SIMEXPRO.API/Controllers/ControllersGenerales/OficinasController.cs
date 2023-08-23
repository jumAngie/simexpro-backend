using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models;
using SIMEXPRO.BussinessLogic.Services.GeneralServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersGenerales
{
    [Route("api/[controller]")]
    [ApiController]
    public class OficinasController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public OficinasController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _generalesServices.ListarOficinas();
            listado.Data = _mapper.Map<IEnumerable<OficinasViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(OficinasViewModel oficinasViewModel)
        {
            var item = _mapper.Map<tbOficinas>(oficinasViewModel);
            var respuesta = _generalesServices.InsertarOficinas(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(OficinasViewModel oficinasViewModel)
        {
            var item = _mapper.Map<tbOficinas>(oficinasViewModel);
            var respuesta = _generalesServices.ActualizarOficinas(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(OficinasViewModel oficinasViewModel)
        {
            var item = _mapper.Map<tbOficinas>(oficinasViewModel);
            var respuesta = _generalesServices.EliminarOficinas(item);
            return Ok(respuesta);
        }
    }
}

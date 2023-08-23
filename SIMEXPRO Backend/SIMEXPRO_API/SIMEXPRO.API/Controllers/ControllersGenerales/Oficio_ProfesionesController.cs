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
    public class Oficio_ProfesionesController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public Oficio_ProfesionesController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }
        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _generalesServices.ListarOficio_Profesiones();
            listado.Data = _mapper.Map<IEnumerable<Oficio_ProfesionesViewModel>>(listado.Data);
            return Ok(listado);
        }


        [HttpPost("Insertar")]
        public IActionResult Insert(Oficio_ProfesionesViewModel oficio_ProfesionesViewModel)
        {
            var item = _mapper.Map<tbOficio_Profesiones>(oficio_ProfesionesViewModel);
            var respuesta = _generalesServices.InsertarOficio_Profesiones(item);
            return Ok(respuesta);
        }


        [HttpPost("Editar")]
        public IActionResult Update(Oficio_ProfesionesViewModel oficio_ProfesionesViewModel)
        {
            var item = _mapper.Map<tbOficio_Profesiones>(oficio_ProfesionesViewModel);
            var respuesta = _generalesServices.ActualizarOficio_Profesiones(item);
            return Ok(respuesta);
        }

        //[HttpPost("Eliminar")]
        //public IActionResult Delete(Oficio_ProfesionesViewModel oficio_ProfesionesViewModel)
        //{
        //    var item = _mapper.Map<tbOficio_Profesiones>(oficio_ProfesionesViewModel);
        //    var respuesta = _generalesServices.EliminarOficio_Profesiones(item);
        //    return Ok(respuesta);
        //}
    }
}

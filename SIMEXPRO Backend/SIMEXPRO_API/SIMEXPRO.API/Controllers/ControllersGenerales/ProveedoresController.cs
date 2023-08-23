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
    public class ProveedoresController : Controller
    {
        private readonly GeneralServices _generalesServices;
        private readonly IMapper _mapper;

        public ProveedoresController(GeneralServices generalesService, IMapper mapper)
        {
            _generalesServices = generalesService;
            _mapper = mapper;
        }

        [HttpGet("Listar")]
        public IActionResult Index()
        {
            var listado = _generalesServices.ListarProveedores();
            listado.Data = _mapper.Map<IEnumerable<ProveedoresViewModel>>(listado.Data);
            return Ok(listado);
        }

       
        [HttpPost("Insertar")]
        public IActionResult Insert(ProveedoresViewModel proveedoresViewModel)
        {
            var item = _mapper.Map<tbProveedores>(proveedoresViewModel);
            var respuesta = _generalesServices.InsertarProveedores(item);
            return Ok(respuesta);
        }

        [HttpPost("Editar")]
        public IActionResult Update(ProveedoresViewModel proveedoresViewModel)
        {
            var item = _mapper.Map<tbProveedores>(proveedoresViewModel);
            var respuesta = _generalesServices.ActualizarProveedores(item);
            return Ok(respuesta);
        }

        [HttpPost("Eliminar")]
        public IActionResult Delete(ProveedoresViewModel proveedoresViewModel)
        {
            var item = _mapper.Map<tbProveedores>(proveedoresViewModel);
            var respuesta = _generalesServices.EliminarProveedores(item);
            return Ok(respuesta);
        }
    }
}

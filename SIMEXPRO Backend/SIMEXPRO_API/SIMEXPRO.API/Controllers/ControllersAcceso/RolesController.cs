using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsAcceso;
using SIMEXPRO.BussinessLogic.Services.AccesoServices;
using SIMEXPRO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersAcceso
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : Controller
    {
        private readonly AccesoServices _accesoServices;
        private readonly IMapper _mapper;

        public RolesController(AccesoServices accesoService, IMapper mapper)
        {
            _accesoServices = accesoService;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index(bool? role_Aduana)
        {
            var listado = _accesoServices.ListarRoles(role_Aduana);

            listado.Data = _mapper.Map<IEnumerable<RolesViewModel>>(listado.Data);

            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(RolesViewModel roles)
        {
            var mapped = _mapper.Map<tbRoles>(roles);
            var datos = _accesoServices.InsertarRol(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(RolesViewModel roles)
        {
            var mapped = _mapper.Map<tbRoles>(roles);
            var datos = _accesoServices.ActualizarRol(mapped);
            return Ok(datos);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(RolesViewModel roles)
        {
            var mapped = _mapper.Map<tbRoles>(roles);
            var datos = _accesoServices.DeleteRol(mapped);
            return Ok(datos);
        }

    }
}

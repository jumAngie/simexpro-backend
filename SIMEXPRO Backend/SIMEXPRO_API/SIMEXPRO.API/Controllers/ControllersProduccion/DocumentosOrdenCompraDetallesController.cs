using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIMEXPRO.API.Models.ModelsProduccion;
 using SIMEXPRO.BussinessLogic.Services.ProduccionServices;
using SIMEXPRO.Entities.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIMEXPRO.API.Controllers.ControllersProduccion
{

    [Route("api/[controller]")]
    [ApiController]
    public class DocumentosOrdenCompraDetallesController : Controller
    {
        private readonly ProduccionServices _produccionServices;
        private readonly IMapper _mapper;

        public DocumentosOrdenCompraDetallesController(ProduccionServices produccionServices, IMapper mapper)
        {
            _produccionServices = produccionServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Index(int orco_Id)
        {
            var listado = _produccionServices.ListarDocumentosOrdenCompraDetalles(orco_Id);

            listado.Data = _mapper.Map<IEnumerable<DocumentosOrdenCompraDetallesViewModel>>(listado.Data);

            return Ok(listado);
        }

        [HttpPost("Insertar")]
        public IActionResult Insertar(DocumentosOrdenCompraDetallesViewModel tbDocumentosOrdenCompraDetalles)
        {
            var mapped = _mapper.Map<tbDocumentosOrdenCompraDetalles>(tbDocumentosOrdenCompraDetalles);
            var datos = _produccionServices.InsertarDocumentosOrdenCompraDetalles(mapped);
            return Ok(datos);
        }

        [HttpPost("Editar")]
        public IActionResult Editar(DocumentosOrdenCompraDetallesViewModel tbDocumentosOrdenCompraDetalles)
        {
            var mapped = _mapper.Map<tbDocumentosOrdenCompraDetalles>(tbDocumentosOrdenCompraDetalles);
            var datos = _produccionServices.ActualizarDocumentosOrdenCompraDetalles(mapped);
            return Ok(datos);
        }

        [HttpPost("Eliminar")]
        public IActionResult Eliminar(DocumentosOrdenCompraDetallesViewModel tbDocumentosOrdenCompraDetalles)
        {
            var mapped = _mapper.Map<tbDocumentosOrdenCompraDetalles>(tbDocumentosOrdenCompraDetalles);
            var datos = _produccionServices.EliminarDocumentosOrdenCompraDetalles(mapped);
            return Ok(datos);
        }
    }
}

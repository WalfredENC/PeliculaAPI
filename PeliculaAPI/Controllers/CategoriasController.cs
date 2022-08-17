using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeliculaAPI.Models;
using PeliculaAPI.Models.Dtos;
using PeliculaAPI.Repository.IRepository;

namespace PeliculaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : Controller
    {
        private readonly ICategoriaRepository _ctRepo;
        private readonly IMapper _mapper;
        public CategoriasController(ICategoriaRepository ctRepo, IMapper mapper)
        {
            _ctRepo = ctRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllCategorias()
        {
            var listacategorias = _ctRepo.GetCategorias();

            var listaCategoriasDto = new List<CategoriaDto>();
            foreach (var lista in listacategorias)
            {
                listaCategoriasDto.Add(_mapper.Map<CategoriaDto>(lista));
            }
            return Ok(listaCategoriasDto);
        }

        [HttpGet("{categoriaId:int}", Name = "GetCategoria")]
        public IActionResult GetCategoria(int categoriaId)
        {
            var itemCategoria = _ctRepo.GetCategoria(categoriaId);
            if (itemCategoria == null)
            {
                return NotFound();

            }
            var itemCategoriaDto = _mapper.Map<CategoriaDto>(itemCategoria);
            return Ok(itemCategoriaDto);
        }
        [HttpPost]
        public IActionResult CrearCategoria([FromBody] CategoriaDto categoriaDtos)
        {
            if (categoriaDtos == null)
            {
                return BadRequest(ModelState);
            }
            if (_ctRepo.ExisteCategoria(categoriaDtos.Nombre))
            {
                ModelState.AddModelError("", "La categoria ya existe");
                return StatusCode(404, ModelState);
            }
            var categoria = _mapper.Map<Categoria>(categoriaDtos);
            if (!_ctRepo.CrearCategoria(categoria))
            {
                ModelState.AddModelError("", $"Algo salio mal guardando el registro {categoria.Nombre}");
                return StatusCode(500, ModelState);
            }
            return CreatedAtRoute("GetCategoria", new { categoriaId = categoria.Id }, categoria);
        }
    }
}

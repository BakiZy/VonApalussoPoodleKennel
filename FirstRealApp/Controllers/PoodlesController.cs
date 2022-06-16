using AutoMapper;
using AutoMapper.QueryableExtensions;
using FirstRealApp.Interfaces;
using FirstRealApp.Models.DTO_models.PoodleDTos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRealApp.Controllers
{
    [Route("api/poodles")]
    [ApiController]
    [AllowAnonymous]
    
    public class PoodlesController : ControllerBase
    {
        private readonly IPoodlesRepository _poodlesRepository;

        private readonly IMapper _mapper;

        public PoodlesController(IPoodlesRepository poodlesRepository, IMapper mapper)
        {
            _poodlesRepository = poodlesRepository;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult GetAllPoodles()
        {
            return Ok(_poodlesRepository.GetAll().ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider));
        }

        [HttpGet("{id}")]
        public IActionResult GetPoodleById(int id)
        {

            var poodle = _poodlesRepository.GetById(id);

            
            if (poodle == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PoodleDTO>(poodle));
        }

    }
}

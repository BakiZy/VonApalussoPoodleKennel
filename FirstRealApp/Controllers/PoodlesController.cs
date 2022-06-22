using AutoMapper;
using AutoMapper.QueryableExtensions;
using FirstRealApp.Interfaces;
using FirstRealApp.Models.DTO_models.PoodleDTos;
using FirstRealApp.Models.PoodleEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRealApp.Controllers
{
    [Route("api/poodles")]
    [ApiController]
    [Authorize]

    public class PoodlesController : ControllerBase
    {
        private readonly IPoodlesRepository _poodlesRepository;
        private readonly IPoodleSizesRepository _poodleSizesRepository;
        private readonly IMapper _mapper;

        public PoodlesController(IPoodlesRepository poodlesRepository, IPoodleSizesRepository poodleSizesRepository,  IMapper mapper)
        {
            _poodleSizesRepository = poodleSizesRepository;
            _poodlesRepository = poodlesRepository;
            _mapper = mapper;
        }

        
        

        [HttpGet]
        [AllowAnonymous]
        [Route("/api/poodles/list-sizes")]
        public IActionResult GetAllPoodleSizes()
        {
            return Ok(_poodleSizesRepository.GetAllSizes());
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetAllPoodles()
        {
            return Ok(_poodlesRepository.GetAll().ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider));
        }


        [AllowAnonymous]
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

        [HttpPost]

        public IActionResult AddNewPoodle(Poodle poodle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _poodlesRepository.Add(poodle);

            return CreatedAtAction("GetPoodleById", new { id = poodle.Id });

        }

        [HttpDelete("{id}")]

        public IActionResult DeletePoodle(int id )
        {
            var poodle = _poodlesRepository.GetById(id);

            if (poodle == null)
            {
                return NotFound();
            }

            _poodlesRepository.Delete(poodle);
            return NoContent();
        }


       





    }
}

using AutoMapper;
using AutoMapper.QueryableExtensions;
using FirstRealApp.Interfaces;
using FirstRealApp.Models.DTO_models.FilterDTOS;
using FirstRealApp.Models.DTO_models.PoodleDTos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstRealApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        private readonly IFilterRepository _filterRepo;
        private readonly IMapper _mapper;

        public FilterController(IFilterRepository filterRepository, IMapper mapper)
        {
            _filterRepo = filterRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/filters/search-by-color")]

        public IActionResult FilterPoodlesByColor([FromQuery] SearchPoodlesByColorDTO serachByColor )

        {
            return Ok(_filterRepo.SearchPoodleByColor(serachByColor.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
        }

        [HttpGet]
        [Route("/api/filters/search-by-size")]
        public IActionResult FilterPoodlesBySize([FromQuery] SearchPoodlesBySizeDTO searchPoodlesBySizeDTO)
        {
            return Ok(_filterRepo.SearchPoodleBySize(searchPoodlesBySizeDTO.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());


        }

        [HttpGet]
        [Route("/api/filters/search-by-name")]

        public IActionResult FilterPoodleByName([FromQuery] SearchPoodlesByNameDTO searchPoodlesByNameDTO)
        {
            return Ok(_filterRepo.SearchPoodleByName(searchPoodlesByNameDTO.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
        }



    }
}

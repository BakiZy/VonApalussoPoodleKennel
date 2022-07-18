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

        public IActionResult FilterPoodlesByColor([FromQuery] PoodleNameFilterDTO serachByColor)

        {

            return Ok(_filterRepo.FilterPoodleByColor(serachByColor.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
        }

        [HttpGet]
        [Route("/api/filters/search-by-size")]
        public IActionResult FilterPoodlesBySize([FromQuery] PoodleNameFilterDTO searchPoodlesBySize)
        {

            return Ok(_filterRepo.FilterPoodleBySize(searchPoodlesBySize.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());


        }


        [HttpGet]
        [Route("/api/filters/color-and-size")]

        public IActionResult FilterSizeAndCollor([FromQuery] FilterPoodleDTO filter)
        {
            return Ok(_filterRepo.FilterSizeAndColor(filter.SizeName, filter.ColorName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [HttpGet]
        [Route("/api/filters/search-by-name/")]

        public IActionResult FilterPoodleByName([FromQuery] PoodleNameFilterDTO searchPoodlesByName)
        {
            if (string.IsNullOrEmpty(searchPoodlesByName.Name))
            {
                return Ok(_filterRepo.GetAll().ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider));
            }

            return Ok(_filterRepo.FilterPoodleByName(searchPoodlesByName.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
        }



    }


}

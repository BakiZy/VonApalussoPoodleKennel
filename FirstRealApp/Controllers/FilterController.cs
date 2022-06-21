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

            return Ok(_filterRepo.SearchPoodleByColor(serachByColor.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
        }

        [HttpGet]
        [Route("/api/filters/search-by-size")]
        public IActionResult FilterPoodlesBySize([FromQuery] PoodleNameFilterDTO searchPoodlesBySize)
        {

            return Ok(_filterRepo.SearchPoodleBySize(searchPoodlesBySize.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());


        }

        [HttpGet]
        [Route("/api/filters/search-by-name/")]

        public IActionResult FilterPoodleByName([FromQuery] PoodleNameFilterDTO searchPoodlesByName)
        {
            if (string.IsNullOrEmpty(searchPoodlesByName.Name)) 
            {
                return Ok(_filterRepo.GetAll().ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider));
            }
          
            return Ok(_filterRepo.SearchPoodleByName(searchPoodlesByName.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
        }

        [HttpGet]
        [Route("/api/filters/filterall")]

        public IActionResult Filter([FromQuery] FilterPoodleDTO filter )
        {
            if (filter.ColorName == null && filter.SizeName == null)
            {
                return Ok(_filterRepo.GetAll().ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider));
            }

            if (filter.ColorName == null && filter.SizeName != null)
            {
                return Ok(_filterRepo.SearchPoodleBySize(filter.SizeName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
            }

            if (filter.SizeName == null && filter.ColorName != null)
            {
                return Ok(_filterRepo.SearchPoodleByColor(filter.ColorName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());

            }

            return Ok (_filterRepo.Filter(filter.SizeName, filter.ColorName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());


        }





    }
}

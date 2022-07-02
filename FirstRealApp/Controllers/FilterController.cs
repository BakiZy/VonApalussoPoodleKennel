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
        [Route("/api/filters/by-color-and-name")]

        public IActionResult FilterByColorAndName([FromQuery] FilterPoodleDTO filterPoodleDTO)
        {
            return Ok(_filterRepo.FilterNameAndColor(filterPoodleDTO.ColorName, filterPoodleDTO.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
        }


        [HttpGet]
        [Route("/api/filters/color-and-size")]

        public IActionResult FilterColorAndSize([FromQuery] FilterPoodleDTO filter)
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


        [HttpGet]
        [Route("/api/filters/filterall")]

        public IActionResult Filter([FromQuery] FilterPoodleDTO filter)
        {

            // all nulls return full list
            if (filter.ColorName == null && filter.SizeName == null && string.IsNullOrEmpty(filter.Name))
            {
                return Ok(_filterRepo.GetAll().ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider));
            }

            //all nulls but size, return by size
            if (filter.ColorName == null && filter.SizeName != null && string.IsNullOrEmpty(filter.Name))
            {
                return Ok(_filterRepo.FilterPoodleBySize(filter.SizeName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
            }

            //all nulls but color return by color
            if (filter.SizeName == null && filter.ColorName != null && string.IsNullOrEmpty(filter.Name))
            {
                return Ok(_filterRepo.FilterPoodleByColor(filter.ColorName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
            }
            //all nulls but name 
            if (!string.IsNullOrEmpty(filter.Name) && filter.ColorName == null && filter.SizeName == null)
            {
                return Ok(_filterRepo.FilterPoodleByName(filter.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
            }

            //filter by color and size, name null
            if (string.IsNullOrEmpty(filter.Name) && filter.ColorName != null && filter.SizeName != null)
            {

                return Ok(_filterRepo.FilterSizeAndColor(filter.SizeName, filter.ColorName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
            }
            //filter all
            if (!string.IsNullOrEmpty(filter.Name) && filter.ColorName != null && filter.SizeName != null)
            {
                return Ok(_filterRepo.FilterAll(filter.SizeName, filter.ColorName, filter.Name).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
            }

            //filter by name and color 
            if (!string.IsNullOrEmpty(filter.Name) && filter.ColorName != null && filter.SizeName == null)
            {

                return Ok(_filterRepo.FilterNameAndColor(filter.Name, filter.ColorName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());

            }
            //filter by name and size


            if (!string.IsNullOrEmpty(filter.Name) && filter.ColorName == null && filter.SizeName != null)
            {
                return Ok(_filterRepo.FilterNameAndSize(filter.Name, filter.SizeName).ProjectTo<PoodleDTO>(_mapper.ConfigurationProvider).ToList());
            }

            return BadRequest();

        }
    }


}

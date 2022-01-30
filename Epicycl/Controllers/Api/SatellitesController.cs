using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Epicycl.DTOs;
using Epicycl.Models;
using Microsoft.AspNetCore.Http.Extensions;
using System.Web.Http;

namespace Epicycl.Controllers.Api
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class SatellitesController : ControllerBase
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public SatellitesController(DataContext dataContext, IMapper mapper)
        {
            _context = dataContext;
            _mapper = mapper;
        }

        // GET /api/satellites
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<SatelliteDto> GetSatellites()
        {
            return _context.Satellites.ToList().Select(_mapper.Map<Satellite, SatelliteDto>);
        }
        // GET /api/satellites/{id}
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public ActionResult GetSatellite(int id)
        {
            var satellite = _context.Satellites.SingleOrDefault(x => x.Id == id);
            if (satellite == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<Satellite, SatelliteDto>(satellite));
        }

        // POST /api/satellites
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public ActionResult CreateSatellite(SatelliteDto satelliteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var satellite = _mapper.Map<SatelliteDto, Satellite>(satelliteDto);
            _context.Satellites.Add(satellite);
            _context.SaveChanges();
            satellite.Id = satelliteDto.Id;

            return Created(new Uri(Request.GetEncodedUrl() + "/" + satellite.Id), satelliteDto);

        }

        // PUT  /api/satellites/{id}
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public void EditSatellite(int id, SatelliteDto satelliteDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }
            var satelliteInDb = _context.Satellites.SingleOrDefault(x => x.Id == id);
            if (satelliteDto == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            _mapper.Map(satelliteDto, satelliteInDb);
            _context.SaveChanges();
        }

        // DELETE /api/satellites/{id}
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public void DeleteSatellite(int id)
        {
            var satellite = _context.Satellites.SingleOrDefault(x => x.Id == id);
            if (satellite == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            _context.Satellites.Remove(satellite);
            _context.SaveChanges();
        }
        
    }
}

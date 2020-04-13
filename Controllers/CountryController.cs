using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PinArt_ProfileInfo_MS.Models;

namespace PinArt_ProfileInfo_MS.Controllers
{
    [ApiController]
    [Route("api/country")]
    public class CountryController : ControllerBase
    {
        private readonly InfoContext _context;

        public CountryController(InfoContext context) => _context = context;

        // GET:     api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Country>> GetCountries()
        {
            return _context.Countries;
        }

        // GET:     api/commands/n
        [HttpGet("{id}")]
        public ActionResult<Country> GetCountryId(int id)
        {
            var countryItem = _context.Countries.Find(id);

            if (countryItem == null)
            {
                return NotFound();
            }

            return countryItem;
        }

        // POST:    api/commnands
        [HttpPost]
        public ActionResult<Country> CreateCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();

            return CreatedAtAction("GetCountryId", new Country { Id = country.Id }, country);
        }

    }
}
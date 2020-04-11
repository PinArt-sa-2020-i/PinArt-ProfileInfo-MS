using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PinArt_ProfileInfo_MS.Models;

namespace PinArt_ProfileInfo_MS.Controllers
{
    [ApiController]
    [Route("api/profile")]
    public class ProfileController : ControllerBase
    {
        private readonly InfoContext _context;

        public ProfileController(InfoContext context) => _context = context;

        // GET:     api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Profile>> GetProfiles()
        {
            return _context.Profiles;
        }

        // GET:     api/commands/n
        [HttpGet("{id}")]
        public ActionResult<Profile> GetProfileId(int id)
        {
            var profileItem = _context.Profiles.Find(id);

            if (profileItem == null)
            {
                return NotFound();
            }

            return profileItem;
        }

        // POST:    api/commnands
        [HttpPost]
        public ActionResult<Profile> CreateProfile(Profile profile)
        {
            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return CreatedAtAction("GetProfileId", new Profile { Id = profile.Id, UserId = profile.UserId, CountryId = profile.Id }, profile);
        }

    }
}
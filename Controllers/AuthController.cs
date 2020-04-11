using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PinArt_ProfileInfo_MS.Models;

namespace PinArt_ProfileInfo_MS.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly InfoContext _context;

        public AuthController(InfoContext context) => _context = context;

        // GET:     api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Authentication>> GetAuths()
        {
            return _context.Authentications;
        }

        // GET:     api/commands/n
        [HttpGet("{id}")]
        public ActionResult<Authentication> GetAuthId(int id)
        {
            var authItem = _context.Authentications.Find(id);

            if (authItem == null)
            {
                return NotFound();
            }

            return authItem;
        }

        // POST:    api/commnands
        [HttpPost]
        public ActionResult<Authentication> CreateAuthPolicy(Authentication auth)
        {
            _context.Authentications.Add(auth);
            _context.SaveChanges();

            return CreatedAtAction("GetAuthId", new Authentication { Id = auth.Id, UserId = auth.UserId }, auth);
        }

    }
}
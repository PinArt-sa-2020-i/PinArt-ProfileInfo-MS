using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PinArt_ProfileInfo_MS.Models;

namespace PinArt_ProfileInfo_MS.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly InfoContext _context;

        public UserController(InfoContext context) => _context = context;

        // GET:     api/commands
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _context.Users;
        }

        // GET:     api/commands/n
        [HttpGet("{id}")]
        public ActionResult<User> GetUserId(int id)
        {
            var commandItem = _context.Users.Find(id);

            if (commandItem == null)
            {
                return NotFound();
            }

            return commandItem;
        }

        // POST:    api/commnands
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return CreatedAtAction("GetUserId", new User { Id = user.Id }, user);
        }

    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PinArt_ProfileInfo_MS.Models;

namespace PinArt_ProfileInfo_MS.Controllers
{
    [ApiController]
    [Route("api/recovery")]
    public class RecoveryController : ControllerBase
    {
        private readonly InfoContext _context;

        public RecoveryController(InfoContext context) => _context = context;

        // GET:     api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Recovery>> GetRecoveries()
        {
            return _context.Recoveries;
        }

        // GET:     api/commands/n
        [HttpGet("{id}")]
        public ActionResult<Recovery> GetRecoveryId(int id)
        {
            var recoveryItem = _context.Recoveries.Find(id);

            if (recoveryItem == null)
            {
                return NotFound();
            }

            return recoveryItem;
        }

        // POST:    api/commnands
        [HttpPost]
        public ActionResult<Recovery> CreateRecovery(Recovery recovery)
        {
            _context.Recoveries.Add(recovery);
            _context.SaveChanges();

            return CreatedAtAction("GetRecoveryId", new Recovery { Id = recovery.Id, UserId = recovery.UserId }, recovery);
        }

    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PinArt_ProfileInfo_MS.Models;

namespace PinArt_ProfileInfo_MS.Controllers
{
    [ApiController]
    [Route("api/cause")]
    public class CauseController : ControllerBase
    {
        private readonly InfoContext _context;

        public CauseController(InfoContext context) => _context = context;

        // GET:     api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Cause>> GetCauses()
        {
            return _context.Causes;
        }

        // GET:     api/commands/n
        [HttpGet("{id}")]
        public ActionResult<Cause> GetCauseId(int id)
        {
            var causeItem = _context.Causes.Find(id);

            if (causeItem == null)
            {
                return NotFound();
            }

            return causeItem;
        }

        // POST:    api/commnands
        [HttpPost]
        public ActionResult<Cause> CreateReportCause(Cause cause)
        {
            _context.Causes.Add(cause);
            _context.SaveChanges();

            return CreatedAtAction("GetCauseId", new Cause { Id = cause.Id }, cause);
        }

    }
}
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PinArt_ProfileInfo_MS.Models;

namespace PinArt_ProfileInfo_MS.Controllers
{
    [ApiController]
    [Route("api/report")]
    public class ReportController : ControllerBase
    {
        private readonly InfoContext _context;

        public ReportController(InfoContext context) => _context = context;

        // GET:     api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Report>> GetReports()
        {
            return _context.Reports;
        }

        // GET:     api/commands/n
        [HttpGet("{id}")]
        public ActionResult<Report> GetReportId(int id)
        {
            var reportItem = _context.Reports.Find(id);

            if (reportItem == null)
            {
                return NotFound();
            }

            return reportItem;
        }

        // POST:    api/commnands
        [HttpPost]
        public ActionResult<Report> CreateReport(Report report)
        {
            _context.Reports.Add(report);
            _context.SaveChanges();

            return CreatedAtAction("GetReportId", new Report { Id = report.Id, UserId = report.UserId, CauseId = report.CauseId }, report);
        }

    }
}
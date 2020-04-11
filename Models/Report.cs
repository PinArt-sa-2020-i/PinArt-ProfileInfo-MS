using System;

namespace PinArt_ProfileInfo_MS.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Comentario { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int CauseId { get; set; }
        public virtual Cause Cause { get; set; }

    }
}
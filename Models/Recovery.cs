using System;

namespace PinArt_ProfileInfo_MS.Models
{
    public class Recovery
    {
        public int Id { get; set; }
        public string RecoveryCode { get; set; }
        public bool Used { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }

        public Recovery()
        {
            this.CreatedDate = DateTime.UtcNow;
        }

    }
}
using System;
using System.Collections.Generic;

namespace PinArt_ProfileInfo_MS.Models
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string Correo { get; set; }
        public bool Eliminado { get; set; }
        public bool Privado { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual List<Authentication> Auth { get; set; } = new List<Authentication>();

        public virtual List<Profile> Profiles { get; set; } = new List<Profile>();

        public virtual List<Recovery> Recoveries { get; set; } = new List<Recovery>();

        public virtual List<Report> Received { get; set; } = new List<Report>();


        public User()
        {
            this.CreatedDate = DateTime.UtcNow;
        }
    }
}
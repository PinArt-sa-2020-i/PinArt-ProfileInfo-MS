using System;

namespace PinArt_ProfileInfo_MS.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public string NoTelefono { get; set; }
        public string Edad { get; set; }

        public int UserId { get; set; }

        public int CountryId { get; set; }

    }
}
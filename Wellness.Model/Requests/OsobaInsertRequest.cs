using System;
using System.Collections.Generic;
using System.Text;

namespace Wellness.Model.Requests
{
    public class OsobaInsertRequest
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodenja { get; set; }
        public string Spol { get; set; }
        public string Jmbg { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public int? GradId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
        public int UlogaId { get; set; }

    }
}


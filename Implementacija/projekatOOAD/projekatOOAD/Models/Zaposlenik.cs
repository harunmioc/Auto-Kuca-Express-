using System;

namespace projekatOOAD.Models
{
    public class Zaposlenik
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Korpa Korpa { get; set; }
        public Guid idProizvoda { get; private set; }
        public Guid idZaposlenika { get; private set; }

        public Zaposlenik(string username, string email, string password, string ime, string prezime, Korpa korpa, Guid IdProizvoda, Guid idZaposlenika)
        {
            Username = username;
            Email = email;
            Password = password;
            Ime = ime;
            Prezime = prezime;
            Korpa = korpa;
            idProizvoda = IdProizvoda != Guid.Empty ? IdProizvoda : Guid.NewGuid();
            idZaposlenika
        }
    }
}

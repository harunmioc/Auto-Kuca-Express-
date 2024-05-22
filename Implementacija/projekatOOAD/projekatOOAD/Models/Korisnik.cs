namespace projekatOOAD.Models
{
    public class Korisnik : Osoba
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        Korpa korpa { get; set; }

        [Key]
        public Guid idKorisnika { get; private set; }

        public Korisnik(Guid idKorisnika, string username, string email, string password, string ime, string prezime, Korpa korpa)
        {
            this.idKorisnika = idKorisnika != Guid.Empty ? idKorisnika : Guid.NewGuid();
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.Ime = ime;
            this.Prezime = prezime;
            this.korpa = korpa;
        }



    }
}
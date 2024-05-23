using Microsoft.AspNetCore.Identity;

namespace projekatOOAD.Models
{
    public class Korisnik : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ProfilePicture { get; set; }
        //iznad je od IdentitiyUser 

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
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
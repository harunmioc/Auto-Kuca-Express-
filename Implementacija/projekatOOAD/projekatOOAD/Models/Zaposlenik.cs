using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekatOOAD.Models
{
    public class Zaposlenik : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ProfilePicture { get; set; }
        //iznad je od IdentitiyUser 

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Korpa Korpa { get; set; }

        [ForeignKey("Proizvod")]
        public Guid idProizvoda { get; private set; }
        [Key]
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

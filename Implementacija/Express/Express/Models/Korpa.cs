
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Express.Models
{
    public class Korpa
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("Korisnik")] public int idKorisnika { get; set; }
        //public Korisnik Korisnik { get; set; } // Assuming Korisnik class exists

        public string brojKartice { get; set; }

       // public ICollection<KorpaProizvod> KorpaProizvodi { get; set; } // Navigation property for one-to-many relationship

        public Korpa() { }

        public Korpa(int Id, int IdKorisnika, string BrojKartice)
        {
            id = Id;
            idKorisnika = IdKorisnika;
            brojKartice = BrojKartice;
           // KorpaProizvodi = new List<KorpaProizvod>(); // Initialize empty list
        }
    }

}

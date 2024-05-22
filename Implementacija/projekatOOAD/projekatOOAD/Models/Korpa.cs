using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekatOOAD.Models
{
    public class Korpa
    {
        [Key]
        public Guid id { get; private set; }

        [ForeignKey("Korisnik")]
        public Guid idKorisnika { get; private set; }

        public string brojKartice { get; set; }

        public Korpa(Guid IdKorisnika, string BrojKartice)
        {
            id = Guid.NewGuid(); 
            idKorisnika = IdKorisnika; 
            brojKartice = BrojKartice;
        }
    }
}

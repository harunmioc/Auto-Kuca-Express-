using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projekatOOAD.Models
{
    public class Kartica
    {
        [Key]
        public Guid id { get; private set; }

        public string BrojKartice { get; private set; }

        [ForeignKey("Korisnik")]
        public Guid IdKorisnika { get; private set; }

        public Kartica(Guid Id, string brojKartice, Guid idKorisnika)
        {
            id = Id != Guid.Empty ? Id : Guid.NewGuid();
            BrojKartice = brojKartice;
            IdKorisnika = idKorisnika;
        }
    }
}

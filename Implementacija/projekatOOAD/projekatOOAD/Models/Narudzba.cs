using System;

namespace projekatOOAD.Models
{
    public class Narudzba
    {
        public int Cijena { get; set; }
        public string AdresaDostave { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public Guid IdProizvoda { get; private set; }

        public Narudzba(int cijena, string adresaDostave, DateTime datumNarudzbe, Guid idProizvoda)
        {
            Cijena = cijena;
            AdresaDostave = adresaDostave;
            DatumNarudzbe = datumNarudzbe;
            IdProizvoda = idProizvoda;
        }
    }
}

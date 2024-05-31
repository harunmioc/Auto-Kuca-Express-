using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Express.Models
{
    public class KorpaProizvod
    {
        [Key] public int id { get; set; }

        [ForeignKey("Korpa")] public int idKorpe { get; set; }
      //  public Korpa Korpa { get; set; }

        [ForeignKey("Proizvod")] public int idProizvoda { get; set; }
        //public Proizvod Proizvod { get; set; }

        public int Kolicina { get; set; } 

        public KorpaProizvod() { }

        public KorpaProizvod(int IdKorpe, int IdProizvoda, int Kolicina)
        {
            idKorpe = IdKorpe;
            idProizvoda = IdProizvoda;
            this.Kolicina = Kolicina;
        }
    }

}

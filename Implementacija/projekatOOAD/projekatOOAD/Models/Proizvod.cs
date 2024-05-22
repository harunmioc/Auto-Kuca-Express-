using System;
using System.ComponentModel.DataAnnotations;

namespace projekatOOAD.Models
{
    public class Proizvod
    {
        [Key]
        public Guid id { get; private set; }
        public string Proizvodjac { get; set; }
        public string Model { get; set; }
        public double Cijena { get; set; }

        public Proizvod(Guid Id, string proizvodjac, string model, double cijena)
        {
            id = Id != Guid.Empty ? Id : Guid.NewGuid();
            Proizvodjac = proizvodjac;
            Model = model;
            Cijena = cijena;
        }
    }
}

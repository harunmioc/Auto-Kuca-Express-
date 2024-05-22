namespace projekatOOAD.Models
{
    public interface Osoba
    {
        string Username { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Ime { get; set; }   
        string Prezime { get; set; }

    }
}

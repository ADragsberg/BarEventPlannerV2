using System.ComponentModel.DataAnnotations;

namespace BarEventPlannerV2.Models
{
    public abstract class Personoplysninger
        //Skrevet af Andreas Dragsberg
    {
        public Personoplysninger()
        {

        }
        public Personoplysninger(string fornavn, string efternavn, string email, int telefonnummer)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Email = email;
            Telefonnummer = telefonnummer;
            Id = telefonnummer;
        }
        
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public int Id { get; set; }

        [EmailAddress]
        public string Email     { get; set; }
        [Phone]
        public int Telefonnummer { get; set; }    


    }
}

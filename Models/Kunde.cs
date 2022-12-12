using BarEventPlannerV2.Service.Repositories.Interface;

namespace BarEventPlannerV2.Models
{
    public class Kunde: Personoplysninger, IUpdateFromOther<Kunde>
        // Skrevet af Andreas Dragsberg
    {

        //public Kunde(string fornavn, string efternavn, string email, int telefonnummer)
        //    : base ( fornavn, efternavn, email, telefonnummer )
        //{

        //}
        public Kunde()
            :base()
        {

        }
        public void Update(Kunde tOther)
        {
            Fornavn = tOther.Fornavn;
            Efternavn = tOther.Efternavn;
            Email =tOther.Email;
            Telefonnummer = tOther.Telefonnummer;
            Id = tOther.Id;


        }

    }
}

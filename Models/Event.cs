using BarEventPlannerV2.Service.Repositories.Interface;
namespace BarEventPlannerV2.Models
{
    // TODO: ikke abstrakt endnu. Skal nok have flere properties/felter i fremtiden.

    /// <summary>
    /// Base klasse for alle events (ikke abstrakt endnu).
    /// </summary>
    public class Event : IHasId
    {
        /// <summary>
        /// Unikt Id for eventet.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Titel på eventet.
        /// </summary>
        public string Titel { get; set; }

        /// <summary>
        /// Er eventet privat eller offentligt.
        /// </summary>
        public bool PrivatEvent { get; set; }

        /// <summary>
        /// Antal af forventede personer til event.
        /// </summary>
        public int AntalPersoner { get; set; }

        /// <summary>
        /// Beskrivelse af eventet.
        /// </summary>
        public string Beskrivelse { get; set; }

        /// <summary>
        /// Kommentarer til eventet.
        /// </summary>
        public string Kommentar { get; set; }

        /// <summary>
        /// Start tidspunkt på eventet.
        /// </summary>
        public DateTime StartTidspunkt { get; set; }

        /// <summary>
        /// Slut tidspunkt på eventet.
        /// </summary>
        public DateTime SlutTidspunkt { get; set; }

        /// <summary>
        /// Tidsrum for eventet.
        /// </summary>
        public TimeSpan Tidsrum { get; set; }

        public bool Godkendt { get ; set; }

        /// <summary>
        /// Billede/ikon til eventet.
        /// </summary>
        //public string Image { get; set; }

        /// <summary>
        /// Konstruktør for Event.
        /// </summary>
        public Event()
        {
            Godkendt = false;
        }

        /// <summary>
        /// Konstruktør med parametre for EventBase
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titel"></param>
        /// <param name="beskrivelse"></param>
        /// <param name="dato"></param>
        /// <param name="tidsrum"></param>
        ///// <param name="image"></param>
        public Event(int id, int antalPersoner, string titel, bool privatEvent, string beskrivelse, string kommentar, TimeSpan tidsrum)
        {
            Id = id;
            AntalPersoner = antalPersoner;
            Titel = titel;
            PrivatEvent = privatEvent;
            Beskrivelse = beskrivelse;
            Kommentar = kommentar;
            Tidsrum = tidsrum;

        }

    }

}

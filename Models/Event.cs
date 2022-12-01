namespace BarEventPlannerV2.Models
{
    // TODO: ikke abstrakt endnu. Skal nok have flere properties/felter i fremtiden.

    /// <summary>
    /// Base klasse for alle events (ikke abstrakt endnu).
    /// </summary>
    public class Event
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

        /// <summary>
        /// Billede/ikon til eventet.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Konstruktør for EventBase.
        /// </summary>
        public Event()
        {

        }

        /// <summary>
        /// Konstruktør med parametre for EventBase
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titel"></param>
        /// <param name="beskrivelse"></param>
        /// <param name="dato"></param>
        /// <param name="tidsrum"></param>
        /// <param name="image"></param>
        public Event(int id, int antalPersoner, string titel, bool privatEvent, string beskrivelse, TimeSpan tidsrum, string image)
        {
            Id = id;
            AntalPersoner = antalPersoner;
            Titel = titel;
            PrivatEvent = privatEvent;
            Beskrivelse = beskrivelse;
            Tidsrum = tidsrum;
            Image = image;

        }

    }

}

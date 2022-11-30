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
        /// Beskrivelse af eventet.
        /// </summary>
        public string Beskrivelse { get; set; }

        /// <summary>
        /// Datoen af eventet.
        /// </summary>
        public DateTime Dato { get; set; }

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
        public Event(int id, string titel, string beskrivelse, DateTime dato, TimeSpan tidsrum, string image)
        {
            Id = id;
            Titel = titel;
            Beskrivelse = beskrivelse;
            Dato = dato;
            Tidsrum = tidsrum;
            Image = image;
        }

    }

}

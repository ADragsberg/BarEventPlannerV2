using BarEventPlannerV2.Service.Repositories.Interface;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BarEventPlannerV2.Models
{//Skrevet af Tristan og Andreas, Mikkel
    // TODO: Skal nok have flere properties/felter i fremtiden.
    // TODO: I fremtiden skal vi nok lave, at Event har en Kunde some felt/prop eller reference via. ID.

    /// <summary>
    /// Base klasse for alle events (ikke abstrakt endnu).
    /// </summary>
    public class Event : IHasId, IUpdateFromOther<Event>
    {
        /// <summary>
        /// Unikt Id for eventet.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Titel på eventet.
        /// </summary>
        [Required(ErrorMessage = "Der skal angives en Titel til et Event")]
        public string? Titel { get; set; }

        /// <summary>
        /// Er eventet privat eller offentligt.
        /// </summary>
        public bool? PrivatEvent { get; set; }

        /// <summary>
        /// Antal af forventede personer til event.
        /// </summary>
        [Required(ErrorMessage = "Der skal angives antal Personer til et Event")]
        [Range(typeof(int), "0", "100", ErrorMessage = "Antal af Personer skal være mellem {1} og {2}")]
        public int? AntalPersoner { get; set; }

        /// <summary>
        /// Beskrivelse af eventet.
        /// </summary>
        [Required(ErrorMessage = "Der skal angives en Beskrivelse af Eventet")]
        public string? Beskrivelse { get; set; }

        /// <summary>
        /// Kommentarer til eventet.
        /// </summary>
        public string? Kommentar { get; set; }

        /// <summary>
        /// Start tidspunkt på eventet.
        /// </summary>
        [Required(ErrorMessage = "Der skal angives et Starttidspunkt til et Event")]
        public DateTime StartTidspunkt { get; set; }

        /// <summary>
        /// Slut tidspunkt på eventet.
        /// </summary>
        [Required(ErrorMessage = "Der skal angives et Sluttidspunkt til et Event")]
        public DateTime SlutTidspunkt { get; set; }

        /// <summary>
        /// Tidsrum for eventet.
        /// </summary>
        public TimeSpan? Tidsrum { get ; set; }

        /// <summary>
        /// Er et Event godkendt eller ej
        /// </summary>
        public bool? Godkendt { get ; set; }

        /// <summary>
        /// Kunden der har booket et Event
        /// </summary>
        public Kunde? Kunde { get; set; }

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

        public void Update(Event tOther)
        {           
            Titel = tOther.Titel;
            PrivatEvent = tOther.PrivatEvent;
            AntalPersoner = tOther.AntalPersoner;
            StartTidspunkt = tOther.StartTidspunkt;
            SlutTidspunkt = tOther.SlutTidspunkt;
            Kommentar = tOther.Kommentar;
            Beskrivelse = tOther.Beskrivelse;
        }

    }

}

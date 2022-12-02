﻿using System.ComponentModel.DataAnnotations;
using BarEventPlannerV2.Service.Repositories.Interface;

namespace BarEventPlannerV2.Models
{
    public abstract class Personoplysninger : IHasId
        //Skrevet af Andreas Dragsberg
    {
        public Personoplysninger()
        {

        }
        //public Personoplysninger(string fornavn, string efternavn, string email, int telefonnummer)
        //{
        //    Fornavn = fornavn;
        //    Efternavn = efternavn;
        //    Email = email;
        //    Telefonnummer = telefonnummer;
        //    Id = telefonnummer;
        //}
        [Required(ErrorMessage = "Hvad er dit fornavn?")]
        public string Fornavn { get; set; }
        [Required(ErrorMessage = "Hvad er dit efternavn?")]
        public string Efternavn { get; set; }

        public int Id { get; set; }

        [EmailAddress]
        public string Email     { get; set; }
        [Required(ErrorMessage = "Du skal angive dit telefonnummer.")]
        public int Telefonnummer { get; set; }    


    }
}

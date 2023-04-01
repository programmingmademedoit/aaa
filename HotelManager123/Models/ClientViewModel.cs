using DataLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservationsManager.Models.Client
{
    public class ClientViewModel : BaseViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [MaxLength(10, ErrorMessage = "Please enter a valid telefon number!")]
        [Required]
        [Display(Name = "Telefon number")]
        public int PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email!")]
        [Required]
        [Display(Name = "email")]
        public string Email { get; set; }

        public int ReservationId { get; set; }


        [Display(Name = "Adult")]
        public bool IsAdult { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarShared.DAL.Entities
{
    public class Trip
    {
        public int TripId { get; set; }
        [Required(ErrorMessage = "Departure City is a Required field.")]
        [DataType(DataType.Text)]
        [Display(Name = "Departure City")]
        public string Country { get; set; }
        public string DepartureCity { get; set; }
        [Required(ErrorMessage = "Arrival City is a Required field.")]
        [DataType(DataType.Text)]
        [Display(Name = "Arrival City")]
        public string ArrivalCity { get; set; }

        public int IdDriver { get; set; }
        [Required(ErrorMessage = "Date of your Trip is a Required field.")]
        [DataType(DataType.Date)]
        [Display(Name = "Trip Date")]
        public DateTime TripDate { get; set; }
        [Display(Name = "Spot Number")]
        [Range(1, 4, ErrorMessage = "Number of available spots should be between 1 and 4")]
        public int NumberOfSpots { get; set; }
        [Required(ErrorMessage = "The price of the ride is a Required field.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Desciption")]
        public string Description { get; set; }
    }
}
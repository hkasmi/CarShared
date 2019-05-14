using CarShared.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.DAL.Entities
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Country Name is a Required field.")]
        [DataType(DataType.Text)]
        [Display(Name = "Country")]
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}

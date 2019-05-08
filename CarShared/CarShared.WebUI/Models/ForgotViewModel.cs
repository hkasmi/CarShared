﻿using System.ComponentModel.DataAnnotations;

namespace CarShared.WebUI.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

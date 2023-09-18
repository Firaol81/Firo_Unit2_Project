using System;
using System.ComponentModel.DataAnnotations;

namespace AgeCalculatorApp.Models
{
    public class AgeCalculatorModel
    {
        [Required(ErrorMessage = "Please enter your birthdate")]
        [DataType(DataType.Date)]
        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }

        public int Age { get; set; }
    }
}

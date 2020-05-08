using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishID { get; set; }


        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least {1} characters")]
        [Display(Name = "Dish Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required.")]
        [MinLength(2, ErrorMessage = "must be at least {1} characters")]
        [Display(Name = "Chef's Name")]
        public string Chef { get; set; }


        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Tastiness")]
        public int Tastiness { get; set; }


        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Calories")]
        public int Calories { get; set; }


        [Required(ErrorMessage = "is required.")]
        [Display(Name = "Description")]
        public string Description { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}
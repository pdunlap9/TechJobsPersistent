using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 20 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Location is required!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Location must be between 3 and 20 characters long")]
        public string Location { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace ProjectCare01.Models
{
    public class Concern
    {
        public string Name { get; set; }
        [Display(Name = "Contact Number")]
        public int ContactNo { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Key]
        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Order Number")]
        public string OrderNo { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Concern")]
        public string Problem { get; set; }
    }
}

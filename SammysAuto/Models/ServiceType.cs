using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SammysAuto.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter service type")]
        [Display(Name ="Service Type")]
        [StringLength(50,ErrorMessage ="Service type name can be between 10 to 50 charactors long", MinimumLength=10)]
        public string ServiceName { get; set; }
    }
}

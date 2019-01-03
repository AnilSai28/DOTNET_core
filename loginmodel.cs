using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace first_mvc_core.Models
{
    public class loginmodel
    {
        [Display(Name ="Login ID")]
        [Required(ErrorMessage ="*")]
        public string LoginID { get; set; }

        [Display(Name = "Password ")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleCrm.Web.Models
{
    public class CustomerEditViewModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required()]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required()]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required()]
        public string PhoneNumber { get; set; }

        [Display(Name = "Get our Newsletter?")]
        public bool OptInNewsletter { get; set; }
        
        public CustomerType Type { get; set; }
    }
}

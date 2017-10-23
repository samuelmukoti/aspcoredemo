using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Data
{
    public class Customer
    {
        
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Customer Name is required")]
        [StringLength(100)]
        [Display(Name="Customer Name")]
        public string Name { get; set; }
        public int VASId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$)")]
        public string Password { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace _30TipsAndTricks.WebForms.Models
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        [Required()]
        public string FirstName { get; set; }
        [Required()]
        public string LastName { get; set; }
        [Required()]
        public string Address { get; set; }
        [Required()]
        public string City { get; set; }
        [Required()]
        public string State { get; set; }
        [Required()]
        public string Zip { get; set; }

        public string EmailAddress { get; set; }

    }
}
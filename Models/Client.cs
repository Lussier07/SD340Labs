using System.ComponentModel.DataAnnotations;

namespace Lab1DataAnnotations.Models
{
    public class Client
    {
        public string Id { get; set; }

        [StringLength(25, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        public Client() { }
    }
}

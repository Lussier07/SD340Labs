using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1DataAnnotations.Models
{
    public class Client
    {
        public string Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(25, MinimumLength = 3)]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required]
        [StringLength(25, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        public bool CreditIsValid { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string CreditHolderName { get; set; }

        public DateTime CreditExpiryDate { get; set; }

        [InverseProperty("CurrentClient")]
        public Room? CurrentRoom { get; set; }
        public int? CurrentRoomId { get; set; }

        [InverseProperty("PreviousClient")]
        public Room? PreviousRoom { get; set; }
        public int? PreviousRoomId { get; set; }

        public Client() { }
    }
}

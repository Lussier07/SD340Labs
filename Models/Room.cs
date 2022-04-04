using System.ComponentModel.DataAnnotations;

namespace Lab1DataAnnotations.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        
        public int Capacity { get; set; }

        public Section Section { get; set; }

        public Room() { }
    }
    public enum Section
    {
        First,
        Second,
        Third
    }
}

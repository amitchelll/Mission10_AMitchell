using System.ComponentModel.DataAnnotations;

namespace Mission10_API.Data
{
    public class BowlerAndTeam
    {
        [Key]
        public int BowlerId { get; set; }
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public string? BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }
        public int TeamId { get; set; }
        public string? TeamName { get; set; }
        public int? CaptainId { get; set; }
    }
}


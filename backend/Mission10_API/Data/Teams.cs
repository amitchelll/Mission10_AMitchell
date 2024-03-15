using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_API.Data
{
    public class Teams
    {
        [Key]
        [Required]
        public int TeamID { get; set; }

        public string? TeamName { get; set; }

        public int? CaptainID { get; set; }
    }
}

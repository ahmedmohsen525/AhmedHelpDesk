using System.ComponentModel.DataAnnotations;

namespace FRA.Update_Dto
{
    public class UpdateServiceProvider
    {
        [Required]
        public required string Name { get; set; }
        public required string Email { get; set; }
        public DateTime End_Time { get; set; }
    }
}

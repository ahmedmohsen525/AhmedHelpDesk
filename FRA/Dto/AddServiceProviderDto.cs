using System.ComponentModel.DataAnnotations;

namespace FRA.Dto
{
    public class AddServiceProviderDto
    {
        [Required]
        public required string Name { get; set; }
        public required string Email { get; set; }
        public DateTime End_Time { get; set; }
    }
}

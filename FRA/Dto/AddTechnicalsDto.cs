using System.ComponentModel.DataAnnotations;

namespace FRA.Dto
{
    public class AddTechnicalsDto
    {
        [Required]
        public string? Group_name { get; set; }
    }
}

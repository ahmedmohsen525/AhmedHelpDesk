using System.ComponentModel.DataAnnotations;

namespace FRA.Dto
{
    public class AddEvaluationDto
    {
        [Required]
        public  string? Service_levels { get; set; }
        
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
    }
}

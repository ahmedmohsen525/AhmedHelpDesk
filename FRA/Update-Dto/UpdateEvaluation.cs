using System.ComponentModel.DataAnnotations;

namespace FRA.Update_Dto
{
    public class UpdateEvaluation
    {
        [Required]
        public required string Service_levels { get; set; }
        
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace FRA.Update_Dto
{
    public class UpdateStatus
    {
        [Required]
        public  string? Status_name { get; set; }
        public DateTime Str_time { get; set; }
        public DateTime End_time { get; set; }
        
    }
}

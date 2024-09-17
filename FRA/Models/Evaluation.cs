using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FRA.Models
{
    public class Evaluation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [ForeignKey("Service_Type")]
        public int Service_ID { get; set; }
        public  string? Service_levels { get; set; }
        public int Agent_ID  { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
    }
}

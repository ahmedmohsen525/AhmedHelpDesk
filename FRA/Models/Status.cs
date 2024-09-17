using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FRA.Models
{
    public class Status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Status_ID { get; set; }
      
        public required string Status_name { get; set; }
        public DateTime Str_time { get; set; }
        public DateTime End_time { get; set; }

    }
}

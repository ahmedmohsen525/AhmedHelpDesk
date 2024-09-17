using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FRA.Models
{
    public class ServiceType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Service_ID { get; set; }
        [ForeignKey("Cat_ID")]
        public int Cat_ID { get; set; }
        public int Agent_ID { get; set; }
        public required string Service_nam { get; set; }
        public required string Descr { get; set; }
        public DateTime Request_time { get; set; }
        public DateTime Start_time { get; set; }
        public int prioity { get; set; }
        public required string Service_levels { get; set; }
    }
}

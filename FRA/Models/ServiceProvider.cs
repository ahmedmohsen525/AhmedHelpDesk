using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FRA.Models
{
    public class ServiceProvider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int  Agent_ID { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public DateTime End_Time { get; set; }

        public virtual List<ServiceType> ServiceType { get; set; } = new List<ServiceType>();
        public virtual List<TecnicalGrop> TecnicalGrop { get; set; } = new List<TecnicalGrop>();
        public virtual List<Ticket> Ticket { get; set; } = new List<Ticket>();
    }
}

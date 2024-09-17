using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FRA.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ticket_ID { get; set; }
        public required string Title { get; set; }
        public required string Descr { get; set; }
        public required string TicketType { get; set; }
        public DateTime Created_Date { get; set; }
        public DateTime Resolved_Date { get; set; }

        public int Service_ID { get; set; }
    }
}

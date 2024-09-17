using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FRA.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Emp_ID { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Phone_Num { get; set; }

        public virtual List<Ticket> Tickets { get; } = new List<Ticket>();
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FRA.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        
        public int Cat_ID { get; set; }
        public  string? Cat_name { get; set; }
        public virtual List<ServiceType> ServiceType { get; set; } = new List<ServiceType>();
    }
}

using System.ComponentModel.DataAnnotations;

namespace FRA.Dto
{
    public class AddCategoryDto
    {
        [Required]
        public  string? Cat_name { get; set; }
    }
}

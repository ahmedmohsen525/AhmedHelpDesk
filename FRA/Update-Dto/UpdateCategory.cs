using System.ComponentModel.DataAnnotations;

namespace FRA.Update_Dto
{
    public class UpdateCategory
    {
        [Required]
        public string? Cat_name { get; set; }
    }
}

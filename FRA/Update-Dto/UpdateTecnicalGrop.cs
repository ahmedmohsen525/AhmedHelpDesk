using System.ComponentModel.DataAnnotations;

namespace FRA.Update_Dto
{
    public class UpdateTecnicalGrop

    {
        [Required]
        public string? Group_name { get; set; }
    }
}

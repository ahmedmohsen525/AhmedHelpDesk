using System.ComponentModel.DataAnnotations.Schema;

namespace FRA.Dto
{
    public class AddTicket_caseDto
    {
        [ForeignKey("Category")]
        public int Cat_ID { get; set; }
        [ForeignKey("Status")]
        public int Status_ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime ResolvedTime { get; set; }
        //Add sup Catigeros (Hard Were )
        public string? Hardwere_Name { get; set; }
        public string? Hardwere_Type { get; set; }
        //Add sup Catigeros (Application Resent )
        public string? AddProblemResnt { get; set; }
        public string? select { get; set; }
        //Add sup Catigeros (Application New )
        public string? AddProblemNew { get; set; }
        //Add sup Catigeros (Knoledg Ser)

        public string? Knoledg_Name { get; set; }

        //Add sup Catigeros (Hosting)
        public string? Hosting_Name { get; set; }
        //Add sup Catigeros (Training inside_outside)
        public string? Inside { get; set; }
        public string? outside { get; set; }

        //Add sup Catigeros (conference )
        public string? Insidecon { get; set; }
        public string? Outsidecon { get; set; }
    }
}

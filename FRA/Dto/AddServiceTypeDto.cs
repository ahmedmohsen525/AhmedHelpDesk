namespace FRA.Dto
{
    public class AddServiceTypeDto
    {
        public required string Service_nam { get; set; }
        public required string Descr { get; set; }
        public DateTime Request_time { get; set; }
        public DateTime Start_time { get; set; }
        public int prioity { get; set; }
        public required string Service_levels { get; set; }
    }
}

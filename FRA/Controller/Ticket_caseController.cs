using FRA.Data;
using FRA.Dto;
using FRA.Models;
using FRA.Update_Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FRA.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ticket_caseController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public Ticket_caseController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllTecnicalGrop()
        {
            var Ticket_case = dbContext.Types.ToList();
            return Ok(Ticket_case);
        }
                        //Get With ID ONlY
        [HttpGet]
        [Route("{ID:int}")]
        public IActionResult GetTecnicalGropByID(int ID)
        {
            var Ticket_case = dbContext.Ticket_cases.Find(ID);
            if (Ticket_case is null)
            {
                return NotFound();
            }
            return Ok(Ticket_case);

        }



        
        //Add New Opject 
        [HttpPost]
        public IActionResult Ticket_case(AddTicket_caseDto ticket_CaseDto)
        {

            var Ticket_case = new Ticket_case()
            {
                Cat_ID = ticket_CaseDto.Cat_ID,
                Status_ID = ticket_CaseDto.Status_ID,
                Description = ticket_CaseDto.Description,
                ResolvedTime = ticket_CaseDto.ResolvedTime,
                Hardwere_Name = ticket_CaseDto.Hardwere_Name,
                Hardwere_Type = ticket_CaseDto.Hardwere_Type,
                AddProblemResnt = ticket_CaseDto.AddProblemResnt,
                select = ticket_CaseDto.select,
                AddProblemNew = ticket_CaseDto.AddProblemNew,
                Knoledg_Name = ticket_CaseDto.Knoledg_Name,
                Hosting_Name = ticket_CaseDto.Hosting_Name,
                Inside = ticket_CaseDto.Inside,
                outside = ticket_CaseDto.outside,
                Insidecon = ticket_CaseDto.Insidecon,
                Outsidecon = ticket_CaseDto.Outsidecon
            };

            dbContext.Ticket_cases.Add(Ticket_case);
            dbContext.SaveChanges();

            return Ok(Ticket_case);


        }
                           //Update  METHOD

        [HttpPut]
        [Route("{ID:int}")]
        public IActionResult UpdateTicket_case(int ID, UpdateTicket_case ticket_Case)
        {
            var Ticket_case = dbContext.Ticket_cases.Find(ID);
            if (Ticket_case is null)
            {
                return NotFound();
            }


            Ticket_case.Cat_ID = ticket_Case.Cat_ID;
            Ticket_case.Status_ID = ticket_Case.Status_ID;
            Ticket_case.Name = ticket_Case.Name;
            Ticket_case.Description = ticket_Case.Description;
            Ticket_case.ResolvedTime = ticket_Case.ResolvedTime;
            Ticket_case.Hardwere_Name = ticket_Case.Hardwere_Name;
            Ticket_case.Hardwere_Type = ticket_Case.Hardwere_Type;
            Ticket_case.AddProblemResnt = ticket_Case.AddProblemResnt;
            Ticket_case.select = ticket_Case.select;
            Ticket_case.AddProblemNew = ticket_Case.AddProblemNew;
            Ticket_case.Knoledg_Name = ticket_Case.Knoledg_Name;
            Ticket_case.Hosting_Name = ticket_Case.Hosting_Name;
            Ticket_case.Inside = ticket_Case.Inside;
            Ticket_case.outside = ticket_Case.outside;
            Ticket_case.Insidecon = ticket_Case.Insidecon;
            Ticket_case.Outsidecon = ticket_Case.Outsidecon;
            dbContext.SaveChanges();
            return Ok(Ticket_case);
        }

                            //DELET METHOD
        [HttpDelete]
        [Route("{ID:int}")]
        public IActionResult DeleteTicket_case(int ID)
        {
            var Ticket_case = dbContext.Ticket_cases.Find(ID);
            if (Ticket_case is null)
            {
                return NotFound();
            }
            dbContext.Ticket_cases.Remove(Ticket_case);
            dbContext.SaveChanges();
            return Ok(Ticket_case);
        }

    }
}

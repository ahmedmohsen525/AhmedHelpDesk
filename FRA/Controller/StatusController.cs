using FRA.Data;
using FRA.Dto;
using FRA.Models;
using FRA.Update_Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Status = FRA.Models.Status;
namespace FRA.Controller
{

    [Route("api/[controller]")]
    [ApiController]



    public class StatusController : ControllerBase
    {
       
        
        private readonly ApplicationDbContext dbContext;

        public StatusController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

                    //get Method

        [HttpGet]
        public IActionResult GetAllStatus()
        {
            var AllStatuses = dbContext.Statuses.ToList();
            return Ok(AllStatuses);
        }

                            //Get With ID ONlY  

        [HttpGet]
        [Route("{Status_ID:int}")]
        public IActionResult GetStatusByStatus_ID(int Status_ID)
        {
            var Statuses = dbContext.Statuses.Find(Status_ID);
            if (Statuses is null)
            {
                return NotFound();
            }
            return Ok(Statuses);

        }

                               //Add New Opject 

        [HttpPost]
        public IActionResult Status(AddStatusDto addStatusDto)
        {
            var Statuses = new Status()
            {
                Status_name = addStatusDto.Status_name,
                Str_time = addStatusDto.Str_time,
                End_time = addStatusDto.End_time
            };
            dbContext.Statuses.Add(Statuses);
            dbContext.SaveChanges();
            return Ok(Statuses);
        }



                          //Update  METHOD


        [HttpPut]
        [Route("{Status_ID:int}")]
        public IActionResult UpdateStatus(int Status_ID, UpdateStatus updateStatus)
        {
            var Statuses = dbContext.Statuses.Find(Status_ID);
            if (Statuses is null)
            {
                return NotFound();
            }


            Statuses.Status_name = updateStatus.Status_name;
            Statuses.Str_time = updateStatus.Str_time;
            Statuses.End_time = updateStatus.End_time;
            dbContext.SaveChanges();
            return Ok(Statuses);
        }

        //DELET METHOD
        [HttpDelete]
        [Route("{Status_ID:int}")]
        public IActionResult DeleteStatus(int Status_ID)
        {
            var Status = dbContext.Statuses.Find(Status_ID);
            if (Status is null)
            {
                return NotFound();
            }
            dbContext.Statuses.Remove(Status);
            dbContext.SaveChanges();
            return Ok(Status);
        }

    }
}

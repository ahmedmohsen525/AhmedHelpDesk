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

    public class TecnicalGropController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public TecnicalGropController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
                             //GET   METHOD 
        [HttpGet]
        public IActionResult GetAllTecnicalGrop()
        {
            var Technical = dbContext.Technicals.ToList();
            return Ok(Technical);
        }
                                //Get With ID ONlY
        [HttpGet]
        [Route("{Group_ID:int}")]
        public IActionResult GetTecnicalGropByGroup_ID(int Group_ID)
        {
            var Technical = dbContext.Technicals.Find(Group_ID);
            if (Technical is null)
            {
                return NotFound();
            }
            return Ok(Technical);

        }
                               //Add New Opject 

        [HttpPost]
        public IActionResult TecnicalGrop(AddTechnicalsDto addTechnicalsDto)
        {

            var Technical = new TecnicalGrop()
            {
                Group_name = addTechnicalsDto.Group_name
            };

            dbContext.Technicals.Add(Technical);
            dbContext.SaveChanges();

            return Ok(Technical);


        }
                           //Update  METHOD
        [HttpPut]
        [Route("{Group_ID:int}")]
        public IActionResult UpdateTecnicalGrop(int Group_ID, UpdateTecnicalGrop updateTecnical)
        {
            var Technical = dbContext.Technicals.Find(Group_ID);
            if(Technical is null)
            {
                return NotFound();
            }


            Technical.Group_name = updateTecnical.Group_name;
            dbContext.SaveChanges();
            return Ok(Technical);
        }

                         //DELET METHOD
        [HttpDelete]
        [Route("{Group_ID:int}")]
        public IActionResult DeleteTecnicalGrop(int Group_ID)
        {
            var Technical = dbContext.Technicals.Find(Group_ID);
            if (Technical is null)
            {
                return NotFound();
            }
            dbContext.Technicals.Remove(Technical);
            dbContext.SaveChanges();
            return Ok(Technical);
        }
        
    }

}
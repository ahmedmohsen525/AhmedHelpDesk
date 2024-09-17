using FRA.Data;
using FRA.Dto;
using FRA.Models;
using FRA.Update_Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using ServiceProvider = FRA.Models.ServiceProvider;

namespace FRA.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceProviderController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ServiceProviderController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllServiceProvider()
        {
            var AllServices = dbContext.Services.ToList();
            return Ok(AllServices);
        }
                              //Get With ID ONlY

        [HttpGet]
        [Route("{Agent_ID:int}")]
        public IActionResult GetServiceProviderByAgent_ID(int Agent_ID)
        {
            var Services = dbContext.Services.Find(Agent_ID);
            if (Services is null)
            {
                return NotFound();
            }
            return Ok(Services);

        }
                                 //Add New Opject 

        [HttpPost]
        public IActionResult ServiceProvider(AddServiceProviderDto addServiceProvider )
        {

            var AllServices = new ServiceProvider()
            {
                Name = addServiceProvider.Name,
                Email = addServiceProvider.Email,
                End_Time = addServiceProvider.End_Time,
            };
            

            dbContext.Services.Add(AllServices);
            dbContext.SaveChanges();

            return Ok(AllServices);


        }
                              //Update  METHOD
        [HttpPut] 
        [Route("{Agent_ID:int}")]
        public IActionResult UpdateServiceProvider(int Agent_ID, UpdateServiceProvider updateService )
        {
            var Services = dbContext.Services.Find(Agent_ID);
            if (Services is null)
            {
                return NotFound();
            }


            Services.Name = updateService.Name;
            Services.Email = updateService.Email;
            Services.End_Time = updateService.End_Time;
            dbContext.SaveChanges();
            return Ok(Services);
        }

                        //DELET METHOD
        [HttpDelete]
        [Route("{Agent_ID:int}")]
        public IActionResult DeleteServiceProvider(int Agent_ID)
        {
            var Services = dbContext.Services.Find(Agent_ID);
            if (Services is null)
            {
                return NotFound();
            }
            dbContext.Services.Remove(Services);
            dbContext.SaveChanges();
            return Ok(Services);
        }

    }

}


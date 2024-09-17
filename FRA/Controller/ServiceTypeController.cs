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
    public class ServiceTypeController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ServiceTypeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllTecnicalGrop()
        {
            var ServiceType = dbContext.Types.ToList();
            return Ok(ServiceType);
        }
                        //Get With ID ONlY
        [HttpGet]
        [Route("{Service_ID:int}")]
        public IActionResult GetTecnicalGropByService_ID(int Service_ID)
        {
            var ServiceType = dbContext.Types.Find(Service_ID);
            if (ServiceType is null)
            {
                return NotFound();
            }
            return Ok(ServiceType);

        }
                                //Add New Opject 
        [HttpPost]
        public IActionResult ServiceType(AddServiceTypeDto addServiceType )
        {

            var Types = new ServiceType()
            {
                Service_nam = addServiceType.Service_nam,
                Descr = addServiceType.Descr,
                Request_time = addServiceType.Request_time,
                Start_time = addServiceType.Start_time,
                prioity = addServiceType.prioity,
                Service_levels = addServiceType.Service_levels
            };

            dbContext.Types.Add(Types);
            dbContext.SaveChanges();

            return Ok(Types);


        }
                                  //Update  METHOD

        [HttpPut]
        [Route("{Service_ID:int}")]
        public IActionResult UpdateServiceType(int Service_ID, UpdateServiceType updateService )
        {
            var ServiceType = dbContext.Types.Find(Service_ID);
            if (ServiceType is null)
            {
                return NotFound();
            }


            ServiceType.Service_nam = updateService.Service_nam;
            ServiceType.Descr = updateService.Descr;
            ServiceType.Request_time = updateService.Request_time;
            ServiceType.Start_time = updateService.Start_time;
            ServiceType.prioity = updateService.prioity;
            ServiceType.Service_levels = updateService.Service_levels;
            dbContext.SaveChanges();
            return Ok(ServiceType);
        }

        //DELET METHOD
        [HttpDelete]
        [Route("{Service_ID:int}")]
        public IActionResult DeleteServiceType(int Service_ID)
        {
            var ServiceType = dbContext.Types.Find(Service_ID);
            if (ServiceType is null)
            {
                return NotFound();
            }
            dbContext.Types.Remove(ServiceType);
            dbContext.SaveChanges();
            return Ok(ServiceType);
        }
    }
}

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
    public class EvaluationController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EvaluationController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
                                        //Get With ID ONlY
        [HttpGet]

        public IActionResult GetAllTecnicalGrop()
        {
            var Evaluation = dbContext.Evaluations.ToList();
            return Ok(Evaluation);
        }

        [HttpGet]
        [Route("{Agent_ID:int}")]
        public IActionResult GetTecnicalGropByAgent_ID(int Agent_ID)
        {
            var Evaluation = dbContext.Evaluations.Find(Agent_ID);
            if (Evaluation is null)
            {
                return NotFound();
            }
            return Ok(Evaluation);

        }
                                   //Add New Opject 

        [HttpPost]
        public IActionResult Evaluation(AddEvaluationDto addEvaluation )
        {

            var Evaluations = new Evaluation()
            {
                Service_levels = addEvaluation.Service_levels,
                Start_time = addEvaluation.Start_time,
                End_time = addEvaluation.End_time
            };

            dbContext.Evaluations.Add(Evaluations);
            dbContext.SaveChanges();

            return Ok(Evaluations);


        }

                                      //Update  METHOD
        [HttpPut]
        [Route("{Agent_ID:int}")]
        public IActionResult UpdateEvaluation(int Agent_ID, UpdateEvaluation updateEvaluation )
        {
            var Evaluation = dbContext.Evaluations.Find(Agent_ID);
            if(Evaluation is null)
            {
                return NotFound();
            }


            Evaluation.Service_levels = updateEvaluation.Service_levels;
            Evaluation.Start_time = updateEvaluation.Start_time;
            Evaluation.End_time = updateEvaluation.End_time;
            dbContext.SaveChanges();
            return Ok(Evaluation);
        }

                                 //DELET METHOD
        [HttpDelete]
        [Route("{Agent_ID:int}")]
        public IActionResult DeleteTecnicalGrop(int Agent_ID)
        {
            var Evaluation = dbContext.Evaluations.Find(Agent_ID);
            if (Evaluation is null)
            {
                return NotFound();
            }
            dbContext.Evaluations.Remove(Evaluation);
            dbContext.SaveChanges();
            return Ok(Evaluation);
        }
    }
}

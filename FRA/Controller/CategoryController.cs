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
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


                            //GET   METHOD 



        [HttpGet]
        public IActionResult GetAllTecnicalGrop()
        {
            var Category = dbContext.Categoties.ToList();
            return Ok(Category);
        }


                              //Get With ID ONlY



        [HttpGet]
        [Route("{Cat_ID:int}")]
        public IActionResult GetTecnicalGropByCat_ID(int Cat_ID)
        {
            var Category = dbContext.Categoties.Find(Cat_ID);
            if (Category is null)
            {
                return NotFound();
            }
            return Ok(Category);

        }


                               //Add New Opject 

        [HttpPost]
        public IActionResult AddCategoryDto(AddCategoryDto addCategory )
        {

            var Categoties = new Category()
            {
                Cat_name = addCategory.Cat_name
            };

            dbContext.Categoties.Add(Categoties);
            dbContext.SaveChanges();

            return Ok(Categoties);


        }



                           //Update  METHOD

        [HttpPut]
        [Route("{Cat_ID:int}")]
        public IActionResult UpdateCategory(int Cat_ID, UpdateCategory updateCategory)
        {
            var Category = dbContext.Categoties.Find(Cat_ID);
            if (Category is null)
            {
                return NotFound();
            }


            Category.Cat_name = updateCategory.Cat_name;
            dbContext.SaveChanges();
            return Ok(Category);
        }




                         //DELET METHOD


        [HttpDelete]
        [Route("{GroCat_IDup_ID:int}")]
        public IActionResult DeleteTecnicalGrop(int Cat_ID)
        {
            var Category = dbContext.Categoties.Find(Cat_ID);
            if (Category is null)
            {
                return NotFound();
            }
            dbContext.Categoties.Remove(Category);
            dbContext.SaveChanges();
            return Ok(Category);
        }
    }
}

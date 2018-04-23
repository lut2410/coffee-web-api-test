using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OOS.Domain.CategoryFoods.Models;
using OOS.Presentation.ApplicationLogic.CategoryFoods;

namespace OOS.Presentation.WebAPIs.Controllers
{
    [Produces("application/json")]
    [Route("api/CategoryFood")]
    public class CategoryFoodController : Controller
    {
        private readonly ICategoryFoodsBusinessLogic _cfBusinessLogic;

        public CategoryFoodController(ICategoryFoodsBusinessLogic cfBusinessLogic)
        {
            _cfBusinessLogic = cfBusinessLogic;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = _cfBusinessLogic.GetCategoryFoods();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var result = _cfBusinessLogic.GetCategoryFood(id);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] CategoryFood cf)
        {
            var result = _cfBusinessLogic.CreateCategoryFood(cf);
            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]CategoryFood table)
        {
            var result = _cfBusinessLogic.EditCategoryFood(id, table);
            return Ok(result);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _cfBusinessLogic.DeleteCategoryFood(id);
            return Ok();
        }


    }
}
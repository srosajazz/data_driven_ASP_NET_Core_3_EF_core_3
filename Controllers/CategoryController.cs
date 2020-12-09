using System.Collections.Generic;
using System.Threading.Tasks;
using Backoffice.Models;
using Microsoft.AspNetCore.Mvc;



// EndPoint => URL
// http://localhost:5000
// https://localhost: 5001 

[Route("categories")]
public class CategoryController : ControllerBase 
{
  // GET
  [HttpGet]
  [Route("")]
  public async Task<ActionResult<List<Category>>> Get()
  {
    return new List<Category>();
  }

   // GETById
  [HttpGet]
  [Route("{id:int}")]
  public async Task<ActionResult<Category>> GetById(int id)
  {
    return new Category();
  }


  // POST
  [HttpPost]
  [Route("")]
  public async Task<ActionResult<List<Category>>> Post([FromBody] Category model)
  {
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }
    return Ok(model);
  }

  //PUT
  [HttpPut]
  [Route("{id:int}")]
  public async Task<ActionResult<Category>> Put(int id, [FromBody]Category model)
  {
     // todo: Check ID if i sthe same id from model
            if (id != model.Id)
                return NotFound(new { message = "Category not found" });

            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

    return Ok(model);
  }

  //DELETE
  [HttpDelete]
  [Route("{id:int}")]
  public  async Task<ActionResult<Category>> Delete()
  {
    return Ok();
  }
}

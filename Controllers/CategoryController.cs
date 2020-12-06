using System.Collections.Generic;
using System.Threading.Tasks;
using Backoffice.Models;
using Microsoft.AspNetCore.Mvc;


// EndPoint => URL
// http://localhost:5000
// https://localhost: 5001 - Azure

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
  public async Task<ActionResult<Category>> Post([FromBody] Category model)
  {
    return model;
  }

//PUT
  [HttpPut]
  [Route("{id:int}")]
  public  async Task<ActionResult<Category>> Put(int id, [FromBody]Category model)
  {
    if (model.Id == id)
    return Ok(model);

    return NotFound();
  }
//DELETE
  [HttpDelete]
  [Route("{id:int}")]
  public  async Task<ActionResult<Category>> Delete()
  {
    return Ok();
  }
}

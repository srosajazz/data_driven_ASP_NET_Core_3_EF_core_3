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
  public string Get()
  {
    return "GET";
  }

   // GETById
  [HttpGet]
  [Route("{id:int}")]
  public string GetById(int id)
  {
    return "GET" + id.ToString();
  }


// POST
  [HttpPost]
  [Route("")]
  public Category Post([FromBody] Category model)
  {
    return model;
  }

//PUT
  [HttpPut]
  [Route("")]
  public string Put()
  {s
    return "PUT";
  }
//DELETE
  [HttpDelete]
  [Route("")]
  public string Delete()
  {
    return "DELETE";
  }
}

using Microsoft.AspNetCore.Mvc;


// EndPoint => URL
// http://localhost:5000
// https://localhost: 5001 - Azure

[Route("categories")]
public class CategoryController : ControllerBase 
{
  // https://localhost:5001/categories
  [Route("")]
  public string MyMethod()
  {
    return "Hello World!";
  }


}

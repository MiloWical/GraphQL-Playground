using BakeryDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BakeryDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DonutLookupController : ControllerBase
{
  private DonutRepository _donutRepository;

  public DonutLookupController(DonutRepository donutRepository)
  {
    _donutRepository = donutRepository ?? throw new ArgumentNullException(nameof(donutRepository));
  }

  [HttpGet("id/{id}")]
  public IActionResult GetDonutById(int id)
  {
    var donuts = _donutRepository.GetDonuts();

    if(id > donuts.Count()) return NotFound($"Cannot find a donut at index '{id}'");

    return Ok(donuts.ElementAt(id - 1));
  }

  [HttpGet]
  [Route("")]
  [Route("{count?}")]
  public IActionResult GetDonuts(int? count = null)
  {
    var donuts = _donutRepository.GetDonuts();

    if(count == null) return Ok(donuts);

    return Ok(donuts.Take(count.Value));
  }
}
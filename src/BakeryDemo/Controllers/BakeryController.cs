using BakeryDemo.Repository;
using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;

public class BakeryController : GraphController
{
  private DonutRepository _donutRepository;

  public BakeryController(DonutRepository donutRepository)
  {
    _donutRepository = donutRepository ?? throw new ArgumentNullException(nameof(donutRepository));
  }

  [QueryRoot("donut")]
  public DonutModel RetrieveDonut(int? id)
  {
     var donuts = _donutRepository.GetDonuts();

    // if(id > donuts.Count()) return NotFound($"Cannot find a donut at index '{id}'");

    return donuts.ElementAt(id.Value - 1);
  }

  [QueryRoot("donuts")]
  public IEnumerable<DonutModel> GetDonuts(int? count)
  {
    var donuts = _donutRepository.GetDonuts();

    if(count == null) return donuts;

    return donuts.Take(count.Value);
  }
}
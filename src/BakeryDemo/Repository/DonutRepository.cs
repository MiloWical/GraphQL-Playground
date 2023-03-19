namespace BakeryDemo.Repository;

public class DonutRepository
{
  private static IEnumerable<DonutModel> _donutRepository = new DonutModel[] {
      new DonutModel {
        Id = 1,
        Name = "Mudslide",
        Flavor = "Chocolate"
      },
      new DonutModel {
        Id = 2,
        Name = "Party Time!",
        Flavor = "Birthday Cake"
      },
      new DonutModel {
        Id = 3,
        Name = "Snowy Dream",
        Flavor = "Vanilla"
      }
    };

  public IEnumerable<DonutModel> GetDonuts()
  {
    return _donutRepository;
  }
}
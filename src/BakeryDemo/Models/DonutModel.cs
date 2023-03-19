using GraphQL.AspNet.Attributes;

[GraphType("Donut")]
public class DonutModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Flavor { get; set; }
}
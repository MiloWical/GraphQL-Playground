# GraphQL-Playground

## Bakery Demo

This demo is based off of the [Your First App documentation](https://graphql-aspnet.github.io/docs/quick/create-app) for [GraphQL ASP.NET](https://graphql-aspnet.github.io/). Instead of a single record being returned, the following data structures are set up using a repository for interaction by the various endpoints:

```c#
IEnumerable<DonutModel> _donutRepository = new DonutModel[] {
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
```

### BakeryDemo - GraphQL

Run the application and then run the following command from a shell: `curl 'http://localhost:5018/graphql' -H 'Accept-Encoding: gzip, deflate, br' -H 'Content-Type: application/json' -H 'Accept: application/json' -H 'Connection: keep-alive' -H 'DNT: 1' -H 'Origin: file://' --data-binary '{"query":"query { donut(id: 3) { id name flavor }}"}'`

Your response should look like this:
```json
{
  "data": {
    "donut": {
      "id": 3,
      "name": "Snowy Dream",
      "flavor": "Vanilla"
    }
  }
}
```

Alternatively, you can use a tool like [GraphQL Playground](https://github.com/graphql/graphql-playground) and have it interact with [`http://localhost:5018/graphql`](http://localhost:5018/graphql).

### BakeryDemo - REST

This set of REST endpoints basically provides the same functionality in a REST-style request format. All you need to do is run the application and go to [`http://localhost:5018/swagger`](http://localhost:5018/swagger) to interact with the various endpoints.
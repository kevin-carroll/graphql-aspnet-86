# graphql-aspnet-86
A sample project relating to [issue 86](https://github.com/graphql-aspnet/graphql-aspnet/issues/86) on graphql-aspnet.

This project features a very simple implementation with one "weather" controller. Launch the project (either the .NET 6 or .NET Core 3.1 version) and using your favorite tool execute this query:

EndPoint:  `http://localhost:5000/graphql`

```graphql
query {
  weatherForecast {
    weather {
      date
      temperatureF
      summary
    }
  }
}
```

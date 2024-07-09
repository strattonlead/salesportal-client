# SalesPortal API

Welcome to the Sales Portal API

# Usage with Dependency Injection

## Add services to your service provider. Usually you do this in your Program.cs
```
var services = new ServiceCollection();
services.AddSalesPortalClient(options => options
    .UseApiKey("your api key"));
var serviceProvider = services.BuildServiceProvider();
```

## Optionally you can specify another host
```
var services = new ServiceCollection();
services.AddSalesPortalClient(options => options
    .UseBaseUrl("https://yourhost:12345/")
    .UseAllowedHosts("yourhost")
    .UseApiKey("your api key"));
var serviceProvider = services.BuildServiceProvider();
```

## It is time to make your first call
```
var clientProvider = serviceProvider.GetRequiredService<SalesPortalClientProvider>();
var client = clientProvider.Client;
var getResponse = await client.Product.GetProduct.PostAsync(new GetProductRequest() { Id = 1 });
```

## Expand nested properties

You can expand 4 levels deep. 

```
var getResponse = await client.Product.GetProduct.PostAsync(new GetProductRequest() { Id = 1, Expand = new List<string> { "ProductGroup.SalesGroup", "Sales" } });
```
    
# Generate or update your own client

kiota generate -l CSharp -c SalesPortalClient -n SalesPortal.Client -d https://api.sales.createif-labs.de/swagger/v1/swagger.json -o ./SalesPortal.Client
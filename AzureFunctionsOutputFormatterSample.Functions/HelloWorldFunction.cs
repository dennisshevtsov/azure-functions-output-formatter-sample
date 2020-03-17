// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// See License.txt in the project root for license information.

namespace AzureFunctionsOutputFormatterSample.Functions
{
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.Azure.WebJobs;
  using Microsoft.Azure.WebJobs.Extensions.Http;
  using Microsoft.AspNetCore.Http;

  public static class HelloWorldFunction
  {
    [FunctionName(nameof(HelloWorldFunction.RunHellowWorld))]
    public static IActionResult RunHellowWorld(
      [HttpTrigger(AuthorizationLevel.Function, "get", Route = "hello-world")] HttpRequest req)
      => new OkObjectResult("Formatter does not work.");
  }
}

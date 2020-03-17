// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// See License.txt in the project root for license information.

namespace AzureFunctionsOutputFormatterSample.Formatters.HelloWorld
{
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.Extensions.Options;

  internal sealed class HelloWorldOutputFormattersSetup : IConfigureOptions<MvcOptions>
  {
    public void Configure(MvcOptions options)
    {
      options.OutputFormatters.Clear();
      options.OutputFormatters.Add(new HelloWorldFormatter());
    }
  }
}

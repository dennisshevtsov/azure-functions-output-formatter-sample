// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// See License.txt in the project root for license information.

namespace AzureFunctionsOutputFormatterSample.Formatters.HelloWorld
{
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.AspNetCore.Mvc.Infrastructure;
  using Microsoft.Extensions.DependencyInjection;
  using Microsoft.Extensions.DependencyInjection.Extensions;
  using Microsoft.Extensions.Options;

  public static class ServicesExtensions
  {
    public static IServiceCollection AddHelloWorldOutputFormatter(this IServiceCollection services)
    {
      services.TryAddEnumerable(
        ServiceDescriptor.Transient<IConfigureOptions<MvcOptions>, HelloWorldOutputFormattersSetup>());

      services.TryAddSingleton<IHttpResponseStreamWriterFactory, MemoryPoolHttpResponseStreamWriterFactory>();
      services.TryAddSingleton<OutputFormatterSelector, DefaultOutputFormatterSelector>();
      services.TryAddSingleton<IActionResultExecutor<ObjectResult>, ObjectResultExecutor>();

      return services;
    }
  }
}

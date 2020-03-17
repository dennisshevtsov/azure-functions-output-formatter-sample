// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// See License.txt in the project root for license information.

namespace AzureFunctionsOutputFormatterSample.Formatters.HelloWorld
{
  using System.Net.Mime;
  using System.Text;
  using System.Threading.Tasks;

  using Microsoft.AspNetCore.Mvc.Formatters;
  using Microsoft.Net.Http.Headers;

  internal sealed class HelloWorldFormatter : TextOutputFormatter
  {
    public HelloWorldFormatter()
    {
      SupportedEncodings.Add(Encoding.UTF8);
      SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse(MediaTypeNames.Application.Json).CopyAsReadOnly());
    }

    public async override Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
      => await context.HttpContext.Response.Body.WriteAsync(Encoding.UTF8.GetBytes("{ \"message\": \"Hello World!\" }"));
  }
}

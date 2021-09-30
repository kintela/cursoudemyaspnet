using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Back_End.Filtros
{
  public class FiltroDeExcepcion:ExceptionFilterAttribute
  {
    private readonly ILogger<FieldAccessException> logger;

    public FiltroDeExcepcion(ILogger<FieldAccessException> logger)
    {
      this.logger = logger;
    }

    public override void OnException(ExceptionContext context)
    {
      logger.LogError(context.Exception, context.Exception.Message);
      base.OnException(context);
    }
  }
}

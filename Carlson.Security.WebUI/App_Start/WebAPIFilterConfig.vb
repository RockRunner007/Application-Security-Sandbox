Imports System.Web.Http
Imports Carlson.Security.WebUI.Filters.Mvc

Public Class WebApiFilterConfig
  Public Shared Sub Register(configuration As HttpConfiguration)
    configuration.Filters.Add(New ExceptionFilterAttribute()) 'Global Error Handling
    configuration.Filters.Add(New AntiXssFilterAttribute()) 'Custom Business Logic Filter
    'configuration.Filters.Add(New LoggingFilterAttribute()) 'Logging Filter
  End Sub
End Class
Imports Microsoft.Ajax.Utilities
Imports Newtonsoft.Json
Imports NLog

Namespace Filters.Mvc
  Public Class LoggingFilterAttribute
    Inherits ActionFilterAttribute
    Public Overrides Sub OnResultExecuting(filterContext As ResultExecutingContext)
      Dim logger = LogManager.GetCurrentClassLogger()
      Dim messageToLog = "{filterContext.HttpContext.Request.HttpMethod} Request to URL: {filterContext.HttpContext.Request.Url}" & vbCr & vbLf & "Request Data: {GetRequestParameters(filterContext)}"

      logger.Trace(messageToLog)

      MyBase.OnResultExecuting(filterContext)
    End Sub

    Public Overrides Sub OnActionExecuted(filterContext As ActionExecutedContext)
      MyBase.OnActionExecuted(filterContext)
    End Sub

    Private Function GetRequestParameters(filterContext As ResultExecutingContext) As String
      Dim argumentKeys = filterContext.HttpContext.Request.Params.Keys
      Dim content = New StringBuilder()

      For Each key As Var In argumentKeys
        content.AppendLine(JsonConvert.SerializeObject(filterContext.HttpContext.Request.Params.[Get](key.ToString())))
      Next

      Return content.ToString()
    End Function
  End Class
End Namespace
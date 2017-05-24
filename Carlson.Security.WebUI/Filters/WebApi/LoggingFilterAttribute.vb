Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web.Http.Controllers
Imports System.Web.Http.Filters
Imports Newtonsoft.Json
Imports NLog

Namespace Filters.WebApi
  Public Class LoggingFilterAttribute
    Inherits ActionFilterAttribute
    ''' <summary>
    ''' Runs before the controller action starts processing
    ''' </summary>        
    Public Overrides Sub OnActionExecuting(actionContext As HttpActionContext)
      Dim logger = LogManager.GetLogger("database")
      Dim messageToLog = "{actionContext.Request.Method} Request to URL: {actionContext.Request.RequestUri}" & vbCr & vbLf & "Request Data: {GetRequestParameters(actionContext)}"

      logger.Trace(messageToLog)
    End Sub

    ''' <summary>
    ''' Runs after the controller action finishes processing and is ready to send back a response
    ''' </summary>        
    Public Overrides Async Function OnActionExecutedAsync(actionExecutedContext As HttpActionExecutedContext, cancellationToken As CancellationToken) As Task
      If actionExecutedContext.Exception Is Nothing Then
        Dim response = String.Empty

        If actionExecutedContext.Response IsNot Nothing AndAlso actionExecutedContext.Response.Content IsNot Nothing Then
          response = Await actionExecutedContext.Response.Content.ReadAsStringAsync()
        End If

        Dim messageToLog = "{actionExecutedContext.Request.Method} Response from URL: {actionExecutedContext.Request.RequestUri}" & vbCr & vbLf & "Response Code: {(actionExecutedContext.Response != null ? actionExecutedContext.Response.StatusCode : HttpStatusCode.InternalServerError)}," & vbCr & vbLf & "Response Data: {(string.IsNullOrWhiteSpace(response) == false && response.Length > 500 ? response.Substring(0, 500) : response)}"

        Dim logger = LogManager.GetCurrentClassLogger()
        logger.Trace(messageToLog)
      End If

      Await MyBase.OnActionExecutedAsync(actionExecutedContext, cancellationToken)
    End Function

    Private Function GetRequestParameters(actionContext As HttpActionContext) As String
      Dim argumentKeys = actionContext.ActionArguments.Keys
      Dim content = New StringBuilder()

      For Each key In argumentKeys
        content.AppendLine(JsonConvert.SerializeObject(actionContext.ActionArguments(key)))
      Next

      Return content.ToString()
    End Function
  End Class
End Namespace
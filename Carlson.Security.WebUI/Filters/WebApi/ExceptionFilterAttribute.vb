Imports System.Net
Imports System.Net.Http
Imports System.Web.Http.Filters
Imports NLog

Public Class ExceptionFilterAttribute
  Inherits System.Web.Http.Filters.ExceptionFilterAttribute
  Public Overrides Sub OnException(actionExecutedContext As HttpActionExecutedContext)
    Dim logger = LogManager.GetCurrentClassLogger()
    logger.[Error](actionExecutedContext.Exception)

    If TypeOf actionExecutedContext.Exception Is SiteException Then
      actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, actionExecutedContext.Exception.Message)
    Else
      actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "We're Sorry.  An unexpected error has occurred.  If this continues please contact Tech Support.")
    End If
  End Sub
End Class
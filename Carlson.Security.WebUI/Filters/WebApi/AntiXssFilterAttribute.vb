Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web.Http.Controllers
Imports System.Web.Http.Filters
Imports System.Web.Security.AntiXss
Imports Microsoft.Ajax.Utilities
Imports Microsoft.Security.Application

Public Class AntiXssFilterAttribute
  Inherits ActionFilterAttribute
  ''' <summary>
  ''' This method will fire before the controller method is executed
  ''' </summary>        
  Public Overrides Function OnActionExecutingAsync(actionContext As HttpActionContext, cancellationToken As CancellationToken) As Task
    Dim actionArgumentsKeys = actionContext.ActionArguments.Keys

    For Each key In actionArgumentsKeys
      Dim data = actionContext.ActionArguments(key)
      Dim type = data.[GetType]()

      CheckAllStrings(data, type)

      actionContext.ActionArguments(key) = data
    Next

    Return MyBase.OnActionExecutingAsync(actionContext, cancellationToken)
  End Function

  Private Sub CheckAllStrings(data As Object, dataType As Type)
    If dataType = GetType(String) Then
      Dim tempData = Web.Security.AntiXss.AntiXssEncoder.HtmlEncode(data.ToString(), False)

      If String.Equals(tempData, data.ToString(), StringComparison.OrdinalIgnoreCase) = False Then
        Throw New SiteException("You attempted to pass in some XSS, none shall pass!")
      End If
    ElseIf dataType.IsClass Then
      Dim properties = dataType.GetProperties()

      For Each [property] In properties
        Dim dataToConvert = [property].GetValue(data, Nothing)

        CheckAllStrings(dataToConvert, [property].PropertyType)

        [property].SetValue(data, dataToConvert, Nothing)
      Next
    End If
  End Sub
End Class
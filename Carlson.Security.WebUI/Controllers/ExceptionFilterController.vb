Imports System.Web.Http

Public Class ExceptionFilterController
  Inherits ApiController
  <HttpGet>
  Public Function GetIdList() As List(Of Integer)
    Dim valueToAdd = Integer.Parse("Test")

    Return New List(Of Integer)() From {
      valueToAdd
    }
  End Function
End Class
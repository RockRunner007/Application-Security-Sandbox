Public Class FilterController
  Inherits Controller
  Public Function GlobalExceptionHandling() As ActionResult
    ViewBag.Title = "Global Exception Handling - WebApi"
    Return View()
  End Function

  Public Function ActionFilter() As ActionResult
    ViewBag.Title = "Action Filter - WebApi"
    Return View()
  End Function
End Class
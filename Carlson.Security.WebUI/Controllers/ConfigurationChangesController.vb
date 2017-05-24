Public Class ConfigurationChangesController
  Inherits Controller
  ' GET: 
  Public Function ContentSecurityPolicy() As ActionResult
    ViewBag.Title = "Content Security Policy"
    Return View()
  End Function

  Public Function CookiePolicies() As ActionResult
    ViewBag.Title = "Cookie Policies"
    Return View()
  End Function

  Public Function AntiXSSEncoder() As ActionResult
    ViewBag.Title = "Anti XSS Encoder"
    Return View()
  End Function
End Class
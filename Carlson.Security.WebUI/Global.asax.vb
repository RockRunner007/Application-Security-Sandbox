Imports System.Web.Http
Imports System.Web.Optimization
Imports System.Web.Security
Imports System.Web.SessionState

Public Class MvcApplication
  Inherits HttpApplication

  Protected Sub Application_Start()
    AreaRegistration.RegisterAllAreas()
    GlobalConfiguration.Configure(AddressOf Register)
    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
    RouteConfig.RegisterRoutes(RouteTable.Routes)
    BundleConfig.RegisterBundles(BundleTable.Bundles)
    WebApiFilterConfig.Register(GlobalConfiguration.Configuration)
  End Sub
  Sub Application_BeginRequest(sender As Object, e As EventArgs)
    With Response
      .Buffer = True
      .Expires = -1
      .ExpiresAbsolute = DateTime.Now.AddDays(-1)
      .AddHeader("pragma", "no-cache")
      .AddHeader("cache-control", "no-cache, no-store")
      .AddHeader("X-UA-Compatible", "IE=edge;")
      .CacheControl = "no-cache"
      .Cache.SetCacheability(HttpCacheability.NoCache)
      .Cache.SetNoStore()
      .Cache.SetNoServerCaching()
      .Headers.Remove("Server")
      .Headers.Remove("X-AspNet-Version")
      .Headers.Remove("X-AspNetMvc-Version")
      .Headers.Remove("X-Powered-By")
    End With
  End Sub
  Sub Application_EndRequest(sender As [Object], e As EventArgs)
    Dim authCookie As String = FormsAuthentication.FormsCookieName
    For Each sCookie As String In Response.Cookies
      If sCookie = authCookie OrElse sCookie = "ASP.NET_SessionId" Then
        Response.Cookies(sCookie).Path += ";HttpOnly"
      End If
      If UCase(Left(ConfigurationManager.AppSettings("RootPath"), 5)) = "HTTPS" Then Response.Cookies(sCookie).Secure = True
    Next
  End Sub
End Class
Imports System.Web.Optimization

Public Module BundleConfig
  Public Sub RegisterBundles(ByVal bundles As BundleCollection)
    bundles.Add(New ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js", "~/Scripts/jquery.cookie.js"))
    bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"))

    bundles.Add(New ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"))
    bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"))

    bundles.Add(New StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"))
  End Sub
End Module
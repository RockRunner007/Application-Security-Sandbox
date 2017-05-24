@Code
  ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
  <h1>Carlson.Security</h1>
  <p class="lead">Carlson.Security is a test project for security vulnerabilities.</p>
</div>

<div class="row">
  <div class="col-md-4">
    <h2>Content Security Policy</h2>
    <p>Content security policy allows you to only allow certain sources (JavaScript, Images, etc) to load. It is a good first line of defense against XSS</p>
    @*<p>@Html.ActionLink("Learn More", "ContentSecurityPolicy", "ConfigurationChanges", New {}, New {@class = "btn btn-default"})</p>*@
  </div>
  <div class="col-md-4">
    <h2>Anti XSS Encoder</h2>
    <p>The Anti XSS Encoder prevents XSS from reaching the user.  This is another line of defense against XSS</p>
    @*<p>@Html.ActionLink("Learn More", "AntiXSSEncoder", "ConfigurationChanges", New { }, New { @class = "btn btn-default" })</p>*@
  </div>
  <div class="col-md-4">
    <h2>Cookie Policies</h2>
    <p>Cookie Policies allow you to only allow cookies to be accessed via http requests and through SSL. This is another line of defense against XSS</p>
    @*<p>@Html.ActionLink("Learn More", "CookiePolicies", "ConfigurationChanges", New {}, New {@class = "btn btn-default"})</p>*@
  </div>
</div>
<div class="row">
  <div class="col-md-4">
    <h2>Global Exception Handling</h2>
    <p>It is never a good idea to expose any details about an exception to users.</p>
    @*<p>@Html.ActionLink("Learn More", "GlobalExceptionHandling", "Filter", New {}, New { @class = "btn btn-default" })</p>*@
  </div>
  <div class="col-md-4">
    <h2>Action Filters</h2>
    <p>Action filters allow you to write custom business rules to help protect your website</p>
    @*<p>@Html.ActionLink("Learn More", "ActionFilter", "Filter", New { }, New { @class = "btn btn-default" })</p>*@
  </div>
</div>

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.LoginStatus
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
    using Telerik.Sitefinity.Mvc.Proxy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginButton.cshtml")]
    public partial class LoginStatus_LoginButton : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginButton()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
  
    var SignOutUrl = string.Concat(Url.Action("SignOut"), string.Format("?{0}={1}", MvcControllerProxy.ControllerKey, ViewData[MvcControllerProxy.ControllerKey]));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 400), Tuple.Create("\"", 423)
            
            #line 11 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 408), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 408), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"media\"");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"media-left pr-2\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"media-object\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" data-sf-role=\"sf-logged-in-avatar\"");

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"media-body\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 773), Tuple.Create("\"", 810)
            
            #line 19 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 780), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 780), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral("></a>\r\n            <p");

WriteLiteral(" data-sf-role=\"sf-logged-in-email\"");

WriteLiteral("></p>\r\n            <a");

WriteLiteral(" class=\"btn btn-secondary\"");

WriteAttribute("href", Tuple.Create(" href=\"", 946), Tuple.Create("\"", 964)
            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 953), Tuple.Create<System.Object, System.Int32>(SignOutUrl
            
            #line default
            #line hidden
, 953), false)
);

WriteLiteral(">");

            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                       Write(Html.Resource("Logout"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n\r\n        <button");

WriteLiteral(" class=\"btn btn-secondary\"");

WriteLiteral(" data-sf-role=\"login-status-button\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                                                      Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1230), Tuple.Create("\"", 1272)
            
            #line 28 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 1237), false)
);

WriteLiteral(">");

            
            #line 28 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
                                                 Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\r\n    </div>\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1396), Tuple.Create("\"", 1427)
            
            #line 33 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1404), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 1404), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1490), Tuple.Create("\"", 1518)
            
            #line 34 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1498), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 1498), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-login-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1580), Tuple.Create("\"", 1607)
            
            #line 35 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 1588), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1672), Tuple.Create("\"", 1712)
            
            #line 36 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1680), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-allow-windows-sts-login\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1780), Tuple.Create("\"", 1826)
            
            #line 37 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
, Tuple.Create(Tuple.Create("", 1788), Tuple.Create<System.Object, System.Int32>(Model.AllowWindowsStsLogin.ToString()
            
            #line default
            #line hidden
, 1788), false)
);

WriteLiteral(" />\r\n\r\n");

            
            #line 39 "..\..MVC\Views\LoginStatus\LoginStatus.LoginButton.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.UnsubscribeForm
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
    
    #line 3 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/UnsubscribeForm/UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml")]
    public partial class UnsubscribeFormByEmailAddress_UnsubscribeForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.EmailCampaigns.Mvc.Models.UnsubscribeForm.UnsubscribeFormViewModel>
    {
        public UnsubscribeFormByEmailAddress_UnsubscribeForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 9 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 11 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 13 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
  
	var hasValidationMessage = Html.ValidationMessageFor(u => u.Email) != null;
	var attributes = new Dictionary<string, object>()
	{
		{ "class", "form-control" },
		{ "type", "email" },
		{ "aria-required", "true" }
	};

	if (hasValidationMessage)
	{
		attributes.Add("aria-describedby", Html.UniqueId("UnsubscribeFormInfo") + " " + Html.UniqueId("UnsubscribeFormValidatonInfo"));
	}
	else
	{
		attributes.Add("aria-describedby", Html.UniqueId("UnsubscribeFormInfo"));
	}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1049), Tuple.Create("\"", 1072)
            
            #line 32 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 1057), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1057), false)
);

WriteLiteral(">    \r\n");

            
            #line 33 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
	
            
            #line default
            #line hidden
            
            #line 33 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
     using (Html.BeginFormSitefinity("Unsubscribe", "UnsubscribeForm"))
	{	

            
            #line default
            #line hidden
WriteLiteral("\t\t<h3>");

            
            #line 35 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
       Write(Model.WidgetTitle);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 36 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		

            
            #line default
            #line hidden
WriteLiteral("\t\t<p");

WriteLiteral(" class=\"text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1213), Tuple.Create("\'", 1255)
            
            #line 37 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 1218), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("UnsubscribeFormInfo")
            
            #line default
            #line hidden
, 1218), false)
);

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t");

            
            #line 38 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
       Write(Model.WidgetDescription);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t</p>\r\n");

            
            #line 40 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		
		if (ViewBag.IsSucceded == true)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 44 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(Html.HtmlSanitize(Model.Message));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n");

            
            #line 46 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		}
		
		
            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                     		
		if (!string.IsNullOrEmpty(ViewBag.Error))
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 52 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</div>\r\n");

            
            #line 54 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
		}
		

            
            #line default
            #line hidden
WriteLiteral("\t\t<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t");

            
            #line 57 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
       Write(Html.LabelFor(u => u.Email, Html.Resource("Email")));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\t\t\t<div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 60 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
           Write(Html.TextBoxFor(u => u.Email, attributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t<button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary ml-2\"");

WriteLiteral(" ");

            
            #line 61 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                                               Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 61 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                                                                                              Write(Html.Resource("ButtonUnsubscribe"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n\t\t\t</div>\r\n\r\n");

            
            #line 64 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
			
            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
             if (Html.ValidationMessageFor(u => u.Email) != null)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<div");

WriteAttribute("id", Tuple.Create(" id=\'", 2068), Tuple.Create("\'", 2119)
            
            #line 66 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 2073), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("UnsubscribeFormValidatonInfo")
            
            #line default
            #line hidden
, 2073), false)
);

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"form-text\"");

WriteLiteral(">");

            
            #line 67 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
                                       Write(Html.ValidationMessageFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t</div>\r\n");

            
            #line 69 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n");

            
            #line 71 "..\..MVC\Views\UnsubscribeForm\UnsubscribeFormByEmailAddress.UnsubscribeForm.cshtml"
	}

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591

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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Comments
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
    
    #line 3 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Comments/CommentsCount.Default.cshtml")]
    public partial class CommentsCount_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsCountViewModel>
    {
        public CommentsCount_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" data-sf-role=\"comments-count-wrapper\"");

WriteLiteral(" data-sf-thread-key=\"");

            
            #line 8 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
                                                          Write(Model.ThreadKey);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"sf-Comment-count\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" data-sf-role=\"comments-count-anchor\"");

WriteAttribute("href", Tuple.Create(" href=\"", 372), Tuple.Create("\"", 397)
            
            #line 9 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 379), Tuple.Create<System.Object, System.Int32>(Model.NavigateUrl
            
            #line default
            #line hidden
, 379), false)
);

WriteLiteral(">\r\n        <svg");

WriteLiteral(" class=\"sf-icon-comment sf-icon-xs\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n            <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 486), Tuple.Create("\"", 570)
, Tuple.Create(Tuple.Create("", 499), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#comment-alt")
, 499), false)
);

WriteLiteral("></use>\r\n        </svg>\r\n        <span");

WriteLiteral(" data-sf-role=\"comments-count-anchor-text\"");

WriteLiteral("></span>\r\n    </a>\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"service-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 724), Tuple.Create("\"", 751)
            
            #line 16 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 732), Tuple.Create<System.Object, System.Int32>(ViewBag.ServiceUrl
            
            #line default
            #line hidden
, 732), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-count-resources\"");

WriteAttribute("value", Tuple.Create(" value=\'", 821), Tuple.Create("\'", 972)
, Tuple.Create(Tuple.Create("", 829), Tuple.Create("{\"commentsPlural\":", 829), true)
, Tuple.Create(Tuple.Create(" ", 847), Tuple.Create("\"", 848), true)
            
            #line 17 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
             , Tuple.Create(Tuple.Create("", 849), Tuple.Create<System.Object, System.Int32>(Html.Resource("CommentsPlural")
            
            #line default
            #line hidden
, 849), false)
, Tuple.Create(Tuple.Create("", 881), Tuple.Create("\",", 881), true)
, Tuple.Create(Tuple.Create(" ", 883), Tuple.Create("\"leaveComment\":\"", 884), true)
            
            #line 17 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 900), Tuple.Create<System.Object, System.Int32>(Html.Resource("LeaveComment")
            
            #line default
            #line hidden
, 900), false)
, Tuple.Create(Tuple.Create("", 930), Tuple.Create("\",", 930), true)
, Tuple.Create(Tuple.Create(" ", 932), Tuple.Create("\"comment\":\"", 933), true)
            
            #line 17 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
                                                                                                            , Tuple.Create(Tuple.Create("", 944), Tuple.Create<System.Object, System.Int32>(Html.Resource("Comment")
            
            #line default
            #line hidden
, 944), false)
, Tuple.Create(Tuple.Create("", 969), Tuple.Create("\"", 969), true)
, Tuple.Create(Tuple.Create(" ", 970), Tuple.Create("}", 971), true)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

            
            #line 20 "..\..MVC\Views\Comments\CommentsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-count.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591

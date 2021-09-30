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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Event
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Event/List.EventsList.cshtml")]
    public partial class List_EventsList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_EventsList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 265), Tuple.Create("\"", 288)
            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
, Tuple.Create(Tuple.Create("", 273), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 273), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
         foreach (var item in Model.Items)
        {
            var navigateUrl = HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);


            
            #line default
            #line hidden
WriteLiteral("            <li ");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
           Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"sf-event-title\"");

WriteLiteral(">\r\n                    <a ");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                  Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                                                                                 Write(navigateUrl);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                                                                                               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </h3>\r\n                <span");

WriteLiteral(" data-calendar-color=\"");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                                      Write(item.EventCalendarColour());

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></span>\r\n                <p");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                    ");

WriteLiteral("\r\n                    <time>");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                     Write(item.EventDates());

            
            #line default
            #line hidden
WriteLiteral("</time>");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                                                    if (!string.IsNullOrEmpty(item.Fields.City)){
            
            #line default
            #line hidden
WriteLiteral("<span>, ");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                                                                                                    Write(item.Fields.City);

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                                                                                                                                 }

            
            #line default
            #line hidden
WriteLiteral("                </p>\r\n                <p ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
              Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                                                                        Write(Html.HtmlSanitize((string)item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <div");

WriteLiteral(" class=\"sf-Comment-count--block\"");

WriteLiteral(">");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
                                                Write(Html.CommentsCount((string)navigateUrl, item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </li>\r\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n\r\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
        {
            currentPage = Model.CurrentPage,
            totalPagesCount = Model.TotalPagesCount.Value,
            redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
        }));

            
            #line default
            #line hidden
            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Event\List.EventsList.cshtml"
          
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591

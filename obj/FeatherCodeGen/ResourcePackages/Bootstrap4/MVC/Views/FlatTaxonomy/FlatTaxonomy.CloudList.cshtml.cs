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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.FlatTaxonomy
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/FlatTaxonomy/FlatTaxonomy.CloudList.cshtml")]
    public partial class FlatTaxonomy_CloudList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public FlatTaxonomy_CloudList()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 81), Tuple.Create("\"", 126)
            
            #line 3 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
, Tuple.Create(Tuple.Create("", 89), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 89), false)
, Tuple.Create(Tuple.Create(" ", 104), Tuple.Create("sf-Tags", 105), true)
, Tuple.Create(Tuple.Create(" ", 112), Tuple.Create("list-unstyled", 113), true)
);

WriteLiteral(">\r\n");

            
            #line 4 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
     foreach (var taxa in Model.Taxa)
    {
        var cloudSizeClass = "sf-Tags-size" + @taxa.CloudSize;
    
        
            
            #line default
            #line hidden
WriteLiteral("<li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 274), Tuple.Create("\"", 290)
            
            #line 9 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
, Tuple.Create(Tuple.Create("", 281), Tuple.Create<System.Object, System.Int32>(taxa.Url
            
            #line default
            #line hidden
, 281), false)
);

WriteAttribute("class", Tuple.Create(" class=\"", 291), Tuple.Create("\"", 314)
            
            #line 9 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
, Tuple.Create(Tuple.Create("", 299), Tuple.Create<System.Object, System.Int32>(cloudSizeClass
            
            #line default
            #line hidden
, 299), false)
);

WriteLiteral(">");

            
            #line 9 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                                                   Write(taxa.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <span");

WriteLiteral(" class=\"small text-muted\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                
            
            #line default
            #line hidden
            
            #line 11 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                 if (Model.ShowItemCount)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("(");

            
            #line 13 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                  Write(taxa.Count);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 14 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </span>\r\n        </li>\r\n");

            
            #line 17 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.CloudList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>");

        }
    }
}
#pragma warning restore 1591

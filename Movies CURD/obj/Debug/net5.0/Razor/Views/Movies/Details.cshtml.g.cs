#pragma checksum "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e134c6ddcbfe3ac9bb3de62d94cec8bd96d21f58fed2ce7f80811e1121c1eb15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\MVC\Movies CURD\Movies CURD\Views\_ViewImports.cshtml"
using Movies_CURD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MVC\Movies CURD\Movies CURD\Views\_ViewImports.cshtml"
using Movies_CURD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MVC\Movies CURD\Movies CURD\Views\_ViewImports.cshtml"
using Movies_CURD.NewFolder;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e134c6ddcbfe3ac9bb3de62d94cec8bd96d21f58fed2ce7f80811e1121c1eb15", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f4ced0ec30cf9187d05d592b7395331d35b8ee974861dd59aa5c1d3d734d7b75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml"
     
        
        ViewData["Title"] = Model.Title;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row justify-content-between mt-60-px\">\r\n        <div class=\"col-md-3\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 187, "\"", 252, 2);
            WriteAttributeValue("", 193, "data:image/*;base64,", 193, 20, true);
#nullable restore
#line 9 "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml"
WriteAttributeValue("", 213, Convert.ToBase64String(Model.Poster), 213, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 275, "\"", 293, 1);
#nullable restore
#line 9 "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml"
WriteAttributeValue("", 281, Model.Title, 281, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-md-7\">\r\n            <div class=\"d-flex justify-content-between mb-3\">\r\n                <h3>");
#nullable restore
#line 13 "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <span class=\"mt-2\">\r\n                    <i class=\"bi bi-star-fill text-warning\"></i>\r\n                    <span class=\"text-muted\">");
#nullable restore
#line 16 "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml"
                                        Write(Model.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </span>\r\n            </div>\r\n            <span class=\"text-muted mr-3\">\r\n                <i class=\"bi bi-calendar-week\"></i>\r\n                ");
#nullable restore
#line 21 "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml"
           Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <span class=\"text-muted\">\r\n                <i class=\"bi bi-film\"></i>\r\n                ");
#nullable restore
#line 25 "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml"
           Write(Model.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </span>\r\n            <p class=\"text-justify mt-3\">");
#nullable restore
#line 27 "D:\MVC\Movies CURD\Movies CURD\Views\Movies\Details.cshtml"
                                    Write(Model.Storeline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n   \r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d15e52c67132111277768f3b83ee801210478c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllCategories), @"mvc.1.0.view", @"/Views/Home/AllCategories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AllCategories.cshtml", typeof(AspNetCore.Views_Home_AllCategories))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\_ViewImports.cshtml"
using SkateShop;

#line default
#line hidden
#line 2 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\_ViewImports.cshtml"
using SkateShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d15e52c67132111277768f3b83ee801210478c", @"/Views/Home/AllCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d42a0c97c6b4447364b739898739f6777ee360d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Header", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllCategories.cshtml"
  
    ViewData["Title"] = "All Products";

#line default
#line hidden
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(46, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37d15e52c67132111277768f3b83ee801210478c3651", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(70, 78, true);
            WriteLiteral("</partial>\n\n<h3 class=\"text-center\">All Categories</h3>\n\n<div class=\"row\">\n\n\n\n");
            EndContext();
#line 13 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllCategories.cshtml"
   foreach (Category cat in ViewBag.AllCats)
{


#line default
#line hidden
            BeginContext(196, 190, true);
            WriteLiteral("     <div class=\"col-lg-4 col-md-6 mb-4\">\n            <div class=\"card h-100\">\n            \n              <div class=\"card-body\">\n                <h4 class=\"card-title\">\n                  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 386, "\"", 418, 2);
            WriteAttributeValue("", 393, "/category/", 393, 10, true);
#line 21 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllCategories.cshtml"
WriteAttributeValue("", 403, cat.CategoryId, 403, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(419, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(421, 8, false);
#line 21 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllCategories.cshtml"
                                                 Write(cat.Name);

#line default
#line hidden
            EndContext();
            BeginContext(429, 115, true);
            WriteLiteral("</a>\n                </h4>\n                \n              </div>\n             \n            </div>\n          </div>\n");
            EndContext();
#line 28 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllCategories.cshtml"

  
}

#line default
#line hidden
            BeginContext(550, 9, true);
            WriteLiteral("\n\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

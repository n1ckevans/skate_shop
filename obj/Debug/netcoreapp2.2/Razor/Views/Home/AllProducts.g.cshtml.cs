#pragma checksum "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58a8547919318c7ac0b362964ddb4a810019315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllProducts), @"mvc.1.0.view", @"/Views/Home/AllProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AllProducts.cshtml", typeof(AspNetCore.Views_Home_AllProducts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58a8547919318c7ac0b362964ddb4a810019315", @"/Views/Home/AllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d42a0c97c6b4447364b739898739f6777ee360d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
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
#line 1 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllProducts.cshtml"
  
    ViewData["Title"] = "All Products";

#line default
#line hidden
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(46, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f58a8547919318c7ac0b362964ddb4a8100193153635", async() => {
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
            BeginContext(70, 79, true);
            WriteLiteral("</partial>\n\n<h3 class=\"text-center mb-2\">All Products</h3>\n\n<div class=\"row\">\n\n");
            EndContext();
            BeginContext(164, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 13 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllProducts.cshtml"
   foreach (Product prod in ViewBag.AllProds)
{


#line default
#line hidden
            BeginContext(214, 283, true);
            WriteLiteral(@"     <div class=""col-lg-4 col-md-6 mb-4"">
            <div class=""card h-100"">
              <!-- <a href=""#""><img class=""card-img-top"" src=""~/img/polar.jpeg"" alt=""Polar Deck""></a> -->
              <div class=""card-body"">
                <h4 class=""card-title"">
                  <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 497, "\"", 528, 2);
            WriteAttributeValue("", 504, "/product/", 504, 9, true);
#line 21 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllProducts.cshtml"
WriteAttributeValue("", 513, prod.ProductId, 513, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(529, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(531, 9, false);
#line 21 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllProducts.cshtml"
                                                Write(prod.Name);

#line default
#line hidden
            EndContext();
            BeginContext(540, 48, true);
            WriteLiteral("</a>\n                </h4>\n                <h5>$");
            EndContext();
            BeginContext(589, 10, false);
#line 23 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllProducts.cshtml"
                Write(prod.Price);

#line default
#line hidden
            EndContext();
            BeginContext(599, 223, true);
            WriteLiteral("</h5>\n                <p class=\"card-text\"></p>\n              </div>\n              <div class=\"card-footer\">\n               \n                  \n                 \n                \n                  <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 822, "\"", 853, 2);
            WriteAttributeValue("", 829, "/addcart/", 829, 9, true);
#line 31 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllProducts.cshtml"
WriteAttributeValue("", 838, prod.ProductId, 838, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(854, 110, true);
            WriteLiteral(">Add to Cart</a>\n                  \n               \n\n              </div>\n            </div>\n          </div>\n");
            EndContext();
#line 38 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\AllProducts.cshtml"

  
}

#line default
#line hidden
            BeginContext(970, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591

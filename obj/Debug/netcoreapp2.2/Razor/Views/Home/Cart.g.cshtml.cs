#pragma checksum "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d8b708c79f436c77d1f7efc76b8c0245045ea6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Cart.cshtml", typeof(AspNetCore.Views_Home_Cart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8b708c79f436c77d1f7efc76b8c0245045ea6d", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d42a0c97c6b4447364b739898739f6777ee360d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
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
#line 1 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "Nick's Skate Shop";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("  \n ");
            EndContext();
            BeginContext(54, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9d8b708c79f436c77d1f7efc76b8c0245045ea6d3585", async() => {
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
            BeginContext(78, 12, true);
            WriteLiteral("</partial>\n\n");
            EndContext();
            BeginContext(103, 257, true);
            WriteLiteral(@"

<table class=""table table-striped table-hover"">
    <thead>
        <tr>
            <th class=""fixed"">Item</th>
            <th class=""fixed"">Quantity</th>
            <th class=""fixed"">Price</th>
        </tr>
    </thead>
    <tbody>
         
       
");
            EndContext();
#line 21 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\Cart.cshtml"
              foreach (Order prod in ViewBag.Items)
            {
            

#line default
#line hidden
            BeginContext(439, 61, true);
            WriteLiteral("              <tr>\n                  <td class=\"text-left\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 500, "\"", 531, 2);
            WriteAttributeValue("", 507, "/product/", 507, 9, true);
#line 25 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\Cart.cshtml"
WriteAttributeValue("", 516, prod.ProductId, 516, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(532, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(534, 19, false);
#line 25 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\Cart.cshtml"
                                                                      Write(prod.ProdOrder.Name);

#line default
#line hidden
            EndContext();
            BeginContext(553, 49, true);
            WriteLiteral("<a></td>\n                  <td class=\"text-left\">");
            EndContext();
            BeginContext(603, 13, false);
#line 26 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\Cart.cshtml"
                                   Write(prod.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(616, 47, true);
            WriteLiteral("</td>\n                  <td class=\"text-left\">$");
            EndContext();
            BeginContext(664, 20, false);
#line 27 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\Cart.cshtml"
                                    Write(prod.ProdOrder.Price);

#line default
#line hidden
            EndContext();
            BeginContext(684, 154, true);
            WriteLiteral("</td>\n                  <td class=\"text-left\">\n\n                 \n                    \n                    \n                    </td>\n              </tr>\n");
            EndContext();
#line 35 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Home\Cart.cshtml"
            



            

}

#line default
#line hidden
            BeginContext(870, 182, true);
            WriteLiteral("</tbody>\n</table>\n\n<a class=\"btn btn-success d-i-block mx-2\" href=\"/cart/checkout\">Checkout</a>\n\n<a class=\"btn btn-primary d-i-block mx-2\" href=\"/allprod\">Continue Shopping</a>\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591

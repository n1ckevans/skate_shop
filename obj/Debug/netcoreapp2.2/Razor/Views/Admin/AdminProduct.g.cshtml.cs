#pragma checksum "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f98195f4e5dc2dbac71301f7621144df3589232"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminProduct), @"mvc.1.0.view", @"/Views/Admin/AdminProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/AdminProduct.cshtml", typeof(AspNetCore.Views_Admin_AdminProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f98195f4e5dc2dbac71301f7621144df3589232", @"/Views/Admin/AdminProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d42a0c97c6b4447364b739898739f6777ee360d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Association>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AdminHeader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProdCat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
  
    ViewData["Title"] = "Admin Product";

#line default
#line hidden
            BeginContext(65, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(66, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f98195f4e5dc2dbac71301f7621144df35892325893", async() => {
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
            BeginContext(95, 43, true);
            WriteLiteral("</partial>\n\n\n\n<h1 class=\"text-center my-2\">");
            EndContext();
            BeginContext(139, 24, false);
#line 10 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                        Write(ViewBag.CurrentProd.Name);

#line default
#line hidden
            EndContext();
            BeginContext(163, 35, true);
            WriteLiteral("</h1>\n\n<p class=\"text-center my-2\">");
            EndContext();
            BeginContext(199, 31, false);
#line 12 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                       Write(ViewBag.CurrentProd.Description);

#line default
#line hidden
            EndContext();
            BeginContext(230, 36, true);
            WriteLiteral("</p>\n\n<h3 class=\"text-center my-2\">$");
            EndContext();
            BeginContext(267, 25, false);
#line 14 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                         Write(ViewBag.CurrentProd.Price);

#line default
#line hidden
            EndContext();
            BeginContext(292, 203, true);
            WriteLiteral("</h3>\n\n<h3>Categories</h3>\n\n\n\n<div class=\"text-center\">\n      \n      <div class=\"container mt-5\">\n    <div class=\"row\">\n        <div class=\"col-md\">\n            \n                <ul class=\"list-group\">\n\n");
            EndContext();
#line 28 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                  foreach (Category cat in ViewBag.ShowCats)
                {

#line default
#line hidden
            BeginContext(574, 46, true);
            WriteLiteral("                  <li class=\"list-group-item\">");
            EndContext();
            BeginContext(621, 8, false);
#line 30 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                                         Write(cat.Name);

#line default
#line hidden
            EndContext();
            BeginContext(629, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 31 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                  
                }

#line default
#line hidden
            BeginContext(672, 90, true);
            WriteLiteral("\n             </ul>\n\n        </div>\n        <div class=\"col-md\">\n            \n            ");
            EndContext();
            BeginContext(762, 799, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f98195f4e5dc2dbac71301f7621144df35892329609", async() => {
                BeginContext(815, 57, true);
                WriteLiteral("\n\n              <div class=\"form-group\">\n                ");
                EndContext();
                BeginContext(872, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f98195f4e5dc2dbac71301f7621144df358923210049", async() => {
                    BeginContext(900, 10, true);
                    WriteLiteral("Categories");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 42 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(918, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(935, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f98195f4e5dc2dbac71301f7621144df358923211807", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 43 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1017, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(1034, 277, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f98195f4e5dc2dbac71301f7621144df358923213591", async() => {
                    BeginContext(1063, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 45 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                     foreach (Category cat in ViewBag.AddCats)
                    {
                    

#line default
#line hidden
                    BeginContext(1170, 22, true);
                    WriteLiteral("                      ");
                    EndContext();
                    BeginContext(1192, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f98195f4e5dc2dbac71301f7621144df358923214368", async() => {
                        BeginContext(1225, 8, false);
#line 48 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                                                 Write(cat.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 48 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                         WriteLiteral(cat.CategoryId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1242, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 49 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                      
                    }

#line default
#line hidden
                    BeginContext(1288, 14, true);
                    WriteLiteral("              ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 44 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1311, 15, true);
                WriteLiteral("\n              ");
                EndContext();
                BeginContext(1326, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f98195f4e5dc2dbac71301f7621144df358923218147", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 52 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
#line 52 "C:\Users\nicho\Documents\Coding\C#\SkateShop\Views\Admin\AdminProduct.cshtml"
                                                  WriteLiteral(ViewBag.CurrentProd.ProductId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1406, 148, true);
                WriteLiteral("\n              </div>\n              \n             \n              \n              <button class=\"btn btn-info\" type=\"submit\">Add</button>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1561, 46, true);
            WriteLiteral("\n            \n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Association> Html { get; private set; }
    }
}
#pragma warning restore 1591
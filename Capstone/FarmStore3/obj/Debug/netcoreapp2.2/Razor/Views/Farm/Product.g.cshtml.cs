#pragma checksum "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "584e759e6cabc4903451b3d4a640f792c35fe722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Farm_Product), @"mvc.1.0.view", @"/Views/Farm/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Farm/Product.cshtml", typeof(AspNetCore.Views_Farm_Product))]
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
#line 1 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\_ViewImports.cshtml"
using FarmStore3;

#line default
#line hidden
#line 2 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\_ViewImports.cshtml"
using FarmStore3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"584e759e6cabc4903451b3d4a640f792c35fe722", @"/Views/Farm/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f421d127ef7feaf1a0eb4af9289f2ddeb7fcb19", @"/Views/_ViewImports.cshtml")]
    public class Views_Farm_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FarmStore3.Models.Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
            BeginContext(80, 87, true);
            WriteLiteral("\r\n<h1>Product</h1>\r\n\r\n<div>\r\n    <h4>Products</h4>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(168, 47, false);
#line 12 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml"
   Write(Html.DisplayNameFor(model => model.ProduceName));

#line default
#line hidden
            EndContext();
            BeginContext(215, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(265, 43, false);
#line 15 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml"
   Write(Html.DisplayFor(model => model.ProduceName));

#line default
#line hidden
            EndContext();
            BeginContext(308, 48, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(357, 45, false);
#line 18 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml"
   Write(Html.DisplayNameFor(model => model.ProduceID));

#line default
#line hidden
            EndContext();
            BeginContext(402, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(452, 41, false);
#line 21 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml"
   Write(Html.DisplayFor(model => model.ProduceID));

#line default
#line hidden
            EndContext();
            BeginContext(493, 48, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(542, 49, false);
#line 24 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml"
   Write(Html.DisplayNameFor(model => model.StockQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(591, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(641, 45, false);
#line 27 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml"
   Write(Html.DisplayFor(model => model.StockQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(686, 32, true);
            WriteLiteral("\r\n    </dd>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(719, 68, false);
#line 31 "C:\Users\rasha\source\repos\Capstone\Capstone\FarmStore3\Views\Farm\Product.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(787, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(795, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "584e759e6cabc4903451b3d4a640f792c35fe7226704", async() => {
                BeginContext(817, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(833, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FarmStore3.Models.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591

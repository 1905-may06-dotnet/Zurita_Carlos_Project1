#pragma checksum "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc503677eb647756d30bdf9ee5acf7672f3dd62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_PizzasPreview), @"mvc.1.0.view", @"/Views/Location/PizzasPreview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/PizzasPreview.cshtml", typeof(AspNetCore.Views_Location_PizzasPreview))]
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
#line 1 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc503677eb647756d30bdf9ee5acf7672f3dd62", @"/Views/Location/PizzasPreview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_PizzasPreview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.Pizza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
  
    ViewData["Title"] = "PizzasPreview";
    int nump = 1;
    ViewBag.Title = "Index";
    //var OPID = ViewBag.OPID;
    var ppid = ViewBag.ppid;

#line default
#line hidden
            BeginContext(200, 30, true);
            WriteLiteral("\r\n<h1>PizzasPreview</h1>\r\n<h2>");
            EndContext();
            BeginContext(231, 4, false);
#line 12 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
Write(ppid);

#line default
#line hidden
            EndContext();
            BeginContext(235, 16, true);
            WriteLiteral("</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(251, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfc503677eb647756d30bdf9ee5acf7672f3dd624239", async() => {
                BeginContext(274, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(288, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(381, 40, false);
#line 20 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.Nump));

#line default
#line hidden
            EndContext();
            BeginContext(421, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(477, 43, false);
#line 23 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.Pizzaid));

#line default
#line hidden
            EndContext();
            BeginContext(520, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(576, 40, false);
#line 26 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(616, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(672, 41, false);
#line 29 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(713, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(769, 40, false);
#line 32 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(809, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(865, 44, false);
#line 35 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.Porderid));

#line default
#line hidden
            EndContext();
            BeginContext(909, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(965, 45, false);
#line 38 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN1));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1066, 45, false);
#line 41 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN2));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1167, 45, false);
#line 44 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN3));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1268, 45, false);
#line 47 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN4));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1369, 45, false);
#line 50 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayNameFor(model => model.ToppingN5));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 56 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1532, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1581, 39, false);
#line 59 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nump));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1676, 42, false);
#line 62 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pizzaid));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1774, 39, false);
#line 65 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1813, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1869, 40, false);
#line 68 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(1909, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1965, 39, false);
#line 71 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(2004, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2060, 43, false);
#line 74 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.Porderid));

#line default
#line hidden
            EndContext();
            BeginContext(2103, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2159, 44, false);
#line 77 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN1));

#line default
#line hidden
            EndContext();
            BeginContext(2203, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2259, 44, false);
#line 80 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN2));

#line default
#line hidden
            EndContext();
            BeginContext(2303, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2359, 44, false);
#line 83 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN3));

#line default
#line hidden
            EndContext();
            BeginContext(2403, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2459, 44, false);
#line 86 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN4));

#line default
#line hidden
            EndContext();
            BeginContext(2503, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2559, 44, false);
#line 89 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToppingN5));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2659, 65, false);
#line 92 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2724, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2745, 71, false);
#line 93 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2816, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2837, 69, false);
#line 94 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2906, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 97 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPreview.cshtml"
}

#line default
#line hidden
            BeginContext(2945, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38a741d4cadf4f2766e50e5f88affb40b13835ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_ToppingsPage), @"mvc.1.0.view", @"/Views/Location/ToppingsPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/ToppingsPage.cshtml", typeof(AspNetCore.Views_Location_ToppingsPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38a741d4cadf4f2766e50e5f88affb40b13835ef", @"/Views/Location/ToppingsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_ToppingsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.Topping>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTopping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PizzasPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
  
    ViewData["Title"] = "ToppingsPage";
    int numt = 1;
    ViewBag.Title = "Index";
    var PTID = ViewBag.PTID;
    var PTIDOrder = ViewBag.PTIDOrder;
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
            BeginContext(257, 32, true);
            WriteLiteral("\r\n<h1>Toppings</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(289, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38a741d4cadf4f2766e50e5f88affb40b13835ef4586", async() => {
                BeginContext(339, 12, true);
                WriteLiteral("Add Toppings");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
                                    WriteLiteral(PTID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 40, false);
#line 21 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Numt));

#line default
#line hidden
            EndContext();
            BeginContext(488, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(718, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(753, 44, false);
#line 30 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(797, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
         foreach (var item in Model)
        {
            if (item.Tpizzaid == PTID)
            {

#line default
#line hidden
            BeginContext(987, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1060, 4, false);
#line 42 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
                   Write(numt);

#line default
#line hidden
            EndContext();
            BeginContext(1064, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
                          numt++;

#line default
#line hidden
            BeginContext(1102, 27, true);
            WriteLiteral("                    </td>\r\n");
            EndContext();
            BeginContext(1384, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1435, 43, false);
#line 52 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
            BeginContext(1969, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 62 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2045, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2071, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38a741d4cadf4f2766e50e5f88affb40b13835ef9974", async() => {
                BeginContext(2124, 14, true);
                WriteLiteral("Back To Pizzas");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-opid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\ToppingsPage.cshtml"
                              WriteLiteral(PTIDOrder);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-opid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2142, 14, true);
            WriteLiteral("<br><br><br>\r\n");
            EndContext();
            BeginContext(2156, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38a741d4cadf4f2766e50e5f88affb40b13835ef12318", async() => {
                BeginContext(2178, 17, true);
                WriteLiteral("Back To Locations");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.Topping>> Html { get; private set; }
    }
}
#pragma warning restore 1591
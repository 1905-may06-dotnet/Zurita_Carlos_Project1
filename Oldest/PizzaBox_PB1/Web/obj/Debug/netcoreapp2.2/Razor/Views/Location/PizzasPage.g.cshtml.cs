#pragma checksum "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf1f5eabb676e36340cdb66cbd57cbaa0d10fd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_PizzasPage), @"mvc.1.0.view", @"/Views/Location/PizzasPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/PizzasPage.cshtml", typeof(AspNetCore.Views_Location_PizzasPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf1f5eabb676e36340cdb66cbd57cbaa0d10fd7", @"/Views/Location/PizzasPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_PizzasPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.Pizza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToppingsPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTopping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrdersPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
  
    ViewData["Title"] = "PizzasPage";
    int nump = 1;
    ViewBag.Title = "Index";
    var OPID = ViewBag.OPID;
    var PTID = ViewBag.PTIDUser;
    var PTIDName = ViewBag.PTIDName;
    Layout = "~/Views/Shared/_Layout1.cshtml";
    int totalordercost1 = 0;

#line default
#line hidden
            BeginContext(315, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(322, 8, false);
#line 14 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
Write(PTIDName);

#line default
#line hidden
            EndContext();
            BeginContext(330, 19, true);
            WriteLiteral(" Pizzas</h1>\r\n<p>\r\n");
            EndContext();
            BeginContext(418, 90, true);
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(509, 40, false);
#line 22 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Nump));

#line default
#line hidden
            EndContext();
            BeginContext(549, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(673, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(708, 40, false);
#line 28 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(748, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(804, 41, false);
#line 31 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(845, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(901, 40, false);
#line 34 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(941, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(1029, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(1064, 44, false);
#line 40 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Porderid));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
         foreach (var item in Model)
        {
            if (item.Porderid == OPID)
            {

#line default
#line hidden
            BeginContext(1298, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1359, 4, false);
#line 52 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
               Write(nump);

#line default
#line hidden
            EndContext();
            BeginContext(1363, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
                      nump++;

#line default
#line hidden
            BeginContext(1397, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
            BeginContext(1534, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1577, 39, false);
#line 59 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1684, 40, false);
#line 62 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1792, 39, false);
#line 65 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
                      
                        totalordercost1 = +item.Cost; 
                        

#line default
#line hidden
            BeginContext(1940, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
            BeginContext(2055, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2098, 43, false);
#line 74 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
               Write(Html.DisplayFor(modelItem => item.Porderid));

#line default
#line hidden
            EndContext();
            BeginContext(2141, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(2353, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2373, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faf1f5eabb676e36340cdb66cbd57cbaa0d10fd710739", async() => {
                BeginContext(2431, 8, true);
                WriteLiteral("Toppings");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ptid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
                                                    WriteLiteral(item.Pizzaid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ptid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ptid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ptid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2443, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2467, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faf1f5eabb676e36340cdb66cbd57cbaa0d10fd713110", async() => {
                BeginContext(2525, 12, true);
                WriteLiteral("Add Toppings");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
                                                    WriteLiteral(item.Pizzaid);

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
            BeginContext(2541, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2833, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 86 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2901, 46, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<h4>Total Order Cost: ");
            EndContext();
            BeginContext(2948, 15, false);
#line 90 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
                 Write(totalordercost1);

#line default
#line hidden
            EndContext();
            BeginContext(2963, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(2970, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faf1f5eabb676e36340cdb66cbd57cbaa0d10fd716233", async() => {
                BeginContext(3018, 19, true);
                WriteLiteral("Back To Orders List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-uoid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 91 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\PizzasPage.cshtml"
                              WriteLiteral(PTID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["uoid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-uoid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["uoid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591

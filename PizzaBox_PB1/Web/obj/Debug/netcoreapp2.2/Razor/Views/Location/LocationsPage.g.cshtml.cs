#pragma checksum "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77eee61b7d52fbd58851daacbe33fdee367e16aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_LocationsPage), @"mvc.1.0.view", @"/Views/Location/LocationsPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/LocationsPage.cshtml", typeof(AspNetCore.Views_Location_LocationsPage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77eee61b7d52fbd58851daacbe33fdee367e16aa", @"/Views/Location/LocationsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_LocationsPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.Models.Location>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserSignedIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
  
    ViewData["Title"] = "LocationsPage";
    int num = 1;
    var LPID = ViewBag.LPID;

#line default
#line hidden
            BeginContext(140, 24, true);
            WriteLiteral("\r\n<h1>Locations</h1>\r\n\r\n");
            EndContext();
            BeginContext(222, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(307, 39, false);
#line 18 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Num));

#line default
#line hidden
            EndContext();
            BeginContext(346, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(473, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(508, 43, false);
#line 24 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Street1));

#line default
#line hidden
            EndContext();
            BeginContext(551, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(607, 43, false);
#line 27 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Street2));

#line default
#line hidden
            EndContext();
            BeginContext(650, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(706, 40, false);
#line 30 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(746, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(802, 41, false);
#line 33 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(843, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(899, 43, false);
#line 36 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(942, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(998, 43, false);
#line 39 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayNameFor(model => model.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 45 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1159, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1208, 3, false);
#line 48 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(1211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
                  num++;

#line default
#line hidden
            BeginContext(1240, 19, true);
            WriteLiteral("            </td>\r\n");
            EndContext();
            BeginContext(1364, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1399, 42, false);
#line 55 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street1));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1497, 42, false);
#line 58 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street2));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1595, 39, false);
#line 61 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1690, 40, false);
#line 64 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1786, 42, false);
#line 67 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1828, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1884, 42, false);
#line 70 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
           Write(Html.DisplayFor(modelItem => item.Zipcode));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(2319, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 79 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
}

#line default
#line hidden
            BeginContext(2356, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2382, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77eee61b7d52fbd58851daacbe33fdee367e16aa10937", async() => {
                BeginContext(2432, 24, true);
                WriteLiteral("Back To User Information");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-lsid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Revature\Homework\PizzaBox_PB1\Web\Views\Location\LocationsPage.cshtml"
                                WriteLiteral(LPID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lsid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-lsid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lsid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2460, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.Models.Location>> Html { get; private set; }
    }
}
#pragma warning restore 1591

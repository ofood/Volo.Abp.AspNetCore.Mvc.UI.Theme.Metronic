#pragma checksum "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d27635c76bac694e30f782c1cff18398bd4823d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Themes_Metronic_Components_Menu__MenuItem), @"mvc.1.0.view", @"/Themes/Metronic/Components/Menu/_MenuItem.cshtml")]
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
#nullable restore
#line 1 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
using Volo.Abp.UI.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d27635c76bac694e30f782c1cff18398bd4823d5", @"/Themes/Metronic/Components/Menu/_MenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4774f01943f02a49507315c0ef1cabe5607aa081", @"/Themes/Metronic/_ViewImports.cshtml")]
    public class Themes_Metronic_Components_Menu__MenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationMenuItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
  
    var elementId = string.IsNullOrEmpty(Model.ElementId) ? string.Empty : $"id=\"{Model.ElementId}\"";
    var cssClass = string.IsNullOrEmpty(Model.CssClass) ? string.Empty : Model.CssClass;
    var disabled = Model.IsDisabled ? "disabled" : string.Empty;
    var url = string.IsNullOrEmpty(Model.Url) ? "#" : Url.Content(Model.Url);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
 if (Model.IsLeaf)
{
    if (Model.Url != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("class", " class=\"", 462, "\"", 503, 3);
            WriteAttributeValue("", 470, "dropdown-item", 470, 13, true);
#nullable restore
#line 13 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
WriteAttributeValue(" ", 483, cssClass, 484, 9, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
WriteAttributeValue(" ", 493, disabled, 494, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 504, "\"", 515, 1);
#nullable restore
#line 13 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
WriteAttributeValue("", 511, url, 511, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 13 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
                                                            Write(Html.Raw(elementId));

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n");
#nullable restore
#line 14 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
             if (Model.Icon != null)
            {
                if (Model.Icon.StartsWith("fa"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i");
            BeginWriteAttribute("class", " class=\"", 679, "\"", 698, 1);
#nullable restore
#line 18 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
WriteAttributeValue("", 687, Model.Icon, 687, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n");
#nullable restore
#line 19 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 21 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
       Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </a>\n");
#nullable restore
#line 23 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
    }
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-submenu\">\n        <a role=\"button\" class=\"btn dropdown-toggle\" data-toggle=\"dropdown\"\n                aria-haspopup=\"true\" aria-expanded=\"false\">\n            <span class=\"lp-icon\">\n                <i");
            BeginWriteAttribute("class", " class=\"", 1020, "\"", 1047, 1);
#nullable restore
#line 31 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
WriteAttributeValue("", 1028, Model.Icon ?? "", 1028, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n            </span>\n            <span class=\"lp-text\">\n                ");
#nullable restore
#line 34 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </span>\n        </a>\n        <div class=\"dropdown-menu border-0 shadow-sm\">\n");
#nullable restore
#line 38 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
             foreach (var childMenuItem in Model.Items)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
           Write(await Html.PartialAsync("~/Themes/Metronic/Components/Menu/_MenuItem.cshtml", childMenuItem));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
                                                                                                             
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div> \n");
#nullable restore
#line 44 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Menu\_MenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationMenuItem> Html { get; private set; }
    }
}
#pragma warning restore 1591

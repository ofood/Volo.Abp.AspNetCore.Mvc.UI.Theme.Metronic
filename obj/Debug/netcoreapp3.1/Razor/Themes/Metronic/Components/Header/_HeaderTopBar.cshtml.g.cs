#pragma checksum "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Header\_HeaderTopBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e989cfd5380d99d4969dab2aa9db3fe306776ad8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Themes_Metronic_Components_Header__HeaderTopBar), @"mvc.1.0.view", @"/Themes/Metronic/Components/Header/_HeaderTopBar.cshtml")]
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
#line 1 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Header\_HeaderTopBar.cshtml"
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic.Themes.Metronic.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e989cfd5380d99d4969dab2aa9db3fe306776ad8", @"/Themes/Metronic/Components/Header/_HeaderTopBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4774f01943f02a49507315c0ef1cabe5607aa081", @"/Themes/Metronic/_ViewImports.cshtml")]
    public class Themes_Metronic_Components_Header__HeaderTopBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- begin:: Header Topbar -->\n<div class=\"kt-header__topbar\">\n\n    <!--begin: Search -->\n    ");
#nullable restore
#line 6 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Header\_HeaderTopBar.cshtml"
Write(await Component.InvokeAsync<MainHeaderSearchViewComponent>());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <!--end: Search -->\n    <!--begin: Notifications -->\n    ");
#nullable restore
#line 9 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Header\_HeaderTopBar.cshtml"
Write(await Component.InvokeAsync<MainHeaderNotificationsViewComponent>());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <!--end: Notifications -->\n    <!--begin: Quick Actions -->\n    ");
#nullable restore
#line 12 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Header\_HeaderTopBar.cshtml"
Write(await Component.InvokeAsync<MainHeaderActionsViewComponent>());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <!--end: Quick Actions -->
    <!--begin: Quick panel toggler -->
    <div class=""kt-header__topbar-item kt-header__topbar-item--quick-panel"" data-toggle=""kt-tooltip"" title=""Quick panel"" data-placement=""right"">
        <span class=""kt-header__topbar-icon"" id=""kt_quick_panel_toggler_btn"">
            <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""24px"" height=""24px"" viewBox=""0 0 24 24"" version=""1.1"" class=""kt-svg-icon"">
                <g stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd"">
                    <rect x=""0"" y=""0"" width=""24"" height=""24"" />
                    <rect fill=""#000000"" x=""4"" y=""4"" width=""7"" height=""7"" rx=""1.5"" />
                    <path d=""M5.5,13 L9.5,13 C10.3284271,13 11,13.6715729 11,14.5 L11,18.5 C11,19.3284271 10.3284271,20 9.5,20 L5.5,20 C4.67157288,20 4,19.3284271 4,18.5 L4,14.5 C4,13.6715729 4.67157288,13 5.5,13 Z M14.5,4 L18.5,4 C19.3284271,4 20,4.67157288 20,5.5 L20,9.5 C20,10.3284271 19.3284271,11 18.5,11 L14.5,11 ");
            WriteLiteral(@"C13.6715729,11 13,10.3284271 13,9.5 L13,5.5 C13,4.67157288 13.6715729,4 14.5,4 Z M14.5,13 L18.5,13 C19.3284271,13 20,13.6715729 20,14.5 L20,18.5 C20,19.3284271 19.3284271,20 18.5,20 L14.5,20 C13.6715729,20 13,19.3284271 13,18.5 L13,14.5 C13,13.6715729 13.6715729,13 14.5,13 Z"" fill=""#000000"" opacity=""0.3"" />
                </g>
            </svg>
        </span>
    </div>

    <!--end: Quick panel toggler -->
    <!--begin: Language bar -->
    ");
#nullable restore
#line 29 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Header\_HeaderTopBar.cshtml"
Write(await Component.InvokeAsync<LanguageSwitchViewComponent>());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <!--end: Language bar -->\n    <!--begin: User Bar -->\n    ");
#nullable restore
#line 32 "E:\abpdemo\abp-3.3.1\modules\ecology\themes\Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic\Themes\Metronic\Components\Header\_HeaderTopBar.cshtml"
Write(await Component.InvokeAsync<MainHeaderUserBarViewComponent>());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <!--end: User Bar -->\n</div>\n\n<!-- end:: Header Topbar -->");
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

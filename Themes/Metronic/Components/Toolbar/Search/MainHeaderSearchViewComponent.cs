using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic.Themes.Metronic.Components
{
    public class MainHeaderSearchViewComponent: AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Metronic/Components/Toolbar/Search/Default.cshtml");
        }
    }
}

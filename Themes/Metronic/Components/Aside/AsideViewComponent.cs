using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic.Themes.Metronic.Components
{
    public class AsideViewComponent: AbpViewComponent
    {
        private readonly IMenuManager _menuManager;

        public AsideViewComponent(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menu = await _menuManager.GetAsync(StandardMenus.Main);
            return View("~/Themes/Metronic/Components/Aside/Default.cshtml", menu);
        }
    }
}

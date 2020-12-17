using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Alerts;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic.Themes.Metronic.Components.PageAlerts
{
    public class PageAlertsViewComponent : AbpViewComponent
    {
        private readonly IAlertManager _alertManager;

        public PageAlertsViewComponent(IAlertManager alertManager)
        {
            _alertManager = alertManager;
        }

        public IViewComponentResult Invoke(string name)
        {
            return View("~/Themes/Metronic/Components/PageAlerts/Default.cshtml", _alertManager.Alerts);
        }
    }
}

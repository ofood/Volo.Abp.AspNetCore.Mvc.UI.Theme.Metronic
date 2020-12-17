using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic
{
    [ThemeName(Name)]
    public class MetronicTheme : ITheme, ITransientDependency
    {
        public const string Name = "Metronic";

        public virtual string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case StandardLayouts.Account:
                    return "~/Themes/Metronic/Layouts/Account.cshtml";
                case StandardLayouts.Empty:
                    return "~/Themes/Metronic/Layouts/Empty.cshtml";
                case MetronicStandardLayouts.Admin:
                    return "~/Themes/Metronic/Layouts/Admin.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/Metronic/Layouts/Admin.cshtml" : null;
            }
        }
    }
}

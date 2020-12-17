using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic.Bundling
{
    /// <summary>
    /// 全局样式贡献者
    /// </summary>
    public class MetronicThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Clear();
            context.Files.Add("/themes/metronic/plugins/global/plugins.bundle.css");
            context.Files.Add("/themes/metronic/css/style.bundle.css");
            context.Files.Add("/themes/metronic/css/skins/header/base/light.css");
            context.Files.Add("/themes/metronic/css/skins/header/menu/light.css");
            context.Files.Add("/themes/metronic/css/skins/brand/dark.css");
            context.Files.Add("/themes/metronic/css/skins/aside/dark.css");
        }
    }
}

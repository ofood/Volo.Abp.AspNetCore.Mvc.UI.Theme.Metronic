using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Metronic.Bundling
{
    /// <summary>
    /// 全局脚本贡献者
    /// </summary>
    public class MetronicThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Clear();
            context.Files.Add("/themes/metronic/plugins/global/plugins.bundle.js");
            context.Files.Add("/themes/metronic/js/scripts.bundle.js");
        }
    }
}
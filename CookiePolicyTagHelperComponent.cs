using Microsoft.AspNetCore.Razor.TagHelpers;
using Piranha.CookiePolicy.Models;

namespace Piranha.CookiePolicy
{
    public class CookiePolicyTagHelperComponent : TagHelperComponent
    {
        private readonly CookieBannerTag _banner;

        public CookiePolicyTagHelperComponent(CookieBannerTag banner)
        {
            _banner = banner;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.TagName == "body")
                output.PostContent.AppendHtml(_banner);
        }
    }
}

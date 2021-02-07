using Microsoft.AspNetCore.Mvc.Rendering;
using Piranha.CookiePolicy.ExtensionsMethods;

namespace Piranha.CookiePolicy.Models
{
    public class CookieBannerTag : TagBuilder
    {
        public CookieBannerTag(CookieBannerConfiguration configuration) : base("script")
        {
            Attributes.Add("type", "text/javascript");
            Attributes.Add("id", "cookieinfo");
            Attributes.Add("src", "//cookieinfoscript.com/js/cookieinfo.min.js");

            foreach (var property in configuration.GetType().GetProperties())
            {
                var key = property.Name.PascalToKebabCase();
                string value = property.GetValue(configuration, null) as string;

                if (!string.IsNullOrEmpty(value))
                    Attributes.Add(key, value);
            }
        }
    }
}

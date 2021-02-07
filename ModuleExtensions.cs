using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using Piranha.CookiePolicy.Models;
using System;

namespace Piranha.CookiePolicy
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddCookiePolicyModule(this IServiceCollection services, CookieBannerConfiguration configuration)
        {
            App.Modules.Register<Module>();
            services.AddSingleton<CookieBannerTag>(service => new CookieBannerTag(configuration));
            services.AddSingleton<ITagHelperComponent, CookiePolicyTagHelperComponent>();

            return services;
        }
    }
}

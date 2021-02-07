using Piranha.Extend;
using System;

namespace Piranha.CookiePolicy
{
    public class Module : IModule
    {
        public string Author => "Gasperi Patrizio";

        public string Name => "Piranha.CookiePolicy";

        public string Version => Piranha.Utils.GetAssemblyVersion(GetType().Assembly);

        public string Description => "Piranha Module for apply a cookie policy banner powered by https://cookieinfoscript.com/";

        public string PackageUrl => "";

        public string IconUrl => "";

        public void Init()
        {
            
        }
    }
}

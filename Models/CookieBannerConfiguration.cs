namespace Piranha.CookiePolicy.Models
{
    public class CookieBannerConfiguration
    {
        /// <summary>
        /// text size of the message and the link(default: 14px)
        /// </summary>
        public string DataFontSize { get; set; }

        /// <summary>
        /// font family of the message and the link(default: verdana, arial, sans-serif)
        /// </summary>
        public string DataFontFamily { get; set; }

        /// <summary>
        /// position of the text(default: center)
        /// </summary>
        public string DataTextAlign { get; set; }

        /// <summary>
        /// banner height(default: 31 pixels)
        /// </summary>
        public string DataHeight { get; set; }

        /// <summary>
        /// banner text color(default: #333)
        /// </summary>
        public string DataFg { get; set; }

        /// <summary>
        /// banner background color (default: #eee)
        /// </summary>
        public string DataBg { get; set; }

        /// <summary>
        /// link text color (default: #31A8F0)
        /// </summary>
        public string DataLink { get; set; }

        /// <summary>
        /// button text color (default: #000)
        /// </summary>
        public string DataDivlink { get; set; }

        /// <summary>
        /// button background color (default: #F1D600)
        /// </summary>
        public string DataDivlinkbg { get; set; }

        /// <summary>
        /// banner position, top or bottom (default: bottom)
        /// </summary>
        public string DataPosition { get; set; }

        /// <summary>
        /// message text(default: We use cookies to enhance your experience.By continuing to visit this site you agree to our use of cookies.)
        /// </summary>
        public string DataMessage { get; set; }

        /// <summary>
        /// link text(default: More info)
        /// </summary>
        public string DataLinkmsg { get; set; }

        /// <summary>
        /// where the visitor can read more about cookies(default: https://wikipedia.org/wiki/HTTP_cookie
        /// </summary>
        public string DataMoreinfo { get; set; }

        /// <summary>
        ///  the text/symbol for the close button (default: ✖)
        /// </summary>
        public string DataCloseText { get; set; }

        /// <summary>
        /// effect to use(default: null)
        /// </summary>
        public string DataEffect { get; set; }

        /// <summary>
        /// name for the cookie to store the cookiebanner acceptance information(default: we-love-cookies)
        /// </summary>
        public string DataCookie { get; set; }

        /// <summary>
        /// cookie expiry date/time(default is Infinity aka "Fri, 31 Dec 9999 23:59:59 GMT").
        /// </summary>
        public string DataExpires { get; set; }

        /// <summary>
        /// Path to set for the cookie
        /// </summary>
        public string DataCookiePath { get; set; }

        /// <summary>
        /// whether to create a mask over the viewport(default: false). Clicking anywhere on the mask is considered as acceptance.
        /// </summary>
        public string DataMask { get; set; }

        /// <summary>
        /// the opacity to use for the window mask(default: 0.5)
        /// </summary>
        public string DataMaskOpacity { get; set; }

        /// <summary>
        /// optional background style you wish to apply to the mask(default: #999)
        /// </summary>
        public string DataMaskBackground { get; set; }

        /// <summary>
        /// z-index to set on the notice (default: 255). If mask is used, the notice's z-index is automatically incremented by 1 so it appears above the mask)
        /// </summary>
        public string DataZindex { get; set; }

        /// <summary>
        ///  when is set true window scrolling is considered as acceptance. (default: false)
        /// </summary>
        public string DataAcceptOnScroll { get; set; }

        /// <summary>
        /// Tracking pixel(default: Off{get; set;} // To enable you will need to enter a (image) tracking url or script.Example:
        /// </summary>
        public string DataTracking { get; set; }
    }
}

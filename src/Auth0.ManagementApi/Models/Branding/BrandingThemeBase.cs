using Newtonsoft.Json;

namespace Auth0.ManagementApi.Models
{
    public class BrandingThemeBase
    {
        /// <summary>
        /// Display Name.
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Borders.
        /// </summary>
        [JsonProperty("borders")]
        public BrandingThemeBorders Borders { get; set; }

        /// <summary>
        /// Colors.
        /// </summary>
        [JsonProperty("colors")]
        public BrandingThemeColors Colors { get; set; }

        /// <summary>
        /// Fonts.
        /// </summary>
        [JsonProperty("fonts")]
        public BrandingThemeFonts Fonts { get; set; }

        /// <summary>
        /// Page Background.
        /// </summary>
        [JsonProperty("page_background")]
        public BrandingThemePageBackground PageBackground { get; set; }

        /// <summary>
        /// Widget.
        /// </summary>
        [JsonProperty("widget")]
        public BrandingThemeWidget Widget { get; set; }
    }
}

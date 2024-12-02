using Newtonsoft.Json;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Represents the Auth0 Tenant's branding theme settings
    /// </summary>
    public class BrandingTheme : BrandingThemeBase
    {
        /// <summary>
        /// Theme Id.
        /// </summary>
        [JsonProperty("themeId")]
        public string ThemeId { get; set; }
    }
}

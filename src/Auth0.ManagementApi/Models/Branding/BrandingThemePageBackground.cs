using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auth0.ManagementApi.Models
{
    public class BrandingThemePageBackground
    {
        /// <summary>
        /// Background color.
        /// </summary>
        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Background image url.
        /// </summary>
        [JsonProperty("background_image_url")]
        public string BackgroundImageUrl { get; set; }

        /// <inheritdoc cref="Auth0.ManagementApi.Models.HorizontalAlignment"/>
        [JsonProperty("page_layout")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HorizontalAlignment PageLayout { get; set; }
    }
}

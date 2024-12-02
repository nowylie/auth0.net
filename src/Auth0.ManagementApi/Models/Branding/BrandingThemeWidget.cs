using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auth0.ManagementApi.Models
{
    public class BrandingThemeWidget
    {
        /// <inheritdoc cref="Auth0.ManagementApi.Models.HorizontalAlignment"/>
        [JsonProperty("header_text_alignment")]
        [JsonConverter(typeof(StringEnumConverter))]
        public HorizontalAlignment HeaderTextAlignment { get; set; }

        /// <summary>
        /// Logo height.
        /// </summary>
        [JsonProperty("logo_height")]
        public uint LogoHeight { get; set; }
        
        /// <inheritdoc cref="Auth0.ManagementApi.Models.LogoPosition"/>
        [JsonProperty("logo_position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LogoPosition LogoPosition { get; set; }

        /// <summary>
        /// Logo url.
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        /// <inheritdoc cref="Auth0.ManagementApi.Models.SocialButtonsLayout"/>
        [JsonProperty("social_buttons_layout")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SocialButtonLayout SocialButtonsLayout { get; set; }
    }
}

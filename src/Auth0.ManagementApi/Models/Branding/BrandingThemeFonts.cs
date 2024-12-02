using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auth0.ManagementApi.Models
{
    public class BrandingThemeFonts
    {
        /// <summary>
        /// Body text.
        /// </summary>
        [JsonProperty("body_text")]
        public BrandingThemeFontStyle BodyText { get; set; }

        /// <summary>
        /// Buttons text.
        /// </summary>
        [JsonProperty("buttons_text")]
        public BrandingThemeFontStyle ButtonsText { get; set; }

        /// <summary>
        /// Font URL.
        /// </summary>
        [JsonProperty("font_url")]
        public string FontUrl { get; set; }

        /// <summary>
        /// Input Labels.
        /// </summary>
        [JsonProperty("input_labels")]
        public BrandingThemeFontStyle InputLabels { get; set; }

        /// <summary>
        /// Links.
        /// </summary>
        [JsonProperty("links")]
        public BrandingThemeFontStyle Links { get; set; }

        /// <inheritdoc cref="Auth0.ManagementApi.Models.TextStyle"/>
        [JsonProperty("links_style")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TextStyle LinksStyle { get; set; }

        /// <summary>
        /// Reference text size.
        /// </summary>
        [JsonProperty("reference_text_size")]
        public uint ReferenceTextSize { get; set; }

        /// <summary>
        /// Subtitle.
        /// </summary>
        [JsonProperty("subtitle")]
        public BrandingThemeFontStyle Subtitle { get; set; }

        /// <summary>
        /// Title.
        /// </summary>
        [JsonProperty("title")]
        public BrandingThemeFontStyle Title { get; set; }
    }
}

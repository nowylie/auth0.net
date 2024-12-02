using Newtonsoft.Json;

namespace Auth0.ManagementApi.Models
{
    public class BrandingThemeFontStyle
    {
        /// <summary>
        /// Bold?
        /// </summary>
        [JsonProperty("bold")]
        public bool Bold { get; set; }

        /// <summary>
        /// Size.
        /// </summary>
        [JsonProperty("size")]
        public uint Size { get; set; }
    }
}

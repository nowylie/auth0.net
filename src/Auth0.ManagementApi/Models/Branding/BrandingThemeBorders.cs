using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auth0.ManagementApi.Models
{
    public class BrandingThemeBorders
    {
        /// <summary>
        /// Button border radius.
        /// Required
        /// </summary>
        [JsonProperty("button_border_radius")]
        public uint ButtonBorderRadius { get; set; }

        /// <summary>
        /// Button border weight.
        /// Required
        /// </summary>
        [JsonProperty("button_border_weight")]
        public uint ButtonBorderWeight { get; set; }

        /// <inheritdoc cref="Auth0.ManagementApi.Models.BorderStyle"/>
        [JsonProperty("buttons_style")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BorderStyle ButtonsStyle { get; set; }

        /// <summary>
        /// Input border radius.
        /// Required
        /// </summary>
        [JsonProperty("input_border_radius")]
        public uint InputBorderRadius { get; set; }

        /// <summary>
        /// Input border weight.
        /// Required
        /// </summary>
        [JsonProperty("input_border_weight")]
        public uint InputBorderWeight { get; set; }

        /// <inheritdoc cref="Auth0.ManagementApi.Models.BorderStyle"/>
        [JsonProperty("inputs_style")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BorderStyle InputsStyle { get; set; }

        /// <summary>
        /// Show widget shadow.
        /// Required
        /// </summary>
        [JsonProperty("show_widget_shadow")]
        public bool ShowWidgetShadow { get; set; }

        /// <summary>
        /// Widget border weight.
        /// Required
        /// </summary>
        [JsonProperty("widget_border_weight")]
        public uint WidgetBorderWeight { get; set; }

        /// <summary>
        /// Widget corner radius.
        /// Required
        /// </summary>
        [JsonProperty("widget_corner_radius")]
        public uint WidgetCornerRadius { get; set; }
    }
}

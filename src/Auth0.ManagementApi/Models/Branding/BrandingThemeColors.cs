using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auth0.ManagementApi.Models
{
    public class BrandingThemeColors
    {
        /// <summary>
        /// Base Focus Color.
        /// </summary>
        [JsonProperty("base_focus_color")]
        public string BaseFocusColor { get; set; }

        /// <summary>
        /// Base Hover Color.
        /// </summary>
        [JsonProperty("base_hover_color")]
        public string BaseHoverColor { get; set; }

        /// <summary>
        /// Body text.
        /// Required
        /// </summary>
        [JsonProperty("body_text")]
        public string BodyText { get; set; }

        /// <inheritdoc cref="Auth0.ManagementApi.Models.ThemeStyle"/>
        [JsonProperty("captcha_widget_theme")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ThemeStyle CaptchaWidgetTheme { get; set; }

        /// <summary>
        /// Error.
        /// Required
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// Header.
        /// Required
        /// </summary>
        [JsonProperty("header")]
        public string Header { get; set; }

        /// <summary>
        /// Icons.
        /// Required
        /// </summary>
        [JsonProperty("icons")]
        public string Icons { get; set; }

        /// <summary>
        /// Input background.
        /// Required
        /// </summary>
        [JsonProperty("input_background")]
        public string InputBackground { get; set; }

        /// <summary>
        /// Input border.
        /// Required
        /// </summary>
        [JsonProperty("input_border")]
        public string InputBorder { get; set; }

        /// <summary>
        /// Input filled text.
        /// Required
        /// </summary>
        [JsonProperty("input_filled_text")]
        public string InputFilledText { get; set; }

        /// <summary>
        /// Input labels & placeholders.
        /// Required
        /// </summary>
        [JsonProperty("input_labels_placeholders")]
        public string InputLabelsPlaceholders { get; set; }

        /// <summary>
        /// Links & focused components.
        /// Required
        /// </summary>
        [JsonProperty("links_focused_components")]
        public string LinksFocusedComponents { get; set; }

        /// <summary>
        /// Primary button.
        /// Required
        /// </summary>
        [JsonProperty("primary_button")]
        public string PrimaryButton { get; set; }

        /// <summary>
        /// Primary button label.
        /// Required
        /// </summary>
        [JsonProperty("primary_button_label")]
        public string PrimaryButtonLabel { get; set; }

        /// <summary>
        /// Secondary button border.
        /// Required
        /// </summary>
        [JsonProperty("secondary_button_border")]
        public string SecondaryButtonBorder { get; set; }

        /// <summary>
        /// Secondary button label.
        /// Required
        /// </summary>
        [JsonProperty("secondary_button_label")]
        public string SecondaryButtonLabel { get; set; }

        /// <summary>
        /// Success.
        /// Required
        /// </summary>
        [JsonProperty("success")]
        public string Success { get; set; }

        /// <summary>
        /// Widget background.
        /// Required
        /// </summary>
        [JsonProperty("widget_background")]
        public string WidgetBackground { get; set; }

        /// <summary>
        /// Widget border.
        /// Required
        /// </summary>
        [JsonProperty("widget_border")]
        public string WidgetBorder { get; set; }

    }
}

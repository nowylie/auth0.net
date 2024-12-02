using System.Runtime.Serialization;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Defines a style for text.
    /// </summary>
    public enum TextStyle
    {
        /// <summary>
        /// Text style 'normal'
        /// </summary>
        [EnumMember(Value = "normal")]
        NORMAL,
        
        /// <summary>
        /// Text style 'underlined'
        /// </summary>
        [EnumMember(Value = "underlined")]
        UNDERLINED
    }
}

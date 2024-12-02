using System.Runtime.Serialization;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Defines a style for buttons.
    /// </summary>
    public enum BorderStyle
    {
        /// <summary>
        /// Buttons style 'pill'
        /// </summary>
        [EnumMember(Value = "pill")]
        PILL,
        
        /// <summary>
        /// Buttons style 'rounded'
        /// </summary>
        [EnumMember(Value = "rounded")]
        ROUNDED,
        
        /// <summary>
        /// Buttons style 'sharp'
        /// </summary>
        [EnumMember(Value = "sharp")]
        SHARP
    }
}

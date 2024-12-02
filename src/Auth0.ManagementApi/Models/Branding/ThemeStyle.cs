using System.Runtime.Serialization;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Defines theme styles.
    /// </summary>
    public enum ThemeStyle
    {
        /// <summary>
        /// Theme style 'auto'
        /// </summary>
        [EnumMember(Value = "auto")]
        AUTO,
        
        /// <summary>
        /// Theme style 'dark'
        /// </summary>
        [EnumMember(Value = "dark")]
        DARK,
        
        /// <summary>
        /// Theme style 'light'
        /// </summary>
        [EnumMember(Value = "light")]
        LIGHT
    }
}

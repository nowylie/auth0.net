using System.Runtime.Serialization;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Defines social button layouts.
    /// </summary>
    public enum SocialButtonLayout
    {
        /// <summary>
        /// Button layout 'bottom'
        /// </summary>
        [EnumMember(Value = "bottom")]
        BOTTOM,
        
        /// <summary>
        /// Button layout 'top'
        /// </summary>
        [EnumMember(Value = "top")]
        TOP
    }
}

using System.Runtime.Serialization;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Defines logo positions.
    /// </summary>
    public enum LogoPosition
    {
        /// <summary>
        /// Position 'none'
        /// </summary>
        [EnumMember(Value = "none")]
        NONE,

        /// <summary>
        /// Position 'left'
        /// </summary>
        [EnumMember(Value = "left")]
        LEFT,
        
        /// <summary>
        /// Position 'center'
        /// </summary>
        [EnumMember(Value = "center")]
        CENTER,
        
        /// <summary>
        /// Position 'right'
        /// </summary>
        [EnumMember(Value = "right")]
        RIGHT
    }
}

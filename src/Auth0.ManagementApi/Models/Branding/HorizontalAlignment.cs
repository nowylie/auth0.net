using System.Runtime.Serialization;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Defines horizontal alignments.
    /// </summary>
    public enum HorizontalAlignment
    {
        /// <summary>
        /// Align 'left'
        /// </summary>
        [EnumMember(Value = "left")]
        LEFT,
        
        /// <summary>
        /// Align 'center'
        /// </summary>
        [EnumMember(Value = "center")]
        CENTER,
        
        /// <summary>
        /// Align 'right'
        /// </summary>
        [EnumMember(Value = "right")]
        RIGHT
    }
}

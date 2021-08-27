using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// Extension methods for LayerMask.
    /// </summary>
    public static class LayerMaskExtensions
    {
        /// <summary>
        /// Checks if the given layer is included in the mask.
        /// </summary>
        /// <param name="mask">The mask to check.</param>
        /// <param name="layer">The layer to check.</param>
        /// <returns>True if the layer is included in the mask, false otherwise.</returns>
        public static bool Contains(this LayerMask mask, int layer)
        {
            return mask == (mask | (1 << layer));
        }

    }

}

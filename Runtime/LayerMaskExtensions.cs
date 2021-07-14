using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// Extension methods for LayerMask.
    /// </summary>
    public static class LayerMaskExtensions
    {
        /// <summary>
        /// Checks if the given <paramref name="layer"/> is included in the
        /// LayerMask.
        /// </summary>
        /// <param name="mask">The LayerMask to check.</param>
        /// <param name="layer">The layer to check.</param>
        public static bool Contains(this LayerMask mask, int layer)
        {
            return mask == (mask | (1 << layer));
        }

    }

}

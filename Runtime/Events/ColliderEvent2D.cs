using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// A custom unity event for use with the Collider2D class.
    /// </summary>
    [System.Serializable]
    public class ColliderEvent2D : UnityEvent<Collider2D>
    {
    }

}

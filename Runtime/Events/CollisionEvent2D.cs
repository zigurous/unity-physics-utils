using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// A custom unity event for use with the Collision2D class.
    /// </summary>
    [System.Serializable]
    public class CollisionEvent2D : UnityEvent<Collision2D>
    {
    }

}

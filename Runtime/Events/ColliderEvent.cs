using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// A custom unity event for use with the Collider class.
    /// </summary>
    [System.Serializable]
    public class ColliderEvent : UnityEvent<Collider>
    {
    }

}

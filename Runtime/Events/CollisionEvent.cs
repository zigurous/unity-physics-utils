using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// A custom unity event for use with the Collision class.
    /// </summary>
    [System.Serializable]
    public class CollisionEvent : UnityEvent<Collision>
    {
    }

}

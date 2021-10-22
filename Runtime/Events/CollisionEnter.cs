using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionEnter.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Collision Enter")]
    public class CollisionEnter : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnCollisionEnter.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionEnter.")]
        public CollisionEvent collisionEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionEnter.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionEnter(Collision collision)
        {
            if (collisionEvent != null && layerMask.Contains(collision.gameObject.layer)) {
                collisionEvent.Invoke(collision);
            }
        }

    }

}

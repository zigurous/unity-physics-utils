using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionStay2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Collision Stay 2D")]
    public class CollisionStay2D : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnCollisionStay2D.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionStay2D.")]
        public CollisionEvent2D collisionEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionStay2D.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionStay2D(Collision2D collision)
        {
            if (collisionEvent != null && layerMask.Contains(collision.gameObject.layer)) {
                collisionEvent.Invoke(collision);
            }
        }

    }

}

using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionExit.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Events/Collision Exit")]
    [HelpURL("https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Events/CollisionExit")]
    [RequireComponent(typeof(Collider))]
    public class CollisionExit : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnCollisionExit.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionExit.")]
        public CollisionEvent collisionEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionExit.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionExit(Collision collision)
        {
            if (collisionEvent != null && layerMask.Contains(collision.gameObject.layer)) {
                collisionEvent.Invoke(collision);
            }
        }

    }

}

using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionStay.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Events/Collision Stay")]
    [HelpURL("https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Events/CollisionStay")]
    [RequireComponent(typeof(Collider))]
    public class CollisionStay : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnCollisionStay.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionStay.")]
        public CollisionEvent collisionEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionStay.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionStay(Collision collision)
        {
            if (collisionEvent != null && layerMask.Contains(collision.gameObject.layer)) {
                collisionEvent.Invoke(collision);
            }
        }

    }

}

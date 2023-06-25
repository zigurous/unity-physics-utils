using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionExit2D.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Events/Collision Exit 2D")]
    [HelpURL("https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Events/CollisionExit2D")]
    [RequireComponent(typeof(Collider2D))]
    public class CollisionExit2D : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnCollisionExit2D.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionExit2D.")]
        public CollisionEvent2D collisionEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionExit2D.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionExit2D(Collision2D collision)
        {
            if (collisionEvent != null && layerMask.Contains(collision.gameObject.layer)) {
                collisionEvent.Invoke(collision);
            }
        }

    }

}

using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionExit2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Collision Exit 2D")]
    public class CollisionExit2D : MonoBehaviour
    {
        /// <summary>
        /// The event invoked during OnCollisionExit2D.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionExit2D.")]
        public CollisionEvent2D onCollisionExit2D;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionExit2D.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionExit2D(Collision2D collision)
        {
            if (this.onCollisionExit2D != null) {
                this.onCollisionExit2D.Invoke(collision);
            }
        }

    }

}

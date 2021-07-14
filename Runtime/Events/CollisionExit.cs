using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionExit.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Collision Exit")]
    public class CollisionExit : MonoBehaviour
    {
        /// <summary>
        /// The event invoked during OnCollisionExit.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionExit.")]
        public CollisionEvent onCollisionExit;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionExit.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionExit(Collision collision)
        {
            if (this.onCollisionExit != null) {
                this.onCollisionExit.Invoke(collision);
            }
        }

    }

}

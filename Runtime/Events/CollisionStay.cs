using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionStay.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Collision Stay")]
    public class CollisionStay : MonoBehaviour
    {
        /// <summary>
        /// The event invoked during OnCollisionStay.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionStay.")]
        public CollisionEvent onCollisionStay;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionStay.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionStay(Collision collision)
        {
            if (this.onCollisionStay != null) {
                this.onCollisionStay.Invoke(collision);
            }
        }

    }

}

using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionEnter2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Collision Enter 2D")]
    public class CollisionEnter2D : MonoBehaviour
    {
        /// <summary>
        /// The event invoked during OnCollisionEnter2D.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionEnter2D.")]
        public CollisionEvent2D collisionEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnCollisionEnter2D.
        /// </summary>
        /// <param name="collision">The collision data to send with the event.</param>
        protected virtual void OnCollisionEnter2D(Collision2D collision)
        {
            if (this.collisionEvent != null) {
                this.collisionEvent.Invoke(collision);
            }
        }

    }

}

using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerEnter2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Enter 2D")]
    public class TriggerEnter2D : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnTriggerEnter2D.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerEnter2D.")]
        public ColliderEvent2D triggerEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerEnter2D.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerEnter2D(Collider2D other)
        {
            if (triggerEvent != null && layerMask.Contains(other.gameObject.layer)) {
                triggerEvent.Invoke(other);
            }
        }

    }

}

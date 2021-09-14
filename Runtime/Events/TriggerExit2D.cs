using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerExit2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Exit 2D")]
    public class TriggerExit2D : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnTriggerExit2D.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerExit2D.")]
        public ColliderEvent2D triggerEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerExit2D.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerExit2D(Collider2D other)
        {
            if (this.triggerEvent != null && this.layerMask.Contains(other.gameObject.layer)) {
                this.triggerEvent.Invoke(other);
            }
        }

    }

}

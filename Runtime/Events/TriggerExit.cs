using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerExit.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Exit")]
    public class TriggerExit : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnTriggerExit.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerExit.")]
        public ColliderEvent triggerEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerExit.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerExit(Collider other)
        {
            if (this.triggerEvent != null && this.layerMask.Contains(other.gameObject.layer)) {
                this.triggerEvent.Invoke(other);
            }
        }

    }

}

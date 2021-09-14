using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerStay.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Stay")]
    public class TriggerStay : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnTriggerStay.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerStay.")]
        public ColliderEvent triggerEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerStay.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerStay(Collider other)
        {
            if (this.triggerEvent != null && this.layerMask.Contains(other.gameObject.layer)) {
                this.triggerEvent.Invoke(other);
            }
        }

    }

}

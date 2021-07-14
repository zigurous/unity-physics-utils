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
        /// The event invoked during OnTriggerStay.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerStay.")]
        public ColliderEvent onTriggerStay;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerStay.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerStay(Collider other)
        {
            if (this.onTriggerStay != null) {
                this.onTriggerStay.Invoke(other);
            }
        }

    }

}

using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerStay.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Stay")]
    [HelpURL("https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Events/TriggerStay")]
    [RequireComponent(typeof(Collider))]
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
            if (triggerEvent != null && layerMask.Contains(other.gameObject.layer)) {
                triggerEvent.Invoke(other);
            }
        }

    }

}

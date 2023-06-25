using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerStay2D.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Stay 2D")]
    [HelpURL("https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Events/TriggerStay2D")]
    [RequireComponent(typeof(Collider2D))]
    public class TriggerStay2D : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnTriggerStay2D.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerStay2D.")]
        public ColliderEvent2D triggerEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerStay2D.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerStay2D(Collider2D other)
        {
            if (triggerEvent != null && layerMask.Contains(other.gameObject.layer)) {
                triggerEvent.Invoke(other);
            }
        }

    }

}

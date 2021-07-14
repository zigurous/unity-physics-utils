using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerStay2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Stay 2D")]
    public class TriggerStay2D : MonoBehaviour
    {
        /// <summary>
        /// The event invoked during OnTriggerStay2D.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerStay2D.")]
        public ColliderEvent2D onTriggerStay2D;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerStay2D.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerStay2D(Collider2D other)
        {
            if (this.onTriggerStay2D != null) {
                this.onTriggerStay2D.Invoke(other);
            }
        }

    }

}

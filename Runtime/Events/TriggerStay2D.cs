using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerStay2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Stay 2D")]
    public class TriggerStay2D : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collider2D> {}

        /// <summary>
        /// The event invoked during OnTriggerStay2D.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerStay2D.")]
        public Event onStay;

        protected virtual void OnTriggerStay2D(Collider2D other)
        {
            if (this.onStay != null) {
                this.onStay.Invoke(other);
            }
        }

    }

}

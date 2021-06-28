using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerStay.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Stay")]
    public class TriggerStay : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collider> {}

        /// <summary>
        /// The event invoked during OnTriggerStay.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerStay.")]
        public Event onStay;

        protected virtual void OnTriggerStay(Collider other)
        {
            if (this.onStay != null) {
                this.onStay.Invoke(other);
            }
        }

    }

}

using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerExit.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Exit")]
    public class TriggerExit : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collider> {}

        /// <summary>
        /// The event invoked during OnTriggerExit.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerExit.")]
        public Event onExit;

        protected virtual void OnTriggerExit(Collider other)
        {
            if (this.onExit != null) {
                this.onExit.Invoke(other);
            }
        }

    }

}

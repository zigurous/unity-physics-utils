using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerEnter.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class TriggerEnter : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collider> {}

        /// <summary>
        /// The event invoked during OnTriggerEnter.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerEnter.")]
        public Event onEnter;

        protected virtual void OnTriggerEnter(Collider other)
        {
            if (this.onEnter != null) {
                this.onEnter.Invoke(other);
            }
        }

    }

}

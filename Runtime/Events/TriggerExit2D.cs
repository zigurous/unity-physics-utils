using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerExit2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    public class TriggerExit2D : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collider2D> {}

        /// <summary>
        /// The event invoked during OnTriggerExit2D.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerExit2D.")]
        public Event onExit;

        protected virtual void OnTriggerExit2D(Collider2D other)
        {
            if (this.onExit != null) {
                this.onExit.Invoke(other);
            }
        }

    }

}

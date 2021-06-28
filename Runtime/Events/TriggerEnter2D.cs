using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerEnter2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Enter 2D")]
    public class TriggerEnter2D : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collider2D> {}

        /// <summary>
        /// The event invoked during OnTriggerEnter2D.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerEnter2D.")]
        public Event onEnter;

        protected virtual void OnTriggerEnter2D(Collider2D other)
        {
            if (this.onEnter != null) {
                this.onEnter.Invoke(other);
            }
        }

    }

}

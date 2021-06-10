using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionEnter.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class CollisionEnter : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collision> {}

        /// <summary>
        /// The event invoked during OnCollisionEnter.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionEnter.")]
        public Event onEnter;

        protected virtual void OnCollisionEnter(Collision collision)
        {
            if (this.onEnter != null) {
                this.onEnter.Invoke(collision);
            }
        }

    }

}

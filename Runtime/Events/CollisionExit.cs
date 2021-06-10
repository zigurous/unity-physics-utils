using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionExit.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class CollisionExit : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collision> {}

        /// <summary>
        /// The event invoked during OnCollisionExit.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionExit.")]
        public Event onExit;

        protected virtual void OnCollisionExit(Collision collision)
        {
            if (this.onExit != null) {
                this.onExit.Invoke(collision);
            }
        }

    }

}

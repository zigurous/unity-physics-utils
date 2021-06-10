using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionExit2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    public class CollisionExit2D : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collision2D> {}

        /// <summary>
        /// The event invoked during OnCollisionExit2D.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionExit2D.")]
        public Event onExit;

        protected virtual void OnCollisionExit2D(Collision2D collision)
        {
            if (this.onExit != null) {
                this.onExit.Invoke(collision);
            }
        }

    }

}

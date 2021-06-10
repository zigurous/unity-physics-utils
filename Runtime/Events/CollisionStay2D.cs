using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionStay2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    public class CollisionStay2D : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collision2D> {}

        /// <summary>
        /// The event invoked during OnCollisionStay2D.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionStay2D.")]
        public Event onStay;

        protected virtual void OnCollisionStay2D(Collision2D collision)
        {
            if (this.onStay != null) {
                this.onStay.Invoke(collision);
            }
        }

    }

}

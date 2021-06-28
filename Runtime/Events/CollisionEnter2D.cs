using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionEnter2D.
    /// </summary>
    [RequireComponent(typeof(Collider2D))]
    [AddComponentMenu("Zigurous/Physics/Events/Collision Enter 2D")]
    public class CollisionEnter2D : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collision2D> {}

        /// <summary>
        /// The event invoked during OnCollisionEnter2D.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionEnter2D.")]
        public Event onEnter;

        protected virtual void OnCollisionEnter2D(Collision2D collision)
        {
            if (this.onEnter != null) {
                this.onEnter.Invoke(collision);
            }
        }

    }

}

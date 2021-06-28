using UnityEngine;
using UnityEngine.Events;

namespace Zigurous.Physics
{
    /// <summary>
    /// Invokes a custom unity event OnCollisionStay.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Collision Stay")]
    public class CollisionStay : MonoBehaviour
    {
        [System.Serializable]
        public class Event : UnityEvent<Collision> {}

        /// <summary>
        /// The event invoked during OnCollisionStay.
        /// </summary>
        [Tooltip("The event invoked during OnCollisionStay.")]
        public Event onStay;

        protected virtual void OnCollisionStay(Collision collision)
        {
            if (this.onStay != null) {
                this.onStay.Invoke(collision);
            }
        }

    }

}

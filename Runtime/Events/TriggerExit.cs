﻿using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerExit.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Exit")]
    [HelpURL("https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics.Events/TriggerExit")]
    [RequireComponent(typeof(Collider))]
    public class TriggerExit : MonoBehaviour
    {
        /// <summary>
        /// The layers that this object can collide with.
        /// </summary>
        [Tooltip("The layers that this object can collide with.")]
        public LayerMask layerMask = ~0;

        /// <summary>
        /// The event invoked during OnTriggerExit.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerExit.")]
        public ColliderEvent triggerEvent;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerExit.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerExit(Collider other)
        {
            if (triggerEvent != null && layerMask.Contains(other.gameObject.layer)) {
                triggerEvent.Invoke(other);
            }
        }

    }

}

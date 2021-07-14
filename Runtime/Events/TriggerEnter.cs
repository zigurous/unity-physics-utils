﻿using UnityEngine;

namespace Zigurous.Physics.Events
{
    /// <summary>
    /// Invokes a custom unity event OnTriggerEnter.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu("Zigurous/Physics/Events/Trigger Enter")]
    public class TriggerEnter : MonoBehaviour
    {
        /// <summary>
        /// The event invoked during OnTriggerEnter.
        /// </summary>
        [Tooltip("The event invoked during OnTriggerEnter.")]
        public ColliderEvent onTriggerEnter;

        /// <summary>
        /// Invokes the custom unity event in response to OnTriggerEnter.
        /// </summary>
        /// <param name="other">The collider reference to send with the event.</param>
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (this.onTriggerEnter != null) {
                this.onTriggerEnter.Invoke(other);
            }
        }

    }

}
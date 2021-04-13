using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// An object with magnetic properties that can be attracted to a magnet.
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class Magnetic : MonoBehaviour
    {
        /// <summary>
        /// The magnet the object is currently attracted to.
        /// </summary>
        public Magnet attractedMagnet { get; protected set; }

        /// <summary>
        /// The rigidbody of the magnetic object that handles moving the object
        /// towards the magnet when attracted.
        /// </summary>
        public new Rigidbody rigidbody { get; protected set; }

        protected virtual void Awake()
        {
            this.rigidbody = GetComponent<Rigidbody>();
        }

        protected virtual void OnDestroy()
        {
            this.attractedMagnet = null;
            this.rigidbody = null;
        }

        protected virtual void FixedUpdate()
        {
            if (this.attractedMagnet != null)
            {
                Vector3 direction = this.attractedMagnet.transform.position - this.transform.position;
                float index = (this.attractedMagnet.magneticField.radius - direction.magnitude) / this.attractedMagnet.magneticField.radius;
                this.rigidbody.AddForce(this.attractedMagnet.strength * direction * index);
            }
        }

        protected virtual void OnTriggerEnter(Collider other)
        {
            Magnet magnet = other.GetComponent<Magnet>();

            if (magnet != null)
            {
                if (this.attractedMagnet == null) {
                    this.attractedMagnet = magnet;
                } else if (magnet.strength > this.attractedMagnet.strength) {
                    this.attractedMagnet = magnet;
                }
            }
        }

        protected virtual void OnTriggerExit(Collider other)
        {
            Magnet magnet = other.GetComponent<Magnet>();

            if (magnet != null && this.attractedMagnet == magnet) {
                this.attractedMagnet = null;
            }
        }

    }

}

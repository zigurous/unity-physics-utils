using System.Collections.Generic;
using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// An object with magnetic properties that can be attracted to a magnet.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Magnetic")]
    public sealed class Magnetic : MonoBehaviour
    {
        /// <summary>
        /// The rigidbody of the magnetic object that handles moving the object
        /// toward attracted magnets. When not present, forces will be added
        /// directly to the transform's position instead (Read only).
        /// </summary>
        public new Rigidbody rigidbody { get; private set; }

        /// <summary>
        /// The magnets the object is currently attracted to (Read only).
        /// </summary>
        public List<Magnet> attractedMagnets { get; private set; } = new List<Magnet>(1);

        private void Awake()
        {
            this.rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (this.rigidbody == null)
            {
                Vector3 force = CombineForces(this.transform.position);
                this.transform.position += force * Time.deltaTime;
            }
        }

        private void FixedUpdate()
        {
            if (this.rigidbody != null)
            {
                Vector3 force = CombineForces(this.rigidbody.position);
                this.rigidbody.AddForce(force);
            }
        }

        private Vector3 CombineForces(Vector3 currentPosition)
        {
            Vector3 forces = Vector3.zero;

            foreach (Magnet magnet in this.attractedMagnets) {
                forces += CalculateForce(magnet, currentPosition);
            }

            return forces;
        }

        private Vector3 CalculateForce(Magnet magnet, Vector3 currentPosition)
        {
            Vector3 direction = magnet.transform.position - currentPosition;
            float index = (magnet.radius - direction.magnitude) / magnet.radius;
            return direction * magnet.strength * index;
        }

        private void OnTriggerEnter(Collider other)
        {
            Magnet magnet = other.GetComponent<Magnet>();

            if (magnet != null) {
                this.attractedMagnets.Add(magnet);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            Magnet magnet = other.GetComponent<Magnet>();

            if (magnet != null) {
                this.attractedMagnets.Remove(magnet);
            }
        }

    }

}

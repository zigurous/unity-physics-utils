using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// Adds an explosion force to all rigidbodies within a set radius upon
    /// being triggered.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Explosion")]
    public class Explosion : MonoBehaviour
    {
        /// <summary>
        /// A type of trigger that causes an explosion.
        /// </summary>
        public enum Trigger
        {
            /// <summary>
            /// The explosion is triggered manually.
            /// </summary>
            Manual,

            /// <summary>
            /// Triggers the explosion on the start of the script.
            /// </summary>
            OnStart,

            /// <summary>
            /// Triggers the explosion when a collision occurs on the object.
            /// </summary>
            OnCollisionEnter,

            /// <summary>
            /// Triggers the explosion after a collision exits on the object.
            /// </summary>
            OnCollisionExit,

            /// <summary>
            /// Triggers the explosion when entering a trigger collider.
            /// </summary>
            OnTriggerEnter,

            /// <summary>
            /// Triggers the explosion after exiting a trigger collider.
            /// </summary>
            OnTriggerExit,
        }

        /// <summary>
        /// The type of trigger that causes the explosion.
        /// </summary>
        [Tooltip("The type of trigger that causes the explosion.")]
        public Trigger trigger = Trigger.Manual;

        /// <summary>
        /// The type of force applied to affected rigidbodies.
        /// </summary>
        [Tooltip("The type of force applied to affected rigidbodies.")]
        public ForceMode forceMode = ForceMode.Force;

        /// <summary>
        /// The layers that can be affected by the explosion.
        /// </summary>
        [Tooltip("The layers that can be affected by the explosion.")]
        public LayerMask layerMask = 1;

        /// <summary>
        /// The radius of the sphere within which the explosion has its effect.
        /// </summary>
        [Tooltip("The radius of the sphere within which the explosion has its effect.")]
        public float radius;

        /// <summary>
        /// The force strength of the explosion.
        /// </summary>
        [Tooltip("The force strength of the explosion.")]
        public float strength;

        /// <summary>
        /// An adjustment to the apparent position of the explosion to make it
        /// seem to lift objects.
        /// </summary>
        [Tooltip("An adjustment to the apparent position of the explosion to make it seem to lift objects.")]
        public float upwardsModifier;

        /// <summary>
        /// The amount of seconds before the explosion takes effect after being
        /// triggered.
        /// </summary>
        [Tooltip("The amount of seconds before the explosion takes effect after being triggered.")]
        public float fuseTime;

        /// <summary>
        /// Destroys the game object of the script after exploding.
        /// </summary>
        [Tooltip("Destroys the game object of the script after exploding.")]
        public bool destroyOnExplode;

        /// <summary>
        /// Triggers the explosion.
        /// </summary>
        public virtual void Explode()
        {
            Collider[] colliders = UnityEngine.Physics.OverlapSphere(transform.position, radius, layerMask);

            for (int i = 0; i < colliders.Length; i++)
            {
                Rigidbody rigidbody = colliders[i].attachedRigidbody;

                if (rigidbody != null) {
                    rigidbody.AddExplosionForce(strength, transform.position, radius, upwardsModifier);
                }
            }

            if (destroyOnExplode) {
                Destroy(gameObject);
            }
        }

        /// <summary>
        /// Triggers the explosion after the given amount of seconds specified
        /// by a fuse time.
        /// </summary>
        /// <param name="fuseTime">The amount of seconds before the explosion takes effect.</param>
        public void Explode(float fuseTime)
        {
            if (fuseTime > 0f) {
                Invoke(nameof(Explode), fuseTime);
            } else {
                Explode();
            }
        }

        protected virtual void Start()
        {
            if (trigger == Trigger.OnStart) {
                Explode(fuseTime);
            }
        }

        protected virtual void OnCollisionEnter(Collision collision)
        {
            if (trigger == Trigger.OnCollisionEnter) {
                Explode(fuseTime);
            }
        }

        protected virtual void OnCollisionExit(Collision collision)
        {
            if (trigger == Trigger.OnCollisionExit) {
                Explode(fuseTime);
            }
        }

        protected virtual void OnTriggerEnter(Collider collider)
        {
            if (trigger == Trigger.OnTriggerEnter) {
                Explode(fuseTime);
            }
        }

        protected virtual void OnTriggerExit(Collider collider)
        {
            if (trigger == Trigger.OnTriggerExit) {
                Explode(fuseTime);
            }
        }

    }

}

using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// An object that produces a magnetic field that attracts objects.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Magnet")]
    public sealed class Magnet : MonoBehaviour
    {
        /// <summary>
        /// The sphere collider that represents the magnetic field of the
        /// magnet (Read only).
        /// </summary>
        public SphereCollider magneticField { get; private set; }

        /// <summary>
        /// The strength of the magnet. If an object is within multiple magnetic
        /// fields, then it will be attracted to the magnet with the higher
        /// strength.
        /// </summary>
        [Tooltip("The strength of the magnet. If an object is within multiple magnetic fields, then it will be attracted to the magnet with the higher strength.")]
        public float strength = 1f;

        [SerializeField]
        [Tooltip("The radius of the magnetic field produced by the magnet. Magnetic objects within the radius are attracted to the magnet.")]
        private float _radius = 10f;

        /// <summary>
        /// The radius of the magnetic field produced by the magnet. Magnetic
        /// objects within the radius are attracted to the magnet.
        /// </summary>
        public float radius
        {
            get => _radius;
            set
            {
                _radius = value;
                this.magneticField.radius = value;
            }
        }

        private void Awake()
        {
            this.magneticField = this.gameObject.AddComponent<SphereCollider>();
            this.magneticField.isTrigger = true;
            this.magneticField.radius = this.radius;
            this.magneticField.hideFlags = HideFlags.HideInInspector;
        }

        private void OnValidate()
        {
            if (this.magneticField != null) {
                this.magneticField.radius = this.radius;
            }
        }

        private void OnDestroy()
        {
            Destroy(this.magneticField);
        }

    }

}

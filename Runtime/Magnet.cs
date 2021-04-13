using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// An object that produces a magnetic field that attracts objects.
    /// </summary>
    public class Magnet : MonoBehaviour
    {
        /// <summary>
        /// The strength of the magnet. If an object is within multiple magnetic
        /// fields, then it will be attracted to the magnet with the higher
        /// strength.
        /// </summary>
        [Tooltip("The strength of the magnet. If an object is within multiple magnetic fields, then it will be attracted to the magnet with the higher strength.")]
        public float strength = 1.0f;

        /// <summary>
        /// The radius of the magnetic field produced by the magnet. Magnetic
        /// objects within the radius are attracted to the magnet.
        /// </summary>
        [Tooltip("The radius of the magnetic field produced by the magnet. Magnetic objects within the radius are attracted to the magnet.")]
        [SerializeField]
        private float _fieldRadius = 10.0f;

        /// <summary>
        /// The radius of the magnetic field produced by the magnet. Magnetic
        /// objects within the radius are attracted to the magnet.
        /// </summary>
        public float fieldRadius
        {
            get => _fieldRadius;
            set
            {
                _fieldRadius = value;
                this.magneticField.radius = value;
            }
        }

        /// <summary>
        /// The sphere collider that represents the magnetic field of the
        /// magnet.
        /// </summary>
        public SphereCollider magneticField { get; protected set; }

        protected virtual void Awake()
        {
            this.magneticField = this.gameObject.AddComponent<SphereCollider>();
            this.magneticField.isTrigger = true;
            this.magneticField.radius = _fieldRadius;
            this.magneticField.hideFlags = HideFlags.HideInInspector;
        }

        protected virtual void OnDestroy()
        {
            this.magneticField = null;
        }

        protected virtual void OnValidate()
        {
            if (this.magneticField != null) {
                this.magneticField.radius = _fieldRadius;
            }
        }

    }

}

﻿using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// An object that produces a magnetic field that attracts objects.
    /// </summary>
    public sealed class Magnet : MonoBehaviour
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
        private float _radius = 10.0f;

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

        /// <summary>
        /// The sphere collider that represents the magnetic field of the
        /// magnet.
        /// </summary>
        public SphereCollider magneticField { get; private set; }

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
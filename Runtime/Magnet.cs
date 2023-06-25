using UnityEngine;

namespace Zigurous.Physics
{
    /// <summary>
    /// An object that produces a magnetic field that attracts objects.
    /// </summary>
    [AddComponentMenu("Zigurous/Physics/Magnet")]
    [HelpURL("https://docs.zigurous.com/com.zigurous.physics/api/Zigurous.Physics/Magnet")]
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
        private float m_Radius = 10f;

        /// <summary>
        /// The radius of the magnetic field produced by the magnet. Magnetic
        /// objects within the radius are attracted to the magnet.
        /// </summary>
        public float radius
        {
            get => m_Radius;
            set
            {
                m_Radius = value;
                magneticField.radius = value;
            }
        }

        private void Awake()
        {
            magneticField = gameObject.AddComponent<SphereCollider>();
            magneticField.isTrigger = true;
            magneticField.radius = radius;
            magneticField.hideFlags = HideFlags.HideInInspector;
        }

        private void OnValidate()
        {
            if (magneticField != null) {
                magneticField.radius = radius;
            }
        }

        private void OnDestroy()
        {
            Destroy(magneticField);
        }

    }

}

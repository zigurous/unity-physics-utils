using UnityEngine;

namespace Zigurous.Physics
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(SphereCollider))]
    public sealed class MagneticField : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private SphereCollider _collider;
        private Magnet _attractedMagnet;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _collider = GetComponent<SphereCollider>();
            _collider.isTrigger = true;
        }

        private void OnDestroy()
        {
            _rigidbody = null;
            _collider = null;
            _attractedMagnet = null;
        }

        private void FixedUpdate()
        {
            if (_attractedMagnet != null)
            {
                Vector3 magneticField = _attractedMagnet.transform.position - this.transform.position;
                float index = (_collider.radius - magneticField.magnitude) / _collider.radius;
                _rigidbody.AddForce(_attractedMagnet.strength * magneticField * index);
            }
        }

        public void OnTriggerEnter(Collider other)
        {
            Magnet magnet = other.GetComponent<Magnet>();

            if (magnet != null)
            {
                if (_attractedMagnet == null) {
                    _attractedMagnet = magnet;
                } else {
                    // Attract to the magnet that is stronger
                    _attractedMagnet = _attractedMagnet.strength >= magnet.strength ? _attractedMagnet : magnet;
                }
            }
        }

        public void OnTriggerExit(Collider other)
        {
            Magnet magnet = other.GetComponent<Magnet>();

            if (magnet != null && _attractedMagnet == magnet) {
                _attractedMagnet = null;
            }
        }

    }

}

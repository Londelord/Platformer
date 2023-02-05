using UnityEngine;

namespace Platformer
{
    public class LayerChecker : MonoBehaviour
    {
        [SerializeField] LayerMask _groundlayer;
        private Collider2D _collider;
        public bool _istouchinglayer;

        private void Awake()
        {
            _collider = GetComponent<Collider2D>();
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            _istouchinglayer = _collider.IsTouchingLayers(_groundlayer);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            _istouchinglayer = _collider.IsTouchingLayers(_groundlayer);
        }
    }
}


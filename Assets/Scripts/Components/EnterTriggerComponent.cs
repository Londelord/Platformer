using UnityEngine;
using UnityEngine.Events;

namespace Platformer.Components
{
    public class EnterTriggerComponent : MonoBehaviour
    {
        [SerializeField] string _tag;
        [SerializeField] UnityEvent _ontrigger;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(_tag))
            {
            _ontrigger?.Invoke();
            }
        }
    }
}


using UnityEngine;

namespace Platformer.Components
{
    public class DestroyObjectComponent : MonoBehaviour
    {
        [SerializeField] GameObject _objecttodestroy;

        public void DestroyObject()
        {
            Destroy(_objecttodestroy);
        }
    }
}


using UnityEngine;
using UnityEngine.InputSystem;


namespace Platformer
{
    public class HeroInputReader : MonoBehaviour
    {
        private Hero _hero;

        private void Awake()
        {
            _hero = GetComponent<Hero>();
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            Vector2 direction = context.ReadValue<Vector2>();
            _hero.SetDirection(direction);
        }
    }
}


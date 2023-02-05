using UnityEngine;

namespace Platformer
{
    public class Hero : MonoBehaviour
    {
        [SerializeField] float _speed;
        [SerializeField] float _jumpspeed;
        [SerializeField] LayerChecker _groundcheck;

        private Vector2 _direction;
        private Rigidbody2D _rigidbody;
        private SpriteRenderer _spriterenderer;

        private Animator _animator;
        private int _isrunning = Animator.StringToHash("isrunning");
        private int _Isonground = Animator.StringToHash("isonground");
        private int _yvelocity = Animator.StringToHash("velocity.y");

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _animator = GetComponent<Animator>();
            _spriterenderer = GetComponent<SpriteRenderer>();
        }

        public void SetDirection(Vector2 direction)
        {
            _direction = direction;
        }

        private void FixedUpdate()
        {
            _rigidbody.velocity = new Vector2(_direction.x * _speed, _rigidbody.velocity.y);
            var _isonground = IsOnGround();
            var _isjumping = _direction.y > 0;

            if (_isjumping && _isonground)
            {
                _rigidbody.AddForce(Vector2.up * _jumpspeed, ForceMode2D.Impulse);
            }

            _animator.SetBool(_isrunning, _direction.x != 0);
            _animator.SetBool(_Isonground, _isonground);
            _animator.SetFloat(_yvelocity, _rigidbody.velocity.y);
            FlipXSptires();
        }

        private bool IsOnGround()
        {
            return _groundcheck._istouchinglayer;
        }

        private void FlipXSptires()
        {
            if (_direction.x > 0)
            {
                _spriterenderer.flipX = false;
            }
            else if (_direction.x < 0)
            {
                _spriterenderer.flipX = true;
            }
        }
    }
}


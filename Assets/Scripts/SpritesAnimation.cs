using UnityEngine;
using UnityEngine.Events;

namespace Platformer
{
    public class SpritesAnimation : MonoBehaviour
    {
        [SerializeField] float _framerate;
        [SerializeField] bool _loop;
        [SerializeField] Sprite[] _sprites;
        [SerializeField] UnityEvent _oncomplete;

        private float _secondsperframe;
        private float _timeofnextframe;
        private int _currentsprire;

        private SpriteRenderer _spriterenderer;

        private void Start()
        {
            _spriterenderer = GetComponent<SpriteRenderer>();
        }

        private void OnEnable()
        {
            _secondsperframe = 1f / _framerate;
            _timeofnextframe = Time.time + _secondsperframe;            
        }

        private void Update()
        {
            if (Time.time < _timeofnextframe) return;
            if (_currentsprire >= _sprites.Length)
            {
                if (_loop)
                {
                    _currentsprire = 0;
                }
                else
                {
                    enabled = false;
                    _oncomplete?.Invoke();
                    return;
                }
            }
            _spriterenderer.sprite = _sprites[_currentsprire];
            _timeofnextframe += _secondsperframe;
            _currentsprire++;
        }
    }
}


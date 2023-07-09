using UnityEngine;

namespace Maze
{
    public abstract class Unit : MonoBehaviour
    {
        public Transform _transform;
        public Rigidbody _rigidbody;

        private float _speed = 7f;
        private int _health = 100;
        private bool _isDead;

        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                if (value <= 100 && value >= 0)
                {
                    _health = value;
                }
                else
                {
                    _health = 100;
                    Debug.Log("wrong health value");
                }
            }  
        }

        public float Speed { get => _speed; set => _speed = value; }
        public bool IsDead { get => _isDead; set => _isDead = value; }

        public virtual void Awake()
        {
            if (!TryGetComponent<Transform>(out _transform))
            {
                Debug.Log("No Transform component"); 
            }

            if (!TryGetComponent<Rigidbody>(out _rigidbody))
            {
                Debug.Log("No Rigidbody component");
            }
        }

        public abstract void Move(float x, float y, float z);
    }
}
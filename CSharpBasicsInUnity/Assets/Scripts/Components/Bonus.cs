using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Maze
{
    public abstract class Bonus : MonoBehaviour, IExecute
    {
        private bool _isInterctable;
        protected Color _color;
        private Renderer _renderer;
        private Collider _collider;
        public float _heightFly;

        public bool IsInterctable
        {
            get => _isInterctable;
            set
            {
                _isInterctable = value;
                _renderer.enabled = value;
                _collider.enabled = value;
            }
        }

        public virtual void Awake()
        {
            if (!TryGetComponent<Renderer>(out _renderer))
            {
                Debug.Log("No Renderer component");
            }

            if (!TryGetComponent<Collider>(out _collider))
            {
                Debug.Log("No Collider component");
            }

            IsInterctable = true;
            _color = Random.ColorHSV();
            _renderer.sharedMaterial.color = _color;
        }

        private void OnTriggerEnter(Collider other)
        {
           if (other.CompareTag("Player"))
            {
                Interaction();
            } 
        }

        protected abstract void Interaction();

        public abstract void Update(); 
        
    }
}
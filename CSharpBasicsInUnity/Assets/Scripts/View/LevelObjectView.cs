using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class LevelObjectView : MonoBehaviour
    {
        [SerializeField] private Transform _transform;
        [SerializeField] private Collider _collider;
        [SerializeField] private Renderer _renderer;

        public Transform _Transform { get => _transform; set => _transform = value; }
        public Collider _Collider { get => _collider; set => _collider = value; }
        public Renderer _Renderer { get => _renderer; set => _renderer = value; }

        //void Awake()
        //{
        //    if (!TryGetComponent<Transform>(out _Transform))
        //    {
        //        Debug.Log("No Transform component");
        //    }
        //    if (!TryGetComponent<Renderer>(out Renderer))
        //    {
        //        Debug.Log("No Renderer component");
        //    }

        //    if (!TryGetComponent<Collider>(out Collider))
        //    {
        //        Debug.Log("No Collider component");
        //    }
        //}

    }
}
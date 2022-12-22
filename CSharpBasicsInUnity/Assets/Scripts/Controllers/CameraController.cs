using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class CameraController : MonoBehaviour//, IExecute
    {
        public Unit _player;
        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - _player.transform.position;
        }
        private void LateUpdate()
        {
            transform.position = _player.transform.position + _offset;
        }

        //public void Execute()
        //{
        //    transform.position = _player.transform.position + _offset;
        //}
    }
}
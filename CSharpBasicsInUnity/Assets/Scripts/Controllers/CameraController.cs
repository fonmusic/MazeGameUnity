using UnityEngine;

namespace Maze
{
    public class CameraController :  IExecute
    {
        private Transform _player;
        private Transform _camera;
        private Vector3 _offset;

        public CameraController(Transform player, Transform mainCamera)
        {
            _player = player;
            _camera = mainCamera;
            _offset = _camera.position - _player.position;
            _camera.LookAt(_player);
        }


        public void Execute()
        {
            _camera.position = _player.position + _offset;
        }
    }
}
using UnityEngine;

namespace Maze
{
    public class InputController: IExecute
    {
        private readonly Unit _player;
        private float horizintal;
        private float vertical;

        public InputController(Unit player)
        {
            _player = player;
        }

        public void Update()
        {
            horizintal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            _player.Move(horizintal, 0, vertical);
        }
    }
}
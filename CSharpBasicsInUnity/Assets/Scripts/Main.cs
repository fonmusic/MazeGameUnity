using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        private InputController _inputController;

        private ListExecuteObjectController _executeObjectController;

        [SerializeField] private Unit _player;

        [SerializeField] private Bonus[] BonusObj;

        private void Awake()
        {
            _inputController = new InputController(_player);

            _executeObjectController = new ListExecuteObjectController(BonusObj);

            _executeObjectController.AddExecuteObject(_inputController);
        }

        private void Update()
        {
            for (int i = 0; i < _executeObjectController.Length; i++)
            {
                if (_executeObjectController.ExecuteObjects[i] == null)
                {
                    continue;
                }
                _executeObjectController.ExecuteObjects[i].Execute();
            }
        }
    }
}
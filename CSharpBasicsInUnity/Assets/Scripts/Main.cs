using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Maze
{
    public class Main : MonoBehaviour
    {
        IEnumerator executiveEnumerator;

        private InputController _inputController;
        private CameraController _cameraController;
        private ListExecuteObjectController _executeObjectController;
        private Reference _reference;
        private ViewBonus _viewBonus;
        private ViewEndGame _viewEndGame;

        private (string, int) _bounceCount;

        //private int _bounceCount;

        [SerializeField] private Unit _player;
        [SerializeField] private Bonus[] BonusObjects;
        [SerializeField] private BadBonus BadBonusObj;
        [SerializeField] private Button _restartButton;

        private void Awake()
        {
            Time.timeScale = 1f;


            _reference = new Reference();

            _viewBonus = new ViewBonus(_reference.BonusLabel);
            _viewEndGame = new ViewEndGame(_reference.EndGameLabel);
            _restartButton.onClick.AddListener(RestartGame);
            _restartButton.gameObject.SetActive(false);



            _inputController = new InputController(_player);
            _cameraController = new CameraController(_player.transform, Camera.main.transform);
            _executeObjectController = new ListExecuteObjectController(BonusObjects);

            _executeObjectController.AddExecuteObject(_inputController);
            _executeObjectController.AddExecuteObject(_cameraController);
            _executeObjectController.GetEnumerator();

            foreach (var item in _executeObjectController)
            {
                if (item is GoodBonus goodBonus)
                    goodBonus.AddPoints += AddBonus;
                if (item is BadBonus badBonus)
                {
                    badBonus.OnCaughtPlayer += _viewEndGame.GameOver;
                    badBonus.OnCaughtPlayer += CaughtPlayer;
                }
            }
        }


        private void RestartGame()
        {
            SceneManager.LoadScene(0);
        }

        private void AddBonus(string name, int value)
        {
            _bounceCount.Item1 = name; 
            _bounceCount.Item2 += value;
            _viewBonus.Display(_bounceCount.Item1, _bounceCount.Item2);
        }

        private void CaughtPlayer(string value, Color color)
        {
            _restartButton.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }

        private void Update()
        {

            for (int i = 0; i < _executeObjectController.Length; i++)
            {
                if (_executeObjectController[i] == null)
                {
                    continue;
                }
                _executeObjectController[i].Execute();
            }

        }
    }
}
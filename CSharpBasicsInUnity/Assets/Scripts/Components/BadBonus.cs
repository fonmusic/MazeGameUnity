using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Maze
{

    public class BadBonus : Bonus, IFly, IRotation
    {
        public event Action<string, Color> OnCaughtPlayer = delegate (string str, Color color) { };
        private float speedRotation;
        private LevelObjectView _levelObjectView;
        

        public BadBonus(LevelObjectView levelObjectView) : base(levelObjectView)
        {
            _levelObjectView = levelObjectView;
            Init();
        }

        public void Init()
        {
            _heightFly = UnityEngine.Random.Range(1.0f, 5.0f);
            speedRotation = UnityEngine.Random.Range(13f, 40f);
        }

        

        public override void Execute()
        {
            Fly();
            Rotate();
        }

        public void Fly()
        {
            _levelObjectView._Transform.position = new Vector3(_levelObjectView._Transform.position.x, Mathf.PingPong(Time.time, _heightFly), _levelObjectView._Transform.position.z);
        }

        public void Rotate()
        {
            _levelObjectView._Transform.Rotate(Vector3.up * (Time.deltaTime * speedRotation), Space.World);
        }

        protected override void Interaction()
        {
            OnCaughtPlayer?.Invoke(_levelObjectView.name, _color);
        }
    }
}
